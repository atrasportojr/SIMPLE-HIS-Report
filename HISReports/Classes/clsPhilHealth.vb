Public Class clsPhilHealth
#Region "Variables"
    Public operation As Integer
    Private mPhilhealthNo As String
    Private mPhilLastName As String
    Private mPhilFirstName As String
    Private mPhilMiddleName As String
    Private mPhilSuffix As String
    Private mPhilMembershipCatCode As Integer
    Private mPhilAvailmentType As Char
    Private mPhilHouseNo As String
    Private mPhilBarangay As String
    Private mPhilCityMunicipality As String
    Private mPhilProvince As String
    Private mPhilZipCode As String
    Private mPhilDateofBirth As DateTime
    Private mPhilEmailAdd As String
    Private mPhilMobileNo As String
    Private mPhilLandLineNo As String
    Private mPhilEmpNo As String
    Private mPhilEmpContactNo As String
    Private mPhilEmpBusName As String
    Private mPhilEmpBldgNo As String
    Private mPhilEmpCityMunicipality As String
    Private mPhilEmpProvince As String
    Private mPhilEmpZipCode As String
    Private mAvailmentType As Char
    Public gender As Char
    Public unitroomnofloor As String
    Public buildingname As String
    Public lotblockhousebldngno As String
    Public country As String
    Public relationshiptomember As String
#End Region

#Region "Properties"
    Public Property PhilHealthNo() As String
        Get
            Return mPhilhealthNo
        End Get
        Set(ByVal value As String)
            mPhilhealthNo = value
        End Set
    End Property
    Public Property PhilLastName() As String
        Get
            Return mPhilLastName
        End Get
        Set(ByVal value As String)
            mPhilLastName = value
        End Set
    End Property
    Public Property PhilFirstName() As String
        Get
            Return mPhilFirstName
        End Get
        Set(ByVal value As String)
            mPhilFirstName = value
        End Set
    End Property
    Public Property PhilMiddleName() As String
        Get
            Return mPhilMiddleName
        End Get
        Set(ByVal value As String)
            mPhilMiddleName = value
        End Set
    End Property
    Public Property PhilSuffix() As String
        Get
            Return mPhilSuffix
        End Get
        Set(ByVal value As String)
            mPhilSuffix = value
        End Set
    End Property
    Public Property PhilMembershipCatCode() As Integer
        Get
            Return mPhilMembershipCatCode
        End Get
        Set(ByVal value As Integer)
            mPhilMembershipCatCode = value
        End Set
    End Property
    Public Property PhilAvailmentType() As Char
        Get
            Return mPhilAvailmentType
        End Get
        Set(ByVal value As Char)
            mPhilAvailmentType = value
        End Set
    End Property
    Public Property PhilHouseNo() As String
        Get
            Return mPhilHouseNo
        End Get
        Set(ByVal value As String)
            mPhilHouseNo = value
        End Set
    End Property
    Public Property PhilBarangay() As String
        Get
            Return mPhilBarangay
        End Get
        Set(ByVal value As String)
            mPhilBarangay = value
        End Set
    End Property
    Public Property PhilCityMunicipality() As String
        Get
            Return mPhilCityMunicipality
        End Get
        Set(ByVal value As String)
            mPhilCityMunicipality = value
        End Set
    End Property
    Public Property PhilProvince() As String
        Get
            Return mPhilProvince
        End Get
        Set(ByVal value As String)
            mPhilProvince = value
        End Set
    End Property
    Public Property PhilZipCode() As String
        Get
            Return mPhilZipCode
        End Get
        Set(ByVal value As String)
            mPhilZipCode = value
        End Set
    End Property
    Public Property PhilDateofBirth() As DateTime
        Get
            Return mPhilDateofBirth
        End Get
        Set(ByVal value As DateTime)
            mPhilDateofBirth = value
        End Set
    End Property
    Public Property PhilEmailAdd() As String
        Get
            Return mPhilEmailAdd
        End Get
        Set(ByVal value As String)
            mPhilEmailAdd = value
        End Set
    End Property
    Public Property PhilMobileNo() As String
        Get
            Return mPhilMobileNo
        End Get
        Set(ByVal value As String)
            mPhilMobileNo = value
        End Set
    End Property
    Public Property PhilLandLineNo() As String
        Get
            Return mPhilLandLineNo
        End Get
        Set(ByVal value As String)
            mPhilLandLineNo = value
        End Set
    End Property
    Public Property PhilEmpNo() As String
        Get
            Return mPhilEmpNo
        End Get
        Set(ByVal value As String)
            mPhilEmpNo = value
        End Set
    End Property
    Public Property PhilEmpContactNo() As String
        Get
            Return mPhilEmpContactNo
        End Get
        Set(ByVal value As String)
            mPhilEmpContactNo = value
        End Set
    End Property
    Public Property PhilEmpBusName() As String
        Get
            Return mPhilEmpBusName
        End Get
        Set(ByVal value As String)
            mPhilEmpBusName = value
        End Set
    End Property
    Public Property PhilEmpBldgNo() As String
        Get
            Return mPhilEmpBldgNo
        End Get
        Set(ByVal value As String)
            mPhilEmpBldgNo = value
        End Set
    End Property
    Public Property PhilEmpCityMunicipality() As String
        Get
            Return mPhilEmpCityMunicipality
        End Get
        Set(ByVal value As String)
            mPhilEmpCityMunicipality = value
        End Set
    End Property
    Public Property PhilEmpProvince() As String
        Get
            Return mPhilEmpProvince
        End Get
        Set(ByVal value As String)
            mPhilEmpProvince = value
        End Set
    End Property
    Public Property PhilEmpZipCode() As String
        Get
            Return mPhilEmpZipCode
        End Get
        Set(ByVal value As String)
            mPhilEmpZipCode = value
        End Set
    End Property
   
