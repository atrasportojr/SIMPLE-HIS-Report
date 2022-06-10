Imports System.Drawing.Drawing2D

Public Class frmNursingNotes
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

    Private colremoveidx As Integer = 0
    Private colnotedateidx As Integer = 1
    Private colfocusidx As Integer = 2
    Private coldataidx As Integer = 3
    Private colactionidx As Integer = 4
    Private colresponseidx As Integer = 5
    Private colnurseidx As Integer = 6
    Private colnurseididx As Integer = 7
    Private colididx As Integer = 8
#End Region

#Region "validation"
    Private Sub SetErrorProvider(ByVal ctl As Control, Optional ByVal strErrorMessage As String = "")
        erp.SetError(ctl, strErrorMessage)
    End Sub
    Private Function AllDataEntryFieldsAreValid() As Boolean
        Dim blnValid As Boolean = True

        For i As Integer = 0 To Me.dgvNotes.Rows.Count - 1
            'If Trim(Me.dgvNotes.Rows(i).Cells(colfocusidx).Value) = "" Then
            '    Me.dgvNotes.FirstDisplayedScrollingRowIndex = i
            '    Me.dgvNotes.Rows(i).Cells(colfocusidx).ErrorText = "This field is required!"
            '    blnValid = False
            '    Return blnValid
            '    Exit Function
            'Else
            '    Me.dgvNotes.Rows(i).Cells(colfocusidx).ErrorText = ""
            'End If
            If Trim(Me.dgvNotes.Rows(i).Cells(coldataidx).Value) = "" And Trim(Me.dgvNotes.Rows(i).Cells(colactionidx).Value) = "" And Trim(Me.dgvNotes.Rows(i).Cells(colresponseidx).Value) = "" Then
                Me.dgvNotes.Rows(i).Cells(coldataidx).ErrorText = "This field is required!"
                Me.dgvNotes.Rows(i).Cells(colactionidx).ErrorText = "This field is required!"
                Me.dgvNotes.Rows(i).Cells(colresponseidx).ErrorText = "This field is required!"
                Me.dgvNotes.FirstDisplayedScrollingRowIndex = i
                blnValid = False
                Return blnValid
                Exit Function
            Else
                Me.dgvNotes.Rows(i).Cells(coldataidx).ErrorText = ""
                Me.dgvNotes.Rows(i).Cells(colactionidx).ErrorText = ""
                Me.dgvNotes.Rows(i).Cells(colresponseidx).ErrorText = ""
            End If
        Next
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
    Private Sub addColumns()
        Dim colremove As New DataGridViewButtonColumn
        colremove.HeaderText = ""
        colremove.Width = 30
        Me.dgvNotes.Columns.Add(colremove)
        Dim coldate As New CalendarColumn
        coldate.HeaderText = "DATE/TIME"
        coldate.Width = 120
        coldate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvNotes.Columns.Add(coldate)
        Dim colfocus As New DataGridViewTextBoxColumn
        colfocus.HeaderText = "FOCUS"
        colfocus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'colfocus.Width = 200
        colfocus.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgvNotes.Columns.Add(colfocus)
        Dim coldata As New DataGridViewTextBoxColumn
        coldata.HeaderText = "DATA"
        coldata.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        coldata.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgvNotes.Columns.Add(coldata)
        Dim colaction As New DataGridViewTextBoxColumn
        colaction.HeaderText = "ACTION"
        colaction.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colaction.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgvNotes.Columns.Add(colaction)
        Dim colresponse As New DataGridViewTextBoxColumn
        colresponse.HeaderText = "RESPONSE"
        colresponse.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colresponse.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgvNotes.Columns.Add(colresponse)
        Dim colnurse As New DataGridViewTextBoxColumn
        colnurse.HeaderText = "NURSE"
        colnurse.Width = 100
        colnurse.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        colnurse.ReadOnly = True
        Me.dgvNotes.Columns.Add(colnurse)
        Dim colnurseid As New DataGridViewTextBoxColumn
        colnurseid.HeaderText = "ID"
        colnurseid.Visible = False
        Me.dgvNotes.Columns.Add(colnurseid)
        Dim colid As New DataGridViewTextBoxColumn
        colid.HeaderText = "ID"
        colid.Visible = False
        Me.dgvNotes.Columns.Add(colid)
        dgvNotes.Columns(colfocusidx).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvNotes.Columns(coldataidx).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvNotes.Columns(colactionidx).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvNotes.Columns(colresponseidx).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvNotes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        dgvNotes.RowTemplate.MinimumHeight = 48
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
        Call addColumns()
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
        Dim x As New clsNursingNotes
        x.admissionid = Me.admissionid
        For i As Integer = 0 To Me.dgvNotes.Rows.Count - 1
            x.nursenotesid = Me.dgvNotes.Rows(i).Cells(colididx).Value
            x.nurseid = Me.dgvNotes.Rows(i).Cells(colnurseididx).Value
            x.dateofnote = Me.dgvNotes.Rows(i).Cells(colnotedateidx).Value
            x.focus = Utility.NullToEmptyString(Me.dgvNotes.Rows(i).Cells(colfocusidx).Value)
            x.data = Utility.NullToEmptyString(Me.dgvNotes.Rows(i).Cells(coldataidx).Value)
            x.action = Utility.NullToEmptyString(Me.dgvNotes.Rows(i).Cells(colactionidx).Value)
            x.response = Utility.NullToEmptyString(Me.dgvNotes.Rows(i).Cells(colresponseidx).Value)

            x.issync = False
            x.server_id = 0
            x.isdeleted = False
            If x.nursenotesid = 0 Then
                x.nursenotesid = x.Save(True)
                Me.dgvNotes.Rows(i).Cells(colididx).Value = x.nursenotesid
            Else
                x.Save(False)
            End If
        Next
    End Sub
    Public Sub LoadREcord()
        Dim dtRecord As New DataTable
        dtRecord = clsNursingNotes.GetNotes(0, admissionid)
        Dim lastindex As Integer = 0
        For Each row As DataRow In dtRecord.Rows
            Me.dgvNotes.Rows.Add(1)
            lastindex = Me.dgvNotes.RowCount - 1
            Me.dgvNotes.Rows(lastindex).Cells(colnotedateidx).Value = Utility.NullToDefaultDateFormat(row.Item("dateofnote"))
            Me.dgvNotes.Rows(lastindex).Cells(colfocusidx).Value = Utility.NullToEmptyString(row.Item("focus"))
            Me.dgvNotes.Rows(lastindex).Cells(coldataidx).Value = Utility.NullToEmptyString(row.Item("data"))
            Me.dgvNotes.Rows(lastindex).Cells(colactionidx).Value = Utility.NullToEmptyString(row.Item("action"))
            Me.dgvNotes.Rows(lastindex).Cells(colresponseidx).Value = Utility.NullToEmptyString(row.Item("response"))
            Me.dgvNotes.Rows(lastindex).Cells(colnurseididx).Value = Utility.NullToZero(row.Item("nurseid"))
            Me.dgvNotes.Rows(lastindex).Cells(colnurseidx).Value = Utility.NullToEmptyString(row.Item("nurse"))
            Me.dgvNotes.Rows(lastindex).Cells(colididx).Value = row.Item("nursenotesid")
            If Utility.NullToZero(row.Item("nurseid")) = modGlobal.employeeid Then
                Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).DefaultCellStyle.BackColor = Color.PeachPuff
                Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).DefaultCellStyle.SelectionBackColor = Color.PeachPuff
                Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).ReadOnly = False
            Else
                Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).DefaultCellStyle.BackColor = Color.White
                Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).DefaultCellStyle.SelectionBackColor = Color.White
                Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).ReadOnly = True
            End If
        Next
    End Sub

