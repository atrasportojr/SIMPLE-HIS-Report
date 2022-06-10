Public Class clsUsers


    Public Shared Function GetUser(ByVal sop As Integer, ByRef username As String, ByVal password As String, ByRef employeeid As Long) As DataTable
        Dim StrPar As String() = {"operation", "suboperation", "username", "password", "employeeid"}
        Dim StrVal As String() = {0, sop, username, password, employeeid}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring)
        Return s.SetParam(StrPar, StrVal, "spUsers", 0)
    End Function
End Class
