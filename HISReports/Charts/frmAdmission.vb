Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Public Class frmAdmission
#Region "Validation"
    Private Function AllDataEntryFieldsAreValid() As Boolean
        Dim blnValid As Boolean = True
        If HospitalNo(Me.lblHospNo) = False Then
            blnValid = False
            Return blnValid
            Exit Function
        End If
        'If Room(Me.lblroom) = False Then
        '    blnValid = False
        '    Return blnValid
        '    Exit Function
        'End If
        If AdmittingPhysician(Me.lblAdmittingDoctor) = False Then
            blnValid = False
            Return blnValid
            Exit Function
        End If
        If AttendingPhysician(Me.lblAttendingPhysician) = False Then
            blnValid = False
            Return blnValid
            Exit Function
        End If
        If validatePtNo(Me.lblPatientNo) = False Then
            blnValid = False
            Return blnValid
            Exit Function
        End If
        Return blnValid
    End Function
    Private Function HospitalNo(ByVal ctl As Control) As Boolean
        Dim isValid As Boolean
        If myCurrentFormStatus <> enFormStatus.browsing Then

            If ctl.Text = "" Then
                SetErrorProvider(ctl, "This field is required.")
                isValid = False
            Else
                isValid = True
                ResHospNo(lblHospNo)
            End If
        End If
        Return isValid
    End Function
    Private Function Room(ByVal ctl As Control) As Boolean
        Dim isValid As Boolean
        If myCurrentFormStatus <> enFormStatus.browsing Then

            If ctl.Text = "" Then
                SetErrorProvider(ctl, "This field is required.")
                isValid = False
            Else
                isValid = True
                ResRoom(lblroom)
            End If

        End If
        Return isValid
    End Function
    Private Function AdmittingPhysician(ByVal ctl As Control) As Boolean
        Dim isValid As Boolean
        If myCurrentFormStatus <> enFormStatus.browsing Then

            If ctl.Text = "" Then
                SetErrorProvider(ctl, "This field is required.")
                isValid = False
            Else
                isValid = True
                ResAdmittingPhysician(lblAdmittingDoctor)
            End If

        End If
        Return isValid
    End Function
    Private Function AttendingPhysician(ByVal ctl As Control) As Boolean
        Dim isValid As Boolean
        If myCurrentFormStatus <> enFormStatus.browsing Then

            If ctl.Text = "" Then
                SetErrorProvider(ctl, "This field is required.")
                isValid = False
            Else
                isValid = True
                ResAttendingPhysician(lblAttendingPhysician)
            End If
        End If
        Return isValid
    End Function
    Private Function validatePtNo(ByVal ctl As Control) As Boolean
        Dim isValid As Boolean
        If myCurrentFormStatus <> enFormStatus.browsing Then

            Dim dts As DataTable = clsAdmissiondetails.genericcls(32, Me.lblPatientNo.Text, admissiontype)
            If dts.Rows(0).Item("isexist") = 1 Then
                SetErrorProvider(Me.lblPatientNo, "Pt No. already exists.")
                isValid = False
            ElseIf ctl.Text = "" Then
                SetErrorProvider(ctl, "This field is required.")
                isValid = False
            Else
                isValid = True
                ResPatNo(lblPatientNo)
            End If

        End If
        Return isValid
    End Function
    Private Sub ResHospNo(ByVal sClear As Control)
        SetErrorProvider(Me.lblHospNo)
    End Sub
    Private Sub ResAttendingPhysician(ByVal sClear As Control)
        SetErrorProvider(Me.lblAttendingPhysician)
    End Sub
    Private Sub ResRoom(ByVal sClear As Control)
        SetErrorProvider(Me.lblroom)
    End Sub
    Private Sub ResAdmittingPhysician(ByVal sClear As Control)
        SetErrorProvider(Me.lblAdmittingDoctor)
    End Sub
    Private Sub SetErrorProvider(ByVal ctl As Control, Optional ByVal strErrorMessage As String = "")
        erp.SetError(ctl, strErrorMessage)
    End Sub
    Private Sub ResPatNo(ByVal sClear As Control)
        SetErrorProvider(Me.lblPatientNo)
    End Sub
    Private Sub lblroom_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblroom.TextChanged
        If Me.lblHospNo.Text <> "" Then
            Room(Me.lblroom)
        End If
        Room(Me.lblroom)
    End Sub
    Private Sub lblAttendingPhysician_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAttendingPhysician.TextChanged
        If Me.lblAttendingPhysician.Text <> "" Then
            AttendingPhysician(Me.lblAttendingPhysician)
        End If
        AttendingPhysician(Me.lblAttendingPhysician)
    End Sub
    Private Sub lblAdmittingDoctor_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAdmittingDoctor.TextChanged
        If Me.lblAdmittingDoctor.Text <> "" Then
            AdmittingPhysician(Me.lblAdmittingDoctor)
        End If
        AdmittingPhysician(Me.lblAdmittingDoctor)
    End Sub
    Private Sub lblHospNo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHospNo.TextChanged
        If lblHospNo.Text <> "" Then
            HospitalNo(Me.lblHospNo)
        End If
        HospitalNo(Me.lblHospNo)
    End Sub
    Private Sub dgobygne_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) 'Handles dgobygne.CellValidating
        Dim CurrentCellValue As Object = e.FormattedValue
        Dim CurrentCellValueMinusCurrenctyFormatting As String = Replace(CurrentCellValue.ToString, "$", "")

        Dim DoubleForConvert As Double
        If Double.TryParse(CurrentCellValueMinusCurrenctyFormatting, DoubleForConvert) = True Then
            dgobygne.CurrentCell.Value = DoubleForConvert
        Else
            dgobygne.CurrentCell.Value = 0
            e.Cancel = True
            Exit Sub
        End If
    End Sub
    Private Sub dgObgyne_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgObgyne.CurrentCellDirtyStateChanged
        Dim dgCheckBox As DataGridViewCheckBoxCell
        Dim idx As Integer = dgObgyne.CurrentRow.Index

        Try
            If dgObgyne.CurrentCellAddress.X = 0 Then
                dgCheckBox = dgObgyne.CurrentRow.Cells(0)

                If (dgObgyne.IsCurrentCellDirty) Then
                    dgObgyne.CommitEdit(DataGridViewDataErrorContexts.Commit)

                    If dgCheckBox.Value Then
                        Call LoadObgyne()
                    End If

                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub DataError(ByVal sender As Control, ByVal e As DataGridViewDataErrorEventArgs) Handles dgObgyne.DataError
        If TypeOf e.Exception Is ConstraintException Then

            Dim view As DataGridView = DirectCast(sender, DataGridView)
            view.Rows(e.RowIndex).ErrorText = "an error"
            view.Rows(e.RowIndex).Cells(e.ColumnIndex).ErrorText = "an error"
            e.ThrowException = False

        End If
    End Sub
#End Region

#Region "Variables"
    Public myCurrentFormStatus As enFormStatus
    Public vFilterby As String
    Public admissiontype As String
    Public subModule As String
    Public isSave As Boolean
    Public PatType As String
    Private SearchName As String
    Public AdmissionID As Integer
    Public misAdmitPatient As Boolean
    Public PtNo As String
    Public hospnolen As String
    Dim value As String
    Public DocID As Integer
    Private oldAdmittingPhy As Integer     '---- Doctors Variables
    Private Docfee As Decimal       '---- Doctors Variables
    Private mAttendingphyCharge As Decimal
    Private OldAttendingpHy As Integer
    Public vAdmissionID As String
    Public mAttendingPhysician As Integer '------AttendingPhysician
    Public PatientID As Integer '---- Rooms Variables
    Dim dateadmitted As DateTime
    Dim PatientType As String   '---- Rooms Variables
    Public RoomID As Integer = 0 '---- Rooms Variables
    Private OldRoomID As Integer = 0
    Dim sRoomID As Integer
    Dim dtLoadtoGrid As New DataTable
    Dim dtSelected As New DataTable
    Dim RoomRate As Integer     '---- Rooms Variables
    Dim ObsPogNo As String
    Dim misAvailableroom As Boolean
    Dim PregnancyOrder As String
    Dim imageName As String
    Dim imageName1 As String
    'Dim _SqlConnection As New System.Data.SqlClient.SqlConnection()
    Dim erp As New ErrorProvider
    Dim sFilterby As String
    Dim hasImage As Boolean
    Dim vDepartmentcode As String
    Private gender As String
    Private userid As String
    Dim Exist As Boolean = False
    Public status As Integer
    Private misnewborn As Boolean
    Dim fSearchPAt As New frmSearchEngine()
    Dim PogDoctorID As Long
    Private vid As Long
    Private x As Integer
    Private vdischargestat As Integer
    Private dtfinalbill As DataTable
    Dim caseno As Long
    Dim casedesc As String
    Private interviewedbyid As Long
    Public enformpurpose As String 'Redirect to specific tab. Valid value('Newborn'->Redirect to newbord tab)
    Enum enFormStatus
        browsing = 0
        add = 1
        edit = 2
        view = 3
    End Enum
#End Region

