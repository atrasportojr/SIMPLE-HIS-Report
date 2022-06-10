Imports System.Drawing.Drawing2D
Public Class frmPrescription

#Region "Variables"
    Dim erp As New ErrorProvider
    Public isSave As Boolean
    Public myFormStatus As enFormStatus
    Dim stats As String
    Public admissionID As String
    Dim dtRecord As New DataTable()
    Dim dtFrequency As New DataTable
    Dim indicator, _
        itemcount As Integer
    Public oldprescriptionid, _
        oldrefpatientrequestno As Long
#End Region
    Enum enFormStatus
        browsing = 0 : add = 1 : edit = 2 : view = 3
    End Enum
#Region "New Methods"
    Sub New(ByVal FormStatus As enFormStatus)
        InitializeComponent() : myFormStatus = FormStatus : loadDrugCode("")
    End Sub
#End Region
    'Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frmdrugcode As New frmDrugItems(frmDrugItems.enFormStatus.browsing)
    '    frmdrugcode.dtitems.Size = New Size(778, 334)
    '    frmdrugcode.dtitems.Location = New Point(5, 101)
    '    frmdrugcode.ShowDialog()
    'End Sub
    Public Function isExistFromTemplates(ByVal str As String, ByVal word As String)
        Dim ok As Boolean = False
        If str = "N/A External Drug" Then
            For ctr = 0 To Me.dvgListOfPrescribedMedicines.Rows.Count - 1
                If word = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldrugname.Index).Value Then
                    ok = True : Exit For
                End If
            Next
        Else
            For ctr = 0 To Me.dvgListOfPrescribedMedicines.Rows.Count - 1
                If str = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldrugcode.Index).Value Then
                    ok = True : Exit For
                End If
            Next
        End If
        Return ok
    End Function
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New frmPrescriptionTemplates()
IDRIZ:
        frm.ShowDialog()
        If frm.dgvListOfPrescription.Rows.Count > 0 Then
            If frm.dgvListOfPrescription.CurrentCell.RowIndex >= 0 And frm.ok Then
                If isExistFromTemplates(frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(10).Value, frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(4).Value) = False Then
                    Me.dvgListOfPrescribedMedicines.Rows.Add(1)
                    Dim dgvcc As DataGridViewComboBoxCell
                    Dim dgvcc1 As DataGridViewComboBoxCell
                    Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colid.Index).Value = 0
                    Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(coldrugname.Index).Value = frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(4).Value
                    If frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(10).Value <> "N/A External Drug" Then
                        Dim dt As DataTable = clsDashboard.getMyPatients(13, frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(10).Value)
                        If dt.Rows.Count > 0 Then
                            If dt.Rows(0).Item("stats").ToString() = "Unavailable" Then
                                Me.dvgListOfPrescribedMedicines.Item(colavailability.Index, Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Style.ForeColor = Color.Red
                                Me.dvgListOfPrescribedMedicines.Item(colavailability.Index, Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Style.SelectionForeColor = Color.Red
                            End If
                            Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colavailability.Index).Value = dt.Rows(0).Item("stats").ToString()
                        End If
                    Else
                        Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colavailability.Index).Value = "Outside"
                    End If
                    Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colquantity.Index).Value = frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(8).Value
                    Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(coldosage.Index).Value = frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(6).Value
                    Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colperiod.Index).Value = frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(11).Value
                    Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(coldrugcode.Index).Value = frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(10).Value
                    dgvcc = Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colper.Index)
                    dgvcc.Items.Add(New DictionaryEntry("day/s", "1"))
                    dgvcc.Items.Add(New DictionaryEntry("week/s", "2"))
                    dgvcc.Items.Add(New DictionaryEntry("month/s", "3"))
                    dgvcc.DisplayMember = "Key"
                    dgvcc.ValueMember = "Value"
                    dgvcc.DataSource = dgvcc.Items
                    dgvcc1 = Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colfrequency.Index)
                    dgvcc1.DataSource = Me.dtFrequency
                    dgvcc1.DisplayMember = "description"
                    dgvcc1.ValueMember = "frequencyid"
                    dgvcc1.Value = CInt(frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(13).Value)
                    Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colper.Index).Value = Convert.ToString(frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(12).Value)
                    Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(coltemplate.Index).Value = "From Templates"
                    If frm.ok Then : GoTo IDRIZ : Else : Exit Sub : End If
                Else
                    If (MessageBox.Show("The prescription template that you have selected was already in the list of prescribed medicines." & vbNewLine & vbNewLine & "Item name : " & frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(4).Value & vbNewLine & vbNewLine & "Would you like to retry and select another prescription template?", modGlobal.msgboxTitle, MessageBoxButtons.RetryCancel, MessageBoxIcon.Information)) = DialogResult.Retry Then
                        GoTo IDRIZ
                    Else : Exit Sub : End If
                End If
            End If
        End If
    End Sub
    Private Function AllDataEntryFieldsAreValid() As Boolean
        SetErrorProvider(Me.cmbphysician)
        Dim blnValid As Boolean = True
        If Me.cmbphysician.SelectedIndex < 0 Then
            SetErrorProvider(Me.cmbphysician, "This field is required")
            blnValid = False
            Return blnValid
            Exit Function
        End If
        If Me.chkatemp.Checked Then
            If isFieldValid(Me.txtTemplateName) = False Then
                blnValid = False
                Return blnValid
                Exit Function
            End If
        End If
        If Me.chkatemp.Checked Then
            If isTemplateNameValid(Me.txtTemplateName) = False Then
                blnValid = False
                Return blnValid
                Exit Function
            End If
        End If
        Return blnValid
    End Function
    Private Sub ResetAllErrorProviders()
        SetErrorProvider(Me.txtTemplateName)
    End Sub
    Private Sub ClearAllErrorProviders()
        clearErrorProvider(Me.txtTemplateName)
    End Sub
    Private Sub SetErrorProvider(ByVal ctl As Control, Optional ByVal strErrorMessage As String = "")
        erp.SetError(ctl, strErrorMessage)
    End Sub
    Private Sub clearErrorProvider(ByVal ctl As Control, Optional ByVal strErrorMessage As String = "")
        erp.Clear()
    End Sub
    Private Function isFieldValid(ByVal ctl As Control)
        Dim isValid As Boolean
        If ctl.Text = "" Then
            SetErrorProvider(ctl, "This field is required.")
            isValid = False
        Else
            ResetAllErrorProviders()
            isValid = True
        End If
        Return isValid
    End Function
    Private Function isTemplateNameValid(ByVal ctl As Control)
        Dim isValid As Boolean
        Dim dt As DataTable
        If myFormStatus = enFormStatus.add Then
            dt = clsDashboard.getMyPatients(25, ctl.Text)
        Else
            Dim dtspec = clsDashboard.getMyPatients(11, oldprescriptionid)
            dt = clsDashboard.getMyPatients(26, ctl.Text, 0, 0, dtspec.Rows(0).Item("name").ToString())
        End If
        If ctl.Text = "" Then
            SetErrorProvider(ctl, "This field is required.")
            isValid = False
        Else
            If dt.Rows.Count > 0 Then
                Me.labelwarning.Visible = True
                SetErrorProvider(ctl, "This field is required.")
                isValid = False
            Else
                Me.labelwarning.Visible = False
                ResetAllErrorProviders()
                isValid = True
            End If
        End If
        Return isValid
    End Function
    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        subSave()
    End Sub
    Private Sub subSave()
        If AllDataEntryFieldsAreValid() = False Then
            Exit Sub
        Else
            If MsgBox("Are you sure you want to " & Me.tsSave.Text.ToLower() & " this Prescription?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, modGlobal.msgboxTitle) = MsgBoxResult.Yes Then
                If save() Then
                    MessageBox.Show("Record successfully " & Me.tsSave.Text.ToLower() & "d.", modGlobal.msgboxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.dvgListOfPrescribedMedicines.ReadOnly = True
                    enabledFields(False)
                    isSave = True
                    Me.Button4.Visible = False
                    Me.Button2.Visible = False
                    Me.txtDrugname.Visible = False
                    Me.TextBox2.Visible = False
                    'Call SaveLog("Doctor Dashboard Requisition", "Doctor Department Request", modGlobal.userid)
                Else
                    MsgBox("Transaction cancelled. You may try again thank you", MsgBoxStyle.Information, modGlobal.msgboxTitle)
                End If
            End If
        End If
    End Sub
    Private Sub enabledFields(ByVal sw As Boolean)
        Me.txtTemplateName.Enabled = sw
        Me.chkatemp.Enabled = sw
        Me.lblSatemp.Enabled = sw
        Me.dtTime.Enabled = sw
        Me.Button1.Enabled = sw
        Me.tsSave.Visible = sw
        Me.txtSpecial.Enabled = sw
        Me.txtExternal.Enabled = sw
        Me.Button1.Enabled = sw
        Me.Button6.Enabled = sw
        Me.dtTime.Enabled = sw
        Me.btnaddexternal.Enabled = sw
    End Sub
    Private Function save(Optional ByVal id As Long = 0) As Boolean
        Dim x As New clsDashboard()
        Dim isPost As Boolean
        Dim cRequisition As New clsRequisition()
        Dim hasPostMeds As Boolean
        For ctr = 0 To Me.dvgListOfPrescribedMedicines.Rows.Count - 1
            If Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldrugcode.Index).Value <> "N/A External Drug" Then
                hasPostMeds = True
                Exit For
            End If
        Next
        'save Request
        If hasPostMeds And Me.chkpostrequisition.Checked Then
            If myFormStatus = enFormStatus.add Then
                If MsgBox("Would you like to post this request?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, modGlobal.msgboxTitle) = MsgBoxResult.Yes Then
                    isPost = True
                End If
            Else
                If oldrefpatientrequestno = 0 Then
                    If MsgBox("Would you like to post this request?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, modGlobal.msgboxTitle) = MsgBoxResult.Yes Then
                        isPost = True
                    Else
                        isPost = False
                    End If
                Else
                    isPost = True
                End If
            End If
        End If
        If isPost Then
            Dim fLogin As New frmRequestedBy
            fLogin.ShowDialog()

            If fLogin.isLoginValid Then
                cRequisition.registrydetailno = admissionID
                cRequisition.sourceoffice = modGlobal.sourceOfficeCode
                Dim transDt As New DataTable
                transDt = clsRequisition.getTransno(modGlobal.sourceOfficeCode)
                cRequisition.documentno = "PReq" & modGlobal.sourceOfficeCode & "-" & Format(transDt.Rows(0).Item("reqtransno"), "00000")
                cRequisition.purpose = "Doctors prescription request."
                cRequisition.requestedbyid = fLogin.RequestedByID
                cRequisition.daterequested = Utility.GetServerDate()
                cRequisition.dateapproved = Utility.GetServerDate()
                cRequisition.daterender = Utility.GetServerDate()
                cRequisition.destinationofficemaster = "001"
                If oldrefpatientrequestno = 0 Then

                    cRequisition.patientrequestno = cRequisition.Save(True)

                    x.patientrequestno = cRequisition.patientrequestno
                    Me.oldrefpatientrequestno = x.patientrequestno
                    x.approvedbyid = fLogin.RequestedByID
                    x.dateapproved = Utility.GetServerDate()
                    x.updateRequest(False) 'Update Request
                End If
            Else
                If fLogin.isSubModal Then
                    MsgBox("The username or password is invalid or the account is inactive. Please try again.", MsgBoxStyle.Information, modGlobal.msgboxTitle)
                End If
                isPost = False
                Return False
                Exit Function
            End If
        End If

        'Save Master prescription
        x.oldprescriptionid = oldprescriptionid
        x.admissionid = admissionID
        x.description = Me.txtSpecial.Text
        x.xdate = Me.dtTime.Value
        x.physician = Me.cmbphysician.SelectedValue
        x.name = Me.txtTemplateName.Text
        x.istemplate = IIf(Me.chkatemp.Checked, 1, 0)
        x.isdeleted = False
        x.createdbyid = modGlobal.employeeid
        If myFormStatus = enFormStatus.add Then
            If isPost Then
                x.refpatientrequestno = cRequisition.patientrequestno
            Else
                x.refpatientrequestno = Nothing
            End If
            oldprescriptionid = x.save(True, 0)
        Else
            If oldrefpatientrequestno <> 0 Then
                x.refpatientrequestno = oldrefpatientrequestno
            Else
                If isPost Then
                    x.refpatientrequestno = cRequisition.patientrequestno
                Else
                    x.refpatientrequestno = Nothing
                End If
            End If
            x.save(False, 0)
        End If

        'Save Prescription Details
        For ctr = 0 To Me.dvgListOfPrescribedMedicines.Rows.Count - 1
            x.oldpresecriptiondetailsid = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colid.Index).Value
            x.oldprescriptionid = oldprescriptionid
            If Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(8).Value = "" Or Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldrugcode.Index).Value = "N/A External Drug" Then
                x.drugcode = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldrugname.Index).Value
            Else
                x.drugcode = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldrugcode.Index).Value
            End If
            x.frequency = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colfrequency.Index).Value
            x.quantity = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colquantity.Index).Value
            x.dosage = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldosage.Index).Value
            x.period = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colperiod.Index).Value
            x.per = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colper.Index).Value
            If myFormStatus = enFormStatus.add Then
                x.save(True, 2)
            Else
                If Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colid.Index).Value = 0 Then
                    x.save(True, 2)
                Else
                    x.save(False, 2)
                End If
            End If
        Next

        'Save request details
        For i As Integer = 0 To dvgListOfPrescribedMedicines.Rows.Count - 1
            If Me.dvgListOfPrescribedMedicines.Rows(i).Cells(coldrugcode.Index).Value <> "N/A External Drug" And Me.dvgListOfPrescribedMedicines.Rows(i).Cells(coldrugcode.Index).Value <> "" Then
                dtRecord = clsDashboard.getMyPatients(24, oldrefpatientrequestno, 0, 0, Me.dvgListOfPrescribedMedicines.Rows(i).Cells(coldrugcode.Index).Value.ToString().Trim())
                If myFormStatus = enFormStatus.add Then
                    If isPost Then
                        cRequisition.itemcode = Me.dvgListOfPrescribedMedicines.Rows(i).Cells(coldrugcode.Index).Value
                        cRequisition.quantityrequested = Me.dvgListOfPrescribedMedicines.Rows(i).Cells(colquantity.Index).Value
                        cRequisition.quantityrendered = Me.dvgListOfPrescribedMedicines.Rows(i).Cells(colquantity.Index).Value
                        cRequisition.frequencyid = Me.dvgListOfPrescribedMedicines.Rows(i).Cells(colfrequency.Index).Value
                        cRequisition.remarks = Me.dvgListOfPrescribedMedicines.Rows(i).Cells(coldosage.Index).Value
                        cRequisition.destinationoffice = "001"
                        cRequisition.stat = 2
                        cRequisition.saveDetails(True)
                    End If
                Else
                    If dtRecord.Rows.Count = 0 Then
                        If isPost Then
                            cRequisition.itemcode = Me.dvgListOfPrescribedMedicines.Rows(i).Cells(coldrugcode.Index).Value
                            cRequisition.quantityrequested = Me.dvgListOfPrescribedMedicines.Rows(i).Cells(colquantity.Index).Value
                            cRequisition.quantityrendered = Me.dvgListOfPrescribedMedicines.Rows(i).Cells(colquantity.Index).Value
                            cRequisition.frequencyid = Me.dvgListOfPrescribedMedicines.Rows(i).Cells(colfrequency.Index).Value
                            cRequisition.remarks = Me.dvgListOfPrescribedMedicines.Rows(i).Cells(coldosage.Index).Value
                            cRequisition.destinationoffice = "001"
                            cRequisition.stat = 2
                            cRequisition.patientrequestno = x.refpatientrequestno
                            cRequisition.saveDetails(True)
                        End If
                    Else
                        cRequisition.itemcode = Me.dvgListOfPrescribedMedicines.Rows(i).Cells(coldrugcode.Index).Value
                        cRequisition.quantityrequested = Me.dvgListOfPrescribedMedicines.Rows(i).Cells(colquantity.Index).Value
                        cRequisition.quantityrendered = Me.dvgListOfPrescribedMedicines.Rows(i).Cells(colquantity.Index).Value
                        cRequisition.frequencyid = Me.dvgListOfPrescribedMedicines.Rows(i).Cells(colfrequency.Index).Value
                        cRequisition.remarks = Me.dvgListOfPrescribedMedicines.Rows(i).Cells(coldosage.Index).Value
                        cRequisition.destinationoffice = "001"
                        cRequisition.stat = 2
                        cRequisition.patientrequestno = x.refpatientrequestno
                        cRequisition.saveDetails(False)
                    End If
                End If
            End If
        Next
        isPost = False
        Return True
    End Function
    Private Sub tsClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsClose.Click
        Me.Close()
    End Sub
    Public Sub loadDrugCode(Optional ByVal str As String = "")
        Me.txtExternal.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtExternal.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim dt1 As DataTable = clsDashboard.getMyPatients(27, "")
        Dim x1 As New AutoCompleteStringCollection
        For i = 0 To dt1.Rows.Count - 1
            x1.Add(dt1.Rows(i).Item("GenericName").ToString())
        Next
        Me.txtExternal.AutoCompleteCustomSource = x1
    End Sub



    Private Sub dvgListOfPrescribedMedicines_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dvgListOfPrescribedMedicines.CellPainting
        'If e.ColumnIndex = 8 AndAlso e.RowIndex >= 0 Then
        '    e.Paint(e.CellBounds, DataGridViewPaintParts.All)
        '    Dim bmpFind As Bitmap = modGlobal.remove_icon ' ImageList1.Images(0)
        '    Dim ico As Icon = Icon.FromHandle(bmpFind.GetHicon)
        '    e.Graphics.DrawIcon(ico, e.CellBounds.Left + 3, e.CellBounds.Top + 3)
        '    e.Handled = True
        'End If
    End Sub

    Private Sub frmPrescription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.tstitle.Text = modGlobal.msgboxTitle & " ©" & Utility.GetServerDate().Year
        dtRecord.Rows.Clear()
        Me.dtTime.CustomFormat = "MM/dd/yyyy hh:mm tt"
        dtRecord = clsDashboard.getMyPatients(1, admissionID)
        dtFrequency = clsFrequency.getInfo(1, "")
        Me.KeyPreview = True
        Me.lblPatientNo.Text = dtRecord.Rows(0).Item("Patient No").ToString()
        Me.lblAddress.Text = dtRecord.Rows(0).Item("Address").ToString()
        Me.lblHospno.Text = Utility.formatHospitalNumber(dtRecord.Rows(0).Item("Hospital No").ToString())
        Me.lblPatient.Text = dtRecord.Rows(0).Item("Name").ToString()
        Me.lblAge.Text = dtRecord.Rows(0).Item("Age").ToString()
        If dtRecord.Rows(0).Item("Gender").ToString() = "F" Then
            Me.lblGender.Text = "Female"
        Else
            Me.lblGender.Text = "Male"
        End If
        With Me.cmbphysician
            If dtRecord.Rows(0).Item("admittingphysicianid") > 0 Then
                .Items.Add(New DictionaryEntry(dtRecord.Rows(0).Item("admittingphysician"), dtRecord.Rows(0).Item("admittingphysicianid")))
            End If
            If dtRecord.Rows(0).Item("admittingphysicianid") <> dtRecord.Rows(0).Item("attendingphysicianid") And dtRecord.Rows(0).Item("attendingphysicianid") > 0 Then
                .Items.Add(New DictionaryEntry(dtRecord.Rows(0).Item("attendingphysician"), dtRecord.Rows(0).Item("attendingphysicianid")))
            End If
            .DisplayMember = "Key"
            .ValueMember = "Value"
            .DataSource = .Items
            If .Items.Count > 0 Then
                .SelectedIndex = 0
            End If
        End With
        If myFormStatus = enFormStatus.add Then
            Me.tsSave.Text = "Save" : enabledFields(True)
            Me.tsprint.Visible = False
            Me.tsseparatorprint.Visible = False
        ElseIf myFormStatus = enFormStatus.edit Then
            loadRecord() : Me.tsSave.Text = "Update" : enabledFields(True)
        Else
            enabledFields(False)
        End If
        Me.tsSave.Image = modGlobal.save_icon
        Me.tsClose.Image = modGlobal.close_icon
        Me.Button2.Image = modGlobal.remove_icon
        indicator += 1

    End Sub

    Private Sub paintForm(ByVal sender As Object, ByVal e As PaintEventArgs) 'Handles MyBase.Paint, TabPage3.Paint, TabPage1.Paint
        Dim mGraphics As Graphics = e.Graphics
        Dim pen1 As Pen = New Pen(Color.FromArgb(252, 254, 255), 1)
        Dim Area1 As Rectangle = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1) '253, 254, 255
        Dim LGB As LinearGradientBrush = New LinearGradientBrush(Area1, Color.FromArgb(252, 254, 255), Color.ForestGreen, LinearGradientMode.Vertical)
        mGraphics.FillRectangle(LGB, Area1)
        mGraphics.DrawRectangle(pen1, Area1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        addMed()
    End Sub
    Private Sub loadRecord()
        dtRecord.Rows.Clear()
        dtRecord = clsDashboard.getMyPatients(11, oldprescriptionid)
        If dtRecord.Rows.Count = 0 Then
            MsgBox("Prescription not found!", MsgBoxStyle.Information)
            Me.Close()
            Exit Sub
        End If
        Me.txtSpecial.Text = dtRecord.Rows(0).Item("desc").ToString()
        Me.chkatemp.Checked = dtRecord.Rows(0).Item("istemplate")
        Me.txtTemplateName.Text = dtRecord.Rows(0).Item("name").ToString()
        Me.oldrefpatientrequestno = Utility.NullToZero(dtRecord.Rows(0).Item("refpatientrequestno"))
        Me.cmbphysician.SelectedValue = dtRecord.Rows(0).Item("physician")
        Me.dtTime.Value = Utility.NullToCurrentDate(dtRecord.Rows(0).Item("date"))
        Me.chkpostrequisition.Checked = Me.oldrefpatientrequestno > 0
        For ctr = 0 To dtRecord.Rows.Count - 1
            Me.dvgListOfPrescribedMedicines.Rows.Add(1)
            Dim dgvcc As DataGridViewComboBoxCell
            Dim dgvcc1 As DataGridViewComboBoxCell
            Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colid.Index).Value = dtRecord.Rows(ctr).Item("id").ToString()
            Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldrugname.Index).Value = dtRecord.Rows(ctr).Item("Drug Name").ToString()
            If dtRecord.Rows(ctr).Item("drugcode").ToString() <> "N/A External Drug" Then
                Dim dt As DataTable = clsDashboard.getMyPatients(13, dtRecord.Rows(ctr).Item("drugcode").ToString())
                If dt.Rows.Count > 0 Then
                    Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colavailability.Index).Value = dt.Rows(0).Item("stats").ToString()
                    If dt.Rows(0).Item("stats").ToString() = "Unavailable" Then
                        Me.dvgListOfPrescribedMedicines.Item(colavailability.Index, Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Style.ForeColor = Color.Red
                        Me.dvgListOfPrescribedMedicines.Item(colavailability.Index, Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Style.SelectionForeColor = Color.Red
                    End If
                End If
            Else
                Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colavailability.Index).Value = "Outside"
            End If
            Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colquantity.Index).Value = dtRecord.Rows(ctr).Item("quantity").ToString()
            Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldosage.Index).Value = dtRecord.Rows(ctr).Item("dosage").ToString()
            Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colperiod.Index).Value = dtRecord.Rows(ctr).Item("period").ToString()
            dgvcc = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colper.Index)
            dgvcc.Items.Add(New DictionaryEntry("day/s", "1"))
            dgvcc.Items.Add(New DictionaryEntry("week/s", "2"))
            dgvcc.Items.Add(New DictionaryEntry("month/s", "3"))
            dgvcc.DisplayMember = "Key"
            dgvcc.ValueMember = "Value"
            dgvcc.DataSource = dgvcc.Items
            Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colper.Index).Value = dtRecord.Rows(ctr).Item("per").ToString()

            dgvcc1 = Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colfrequency.Index)
            dgvcc1.DataSource = Me.dtFrequency
            dgvcc1.DisplayMember = "description"
            dgvcc1.ValueMember = "frequencyid"
            dgvcc1.Value = CInt(Utility.NullToZero(dtRecord.Rows(ctr).Item("frequency")))
            Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldrugcode.Index).Value = dtRecord.Rows(ctr).Item("drugcode").ToString()
            Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colptrequestno.Index).Value = Me.oldrefpatientrequestno
        Next
    End Sub
    Public Function isExist(ByVal str As String)
        Dim ok As Boolean = False
        For ctr = 0 To Me.dvgListOfPrescribedMedicines.Rows.Count - 1
            If str = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(8).Value Then
                ok = True : Exit For
            End If
        Next
        Return ok
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.dvgListOfPrescribedMedicines.Rows.Count > 0 Then
            Dim hasSelect As Boolean
            For ctr = 0 To Me.dvgListOfPrescribedMedicines.Rows.Count - 1
                If Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(1).Value = True Then
                    hasSelect = True : Exit For
                End If
            Next
            If hasSelect Then
                If MessageBox.Show("Are you sure you want to remove the selected medicine from the list?", modGlobal.msgboxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    Dim ok = False : Dim str As String = ""
                    Dim myEmp As New clsDashboard()
                    Dim counter As Integer = Me.dvgListOfPrescribedMedicines.Rows.Count - 1
                    For ctr = 0 To counter
                        If Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(1).Value = True Then
                            If Convert.ToString(Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(0).Value) <> 0 Then
                                dtRecord.Rows.Clear()
                                If Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldrugcode.Index).Value = "N/A External Drug" Then
                                    dtRecord = clsDashboard.getMyPatients(32, Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colptrequestno.Index).Value, 0, 0, Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(8).Value, Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(10).Value)
                                Else
                                    dtRecord = clsDashboard.getMyPatients(23, admissionID, 0, 0, Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldrugcode.Index).Value, Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colptrequestno.Index).Value)
                                End If
                                If dtRecord.Rows(0).Item("indicate") <> 0 Then
                                    myEmp.Deleterequestdetails(admissionID, Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldrugcode.Index).Value, Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colptrequestno.Index).Value)
                                Else
                                    itemcount += 1
                                End If
                                myEmp.DeleteSelectedPrescription(Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colid.Index).Value)
                                Me.dvgListOfPrescribedMedicines.Rows.RemoveAt(ctr)
                                If ctr = 0 Then
                                    ctr -= 1
                                Else
                                    ctr -= ctr + 1
                                End If
                                counter -= 1
                            Else
                                Me.dvgListOfPrescribedMedicines.Rows.RemoveAt(ctr)
                                If ctr = 0 Then
                                    ctr -= 1
                                Else
                                    ctr -= ctr + 1
                                End If
                                counter -= 1
                            End If
                        End If
                        If ctr = counter Then
                            Exit For
                        End If
                    Next
                    If Me.dvgListOfPrescribedMedicines.Rows.Count = 0 Then
                        clsDashboard.DeleteMainPrescription(oldprescriptionid)
                        myEmp.Deleterequest(oldrefpatientrequestno)
                        Me.oldrefpatientrequestno = 0
                    End If
                Else
                    For ctr = 0 To Me.dvgListOfPrescribedMedicines.Rows.Count - 1
                        Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(1).Value = False
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub lblSatemp_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblSatemp.LinkClicked
        Me.chkatemp.Checked = True
        Me.txtTemplateName.Enabled = True
    End Sub

    Private Sub chkatemp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkatemp.CheckedChanged
        If Me.chkatemp.Checked Then
            Me.chkatemp.Checked = True
            Me.txtTemplateName.Enabled = True
        Else
            Me.txtTemplateName.Enabled = False
            Me.chkatemp.Checked = False
        End If
    End Sub

    Private Sub frmPrescription_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.Control = True And e.KeyCode = Keys.S And isSave = False Then
            subSave()
        ElseIf e.Control = True And e.KeyCode = Keys.T Then
            Dim frm As New frmPrescriptionTemplates()
