Public Class clsAdmission

#Region "Properties"
    Private mPatientID As Long
    Private mAdmissionNo As String
    Private mDateofAdmin As DateTime
    Private mDateDischarge As DateTime
    Private mFinalDiagnosis As String
    Private mAdmittingDiagnosis As String
    Private mReasonForAdmission As String
    Private mPhilHealthNo As String
    Private mPhilHealthMember As String
    Private mAdmissionID As Long
    Private mHC As String
    Private mPC As String
    Private mInformant As String
    Private mInformantRelationship As String
    Private mNotify As String
    Private mNotifyRelationship As String
    Private mNotifyAddress As String
    Private mNotifyTelNo As String
    Private mKindOfOperation As String
    Private mEmployeeID As Integer
    Private mCompanyID As Integer
    Private mAdmissionType As String
    Public casetype As Char
    Public hospitalplan As Integer

    Public testresultype As String
    Public testresultid As Long
    Public photo As Object
    Public testresultname As String
    Public testresultdesc As String
    Public testdate As Date
    Public isimagesync As Boolean


    Public Property PatientID() As Long
        Get
            Return mPatientID
        End Get
        Set(ByVal value As Long)
            mPatientID = value
        End Set
    End Property
    Public Property AdmissionID() As String
        Get
            Return mAdmissionID
        End Get
        Set(ByVal value As String)
            mAdmissionID = value
        End Set
    End Property
    Public Property DateofAdmin() As DateTime
        Get
            Return mDateofAdmin
        End Get
        Set(ByVal value As DateTime)
            mDateofAdmin = value
        End Set
    End Property
    Public Property DateDischarge() As DateTime
        Get
            Return mDateDischarge
        End Get
        Set(ByVal value As DateTime)
            mDateDischarge = value
        End Set
    End Property

    Public Property FinalDiagnosis() As String
        Get
            Return mFinalDiagnosis
        End Get
        Set(ByVal value As String)
            mFinalDiagnosis = value
        End Set
    End Property
    Public Property AdmittingDiagnosis() As String
        Get
            Return mAdmittingDiagnosis
        End Get
        Set(ByVal value As String)
            mAdmittingDiagnosis = value
        End Set
    End Property
    Public Property ReasonForAdmission() As String
        Get
            Return mReasonForAdmission
        End Get
        Set(ByVal value As String)
            mReasonForAdmission = value
        End Set
    End Property
    Public Property PhilHealthNo() As String
        Get
            Return mPhilHealthNo
        End Get
        Set(ByVal value As String)
            mPhilHealthNo = value
        End Set
    End Property
    Public Property PhilHealthMember() As String
        Get
            Return mPhilHealthMember
        End Get
        Set(ByVal value As String)
            mPhilHealthMember = value
        End Set
    End Property
    Public Property AdmissionNo() As Integer
        Get
            Return mAdmissionNo
        End Get
        Set(ByVal value As Integer)
            mAdmissionNo = value
        End Set
    End Property
    Public Property HC() As String
        Get
            Return mHC
        End Get
        Set(ByVal value As String)
            mHC = value
        End Set
    End Property
    Public Property Pc() As String
        Get
            Return mPC
        End Get
        Set(ByVal value As String)
            mPC = value
        End Set
    End Property
    Public Property Informant() As String
        Get
            Return mInformant
        End Get
        Set(ByVal value As String)
            mInformant = value
        End Set
    End Property
    Public Property InformantRelationship() As String
        Get
            Return mInformantRelationship
        End Get
        Set(ByVal value As String)
            mInformantRelationship = value
        End Set
    End Property
    Public Property Notify() As String
        Get
            Return mNotify
        End Get
        Set(ByVal value As String)
            mNotify = value
        End Set
    End Property
    Public Property NotifyRelationShip() As String
        Get
            Return mNotifyRelationship
        End Get
        Set(ByVal value As String)
            mNotifyRelationship = value
        End Set
    End Property
    Public Property NotifyAddress() As String
        Get
            Return mNotifyAddress
        End Get
        Set(ByVal value As String)
            mNotifyAddress = value
        End Set
    End Property
    Public Property NotifyTelNo() As String
        Get
            Return mNotifyTelNo
        End Get
        Set(ByVal value As String)
            mNotifyTelNo = value
        End Set
    End Property

    Public Property KindOfOperation() As String
        Get
            Return mKindOfOperation
        End Get
        Set(ByVal value As String)
            mKindOfOperation = value
        End Set
    End Property

    Public Property AdmissionType() As String
        Get
            Return mAdmissionType
        End Get
        Set(ByVal value As String)
            mAdmissionType = value
        End Set
    End Property
    Public Property EmployeeID() As String
        Get
            Return mEmployeeID
        End Get
        Set(ByVal value As String)
            mEmployeeID = value
        End Set
    End Property

    Public Property CompanyID() As Integer
        Get
            Return mCompanyID
        End Get
        Set(ByVal value As Integer)
            mCompanyID = value
        End Set
    End Property
#End Region

#Region "Data Access"
    Public Shared Function GetAdmissionRecord(ByVal sValue As String, ByVal sAdmissiontype As String) As DataTable
        Select Case sAdmissiontype
            Case "Inpatients", "NursingServices"
                sAdmissiontype = "IPD"
            Case "Outpatients"
                sAdmissiontype = "OPD"
            Case "Emergency"
                sAdmissiontype = "ER"
        End Select

        'test
        Dim arrFieldName() As String = {"operation", "soperation", "searchvalue", "admissiontype"}
        Dim arrFieldValue() As Object = {0, 0, sValue, sAdmissiontype} 'FETCHDETAILS
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(arrFieldName, arrFieldValue, "spAdmission", 0)
    End Function

    Public Sub SaveMghClearance(ByVal strAdmissionNo As String)

        Dim arFields As String() = New String() {"operation", "soperation", "admissionid"}

        Dim arVal As Object() = New Object() {1, 0, strAdmissionNo}

        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : s.setparam(arFields, arVal, "spMedicalRecordReport", 1)
    End Sub
#End Region

End Class

