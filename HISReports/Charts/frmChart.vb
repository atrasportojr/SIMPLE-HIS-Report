Public Class frmChart

    Private Sub Reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadAdmissionInfo()
        setUserAccess()
    End Sub

#Region "Vars"
    Public admissionid As Long
    Private afterload As Boolean = True
    Private admissiontype As String
    Private selectedreportcode As subreports
    Enum subreports
        None = 0
        ClinicalRecord = 3
        DischargeSummary = 4
        HistoryandPE = 13
        ConsentforProcedure = 15
        OperativeRecord = -1
        ORNursingRecord = -2
        ORSafetyChecklist = -3
        NursingNotes = -4
        ProgressNotes = -5
        PreoperativecheckList = -6
        APGARScoreSheet = -7
        PreAnestheticAssessment = -8
        ChildCareandDevCard = -9
        ConsentforAdmission = -10
        IVFluidSheet = -11
    End Enum
#End Region
#Region "Methods"
    Private Sub setUserAccess()
        Me.btnProgressNotes.Visible = GetUserSubModulesVisibility(modGlobal.employeeid, AccountSubModule.smodProgressNotes)
        Me.btnnursingnotes.Visible = GetUserSubModulesVisibility(modGlobal.employeeid, AccountSubModule.smodNursingNotes)
        Me.btnintravenousfluids.Visible = GetUserSubModulesVisibility(modGlobal.employeeid, AccountSubModule.smodIVFluidSheet)
        Me.btnEditOperation.Visible = GetUserSubModulesVisibility(modGlobal.employeeid, AccountSubModule.smodOperativeRecord)
        If Me.admissiontype = "IPD" Then
            GetUserModules(AccountModule.modInpatients)
            Me.btnapgarscoresheet.Visible = canEdit
        ElseIf Me.admissiontype = "OPD" Then
            GetUserModules(AccountModule.modOutpatient)
            Me.btnapgarscoresheet.Visible = canEdit
        ElseIf Me.admissiontype = "ER" Then
            GetUserModules(AccountModule.modEmergency)
            Me.btnapgarscoresheet.Visible = canEdit
        End If
    End Sub
    Private Sub LoadAdmissionInfo()
        Dim dtAdmissions As New DataTable
        dtAdmissions = clsAdmissiondetails.loadAdmission(admissionid)
        Me.admissiontype = dtAdmissions.Rows(0).Item("admissiontype")
        Me.lbladmissiondate.Text = dtAdmissions.Rows(0).Item("dateadmitted")
        Call LoadPatient(dtAdmissions.Rows(0).Item("PatientID"))

        afterload = False
        With Me.cmbprocedurename
            .DataSource = clsOperativeRecord.genericcls(0, Me.admissionid)
            .DisplayMember = "diagnosis"
            .ValueMember = "icd10code"
            .SelectedIndex = -1
        End With
        afterload = True
        If Me.cmbprocedurename.Items.Count > 0 Then
            Me.cmbprocedurename.SelectedIndex = 0
        End If
    End Sub
    Private Sub LoadPatient(ByVal PatientID As Integer)
        Dim mHospno As String
        Dim dtpat As New DataTable
        dtpat = clsAdmissiondetails.getPatientDetails(PatientID)
        mHospno = Utility.NullToEmptyString(dtpat.Rows(0).Item("HospitalNo"))
        Me.lblpatient.Text = dtpat.Rows(0).Item("lastname") & " " & Utility.NullToEmptyString(dtpat.Rows(0).Item("suffixname")) & ", " & dtpat.Rows(0).Item("FirstName") & " " & dtpat.Rows(0).Item("MiddleName")
        Me.lblbirthdate.Text = dtpat.Rows(0).Item("BirthDate")
        Me.lbladdress.Text = dtpat.Rows(0).Item("homeaddress")
    End Sub
    Private Sub loadReport(Optional ByVal reportcode As subreports = subreports.None)
        If reportcode = subreports.None Then
            reportcode = selectedreportcode
        Else
            Me.selectedreportcode = reportcode
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim crpt As New Object
        Dim dtReport As New DataTable
        Dim dtRecord As New DataTable
        Select Case reportcode
            Case subreports.ClinicalRecord, subreports.HistoryandPE, subreports.DischargeSummary, subreports.ConsentforProcedure
                dtReport = clsReportDashboard.getHISReports(2, reportcode)
                crpt = Activator.CreateInstance(Type.GetType(Me.GetType().Namespace & "." & dtReport.Rows(0).Item("reportfilename")))
                dtRecord = clsReportDashboard.getReport(dtReport.Rows(0).Item("soperation"), Utility.NullToEmptyString(Me.cmbprocedurename.SelectedValue), Me.admissionid)
            Case subreports.OperativeRecord
                crpt = New crptOperativeRecord
                dtRecord = clsOperativeRecord.genericcls(1, Me.admissionid, Me.cmbprocedurename.SelectedValue)
            Case subreports.ORNursingRecord
                crpt = New crptORNursingRecord
                dtRecord = clsOperativeRecord.genericcls(1, Me.admissionid, Me.cmbprocedurename.SelectedValue)
            Case subreports.ORSafetyChecklist
                crpt = New crptSurgicalSafetyChecklist
                dtRecord = clsOperativeRecord.genericcls(1, Me.admissionid, Me.cmbprocedurename.SelectedValue)
            Case subreports.PreAnestheticAssessment
                crpt = New crptPreAnestheticAssessment
                dtRecord = clsOperativeRecord.genericcls(1, Me.admissionid, Me.cmbprocedurename.SelectedValue)
            Case subreports.APGARScoreSheet
                crpt = New crptAPGARScoreSheet
                dtRecord = clsAdmissionNewborn.genericcls(0, Me.admissionid)
            Case subreports.ChildCareandDevCard
                crpt = New crptChildCard
                dtRecord = clsAdmissionNewborn.genericcls(1, Me.admissionid)
            Case subreports.NursingNotes
                crpt = New crptNursingNotes_V2
                dtRecord = clsNursingNotes.getReportData(admissionid)
            Case subreports.ProgressNotes
                crpt = New crptProgressNotes_V2
                dtRecord = clsProgressNotes.getReportData(Me.admissionid)
            Case subreports.ConsentforAdmission
                crpt = New crptAdmissionConsent_LHI
                dtRecord = clsReportDashboard.getReport(27, "", Me.admissionid)
            Case subreports.IVFluidSheet
                crpt = New crptIVFluidSheet
                dtRecord = clsIVFluidSheet.genericcls(0, Me.admissionid)
            Case subreports.PreoperativecheckList
                crpt = New crptPreOperativeChecklist
                dtRecord = clsOperativeRecord.genericcls(1, Me.admissionid, Me.cmbprocedurename.SelectedValue)
            Case Else
                reportcode = subreports.None
        End Select
        If Not reportcode = subreports.None Then
            crpt.SetDataSource(dtRecord)
            Me.crvPrinting.ReportSource = crpt
        End If
        Me.Cursor = Cursors.Arrow
    End Sub
