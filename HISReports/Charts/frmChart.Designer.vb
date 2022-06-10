<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChart
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
        Me.crvPrinting = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnapgarscoresheet = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnEditOperation = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbprocedurename = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnintravenousfluids = New System.Windows.Forms.Button()
        Me.btnnursingnotes = New System.Windows.Forms.Button()
        Me.btnProgressNotes = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblclinicalrecord = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbladmissiondate = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblbirthdate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblpatient = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'crvPrinting
        '
        Me.crvPrinting.ActiveViewIndex = -1
        Me.crvPrinting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvPrinting.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvPrinting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvPrinting.Location = New System.Drawing.Point(0, 0)
        Me.crvPrinting.Name = "crvPrinting"
        Me.crvPrinting.ShowGroupTreeButton = False
        Me.crvPrinting.ShowParameterPanelButton = False
        Me.crvPrinting.ShowRefreshButton = False
        Me.crvPrinting.Size = New System.Drawing.Size(955, 701)
        Me.crvPrinting.TabIndex = 0
        Me.crvPrinting.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.crvPrinting)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(388, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(955, 701)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.btnintravenousfluids)
        Me.Panel2.Controls.Add(Me.btnnursingnotes)
        Me.Panel2.Controls.Add(Me.btnProgressNotes)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.lblclinicalrecord)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.lbladmissiondate)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.lblbirthdate)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lbladdress)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblpatient)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(388, 701)
        Me.Panel2.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label21.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(39, 185)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(148, 18)
        Me.Label21.TabIndex = 299
        Me.Label21.Text = "Consent for Admission"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label29.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(25, 185)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(15, 18)
        Me.Label29.TabIndex = 298
        Me.Label29.Text = ">"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.btnapgarscoresheet)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 573)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(372, 80)
        Me.GroupBox2.TabIndex = 297
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Newborn"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(234, 17)
        Me.Label10.TabIndex = 297
        Me.Label10.Text = "> Childhood Care && Development Card"
        '
        'btnapgarscoresheet
        '
        Me.btnapgarscoresheet.Image = Global.HISReports.My.Resources.Resources.edit
        Me.btnapgarscoresheet.Location = New System.Drawing.Point(338, 23)
        Me.btnapgarscoresheet.Name = "btnapgarscoresheet"
        Me.btnapgarscoresheet.Size = New System.Drawing.Size(26, 24)
        Me.btnapgarscoresheet.TabIndex = 296
        Me.btnapgarscoresheet.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label30.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(28, 25)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(131, 17)
        Me.Label30.TabIndex = 263
        Me.Label30.Text = "> APGAR Score Sheet"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnEditOperation)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbprocedurename)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 343)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 224)
        Me.GroupBox1.TabIndex = 275
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operation"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 17)
        Me.Label8.TabIndex = 271
        Me.Label8.Text = "> Pre-Anesthetic Assessment"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 17)
        Me.Label6.TabIndex = 270
        Me.Label6.Text = "> Pre-Operative Checklist"
        '
        'btnEditOperation
        '
        Me.btnEditOperation.Image = Global.HISReports.My.Resources.Resources.edit
        Me.btnEditOperation.Location = New System.Drawing.Point(338, 20)
        Me.btnEditOperation.Name = "btnEditOperation"
        Me.btnEditOperation.Size = New System.Drawing.Size(26, 24)
        Me.btnEditOperation.TabIndex = 269
        Me.btnEditOperation.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label20.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(28, 189)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(217, 17)
        Me.Label20.TabIndex = 268
        Me.Label20.Text = "> Consent for Procedure/Operation"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 17)
        Me.Label7.TabIndex = 267
        Me.Label7.Text = "> Safety Checklist"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 17)
        Me.Label5.TabIndex = 264
        Me.Label5.Text = "> Nursing Operative Record"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 17)
        Me.Label4.TabIndex = 263
        Me.Label4.Text = "> Operative Record"
        '
        'cmbprocedurename
        '
        Me.cmbprocedurename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbprocedurename.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbprocedurename.FormattingEnabled = True
        Me.cmbprocedurename.Location = New System.Drawing.Point(74, 20)
        Me.cmbprocedurename.Name = "cmbprocedurename"
        Me.cmbprocedurename.Size = New System.Drawing.Size(260, 24)
        Me.cmbprocedurename.TabIndex = 262
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(5, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 261
        Me.Label1.Text = "Operation : "
        '
        'btnintravenousfluids
        '
        Me.btnintravenousfluids.Image = Global.HISReports.My.Resources.Resources.edit
        Me.btnintravenousfluids.Location = New System.Drawing.Point(346, 315)
        Me.btnintravenousfluids.Name = "btnintravenousfluids"
        Me.btnintravenousfluids.Size = New System.Drawing.Size(26, 24)
        Me.btnintravenousfluids.TabIndex = 296
        Me.btnintravenousfluids.UseVisualStyleBackColor = True
        '
        'btnnursingnotes
        '
        Me.btnnursingnotes.Image = Global.HISReports.My.Resources.Resources.edit
        Me.btnnursingnotes.Location = New System.Drawing.Point(346, 288)
        Me.btnnursingnotes.Name = "btnnursingnotes"
        Me.btnnursingnotes.Size = New System.Drawing.Size(26, 24)
        Me.btnnursingnotes.TabIndex = 295
        Me.btnnursingnotes.UseVisualStyleBackColor = True
        '
        'btnProgressNotes
        '
        Me.btnProgressNotes.Image = Global.HISReports.My.Resources.Resources.edit
        Me.btnProgressNotes.Location = New System.Drawing.Point(346, 261)
        Me.btnProgressNotes.Name = "btnProgressNotes"
        Me.btnProgressNotes.Size = New System.Drawing.Size(26, 24)
        Me.btnProgressNotes.TabIndex = 294
        Me.btnProgressNotes.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label28.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(25, 373)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(15, 18)
        Me.Label28.TabIndex = 293
        Me.Label28.Text = ">"
        Me.Label28.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label27.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(25, 291)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(15, 18)
        Me.Label27.TabIndex = 292
        Me.Label27.Text = ">"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label26.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(25, 345)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(15, 18)
        Me.Label26.TabIndex = 291
        Me.Label26.Text = ">"
        Me.Label26.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label25.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(25, 267)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(15, 18)
        Me.Label25.TabIndex = 290
        Me.Label25.Text = ">"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label24.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(25, 317)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(15, 18)
        Me.Label24.TabIndex = 289
        Me.Label24.Text = ">"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label23.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(25, 241)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(15, 18)
        Me.Label23.TabIndex = 288
        Me.Label23.Text = ">"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label22.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(25, 211)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(15, 18)
        Me.Label22.TabIndex = 287
        Me.Label22.Text = ">"
        '
        'lblclinicalrecord
        '
        Me.lblclinicalrecord.AutoSize = True
        Me.lblclinicalrecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblclinicalrecord.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclinicalrecord.Location = New System.Drawing.Point(39, 161)
        Me.lblclinicalrecord.Name = "lblclinicalrecord"
        Me.lblclinicalrecord.Size = New System.Drawing.Size(157, 18)
        Me.lblclinicalrecord.TabIndex = 285
        Me.lblclinicalrecord.Text = "Patient's Clinical Record"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label19.Enabled = False
        Me.Label19.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(39, 373)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(213, 18)
        Me.Label19.TabIndex = 284
        Me.Label19.Text = "Quality Assurance Checklist No. 1"
        Me.Label19.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label17.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(39, 291)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(147, 18)
        Me.Label17.TabIndex = 283
        Me.Label17.Text = "Nurses Progress Notes"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label18.Enabled = False
        Me.Label18.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(39, 345)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(218, 18)
        Me.Label18.TabIndex = 282
        Me.Label18.Text = "Medication and Treatment Record"
        Me.Label18.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label16.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(39, 267)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 18)
        Me.Label16.TabIndex = 281
        Me.Label16.Text = "Doctor's Order"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label15.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(39, 317)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(188, 18)
        Me.Label15.TabIndex = 280
        Me.Label15.Text = "Intravenous Fluid Flow Sheet"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(39, 241)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(234, 18)
        Me.Label13.TabIndex = 279
        Me.Label13.Text = "Clinical Abstract/Discharge Summary"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label12.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(39, 211)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(211, 18)
        Me.Label12.TabIndex = 278
        Me.Label12.Text = "History and Physical Examination"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 18)
        Me.Label9.TabIndex = 276
        Me.Label9.Text = ">"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(5, 113)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 14)
        Me.Label14.TabIndex = 274
        Me.Label14.Text = "Admission Date"
        '
        'lbladmissiondate
        '
        Me.lbladmissiondate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbladmissiondate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbladmissiondate.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.lbladmissiondate.Location = New System.Drawing.Point(107, 109)
        Me.lbladmissiondate.Name = "lbladmissiondate"
        Me.lbladmissiondate.Size = New System.Drawing.Size(273, 22)
        Me.lbladmissiondate.TabIndex = 273
        Me.lbladmissiondate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(36, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 14)
        Me.Label11.TabIndex = 272
        Me.Label11.Text = "Birth Date"
        '
        'lblbirthdate
        '
        Me.lblbirthdate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblbirthdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblbirthdate.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.lblbirthdate.Location = New System.Drawing.Point(107, 82)
        Me.lblbirthdate.Name = "lblbirthdate"
        Me.lblbirthdate.Size = New System.Drawing.Size(273, 22)
        Me.lblbirthdate.TabIndex = 271
        Me.lblbirthdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 14)
        Me.Label3.TabIndex = 270
        Me.Label3.Text = "Address"
        '
        'lbladdress
        '
        Me.lbladdress.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbladdress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbladdress.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.lbladdress.Location = New System.Drawing.Point(107, 55)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(273, 22)
        Me.lbladdress.TabIndex = 269
        Me.lbladdress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 14)
        Me.Label2.TabIndex = 268
        Me.Label2.Text = "Patient Name"
        '
        'lblpatient
        '
        Me.lblpatient.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblpatient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblpatient.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.lblpatient.Location = New System.Drawing.Point(107, 29)
        Me.lblpatient.Name = "lblpatient"
        Me.lblpatient.Size = New System.Drawing.Size(273, 22)
        Me.lblpatient.TabIndex = 267
        Me.lblpatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1343, 701)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmChart"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Chart"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvPrinting As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbladmissiondate As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblbirthdate As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbladdress As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblpatient As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbprocedurename As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblclinicalrecord As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnEditOperation As System.Windows.Forms.Button
    Friend WithEvents btnProgressNotes As System.Windows.Forms.Button
    Friend WithEvents btnnursingnotes As System.Windows.Forms.Button
    Friend WithEvents btnintravenousfluids As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnapgarscoresheet As System.Windows.Forms.Button
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
End Class