#End Region

#Region "Methods"
    Public Shared Function genericcls(ByVal vsOP As Integer, Optional ByVal mSearch As String = "", Optional ByVal patid As Long = 0) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "Search", "Patientid"}
        Dim strVal() As String = {0, vsOP, mSearch, patid}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spPhilHealth", 0)
    End Function
    Public Shared Function getPhilHealthRecords(Optional ByVal mSearch As String = "") As DataTable
        Dim strPar() As String = {"operation", "sOperation", "Search"}
        Dim strVal() As String = {0, 0, mSearch}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spPhilHealth", 0)
    End Function
    Public Shared Function LoadPHIC(ByVal mPhilHealthNo As String) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "PhilHealthNo"}
        Dim strVal() As String = {0, 1, mPhilHealthNo}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spPhilHealth", 0)
    End Function
    Public Function IsExist(ByVal mPhilHealthNo As String) As Boolean
        Dim dt As New DataTable
        Dim par() As String = {"operation", "sOperation", "philhealthno"}
        Dim parVal() As String = {0, 2, mPhilHealthNo}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring)
        dt = s.SetParam(par, parVal, "spPhilHealth", 0)
        Return CBool(dt.Rows(0).Item("isExist").ToString)
    End Function
    Public Shared Function isPhilMemberNoExist(ByVal sOperation As Integer, ByVal dbLastName As String, ByVal dbFirstName As String, ByVal dbMI As String, Optional ByVal dbPhilHealthNo As String = "", Optional ByVal EPhilhealthno As String = "", Optional ByVal mlastname As String = "", Optional ByVal mfirstname As String = "", Optional ByVal mMi As String = "") As DataTable
        Dim par() As String = {"operation", "sOperation", "dbPhilHealthlastname", "dbPhilHealthfirstname", "dbPhilHealthmiddlename", "Philhealthno", "ePhilhealthno", "PhilHealthlastname", "PhilHealthfirstname", "PhilHealthmiddlename"}
        Dim parVal() As String = {0, sOperation, dbLastName, dbFirstName, dbMI, dbPhilHealthNo, EPhilhealthno, mlastname, mfirstname, mMi}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(par, parVal, "spPhilHealth", 0)
    End Function

    Public Function Save(ByVal isNew As Boolean, Optional ByVal mPhilHealthNo As String = "") As Long

        If isNew Then
            operation = 1
        Else
            operation = 2
        End If
        Dim strPar() As String = {"Operation", "Philhealthno", "PhilHealthlastname", "PhilHealthfirstname", "PhilHealthmiddlename", "PhilHealthsuffixname", "PhilHealthmembershipcategorycode", "PhilHealthavailmenttype", "PhilHealthhousenonamestreet", "PhilHealthbarangay", _
                                  "PhilHealthcitymunicipality", "PhilHealthprovince", "PhilHealthzipcode", "PhilHealthdateofbirth", "PhilHealthemailaddress", "PhilHealthmobileno", "PhilHealthlandlineno", "PhilHealthphilhealthemployeeno", "PhilHealthemplyrcontactno", _
                                  "PhilHealthemplyrbusinessname", "PhilHealthemplyrbuildingnonamestreet", "PhilHealthemplyrcitymunicipality", "PhilHealthemplyrprovince", "PhilHealthemplyrzipcode", "oldPhilHealthNo", "gender", _
                                   "unitroomnofloor", "buildingname", "lotblockhousebldngno", "country", "relationshiptomember"}
        Dim strVar() As String = {operation, PhilHealthNo, PhilLastName, PhilFirstName, PhilMiddleName, PhilSuffix, PhilMembershipCatCode, PhilAvailmentType, PhilHouseNo, PhilBarangay, _
                                  PhilCityMunicipality, PhilProvince, PhilZipCode, PhilDateofBirth, PhilEmailAdd, PhilMobileNo, PhilLandLineNo, PhilEmpNo, PhilEmpContactNo, _
                                  PhilEmpBusName, PhilEmpBldgNo, PhilEmpCityMunicipality, PhilEmpProvince, PhilEmpZipCode, mPhilHealthNo, gender, _
                                  unitroomnofloor, buildingname, lotblockhousebldngno, country, relationshiptomember}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVar, "spPhilHealth", 1)
    End Function
    Public Function UpdateAdmission(ByVal admissionid As Long) As Long

        Dim strPar() As String = {"Operation", "philhealthno", "admissionid"}
        Dim strVar() As String = {3, PhilHealthNo, admissionid}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVar, "spPhilHealth", 1)
    End Function
#End Region
End Class
