<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHISReports
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
        Me.panelside = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.panelfilters = New System.Windows.Forms.Panel()
        Me.gpfilterpurpose = New System.Windows.Forms.GroupBox()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gpfilterpickdate = New System.Windows.Forms.GroupBox()
        Me.dtppickdate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gpfiltersearch = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.gpfiltercbshow = New System.Windows.Forms.GroupBox()
        Me.cbShow = New System.Windows.Forms.CheckBox()
        Me.gpfilteremployee = New System.Windows.Forms.GroupBox()
        Me.lblClearEmployee = New System.Windows.Forms.Label()
        Me.btnSearchEmployee = New System.Windows.Forms.Button()
        Me.txtEmployee = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gpfilterentrydata = New System.Windows.Forms.GroupBox()
        Me.txtEntryData = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.gpfilteradmissions = New System.Windows.Forms.GroupBox()
        Me.lblClearAdmission = New System.Windows.Forms.Label()
        Me.btnsearchadmission = New System.Windows.Forms.Button()
        Me.txtadmission = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.gpfilterpatient = New System.Windows.Forms.GroupBox()
        Me.lblClearPatient = New System.Windows.Forms.Label()
        Me.btnSearchPatient = New System.Windows.Forms.Button()
        Me.txtpatient = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gpfilterprocedure = New System.Windows.Forms.GroupBox()
        Me.lblClearProcedure = New System.Windows.Forms.Label()
        Me.btnsearchprocedure = New System.Windows.Forms.Button()
        Me.txtprocedure = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gpfiltericd10 = New System.Windows.Forms.GroupBox()
        Me.lblClearICD10 = New System.Windows.Forms.Label()
        Me.btnsearchicd10code = New System.Windows.Forms.Button()
        Me.txtICD10Code = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gpfilteritemcategory = New System.Windows.Forms.GroupBox()
        Me.lblClearCategory = New System.Windows.Forms.Label()
        Me.btnSearchItemCategory = New System.Windows.Forms.Button()
        Me.txtItemCategory = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.gpfilteradmissiontype = New System.Windows.Forms.GroupBox()
        Me.cmbadmissiontype = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gpfiltermonthly = New System.Windows.Forms.GroupBox()
        Me.dtpmonthly = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gpfiltersupplier = New System.Windows.Forms.GroupBox()
        Me.lblClearSupplier = New System.Windows.Forms.Label()
        Me.btnSearchSupplier = New System.Windows.Forms.Button()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.gpfilteryearly = New System.Windows.Forms.GroupBox()
        Me.dtpYearly = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.gpfilterlotno = New System.Windows.Forms.GroupBox()
        Me.lblClearLotno = New System.Windows.Forms.Label()
        Me.btnSearchLotno = New System.Windows.Forms.Button()
        Me.txtLotNo = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.gpfilteritem = New System.Windows.Forms.GroupBox()
        Me.lblClearItem = New System.Windows.Forms.Label()
        Me.btnSearchItem = New System.Windows.Forms.Button()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.gpfilteroffice = New System.Windows.Forms.GroupBox()
        Me.lblClearOffice = New System.Windows.Forms.Label()
        Me.btnSearchOffice = New System.Windows.Forms.Button()
        Me.txtOffice = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.gpfilterdatarange = New System.Windows.Forms.GroupBox()
        Me.cmbPeriod = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpenddate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartdate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSubreports = New System.Windows.Forms.ComboBox()
        Me.cmbReports = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cprtViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.panelside.SuspendLayout()
        Me.panelfilters.SuspendLayout()
        Me.gpfilterpurpose.SuspendLayout()
        Me.gpfilterpickdate.SuspendLayout()
        Me.gpfiltersearch.SuspendLayout()
        Me.gpfiltercbshow.SuspendLayout()
        Me.gpfilteremployee.SuspendLayout()
        Me.gpfilterentrydata.SuspendLayout()
        Me.gpfilteradmissions.SuspendLayout()
        Me.gpfilterpatient.SuspendLayout()
        Me.gpfilterprocedure.SuspendLayout()
        Me.gpfiltericd10.SuspendLayout()
        Me.gpfilteritemcategory.SuspendLayout()
        Me.gpfilteradmissiontype.SuspendLayout()
        Me.gpfiltermonthly.SuspendLayout()
        Me.gpfiltersupplier.SuspendLayout()
        Me.gpfilteryearly.SuspendLayout()
        Me.gpfilterlotno.SuspendLayout()
        Me.gpfilteritem.SuspendLayout()
        Me.gpfilteroffice.SuspendLayout()
        Me.gpfilterdatarange.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelside
        '
        Me.panelside.Controls.Add(Me.Label5)
        Me.panelside.Controls.Add(Me.btnRefresh)
        Me.panelside.Controls.Add(Me.panelfilters)
        Me.panelside.Controls.Add(Me.cmbSubreports)
        Me.panelside.Controls.Add(Me.cmbReports)
        Me.panelside.Controls.Add(Me.Label2)
        Me.panelside.Controls.Add(Me.Label1)
        Me.panelside.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelside.Location = New System.Drawing.Point(0, 0)
        Me.panelside.Name = "panelside"
        Me.panelside.Size = New System.Drawing.Size(304, 652)
        Me.panelside.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Report Filters :"
        '
        'btnRefresh
        '
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnRefresh.Font = New System.Drawing.Font("Arial Unicode MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnRefresh.Location = New System.Drawing.Point(0, 613)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(304, 39)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'panelfilters
        '
        Me.panelfilters.Controls.Add(Me.gpfilterpurpose)
        Me.panelfilters.Controls.Add(Me.gpfilterpickdate)
        Me.panelfilters.Controls.Add(Me.gpfiltersearch)
        Me.panelfilters.Controls.Add(Me.gpfiltercbshow)
        Me.panelfilters.Controls.Add(Me.gpfilteremployee)
        Me.panelfilters.Controls.Add(Me.gpfilterentrydata)
        Me.panelfilters.Controls.Add(Me.gpfilteradmissions)
        Me.panelfilters.Controls.Add(Me.gpfilterpatient)
        Me.panelfilters.Controls.Add(Me.gpfilterprocedure)
        Me.panelfilters.Controls.Add(Me.gpfiltericd10)
        Me.panelfilters.Controls.Add(Me.gpfilteritemcategory)
        Me.panelfilters.Controls.Add(Me.gpfilteradmissiontype)
        Me.panelfilters.Controls.Add(Me.gpfiltermonthly)
        Me.panelfilters.Controls.Add(Me.gpfiltersupplier)
        Me.panelfilters.Controls.Add(Me.gpfilteryearly)
        Me.panelfilters.Controls.Add(Me.gpfilterlotno)
        Me.panelfilters.Controls.Add(Me.gpfilteritem)
        Me.panelfilters.Controls.Add(Me.gpfilteroffice)
        Me.panelfilters.Controls.Add(Me.gpfilterdatarange)
        Me.panelfilters.Location = New System.Drawing.Point(2, 86)
        Me.panelfilters.Name = "panelfilters"
        Me.panelfilters.Padding = New System.Windows.Forms.Padding(5)
        Me.panelfilters.Size = New System.Drawing.Size(299, 615)
        Me.panelfilters.TabIndex = 6
        '
        'gpfilterpurpose
        '
        Me.gpfilterpurpose.Controls.Add(Me.txtPurpose)
        Me.gpfilterpurpose.Controls.Add(Me.Label14)
        Me.gpfilterpurpose.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpfilterpurpose.Location = New System.Drawing.Point(5, 970)
        Me.gpfilterpurpose.Name = "gpfilterpurpose"
        Me.gpfilterpurpose.Size = New System.Drawing.Size(289, 63)
        Me.gpfilterpurpose.TabIndex = 8
        Me.gpfilterpurpose.TabStop = False
        Me.gpfilterpurpose.Visible = False
        '
        'txtPurpose
        '
        Me.txtPurpose.Location = New System.Drawing.Point(67, 16)
        Me.txtPurpose.Multiline = True
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(203, 41)
        Me.txtPurpose.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 16)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Purpose :"
        '
        'gpfilterpickdate
        '
        Me.gpfilterpickdate.Controls.Add(Me.dtppickdate)
        Me.gpfilterpickdate.Controls.Add(Me.Label10)
        Me.gpfilterpickdate.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpfilterpickdate.Location = New System.Drawing.Point(5, 921)
        Me.gpfilterpickdate.Name = "gpfilterpickdate"
        Me.gpfilterpickdate.Size = New System.Drawing.Size(289, 49)
        Me.gpfilterpickdate.TabIndex = 4
        Me.gpfilterpickdate.TabStop = False
        Me.gpfilterpickdate.Visible = False
        '
        'dtppickdate
        '
        Me.dtppickdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtppickdate.Location = New System.Drawing.Point(52, 16)
        Me.dtppickdate.Name = "dtppickdate"
        Me.dtppickdate.Size = New System.Drawing.Size(218, 24)
        Me.dtppickdate.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Date :"
        '
        'gpfiltersearch
        '
        Me.gpfiltersearch.Controls.Add(Me.txtSearch)
        Me.gpfiltersearch.Controls.Add(Me.Label22)
        Me.gpfiltersearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpfiltersearch.Location = New System.Drawing.Point(5, 874)
        Me.gpfiltersearch.Name = "gpfiltersearch"
        Me.gpfiltersearch.Size = New System.Drawing.Size(289, 47)
        Me.gpfiltersearch.TabIndex = 15
        Me.gpfiltersearch.TabStop = False
        Me.gpfiltersearch.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(57, 15)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(213, 24)
        Me.txtSearch.TabIndex = 5
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(3, 18)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 16)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "Search :"
        '
        'gpfiltercbshow
        '
        Me.gpfiltercbshow.Controls.Add(Me.cbShow)
        Me.gpfiltercbshow.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpfiltercbshow.Location = New System.Drawing.Point(5, 839)
        Me.gpfiltercbshow.Name = "gpfiltercbshow"
        Me.gpfiltercbshow.Size = New System.Drawing.Size(289, 35)
        Me.gpfiltercbshow.TabIndex = 16
        Me.gpfiltercbshow.TabStop = False
        Me.gpfiltercbshow.Visible = False
        '
        'cbShow
        '
        Me.cbShow.AutoSize = True
        Me.cbShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbShow.Location = New System.Drawing.Point(8, 12)
        Me.cbShow.Name = "cbShow"
        Me.cbShow.Size = New System.Drawing.Size(58, 20)
        Me.cbShow.TabIndex = 0
        Me.cbShow.Text = "Show"
        Me.cbShow.UseVisualStyleBackColor = True
        '
        'gpfilteremployee
        '
        Me.gpfilteremployee.Controls.Add(Me.lblClearEmployee)
        Me.gpfilteremployee.Controls.Add(Me.btnSearchEmployee)
        Me.gpfilteremployee.Controls.Add(Me.txtEmployee)
        Me.gpfilteremployee.Controls.Add(Me.Label15)
        Me.gpfilteremployee.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpfilteremployee.Location = New System.Drawing.Point(5, 791)
        Me.gpfilteremployee.Name = "gpfilteremployee"
        Me.gpfilteremployee.Size = New System.Drawing.Size(289, 48)
        Me.gpfilteremployee.TabIndex = 9
        Me.gpfilteremployee.TabStop = False
        Me.gpfilteremployee.Visible = False
        '
        'lblClearEmployee
        '
        Me.lblClearEmployee.AutoSize = True
        Me.lblClearEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearEmployee.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearEmployee.ForeColor = System.Drawing.Color.Red
        Me.lblClearEmployee.Location = New System.Drawing.Point(271, 20)
        Me.lblClearEmployee.Name = "lblClearEmployee"
        Me.lblClearEmployee.Size = New System.Drawing.Size(17, 16)
        Me.lblClearEmployee.TabIndex = 10
        Me.lblClearEmployee.Text = "X"
        '
        'btnSearchEmployee
        '
        Me.btnSearchEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchEmployee.Image = Global.HISReports.My.Resources.Resources.search_glyph
        Me.btnSearchEmployee.Location = New System.Drawing.Point(239, 16)
        Me.btnSearchEmployee.Name = "btnSearchEmployee"
        Me.btnSearchEmployee.Size = New System.Drawing.Size(31, 24)
        Me.btnSearchEmployee.TabIndex = 6
        Me.btnSearchEmployee.UseVisualStyleBackColor = True
        '
        'txtEmployee
        '
        Me.txtEmployee.Location = New System.Drawing.Point(78, 16)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.ReadOnly = True
        Me.txtEmployee.Size = New System.Drawing.Size(158, 24)
        Me.txtEmployee.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 16)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Employee :"
        '
        'gpfilterentrydata
        '
        Me.gpfilterentrydata.Controls.Add(Me.txtEntryData)
        Me.gpfilterentrydata.Controls.Add(Me.Label21)
        Me.gpfilterentrydata.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpfilterentrydata.Location = New System.Drawing.Point(5, 744)
        Me.gpfilterentrydata.Name = "gpfilterentrydata"
        Me.gpfilterentrydata.Size = New System.Drawing.Size(289, 47)
        Me.gpfilterentrydata.TabIndex = 17
        Me.gpfilterentrydata.TabStop = False
        Me.gpfilterentrydata.Visible = False
        '
        'txtEntryData
        '
        Me.txtEntryData.Location = New System.Drawing.Point(104, 15)
        Me.txtEntryData.Name = "txtEntryData"
        Me.txtEntryData.Size = New System.Drawing.Size(166, 24)
        Me.txtEntryData.TabIndex = 5
        Me.txtEntryData.Text = "0"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(3, 18)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(100, 16)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Entry :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gpfilteradmissions
        '
        Me.gpfilteradmissions.Controls.Add(Me.lblClearAdmission)
        Me.gpfilteradmissions.Controls.Add(Me.btnsearchadmission)
        Me.gpfilteradmissions.Controls.Add(Me.txtadmission)
        Me.gpfilteradmissions.Controls.Add(Me.Label13)
        Me.gpfilteradmissions.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpfilteradmissions.Location = New System.Drawing.Point(5, 681)
        Me.gpfilteradmissions.Name = "gpfilteradmissions"
        Me.gpfilteradmissions.Size = New System.Drawing.Size(289, 63)
        Me.gpfilteradmissions.TabIndex = 7
        Me.gpfilteradmissions.TabStop = False
        Me.gpfilteradmissions.Visible = False
        '
        'lblClearAdmission
        '
        Me.lblClearAdmission.AutoSize = True
        Me.lblClearAdmission.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearAdmission.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearAdmission.ForeColor = System.Drawing.Color.Red
        Me.lblClearAdmission.Location = New System.Drawing.Point(271, 20)
        Me.lblClearAdmission.Name = "lblClearAdmission"
        Me.lblClearAdmission.Size = New System.Drawing.Size(17, 16)
        Me.lblClearAdmission.TabIndex = 10
        Me.lblClearAdmission.Text = "X"
        '
        'btnsearchadmission
        '
        Me.btnsearchadmission.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsearchadmission.Image = Global.HISReports.My.Resources.Resources.search_glyph
        Me.btnsearchadmission.Location = New System.Drawing.Point(239, 16)
        Me.btnsearchadmission.Name = "btnsearchadmission"
        Me.btnsearchadmission.Size = New System.Drawing.Size(31, 24)
        Me.btnsearchadmission.TabIndex = 6
        Me.btnsearchadmission.UseVisualStyleBackColor = True
        '
        'txtadmission
        '
        Me.txtadmission.Location = New System.Drawing.Point(78, 16)
        Me.txtadmission.Multiline = True
        Me.txtadmission.Name = "txtadmission"
        Me.txtadmission.ReadOnly = True
        Me.txtadmission.Size = New System.Drawing.Size(158, 41)
        Me.txtadmission.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 16)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Admission :"
        '
        'gpfilterpatient
        '
        Me.gpfilterpatient.Controls.Add(Me.lblClearPatient)
        Me.gpfilterpatient.Controls.Add(Me.btnSearchPatient)
        Me.gpfilterpatient.Controls.Add(Me.txtpatient)
        Me.gpfilterpatient.Controls.Add(Me.Label8)
        Me.gpfilterpatient.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpfilterpatient.Location = New System.Drawing.Point(5, 633)
        Me.gpfilterpatient.Name = "gpfilterpatient"
        Me.gpfilterpatient.Size = New System.Drawing.Size(289, 48)
        Me.gpfilterpatient.TabIndex = 3
        Me.gpfilterpatient.TabStop = False
        Me.gpfilterpatient.Visible = False
        '
        'lblClearPatient
        '
        Me.lblClearPatient.AutoSize = True
        Me.lblClearPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearPatient.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearPatient.ForeColor = System.Drawing.Color.Red
        Me.lblClearPatient.Location = New System.Drawing.Point(271, 20)
        Me.lblClearPatient.Name = "lblClearPatient"
        Me.lblClearPatient.Size = New System.Drawing.Size(17, 16)
        Me.lblClearPatient.TabIndex = 12
        Me.lblClearPatient.Text = "X"
        '
        'btnSearchPatient
        '
        Me.btnSearchPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchPatient.Image = Global.HISReports.My.Resources.Resources.search_glyph
        Me.btnSearchPatient.Location = New System.Drawing.Point(239, 16)
        Me.btnSearchPatient.Name = "btnSearchPatient"
        Me.btnSearchPatient.Size = New System.Drawing.Size(31, 24)
        Me.btnSearchPatient.TabIndex = 6
        Me.btnSearchPatient.UseVisualStyleBackColor = True
        '
        'txtpatient
        '
        Me.txtpatient.Location = New System.Drawing.Point(57, 16)
        Me.txtpatient.Name = "txtpatient"
        Me.txtpatient.ReadOnly = True
        Me.txtpatient.Size = New System.Drawing.Size(179, 24)
        Me.txtpatient.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Patient :"
        '
        'gpfilterprocedure
        '
        Me.gpfilterprocedure.Controls.Add(Me.lblClearProcedure)
        Me.gpfilterprocedure.Controls.Add(Me.btnsearchprocedure)
        Me.gpfilterprocedure.Controls.Add(Me.txtprocedure)
        Me.gpfilterprocedure.Controls.Add(Me.Label6)
        Me.gpfilterprocedure.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpfilterprocedure.Location = New System.Drawing.Point(5, 570)
        Me.gpfilterprocedure.Name = "gpfilterprocedure"
        Me.gpfilterprocedure.Size = New System.Drawing.Size(289, 63)
        Me.gpfilterprocedure.TabIndex = 2
        Me.gpfilterprocedure.TabStop = False
        Me.gpfilterprocedure.Visible = False
        '
        'lblClearProcedure
        '
        Me.lblClearProcedure.AutoSize = True
        Me.lblClearProcedure.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearProcedure.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearProcedure.ForeColor = System.Drawing.Color.Red
        Me.lblClearProcedure.Location = New System.Drawing.Point(271, 20)
        Me.lblClearProcedure.Name = "lblClearProcedure"
        Me.lblClearProcedure.Size = New System.Drawing.Size(17, 16)
        Me.lblClearProcedure.TabIndex = 12
        Me.lblClearProcedure.Text = "X"
        '
        'btnsearchprocedure
        '
        Me.btnsearchprocedure.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsearchprocedure.Image = Global.HISReports.My.Resources.Resources.search_glyph
        Me.btnsearchprocedure.Location = New System.Drawing.Point(239, 16)
        Me.btnsearchprocedure.Name = "btnsearchprocedure"
        Me.btnsearchprocedure.Size = New System.Drawing.Size(31, 24)
        Me.btnsearchprocedure.TabIndex = 6
        Me.btnsearchprocedure.UseVisualStyleBackColor = True
        '
        'txtprocedure
        '
        Me.txtprocedure.Location = New System.Drawing.Point(78, 16)
        Me.txtprocedure.Multiline = True
        Me.txtprocedure.Name = "txtprocedure"
        Me.txtprocedure.ReadOnly = True
        Me.txtprocedure.Size = New System.Drawing.Size(158, 41)
        Me.txtprocedure.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Procedure :"
        '
        'gpfiltericd10
        '
        Me.gpfiltericd10.Controls.Add(Me.lblClearICD10)
        Me.gpfiltericd10.Controls.Add(Me.btnsearchicd10code)
        Me.gpfiltericd10.Controls.Add(Me.txtICD10Code)
        Me.gpfiltericd10.Controls.Add(Me.Label7)
        Me.gpfiltericd10.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpfiltericd10.Location = New System.Drawing.Point(5, 507)
        Me.gpfiltericd10.Name = "gpfiltericd10"
        Me.gpfiltericd10.Size = New System.Drawing.Size(289, 63)
        Me.gpfiltericd10.TabIndex = 1
        Me.gpfiltericd10.TabStop = False
        Me.gpfiltericd10.Visible = False
        '
        'lblClearICD10
        '
        Me.lblClearICD10.AutoSize = True
        Me.lblClearICD10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearICD10.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearICD10.ForeColor = System.Drawing.Color.Red
        Me.lblClearICD10.Location = New System.Drawing.Point(271, 20)
        Me.lblClearICD10.Name = "lblClearICD10"
        Me.lblClearICD10.Size = New System.Drawing.Size(17, 16)
        Me.lblClearICD10.TabIndex = 11
        Me.lblClearICD10.Text = "X"
        '
        'btnsearchicd10code
        '
        Me.btnsearchicd10code.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsearchicd10code.Image = Global.HISReports.My.Resources.Resources.search_glyph
        Me.btnsearchicd10code.Location = New System.Drawing.Point(239, 16)
        Me.btnsearchicd10code.Name = "btnsearchicd10code"
        Me.btnsearchicd10code.Size = New System.Drawing.Size(31, 24)
        Me.btnsearchicd10code.TabIndex = 6
        Me.btnsearchicd10code.UseVisualStyleBackColor = True
        '
        'txtICD10Code
        '
        Me.txtICD10Code.Location = New System.Drawing.Point(57, 16)
        Me.txtICD10Code.Multiline = True
        Me.txtICD10Code.Name = "txtICD10Code"
        Me.txtICD10Code.ReadOnly = True
        Me.txtICD10Code.Size = New System.Drawing.Size(179, 41)
        Me.txtICD10Code.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "ICD10 :"
        '
        'gpfilteritemcategory
        '
        Me.gpfilteritemcategory.Controls.Add(Me.lblClearCategory)
        Me.gpfilteritemcategory.Controls.Add(Me.btnSearchItemCategory)
        Me.gpfilteritemcategory.Controls.Add(Me.txtItemCategory)
        Me.gpfilteritemcategory.Controls.Add(Me.Label18)
        Me.gpfilteritemcategory.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpfilteritemcategory.Location = New System.Drawing.Point(5, 459)
        Me.gpfilteritemcategory.Name = "gpfilteritemcategory"
        Me.gpfilteritemcategory.Size = New System.Drawing.Size(289, 48)
        Me.gpfilteritemcategory.TabIndex = 12
        Me.gpfilteritemcategory.TabStop = False
        Me.gpfilteritemcategory.Visible = False
        '
        'lblClearCategory
        '
        Me.lblClearCategory.AutoSize = True
        Me.lblClearCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearCategory.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearCategory.ForeColor = System.Drawing.Color.Red
        Me.lblClearCategory.Location = New System.Drawing.Point(271, 20)
        Me.lblClearCategory.Name = "lblClearCategory"
        Me.lblClearCategory.Size = New System.Drawing.Size(17, 16)
        Me.lblClearCategory.TabIndex = 9
        Me.lblClearCategory.Text = "X"
        '
        'btnSearchItemCategory
        '
        Me.btnSearchItemCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchItemCategory.Image = Global.HISReports.My.Resources.Resources.search_glyph
        Me.btnSearchItemCategory.Location = New System.Drawing.Point(239, 16)
        Me.btnSearchItemCategory.Name = "btnSearchItemCategory"
        Me.btnSearchItemCategory.Size = New System.Drawing.Size(31, 24)
        Me.btnSearchItemCategory.TabIndex = 6
        Me.btnSearchItemCategory.UseVisualStyleBackColor = True
        '
        'txtItemCategory
        '
        Me.txtItemCategory.Location = New System.Drawing.Point(73, 16)
        Me.txtItemCategory.Name = "txtItemCategory"
        Me.txtItemCategory.ReadOnly = True
        Me.txtItemCategory.Size = New System.Drawing.Size(163, 24)
        Me.txtItemCategory.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 16)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Category :"
        '
        'gpfilteradmissiontype
        '
        Me.gpfilteradmissiontype.Controls.Add(Me.cmbadmissiontype)
        Me.gpfilteradmissiontype.Controls.Add(Me.Label11)
        Me.gpfilteradmissiontype.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpfilteradmissiontype.Location = New System.Drawing.Point(5, 410)
        Me.gpfilteradmissiontype.Name = "gpfilteradmissiontype"
        Me.gpfilteradmissiontype.Size = New System.Drawing.Size(289, 49)
        Me.gpfilteradmissiontype.TabIndex = 6
        Me.gpfilteradmissiontype.TabStop = False
        Me.gpfilteradmissiontype.Visible = False
        '
        'cmbadmissiontype
        '
        Me.cmbadmissiontype.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbadmissiontype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbadmissiontype.FormattingEnabled = True
        Me.cmbadmissiontype.Location = New System.Drawing.Point(110, 17)
        Me.cmbadmissiontype.Name = "cmbadmissiontype"
        Me.cmbadmissiontype.Size = New System.Drawing.Size(160, 24)
        Me.cmbadmissiontype.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 16)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Admission Type :"
        '
        'gpfiltermonthly
        '
        Me.gpfiltermonthly.Controls.Add(Me.dtpmonthly)
        Me.gpfiltermonthly.Controls.Add(Me.Label9)
        Me.gpfiltermonthly.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpfiltermonthly.Location = New System.Drawing.Point(5, 361)
        Me.gpfiltermonthly.Name = "gpfiltermonthly"
        Me.gpfiltermonthly.Size = New System.Drawing.Size(289, 49)
        Me.gpfiltermonthly.TabIndex = 5
        Me.gpfiltermonthly.TabStop = False
        Me.gpfiltermonthly.Visible = False
        '
        'dtpmonthly
        '
        Me.dtpmonthly.CustomFormat = "MMMM yyyy"
        Me.dtpmonthly.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpmonthly.Location = New System.Drawing.Point(52, 16)
        Me.dtpmonthly.Name = "dtpmonthly"
        Me.dtpmonthly.Size = New System.Drawing.Size(218, 24)
        Me.dtpmonthly.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Date :"
        '
        'gpfiltersupplier
        '
        Me.gpfiltersupplier.Controls.Add(Me.lblClearSupplier)
        Me.gpfiltersupplier.Controls.Add(Me.btnSearchSupplier)
        Me.gpfiltersupplier.Controls.Add(Me.txtSupplier)
        Me.gpfiltersupplier.Controls.Add(Me.Label16)
        Me.gpfiltersupplier.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpfiltersupplier.Location = New System.Drawing.Point(5, 313)
        Me.gpfiltersupplier.Name = "gpfiltersupplier"
        Me.gpfiltersupplier.Size = New System.Drawing.Size(289, 48)
        Me.gpfiltersupplier.TabIndex = 11
        Me.gpfiltersupplier.TabStop = False
        Me.gpfiltersupplier.Visible = False
        '
        'lblClearSupplier
        '
        Me.lblClearSupplier.AutoSize = True
        Me.lblClearSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearSupplier.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearSupplier.ForeColor = System.Drawing.Color.Red
        Me.lblClearSupplier.Location = New System.Drawing.Point(271, 20)
        Me.lblClearSupplier.Name = "lblClearSupplier"
        Me.lblClearSupplier.Size = New System.Drawing.Size(17, 16)
        Me.lblClearSupplier.TabIndex = 10
        Me.lblClearSupplier.Text = "X"
        '
        'btnSearchSupplier
        '
        Me.btnSearchSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchSupplier.Image = Global.HISReports.My.Resources.Resources.search_glyph
        Me.btnSearchSupplier.Location = New System.Drawing.Point(239, 16)
        Me.btnSearchSupplier.Name = "btnSearchSupplier"
        Me.btnSearchSupplier.Size = New System.Drawing.Size(31, 24)
        Me.btnSearchSupplier.TabIndex = 6
        Me.btnSearchSupplier.UseVisualStyleBackColor = True
        '
        'txtSupplier
        '
        Me.txtSupplier.Location = New System.Drawing.Point(67, 16)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.ReadOnly = True
        Me.txtSupplier.Size = New System.Drawing.Size(169, 24)
        Me.txtSupplier.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(5, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 16)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Supplier :"
        '
        'gpfilteryearly
        '
        Me.gpfilteryearly.Controls.Add(Me.dtpYearly)
        Me.gpfilteryearly.Controls.Add(Me.Label23)
        Me.gpfilteryearly.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpfilteryearly.Location = New System.Drawing.Point(5, 264)
        Me.gpfilteryearly.Name = "gpfilteryearly"
        Me.gpfilteryearly.Size = New System.Drawing.Size(289, 49)
        Me.gpfilteryearly.TabIndex = 18
        Me.gpfilteryearly.TabStop = False
        Me.gpfilteryearly.Visible = False
        '
        'dtpYearly
        '
        Me.dtpYearly.CustomFormat = "yyyy"
        Me.dtpYearly.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYearly.Location = New System.Drawing.Point(52, 16)
        Me.dtpYearly.Name = "dtpYearly"
        Me.dtpYearly.Size = New System.Drawing.Size(218, 24)
        Me.dtpYearly.TabIndex = 6
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 20)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(40, 16)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Year :"
        '
        'gpfilterlotno
        '
        Me.gpfilterlotno.Controls.Add(Me.lblClearLotno)
        Me.gpfilterlotno.Controls.Add(Me.btnSearchLotno)
        Me.gpfilterlotno.Controls.Add(Me.txtLotNo)
        Me.gpfilterlotno.Controls.Add(Me.Label20)
        Me.gpfilterlotno.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpfilterlotno.Location = New System.Drawing.Point(5, 216)
        Me.gpfilterlotno.Name = "gpfilterlotno"
        Me.gpfilterlotno.Size = New System.Drawing.Size(289, 48)
        Me.gpfilterlotno.TabIndex = 14
        Me.gpfilterlotno.TabStop = False
        Me.gpfilterlotno.Visible = False
        '
        'lblClearLotno
        '
        Me.lblClearLotno.AutoSize = True
        Me.lblClearLotno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearLotno.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearLotno.ForeColor = System.Drawing.Color.Red
        Me.lblClearLotno.Location = New System.Drawing.Point(271, 20)
        Me.lblClearLotno.Name = "lblClearLotno"
        Me.lblClearLotno.Size = New System.Drawing.Size(17, 16)
        Me.lblClearLotno.TabIndex = 8
        Me.lblClearLotno.Text = "X"
        '
        'btnSearchLotno
        '
        Me.btnSearchLotno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchLotno.Image = Global.HISReports.My.Resources.Resources.search_glyph
        Me.btnSearchLotno.Location = New System.Drawing.Point(239, 16)
        Me.btnSearchLotno.Name = "btnSearchLotno"
        Me.btnSearchLotno.Size = New System.Drawing.Size(31, 24)
        Me.btnSearchLotno.TabIndex = 6
        Me.btnSearchLotno.UseVisualStyleBackColor = True
        '
        'txtLotNo
        '
        Me.txtLotNo.Location = New System.Drawing.Point(57, 16)
        Me.txtLotNo.Name = "txtLotNo"
        Me.txtLotNo.ReadOnly = True
        Me.txtLotNo.Size = New System.Drawing.Size(179, 24)
        Me.txtLotNo.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(2, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 16)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Lot No. :"
        '
        'gpfilteritem
        '
        Me.gpfilteritem.Controls.Add(Me.lblClearItem)
        Me.gpfilteritem.Controls.Add(Me.btnSearchItem)
        Me.gpfilteritem.Controls.Add(Me.txtItem)
        Me.gpfilteritem.Controls.Add(Me.Label19)
        Me.gpfilteritem.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpfilteritem.Location = New System.Drawing.Point(5, 168)
        Me.gpfilteritem.Name = "gpfilteritem"
        Me.gpfilteritem.Size = New System.Drawing.Size(289, 48)
        Me.gpfilteritem.TabIndex = 13
        Me.gpfilteritem.TabStop = False
        Me.gpfilteritem.Visible = False
        '
        'lblClearItem
        '
        Me.lblClearItem.AutoSize = True
        Me.lblClearItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearItem.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearItem.ForeColor = System.Drawing.Color.Red
        Me.lblClearItem.Location = New System.Drawing.Point(271, 20)
        Me.lblClearItem.Name = "lblClearItem"
        Me.lblClearItem.Size = New System.Drawing.Size(17, 16)
        Me.lblClearItem.TabIndex = 8
        Me.lblClearItem.Text = "X"
        '
        'btnSearchItem
        '
        Me.btnSearchItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchItem.Image = Global.HISReports.My.Resources.Resources.search_glyph
        Me.btnSearchItem.Location = New System.Drawing.Point(239, 16)
        Me.btnSearchItem.Name = "btnSearchItem"
        Me.btnSearchItem.Size = New System.Drawing.Size(31, 24)
        Me.btnSearchItem.TabIndex = 6
        Me.btnSearchItem.UseVisualStyleBackColor = True
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(49, 16)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = True
        Me.txtItem.Size = New System.Drawing.Size(187, 24)
        Me.txtItem.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(38, 16)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Item :"
        '
        'gpfilteroffice
        '
        Me.gpfilteroffice.Controls.Add(Me.lblClearOffice)
        Me.gpfilteroffice.Controls.Add(Me.btnSearchOffice)
        Me.gpfilteroffice.Controls.Add(Me.txtOffice)
        Me.gpfilteroffice.Controls.Add(Me.Label17)
        Me.gpfilteroffice.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpfilteroffice.Location = New System.Drawing.Point(5, 120)
        Me.gpfilteroffice.Name = "gpfilteroffice"
        Me.gpfilteroffice.Size = New System.Drawing.Size(289, 48)
        Me.gpfilteroffice.TabIndex = 10
        Me.gpfilteroffice.TabStop = False
        Me.gpfilteroffice.Visible = False
        '
        'lblClearOffice
        '
        Me.lblClearOffice.AutoSize = True
        Me.lblClearOffice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearOffice.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearOffice.ForeColor = System.Drawing.Color.Red
        Me.lblClearOffice.Location = New System.Drawing.Point(271, 21)
        Me.lblClearOffice.Name = "lblClearOffice"
        Me.lblClearOffice.Size = New System.Drawing.Size(17, 16)
        Me.lblClearOffice.TabIndex = 7
        Me.lblClearOffice.Text = "X"
        '
        'btnSearchOffice
        '
        Me.btnSearchOffice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchOffice.Image = Global.HISReports.My.Resources.Resources.search_glyph
        Me.btnSearchOffice.Location = New System.Drawing.Point(239, 17)
        Me.btnSearchOffice.Name = "btnSearchOffice"
        Me.btnSearchOffice.Size = New System.Drawing.Size(31, 24)
        Me.btnSearchOffice.TabIndex = 6
        Me.btnSearchOffice.UseVisualStyleBackColor = True
        '
        'txtOffice
        '
        Me.txtOffice.Location = New System.Drawing.Point(52, 17)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.ReadOnly = True
        Me.txtOffice.Size = New System.Drawing.Size(184, 24)
        Me.txtOffice.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(5, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 16)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Office :"
        '
        'gpfilterdatarange
        '
        Me.gpfilterdatarange.Controls.Add(Me.cmbPeriod)
        Me.gpfilterdatarange.Controls.Add(Me.Label12)
        Me.gpfilterdatarange.Controls.Add(Me.dtpenddate)
        Me.gpfilterdatarange.Controls.Add(Me.dtpStartdate)
        Me.gpfilterdatarange.Controls.Add(Me.Label4)
        Me.gpfilterdatarange.Controls.Add(Me.Label3)
        Me.gpfilterdatarange.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpfilterdatarange.Location = New System.Drawing.Point(5, 5)
        Me.gpfilterdatarange.Name = "gpfilterdatarange"
        Me.gpfilterdatarange.Size = New System.Drawing.Size(289, 115)
        Me.gpfilterdatarange.TabIndex = 0
        Me.gpfilterdatarange.TabStop = False
        Me.gpfilterdatarange.Visible = False
        '
        'cmbPeriod
        '
        Me.cmbPeriod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPeriod.FormattingEnabled = True
        Me.cmbPeriod.Location = New System.Drawing.Point(78, 20)
        Me.cmbPeriod.Name = "cmbPeriod"
        Me.cmbPeriod.Size = New System.Drawing.Size(192, 24)
        Me.cmbPeriod.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 16)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Period :"
        '
        'dtpenddate
        '
        Me.dtpenddate.Enabled = False
        Me.dtpenddate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpenddate.Location = New System.Drawing.Point(80, 81)
        Me.dtpenddate.Name = "dtpenddate"
        Me.dtpenddate.Size = New System.Drawing.Size(190, 24)
        Me.dtpenddate.TabIndex = 7
        '
        'dtpStartdate
        '
        Me.dtpStartdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartdate.Location = New System.Drawing.Point(80, 51)
        Me.dtpStartdate.Name = "dtpStartdate"
        Me.dtpStartdate.Size = New System.Drawing.Size(190, 24)
        Me.dtpStartdate.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "End Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Start Date :"
        '
        'cmbSubreports
        '
        Me.cmbSubreports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbSubreports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubreports.FormattingEnabled = True
        Me.cmbSubreports.Location = New System.Drawing.Point(80, 45)
        Me.cmbSubreports.Name = "cmbSubreports"
        Me.cmbSubreports.Size = New System.Drawing.Size(221, 24)
        Me.cmbSubreports.TabIndex = 5
        '
        'cmbReports
        '
        Me.cmbReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbReports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReports.FormattingEnabled = True
        Me.cmbReports.Location = New System.Drawing.Point(56, 16)
        Me.cmbReports.Name = "cmbReports"
        Me.cmbReports.Size = New System.Drawing.Size(245, 24)
        Me.cmbReports.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sub-Report :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Report :"
        '
        'cprtViewer
        '
        Me.cprtViewer.ActiveViewIndex = -1
        Me.cprtViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cprtViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.cprtViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cprtViewer.EnableDrillDown = False
        Me.cprtViewer.Location = New System.Drawing.Point(304, 0)
        Me.cprtViewer.Name = "cprtViewer"
        Me.cprtViewer.ShowCloseButton = False
        Me.cprtViewer.ShowGroupTreeButton = False
        Me.cprtViewer.ShowParameterPanelButton = False
        Me.cprtViewer.ShowRefreshButton = False
        Me.cprtViewer.Size = New System.Drawing.Size(1066, 652)
        Me.cprtViewer.TabIndex = 1
        Me.cprtViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmHISReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 652)
        Me.Controls.Add(Me.cprtViewer)
        Me.Controls.Add(Me.panelside)
        Me.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmHISReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "   SIMPLE HIS REPORTS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelside.ResumeLayout(False)
        Me.panelside.PerformLayout()
        Me.panelfilters.ResumeLayout(False)
        Me.gpfilterpurpose.ResumeLayout(False)
        Me.gpfilterpurpose.PerformLayout()
        Me.gpfilterpickdate.ResumeLayout(False)
        Me.gpfilterpickdate.PerformLayout()
        Me.gpfiltersearch.ResumeLayout(False)
        Me.gpfiltersearch.PerformLayout()
        Me.gpfiltercbshow.ResumeLayout(False)
        Me.gpfiltercbshow.PerformLayout()
        Me.gpfilteremployee.ResumeLayout(False)
        Me.gpfilteremployee.PerformLayout()
        Me.gpfilterentrydata.ResumeLayout(False)
        Me.gpfilterentrydata.PerformLayout()
        Me.gpfilteradmissions.ResumeLayout(False)
        Me.gpfilteradmissions.PerformLayout()
        Me.gpfilterpatient.ResumeLayout(False)
        Me.gpfilterpatient.PerformLayout()
        Me.gpfilterprocedure.ResumeLayout(False)
        Me.gpfilterprocedure.PerformLayout()
        Me.gpfiltericd10.ResumeLayout(False)
        Me.gpfiltericd10.PerformLayout()
        Me.gpfilteritemcategory.ResumeLayout(False)
        Me.gpfilteritemcategory.PerformLayout()
        Me.gpfilteradmissiontype.ResumeLayout(False)
        Me.gpfilteradmissiontype.PerformLayout()
        Me.gpfiltermonthly.ResumeLayout(False)
        Me.gpfiltermonthly.PerformLayout()
        Me.gpfiltersupplier.ResumeLayout(False)
        Me.gpfiltersupplier.PerformLayout()
        Me.gpfilteryearly.ResumeLayout(False)
        Me.gpfilteryearly.PerformLayout()
        Me.gpfilterlotno.ResumeLayout(False)
        Me.gpfilterlotno.PerformLayout()
        Me.gpfilteritem.ResumeLayout(False)
        Me.gpfilteritem.PerformLayout()
        Me.gpfilteroffice.ResumeLayout(False)
        Me.gpfilteroffice.PerformLayout()
        Me.gpfilterdatarange.ResumeLayout(False)
        Me.gpfilterdatarange.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelside As System.Windows.Forms.Panel
    Friend WithEvents cprtViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSubreports As System.Windows.Forms.ComboBox
    Friend WithEvents cmbReports As System.Windows.Forms.ComboBox
    Friend WithEvents panelfilters As System.Windows.Forms.Panel
    Friend WithEvents gpfilterdatarange As System.Windows.Forms.GroupBox
    Friend WithEvents dtpenddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStartdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gpfiltericd10 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtICD10Code As System.Windows.Forms.TextBox
    Friend WithEvents btnsearchicd10code As System.Windows.Forms.Button
    Friend WithEvents gpfilterprocedure As System.Windows.Forms.GroupBox
    Friend WithEvents btnsearchprocedure As System.Windows.Forms.Button
    Friend WithEvents txtprocedure As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gpfilterpatient As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchPatient As System.Windows.Forms.Button
    Friend WithEvents txtpatient As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gpfilterpickdate As System.Windows.Forms.GroupBox
    Friend WithEvents dtppickdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gpfiltermonthly As System.Windows.Forms.GroupBox
    Friend WithEvents dtpmonthly As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents gpfilteradmissiontype As System.Windows.Forms.GroupBox
    Friend WithEvents cmbadmissiontype As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents gpfilteradmissions As System.Windows.Forms.GroupBox
    Friend WithEvents btnsearchadmission As System.Windows.Forms.Button
    Friend WithEvents txtadmission As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents gpfilterpurpose As System.Windows.Forms.GroupBox
    Friend WithEvents txtPurpose As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents gpfilteremployee As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchEmployee As System.Windows.Forms.Button
    Friend WithEvents txtEmployee As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents gpfiltersupplier As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchSupplier As System.Windows.Forms.Button
    Friend WithEvents txtSupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents gpfilteroffice As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchOffice As System.Windows.Forms.Button
    Friend WithEvents txtOffice As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents gpfilteritemcategory As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchItemCategory As System.Windows.Forms.Button
    Friend WithEvents txtItemCategory As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents gpfilteritem As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchItem As System.Windows.Forms.Button
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents gpfilterlotno As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchLotno As System.Windows.Forms.Button
    Friend WithEvents txtLotNo As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblClearOffice As System.Windows.Forms.Label
    Friend WithEvents lblClearLotno As System.Windows.Forms.Label
    Friend WithEvents lblClearItem As System.Windows.Forms.Label
    Friend WithEvents lblClearCategory As System.Windows.Forms.Label
    Friend WithEvents lblClearSupplier As System.Windows.Forms.Label
    Friend WithEvents gpfiltersearch As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents gpfiltercbshow As System.Windows.Forms.GroupBox
    Friend WithEvents cbShow As System.Windows.Forms.CheckBox
    Friend WithEvents gpfilterentrydata As System.Windows.Forms.GroupBox
    Friend WithEvents txtEntryData As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblClearEmployee As System.Windows.Forms.Label
    Friend WithEvents lblClearAdmission As System.Windows.Forms.Label
    Friend WithEvents lblClearICD10 As System.Windows.Forms.Label
    Friend WithEvents lblClearPatient As System.Windows.Forms.Label
    Friend WithEvents lblClearProcedure As System.Windows.Forms.Label
    Friend WithEvents gpfilteryearly As System.Windows.Forms.GroupBox
    Friend WithEvents dtpYearly As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label23 As System.Windows.Forms.Label

End Class
