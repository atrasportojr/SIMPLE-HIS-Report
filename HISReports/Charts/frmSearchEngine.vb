Public Class frmSearchEngine
#Region "Variables"
    Public myCurrentFormStatus As enFormStatus
    Public mModuleName As ModuleName
    Public mKey As String
    Public mId As String
    Public mvalue As String
    Public mrow As DataGridViewRow
    'used in frmadmissions
    Public isPatientSearch As Boolean
    Public vIsnewborn As Boolean
    Public mAdmissionType As String = "IPD"
    Public mDocFee As Double
    Public mRoomRate As Double
    Public caseratetype As Integer = 1
    Public isActivePatient As Boolean = True
    Public mICD10Description As String
    Public Isnewborn As Boolean
    Public isexpired As Boolean
    ''end
    Dim vphilhealthno As String
    Public issave, afterload As Boolean
    Public isAdmissionSearch As Boolean
    Public itemcode, officecode As String
    Enum enFormStatus
        browsing = 0
        add = 1
        edit = 2
        view = 3
    End Enum

    Enum ModuleName
        Patient
        Admission
        Physician
        ICD10Diagnosis
        Procedures
        Items
        NonHospitalItems
        PhilHealthPackages1
        PhilHealthPackages2
        TransmittalUnmapped
        PhilHealthMembers
        Hospital
        ZBenefit
        Employees
        Nurses
        HospitalSuppliers
        NonHospitalSuppliers
        GenericName
        Rooms
        PackageCharges
        PhilhealthMedicines
        UnmappedItems
        Offices
        LotNo
        ItemCategory
    End Enum



#End Region


