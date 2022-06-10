Public Class clsReferral
    Public Shared Function generic(Optional ByVal hciid As Long = 0, Optional ByVal sop As Integer = 0) As DataTable
        Dim strPar() As String = {"operation", "soperation", "search", "isactive", "hciid"}
        Dim strVal() As Object = {0, sop, "", True, hciid}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spHCI", 0)
    End Function
End Class

