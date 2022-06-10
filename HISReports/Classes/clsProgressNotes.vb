Public Class clsProgressNotes
    Private operation As Integer
    Private soperation As Integer

    Public progressnoteid As Long
    Public admissionid As Long
    Public progressdate As Date
    Public notes As String
    Public medicalorder As String
    Public carried As Boolean
    Public administered As Boolean
    Public requested As Boolean
    Public endorsed As Boolean
    Public discontinued As Boolean
    Public prescriptionid As Long
    Public testrequestid As Long
    Public createdbyid As Long

    Public issync As Boolean
    Public server_id As Long
    Public isdeleted As Boolean
    Public iscourseward As Boolean

    Public Shared Function GetNotes(ByVal sop As Integer, ByVal search As Long, Optional ByVal filterby As Integer = 0) As DataTable
        Dim StrPar As String() = {"operation", "soperation", "search", "filterby"}
        Dim StrVal As String() = {0, sop, search, filterby}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(StrPar, StrVal, "spProgressNotes", 0)
    End Function
    Public Function Save(ByVal isnew As Boolean) As Long
        operation = 2
        If isnew Then
            operation = 1
        End If
        Dim StrPar As String() = {"operation", "soperation", "progressnoteid", "admissionid", "progressdate", "notes", "medicalorder", "carried",
                                  "administered", "requested", "endorsed", "discontinued", "issync", "server_id", "isdeleted", "iscourseward",
                                  "prescriptionid", "testrequestid", "createdbyid", "NewPK"}
        Dim StrVal As String() = {operation, 0, progressnoteid, admissionid, progressdate, notes, medicalorder, carried,
                                  administered, requested, endorsed, discontinued, issync, server_id, isdeleted, iscourseward,
                                  prescriptionid, testrequestid, createdbyid, operation}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(StrPar, StrVal, "spProgressNotes", 2)
    End Function
    Public Sub RemoveNote()
        Dim StrPar As String() = {"operation", "soperation", "progressnoteid", "isdeleted", "issync"}
        Dim StrVal As String() = {2, 1, progressnoteid, isdeleted, issync}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : s.SetParam(StrPar, StrVal, "spProgressNotes", 1)
    End Sub

    Public Shared Function getReportData(ByVal admissionid As Long) As DataTable
        Dim dtRecord As New DataTable
        'Dim frm As New frmReportHandler
        Dim crpt As New crptProgressNotes_V2
        dtRecord = clsProgressNotes.GetNotes(0, admissionid)
        Dim lastindex As Integer = 0
        Dim lastdate As String = ""
        Dim lastrxid As Long = 0
        For Each row As DataRow In dtRecord.Rows
            Dim subheader As String = ""
            If Utility.NullToDefaultDateFormat(row.Item("progressdate")).ToString("yyyy-MM-dd") = lastdate Then
                dtRecord.Rows(lastindex).Item("datetimevalue") = Utility.NullToDefaultDateFormat(row.Item("progressdate")).ToString("hh:mm tt")
            Else
                dtRecord.Rows(lastindex).Item("newday") = "1"
                dtRecord.Rows(lastindex).Item("datetimevalue") = Utility.NullToDefaultDateFormat(row.Item("progressdate")).ToString("MM/dd/yyyy hh:mm tt")
            End If
            If Utility.NullToZero(row.Item("prescriptionid")) > 0 Then
                If lastrxid <> row.Item("prescriptionid") Then
                    dtRecord.Rows(lastindex).Item("displaytype") = "2"
                Else
                    dtRecord.Rows(lastindex).Item("datetimevalue") = ""
                    dtRecord.Rows(lastindex).Item("displaytype") = "4"
                End If
                lastrxid = row.Item("prescriptionid")
            ElseIf Utility.NullToZero(row.Item("testrequestid")) > 0 Then
                If lastrxid <> row.Item("testrequestid") Then
                    dtRecord.Rows(lastindex).Item("displaytype") = "3"
                Else
                    dtRecord.Rows(lastindex).Item("datetimevalue") = ""
                    dtRecord.Rows(lastindex).Item("displaytype") = "4"
                End If
                lastrxid = row.Item("testrequestid")
            End If
            dtRecord.Rows(lastindex).Item("medicalorder") = subheader & Utility.NullToEmptyString(row.Item("medicalorder"))
            lastdate = Utility.NullToDefaultDateFormat(row.Item("progressdate")).ToString("yyyy-MM-dd")
            lastindex = lastindex + 1
        Next
        Return dtRecord
    End Function
End Class
