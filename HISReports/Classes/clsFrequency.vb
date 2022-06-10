Public Class clsFrequency
#Region "Variables"

    Public operation As Integer

    Public frequencyid As Long
    Public frequencyname As String
    Public description As String
    Public per As Integer
    Public days As Integer
    Public isactive As Boolean

    Public createdbyid, updatedbyid As Long
#End Region
    Public Shared Function getInfo(ByRef sop As Integer, ByRef search As String, Optional ByRef isactive As Boolean = True) As DataTable
        Dim StrPar As String() = {"operation", "soperation", "search", "isactive"}
        Dim StrVal As String() = {0, sop, search, isactive}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring)
        Return s.SetParam(StrPar, StrVal, "spFrequency", 0)
    End Function

    Public Function saveFrequency(ByVal isNew As Boolean) As Long
        operation = 2
        If isNew = True Then
            operation = 1
        End If
        Dim strPar() As String = {"Operation", "sOperation", "frequencyid", "frequencyname", "description", "per", "days", "isactive",
                                  "createdbyid", "updatedbyid", "NewPK"}
        Dim strVar() As String = {operation, 0, frequencyid, frequencyname, description, per, days, isactive,
                                  createdbyid, updatedbyid, operation}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVar, "spFrequency", 2)
    End Function
End Class
