Public Class clsEmployees

    Public operation As Integer
    Public soperation As Integer
    'employee types
    Public employeetypeid As Long
    Public employeetypedescription As String
    Public reportseqno As Integer

    'employees
    Public employeeid As Long
    Public employeemasterid As Long
    Public employeeno As String
    Public lastname As String
    Public firstname As String
    Public middlename As String
    Public extensioname As String
    Public gender As String
    Public officecode As String
    Public permanentaddress As String
    Public religion As Long
    Public permanent_zipcode As String
    Public permanent_tel_no As String
    Public residential_address As String
    Public residential_zipcode As String
    Public residential_tel_no As String
    Public birthdate As Date
    Public birthplace As String
    Public mobileno As String
    Public email As String
    Public designation As String
    Public citizenship As Long
    Public notes As String
    Public monthly_salary As Double
    Public phic_accreditationno As String
    Public dailyvisitrate As Double
    Public proffee As Double
    Public ptr As String
    Public licenceno As String
    Public proftype As String
    Public specialization As String
    Public photo As Object
    Public sig_photo As Object
    Public issync As Boolean
    Public server_id As Long

    Public modcode As Integer
    Public canadd As Boolean
    Public canedit As Boolean
    Public candelete As Boolean
    Public canview As Boolean
    Public canapprove As Boolean
    Public caninspect As Boolean
    Public cancheck As Boolean
    Public canreceive As Boolean
    Public canissue As Boolean
    Public canverify As Boolean
    Public clinicid As Long
    Public username As String
    Public password As String
    Public isappsysadmin As Boolean

    Public memo As String
    Public isactive As Boolean
    Public isdefault As Boolean
    Public createdbyid As Long
    Public datecreated As DateTime
    Public updatedbyid As Long
    Public dateupdated As DateTime

    


    Public Shared Function GetEmployeeInfo(ByVal sop As Integer, ByVal search As String, Optional ByVal isactive As Integer = 1, Optional ByVal Employees As Boolean = True) As DataTable
        Dim StrPar As String() = {"operation", "soperation", "search", "isactive", "Employees"}
        Dim StrVal As String() = {0, sop, search, isactive, Employees}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(StrPar, StrVal, "spEmployees", 0)
    End Function
    Public Shared Function GetUsers(ByVal sop As Integer, ByVal search As String, Optional ByRef username As String = "", Optional ByRef password As String = "", Optional ByRef isactive As Integer = 1) As DataTable
        Dim StrPar As String() = {"operation", "soperation", "search", "username", "password", "isactive"}
        Dim StrVal As String() = {0, sop, search, username, password, isactive}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring)
        Return s.SetParam(StrPar, StrVal, "spEmployees", 0)
    End Function
    Public Function SaveEmployeeTypes() As Long
        Dim StrPar As String() = {"operation", "soperation", "employeetypeid", "employeetypedescription", "reportseqno", "isactive",
                                  "isdefault", "memo", "createdbyid", "datecreated", "updatedbyid", "dateupdated"}
        Dim StrVal As String() = {operation, 2, employeetypeid, employeetypedescription, reportseqno, isactive,
                                  isdefault, memo, createdbyid, datecreated, updatedbyid, dateupdated}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(StrPar, StrVal, "spEmployees", 2)
    End Function
    Public Function SaveEmployee(ByRef isnew As Boolean) As Long
        If isnew Then
            operation = 1
            soperation = 0
        Else
            operation = 2
            soperation = 0
        End If
        Dim StrPar As String() = {"operation", "soperation", "Oldemployeeid", "employeeid", "employeemasterid", "employeeno", "lastname", "firstname", "middlename", "extensioname", "gender",
                                  "permanentaddress", "religion", "permanent_address_zipcode", "address", "contactno",
                                  "residential_address", "zipcode", "telephone_no", "birthdate", "placeofbirth", "mobileno", "email",
                                  "designation", "citizenship", "notes", "officecode", "employeetypeid",
                                  "phicaccreditationno", "dailyvisitrate", "proffee", "ptr", "licenceno", "proftype",
                                  "specialization", "isactive", "photo",
                                  "createdbyid", "updatedbyid", "Employees", "isADoctor", "NewPK"}
        Dim StrVal As Object = {operation, soperation, employeeid, employeeid, employeemasterid, employeeno, lastname, firstname, middlename, extensioname, gender,
                                permanentaddress, religion, permanent_zipcode, residential_address, permanent_tel_no,
                                residential_address, residential_zipcode, residential_tel_no, birthdate, birthplace, mobileno, email,
                                  designation, citizenship, notes, officecode, employeetypeid,
                                  phic_accreditationno, dailyvisitrate, proffee, ptr, licenceno, proftype,
                                  specialization, isactive, photo,
                                  createdbyid, updatedbyid, 1, 1, operation}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(StrPar, StrVal, "spEmployees", 2)
    End Function
    Public Sub SavePrivileges(ByRef isnew As Boolean)
        If isnew Then
            operation = 1
        Else
            operation = 2
        End If
        Dim StrPar As String() = {"operation", "soperation", "Oldemployeeid", "employeeid", "username", "userpass", "usersign", "isappsysadmin",
                                  "modcode", "canadd", "canedit", "candelete", "canview", "canapprove", "caninspect", "cancheck", "canreceive",
                                  "canissue","canverify", "createdbyid", "updatedbyid", "Employees"}
        Dim StrVal As Object = {operation, soperation, employeeid, employeeid, username, password, Nothing, isappsysadmin,
                                modcode, canadd, canedit, candelete, canview, canapprove, caninspect, cancheck, canreceive,
                                canissue,canverify, createdbyid, updatedbyid, 1}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : s.SetParam(StrPar, StrVal, "spEmployees", 1)
    End Sub

    Public Sub deletePrivileges()
        Dim StrPar As String() = {"operation", "soperation", "Oldemployeeid"}
        Dim StrVal As Object() = {2, 4, employeeid}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : s.SetParam(StrPar, StrVal, "spEmployees", 1)
    End Sub
    
End Class
