<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhilHealthEntry
    Inherits System.Windows.Forms.Form
    
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbgeneral = New System.Windows.Forms.TabPage()
        Me.txtlotblockhousebldgno = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtbuildingname = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtunitroomnofloor = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtcountry = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.gbGender = New System.Windows.Forms.GroupBox()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.chkispatphilhealthmember = New System.Windows.Forms.CheckBox()
        Me.A4 = New System.Windows.Forms.Label()
        Me.A3 = New System.Windows.Forms.Label()
        Me.A2 = New System.Windows.Forms.Label()
        Me.A1 = New System.Windows.Forms.Label()
        Me.txtPhilMemberNo = New System.Windows.Forms.MaskedTextBox()
        Me.txtPhilMobileNo = New System.Windows.Forms.MaskedTextBox()
        Me.txtPhilLandline = New System.Windows.Forms.MaskedTextBox()
        Me.txtAvailmenttype = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtpPhilHealthBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbPhilMembershipCat = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPhilEmailAdd = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPhilZipCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPhilProvince = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPhilCityMunicipality = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPhilBrgy = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPhilHouseNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPhilMiddleName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPhilLastName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPhilFirstName = New System.Windows.Forms.TextBox()
        Me.Label241 = New System.Windows.Forms.Label()
        Me.cmbRelToMember = New System.Windows.Forms.ComboBox()
        Me.tbemployeerinfo = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPhilempno = New System.Windows.Forms.MaskedTextBox()
        Me.txtPhilEmpContactNo = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtPhilEmpZipCode = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPhilEmpProvince = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPhilEmpCityMunicipality = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPhilEmpBldgNo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPhilEmpBusName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsSave1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsclose = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.txtPhilSuffix = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tbgeneral.SuspendLayout()
        Me.gbGender.SuspendLayout()
        Me.tbemployeerinfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbgeneral)
        Me.TabControl1.Controls.Add(Me.tbemployeerinfo)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.TabControl1.Location = New System.Drawing.Point(12, 49)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(544, 576)
        Me.TabControl1.TabIndex = 0
        '
        'tbgeneral
        '
        Me.tbgeneral.Controls.Add(Me.txtPhilSuffix)
        Me.tbgeneral.Controls.Add(Me.Label26)
        Me.tbgeneral.Controls.Add(Me.txtlotblockhousebldgno)
        Me.tbgeneral.Controls.Add(Me.Label23)
        Me.tbgeneral.Controls.Add(Me.txtbuildingname)
        Me.tbgeneral.Controls.Add(Me.Label24)
        Me.tbgeneral.Controls.Add(Me.txtunitroomnofloor)
        Me.tbgeneral.Controls.Add(Me.Label25)
        Me.tbgeneral.Controls.Add(Me.txtcountry)
        Me.tbgeneral.Controls.Add(Me.Label22)
        Me.tbgeneral.Controls.Add(Me.gbGender)
        Me.tbgeneral.Controls.Add(Me.chkispatphilhealthmember)
        Me.tbgeneral.Controls.Add(Me.A4)
        Me.tbgeneral.Controls.Add(Me.A3)
        Me.tbgeneral.Controls.Add(Me.A2)
        Me.tbgeneral.Controls.Add(Me.A1)
        Me.tbgeneral.Controls.Add(Me.txtPhilMemberNo)
        Me.tbgeneral.Controls.Add(Me.txtPhilMobileNo)
        Me.tbgeneral.Controls.Add(Me.txtPhilLandline)
        Me.tbgeneral.Controls.Add(Me.txtAvailmenttype)
        Me.tbgeneral.Controls.Add(Me.Label21)
        Me.tbgeneral.Controls.Add(Me.dtpPhilHealthBirthDate)
        Me.tbgeneral.Controls.Add(Me.cmbPhilMembershipCat)
        Me.tbgeneral.Controls.Add(Me.Label13)
        Me.tbgeneral.Controls.Add(Me.Label9)
        Me.tbgeneral.Controls.Add(Me.Label10)
        Me.tbgeneral.Controls.Add(Me.Label11)
        Me.tbgeneral.Controls.Add(Me.txtPhilEmailAdd)
        Me.tbgeneral.Controls.Add(Me.Label12)
        Me.tbgeneral.Controls.Add(Me.txtPhilZipCode)
        Me.tbgeneral.Controls.Add(Me.Label2)
        Me.tbgeneral.Controls.Add(Me.Label8)
        Me.tbgeneral.Controls.Add(Me.txtPhilProvince)
        Me.tbgeneral.Controls.Add(Me.Label6)
        Me.tbgeneral.Controls.Add(Me.txtPhilCityMunicipality)
        Me.tbgeneral.Controls.Add(Me.Label7)
        Me.tbgeneral.Controls.Add(Me.txtPhilBrgy)
        Me.tbgeneral.Controls.Add(Me.Label4)
        Me.tbgeneral.Controls.Add(Me.txtPhilHouseNo)
        Me.tbgeneral.Controls.Add(Me.Label5)
        Me.tbgeneral.Controls.Add(Me.txtPhilMiddleName)
        Me.tbgeneral.Controls.Add(Me.Label3)
        Me.tbgeneral.Controls.Add(Me.txtPhilLastName)
        Me.tbgeneral.Controls.Add(Me.Label1)
        Me.tbgeneral.Controls.Add(Me.txtPhilFirstName)
        Me.tbgeneral.Controls.Add(Me.Label241)
        Me.tbgeneral.Controls.Add(Me.cmbRelToMember)
        Me.tbgeneral.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.tbgeneral.Location = New System.Drawing.Point(4, 22)
        Me.tbgeneral.Name = "tbgeneral"
        Me.tbgeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tbgeneral.Size = New System.Drawing.Size(536, 550)
        Me.tbgeneral.TabIndex = 0
        Me.tbgeneral.Text = "General"
        Me.tbgeneral.UseVisualStyleBackColor = True
        '
        'txtlotblockhousebldgno
        '
        Me.txtlotblockhousebldgno.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txtlotblockhousebldgno.Location = New System.Drawing.Point(167, 356)
        Me.txtlotblockhousebldgno.MaxLength = 250
        Me.txtlotblockhousebldgno.Multiline = True
        Me.txtlotblockhousebldgno.Name = "txtlotblockhousebldgno"
        Me.txtlotblockhousebldgno.Size = New System.Drawing.Size(261, 21)
        Me.txtlotblockhousebldgno.TabIndex = 15
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.Label23.Location = New System.Drawing.Point(9, 356)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(152, 14)
        Me.Label23.TabIndex = 194
        Me.Label23.Text = "Lot/Block/House/Bldg No.:"
        '
        'txtbuildingname
        '
        Me.txtbuildingname.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txtbuildingname.Location = New System.Drawing.Point(167, 329)
        Me.txtbuildingname.MaxLength = 250
        Me.txtbuildingname.Multiline = True
        Me.txtbuildingname.Name = "txtbuildingname"
        Me.txtbuildingname.Size = New System.Drawing.Size(261, 21)
        Me.txtbuildingname.TabIndex = 14
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.Label24.Location = New System.Drawing.Point(74, 329)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(87, 14)
        Me.Label24.TabIndex = 191
        Me.Label24.Text = "Building Name:"
        '
        'txtunitroomnofloor
        '
        Me.txtunitroomnofloor.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txtunitroomnofloor.Location = New System.Drawing.Point(167, 302)
        Me.txtunitroomnofloor.MaxLength = 250
        Me.txtunitroomnofloor.Multiline = True
        Me.txtunitroomnofloor.Name = "txtunitroomnofloor"
        Me.txtunitroomnofloor.Size = New System.Drawing.Size(261, 21)
        Me.txtunitroomnofloor.TabIndex = 13
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.Label25.Location = New System.Drawing.Point(35, 303)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(126, 14)
        Me.Label25.TabIndex = 189
        Me.Label25.Text = "Unit/Room No., Floor:"
        '
        'txtcountry
        '
        Me.txtcountry.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txtcountry.Location = New System.Drawing.Point(167, 493)
        Me.txtcountry.MaxLength = 250
        Me.txtcountry.Multiline = True
        Me.txtcountry.Name = "txtcountry"
        Me.txtcountry.Size = New System.Drawing.Size(261, 21)
        Me.txtcountry.TabIndex = 20
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.Label22.Location = New System.Drawing.Point(107, 493)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(54, 14)
        Me.Label22.TabIndex = 188
        Me.Label22.Text = "Country:"
        '
        'gbGender
        '
        Me.gbGender.Controls.Add(Me.rbFemale)
        Me.gbGender.Controls.Add(Me.rbMale)
        Me.gbGender.Location = New System.Drawing.Point(300, 143)
        Me.gbGender.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gbGender.Name = "gbGender"
        Me.gbGender.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gbGender.Size = New System.Drawing.Size(128, 59)
        Me.gbGender.TabIndex = 8
        Me.gbGender.TabStop = False
        Me.gbGender.Text = "Gender"
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.rbFemale.Location = New System.Drawing.Point(63, 29)
        Me.rbFemale.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(63, 18)
        Me.rbFemale.TabIndex = 17
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Checked = True
        Me.rbMale.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.rbMale.Location = New System.Drawing.Point(9, 29)
        Me.rbMale.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(49, 18)
        Me.rbMale.TabIndex = 16
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'chkispatphilhealthmember
        '
        Me.chkispatphilhealthmember.AutoSize = True
        Me.chkispatphilhealthmember.Location = New System.Drawing.Point(316, 15)
        Me.chkispatphilhealthmember.Name = "chkispatphilhealthmember"
        Me.chkispatphilhealthmember.Size = New System.Drawing.Size(154, 18)
        Me.chkispatphilhealthmember.TabIndex = 40
        Me.chkispatphilhealthmember.Text = "Patient is PHIC Member"
        Me.chkispatphilhealthmember.UseVisualStyleBackColor = True
        Me.chkispatphilhealthmember.Visible = False
        '
        'A4
        '
        Me.A4.AutoSize = True
        Me.A4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A4.ForeColor = System.Drawing.Color.Maroon
        Me.A4.Location = New System.Drawing.Point(434, 94)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(16, 20)
        Me.A4.TabIndex = 39
        Me.A4.Text = "*"
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A3.ForeColor = System.Drawing.Color.Maroon
        Me.A3.Location = New System.Drawing.Point(434, 69)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(16, 20)
        Me.A3.TabIndex = 38
        Me.A3.Text = "*"
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A2.ForeColor = System.Drawing.Color.Maroon
        Me.A2.Location = New System.Drawing.Point(434, 42)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(16, 20)
        Me.A2.TabIndex = 37
        Me.A2.Text = "*"
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A1.ForeColor = System.Drawing.Color.Maroon
        Me.A1.Location = New System.Drawing.Point(293, 17)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(16, 20)
        Me.A1.TabIndex = 36
        Me.A1.Text = "*"
        '
        'txtPhilMemberNo
        '
        Me.txtPhilMemberNo.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txtPhilMemberNo.Location = New System.Drawing.Point(167, 14)
        Me.txtPhilMemberNo.Mask = "00-000000000-0"
        Me.txtPhilMemberNo.Name = "txtPhilMemberNo"
        Me.txtPhilMemberNo.Size = New System.Drawing.Size(122, 21)
        Me.txtPhilMemberNo.TabIndex = 1
        '
        'txtPhilMobileNo
        '
        Me.txtPhilMobileNo.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txtPhilMobileNo.Location = New System.Drawing.Point(167, 168)
        Me.txtPhilMobileNo.Mask = "(+63) 000-0000-000"
        Me.txtPhilMobileNo.Name = "txtPhilMobileNo"
        Me.txtPhilMobileNo.Size = New System.Drawing.Size(122, 21)
        Me.txtPhilMobileNo.TabIndex = 7
        '
        'txtPhilLandline
        '
        Me.txtPhilLandline.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txtPhilLandline.Location = New System.Drawing.Point(167, 195)
        Me.txtPhilLandline.Mask = "(000) 000-0000"
        Me.txtPhilLandline.Name = "txtPhilLandline"
        Me.txtPhilLandline.Size = New System.Drawing.Size(122, 21)
        Me.txtPhilLandline.TabIndex = 9
        '
        'txtAvailmenttype
        '
        Me.txtAvailmenttype.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txtAvailmenttype.Location = New System.Drawing.Point(167, 275)
        Me.txtAvailmenttype.MaxLength = 1
        Me.txtAvailmenttype.Name = "txtAvailmenttype"
        Me.txtAvailmenttype.Size = New System.Drawing.Size(122, 21)
        Me.txtAvailmenttype.TabIndex = 10
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.Label21.Location = New System.Drawing.Point(65, 278)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 14)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "Availment Type:"
        '
        'dtpPhilHealthBirthDate
        '
        Me.dtpPhilHealthBirthDate.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.dtpPhilHealthBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPhilHealthBirthDate.Location = New System.Drawing.Point(167, 143)
        Me.dtpPhilHealthBirthDate.Name = "dtpPhilHealthBirthDate"
        Me.dtpPhilHealthBirthDate.Size = New System.Drawing.Size(122, 21)
        Me.dtpPhilHealthBirthDate.TabIndex = 6
        '
        'cmbPhilMembershipCat
        '
        Me.cmbPhilMembershipCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPhilMembershipCat.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.cmbPhilMembershipCat.FormattingEnabled = True
        Me.cmbPhilMembershipCat.Location = New System.Drawing.Point(167, 247)
        Me.cmbPhilMembershipCat.Name = "cmbPhilMembershipCat"
        Me.cmbPhilMembershipCat.Size = New System.Drawing.Size(261, 21)
        Me.cmbPhilMembershipCat.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.Label13.Location = New System.Drawing.Point(32, 251)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 14)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Membership Category:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.Label9.Location = New System.Drawing.Point(80, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 14)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Date of Birth:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.Label10.Location = New System.Drawing.Point(106, 199)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 14)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Landline:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.Label11.Location = New System.Drawing.Point(93, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 14)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Mobile No.:"
        '
        'txtPhilEmailAdd
        '
        Me.txtPhilEmailAdd.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txtPhilEmailAdd.Location = New System.Drawing.Point(167, 220)
        Me.txtPhilEmailAdd.MaxLength = 50
        Me.txtPhilEmailAdd.Name = "txtPhilEmailAdd"
        Me.txtPhilEmailAdd.Size = New System.Drawing.Size(261, 21)
        Me.txtPhilEmailAdd.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.Label12.Location = New System.Drawing.Point(120, 226)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 14)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "E-Mail:"
        '
        'txtPhilZipCode
        '
        Me.txtPhilZipCode.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txtPhilZipCode.Location = New System.Drawing.Point(167, 518)
        Me.txtPhilZipCode.MaxLength = 9
        Me.txtPhilZipCode.Name = "txtPhilZipCode"
        Me.txtPhilZipCode.Size = New System.Drawing.Size(122, 21)
        Me.txtPhilZipCode.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.Label2.Location = New System.Drawing.Point(102, 521)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 14)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Zip Code:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.Label8.Location = New System.Drawing.Point(26, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 14)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "PhilHealth Member No.:"
        '
        'txtPhilProvince
        '
        Me.txtPhilProvince.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txtPhilProvince.Location = New System.Drawing.Point(167, 466)
        Me.txtPhilProvince.MaxLength = 250
        Me.txtPhilProvince.Multiline = True
        Me.txtPhilProvince.Name = "txtPhilProvince"
        Me.txtPhilProvince.Size = New System.Drawing.Size(261, 21)
        Me.txtPhilProvince.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.Label6.Location = New System.Drawing.Point(104, 466)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 14)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Province:"
        '
        'txtPhilCityMunicipality
        '
        Me.txtPhilCityMunicipality.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txtPhilCityMunicipality.Location = New System.Drawing.Point(167, 439)
        Me.txtPhilCityMunicipality.MaxLength = 250
        Me.txtPhilCityMunicipality.Multiline = True
        Me.txtPhilCityMunicipality.Name = "txtPhilCityMunicipality"
        Me.txtPhilCityMunicipality.Size = New System.Drawing.Size(261, 21)
        Me.txtPhilCityMunicipality.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.Label7.Location = New System.Drawing.Point(64, 439)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 14)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "City/Municipality:"
        '
        'txtPhilBrgy
        '
        Me.txtPhilBrgy.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txtPhilBrgy.Location = New System.Drawing.Point(167, 412)
        Me.txtPhilBrgy.MaxLength = 250
        Me.txtPhilBrgy.Multiline = True
        Me.txtPhilBrgy.Name = "txtPhilBrgy"
        Me.txtPhilBrgy.Size = New System.Drawing.Size(261, 21)
        Me.txtPhilBrgy.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.Label4.Location = New System.Drawing.Point(101, 412)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 14)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Barangay:"
        '
        'txtPhilHouseNo
        '
        Me.txtPhilHouseNo.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txtPhilHouseNo.Location = New System.Drawing.Point(167, 385)
        Me.txtPhilHouseNo.MaxLength = 250
        Me.txtPhilHouseNo.Multiline = True
        Me.txtPhilHouseNo.Name = "txtPhilHouseNo"
        Me.txtPhilHouseNo.Size = New System.Drawing.Size(261, 21)
        Me.txtPhilHouseNo.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.Label5.Location = New System.Drawing.Point(12, 386)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 14)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Street/Subdivision/Village:"
        '
        'txtPhilMiddleName
        '
        Me.txtPhilMiddleName.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txtPhilMiddleName.Location = New System.Drawing.Point(167, 93)
        Me.txtPhilMiddleName.MaxLength = 25
        Me.txtPhilMiddleName.Name = "txtPhilMiddleName"
        Me.txtPhilMiddleName.Size = New System.Drawing.Size(261, 21)
        Me.txtPhilMiddleName.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.Label3.Location = New System.Drawing.Point(81, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Middle Name:"
        '
        'txtPhilLastName
        '
        Me.txtPhilLastName.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txtPhilLastName.Location = New System.Drawing.Point(167, 41)
        Me.txtPhilLastName.MaxLength = 25
        Me.txtPhilLastName.Name = "txtPhilLastName"
        Me.txtPhilLastName.Size = New System.Drawing.Size(261, 21)
        Me.txtPhilLastName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.Label1.Location = New System.Drawing.Point(93, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Last Name:"
        '
        'txtPhilFirstName
        '
        Me.txtPhilFirstName.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txtPhilFirstName.Location = New System.Drawing.Point(167, 68)
        Me.txtPhilFirstName.MaxLength = 25
        Me.txtPhilFirstName.Name = "txtPhilFirstName"
        Me.txtPhilFirstName.Size = New System.Drawing.Size(261, 21)
        Me.txtPhilFirstName.TabIndex = 3
        '
        'Label241
        '
        Me.Label241.AutoSize = True
        Me.Label241.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.Label241.Location = New System.Drawing.Point(93, 68)
        Me.Label241.Name = "Label241"
        Me.Label241.Size = New System.Drawing.Size(68, 14)
        Me.Label241.TabIndex = 2
        Me.Label241.Text = "First Name:"
        '
        'cmbRelToMember
        '
        Me.cmbRelToMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRelToMember.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.cmbRelToMember.FormattingEnabled = True
        Me.cmbRelToMember.ItemHeight = 13
        Me.cmbRelToMember.Location = New System.Drawing.Point(167, 276)
        Me.cmbRelToMember.Name = "cmbRelToMember"
        Me.cmbRelToMember.Size = New System.Drawing.Size(261, 21)
        Me.cmbRelToMember.TabIndex = 195
        Me.cmbRelToMember.Visible = False
        '
        'tbemployeerinfo
        '
        Me.tbemployeerinfo.Controls.Add(Me.GroupBox1)
        Me.tbemployeerinfo.Location = New System.Drawing.Point(4, 22)
        Me.tbemployeerinfo.Name = "tbemployeerinfo"
        Me.tbemployeerinfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tbemployeerinfo.Size = New System.Drawing.Size(536, 527)
        Me.tbemployeerinfo.TabIndex = 1
        Me.tbemployeerinfo.Text = "Employer Information"
        Me.tbemployeerinfo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPhilempno)
        Me.GroupBox1.Controls.Add(Me.txtPhilEmpContactNo)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtPhilEmpZipCode)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtPhilEmpProvince)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtPhilEmpCityMunicipality)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtPhilEmpBldgNo)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtPhilEmpBusName)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 428)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtPhilempno
        '
        Me.txtPhilempno.Location = New System.Drawing.Point(130, 20)
        Me.txtPhilempno.Mask = "00-000000000-0"
        Me.txtPhilempno.Name = "txtPhilempno"
        Me.txtPhilempno.Size = New System.Drawing.Size(115, 21)
        Me.txtPhilempno.TabIndex = 1
        '
        'txtPhilEmpContactNo
        '
        Me.txtPhilEmpContactNo.Location = New System.Drawing.Point(130, 76)
        Me.txtPhilEmpContactNo.MaxLength = 15
        Me.txtPhilEmpContactNo.Name = "txtPhilEmpContactNo"
        Me.txtPhilEmpContactNo.Size = New System.Drawing.Size(115, 21)
        Me.txtPhilEmpContactNo.TabIndex = 3
        Me.txtPhilEmpContactNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(47, 77)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 14)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Contact No.:"
        '
        'txtPhilEmpZipCode
        '
        Me.txtPhilEmpZipCode.Location = New System.Drawing.Point(130, 183)
        Me.txtPhilEmpZipCode.Name = "txtPhilEmpZipCode"
        Me.txtPhilEmpZipCode.Size = New System.Drawing.Size(115, 21)
        Me.txtPhilEmpZipCode.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(65, 185)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 14)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Zip Code:"
        '
        'txtPhilEmpProvince
        '
        Me.txtPhilEmpProvince.Location = New System.Drawing.Point(130, 156)
        Me.txtPhilEmpProvince.MaxLength = 250
        Me.txtPhilEmpProvince.Multiline = True
        Me.txtPhilEmpProvince.Name = "txtPhilEmpProvince"
        Me.txtPhilEmpProvince.Size = New System.Drawing.Size(261, 21)
        Me.txtPhilEmpProvince.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(67, 156)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 14)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Province:"
        '
        'txtPhilEmpCityMunicipality
        '
        Me.txtPhilEmpCityMunicipality.Location = New System.Drawing.Point(130, 129)
        Me.txtPhilEmpCityMunicipality.MaxLength = 250
        Me.txtPhilEmpCityMunicipality.Multiline = True
        Me.txtPhilEmpCityMunicipality.Name = "txtPhilEmpCityMunicipality"
        Me.txtPhilEmpCityMunicipality.Size = New System.Drawing.Size(261, 21)
        Me.txtPhilEmpCityMunicipality.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(27, 130)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 14)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "City/Municipality:"
        '
        'txtPhilEmpBldgNo
        '
        Me.txtPhilEmpBldgNo.Location = New System.Drawing.Point(130, 102)
        Me.txtPhilEmpBldgNo.MaxLength = 250
        Me.txtPhilEmpBldgNo.Multiline = True
        Me.txtPhilEmpBldgNo.Name = "txtPhilEmpBldgNo"
        Me.txtPhilEmpBldgNo.Size = New System.Drawing.Size(261, 21)
        Me.txtPhilEmpBldgNo.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(27, 102)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 14)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Bldg.No./Street:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(37, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 14)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "PhilHealth No.:"
        '
        'txtPhilEmpBusName
        '
        Me.txtPhilEmpBusName.Location = New System.Drawing.Point(130, 50)
        Me.txtPhilEmpBusName.MaxLength = 150
        Me.txtPhilEmpBusName.Name = "txtPhilEmpBusName"
        Me.txtPhilEmpBusName.Size = New System.Drawing.Size(261, 21)
        Me.txtPhilEmpBusName.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(33, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 14)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Business Name:"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave1, Me.ToolStripSeparator1, Me.tsclose})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(568, 25)
        Me.ToolStrip2.TabIndex = 165
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsSave1
        '
        Me.tsSave1.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.tsSave1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave1.Name = "tsSave1"
        Me.tsSave1.Size = New System.Drawing.Size(37, 22)
        Me.tsSave1.Text = "Save"
        Me.tsSave1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsSave1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsclose
        '
        Me.tsclose.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.tsclose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsclose.Name = "tsclose"
        Me.tsclose.Size = New System.Drawing.Size(39, 22)
        Me.tsclose.Text = "Close"
        Me.tsclose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Location = New System.Drawing.Point(1, 29)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(567, 10)
        Me.GroupBox4.TabIndex = 184
        Me.GroupBox4.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 628)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(568, 22)
        Me.StatusStrip1.TabIndex = 185
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtPhilSuffix
        '
        Me.txtPhilSuffix.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txtPhilSuffix.Location = New System.Drawing.Point(167, 118)
        Me.txtPhilSuffix.MaxLength = 25
        Me.txtPhilSuffix.Name = "txtPhilSuffix"
        Me.txtPhilSuffix.Size = New System.Drawing.Size(261, 21)
        Me.txtPhilSuffix.TabIndex = 5
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.Label26.Location = New System.Drawing.Point(120, 121)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(41, 14)
        Me.Label26.TabIndex = 197
        Me.Label26.Text = "Suffix:"
        '
        'frmPhilHealthEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(568, 650)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmPhilHealthEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PhilHealth Member"
        Me.TabControl1.ResumeLayout(False)
        Me.tbgeneral.ResumeLayout(False)
        Me.tbgeneral.PerformLayout()
        Me.gbGender.ResumeLayout(False)
        Me.gbGender.PerformLayout()
        Me.tbemployeerinfo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbemployeerinfo As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPhilEmpZipCode As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtPhilEmpProvince As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtPhilEmpCityMunicipality As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtPhilEmpBldgNo As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPhilEmpBusName As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Public WithEvents tsSave1 As System.Windows.Forms.ToolStripButton
    Public WithEvents tsclose As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtPhilEmpContactNo As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtPhilempno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tbgeneral As System.Windows.Forms.TabPage
    Friend WithEvents A4 As System.Windows.Forms.Label
    Friend WithEvents A3 As System.Windows.Forms.Label
    Friend WithEvents A2 As System.Windows.Forms.Label
    Friend WithEvents A1 As System.Windows.Forms.Label
    Friend WithEvents txtPhilMemberNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPhilMobileNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPhilLandline As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtAvailmenttype As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents dtpPhilHealthBirthDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbPhilMembershipCat As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPhilEmailAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPhilZipCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPhilProvince As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPhilCityMunicipality As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPhilBrgy As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPhilHouseNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPhilMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPhilLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPhilFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label241 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents chkispatphilhealthmember As System.Windows.Forms.CheckBox
    Friend WithEvents gbGender As System.Windows.Forms.GroupBox
    Friend WithEvents rbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbMale As System.Windows.Forms.RadioButton
    Friend WithEvents cmbRelToMember As System.Windows.Forms.ComboBox
    Friend WithEvents txtlotblockhousebldgno As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtbuildingname As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtunitroomnofloor As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtcountry As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtPhilSuffix As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property
End Class
