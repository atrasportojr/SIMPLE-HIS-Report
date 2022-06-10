Public Class clsNursingNotes
    Private operation As Integer
    Private soperation As Integer

    Public nursenotesid As Long
    Public admissionid As Long
    Public nurseid As Long
    Public dateofnote As Date
    Public focus As String
    Public data As String
    Public action As String
    Public response As String

    Public issync As Boolean
    Public server_id As Long
    Public isdeleted As Boolean

    Public Shared Function GetNotes(ByVal sop As Integer, ByVal search As Long) As DataTable
        Dim StrPar As String() = {"operation", "soperation", "search"}
        Dim StrVal As String() = {0, sop, search}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(StrPar, StrVal, "spNursingNotes", 0)
    End Function
    Public Function Save(ByVal isnew As Boolean) As Long
        operation = 2
        If isnew Then
            operation = 1
        End If
        Dim StrPar As String() = {"operation", "soperation", "nursenotesid", "admissionid", "nurseid", "dateofnote",
                                  "focus", "data", "action", "response", "issync", "server_id", "isdeleted", "NewPK"}
        Dim StrVal As String() = {operation, 0, nursenotesid, admissionid, nurseid, dateofnote,
                                  focus, data, action, response, issync, server_id, isdeleted, operation}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(StrPar, StrVal, "spNursingNotes", 2)
    End Function
    Public Sub RemoveNote()
        Dim StrPar As String() = {"operation", "soperation", "nursenotesid", "isdeleted", "issync"}
        Dim StrVal As String() = {2, 1, nursenotesid, isdeleted, issync}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : s.SetParam(StrPar, StrVal, "spNursingNotes", 1)
    End Sub

    Public Shared Function getReportData(ByVal admissionid As Long) As DataTable
        Dim dtRecord As New DataTable
        dtRecord = clsNursingNotes.GetNotes(0, admissionid)
        Dim lastindex As Integer = 0
        Dim lastdate As String = ""
        Dim lastnurseid As Long = 0
        For Each row As DataRow In dtRecord.Rows
            Dim subheader As String = ""
            If Utility.NullToDefaultDateFormat(row.Item("dateofnote")).ToString("yyyy-MM-dd") = lastdate Then
                dtRecord.Rows(lastindex).Item("datetimevalue") = Utility.NullToDefaultDateFormat(row.Item("dateofnote")).ToString("hh:mm tt")
            Else
                dtRecord.Rows(lastindex).Item("newday") = "1"
                dtRecord.Rows(lastindex).Item("datetimevalue") = Utility.NullToDefaultDateFormat(row.Item("dateofnote")).ToString("MM/dd/yyyy hh:mm tt")
                If Utility.NullToZero(row.Item("nurseid")) > 0 And lastindex > 0 Then
                        dtRecord.Rows(lastindex - 1).Item("newnurse") = "1"
                End If
            End If
            If Utility.NullToZero(row.Item("nurseid")) > 0 And Utility.NullToZero(row.Item("nurseid")) <> lastnurseid Then
                If lastindex > 0 Then
                    dtRecord.Rows(lastindex - 1).Item("newnurse") = "1"
                ElseIf lastindex = 0 And dtRecord.Rows.Count = 1 Then
                    dtRecord.Rows(lastindex).Item("newnurse") = "1"
                End If
            End If
            If lastindex = dtRecord.Rows.Count - 1 Then
                dtRecord.Rows(lastindex).Item("newnurse") = "1"
            End If
            lastdate = Utility.NullToDefaultDateFormat(row.Item("dateofnote")).ToString("yyyy-MM-dd")
            lastnurseid = Utility.NullToZero(row.Item("nurseid"))
            lastindex = lastindex + 1
        Next
        Return dtRecord
    End Function
End Class
