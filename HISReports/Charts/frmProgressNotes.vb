Imports System.Drawing.Drawing2D

Public Class frmProgressNotes
    Inherits Windows.Forms.Form

#Region "Variables"
    Dim erp As New ErrorProvider
    Public isSave As Boolean
    Public myFormStatus As enFormStatus
    Public admissionid As Long
    Enum enFormStatus
        browsing = 0            'edit fields disabled
        add = 1
        edit = 2
        view = 3
    End Enum

    Private colcourseremoveidx As Integer = 0
    Private colcoursedateidx As Integer = 1
    Private colcourseactionidx As Integer = 2
    Private colcourseididx As Integer = 3

#End Region

#Region "validation"
    Private Sub SetErrorProvider(ByVal ctl As Control, Optional ByVal strErrorMessage As String = "")
        erp.SetError(ctl, strErrorMessage)
    End Sub
    Private Function AllDataEntryFieldsAreValid() As Boolean
        Dim blnValid As Boolean = True

        'For i As Integer = 0 To Me.dgvNotes.Rows.Count - 1
        '    If Trim(Me.dgvNotes.Rows(i).Cells(colprogress.Index).Value) = "" And Trim(Me.dgvNotes.Rows(i).Cells(colmedicalorder.Index).Value) = "" Then
        '        Me.dgvNotes.Rows(i).Cells(colprogress.Index).ErrorText = "This field is required!"
        '        Me.dgvNotes.Rows(i).Cells(colmedicalorder.Index).ErrorText = "This field is required!"
        '        Me.dgvNotes.FirstDisplayedScrollingRowIndex = i
        '        blnValid = False
        '        Return blnValid
        '        Exit Function
        '    Else
        '        Me.dgvNotes.Rows(i).Cells(colprogress.Index).ErrorText = ""
        '        Me.dgvNotes.Rows(i).Cells(colmedicalorder.Index).ErrorText = ""
        '    End If
        'Next
        'If isvaliddescription() = False Then
        '    blnValid = False
        '    Return blnValid
        '    Exit Function
        'End If
        Return blnValid
    End Function

#End Region
#Region "Methods"

    Private Sub LoadAdmissionInfo()
        Dim dtAdmissions As New DataTable
        dtAdmissions = clsAdmissiondetails.loadAdmission(admissionid)
        Me.lblPatientNo.Text = Utility.NullToZero(dtAdmissions.Rows(0).Item("ptno"))
        Me.lblDateAdmitted.Text = dtAdmissions.Rows(0).Item("dateadmitted")
        Call LoadPatient(dtAdmissions.Rows(0).Item("PatientID"))
    End Sub
    Private Sub LoadPatient(ByVal PatientID As Integer)
        Dim mHospno As String
        Dim dtpat As New DataTable
        dtpat = clsAdmissiondetails.getPatientDetails(PatientID)
        mHospno = Utility.NullToEmptyString(dtpat.Rows(0).Item("HospitalNo"))
        Me.lblLastName.Text = dtpat.Rows(0).Item("lastname") & " " & Utility.NullToEmptyString(dtpat.Rows(0).Item("suffixname")) & ", " & dtpat.Rows(0).Item("FirstName") & " " & dtpat.Rows(0).Item("MiddleName")
        Me.lblBirthDate.Text = dtpat.Rows(0).Item("BirthDate")
        Me.lblage.Text = Utility.NullToZero(dtpat.Rows(0).Item("age"))
        Dim gender As String = UCase(dtpat.Rows(0).Item("Gender").ToString)
        If Trim(gender) = "M" Then
            Me.lblSex.Text = "Male"
        Else
            Me.lblSex.Text = "Female"
        End If
    End Sub

    Public Sub addColumnsCourse()
        Dim colremove As New DataGridViewButtonColumn
        colremove.HeaderText = ""
        colremove.Width = 30
        Me.dgvCourseWard.Columns.Add(colremove)
        Dim coldate As New CalendarColumn
        coldate.HeaderText = "Date"
        coldate.Width = 160
        coldate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvCourseWard.Columns.Add(coldate)
        Dim colaction As New DataGridViewTextBoxColumn
        colaction.HeaderText = "Progress Report"
        colaction.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.dgvCourseWard.Columns.Add(colaction)
        Dim colid As New DataGridViewTextBoxColumn
        colid.HeaderText = "ID"
        colid.Visible = False
        Me.dgvCourseWard.Columns.Add(colid)
        dgvCourseWard.Columns(colcourseactionidx).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvCourseWard.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        dgvCourseWard.AllowUserToResizeRows = True
        dgvCourseWard.RowTemplate.MinimumHeight = 48
    End Sub

    Private Sub Print(ByRef printtype As Integer)
        'If AllDataEntryFieldsAreValid() = False Then
        '    Exit Sub
        'Else
        '    SaveRecord()
        '    Dim frm As New frmReportHandler
        '    If printtype = 0 Then
        '        Dim crpt As New crptProgressNotes_V2
        '        Dim dtRecord As DataTable = clsProgressNotes.getReportData(Me.admissionid)
        '        crpt.SetDataSource(dtRecord)
        '        frm.crvPrinting.ReportSource = crpt
        '    Else
        '        Dim crpt As New crptCourseWard
        '        Dim dtRecord As DataTable = clsProgressNotes.GetNotes(1, admissionid)
        '        crpt.SetDataSource(dtRecord)
        '        frm.crvPrinting.ReportSource = crpt
        '    End If
        '    frm.ShowDialog()
        '    frm.Dispose()
        'End If
    End Sub
