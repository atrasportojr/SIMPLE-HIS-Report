<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrescriptionList
    Inherits Windows.Forms.Form




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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrescriptionList))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblDateAdmitted = New System.Windows.Forms.Label()
        Me.lblPatientNo = New System.Windows.Forms.Label()
        Me.lblage = New System.Windows.Forms.Label()
        Me.Label303 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblPno = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ts_newrx = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_editrx = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_deleterx = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsPrintPrescription = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tspreprintedprescription = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ts_newtestrequest = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_edittestrequest = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_deletetestrequest = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsprinttestrequest = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.dvgListOfPrescribedMedicines = New System.Windows.Forms.DataGridView()
        Me.colprescriptionid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colprescriptiondescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colispostrequest = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgvTestRequest = New System.Windows.Forms.DataGridView()
        Me.coltestrequestid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltestrequestdetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldestinationoffice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colispostrequesttest = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dvgListOfPrescribedMedicines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTestRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 605)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1162, 22)
        Me.StatusStrip1.TabIndex = 183
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.lblDateAdmitted)
        Me.Panel1.Controls.Add(Me.lblPatientNo)
        Me.Panel1.Controls.Add(Me.lblage)
        Me.Panel1.Controls.Add(Me.Label303)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.lblSex)
        Me.Panel1.Controls.Add(Me.lblPno)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.lblBirthDate)
        Me.Panel1.Controls.Add(Me.lblLastName)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(17, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1132, 90)
        Me.Panel1.TabIndex = 255
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label28.Location = New System.Drawing.Point(17, 41)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 13)
        Me.Label28.TabIndex = 247
        Me.Label28.Text = "Date Admitted:"
        '
        'lblDateAdmitted
        '
        Me.lblDateAdmitted.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblDateAdmitted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateAdmitted.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.lblDateAdmitted.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDateAdmitted.Location = New System.Drawing.Point(18, 57)
        Me.lblDateAdmitted.Name = "lblDateAdmitted"
        Me.lblDateAdmitted.Size = New System.Drawing.Size(123, 20)
        Me.lblDateAdmitted.TabIndex = 248
        Me.lblDateAdmitted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPatientNo
        '
        Me.lblPatientNo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPatientNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPatientNo.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.lblPatientNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblPatientNo.Location = New System.Drawing.Point(17, 18)
        Me.lblPatientNo.Name = "lblPatientNo"
        Me.lblPatientNo.Size = New System.Drawing.Size(100, 20)
        Me.lblPatientNo.TabIndex = 246
        Me.lblPatientNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblage
        '
        Me.lblage.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblage.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.lblage.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblage.Location = New System.Drawing.Point(286, 57)
        Me.lblage.Name = "lblage"
        Me.lblage.Size = New System.Drawing.Size(50, 20)
        Me.lblage.TabIndex = 245
        Me.lblage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label303
        '
        Me.Label303.AutoSize = True
        Me.Label303.Location = New System.Drawing.Point(286, 44)
        Me.Label303.Name = "Label303"
        Me.Label303.Size = New System.Drawing.Size(30, 13)
        Me.Label303.TabIndex = 244
        Me.Label303.Text = "Age:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(139, 44)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(59, 13)
        Me.Label30.TabIndex = 226
        Me.Label30.Text = "Birth Date:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(120, 5)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(45, 13)
        Me.Label29.TabIndex = 227
        Me.Label29.Text = "Patient:"
        '
        'lblSex
        '
        Me.lblSex.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSex.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.lblSex.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblSex.Location = New System.Drawing.Point(342, 57)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(141, 20)
        Me.lblSex.TabIndex = 240
        Me.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPno
        '
        Me.lblPno.AutoSize = True
        Me.lblPno.Location = New System.Drawing.Point(14, 5)
        Me.lblPno.Name = "lblPno"
        Me.lblPno.Size = New System.Drawing.Size(65, 13)
        Me.lblPno.TabIndex = 231
        Me.lblPno.Text = "Patient No.:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(342, 44)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(46, 13)
        Me.Label26.TabIndex = 239
        Me.Label26.Text = "Gender:"
        '
        'lblBirthDate
        '
        Me.lblBirthDate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblBirthDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBirthDate.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.lblBirthDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblBirthDate.Location = New System.Drawing.Point(142, 57)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(141, 20)
        Me.lblBirthDate.TabIndex = 237
        Me.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLastName
        '
        Me.lblLastName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLastName.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.lblLastName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblLastName.Location = New System.Drawing.Point(123, 18)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(360, 20)
        Me.lblLastName.TabIndex = 234
        Me.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(579, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(2, 501)
        Me.GroupBox2.TabIndex = 260
        Me.GroupBox2.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackgroundImage = CType(resources.GetObject("ToolStrip1.BackgroundImage"), System.Drawing.Image)
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_newrx, Me.ToolStripSeparator5, Me.ts_editrx, Me.ToolStripSeparator8, Me.ts_deleterx, Me.ToolStripSeparator9, Me.tsPrintPrescription, Me.ToolStripSeparator7, Me.tspreprintedprescription, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(12, 121)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(560, 27)
        Me.ToolStrip1.TabIndex = 261
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ts_newrx
        '
        Me.ts_newrx.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ts_newrx.Enabled = False
        Me.ts_newrx.Font = New System.Drawing.Font("Trebuchet MS", 8.0!)
        Me.ts_newrx.ForeColor = System.Drawing.Color.Green
        Me.ts_newrx.Image = CType(resources.GetObject("ts_newrx.Image"), System.Drawing.Image)
        Me.ts_newrx.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_newrx.Name = "ts_newrx"
        Me.ts_newrx.Size = New System.Drawing.Size(33, 24)
        Me.ts_newrx.Text = "New"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'ts_editrx
        '
        Me.ts_editrx.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ts_editrx.Enabled = False
        Me.ts_editrx.Font = New System.Drawing.Font("Trebuchet MS", 8.0!)
        Me.ts_editrx.ForeColor = System.Drawing.Color.ForestGreen
        Me.ts_editrx.Image = CType(resources.GetObject("ts_editrx.Image"), System.Drawing.Image)
        Me.ts_editrx.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_editrx.Name = "ts_editrx"
        Me.ts_editrx.Size = New System.Drawing.Size(32, 24)
        Me.ts_editrx.Text = "Edit"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 27)
        '
        'ts_deleterx
        '
        Me.ts_deleterx.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ts_deleterx.Enabled = False
        Me.ts_deleterx.Font = New System.Drawing.Font("Trebuchet MS", 8.0!)
        Me.ts_deleterx.ForeColor = System.Drawing.Color.ForestGreen
        Me.ts_deleterx.Image = CType(resources.GetObject("ts_deleterx.Image"), System.Drawing.Image)
        Me.ts_deleterx.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_deleterx.Name = "ts_deleterx"
        Me.ts_deleterx.Size = New System.Drawing.Size(44, 24)
        Me.ts_deleterx.Text = "Delete"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 27)
        '
        'tsPrintPrescription
        '
        Me.tsPrintPrescription.Enabled = False
        Me.tsPrintPrescription.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsPrintPrescription.ForeColor = System.Drawing.Color.Green
        Me.tsPrintPrescription.Image = Global.HISReports.My.Resources.Resources.printer
        Me.tsPrintPrescription.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPrintPrescription.Name = "tsPrintPrescription"
        Me.tsPrintPrescription.Size = New System.Drawing.Size(49, 24)
        Me.tsPrintPrescription.Text = "Print"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 27)
        '
        'tspreprintedprescription
        '
        Me.tspreprintedprescription.Enabled = False
        Me.tspreprintedprescription.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tspreprintedprescription.ForeColor = System.Drawing.Color.Green
        Me.tspreprintedprescription.Image = Global.HISReports.My.Resources.Resources.printer
        Me.tspreprintedprescription.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tspreprintedprescription.Name = "tspreprintedprescription"
        Me.tspreprintedprescription.Size = New System.Drawing.Size(77, 24)
        Me.tspreprintedprescription.Text = "Preprinted"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Green
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(91, 24)
        Me.ToolStripLabel1.Text = "Prescriptions"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.BackgroundImage = CType(resources.GetObject("ToolStrip2.BackgroundImage"), System.Drawing.Image)
        Me.ToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_newtestrequest, Me.ToolStripSeparator1, Me.ts_edittestrequest, Me.ToolStripSeparator2, Me.ts_deletetestrequest, Me.ToolStripSeparator3, Me.tsprinttestrequest, Me.ToolStripLabel2})
        Me.ToolStrip2.Location = New System.Drawing.Point(590, 121)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(560, 27)
        Me.ToolStrip2.TabIndex = 262
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ts_newtestrequest
        '
        Me.ts_newtestrequest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ts_newtestrequest.Enabled = False
        Me.ts_newtestrequest.Font = New System.Drawing.Font("Trebuchet MS", 8.0!)
        Me.ts_newtestrequest.ForeColor = System.Drawing.Color.Green
        Me.ts_newtestrequest.Image = CType(resources.GetObject("ts_newtestrequest.Image"), System.Drawing.Image)
        Me.ts_newtestrequest.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_newtestrequest.Name = "ts_newtestrequest"
        Me.ts_newtestrequest.Size = New System.Drawing.Size(33, 24)
        Me.ts_newtestrequest.Text = "New"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ts_edittestrequest
        '
        Me.ts_edittestrequest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ts_edittestrequest.Enabled = False
        Me.ts_edittestrequest.Font = New System.Drawing.Font("Trebuchet MS", 8.0!)
        Me.ts_edittestrequest.ForeColor = System.Drawing.Color.ForestGreen
        Me.ts_edittestrequest.Image = CType(resources.GetObject("ts_edittestrequest.Image"), System.Drawing.Image)
        Me.ts_edittestrequest.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_edittestrequest.Name = "ts_edittestrequest"
        Me.ts_edittestrequest.Size = New System.Drawing.Size(32, 24)
        Me.ts_edittestrequest.Text = "Edit"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ts_deletetestrequest
        '
        Me.ts_deletetestrequest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ts_deletetestrequest.Enabled = False
        Me.ts_deletetestrequest.Font = New System.Drawing.Font("Trebuchet MS", 8.0!)
        Me.ts_deletetestrequest.ForeColor = System.Drawing.Color.ForestGreen
        Me.ts_deletetestrequest.Image = CType(resources.GetObject("ts_deletetestrequest.Image"), System.Drawing.Image)
        Me.ts_deletetestrequest.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_deletetestrequest.Name = "ts_deletetestrequest"
        Me.ts_deletetestrequest.Size = New System.Drawing.Size(44, 24)
        Me.ts_deletetestrequest.Text = "Delete"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'tsprinttestrequest
        '
        Me.tsprinttestrequest.Enabled = False
        Me.tsprinttestrequest.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsprinttestrequest.ForeColor = System.Drawing.Color.Green
        Me.tsprinttestrequest.Image = Global.HISReports.My.Resources.Resources.printer
        Me.tsprinttestrequest.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsprinttestrequest.Name = "tsprinttestrequest"
        Me.tsprinttestrequest.Size = New System.Drawing.Size(49, 24)
        Me.tsprinttestrequest.Text = "Print"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Green
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(217, 24)
        Me.ToolStripLabel2.Text = " Laboratory && Radiology Request"
        '
        'dvgListOfPrescribedMedicines
        '
        Me.dvgListOfPrescribedMedicines.AllowUserToAddRows = False
        Me.dvgListOfPrescribedMedicines.AllowUserToDeleteRows = False
        Me.dvgListOfPrescribedMedicines.AllowUserToResizeColumns = False
        Me.dvgListOfPrescribedMedicines.AllowUserToResizeRows = False
        Me.dvgListOfPrescribedMedicines.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dvgListOfPrescribedMedicines.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dvgListOfPrescribedMedicines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dvgListOfPrescribedMedicines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dvgListOfPrescribedMedicines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dvgListOfPrescribedMedicines.ColumnHeadersHeight = 28
        Me.dvgListOfPrescribedMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dvgListOfPrescribedMedicines.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colprescriptionid, Me.colprescriptiondescription, Me.colispostrequest})
        Me.dvgListOfPrescribedMedicines.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgListOfPrescribedMedicines.DefaultCellStyle = DataGridViewCellStyle1
        Me.dvgListOfPrescribedMedicines.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dvgListOfPrescribedMedicines.Location = New System.Drawing.Point(11, 169)
        Me.dvgListOfPrescribedMedicines.MultiSelect = False
        Me.dvgListOfPrescribedMedicines.Name = "dvgListOfPrescribedMedicines"
        Me.dvgListOfPrescribedMedicines.RowHeadersVisible = False
        Me.dvgListOfPrescribedMedicines.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgListOfPrescribedMedicines.RowTemplate.Height = 40
        Me.dvgListOfPrescribedMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgListOfPrescribedMedicines.Size = New System.Drawing.Size(561, 433)
        Me.dvgListOfPrescribedMedicines.TabIndex = 263
        '
        'colprescriptionid
        '
        Me.colprescriptionid.HeaderText = "colprescriptionid"
        Me.colprescriptionid.Name = "colprescriptionid"
        Me.colprescriptionid.Visible = False
        '
        'colprescriptiondescription
        '
        Me.colprescriptiondescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colprescriptiondescription.HeaderText = "Rx Details"
        Me.colprescriptiondescription.Name = "colprescriptiondescription"
        Me.colprescriptiondescription.ReadOnly = True
        '
        'colispostrequest
        '
        Me.colispostrequest.HeaderText = "Is Post Request?"
        Me.colispostrequest.Name = "colispostrequest"
        Me.colispostrequest.ReadOnly = True
        '
        'dgvTestRequest
        '
        Me.dgvTestRequest.AllowUserToAddRows = False
        Me.dgvTestRequest.AllowUserToDeleteRows = False
        Me.dgvTestRequest.AllowUserToResizeColumns = False
        Me.dgvTestRequest.AllowUserToResizeRows = False
        Me.dgvTestRequest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTestRequest.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvTestRequest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTestRequest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgvTestRequest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTestRequest.ColumnHeadersHeight = 28
        Me.dgvTestRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTestRequest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coltestrequestid, Me.coltestrequestdetails, Me.coldestinationoffice, Me.colispostrequesttest})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTestRequest.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTestRequest.Location = New System.Drawing.Point(589, 169)
        Me.dgvTestRequest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvTestRequest.Name = "dgvTestRequest"
        Me.dgvTestRequest.RowHeadersVisible = False
        Me.dgvTestRequest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTestRequest.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTestRequest.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTestRequest.RowTemplate.Height = 30
        Me.dgvTestRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTestRequest.Size = New System.Drawing.Size(561, 433)
        Me.dgvTestRequest.TabIndex = 264
        '
        'coltestrequestid
        '
        Me.coltestrequestid.HeaderText = "coltestrequestid"
        Me.coltestrequestid.Name = "coltestrequestid"
        Me.coltestrequestid.Visible = False
        '
        'coltestrequestdetails
        '
        Me.coltestrequestdetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coltestrequestdetails.HeaderText = "Test Request Details"
        Me.coltestrequestdetails.Name = "coltestrequestdetails"
        Me.coltestrequestdetails.ReadOnly = True
        '
        'coldestinationoffice
        '
        Me.coldestinationoffice.HeaderText = "coldestinationoffice"
        Me.coldestinationoffice.Name = "coldestinationoffice"
        Me.coldestinationoffice.Visible = False
        '
        'colispostrequesttest
        '
        Me.colispostrequesttest.HeaderText = "Is Post Request?"
        Me.colispostrequesttest.Name = "colispostrequesttest"
        Me.colispostrequesttest.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "colprescriptionid"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "Rx Details"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "coltestrequestid"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.HeaderText = "Test Request Details"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "coldestinationoffice"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'frmPrescriptionList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 627)
        Me.Controls.Add(Me.dgvTestRequest)
        Me.Controls.Add(Me.dvgListOfPrescribedMedicines)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPrescriptionList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prescription & Test Request"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dvgListOfPrescribedMedicines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTestRequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lblDateAdmitted As System.Windows.Forms.Label
    Friend WithEvents lblPatientNo As System.Windows.Forms.Label
    Friend WithEvents lblage As System.Windows.Forms.Label
    Friend WithEvents Label303 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents lblPno As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lblBirthDate As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ts_newrx As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_editrx As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_deleterx As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsPrintPrescription As System.Windows.Forms.ToolStripButton
    Public WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ts_newtestrequest As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_edittestrequest As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_deletetestrequest As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsprinttestrequest As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Public WithEvents dvgListOfPrescribedMedicines As System.Windows.Forms.DataGridView
    Friend WithEvents dgvTestRequest As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tspreprintedprescription As System.Windows.Forms.ToolStripButton
    Friend WithEvents colprescriptionid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colprescriptiondescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colispostrequest As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents coltestrequestid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltestrequestdetails As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldestinationoffice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colispostrequesttest As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