BACK:
            frm.ShowDialog()
            If frm.dgvListOfPrescription.Rows.Count > 0 Then


                If frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(8).Selected = True Then
                    If isExistFromTemplates(frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(9).Value, frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(4).Value) = False Then
                        Me.dvgListOfPrescribedMedicines.Rows.Add(1)
                        Dim dgvcc As DataGridViewComboBoxCell
                        Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(0).Value = frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(0).Value
                        Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(2).Value = frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(4).Value
                        If frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(9).Value <> "N/A External Drug" Then
                            Dim dt As DataTable = clsDashboard.getMyPatients(13, frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(9).Value)
                            If dt.Rows.Count > 0 Then
                                Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(3).Value = dt.Rows(0).Item("stats").ToString()
                            End If
                        Else
                            Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(3).Value = "Outside"

                        End If
                        Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(4).Value = frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(5).Value
                        Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(5).Value = frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(6).Value
                        Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(6).Value = frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(10).Value
                        Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(8).Value = frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(9).Value
                        dgvcc = Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(7)
                        dgvcc.Items.Add(New DictionaryEntry("day/s", "1"))
                        dgvcc.Items.Add(New DictionaryEntry("week/s", "2"))
                        dgvcc.Items.Add(New DictionaryEntry("month/s", "3"))
                        dgvcc.DisplayMember = "Key"
                        dgvcc.ValueMember = "Value"
                        dgvcc.DataSource = dgvcc.Items
                        Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(7).Value = Convert.ToString(frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(11).Value)
                        Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(9).Value = "From Templates"
                        If frm.ok Then
                            GoTo BACK
                        Else : Exit Sub : End If
                    Else
                        If (MessageBox.Show("The template you've selected has already exist from list of prescribe medicines." & vbNewLine & vbNewLine & "Item name : " & frm.dgvListOfPrescription.Rows(frm.dgvListOfPrescription.CurrentRow.Index).Cells(4).Value & vbNewLine & vbNewLine & "Would you like to retry to select another template?", modGlobal.msgboxTitle, MessageBoxButtons.RetryCancel, MessageBoxIcon.Information)) = DialogResult.Retry Then
                            GoTo BACK
                        Else : Exit Sub : End If
                    End If
                End If
            End If
        ElseIf e.KeyCode = Keys.Enter And Me.TabControl1.SelectedIndex = 0 Then
            addMed()
        ElseIf e.KeyCode = Keys.Enter And Me.TabControl1.SelectedIndex = 1 Then
            Me.btnaddexternal.PerformClick()
        End If
    End Sub

    Private Sub dvgListOfPrescribedMedicines_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dvgListOfPrescribedMedicines.DataError
        If TypeOf (e.Exception) Is ConstraintException Then
            Dim view As DataGridView = DirectCast(sender, DataGridView)
            view.Rows(e.RowIndex).ErrorText = "an error"
            view.Rows(e.RowIndex).Cells(e.ColumnIndex).ErrorText = "an error"
            e.ThrowException = False
        End If
    End Sub

    Private Sub dvgListOfPrescribedMedicines_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dvgListOfPrescribedMedicines.CurrentCellDirtyStateChanged
        If (dvgListOfPrescribedMedicines.IsCurrentCellDirty) Then
            dvgListOfPrescribedMedicines.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddexternal.Click
        If Me.txtExternal.Text = "" Then
            MessageBox.Show("Please enter a drug name.", modGlobal.msgboxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf isExistExternal(Me.txtExternal.Text, "N/A External Drug") = False Then
            Me.dvgListOfPrescribedMedicines.Rows.Add(1)
            Dim dgvcc As DataGridViewComboBoxCell
            Dim dgvcc1 As DataGridViewComboBoxCell
            Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(coldrugname.Index).Value = Me.txtExternal.Text
            Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colavailability.Index).Value = "Outside"
            Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(coldrugcode.Index).Value = "N/A External Drug"
            Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colquantity.Index).Value = "10"
            Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(coldosage.Index).Value = "" 'Utility.getDosage(Me.txtExternal.Text)
            Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colperiod.Index).Value = "3"
            dgvcc = Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colper.Index)
            dgvcc.Items.Add(New DictionaryEntry("day/s", "1"))
            dgvcc.Items.Add(New DictionaryEntry("week/s", "2"))
            dgvcc.Items.Add(New DictionaryEntry("month/s", "3"))
            dgvcc.DisplayMember = "Key"
            dgvcc.ValueMember = "Value"
            dgvcc.DataSource = dgvcc.Items
            Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colper.Index).Value = ("1").ToString()
            dgvcc1 = Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colfrequency.Index)
            dgvcc1.DataSource = Me.dtFrequency
            dgvcc1.DisplayMember = "description"
            dgvcc1.ValueMember = "frequencyid"
            dgvcc1.Value = 0
        Else
            MessageBox.Show("Entered drug name is already in the list.", modGlobal.msgboxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Function isExistExternal(ByVal str As String, ByVal s As String)
        Dim ok As Boolean
        For ctr = 0 To Me.dvgListOfPrescribedMedicines.Rows.Count - 1
            If s = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldrugcode.Index).Value And Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldrugname.Index).Value = str Then
                ok = True : Exit For
            End If
        Next
        Return ok
    End Function
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Me.dvgListOfPrescribedMedicines.Rows.Count > 0 Then
            If Me.txtDrugname.Text <> "" Then
                If Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.CurrentRow.Index).Cells(8).Value = "N/A External Drug" Then
                    Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.CurrentRow.Index).Cells(2).Value = Me.txtDrugname.Text
                Else
                    MessageBox.Show("Only External Drug can be modified.", modGlobal.msgboxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub dvgListOfPrescribedMedicines_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvgListOfPrescribedMedicines.CellContentClick
        'If Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.CurrentRow.Index).Cells(1).Value = True Then       
        '    Me.txtDrugname.Text = Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.CurrentRow.Index).Cells(2).Value
        'Else
        '    Me.txtDrugname.Clear()
        'End If
        Dim hasSelect As Boolean
        Dim ctr As Integer = 0
        For ctr = 0 To Me.dvgListOfPrescribedMedicines.Rows.Count - 1
            If Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(1).Value = True Then
                hasSelect = True : Exit For
            End If
        Next
        If hasSelect Then
            Me.Button2.Visible = True
            Me.Button4.Visible = True
            Me.txtDrugname.Visible = True
            If Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.CurrentRow.Index).Cells(8).Value = "N/A External Drug" Then
                Me.Button4.Enabled = True
                Me.txtDrugname.Enabled = True
            Else
                Me.Button4.Enabled = False
                Me.txtDrugname.Enabled = False
            End If
            Me.TextBox4.Visible = True
            If Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.CurrentRow.Index).Cells(1).Value = True Then
                Me.txtDrugname.Text = Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.CurrentRow.Index).Cells(2).Value
            Else
                Me.txtDrugname.Clear()
            End If
        Else
            Me.Button2.Visible = False
            Me.Button4.Visible = False
            Me.TextBox4.Visible = False
            Me.txtDrugname.Clear()
            Me.txtDrugname.Visible = False
        End If
    End Sub

    Private Sub addMed()
        Dim frm As New frmViewAllDrug()
