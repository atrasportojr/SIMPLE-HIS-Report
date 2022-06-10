Public Class clsPatient

#Region " Code History "
    'Author:    STI
    'Created:   16 April 2010
    'About:
    'A customer is the owner of one or more boats.
    'The customer class only exists on the “one” end of the relationship between customer 
    'and boat.
    'To find which Boats belong to this Customer use Boat.GetAllBoatsForCustomer(CustID)
    '******************************************************************************
    'Modified By:   x
    'Modified On:   dd/mm/yyyy
    'Changes:
    '* Change 1
    '* Change 2
    '******************************************************************************
    'Modified By:   x
    'Modified On:   dd/mm/yyyy
    'Changes:
    '* Change 1
    '* Change 2
    '******************************************************************************
#End Region

#Region " Properties "
    Dim operation As Integer
    Private mCustID As Integer  'primary key
    Private mPatientID As Long
    Private mHospitalNo As String
    Private mBloodType As String
    Private mOscaIDNo As String
    Private mMothersName As String
    Private mFathersName As String
    Private mNewBornBaby As Boolean
    Private mFirstName As String
    Private mLastName As String
    Private mMiddleName As String
    Private mSuffix As String
    Private mBirthDate As DateTime
    Private mBirthPlace As String
    Private mReligion As String
    Private mNationality As String
    Private mGSISNo As String
    Private mSSSNo As String
    Private mOccupation As String
    Private mFather As String
    Private mMother As String
    Private mPhilHealthNo As String
    Private mGender As String
    Private mCivilStatus As String
    Private mHomeAddress As String
    Private mCompanyName As String
    Private mBusinessAddress As String
    Private mMobileNo As String
    Private mEmailAddress As String
    Private mTelephoneNo As String
    Private mPhoto As Object
    Private mDateRegistered As DateTime
    Private mRegisteredBy As Integer
    Private misActive As Boolean
    Private mAge As Integer
    Private mHouseNoStreet As String
    Private mbarangay As String
    Private mmunicipality As Integer
    Private mprovince As Integer
    Private mregion As Integer
    Private missync As Boolean
    Private mserverid As Long
    Public isphilhealthmember As Boolean
    Public relationshiptomember As String

    Public Property PatientID() As Long
        Get
            Return mPatientID
        End Get
        Set(ByVal Value As Long)
            mPatientID = Value
        End Set
    End Property
    Public Property PhilHealthNo() As String
        Get
            Return mPhilHealthNo
        End Get
        Set(ByVal Value As String)
            mPhilHealthNo = Value
        End Set
    End Property
    Public Property CustomerID() As Integer
        Get
            Return mCustID
        End Get
        Set(ByVal Value As Integer)
            mCustID = Value
        End Set
    End Property
    Public Property FName() As String
        Get
            Return mFirstName
        End Get
        Set(ByVal Value As String)
            mFirstName = Value
        End Set
    End Property
    Public Property LName() As String
        Get
            Return mLastName
        End Get
        Set(ByVal Value As String)
            mLastName = Value
        End Set
    End Property
    Public Property Suffix() As String
        Get
            Return mSuffix
        End Get
        Set(ByVal Value As String)
            mSuffix = Value
        End Set
    End Property
    Public Property MName() As String
        Get
            Return mMiddleName
        End Get
        Set(ByVal Value As String)
            mMiddleName = Value
        End Set
    End Property
    Public Property BirthDate() As DateTime
        Get
            Return mBirthDate
        End Get
        Set(ByVal Value As DateTime)
            mBirthDate = Value
        End Set
    End Property
    Public Property CompanyName() As String
        Get
            Return mCompanyName
        End Get
        Set(ByVal Value As String)
            mCompanyName = Value
        End Set
    End Property
    Public Property BusinessAddress() As String
        Get
            Return mBusinessAddress
        End Get
        Set(ByVal Value As String)
            mBusinessAddress = Value
        End Set
    End Property
    Public Property BirthPlace() As String
        Get
            Return mBirthPlace
        End Get
        Set(ByVal Value As String)
            mBirthPlace = Value
        End Set
    End Property
    Public Property MobileNo() As String
        Get
            Return mMobileNo
        End Get
        Set(ByVal Value As String)
            mMobileNo = Value
        End Set
    End Property
    Public Property Address() As String
        Get
            Return mHomeAddress
        End Get
        Set(ByVal Value As String)
            mHomeAddress = Value
        End Set
    End Property
    Public Property TelephoneNo() As String
        Get
            Return mTelephoneNo
        End Get
        Set(ByVal Value As String)
            mTelephoneNo = Value
        End Set
    End Property
    Public Property Gender() As String
        Get
            Return mGender
        End Get
        Set(ByVal Value As String)
            mGender = Value
        End Set
    End Property
    Public Property isActive() As Boolean
        Get
            Return misActive
        End Get
        Set(ByVal Value As Boolean)
            misActive = Value
        End Set
    End Property
    Public Property CivilStatus() As String
        Get
            Return mCivilStatus
        End Get
        Set(ByVal value As String)
            mCivilStatus = value
        End Set
    End Property
    Public Property HospitalNo() As String
        Get
            Return mHospitalNo
        End Get
        Set(ByVal value As String)
            mHospitalNo = value
        End Set
    End Property
    Public Property BloodType() As String
        Get
            Return mBloodType
        End Get
        Set(ByVal value As String)
            mBloodType = value
        End Set
    End Property
    Public Property OscaIDNo() As String
        Get
            Return mOscaIDNo
        End Get
        Set(ByVal value As String)
            mOscaIDNo = value
        End Set
    End Property
    Public Property MothersName() As String
        Get
            Return mMothersName
        End Get
        Set(ByVal value As String)
            mMothersName = value
        End Set
    End Property
    Public Property FathersName() As String
        Get
            Return mFathersName
        End Get
        Set(ByVal value As String)
            mFathersName = value
        End Set
    End Property
    Public Property NewBornBaby() As Boolean
        Get
            Return mNewBornBaby
        End Get
        Set(ByVal value As Boolean)
            mNewBornBaby = value
        End Set
    End Property
    Public Property Religion() As String
        Get
            Return mReligion
        End Get
        Set(ByVal value As String)
            mReligion = value
        End Set
    End Property
    Public Property Nationality() As String
        Get
            Return mNationality
        End Get
        Set(ByVal value As String)
            mNationality = value
        End Set
    End Property
    Public Property GSISNo() As String
        Get
            Return mGSISNo
        End Get
        Set(ByVal value As String)
            mGSISNo = value
        End Set
    End Property
    Public Property SSSNo() As String
        Get
            Return mSSSNo
        End Get
        Set(ByVal value As String)
            mSSSNo = value
        End Set
    End Property
    Public Property Occupation() As String
        Get
            Return mOccupation
        End Get
        Set(ByVal value As String)
            mOccupation = value
        End Set
    End Property
    Public Property Father() As String
        Get
            Return mFather
        End Get
        Set(ByVal value As String)
            mFather = value
        End Set
    End Property
    Public Property Mother() As String
        Get
            Return mMother
        End Get
        Set(ByVal value As String)
            mMother = value
        End Set
    End Property
    Public Property EmailAddress() As String
        Get
            Return mEmailAddress
        End Get
        Set(ByVal value As String)
            mEmailAddress = value
        End Set
    End Property
    Public Property Photo() As Object
        Get
            Return mPhoto
        End Get
        Set(ByVal value As Object)
            mPhoto = value
        End Set
    End Property
    Public Property DateRegistered() As DateTime
        Get
            Return mDateRegistered
        End Get
        Set(ByVal value As DateTime)
            mDateRegistered = value
        End Set
    End Property
    Public Property RegisteredBy() As Integer
        Get
            Return mRegisteredBy
        End Get
        Set(ByVal value As Integer)
            mRegisteredBy = value
        End Set
    End Property
    Public Property Age() As Integer
        Get
            Return mAge
        End Get
        Set(ByVal value As Integer)
            mAge = value
        End Set
    End Property
    Public Property HouseNoStreet() As String
        Get
            Return mHouseNoStreet
        End Get
        Set(ByVal value As String)
            mHouseNoStreet = value
        End Set
    End Property
    Public Property Barangay() As String
        Get
            Return mbarangay
        End Get
        Set(ByVal value As String)
            mbarangay = value
        End Set
    End Property
    Public Property Municipality() As Integer
        Get
            Return mmunicipality
        End Get
        Set(ByVal value As Integer)
            mmunicipality = value
        End Set
    End Property
    Public Property Province() As Integer
        Get
            Return mprovince
        End Get
        Set(ByVal value As Integer)
            mprovince = value
        End Set
    End Property
    Public Property Region() As Integer
        Get
            Return mregion
        End Get
        Set(ByVal value As Integer)
            mregion = value
        End Set
    End Property
    Public Property Issync() As Boolean
        Get
            Return missync
        End Get
        Set(ByVal value As Boolean)
            missync = value
        End Set
    End Property
    Public Property ServeId() As Long
        Get
            Return mserverid
        End Get
        Set(ByVal value As Long)
            mserverid = value
        End Set
    End Property