#Region "Form Events"

    Private Sub frmSearchEngine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        FilterBy()
        Call LoadImage()

        Call DisplayList(mModuleName)
        Application.DoEvents()
        Me.txtSearch.Focus()
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
    Public Sub DisplayList(ByVal search As ModuleName)
        Me.dgGeneric.DataSource = Nothing
        Me.dgGeneric.RowTemplate.Height = 30
        'Me.dgGeneric.DefaultCellStyle.SelectionBackColor = modGlobal.default_color
        If search = ModuleName.Patient Then
            Dim patient As New clsAdmissiondetails
            With patient
                .isnewborn = Isnewborn
                .isexpired = isexpired
                Me.dgGeneric.DataSource = .PatientInfor(1, Me.txtSearch.Text, Me.isActivePatient)
            End With
        ElseIf search = ModuleName.Admission Then
            Me.dgGeneric.DataSource = clsEclaims.getInfo(3, Me.txtSearch.Text)

        ElseIf search = ModuleName.Physician Then
            Me.dgGeneric.DataSource = clsAdmissiondetails.genericcls(2, Me.txtSearch.Text)

        ElseIf search = ModuleName.Rooms Then
            Me.dgGeneric.DataSource = clsAdmissiondetails.getRooms(Me.txtSearch.Text)

        ElseIf search = ModuleName.ICD10Diagnosis Then
            Me.dgGeneric.DataSource = clsEclaims.getInfo(8, Me.txtSearch.Text)

        ElseIf search = ModuleName.Procedures Then
            Me.dgGeneric.DataSource = clsEclaims.getInfo(9, Me.txtSearch.Text)

        ElseIf search = ModuleName.Items Or search = ModuleName.NonHospitalItems Then
            Me.dgGeneric.DataSource = clsitems.getitem(0, txtSearch.Text, Me.cmbFilterby.SelectedIndex = 0, search = ModuleName.Items)

        ElseIf search = ModuleName.PhilHealthPackages1 Then
            Me.dgGeneric.DataSource = clsEclaims.getInfo(16, Me.txtSearch.Text)

        ElseIf search = ModuleName.PhilHealthPackages2 Then
            Me.dgGeneric.DataSource = clsEclaims.getInfo(39, Me.txtSearch.Text)

        ElseIf search = ModuleName.TransmittalUnmapped Then
            Me.dgGeneric.DataSource = clsEclaims.getInfo(22, Me.txtSearch.Text)

        ElseIf search = ModuleName.PhilHealthMembers Then
            Me.dgGeneric.DataSource = clsAdmissiondetails.GetPhilHealthMembers(Me.txtSearch.Text)

        ElseIf search = ModuleName.Hospital Then
            Me.dgGeneric.DataSource = clsHCI.getHCI(4, Me.txtSearch.Text)

        ElseIf search = ModuleName.ZBenefit Then
            Me.dgGeneric.DataSource = clsEclaims.getInfo(35, Me.txtSearch.Text)

        ElseIf search = ModuleName.Employees Then
            Me.dgGeneric.DataSource = clsEmployees.GetEmployeeInfo(0, Me.txtSearch.Text, 0, True)

        ElseIf search = ModuleName.Nurses Then
            Me.dgGeneric.DataSource = clsEmployees.GetEmployeeInfo(32, Me.txtSearch.Text, 0, True)

        ElseIf search = ModuleName.NonHospitalSuppliers Or search = ModuleName.HospitalSuppliers Then   'uncomment tonton 6/1/2022
            Me.dgGeneric.DataSource = clsitems.getSupplier(2, Me.txtSearch.Text, 1, search = ModuleName.HospitalSuppliers)

        ElseIf search = ModuleName.GenericName Then
            Me.dgGeneric.DataSource = clsitems.getitem(4, Me.txtSearch.Text, 1)
            'ElseIf search = ModuleName.PackageCharges Then
            '    Me.dgGeneric.DataSource = clsPackageItems.getPackage(0, Me.txtSearch.Text, "", True)
        ElseIf search = ModuleName.PhilhealthMedicines Then
            Me.dgGeneric.DataSource = clsEclaims.getInfo(53, Me.txtSearch.Text)
            'ElseIf search = ModuleName.UnmappedItems Then
            '    Me.dgGeneric.DataSource = clsitems.getitem(27, Me.txtSearch.Text)
        ElseIf search = ModuleName.Offices Then
            Me.dgGeneric.DataSource = clsHISReports.getOffices(0, Me.txtSearch.Text)
        ElseIf search = ModuleName.LotNo Then
            Me.dgGeneric.DataSource = clsHISReports.getLotNo(itemcode, officecode)
        ElseIf search = ModuleName.ItemCategory Then
            Me.dgGeneric.DataSource = clsHISReports.getItemCategory(txtSearch.Text)
        End If
        Me.lblRecordCount.Text = Me.dgGeneric.Rows.Count & " rows"
        Call FormatGrid(search)
        If Me.dgGeneric.RowCount > 0 Then
            Me.dgGeneric.Rows(0).Selected = True
            Me.chknotfound.Visible = False
        End If

        If Me.mModuleName = ModuleName.Patient Or Me.mModuleName = ModuleName.PhilHealthMembers Or Me.mModuleName = ModuleName.Physician Or
            Me.mModuleName = ModuleName.NonHospitalSuppliers Or Me.mModuleName = ModuleName.NonHospitalItems Or Me.mModuleName = ModuleName.GenericName Or
            Me.mModuleName = ModuleName.Items Or Me.mModuleName = ModuleName.HospitalSuppliers Or Me.mModuleName = ModuleName.UnmappedItems Then
            Me.btnIgnoreCreateNew.Visible = Me.dgGeneric.RowCount = 0
        End If
        If Me.mModuleName = ModuleName.PhilhealthMedicines Then
            Me.btnIgnoreCreateNew.Visible = False
            Me.chknotfound.Visible = Me.dgGeneric.RowCount = 0
        End If
    End Sub
    Private Sub frmSearchEngine_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter And dgGeneric.Focused Then
            SelectedRecord()
        ElseIf e.KeyCode = Keys.F3 Then
            Me.txtSearch.Select()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
            issave = False
            'Dispose()
        End If
    End Sub
    Public Sub FormatGrid(ByVal search As ModuleName)
        With dgGeneric
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True

            '========================'----used for printing certificates----'========================

            If search = ModuleName.Patient Then
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(1).HeaderText = ""
                'DirectCast(.Columns(1), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
                .Columns(2).Width = 100
                .Columns(2).HeaderText = "Hospital No"
                .Columns(3).Visible = False
                .Columns(4).Width = 240
                .Columns(4).HeaderText = "Patient Name"
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
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
                'ElseIf search = "Patient PHIC Member" Then
                '    .Columns(0).Visible = False  'pat ID
                '    .Columns(1).Width = 140
                '    .Columns(1).HeaderText = "PhilHealth No."
                '    .Columns(2).Width = 250
                '    .Columns(2).HeaderText = "PhilHealth Member"
                '    .Columns(3).Width = 200
                '    .Columns(3).HeaderText = "E-mail Address"
                '    .Columns(4).Width = 300
                '    .Columns(4).HeaderText = "Address"
                '    .Columns(5).Width = 130
                '    .Columns(5).HeaderText = "Date Birth"
                '    .Columns(6).Visible = False
                '    .Columns(7).Visible = False
                '    .Columns(8).Visible = False
                '    .Columns(9).Visible = False
                '    .Columns(10).Visible = False
                '    .Columns(11).Visible = False
                '    .Columns(12).Visible = False
                '    .Columns(13).Visible = False
                '    .Columns(14).Visible = False
                '    .Columns(15).Visible = False
                '    .Columns(16).Visible = False
            ElseIf search = ModuleName.Admission Then
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
            ElseIf search = ModuleName.Physician Then
                .Columns(0).Visible = False
                .Columns(1).Visible = True
                .Columns(1).HeaderText = ""
                .Columns(1).Width = 60
                DirectCast(.Columns(1), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
                .Columns(2).Width = 100
                .Columns(2).HeaderText = "PAN"
                .Columns(3).Width = 270
                .Columns(3).HeaderText = "Physician"
                .Columns(4).Width = 100
                .Columns(4).HeaderText = "Gender"
                .Columns(5).Width = 200
                .Columns(5).HeaderText = "Profession Type"
                .Columns(6).Width = 120
                .Columns(6).HeaderText = "Specialization"
                .Columns(7).Width = 120
                .Columns(7).HeaderText = "Birthdate"
                .Columns(8).Width = 100
                .Columns(8).HeaderText = "Contact No."
                .Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(9).HeaderText = "Rate"
                .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(9).DefaultCellStyle.Format = "#,##0.00"
                .Columns(10).Visible = False
            ElseIf search = ModuleName.Rooms Then
                .Columns(0).Width = 100
                .Columns(0).HeaderText = "Room ID"
                .Columns(1).Width = 120
                .Columns(1).HeaderText = "Room #"
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(3).Width = 100
                .Columns(3).HeaderText = "No. of Beds"
                .Columns(4).Width = 160
                .Columns(4).HeaderText = "Room Type"
                .Columns(5).HeaderText = "Charge"
                .Columns(5).DefaultCellStyle.Format = "F2"
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            ElseIf search = ModuleName.ICD10Diagnosis Then
                .Columns(0).Width = 154
                .Columns(0).HeaderText = "ICD10Code"
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(1).HeaderText = "Diagnosis Description"
                .Columns(2).Width = 160
                .Columns(2).HeaderText = "Classification"
                .Columns(3).Visible = False
                .Columns(4).Visible = False
            ElseIf search = ModuleName.Procedures Then
                .Columns(0).Width = 154
                .Columns(0).HeaderText = "RVS Code"
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(1).HeaderText = "Case Name"
                .Columns(2).Width = 160
                .Columns(2).HeaderText = "Category"
            ElseIf search = ModuleName.Items Or search = ModuleName.NonHospitalItems Then
                .Columns(0).Width = 100
                .Columns(0).HeaderText = "Item Code"
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(1).HeaderText = "Item Description"
                '.Columns(2).Width = 130
                '.Columns(2).HeaderText = "Generic"
                '.Columns(3).Width = 100
                '.Columns(3).HeaderText = "Category"
                '.Columns(4).Width = 130
                '.Columns(4).HeaderText = "Supplier"
                '.Columns(5).Width = 60
                '.Columns(5).HeaderText = "Unit"
                .Columns(2).Visible = False
                .Columns(3).Visible = False
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                .Columns(14).Visible = False
                '.Columns(12).Width = 70
                '.Columns(12).HeaderText = "Price 1"
                '.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                '.Columns(13).Width = 70
                '.Columns(13).HeaderText = "Price 2"
                '.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                '.Columns(14).Width = 70
                '.Columns(14).HeaderText = "Price 3"
                '.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
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
                .Columns(25).Visible = False
                .Columns(26).Visible = False
                '.Columns(26).Width = 54
                '.Columns(26).HeaderText = "Is Active"
                .Columns(27).Visible = False
                .Columns(28).Visible = False
                .Columns(29).Visible = False
                .Columns(30).Visible = False
                .Columns(31).Visible = False
            ElseIf search = ModuleName.PhilHealthPackages1 Or search = ModuleName.PhilHealthPackages2 Then
                .Columns(0).Width = 154
                .Columns(0).HeaderText = "Case No."
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(1).HeaderText = "Case Name"
                .Columns(2).Width = 100
                .Columns(2).HeaderText = "ICD Code"
                .Columns(3).Width = 154
                .Columns(3).HeaderText = "Case Rate"
                .Columns(4).Width = 154
                .Columns(4).HeaderText = "Facility Fee"
                .Columns(5).Width = 154
                .Columns(5).HeaderText = "Prof Fee"
                .Columns(6).Width = 154
                .Columns(6).HeaderText = "Case Rate Type"
                .Columns(7).Visible = False
                .Columns(8).Visible = False
            ElseIf search = ModuleName.TransmittalUnmapped Then
                .Columns(0).Visible = False
                .Columns(1).Width = 170
                .Columns(1).HeaderText = "Hospital Transmittal No."
                .Columns(2).Width = 170
                .Columns(2).HeaderText = "PHIC Transmittal No."
                .Columns(3).Width = 170
                .Columns(3).HeaderText = "Transmittal Date"
                .Columns(4).Width = 140
                .Columns(4).HeaderText = "Hospital Claim"
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).Width = 140
                .Columns(5).HeaderText = "Professional Claim"
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(6).Width = 130
                .Columns(6).HeaderText = "No. of Claims"
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(7).HeaderText = "Mapping Status"
                .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            ElseIf search = ModuleName.PhilHealthMembers Then
                .Columns(0).Width = 110
                .Columns(0).HeaderText = "PhilHealth No."
                .Columns(1).Width = 280
                .Columns(1).HeaderText = "PhilHealth Member"
                .Columns(2).Visible = False
                .Columns(2).HeaderText = "Membership Category"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(3).HeaderText = "Address"
                .Columns(4).Width = 100
                .Columns(4).HeaderText = "Mobile No."
                .Columns(5).Width = 100
                .Columns(5).HeaderText = "Landline No."
            ElseIf search = ModuleName.Hospital Then
                .Columns(0).Width = 110
                .Columns(0).HeaderText = "HCI ID"
                .Columns(1).Width = 180
                .Columns(1).HeaderText = "HCI Code"
                .Columns(2).Width = 280
                .Columns(2).HeaderText = "HCI Name"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(3).HeaderText = "Address"
            ElseIf search = ModuleName.ZBenefit Then
                .Columns(0).Width = 150
                .Columns(0).HeaderText = "Z-Benefit Code"
                .Columns(1).HeaderText = "Description"
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).HeaderText = "Tranche"
                .Columns(2).Width = 150
                .Columns(3).HeaderText = "Amount"
                .Columns(3).Width = 150
                .Columns(3).DefaultCellStyle.Format = "N2"
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(4).HeaderText = "Facility Fee"
                .Columns(4).Width = 150
                .Columns(4).DefaultCellStyle.Format = "N2"
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).HeaderText = "Prof Fee"
                .Columns(5).Width = 150
                .Columns(5).DefaultCellStyle.Format = "N2"
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            ElseIf search = ModuleName.Employees Or search = ModuleName.Nurses Then
                .Columns(0).Visible = False
                .Columns(1).Width = 80
                .Columns(2).Width = 130
                .Columns(3).Width = 130
                .Columns(4).Width = 100
                .Columns(5).Width = 150 'address
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(6).Width = 100
                .Columns(7).Width = 100
                .Columns(8).Visible = False
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                .Columns(14).Visible = False
                .Columns(15).Visible = False
                .Columns(16).Visible = False
                .Columns(17).Visible = False
                .Columns(18).Width = 100
                .Columns(19).Visible = False
                .Columns(20).Visible = False
                .Columns(21).Visible = False
            ElseIf search = ModuleName.NonHospitalSuppliers Or search = ModuleName.HospitalSuppliers Then   ''uncomment tonton 6/1/2022
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
                'ElseIf search = ModuleName.GenericName Then
                '    .Columns(0).Visible = False 'unitcode
                '    .Columns(0).HeaderText = "genericid"
                '    .Columns(1).HeaderText = "Generic Code"
                '    .Columns(1).Width = 310
                '    .Columns(2).HeaderText = "Generic Name"
                '    .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                '    .Columns(3).Visible = False
                '    .Columns(4).Visible = False
                '    .Columns(5).Visible = False
                '    .Columns(6).Visible = False
                '    .Columns(7).Visible = False
            ElseIf search = ModuleName.PackageCharges Then
                .Columns(0).HeaderText = "Package Charge #"
                .Columns(0).Width = 140
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(2).Width = 140
                .Columns(3).Width = 140
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).Visible = False

            ElseIf search = ModuleName.PhilhealthMedicines Then
                .Columns(0).Width = 200
                .Columns(0).HeaderText = "Drug Code"
                .Columns(1).HeaderText = "Drug Description"
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Visible = False
                .Columns(3).HeaderText = "Generic Name"
                .Columns(3).Width = 200
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                'ElseIf search = ModuleName.UnmappedItems Then
                '    .Columns(0).Width = 150
                '    .Columns(0).HeaderText = "Item Code"
                '    .Columns(1).HeaderText = "Item Description"
                '    .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                '    .Columns(3).HeaderText = "Generic Name"
                '    .Columns(3).Width = 160
                '    .Columns(3).HeaderText = "Item Category"
                '    .Columns(3).Width = 140

            ElseIf search = ModuleName.Offices Then
                .Columns(0).Width = 200
                .Columns(0).HeaderText = "Office Code"
                .Columns(1).HeaderText = "Office Name"
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Width = 300
                .Columns(2).HeaderText = "Division Name"
                .Columns(3).Visible = False
                .Columns(4).Visible = False

            ElseIf search = ModuleName.LotNo Then
                .Columns(0).HeaderText = "Lot Number"
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(1).Visible = False

            ElseIf search = ModuleName.ItemCategory Then
                .Columns(0).Width = 200
                .Columns(0).HeaderText = "Item Category Code"
                .Columns(1).HeaderText = "Item Category Description"
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Visible = False
                .Columns(3).Visible = False
                .Columns(4).Width = 300
                .Columns(4).HeaderText = "Category Type"
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False

            End If
        End With
    End Sub

    Private Sub IgnoreCreateNew()
        If mModuleName = ModuleName.Patient Then
            Dim fPatients As New frmPatient
            fPatients.myCurrentFormStatus = frmPatient.enFormStatus.add
            fPatients.ShowDialog()
            issave = fPatients.isSave
            If issave <> False Then
                mKey = fPatients.patientid
                Me.Close()
            End If
            fPatients.Close()
        ElseIf mModuleName = ModuleName.PhilHealthMembers Then
            Dim f As New frmPhilHealthEntry
            f.myCurrentFormStatus = frmPhilHealthEntry.enFormStatus.add
            f.ShowDialog()
            issave = f.isSave
            If f.isSave Then
                mKey = f.PhilHealthNo
                Me.Close()
            End If
            f.Dispose()
        'ElseIf mModuleName = ModuleName.Physician Then
        '    Dim f As New frmEmployees
        '    f.myCurrentFormStatus = frmEmployees.enFormStatus.add
        '    f.ShowDialog()
        '    issave = f.issave
        '    If f.isSave Then
        '        mKey = f.employeetypeid
        '        Me.Close()
        '    End If
        '    f.Dispose()
            'ElseIf mModuleName = ModuleName.NonHospitalSuppliers Then
            '    Dim f As New frmSupplier(frmSupplier.enFormStatus.add)
            '    f.ishospitalsupplier = False
            '    f.ShowDialog()
            '    issave = f.isSave
            '    If f.issave Then
            '        mKey = f.msupplierid
            '        mvalue = f.oldName
            '        Me.Close()
            '    End If
            '    f.Dispose()
            'ElseIf mModuleName = ModuleName.HospitalSuppliers Then
            '    Dim fManufacturer As New frmSupplier(frmSupplier.enFormStatus.add)
            '    fManufacturer.ShowDialog()
            '    issave = fManufacturer.isSave
            '    If fManufacturer.isSave Then
            '        mKey = fManufacturer.msupplierid
            '        mvalue = fManufacturer.oldName
            '        Me.Close()
            '    End If
            'ElseIf mModuleName = ModuleName.NonHospitalItems Then
            '    Dim f As New frmItems
            '    f.myFormStatus = frmItems.enFormStatus.add
            '    f.ishospitalitem = False
            '    f.ShowDialog()
            '    issave = f.isSave
            '    If f.isSave Then
            '        mKey = f.itemcode
            '        Me.Close()
            '    End If
            '    f.Dispose()
            'ElseIf mModuleName = ModuleName.Items Or mModuleName = ModuleName.UnmappedItems Then
            'Dim f As New frmItems
            'f.myFormStatus = frmItems.enFormStatus.add
            'f.ishospitalitem = True
            'f.ShowDialog()
            'issave = f.isSave
            'If f.isSave Then
            '    mKey = f.txtItemCode.Text
            '    Me.Close()
            'End If
            'f.Dispose()
            'ElseIf mModuleName = ModuleName.GenericName Then
            '    Dim fGeneric As New frmGeneric
            '    fGeneric.myCurrentFormStatus = frmGeneric.enFormStatus.add
            '    fGeneric.ShowDialog()
            '    If fGeneric.GenericID > 0 Then
            '        mKey = fGeneric.GenericID
            '        mvalue = fGeneric.GenericName
            '    End If
            '    fGeneric.Dispose()
            '    issave = fGeneric.isSave
            '    If issave <> False Then
            '        Me.Dispose()
            '    End If
        End If
    End Sub
    Private Sub txtSearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        If e.KeyCode = Keys.Enter Then
            afterload = True
            Call DisplayList(mModuleName)
        End If
    End Sub
    Private Sub tsClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsClose.Click
        issave = False
        Close()
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

