<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntravenousFluids
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIntravenousFluids))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsClose = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.btnAddNote = New System.Windows.Forms.Button()
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.colremove = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colbottleno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldatestarted = New HISReports.CalendarColumn()
        Me.colivtype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colnurse1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldrugadditives = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltypecannula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colflowrate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldateend = New HISReports.CalendarColumn()
        Me.colnurse2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colremarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colnurse1id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colnurse2id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblAdmissionType = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPatientNo = New System.Windows.Forms.Label()
        Me.lblage = New System.Windows.Forms.Label()
        Me.Label303 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblPno = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblDateAdmitted = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalendarColumn1 = New HISReports.CalendarColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalendarColumn2 = New HISReports.CalendarColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.ToolStripSeparator1, Me.tsPrint, Me.ToolStripSeparator2, Me.tsClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1335, 37)
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
        'tsPrint
        '
        Me.tsPrint.Image = Global.HISReports.My.Resources.Resources.printer
        Me.tsPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPrint.Name = "tsPrint"
        Me.tsPrint.Size = New System.Drawing.Size(36, 34)
        Me.tsPrint.Text = "Print"
        Me.tsPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.GroupBox5.Location = New System.Drawing.Point(-2, 36)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1000, 2)
        Me.GroupBox5.TabIndex = 180
        Me.GroupBox5.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 649)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1335, 22)
        Me.StatusStrip1.TabIndex = 183
        Me.StatusStrip1.Text = "StatusStrip1"
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
        Me.btnAddNote.Location = New System.Drawing.Point(1208, 170)
        Me.btnAddNote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddNote.Name = "btnAddNote"
        Me.btnAddNote.Size = New System.Drawing.Size(115, 33)
        Me.btnAddNote.TabIndex = 249
        Me.btnAddNote.Text = "Create New"
        Me.btnAddNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddNote.UseVisualStyleBackColor = False
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AllowUserToResizeColumns = False
        Me.dgvMain.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMain.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgvMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colremove, Me.colbottleno, Me.coldatestarted, Me.colivtype, Me.colnurse1, Me.coldrugadditives, Me.coltypecannula, Me.colflowrate, Me.coldateend, Me.colnurse2, Me.colremarks, Me.colid, Me.colnurse1id, Me.colnurse2id})
        Me.dgvMain.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMain.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvMain.Location = New System.Drawing.Point(12, 206)
        Me.dgvMain.MultiSelect = False
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.RowHeadersVisible = False
        Me.dgvMain.RowHeadersWidth = 20
        Me.dgvMain.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvMain.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMain.RowTemplate.Height = 48
        Me.dgvMain.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvMain.Size = New System.Drawing.Size(1311, 420)
        Me.dgvMain.TabIndex = 184
        '
        'colremove
        '
        Me.colremove.HeaderText = ""
        Me.colremove.Name = "colremove"
        Me.colremove.Width = 30
        '
        'colbottleno
        '
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colbottleno.DefaultCellStyle = DataGridViewCellStyle3
        Me.colbottleno.HeaderText = "I.V. Fluid Bottle No."
        Me.colbottleno.Name = "colbottleno"
        Me.colbottleno.Width = 80
        '
        'coldatestarted
        '
        Me.coldatestarted.HeaderText = "Date & Time Started"
        Me.coldatestarted.Name = "coldatestarted"
        Me.coldatestarted.Width = 120
        '
        'colivtype
        '
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colivtype.DefaultCellStyle = DataGridViewCellStyle4
        Me.colivtype.HeaderText = "Type of I.V. Fluid & Volume"
        Me.colivtype.Name = "colivtype"
        Me.colivtype.Width = 140
        '
        'colnurse1
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.colnurse1.DefaultCellStyle = DataGridViewCellStyle5
        Me.colnurse1.HeaderText = "Nurse"
        Me.colnurse1.Name = "colnurse1"
        Me.colnurse1.ReadOnly = True
        Me.colnurse1.Width = 140
        '
        'coldrugadditives
        '
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldrugadditives.DefaultCellStyle = DataGridViewCellStyle6
        Me.coldrugadditives.HeaderText = "Drug Additives"
        Me.coldrugadditives.Name = "coldrugadditives"
        Me.coldrugadditives.Width = 160
        '
        'coltypecannula
        '
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coltypecannula.DefaultCellStyle = DataGridViewCellStyle7
        Me.coltypecannula.HeaderText = "Type of Canulla & Location of Insertion"
        Me.coltypecannula.Name = "coltypecannula"
        Me.coltypecannula.Width = 140
        '
        'colflowrate
        '
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colflowrate.DefaultCellStyle = DataGridViewCellStyle8
        Me.colflowrate.HeaderText = "Flow Rate & Infusion Device"
        Me.colflowrate.Name = "colflowrate"
        Me.colflowrate.Width = 140
        '
        'coldateend
        '
        Me.coldateend.HeaderText = "Date & Time Consumed"
        Me.coldateend.Name = "coldateend"
        Me.coldateend.Width = 120
        '
        'colnurse2
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.colnurse2.DefaultCellStyle = DataGridViewCellStyle9
        Me.colnurse2.HeaderText = "Nurse"
        Me.colnurse2.Name = "colnurse2"
        Me.colnurse2.ReadOnly = True
        Me.colnurse2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colnurse2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colnurse2.Width = 140
        '
        'colremarks
        '
        Me.colremarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colremarks.DefaultCellStyle = DataGridViewCellStyle10
        Me.colremarks.HeaderText = "Remarks"
        Me.colremarks.Name = "colremarks"
        '
        'colid
        '
        Me.colid.HeaderText = "colid"
        Me.colid.Name = "colid"
        Me.colid.Visible = False
        '
        'colnurse1id
        '
        Me.colnurse1id.HeaderText = "colnurse1id"
        Me.colnurse1id.Name = "colnurse1id"
        Me.colnurse1id.Visible = False
        '
        'colnurse2id
        '
        Me.colnurse2id.HeaderText = "colnurse2id"
        Me.colnurse2id.Name = "colnurse2id"
        Me.colnurse2id.Visible = False
        '
        'lblAdmissionType
        '
        Me.lblAdmissionType.BackColor = System.Drawing.Color.Transparent
        Me.lblAdmissionType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblAdmissionType.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmissionType.ForeColor = System.Drawing.Color.Red
        Me.lblAdmissionType.Location = New System.Drawing.Point(12, 166)
        Me.lblAdmissionType.Name = "lblAdmissionType"
        Me.lblAdmissionType.Size = New System.Drawing.Size(392, 37)
        Me.lblAdmissionType.TabIndex = 252
        Me.lblAdmissionType.Text = "INTRAVENOUS FLUID FLOW SHEET"
        Me.lblAdmissionType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.lblPatientNo)
        Me.Panel1.Controls.Add(Me.lblage)
        Me.Panel1.Controls.Add(Me.Label303)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.lblSex)
        Me.Panel1.Controls.Add(Me.lblPno)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.lblBirthDate)
        Me.Panel1.Controls.Add(Me.lblLastName)
        Me.Panel1.Controls.Add(Me.lblDateAdmitted)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(11, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1138, 99)
        Me.Panel1.TabIndex = 253
        '
        'lblPatientNo
        '
        Me.lblPatientNo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPatientNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPatientNo.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.lblPatientNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPatientNo.Location = New System.Drawing.Point(19, 25)
        Me.lblPatientNo.Name = "lblPatientNo"
        Me.lblPatientNo.Size = New System.Drawing.Size(57, 20)
        Me.lblPatientNo.TabIndex = 246
        Me.lblPatientNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblage
        '
        Me.lblage.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblage.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.lblage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblage.Location = New System.Drawing.Point(447, 66)
        Me.lblage.Name = "lblage"
        Me.lblage.Size = New System.Drawing.Size(66, 20)
        Me.lblage.TabIndex = 245
        Me.lblage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label303
        '
        Me.Label303.AutoSize = True
        Me.Label303.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label303.Location = New System.Drawing.Point(445, 52)
        Me.Label303.Name = "Label303"
        Me.Label303.Size = New System.Drawing.Size(30, 13)
        Me.Label303.TabIndex = 244
        Me.Label303.Text = "Age:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label30.Location = New System.Drawing.Point(290, 52)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(59, 13)
        Me.Label30.TabIndex = 226
        Me.Label30.Text = "Birth Date:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label29.Location = New System.Drawing.Point(80, 11)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(45, 13)
        Me.Label29.TabIndex = 227
        Me.Label29.Text = "Patient:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label28.Location = New System.Drawing.Point(18, 50)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 13)
        Me.Label28.TabIndex = 228
        Me.Label28.Text = "Date Admitted:"
        '
        'lblSex
        '
        Me.lblSex.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSex.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.lblSex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSex.Location = New System.Drawing.Point(148, 66)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(141, 20)
        Me.lblSex.TabIndex = 240
        Me.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPno
        '
        Me.lblPno.AutoSize = True
        Me.lblPno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPno.Location = New System.Drawing.Point(16, 11)
        Me.lblPno.Name = "lblPno"
        Me.lblPno.Size = New System.Drawing.Size(65, 13)
        Me.lblPno.TabIndex = 231
        Me.lblPno.Text = "Patient No.:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label26.Location = New System.Drawing.Point(147, 52)
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
        Me.lblBirthDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBirthDate.Location = New System.Drawing.Point(293, 66)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(150, 20)
        Me.lblBirthDate.TabIndex = 237
        Me.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLastName
        '
        Me.lblLastName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLastName.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.lblLastName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLastName.Location = New System.Drawing.Point(82, 25)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(431, 20)
        Me.lblLastName.TabIndex = 234
        Me.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDateAdmitted
        '
        Me.lblDateAdmitted.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblDateAdmitted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateAdmitted.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.lblDateAdmitted.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDateAdmitted.Location = New System.Drawing.Point(19, 66)
        Me.lblDateAdmitted.Name = "lblDateAdmitted"
        Me.lblDateAdmitted.Size = New System.Drawing.Size(123, 20)
        Me.lblDateAdmitted.TabIndex = 235
        Me.lblDateAdmitted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "I.V. Fluid Bottle No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'CalendarColumn1
        '
        Me.CalendarColumn1.HeaderText = "Date & Time Started"
        Me.CalendarColumn1.Name = "CalendarColumn1"
        Me.CalendarColumn1.Width = 120
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Type of I.V. Fluid & Volume"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 140
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Gainsboro
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nurse"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 140
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Drug Additives"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 160
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Type of Canulla & Location of Insertion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 140
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Flow Rate & Infusion Device"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 140
        '
        'CalendarColumn2
        '
        Me.CalendarColumn2.HeaderText = "Date & Time Consumed"
        Me.CalendarColumn2.Name = "CalendarColumn2"
        Me.CalendarColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn7
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Gainsboro
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nurse"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn7.Width = 140
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "colid"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "colnurse1id"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "colnurse2id"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'frmIntravenousFluids
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1335, 671)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblAdmissionType)
        Me.Controls.Add(Me.btnAddNote)
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmIntravenousFluids"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Intravernous Fluid Flow Sheet"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents dgvMain As System.Windows.Forms.DataGridView
    Public WithEvents tsPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblAdmissionType As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblPatientNo As System.Windows.Forms.Label
    Friend WithEvents lblage As System.Windows.Forms.Label
    Friend WithEvents Label303 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents lblPno As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lblBirthDate As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblDateAdmitted As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalendarColumn1 As HISReports.CalendarColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalendarColumn2 As HISReports.CalendarColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colremove As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colbottleno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldatestarted As HISReports.CalendarColumn
    Friend WithEvents colivtype As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colnurse1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldrugadditives As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltypecannula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colflowrate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldateend As HISReports.CalendarColumn
    Friend WithEvents colnurse2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colremarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colnurse1id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colnurse2id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
