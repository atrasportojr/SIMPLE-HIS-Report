Imports System.Drawing.Drawing2D

Public Class frmIntravenousFluids
    Inherits Windows.Forms.Form

#Region "Variables"
    Dim erp As New ErrorProvider
    Public isSave As Boolean
    Public myFormStatus As enFormStatus
    Public admissionid As Long
    Private afterload As Boolean = True
    Enum enFormStatus
        browsing = 0            'edit fields disabled
        add = 1
        edit = 2
        view = 3
    End Enum
#End Region

#Region "validation"
    Private Sub SetErrorProvider(ByVal ctl As Control, Optional ByVal strErrorMessage As String = "")
        erp.SetError(ctl, strErrorMessage)
    End Sub
    Private Function AllDataEntryFieldsAreValid() As Boolean
        Dim blnValid As Boolean = True

        For i As Integer = 0 To Me.dgvMain.Rows.Count - 1
            If Trim(Me.dgvMain.Rows(i).Cells(colivtype.Index).Value) = "" Then
                Me.dgvMain.FirstDisplayedScrollingRowIndex = i
                Me.dgvMain.Rows(i).Cells(colivtype.Index).ErrorText = "This field is required!"
                blnValid = False
                Return blnValid
                Exit Function
            Else
                Me.dgvMain.Rows(i).Cells(colivtype.Index).ErrorText = ""
            End If
        Next
        Return blnValid
    End Function

#End Region
#Region "Methods"

    Private Sub LoadAdmissionInfo()
        Dim dtAdmissions As New DataTable
        dtAdmissions = clsAdmissiondetails.loadAdmission(admissionid)
        Me.lblPatientNo.Text = Utility.NullToZero(dtAdmissions.Rows(0).Item("ptno"))
        Me.lbldateadmitted.text = dtAdmissions.Rows(0).Item("dateadmitted")
        Call LoadPatient(dtAdmissions.Rows(0).Item("PatientID"))
    End Sub
    Private Sub LoadPatient(ByVal PatientID As Integer)
        Dim mHospno As String
        Dim dtpat As New DataTable
        dtpat = clsPatient.getPatientDetails(PatientID)
        mHospno = Utility.NullToEmptyString(dtpat.Rows(0).Item("HospitalNo"))
        If mHospno <> "" Then
            Call Split(mHospno)
        End If
        Me.lblLastName.Text = dtpat.Rows(0).Item("lastname") & " " & Utility.NullToEmptyString(dtpat.Rows(0).Item("suffixname")) & ", " & dtpat.Rows(0).Item("FirstName") & " " & dtpat.Rows(0).Item("MiddleName")

        Me.lblBirthDate.Text = dtpat.Rows(0).Item("BirthDate")
        Me.lblage.Text = Utility.NullToZero(dtpat.Rows(0).Item("age1"))
        Dim gender As String = UCase(dtpat.Rows(0).Item("Gender").ToString)
        If Trim(gender) = "M" Then
            Me.lblSex.Text = "Male"
        Else
            Me.lblSex.Text = "Female"
        End If

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
    Private Sub frmNursingNotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        subLoad(myFormStatus)
    End Sub

#End Region

