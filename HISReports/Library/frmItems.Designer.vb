<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItems))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEstUnitCost = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEstNewUnitCost = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtQtyPerPack = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPrice1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPrice2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPrice3 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbItemType = New System.Windows.Forms.ComboBox()
        Me.txtPrice1MarkUp = New System.Windows.Forms.TextBox()
        Me.txtPrice2MarkUp = New System.Windows.Forms.TextBox()
        Me.txtPrice3Markup = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.p3 = New System.Windows.Forms.TextBox()
        Me.p1 = New System.Windows.Forms.TextBox()
        Me.p2 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsClose = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtItemCode = New System.Windows.Forms.MaskedTextBox()
        Me.cmbUnitOfMeasurement = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkIsSalesItems = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.chkIsactive = New System.Windows.Forms.CheckBox()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.txtitemname = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lblgenericname = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.cmbItemCategory = New System.Windows.Forms.ComboBox()
        Me.btnaddunitmeasurement = New System.Windows.Forms.Button()
        Me.btnadditemcategory = New System.Windows.Forms.Button()
        Me.btngenericname = New System.Windows.Forms.Button()
        Me.btnloadSupplier = New System.Windows.Forms.Button()
        Me.txtItemDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtgenericname = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Item Category:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Item Code:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(412, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Actual Unit Cost:"
        '
        'txtEstUnitCost
        '
        Me.txtEstUnitCost.BackColor = System.Drawing.Color.White
        Me.txtEstUnitCost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstUnitCost.Location = New System.Drawing.Point(501, 83)
        Me.txtEstUnitCost.Name = "txtEstUnitCost"
        Me.txtEstUnitCost.Size = New System.Drawing.Size(258, 21)
        Me.txtEstUnitCost.TabIndex = 12
        Me.txtEstUnitCost.Text = "0"
        Me.txtEstUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(64, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Supplier:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(443, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Unit Cost:"
        '
        'txtEstNewUnitCost
        '
        Me.txtEstNewUnitCost.BackColor = System.Drawing.Color.White
        Me.txtEstNewUnitCost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstNewUnitCost.Location = New System.Drawing.Point(501, 115)
        Me.txtEstNewUnitCost.Name = "txtEstNewUnitCost"
        Me.txtEstNewUnitCost.Size = New System.Drawing.Size(259, 21)
        Me.txtEstNewUnitCost.TabIndex = 13
        Me.txtEstNewUnitCost.Text = "0"
        Me.txtEstNewUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(83, 302)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Unit:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(427, 308)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Qty Per Pack:"
        '
        'txtQtyPerPack
        '
        Me.txtQtyPerPack.BackColor = System.Drawing.Color.White
        Me.txtQtyPerPack.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtyPerPack.Location = New System.Drawing.Point(501, 305)
        Me.txtQtyPerPack.Name = "txtQtyPerPack"
        Me.txtQtyPerPack.Size = New System.Drawing.Size(259, 21)
        Me.txtQtyPerPack.TabIndex = 24
        Me.txtQtyPerPack.Text = "0"
        Me.txtQtyPerPack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(424, 186)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Price 1(Cash):"
        '
        'txtPrice1
        '
        Me.txtPrice1.BackColor = System.Drawing.Color.White
        Me.txtPrice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice1.Location = New System.Drawing.Point(156, 38)
        Me.txtPrice1.Name = "txtPrice1"
        Me.txtPrice1.Size = New System.Drawing.Size(60, 21)
        Me.txtPrice1.TabIndex = 16
        Me.txtPrice1.Text = "0.00"
        Me.txtPrice1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(409, 211)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 13)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Price 2 (Charge):"
        '
        'txtPrice2
        '
        Me.txtPrice2.BackColor = System.Drawing.Color.White
        Me.txtPrice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice2.Location = New System.Drawing.Point(156, 65)
        Me.txtPrice2.Name = "txtPrice2"
        Me.txtPrice2.Size = New System.Drawing.Size(60, 21)
        Me.txtPrice2.TabIndex = 19
        Me.txtPrice2.Text = "0.00"
        Me.txtPrice2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(416, 237)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 13)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Price 3(Special):"
        '
        'txtPrice3
        '
        Me.txtPrice3.BackColor = System.Drawing.Color.White
        Me.txtPrice3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice3.Location = New System.Drawing.Point(156, 91)
        Me.txtPrice3.Name = "txtPrice3"
        Me.txtPrice3.Size = New System.Drawing.Size(60, 21)
        Me.txtPrice3.TabIndex = 22
        Me.txtPrice3.Text = "0.00"
        Me.txtPrice3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(440, 283)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 13)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Item Type:"
        '
        'cmbItemType
        '
        Me.cmbItemType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItemType.FormattingEnabled = True
        Me.cmbItemType.Location = New System.Drawing.Point(501, 279)
        Me.cmbItemType.Name = "cmbItemType"
        Me.cmbItemType.Size = New System.Drawing.Size(258, 21)
        Me.cmbItemType.TabIndex = 23
        '
        'txtPrice1MarkUp
        '
        Me.txtPrice1MarkUp.BackColor = System.Drawing.Color.White
        Me.txtPrice1MarkUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice1MarkUp.Location = New System.Drawing.Point(12, 39)
        Me.txtPrice1MarkUp.Name = "txtPrice1MarkUp"
        Me.txtPrice1MarkUp.Size = New System.Drawing.Size(47, 21)
        Me.txtPrice1MarkUp.TabIndex = 14
        Me.txtPrice1MarkUp.Text = "25"
        Me.txtPrice1MarkUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrice2MarkUp
        '
        Me.txtPrice2MarkUp.BackColor = System.Drawing.Color.White
        Me.txtPrice2MarkUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice2MarkUp.Location = New System.Drawing.Point(12, 65)
        Me.txtPrice2MarkUp.Name = "txtPrice2MarkUp"
        Me.txtPrice2MarkUp.Size = New System.Drawing.Size(47, 21)
        Me.txtPrice2MarkUp.TabIndex = 17
        Me.txtPrice2MarkUp.Text = "35"
        Me.txtPrice2MarkUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrice3Markup
        '
        Me.txtPrice3Markup.BackColor = System.Drawing.Color.White
        Me.txtPrice3Markup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice3Markup.Location = New System.Drawing.Point(12, 91)
        Me.txtPrice3Markup.Name = "txtPrice3Markup"
        Me.txtPrice3Markup.Size = New System.Drawing.Size(47, 21)
        Me.txtPrice3Markup.TabIndex = 20
        Me.txtPrice3Markup.Text = "15"
        Me.txtPrice3Markup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(56, 42)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 15)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "% X Unit Cost+ ="
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.txtPrice1)
        Me.GroupBox1.Controls.Add(Me.txtPrice3)
        Me.GroupBox1.Controls.Add(Me.txtPrice2)
        Me.GroupBox1.Controls.Add(Me.txtPrice1MarkUp)
        Me.GroupBox1.Controls.Add(Me.txtPrice2MarkUp)
        Me.GroupBox1.Controls.Add(Me.txtPrice3Markup)
        Me.GroupBox1.Controls.Add(Me.p3)
        Me.GroupBox1.Controls.Add(Me.p1)
        Me.GroupBox1.Controls.Add(Me.p2)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(501, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 133)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(156, 21)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(30, 13)
        Me.Label32.TabIndex = 191
        Me.Label32.Text = "Price"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(79, 22)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(51, 13)
        Me.Label31.TabIndex = 190
        Me.Label31.Text = "Unit Cost"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(9, 21)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(68, 13)
        Me.Label30.TabIndex = 189
        Me.Label30.Text = "Markup Rate"
        '
        'p3
        '
        Me.p3.BackColor = System.Drawing.Color.White
        Me.p3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p3.Location = New System.Drawing.Point(82, 90)
        Me.p3.Name = "p3"
        Me.p3.ReadOnly = True
        Me.p3.Size = New System.Drawing.Size(58, 21)
        Me.p3.TabIndex = 21
        Me.p3.Text = "0.00"
        Me.p3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'p1
        '
        Me.p1.BackColor = System.Drawing.Color.White
        Me.p1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1.Location = New System.Drawing.Point(82, 39)
        Me.p1.Name = "p1"
        Me.p1.ReadOnly = True
        Me.p1.Size = New System.Drawing.Size(59, 21)
        Me.p1.TabIndex = 15
        Me.p1.Text = "0.00"
        Me.p1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'p2
        '
        Me.p2.BackColor = System.Drawing.Color.White
        Me.p2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2.Location = New System.Drawing.Point(82, 65)
        Me.p2.Name = "p2"
        Me.p2.ReadOnly = True
        Me.p2.Size = New System.Drawing.Size(58, 21)
        Me.p2.TabIndex = 18
        Me.p2.Text = "0.00"
        Me.p2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(56, 94)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 15)
        Me.Label19.TabIndex = 54
        Me.Label19.Text = "% X Unit Cost+ ="
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(56, 70)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(98, 15)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = "% X Unit Cost+ ="
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(5, 67)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(11, 15)
        Me.Label21.TabIndex = 56
        Me.Label21.Text = "("
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(5, 41)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(11, 15)
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "("
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(5, 93)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(11, 15)
        Me.Label22.TabIndex = 57
        Me.Label22.Text = "("
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.ToolStripSeparator1, Me.tsClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(786, 37)
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
        'tsClose
        '
        Me.tsClose.Image = CType(resources.GetObject("tsClose.Image"), System.Drawing.Image)
        Me.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsClose.Name = "tsClose"
        Me.tsClose.Size = New System.Drawing.Size(39, 34)
        Me.tsClose.Text = "Close"
        Me.tsClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(379, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(2, 377)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(787, 30)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(2, 377)
        Me.GroupBox3.TabIndex = 66
        Me.GroupBox3.TabStop = False
        '
        'txtItemCode
        '
        Me.txtItemCode.BackColor = System.Drawing.Color.White
        Me.txtItemCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCode.Location = New System.Drawing.Point(117, 52)
        Me.txtItemCode.Mask = "0000000000000"
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtItemCode.ReadOnly = True
        Me.txtItemCode.Size = New System.Drawing.Size(221, 23)
        Me.txtItemCode.TabIndex = 1
        '
        'cmbUnitOfMeasurement
        '
        Me.cmbUnitOfMeasurement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbUnitOfMeasurement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnitOfMeasurement.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnitOfMeasurement.FormattingEnabled = True
        Me.cmbUnitOfMeasurement.Location = New System.Drawing.Point(116, 299)
        Me.cmbUnitOfMeasurement.Name = "cmbUnitOfMeasurement"
        Me.cmbUnitOfMeasurement.Size = New System.Drawing.Size(191, 21)
        Me.cmbUnitOfMeasurement.TabIndex = 8
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Location = New System.Drawing.Point(-2, 36)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1211, 2)
        Me.GroupBox5.TabIndex = 180
        Me.GroupBox5.TabStop = False
        '
        'chkIsSalesItems
        '
        Me.chkIsSalesItems.AutoSize = True
        Me.chkIsSalesItems.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkIsSalesItems.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkIsSalesItems.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsSalesItems.Location = New System.Drawing.Point(671, 54)
        Me.chkIsSalesItems.Name = "chkIsSalesItems"
        Me.chkIsSalesItems.Size = New System.Drawing.Size(88, 17)
        Me.chkIsSalesItems.TabIndex = 11
        Me.chkIsSalesItems.Text = "Is Sales Item"
        Me.chkIsSalesItems.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 413)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(786, 22)
        Me.StatusStrip1.TabIndex = 183
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'chkIsactive
        '
        Me.chkIsactive.AutoSize = True
        Me.chkIsactive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkIsactive.Checked = True
        Me.chkIsactive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIsactive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkIsactive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsactive.Location = New System.Drawing.Point(562, 52)
        Me.chkIsactive.Name = "chkIsactive"
        Me.chkIsactive.Size = New System.Drawing.Size(68, 17)
        Me.chkIsactive.TabIndex = 10
        Me.chkIsactive.Text = "Is Active"
        Me.chkIsactive.UseVisualStyleBackColor = True
        '
        'lblSupplier
        '
        Me.lblSupplier.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSupplier.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.lblSupplier.Location = New System.Drawing.Point(117, 241)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(190, 22)
        Me.lblSupplier.TabIndex = 199
        Me.lblSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtitemname
        '
        Me.txtitemname.BackColor = System.Drawing.Color.White
        Me.txtitemname.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitemname.Location = New System.Drawing.Point(116, 83)
        Me.txtitemname.Name = "txtitemname"
        Me.txtitemname.Size = New System.Drawing.Size(222, 21)
        Me.txtitemname.TabIndex = 2
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(50, 86)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(63, 13)
        Me.Label33.TabIndex = 202
        Me.Label33.Text = "Item Name:"
        '
        'lblgenericname
        '
        Me.lblgenericname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblgenericname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblgenericname.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.lblgenericname.Location = New System.Drawing.Point(117, 212)
        Me.lblgenericname.Name = "lblgenericname"
        Me.lblgenericname.Size = New System.Drawing.Size(190, 22)
        Me.lblgenericname.TabIndex = 204
        Me.lblgenericname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(36, 216)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(77, 13)
        Me.Label35.TabIndex = 203
        Me.Label35.Text = "Generic Name:"
        '
        'cmbItemCategory
        '
        Me.cmbItemCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemCategory.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItemCategory.FormattingEnabled = True
        Me.cmbItemCategory.Location = New System.Drawing.Point(116, 271)
        Me.cmbItemCategory.Name = "cmbItemCategory"
        Me.cmbItemCategory.Size = New System.Drawing.Size(191, 21)
        Me.cmbItemCategory.TabIndex = 6
        '
        'btnaddunitmeasurement
        '
        Me.btnaddunitmeasurement.Image = Global.HISReports.My.Resources.Resources.add_16
        Me.btnaddunitmeasurement.Location = New System.Drawing.Point(307, 298)
        Me.btnaddunitmeasurement.Name = "btnaddunitmeasurement"
        Me.btnaddunitmeasurement.Size = New System.Drawing.Size(32, 23)
        Me.btnaddunitmeasurement.TabIndex = 9
        Me.btnaddunitmeasurement.UseVisualStyleBackColor = True
        '
        'btnadditemcategory
        '
        Me.btnadditemcategory.Image = Global.HISReports.My.Resources.Resources.add_16
        Me.btnadditemcategory.Location = New System.Drawing.Point(307, 270)
        Me.btnadditemcategory.Name = "btnadditemcategory"
        Me.btnadditemcategory.Size = New System.Drawing.Size(32, 23)
        Me.btnadditemcategory.TabIndex = 7
        Me.btnadditemcategory.UseVisualStyleBackColor = True
        '
        'btngenericname
        '
        Me.btngenericname.Image = Global.HISReports.My.Resources.Resources.search_glyph
        Me.btngenericname.Location = New System.Drawing.Point(307, 211)
        Me.btngenericname.Name = "btngenericname"
        Me.btngenericname.Size = New System.Drawing.Size(32, 23)
        Me.btngenericname.TabIndex = 205
        Me.btngenericname.UseVisualStyleBackColor = True
        '
        'btnloadSupplier
        '
        Me.btnloadSupplier.Image = Global.HISReports.My.Resources.Resources.search_glyph
        Me.btnloadSupplier.Location = New System.Drawing.Point(307, 240)
        Me.btnloadSupplier.Name = "btnloadSupplier"
        Me.btnloadSupplier.Size = New System.Drawing.Size(32, 23)
        Me.btnloadSupplier.TabIndex = 5
        Me.btnloadSupplier.UseVisualStyleBackColor = True
        '
        'txtItemDescription
        '
        Me.txtItemDescription.BackColor = System.Drawing.Color.White
        Me.txtItemDescription.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDescription.Location = New System.Drawing.Point(117, 112)
        Me.txtItemDescription.Multiline = True
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.Size = New System.Drawing.Size(222, 92)
        Me.txtItemDescription.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Item Description:"
        '
        'txtgenericname
        '
        Me.txtgenericname.BackColor = System.Drawing.Color.White
        Me.txtgenericname.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgenericname.Location = New System.Drawing.Point(117, 212)
        Me.txtgenericname.Name = "txtgenericname"
        Me.txtgenericname.Size = New System.Drawing.Size(222, 21)
        Me.txtgenericname.TabIndex = 4
        '
        'frmItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 435)
        Me.Controls.Add(Me.txtgenericname)
        Me.Controls.Add(Me.btnaddunitmeasurement)
        Me.Controls.Add(Me.btnadditemcategory)
        Me.Controls.Add(Me.btngenericname)
        Me.Controls.Add(Me.lblgenericname)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.txtitemname)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.btnloadSupplier)
        Me.Controls.Add(Me.lblSupplier)
        Me.Controls.Add(Me.chkIsactive)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.chkIsSalesItems)
        Me.Controls.Add(Me.cmbUnitOfMeasurement)
        Me.Controls.Add(Me.txtItemCode)
        Me.Controls.Add(Me.cmbItemType)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtQtyPerPack)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEstNewUnitCost)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEstUnitCost)
        Me.Controls.Add(Me.txtItemDescription)
        Me.Controls.Add(Me.cmbItemCategory)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEstUnitCost As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEstNewUnitCost As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtQtyPerPack As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPrice1 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPrice2 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPrice3 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmbItemType As System.Windows.Forms.ComboBox
    Friend WithEvents txtPrice1MarkUp As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice2MarkUp As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice3Markup As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Public WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Public WithEvents tsClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtItemCode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents p3 As System.Windows.Forms.TextBox
    Friend WithEvents p2 As System.Windows.Forms.TextBox
    Friend WithEvents cmbUnitOfMeasurement As System.Windows.Forms.ComboBox
    Friend WithEvents p1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents chkIsSalesItems As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents chkIsactive As System.Windows.Forms.CheckBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents btnloadSupplier As System.Windows.Forms.Button
    Friend WithEvents txtitemname As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents btngenericname As System.Windows.Forms.Button
    Friend WithEvents lblgenericname As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cmbItemCategory As System.Windows.Forms.ComboBox
    Friend WithEvents btnadditemcategory As System.Windows.Forms.Button
    Friend WithEvents btnaddunitmeasurement As System.Windows.Forms.Button
    Friend WithEvents txtItemDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtgenericname As System.Windows.Forms.TextBox
End Class