#End Region

#Region "Methods"
    Public Shared Function getgeneric(ByRef sop As Integer, ByRef search As String) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "search"}
        Dim strVal() As String = {0, sop, search}
        'Dim x As New Public_Modules : Return x.CUSTOM_RETRIEVE("SP_DoctorPatient", strPar, strVal)
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spPatient", 0)
    End Function
    Public Shared Function genericcls(ByVal sop As Integer, Optional ByVal hospno As String = "", Optional ByVal philhealthno As String = "") As DataTable
        Dim strPar() As String = {"operation", "sOperation", "search", "dbisphilhealthmember"}
        Dim strVal() As String = {0, sop, hospno, philhealthno}
        'Dim s As New Public_Modules : Return s.CUSTOM_RETRIEVE("spPatient", strPar, strVal)
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spPatient", 0)
    End Function
    Public Shared Function genericcls1(ByVal sop As Integer, Optional ByVal search As String = "", Optional ByVal isactive As String = "") As DataTable
        Dim strPar() As String = {"operation", "sOperation", "search", "isactive"}
        Dim strVal() As String = {0, sop, search, isactive}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spAutoCreateReligiousPatient", 0)
    End Function
    Public Shared Function genericcls2(ByVal sop As Integer, Optional ByVal hospno As String = "") As DataTable
        Dim strPar() As String = {"operation", "sOperation", "search"}
        Dim strVal() As String = {0, sop, hospno}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spAutoCreateReligiousPatient", 0)
    End Function
    Public Shared Function PatientInfor(ByVal vpatientid As Long) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "PatientID"}
        Dim strVal() As String = {0, 0, vpatientid}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spPatient", 0)
    End Function
    Public Shared Function getAdmissions(ByVal vsearch As String) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "search"}
        Dim strVal() As String = {0, 13, vsearch}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spPatient", 0)
    End Function
    Public Shared Function getPatInfo(Optional ByVal vHospNo As String = "", Optional ByRef vPatID As Long = 0) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "hospitalno", "PatientID"}
        Dim strVal() As String = {0, 1, vHospNo, vPatID}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spPatient", 0)
    End Function
    'Public Shared Function getPatID() As DataTable
    '    Dim strPar() As String = {"operation", "sOperation"}
    '    Dim strVal() As String = {0, 1}
    '    Dim s As New simpleadapter.SimpleAdapter(gconnectionstring): Return s.setparam(strPar, strVal, "sp_Patient_Save", 0)
    'End Function
    Public Shared Function getAllPatientName() As DataTable
        Dim strPar() As String = {"operation", "sOperation"}
        Dim strVal() As String = {0, 7}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spPatient", 0)
    End Function
    Public Shared Function getPatientInfo(ByVal admissionid As Long) As DataTable
        Dim strPar() As String = {"operation", "searchvalue"}
        Dim strVal() As String = {"FetchPatient", admissionid}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "sp_ManageAdmission", 0)
    End Function
    Public Shared Function getPatientDetails(ByVal patientid As Long) As DataTable
        Dim strPar() As String = {"operation", "soperation", "PatientID"}
        Dim strVal() As String = {0, 0, patientid}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spPatient", 0)
    End Function
    Public Shared Function getPatientRecord(ByVal PatientID As Long) As DataTable
        Dim strPar() As String = {"operation", "searchvalue"}
        Dim strVal() As String = {"FetchPatientDetails", PatientID}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "sp_ManageAdmission", 0)
    End Function
    Public Shared Function GetAllRecords(ByVal strSearch As String) As DataTable
        Dim par() As String = New String() {"operation", "Search"}
        Dim parVal() As String = New String() {0, strSearch}

        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(par, parVal, "sp_Patient_Save", 0)
    End Function
    Public Shared Function getReligion() As DataTable
        Dim strPar() As String = {"operation", "sOperation"}
        Dim strVal() As String = {0, 3}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spPatient", 0)
    End Function
    Public Shared Function getNationality() As DataTable
        Dim strPar() As String = {"operation", "sOperation"}
        Dim strVal() As String = {0, 2}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spPatient", 0)
    End Function
    Public Shared Function PatientAdmissionRecord(ByVal mPatID As Integer) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "PatientID"}
        Dim strVal() As String = {0, 4, mPatID}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spPatient", 0)
    End Function
    Public Function IsExist(ByVal mHospitalno As String) As Boolean
        Dim dt As New DataTable
        Dim par() As String = {"operation", "sOperation", "HospitalNo"}
        Dim parVal() As String = {0, 5, mHospitalno}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : dt = s.setparam(par, parVal, "spPatient", 0)
        Return CBool(dt.Rows(0).Item("isexist").ToString)
    End Function
    Public Shared Function isPatientNameExist(ByVal subOP As Integer, ByVal vlastname As String, ByVal vfirstname As String, ByVal vmiddlename As String, ByVal patientid As Long) As Boolean
        Dim dt As New DataTable
        Dim par() As String = {"operation", "sOperation", "SubOP", "dblastname ", "dbFirstName", "dbMiddleName", "patientid"}
        Dim parVal() As String = {0, 8, subOP, vlastname, vfirstname, vmiddlename, patientid}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : dt = s.setparam(par, parVal, "spPatient", 0)
        Return CBool(dt.Rows(0).Item("patcount").ToString)
    End Function
    Public Shared Function isfullPatientNameExist(ByVal dbLastName As String, ByVal dbFirstName As String, Optional ByVal dbMI As String = " ", Optional ByVal mlastname As String = "", Optional ByVal mfirstname As String = "", Optional ByVal mMi As String = "") As DataTable
        Dim par() As String = {"operation", "sOperation", "dbLastName", "dbFirstName", "dbMiddleName", "LastName", "FirstName", "MiddleName"}
        Dim parVal() As String = {0, 6, dbLastName, dbFirstName, dbMI, mlastname, mfirstname, mMi}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(par, parVal, "spPatient", 0)
    End Function
    Public Shared Function getAllRequisiton(ByVal admissionid As Long) As DataTable
        Dim strPar() As String = {"operation", "soperation", "admissionid"}
        Dim strVal() As String = {0, 9, admissionid}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spPatient", 0)
    End Function
    Public Shared Function getAllPatientCharges(ByVal admissionid As Long) As DataTable        'search = registryno or admissionchargeno
        Dim strPar() As String = {"operation", "soperation", "admissionid"}
        Dim strVal() As String = {0, 10, admissionid}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spPatient", 0)
    End Function
    Public Shared Function getPatientdetailsinfo(ByVal admissionid As Long) As DataTable        'search = registryno or admissionchargeno
        Dim strPar() As String = {"operation", "soperation", "admissionid"}
        Dim strVal() As String = {0, 11, admissionid}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spPatient", 0)
    End Function
    Public Shared Function getHospitalNo(ByVal vHospitalno As String) As DataTable        'search = registryno or admissionchargeno
        Dim strPar() As String = {"operation", "soperation", "HospitalNo"}
        Dim strVal() As String = {0, 12, vHospitalno}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spPatient", 0)
    End Function
    Public Shared Function getregions(ByVal subOP As Integer, ByVal mID As Integer) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "subOP"}
        Dim strVal() As String = {0, subOP, mID}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spPatient", 0)
    End Function
    Public Shared Function getprovid(ByVal vprovname As String) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "ProvName"}
        Dim strVal() As String = {0, 17, vprovname}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spPatient", 0)
    End Function
    Public Shared Function getID(ByVal mID As Integer) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "subOP"}
        Dim strVal() As String = {0, 14, mID}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spPatient", 0)
    End Function
    Public Shared Function getChargelist(ByVal vadmissionid As Integer) As DataTable        'search = registryno or admissionchargeno
        Dim strPar() As String = {"operation", "soperation", "AdmissionID"}
        Dim strVal() As String = {0, 6, vadmissionid}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spMedicalRecordReport", 0)
    End Function
    Public Shared Function getoccupation() As DataTable
        Dim strPar() As String = {"operation", "sOperation"}
        Dim strVal() As String = {0, 18}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spPatient", 0)
    End Function
    Public Shared Function getpatientcredentials(ByRef sop As Integer, ByRef search As String, Optional ByVal doctorid As Long = 0) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "patientid", "doctorid"}
        Dim strVal() As String = {0, sop, search, doctorid}
        'Dim x As New Public_Modules : Return x.CUSTOM_RETRIEVE("SP_DoctorPatient", strPar, strVal)
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "SP_DoctorPatient", 0)
    End Function
    Public Function Save(ByVal isNew As Boolean, Optional ByVal isImage As Boolean = False) As Long
        Dim sOperation As Integer = 1
        If isNew Then
            operation = 1
        Else
            operation = 2
                sOperation = 0
        End If
        Dim par() As String = {"operation", "sOperation", "PatientID", "HospitalNo", "FirstName", "LastName", "MiddleName", "suffixname", "BirthDate", "BirthPlace", _
                                "Religion", "BloodType", "Nationality", "Occupation", "Father", "Mother", "SSSNo", "GSISNo", "PhilHealthNo", "Gender", "CivilStatus", _
                                "HomeAddress", "CompanyName", "BusinessAddress", "TelephoneNo", "MobileNo", "EmailAddress", "OscaID", "isNewBorn", "RegisteredBy", _
                                "isActive", "age", "Region", "Province", "MunCity", "Barangay", "HouseNoStreet", "isphilhealthmember", "Photo", "relationshiptomember", "NewPK"}

        Dim parval() As Object = {Me.operation, sOperation, Me.PatientID, Me.HospitalNo, Me.FName, Me.LName, Me.MName, Me.Suffix, Me.BirthDate, Me.BirthPlace,
                                  Me.Religion, Me.BloodType.Trim, Me.Nationality, Me.Occupation, Me.Father, Me.Mother, Me.SSSNo, Me.GSISNo, Me.PhilHealthNo, Me.Gender.Trim, Me.CivilStatus,
                                  Me.Address, Me.CompanyName, Me.BusinessAddress, Me.TelephoneNo, Me.MobileNo, Me.EmailAddress, Me.OscaIDNo, Me.NewBornBaby, RegisteredBy,
                                  isActive, Age, Me.Region, Me.Province, Me.Municipality, Me.Barangay, Me.HouseNoStreet, isphilhealthmember, Me.Photo, Me.relationshiptomember, operation}
        'Dim s As New sqlbridge(gconnectionstring) : Return s.ReturnNewPK("spPatient", par, parval)
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(par, parval, "spPatient", 2)
    End Function



#End Region

End Class
