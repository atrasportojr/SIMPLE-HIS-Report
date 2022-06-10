Public Class frmSearchEngine
#Region "Variables"
    Public myCurrentFormStatus As enFormStatus
    Public isAdmissionSearch As Boolean
    Public mModuleName As String
    Public mofficecode As String
    Public mKey As String
    Public mRoomRate As String
    Public mDocFee As String
    Public mRVU As String
    Public mProcDescription As String
    Public mDiagnosisDesc As String
    Public mICD10Code As String
    Public mICD10Description As String
    Public mLastName As String
    Public mFirstName As String
    Public mAdmissionType As String
    Public mvalue As String
    Public isbilling As Boolean
    Dim misAvailable As Boolean = True
    Dim afteritemsload As Boolean = True
    Dim oldval As Boolean
    Dim vphilhealthno As String
    Public issave, istype As Boolean
    Public isPatientSearch As Boolean = False
    Private vdischargestatus As String
    Public Isnewborn As Boolean
    Public isexpired As Boolean
    Public afterload As Boolean
    Public AdmissionID As Long 'Add By IDRIZ
    Public mpatientid As Long 'Add By Royette
    Public caseratetype As Byte
    Public isActivePatient As Boolean = True
    Dim dtCharges As New DataTable()
    'Dim newAdmission As New clsAdmissiondetails
    Public dt As New DataTable
    Private dtitems As New DataTable
    Enum enFormStatus
        browsing = 0
        add = 1
        edit = 2
        view = 3
    End Enum

#End Region