#Region "Methods"
    Private Sub frmAdmission_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control = True And e.KeyCode = Keys.S Then
            If isSave = False And myCurrentFormStatus <> enFormStatus.browsing Then
                Save()
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            If myCurrentFormStatus <> enFormStatus.browsing Then
                If MsgBox("Are you sure you want to save this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, modGlobal.msgboxTitle) = MsgBoxResult.Yes Then
                    Me.Close()
                End If
            Else
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F3 And btnPatient.Visible = True Then
            loadPatient()
            Exit Sub
        ElseIf e.Control = True And e.KeyCode = Keys.A And subModule = "Inpatients" And btnSearchDoctor.Enabled = True Then
            LoadSearchPhysician()
            Exit Sub
        ElseIf e.Control = True And e.KeyCode = Keys.D And btnAttendingPhysician.Enabled = True Then
            LoadAttendingPhysician()
            Exit Sub
        ElseIf e.Control = True And e.KeyCode = Keys.R And subModule = "Inpatients" And btnSearchRoom.Enabled = True Then
            LoadSearchRoom()
            Exit Sub
        End If
    End Sub
    Private Sub frmclosed()
        If fSearchPAt.mKey = 0 Or fSearchPAt.issave = False Then
            Me.Close()
        ElseIf myCurrentFormStatus <> enFormStatus.browsing Then
            If MsgBox("Are you sure you want to close this form?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, modGlobal.msgboxTitle) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub
    Public Function Save() As Boolean
        Dim strMsgBox As String = ""
        Dim sw As Boolean
        'Dim datetimeadmitted As Date = CDate(Me.dtpAdmissionDate.Value.ToShortDateString & " " & Me.dtpAdmissionTime.Value.ToLongTimeString)
        Dim datetimemgh As Date = CDate(Me.dtpMGHDate.Value.ToShortDateString & " " & Me.dtpMGHTime.Value.ToLongTimeString)
        Dim datetimedischarged As Date = CDate(Me.dtpDDDate.Value.ToShortDateString & " " & Me.dtpDDTime.Value.ToLongTimeString)

        'If subModule = "Inpatients" Then
        Dim filterby As String = ""
        If vFilterby = "SubMGH" Or vFilterby = "SubDischarge" Or vFilterby = "SubUntagasMGH" Then
            Select Case vFilterby
                Case "SubMGH"
                    filterby = "May Go Home"
                    If datetimemgh <= dateadmitted Then
                        MsgBox("MGH Date/Time should be after the Admission Date/Time.", vbCritical, msgboxTitle)
                        Return sw
                        Exit Function
                    End If
                Case "SubDischarge"
                    filterby = "Discharged"
                    If datetimedischarged <= dateadmitted Then
                        MsgBox("Discharge Date/Time should be after the Admission Date/Time.", vbCritical, msgboxTitle)
                        Return sw
                        Exit Function
                    End If
                Case "SubUntagasMGH"
                    filterby = "Active"
            End Select
            strMsgBox = "Are you sure you want to tag this patient as " & UCase(filterby) & " ?"
        ElseIf myCurrentFormStatus = enFormStatus.add Then
            strMsgBox = "Are you sure you want to register this patient as " & UCase(admissiontype) & " ?"
        ElseIf myCurrentFormStatus = enFormStatus.edit Then
            strMsgBox = "Are you sure you want to update this record? "
        End If
        'End If

        If ValidatePatients() Then
            If MsgBox(strMsgBox, MsgBoxStyle.Question + MsgBoxStyle.YesNo, modGlobal.msgboxTitle) = MsgBoxResult.Yes Then
                SaveRecords()
                sw = True
            End If
        End If
        Return sw
    End Function
    Private Sub frmAdmission_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call LoadImage()
        Call LoadToCombox()
        Call loadReferringHCI()
        Call BlankForm()
        Call removetabs()
        If myCurrentFormStatus = enFormStatus.add Then
            Call loadPatient(PatientID)
            If PatientID <> 0 Then
                SetErrorProvider(Me.btnPatient)
            End If
        End If
        If vFilterby = "SubMGH" Or vFilterby = "SubDischarge" Or vFilterby = "SubUntagasMGH" Then
            If vFilterby = "SubMGH" Then
                Me.Text = "MGH"
            ElseIf vFilterby = "SubDischarge" Then
                Me.Text = "DISCHARGE"
            ElseIf vFilterby = "SubUntagasMGH" Then
                Me.Text = "UNTAG as MGH"
            End If
            Call LoadDischargeData()
            Call LoadReasonsforRefferal()
            Me.tabadmission.Controls.Add(tbDischargeStatus)
            'Call chkAdmisionStatus()
            Call loadMGH()
            Call EnableField()
        ElseIf myCurrentFormStatus = enFormStatus.browsing Or myCurrentFormStatus = enFormStatus.edit Then
            Call LoadRecords()
            Call RoomEnabledFields()
            Call ShowDepartmentTabs()
        End If
        Me.dtpAdmissionDate.MaxDate = Utility.GetServerDate()
        Call EnableFields()
        If enformpurpose = "Newborn" Then
            tabadmission.SelectedTab = tabNewborn
        End If
    End Sub
    Private Sub chkAdmisionStatus()
        If vFilterby = "SubMGH" Or vFilterby = "SubDischarge" Or vFilterby = "SubUntagasMGH" Then
            Dim admission As New clsAdmissiondetails
            Call loadMGH()
            If vFilterby = "SubDischarge" Then
                If fMain.cmbFilterBy.SelectedIndex = 0 Then
                    MsgBox("The transaction cannot be processed due to patient is not tagged as MGH.", vbInformation + MsgBoxStyle.OkOnly, modGlobal.msgboxTitle)
                    Call Dispose()
                    Exit Sub
                End If
            ElseIf vFilterby = "SubMGH" Then
                If admission.isTagtoMGH(AdmissionID) = True Then
                    MsgBox("The transaction cannot be processed due to patient was already tagged as DISCHARGED.", vbInformation + MsgBoxStyle.OkOnly, modGlobal.msgboxTitle)
                    Call Dispose()
                    Exit Sub
                ElseIf fMain.cmbFilterBy.SelectedIndex = 1 Then
                    MsgBox("The transaction cannot be processed due to patient is on MGH state already.", vbInformation + MsgBoxStyle.OkOnly, modGlobal.msgboxTitle)
                    Call Dispose()
                    Exit Sub
                End If
            ElseIf vFilterby = "SubUntagasMGH" Then
                If fMain.cmbFilterBy.SelectedIndex = 0 Then
                    MsgBox("The transaction cannot be processed due to patient is not tagged as MGH.", vbInformation + MsgBoxStyle.OkOnly, modGlobal.msgboxTitle)
                    Call Dispose()
                    Exit Sub
                ElseIf fMain.cmbFilterBy.SelectedIndex = 2 Then
                    MsgBox("The transaction cannot be processed due to patient was on the DISCHARGED state already.", vbInformation + MsgBoxStyle.OkOnly, modGlobal.msgboxTitle)
                    Call Dispose()
                    Exit Sub
                End If

            End If
            EnableField()
            Exit Sub
        End If
    End Sub
    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        isSave = Save()
    End Sub
    Private Sub tsClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsClose.Click
        'Call frmclosed()
        If isSave Or myCurrentFormStatus = enFormStatus.browsing Then
            Me.Close()
        ElseIf MsgBox("Are you sure you want to close this form?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, modGlobal.msgboxTitle) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub btnPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPatient.Click
        Call loadPatient()
        If PatientID <> 0 Then
            SetErrorProvider(Me.btnPatient)
        End If
    End Sub
    Private Sub loadPatient()
        SearchName = "Patient"
        'Dim newAdmission As New clsAdmissiondetails
        Dim fSearchPAtKey As New frmSearchEngine()
        fSearchPAtKey.mModuleName = "Patient"
        fSearchPAtKey.isAdmissionSearch = True
        fSearchPAtKey.Text = "Patient Listing"
        fSearchPAtKey.ShowDialog()
        If fSearchPAtKey.mKey = 0 And fSearchPAtKey.issave = False And lblLastName.Text = "" Then
            Call frmclosed()
            Exit Sub
        ElseIf fSearchPAtKey.mKey = 0 Then
            If lblLastName.Text = "" Then
                Call frmclosed()
                Exit Sub
            Else
                fSearchPAtKey.Close()
                Exit Sub
            End If
        End If
        PatientID = fSearchPAtKey.mKey
        misnewborn = fSearchPAtKey.vIsnewborn
        PatientType = fSearchPAtKey.mAdmissionType
        'If newAdmission.isExist(PatientID, PatientType) = True Then
        '    MsgBox("The patient is currently ACTIVE/ADMITTED.", vbInformation + MessageBoxButtons.OK, modGlobal.msgboxTitle)
        '    Call loadPatient()
        'End If
        Call loadPatient(PatientID)
        'fSearchPAt.Dispose()
        'fSearchPAt.Close()
    End Sub
    Private Sub btnSearchDoctor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearchDoctor.Click
        LoadSearchPhysician()
        'Call lblAdmittingDoctor()
    End Sub
    Public Sub LoadSearchPhysician()
        SearchName = "Physician"
        Dim fSearchDoctor As New frmSearchEngine()
        SearchName = "Physician"
        fSearchDoctor.mModuleName = SearchName '"Physician"
        fSearchDoctor.Text = "Admitting Physician"
        fSearchDoctor.ShowDialog()
        If fSearchDoctor.issave = False Then
            Exit Sub
        End If
        oldAdmittingPhy = fSearchDoctor.mKey
        Docfee = fSearchDoctor.mDocFee

        Call LoadPhysician(oldAdmittingPhy)
    End Sub
    Private Sub btnAttendingPhysician_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAttendingPhysician.Click
        LoadAttendingPhysician()
    End Sub
    Private Sub LoadAttendingPhysician()
        Dim fSearchDoctor As New frmSearchEngine()
        SearchName = "Physician"
        fSearchDoctor.mModuleName = SearchName '"Physician"
        fSearchDoctor.Text = "Attending Physician"
        fSearchDoctor.ShowDialog()
        If fSearchDoctor.issave = False Then
            Exit Sub
        End If
        OldAttendingpHy = fSearchDoctor.mKey
        mAttendingphyCharge = fSearchDoctor.mDocFee
        fSearchDoctor.Text = "Physician"
        Call LoadAttendingPhysician(OldAttendingpHy)
    End Sub
    Private Sub btnSearchRoom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearchRoom.Click
        LoadSearchRoom()
    End Sub
    Private Sub LoadSearchRoom()

        Dim fSearchRoom As New frmSearchEngine()
        SearchName = "Room"
        fSearchRoom.mModuleName = SearchName '"Room"
        fSearchRoom.Text = "Room Listing"
        fSearchRoom.ShowDialog()
        If fSearchRoom.issave = False Then
            Exit Sub
        End If
        sRoomID = fSearchRoom.mKey
        RoomRate = fSearchRoom.mRoomRate

        Call LoadRoom(sRoomID)
    End Sub
    Private Sub chktetanus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktetanus.CheckedChanged
        If chktetanus.Checked = True Then
            grptetanus.Visible = True
        Else
            grptetanus.Visible = False
        End If
    End Sub
    Private Sub chkcontracted_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcontracted.CheckedChanged
        If chkcontracted.Checked = True Then
            grpContracted.Visible = True
        Else
            grpContracted.Visible = False
            Me.txtintlet.Clear()
            Me.txtintlet.Visible = False
            Me.txtmidplane.Clear()
            Me.txtmidplane.Visible = False
            Me.txtoutlet.Clear()
            Me.txtoutlet.Visible = False
        End If
    End Sub
    Private Sub chkinlet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkinlet.CheckedChanged
        If chkinlet.Checked = True Then
            Me.txtintlet.Visible = True
        Else
            Me.txtintlet.Visible = False
            Me.txtintlet.Clear()
        End If
    End Sub
    Private Sub chkmidplane_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkmidplane.CheckedChanged
        If chkmidplane.Checked = True Then
            Me.txtmidplane.Visible = True
        Else
            Me.txtmidplane.Visible = False
            Me.txtmidplane.Clear()
        End If
    End Sub
    Private Sub chkoutlet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkoutlet.CheckedChanged
        If chkoutlet.Checked = True Then
            Me.txtoutlet.Visible = True
        Else
            Me.txtoutlet.Visible = False
            Me.txtoutlet.Clear()
        End If
    End Sub
    Private Sub chkboderline_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkboderline.CheckedChanged
        If chkboderline.Checked = True Then
            Me.chkborderlinetriallabor.Visible = True
        Else
            Me.chkborderlinetriallabor.Visible = False
        End If
    End Sub
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub
    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        dgObgyne.Rows.RemoveAt(dgObgyne.CurrentRow.Index)
    End Sub
    Private Sub btnAddPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        selectImage(Me.pctrPhoto, "Photo")
    End Sub
    'Private Sub cmbDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepartment.SelectedIndexChanged
    '    Call removetabs()
    '    'If cmbDepartment.Focused = True Then
    '    '    If Me.cmbDepartment.SelectedValue = "043" Then
    '    '        Me.tabadmission.Controls.Add(tabObgyne)
    '    '        Me.tabadmission.Controls.Add(tabPogsObtetrical)
    '    '        Me.tabadmission.Controls.Add(tabObsPogs)
    '    '    ElseIf (Me.cmbDepartment.SelectedValue = "038" Or Me.cmbDepartment.SelectedValue = "054") And cmbDepartment.Focused = True Then
    '    '        Me.tabadmission.Controls.Add(tabPediatricClinicalHistory)
    '    '        Me.tabadmission.Controls.Add(tabNewborn)
    '    '    End If
    '    'End If
    '    Call ShowDepartmentTabs()
    'End Sub
    Private Sub cmbHospitalPlanCode_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHospitalPlanCode.SelectedIndexChanged
        If cmbHospitalPlanCode.SelectedValue = 1 Then
            Me.btnAddCase.Visible = False
            Me.btnRemCase.Visible = False
            caseno = 0
            Me.txtAdmittingDiagnosis.Text = ""
        Else
            Me.btnAddCase.Visible = Not False
            Me.btnRemCase.Visible = Not False
            LoadCase(AdmissionID)
        End If
        Call removetabPHIC()
    End Sub
    Private Sub cmbDischargeStat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDischargeStat.SelectedIndexChanged

        If Me.cmbDischargeStat.SelectedValue = "T" Then
            Me.btnAddReasons.Visible = 1
            Me.btnEditReasons.Visible = 1
            Me.lblReasonForRefferal.Visible = True
            Me.cmbReasonForRefferal.Visible = True
            Me.tbHealthCareInstitution.Text = "Referral Health Care Institution"
            Me.tabadmission.Controls.Remove(tbHealthCareInstitution)
            Me.tabadmission.Controls.Add(tbHealthCareInstitution)
        Else
            Me.btnAddReasons.Visible = 0
            Me.btnEditReasons.Visible = 0
            Me.lblReasonForRefferal.Visible = False
            Me.cmbReasonForRefferal.Visible = False
            Me.tabadmission.Controls.Remove(tbHealthCareInstitution)
        End If

        If Me.cmbDischargeStat.SelectedValue = "D" Then
            lblDateofDeath.Visible = True
            dtpDateOfDeath.Visible = True
            dtpTimeOfDeath.Visible = True
        Else
            lblDateofDeath.Visible = False
            dtpDateOfDeath.Visible = False
            dtpTimeOfDeath.Visible = False
        End If
    End Sub
#End Region

#Region "New Methods"
    Private Sub ShowDepartmentTabs()
        Select Case Me.cmbDepartment.SelectedValue
            Case "043", "050", "051", "052", "060"
                '43:                 ONGYNE()
                '50:                 OB(-DELIVERED)
                '51:                 OB(-Not DELIVERED)
                '52:                 OB(-SURGICAL)
                '60:                 GYNECOLOGY()
                Me.tabadmission.Controls.Add(tabObgyne)
                Me.tabadmission.Controls.Add(tabPogsObtetrical)
                Me.tabadmission.Controls.Add(tabObsPogs)
            Case "038", "054", "055"
                'office =Pedia 038 ,newborn 054)
                '055	PEDIATRICS SURGERY
                Me.tabadmission.Controls.Add(tabPediatricClinicalHistory)
                Me.tabadmission.Controls.Add(tabNewborn)
        End Select
    End Sub
    Private Sub LoadImage()
        Me.tsSave.Image = modGlobal.save_icon
        Me.tsPrint.Image = modGlobal.print_icon
        Me.tsCancel.Image = modGlobal.cancel_icon
        Me.tsClose.Image = modGlobal.close_icon
        Me.btnAddHCI.Image = modGlobal.load_item_icon
        Me.btnEditHCI.Image = modGlobal.pencil_icon
        Me.btnAddReasons.Image = modGlobal.load_item_icon
        Me.btnEditReasons.Image = modGlobal.pencil_icon
        Me.btnPatient.Image = modGlobal.search_icon
        Me.btnAddCase.Image = modGlobal.search_icon
        Me.btnRemCase.Image = modGlobal.remove_icon
    End Sub
    Private Sub BlankForm()
        Dim dtAdmission As New DataTable

        Call LoadRoom(0)
        Call LoadAttendingPhysician(0)
        Call LoadPhysician(0)
        'dtAdmission = clsAdmissiondetails.getadmissionid(PtNo, admissiontype)
        Select Case subModule
            Case "Inpatients"
                admissiontype = "IPD"
            Case "Outpatients"
                admissiontype = "OPD"
            Case "Emergency"
                admissiontype = "ER"
        End Select
        dtAdmission = clsAdmissiondetails.gethospptno(admissiontype)
        Dim dtAdmissionid As DataTable = clsAdmissiondetails.getadmissionid()
        Dim dtptno = clsAdmissiondetails.loadAdmission(AdmissionID)
        Dim dtDocRoom As DataTable = clsAdmissiondetails.getDocRoom()


        If subModule = "Inpatients" Or subModule = "NursingServices" Then
            Me.lblAdmissionType.Text = "Inpatient"
        ElseIf subModule = "Outpatients" Then
            Me.lblAdmissionType.Text = "Outpatient"
        ElseIf subModule = "Emergency" Then
            Me.lblAdmissionType.Text = "Emergency"
        End If
        'Me.lblAdmissionType.Text = admissiontype
        If myCurrentFormStatus = enFormStatus.add Then
            Me.lblUfullname.Text = modGlobal.ufullName
        Else
            If dtptno.Rows.Count > 0 Then
                userid = dtptno.Rows(0).Item("encodedby")
                Dim dtEncoderName As DataTable = clsAdmissiondetails.getEncoderName(userid)
                Me.lblUfullname.Text = (dtEncoderName.Rows(0).Item("NurseonDuty"))
            End If

        End If
        If myCurrentFormStatus = enFormStatus.add Then
            vAdmissionID = Utility.NullToZero(dtAdmissionid.Rows(0).Item("admissionid"))
        End If
        If myCurrentFormStatus = enFormStatus.add Or fMain.visAdmit = "SubAdmitPatient" And PtNo = 0 Then

            PtNo = Utility.NullToEmptyString(dtAdmission.Rows(0).Item("ptno"))
        ElseIf myCurrentFormStatus = enFormStatus.edit And Utility.NullToEmptyString(dtptno.Rows(0).Item("ptno")) = "" Then
            PtNo = dtAdmission.Rows(0).Item("ptno")
        End If
        If subModule = "Inpatients" Or subModule = "Emergency" Or subModule = "Outpatients" Then
            If PtNo <> Nothing Then
                Me.lblPatientNo.Text = PtNo
                Me.lblPno.Visible = True
                Me.lblPatientNo.Visible = True
            End If
        End If
    End Sub

    Private Sub RoomEnabledFields()
        Dim dtAdmissions As New DataTable
        Dim vdateadmitted As String
        dtAdmissions = clsAdmissiondetails.loadAdmission(AdmissionID)
        Me.dtpAdmissionDate.Value = dtAdmissions.Rows(0).Item("DateAdmitted")
        vdateadmitted = Me.dtpAdmissionDate.Value.ToShortDateString
        Me.btnPatient.Enabled = False
        If fMain.visAdmit = "SubAdmitPatient" Then
            btnSearchRoom.Enabled = True
            Me.dtpAdmissionDate.Enabled = True
            Me.dtpAdmissionTime.Enabled = True
            'ElseIf vdateadmitted >= Utility.GetServerDate Then
            '    'btnSearchRoom.Enabled = True
            '    Me.dtpAdmissionDate.Enabled = True
            '    Me.dtpAdmissionTime.Enabled = True
            'ElseIf vdateadmitted <> Utility.GetServerDate Then
            '    Me.dtpAdmissionDate.Enabled = False
            '    Me.dtpAdmissionTime.Enabled = True
            'Else
            '    btnSearchRoom.Enabled = False
            '    Me.dtpAdmissionTime.Enabled = True
        End If
    End Sub
    Private Sub SaveRecords()
        Dim newAdmission As New clsAdmissiondetails
        Dim dtRoomRate As New DataTable


        If chkUpdate.Checked = True Then
            If subModule = "Inpatients" Then
                admissiontype = "IPD"
            ElseIf subModule = "Outpatients" Then
                admissiontype = "OPD"
            ElseIf subModule = "Emergency" Then
                admissiontype = "ER"
            End If
            If newAdmission.isPtNoExist(PtNo, admissiontype) = True And chkUpdate.Enabled = False Then
                MsgBox("This record already exists in the database.", vbInformation + MessageBoxButtons.OK, modGlobal.msgboxTitle)
                Exist = True
                Exit Sub
            End If
        End If

        If vFilterby = "SubMGH" Then

            newAdmission.MGHDate = CDate(Me.dtpMGHDate.Value.ToShortDateString & " " & Me.dtpMGHTime.Value.ToLongTimeString)
            newAdmission.AdmissionStatus = 1
            newAdmission.UpdateAdmissionStatus(AdmissionID, True)

            Dim newAdmissionM As New clsAdmission
            newAdmissionM.SaveMghClearance(AdmissionID)
            MsgBox("Patient successfully tagged as May Go Home.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, modGlobal.msgboxTitle)
            isSave = True
            myCurrentFormStatus = enFormStatus.browsing
            EnableField()

            Exit Sub
        ElseIf vFilterby = "SubUntagasMGH" Then
            newAdmission.MGHDate = CDate(Me.dtpMGHDate.Value.ToShortDateString & " " & Me.dtpMGHTime.Value.ToLongTimeString)
            newAdmission.AdmissionStatus = 0
            newAdmission.UpdateAdmissionStatus(AdmissionID, True)
            MsgBox("Patient successfully untagged as May Go Home.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, modGlobal.msgboxTitle)
            isSave = True
            myCurrentFormStatus = enFormStatus.browsing
            EnableField()
            Exit Sub
        ElseIf vFilterby = "SubDischarge" Then
            newAdmission.MGHDate = CDate(Me.dtpMGHDate.Value.ToShortDateString & " " & Me.dtpMGHTime.Value.ToLongTimeString)
            newAdmission.DateDischarge = CDate(Me.dtpDDDate.Value.ToShortDateString & " " & Me.dtpDDTime.Value.ToLongTimeString)
            If Me.cmbDischargeStat.SelectedValue = "D" Then
                newAdmission.DateofDeath = CDate(Me.dtpDateOfDeath.Value.ToShortDateString & " " & Me.dtpTimeOfDeath.Value.ToLongTimeString)
            Else
                newAdmission.DateofDeath = "1/1/1900 12:00:00"
            End If

            newAdmission.ReasonRefferalNo = Me.cmbReasonForRefferal.SelectedValue
            newAdmission.DischargeStatus = Me.cmbDischargeStat.SelectedValue
            newAdmission.AdmissionStatus = 2
            newAdmission.IsDischarge = 1
            newAdmission.mreferralid = Me.cmbreferringHCI.SelectedValue
            newAdmission.referringreason = Me.txtreferringreason.Text
            newAdmission.dischargedbyid = modGlobal.employeeid
            newAdmission.updateRoomStatus(RoomID, True, AdmissionID)
            newAdmission.UpdateAdmissionStatus(AdmissionID, False)
            If Me.cmbDischargeStat.SelectedValue = "D" Then
                newAdmission.updateisActive(PatientID)
            End If
            MsgBox("Patient succesfully tagged as DISCHARGED.", vbInformation + MsgBoxStyle.OkOnly, modGlobal.msgboxTitle)
            isSave = True
            myCurrentFormStatus = enFormStatus.browsing
            EnableField()
            EnableFields()
            Exit Sub
        End If

        If subModule = "Inpatients" Then
            admissiontype = "IPD"
        ElseIf subModule = "Outpatients" Then
            admissiontype = "OPD"
        ElseIf subModule = "Emergency" Then
            admissiontype = "ER"
        End If
        newAdmission.HospitalNo = hospnolen
        newAdmission.PtNo = Val(Me.lblPatientNo.Text)
        newAdmission.Admissionid = vAdmissionID
        newAdmission.isAvailable = "False"
        newAdmission.OldRoomID = RoomID
        newAdmission.mreferringid = Me.cmbreferringHCI.SelectedValue
        newAdmission.referringreason = Me.txtreferringreason.Text
        If sRoomID = 0 Then
            newAdmission.RoomID = RoomID
        Else
            newAdmission.RoomID = sRoomID
        End If
        newAdmission.RoomRate = RoomRate
        'End If
        newAdmission.NoOfDays = 1
        newAdmission.PatientID = Utility.EmptyToZero(Me.txtPatNo.Text)
        newAdmission.DateofAdmin = CDate(Me.dtpAdmissionDate.Value.ToShortDateString & " " & Me.dtpAdmissionTime.Value.ToLongTimeString)
        newAdmission.Notify = Me.txtNotify.Text
        newAdmission.NotifyRelationship = Me.txtNotifyRelationship.Text
        newAdmission.NotifyNo = Me.txtNotifyTelNo.Text
        newAdmission.NotifyAddress = Me.txtNotifyAddress.Text
        newAdmission.Informant = Me.txtInformant.Text
        newAdmission.InformantRelationship = Me.txtInformantRelationship.Text
        newAdmission.AdmissionType = admissiontype
        'If admissiontype = "OPD" Then
        '    newAdmission.AdmissionStatus = 2
        '    newAdmission.IsDischarge = 1
        '    newAdmission.DateDischarge = Utility.GetServerDate
        'Else
        If misAdmitPatient = True Then
            newAdmission.AdmissionStatus = 0
            newAdmission.IsDischarge = 0
            'newAdmission.DateDischarge = "1/1/1900"
        Else
            If status = 0 Then
                newAdmission.AdmissionStatus = 0
                newAdmission.IsDischarge = 0
                'newAdmission.DateDischarge = "1/1/1900"
            ElseIf status = 1 Then
                newAdmission.AdmissionStatus = 1
                newAdmission.IsDischarge = 0
                'newAdmission.DateDischarge = "1/1/1900"
            Else
                newAdmission.AdmissionStatus = 2
                newAdmission.IsDischarge = 1
                'newAdmission.DateDischarge = "1/1/1900"
            End If
        End If
        'End If
        newAdmission.HospitalPlan = Me.cmbHospitalPlanCode.SelectedValue

        newAdmission.OldAdmittingPhysician = Me.DocID
        If oldAdmittingPhy = 0 Then
            newAdmission.AdmittingPhysician = DocID
        Else
            newAdmission.AdmittingPhysician = oldAdmittingPhy
        End If
        newAdmission.OldAttendingPhysician = mAttendingPhysician
        If OldAttendingpHy = 0 Then
            newAdmission.AttendingPhysician = mAttendingPhysician
        Else
            newAdmission.AttendingPhysician = OldAttendingpHy
        End If
        newAdmission.DCharge = Docfee
        newAdmission.PCharge = mAttendingphyCharge
        newAdmission.AdmittingDiagnosis = Me.txtAdmittingDiagnosis.Text
        newAdmission.packagecaseno = caseno
        newAdmission.FinalDiagnosis = " "
        newAdmission.Deposit = ""
        newAdmission.KindOfOperation = ""
        'newAdmission.MemberPHID = 1
        newAdmission.AccreditationNo = ""
        newAdmission.CaseType = "A"
        newAdmission.ChiefComplaints = txtchiefcom.Text
        newAdmission.ReasonForAdmission = ""
        newAdmission.Historyofpresentillness = txtpresentillness.Text
        newAdmission.PhysicalExam = ""
        newAdmission.CourseInTheWards = ""
        newAdmission.PLPDF = ""
        newAdmission.ConditionOnDischarge = ""
        newAdmission.SODateTime = "1/1/1900"
        newAdmission.SOAnesthesiaType = ""
        newAdmission.SOSurgeonName = ""
        newAdmission.SOAnesthesiologist = ""
        newAdmission.Reference = ""
        newAdmission.PhilHealthCaseType = "A"
        newAdmission.StartDAte = Utility.GetServerDate
        newAdmission.EncodedBy = modGlobal.userid
        newAdmission.UpdatedBy = modGlobal.userid
        newAdmission.DateEncoded = Utility.GetServerDate
        newAdmission.ReasonForAdmission = txtreasonforadmission.Text
        newAdmission.AdmittingImpression = Me.txtadmittingimpression.Text
        newAdmission.FamilyHistory = Me.txtfamilyhistory.Text
        newAdmission.PastHistory = Me.txtpasthistory.Text
        newAdmission.PastIllness = Me.txtpastillness.Text
        newAdmission.aBloodPressure = Me.txtBloodPressure.Text
        newAdmission.aDiastolic = Me.txtBPdiastolic.Text
        newAdmission.aBreathing = Me.txtRR.Text
        newAdmission.aPulse = Me.txtCR.Text
        newAdmission.aTemp = Me.txtTemp.Text
        newAdmission.aHeight = Me.txtHeight.Text
        newAdmission.aWeight = Me.txtWeight.Text
        newAdmission.aHeent = Me.txthent.Text
        newAdmission.aChest = Me.txtchest.Text
        newAdmission.aCVs = Me.txtcvs.Text
        newAdmission.aAbdomen = Me.txtabdomen.Text
        newAdmission.aSkinExtrem = Me.txtskin.Text
        newAdmission.aNeuro = Me.txtneuro.Text
        newAdmission.aGU = Me.txtgen.Text
        newAdmission.Officecode = Me.cmbDepartment.SelectedValue
        newAdmission.Gravida = Utility.EmptyToZero(Me.txtgravida.Text)
        newAdmission.Term = Utility.EmptyToZero(Me.txtterm.Text)
        newAdmission.Para = Utility.EmptyToZero(Me.txtpara.Text)
        newAdmission.Premature = Utility.EmptyToZero(Me.txtprematrue.Text)
        newAdmission.Abortion = Utility.EmptyToZero(Me.txtabortion.Text)
        newAdmission.Line = Utility.EmptyToZero(Me.txtline.Text)
        newAdmission.PreviousMenstrualPeriod = Me.dtpmp.Value
        newAdmission.PMPDurationCharacter = Me.txtdurcharpmp.Text
        newAdmission.LastmenstrualPeriod = Me.dtlmp.Value
        newAdmission.LmpDurationCharacter = Me.txtdurcharlmp.Text
        newAdmission.EstimatedDateofConfinement = Me.dtpEDC.Value
        newAdmission.AgeofGestation = Me.txtaog.Text
        newAdmission.Menarche = Me.dtmenarche.Value
        newAdmission.Interval = Utility.EmptyToZero(Me.txtinterval.Text)
        newAdmission.Duration = Me.txtSMDuration.Text
        newAdmission.Amount = Me.txtamount.Text
        newAdmission.Contraception = Me.txtcontraception.Text
        newAdmission.Dysmenorrhea = Me.cmbdysmenorrhea.SelectedValue
        newAdmission.PrenatalCoursePvtmd = IIf(Me.chkspvtmd.Checked, 1, 0)
        newAdmission.PrenatalCourseDHIOPD = IIf(Me.chkdhiopd.Checked, 1, 0)
        newAdmission.PrenatalCourseMidwife = IIf(Me.chkmidwife.Checked, 1, 0)
        newAdmission.PrenatalCourseHilot = IIf(Me.chkhilot.Checked, 1, 0)
        newAdmission.PrenatalCourseHealthCtr = IIf(Me.chkhealtchctr.Checked, 1, 0)
        newAdmission.PrenatalCourseNone = IIf(Me.chknone.Checked, 1, 0)
        newAdmission.FreqofChekUpDoneBy = Me.txtcheckupdoneby.Text
        newAdmission.Complications = Me.txtcomplications.Text
        newAdmission.PrenatalMedsTaken = Me.txtprenatalmedstaken.Text
        newAdmission.ChildhoodDiseases = Me.txtchildhooddisease.Text
        newAdmission.PrevHospitalizations = Me.txtprevhosp.Text
        newAdmission.PrevOperations = Me.txtprevoperations.Text
        newAdmission.MedicalIllness = Me.txtmedillness.Text
        newAdmission.Allergies = Me.txtallergies.Text
        newAdmission.Medications = Me.txtmedications.Text
        newAdmission.FamilyHistoryDM = IIf(Me.chkdm.Checked, 1, 0)
        newAdmission.FamilyHistoryHPN = IIf(Me.chkhpn.Checked, 1, 0)
        newAdmission.FamilyHistoryDse = IIf(Me.chkheartdse.Checked, 1, 0)
        newAdmission.FamilyHistoryPTB = IIf(Me.chkptb.Checked, 1, 0)
        newAdmission.FamilyHistoryCA = IIf(Me.chkca.Checked, 1, 0)
        newAdmission.FamilyHistoryOthers = IIf(Me.chkfamilyhistoryohters.Checked, 1, 0)
        newAdmission.HeadNeck = Me.txtheadneck.Text
        newAdmission.Breasts = Me.txtbreast.Text
        newAdmission.Heart = Me.txtheart.Text
        newAdmission.Lungs = Me.txtlungs.Text
        newAdmission.AbdomenFh = Me.txtabdomenfh.Text
        newAdmission.AbdomenEFW = Me.txtabdomenefw.Text
        newAdmission.AbdomenFHt = Me.txtabdomenfht.Text
        newAdmission.AbdomenFHtCharacter = Me.txtabdomenfhtcharacter.Text
        newAdmission.AbdomenFHtLocation = Me.txtabdomenfhtloacation.Text
        newAdmission.Extremeties = Me.txtextremities.Text
        newAdmission.IEBy = Me.txtieby.Text
        newAdmission.Dilatation = Me.txtdilatation.Text
        newAdmission.Effacement = Me.txteffacement.Text
        newAdmission.Station = Me.txtneurologicstation.Text
        newAdmission.BOW = Me.cmbbow.SelectedValue
        newAdmission.BOWLeakingSince = Utility.EmptyToZero(Me.txtsince.Text)
        newAdmission.PresPart = Me.txtprespart.Text
        newAdmission.CharacterofDischargeMucoid = Me.txtmucoid.Text
        newAdmission.CharacterofDischargeBloody = Me.txtbloody.Text
        newAdmission.CharacterofDischargeColor = Me.txtcolor.Text
        newAdmission.CharacterofDischargeWatery = Me.txtwatery.Text
        newAdmission.CharacterofDischargeOdor = Me.txtodor.Text
        newAdmission.SpeculumExam = Me.txtspeculumexam.Text
        newAdmission.Abnormalities = Me.txtabnormalities.Text
        newAdmission.ClinicalPelvimetryIschialSpines = Me.txtischialspines.Text
        newAdmission.ClinicalPelvimetrySideWalls = Me.txtsidewalls.Text
        newAdmission.ClinicalPelvimetryPubicArch = Me.txtpubicarch.Text
        newAdmission.ClinicalPelvimetrySacrumContour = Me.txtsacrumcontour.Text
        newAdmission.ClinicalPelvimetrySacrosciaticNotch = Me.txtsacrosciaticnotch.Text
        newAdmission.ClinicalPelvimetryIschialTuberosities = Me.txtischialtuberosities.Text
        newAdmission.EPCAdequate = Me.txtadequate.Text
        newAdmission.EPCBorderLine = Me.txtborderline.Text
        newAdmission.EPCNarrow = Me.txtnarrow.Text
        newAdmission.Impression = Me.txtimpression.Text
        newAdmission.MGHDate = Utility.GetServerDate

        newAdmission.PogsGravida = Utility.EmptyToZero(Me.txtpogsgravida.Text)
        newAdmission.Pogspara = Utility.EmptyToZero(Me.txtpogspara.Text)
        newAdmission.Pogsline = Utility.EmptyToZero(Me.txtpogsline.Text)
        newAdmission.Pogspremature = Utility.EmptyToZero(Me.txtpogspremature.Text)
        newAdmission.Pogsabortion = Utility.EmptyToZero(Me.txtpogsabortion.Text)
        newAdmission.Pogsterm = Utility.EmptyToZero(Me.txtpogsterm.Text)
        newAdmission.ContraceptivesHistory = Me.cmbcontraceptivehistory.SelectedValue
        newAdmission.HealthCareProvider = Me.cmbhealthcareprovider.SelectedValue
        newAdmission.PreviousMenstrualPeriod = Me.dtpogspmp.Value
        newAdmission.LastmenstrualPeriod = Me.dtpogslmp.Value
        newAdmission.EstimatedDateofConfinement = Me.dtppogsedc.Value
        newAdmission.AgeofGestation = Me.txtpogsaog.Text
        newAdmission.Menarche = Me.dtpogsmenarche.Value
        newAdmission.DateOfQuickening = Me.dtdateofquickening.Value
        newAdmission.UltrasoundDate = Me.dtultrasounddate.Value
        newAdmission.UltrasoundAOG = Me.txtultrsoundaog.Text
        newAdmission.AdjustedEDC = Me.txtultrasoundadjedc.Text
        newAdmission.ImmunizationsOthers = Me.txtimmunizationsothers.Text
        newAdmission.ImmunizationsTetanus = IIf(Me.chktetanus.Checked, 1, 0)
        newAdmission.ImmunizationsTetanusDoses = Me.txtimmunizationdoses.Text
        newAdmission.ImmunizationsTetanusDate = Me.dtimmunizationsdates.Value
        newAdmission.ImmunizationsHepatitisB = IIf(Me.chkhepatitisb.Checked, 1, 0)
        newAdmission.TotalGainWeight = Me.txttotalwatgain.Text
        newAdmission.BP = Me.txtpogsbp.Text
        newAdmission.HB = Me.txtpogshb.Text
        newAdmission.UrineALB = Me.txturinealb.Text
        newAdmission.Sugar = Me.txtsugar.Text
        newAdmission.AntenatalProblemsMB98ms = IIf(Me.chkmb98.Checked, 1, 0)
        newAdmission.AntenatalProblemsInfectionTracts = IIf(Me.chkinfectionlgtracts.Checked, 1, 0)
        newAdmission.AntenatalProblemsCardiac = IIf(Me.chkcardiac.Checked, 1, 0)
        newAdmission.AntenatalProblemsRespiratory = IIf(Me.chkrepiratory.Checked, 1, 0)
        newAdmission.AntenatalProblemsIUGR = IIf(Me.chkiugr.Checked, 1, 0)
        newAdmission.AntenatalProblemsPrevCSSurgery = IIf(Me.chkcssurgery.Checked, 1, 0)
        newAdmission.AntenatalProblemsNutritional = IIf(Me.chknutritional.Checked, 1, 0)
        newAdmission.AntenatalProblemsRenal = IIf(Me.chkrenal.Checked, 1, 0)
        newAdmission.AntenatalProblemsFetalWastage = IIf(Me.chkfetalwastage.Checked, 1, 0)
        newAdmission.AntenatalProblemsInfertility = IIf(Me.chkinfertility.Checked, 1, 0)
        newAdmission.AntenatalProblemsUTI = IIf(Me.chkuti.Checked, 1, 0)
        newAdmission.AntenatalProblemsHPNPIDCHVD = IIf(Me.chkhpnpidchvd.Checked, 1, 0)
        newAdmission.AntenatalProblemsDMMetabolic = IIf(Me.chkdmmetabolic.Checked, 1, 0)
        newAdmission.AntenatalProblemsPrematureLabor = IIf(Me.chkprematurelabor.Checked, 1, 0)
        newAdmission.AntenatalProblemsOthers = IIf(Me.chkantenatalothers.Checked, 1, 0)
        newAdmission.RiskStatus = Me.cmbriskstatus.SelectedValue
        newAdmission.EENT = Me.txteent.Text
        newAdmission.LevelofSensorium = Me.cmbsensorium.SelectedValue
        newAdmission.GeneralStatus = Me.cmbgeneralstatus.SelectedValue
        newAdmission.ChestHeart = Me.txtchestheart.Text
        newAdmission.ChestLungs = Me.txtchestlungs.Text
        newAdmission.ChestBreast = Me.txtchestbreast.Text
        newAdmission.AbdomenLSK = Me.txtabdomenelsk.Text
        newAdmission.AbdomenFundicHeight = Me.txtfundicht.Text
        newAdmission.Pogsefw = Me.txtefw.Text
        newAdmission.Pogsfht = Me.txtfht.Text
        newAdmission.PrenatalVisits = Me.cmbprenatalvisits.SelectedValue
        newAdmission.AbdomenPresentation = Me.txtpresentation.Text
        newAdmission.AbdomenFloatingEngaged = Me.txtfloatingengaged.Text
        newAdmission.AbdomenOther = Me.txtpogsabdomenothers.Text
        newAdmission.PogsExtremities = Me.txtpogsextremities.Text
        newAdmission.PelvicExamVaginaCervixLength = Me.txtcervixlength.Text
        newAdmission.PogsDilatation = Me.txtpogdilation.Text
        newAdmission.PogsEffacement = Me.txtpogseffacement.Text
        newAdmission.PelvicExamPositionAnt = Me.cmbposition.SelectedValue
        newAdmission.PresentationPosition = Me.txtpogspresentationposition.Text
        newAdmission.PresentationMembranes = Me.cmbmembranes.SelectedValue
        newAdmission.PresentationStation = Me.txtstation.Text
        newAdmission.PresentationAmnioticFld = Me.cmbamnioticfld.SelectedValue
        newAdmission.PresentationSutures = Me.txtsutures.Text
        newAdmission.PelvimetryContracted = IIf(Me.chkcontracted.Checked, 1, 0)
        newAdmission.PelvimetryContractedInlet = IIf(Me.chkinlet.Checked, 1, 0)
        newAdmission.PelvimetryContractedInletTxt = Me.txtintlet.Text
        newAdmission.PelvimetryContractedMidLine = IIf(Me.chkmidplane.Checked, 1, 0)
        newAdmission.PelvimetryContractedMidLineTxt = Me.txtmidplane.Text
        newAdmission.PelvimetryContractedOutlet = IIf(Me.chkoutlet.Checked, 1, 0)
        newAdmission.PelvimetryContractedOutletTxt = Me.txtoutlet.Text
        newAdmission.PelvimetryBorderLine = IIf(Me.chkboderline.Checked, 1, 0)
        newAdmission.PelvimetryBorderLineTrialLabor = IIf(Me.chkborderlinetriallabor.Checked, 1, 0)
        newAdmission.PelvimetryAdequate = IIf(Me.chkspelvimetyadequate.Checked, 1, 0)
        newAdmission.MenstrualCycle1 = Me.txtMenstrualCycle1.Text
        newAdmission.MenstrualCycle2 = Me.txtMenstrualCycle2.Text
        newAdmission.MenstrualCycle3 = Me.txtMenstrualCycle3.Text

        newAdmission.PrenatalInfection = Me.txtinfection.Text
        newAdmission.PrenatalExposureToDrugs = Me.txtexposuretodrugs.Text
        newAdmission.PrenatalSmokingAlcohol = Me.txtsmokingalcohol.Text
        newAdmission.FeedingHistoryBreastFeeding = Me.txtbreastfeeding.Text
        newAdmission.FeedingHistoryMilkFormula = Me.txtmilkformula.Text
        newAdmission.FeedingHistorySupplemental = Me.txtsupplemental.Text
        newAdmission.FeedingHistoryAllergies = Me.txtfeedinghistoryAllergies.Text
        newAdmission.NatalTypeofDelivery = Me.cmbnataltypeofdelivery.SelectedValue
        newAdmission.NatalNSD = Me.txtnsd.Text
        newAdmission.NatalCS = Me.txtcs.Text
        newAdmission.PediaGravida = Utility.EmptyToZero(Me.txg.Text)
        newAdmission.Pediapara = Utility.EmptyToZero(Me.txtp.Text)
        newAdmission.Pediaabortion = Utility.EmptyToZero(Me.txta.Text)
        newAdmission.NatalYO = Me.txtyo.Text
        newAdmission.NatalGestationalAge = Me.txtgestationalage.Text
        newAdmission.NatalBodyWeight = Me.txtbw.Text
        newAdmission.NatalApgarScore = Me.txtapgarscore1.Text
        newAdmission.NatalAnomalies = Me.txtanomolies.Text
        newAdmission.NatalResuscitation = Me.txtresuscitation.Text
        newAdmission.NatalComplication = Me.txtnatalcomplications.Text
        newAdmission.GrowthDevelopmentMotor = Me.txtmotor.Text
        newAdmission.GrowthDevelopmentLanguage = Me.txtlanguage.Text
        newAdmission.GrowthDevelopmentToiletTraining = Me.txttoilettraining.Text
        newAdmission.GrowthDevelopmentSchool = Me.txtschools.Text
        newAdmission.ImmunizationBCG = Me.txtbcg.Text
        newAdmission.ImmunizationDPT = Me.txtdpt.Text
        newAdmission.ImmunizationOPV = Me.txtopv.Text
        newAdmission.ImmunizationBoosterDoses = Me.txtboosterdoses.Text
        newAdmission.ImmunizationMeascles = Me.txtmeascles.Text
        newAdmission.ImmunizationHIB = Me.txthib.Text
        newAdmission.ImmunizationHepatitis = Me.txthipatitis.Text
        newAdmission.alteredmentalsensorium = Me.chkalteredmentalsensorium.Checked
        newAdmission.abdominalcramp_pain = Me.chkabdominalcramp_pain.Checked
        newAdmission.anorexia = Me.chkanorexia.Checked
        newAdmission.bleedinggums = Me.chkbleedinggums.Checked
        newAdmission.bodyweakness = Me.chkbodyweakness.Checked
        newAdmission.blurringofvision = Me.chkblurringofvision.Checked
        newAdmission.constipation = Me.chkconstipation.Checked
        newAdmission.chestpain_discomfort = Me.chkchestpain_discomfort.Checked
        newAdmission.cough_dry = Me.chkcough.Checked
        newAdmission.cough_productive = Me.chkcough.Checked
        newAdmission.diarrhea = Me.chkdiarrhea.Checked
        newAdmission.dizziness = Me.chkdizziness.Checked
        newAdmission.dysphagia = Me.chkdysphagia.Checked
        newAdmission.dyspnea = Me.chkdyspnea.Checked
        newAdmission.dysuria = Me.chkdysuria.Checked
        newAdmission.epistaxis = Me.chkepistaxis.Checked
        newAdmission.fever = Me.chkfever.Checked
        newAdmission.frequencyofurination = Me.chkfrequencyofurination.Checked
        newAdmission.headache = Me.chkheadache.Checked
        newAdmission.hematemesis = Me.chkhematemesis.Checked
        newAdmission.hematuria = Me.chkhematuria.Checked
        newAdmission.hemoptysis = Me.chkhemoptysis.Checked
        newAdmission.increaseirritability = Me.chkincreaseirritability.Checked
        newAdmission.jaundice = Me.chkjaundice.Checked
        newAdmission.lowerextremityedema = Me.chklowerextremityedema.Checked
        newAdmission.myalgia = Me.chkmyalgia.Checked
        newAdmission.orthopnea = Me.chkorthopnea.Checked
        newAdmission.palpitations = Me.chkpalpitations.Checked
        newAdmission.skinrashes = Me.chkskinrashes.Checked
        newAdmission.stool_bloody_blacktarry_mucoid = Me.chkstool_bloody_blacktarry_mucoid.Checked
        newAdmission.sweating = Me.chksweating.Checked
        newAdmission.seizures = Me.chkseizures.Checked
        newAdmission.urgency = Me.chkurgency.Checked
        newAdmission.vomiting = Me.chkvomiting.Checked
        newAdmission.weightloss = Me.chkweightloss.Checked
        newAdmission.others = Me.txtothers.Text
        newAdmission.pain = Me.txtpain.Text
        newAdmission.survey_awakeandalert = Me.chksurvey_awakeandalert.Checked
        newAdmission.survey_alteredsensorium = Me.txtalteredsersorium.Text
        newAdmission.heent_essentiallynormal = Me.chkheent_essentiallynormal.Checked
        newAdmission.heent_abnormalpupillaryreaction = Me.chkheent_abnormalpupillaryreaction.Checked
        newAdmission.heent_cervicallympadenopathy = Me.chkheent_cervicallympadenopathy.Checked
        newAdmission.heent_drymucousmembrane = Me.chkheent_drymucousmembrane.Checked
        newAdmission.heent_ictericsclerae = Me.chkheent_ictericsclerae.Checked
        newAdmission.heent_paleconjunctivae = Me.chkheent_paleconjunctivae.Checked
        newAdmission.heent_sunkeneyeballs = Me.chkheent_sunkeneyeballs.Checked
        newAdmission.heent_sunkenfontanelle = Me.chkheent_sunkenfontanelle.Checked
        newAdmission.chest_essentiallynormal = Me.chkchest_essentiallynormal.Checked
        newAdmission.chest_asymmetricalexpansion = Me.chkchest_asymmetricalexpansion.Checked
        newAdmission.chest_decreasedbreathsounds = Me.chkchest_decreasedbreathsounds.Checked
        newAdmission.chest_wheezes = Me.chkchest_wheezes.Checked
        newAdmission.chest_lumpsoverbreast = Me.chkchest_lumpsoverbreast.Checked
        newAdmission.chest_ralescracklesrhonchi = Me.chkchest_ralescracklesrhonchi.Checked
        newAdmission.chest_intercostalribretraction = Me.chkchest_intercostalribretraction.Checked
        newAdmission.cvs_essentiallynormal = Me.chkcvs_essentiallynormal.Checked
        newAdmission.cvs_displacedapexbeat = Me.chkcvs_displacedapexbeat.Checked
        newAdmission.cvs_heaves = Me.chkcvs_heaves.Checked
        newAdmission.cvs_irregularrhythm = Me.chkcvs_irregularrhythm.Checked
        newAdmission.cvs_muffledheartsounds = Me.chkcvs_muffledheartsounds.Checked
        newAdmission.cvs_murmur = Me.chkcvs_murmur.Checked
        newAdmission.cvs_pericardialbulge = Me.chkcvs_pericardialbulge.Checked
        newAdmission.abdomen_essentiallynormal = Me.chkabdomen_essentiallynormal.Checked
        newAdmission.abdomen_abdominalrigidity = Me.chkabdomen_abdominalrigidity.Checked
        newAdmission.abdomen_abdominaltenderness = Me.chkabdomen_abdominaltenderness.Checked
        newAdmission.abdomen_hyperactivebowelsounds = Me.chkabdomen_hyperactivebowelsounds.Checked
        newAdmission.abdomen_palpablemass = Me.chkabdomen_palpablemass.Checked
        newAdmission.abdomen_tympaniticdullabdomen = Me.chkabdomen_tympaniticdullabdomen.Checked
        newAdmission.abdomen_uterinecontraction = Me.chkabdomen_uterinecontraction.Checked
        newAdmission.gu_essentiallynormal = Me.chkgu_essentiallynormal.Checked
        newAdmission.gu_bloodstainedfinger = Me.chkgu_bloodstainedfinger.Checked
        newAdmission.gu_cervicaldilatation = Me.chkgu_cervicaldilatation.Checked
        newAdmission.gu_presenceofabnormaldischarge = Me.chkgu_presenceofabnormaldischarge.Checked
        newAdmission.skin_essentiallynormal = Me.chkskin_essentiallynormal.Checked
        newAdmission.skin_clubbing = Me.chkskin_clubbing.Checked
        newAdmission.skin_coldclammy = Me.chkskin_coldclammy.Checked
        newAdmission.skin_cyanosis = Me.chkskin_cyanosis.Checked
        newAdmission.skin_edema = Me.chkskin_edema.Checked
        newAdmission.skin_muscles = Me.chkskin_muscles.Checked
        newAdmission.skin_palenailbeds = Me.chkskin_palenailbeds.Checked
        newAdmission.skin_poorskinturgor = Me.chkskin_poorskinturgor.Checked
        newAdmission.skin_rashespetechiae = Me.chkskin_rashespetechiae.Checked
        newAdmission.skin_weakpulses = Me.chkskin_weakpulses.Checked
        newAdmission.neuro_essentiallynormal = Me.chkneuro_essentiallynormal.Checked
        newAdmission.neuro_abnormalgait = Me.chkneuro_abnormalgait.Checked
        newAdmission.neuro_abnormalposition = Me.chkneuro_abnormalposition.Checked
        newAdmission.neuro_abnormalsensation = Me.chkneuro_abnormalsensation.Checked
        newAdmission.neuro_presenceofabnormalreflex = Me.chkneuro_presenceofabnormalreflex.Checked
        newAdmission.neuro_pooralteredmemory = Me.chkneuro_pooralteredmemory.Checked
        newAdmission.neuro_poormuscletone = Me.chkneuro_poormuscletone.Checked
        newAdmission.neuro_poorcoordination = Me.chkneuro_poorcoordination.Checked

        newAdmission.interviewedbyid = Me.interviewedbyid
        If Me.rdambulatory.Checked Then
            newAdmission.conditiononarrival = 1
        ElseIf Me.rdperwheelchair.Checked Then
            newAdmission.conditiononarrival = 2
        ElseIf Me.rdperstretcher.Checked Then
            newAdmission.conditiononarrival = 3
        Else
            newAdmission.conditiononarrival = 0
        End If

        Dim newborn As New clsAdmissionNewborn
        With newborn
            .newborncare = Me.chknewborncare.Checked
            .newbornhearing = Me.chknewbornhearing.Checked
            .newbornscreening = Me.chknewbornscreening.Checked
            .filtercardno = Me.txtfiltercardno.Text
            .immediatedrying = Me.chkndying.Checked
            .weighing = Me.chknweighing.Checked
            .earlyskintoskin = Me.chknearlyskin.Checked
            .timelycordclamping = Me.chkntimelycord.Checked
            .bcgvacination = Me.chknbcg.Checked
            .eyeprophylaxis = Me.chkneyepro.Checked
            .vitkadministration = Me.chknvitk.Checked
            .nonseparationbreatfeeding = Me.chknnoneseparation.Checked
            .hepatitisb = Me.chknhepa.Checked

            .nbsphenykytonuria = Me.chknbsphenykytonuria.Checked
            .nbsG6PD = Me.chknbsG6PD.Checked
            .nbsGalactosemia = Me.chknbsGalactosemia.Checked
            .nbshypothyroidism = Me.chknbshypothyroidism.Checked
            .nbshyperplasia = Me.chknbshyperplasia.Checked
            .newbornshearingresult = Me.cmbnewbornhearingresult.Text
            .newbornshearingregistryno = Me.txtnewbornhearingregno.Text
            .birthlength = Me.txtbirthlength.Text
            .headcirc = Me.txtheadcirc.Text
            .chestcirc = Me.txtchestcirc.Text
            .abdomincirc = Me.txtabdomincirc.Text
            .apgarA1 = Val(Me.txtapgarA1.Text)
            .apgarP1 = Val(Me.txtapgarP1.Text)
            .apgarG1 = Val(Me.txtapgarG1.Text)
            .apgarAC1 = Val(Me.txtapgarAC1.Text)
            .apgarR1 = Val(Me.txtapgarR1.Text)
            .apgarA5 = Val(Me.txtapgarA5.Text)
            .apgarP5 = Val(Me.txtapgarP5.Text)
            .apgarG5 = Val(Me.txtapgarG5.Text)
            .apgarAC5 = Val(Me.txtapgarAC5.Text)
            .apgarR5 = Val(Me.txtapgarR5.Text)
            .apgarscore5 = Val(Me.txtapgarscore5.Text)
        End With


        If admissiontype = "IPD" Or admissiontype = "ER" Or admissiontype = "OPD" Then
            Try
                Dim imageData As Byte() = IO.File.ReadAllBytes(imageName)
                newAdmission.Photo = imageData
            Catch ex As Exception
                newAdmission.Photo = Nothing
            End Try
        End If

        If myCurrentFormStatus = enFormStatus.add Then
            PtNo = newAdmission.Save(True)
            AdmissionID = newAdmission.Admissionid


        Else
            newAdmission.Admissionid = AdmissionID
            newAdmission.Save(False)
        End If

        If imageName <> Nothing Then
            newAdmission.SavePhoto(Me.txtPatNo.Text)
        End If

        If newAdmission.isAdmissionIDExist(AdmissionID) <> True And myCurrentFormStatus = enFormStatus.edit Then
            newAdmission.reSave()

        End If

        If misAdmitPatient = True Then
            PtNo = newAdmission.updateptno(admissiontype)
        End If
        Call LoadObgyne()


        newborn.admissionid = AdmissionID
        newborn.Save()

        isSave = True

        'clsAdmissiondetails.gethospptno(admissiontype)
        misAdmitPatient = False
        myCurrentFormStatus = enFormStatus.browsing
        Call EnableFields()
    End Sub

    Private Sub loadMGH()
        Dim vDstatus As Char
        'Dim PatientID As String
        Dim dtAdmissions As New DataTable
        Dim vPlan As String
        dtAdmissions = clsAdmissiondetails.loadAdmission(AdmissionID)
        Me.lblPatientNo1.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("ptno"))
        PatientID = dtAdmissions.Rows(0).Item("PatientID")
        Me.txtPatNo.Text = PatientID
        RoomID = dtAdmissions.Rows(0).Item("RoomID")

        vPlan = Trim(dtAdmissions.Rows(0).Item("HospitalPlan"))
        If vPlan = 1 Then
            Me.lblHospPlan.Text = "Non-PhilHealth"
        Else
            Me.lblHospPlan.Text = "PhilHealth"
        End If

        vAdmissionID = dtAdmissions.Rows(0).Item("AdmissionID")
        Me.lblAdmissionTime.Text = dtAdmissions.Rows(0).Item("DateAdmitted")
        dateadmitted = dtAdmissions.Rows(0).Item("DateAdmitted")
        If vFilterby = "SubUntagasMGH" Then
            Me.dtpMGHDate.Value = Utility.GetServerDate
            Me.dtpMGHTime.Text = CDate(TimeOfDay)
        ElseIf vFilterby = "SubDischarge" Then
            vDstatus = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("dischargestatus"))
            Me.btnAddReasons.Visible = 0
            Me.btnEditReasons.Visible = 0
            Me.cmbDischargeStat.SelectedValue = Trim(vDstatus)
            If Me.cmbDischargeStat.SelectedValue = "T" Then
                Me.cmbReasonForRefferal.SelectedValue = Utility.NullToZero(dtAdmissions.Rows(0).Item("reasonrefferalno"))
                Me.tbHealthCareInstitution.Text = "Referral Health Care Institution"
            ElseIf Me.cmbDischargeStat.SelectedValue = "D" Then
                Me.dtpDateOfDeath.Value = Utility.NullToCurrentDate(dtAdmissions.Rows(0).Item("DateofDeath"))
                Me.dtpTimeOfDeath.Value = Utility.NullToCurrentDate(dtAdmissions.Rows(0).Item("DateofDeath"))
            ElseIf Me.cmbDischargeStat.SelectedValue = Nothing Then
                Me.cmbDischargeStat.SelectedValue = "I"
            Else

            End If
            Me.dtpMGHDate.Value = Utility.NullToCurrentDate(dtAdmissions.Rows(0).Item("MGHDate"))
            Me.dtpMGHTime.Value = Utility.NullToCurrentDate(dtAdmissions.Rows(0).Item("MGHDate"))
            Me.dtpDDDate.Value = Utility.GetServerDate
            Me.dtpDDTime.Text = CDate(TimeOfDay)
        End If
        Call loadPatient(PatientID)
    End Sub
    Private Sub LoadRecords()

        Dim dtAdmissions As New DataTable
        dtAdmissions = clsAdmissiondetails.loadAdmission(AdmissionID)
        dtfinalbill = clsAdmissiondetails.genericcls(33, AdmissionID)
        PatientID = dtAdmissions.Rows(0).Item("PatientID")
        If PtNo = Nothing Then
            PtNo = Utility.NullToZero(dtAdmissions.Rows(0).Item("ptno"))
            Me.lblPatientNo.Text = PtNo
        End If
        If dtAdmissions.Rows(0).Item("RoomID") = 0 And dtAdmissions.Rows(0).Item("admittingphysicianid") = 0 Then
            Me.lblAdmittingDoctor.Text = ""
            Me.lblroom.Text = ""
        End If
        Me.txtPatNo.Text = PatientID

        Me.cmbHospitalPlanCode.SelectedValue = Trim(dtAdmissions.Rows(0).Item("HospitalPlan"))
        vAdmissionID = dtAdmissions.Rows(0).Item("AdmissionID")
        Me.dtpAdmissionDate.Value = dtAdmissions.Rows(0).Item("DateAdmitted")
        Me.dtpAdmissionTime.Value = dtAdmissions.Rows(0).Item("DateAdmitted")
        dateadmitted = dtAdmissions.Rows(0).Item("DateAdmitted")
        vid = Utility.NullToZero(dtAdmissions.Rows(0).Item("referringhciid"))
        Me.cmbreferringHCI.SelectedValue = vid
        Me.txtreferringreason.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("referringreason"))
        Call LoadHCIInfo()
        Call loadPatient(PatientID)
        Call LoadCase(AdmissionID)
        RoomID = dtAdmissions.Rows(0).Item("RoomID")
        Me.lblroom.Text = RoomID
        Call LoadRoom(RoomID)
        DocID = Utility.NullToZero(dtAdmissions.Rows(0).Item("AdmittingPhysicianID"))
        Me.lblAdmittingDoctor.Text = DocID
        Call LoadPhysician(DocID)
        mAttendingPhysician = Utility.NullToZero(dtAdmissions.Rows(0).Item("AttendingPhysicianID"))
        Me.lblAttendingPhysician.Text = mAttendingPhysician
        Call LoadAttendingPhysician(mAttendingPhysician)
        Me.txtNotify.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Notify"))
        Me.txtNotifyAddress.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("NotifyAddress"))
        Me.txtNotifyTelNo.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("NotifyTelNo"))
        Me.txtNotifyRelationship.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("NotifyRelationship"))
        Me.txtInformant.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Informant"))
        Me.txtInformantRelationship.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("InformantRelationship"))
        Me.txtAdmittingDiagnosis.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("AdmittingDiagnosis"))
        Me.txtreasonforadmission.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("reasonforadmission"))
        Me.txtadmittingimpression.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("admittingimpression"))
        Me.txtfamilyhistory.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("familyhistory"))
        Me.txtpasthistory.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("pasthistory"))
        Me.txtpastillness.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("pastillness"))
        Me.txtchiefcom.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("ChiefComplaints"))
        Me.txtpresentillness.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("historyofpresentillness"))
        Me.txtBloodPressure.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("bloodpressure"))
        Me.txtBPdiastolic.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("bpdiastolic"))
        Me.txtRR.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Breathing"))
        Me.txtCR.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Pulse"))
        Me.txtTemp.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Temperature"))
        Me.txtHeight.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Height"))
        Me.txtWeight.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Weight"))
        Me.txthent.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Heent"))
        Me.txtchest.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Chest"))
        Me.txtcvs.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("CVs"))
        Me.txtabdomen.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Abdomen"))
        Me.txtskin.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("SkinExtremities"))
        Me.txtneuro.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("NeuroExamination"))
        Me.txtgen.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("GU"))

        Me.chkalteredmentalsensorium.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("alteredmentalsensorium"))
        Me.chkabdominalcramp_pain.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("abdominalcramp_pain"))
        Me.chkanorexia.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("anorexia"))
        Me.chkbleedinggums.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("bleedinggums"))
        Me.chkbodyweakness.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("bodyweakness"))
        Me.chkblurringofvision.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("blurringofvision"))
        Me.chkconstipation.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("constipation"))
        Me.chkchestpain_discomfort.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("chestpain_discomfort"))
        Me.chkcough.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("cough_dry"))
        Me.chkdiarrhea.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("diarrhea"))
        Me.chkdizziness.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("dizziness"))
        Me.chkdysphagia.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("dysphagia"))
        Me.chkdyspnea.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("dyspnea"))
        Me.chkdysuria.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("dysuria"))
        Me.chkepistaxis.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("epistaxis"))
        Me.chkfever.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("fever"))
        Me.chkfrequencyofurination.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("frequencyofurination"))
        Me.chkheadache.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("headache"))
        Me.chkhematemesis.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("hematemesis"))
        Me.chkhematuria.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("hematuria"))
        Me.chkhemoptysis.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("hemoptysis"))
        Me.chkincreaseirritability.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("increaseirritability"))
        Me.chkjaundice.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("jaundice"))
        Me.chklowerextremityedema.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("lowerextremityedema"))
        Me.chkmyalgia.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("myalgia"))
        Me.chkorthopnea.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("orthopnea"))
        Me.chkpalpitations.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("palpitations"))
        Me.chkskinrashes.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("skinrashes"))
        Me.chkstool_bloody_blacktarry_mucoid.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("stool_bloody_blacktarry_mucoid"))
        Me.chksweating.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("sweating"))
        Me.chkseizures.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("seizures"))
        Me.chkurgency.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("urgency"))
        Me.chkvomiting.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("vomiting"))
        Me.chkweightloss.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("weightloss"))
        Me.txtothers.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("others"))
        Me.txtpain.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("pain"))
        Me.chkPain.Checked = Not Me.txtpain.Text = ""
        Me.chkothers.Checked = Not Me.txtothers.Text = ""
        Me.chksurvey_awakeandalert.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("survey_awakeandalert"))
        Me.txtalteredsersorium.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("survey_alteredsensorium"))
        Me.chksurvey_alteredsensorium.Checked = Not Me.txtalteredsersorium.Text = ""
        Me.chkheent_essentiallynormal.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("heent_essentiallynormal"))
        Me.chkheent_abnormalpupillaryreaction.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("heent_abnormalpupillaryreaction"))
        Me.chkheent_cervicallympadenopathy.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("heent_cervicallympadenopathy"))
        Me.chkheent_drymucousmembrane.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("heent_drymucousmembrane"))
        Me.chkheent_ictericsclerae.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("heent_ictericsclerae"))
        Me.chkheent_paleconjunctivae.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("heent_paleconjunctivae"))
        Me.chkheent_sunkeneyeballs.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("heent_sunkeneyeballs"))
        Me.chkheent_sunkenfontanelle.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("heent_sunkenfontanelle"))
        Me.chkchest_essentiallynormal.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("chest_essentiallynormal"))
        Me.chkchest_asymmetricalexpansion.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("chest_asymmetricalexpansion"))
        Me.chkchest_decreasedbreathsounds.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("chest_decreasedbreathsounds"))
        Me.chkchest_wheezes.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("chest_wheezes"))
        Me.chkchest_lumpsoverbreast.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("chest_lumpsoverbreast"))
        Me.chkchest_ralescracklesrhonchi.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("chest_ralescracklesrhonchi"))
        Me.chkchest_intercostalribretraction.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("chest_intercostalribretraction"))
        Me.chkcvs_essentiallynormal.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("cvs_essentiallynormal"))
        Me.chkcvs_displacedapexbeat.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("cvs_displacedapexbeat"))
        Me.chkcvs_heaves.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("cvs_heaves"))
        Me.chkcvs_irregularrhythm.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("cvs_irregularrhythm"))
        Me.chkcvs_muffledheartsounds.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("cvs_muffledheartsounds"))
        Me.chkcvs_murmur.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("cvs_murmur"))
        Me.chkcvs_pericardialbulge.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("cvs_pericardialbulge"))
        Me.chkabdomen_essentiallynormal.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("abdomen_essentiallynormal"))
        Me.chkabdomen_abdominalrigidity.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("abdomen_abdominalrigidity"))
        Me.chkabdomen_abdominaltenderness.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("abdomen_abdominaltenderness"))
        Me.chkabdomen_hyperactivebowelsounds.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("abdomen_hyperactivebowelsounds"))
        Me.chkabdomen_palpablemass.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("abdomen_palpablemass"))
        Me.chkabdomen_tympaniticdullabdomen.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("abdomen_tympaniticdullabdomen"))
        Me.chkabdomen_uterinecontraction.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("abdomen_uterinecontraction"))
        Me.chkgu_essentiallynormal.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("gu_essentiallynormal"))
        Me.chkgu_bloodstainedfinger.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("gu_bloodstainedfinger"))
        Me.chkgu_cervicaldilatation.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("gu_cervicaldilatation"))
        Me.chkgu_presenceofabnormaldischarge.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("gu_presenceofabnormaldischarge"))
        Me.chkskin_essentiallynormal.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("skin_essentiallynormal"))
        Me.chkskin_clubbing.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("skin_clubbing"))
        Me.chkskin_coldclammy.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("skin_coldclammy"))
        Me.chkskin_cyanosis.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("skin_cyanosis"))
        Me.chkskin_edema.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("skin_edema"))
        Me.chkskin_muscles.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("skin_muscles"))
        Me.chkskin_palenailbeds.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("skin_palenailbeds"))
        Me.chkskin_poorskinturgor.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("skin_poorskinturgor"))
        Me.chkskin_rashespetechiae.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("skin_rashespetechiae"))
        Me.chkskin_weakpulses.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("skin_weakpulses"))
        Me.chkneuro_essentiallynormal.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("neuro_essentiallynormal"))
        Me.chkneuro_abnormalgait.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("neuro_abnormalgait"))
        Me.chkneuro_abnormalposition.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("neuro_abnormalposition"))
        Me.chkneuro_abnormalsensation.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("neuro_abnormalsensation"))
        Me.chkneuro_presenceofabnormalreflex.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("neuro_presenceofabnormalreflex"))
        Me.chkneuro_pooralteredmemory.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("neuro_pooralteredmemory"))
        Me.chkneuro_poormuscletone.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("neuro_poormuscletone"))
        Me.chkneuro_poorcoordination.Checked = Utility.NullToBoolean(dtAdmissions.Rows(0).Item("neuro_poorcoordination"))

        vDepartmentcode = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("OfficeCode"))
        If vDepartmentcode = "" Then
            Me.cmbDepartment.SelectedValue = "037"
        Else
            Me.cmbDepartment.SelectedValue = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("OfficeCode"))
        End If

        Me.txtgravida.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Gravida"))
        Me.txtterm.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Term"))
        Me.txtpara.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Para"))
        Me.txtprematrue.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Premature"))
        Me.txtabortion.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("abortion"))
        Me.txtline.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Line"))
        Me.dtpmp.Value = Utility.NullToCurrentDate(dtAdmissions.Rows(0).Item("PreviousMenstrualPeriod"))
        Me.txtdurcharpmp.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PMPDurationCharacter"))
        Me.dtlmp.Value = Utility.NullToCurrentDate(dtAdmissions.Rows(0).Item("LastMenstrualPeriod"))
        Me.txtdurcharlmp.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("LmpDurationCharacter"))
        Me.dtpEDC.Value = Utility.NullToCurrentDate(dtAdmissions.Rows(0).Item("EstimatedDateofConfinement"))
        Me.txtaog.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("AgeofGestation"))
        Me.dtmenarche.Value = Utility.NullToCurrentDate(dtAdmissions.Rows(0).Item("Menarche"))
        Me.txtinterval.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Interval"))
        Me.txtSMDuration.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Duration"))
        Me.txtamount.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Amount"))
        Me.txtcontraception.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Contraception"))
        Me.cmbdysmenorrhea.SelectedValue = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Dysmenorrhea"))
        Me.chkspvtmd.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("PrenatalCoursePvtmd"))
        Me.chkdhiopd.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("PrenatalCourseDHIOPD"))
        Me.chkmidwife.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("Midwife"))
        Me.chkhilot.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("Hilot"))
        Me.chkhealtchctr.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("PrenatalCourseHealthCtr"))
        Me.chknone.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("None"))
        Me.txtcheckupdoneby.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("FreqofCheckUpDoneBy"))
        Me.txtcomplications.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Complications"))
        Me.txtprenatalmedstaken.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PrenatalMedsTaken"))
        Me.txtchildhooddisease.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("ChildhoodDiseases"))
        Me.txtprevhosp.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PreviousHospitalizations"))
        Me.txtprevoperations.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PreviousOperations"))
        Me.txtmedillness.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("MedicalIllness"))
        Me.txtallergies.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Allergies"))
        Me.txtmedications.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Medications"))
        Me.chkdm.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("FamilyHistoryDM"))
        Me.chkhpn.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("FamilyHistoryHPN"))
        Me.chkheartdse.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("FamilyHistoryHeartDse"))
        Me.chkptb.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("FamilyHistoryPTB"))
        Me.chkca.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("FamilyHistoryCA"))
        Me.chkfamilyhistoryohters.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("FamilyHistoryOthers"))
        Me.txtheadneck.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("HeadNeck"))
        Me.txtbreast.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Breasts"))
        Me.txtheart.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Heart"))
        Me.txtlungs.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Lungs"))
        Me.txtabdomenfh.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("AbdomenFh"))
        Me.txtabdomenefw.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("AbdomenEFW"))
        Me.txtabdomenfht.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("AbdomenFHt"))
        Me.txtabdomenfhtcharacter.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("AbdomenFHtCharacter"))
        Me.txtabdomenfhtloacation.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("AbdomenFHtLocation"))
        Me.txtextremities.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Extremeties"))
        Me.txtieby.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("IEBy"))
        Me.txtdilatation.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Dilatation"))
        Me.txteffacement.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Effacement"))
        Me.txtneurologicstation.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Station"))
        Me.cmbbow.SelectedValue = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("BOW"))
        Me.txtsince.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("BOWLeakingSince"))
        Me.txtprespart.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PresPart"))
        Me.txtmucoid.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("CharacterofDischargeMucoid"))
        Me.txtbloody.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("CharacterofDischargeBloody"))
        Me.txtcolor.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("CharacterofDischargeColor"))
        Me.txtwatery.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("CharacterofDischargeWatery"))
        Me.txtodor.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("CharacterofDischargeOdor"))
        Me.txtspeculumexam.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("SpeculumExam"))
        Me.txtabnormalities.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Abnormalities"))
        Me.txtischialspines.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("ClinicalPelvimetryIschialSpines"))
        Me.txtsidewalls.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("ClinicalPelvimetrySideWalls"))
        Me.txtpubicarch.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("ClinicalPelvimetryPubicArch"))
        Me.txtsacrumcontour.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("ClinicalPelvimetrySacrumContour"))
        Me.txtsacrosciaticnotch.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("ClinicalPelvimetrySacrosciaticNotch"))
        Me.txtischialtuberosities.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("ClinicalPelvimetryIschialTuberosities"))
        Me.txtadequate.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("EPCAdequate"))
        Me.txtborderline.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("EPCBorderLine"))
        Me.txtnarrow.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("EPCNarrow"))
        Me.txtimpression.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Impression"))

        Me.txtpogsgravida.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PogsGravida"))
        Me.txtpogspara.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PogsPara"))
        Me.txtpogsline.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PogsLine"))
        Me.txtpogspremature.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PogsPremature"))
        Me.txtpogsabortion.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PogsAbortion"))
        Me.txtpogsterm.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PogsTerm"))
        Me.cmbcontraceptivehistory.SelectedValue = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("ContraceptivesHistory"))
        Me.cmbhealthcareprovider.SelectedValue = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("HealthCareProvider"))
        Me.dtpogspmp.Value = Utility.NullToCurrentDate(dtAdmissions.Rows(0).Item("PreviousMenstrualPeriod"))
        Me.dtpogslmp.Value = Utility.NullToCurrentDate(dtAdmissions.Rows(0).Item("LastmenstrualPeriod"))
        Me.dtppogsedc.Value = Utility.NullToCurrentDate(dtAdmissions.Rows(0).Item("EstimatedDateofConfinement"))
        Me.txtpogsaog.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("AgeofGestation"))
        Me.dtpogsmenarche.Value = Utility.NullToCurrentDate(dtAdmissions.Rows(0).Item("Menarche"))
        Me.dtdateofquickening.Value = Utility.NullToCurrentDate(dtAdmissions.Rows(0).Item("DateOfQuickening"))
        Me.dtultrasounddate.Value = Utility.NullToCurrentDate(dtAdmissions.Rows(0).Item("UltrasoundDate"))
        Me.txtultrsoundaog.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("UltrasoundAOG"))
        Me.txtultrasoundadjedc.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("AdjustedEDC"))
        Me.txtimmunizationsothers.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("ImmunizationsOthers"))
        Me.chktetanus.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("ImmunizationsTetanus"))
        Me.txtimmunizationdoses.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("ImmunizationsTetanusDoses"))
        Me.dtimmunizationsdates.Value = Utility.NullToCurrentDate(dtAdmissions.Rows(0).Item("ImmunizationsTetanusDate"))
        Me.chkhepatitisb.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("ImmunizationsHepatitisB"))
        Me.txttotalwatgain.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("TotalGainWeight"))
        Me.txtpogsbp.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("BP"))
        Me.txtpogshb.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("HB"))
        Me.txturinealb.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("UrineALB"))
        Me.txtsugar.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("Sugar"))
        Me.chkmb98.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("AntenatalProblemsMB98ms"))
        Me.chkinfectionlgtracts.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("AntenatalProblemsInfectionTracts"))
        Me.chkcardiac.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("AntenatalProblemsCardiac"))
        Me.chkrepiratory.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("AntenatalProblemsRespiratory"))
        Me.chkiugr.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("AntenatalProblemsIUGR"))
        Me.chkcssurgery.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("AntenatalProblemsPrevCSSurgery"))
        Me.chknutritional.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("AntenatalProblemsNutritional"))
        Me.chkrenal.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("AntenatalProblemsRenal"))
        Me.chkfetalwastage.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("AntenatalProblemsFetalWastage"))
        Me.chkinfertility.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("AntenatalProblemsInfertility"))
        Me.chkuti.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("AntenatalProblemsUTI"))
        Me.chkhpnpidchvd.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("AntenatalProblemsHPNPIDCHVD"))
        Me.chkdmmetabolic.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("AntenatalProblemsDMMetabolic"))
        Me.chkprematurelabor.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("AntenatalProblemsPrematureLabor"))
        Me.chkantenatalothers.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("AntenatalProblemsOthers"))
        Me.cmbriskstatus.SelectedValue = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("RiskStatus"))
        Me.txteent.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("EENT"))
        Me.cmbsensorium.SelectedValue = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("LevelofSensorium"))
        Me.cmbgeneralstatus.SelectedValue = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("GeneralStatus"))
        Me.txtchestheart.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("ChestHeart"))
        Me.txtchestlungs.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("ChestLungs"))
        Me.txtchestbreast.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("ChestBreast"))
        Me.txtabdomenelsk.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("AbdomenLSK"))
        Me.txtfundicht.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("AbdomenFundicHeight"))
        Me.txtefw.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("pogsEFW"))
        Me.txtfht.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("pogsFHt"))
        Me.txtpresentation.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("AbdomenPresentation"))
        Me.txtfloatingengaged.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("AbdomenFloatingEngaged"))
        Me.txtpogsabdomenothers.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("AbdomenOther"))
        Me.txtpogsextremities.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PogsExtremities"))
        Me.txtcervixlength.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PelvicExamVaginaCervixLength"))
        Me.txtpogdilation.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("pogsDilatation"))
        Me.txtpogseffacement.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("pogsEffacement"))
        Me.cmbposition.SelectedValue = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("pelvicexampositionant"))
        Me.cmbprenatalvisits.SelectedValue = Trim(Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PrenatalVisits")))
        Me.txtpogspresentationposition.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PresentationPosition"))
        Me.cmbmembranes.SelectedValue = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PresentationMembranes"))
        Me.txtstation.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PresentationStation"))
        Me.cmbamnioticfld.SelectedValue = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PresentationAmnioticFld"))
        Me.txtsutures.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PresentationSutures"))
        Me.chkcontracted.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("PelvimetryContracted"))
        Me.chkinlet.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("PelvimetryContractedInlet"))
        Me.txtintlet.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PelvimetryContractedInletTxt"))
        Me.chkmidplane.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("PelvimetryContractedMidLine"))
        Me.txtmidplane.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PelvimetryContractedMidLineTxt"))
        Me.chkoutlet.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("PelvimetryContractedOutlet"))
        Me.txtoutlet.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PelvimetryContractedOutletTxt"))
        Me.chkboderline.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("PelvimetryBorderLine"))
        Me.chkborderlinetriallabor.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("PelvimetryBorderLineTrialLabor"))
        Me.chkspelvimetyadequate.Checked = Utility.NullToZero(dtAdmissions.Rows(0).Item("PelvimetryAdequate"))
        Me.txtMenstrualCycle1.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("MenstrualCycle1"))
        Me.txtMenstrualCycle2.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("MenstrualCycle2"))
        Me.txtMenstrualCycle3.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("MenstrualCycle3"))

        Me.txtinfection.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PrenatalInfection"))
        Me.txtexposuretodrugs.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PrenatalExposureToDrugs"))
        Me.txtsmokingalcohol.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PrenatalSmokingAlcohol"))
        Me.txtbreastfeeding.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("FeedingHistoryBreastFeeding"))
        Me.txtmilkformula.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("FeedingHistoryMilkFormula"))
        Me.txtsupplemental.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("FeedingHistorySupplemental"))
        Me.txtfeedinghistoryAllergies.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("FeedingHistoryAllergies"))
        Me.cmbnataltypeofdelivery.SelectedValue = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("NatalTypeofDelivery"))
        Me.txtnsd.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("NatalNSD"))
        Me.txtcs.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("NatalCS"))
        Me.txg.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PediaGravida"))
        Me.txtp.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PediaPara"))
        Me.txta.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("PediaAbortion"))
        Me.txtyo.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("NatalYO"))
        Me.txtgestationalage.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("NatalGestationalAge"))
        Me.txtbw.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("NatalBodyWeight"))
        Me.txtapgarscore1.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("NatalApgarScore"))
        Me.txtanomolies.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("NatalAnomalies"))
        Me.txtresuscitation.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("NatalResuscitation"))
        Me.txtnatalcomplications.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("NatalComplication"))
        Me.txtmotor.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("GrowthDevelopmentMotor"))
        Me.txtlanguage.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("GrowthDevelopmentLanguage"))
        Me.txttoilettraining.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("GrowthDevelopmentToiletTraining"))
        Me.txtschools.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("GrowthDevelopmentSchool"))
        Me.txtbcg.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("ImmunizationBCG"))
        Me.txtdpt.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("ImmunizationDPT"))
        Me.txtopv.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("ImmunizationOPV"))
        Me.txtboosterdoses.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("ImmunizationBoosterDoses"))
        Me.txtmeascles.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("ImmunizationMeascles"))
        Me.txthib.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("ImmunizationHIB"))
        Me.txthipatitis.Text = Utility.NullToEmptyString(dtAdmissions.Rows(0).Item("ImmunizationHepatitis"))

        Me.interviewedbyid = Utility.NullToZero(dtAdmissions.Rows(0).Item("interviewedbyid"))
        Call LoadInterviewedBy(Me.interviewedbyid)

        If Utility.NullToZero(dtAdmissions.Rows(0).Item("conditiononarrival")) = 1 Then
            Me.rdambulatory.Checked = True
        ElseIf Utility.NullToZero(dtAdmissions.Rows(0).Item("conditiononarrival")) = 2 Then
            Me.rdperwheelchair.Checked = True
        ElseIf Utility.NullToZero(dtAdmissions.Rows(0).Item("conditiononarrival")) = 3 Then
            Me.rdperstretcher.Checked = True
        End If
        Call loadAdmissionNewborn()
        If PtNo <> Nothing Then
            Call loadtoGrid(PtNo)
        End If
    End Sub
    Private Sub loadAdmissionNewborn()
        Dim newborn As New clsAdmissionNewborn

        With newborn
            .admissionid = AdmissionID
            .getNewborn()
            Me.chknewborncare.Checked = .newborncare
            Me.chknewbornhearing.Checked = .newbornhearing
            Me.chknewbornscreening.Checked = .newbornscreening
            Me.txtfiltercardno.Text = .filtercardno
            Me.chkndying.Checked = .immediatedrying
            Me.chknweighing.Checked = .weighing
            Me.chknearlyskin.Checked = .earlyskintoskin
            Me.chkntimelycord.Checked = .timelycordclamping
            Me.chknbcg.Checked = .bcgvacination
            Me.chkneyepro.Checked = .eyeprophylaxis
            Me.chknvitk.Checked = .vitkadministration
            Me.chknnoneseparation.Checked = .nonseparationbreatfeeding
            Me.chknhepa.Checked = .hepatitisb

            Me.chknbsphenykytonuria.Checked = .nbsphenykytonuria
            Me.chknbsG6PD.Checked = .nbsG6PD
            Me.chknbsGalactosemia.Checked = .nbsGalactosemia
            Me.chknbshypothyroidism.Checked = .nbshypothyroidism
            Me.chknbshyperplasia.Checked = .nbshyperplasia
            Me.cmbnewbornhearingresult.SelectedValue = .newbornshearingresult
            Me.txtnewbornhearingregno.Text = .newbornshearingregistryno
            Me.txtbirthlength.Text = .birthlength
            Me.txtheadcirc.Text = .headcirc
            Me.txtchestcirc.Text = .chestcirc
            Me.txtabdomincirc.Text = .abdomincirc
            Me.txtapgarA1.Text = .apgarA1
            Me.txtapgarP1.Text = .apgarP1
            Me.txtapgarG1.Text = .apgarG1
            Me.txtapgarAC1.Text = .apgarAC1
            Me.txtapgarR1.Text = .apgarR1
            Me.txtapgarA5.Text = .apgarA5
            Me.txtapgarP5.Text = .apgarP5
            Me.txtapgarG5.Text = .apgarG5
            Me.txtapgarAC5.Text = .apgarAC5
            Me.txtapgarR5.Text = .apgarR5
            Me.txtapgarscore5.Text = .apgarscore5

        End With
    End Sub
    Public Sub LoadDischargeData()
        'Me.cmbDischargeStat.Items.Add(New DictionaryEntry("Recovered/Improved", "R"))
        'Me.cmbDischargeStat.Items.Add(New DictionaryEntry("Transferred", "T"))
        'Me.cmbDischargeStat.Items.Add(New DictionaryEntry("Unimproved", "U"))
        'Me.cmbDischargeStat.Items.Add(New DictionaryEntry("Home Against Medical Advice", "H"))
        'Me.cmbDischargeStat.Items.Add(New DictionaryEntry("Absconded", "A"))
        'Me.cmbDischargeStat.Items.Add(New DictionaryEntry("Died", "D"))


        Me.cmbDischargeStat.Items.Add(New DictionaryEntry("Improved", "I"))
        Me.cmbDischargeStat.Items.Add(New DictionaryEntry("Recovered", "R"))
        Me.cmbDischargeStat.Items.Add(New DictionaryEntry("Home/Discharge Against Medical Advice", "H"))
        Me.cmbDischargeStat.Items.Add(New DictionaryEntry("Absconded", "A"))
        Me.cmbDischargeStat.Items.Add(New DictionaryEntry("Expired", "D"))
        Me.cmbDischargeStat.Items.Add(New DictionaryEntry("Transferred", "T"))


        Me.cmbDischargeStat.DisplayMember = "Key"
        Me.cmbDischargeStat.ValueMember = "Value"
        Me.cmbDischargeStat.DataSource = Me.cmbDischargeStat.Items
        Me.cmbDischargeStat.SelectedIndex = 0
        vdischargestat = cmbDischargeStat.SelectedIndex
    End Sub
    Private Sub LoadReasonsforRefferal()
        Me.cmbReasonForRefferal.DataSource = clsAdmissiondetails.getRefferalNo()
        Me.cmbReasonForRefferal.DisplayMember = "description"
        Me.cmbReasonForRefferal.ValueMember = "reasonrefferalno"
    End Sub
    Private Sub LoadToCombox()
        Me.cmbHospitalPlanCode.Items.Add(New DictionaryEntry("Non-PhilHealth", "1"))
        Me.cmbHospitalPlanCode.Items.Add(New DictionaryEntry("PhilHealth", "2"))

        Me.cmbHospitalPlanCode.DisplayMember = "Key"
        Me.cmbHospitalPlanCode.ValueMember = "Value"
        Me.cmbHospitalPlanCode.DataSource = Me.cmbHospitalPlanCode.Items

        Me.cmbdysmenorrhea.Items.Add(New DictionaryEntry("+", "Pos"))
        Me.cmbdysmenorrhea.Items.Add(New DictionaryEntry("-", "Neg"))
        Me.cmbdysmenorrhea.Items.Add(New DictionaryEntry("Occassional", "Occ"))

        Me.cmbdysmenorrhea.DisplayMember = "Key"
        Me.cmbdysmenorrhea.ValueMember = "Value"
        Me.cmbdysmenorrhea.DataSource = Me.cmbdysmenorrhea.Items

        Me.cmbbow.Items.Add(New DictionaryEntry("+", "Pos"))
        Me.cmbbow.Items.Add(New DictionaryEntry("-", "Neg"))
        Me.cmbbow.Items.Add(New DictionaryEntry("Leaking", "Leak"))

        Me.cmbbow.DisplayMember = "Key"
        Me.cmbbow.ValueMember = "Value"
        Me.cmbbow.DataSource = Me.cmbbow.Items

        Me.cmbcontraceptivehistory.Items.Add(New DictionaryEntry("None", "None"))
        Me.cmbcontraceptivehistory.Items.Add(New DictionaryEntry("Pills", "Pills"))
        Me.cmbcontraceptivehistory.Items.Add(New DictionaryEntry("IUD", "IUD"))
        Me.cmbcontraceptivehistory.Items.Add(New DictionaryEntry("Rhythm", "Rhythm"))
        Me.cmbcontraceptivehistory.Items.Add(New DictionaryEntry("Condom", "Condom"))
        Me.cmbcontraceptivehistory.Items.Add(New DictionaryEntry("Others", "Others"))

        Me.cmbcontraceptivehistory.DisplayMember = "Key"
        Me.cmbcontraceptivehistory.ValueMember = "Value"
        Me.cmbcontraceptivehistory.DataSource = Me.cmbcontraceptivehistory.Items

        Me.cmbhealthcareprovider.Items.Add(New DictionaryEntry("MOH-DOH-SO", "MDS"))
        Me.cmbhealthcareprovider.Items.Add(New DictionaryEntry("MD", "MD"))
        Me.cmbhealthcareprovider.Items.Add(New DictionaryEntry("MW", "MW"))
        Me.cmbhealthcareprovider.Items.Add(New DictionaryEntry("Others", "Others"))

        Me.cmbhealthcareprovider.DisplayMember = "Key"
        Me.cmbhealthcareprovider.ValueMember = "Value"
        Me.cmbhealthcareprovider.DataSource = Me.cmbhealthcareprovider.Items

        Me.cmbprenatalvisits.Items.Add(New DictionaryEntry("None", "0"))
        Me.cmbprenatalvisits.Items.Add(New DictionaryEntry("1-2", "1"))
        Me.cmbprenatalvisits.Items.Add(New DictionaryEntry("2-5", "2"))
        Me.cmbprenatalvisits.Items.Add(New DictionaryEntry("5", "5"))

        Me.cmbprenatalvisits.DisplayMember = "Key"
        Me.cmbprenatalvisits.ValueMember = "Value"
        Me.cmbprenatalvisits.DataSource = Me.cmbprenatalvisits.Items

        Me.cmbsensorium.Items.Add(New DictionaryEntry("Unconcious", "Unconcious"))
        Me.cmbsensorium.Items.Add(New DictionaryEntry("Cooperative", "Cooperative"))

        Me.cmbsensorium.DisplayMember = "Key"
        Me.cmbsensorium.ValueMember = "Value"
        Me.cmbsensorium.DataSource = Me.cmbsensorium.Items

        Me.cmbgeneralstatus.Items.Add(New DictionaryEntry("Concious", "Concious"))
        Me.cmbgeneralstatus.Items.Add(New DictionaryEntry("Coherent", "Coherent"))
        Me.cmbgeneralstatus.Items.Add(New DictionaryEntry("Distressed", "Distressed"))
        Me.cmbgeneralstatus.Items.Add(New DictionaryEntry("Anxious", "Anxious"))
        Me.cmbgeneralstatus.Items.Add(New DictionaryEntry("Pale/Flushed", "PF"))
        Me.cmbgeneralstatus.Items.Add(New DictionaryEntry("Others", "Others"))

        Me.cmbgeneralstatus.DisplayMember = "Key"
        Me.cmbgeneralstatus.ValueMember = "Value"
        Me.cmbgeneralstatus.DataSource = Me.cmbgeneralstatus.Items

        Me.cmbriskstatus.Items.Add(New DictionaryEntry("Low", "L"))
        Me.cmbriskstatus.Items.Add(New DictionaryEntry("High", "H"))

        Me.cmbriskstatus.DisplayMember = "Key"
        Me.cmbriskstatus.ValueMember = "Value"
        Me.cmbriskstatus.DataSource = Me.cmbriskstatus.Items

        Me.cmbposition.Items.Add(New DictionaryEntry("Ant", "A"))
        Me.cmbposition.Items.Add(New DictionaryEntry("Midline", "M"))
        Me.cmbposition.Items.Add(New DictionaryEntry("Post", "P"))

        Me.cmbposition.DisplayMember = "Key"
        Me.cmbposition.ValueMember = "Value"
        Me.cmbposition.DataSource = Me.cmbposition.Items

        Me.cmbmembranes.Items.Add(New DictionaryEntry("Intact", "I"))
        Me.cmbmembranes.Items.Add(New DictionaryEntry("Raptured", "R"))

        Me.cmbmembranes.DisplayMember = "Key"
        Me.cmbmembranes.ValueMember = "Value"
        Me.cmbmembranes.DataSource = Me.cmbmembranes.Items

        Me.cmbamnioticfld.Items.Add(New DictionaryEntry("Meconium-STD", "M"))
        Me.cmbamnioticfld.Items.Add(New DictionaryEntry("Clear", "C"))

        Me.cmbamnioticfld.DisplayMember = "Key"
        Me.cmbamnioticfld.ValueMember = "Value"
        Me.cmbamnioticfld.DataSource = Me.cmbamnioticfld.Items

        Me.cmbDepartment.DataSource = clsAdmissiondetails.getDepartment()
        Me.cmbDepartment.DisplayMember = "OfficeDescription"
        Me.cmbDepartment.ValueMember = "OfficeCode"
        If (modGlobal.hospitalname).ToUpper Like "*DOMINICAN*" Then
            Me.cmbDepartment.SelectedValue = "037" 'INTERNAL MEDICINE
        Else
            Me.cmbDepartment.SelectedValue = "040" 'FAMILY MEDICINE
        End If
        Dim sOperation As String = cmbDepartment.SelectedValue

        Me.dtpObyear.CustomFormat = "yyyy"
        Me.dtpObyear.Format = DateTimePickerFormat.Custom
        Me.dtpPogYear.CustomFormat = "yyyy"
        Me.dtpPogYear.Format = DateTimePickerFormat.Custom
        'Me.cmbPogSex.Items.Add(New DictionaryEntry("Male", "M"))
        'Me.cmbPogSex.Items.Add(New DictionaryEntry("Female", "F"))

        'Me.cmbPogSex.DisplayMember = "Key"
        'Me.cmbPogSex.ValueMember = "Value"
        'Me.cmbPogSex.DataSource = Me.cmbPogSex.Items

        'Me.cmbObSex.Items.Add(New DictionaryEntry("Male", "M"))
        'Me.cmbObSex.Items.Add(New DictionaryEntry("Female", "F"))

        'Me.cmbObSex.DisplayMember = "Key"
        'Me.cmbObSex.ValueMember = "Value"
        'Me.cmbObSex.DataSource = Me.cmbObSex.Items

        Me.cmbObTypeofDelivery.Items.Add(New DictionaryEntry("Normal", "0"))
        Me.cmbObTypeofDelivery.Items.Add(New DictionaryEntry("Cesarean", "1"))

        Me.cmbObTypeofDelivery.DisplayMember = "Key"
        Me.cmbObTypeofDelivery.ValueMember = "Value"
        Me.cmbObTypeofDelivery.DataSource = Me.cmbObTypeofDelivery.Items

        Me.cmbnataltypeofdelivery.Items.Add(New DictionaryEntry("Normal", "0"))
        Me.cmbnataltypeofdelivery.Items.Add(New DictionaryEntry("Cesarean", "1"))

        Me.cmbnataltypeofdelivery.DisplayMember = "Key"
        Me.cmbnataltypeofdelivery.ValueMember = "Value"
        Me.cmbnataltypeofdelivery.DataSource = Me.cmbnataltypeofdelivery.Items

        With Me.cmbnewbornhearingresult
            .DataSource = Nothing
            .Items.Add(New DictionaryEntry("NA", clsModel.NewbornHearingTestResult.NA))
            .Items.Add(New DictionaryEntry("Passed", clsModel.NewbornHearingTestResult.Passed))
            .Items.Add(New DictionaryEntry("Referred", clsModel.NewbornHearingTestResult.Referred))
            .DisplayMember = "Key"
            .ValueMember = "Value"
            .DataSource = .Items
        End With
    End Sub
    Private Sub loadReferringHCI()
        Me.cmbreferringHCI.DataSource = clsReferral.generic()
        Me.cmbreferringHCI.DisplayMember = "hciname"
        Me.cmbreferringHCI.ValueMember = "hciid"
        Call LoadHCIInfo()
    End Sub
    Private Sub LoadObgyne()
        Dim newAdmission As New clsAdmissiondetails
        If Trim(Me.txtObNo.Text) = "" Then
            Exit Sub
        End If
        With newAdmission
            .PtNo = AdmissionID
            .ObgyneNo = Trim(Me.txtObNo.Text)
            .ObgyneYear = Utility.NullToDefaultDateFormat(Me.dtpObyear.Value)
            If Me.rbObMale.Checked = True Then
                .ObgyneSex = "M"
            Else
                .ObgyneSex = "F"
            End If
            .ObgyneTypeofDelivery = Me.cmbObTypeofDelivery.SelectedValue
            .ObgynePlaceofDelivery = Me.txtObPlaceofDelivery.Text
            .ObgyneAttending = PogDoctorID
            .ObgyneBW = Me.txtObBW.Text
            .ObgyneComplications = Me.txtObComplication.Text
            .PregnancyOrder = Me.txtObPregnancyOrder.Text
            .PregnancyOutcome = Me.txtObPregnancyOutcome.Text
            .PogsYear = Utility.NullToDefaultDateFormat(Me.dtpPogYear.Value)
            .GestationalCompleted = Me.txtObGestationalCompleted.Text
            If Me.rbPogMale.Checked = True Then
                .PogsSex = "M"
            Else
                .PogsSex = "F"
            End If
            .Birth = Me.dtpPogBirth.Value
            .Present = Me.txtPogPresent.Text
            .PogsComplications = Me.txtPogComplications.Text
            .SaveObgyne()
        End With

        'Dim ctr As Integer

        'Dim dtObsPogID As New DataTable
        'dtObsPogID = clsAdmissiondetails.loadtoGrid(PtNo)
        'If PtNo <> Nothing Then
        '    Dim dtcount As Integer = dtObsPogID.Rows.Count
        '    While ctr < dtcount
        '        ObsPogNo = Utility.NullToEmptyString(dtObsPogID.Rows(ctr).Item("No"))
        '        PregnancyOrder = Utility.NullToEmptyString(dtObsPogID.Rows(ctr).Item("PregnancyOrder"))
        '        newAdmission.DelPtNo(PtNo, ObsPogNo, PregnancyOrder)
        '        ctr = ctr + 1
        '    End While
        '    ctr = 0
        '    newAdmission.PtNo = Me.lblPatientNo.Text
        '    Dim reccount As Integer = Me.dgObgyne.RowCount
        '    While ctr < reccount - 1
        '        newAdmission.ObgyneNo = Trim(Me.dgObgyne.Item(0, ctr).Value)
        '        newAdmission.ObgyneYear = Utility.NullToDefaultDateFormat(Me.dgObgyne.Item(1, ctr).Value)
        '        newAdmission.ObgyneSex = (Me.dgObgyne.Item(2, ctr).Value)
        '        newAdmission.ObgyneTypeofDelivery = Me.dgObgyne.Item(3, ctr).Value
        '        newAdmission.ObgynePlaceofDelivery = Me.dgObgyne.Item(4, ctr).Value
        '        newAdmission.ObgyneAttending = Me.dgObgyne.Item(5, ctr).Value
        '        newAdmission.ObgyneBW = Me.dgObgyne.Item(6, ctr).Value
        '        newAdmission.ObgyneComplications = Me.dgObgyne.Item(7, ctr).Value
        '        newAdmission.PregnancyOrder = Me.dgObgyne.Item(8, ctr).Value
        '        newAdmission.PregnancyOutcome = Me.dgObgyne.Item(9, ctr).Value
        '        newAdmission.PogsYear = Utility.NullToDefaultDateFormat(Me.dgObgyne.Item(10, ctr).Value)
        '        newAdmission.GestationalCompleted = Me.dgObgyne.Item(11, ctr).Value
        '        newAdmission.PogsSex = Me.dgObgyne.Item(12, ctr).Value
        '        newAdmission.Birth = Me.dgObgyne.Item(13, ctr).Value
        '        newAdmission.Present = Me.dgObgyne.Item(14, ctr).Value
        '        newAdmission.PogsComplications = Me.dgObgyne.Item(15, ctr).Value
        '        ctr = ctr + 1
        '        newAdmission.SaveObgyne()
        '    End While
        'End If
    End Sub
    Public Sub Split(ByVal mHospitalNo As String)
        Dim i As Integer
        Dim lhospno As String
        hospnolen = mHospitalNo

        lhospno = hospnolen.Length()
        value = hospnolen
        Dim a As Integer = 2

        For i = 0 To lhospno - 2 Step a
            value = value.Insert(i + a, "-")
            If (a = 3) = True Then
                Exit For
            Else
                a = a + 1
            End If
        Next

        If vFilterby = "SubMGH" Or vFilterby = "SubDischarge" Or vFilterby = "SubUntagasMGH" Then
            Me.lblHospNo1.Text = value
        Else
            Me.lblHospNo.Text = value
        End If
    End Sub
    Private Sub loadtoGrid(ByVal ptno As String)
        Me.dtLoadtoGrid = clsAdmissiondetails.loadtoGrid(AdmissionID)
        If dtLoadtoGrid.Rows.Count = 0 Then
            Exit Sub
        End If
        Me.txtObNo.Text = dtLoadtoGrid.Rows(0).Item("No").ToString
        Me.dtpObyear.Value = Utility.NullToCurrentDate(dtLoadtoGrid.Rows(0).Item("Year").ToString)
        If Trim(dtLoadtoGrid.Rows(0).Item("sex").ToString) = "M" Then
            Me.rbObMale.Checked = True
        Else
            Me.rbObFemale.Checked = True
        End If
        Me.cmbObTypeofDelivery.SelectedValue = dtLoadtoGrid.Rows(0).Item("typeofdelivery").ToString
        Me.txtObPlaceofDelivery.Text = dtLoadtoGrid.Rows(0).Item("placeofdelivery").ToString
        PogDoctorID = dtLoadtoGrid.Rows(0).Item("doctorID").ToString
        Me.txtObDoctor.Text = dtLoadtoGrid.Rows(0).Item("attending").ToString
        Me.txtObBW.Text = dtLoadtoGrid.Rows(0).Item("bw").ToString
        Me.txtObComplication.Text = dtLoadtoGrid.Rows(0).Item("complications").ToString
        Me.txtObPregnancyOrder.Text = dtLoadtoGrid.Rows(0).Item("pregnancyorder").ToString
        Me.txtObPregnancyOutcome.Text = dtLoadtoGrid.Rows(0).Item("pregnancyoutcome").ToString
        Me.dtpPogYear.Value = Utility.NullToCurrentDate(dtLoadtoGrid.Rows(0).Item("PogsYear").ToString)
        Me.txtObGestationalCompleted.Text = dtLoadtoGrid.Rows(0).Item("gestationalcompleted").ToString
        If Trim(dtLoadtoGrid.Rows(0).Item("Pogsex").ToString) = "M" Then
            Me.rbPogMale.Checked = True
        Else
            Me.rbPogFemale.Checked = True
        End If
        Me.dtpPogBirth.Value = Utility.NullToCurrentDate(dtLoadtoGrid.Rows(0).Item("birth").ToString)
        Me.txtPogPresent.Text = dtLoadtoGrid.Rows(0).Item("present").ToString
        Me.txtPogComplications.Text = dtLoadtoGrid.Rows(0).Item("Pogscomplications").ToString
        'Dim max As Integer = dtLoadtoGrid.Rows.Count
        'Dim ctr As Integer
        'Do While ctr < max
        '    dgObgyne.Rows.Add()
        '    Me.dgObgyne.Rows(ctr).Cells(0).Value = dtLoadtoGrid.Rows(ctr).Item("No").ToString
        '    Me.dgObgyne.Rows(ctr).Cells(1).Value = dtLoadtoGrid.Rows(ctr).Item("Year").ToString
        '    Me.dgObgyne.Rows(ctr).Cells(2).Value = dtLoadtoGrid.Rows(ctr).Item("sex").ToString
        '    Me.dgObgyne.Rows(ctr).Cells(3).Value = dtLoadtoGrid.Rows(ctr).Item("typeofdelivery").ToString
        '    Me.dgObgyne.Rows(ctr).Cells(4).Value = dtLoadtoGrid.Rows(ctr).Item("placeofdelivery").ToString
        '    Me.dgObgyne.Rows(ctr).Cells(5).Value = dtLoadtoGrid.Rows(ctr).Item("attending").ToString
        '    Me.dgObgyne.Rows(ctr).Cells(6).Value = dtLoadtoGrid.Rows(ctr).Item("bw").ToString
        '    Me.dgObgyne.Rows(ctr).Cells(7).Value = dtLoadtoGrid.Rows(ctr).Item("complications").ToString
        '    Me.dgObgyne.Rows(ctr).Cells(8).Value = dtLoadtoGrid.Rows(ctr).Item("pregnancyorder").ToString
        '    Me.dgObgyne.Rows(ctr).Cells(9).Value = dtLoadtoGrid.Rows(ctr).Item("pregnancyoutcome").ToString
        '    Me.dgObgyne.Rows(ctr).Cells(10).Value = dtLoadtoGrid.Rows(ctr).Item("PogsYear").ToString
        '    Me.dgObgyne.Rows(ctr).Cells(11).Value = dtLoadtoGrid.Rows(ctr).Item("gestationalcompleted").ToString
        '    Me.dgObgyne.Rows(ctr).Cells(12).Value = dtLoadtoGrid.Rows(ctr).Item("Pogsex").ToString
        '    Me.dgObgyne.Rows(ctr).Cells(13).Value = dtLoadtoGrid.Rows(ctr).Item("birth").ToString
        '    Me.dgObgyne.Rows(ctr).Cells(14).Value = dtLoadtoGrid.Rows(ctr).Item("present").ToString
        '    Me.dgObgyne.Rows(ctr).Cells(15).Value = dtLoadtoGrid.Rows(ctr).Item("Pogscomplications").ToString
        '    ctr = ctr + 1
        'Loop
    End Sub
    Private Sub LoadCase(ByVal admissionid As Long)
        Dim dtcase As New DataTable
        dtcase = clsAdmissiondetails.genericcls(34, admissionid)
        If dtcase.Rows.Count > 0 Then
            caseno = Utility.NullToZero(dtcase.Rows(0).Item("caseno"))
            Me.txtAdmittingDiagnosis.Text = IIf(caseno <> 0, Utility.NullToEmptyString(dtcase.Rows(0).Item("casename")), "")
        End If

    End Sub
    'added 9/9/17 toni
    Private Sub displayLastAdmissionBalance(ByVal PatientID As Integer)
        'Dim dtPatientBalance As DataTable = clsBilling.getPatientBalance(PatientID)
        'Dim balanceAmount As Double
        'Dim lastDateAdmitted As Date
        'If dtPatientBalance.Rows.Count > 0 Then

        '    balanceAmount = dtPatientBalance.Rows(0).Item("excess")
        '    lastDateAdmitted = CDate(dtPatientBalance.Rows(0).Item("dateadmitted"))
        'End If
        'If balanceAmount > 0 Then
        '    'Me.Timer1.Enabled = True
        '    'Me.lblAbsconded.Visible = True
        '    Me.lblBalance.Visible = True
        '    Me.lblBalanceLabel.Visible = True
        '    Me.lblBalance.Text = FormatNumber(balanceAmount, 2)

        '    Me.lblLastAdmitted.Text = lastDateAdmitted
        '    Me.lblLastAdmitted.Visible = True
        '    Me.lblLastAdmittedLabel.Visible = True
        'Else
        '    Me.lblBalance.Visible = False
        '    Me.lblBalanceLabel.Visible = False

        '    Me.lblLastAdmitted.Visible = False
        '    Me.lblLastAdmittedLabel.Visible = False
        'End If


    End Sub
    Public Sub LoadPatient(ByVal PatientID As Integer)
        Dim mHospno As String
        Dim dtpat As New DataTable

        dtpat = clsAdmissiondetails.getPatientDetails(PatientID)
        mHospno = Utility.NullToEmptyString(dtpat.Rows(0).Item("HospitalNo"))
        'added 9/9/17 toni
        Call displayLastAdmissionBalance(PatientID)
        If mHospno <> "" Then
            Call Split(mHospno)
        End If
        If vFilterby = "SubMGH" Or vFilterby = "SubDischarge" Or vFilterby = "SubUntagasMGH" Then
            Me.lblLastName1.Text = dtpat.Rows(0).Item("lastname")
            Me.lblFirstName1.Text = dtpat.Rows(0).Item("FirstName")
            Me.lblMI1.Text = dtpat.Rows(0).Item("MiddleName")
            Me.lblSuffixName.Text = Utility.NullToEmptyString(dtpat.Rows(0).Item("SuffixName"))
            Me.lblBirthDate1.Text = dtpat.Rows(0).Item("BirthDate")
            Me.lblAddress1.Text = Utility.NullToEmptyString(dtpat.Rows(0).Item("HomeAddress"))
            Dim gender1 As String = LCase(dtpat.Rows(0).Item("Gender").ToString)
            Me.txtPatNo.Text = PatientID


            If Trim(gender1) = "m" Then
                Me.lblGender.Text = "Male"
            Else
                Me.lblGender.Text = "Female"
            End If
            Me.lblCompany1.Text = Utility.NullToEmptyString(dtpat.Rows(0).Item("Company"))
            Try
                Dim tempphoto As Byte() = dtpat.Rows(0).Item("photo")
                If IsDBNull(dtpat.Rows(0).Item("photo")) Or tempphoto.Length = 0 Then
                    pctrPhoto1.Image = Nothing
                Else
                    pctrPhoto1.Image = Utility.convertImage(dtpat.Rows(0).Item("photo")) 'image here
                End If
            Catch ex As Exception

            End Try
        Else
            Me.lblLastName.Text = dtpat.Rows(0).Item("lastname")
            Me.lblFirstName.Text = dtpat.Rows(0).Item("FirstName")
            Me.lblMI.Text = dtpat.Rows(0).Item("MiddleName")
            Me.lblSuffixName.Text = Utility.NullToEmptyString(dtpat.Rows(0).Item("SuffixName"))
            Me.lblBirthDate.Text = dtpat.Rows(0).Item("BirthDate")
            Me.lblAddress.Text = Utility.NullToEmptyString(dtpat.Rows(0).Item("HomeAddress"))
            Dim gender As String = UCase(dtpat.Rows(0).Item("Gender").ToString)
            Me.txtPatNo.Text = PatientID
            If Trim(gender) = "M" Then
                Me.lblSex.Text = "Male"
            Else
                Me.lblSex.Text = "Female"
            End If
            Me.lblCompany.Text = Utility.NullToEmptyString(dtpat.Rows(0).Item("Company"))

            Me.txtNotify.Text = dtpat.Rows(0).Item("notify")
            Me.txtNotifyRelationship.Text = dtpat.Rows(0).Item("notifyrelationship")
            Me.txtNotifyAddress.Text = dtpat.Rows(0).Item("notifyaddress")
            Me.txtNotifyTelNo.Text = dtpat.Rows(0).Item("notifytelno")
            Me.txtInformant.Text = dtpat.Rows(0).Item("informant")
            Me.txtInformantRelationship.Text = dtpat.Rows(0).Item("informantrelationship")


            Try
                If IsDBNull(dtpat.Rows(0).Item("photo")) = True Then
                    Try
                        If hasImage = False And gender = "M" Then
                            ' Me.pctrPhoto.Image = Global.DominicanHMS.My.Resources.Resources.male
                            imageName = ImageList1.Images.Keys(0)
                        Else
                            'Me.pctrPhoto.Image = Global.DominicanHIS.My.Resources.Resources.female
                            imageName = ImageList1.Images.Keys(1)
                        End If
                    Catch ex As Exception

                    End Try
                Else
                    Dim tempphoto As Byte() = dtpat.Rows(0).Item("photo")
                    If IsDBNull(dtpat.Rows(0).Item("photo")) Or tempphoto.Length = 0 Then
                        pctrPhoto.Image = Nothing
                    Else
                        pctrPhoto.Image = Utility.convertImage(dtpat.Rows(0).Item("photo")) 'image here
                        imageName = Nothing
                    End If
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub LoadPhysician(ByVal mPhysicianID As Integer)
        Dim dtpat As DataTable = clsAdmissiondetails.getDoctors(mPhysicianID)
        If mPhysicianID <> 0 Then
            Me.lblAdmittingDoctor.Text = Utility.NullToEmptyString("DR." & " " & UCase(dtpat.Rows(0).Item("Physician")))
        Else
            Me.lblAdmittingDoctor.Text = Utility.NullToEmptyString(UCase(dtpat.Rows(0).Item("Physician")))
        End If
        If myCurrentFormStatus = enFormStatus.edit Then
            Docfee = Utility.NullToZero(dtpat.Rows(0).Item("dailyvisitrate"))
        End If
    End Sub
    Private Sub LoadAttendingPhysician(ByVal mDocID As Integer)
        Dim dtpat As DataTable = clsAdmissiondetails.getDoctors(mDocID)
        If mDocID <> 0 Then
            Me.lblAttendingPhysician.Text = Utility.NullToEmptyString("DR." & " " & UCase(dtpat.Rows(0).Item("Physician")))
        Else
            Me.lblAttendingPhysician.Text = Utility.NullToEmptyString(UCase(dtpat.Rows(0).Item("Physician")))
        End If

        If myCurrentFormStatus = enFormStatus.edit Then
            mAttendingphyCharge = Utility.NullToZero(dtpat.Rows(0).Item("dailyvisitrate"))
        End If
    End Sub
    Private Sub LoadRoom(ByVal mRoomID As Integer)
        Dim dtRoom As DataTable = clsAdmissiondetails.getRoom(mRoomID)
        'If dtRoom.Rows(0).Item("RoomID") = 0 Then
        '    Me.lblroom.Text = ""
        'Else
        Me.lblroom.Text = dtRoom.Rows(0).Item("roomno") & "-" & dtRoom.Rows(0).Item("Description")
        'End If

        If myCurrentFormStatus = enFormStatus.edit Then
            RoomRate = dtRoom.Rows(0).Item("Charge")
        End If
    End Sub
    Private Sub EnableFields()
        Me.tsCancel.Visible = False
        Me.tsPrint.Visible = False
        Me.chkUpdate.Visible = False
        Me.ToolStripSeparator2.Visible = 0
        Me.ToolStripSeparator3.Visible = 0
        If subModule = "Outpatients" Or subModule = "Emergency" Then
            Me.lblAdPhys.Visible = False
            Me.lblroom1.Visible = False
            Me.lblAdmittingDoctor.Visible = False
            Me.lblroom.Visible = False
            Me.btnSearchDoctor.Visible = False
            Me.btnSearchRoom.Visible = False
        ElseIf subModule = "Inpatients" Or subModule = "Nursing Services" Then
            Me.lblAdPhys.Visible = True
            Me.lblroom1.Visible = True
            Me.lblAdmittingDoctor.Visible = True
            Me.lblroom.Visible = True
            Me.btnSearchDoctor.Visible = True
            Me.btnSearchRoom.Visible = True
            If fMain.cmbFilterBy.SelectedIndex = 0 And vFilterby <> "SubMGH" Then
                Me.tabpatientinfo.Controls.Remove(tbDischargeStatus)
            End If
        End If
        If myCurrentFormStatus = enFormStatus.browsing Then
            Me.tsPrint.Visible = True
            Me.dtpAdmissionTime.Enabled = False
            Me.tsSave.Visible = False
            Me.btnPatient.Visible = False
            Me.ToolStripSeparator1.Visible = 0
            Me.btnAddHCI.Enabled = 0
            Me.btnEditHCI.Enabled = 0
            Me.btnAddReasons.Enabled = 0
            Me.btnEditReasons.Enabled = 0
            Me.btnAttendingPhysician.Enabled = False
            Me.btnSearchRoom.Enabled = False
            Me.pctrPhoto.Enabled = False
            Me.btnSearchDoctor.Enabled = False
            Me.cmbDepartment.Enabled = False
            Me.dtpAdmissionDate.Enabled = False
            Me.txtNotify.Enabled = False
            Me.txtNotifyRelationship.Enabled = False
            Me.txtNotifyTelNo.Enabled = False
            Me.txtNotifyAddress.Enabled = False
            Me.txtInformant.Enabled = False
            Me.txtInformantRelationship.Enabled = False
            Me.txtreasonforadmission.Enabled = False
            Me.txtadmittingimpression.Enabled = False
            Me.txtfamilyhistory.Enabled = False
            Me.txtpasthistory.Enabled = False
            Me.txtpastillness.Enabled = False
            Me.btnAddCase.Enabled = False
            Me.btnRemCase.Enabled = False
            Me.txtAdmittingDiagnosis.Enabled = False
            Me.txtBloodPressure.Enabled = False
            Me.txtBPdiastolic.Enabled = False
            Me.txtTemp.Enabled = False
            Me.txtHeight.Enabled = False
            Me.txtRR.Enabled = False
            Me.txtCR.Enabled = False
            Me.txtWeight.Enabled = False
            Me.txthent.Enabled = False
            Me.txtchest.Enabled = False
            Me.txtgen.Enabled = False
            Me.txtcvs.Enabled = False
            Me.txtskin.Enabled = False
            Me.txtneuro.Enabled = False
            Me.txtchiefcom.Enabled = False
            Me.txtpresentillness.Enabled = False
            Me.txtgravida.Enabled = False
            Me.txtterm.Enabled = False
            Me.txtpara.Enabled = False
            Me.txtprematrue.Enabled = False
            Me.txtabortion.Enabled = False
            Me.txtline.Enabled = False
            Me.dtpmp.Enabled = False
            Me.dtlmp.Enabled = False
            Me.txtdurcharpmp.Enabled = False
            Me.txtdurcharlmp.Enabled = False
            Me.dtpEDC.Enabled = False
            Me.txtaog.Enabled = False
            Me.dtmenarche.Enabled = False
            Me.txtinterval.Enabled = False
            Me.txtSMDuration.Enabled = False
            Me.txtamount.Enabled = False
            Me.txtcontraception.Enabled = False
            Me.cmbdysmenorrhea.Enabled = False
            Me.grpPrenatalCourse.Enabled = False
            Me.txtcheckupdoneby.Enabled = False
            Me.txtcomplications.Enabled = False
            Me.txtprenatalmedstaken.Enabled = False
            Me.txtchildhooddisease.Enabled = False
            Me.txtprevhosp.Enabled = False
            Me.txtprevoperations.Enabled = False
            Me.txtmedillness.Enabled = False
            Me.txtmedications.Enabled = False
            Me.grpFamilyHistory.Enabled = False
            Me.txtheadneck.Enabled = False
            Me.txtbreastfeeding.Enabled = False
            Me.txtheart.Enabled = False
            Me.txtlungs.Enabled = False
            Me.txtabdomenfh.Enabled = False
            Me.txtabdomenefw.Enabled = False
            Me.txtabdomenfht.Enabled = False
            Me.txtabdomenfhtcharacter.Enabled = False
            Me.txtabdomenfhtloacation.Enabled = False
            Me.txtextremities.Enabled = False
            Me.txtieby.Enabled = False
            Me.txtdilatation.Enabled = False
            Me.txteffacement.Enabled = False
            Me.txtstation.Enabled = False
            Me.cmbbow.Enabled = False
            Me.txtsince.Enabled = False
            Me.txtprespart.Enabled = False
            Me.txtmucoid.Enabled = False
            Me.txtwatery.Enabled = False
            Me.txtbloody.Enabled = False
            Me.txtodor.Enabled = False
            Me.txtcolor.Enabled = False
            Me.txtischialspines.Enabled = False
            Me.txtsidewalls.Enabled = False
            Me.txtpubicarch.Enabled = False
            Me.txtsacrumcontour.Enabled = False
            Me.txtsacrosciaticnotch.Enabled = False
            Me.txtischialtuberosities.Enabled = False
            Me.txtadequate.Enabled = False
            Me.txtborderline.Enabled = False
            Me.txtnarrow.Enabled = False
            Me.txtimpression.Enabled = False
            Me.grpAntenatalProblems.Enabled = False
            Me.txteent.Enabled = False
            Me.cmbsensorium.Enabled = False
            Me.cmbgeneralstatus.Enabled = False
            Me.txtchestheart.Enabled = False
            Me.txtchestlungs.Enabled = False
            Me.txtchestbreast.Enabled = False
            Me.txtabdomenelsk.Enabled = False
            Me.txtfundicht.Enabled = False
            Me.txtabdomenefw.Enabled = False
            Me.txtabdomenfht.Enabled = False
            Me.txtpresentation.Enabled = False
            Me.txtfloatingengaged.Enabled = False
            Me.txtpogsabdomenothers.Enabled = False
            Me.txtpogsextremities.Enabled = False
            Me.txtcervixlength.Enabled = False
            Me.txtpogdilation.Enabled = False
            Me.txtpogseffacement.Enabled = False
            Me.cmbposition.Enabled = False
            Me.txtpogspresentationposition.Enabled = False
            Me.cmbmembranes.Enabled = False
            Me.txtstation.Enabled = False
            Me.cmbamnioticfld.Enabled = False
            Me.txtsutures.Enabled = False
            Me.chkcontracted.Enabled = False
            Me.grpContracted.Enabled = False
            Me.txtintlet.Enabled = False
            Me.txtmidplane.Enabled = False
            Me.txtoutlet.Enabled = False
            Me.chkboderline.Enabled = False
            Me.chkborderlinetriallabor.Enabled = False
            Me.chkspelvimetyadequate.Enabled = False
            Me.txtinfection.Enabled = False
            Me.txtexposuretodrugs.Enabled = False
            Me.txtsmokingalcohol.Enabled = False
            Me.txtbreastfeeding.Enabled = False
            Me.txtmilkformula.Enabled = False
            Me.txtsupplemental.Enabled = False
            Me.txtallergies.Enabled = False
            Me.cmbnataltypeofdelivery.Enabled = False
            Me.txtnsd.Enabled = False
            Me.txtcs.Enabled = False
            Me.txg.Enabled = False
            Me.txtp.Enabled = False
            Me.txta.Enabled = False
            Me.txtyo.Enabled = False
            Me.txtgestationalage.Enabled = False
            Me.txtbw.Enabled = False
            Me.txtapgarscore1.Enabled = False
            Me.txtanomolies.Enabled = False
            Me.txtresuscitation.Enabled = False
            Me.txtcomplications.Enabled = False
            Me.txtmotor.Enabled = False
            Me.txtlanguage.Enabled = False
            Me.txttoilettraining.Enabled = False
            Me.txtschools.Enabled = False
            Me.txtbcg.Enabled = False
            Me.txtmeascles.Enabled = False
            Me.txtdpt.Enabled = False
            Me.txthib.Enabled = False
            Me.txtopv.Enabled = False
            Me.txthipatitis.Enabled = False
            Me.txtboosterdoses.Enabled = False
            Me.dgObgyne.Enabled = False
            Me.cmbHospitalPlanCode.Enabled = False
            Me.txtabdomen.Enabled = False
            Me.txtbreast.Enabled = False
            Me.txtefw.Enabled = False
            Me.txtneurologicstation.Enabled = False
            Me.txtfht.Enabled = False
            Me.txtpogsgravida.Enabled = False
            Me.txtpogspara.Enabled = False
            Me.txtpogsline.Enabled = False
            Me.txtpogspremature.Enabled = False
            Me.txtpogsabortion.Enabled = False
            Me.txtpogsterm.Enabled = False
            Me.cmbcontraceptivehistory.Enabled = False
            Me.cmbhealthcareprovider.Enabled = False
            Me.dtpogspmp.Enabled = False
            Me.dtpogslmp.Enabled = False
            Me.dtppogsedc.Enabled = False
            Me.txtpogsaog.Enabled = False
            Me.dtpogsmenarche.Enabled = False
            Me.dtdateofquickening.Enabled = False
            Me.txtMenstrualCycle1.Enabled = False
            Me.txtMenstrualCycle2.Enabled = False
            Me.txtMenstrualCycle3.Enabled = False
            Me.dtultrasounddate.Enabled = False
            Me.txtultrasoundadjedc.Enabled = False
            Me.txtultrsoundaog.Enabled = False
            Me.cmbprenatalvisits.Enabled = False
            Me.chktetanus.Enabled = False
            Me.chkhepatitisb.Enabled = False
            Me.txtimmunizationdoses.Enabled = False
            Me.dtimmunizationsdates.Enabled = False
            Me.txtimmunizationsothers.Enabled = False
            Me.txttotalwatgain.Enabled = False
            Me.txtpogsbp.Enabled = False
            Me.txtpogshb.Enabled = False
            Me.txturinealb.Enabled = False
            Me.txtsugar.Enabled = False
            Me.chkUpdate.Enabled = False
            Me.lblPatientNo.Enabled = False
            Me.txtspeculumexam.Enabled = False
            Me.txtabnormalities.Enabled = False
            Me.btnRemove.Enabled = False
            Me.txtObNo.Enabled = False
            Me.rbObMale.Enabled = False
            Me.rbObFemale.Enabled = False
            Me.dtpObyear.Enabled = False
            Me.cmbObTypeofDelivery.Enabled = False
            Me.txtObPlaceofDelivery.Enabled = False
            Me.btnDoctor.Enabled = False
            Me.txtObBW.Enabled = False
            Me.txtObComplication.Enabled = False
            Me.txtObPregnancyOrder.Enabled = False
            Me.txtObPregnancyOutcome.Enabled = False
            Me.dtpPogYear.Enabled = False
            Me.txtObGestationalCompleted.Enabled = False
            Me.rbPogMale.Enabled = False
            Me.rbPogFemale.Enabled = False
            Me.dtpPogBirth.Enabled = False
            Me.txtPogPresent.Enabled = False
            Me.txtPogComplications.Enabled = False
            Me.cmbreferringHCI.Enabled = False
            Me.txtreferringreason.ReadOnly = True

            Me.chkalteredmentalsensorium.Enabled = False
            Me.chkabdominalcramp_pain.Enabled = False
            Me.chkanorexia.Enabled = False
            Me.chkbleedinggums.Enabled = False
            Me.chkbodyweakness.Enabled = False
            Me.chkblurringofvision.Enabled = False
            Me.chkconstipation.Enabled = False
            Me.chkchestpain_discomfort.Enabled = False
            Me.chkcough.Enabled = False
            Me.chkdiarrhea.Enabled = False
            Me.chkdizziness.Enabled = False
            Me.chkdysphagia.Enabled = False
            Me.chkdyspnea.Enabled = False
            Me.chkdysuria.Enabled = False
            Me.chkepistaxis.Enabled = False
            Me.chkfever.Enabled = False
            Me.chkfrequencyofurination.Enabled = False
            Me.chkheadache.Enabled = False
            Me.chkhematemesis.Enabled = False
            Me.chkhematuria.Enabled = False
            Me.chkhemoptysis.Enabled = False
            Me.chkincreaseirritability.Enabled = False
            Me.chkjaundice.Enabled = False
            Me.chklowerextremityedema.Enabled = False
            Me.chkmyalgia.Enabled = False
            Me.chkorthopnea.Enabled = False
            Me.chkpalpitations.Enabled = False
            Me.chkskinrashes.Enabled = False
            Me.chkstool_bloody_blacktarry_mucoid.Enabled = False
            Me.chksweating.Enabled = False
            Me.chkseizures.Enabled = False
            Me.chkurgency.Enabled = False
            Me.chkvomiting.Enabled = False
            Me.chkweightloss.Enabled = False
            Me.chkothers.Enabled = False
            Me.txtothers.ReadOnly = True
            Me.txtpain.ReadOnly = True
            Me.chksurvey_awakeandalert.Enabled = False
            Me.chksurvey_alteredsensorium.Enabled = False
            Me.txtalteredsersorium.ReadOnly = True
            Me.chkheent_essentiallynormal.Enabled = False
            Me.chkheent_abnormalpupillaryreaction.Enabled = False
            Me.chkheent_cervicallympadenopathy.Enabled = False
            Me.chkheent_drymucousmembrane.Enabled = False
            Me.chkheent_ictericsclerae.Enabled = False
            Me.chkheent_paleconjunctivae.Enabled = False
            Me.chkheent_sunkeneyeballs.Enabled = False
            Me.chkheent_sunkenfontanelle.Enabled = False
            Me.chkchest_essentiallynormal.Enabled = False
            Me.chkchest_asymmetricalexpansion.Enabled = False
            Me.chkchest_decreasedbreathsounds.Enabled = False
            Me.chkchest_wheezes.Enabled = False
            Me.chkchest_lumpsoverbreast.Enabled = False
            Me.chkchest_ralescracklesrhonchi.Enabled = False
            Me.chkchest_intercostalribretraction.Enabled = False
            Me.chkcvs_essentiallynormal.Enabled = False
            Me.chkcvs_displacedapexbeat.Enabled = False
            Me.chkcvs_heaves.Enabled = False
            Me.chkcvs_irregularrhythm.Enabled = False
            Me.chkcvs_muffledheartsounds.Enabled = False
            Me.chkcvs_murmur.Enabled = False
            Me.chkcvs_pericardialbulge.Enabled = False
            Me.chkabdomen_essentiallynormal.Enabled = False
            Me.chkabdomen_abdominalrigidity.Enabled = False
            Me.chkabdomen_abdominaltenderness.Enabled = False
            Me.chkabdomen_hyperactivebowelsounds.Enabled = False
            Me.chkabdomen_palpablemass.Enabled = False
            Me.chkabdomen_tympaniticdullabdomen.Enabled = False
            Me.chkabdomen_uterinecontraction.Enabled = False
            Me.chkgu_essentiallynormal.Enabled = False
            Me.chkgu_bloodstainedfinger.Enabled = False
            Me.chkgu_cervicaldilatation.Enabled = False
            Me.chkgu_presenceofabnormaldischarge.Enabled = False
            Me.chkskin_essentiallynormal.Enabled = False
            Me.chkskin_clubbing.Enabled = False
            Me.chkskin_coldclammy.Enabled = False
            Me.chkskin_cyanosis.Enabled = False
            Me.chkskin_edema.Enabled = False
            Me.chkskin_muscles.Enabled = False
            Me.chkskin_palenailbeds.Enabled = False
            Me.chkskin_poorskinturgor.Enabled = False
            Me.chkskin_rashespetechiae.Enabled = False
            Me.chkskin_weakpulses.Enabled = False
            Me.chkneuro_essentiallynormal.Enabled = False
            Me.chkneuro_abnormalgait.Enabled = False
            Me.chkneuro_abnormalposition.Enabled = False
            Me.chkneuro_abnormalsensation.Enabled = False
            Me.chkneuro_presenceofabnormalreflex.Enabled = False
            Me.chkneuro_pooralteredmemory.Enabled = False
            Me.chkneuro_poormuscletone.Enabled = False
            Me.chkneuro_poorcoordination.Enabled = False
            Me.btninterviewedby.Enabled = False

        ElseIf myCurrentFormStatus = enFormStatus.edit Then
            Me.btnPatient.Visible = 0
            If modGlobal.sourceOfficeCode = "017" Or fMain.visAdmit = "SubAdmitPatient" Then
                'medical record office (017)
                Me.btnPatient.Enabled = True
                Me.btnPatient.Visible = True
            ElseIf vFilterby <> "SubMGH" And vFilterby <> "SubDischarge" And vFilterby <> "SubUntagasMGH" Then
                If dtfinalbill.Rows.Count > 0 Then
                    If dtfinalbill.Rows(0).Item("isfinal") = 1 Or dtfinalbill.Rows(0).Item("isdischarge") = True Then
                        Me.btnSearchRoom.Enabled = False
                        Me.btnSearchDoctor.Enabled = 0
                        Me.btnAttendingPhysician.Enabled = 0
                    End If
                    If dtfinalbill.Rows(0).Item("NoOfDays") > 1 Or dtfinalbill.Rows(0).Item("isdischarge") = True Or dtfinalbill.Rows(0).Item("isfinal") = 1 Then
                        Me.dtpAdmissionDate.Enabled = False
                    End If
                    If dtfinalbill.Rows(0).Item("isdischarge") = True Or dtfinalbill.Rows(0).Item("isfinal") = 1 Then
                        Me.dtpAdmissionTime.Enabled = False
                    End If
                End If
            End If
            'Me.dtpAdmissionDate.Enabled = False
            Me.chkUpdate.Visible = True
            If fMain.visAdmit = "SubAdmitPatient" Then
                Me.chkUpdate.Visible = False
            End If
        End If
    End Sub
    Private Sub EnableField()
        Me.tsCancel1.Visible = False
        Me.tsPrint1.Visible = False
        If myCurrentFormStatus = enFormStatus.browsing Then
            If vFilterby = "SubMGH" Or vFilterby = "SubDischarge" Then
                Me.dtpMGHDate.Enabled = False
                Me.dtpMGHTime.Enabled = False
                Me.dtpDDDate.Enabled = False
                Me.dtpDDTime.Enabled = False
                Me.dtpDateOfDeath.Enabled = False
                Me.dtpTimeOfDeath.Enabled = False
                Me.cmbReasonForRefferal.Enabled = False
                Me.tsSave.Visible = False  
                Me.cmbDischargeStat.Enabled = False
            ElseIf vFilterby = "SubUntagasMGH" Then
                Me.tsSave.Visible = False
            End If
            Me.tsPrint.Visible = True
        ElseIf myCurrentFormStatus = enFormStatus.edit Then
            If vFilterby = "SubMGH" Then
                Me.dtpMGHDate.Enabled = True
                Me.dtpMGHTime.Enabled = True
                Me.dtpDDDate.Enabled = False
                Me.dtpDDTime.Enabled = False
                Me.tsSave1.Visible = True
                Me.cmbDischargeStat.Visible = False
                Me.lblDischargeStatus.Visible = False
            ElseIf vFilterby = "SubDischarge" Then
                Me.lblDischargeStatus.Visible = True
                Me.cmbDischargeStat.Visible = True
                Me.dtpMGHDate.Enabled = True
                Me.dtpMGHTime.Enabled = True
                Me.cmbReasonForRefferal.Enabled = True
                Me.dtpDateOfDeath.Enabled = True
                Me.dtpTimeOfDeath.Enabled = True
                Me.dtpDDDate.Enabled = True
                Me.dtpDDTime.Enabled = True
                Me.tsSave1.Visible = True
            ElseIf vFilterby = "SubUntagasMGH" Then
                Me.dtpMGHDate.Enabled = False
                Me.dtpMGHTime.Enabled = False
                Me.dtpDDDate.Enabled = True
                Me.dtpDDTime.Enabled = True
                Me.cmbReasonForRefferal.Enabled = False
                Me.dtpDateOfDeath.Enabled = False
                Me.dtpTimeOfDeath.Enabled = False
                Me.tsSave.Visible = True
                Me.lblDischargeStatus.Visible = False
                Me.cmbDischargeStat.Visible = False
            End If
        End If
    End Sub
    Private Sub selectImage(ByVal pctr As PictureBox, ByVal fromWho As String)
        Dim dlg As New OpenFileDialog()
        dlg.Filter = "Image Files|*.jpg;*.gif;*.bmp;*.png;*.jpeg"
        Dim dlgRes As DialogResult = dlg.ShowDialog()
        If dlgRes <> DialogResult.Cancel Then
            pctr.Image = Image.FromFile(dlg.FileName)
            If fromWho = "Photo" Then
                imageName = dlg.FileName
            Else
                imageName1 = dlg.FileName
            End If
            fromWho = Nothing
        End If
    End Sub
    Private Sub removetabs()
        Me.tabadmission.Controls.Remove(tabObgyne)
        Me.tabadmission.Controls.Remove(tabObsPogs)
        Me.tabadmission.Controls.Remove(tabPogsObtetrical)
        Me.tabadmission.Controls.Remove(tabPediatricClinicalHistory)
        Me.tabadmission.Controls.Remove(tabNewborn)
        If vFilterby = "SubMGH" Or vFilterby = "SubDischarge" Or vFilterby = "SubUntagasMGH" Then
            Me.tabadmission.Controls.Remove(admission)
            Me.tabpatientinfo.Controls.Remove(tbPatInfo)
            Me.tabpatientinfo.Controls.Remove(tbHistory)
            Me.tabpatientinfo.Controls.Remove(tbVitalSign)
            Me.tsSave1.Visible = True
            Me.tsCancel1.Visible = False
            Me.tsPrint1.Visible = False
            lblDD.Visible = False
            dtpDDDate.Visible = False
            dtpDDTime.Visible = False
            lblReasonForRefferal.Visible = False
            cmbReasonForRefferal.Visible = False
            If Me.cmbDischargeStat.SelectedValue = "D" Then
                lblDateofDeath.Visible = True
                dtpDateOfDeath.Visible = True
                dtpTimeOfDeath.Visible = True
            Else
                lblDateofDeath.Visible = False
                dtpDateOfDeath.Visible = False
                dtpTimeOfDeath.Visible = False
            End If
            If Me.cmbDischargeStat.SelectedValue = "T" Then
                cmbReasonForRefferal.Visible = True
                lblReasonForRefferal.Visible = True
            Else
                cmbReasonForRefferal.Visible = False
                lblReasonForRefferal.Visible = False
            End If
            If vFilterby = "SubMGH" Then
                Me.tbDischargeStatus.Text = "MAY GO HOME"
                lblMGHD.Visible = True
                dtpMGHDate.Visible = True
                dtpMGHTime.Visible = True
            ElseIf vFilterby = "SubUntagasMGH" Then
                Me.tbDischargeStatus.Text = "Untag MAY GO HOME"
                lblMGHD.Visible = True
                dtpMGHDate.Visible = True
                dtpMGHTime.Visible = True
            Else
                Me.tbDischargeStatus.Text = "DISCHARGE"
                lblDD.Visible = True
                dtpDDDate.Visible = True
                dtpDDTime.Visible = True
                lblMGHD.Enabled = True
                dtpMGHDate.Enabled = False
                dtpMGHTime.Enabled = False
            End If
            Me.admission.Text = "Admission Information"
        End If
    End Sub
    Public Sub removetabPHIC()
        Me.tabpatientinfo.Controls.Remove(tbDischargeStatus)
    End Sub
    Private Sub LoadPhilHealthMember(ByVal vphilhealthno As String)
        Throw New NotImplementedException
    End Sub

    'Private Function ValidateAllFields() As Boolean
    '    Dim isvalid As Boolean = True
    '    If PatientID = 0 Then
    '        isvalid = False
    '    End If
    '    If AttendingPhysician(lblAttendingPhysician) = False Then
    '        isvalid = False
    '    End If

    '    Return isvalid
    'End Function
    Private Function ValidatePatients() As Boolean
        Dim isvalid As Boolean = True

        If PatientID = 0 Then
            isvalid = False
            SetErrorProvider(Me.btnPatient, "Search patient to register.")
        End If

        If subModule = "Inpatients" Or subModule = "Inpatient" Then
            If AdmittingPhysician(lblAdmittingDoctor) = False Then
                isvalid = False
            End If
            If fSearchPAt.vIsnewborn = False And misnewborn = False Then
                If Room(lblroom) = False Then
                    isvalid = False
                End If
            Else
                ResRoom(lblroom)
            End If
        End If

        If AttendingPhysician(lblAttendingPhysician) = False And (subModule = "Outpatients" Or subModule = "Outpatient" Or subModule = "Emergency") Then     '--ALTER 10/11/2013 ADD admissiontype = "Outpatients"
            isvalid = False
        End If

        Return isvalid
    End Function
    Private Function dgobygne() As Object
        Throw New NotImplementedException
    End Function
    Private Sub chkUpdate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUpdate.CheckedChanged
        Dim dtptno = clsAdmissiondetails.loadAdmission(AdmissionID)
        'Dim dtAdmission As DataTable = clsAdmissiondetails.getadmissionid(AdmissionID, PtNo)
        Dim dtAdmission As DataTable = clsAdmissiondetails.gethospptno(admissiontype)
        If chkUpdate.Checked = True Then
            Me.lblPatientNo.Enabled = True
        Else
            Me.lblPatientNo.Enabled = False
            ResPatNo(lblPatientNo)
            If myCurrentFormStatus = enFormStatus.edit Then
                If Utility.NullToEmptyString(dtptno.Rows(0).Item("ptno")) = "" Then
                    PtNo = dtAdmission.Rows(0).Item("ptno")
                    Me.lblPatientNo.Text = PtNo
                Else
                    Me.lblPatientNo.Text = (dtptno.Rows(0).Item("ptno"))
                End If
            Else
                Me.lblPatientNo.Text = Utility.NullToZero(dtAdmission.Rows(0).Item("ptno"))
            End If
        End If
    End Sub
    Private Sub lblPatientNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPatientNo.TextChanged
        If myCurrentFormStatus = enFormStatus.edit Then
            Try
                If lblPatientNo.Enabled = True Then
                    validatePtNo(Me.lblPatientNo)
                End If
            Catch

            End Try
        End If
    End Sub
    Private Sub txtpogsgravida_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpogsgravida.TextChanged
        If IsNumeric(Me.txtpogsgravida.Text) = False Then
            Me.txtpogsgravida.Text = 0
        End If
    End Sub
    Private Sub txtpogsterm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpogsterm.TextChanged
        If IsNumeric(Me.txtpogsterm.Text) = False Then
            Me.txtpogsterm.Text = 0
        End If
    End Sub
    Private Sub txtpogsabortion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpogsabortion.TextChanged
        If IsNumeric(Me.txtpogsabortion.Text) = False Then
            Me.txtpogsabortion.Text = 0
        End If
    End Sub
    Private Sub txtpogspremature_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpogspremature.TextChanged
        If IsNumeric(Me.txtpogspremature.Text) = False Then
            Me.txtpogspremature.Text = 0
        End If
    End Sub
    Private Sub txtpogspara_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpogspara.TextChanged
        If IsNumeric(Me.txtpogspara.Text) = False Then
            Me.txtpogspara.Text = 0
        End If
    End Sub
    Private Sub txtpogsline_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpogsline.TextChanged
        If IsNumeric(Me.txtpogsline.Text) = False Then
            Me.txtpogsline.Text = 0
        End If
    End Sub
    Private Sub txtpogsaog_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpogsaog.TextChanged
        If IsNumeric(Me.txtpogsaog.Text) = False Then
            Me.txtpogsaog.Text = 0
        End If
    End Sub
    Private Sub txtsince_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsince.TextChanged
        If IsNumeric(Me.txtsince.Text) = False Then
            Me.txtsince.Text = 0
        End If
    End Sub
    Private Sub txtaog_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaog.TextChanged
        If IsNumeric(Me.txtaog.Text) = False Then
            Me.txtaog.Text = 0
        End If
    End Sub
    Private Sub txtinterval_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtinterval.TextChanged
        If IsNumeric(Me.txtinterval.Text) = False Then
            Me.txtinterval.Text = 0
        End If
    End Sub
    Private Sub txtabortion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtabortion.TextChanged
        If IsNumeric(Me.txtabortion.Text) = False Then
            Me.txtabortion.Text = 0
        End If
    End Sub
    Private Sub txtline_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtline.TextChanged
        If IsNumeric(Me.txtline.Text) = False Then
            Me.txtline.Text = 0
        End If
    End Sub
    Private Sub txtprematrue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprematrue.TextChanged
        If IsNumeric(Me.txtprematrue.Text) = False Then
            Me.txtprematrue.Text = 0
        End If
    End Sub
    Private Sub txtterm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtterm.TextChanged
        If IsNumeric(Me.txtterm.Text) = False Then
            Me.txtterm.Text = 0
        End If
    End Sub
    Private Sub txtpara_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpara.TextChanged
        If IsNumeric(Me.txtpara.Text) = False Then
            Me.txtpara.Text = 0
        End If
    End Sub
    Private Sub txtgravida_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgravida.TextChanged
        If IsNumeric(Me.txtgravida.Text) = False Then
            Me.txtgravida.Text = 0
        End If
    End Sub