#End Region

    Private Sub lblclinicalrecord_Click(sender As System.Object, e As System.EventArgs) Handles lblclinicalrecord.Click
        Call loadReport(subreports.ClinicalRecord)
    End Sub

    Private Sub Label10_Click(sender As System.Object, e As System.EventArgs)
        Call loadReport(subreports.ConsentforProcedure)
    End Sub

    Private Sub Label12_Click(sender As System.Object, e As System.EventArgs) Handles Label12.Click
        Call loadReport(subreports.HistoryandPE)
    End Sub

    Private Sub Label13_Click(sender As System.Object, e As System.EventArgs) Handles Label13.Click
        Call loadReport(subreports.DischargeSummary)
    End Sub

    Private Sub Label16_Click(sender As System.Object, e As System.EventArgs) Handles Label16.Click
        Call loadReport(subreports.ProgressNotes)
    End Sub

    Private Sub btnEditOperation_Click(sender As System.Object, e As System.EventArgs) Handles btnEditOperation.Click
        Dim f As New frmOperativeRecords
        f.admissionid = Me.admissionid
        f.ShowDialog()
        Call loadReport()
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click
        If Me.cmbprocedurename.SelectedIndex >= 0 Then
            Call loadReport(subreports.OperativeRecord)
        End If
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click
        If Me.cmbprocedurename.SelectedIndex >= 0 Then
            Call loadReport(subreports.ORNursingRecord)
        End If
    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click
        If Me.cmbprocedurename.SelectedIndex >= 0 Then
            Call loadReport(subreports.ORSafetyChecklist)
        End If
    End Sub

    Private Sub Label20_Click(sender As System.Object, e As System.EventArgs) Handles Label20.Click
        If Me.cmbprocedurename.SelectedIndex >= 0 Then
            Call loadReport(subreports.ConsentforProcedure)
        End If
    End Sub

    Private Sub btnProgressNotes_Click(sender As System.Object, e As System.EventArgs) Handles btnProgressNotes.Click
        Dim f As New frmProgressNotes
        f.admissionid = Me.admissionid
        f.ShowDialog()
        Call loadReport(subreports.ProgressNotes)
    End Sub

    Private Sub btnnursingnotes_Click(sender As System.Object, e As System.EventArgs) Handles btnnursingnotes.Click
        Dim f As New frmNursingNotes
        f.admissionid = Me.admissionid
        f.ShowDialog()
        Call loadReport(subreports.NursingNotes)
    End Sub

    Private Sub Label17_Click(sender As System.Object, e As System.EventArgs) Handles Label17.Click
        Call loadReport(subreports.NursingNotes)
    End Sub

    Private Sub colintravenousfluids_Click(sender As System.Object, e As System.EventArgs) Handles btnintravenousfluids.Click
        Dim f As New frmIntravenousFluids
        f.admissionid = Me.admissionid
        f.ShowDialog()
        Call loadReport(subreports.IVFluidSheet)
    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click
        If Me.cmbprocedurename.SelectedIndex >= 0 Then
            Call loadReport(subreports.Preoperativechecklist)
        End If
    End Sub

    Private Sub btnapgarscoresheet_Click(sender As System.Object, e As System.EventArgs) Handles btnapgarscoresheet.Click
        Dim f As New frmAdmission
        f.admissiontype = Me.admissiontype
        f.myCurrentFormStatus = frmAdmission.enFormStatus.edit
        f.AdmissionID = Me.admissionid
        f.enformpurpose = "Newborn"
        f.ShowDialog()
        Call loadReport(subreports.APGARScoreSheet)
    End Sub

    Private Sub Label30_Click(sender As System.Object, e As System.EventArgs) Handles Label30.Click
        Call loadReport(subreports.APGARScoreSheet)
    End Sub

    Private Sub Label8_Click(sender As System.Object, e As System.EventArgs) Handles Label8.Click
        Call loadReport(subreports.PreAnestheticAssessment)
    End Sub

    Private Sub Label10_Click_1(sender As System.Object, e As System.EventArgs) Handles Label10.Click
        Call loadReport(subreports.ChildCareandDevCard)
    End Sub


    Private Sub Label21_Click(sender As System.Object, e As System.EventArgs) Handles Label21.Click
        Call loadReport(subreports.ConsentforAdmission)
    End Sub

    Private Sub Label15_Click(sender As System.Object, e As System.EventArgs) Handles Label15.Click
        Call loadReport(subreports.IVFluidSheet)
    End Sub
End Class