Public Class clsHISReports
    Public operation As Integer
    Public soperation As Integer
    Public storedProc As String
    Public subreportcode As Integer

    'Public employeeid As Long
    'Public admissiontype As String
    'Public filterby As Integer
    'Public startdate As Date
    'Public enddate As Date
    'Public patientid As Long
    'Public icd10code As String
    'Public admissionid As Long
    'Public purpose As String

    Public mainStrPar As New List(Of String)
    Public mainStrVal As New List(Of String)

    Public Shared Function getSOAP(ByVal sop As Integer, Optional ByVal search As String = "") As DataTable
        Dim strPar() As String = {"operation", "soperation", "search"}
        Dim strVal() As String = {0, sop, search}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spDashboard", 0)
    End Function

    Public Shared Function genericcls(ByVal sop As Integer, Optional ByVal search As String = "", Optional ByVal isactive As Boolean = True,
                                      Optional ByVal userid As Integer = 0) As DataTable
        Dim strPar() As String = {"operation", "soperation", "search", "isActive", "employeeid"}
        Dim strVal() As String = {0, sop, search, isactive, userid}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spHISReports", 0)
    End Function


    Public Shared Function getOffices(ByVal sop As Integer, ByVal search As String) As DataTable
        Dim strPar() As String = {"operation", "soperation", "search", "IsActiveOffice"}
        Dim strVal() As String = {0, sop, search, True}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spOffices", 0)
    End Function
    Public Shared Function getLotNo(ByVal itemcode As String, ByVal officecode As String) As DataTable
        Dim strPar() As String = {"operation", "soperation", "itemcode", "officecode"}
        Dim strVal() As String = {1, 0, itemcode, officecode}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spInventoryPrinting_V2", 0)
    End Function
    Public Shared Function getItemCategory(ByVal search As String) As DataTable
        Dim strPar() As String = {"operation", "soperation", "search"}
        Dim strVal() As String = {0, 4, search}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spItemCategory", 0)
    End Function

    'Public Function getReport() As DataTable
    '    Dim strPar() As String = {"operation", "soperation", "employeeid", "admissiontype", "filterby", "startdate",
    '                              "enddate", "icd10code", "PatientID", "admissionid", "remarks"}
    '    Dim strVal() As String = {operation, soperation, employeeid, admissiontype, filterby, startdate,
    '                              enddate, icd10code, patientid, admissionid, purpose}
    '    Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spHISReports", 0)
    'End Function

    Public Function getReport() As DataTable
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring)
        Return s.SetParam(mainStrPar.ToArray, mainStrVal.ToArray, Me.storedProc, 0)
    End Function
End Class
