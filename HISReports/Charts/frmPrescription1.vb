Imports System.Drawing.Drawing2D
Public Class frmPrescription
#Region "Variables"
    Dim erp As New ErrorProvider
    Public isSave, afterload As Boolean
    Public myFormStatus As enFormStatus
    Public admissionID As String
    Dim dtRecord As New DataTable()
    Dim dtFrequency As New DataTable
    Public oldprescriptionid, _
        oldrefpatientrequestno As Long

    Enum enFormStatus
        browsing = 0 : add = 1 : edit = 2 : view = 3
    End Enum
#End Region
#Region "New Methods"
    Sub New(ByVal FormStatus As enFormStatus)
        InitializeComponent() : myFormStatus = FormStatus
    End Sub
#End Region
    Private Sub frmPrescription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.tstitle.Text = modGlobal.msgboxTitle & " ©" & Utility.GetServerDate().Year
        Call loadMedicineList()
        dtRecord.Rows.Clear()
        dtRecord = clsDashboard.getMyPatients(1, admissionID)
        dtFrequency = clsFrequency.getInfo(1, "")
        Dim primaryKey(0) As DataColumn
        primaryKey(0) = dtFrequency.Columns("frequencyid")
        dtFrequency.PrimaryKey = primaryKey
        Me.KeyPreview = True
        Me.lblPatientNo.Text = dtRecord.Rows(0).Item("Patient No").ToString()
        Me.lblAddress.Text = dtRecord.Rows(0).Item("Address").ToString()
        Me.lblHospno.Text = Utility.formatHospNo(dtRecord.Rows(0).Item("Hospital No").ToString())
        Me.lblPatient.Text = dtRecord.Rows(0).Item("Name").ToString()
        Me.lblAge.Text = dtRecord.Rows(0).Item("Age").ToString()
        If dtRecord.Rows(0).Item("Gender").ToString() = "F" Then
            Me.lblGender.Text = "Female"
        Else
            Me.lblGender.Text = "Male"
        End If
        With Me.cmbphysician
            .Items.Add(New DictionaryEntry(dtRecord.Rows(0).Item("admittingphysician"), dtRecord.Rows(0).Item("admittingphysicianid")))
            If dtRecord.Rows(0).Item("admittingphysicianid") <> dtRecord.Rows(0).Item("attendingphysicianid") Then
                .Items.Add(New DictionaryEntry(dtRecord.Rows(0).Item("attendingphysician"), dtRecord.Rows(0).Item("attendingphysicianid")))
            End If
            .DisplayMember = "Key"
            .ValueMember = "Value"
            .DataSource = .Items
            .SelectedValue = dtRecord.Rows(0).Item("admittingphysicianid")
        End With
        If myFormStatus = enFormStatus.add Then
            Me.tsSave.Text = "Save" : enabledFields(True)
        ElseIf myFormStatus = enFormStatus.edit Then
            loadRecord() : Me.tsSave.Text = "Update" : enabledFields(True)
        ElseIf myFormStatus = enFormStatus.browsing Then
            loadRecord() : enabledFields(False)
        End If
        Me.tsSave.Image = modGlobal.save_icon
        Me.tsClose.Image = modGlobal.close_icon
        Me.tsPrint.Image = modGlobal.print_icon
        Me.tspreprinted.Image = modGlobal.print_icon
    End Sub

    Private Sub SetErrorProvider(ByVal ctl As Control, Optional ByVal strErrorMessage As String = "")
        erp.SetError(ctl, strErrorMessage)
    End Sub
    Private Sub clearErrorProvider(ByVal ctl As Control, Optional ByVal strErrorMessage As String = "")
        erp.Clear()
    End Sub
    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        subSave()
    End Sub
    Private Sub subSave()
        If MsgBox("Are you sure you want to " & Me.tsSave.Text.ToLower() & " this Prescription?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, modGlobal.msgboxTitle) = MsgBoxResult.Yes Then
            If save() Then
                MessageBox.Show("Record successfully " & Me.tsSave.Text.ToLower() & "d.", modGlobal.msgboxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.dvgListOfPrescribedMedicines.ReadOnly = True
                enabledFields(False)
                isSave = True
                'Me.TextBox2.Visible = False
                Call SaveLog("Presciption ", IIf(Me.tsSave.Text.ToLower = "save", "Added prescription ", "Updated prescription ") & "for Patient No. " & Me.lblPatientNo.Text & "(" & Me.lblPatient.Text & ")")
            Else
                MsgBox("Transaction cancelled. You may try again thank you", MsgBoxStyle.Information, modGlobal.msgboxTitle)
            End If
        End If
    End Sub
    Private Sub enabledFields(ByVal sw As Boolean)
        Me.dvgListOfPrescribedMedicines.Enabled = sw
        Me.separatorprint.Visible = Not sw
        Me.tsPrint.Visible = Not sw
        Me.separatorpreprinted.Visible = Not sw
        Me.tspreprinted.Visible = Not sw
        Me.dtTime.Enabled = sw
        Me.tsSave.Visible = sw
        Me.dtTime.Enabled = sw
    End Sub

    Private Sub loadMedicineList()
        afterload = False
        With Me.cmbSearchrx
            .DataSource = clsDashboard.getMyPatients(14, "")
            .DisplayMember = "Brand Name"
            .ValueMember = "Item Code"
            .SelectedIndex = -1
        End With
        afterload = True
    End Sub
    Private Function save(Optional ByVal id As Long = 0) As Boolean
        Dim x As New clsDashboard()
        x.name = ""
        x.oldprescriptionid = oldprescriptionid
        x.admissionid = admissionID
        'x.description = Me.txtSpecial.Text
        x.xdate = Me.dtTime.Value
        x.physician = Me.cmbphysician.SelectedValue

        x.istemplate = 0
        x.issync = False
        x.isdeleted = False

        If myFormStatus = enFormStatus.add Then
            oldprescriptionid = x.save(True, 0)
        Else
            x.save(False, 0)
        End If

        'Save Prescription Details
        For ctr = 0 To Me.dvgListOfPrescribedMedicines.Rows.Count - 1
            x.oldpresecriptiondetailsid = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colid.Index).Value
            x.oldprescriptionid = oldprescriptionid
            If Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldrugcode.Index).Value = "" Or Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldrugcode.Index).Value = "N/A External Drug" Then
                x.drugcode = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldrugname.Index).Value
            Else
                x.drugcode = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldrugcode.Index).Value
            End If
            x.frequency = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colfrequency.Index).Value
            x.quantity = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colqty.Index).Value
            x.dosage = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colinstructions.Index).Value
            x.period = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colperiod.Index).Value
            x.per = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colper.Index).Value
            x.issync = False
            x.isdeleted = False
            If myFormStatus = enFormStatus.add Then
                x.serverid = 0
                Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colid.Index).Value = x.save(True, 2)
            Else
                If Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colid.Index).Value = "" Then
                    x.serverid = 0
                    x.save(True, 2)
                Else
                    x.save(False, 2)
                End If
            End If
        Next
        Return True
    End Function
    Private Sub tsClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsClose.Click
        Me.Close()
    End Sub

    Private Sub paintForm(ByVal sender As Object, ByVal e As PaintEventArgs) 'Handles MyBase.Paint, TabPage3.Paint, TabPage1.Paint
        Dim mGraphics As Graphics = e.Graphics
        Dim pen1 As Pen = New Pen(Color.FromArgb(252, 254, 255), 1)
        Dim Area1 As Rectangle = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1) '253, 254, 255
        Dim LGB As LinearGradientBrush = New LinearGradientBrush(Area1, Color.FromArgb(252, 254, 255), Color.ForestGreen, LinearGradientMode.Vertical)
        mGraphics.FillRectangle(LGB, Area1)
        mGraphics.DrawRectangle(pen1, Area1)
    End Sub

    Private Sub loadRecord()

        afterload = False
        Dim r As Integer = 0
        dtRecord.Rows.Clear()
        Me.dvgListOfPrescribedMedicines.Rows.Clear()
        dtRecord = clsDashboard.getClinicPatients(5, Me.oldprescriptionid, 0)
        If dtRecord.Rows.Count > 0 Then
            Me.cmbphysician.SelectedValue = dtRecord.Rows(0).Item("physician")

            Me.dvgListOfPrescribedMedicines.Columns(coldrugname.Index).HeaderText = "Drug Name"
            Me.dvgListOfPrescribedMedicines.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
            For ctr = 0 To dtRecord.Rows.Count - 1
                Me.dvgListOfPrescribedMedicines.Rows.Add(1)
                Dim dgvcc As DataGridViewComboBoxCell
                Dim dgvcc1 As DataGridViewComboBoxCell
                Me.oldprescriptionid = dtRecord.Rows(ctr).Item("masterid").ToString()
                Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colid.Index).Value = dtRecord.Rows(ctr).Item("id").ToString()
                Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldrugname.Index).Value = dtRecord.Rows(ctr).Item("Drug Name").ToString()
                Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colisupdatedrx.Index).Value = "0"
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
                Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colinstructions.Index).Value = dtRecord.Rows(ctr).Item("dosage").ToString()
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
                Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colptrequestno.Index).Value = dtRecord.Rows(ctr).Item("refpatientrequestno").ToString()
                Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(colqty.Index).Value = dtRecord.Rows(ctr).Item("quantity").ToString()
                r = r + 1
            Next
        End If

        afterload = True
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

    Private Sub frmPrescription_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.Control = True And e.KeyCode = Keys.S And isSave = False Then
            subSave()
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


    Private Function isExistExternal(ByVal str As String, ByVal s As String)
        Dim ok As Boolean
        For ctr = 0 To Me.dvgListOfPrescribedMedicines.Rows.Count - 1
            If s = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldrugcode.Index).Value And Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldrugname.Index).Value = str Then
                ok = True : Exit For
            End If
        Next
        Return ok
    End Function

    Private Sub dvgListOfPrescribedMedicines_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvgListOfPrescribedMedicines.CellContentClick
        If e.ColumnIndex = colselectmed.Index Then
            If MessageBox.Show("Are you sure you want to remove the selected medicine from the list?", modGlobal.msgboxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Dim myEmp As New clsDashboard()
                If Val(Me.dvgListOfPrescribedMedicines.Rows(e.RowIndex).Cells(colid.Index).Value) > 0 Then
                    With myEmp
                        .DeleteSelectedPrescription(Me.dvgListOfPrescribedMedicines.Rows(e.RowIndex).Cells(colid.Index).Value)
                        .Deleterequestdetails(admissionID, Me.dvgListOfPrescribedMedicines.Rows(e.RowIndex).Cells(coldrugcode.Index).Value, Me.dvgListOfPrescribedMedicines.Rows(e.RowIndex).Cells(colptrequestno.Index).Value)
                        Me.dvgListOfPrescribedMedicines.Rows.RemoveAt(e.RowIndex)
                    End With
                Else
                    Me.dvgListOfPrescribedMedicines.Rows.RemoveAt(e.RowIndex)
                End If
            End If
        End If
    End Sub

    Private Sub addMed(ByRef itemcode As String)
        If isPrescriptionExist(itemcode) = False Then

            Me.dvgListOfPrescribedMedicines.Rows.Add(1)
            Dim dgvcc As DataGridViewComboBoxCell
            Dim dgvcc1 As DataGridViewComboBoxCell
            Dim dtItem As New DataTable
            dtItem = clsitems.getitem(4, itemcode)
            Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(coldrugname.Index).Value = dtItem.Rows(0).Item("itemdescription").ToString
            Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colavailability.Index).Value = "Available"
            Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(coldrugcode.Index).Value = itemcode
            Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colqty.Index).Value = "1"
            Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colperiod.Index).Value = "3"
            Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colisupdatedrx.Index).Value = "0"

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
            Me.dvgListOfPrescribedMedicines.Rows(Me.dvgListOfPrescribedMedicines.Rows.Count - 1).Cells(colfrequency.Index).Value = 0
            Me.cmbSearchrx.Text = ""
        Else
            MessageBox.Show("The drug/medicine that you have selected was already in the list of prescribed medicines.", modGlobal.msgboxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Function isPrescriptionExist(ByVal str As String)
        Dim ok As Boolean = False
        For ctr = 0 To Me.dvgListOfPrescribedMedicines.Rows.Count - 1
            If str = Me.dvgListOfPrescribedMedicines.Rows(ctr).Cells(coldrugcode.Index).Value Then
                ok = True : Exit For
            End If
        Next
        Return ok
    End Function
    Private Sub tsPrints_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsPrint.Click
        Try
            If dvgListOfPrescribedMedicines.CurrentRow.Index >= 0 Then
                dtRecord = clsReportDashboard.genericcls(3, Me.admissionID, 1)
                Call clsDashboard.printPrescription(dtRecord)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tspreprinted_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tspreprinted.Click
        Call clsDashboard.printPreprintedPrescription(dtRecord)
    End Sub

    Private Sub dvgListOfPrescribedMedicines_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvgListOfPrescribedMedicines.CellValueChanged
        If afterload Then
            If e.ColumnIndex = colfrequency.Index Or e.ColumnIndex = colinstructions.Index Or e.ColumnIndex = colperiod.Index Or e.ColumnIndex = colper.Index Or e.ColumnIndex = colqty.Index Then
                Me.dvgListOfPrescribedMedicines.Rows(e.RowIndex).Cells(colisupdatedrx.Index).Value = "1"
                If e.ColumnIndex = colfrequency.Index Or e.ColumnIndex = colperiod.Index Or e.ColumnIndex = colper.Index Then
                    Dim freq As Integer = Val(Me.dvgListOfPrescribedMedicines.Rows(e.RowIndex).Cells(colfrequency.Index).Value)
                    Dim noofdays As Integer = Val(Me.dvgListOfPrescribedMedicines.Rows(e.RowIndex).Cells(colperiod.Index).Value)
                    If Me.dvgListOfPrescribedMedicines.Rows(e.RowIndex).Cells(colper.Index).Value = "2" Then
                        noofdays = Val(Me.dvgListOfPrescribedMedicines.Rows(e.RowIndex).Cells(colperiod.Index).Value) * 7
                    ElseIf Me.dvgListOfPrescribedMedicines.Rows(e.RowIndex).Cells(colper.Index).Value = "3" Then
                        noofdays = Val(Me.dvgListOfPrescribedMedicines.Rows(e.RowIndex).Cells(colperiod.Index).Value) * 30
                    End If
                    If Utility.NullToZero(Me.dtFrequency.Rows.Find(freq).Item("days")) > 0 Then
                        freq = Math.Round(Me.dtFrequency.Rows.Find(freq).Item("per") / Me.dtFrequency.Rows.Find(freq).Item("days"), 0)
                    Else
                        freq = 0
                    End If
                    freq = freq * noofdays
                    If freq > 0 Then
                        Me.dvgListOfPrescribedMedicines.Rows(e.RowIndex).Cells(colqty.Index).Value = freq
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub dvgListOfPrescribedMedicines_CellPainting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dvgListOfPrescribedMedicines.CellPainting
        Try
            If e.ColumnIndex = colselectmed.Index AndAlso e.RowIndex >= 0 Then
                e.Paint(e.CellBounds, DataGridViewPaintParts.All)
                Dim bmpFind As Bitmap = modGlobal.delete_icon  'ImageList1.Images(1)
                Dim ico As Icon = Icon.FromHandle(bmpFind.GetHicon)
                e.Graphics.DrawIcon(ico, e.CellBounds.Left + 7, e.CellBounds.Top + 12)
                e.Handled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbSearchrx_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbSearchrx.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then
            If Not sender.DroppedDown Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmbSearchrx_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cmbSearchrx.SelectedValueChanged
        Try
            If cmbSearchrx.SelectedValue > 0 And afterload Then
                Call addMed(Me.cmbSearchrx.SelectedValue)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnaddpresciptionitem_Click(sender As System.Object, e As System.EventArgs) Handles btnaddpresciptionitem.Click
        Dim frm As New frmItems
        frm.myFormStatus = frmItems.enFormStatus.add
        'frm.isPrescription = True
        frm.ShowDialog()
        If frm.isSave Then
            Call loadMedicineList()
            Call addMed(frm.itemcode)
        End If
    End Sub
End Class