<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCategoryDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbCategoryType = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.tsCancel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsClose = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkISDiscountable = New System.Windows.Forms.CheckBox()
        Me.chkIsactive = New System.Windows.Forms.CheckBox()
        Me.txtMemo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkIsvatable = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Item Category Description:"
        '
        'txtCategoryDescription
        '
        Me.txtCategoryDescription.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoryDescription.Location = New System.Drawing.Point(151, 71)
        Me.txtCategoryDescription.Multiline = True
        Me.txtCategoryDescription.Name = "txtCategoryDescription"
        Me.txtCategoryDescription.Size = New System.Drawing.Size(344, 47)
        Me.txtCategoryDescription.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Item Category Type:"
        '
        'cmbCategoryType
        '
        Me.cmbCategoryType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbCategoryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoryType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategoryType.FormattingEnabled = True
        Me.cmbCategoryType.Location = New System.Drawing.Point(151, 125)
        Me.cmbCategoryType.Name = "cmbCategoryType"
        Me.cmbCategoryType.Size = New System.Drawing.Size(344, 21)
        Me.cmbCategoryType.TabIndex = 46
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.tsCancel, Me.ToolStripSeparator1, Me.tsClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(510, 25)
        Me.ToolStrip1.TabIndex = 48
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsSave
        '
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(37, 22)
        Me.tsSave.Text = "Save"
        Me.tsSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsCancel
        '
        Me.tsCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCancel.Name = "tsCancel"
        Me.tsCancel.Size = New System.Drawing.Size(46, 22)
        Me.tsCancel.Text = "Cancel"
        Me.tsCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsClose
        '
        Me.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsClose.Name = "tsClose"
        Me.tsClose.Size = New System.Drawing.Size(39, 22)
        Me.tsClose.Text = "Close"
        Me.tsClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 187)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(510, 22)
        Me.StatusStrip1.TabIndex = 178
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(-5, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 2)
        Me.GroupBox1.TabIndex = 179
        Me.GroupBox1.TabStop = False
        '
        'chkISDiscountable
        '
        Me.chkISDiscountable.AutoSize = True
        Me.chkISDiscountable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkISDiscountable.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkISDiscountable.Location = New System.Drawing.Point(378, 127)
        Me.chkISDiscountable.Name = "chkISDiscountable"
        Me.chkISDiscountable.Size = New System.Drawing.Size(99, 17)
        Me.chkISDiscountable.TabIndex = 180
        Me.chkISDiscountable.Text = "Is Discountable"
        Me.chkISDiscountable.UseVisualStyleBackColor = True
        Me.chkISDiscountable.Visible = False
        '
        'chkIsactive
        '
        Me.chkIsactive.AutoSize = True
        Me.chkIsactive.Checked = True
        Me.chkIsactive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIsactive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkIsactive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsactive.Location = New System.Drawing.Point(427, 48)
        Me.chkIsactive.Name = "chkIsactive"
        Me.chkIsactive.Size = New System.Drawing.Size(68, 17)
        Me.chkIsactive.TabIndex = 181
        Me.chkIsactive.Text = "Is Active"
        Me.chkIsactive.UseVisualStyleBackColor = True
        '
        'txtMemo
        '
        Me.txtMemo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemo.Location = New System.Drawing.Point(151, 150)
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(344, 21)
        Me.txtMemo.TabIndex = 182
        Me.txtMemo.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 183
        Me.Label2.Text = "Memo:"
        Me.Label2.Visible = False
        '
        'chkIsvatable
        '
        Me.chkIsvatable.AutoSize = True
        Me.chkIsvatable.Checked = True
        Me.chkIsvatable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIsvatable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkIsvatable.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsvatable.Location = New System.Drawing.Point(298, 127)
        Me.chkIsvatable.Name = "chkIsvatable"
        Me.chkIsvatable.Size = New System.Drawing.Size(74, 17)
        Me.chkIsvatable.TabIndex = 184
        Me.chkIsvatable.Text = "Is Vatable"
        Me.chkIsvatable.UseVisualStyleBackColor = True
        Me.chkIsvatable.Visible = False
        '
        'frmCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 209)
        Me.Controls.Add(Me.chkIsvatable)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMemo)
        Me.Controls.Add(Me.chkIsactive)
        Me.Controls.Add(Me.chkISDiscountable)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtCategoryDescription)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cmbCategoryType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Category"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCategoryDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbCategoryType As System.Windows.Forms.ComboBox
    Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Public WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Public WithEvents tsCancel As System.Windows.Forms.ToolStripButton
    Public WithEvents tsClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkISDiscountable As System.Windows.Forms.CheckBox
    Friend WithEvents chkIsactive As System.Windows.Forms.CheckBox
    Friend WithEvents txtMemo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chkIsvatable As System.Windows.Forms.CheckBox
End Class
