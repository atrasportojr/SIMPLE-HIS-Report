Public Class clsIVFluidSheet

    Private operation As Integer
    Private soperation As Integer

    Public ivfluidid As Long
    Public admissionid As Long
    Public bottleno As String
    Public startedby As Long
    Public datestarted As Date
    Public ivtype As String
    Public drugadditives As String
    Public typeofcannula As String
    Public flowrate As String
    Public dateended As Date
    Public endedby As Long
    Public remarks As String

    Public issync As Boolean
    Public server_id As Long
    Public isdeleted As Boolean

    Public Shared Function genericcls(ByVal sop As Integer, ByVal search As Long, Optional ByVal filterby As Integer = 0) As DataTable
        Dim StrPar As String() = {"operation", "soperation", "search", "filterby"}
        Dim StrVal As String() = {0, sop, search, filterby}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(StrPar, StrVal, "spIVFluidSheet", 0)
    End Function
    Public Function Save(ByVal isnew As Boolean) As Long
        operation = 2
        If isnew Then
            operation = 1
        End If
        Dim StrPar As String() = {"operation", "soperation", "ivfluidid", "admissionid", "bottleno", "datestarted", "ivtype", "startedby", "drugadditives", "typeofcannula", "flowrate",
                                  "dateended", "endedby", "remarks", "issync", "server_id", "isdeleted", "NewPK"}
        Dim StrVal As String() = {operation, 0, ivfluidid, admissionid, bottleno, datestarted, ivtype, startedby, drugadditives, typeofcannula, flowrate,
                                  dateended, endedby, remarks, issync, server_id, isdeleted, operation}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(StrPar, StrVal, "spIVFluidSheet", 2)
    End Function
    Public Sub Remove()
        Dim StrPar As String() = {"operation", "soperation", "ivfluidid", "isdeleted", "issync"}
        Dim StrVal As String() = {2, 1, ivfluidid, isdeleted, issync}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : s.SetParam(StrPar, StrVal, "spIVFluidSheet", 1)
    End Sub
End Class
