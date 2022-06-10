Imports System.Drawing.Drawing2D

Public Class frmPrescriptionList
    Inherits Windows.Forms.Form

#Region "Variables"
    Dim erp As New ErrorProvider
    Public isSave As Boolean
    Public myFormStatus As enFormStatus
    Public admissionid As Long
    Private dtRecord As New DataTable
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
#End Region
#Region "Events"
    Private Sub frmLaboratoryDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        subLoad(myFormStatus)
    End Sub

#End Region

#Region "Methods"
    Private Sub subLoad(ByVal frmstatus As String)
        EnableFields()
        Call LoadAdmissionInfo()
        loadRx()
        loadTestRequest()
    End Sub
    Private Sub EnableFields()
        'If myFormStatus = enFormStatus.add Or myFormStatus = enFormStatus.edit Then
        '    Me.tsSave.Visible = True
        'ElseIf myFormStatus = enFormStatus.browsing Then
        '    Me.tsSave.Visible = False
        'End If
    End Sub
    Public Sub loadRx()
        dtRecord.Rows.Clear()
        Me.dvgListOfPrescribedMedicines.Rows.Clear()
        Me.ts_newrx.Enabled = True
        dtRecord = clsDashboard.getClinicPatients(1, Me.admissionid)
        Me.dvgListOfPrescribedMedicines.Columns(colprescriptiondescription.Index).HeaderText = "Drug Name"
        Me.dvgListOfPrescribedMedicines.DefaultCellStyle.SelectionBackColor = Color.White
        'Me.dvgListOfPrescribedMedicines.DefaultCellStyle.SelectionForeColor = themecolor3
        Me.dvgListOfPrescribedMedicines.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        For ctr = 0 To dtRecord.Rows.Count - 1
            If Trim(Utility.NullToEmptyString(dtRecord.Rows(ctr).Item("drugs"))) <> "" Then
                Me.dvgListOfPrescribedMedicines.Rows.Add(1)
                Me.dvgListOfPrescribedMedicines.Rows(dvgListOfPrescribedMedicines.RowCount - 1).Cells(colprescriptionid.Index).Value = dtRecord.Rows(ctr).Item("prescriptionid").ToString()
                Me.dvgListOfPrescribedMedicines.Rows(dvgListOfPrescribedMedicines.RowCount - 1).Cells(colprescriptiondescription.Index).Value = dtRecord.Rows(ctr).Item("drugs").ToString()
                Me.dvgListOfPrescribedMedicines.Rows(dvgListOfPrescribedMedicines.RowCount - 1).Cells(colispostrequest.Index).Value = Utility.NullToZero(dtRecord.Rows(ctr).Item("refpatientrequestno")) > 0
            End If
        Next
        If dtRecord.Rows.Count > 0 Then
            Me.ts_editrx.Enabled = True
            Me.ts_deleterx.Enabled = True
            Me.tsPrintPrescription.Enabled = True
            Me.tspreprintedprescription.Enabled = True
        End If

        dvgListOfPrescribedMedicines.Columns(colprescriptiondescription.Index).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dvgListOfPrescribedMedicines.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        dvgListOfPrescribedMedicines.AllowUserToResizeRows = True
        dvgListOfPrescribedMedicines.AllowUserToResizeRows = True
    End Sub

    Private Sub loadTestRequest()
        dtRecord.Rows.Clear()
        Me.dgvTestRequest.Rows.Clear()
        Me.ts_newtestrequest.Enabled = True
        Me.tsprinttestrequest.Enabled = False
        dtRecord = clsRadiologyLaboratory.getGeneric(10, admissionid)
        Me.dgvTestRequest.DefaultCellStyle.SelectionBackColor = Color.White
        'Me.dgvTestRequest.DefaultCellStyle.SelectionForeColor = themecolor3
        Me.dgvTestRequest.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        For i As Integer = 0 To dtRecord.Rows.Count - 1
            Me.dgvTestRequest.Rows.Add(1)
            Me.dgvTestRequest.Rows(Me.dgvTestRequest.Rows.Count - 1).Cells(coltestrequestid.Index).Value = dtRecord.Rows(i).Item("testrequestid")
            Me.dgvTestRequest.Rows(Me.dgvTestRequest.Rows.Count - 1).Cells(coltestrequestdetails.Index).Value = dtRecord.Rows(i).Item("tests")
            Me.dgvTestRequest.Rows(Me.dgvTestRequest.Rows.Count - 1).Cells(coldestinationoffice.Index).Value = dtRecord.Rows(i).Item("destinationoffice")
            Me.dgvTestRequest.Rows(Me.dgvTestRequest.Rows.Count - 1).Cells(colispostrequesttest.Index).Value = Utility.NullToZero(dtRecord.Rows(i).Item("refpatientrequestno")) > 0
        Next

        dgvTestRequest.Columns(coltestrequestdetails.Index).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvTestRequest.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        dgvTestRequest.AllowUserToResizeRows = True
        dgvTestRequest.ClearSelection()
    End Sub

