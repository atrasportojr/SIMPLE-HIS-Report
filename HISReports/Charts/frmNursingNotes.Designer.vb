<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNursingNotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNursingNotes))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsClose = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.btnAddNote = New System.Windows.Forms.Button()
        Me.dgvNotes = New System.Windows.Forms.DataGridView()
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
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvNotes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStrip1.Size = New System.Drawing.Size(1161, 37)
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
        Me.StatusStrip1.Size = New System.Drawing.Size(1161, 22)
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
        Me.btnAddNote.Location = New System.Drawing.Point(1014, 166)
        Me.btnAddNote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddNote.Name = "btnAddNote"
        Me.btnAddNote.Size = New System.Drawing.Size(135, 33)
        Me.btnAddNote.TabIndex = 249
        Me.btnAddNote.Text = "Add Note"
        Me.btnAddNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddNote.UseVisualStyleBackColor = False
        '
        'dgvNotes
        '
        Me.dgvNotes.AllowUserToAddRows = False
        Me.dgvNotes.AllowUserToDeleteRows = False
        Me.dgvNotes.AllowUserToResizeColumns = False
        Me.dgvNotes.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNotes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvNotes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNotes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvNotes.ColumnHeadersHeight = 28
        Me.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvNotes.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvNotes.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvNotes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvNotes.Location = New System.Drawing.Point(12, 206)
        Me.dgvNotes.MultiSelect = False
        Me.dgvNotes.Name = "dgvNotes"
        Me.dgvNotes.RowHeadersWidth = 20
        Me.dgvNotes.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNotes.RowTemplate.Height = 48
        Me.dgvNotes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvNotes.Size = New System.Drawing.Size(1137, 420)
        Me.dgvNotes.TabIndex = 184
        '
        'lblAdmissionType
        '
        Me.lblAdmissionType.BackColor = System.Drawing.Color.Transparent
        Me.lblAdmissionType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblAdmissionType.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmissionType.ForeColor = System.Drawing.Color.Red
        Me.lblAdmissionType.Location = New System.Drawing.Point(12, 166)
        Me.lblAdmissionType.Name = "lblAdmissionType"
        Me.lblAdmissionType.Size = New System.Drawing.Size(209, 37)
        Me.lblAdmissionType.TabIndex = 252
        Me.lblAdmissionType.Text = "NURSING NOTES"
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
        'frmNursingNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 671)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblAdmissionType)
        Me.Controls.Add(Me.btnAddNote)
        Me.Controls.Add(Me.dgvNotes)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmNursingNotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nursing Notes"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvNotes, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvNotes As System.Windows.Forms.DataGridView
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
End Class
