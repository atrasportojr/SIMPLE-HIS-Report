<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgressNotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProgressNotes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsprintoptions = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PrintAsProgressNotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintAsCF4AttachmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsNursingnotes = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsClose = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblAdmissionType = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvCourseWard = New System.Windows.Forms.DataGridView()
        Me.dgvnotes = New System.Windows.Forms.DataGridView()
        Me.colremove = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colprogressdate = New HISReports.CalendarColumn()
        Me.colprogress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmedicalorder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colc = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cola = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colr = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cole = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cold = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colcreatedby = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colencodedbyid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colprescriptionid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltestrequestid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coledit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colisedit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddTest = New System.Windows.Forms.Button()
        Me.btnAddPrescription = New System.Windows.Forms.Button()
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.btnAddNote = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvCourseWard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvnotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.ToolStripSeparator1, Me.tsprintoptions, Me.ToolStripSeparator3, Me.tsNursingnotes, Me.ToolStripSeparator2, Me.tsClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1261, 37)
        Me.ToolStrip1.TabIndex = 56
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsSave
        '
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(37, 34)
        Me.tsSave.Text = "Save"
        Me.tsSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
        '
        'tsprintoptions
        '
        Me.tsprintoptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintAsProgressNotesToolStripMenuItem, Me.PrintAsCF4AttachmentToolStripMenuItem})
        Me.tsprintoptions.Image = Global.HISReports.My.Resources.Resources.printer
        Me.tsprintoptions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsprintoptions.Name = "tsprintoptions"
        Me.tsprintoptions.Size = New System.Drawing.Size(45, 34)
        Me.tsprintoptions.Text = "Print"
        Me.tsprintoptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PrintAsProgressNotesToolStripMenuItem
        '
        Me.PrintAsProgressNotesToolStripMenuItem.Image = Global.HISReports.My.Resources.Resources.printer
        Me.PrintAsProgressNotesToolStripMenuItem.Name = "PrintAsProgressNotesToolStripMenuItem"
        Me.PrintAsProgressNotesToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.PrintAsProgressNotesToolStripMenuItem.Text = "Print as Progress Notes"
        '
        'PrintAsCF4AttachmentToolStripMenuItem
        '
        Me.PrintAsCF4AttachmentToolStripMenuItem.Image = Global.HISReports.My.Resources.Resources.printer
        Me.PrintAsCF4AttachmentToolStripMenuItem.Name = "PrintAsCF4AttachmentToolStripMenuItem"
        Me.PrintAsCF4AttachmentToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.PrintAsCF4AttachmentToolStripMenuItem.Text = "Print as CF4 Attachment"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 37)
        '
        'tsNursingnotes
        '
        Me.tsNursingnotes.Image = Global.HISReports.My.Resources.Resources.application_edit
        Me.tsNursingnotes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsNursingnotes.Name = "tsNursingnotes"
        Me.tsNursingnotes.Size = New System.Drawing.Size(87, 34)
        Me.tsNursingnotes.Text = "Nursing Notes"
        Me.tsNursingnotes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 37)
        '
        'tsClose
        '
        Me.tsClose.Image = CType(resources.GetObject("tsClose.Image"), System.Drawing.Image)
        Me.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsClose.Name = "tsClose"
        Me.tsClose.Size = New System.Drawing.Size(39, 34)
        Me.tsClose.Text = "Close"
        Me.tsClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Location = New System.Drawing.Point(-2, 31)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1164, 10)
        Me.GroupBox5.TabIndex = 180
        Me.GroupBox5.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 661)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1261, 22)
        Me.StatusStrip1.TabIndex = 183
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblAdmissionType
        '
        Me.lblAdmissionType.BackColor = System.Drawing.Color.Transparent
        Me.lblAdmissionType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblAdmissionType.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmissionType.ForeColor = System.Drawing.Color.Red
        Me.lblAdmissionType.Location = New System.Drawing.Point(12, 129)
        Me.lblAdmissionType.Name = "lblAdmissionType"
        Me.lblAdmissionType.Size = New System.Drawing.Size(300, 37)
        Me.lblAdmissionType.TabIndex = 251
        Me.lblAdmissionType.Text = "Doctor's Order"
        Me.lblAdmissionType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(7, 408)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 37)
        Me.Label1.TabIndex = 252
        Me.Label1.Text = "COURSE IN THE WARD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Panel1.Location = New System.Drawing.Point(17, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1231, 90)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(166, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(501, 14)
        Me.Label2.TabIndex = 256
        Me.Label2.Text = "Legend:    C- Carried    A- Administered    R- Requested    E- Endorsed    D- Dis" & _
    "continued "
        '
        'dgvCourseWard
        '
        Me.dgvCourseWard.AllowUserToAddRows = False
        Me.dgvCourseWard.AllowUserToDeleteRows = False
        Me.dgvCourseWard.AllowUserToResizeColumns = False
        Me.dgvCourseWard.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourseWard.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCourseWard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvCourseWard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourseWard.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCourseWard.ColumnHeadersHeight = 28
        Me.dgvCourseWard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCourseWard.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourseWard.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCourseWard.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvCourseWard.Location = New System.Drawing.Point(12, 448)
        Me.dgvCourseWard.MultiSelect = False
        Me.dgvCourseWard.Name = "dgvCourseWard"
        Me.dgvCourseWard.RowHeadersWidth = 20
        Me.dgvCourseWard.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourseWard.RowTemplate.Height = 48
        Me.dgvCourseWard.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourseWard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvCourseWard.Size = New System.Drawing.Size(1237, 223)
        Me.dgvCourseWard.TabIndex = 253
        '
        'dgvnotes
        '
        Me.dgvnotes.AllowUserToAddRows = False
        Me.dgvnotes.AllowUserToDeleteRows = False
        Me.dgvnotes.AllowUserToResizeColumns = False
        Me.dgvnotes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvnotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvnotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvnotes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgvnotes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvnotes.ColumnHeadersHeight = 28
        Me.dgvnotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvnotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colremove, Me.colprogressdate, Me.colprogress, Me.colmedicalorder, Me.colc, Me.cola, Me.colr, Me.cole, Me.cold, Me.colcreatedby, Me.colencodedbyid, Me.colid, Me.colprescriptionid, Me.coltestrequestid, Me.coledit, Me.colisedit})
        Me.dgvnotes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvnotes.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvnotes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvnotes.Location = New System.Drawing.Point(11, 169)
        Me.dgvnotes.MultiSelect = False
        Me.dgvnotes.Name = "dgvnotes"
        Me.dgvnotes.RowHeadersVisible = False
        Me.dgvnotes.RowHeadersWidth = 20
        Me.dgvnotes.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvnotes.RowTemplate.Height = 48
        Me.dgvnotes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvnotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvnotes.Size = New System.Drawing.Size(1237, 225)
        Me.dgvnotes.TabIndex = 184
        '
        'colremove
        '
        Me.colremove.HeaderText = ""
        Me.colremove.Name = "colremove"
        Me.colremove.Width = 30
        '
        'colprogressdate
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colprogressdate.DefaultCellStyle = DataGridViewCellStyle4
        Me.colprogressdate.HeaderText = "Progress Date"
        Me.colprogressdate.Name = "colprogressdate"
        Me.colprogressdate.Width = 160
        '
        'colprogress
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colprogress.DefaultCellStyle = DataGridViewCellStyle5
        Me.colprogress.HeaderText = "Progress Notes"
        Me.colprogress.Name = "colprogress"
        Me.colprogress.Width = 250
        '
        'colmedicalorder
        '
        Me.colmedicalorder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colmedicalorder.DefaultCellStyle = DataGridViewCellStyle6
        Me.colmedicalorder.HeaderText = "Doctor's Order"
        Me.colmedicalorder.Name = "colmedicalorder"
        '
        'colc
        '
        Me.colc.HeaderText = "C"
        Me.colc.Name = "colc"
        Me.colc.Width = 30
        '
        'cola
        '
        Me.cola.HeaderText = "A"
        Me.cola.Name = "cola"
        Me.cola.Width = 30
        '
        'colr
        '
        Me.colr.HeaderText = "R"
        Me.colr.Name = "colr"
        Me.colr.Width = 30
        '
        'cole
        '
        Me.cole.HeaderText = "E"
        Me.cole.Name = "cole"
        Me.cole.Width = 30
        '
        'cold
        '
        Me.cold.HeaderText = "D"
        Me.cold.Name = "cold"
        Me.cold.Width = 30
        '
        'colcreatedby
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colcreatedby.DefaultCellStyle = DataGridViewCellStyle7
        Me.colcreatedby.HeaderText = "Encoded By"
        Me.colcreatedby.Name = "colcreatedby"
        Me.colcreatedby.Width = 120
        '
        'colencodedbyid
        '
        Me.colencodedbyid.HeaderText = "colencodedbyid"
        Me.colencodedbyid.Name = "colencodedbyid"
        Me.colencodedbyid.Visible = False
        '
        'colid
        '
        Me.colid.HeaderText = "colid"
        Me.colid.Name = "colid"
        Me.colid.Visible = False
        '
        'colprescriptionid
        '
        Me.colprescriptionid.HeaderText = "colprescriptionid"
        Me.colprescriptionid.Name = "colprescriptionid"
        Me.colprescriptionid.Visible = False
        '
        'coltestrequestid
        '
        Me.coltestrequestid.HeaderText = "coltestrequestid"
        Me.coltestrequestid.Name = "coltestrequestid"
        Me.coltestrequestid.Visible = False
        '
        'coledit
        '
        Me.coledit.HeaderText = ""
        Me.coledit.Name = "coledit"
        Me.coledit.Width = 35
        '
        'colisedit
        '
        Me.colisedit.HeaderText = "colisedit"
        Me.colisedit.Name = "colisedit"
        Me.colisedit.Visible = False
        '
        'btnAddTest
        '
        Me.btnAddTest.BackColor = System.Drawing.Color.White
        Me.btnAddTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddTest.FlatAppearance.BorderSize = 0
        Me.btnAddTest.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddTest.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTest.ForeColor = System.Drawing.Color.Black
        Me.btnAddTest.Image = Global.HISReports.My.Resources.Resources.add_16
        Me.btnAddTest.Location = New System.Drawing.Point(1138, 137)
        Me.btnAddTest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddTest.Name = "btnAddTest"
        Me.btnAddTest.Size = New System.Drawing.Size(110, 29)
        Me.btnAddTest.TabIndex = 258
        Me.btnAddTest.Text = "Add Test"
        Me.btnAddTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddTest.UseVisualStyleBackColor = False
        '
        'btnAddPrescription
        '
        Me.btnAddPrescription.BackColor = System.Drawing.Color.White
        Me.btnAddPrescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddPrescription.FlatAppearance.BorderSize = 0
        Me.btnAddPrescription.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddPrescription.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPrescription.ForeColor = System.Drawing.Color.Black
        Me.btnAddPrescription.Image = Global.HISReports.My.Resources.Resources.add_16
        Me.btnAddPrescription.Location = New System.Drawing.Point(1004, 136)
        Me.btnAddPrescription.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddPrescription.Name = "btnAddPrescription"
        Me.btnAddPrescription.Size = New System.Drawing.Size(131, 29)
        Me.btnAddPrescription.TabIndex = 257
        Me.btnAddPrescription.Text = "Add Prescription"
        Me.btnAddPrescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddPrescription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddPrescription.UseVisualStyleBackColor = False
        '
        'btnAddCourse
        '
        Me.btnAddCourse.BackColor = System.Drawing.Color.White
        Me.btnAddCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddCourse.FlatAppearance.BorderSize = 0
        Me.btnAddCourse.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddCourse.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCourse.ForeColor = System.Drawing.Color.Black
        Me.btnAddCourse.Image = Global.HISReports.My.Resources.Resources.add_16
        Me.btnAddCourse.Location = New System.Drawing.Point(1117, 416)
        Me.btnAddCourse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(131, 29)
        Me.btnAddCourse.TabIndex = 254
        Me.btnAddCourse.Text = "Add New"
        Me.btnAddCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddCourse.UseVisualStyleBackColor = False
        '
        'btnAddNote
        '
        Me.btnAddNote.BackColor = System.Drawing.Color.White
        Me.btnAddNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddNote.FlatAppearance.BorderSize = 0
        Me.btnAddNote.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddNote.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNote.ForeColor = System.Drawing.Color.Black
        Me.btnAddNote.Image = Global.HISReports.My.Resources.Resources.add_16
        Me.btnAddNote.Location = New System.Drawing.Point(899, 136)
        Me.btnAddNote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddNote.Name = "btnAddNote"
        Me.btnAddNote.Size = New System.Drawing.Size(102, 29)
        Me.btnAddNote.TabIndex = 249
        Me.btnAddNote.Text = "Add New"
        Me.btnAddNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddNote.UseVisualStyleBackColor = False
        '
        'frmProgressNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1261, 683)
        Me.Controls.Add(Me.btnAddTest)
        Me.Controls.Add(Me.btnAddPrescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAddCourse)
        Me.Controls.Add(Me.dgvCourseWard)
        Me.Controls.Add(Me.dgvnotes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAdmissionType)
        Me.Controls.Add(Me.btnAddNote)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmProgressNotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Course in the Wards"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvCourseWard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvnotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Public WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Public WithEvents tsClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents btnAddNote As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblAdmissionType As System.Windows.Forms.Label
    Friend WithEvents tsprintoptions As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents PrintAsProgressNotesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintAsCF4AttachmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvCourseWard As DataGridView
    Friend WithEvents dgvnotes As DataGridView
    Friend WithEvents btnAddCourse As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents tsNursingnotes As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddPrescription As System.Windows.Forms.Button
    Friend WithEvents btnAddTest As System.Windows.Forms.Button
    Friend WithEvents colremove As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colprogressdate As HISReports.CalendarColumn
    Friend WithEvents colprogress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colmedicalorder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colc As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cola As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colr As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cole As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cold As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colcreatedby As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colencodedbyid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colprescriptionid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltestrequestid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coledit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colisedit As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
