Public Class frmMain

    Public dbSettings As New DatabaseSettings
    Private redirectto As targerreport
    Private _searchkey As String
    Enum targerreport
        medicalrecord = 0
        chart = 1
        labitemmapping = 2 'pwede ta maghimo ug sub components under Diagnostic Test para ma.map ang item sa format sa result. para magamit na ang existing diagnostic
        birthcertificate = 3
        deathcertificate = 4
        progressnotes = 5 'call from ipd subcomponents
        nursingnotes = 6 'call from ipd subcomponents
        prescriptionlist = 7 'call prescriptionlist/testrequestlist from ipd/opd/er subcomponents
    End Enum
    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'modGlobal.gconnectionstring = "Data Source=Royette-PC\SQL2008R2;Initial Catalog=lutheranhospital_EMR_20200120;Trusted_Connection=True;Connection Timeout=60"
        'Me.employeeid = 1186  'supplier userid before opening this report
        'modGlobal.gconnectionstring = "Data Source=Royette-PC\SQL2008R2;Initial Catalog=dominicanhospitalV2_20200205;Trusted_Connection=True;Connection Timeout=60"

        With dbSettings
            modGlobal.gconnectionstring = "Data Source=" & .Host & _
                                             ";Initial Catalog=" & .DatabaseName & _
                                             "; User ID=" & .UserId & _
                                             ";Password=" & .Password & _
                                             ";Connection Timeout=60"
            '";Trusted_Connection=True;Connection Timeout=60" 
            'modGlobal.SQLTestConnection(.Host, .DatabaseName, .AuthType, .UserId, .Password)
        End With
        setUserInfo()
        Me.Hide()
        If redirectto = targerreport.medicalrecord Then
            Dim f As New frmHISReports
            f.ShowDialog()
        ElseIf redirectto = targerreport.chart Then
            Call modGlobal.LoadUserModules()
            Call modGlobal.LoadUserSubModules()
            Dim f As New frmChart
            f.admissionid = _searchkey
            f.ShowDialog()
        ElseIf redirectto = targerreport.labitemmapping Then
            Dim f As New frmLaboratoryItems
            f.ShowDialog()
        ElseIf redirectto = targerreport.birthcertificate Then
            Dim f As New frmHISReports
            f.reportcode = 6
            f.subreportcode = 10
            f.patientid = Me._searchkey
            f.ShowDialog()
        ElseIf redirectto = targerreport.deathcertificate Then
            Dim f As New frmHISReports
            f.reportcode = 6
            f.subreportcode = 11
            f.patientid = Me._searchkey
            f.ShowDialog()
        ElseIf redirectto = targerreport.progressnotes Then
            Dim f As New frmProgressNotes
            f.admissionid = _searchkey
            f.ShowDialog()
        ElseIf redirectto = targerreport.nursingnotes Then
            Dim f As New frmNursingNotes
            f.admissionid = _searchkey
            f.ShowDialog()
        ElseIf redirectto = targerreport.prescriptionlist Then
            Dim f As New frmPrescriptionList
            f.admissionid = _searchkey
            f.ShowDialog()
        End If
        Me.Close()
    End Sub
    Public Class DatabaseSettings
        Public Host As String
        Public DatabaseName As String
        Public AuthType As String
        Public UserId As String
        Public Password As String
    End Class
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        'SQLTestConnection("toni\sqlexpress", "simplehisv3_lhi_20200226", 1, "sa", "sql2008")
        ' Add any initialization after the InitializeComponent() call.
        'With dbSettings
        '    .Host = "toni\sqlexpress"
        '    .DatabaseName = "simplehisv3_lhi_20200226"
        '    .AuthType = 1
        '    .UserId = "sa"
        '    .Password = "sql2008"
        'End With
        With dbSettings
            .Host = "rigie\rigie"
            .DatabaseName = "ecomed_20220610_live_toni"
            .AuthType = 0
            .UserId = "sa"
            .Password = "12345"
        End With
        _searchkey = "123456"
        employeeid = 1
        redirectto = targerreport.medicalrecord
    End Sub
    Public Sub New(ByVal Host As String,
         ByVal DatabaseName As String,
         ByVal AuthType As String,
         ByVal UserId As String,
         ByVal Password As String,
         ByVal _report As Integer,
         ByVal employeeid As Long,
         ByVal search As String)

        ' This call is required by the designer.
        InitializeComponent()



        modGlobal.employeeid = employeeid
        modGlobal.userid = employeeid
        If _report >= 0 Then
            redirectto = _report
        Else
            redirectto = targerreport.medicalrecord
        End If
        _searchkey = search
        With dbSettings
            .Host = Host
            .DatabaseName = DatabaseName
            .AuthType = AuthType
            .UserId = UserId
            .Password = Password
        End With
    End Sub
End Class