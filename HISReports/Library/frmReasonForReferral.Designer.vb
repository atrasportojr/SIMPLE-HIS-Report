<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReasonForReferral
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
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.txtMemo = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsSaved = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsCancels = New System.Windows.Forms.ToolStripButton()
        Me.tsClosed = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Checked = True
        Me.chkActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActive.Location = New System.Drawing.Point(256, 58)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(77, 18)
        Me.chkActive.TabIndex = 255
        Me.chkActive.Text = "is Active?"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'txtMemo
        '
        Me.txtMemo.Location = New System.Drawing.Point(137, 116)
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(192, 21)
        Me.txtMemo.TabIndex = 254
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(137, 87)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(192, 21)
        Me.txtDescription.TabIndex = 253
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 14)
        Me.Label2.TabIndex = 252
        Me.Label2.Text = "Memo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 14)
        Me.Label1.TabIndex = 251
        Me.Label1.Text = "Reason Description:"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSaved, Me.ToolStripSeparator1, Me.tsCancels, Me.tsClosed})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(353, 25)
        Me.ToolStrip2.TabIndex = 250
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsSaved
        '
        Me.tsSaved.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSaved.Name = "tsSaved"
        Me.tsSaved.Size = New System.Drawing.Size(38, 22)
        Me.tsSaved.Text = "Save"
        Me.tsSaved.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsCancels
        '
        Me.tsCancels.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCancels.Name = "tsCancels"
        Me.tsCancels.Size = New System.Drawing.Size(49, 22)
        Me.tsCancels.Text = "Cancel"
        Me.tsCancels.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsCancels.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsCancels.Visible = False
        '
        'tsClosed
        '
        Me.tsClosed.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsClosed.Name = "tsClosed"
        Me.tsClosed.Size = New System.Drawing.Size(42, 22)
        Me.tsClosed.Text = "Close"
        Me.tsClosed.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsClosed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Location = New System.Drawing.Point(0, 31)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(363, 10)
        Me.GroupBox7.TabIndex = 256
        Me.GroupBox7.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 153)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(353, 22)
        Me.StatusStrip1.TabIndex = 257
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'frmReferralReason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 175)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.txtMemo)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.Name = "frmReferralReason"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Referral Reason"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents txtMemo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Public WithEvents tsSaved As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents tsCancels As System.Windows.Forms.ToolStripButton
    Public WithEvents tsClosed As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
End Class
