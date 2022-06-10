<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHCI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHCI))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.closetoolstrip = New System.Windows.Forms.ToolStripButton()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txthciname = New System.Windows.Forms.TextBox()
        Me.txthcicode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txthouseno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbarangay = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcitymunicipality = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtprovince = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkIsactive = New System.Windows.Forms.CheckBox()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 403)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(384, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.ToolStripSeparator2, Me.closetoolstrip})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(384, 38)
        Me.ToolStrip2.TabIndex = 214
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
        'closetoolstrip
        '
        Me.closetoolstrip.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.closetoolstrip.ForeColor = System.Drawing.Color.Black
        Me.closetoolstrip.Image = Global.HISReports.My.Resources.delete_16x16
        Me.closetoolstrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.closetoolstrip.Name = "closetoolstrip"
        Me.closetoolstrip.Size = New System.Drawing.Size(44, 35)
        Me.closetoolstrip.Text = "Close"
        Me.closetoolstrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 27
        Me.LineShape3.X2 = 356
        Me.LineShape3.Y1 = 53
        Me.LineShape3.Y2 = 53
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(384, 425)
        Me.ShapeContainer1.TabIndex = 215
        Me.ShapeContainer1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 237
        Me.Label7.Text = "HCI Name"
        '
        'txthciname
        '
        Me.txthciname.Location = New System.Drawing.Point(27, 130)
        Me.txthciname.MaxLength = 250
        Me.txthciname.Name = "txthciname"
        Me.txthciname.Size = New System.Drawing.Size(331, 21)
        Me.txthciname.TabIndex = 2
        '
        'txthcicode
        '
        Me.txthcicode.Location = New System.Drawing.Point(27, 81)
        Me.txthcicode.MaxLength = 30
        Me.txthcicode.Name = "txthcicode"
        Me.txthcicode.Size = New System.Drawing.Size(331, 21)
        Me.txthcicode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 248
        Me.Label1.Text = "HCI Code"
        '
        'txthouseno
        '
        Me.txthouseno.Location = New System.Drawing.Point(27, 176)
        Me.txthouseno.MaxLength = 250
        Me.txthouseno.Name = "txthouseno"
        Me.txthouseno.Size = New System.Drawing.Size(331, 21)
        Me.txthouseno.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 13)
        Me.Label2.TabIndex = 250
        Me.Label2.Text = "Building/House #/Street"
        '
        'txtbarangay
        '
        Me.txtbarangay.Location = New System.Drawing.Point(27, 221)
        Me.txtbarangay.MaxLength = 100
        Me.txtbarangay.Name = "txtbarangay"
        Me.txtbarangay.Size = New System.Drawing.Size(331, 21)
        Me.txtbarangay.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 252
        Me.Label3.Text = "Barangay"
        '
        'txtcitymunicipality
        '
        Me.txtcitymunicipality.Location = New System.Drawing.Point(26, 268)
        Me.txtcitymunicipality.MaxLength = 100
        Me.txtcitymunicipality.Name = "txtcitymunicipality"
        Me.txtcitymunicipality.Size = New System.Drawing.Size(331, 21)
        Me.txtcitymunicipality.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 254
        Me.Label4.Text = "City/Municipality"
        '
        'txtprovince
        '
        Me.txtprovince.Location = New System.Drawing.Point(27, 314)
        Me.txtprovince.MaxLength = 100
        Me.txtprovince.Name = "txtprovince"
        Me.txtprovince.Size = New System.Drawing.Size(331, 21)
        Me.txtprovince.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 256
        Me.Label5.Text = "Province"
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(27, 359)
        Me.txtZipCode.MaxLength = 10
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(331, 21)
        Me.txtZipCode.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 343)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 260
        Me.Label8.Text = "Zip Code"
        '
        'chkIsactive
        '
        Me.chkIsactive.AutoSize = True
        Me.chkIsactive.Checked = True
        Me.chkIsactive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIsactive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkIsactive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsactive.Location = New System.Drawing.Point(297, 64)
        Me.chkIsactive.Name = "chkIsactive"
        Me.chkIsactive.Size = New System.Drawing.Size(68, 17)
        Me.chkIsactive.TabIndex = 263
        Me.chkIsactive.Text = "Is Active"
        Me.chkIsactive.UseVisualStyleBackColor = True
        '
        'frmHCI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 425)
        Me.Controls.Add(Me.chkIsactive)
        Me.Controls.Add(Me.txtZipCode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtprovince)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcitymunicipality)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtbarangay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txthouseno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txthcicode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txthciname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHCI"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Public WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Public WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents closetoolstrip As System.Windows.Forms.ToolStripButton
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txthciname As System.Windows.Forms.TextBox
    Friend WithEvents txthcicode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txthouseno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbarangay As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcitymunicipality As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtprovince As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkIsactive As System.Windows.Forms.CheckBox
End Class