#End Region
#Region "Events"
#Region "ToolStrip Action"
    Private Sub tsSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsSave.Click
        subsave()
    End Sub
    Private Sub tsClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsClose.Click
        Me.Close()
    End Sub
#End Region
    Private Sub frmItems_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.Control = True And e.KeyCode = Keys.S Then
            If isSave = False And myFormStatus <> enFormStatus.browsing Then
                subsave()
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub frmLaboratoryDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        subLoad(myFormStatus)
    End Sub

#End Region

#Region "Methods"
    Private Sub subLoad(ByVal frmstatus As String)
        Call addColumnsCourse()
        EnableFields()
        Call LoadAdmissionInfo()
        'If frmstatus = enFormStatus.browsing Or frmstatus = enFormStatus.edit Then
        LoadREcord()
        'End If
        Me.tsSave.Image = modGlobal.save_icon
        Me.tsClose.Image = modGlobal.close_icon
        Me.KeyPreview = True
    End Sub
    Private Sub subsave(Optional ByVal isfinal As Boolean = True)
        If AllDataEntryFieldsAreValid() = False Then
            Exit Sub
        Else
            SaveRecord()
            'Me.tsSave.Visible = False
            If isfinal Then
                MessageBox.Show("Record/s successfully saved.", modGlobal.msgboxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'myFormStatus = enFormStatus.browsing
            'EnableFields()
            isSave = True

        End If
    End Sub
    Private Sub EnableFields()
        'If myFormStatus = enFormStatus.add Or myFormStatus = enFormStatus.edit Then
        '    Me.tsSave.Visible = True
        'ElseIf myFormStatus = enFormStatus.browsing Then
        '    Me.tsSave.Visible = False
        'End If
    End Sub
    Public Sub SaveRecord()
        Dim x As New clsProgressNotes
        x.admissionid = Me.admissionid
        For i As Integer = 0 To Me.dgvnotes.Rows.Count - 1
            x.progressnoteid = Me.dgvnotes.Rows(i).Cells(colid.index).Value
            x.progressdate = Me.dgvnotes.Rows(i).Cells(colprogressdate.Index).Value
            x.notes = Utility.NullToEmptyString(Me.dgvnotes.Rows(i).Cells(colprogress.Index).Value)
            x.medicalorder = Utility.NullToEmptyString(Me.dgvnotes.Rows(i).Cells(colmedicalorder.Index).Value)
            x.carried = Me.dgvnotes.Rows(i).Cells(colc.Index).Value
            x.administered = Me.dgvnotes.Rows(i).Cells(cola.Index).Value
            x.requested = Me.dgvnotes.Rows(i).Cells(colr.Index).Value
            x.endorsed = Me.dgvnotes.Rows(i).Cells(cole.Index).Value
            x.discontinued = Me.dgvnotes.Rows(i).Cells(cold.Index).Value
            x.createdbyid = Me.dgvnotes.Rows(i).Cells(colencodedbyid.Index).Value

            x.issync = False
            x.server_id = 0
            x.isdeleted = False
            x.iscourseward = False
            x.prescriptionid = Me.dgvnotes.Rows(i).Cells(colprescriptionid.Index).Value
            x.testrequestid = Me.dgvnotes.Rows(i).Cells(coltestrequestid.Index).Value
            If x.progressnoteid = 0 Then
                x.progressnoteid = x.Save(True)
                Me.dgvnotes.Rows(i).Cells(colid.index).Value = x.progressnoteid
            Else
                x.Save(False)
            End If
        Next
        x.carried = False
        x.administered = False
        x.requested = False
        x.endorsed = False
        x.discontinued = False

        x.issync = False
        x.server_id = 0
        x.isdeleted = False
        x.prescriptionid = 0
        For i As Integer = 0 To Me.dgvCourseWard.Rows.Count - 1
            x.progressnoteid = Me.dgvCourseWard.Rows(i).Cells(colcourseididx).Value
            x.progressdate = Me.dgvCourseWard.Rows(i).Cells(colcoursedateidx).Value
            x.notes = ""
            x.medicalorder = Utility.NullToEmptyString(Me.dgvCourseWard.Rows(i).Cells(colcourseactionidx).Value)

            x.iscourseward = True
            If x.progressnoteid = 0 Then
                x.progressnoteid = x.Save(True)
                Me.dgvCourseWard.Rows(i).Cells(colcourseididx).Value = x.progressnoteid
            Else
                x.Save(False)
            End If
        Next
    End Sub
    Public Sub LoadREcord()
        Dim dtRecord As New DataTable
        dtRecord = clsProgressNotes.GetNotes(0, admissionid, 2)
        Dim lastrxid As Integer = 0
        Dim lastindex As Integer = 0
        Me.dgvCourseWard.Rows.Clear()
        Me.dgvnotes.Rows.Clear()
        For Each row As DataRow In dtRecord.Rows
            If Utility.NullToBoolean(row.Item("iscourseward")) Then
                Me.dgvCourseWard.Rows.Add(1)
                lastindex = Me.dgvCourseWard.RowCount - 1
                Me.dgvCourseWard.Rows(lastindex).Cells(colcoursedateidx).Value = Utility.NullToDefaultDateFormat(row.Item("progressdate"))
                Me.dgvCourseWard.Rows(lastindex).Cells(colcourseactionidx).Value = Utility.NullToEmptyString(row.Item("medicalorder"))
                Me.dgvCourseWard.Rows(lastindex).Cells(colcourseididx).Value = row.Item("progressnoteid")
            Else
                Me.dgvnotes.Rows.Add(1)
                lastindex = Me.dgvnotes.RowCount - 1

                Me.dgvnotes.Rows(lastindex).Cells(colprogressdate.Index).Value = Utility.NullToDefaultDateFormat(row.Item("progressdate"))
                Me.dgvnotes.Rows(lastindex).Cells(colcreatedby.Index).Value = Utility.NullToEmptyString(row.Item("createdby"))

                If Me.dgvnotes.Rows(lastindex).Cells(colencodedbyid.Index).Value = modGlobal.employeeid Or Me.dgvnotes.Rows(lastindex).Cells(colencodedbyid.Index).Value = 0 Then
                    Me.dgvnotes.Rows(lastindex).Cells(colisedit.Index).Value = "1"
                Else
                    Me.dgvnotes.Rows(lastindex).Cells(colisedit.Index).Value = "0"
                End If

                Dim subheader As String = ""
                If Utility.NullToZero(row.Item("prescriptionid")) > 0 Then
                    row.Item("medicalorder") = "   > " & Utility.NullToEmptyString(row.Item("medicalorder"))
                    If lastrxid <> row.Item("prescriptionid") Then
                        subheader = "Therapeutics: " & vbNewLine
                    Else
                        Me.dgvnotes.Rows(lastindex).Cells(colcreatedby.Index).Value = ""
                        Me.dgvnotes.Rows(lastindex).Cells(colprogressdate.Index).Value = Nothing
                        Me.dgvnotes.Rows(lastindex).Cells(colisedit.Index).Value = "0"
                    End If
                    lastrxid = row.Item("prescriptionid")
                ElseIf Utility.NullToZero(row.Item("testrequestid")) > 0 Then
                    row.Item("medicalorder") = "   > " & Utility.NullToEmptyString(row.Item("medicalorder"))
                    If lastrxid <> row.Item("testrequestid") Then
                        subheader = "Diagnostics: " & vbNewLine
                    Else
                        Me.dgvnotes.Rows(lastindex).Cells(colcreatedby.Index).Value = ""
                        Me.dgvnotes.Rows(lastindex).Cells(colprogressdate.Index).Value = Nothing
                        Me.dgvnotes.Rows(lastindex).Cells(colisedit.Index).Value = "0"
                    End If
                    lastrxid = row.Item("testrequestid")
                End If
                lastindex = Me.dgvnotes.RowCount - 1
                Me.dgvnotes.Rows(lastindex).Cells(colprogress.Index).Value = Utility.NullToEmptyString(row.Item("notes"))
                Me.dgvnotes.Rows(lastindex).Cells(colmedicalorder.Index).Value = subheader & Utility.NullToEmptyString(row.Item("medicalorder"))
                Me.dgvnotes.Rows(lastindex).Cells(colc.Index).Value = Utility.NullToBoolean(row.Item("carried"))
                Me.dgvnotes.Rows(lastindex).Cells(cola.Index).Value = Utility.NullToBoolean(row.Item("administered"))
                Me.dgvnotes.Rows(lastindex).Cells(colr.Index).Value = Utility.NullToBoolean(row.Item("requested"))
                Me.dgvnotes.Rows(lastindex).Cells(cole.Index).Value = Utility.NullToBoolean(row.Item("endorsed"))
                Me.dgvnotes.Rows(lastindex).Cells(cold.Index).Value = Utility.NullToBoolean(row.Item("discontinued"))
                Me.dgvnotes.Rows(lastindex).Cells(colid.index).Value = row.Item("progressnoteid")
                Me.dgvnotes.Rows(lastindex).Cells(colprescriptionid.Index).Value = Utility.NullToZero(row.Item("prescriptionid"))
                Me.dgvnotes.Rows(lastindex).Cells(coltestrequestid.Index).Value = Utility.NullToZero(row.Item("testrequestid"))
                Me.dgvnotes.Rows(lastindex).Cells(colencodedbyid.Index).Value = Utility.NullToZero(row.Item("createdbyid"))
                If Me.dgvnotes.Rows(lastindex).Cells(colprescriptionid.Index).Value > 0 Or Me.dgvnotes.Rows(lastindex).Cells(coltestrequestid.Index).Value > 0 Then
                    Me.dgvnotes.Rows(lastindex).Cells(colmedicalorder.Index).Style.BackColor = Color.LightGray
                    Me.dgvnotes.Rows(lastindex).Cells(colmedicalorder.Index).Style.SelectionBackColor = Color.LightGray
                    Me.dgvnotes.Rows(lastindex).Cells(colmedicalorder.Index).ReadOnly = True
                    Me.dgvnotes.Rows(lastindex).Cells(colprogressdate.Index).Style.BackColor = Color.LightGray
                    Me.dgvnotes.Rows(lastindex).Cells(colprogressdate.Index).Style.SelectionBackColor = Color.LightGray
                    Me.dgvnotes.Rows(lastindex).Cells(colprogressdate.Index).ReadOnly = True
                End If
                If Me.dgvnotes.Rows(lastindex).Cells(colencodedbyid.Index).Value <> modGlobal.employeeid And Me.dgvnotes.Rows(lastindex).Cells(colencodedbyid.Index).Value > 0 Then
                    Me.dgvnotes.Rows(lastindex).DefaultCellStyle.BackColor = Color.LightGray
                    Me.dgvnotes.Rows(lastindex).DefaultCellStyle.SelectionBackColor = Color.LightGray
                    Me.dgvnotes.Rows(lastindex).ReadOnly = True
                End If
            End If
        Next
        lastindex = 0

    End Sub

#End Region

    Private Sub btnAddNote_Click(sender As System.Object, e As System.EventArgs) Handles btnAddNote.Click
        Me.dgvNotes.Rows.Add(1)
        Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).Cells(colprogressdate.Index).Value = Utility.GetServerDate
        Me.dgvnotes.Rows(Me.dgvnotes.RowCount - 1).Cells(colid.index).Value = 0
        Me.dgvnotes.Rows(Me.dgvnotes.RowCount - 1).Cells(colcreatedby.Index).Value = modGlobal.ulastName & ", " & modGlobal.ufirstName
        Me.dgvnotes.Rows(Me.dgvnotes.RowCount - 1).Cells(colencodedbyid.Index).Value = modGlobal.employeeid
        Me.dgvnotes.Rows(Me.dgvnotes.RowCount - 1).Cells(colisedit.Index).Value = 1
        Me.dgvNotes.FirstDisplayedScrollingRowIndex = Me.dgvNotes.RowCount - 1
        Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).Cells(colprogress.Index).Selected = True
        Me.dgvNotes.Select()
    End Sub

    Private Sub dgvNotes_CellPainting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvnotes.CellPainting
        Try
            If e.ColumnIndex = colremove.Index AndAlso e.RowIndex >= 0 Then
                If Me.dgvnotes.Rows(e.RowIndex).Cells(colisedit.Index).Value = "1" Then
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All)
                    Dim bmpFind As Bitmap = modGlobal.remove_icon   'ImageList1.Images(1)
                    Dim ico As Icon = Icon.FromHandle(bmpFind.GetHicon)
                    e.Graphics.DrawIcon(ico, e.CellBounds.Left + 7, e.CellBounds.Top + Me.dgvnotes.Rows(e.RowIndex).Height / 2 - 8)
                    e.Handled = True
                End If
            ElseIf e.ColumnIndex = coledit.Index AndAlso e.RowIndex >= 0 AndAlso Me.dgvnotes.Rows(e.RowIndex).Cells(colisedit.Index).Value = "1" Then
                If (Me.dgvnotes.Rows(e.RowIndex).Cells(colprescriptionid.Index).Value > 0 Or Me.dgvnotes.Rows(e.RowIndex).Cells(coltestrequestid.Index).Value > 0) Then
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All)
                    Dim bmpFind As Bitmap = modGlobal.edit_icon
                    Dim ico As Icon = Icon.FromHandle(bmpFind.GetHicon)
                    e.Graphics.DrawIcon(ico, e.CellBounds.Left + 3, e.CellBounds.Top + Me.dgvnotes.Rows(e.RowIndex).Height / 2 - 14)
                    e.Handled = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgvCourseWard_CellPainting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvCourseWard.CellPainting
        Try
            If e.ColumnIndex = colcourseremoveidx AndAlso e.RowIndex >= 0 Then
                e.Paint(e.CellBounds, DataGridViewPaintParts.All)
                Dim bmpFind As Bitmap = modGlobal.remove_icon   'ImageList1.Images(1)
                Dim ico As Icon = Icon.FromHandle(bmpFind.GetHicon)
                e.Graphics.DrawIcon(ico, e.CellBounds.Left + 7, e.CellBounds.Top + Me.dgvCourseWard.Rows(e.RowIndex).Height / 2 - 8)
                e.Handled = True
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgvNotes_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvnotes.CellContentClick
        If e.ColumnIndex = colremove.Index AndAlso Me.dgvnotes.Rows(e.RowIndex).Cells(colisedit.Index).Value = "1" Then
            If Me.dgvnotes.Rows(e.RowIndex).Cells(colencodedbyid.Index).Value > 0 And Me.dgvnotes.Rows(e.RowIndex).Cells(colencodedbyid.Index).Value <> modGlobal.employeeid Then
                MessageBox.Show("Cannot delete order which is not created by you!", modGlobal.msgboxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim x As New clsProgressNotes
            Dim str As String = "Are you sure you want to delete this note"
            If Val(Me.dgvnotes.Rows(e.RowIndex).Cells(colprescriptionid.Index).Value) > 0 Then
                str = str & " and prescription"
            End If
            If Val(Me.dgvnotes.Rows(e.RowIndex).Cells(coltestrequestid.Index).Value) > 0 Then
                str = str & " and test request"
            End If
            If MessageBox.Show(str & "?", modGlobal.msgboxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                If Val(Me.dgvnotes.Rows(e.RowIndex).Cells(colprescriptionid.Index).Value) > 0 Then
                    clsDashboard.DeleteMainPrescription(Me.dgvnotes.Rows(e.RowIndex).Cells(colprescriptionid.Index).Value)
                End If
                If Val(Me.dgvnotes.Rows(e.RowIndex).Cells(coltestrequestid.Index).Value) > 0 Then
                    clsRadiologyLaboratory.RemoveMainTestRequest(Me.dgvnotes.Rows(e.RowIndex).Cells(coltestrequestid.Index).Value)
                End If
                If Val(Me.dgvnotes.Rows(e.RowIndex).Cells(colid.Index).Value) > 0 Then
                    x.isdeleted = True
                    x.issync = False
                    x.progressnoteid = Me.dgvnotes.Rows(e.RowIndex).Cells(colid.Index).Value
                    x.RemoveNote()
                    Me.dgvnotes.Rows.RemoveAt(e.RowIndex)
                Else
                    Me.dgvnotes.Rows.RemoveAt(e.RowIndex)
                End If
            End If
        ElseIf e.ColumnIndex = coledit.Index AndAlso Me.dgvnotes.Rows(e.RowIndex).Cells(colisedit.Index).Value = "1" Then
            If Me.dgvnotes.Rows(e.RowIndex).Cells(colencodedbyid.Index).Value > 0 And Me.dgvnotes.Rows(e.RowIndex).Cells(colencodedbyid.Index).Value <> modGlobal.employeeid Then
                MessageBox.Show("Cannot edit order which is not created by you!", modGlobal.msgboxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Me.dgvnotes.Rows(e.RowIndex).Cells(colprescriptionid.Index).Value > 0 Then
                Dim f As New frmPrescription(frmPrescription.enFormStatus.edit)
                f.admissionID = Me.admissionid
                f.oldprescriptionid = Me.dgvnotes.Rows(e.RowIndex).Cells(colprescriptionid.Index).Value
                f.ShowDialog()
                If f.isSave Then
                    Call subsave()
                    clsProgressNotes.GetNotes(2, f.oldprescriptionid)
                    Call LoadREcord()
                End If
            ElseIf Me.dgvnotes.Rows(e.RowIndex).Cells(coltestrequestid.Index).Value > 0 Then
                Dim f As New frmTestRequest
                f.myFormStatus = frmTestRequest.enFormStatus.edit
                f.admissionid = Me.admissionid
                f.oldtestrequestid = Me.dgvnotes.Rows(e.RowIndex).Cells(coltestrequestid.Index).Value
                f.ShowDialog()
                If f.isSave Then
                    Call subsave()
                    clsProgressNotes.GetNotes(3, f.oldtestrequestid)
                    Call LoadREcord()
                End If
            End If

        End If
    End Sub
    Private Sub dgvCourseWard_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCourseWard.CellContentClick
        If e.ColumnIndex = colcourseremoveidx Then
            If MessageBox.Show("Are you sure you want to remove this item?", modGlobal.msgboxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Dim x As New clsProgressNotes
                If Val(Me.dgvCourseWard.Rows(e.RowIndex).Cells(colcourseididx).Value) > 0 Then
                    x.isdeleted = True
                    x.issync = False
                    x.progressnoteid = Me.dgvCourseWard.Rows(e.RowIndex).Cells(colcourseididx).Value
                    x.RemoveNote()
                    Me.dgvCourseWard.Rows.RemoveAt(e.RowIndex)
                Else
                    Me.dgvCourseWard.Rows.RemoveAt(e.RowIndex)
                End If
            End If
        End If
    End Sub

    Private Sub dgvNotes_CurrentCellDirtyStateChanged(sender As System.Object, e As System.EventArgs) Handles dgvnotes.CurrentCellDirtyStateChanged
        If (dgvnotes.IsCurrentCellDirty) Then
            dgvnotes.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgvCourseWard_CurrentCellDirtyStateChanged(sender As System.Object, e As System.EventArgs) Handles dgvCourseWard.CurrentCellDirtyStateChanged
        If (dgvCourseWard.IsCurrentCellDirty) Then
            dgvCourseWard.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub PrintAsProgressNotesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintAsProgressNotesToolStripMenuItem.Click
        Call Print(0)
    End Sub

    Private Sub PrintAsCF4AttachmentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintAsCF4AttachmentToolStripMenuItem.Click
        Call Print(1)
    End Sub

    Private Sub btnAddCourse_Click(sender As System.Object, e As System.EventArgs) Handles btnAddCourse.Click
        Me.dgvCourseWard.Rows.Add(1)
        Me.dgvCourseWard.Rows(Me.dgvCourseWard.RowCount - 1).Cells(colcoursedateidx).Value = Utility.GetServerDate
        Me.dgvCourseWard.Rows(Me.dgvCourseWard.RowCount - 1).Cells(colcourseididx).Value = 0
        Me.dgvCourseWard.FirstDisplayedScrollingRowIndex = Me.dgvCourseWard.RowCount - 1
        Me.dgvCourseWard.Rows(Me.dgvCourseWard.RowCount - 1).Cells(colcourseactionidx).Selected = True
        Me.dgvCourseWard.Select()
    End Sub

    Private Sub tsNursingnotes_Click(sender As System.Object, e As System.EventArgs) Handles tsNursingnotes.Click
        Dim f As New frmNursingNotes
        f.admissionid = Me.admissionid
        f.ShowDialog()
    End Sub

    Private Sub btnAddPrescription_Click(sender As System.Object, e As System.EventArgs) Handles btnAddPrescription.Click
        Dim f As New frmPrescription(frmPrescription.enFormStatus.add)
        f.admissionID = Me.admissionid
        f.ShowDialog()
        If f.isSave Then
            Call subsave()
            clsProgressNotes.GetNotes(2, f.oldprescriptionid)
            Call LoadREcord()
        End If
    End Sub

    Private Sub btnAddTest_Click(sender As System.Object, e As System.EventArgs) Handles btnAddTest.Click
        Dim f As New frmTestRequest
        f.myFormStatus = frmTestRequest.enFormStatus.add
        f.admissionID = Me.admissionid
        f.ShowDialog()
        If f.isSave Then
            Dim dt As DataTable = clsProgressNotes.GetNotes(3, f.oldtestrequestid)
            If dt.Rows.Count > 0 Then
                Me.dgvNotes.Rows.Add(1)
                Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).Cells(colprogressdate.Index).Value = Utility.NullToCurrentDate(dt.Rows(0).Item("progressdate"))
                Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).Cells(colid.index).Value = Utility.NullToZero(dt.Rows(0).Item("progressnoteid"))
                Me.dgvNotes.FirstDisplayedScrollingRowIndex = Me.dgvNotes.RowCount - 1
                Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).Cells(colmedicalorder.Index).Value = Utility.NullToEmptyString(dt.Rows(0).Item("medicalorder"))
                Me.dgvnotes.Rows(Me.dgvnotes.RowCount - 1).Cells(coltestrequestid.Index).Value = f.oldtestrequestid
                Me.dgvnotes.Rows(Me.dgvnotes.RowCount - 1).Cells(colcreatedby.Index).Value = modGlobal.ulastName & ", " & modGlobal.ufirstName
                Me.dgvnotes.Rows(Me.dgvnotes.RowCount - 1).Cells(colencodedbyid.Index).Value = modGlobal.employeeid
                Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).Cells(colmedicalorder.Index).Style.BackColor = Color.LightGray
                Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).Cells(colmedicalorder.Index).Style.SelectionBackColor = Color.LightGray
                Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).Cells(colmedicalorder.Index).ReadOnly = True
                Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).Cells(colprogress.Index).Selected = True
                Me.dgvNotes.Select()
            End If
        End If
    End Sub

    'Private Sub dgvNotes_EditingControlShowing(sender As System.Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs)
    '    Try

    '        If dgvnotes.CurrentCell.ColumnIndex = colmedicalorder.Index Or dgvnotes.CurrentCell.ColumnIndex = colprogress.Index Then
    '            Dim tb As TextBox = TryCast(e.Control, TextBox)

    '            If tb IsNot Nothing Then
    '                tb.AcceptsTab = True
    '                RemoveHandler tb.PreviewKeyDown, AddressOf Column1_KeyPress
    '                AddHandler tb.PreviewKeyDown, AddressOf Column1_KeyPress
    '            End If
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub
    'Private Sub Column1_KeyPress(ByVal sender As Object, ByVal e As PreviewKeyDownEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        Dim insertPos As Integer = sender.SelectionStart
    '        sender.text = sender.Text.Insert(insertPos, vbNewLine & vbTab)
    '        sender.SelectionStart = insertPos + 3
    '    ElseIf e.KeyCode = Keys.Tab Then
    '        Dim insertPos As Integer = sender.SelectionStart
    '        sender.text = sender.Text.Insert(insertPos, vbTab)
    '        sender.SelectionStart = insertPos + 2
    '    End If
    'End Sub

    'Private Sub btnpostrequest_Click(sender As System.Object, e As System.EventArgs) Handles btnpostrequest.Click
    '    Dim f As New frmRequisition
    '    f.admissionid = Me.admissionid
    '    f.isnew = True
    '    f.showdialog()
    'End Sub

    Private Sub dgvCourseWard_ContextMenuStripChanged(sender As Object, e As System.EventArgs) Handles dgvCourseWard.ContextMenuStripChanged

    End Sub
End Class