#Region "Methods"
    Private Sub subLoad(ByVal frmstatus As String)
        EnableFields()
        Call LoadAdmissionInfo()
        'If frmstatus = enFormStatus.browsing Or frmstatus = enFormStatus.edit Then
        LoadREcord()
        'End If
        Me.tsSave.Image = modGlobal.save_icon
        Me.tsClose.Image = modGlobal.close_icon
        Me.KeyPreview = True
    End Sub
    Private Sub subsave()
        If AllDataEntryFieldsAreValid() = False Then
            Exit Sub
        Else
            SaveRecord()
            'Me.tsSave.Visible = False
            MessageBox.Show("Record/s successfully saved.", modGlobal.msgboxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        Dim x As New clsIVFluidSheet
        x.admissionid = Me.admissionid
        For i As Integer = 0 To Me.dgvMain.Rows.Count - 1
            x.ivfluidid = Me.dgvMain.Rows(i).Cells(colid.Index).Value
            x.bottleno = Utility.NullToEmptyString(Me.dgvMain.Rows(i).Cells(colbottleno.Index).Value)
            x.datestarted = Utility.NullToDefaultDateFormat(Me.dgvMain.Rows(i).Cells(coldatestarted.Index).Value)
            x.ivtype = Utility.NullToEmptyString(Me.dgvMain.Rows(i).Cells(colivtype.Index).Value)
            x.startedby = Utility.NullToZero(Me.dgvMain.Rows(i).Cells(colnurse1id.Index).Value)
            x.drugadditives = Utility.NullToEmptyString(Me.dgvMain.Rows(i).Cells(coldrugadditives.Index).Value)
            x.typeofcannula = Utility.NullToEmptyString(Me.dgvMain.Rows(i).Cells(coltypecannula.Index).Value)
            x.flowrate = Utility.NullToEmptyString(Me.dgvMain.Rows(i).Cells(colflowrate.Index).Value)
            x.dateended = Utility.NullToDefaultDateFormat(Me.dgvMain.Rows(i).Cells(coldateend.Index).Value)
            x.endedby = Utility.NullToZero(Me.dgvMain.Rows(i).Cells(colnurse2id.Index).Value)
            x.remarks = Utility.NullToEmptyString(Me.dgvMain.Rows(i).Cells(colremarks.Index).Value)
            x.issync = False
            x.server_id = 0
            x.isdeleted = False
            If x.ivfluidid = 0 Then
                x.ivfluidid = x.Save(True)
                Me.dgvMain.Rows(i).Cells(colid.Index).Value = x.ivfluidid
            Else
                x.Save(False)
            End If
        Next
    End Sub
    Public Sub LoadREcord()
        Dim dtRecord As New DataTable
        dtRecord = clsIVFluidSheet.genericcls(0, admissionid)
        Dim lastindex As Integer = 0
        For Each row As DataRow In dtRecord.Rows
            Me.dgvMain.Rows.Add(1)
            lastindex = Me.dgvMain.RowCount - 1
            Me.dgvMain.Rows(lastindex).Cells(colid.Index).Value = row.Item("ivfluidid")
            Me.dgvMain.Rows(lastindex).Cells(colbottleno.Index).Value = Utility.NullToEmptyString(row.Item("bottleno"))
            Me.dgvMain.Rows(lastindex).Cells(coldatestarted.Index).Value = Utility.NullToDefaultDateFormat(row.Item("datestarted"))
            Me.dgvMain.Rows(lastindex).Cells(colivtype.Index).Value = Utility.NullToEmptyString(row.Item("ivtype"))
            Me.dgvMain.Rows(lastindex).Cells(colnurse1id.Index).Value = Utility.NullToZero(row.Item("startedby"))
            Me.dgvMain.Rows(lastindex).Cells(colnurse1.Index).Value = Utility.NullToEmptyString(row.Item("startedbyname"))
            Me.dgvMain.Rows(lastindex).Cells(coldrugadditives.Index).Value = Utility.NullToEmptyString(row.Item("drugadditives"))
            Me.dgvMain.Rows(lastindex).Cells(coltypecannula.Index).Value = Utility.NullToEmptyString(row.Item("typeofcannula"))
            Me.dgvMain.Rows(lastindex).Cells(colflowrate.Index).Value = Utility.NullToEmptyString(row.Item("flowrate"))
            If Utility.NullToDefaultDateFormat(row.Item("dateended")) <> FormatDateTime("1/1/1900", DateFormat.ShortDate) Then
                Me.dgvMain.Rows(lastindex).Cells(coldateend.Index).Value = Utility.NullToDefaultDateFormat(row.Item("dateended"))
                Me.dgvMain.Rows(lastindex).Cells(colnurse2id.Index).Value = Utility.NullToZero(row.Item("endedby"))
                Me.dgvMain.Rows(lastindex).Cells(colnurse2.Index).Value = Utility.NullToEmptyString(row.Item("endedbyname"))
            Else
                Me.dgvMain.Rows(lastindex).Cells(colnurse2id.Index).Value = 0
                Me.dgvMain.Rows(lastindex).Cells(colnurse2.Index).Value = ""
            End If
            Me.dgvMain.Rows(lastindex).Cells(colremarks.Index).Value = Utility.NullToEmptyString(row.Item("remarks"))
        Next
    End Sub

#End Region

    Private Sub btnAddNote_Click(sender As System.Object, e As System.EventArgs) Handles btnAddNote.Click
        afterload = False
        Me.dgvMain.Rows.Add(1)
        Me.dgvMain.Rows(Me.dgvMain.RowCount - 1).Cells(coldatestarted.Index).Value = Utility.GetServerDate
        Me.dgvMain.Rows(Me.dgvMain.RowCount - 1).Cells(colid.Index).Value = 0
        Me.dgvMain.Rows(Me.dgvMain.RowCount - 1).Cells(colnurse1.Index).Value = modGlobal.ulastName & ", " & modGlobal.ufirstName
        Me.dgvMain.Rows(Me.dgvMain.RowCount - 1).Cells(colnurse1id.Index).Value = modGlobal.employeeid
        Me.dgvMain.FirstDisplayedScrollingRowIndex = Me.dgvMain.RowCount - 1
        Me.dgvMain.Rows(Me.dgvMain.RowCount - 1).Cells(colbottleno.Index).Selected = True
        Me.dgvMain.Select()
        afterload = True
    End Sub

    Private Sub dgvNotes_CellPainting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvMain.CellPainting
        Try
            If e.ColumnIndex = colremove.Index AndAlso e.RowIndex >= 0 Then
                e.Paint(e.CellBounds, DataGridViewPaintParts.All)
                Dim bmpFind As Bitmap = modGlobal.remove_icon  'ImageList1.Images(1)
                Dim ico As Icon = Icon.FromHandle(bmpFind.GetHicon)
                e.Graphics.DrawIcon(ico, e.CellBounds.Left + 7, e.CellBounds.Top + Me.dgvMain.Rows(e.RowIndex).Height / 2 - 8)
                e.Handled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvNotes_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMain.CellContentClick
        If e.ColumnIndex = colremove.Index Then
            If Me.dgvMain.Rows(e.RowIndex).Cells(colnurse1id.Index).Value <> modGlobal.employeeid Then
                MessageBox.Show("Cannot delete notes which is not created by you!", modGlobal.msgboxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If MessageBox.Show("Are you sure you want to remove this note?", modGlobal.msgboxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Dim x As New clsIVFluidSheet
                If Val(Me.dgvMain.Rows(e.RowIndex).Cells(colid.Index).Value) > 0 Then
                    x.isdeleted = True
                    x.issync = False
                    x.ivfluidid = Me.dgvMain.Rows(e.RowIndex).Cells(colid.Index).Value
                    x.Remove()
                    Me.dgvMain.Rows.RemoveAt(e.RowIndex)
                Else
                    Me.dgvMain.Rows.RemoveAt(e.RowIndex)
                End If
            End If
        End If
    End Sub

    Private Sub tsPrint_Click(sender As System.Object, e As System.EventArgs) Handles tsPrint.Click
        'Dim frm As New frmReportHandler
        'Dim crpt As New crptIVFluidSheet
        'Dim dtRecord As DataTable = clsIVFluidSheet.genericcls(0, admissionid)
        'crpt.SetDataSource(dtRecord)
        'frm.crvPrinting.ReportSource = crpt
        'frm.ShowDialog()
        'frm.Dispose()
    End Sub

    Private Sub dgvNotes_CurrentCellDirtyStateChanged(sender As System.Object, e As System.EventArgs) Handles dgvMain.CurrentCellDirtyStateChanged
        If (dgvMain.IsCurrentCellDirty) Then
            dgvMain.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgvMain_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMain.CellValueChanged
        Try
            If Not afterload Then
                Exit Sub
            End If
            If e.RowIndex >= 0 And e.ColumnIndex = coldateend.Index Then
                If dgvMain.Rows(e.RowIndex).Cells(colnurse2id.Index).Value = 0 Then
                    Me.dgvMain.Rows(e.RowIndex).Cells(colnurse2.Index).Value = modGlobal.ulastName & ", " & modGlobal.ufirstName
                    Me.dgvMain.Rows(e.RowIndex).Cells(colnurse2id.Index).Value = modGlobal.employeeid
                End If
            End If
            If e.RowIndex >= 0 And e.ColumnIndex = coldatestarted.Index Then
                If dgvMain.Rows(e.RowIndex).Cells(colnurse1id.Index).Value = 0 Then
                    Me.dgvMain.Rows(e.RowIndex).Cells(colnurse1.Index).Value = modGlobal.ulastName & ", " & modGlobal.ufirstName
                    Me.dgvMain.Rows(e.RowIndex).Cells(colnurse1id.Index).Value = modGlobal.employeeid
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class