Public Class clsHCI
    Public operation As Integer

    Public description, memo As String
    Public isactive, isrhu As Boolean
    Public createdbyid, updatedbyid, hciid As Long
    Public hcicode, hciname, bldgnonamestreet, barangay, citymunicipality, province, zipcode As String

    Public Shared Function getHCI(ByVal sop As Integer, ByRef search As String, Optional ByVal isactive As Boolean = True) As DataTable
        Dim strPar() As String = {"operation", "soperation", "search", "isactive"}
        Dim strVal() As String = {0, sop, search, isactive}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spHCI", 0)
    End Function
    Public Function saveHealthCareInstitution(ByVal isNew As Boolean) As Long
        operation = 2
        If isNew = True Then
            operation = 1
        End If

        Dim strPar() As String = {"Operation", "sOperation", "hciid", "hcicode", "hciname", "bldgnonamestreet", "barangay", "citymunicipality",
                                  "province", "zipcode", "memo", "isactive", "createdbyid", "updatedbyid", "NewPK"}
        Dim strVar() As String = {operation, 0, hciid, hcicode, hciname, bldgnonamestreet, barangay, citymunicipality,
                                  province, zipcode, memo, isactive, modGlobal.employeeid, modGlobal.employeeid, operation}
        'Dim s As New sqlbridge(gconnectionstring) : Return s.ReturnNewPK("spAdmissionDetails", strPar, strVar)
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVar, "spHCI", 2)
    End Function
End Class