#End Region

    Private Sub lblSex_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblSex.TextChanged
        Try
            If lblSex.Text = "Male" Then
                gender = "M"
                'Me.pctrPhoto.Image = Global.DominicanHIS.My.Resources.Resources.male
                imageName = ImageList1.Images.Keys(0)
            Else
                gender = "F"
                'Me.pctrPhoto.Image = Global.DominicanHIS.My.Resources.Resources.female
                imageName = ImageList1.Images.Keys(1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDoctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoctor.Click, Button1.Click
        Dim fSearchDoctor As New frmSearchEngine()
        SearchName = "Physician"
        fSearchDoctor.mModuleName = SearchName '"Physician"
        fSearchDoctor.Text = "Attending Physician"
        fSearchDoctor.ShowDialog()
        If fSearchDoctor.issave = False Then
            Exit Sub
        End If
        PogDoctorID = fSearchDoctor.mKey
        Dim dtpat As DataTable = clsAdmissiondetails.getDoctors(PogDoctorID)
        Me.txtObDoctor.Text = Utility.NullToEmptyString(dtpat.Rows(0).Item("Physician"))
    End Sub
    Private Sub txtObNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtObNo.TextChanged
        Try
            If IsNumeric(txtObNo.Text) Then
                If CDbl(txtObNo.Text) <= 0 Then
                    txtObNo.Text = ""
                End If
            ElseIf Trim(txtObNo.Text) = "" Then
                Exit Sub
            Else
                MsgBox("Invalid input. Please enter a numeric value.", MsgBoxStyle.Critical, modGlobal.msgboxTitle)
                txtObNo.Text = ""
            End If
        Catch

        End Try

    End Sub

    Private Sub cmbreferringHCI_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbreferringHCI.SelectedIndexChanged
        If cmbreferringHCI.Focused = True Then
            vid = Me.cmbreferringHCI.SelectedValue
            Call LoadHCIInfo()
        End If

    End Sub
    Private Sub LoadHCIInfo(Optional ByVal x As Integer = 1)
        Dim dt As DataTable = clsReferral.generic(vid, x)
        If dt.Rows.Count > 0 Then
            Me.txtbldgnostreet.Text = dt.Rows(0).Item("bldgnonamestreet")
            Me.txtbrgy.Text = dt.Rows(0).Item("barangay")
            Me.txtmunicipality.Text = dt.Rows(0).Item("citymunicipality")
            Me.txtprovince.Text = dt.Rows(0).Item("province")
            Me.txtzipcode.Text = dt.Rows(0).Item("zipcode")
        End If
        
    End Sub

    Private Sub btnEditReasons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditReasons.Click
        Dim frmRFR As New frmReasonForReferral(frmReasonForReferral.enFormStatus.edit)
        frmRFR.reasonreferralno = cmbReasonForRefferal.SelectedValue
        frmRFR.oldDescription = cmbReasonForRefferal.Text
        frmRFR.ShowDialog()
        If frmRFR.IsSave Then
            Call LoadReasonsforRefferal()
            cmbReasonForRefferal.SelectedValue = frmRFR.reasonreferralno
        End If
        frmRFR = Nothing
    End Sub

    Private Sub btnAddReasons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddReasons.Click
        Dim frmRFR As New frmReasonForReferral(frmReasonForReferral.enFormStatus.add)
        frmRFR.ShowDialog()
        If frmRFR.IsSave Then
            Call LoadReasonsforRefferal()
            cmbReasonForRefferal.SelectedValue = frmRFR.reasonreferralno
        End If
        frmRFR = Nothing
    End Sub

    Private Sub btnAddHCI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddHCI.Click
        Dim fHCI As New frmHCI
        fHCI.myFormStatus = frmHCI.enFormStatus.add
        fHCI.ShowDialog()
        If fHCI.isSave Then
            Call loadReferringHCI()
            vid = fHCI.HCIId
            Me.cmbreferringHCI.SelectedValue = vid
            Call LoadHCIInfo()
        End If
        fHCI = Nothing
    End Sub

    Private Sub btnEditHCI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditHCI.Click
        Dim fHCI As New frmHCI
        fHCI.myFormStatus = frmHCI.enFormStatus.edit
        fHCI.HCIId = Me.cmbreferringHCI.SelectedValue
        fHCI.ShowDialog()
        If fHCI.isSave Then
            Call loadReferringHCI()
            Me.cmbreferringHCI.SelectedValue = fHCI.HCIId
        End If
        fHCI = Nothing
    End Sub

    Private Sub btnAddCase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCase.Click
        Dim frm As New frmSearchEngine
        frm.mModuleName = "Cases"
        frm.caseratetype = 1
        frm.ShowDialog()
        If frm.issave = True Then
            caseno = frm.mKey
            Me.txtAdmittingDiagnosis.Text = frm.mICD10Description
        End If
    End Sub

    Private Sub btnRemCase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemCase.Click
        caseno = 0
        Me.txtAdmittingDiagnosis.Text = ""
    End Sub

    Private Sub chkothers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkothers.CheckedChanged
        Me.txtothers.ReadOnly = Not Me.chkothers.Checked
        If Not Me.chkothers.Checked Then
            Me.txtothers.Text = ""
        End If
    End Sub

    Private Sub chkPain_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPain.CheckedChanged
        Me.txtpain.ReadOnly = Not Me.chkPain.Checked
        If Not Me.chkPain.Checked Then
            Me.txtpain.Text = ""
        End If
    End Sub

    Private Sub chksurvey_alteredsensorium_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksurvey_alteredsensorium.CheckedChanged
        txtalteredsersorium.ReadOnly = Not Me.chksurvey_alteredsensorium.Checked
        If Not Me.chksurvey_alteredsensorium.Checked Then
            Me.txtalteredsersorium.Text = ""
        Else
            Me.chksurvey_awakeandalert.Checked = False
        End If
    End Sub

    Private Sub chksurvey_awakeandalert_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksurvey_awakeandalert.CheckedChanged
        If Me.chksurvey_awakeandalert.Checked Then
            Me.txtalteredsersorium.Text = ""
            Me.chksurvey_alteredsensorium.Checked = False
        End If
    End Sub

    Private Sub chkessentialnewborncare_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chknewborncare.CheckedChanged
        If Me.chknewborncare.Checked Then
            Me.gpessential.Enabled = True
        Else
            Me.gpessential.Enabled = False
            Me.chkndying.Checked = False
            Me.chknearlyskin.Checked = False
            Me.chkntimelycord.Checked = False
            Me.chkneyepro.Checked = False
            Me.chknweighing.Checked = False
            Me.chknvitk.Checked = False
            Me.chknbcg.Checked = False
            Me.chknnoneseparation.Checked = False
            Me.chknhepa.Checked = False
        End If
    End Sub

    Private Sub chknewbornscreening_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chknewbornscreening.CheckedChanged
        If Not Me.chknewbornscreening.Checked Then
            Me.txtfiltercardno.Text = ""
        End If
        Me.txtfiltercardno.ReadOnly = Not Me.chknewbornscreening.Checked
    End Sub

    
    Private Sub cmbDepartment_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDepartment.SelectionChangeCommitted
        Call removetabs() 
        Call ShowDepartmentTabs()
    End Sub

    Private Sub tsPrint_Click(sender As System.Object, e As System.EventArgs) Handles tsPrint.Click
        'Dim fReport As New frmReportHandler
        'fReport.varno = AdmissionID
        'fReport.printType = "History and PE"
        'fReport.Show()
    End Sub

    Private Sub chknewbornhearing_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chknewbornhearing.CheckedChanged
        If Me.chknewbornhearing.Checked Then
            Me.gpnewbornhearing.Enabled = True
        Else
            Me.gpnewbornhearing.Enabled = False
            Me.txtnewbornhearingregno.Text = ""
            Me.cmbnewbornhearingresult.SelectedValue = clsModel.NewbornHearingTestResult.NA
        End If
    
    End Sub

    Private Sub txtapgarR5_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtapgarR5.KeyPress, txtapgarR1.KeyPress, txtapgarP5.KeyPress, txtapgarP1.KeyPress, txtapgarG5.KeyPress, txtapgarG1.KeyPress, txtapgarAC5.KeyPress, txtapgarAC1.KeyPress, txtapgarA5.KeyPress, txtapgarA1.KeyPress
        Dim tb As TextBox = CType(sender, TextBox)
        If Not (tb.Text & e.KeyChar = "2" Or tb.Text & e.KeyChar = "1" Or tb.Text & e.KeyChar = "0" Or e.KeyChar = ChrW(Keys.Back)) Then    'Check if Numeric
            e.Handled = True
        End If
    End Sub

    Private Sub txtapgarA1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtapgarR1.TextChanged, txtapgarP1.TextChanged, txtapgarG1.TextChanged, txtapgarAC1.TextChanged, txtapgarA1.TextChanged
        Me.txtapgarscore1.Text = Val(txtapgarR1.Text) + Val(txtapgarP1.Text) + Val(txtapgarG1.Text) + Val(txtapgarAC1.Text) + Val(txtapgarA1.Text)
    End Sub

    Private Sub txtapgarA5_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtapgarR5.TextChanged, txtapgarP5.TextChanged, txtapgarG5.TextChanged, txtapgarAC5.TextChanged, txtapgarA5.TextChanged
        Me.txtapgarscore5.Text = Val(txtapgarR5.Text) + Val(txtapgarP5.Text) + Val(txtapgarG5.Text) + Val(txtapgarAC5.Text) + Val(txtapgarA5.Text)
    End Sub

    Private Sub btninterviewedby_Click(sender As System.Object, e As System.EventArgs) Handles btninterviewedby.Click
        Dim fSearch As New frmSearchEngine()
        SearchName = "Employees"
        fSearch.mModuleName = frmSearchEngine.ModuleName.Employees    'SearchName
        fSearch.Text = "Interviewed By"
        fSearch.ShowDialog()
        If fSearch.issave = False Then
            Exit Sub
        End If
        Call LoadInterviewedBy(fSearch.mKey)
    End Sub
    Private Sub LoadInterviewedBy(ByVal mkey As Long)
        Dim dtpat As DataTable = clsUsers.GetUser(1, "", "", mkey)
        If dtpat.Rows.Count = 0 Then
            Exit Sub
        End If
        Me.interviewedbyid = mkey
        Me.txtinterviewedby.Text = Utility.NullToEmptyString(UCase(dtpat.Rows(0).Item("firstname") & " " & dtpat.Rows(0).Item("lastname")))
    End Sub
End Class
