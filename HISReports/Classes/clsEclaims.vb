Public Class clsEclaims

    Public Shared Function getInfo(ByRef sOp As Integer, Optional ByRef search As String = "", Optional ByRef patientid As Long = 0, Optional ByRef isactive As Boolean = True) As DataTable
        Dim strPar() As String = {"operation", "soperation", "search", "patientid", "isactive"}
        Dim strVal() As String = {0, sOp, search, patientid, isactive}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spEclaims", 0)
    End Function
End Class
