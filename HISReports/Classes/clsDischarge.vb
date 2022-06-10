Public Class clsDischarge
#Region "Variables"
    Private mICD10Code As String
    Private mDiagnosisDesc As String
    Private mAdmissionID As Integer
    Private mIsPrimaryDiagnosis As Boolean
    Private mFinalDiagnosis As String
#End Region

#Region "Property"
    Public Property AdmissionID() As Integer
        Get
            Return mAdmissionID
        End Get
        Set(ByVal value As Integer)
            mAdmissionID = value
        End Set
    End Property
    Public Property IsPrimaryDiagnosis() As Boolean
        Get
            Return mIsPrimaryDiagnosis
        End Get
        Set(ByVal value As Boolean)
            mIsPrimaryDiagnosis = value
        End Set
    End Property
    Public Property ICD10Code() As String
        Get
            Return mICD10Code
        End Get
        Set(ByVal value As String)
            mICD10Code = value
        End Set
    End Property
    Public Property DiagnosisDesc() As String
        Get
            Return mDiagnosisDesc
        End Get
        Set(ByVal value As String)
            mDiagnosisDesc = value
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
#End Region

#Region "Methods"
    Public Shared Function getDiagnosis(ByVal vSearch As String) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "search"}
        Dim strVal() As String = {0, 0, vSearch}
        'Return GenericDA.ManageQuery(strPar, strVal, "spDischarge", 0)
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spDischarge", 0)

    End Function
    Public Shared Function LoadDiagnosis(ByVal vAdmissionID As Integer) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "AdmissionID"}
        Dim strVal() As String = {0, 1, vAdmissionID}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spDischarge", 0) 'GenericDA.ManageQuery(strPar, strVal, "spDischarge", 0)
    End Function
    Public Shared Function DeleteAdmissionDiagnosis(ByVal vAdmissionID As Integer) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "AdmissionID"}
        Dim strVal() As String = {0, 2, vAdmissionID}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spDischarge", 0) ' GenericDA.ManageQuery(strPar, strVal, "spDischarge", 0)
    End Function

    Public Sub SaveDetails()
        Dim strPar() As String = {"operation", "sOperation", "AdmissionID", "ICD10Code", "isprimarydiagnosis", "FinalDiagnosis"}
        Dim strVal() As String = {1, 0, Me.AdmissionID, Me.ICD10Code, IsPrimaryDiagnosis, FinalDiagnosis}
        'GenericDA.ManageQuery(par, parVal, "spDischarge", 1)
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : s.setparam(strPar, strVal, "spDischarge", 1)
    End Sub

    'Public Sub SaveFinalDiagnosis()
    '    Dim par() As String = {"operation", "sOperation", "AdmissionID", "FinalDiagnosis"}
    '    Dim parVal() As String = {1, 1, Me.AdmissionID, FinalDiagnosis}
    '    GenericDA.ManageQuery(par, parVal, "spDischarge", 1)
    'End Sub
#End Region
    
End Class