IDRIZ:
        frm.ShowDialog()
        If frm.issave Then
            If isExist(frm.selected) = False Then
                Dim dt As DataTable = clsDashboard.getMyPatients(13, frm.selected)
                If dt.Rows.Count > 0 Then

                    stats = dt.Rows(0).Item("stats").ToString()
                    Me.dvgListOfPrescribedMedicines.Rows.Add(1)
                    Dim dgvcc As DataGridViewComboBoxCell
                    Dim dgvcc1 As DataGridViewComboBoxCell
                    Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colid.Index).Value = 0
                    Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(coldrugname.Index).Value = frm.DataGridView1.Rows(frm.DataGridView1.CurrentRow.Index).Cells(1).Value
                    If stats = "Unavailable" Then
                        Me.dvgListOfPrescribedMedicines.Item(colavailability.Index, Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Style.ForeColor = Color.Red
                        Me.dvgListOfPrescribedMedicines.Item(colavailability.Index, Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Style.SelectionForeColor = Color.Red
                    End If

                    Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colavailability.Index).Value = stats '"Available"
                    Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(coldrugcode.Index).Value = frm.selected
                    Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colquantity.Index).Value = "10"
                    Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(coldosage.Index).Value = "" 'Utility.getDosage(frm.DataGridView1.Rows(frm.DataGridView1.CurrentRow.Index).Cells(1).Value)
                    Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colperiod.Index).Value = "0"
                    dgvcc = Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colper.Index)
                    dgvcc.Items.Add(New DictionaryEntry("day/s", "1"))
                    dgvcc.Items.Add(New DictionaryEntry("week/s", "2"))
                    dgvcc.Items.Add(New DictionaryEntry("month/s", "3"))
                    dgvcc.DisplayMember = "Key"
                    dgvcc.ValueMember = "Value"
                    dgvcc.DataSource = dgvcc.Items
                    Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colper.Index).Value = ("1").ToString()

                    dgvcc1 = Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colfrequency.Index)
                    dgvcc1.DataSource = Me.dtFrequency
                    dgvcc1.DisplayMember = "description"
                    dgvcc1.ValueMember = "frequencyid"
                    dgvcc1.Value = 0

                    If frm.issave Then
                        If MessageBox.Show("Do you want to add another prescription?", modGlobal.msgboxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                            GoTo IDRIZ
                        End If
                    Else : Exit Sub : End If
                Else
                    MessageBox.Show("Drug name not found in this collection. Please select another a drug name from the list..", modGlobal.msgboxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If (MessageBox.Show("The drug/medicine that you have selected was already in the list of prescribed medicines." & vbNewLine & vbNewLine & "Item name : " & frm.DataGridView1.Rows(frm.DataGridView1.CurrentRow.Index).Cells(1).Value & vbNewLine & vbNewLine & "Would you like to retry and select another drug/medicine?", modGlobal.msgboxTitle, MessageBoxButtons.RetryCancel, MessageBoxIcon.Information)) = DialogResult.Retry Then
                    GoTo IDRIZ
                Else : Exit Sub : End If
            End If
        End If
    End Sub
    Private Sub txtExternal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtExternal.KeyDown
        'If e.KeyCode = Keys.Enter And TabControl1.SelectedIndex = 0 Then
        '    addMed()
        'End If
    End Sub

    Private Sub txtTemplateName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTemplateName.Click
        Me.labelwarning.Visible = False
        ClearAllErrorProviders()
    End Sub

    Private Sub txtSpecial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSpecial.Click
        ClearAllErrorProviders()
    End Sub

    Private Sub tsprint_Click(sender As System.Object, e As System.EventArgs) Handles tsprint.Click
        Me.dtRecord = clsReportDashboard.genericcls(3, oldprescriptionid, 0)
        Call clsDashboard.printPrescription(Me.dtRecord)
    End Sub
End Class