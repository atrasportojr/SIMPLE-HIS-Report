<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrescription
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrescription))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridaPatientInformation = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblHospno = New System.Windows.Forms.Label()
        Me.lblPatient = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblPatientNo = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.dvgListOfPrescribedMedicines = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tstitle = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dtTime = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsClose = New System.Windows.Forms.ToolStripButton()
        Me.separatorprint = New System.Windows.Forms.ToolStripSeparator()
        Me.tsPrint = New System.Windows.Forms.ToolStripButton()
        Me.separatorpreprinted = New System.Windows.Forms.ToolStripSeparator()
        Me.tspreprinted = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbSearchrx = New System.Windows.Forms.ComboBox()
        Me.btnaddpresciptionitem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.colselectmed = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colfrequency = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colper = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbphysician = New System.Windows.Forms.ComboBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldrugname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colavailability = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colinstructions = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colperiod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colqty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldrugcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltemplates = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colptrequestno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colisupdatedrx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridaPatientInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgListOfPrescribedMedicines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridaPatientInformation
        '
        Me.DataGridaPatientInformation.AllowUserToAddRows = False
        Me.DataGridaPatientInformation.AllowUserToDeleteRows = False
        Me.DataGridaPatientInformation.AllowUserToResizeColumns = False
        Me.DataGridaPatientInformation.AllowUserToResizeRows = False
        Me.DataGridaPatientInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridaPatientInformation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridaPatientInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridaPatientInformation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridaPatientInformation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridaPatientInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridaPatientInformation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column11})
        Me.DataGridaPatientInformation.Location = New System.Drawing.Point(12, 60)
        Me.DataGridaPatientInformation.Name = "DataGridaPatientInformation"
        Me.DataGridaPatientInformation.RowHeadersVisible = False
        Me.DataGridaPatientInformation.Size = New System.Drawing.Size(942, 123)
        Me.DataGridaPatientInformation.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(29, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hospital No. :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(225, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Patient No. :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(57, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Patient :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(73, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Age :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(53, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Gender :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(444, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Address :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(464, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Date :"
        '
        'lblHospno
        '
        Me.lblHospno.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHospno.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblHospno.ForeColor = System.Drawing.Color.Black
        Me.lblHospno.Location = New System.Drawing.Point(108, 84)
        Me.lblHospno.Name = "lblHospno"
        Me.lblHospno.Size = New System.Drawing.Size(111, 16)
        Me.lblHospno.TabIndex = 9
        Me.lblHospno.Text = "..."
        '
        'lblPatient
        '
        Me.lblPatient.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPatient.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblPatient.ForeColor = System.Drawing.Color.Black
        Me.lblPatient.Location = New System.Drawing.Point(108, 109)
        Me.lblPatient.Name = "lblPatient"
        Me.lblPatient.Size = New System.Drawing.Size(302, 16)
        Me.lblPatient.TabIndex = 10
        Me.lblPatient.Text = "..."
        '
        'lblAge
        '
        Me.lblAge.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAge.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblAge.ForeColor = System.Drawing.Color.Black
        Me.lblAge.Location = New System.Drawing.Point(108, 131)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(302, 16)
        Me.lblAge.TabIndex = 11
        Me.lblAge.Text = "..."
        '
        'lblGender
        '
        Me.lblGender.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblGender.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblGender.ForeColor = System.Drawing.Color.Black
        Me.lblGender.Location = New System.Drawing.Point(108, 159)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(302, 16)
        Me.lblGender.TabIndex = 12
        Me.lblGender.Text = "..."
        '
        'lblPatientNo
        '
        Me.lblPatientNo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPatientNo.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblPatientNo.ForeColor = System.Drawing.Color.Black
        Me.lblPatientNo.Location = New System.Drawing.Point(301, 82)
        Me.lblPatientNo.Name = "lblPatientNo"
        Me.lblPatientNo.Size = New System.Drawing.Size(109, 16)
        Me.lblPatientNo.TabIndex = 13
        Me.lblPatientNo.Text = "..."
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblAddress.ForeColor = System.Drawing.Color.Black
        Me.lblAddress.Location = New System.Drawing.Point(502, 131)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(453, 44)
        Me.lblAddress.TabIndex = 15
        Me.lblAddress.Text = "..."
        '
        'dvgListOfPrescribedMedicines
        '
        Me.dvgListOfPrescribedMedicines.AllowUserToAddRows = False
        Me.dvgListOfPrescribedMedicines.AllowUserToDeleteRows = False
        Me.dvgListOfPrescribedMedicines.AllowUserToResizeColumns = False
        Me.dvgListOfPrescribedMedicines.AllowUserToResizeRows = False
        Me.dvgListOfPrescribedMedicines.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dvgListOfPrescribedMedicines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dvgListOfPrescribedMedicines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dvgListOfPrescribedMedicines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dvgListOfPrescribedMedicines.ColumnHeadersHeight = 28
        Me.dvgListOfPrescribedMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dvgListOfPrescribedMedicines.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colid, Me.colselectmed, Me.coldrugname, Me.colavailability, Me.colfrequency, Me.colinstructions, Me.colperiod, Me.colper, Me.colqty, Me.coldrugcode, Me.coltemplates, Me.colptrequestno, Me.colisupdatedrx})
        Me.dvgListOfPrescribedMedicines.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.5!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgListOfPrescribedMedicines.DefaultCellStyle = DataGridViewCellStyle4
        Me.dvgListOfPrescribedMedicines.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dvgListOfPrescribedMedicines.Location = New System.Drawing.Point(13, 226)
        Me.dvgListOfPrescribedMedicines.MultiSelect = False
        Me.dvgListOfPrescribedMedicines.Name = "dvgListOfPrescribedMedicines"
        Me.dvgListOfPrescribedMedicines.RowHeadersVisible = False
        Me.dvgListOfPrescribedMedicines.RowTemplate.Height = 40
        Me.dvgListOfPrescribedMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dvgListOfPrescribedMedicines.Size = New System.Drawing.Size(942, 426)
        Me.dvgListOfPrescribedMedicines.TabIndex = 17
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstitle})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 659)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(967, 22)
        Me.StatusStrip1.TabIndex = 24
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tstitle
        '
        Me.tstitle.BackColor = System.Drawing.Color.Transparent
        Me.tstitle.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tstitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tstitle.Name = "tstitle"
        Me.tstitle.Size = New System.Drawing.Size(952, 17)
        Me.tstitle.Spring = True
        Me.tstitle.Text = "..."
        Me.tstitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tstitle.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(58, 403)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(909, 25)
        Me.Label11.TabIndex = 187
        Me.Label11.Text = "List of Prescribed Medicines"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "DeleteFolderHS.png")
        Me.ImageList1.Images.SetKeyName(1, "capsule.png")
        '
        'dtTime
        '
        Me.dtTime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtTime.CustomFormat = "MM/dd/yyyy hh:dd tt"
        Me.dtTime.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTime.Location = New System.Drawing.Point(503, 103)
        Me.dtTime.Name = "dtTime"
        Me.dtTime.Size = New System.Drawing.Size(293, 21)
        Me.dtTime.TabIndex = 188
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.ToolStripSeparator2, Me.tsClose, Me.separatorprint, Me.tsPrint, Me.separatorpreprinted, Me.tspreprinted})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(967, 38)
        Me.ToolStrip2.TabIndex = 53
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsSave
        '
        Me.tsSave.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.tsSave.ForeColor = System.Drawing.Color.Black
        Me.tsSave.Image = Global.HISReports.My.Resources.Resources.ic_save
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(38, 35)
        Me.tsSave.Text = "Save"
        Me.tsSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'tsClose
        '
        Me.tsClose.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.tsClose.ForeColor = System.Drawing.Color.Black
        Me.tsClose.Image = Global.HISReports.My.Resources.Resources.delete_16x16
        Me.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsClose.Name = "tsClose"
        Me.tsClose.Size = New System.Drawing.Size(44, 35)
        Me.tsClose.Text = "Close"
        Me.tsClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'separatorprint
        '
        Me.separatorprint.Name = "separatorprint"
        Me.separatorprint.Size = New System.Drawing.Size(6, 38)
        Me.separatorprint.Visible = False
        '
        'tsPrint
        '
        Me.tsPrint.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.tsPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPrint.Name = "tsPrint"
        Me.tsPrint.Size = New System.Drawing.Size(36, 35)
        Me.tsPrint.Text = "Print"
        Me.tsPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsPrint.Visible = False
        '
        'separatorpreprinted
        '
        Me.separatorpreprinted.Name = "separatorpreprinted"
        Me.separatorpreprinted.Size = New System.Drawing.Size(6, 38)
        Me.separatorpreprinted.Visible = False
        '
        'tspreprinted
        '
        Me.tspreprinted.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.tspreprinted.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tspreprinted.Name = "tspreprinted"
        Me.tspreprinted.Size = New System.Drawing.Size(68, 35)
        Me.tspreprinted.Text = "Preprinted"
        Me.tspreprinted.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tspreprinted.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tspreprinted.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(959, 10)
        Me.GroupBox1.TabIndex = 225
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(-3, 658)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(943, 2)
        Me.GroupBox2.TabIndex = 226
        Me.GroupBox2.TabStop = False
        '
        'cmbSearchrx
        '
        Me.cmbSearchrx.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSearchrx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbSearchrx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSearchrx.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchrx.FormattingEnabled = True
        Me.cmbSearchrx.Location = New System.Drawing.Point(665, 196)
        Me.cmbSearchrx.Name = "cmbSearchrx"
        Me.cmbSearchrx.Size = New System.Drawing.Size(263, 24)
        Me.cmbSearchrx.TabIndex = 227
        '
        'btnaddpresciptionitem
        '
        Me.btnaddpresciptionitem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnaddpresciptionitem.Image = Global.HISReports.My.Resources.Resources.add_16
        Me.btnaddpresciptionitem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaddpresciptionitem.Location = New System.Drawing.Point(929, 196)
        Me.btnaddpresciptionitem.Name = "btnaddpresciptionitem"
        Me.btnaddpresciptionitem.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnaddpresciptionitem.Size = New System.Drawing.Size(26, 23)
        Me.btnaddpresciptionitem.TabIndex = 228
        Me.btnaddpresciptionitem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnaddpresciptionitem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(569, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 229
        Me.Label1.Text = "Search Medicine:"
        '
        'colselectmed
        '
        Me.colselectmed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colselectmed.HeaderText = ""
        Me.colselectmed.Name = "colselectmed"
        Me.colselectmed.Width = 30
        '
        'colfrequency
        '
        Me.colfrequency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colfrequency.HeaderText = "Frequency"
        Me.colfrequency.Name = "colfrequency"
        Me.colfrequency.Width = 120
        '
        'colper
        '
        Me.colper.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colper.FillWeight = 58.02944!
        Me.colper.HeaderText = "   "
        Me.colper.Name = "colper"
        Me.colper.Width = 70
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(437, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 15)
        Me.Label9.TabIndex = 230
        Me.Label9.Text = "Physician :"
        '
        'cmbphysician
        '
        Me.cmbphysician.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbphysician.FormattingEnabled = True
        Me.cmbphysician.Location = New System.Drawing.Point(503, 78)
        Me.cmbphysician.Name = "cmbphysician"
        Me.cmbphysician.Size = New System.Drawing.Size(293, 22)
        Me.cmbphysician.TabIndex = 231
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 901
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Drug Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn3.FillWeight = 78.06763!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Availability"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn5.FillWeight = 223.8419!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Dosage"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Width = 130
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn6.FillWeight = 123.8908!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Period"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn7
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn7.FillWeight = 104.8494!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Drugcode"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "frmTemplates"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "frmTemplates"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "ptrequestno"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "colisupdatedrx"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'colid
        '
        Me.colid.HeaderText = "id"
        Me.colid.Name = "colid"
        Me.colid.Visible = False
        '
        'coldrugname
        '
        Me.coldrugname.FillWeight = 78.06763!
        Me.coldrugname.HeaderText = "Drug Name"
        Me.coldrugname.Name = "coldrugname"
        Me.coldrugname.ReadOnly = True
        Me.coldrugname.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldrugname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.coldrugname.Width = 245
        '
        'colavailability
        '
        Me.colavailability.HeaderText = "Availability"
        Me.colavailability.Name = "colavailability"
        Me.colavailability.Visible = False
        '
        'colinstructions
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colinstructions.DefaultCellStyle = DataGridViewCellStyle1
        Me.colinstructions.FillWeight = 223.8419!
        Me.colinstructions.HeaderText = "Special Instruction"
        Me.colinstructions.Name = "colinstructions"
        Me.colinstructions.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colinstructions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colinstructions.Width = 332
        '
        'colperiod
        '
        Me.colperiod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colperiod.DefaultCellStyle = DataGridViewCellStyle2
        Me.colperiod.FillWeight = 123.8908!
        Me.colperiod.HeaderText = "Period"
        Me.colperiod.Name = "colperiod"
        Me.colperiod.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colperiod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colqty
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colqty.DefaultCellStyle = DataGridViewCellStyle3
        Me.colqty.FillWeight = 104.8494!
        Me.colqty.HeaderText = "Quantity"
        Me.colqty.Name = "colqty"
        Me.colqty.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colqty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colqty.Width = 60
        '
        'coldrugcode
        '
        Me.coldrugcode.HeaderText = "Drugcode"
        Me.coldrugcode.Name = "coldrugcode"
        Me.coldrugcode.Visible = False
        '
        'coltemplates
        '
        Me.coltemplates.HeaderText = "frmTemplates"
        Me.coltemplates.Name = "coltemplates"
        Me.coltemplates.Visible = False
        '
        'colptrequestno
        '
        Me.colptrequestno.HeaderText = "colptrequestno"
        Me.colptrequestno.Name = "colptrequestno"
        Me.colptrequestno.Visible = False
        '
        'colisupdatedrx
        '
        Me.colisupdatedrx.HeaderText = "colisupdatedrx"
        Me.colisupdatedrx.Name = "colisupdatedrx"
        Me.colisupdatedrx.Visible = False
        '
        'Column11
        '
        Me.Column11.HeaderText = "Patient information"
        Me.Column11.Name = "Column11"
        Me.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmPrescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(967, 681)
        Me.Controls.Add(Me.cmbphysician)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnaddpresciptionitem)
        Me.Controls.Add(Me.cmbSearchrx)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dvgListOfPrescribedMedicines)
        Me.Controls.Add(Me.dtTime)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblPatientNo)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblPatient)
        Me.Controls.Add(Me.lblHospno)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridaPatientInformation)
        Me.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.Name = "frmPrescription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prescription"
        CType(Me.DataGridaPatientInformation,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dvgListOfPrescribedMedicines,System.ComponentModel.ISupportInitialize).EndInit
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.ToolStrip2.ResumeLayout(false)
        Me.ToolStrip2.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents DataGridaPatientInformation As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblHospno As System.Windows.Forms.Label
    Friend WithEvents lblPatient As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblPatientNo As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Public WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Public WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Public WithEvents tsClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents dvgListOfPrescribedMedicines As System.Windows.Forms.DataGridView
    Friend WithEvents tstitle As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents separatorprint As System.Windows.Forms.ToolStripSeparator
    Public WithEvents tsPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents separatorpreprinted As System.Windows.Forms.ToolStripSeparator
    Public WithEvents tspreprinted As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbSearchrx As System.Windows.Forms.ComboBox
    Friend WithEvents btnaddpresciptionitem As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colselectmed As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents coldrugname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colavailability As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colfrequency As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colinstructions As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colperiod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colper As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colqty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldrugcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltemplates As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colptrequestno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colisupdatedrx As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbphysician As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