#End Region

#Region "Methods"
    Private Sub LoadImage()
        Me.tsClose.Image = modGlobal.close_icon
        'Me.btnSelRec.Image = modGlobal.select_record_icon
        Me.btnIgnoreCreateNew.Image = modGlobal.load_item_icon
    End Sub
    Private Sub FilterBy()
        Me.cmbFilterby.Visible = False
        Me.lblFilterby.Visible = False
        With Me.cmbFilterby
            If mModuleName = ModuleName.Physician Then
                .Items.Add("Active") 'Active(0)
                .Items.Add("Inactive") 'InActive(1)
                .SelectedIndex = 0
                .Visible = True
                Me.lblFilterby.Visible = True
            End If
        End With
    End Sub
    Private Sub SelectedRecord()
        Try
            If mModuleName = ModuleName.Patient Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                mvalue = Me.dgGeneric.SelectedRows(0).Cells(4).Value

            ElseIf mModuleName = ModuleName.Admission Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(1).Value
                mvalue = CDate(Me.dgGeneric.SelectedRows(0).Cells(5).Value).ToShortDateString & "-" & Me.dgGeneric.SelectedRows(0).Cells(4).Value

            ElseIf mModuleName = ModuleName.Physician Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value

            ElseIf mModuleName = ModuleName.Rooms Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value

            ElseIf mModuleName = ModuleName.ICD10Diagnosis Then
                mrow = Me.dgGeneric.Rows(dgGeneric.CurrentRow.Index)

            ElseIf mModuleName = ModuleName.Procedures Then
                mrow = Me.dgGeneric.Rows(dgGeneric.CurrentRow.Index)

            ElseIf mModuleName = ModuleName.Items Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                Me.mvalue = Me.dgGeneric.SelectedRows(0).Cells(1).Value

            ElseIf mModuleName = ModuleName.NonHospitalItems Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                mrow = Me.dgGeneric.Rows(dgGeneric.CurrentRow.Index)

            ElseIf mModuleName = ModuleName.PhilHealthPackages1 Or mModuleName = ModuleName.PhilHealthPackages2 Then
                mrow = Me.dgGeneric.Rows(dgGeneric.CurrentRow.Index)

            ElseIf mModuleName = ModuleName.TransmittalUnmapped Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value

            ElseIf mModuleName = ModuleName.PhilHealthMembers Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value

            ElseIf mModuleName = ModuleName.Hospital Then
                mrow = Me.dgGeneric.Rows(dgGeneric.CurrentRow.Index)
            ElseIf mModuleName = ModuleName.ZBenefit Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
            ElseIf mModuleName = ModuleName.Employees Or mModuleName = ModuleName.Nurses Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                Me.mvalue = Me.dgGeneric.SelectedRows(0).Cells(2).Value + ", " + Me.dgGeneric.SelectedRows(0).Cells(3).Value + " " + Me.dgGeneric.SelectedRows(0).Cells(4).Value
            ElseIf mModuleName = ModuleName.HospitalSuppliers Then  ''uncomment tonton 6/1/2022
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                Me.mvalue = Me.dgGeneric.SelectedRows(0).Cells(1).Value
                'ElseIf mModuleName = ModuleName.NonHospitalSuppliers Then
                '    mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                '    Me.mvalue = Me.dgGeneric.SelectedRows(0).Cells(1).Value
                'ElseIf mModuleName = ModuleName.GenericName Then
                '    mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                'Me.mvalue = Me.dgGeneric.SelectedRows(0).Cells(2).Value
            ElseIf mModuleName = ModuleName.PackageCharges Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                Me.mvalue = Me.dgGeneric.SelectedRows(0).Cells(1).Value
            ElseIf mModuleName = ModuleName.PhilhealthMedicines Then
                If Not Me.chknotfound.Checked Then
                    mrow = Me.dgGeneric.Rows(dgGeneric.CurrentRow.Index)
                End If
                'ElseIf mModuleName = ModuleName.UnmappedItems Then
                '    mrow = Me.dgGeneric.Rows(dgGeneric.CurrentRow.Index)
            ElseIf mModuleName = ModuleName.Offices Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                Me.mvalue = Me.dgGeneric.SelectedRows(0).Cells(1).Value
            ElseIf mModuleName = ModuleName.LotNo Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
            ElseIf mModuleName = ModuleName.ItemCategory Then
                mKey = Me.dgGeneric.SelectedRows(0).Cells(0).Value
                Me.mvalue = Me.dgGeneric.SelectedRows(0).Cells(1).Value
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

    Private Sub btnIgnoreCreateNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIgnoreCreateNew.Click
        Call IgnoreCreateNew()
    End Sub

End Class