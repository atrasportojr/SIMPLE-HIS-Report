Imports System.Drawing.Drawing2D
Public Class frmTestRequest
#Region "Variables"
    'Public Variables
    Public admissionid As Long
    Public PatientReqno As Long
    Public isSave As Boolean
    Public admissiondetailid As Long
    Public trackinventory As Boolean

    Dim isFirstLoad As Boolean
    'Private Variables
    Dim istag As Boolean
    Dim office As String
    Dim docno As Long
    Dim registrydeatilno As Long
    Dim dtSelectedItem, dtDel As New DataTable
    Dim EditRow As Integer
    Dim HospPlanCode As Integer
    Dim isphic As Integer
    Dim isLabItem As Boolean = False

    Public myFormStatus As enFormStatus
    Dim erp As New ErrorProvider
    Public oldrefpatientrequestno, oldtestrequestid As Long
    Private dtRecord As New DataTable
    Private itemcount As Integer

    Enum enFormStatus
        browsing = 0 : add = 1 : edit = 2 : view = 3
    End Enum
#End Region
#Region "Form Events"
    Private Sub frmRequisition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        isFirstLoad = True
        trackinventory = IsTrackinventory()
        Call LoadOffice()
        Call FormatGridSelectedItem()
        'Call FormatGrid()
        Call LoadRecords()

        If Me.myFormStatus = enFormStatus.add Then
            'btnRequest.Text = "Request [Ctrl + S]"
            office = cmbOffices.SelectedValue.ToString
            Me.tsprint.Visible = False
            Me.tsseparatorprint.Visible = False
        Else
            'btnRequest.Text = "Request [Ctrl + S]"
        End If
        If Me.myFormStatus = enFormStatus.browsing Then
            Call enabledFields(False)
            Call isViewing()
        Else
            Call fetchItems(office)
            Call FormatGrid()
        End If

        Me.txtSearch.Select()
        isFirstLoad = False
    End Sub
    Private Sub SetErrorProvider(ByVal ctl As Control, Optional ByVal strErrorMessage As String = "")
        erp.SetError(ctl, strErrorMessage)
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
        If Me.cmbOffices.SelectedIndex < 0 Then
            SetErrorProvider(Me.cmbOffices, "This field is required")
            blnValid = False
            Return blnValid
            Exit Function
        End If
        Return blnValid
    End Function

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Call fetchItems(office)
        Call FormatGrid()
    End Sub
    Private Sub subSave()
        If AllDataEntryFieldsAreValid() = False Then
            Exit Sub
        Else
            If MsgBox("Are you sure you want to " & Me.tsSave.Text.ToLower() & " this Test?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, modGlobal.msgboxTitle) = MsgBoxResult.Yes Then
                If Save() Then
                    MessageBox.Show("Record successfully " & Me.tsSave.Text.ToLower() & "d.", modGlobal.msgboxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.dgSelectedItems.ReadOnly = True
                    Me.dgItemSelection.ReadOnly = True
                    Me.txtSearch.ReadOnly = True
                    enabledFields(False)
                    isSave = True
                    Me.btnRemove.Visible = False
                    'Call SaveLog("Doctor Dashboard Requisition", "Doctor Department Request", modGlobal.userid)
                Else
                    MsgBox("Transaction cancelled. You may try again thank you", MsgBoxStyle.Information, modGlobal.msgboxTitle)
                End If
            End If
        End If
    End Sub
    Private Function save(Optional ByVal id As Long = 0) As Boolean
        Dim x As New clsDashboard()
        Dim isPost As Boolean
        Dim cRequisition As New clsRequisition()
        Dim hasPostTest As Boolean
        For ctr = 0 To Me.dgSelectedItems.Rows.Count - 1
            If Me.dgSelectedItems.Rows(ctr).Cells(colitemcode.Index).Value <> "N/A External Test" Then
                hasPostTest = True
                Exit For
            End If
        Next
        'save Request
        If hasPostTest And Me.chkpostrequisition.Checked Then
            If Me.myFormStatus = enFormStatus.add Then
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
                cRequisition.registrydetailno = admissionid
                cRequisition.sourceoffice = modGlobal.sourceOfficeCode
                Dim transDt As New DataTable
                transDt = clsRequisition.getTransno(modGlobal.sourceOfficeCode)
                cRequisition.documentno = "PReq" & modGlobal.sourceOfficeCode & "-" & Format(transDt.Rows(0).Item("reqtransno"), "00000")
                cRequisition.purpose = "Doctors test request."
                cRequisition.requestedbyid = fLogin.RequestedByID
                cRequisition.daterequested = Utility.GetServerDate()
                cRequisition.dateapproved = Utility.GetServerDate()
                cRequisition.daterender = Utility.GetServerDate()
                cRequisition.destinationofficemaster = Me.cmbOffices.SelectedValue
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
        'Save Master test
        Dim xrad As New clsRadiologyLaboratory
        xrad.mtestrequestid = Me.oldtestrequestid
        xrad.madmissionid = Me.admissionid
        xrad.mrequestdate = Me.dtTime.Value
        xrad.murgency = False
        xrad.misfasting = False
        xrad.mmedication = ""
        xrad.mremarks = ""
        xrad.missync = False
        xrad.physician = Me.cmbphysician.SelectedValue
        xrad.mclinicid = modGlobal.ClinicID  'set to 4 when lutheran
        xrad.mserverid = 0
        xrad.destinationoffice = Me.cmbOffices.SelectedValue
        xrad.createdbyid = modGlobal.employeeid
        If myFormStatus = enFormStatus.add Then
            If isPost Then
                xrad.refpatientrequestno = cRequisition.patientrequestno
            Else
                xrad.refpatientrequestno = Nothing
            End If
            oldtestrequestid = xrad.SaveRequest(2, True)
        Else
            If oldrefpatientrequestno <> 0 Then
                xrad.refpatientrequestno = oldrefpatientrequestno
            Else
                If isPost Then
                    xrad.refpatientrequestno = cRequisition.patientrequestno
                Else
                    xrad.refpatientrequestno = Nothing
                End If
            End If
            xrad.SaveRequest(4, False)
        End If
        'delete details
        For i As Integer = 0 To dtDel.Rows.Count - 1
            clsRadiologyLaboratory.RemoveTest(Me.dtDel.Rows(i).Item("testrequestdetailid"))
            If Me.dtDel.Rows(i).Item("testrequestdetailid") > 0 Then
                dtRecord.Rows.Clear()
                dtRecord = clsDashboard.getMyPatients(23, admissionid, 0, 0, Me.dtDel.Rows(i).Item("itemcode"), Me.oldrefpatientrequestno)
                If dtRecord.Rows(0).Item("indicate") <> 0 Then
                    x.Deleterequestdetails(admissionid, Me.dtDel.Rows(i).Item("itemcode"), Me.oldrefpatientrequestno)
                End If
            End If
        Next

        'Save Test Details
        For ctr = 0 To Me.dgSelectedItems.Rows.Count - 1
            xrad.mtestrequestdetailid = Me.dgSelectedItems.Rows(ctr).Cells(colid.Index).Value
            xrad.mtestrequestid = oldtestrequestid
            If Me.dgSelectedItems.Rows(ctr).Cells(colitemcode.Index).Value = "" Or Me.dgSelectedItems.Rows(ctr).Cells(colitemcode.Index).Value = "N/A External Test" Then
                xrad.mitemcode = Me.dgSelectedItems.Rows(ctr).Cells(colitemdescription.Index).Value
            Else
                xrad.mitemcode = Me.dgSelectedItems.Rows(ctr).Cells(colitemcode.Index).Value
            End If
            If xrad.mtestrequestdetailid = 0 Then
                xrad.mtestrequestdetailid = xrad.SaveRequest(3, True)
                Me.dgSelectedItems.Rows(ctr).Cells(colid.Index).Value = xrad.mtestrequestdetailid
            Else
                xrad.SaveRequest(3, False)
            End If
        Next

        'Save request details
        For i As Integer = 0 To dgSelectedItems.Rows.Count - 1
            If Me.dgSelectedItems.Rows(i).Cells(colitemcode.Index).Value <> "N/A External Test" And Me.dgSelectedItems.Rows(i).Cells(colitemcode.Index).Value <> "" Then
                dtRecord = clsDashboard.getMyPatients(24, oldrefpatientrequestno, 0, 0, Me.dgSelectedItems.Rows(i).Cells(colitemcode.Index).Value.ToString().Trim())
                If myFormStatus = enFormStatus.add Then
                    If isPost Then
                        cRequisition.itemcode = Me.dgSelectedItems.Rows(i).Cells(colitemcode.Index).Value
                        cRequisition.quantityrequested = 1
                        cRequisition.quantityrendered = 1
                        cRequisition.remarks = Utility.NullToEmptyString(Me.dgSelectedItems.Rows(i).Cells(colremarks.Index).Value)
                        cRequisition.destinationoffice = Me.cmbOffices.SelectedValue
                        cRequisition.stat = 2
                        cRequisition.saveDetails(True)
                    End If
                Else
                    If dtRecord.Rows.Count = 0 Then
                        If isPost Then
                            cRequisition.itemcode = Me.dgSelectedItems.Rows(i).Cells(colitemcode.Index).Value
                            cRequisition.quantityrequested = 1
                            cRequisition.quantityrendered = 1
                            cRequisition.remarks = Utility.NullToEmptyString(Me.dgSelectedItems.Rows(i).Cells(colremarks.Index).Value)
                            cRequisition.destinationoffice = Me.cmbOffices.SelectedValue
                            cRequisition.stat = 2
                            cRequisition.patientrequestno = xrad.refpatientrequestno
                            cRequisition.saveDetails(True)
                        End If
                    Else
                        cRequisition.itemcode = Me.dgSelectedItems.Rows(i).Cells(colitemcode.Index).Value
                        cRequisition.quantityrequested = 1
                        cRequisition.quantityrendered = 1
                        cRequisition.remarks = Utility.NullToEmptyString(Me.dgSelectedItems.Rows(i).Cells(colremarks.Index).Value)
                        cRequisition.destinationoffice = Me.cmbOffices.SelectedValue
                        cRequisition.stat = 2
                        cRequisition.patientrequestno = oldrefpatientrequestno
                        cRequisition.patientrequestdetailno = dtRecord.Rows(0)("p").ToString()
                        cRequisition.saveDetails(False)
                    End If
                End If
            End If
        Next
        isPost = False
        Return True
    End Function

    Private Sub WrapToDatagridCharge()
        Dim isexist As Boolean
        Dim idx As Integer = Me.dgItemSelection.CurrentRow.Index
        For Each row As DataGridViewRow In Me.dgSelectedItems.Rows
            If row.Cells(colitemcode.Index).Value = Me.dgItemSelection.Rows(idx).Cells("itemcode").Value Then
                isexist = True
                Exit For
            End If
        Next
        If Not isexist Then
            Me.dgSelectedItems.Rows.Add(1)
            With Me.dgSelectedItems.Rows(Me.dgSelectedItems.Rows.Count - 1)
                .Cells(colid.Index).Value = 0
                .Cells(colitemcode.Index).Value = Me.dgItemSelection.Rows(idx).Cells("itemcode").Value
                .Cells(colitemdescription.Index).Value = Me.dgItemSelection.Rows(idx).Cells("itemdescription").Value
                .Cells(colremarks.Index).Value = ""
                .Cells(colrequestdetailno.Index).Value = 0
            End With
        End If
    End Sub
    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If Me.dgSelectedItems.Rows.Count > 0 Then
            Dim hasSelect As Boolean
            For ctr = 0 To Me.dgSelectedItems.Rows.Count - 1
                If Me.dgSelectedItems.Rows(ctr).Cells(colselect.Index).Value = True Then
                    hasSelect = True : Exit For
                End If
            Next
            If hasSelect Then
                If MessageBox.Show("Are you sure you want to remove the selected test from the list?", modGlobal.msgboxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    Dim ok = False : Dim str As String = ""
                    Dim myEmp As New clsDashboard()
                    Dim counter As Integer = Me.dgSelectedItems.Rows.Count - 1
                    For ctr As Integer = counter To 0 Step -1
                        If Me.dgSelectedItems.Rows(ctr).Cells(colselect.Index).Value = True Then
                            If Me.dgSelectedItems.Rows(ctr).Cells(colid.Index).Value <> 0 Then
                                dtDel.Rows.Add(1)
                                dtDel.Rows(dtDel.Rows.Count - 1).Item("testrequestdetailid") = Me.dgSelectedItems.Item(colid.Index, ctr).Value
                                dtDel.Rows(dtDel.Rows.Count - 1).Item("patientrequestdetailno") = Me.dgSelectedItems.Item(colrequestdetailno.Index, ctr).Value
                                dtDel.Rows(dtDel.Rows.Count - 1).Item("itemcode") = Me.dgSelectedItems.Item(colitemcode.Index, ctr).Value
                            End If
                            Me.dgSelectedItems.Rows.RemoveAt(ctr)
                        End If
                    Next
                Else
                    For ctr = 0 To Me.dgSelectedItems.Rows.Count - 1
                        Me.dgSelectedItems.Rows(ctr).Cells(colselect.Index).Value = False
                    Next
                End If
            End If
        End If


    End Sub
    Private Sub dgItemSelection_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgItemSelection.CurrentCellDirtyStateChanged
        ''   <summary>
        '   ''' Added: June-11-2011
        '    ''' Author: Jumao-as
        '    ''' Requisition Module
        Dim dgCheckBox As DataGridViewCheckBoxCell
        Try
            If dgItemSelection.CurrentCellAddress.X = 0 Then
                dgCheckBox = dgItemSelection.CurrentRow.Cells(0)

                If (dgItemSelection.IsCurrentCellDirty) Then
                    dgItemSelection.CommitEdit(DataGridViewDataErrorContexts.Commit)

                    If dgCheckBox.Value Then
                        WrapToDatagridCharge()
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgSelectedItems.EditingControlShowing
    '    EditRow = dgSelectedItems.CurrentRow.Index
    'End Sub

    Private Sub dgSelectedItems_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgSelectedItems.RowsAdded
        dgSelectedItems.FirstDisplayedScrollingRowIndex = dgSelectedItems.Rows.Count - 1
        dgSelectedItems.Rows(dgSelectedItems.Rows.Count - 1).Selected = True
    End Sub
    'Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgSelectedItems.SelectionChanged
    '    If EditRow >= 0 Then
    '        Dim new_row As Integer = EditRow
    '        EditRow = -1
    '        dgSelectedItems.CurrentCell = dgSelectedItems.Rows(new_row).Cells(dgSelectedItems.CurrentCell.ColumnIndex)
    '    End If
    'End Sub
    Private Sub frmRequisition_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Delete Then
            btnRemove.PerformClick()
        ElseIf e.Control = True And e.KeyCode = Keys.S Then
            Call Save()
        ElseIf e.KeyCode = Keys.F3 Then
            Me.txtSearch.SelectAll()
            Me.txtSearch.Select()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
#End Region
#Region "Methods"
    Private Sub enabledFields(ByVal sw As Boolean)
        Me.dtTime.Enabled = sw
        Me.tsSave.Visible = sw
        Me.txtExternal.Enabled = sw
        Me.btnRemove.Enabled = sw
        Me.dtTime.Enabled = sw
        Me.btnaddexternal.Enabled = sw
    End Sub
    Private Function IsTrackinventory() As Boolean
        Dim isTrack As Boolean
        Dim dtrecords = clsHospitalInfo.getInfo(0, "")
        Try
            isTrack = dtrecords.Rows(0).Item("trackinventory")
        Catch ex As Exception
            MsgBox(ex.Message)
            isTrack = False
        End Try
        Return isTrack
    End Function
    Private Function getIndex(ByVal vitemcode As String, ByVal isLab As Boolean) As Integer
        Dim rowcount As Integer = Me.dgSelectedItems.Rows.Count
        Dim i As Integer
        If isLab = False Then
            For i = 0 To rowcount - 1
                If Me.dgSelectedItems.Item("itemcode", i).Value = vitemcode Then
                    Exit For
                End If
            Next
        Else
            i = rowcount - 1
        End If
        Return i
    End Function
    Public Sub FormatGrid()
        With Me.dgItemSelection
            '.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            '.DefaultCellStyle.Font = New Font("Tahoma", 9)
            '.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            '.AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(73, 163, 75)
            .AllowUserToAddRows = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DefaultCellStyle.Font = New Font("tahoma", 8)
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke ' themecolor4 'Color.FromArgb(80,123,139) ' Color.WhiteSmoke ' Color.OldLace 'Color.Gainsboro
            .RowsDefaultCellStyle.SelectionBackColor = themecolor3
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White 'Color.FromArgb(142,171,182) ' Color.White
            .AlternatingRowsDefaultCellStyle.SelectionBackColor = themecolor3
            .RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
            '.ReadOnly = True
            .Columns(0).Width = 60
            .Columns(0).ReadOnly = False
            .Columns(0).HeaderText = "Choose"
            .Columns(1).Width = 120
            .Columns(1).ReadOnly = True
            .Columns(1).HeaderText = "Item Code"
            .Columns(2).Width = 300
            .Columns(2).ReadOnly = True
            .Columns(2).HeaderText = "Brand Name"
            .Columns(3).Width = 200
            .Columns(3).HeaderText = "Generic Name"
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(4).Visible = False
            .Columns(5).Width = 65
            .Columns(5).HeaderText = "Inventory Balance"
            .Columns(5).DefaultCellStyle.Format = "#,##0"
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).ReadOnly = True
            .Columns(6).Width = 70
            .Columns(6).HeaderText = "Price 1"
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).DefaultCellStyle.Format = "#,##0.00"
            .Columns(6).ReadOnly = True
            .Columns(7).Width = 70
            .Columns(7).HeaderText = "Price 2"
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(7).DefaultCellStyle.Format = "#,##0.00"
            .Columns(7).ReadOnly = True
            '.Columns(7).Visible = False
            .Columns(8).HeaderText = "Philhealth"
        End With

    End Sub
    Public Sub FormatGridSelectedItem()
        With Me.dgSelectedItems
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .DefaultCellStyle.Font = New Font("tahoma", 8)
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke ' themecolor4 'Color.FromArgb(80,123,139) ' Color.WhiteSmoke ' Color.OldLace 'Color.Gainsboro
            .RowsDefaultCellStyle.SelectionBackColor = themecolor3
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White 'Color.FromArgb(142,171,182) ' Color.White
            .AlternatingRowsDefaultCellStyle.SelectionBackColor = themecolor3
            .RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
        dtDel.Columns.Add("testrequestdetailid")
        dtDel.Columns.Add("patientrequestdetailno")
        dtDel.Columns.Add("itemcode")
    End Sub
    Private Sub LoadRecords()
        dtRecord.Rows.Clear()
        dtRecord = clsDashboard.getMyPatients(1, admissionid)
        Me.KeyPreview = True
        Me.lblPatientNo.Text = dtRecord.Rows(0).Item("Patient No").ToString()
        Me.lblHospno.Text = Utility.formatHospitalNumber(dtRecord.Rows(0).Item("Hospital No").ToString())
        Me.txtPatName.Text = dtRecord.Rows(0).Item("Name").ToString()
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
            .SelectedValue = dtRecord.Rows(0).Item("admittingphysicianid")
        End With
        If Me.myFormStatus <> enFormStatus.add Then
            dtRecord = clsRadiologyLaboratory.getGeneric(9, oldtestrequestid)
            If dtRecord.Rows.Count = 0 Then
                MsgBox("Test request not found!", MsgBoxStyle.Information)
                Me.Close()
                Exit Sub
            End If
            Me.oldrefpatientrequestno = Utility.NullToZero(dtRecord.Rows(0).Item("refpatientrequestno"))
            Me.chkpostrequisition.Checked = Me.oldrefpatientrequestno > 0
            For ctr = 0 To dtRecord.Rows.Count - 1
                Me.dgSelectedItems.Rows.Add(1)
                With Me.dgSelectedItems.Rows(Me.dgSelectedItems.Rows.Count - 1)
                    .Cells(colid.Index).Value = dtRecord.Rows(ctr).Item("id")
                    .Cells(colitemcode.Index).Value = dtRecord.Rows(ctr).Item("itemcode").ToString()
                    .Cells(colitemdescription.Index).Value = dtRecord.Rows(ctr).Item("itemdescription").ToString()
                    .Cells(colremarks.Index).Value = ""
                    .Cells(colrequestdetailno.Index).Value = Me.oldrefpatientrequestno
                End With
            Next
            Me.cmbphysician.SelectedValue = dtRecord.Rows(0).Item("physician")
            Me.office = Utility.NullToEmptyString(dtRecord.Rows(0).Item("destinationoffice"))
            Me.cmbOffices.SelectedValue = Me.office
            Me.cmbOffices.Enabled = False
        End If

    End Sub
    Private Sub LoadDgDetails(ByVal dt As DataTable)
        For i = 0 To dt.Rows.Count - 1
            Dim dgvRow As New DataGridViewRow
            Dim dgvCell As DataGridViewCell

            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = dt.Rows(i).Item("itemcode") 'itemcode '0
            dgvRow.Cells.Add(dgvCell)

            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = dt.Rows(i).Item("itemdescription")  'description '1
            dgvRow.Cells.Add(dgvCell)

            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = dt.Rows(i).Item("itemspecs")  'unit '2
            dgvRow.Cells.Add(dgvCell)

            Dim qty As Double
            qty = dt.Rows(i).Item("Qty") '3
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = qty
            dgvRow.Cells.Add(dgvCell)


            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = dt.Rows(i).Item("remarks")
            dgvRow.Cells.Add(dgvCell)

            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = dt.Rows(i).Item("destinationoffice") 'amount '5
            dgvRow.Cells.Add(dgvCell)

            ' patientrequestdetailno
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = dt.Rows(i).Item("patientrequestdetailno")
            dgvRow.Cells.Add(dgvCell)

            Me.dgSelectedItems.Rows.Add(dgvRow)
        Next

    End Sub
    Private Sub fetchItems(ByVal office As String)
        Me.dgItemSelection.Columns.Clear()
        Dim dtItemsSelection As New DataTable
        dtItemsSelection = clsAncillary.getItemListing(office, txtSearch.Text, isphic, trackinventory)
        Me.dgItemSelection.DataSource = dtItemsSelection
    End Sub
    Public Sub LoadOffice()
        'isFirstLoad = True
        Me.cmbOffices.DataSource = clsRequisition.getOffices(9)
        Me.cmbOffices.DisplayMember = "officedescription"
        Me.cmbOffices.ValueMember = "officecode"
        'isFirstLoad = False
    End Sub
    Public Sub isViewing()
        Me.lblsearch.Visible = False
        Me.cmbOffices.Enabled = False
        Me.txtSearch.Visible = False
        Me.dgItemSelection.Visible = False
        Me.dgItemSelection.AutoSize = True
        Me.tsSave.Visible = False
        Me.btnRemove.Visible = False
        'Me.btnCancel.Visible = True
        'Me.btnCancel.Text = "Close [Esc]"
        Me.PictureBox1.Visible = False
        'Me.Panel2.Size = New Size(1097, 450)
        'Me.Panel2.Location = New Point(26, 159)
    End Sub
    Private Function isExistExternal(ByVal str As String, ByVal s As String)
        Dim ok As Boolean
        For ctr = 0 To Me.dgSelectedItems.Rows.Count - 1
            If s = Me.dgSelectedItems.Rows(ctr).Cells(colitemcode.Index).Value And Me.dgSelectedItems.Rows(ctr).Cells(colitemdescription.Index).Value = str Then
                ok = True : Exit For
            End If
        Next
        Return ok
    End Function
#End Region


    Private Sub cmbOffices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOffices.Click, cmbOffices.SelectedIndexChanged
        If isFirstLoad Then
            Exit Sub
        End If
        If dgSelectedItems.Rows.Count <> 0 Then

            If MsgBox("Are you sure you want to change this department?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, modGlobal.msgboxTitle) = MsgBoxResult.Yes Then

                office = cmbOffices.SelectedValue
                Call fetchItems(office)
                Call FormatGrid()
                If Me.myFormStatus = enFormStatus.add Then
                    dtSelectedItem.Rows.Clear()
                Else
                    For ctr = 0 To dgSelectedItems.Rows.Count - 1
                        dtDel.Rows.Add(1)
                        dtDel.Rows(dtDel.Rows.Count - 1).Item("testrequestdetailid") = Me.dgSelectedItems.Item(colid.Index, ctr).Value
                        dtDel.Rows(dtDel.Rows.Count - 1).Item("patientrequestdetailno") = Me.dgSelectedItems.Item(colrequestdetailno.Index, ctr).Value
                        dtDel.Rows(dtDel.Rows.Count - 1).Item("itemcode") = Me.dgSelectedItems.Item(colitemcode.Index, ctr).Value

                    Next
                    dtSelectedItem.Rows.Clear()
                    dgSelectedItems.Rows.Clear()
                End If

            End If
            Me.txtSearch.Select()
        Else
            If cmbOffices.SelectedValue Is Nothing Then
                Exit Sub
            End If
            office = cmbOffices.SelectedValue
            'office = "004"
            Call fetchItems(office)
            Call FormatGrid()
        End If

    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        subSave()
    End Sub

    Private Sub tsClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsClose.Click
        Me.Close()
    End Sub

    Private Sub btnaddexternal_Click(sender As System.Object, e As System.EventArgs) Handles btnaddexternal.Click
        If Me.txtExternal.Text = "" Then
            MessageBox.Show("Please enter a test name.", modGlobal.msgboxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf isExistExternal(Me.txtExternal.Text, "N/A External Test") = False Then
            Me.dgSelectedItems.Rows.Add(1)
            With Me.dgSelectedItems.Rows(Me.dgSelectedItems.Rows.Count - 1)
                .Cells(colid.Index).Value = 0
                .Cells(colitemcode.Index).Value = "N/A External Test"
                .Cells(colitemdescription.Index).Value = Me.txtExternal.Text
                .Cells(colremarks.Index).Value = ""
                .Cells(colrequestdetailno.Index).Value = 0
            End With
        Else
            MessageBox.Show("Item name is already in the list.", modGlobal.msgboxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub tsprint_Click(sender As System.Object, e As System.EventArgs) Handles tsprint.Click
        'Dim reportviewer As New frmReportHandler
        'Me.dtRecord.Clear()
        'Me.dtRecord = clsReportDashboard.genericcls(8, Me.oldtestrequestid, 0, modGlobal.employeeid)
        'If Me.cmbOffices.SelectedValue = "007" Then
        '    Dim cr As New crptTestRequestLHI_v2
        '    cr.SetDataSource(dtRecord)
        '    reportviewer.crvPrinting.ReportSource = cr
        'Else
        '    Dim cr As New crptRadRequestLHI
        '    cr.SetDataSource(dtRecord)
        '    reportviewer.crvPrinting.ReportSource = cr
        'End If
        ''reportviewer.crvPrinting.Zoom(1)
        'reportviewer.ShowDialog()
    End Sub
End Class