#End Region

    Private Sub tsPrintPrescription_Click(sender As System.Object, e As System.EventArgs) Handles tsPrintPrescription.Click
        Try
            If dvgListOfPrescribedMedicines.CurrentRow.Index >= 0 Then
                dtRecord = clsReportDashboard.genericcls(3, dvgListOfPrescribedMedicines.CurrentRow.Cells(colprescriptionid.Index).Value, 0)
                Call clsDashboard.printPrescription(dtRecord)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tspreprintedprescription_Click(sender As System.Object, e As System.EventArgs) Handles tspreprintedprescription.Click
        Try
            If dvgListOfPrescribedMedicines.CurrentRow.Index >= 0 Then
                dtRecord = clsReportDashboard.genericcls(3, Me.admissionid, 1)
                Call clsDashboard.printPreprintedPrescription(dtRecord)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tsprinttestrequest_Click(sender As System.Object, e As System.EventArgs) Handles tsprinttestrequest.Click
        'Try
        '    If dgvTestRequest.CurrentRow.Index >= 0 Then
        '        Dim reportviewer As New frmReportHandler
        '        Me.dtRecord.Clear()
        '        Me.dtRecord = clsReportDashboard.genericcls(8, dgvTestRequest.CurrentRow.Cells(coltestrequestid.Index).Value, 0, modGlobal.employeeid)
        '        If dgvTestRequest.CurrentRow.Cells(coldestinationoffice.Index).Value = "007" Then
        '            Dim cr As New crptTestRequestLHI_v2
        '            cr.SetDataSource(dtRecord)
        '            reportviewer.crvPrinting.ReportSource = cr
        '        Else
        '            Dim cr As New crptRadRequestLHI
        '            cr.SetDataSource(dtRecord)
        '            reportviewer.crvPrinting.ReportSource = cr
        '        End If
        '        'reportviewer.crvPrinting.Zoom(1)
        '        reportviewer.ShowDialog()
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub ts_newrx_Click(sender As System.Object, e As System.EventArgs) Handles ts_newrx.Click
        Dim f As New frmPrescription(frmPrescription.enFormStatus.add)
        f.admissionID = Me.admissionid
        f.ShowDialog()
        If f.isSave Then
            Call loadRx()
        End If
    End Sub

    Private Sub ts_editrx_Click(sender As System.Object, e As System.EventArgs) Handles ts_editrx.Click
        Try
            Dim f As New frmPrescription(frmPrescription.enFormStatus.edit)
            f.admissionID = Me.admissionid
            f.oldprescriptionid = Me.dvgListOfPrescribedMedicines.CurrentRow.Cells(colprescriptionid.Index).Value
            f.ShowDialog()
            If f.isSave Then
                Call loadRx()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dvgListOfPrescribedMedicines_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dvgListOfPrescribedMedicines.SelectionChanged
        Try
            If Me.dvgListOfPrescribedMedicines.CurrentRow.Index >= 0 Then
                Me.ts_editrx.Enabled = True
                Me.ts_deleterx.Enabled = True
                Me.tsPrintPrescription.Enabled = True
                Me.tspreprintedprescription.Enabled = True
            Else
                Me.ts_editrx.Enabled = False
                Me.ts_deleterx.Enabled = False
                Me.tsPrintPrescription.Enabled = False
                Me.tspreprintedprescription.Enabled = False
            End If
        Catch ex As Exception
            Me.ts_editrx.Enabled = False
            Me.ts_deleterx.Enabled = False
            Me.tsPrintPrescription.Enabled = False
            Me.tspreprintedprescription.Enabled = False
        End Try
    End Sub

    Private Sub ts_deleterx_Click(sender As System.Object, e As System.EventArgs) Handles ts_deleterx.Click
        Try
            Dim str As String = "Are you sure you want to delete this prescription"
            If MessageBox.Show(str & "?", modGlobal.msgboxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                clsDashboard.DeleteMainPrescription(Me.dvgListOfPrescribedMedicines.CurrentRow.Cells(colprescriptionid.Index).Value)
                Me.dvgListOfPrescribedMedicines.Rows.RemoveAt(Me.dvgListOfPrescribedMedicines.CurrentRow.Index)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvTestRequest_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvTestRequest.SelectionChanged
        Try
            If Me.dgvTestRequest.SelectedRows(0).Index >= 0 Then
                Me.ts_edittestrequest.Enabled = True
                Me.ts_deletetestrequest.Enabled = True
                Me.tsprinttestrequest.Enabled = True
            Else
                Me.ts_edittestrequest.Enabled = False
                Me.ts_deletetestrequest.Enabled = False
                Me.tsprinttestrequest.Enabled = False
            End If
        Catch ex As Exception
            Me.ts_edittestrequest.Enabled = False
            Me.ts_deletetestrequest.Enabled = False
            Me.tsprinttestrequest.Enabled = False
        End Try
    End Sub

    Private Sub ts_newtestrequest_Click(sender As System.Object, e As System.EventArgs) Handles ts_newtestrequest.Click
        Dim f As New frmTestRequest
        f.myFormStatus = frmTestRequest.enFormStatus.add
        f.admissionid = Me.admissionid
        f.ShowDialog()
        If f.isSave Then
            Call loadTestRequest()
        End If
    End Sub

    Private Sub ts_edittestrequest_Click(sender As System.Object, e As System.EventArgs) Handles ts_edittestrequest.Click
        Try
            Dim f As New frmTestRequest
            f.myFormStatus = frmTestRequest.enFormStatus.edit
            f.admissionid = Me.admissionid
            f.oldtestrequestid = Me.dgvTestRequest.CurrentRow.Cells(coltestrequestid.Index).Value
            f.ShowDialog()
            If f.isSave Then
                Call loadTestRequest()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ts_deletetestrequest_Click(sender As System.Object, e As System.EventArgs) Handles ts_deletetestrequest.Click
        Try
            Dim str As String = "Are you sure you want to delete this test request"
            If MessageBox.Show(str & "?", modGlobal.msgboxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                clsRadiologyLaboratory.RemoveMainTestRequest(Me.dgvTestRequest.CurrentRow.Cells(coltestrequestid.Index).Value)
                Me.dgvTestRequest.Rows.RemoveAt(Me.dgvTestRequest.CurrentRow.Index)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ts_newtestrequest_Click_1(sender As System.Object, e As System.EventArgs) Handles ts_newtestrequest.Click
        Dim f As New frmTestRequest
        f.myFormStatus = frmTestRequest.enFormStatus.add
        f.admissionid = Me.admissionid
        f.ShowDialog()
        If f.isSave Then
            Call loadTestRequest()
        End If
    End Sub
End Class