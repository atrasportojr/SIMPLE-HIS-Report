Public Class clsReasonForRefferal
    Public Oldreasonreferralno As Integer
    Public description As String
    Public memo As String
    Public isactive As Boolean
    Public isrhu As Boolean
    Public createdbyid As Long
    Public updatedbyid As Long
    Public hciid As Long
    Public datecreated As Date
    Public dateupdated As Date
    Public hcicode As String
    Public hciname As String
    Public bldgnonamestreet As String
    Public barangay As String
    Public citymunicipality As String
    Public province As String
    Public zipcode As String

    Public Shared Function genericcls(ByVal sop As Integer, Optional ByVal search As String = "", Optional ByVal isactive As Boolean = True) As DataTable
        Dim strPar() As String = {"operation", "soperation", "search", "IsActive"}
        Dim strVal() As String = {0, sop, search, isactive}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spReasonForRefferal", 0)
    End Function

    Public Function saveReferralReason(ByVal soperation As Integer, ByVal sNew As Boolean) As Long
        Dim operation As Integer = 2
        If sNew Then
            operation = 1
        End If
        Dim strPar() As String = {"Operation", "sOperation", "Oldreasonreferralno", "description", "isActive", "memo", "createdbyid", "updatedbyid", "NewPK"}
        Dim strVar() As Object = {operation, soperation, Oldreasonreferralno, description, isactive, memo, createdbyid, updatedbyid, 1}
        'Dim s As New sqlbridge(gconnectionstring) : Return s.ReturnNewPK("spEclaims", strPar, strVar)
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVar, "spReasonForRefferal", 2)
    End Function
End Class