#Region "Form Events"

    Private Sub frmSearchEngine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        FilterBy()
        Call LoadImage()
        If mModuleName = "PO" Or mModuleName = "BirthCertificate" Or mModuleName = "DeathCertificate" Then
            Me.btnIgnoreCreateNew.Visible = False
        End If

        Call DisplayList(mModuleName)
        Application.DoEvents()
        Me.txtSearch.Focus()
        Call LoadPrivileges(mModuleName)
    End Sub
    Private Sub btnIgnoreCreateNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIgnoreCreateNew.Click
        IgnoreCreateNew()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        issave = False
        Me.Close()
        Dispose()
    End Sub
    Private Sub btnSelRecClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSelRec.Click
        SelectedRecord()
    End Sub
    Private Sub dgGeneric_doubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgGeneric.DoubleClick
        Me.btnSelRec.PerformClick()
    End Sub
    Private Sub dgGeneric_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) 'Handles dgobygne.CellValidating
        Dim CurrentCellValue As Object = e.FormattedValue
        Dim CurrentCellValueMinusCurrenctyFormatting As String = Replace(CurrentCellValue.ToString, "$", "")

        Dim DoubleForConvert As Double
        If Double.TryParse(CurrentCellValueMinusCurrenctyFormatting, DoubleForConvert) = True Then
            dgGeneric.CurrentCell.Value = DoubleForConvert
        Else
            dgGeneric.CurrentCell.Value = 0
            e.Cancel = True
            Exit Sub
        End If

    End Sub
    Private Sub DataErrorTerminator(ByVal sender As Control, ByVal e As DataGridViewDataErrorEventArgs) Handles dgGeneric.DataError
        If TypeOf (e.Exception) Is ConstraintException Then
            Dim view As DataGridView = DirectCast(sender, DataGridView)
            view.Rows(e.RowIndex).ErrorText = "an error"
            view.Rows(e.RowIndex).Cells(e.ColumnIndex).ErrorText = "an error"
            e.ThrowException = False
        End If
    End Sub
    Public Sub DisplayList(ByVal search As String)
        Me.dgGeneric.DataSource = Nothing
        Me.dgGeneric.RowTemplate.Height = 34
        If search = "Patient" Then
            Dim patient As New clsAdmissiondetails
            With patient
                .isnewborn = Isnewborn
                .isexpired = isexpired
                Me.dgGeneric.DataSource = .PatientInfor(1, Me.txtSearch.Text, Me.isActivePatient)
            End With

        ElseIf search = "ICD10Diagnosis" Then
            Me.dgGeneric.DataSource = clsDischarge.getDiagnosis(Me.txtSearch.Text)
        ElseIf search = "Procedures" Then
            Me.dgGeneric.DataSource = clsProcedures.getProcedures(0, Me.txtSearch.Text, 0)
        ElseIf search = "Admissions" Then
            Me.dgGeneric.DataSource = clsHISReports.genericcls(3, Me.txtSearch.Text)
        End If
        Me.lblRecordCount.Text = Me.dgGeneric.Rows.Count & " rows"
        Call FormatGrid(search)


        If Me.dgGeneric.RowCount > 0 Then
            Me.dgGeneric.Rows(0).Selected = True
            Me.btnIgnoreCreateNew.Enabled = False
        Else
            Me.btnIgnoreCreateNew.Enabled = True
        End If

    End Sub
    Private Sub LoadPrivileges(ByRef search As String)
        'Dim accmod As Integer
        'Select Case search
        '    Case "Patient"
        '        accmod = modGlobal.AccountModule.modPatients
        '    Case "Doctors"
        '        accmod = modGlobal.AccountModule.modDoctors
        '    Case "Employees", "Medical Technologist", "Pathologist"
        '        accmod = modGlobal.AccountModule.modEmployees
        '    Case "Items"
        '        accmod = modGlobal.AccountModule.modItems
        '    Case "ICD10Diagnosis"
        '        accmod = modGlobal.AccountModule.modICD10
        '    Case "Physician"
        '        accmod = modGlobal.AccountModule.modDoctors
        '    Case Else
        '        accmod = 0
        'End Select
        'If accmod > 0 Then
        '    modGlobal.GetUserModules(accmod)
        '    Me.btnIgnoreCreateNew.Enabled = modGlobal.canAdd
        'End If
    End Sub
    Private Sub dgGeneric_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgGeneric.CellContentDoubleClick
        If mModuleName = "CashReceipt" Or mModuleName = "CashTransaction" Then
            Call SelectedRecord()
        End If
    End Sub
    Private Sub frmSearchEngine_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter And dgGeneric.Focused Then
            SelectedRecord()
        ElseIf e.KeyCode = Keys.F3 Then
            Me.txtSearch.Select()
        ElseIf e.Control = True And e.KeyCode = Keys.N And btnIgnoreCreateNew.TabIndex = 2 Then
            IgnoreCreateNew()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
            issave = False
            'Dispose()
        End If
    End Sub
    Public Sub FormatGrid(ByVal search As String)
        With dgGeneric
            'If Not .RowCount > 0 Then
            '    Exit Sub
            'End If
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DefaultCellStyle.Font = New Font("Tahoma", 7.85!)
            '.DefaultCellStyle.ForeColor = Color.DarkGreen
            '.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke ' Color.OldLace 'Color.Gainsboro
            ' .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(73, 163, 75)
            ' .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            ' .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(73, 163, 75)
            '.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
            .ReadOnly = True
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            If search = "Room" Then
                .Columns(0).Visible = False
                .Columns(1).Width = 100
                .Columns(1).HeaderText = "Room No"
                .Columns(2).Width = 650
                .Columns(2).HeaderText = "Room Description"
                .Columns(3).Visible = False
                .Columns(4).Visible = False
                .Columns(5).Width = 224
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                .Columns(5).DefaultCellStyle.Format = "#,##0.00"
                .Columns(5).HeaderText = "Room Rate"
            ElseIf search = "Items" Then
                .ReadOnly = False
                '========================'----used for printing certificates----'========================
            ElseIf search = "Birth Certificate" Then
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).Width = 200
                .Columns(2).HeaderText = "HospNo."
                .Columns(2).DefaultCellStyle.Format = "##-##-##"
                .Columns(3).Width = 600
                .Columns(3).HeaderText = "Patient Name"
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Width = 150
                .Columns(7).HeaderText = "is Released"
            ElseIf search = "Medical Certificate" Then
                .Columns(0).Visible = False
                .Columns(0).HeaderText = "AdmissionID"
                .Columns(1).Width = 120
                .Columns(1).HeaderText = "PTNo"
                .Columns(2).Visible = False
                .Columns(2).HeaderText = "Hospital No"
                .Columns(3).Width = 590
                .Columns(3).HeaderText = "Patient"
                .Columns(4).Width = 150
                .Columns(4).HeaderText = "Admitted"
                .Columns(5).Width = 150
                .Columns(5).HeaderText = "Discharged"
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                '========================'----used for printing certificates----'========================
            ElseIf search = "DietaryAdmissionPatient" Then
                .Columns("id").Visible = False
                .Columns("Patient No.").Width = 150
                .Columns("Hospital No.").Width = 180
                .Columns("Hospital No.").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns("Hospital No.").DefaultCellStyle.Format = "##00-00-00"
                .Columns("Patient Name").Width = 360
                .Columns("Address").Width = 410
            ElseIf search = "OtherCashierCollection" Then
                .Columns(0).Visible = False
                .Columns(1).Width = 500
                .Columns(2).Width = 450
                .Columns(3).Visible = False
            ElseIf search = "OtherCashierCollectionItems" Then
                .Columns(0).Width = 150
                .Columns(1).Width = 450
            ElseIf search = "Check Voucher Entry" Then
                .Columns(0).Visible = False
                Select Case Me.cmbFilterby.SelectedValue
                    Case 0
                        .Columns(1).Width = 500
                        .Columns(1).HeaderText = "Employee Name"
                        .Columns(2).Width = 450
                        .Columns(2).HeaderText = "Address"
                    Case 1
                        .Columns(0).Visible = False
                        .Columns(1).Visible = False
                        .Columns(1).HeaderText = ""
                        'DirectCast(.Columns(1), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
                        .Columns(2).Width = 100
                        .Columns(2).HeaderText = "Hospital No"
                        .Columns(3).Visible = False
                        .Columns(4).Width = 240
                        .Columns(4).HeaderText = "Patient Name"
                        .Columns(5).Width = 230
                        .Columns(5).HeaderText = "Address"
                        .Columns(6).Width = 100
                        .Columns(6).HeaderText = "Birthdate"
                        .Columns(7).Width = 80
                        .Columns(7).HeaderText = "Gender"
                        .Columns(8).Width = 60
                        .Columns(8).HeaderText = "Age"
                        .Columns(9).Width = 200
                        .Columns(9).HeaderText = "Birth Place"
                        '.Columns(9).Visible = False
                        .Columns(10).Visible = False
                        .Columns(11).Visible = False
                        .Columns(12).Visible = False
                        .Columns(13).Visible = False
                        .Columns(14).Visible = False
                        .Columns(15).Visible = False
                        .Columns(16).Visible = False
                        .Columns(17).Visible = False
                        .Columns(18).Visible = False
                        .Columns(19).Visible = False
                        .Columns(20).Visible = False
                        .Columns(21).Visible = False
                        .Columns(22).Visible = False
                        .Columns(23).Visible = False
                        .Columns(24).Visible = False
                    Case 2
                        .Columns(1).Width = 500
                        .Columns(1).HeaderText = "Supplier Name"
                        .Columns(2).Width = 450
                        .Columns(2).HeaderText = "Address"
                End Select

            ElseIf search = "Package Charge" Then
                .Columns(0).Width = 100
                .Columns(1).Width = 650
            ElseIf search = "HMO Claims" Then
                If afterload Then
                    .Columns("claimreceiptid").Visible = False
                    .Columns("HMO").Width = 150
                    .Columns("HMO Claim No").Width = 130
                    .Columns("HMO Claim Date").Width = 130
                    .Columns("Total Amount Claim").Width = 150
                    .Columns("Document No.").Width = 120
                    .Columns("Prepared by").Width = 100
                    .Columns("Prepared Date").Width = 110
                    .Columns("Posted by").Width = 100
                    .Columns("Posted Date").Width = 110
                End If

            ElseIf search = "tsGuarantor" Or search = "tsBalanceForwarded" Then
                If afterload Then
                    .Columns(0).Visible = False
                    .Columns(1).Width = 100
                    .Columns(2).Width = 100
                    .Columns(3).Width = 220
                    .Columns(4).Width = 140
                    .Columns(5).Width = 140
                    .Columns(6).Width = 110

                    .Columns(7).Width = 100
                    .Columns(8).Visible = False

                    .Columns(9).Width = 100
                    .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns(9).DefaultCellStyle.Format = "#,##0.00"
                End If

            ElseIf search = "frmGuarantor_balance_Forwarded" Then
                .Columns(0).Visible = False
                .Columns(1).Width = 100
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(1).DefaultCellStyle.Format = "##00-00-00"
                .Columns(2).Width = 500
                .Columns(3).Width = 150
                .Columns(4).Width = 150
                .Columns(5).Width = 110
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).DefaultCellStyle.Format = "#,##0.00"
            ElseIf search = "guarantor" Or search = "forwarded" Then

                .Columns(0).Visible = False
                .Columns(1).Width = 110
                .Columns(2).Width = 900
                Select Case search
                    Case "guarantor"
                        .Columns(2).HeaderText = "Guarantor Name"
                    Case "forwarded"
                        .Columns(2).HeaderText = "Employee Name"
                End Select


            ElseIf search = "Patient" Or search = "DeathCertificate" Or search = "BirthCertificate" Then
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(1).HeaderText = ""
                'DirectCast(.Columns(1), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
                .Columns(2).Width = 100
                .Columns(2).HeaderText = "Hospital No"
                .Columns(3).Visible = False
                .Columns(4).Width = 240
                .Columns(4).HeaderText = "Patient Name"
                .Columns(5).Width = 230
                .Columns(5).HeaderText = "Address"
                .Columns(6).Width = 100
                .Columns(6).HeaderText = "Birthdate"
                .Columns(7).Width = 80
                .Columns(7).HeaderText = "Gender"
                .Columns(8).Width = 60
                .Columns(8).HeaderText = "Age"
                .Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(9).HeaderText = "Birth Place"
                '.Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                .Columns(14).Visible = False
                .Columns(15).Visible = False
                .Columns(16).Visible = False
                .Columns(17).Visible = False
                .Columns(18).Visible = False
                .Columns(19).Visible = False
                .Columns(20).Visible = False
                .Columns(21).Visible = False
                .Columns(22).Visible = False
                .Columns(23).Visible = False
                .Columns(24).Visible = False
            ElseIf search = "Patient From Other Clinic" Then
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(1).HeaderText = ""
                'DirectCast(.Columns(1), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
                .Columns(2).Width = 100
                .Columns(2).HeaderText = "Hospital No"
                .Columns(3).Visible = False
                .Columns(4).Width = 240
                .Columns(4).HeaderText = "Patient Name"
                .Columns(5).Width = 230
                .Columns(5).HeaderText = "Address"
                .Columns(6).Width = 90
                .Columns(6).HeaderText = "Birthdate"
                .Columns(7).Width = 60
                .Columns(7).HeaderText = "Gender"
                .Columns(8).Width = 40
                .Columns(8).HeaderText = "Age"
                .Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(9).HeaderText = "Birth Place"
                '.Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                .Columns(14).Visible = False
                .Columns(15).Visible = False
                .Columns(16).Visible = False
                .Columns(17).Visible = False
                .Columns(18).Visible = False
                .Columns(19).Visible = False
                .Columns(20).Visible = False
                .Columns(21).Visible = False
                .Columns(22).Visible = False
                .Columns(23).Visible = False
                .Columns(24).Visible = False
                .Columns(25).Width = 100
                .Columns(25).HeaderText = "Clinic"
            ElseIf search = "Physician" Or search = "DRRefund" Then
                .Columns(0).Visible = False 'employeeid
                .Columns(1).Visible = False
                '.Columns(1).HeaderText = ""
                '.Columns(1).Width = 40
                'DirectCast(.Columns(1), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
                .Columns(2).Width = 100
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(4).Width = 100
                .Columns(5).Width = 140
                .Columns(6).Width = 140
                .Columns(6).HeaderText = "Specialization"
                .Columns(7).Width = 90
                .Columns(7).HeaderText = "Birthdate"
                .Columns(8).Width = 100
                .Columns(8).HeaderText = "Contact"
                .Columns(9).Width = 100
                .Columns(9).HeaderText = "Daily Visit Rate"
                .Columns(10).Visible = False
            ElseIf search = "PhilHealthMembers" Then
                .Columns(0).Width = 110
                .Columns(0).HeaderText = "PhilHealth No."
                .Columns(1).Width = 280
                .Columns(1).HeaderText = "PhilHealth Member"
                .Columns(2).Width = 150
                .Columns(2).HeaderText = "Membership Category"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(3).HeaderText = "Address"
                .Columns(4).Width = 100
                .Columns(4).HeaderText = "Mobile No."
                .Columns(5).Width = 100
                .Columns(5).HeaderText = "Landline No."
            ElseIf search = "Patient PHIC Member" Then
                .Columns(0).Visible = False  'pat ID
                .Columns(1).Width = 140
                .Columns(1).HeaderText = "PhilHealth No."
                .Columns(2).Width = 250
                .Columns(2).HeaderText = "PhilHealth Member"
                .Columns(3).Width = 200
                .Columns(3).HeaderText = "E-mail Address"
                .Columns(4).Width = 300
                .Columns(4).HeaderText = "Address"
                .Columns(5).Width = 130
                .Columns(5).HeaderText = "Date Birth"
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                .Columns(14).Visible = False
                .Columns(15).Visible = False
                .Columns(16).Visible = False
            ElseIf search = "Admissions" Then
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).Width = 100
                .Columns(2).HeaderText = "Hospital No"
                .Columns(3).HeaderText = "Patient Name"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(4).HeaderText = "Admitting Physician"
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(5).HeaderText = "Admission Date"
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(6).Visible = False
            ElseIf search = "ICD10Diagnosis" Then
                .Columns(0).Width = 154
                .Columns(0).HeaderText = "ICD10Code"
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(1).HeaderText = "Diagnosis Description"
                .Columns(2).Visible = False
                .Columns(3).Visible = False
                .Columns(4).Visible = False
            ElseIf search = "Procedures" Then
                .Columns(0).Width = 154
                .Columns(0).HeaderText = "Procedure Code"
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(1).HeaderText = "Procedure Description"
                .Columns(2).Width = 100
                .Columns(2).HeaderText = "RVU"
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(3).Width = 160
                .Columns(3).HeaderText = "Category"
            ElseIf search = "Procedure Categories" Then
                .Columns(0).Width = 154
                .Columns(0).HeaderText = "Category Code"
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(1).HeaderText = "Category Description"
                .Columns(2).Width = 100
                .Columns(2).HeaderText = "Is Major"
            ElseIf search = "PO" Then
                .Columns(0).Width = 80
                .Columns(0).HeaderText = "PO No"
                .Columns(1).Width = 150
                .Columns(1).HeaderText = "Office Description"
                .Columns(2).Width = 150
                .Columns(2).HeaderText = "Supplier"
                .Columns(3).Width = 120
                .Columns(3).HeaderText = "PO Date"
                .Columns(4).Width = 200
                .Columns(4).HeaderText = "Approved By"
                .Columns(5).Width = 120
                .Columns(5).HeaderText = "Date Approved"
                .Columns(6).Width = 170
                .Columns(6).HeaderText = "Remarks"
            ElseIf search = "CashReceipt" Or search = "SubCreditNote" Then
                'If afterload Then
                .Columns(0).Visible = False
                .Columns("ptno").Width = 100
                .Columns("Hospital No").DefaultCellStyle.Format = "##-##-#0"
                .Columns("Patient").Width = 356
                .Columns("Patient").HeaderText = "Patient Name"
                .Columns("Admitted").Width = 200
                .Columns("Admission Type").Width = 130
                .Columns("Status").Width = 124
                .Columns("Status").Visible = True
                Select Case Me.cmbFilterby.SelectedValue
                    Case 1, 4
                        .Columns("ptno").HeaderText = "Charge No."
                        .Columns("Hospital No").HeaderText = "Trans No."
                        .Columns("Admission Type").HeaderText = "Trans Type"
                        .Columns("Status").Visible = False
                        .Columns("Admission Type").Width = 254
                        .Columns("Admitted").HeaderText = "Date Prepared"
                    Case Else
                        .Columns("Admitted").HeaderText = "Date Admitted"
                        .Columns("Admission Type").HeaderText = "Admission Type"
                        .Columns("Status").HeaderText = "Admission Status"
                        .Columns("ptno").HeaderText = "Patient No."
                        .Columns("Hospital No").HeaderText = "Hospital No."
                End Select
                .Columns("Discharged").Visible = False
                .Columns("patientid").Visible = False
                .Columns("transtype").Visible = False
                .Columns("ordered").Visible = False
                'End If
            ElseIf search = "CashTransaction" Or search = "Charges" Then
                .Columns(0).Visible = False

                .Columns("ptno").Width = 80
                .Columns("ptno").HeaderText = "Patient No."

                .Columns("ptno").Width = 100
                .Columns("Hospital No").HeaderText = "Hospital No."
                .Columns("Hospital No").DefaultCellStyle.Format = "##-##-#0"



                .Columns("Patient").Width = 356
                .Columns("Patient").HeaderText = "Patient Name"


                .Columns("Admitted").Width = 200
                .Columns("Admitted").HeaderText = "Date Admitted"

                .Columns("Admission Type").Width = 130
                .Columns("Admission Type").HeaderText = "Admission Type"

                .Columns("Status").Width = 124
                .Columns("Status").HeaderText = "Admission Status"


                .Columns("Discharged").Visible = False
                'CashTransaction
            ElseIf search = "HMO" Then
                .Columns("employeeid").Visible = 0
                .Columns("hmo name").Width = 230
                .Columns("hmo name").HeaderText = "HMO/Company"
                .Columns("contact person").Width = 150
                .Columns("contact person").HeaderText = "Contact Person"
                .Columns("address").Width = 200
                .Columns("address").HeaderText = "Address"
                .Columns("contactno").Width = 120
                .Columns("contactno").HeaderText = "Contact No"
                .Columns("notes").Width = 330
                .Columns("notes").HeaderText = "Notes"
            ElseIf search = "ManageUsers" Then
                .Columns(0).Visible = False
                .Columns(1).Width = 80
                .Columns(2).Width = 150 'lastname
                .Columns(3).Width = 150 'firstname
                .Columns(4).Width = 100 'middlename
                .Columns(5).Visible = False 'officecode
                .Columns(6).Width = 150 'officedescription
                .Columns(7).Visible = False 'employeetype
                .Columns(8).Width = 150 'designation
                .Columns(9).Width = 150 'specialization
                .Columns(10).Visible = False 'proftype
                .Columns(11).Visible = False 'pan
                .Columns(12).Width = 250 'address
                .Columns(13).Width = 150 'email
                .Columns(14).Width = 150 'gender
                .Columns(15).Width = 150 'contactno
                .Columns(16).Visible = False 'pan
                .Columns(17).Visible = False 'address
                .Columns(18).Visible = False 'email
                .Columns(19).Visible = False 'gender
            ElseIf search = "Cases" Then
                .Columns("caseno").Visible = 0
                .Columns("casename").Width = 400
                .Columns("casename").HeaderText = "Description"
                .Columns("group").Width = 230
                .Columns("group").HeaderText = "Group"
                .Columns("icd10code").Width = 70
                .Columns("icd10code").HeaderText = "ICD10/RVS"
                .Columns("caserate").Width = 70
                .Columns("caserate").HeaderText = "Case Rate"
                .Columns("caserate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns("caserate").DefaultCellStyle.Format = "#,##0.00"
                .Columns("facilityfee").Width = 70
                .Columns("facilityfee").HeaderText = "HF"
                .Columns("facilityfee").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns("facilityfee").DefaultCellStyle.Format = "#,##0.00"
                .Columns("doctorsfee").Width = 70
                .Columns("doctorsfee").HeaderText = "PF"
                .Columns("doctorsfee").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns("doctorsfee").DefaultCellStyle.Format = "#,##0.00"
                .Columns("caseratetype").Width = 100
                .Columns("caseratetype").HeaderText = "Case Rate"
            ElseIf search = "Credit Memo2" Or search = "Credit Memo" Then
                .Columns(0).Visible = False

                .Columns(1).Width = 400
                .Columns(1).HeaderText = "Name"
                .Columns(2).Width = 400
                .Columns(2).HeaderText = "Address"
            ElseIf search = "CF1" Then
                .Columns(0).Visible = False
                .Columns("datecreated").HeaderText = "Date Created"
                '.Columns("datecreated").DefaultCellStyle.Format = vbShortDate
                .Columns("datecreated").Width = 80
                .Columns("philhealthno").HeaderText = "PHIC No."
                .Columns("philhealthno").Width = 100
                .Columns("phicmember").HeaderText = "PHIC Member"
                .Columns("phicmember").Width = 205
                .Columns("patient").HeaderText = "Patient"
                .Columns("patient").Width = 200
                .Columns("dateadmitted").HeaderText = "Admitted"
                '.Columns("dateadmitted").DefaultCellStyle.Format = vbShortDate
                .Columns("dateadmitted").Width = 80
                .Columns("datedischarged").HeaderText = "Discharged"
                '.Columns("datedischarged").DefaultCellStyle.Format = vbShortDate
                .Columns("datedischarged").Width = 120
                .Columns("hospitalcharges").HeaderText = "Hospital Charges"
                .Columns("hospitalcharges").Width = 120
                .Columns("hospitalcharges").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns("hospitalcharges").DefaultCellStyle.Format = "#,##0.00"
                .Columns("pfcharges").HeaderText = "Prof Fee"
                .Columns("pfcharges").Width = 120
                .Columns("pfcharges").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns("pfcharges").DefaultCellStyle.Format = "#,##0.00"
                .Columns("admissionid").Visible = False
            ElseIf search = "EmployeeCharge" Then
                .Columns(0).Visible = False
                .Columns(1).Width = 150
                .Columns(2).Width = 100 'lastname
                .Columns(3).Width = 100 'firstname
                .Columns(4).Width = 100 'middlename
                .Columns(5).Width = 350 'address
                .Columns(6).Width = 200 'contactno
                .Columns(7).Visible = False 'employeetype

                .Columns(8).Visible = False 'proftype
                .Columns(9).Visible = False 'proftype
                .Columns(11).Visible = False 'proftype
                .Columns(10).Visible = False 'proftype
                .Columns(12).Visible = False 'pan
                .Columns(13).Visible = False 'pan
                .Columns(14).Visible = False 'pan

                '.Columns(15).Width = 150 'contactno
                .Columns(15).Visible = False 'pan
                .Columns(16).Visible = False 'pan
                .Columns(17).Visible = False 'address
                .Columns(18).Visible = False 'email
                .Columns(19).Visible = False 'gender

                .Columns(20).Visible = False 'gender
                .Columns(21).Visible = False 'gender 
            ElseIf search = "ReligiousGroup" Then
                .Columns(0).Visible = False
                .Columns(1).Width = 300
                .Columns(2).Width = 150 'contactperson
                .Columns(3).Width = 150 'address
                .Columns(4).Width = 150 'contactno
                .Columns(5).Width = 250 'notes 
            ElseIf search = "Ancillary" Then
                .Columns(0).Width = 80
                .Columns(0).HeaderText = "Request No"
                .Columns(1).Width = 80
                .Columns(1).HeaderText = "PTNo"
                .Columns(2).Width = 80
                .Columns(2).HeaderText = "Hospital No"
                .Columns(3).Width = 250
                .Columns(3).HeaderText = "Patient Name"
                .Columns(4).Width = 150
                .Columns(4).HeaderText = "Requesting Department"
                .Columns(5).Width = 140
                .Columns(5).HeaderText = "Requisition Status"
                .Columns(6).Width = 140
                .Columns(6).HeaderText = "Requested By"
                .Columns(7).Width = 140
                .Columns(7).HeaderText = "Date Requested"
                .Columns(8).Width = 140
                .Columns(8).HeaderText = "Posted By" 'Date Posted
                .Columns(9).Width = 140
                .Columns(9).HeaderText = "Date Posted"
                .Columns(10).Visible = False 'Admission ID
            ElseIf search = "Doctors" Then
                .Columns(0).Visible = False 'patientid
                .Columns(0).HeaderText = "Doctor ID"
                .Columns(1).HeaderText = ""
                .Columns(1).Width = 40
                DirectCast(.Columns(1), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
                .Columns(2).Visible = False
                .Columns(3).Width = 310
                .Columns(3).HeaderText = "Doctor Name"
                .Columns(4).Width = 100
                .Columns(4).HeaderText = "Gender"
                .Columns(5).Width = 100
                .Columns(5).HeaderText = "Profession"
                .Columns(6).Width = 100
                .Columns(6).HeaderText = "Specialization"
                .Columns(7).Width = 80
                .Columns(7).HeaderText = "Birthdate"
                .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(8).HeaderText = "Contact No."
                .Columns(9).Visible = False
                .Columns(10).Visible = False
            ElseIf search = "Pathologist" Or search = "Medical Technologist" Then
                .Columns(0).Visible = False 'patientid
                .Columns(0).HeaderText = "Employee ID"
                .Columns(1).HeaderText = ""
                .Columns(1).Width = 40
                DirectCast(.Columns(1), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
                .Columns(2).Visible = False
                .Columns(3).Width = 310
                .Columns(3).HeaderText = "Employee Name"
                .Columns(4).Width = 100
                .Columns(4).HeaderText = "Gender"
                .Columns(5).Width = 100
                .Columns(5).HeaderText = "Profession"
                .Columns(6).Visible = False
                .Columns(7).Width = 80
                .Columns(7).HeaderText = "Birthdate"
                .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(8).HeaderText = "Contact No."
                .Columns(9).Visible = False
                .Columns(10).Visible = False
            ElseIf search = "Generic Name" Then
                .Columns(0).Visible = False 'unitcode
                .Columns(0).HeaderText = "genericid"
                .Columns(1).HeaderText = "Generic Code"
                .Columns(1).Width = 310
                .Columns(2).HeaderText = "Generic Name"
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(3).Visible = False
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
            ElseIf search = "Suppliers" Then
                .Columns(0).HeaderText = "Supplier No"
                .Columns(0).Width = 100
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).HeaderText = "Supplier Name"
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).HeaderText = "Address"
                .Columns(2).Width = 150
                .Columns(3).Visible = False
                .Columns(4).HeaderText = "Telephone 1"
                .Columns(4).Width = 150
                .Columns(5).HeaderText = "Telephone 2"
                .Columns(5).Width = 150
                .Columns(6).Visible = False
                .Columns(7).HeaderText = "TIN #"
                .Columns(7).Width = 160
            ElseIf search = "Employees" Then
                .Columns(0).Visible = False 'employeeid
                '.Columns(1).HeaderText = ""
                '.Columns(1).Width = 40
                'DirectCast(.Columns(1), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
                .Columns(1).Width = 70
                .Columns(2).Width = 100
                .Columns(3).Width = 100
                .Columns(4).Width = 100
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(6).Width = 100
                .Columns(7).Width = 100
                .Columns(8).Visible = False
                .Columns(9).Width = 80
                .Columns(10).Width = 80
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                .Columns(14).Visible = False
                .Columns(15).Visible = False
                .Columns(16).Visible = False
                .Columns(17).Visible = False
                .Columns(18).Visible = False
                .Columns(19).Visible = False
                .Columns(20).Visible = False
                .Columns(21).Visible = False
            ElseIf search = "Tests" Then
                .Columns(0).Visible = False
                .Columns(1).HeaderText = "Test Code"
                .Columns(1).Width = 80
                .Columns(2).Width = 300
                .Columns(2).HeaderText = "Description"
                .Columns(3).Width = 320
                .Columns(3).HeaderText = "Type"
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(4).HeaderText = "Category"
            ElseIf search = "Balances" Then
                .ReadOnly = False
                .Columns(0).Width = 30
                .Columns(0).HeaderText = ""
                .Columns(0).ReadOnly = False
                .Columns(1).Width = 100
                .Columns(1).HeaderText = "Charge ID"
                .Columns(2).Width = 100
                .Columns(2).HeaderText = "Date"
                .Columns(3).Width = 200
                .Columns(3).HeaderText = "Patient"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(4).Width = 150
                .Columns(4).HeaderText = "Balance"
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(4).DefaultCellStyle.Format = "F2"
            ElseIf search = "Barangays" Then
                .ReadOnly = False
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "Name"
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(3).Width = 150
                .Columns(3).HeaderText = "Municipality/City"
                .Columns(4).Width = 150
                .Columns(4).HeaderText = "Province"
                .Columns(5).Width = 150
                .Columns(5).HeaderText = "Region"
                .Columns(6).Width = 120
                .Columns(6).HeaderText = "Created By"
                .Columns(7).Width = 100
                .Columns(7).HeaderText = "Date Created"
                .Columns(8).Visible = False
                .Columns(9).Visible = False
                .Columns(10).Width = 80
                .Columns(10).HeaderText = "Is Active"
            End If
        End With
    End Sub
    Private Sub txtSearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        If e.KeyCode = Keys.Enter Then
            afterload = True
            Call DisplayList(mModuleName)
        End If
    End Sub
    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        'istype = True
        'If mModuleName <> "Patient" Then
        '    If mModuleName <> "BirthCertificate" Then
        '        If mModuleName <> "DeathCertificate" Then
        '            Call DisplayList(mModuleName)
        '        End If
        '    End If
        'End If
    End Sub
    Private Sub picSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSearch.Click, Button1.Click
        istype = True
        afterload = True
        If mModuleName <> "Patient" Then
            If mModuleName <> "BirthCertificate" Then
                If mModuleName <> "DeathCertificate" Then
                    Call DisplayList(mModuleName)
                End If
            End If
        End If
    End Sub
    Private Sub tsClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsClose.Click
        issave = False
        Close()
    End Sub
    Private Sub dgGeneric_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgGeneric.CurrentCellDirtyStateChanged
        If mModuleName = "Items" Then
            Dim dgCheckBox As DataGridViewCheckBoxCell
            Try
                If dgGeneric.CurrentCellAddress.X = 0 Then
                    dgCheckBox = dgGeneric.CurrentRow.Cells(0)

                    If (dgGeneric.IsCurrentCellDirty) Then
                        dgGeneric.CommitEdit(DataGridViewDataErrorContexts.Commit)
                        If dgCheckBox.Value = False Then
                            For ctr = 0 To dgGeneric.Rows.Count - 1
                                If ctr = dgGeneric.CurrentRow.Index And dgGeneric.Rows(ctr).Cells("chk").Value = False Then
                                    dgGeneric.Rows.Remove(dgGeneric.Rows(ctr))
                                End If
                            Next
                        End If
                    End If

                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub dgGenerics_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgGeneric.CellContentClick
        If e.ColumnIndex = 0 And mModuleName = "Items" And oldval = True Then
            If dgGeneric.Item(0, dgGeneric.CurrentRow.Index).Value = False Then
                dgGeneric.Rows.Remove(dgGeneric.CurrentRow)
            End If
        End If
    End Sub
    Private Sub enabledFields(ByVal sw As Boolean)
        Me.tsClose.Enabled = sw
        Me.btnIgnoreCreateNew.Enabled = sw
        Me.btnSelRec.Enabled = sw
        Me.txtSearch.Enabled = sw
        Me.picSearch.Enabled = sw
        Me.prgrefresh.Visible = Not sw
        Me.lblLoading.Visible = Not sw

    End Sub
    'Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
    '    dtCharges = clsPayments.getAdmissionGuarantorRecord(7, txtSearch.Text)
    'End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.dgGeneric.DataSource = dtCharges

        Me.prgrefresh.Value = Me.prgrefresh.Maximum
        enabledFields(True)
        Me.txtSearch.Select()
        Call FormatGrid(mModuleName)
        Me.Timer1.Stop()
    End Sub
    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        prgrefresh.Value += 1
        Application.DoEvents()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.lblLoading.Text = "Retrieving record(s). Please wait" Then
            Me.lblLoading.Text = "Retrieving record(s). Please wait."
        ElseIf Me.lblLoading.Text = "Retrieving record(s). Please wait." Then
            Me.lblLoading.Text = "Retrieving record(s). Please wait.."
        ElseIf Me.lblLoading.Text = "Retrieving record(s). Please wait.." Then
            Me.lblLoading.Text = "Retrieving record(s). Please wait..."
        ElseIf Me.lblLoading.Text = "Retrieving record(s). Please wait..." Then
            Me.lblLoading.Text = "Retrieving record(s). Please wait"
        ElseIf Me.lblLoading.Text = "Retrieving record(s). Please wait..." Then
            Me.lblLoading.Text = "Retrieving record(s). Please wait"
        End If
    End Sub
    Private Sub cmbFilterby_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFilterby.SelectedIndexChanged
        Select Case mModuleName
            'Outgoing Payment (Payee)
            Case "Check Voucher Entry", "OtherCashierCollection"
                DisplayList(mModuleName)
        End Select
    End Sub

#End Region

#Region "Methods"
    Private Sub LoadImage()
        'Me.tsClose.Image = modGlobal.close_icon
        ''Me.btnSelRec.Image = modGlobal.select_record_icon
        'Me.btnIgnoreCreateNew.Image = modGlobal.load_item_icon
    End Sub
    Private Sub FilterBy()
        Me.cmbFilterby.Visible = False
        Me.lblFilterby.Visible = False
        With Me.cmbFilterby
            If mModuleName = "CashReceipt" Or mModuleName = "SubCreditNote" Then
                .Items.Add(New DictionaryEntry("Patient Name (Per Admission)", 0))
                .Items.Add(New DictionaryEntry("Patient Name (Per Charges)", 1))
                .Items.Add(New DictionaryEntry("Patient No. (Per Admission)", 2))
                .Items.Add(New DictionaryEntry("Hospital No. (Per Admission)", 3))
                .Items.Add(New DictionaryEntry("Charge No. (Per Charges)", 4))
                .Items.Add(New DictionaryEntry("Admissition Type (Per Admission)", 5))
                .DisplayMember = "Key"
                .ValueMember = "Value"
                .DataSource = .Items
                .SelectedIndex = 0
                .Visible = True
                Me.lblFilterby.Visible = True
            ElseIf mModuleName = "Check Voucher Entry" Then
                .Items.Add(New DictionaryEntry("Employees", 0))
                .Items.Add(New DictionaryEntry("Patients", 1))
                .Items.Add(New DictionaryEntry("Suppliers", 2))
                .DisplayMember = "Key"
                .ValueMember = "Value"
                .DataSource = .Items
                .SelectedIndex = 0
                .Visible = True
                Me.lblFilterby.Visible = True
            ElseIf mModuleName = "Doctors" Then
                .Items.Add("Active") 'Active(0)
                .Items.Add("Inactive") 'InActive(1)
                .SelectedIndex = 0
                .Visible = True
                Me.lblFilterby.Visible = True
            End If

        End With
    End Sub
    Private Function ComputeTotalAmount() As Double
        Dim i As Integer
        Dim payable As Double
        Do While i < dtCharges.Rows.Count
            If IsDBNull(dtCharges.Rows(i)("Excess")) = False Then
                payable = payable + Utility.EmptyToZero(dtCharges.Rows(i)("Excess"))
            End If
            i += 1
        Loop
        Return payable
    End Function
    Private Sub IgnoreCreateNew()
        If mModuleName = "Patient" Then
            'Dim fPatients As New frmPatient
            'fPatients.myCurrentFormStatus = frmPatient.enFormStatus.add
            'fPatients.ShowDialog()
            'issave = fPatients.isSave
            'If issave <> False Then
            '    mKey = fPatients.patientid
            '    Me.Close()
            'End If
            'fPatients.Close()

            'ElseIf mModuleName = "ICD10Diagnosis" Then
            '    Dim fEmployee As New frmICD10(frmICD10.enFormStatus.add)
            '    fEmployee.ShowDialog()
            '    issave = fEmployee.isSave
        End If
    End Sub
    Private Sub SelectedRecord()

        Try

            If mModuleName = "Patient" Or mModuleName = "Patient From Other Clinic" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                mvalue = Me.dgGeneric.SelectedRows(0).Cells(4).Value
                If mModuleName = "BirthCertificate" Or mModuleName = "DeathCertificate" Then
                    Isnewborn = Me.dgGeneric.SelectedRows(0).Cells(21).Value
                End If
            ElseIf mModuleName = "Items" Then
                Dim x As Integer
                dt.Columns.Clear()
                Dim row As DataRow
                dt.Columns.Add("ItemCode")         '0
                dt.Columns.Add("ItemDescription")  '1
                dt.Columns.Add("unitcost")  '2
                'dgGeneric.Item(0, dgGeneric.CurrentRow.Index).Value = True
                Do While x < Me.dgGeneric.RowCount
                    If dgGeneric.Item(0, x).Value = True Then
                        row = dt.NewRow()
                        row(0) = Me.dgGeneric.Item(1, x).Value
                        row(1) = Me.dgGeneric.Item(2, x).Value
                        row(2) = Me.dgGeneric.Item(6, x).Value 'charge price
                        dt.Rows.Add(row)
                    End If
                    x = x + 1
                Loop
                issave = False
                If x > 0 Then
                    issave = True
                End If
                x = 0
                'ElseIf mModuleName = "BirthCertificate" Or mModuleName = "DeathCertificate" Then
                '    mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                'ElseIf mModuleName = "Birth Certificate" Or mModuleName = "Medical Certificate" Then 'used for printing
                '    mLastName = Me.dgGeneric.SelectedRows(0).Cells(3).Value
                '    mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
            ElseIf mModuleName = "Balances" Then
                Dim x As Integer = 0
                dt.Columns.Clear()
                Dim row As DataRow
                dt.Columns.Add("chargeid")
                Do While x < Me.dgGeneric.RowCount
                    If dgGeneric.Item(0, x).Value = True Then
                        row = dt.NewRow()
                        row(0) = Me.dgGeneric.Item(1, x).Value
                        dt.Rows.Add(row)
                    End If
                    x = x + 1
                Loop
                issave = False
                If x > 0 Then
                    issave = True
                End If
                x = 0
            ElseIf mModuleName = "Physician" Or mModuleName = "DRRefund" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                mDocFee = Utility.EmptyToZero(Me.dgGeneric.SelectedRows(0).Cells(9).Value)
                If mModuleName = "DRRefund" Then
                    mLastName = "DOCTOR'S PF REFUND ( " & Me.dgGeneric.SelectedRows(0).Cells(3).Value & ")"
                End If
            ElseIf mModuleName = "Pathologist" Or mModuleName = "Medical Technologist" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                mvalue = Me.dgGeneric.SelectedRows(0).Cells(3).Value
            ElseIf mModuleName = "Employees" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                mvalue = Me.dgGeneric.SelectedRows(0).Cells(2).Value & ", " & Me.dgGeneric.SelectedRows(0).Cells(3).Value & " " & Me.dgGeneric.SelectedRows(0).Cells(4).Value
            ElseIf mModuleName = "Room" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                mRoomRate = Me.dgGeneric.Item(5, dgGeneric.CurrentRow.Index).Value
            ElseIf mModuleName = "PhilHealthMembers" Or mModuleName = "Patient PHIC Member" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
            ElseIf mModuleName = "CF1" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(9).Value
                mLastName = Me.dgGeneric.SelectedRows(0).Cells(4).Value
            ElseIf mModuleName = "AdmissionRoom" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
            ElseIf mModuleName = "Procedures" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                mvalue = Me.dgGeneric.SelectedRows(0).Cells(1).Value
            ElseIf mModuleName = "Procedure Categories" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                mvalue = Me.dgGeneric.SelectedRows(0).Cells(1).Value
            ElseIf mModuleName = "Diagnosis" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                mDiagnosisDesc = Me.dgGeneric.Item(1, dgGeneric.CurrentRow.Index).Value

            ElseIf mModuleName = "Admissions" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(1).Value
                Me.mvalue = Me.dgGeneric.SelectedRows(0).Cells(3).Value & " - " & CDate(Me.dgGeneric.SelectedRows(0).Cells(5).Value).ToString("MM/dd/yyyy")
            ElseIf mModuleName = "ICD10Diagnosis" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                mICD10Description = Me.dgGeneric.Item(1, dgGeneric.CurrentRow.Index).Value
            ElseIf mModuleName = "PO" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                'ElseIf mModuleName = "CashReceipt" Or mModuleName = "SubCreditNote" Then
                '    AdmissionID = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                '    mKey = Me.dgGeneric.SelectedRows(0).Cells("transtype").Value
                '    dtCharges = clsPayments.getPayments(1, AdmissionID)
            ElseIf mModuleName = "CashTransaction" Or mModuleName = "Charges" Then
                AdmissionID = Me.dgGeneric.SelectedRows(0).Cells(0).Value
            ElseIf mModuleName = "HMO" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                mLastName = Me.dgGeneric.SelectedRows(0).Cells(1).Value
            ElseIf mModuleName = "ManageUsers" Or mModuleName = "EmployeeCharge" Or mModuleName = "ReligiousGroup" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
            ElseIf mModuleName = "Credit Memo2" Or mModuleName = "Credit Memo" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
            ElseIf mModuleName = "guarantor" Or mModuleName = "forwarded" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                mModuleName = Me.dgGeneric.SelectedRows(0).Cells(2).Value
            ElseIf mModuleName = "frmGuarantor_balance_Forwarded" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
            ElseIf mModuleName = "tsGuarantor" Or mModuleName = "tsBalanceForwarded" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
            ElseIf mModuleName = "HMO Claims" Then
                AdmissionID = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                mKey = mModuleName
            ElseIf mModuleName = "Package Charge" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                mModuleName = Me.dgGeneric.SelectedRows(0).Cells(1).Value
            ElseIf mModuleName = "Generic Name" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                mModuleName = Me.dgGeneric.SelectedRows(0).Cells(2).Value
            ElseIf mModuleName = "Suppliers" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                mModuleName = Me.dgGeneric.SelectedRows(0).Cells(1).Value
            ElseIf mModuleName = "Tests" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
            ElseIf mModuleName = "Barangays" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
            End If
            If Me.isPatientSearch = True Then
                If mModuleName <> "BirthCertificate" And mModuleName <> "DeathCertificate" Then
                    'If newAdmission.isExist(mKey) = True Then
                    '    MsgBox("The patient is currently active/admitted.", vbInformation + MessageBoxButtons.OK, modGlobal.msgboxTitle)
                    '    mKey = 0
                    '    Exit Sub
                    'Else

                    '    Dim dtPatientBalance As DataTable = clsBilling.getPatientBalance(mKey)

                    '    If dtPatientBalance.Rows.Count > 0 Then

                    '        Dim fPatient As New frmPatient
                    '        fPatient.hasBalance = True
                    '        fPatient.balanceAmount = dtPatientBalance.Rows(0).Item("excess")
                    '        fPatient.lblDateAdmitted.Text = "Last Registered:" & dtPatientBalance.Rows(0).Item("dateadmitted")
                    '        fPatient.myCurrentFormStatus = frmPatient.enFormStatus.browsing
                    '        fPatient.patientid = mKey
                    '        fPatient.ShowDialog()
                    '        'fPatient.Dispose()
                    '        fPatient = Nothing
                    '        Me.Close()
                    '        Exit Sub

                    '    End If
                    'End If
                End If
            End If
            'If mModuleName = "BirthCertificate" Then
            '    If newBirthCert.IsEncoded(mKey, 1) = True Then
            '        MsgBox("This record already exists in the database.", vbInformation + MessageBoxButtons.OK, modGlobal.msgboxTitle)
            '        Exit Sub
            '    Else
            '        Dim dtBirthCert As DataTable = clsCertification.getisNewBorn(mKey)
            '        If Utility.NullToZero(dtBirthCert.Rows(0).Item("isnewborn")) = False Then
            '            MsgBox("The transaction cannot be processed due to patient is not new born baby.", vbInformation + MsgBoxStyle.OkOnly, modGlobal.msgboxTitle)
            '            Exit Sub
            '            Call Dispose()
            '        End If
            '    End If
            'ElseIf mModuleName = "DeathCertificate" Then
            'Dim dtPatAdmissionInfo As DataTable = clsCertification.getPatLastAdmissionID(mKey)
            'AdmissionID = dtPatAdmissionInfo.Rows(0).Item("admissionid")
            'vdischargestatus = Trim(Utility.NullToEmptyString(dtPatAdmissionInfo.Rows(0).Item("dischargestatus")))
            'If newBirthCert.IsEncoded(mKey, 2) = True Then
            '    MsgBox("This record already exists in the database.", vbInformation + MessageBoxButtons.OK, modGlobal.msgboxTitle)
            '    Exit Sub
            'ElseIf vdischargestatus <> "D" Then
            '    MsgBox("The transaction cannot be processed due to patient is not dead.", vbInformation + MessageBoxButtons.OK, modGlobal.msgboxTitle)
            '    Exit Sub
            'End If
            If mModuleName = "Cases" Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                mICD10Code = Me.dgGeneric.SelectedRows(0).Cells(3).Value
                mICD10Description = Me.dgGeneric.SelectedRows(0).Cells(1).Value
                'ElseIf mModuleName = "Ancillary" Then
                '    mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value 'patientrequestno
                '    AdmissionID = Me.dgGeneric.SelectedRows(0).Cells(10).Value 'admissionid
                'ElseIf mModuleName = "Check Voucher Entry" Then
                '    mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                '    mModuleName = Me.cmbFilterby.SelectedValue
                'ElseIf mModuleName = "DietaryAdmissionPatient" Then
                '    mKey = Me.dgGeneric.SelectedRows(0).Cells("id").Value
                '    mModuleName = Me.dgGeneric.SelectedRows(0).Cells("Patient Name").Value & " | Patient No. = " & Me.dgGeneric.SelectedRows(0).Cells("Patient No.").Value
                'ElseIf mModuleName = "OtherCashierCollection" Then
                '    mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                '    mLastName = Me.dgGeneric.SelectedRows(0).Cells(1).Value
                '    mFirstName = Me.dgGeneric.SelectedRows(0).Cells(2).Value
                'ElseIf mModuleName = "OtherCashierCollectionItems" Then
                '    mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                '    mModuleName = Me.dgGeneric.SelectedRows(0).Cells(1).Value
            End If
            issave = True
            Me.Close()
        Catch
            MsgBox("No record selected. Please select from the list or search again.", vbInformation, modGlobal.msgboxTitle)
        End Try

    End Sub
    Private Function verifyitemselection(ByVal itemcode As String) As Integer
        'check if lotno exists from database
        Dim ctr As Integer
        Dim exist As Boolean = False
        With dgGeneric
            Do While ctr < dgGeneric.RowCount
                If UCase(.Item(2, ctr).Value) Like "*" & UCase(itemcode) & "*" Or UCase(.Item(1, ctr).Value) = UCase(itemcode) Then
                    exist = True
                    Exit Do
                End If
                ctr = ctr + 1
            Loop
        End With

        Return exist
    End Function
#End Region
End Class