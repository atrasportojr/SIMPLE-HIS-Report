Public Class clsReportDashboard
    Public Shared Function genericcls(ByVal sop As Integer, Optional ByVal search As String = "", Optional ByVal filterby As Integer = 0, Optional ByVal employeeid As Long = 0) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "search", "filterby", "employeeid"}
        Dim strVal() As String = {0, sop, search, filterby, employeeid}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spReportDashboard", 0)
    End Function
    Public Shared Function genericcls(ByVal sop As Integer, ByVal search As String, ByVal datestart As Date, ByVal dateend As Date) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "search", "datestart", "dateend"}
        Dim strVal() As String = {0, sop, search, datestart, dateend}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spReportDashboard", 0)
    End Function


    Public Shared Function getHISReports(ByVal sop As Integer, Optional ByVal search As String = "", Optional ByVal isactive As Boolean = True) As DataTable
        Dim strPar() As String = {"operation", "soperation", "search", "isActive"}
        Dim strVal() As String = {0, sop, search, isactive}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spHISReports", 0)
    End Function
    Public Shared Function getReport(ByVal sop As Integer, Optional ByVal search As String = "", Optional ByVal admissionid As Long = 0) As DataTable
        Dim strPar() As String = {"operation", "soperation", "search", "admissionid"}
        Dim strVal() As String = {0, sop, search, admissionid}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spHISReports", 0)
    End Function
End Class