#End Region

    Private Sub btnAddNote_Click(sender As System.Object, e As System.EventArgs) Handles btnAddNote.Click
        Me.dgvNotes.Rows.Add(1)
        Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).Cells(colnotedateidx).Value = Utility.GetServerDate
        Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).Cells(colididx).Value = 0
        Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).Cells(colnurseidx).Value = modGlobal.ulastName & ", " & modGlobal.ufirstName
        Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).Cells(colnurseididx).Value = modGlobal.employeeid
        Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).Cells(colfocusidx).Value = ""
        Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).Cells(coldataidx).Value = ""
        Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).Cells(colactionidx).Value = ""
        Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).Cells(colresponseidx).Value = ""
        Me.dgvNotes.FirstDisplayedScrollingRowIndex = Me.dgvNotes.RowCount - 1
        Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).Cells(colfocusidx).Selected = True
        Me.dgvNotes.Rows(Me.dgvNotes.RowCount - 1).DefaultCellStyle.BackColor = Color.PeachPuff
        Me.dgvNotes.Select()
    End Sub

    Private Sub dgvNotes_CellPainting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvNotes.CellPainting
        Try
            If e.ColumnIndex = colremoveidx AndAlso e.RowIndex >= 0 Then
                e.Paint(e.CellBounds, DataGridViewPaintParts.All)
                Dim bmpFind As Bitmap = modGlobal.remove_icon  'ImageList1.Images(1)
                Dim ico As Icon = Icon.FromHandle(bmpFind.GetHicon)
                e.Graphics.DrawIcon(ico, e.CellBounds.Left + 7, e.CellBounds.Top + Me.dgvNotes.Rows(e.RowIndex).Height / 2 - 8)
                e.Handled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvNotes_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvNotes.CellContentClick
        If e.ColumnIndex = colremoveidx Then
            If Me.dgvNotes.Rows(e.RowIndex).Cells(colnurseididx).Value <> modGlobal.employeeid Then
                MessageBox.Show("Cannot delete notes which are not created by you!", modGlobal.msgboxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If MessageBox.Show("Are you sure you want to remove this note?", modGlobal.msgboxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Dim x As New clsNursingNotes
                If Val(Me.dgvNotes.Rows(e.RowIndex).Cells(colididx).Value) > 0 Then
                    x.isdeleted = True
                    x.issync = False
                    x.nursenotesid = Me.dgvNotes.Rows(e.RowIndex).Cells(colididx).Value
                    x.RemoveNote()
                    Me.dgvNotes.Rows.RemoveAt(e.RowIndex)
                Else
                    Me.dgvNotes.Rows.RemoveAt(e.RowIndex)
                End If
            End If
        End If
    End Sub

    Private Sub tsPrint_Click(sender As System.Object, e As System.EventArgs) Handles tsPrint.Click
        'Dim frm As New frmReportHandler
        'Dim crpt As New crptNursingNotes_V2
        'Dim dtRecord As DataTable = clsNursingNotes.getReportData(admissionid)
        'crpt.SetDataSource(dtRecord)
        'frm.crvPrinting.ReportSource = crpt
        'frm.ShowDialog()
        'frm.Dispose()
    End Sub

    Private Sub dgvNotes_CurrentCellDirtyStateChanged(sender As System.Object, e As System.EventArgs) Handles dgvNotes.CurrentCellDirtyStateChanged
        If (dgvNotes.IsCurrentCellDirty) Then
            dgvNotes.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
End Class