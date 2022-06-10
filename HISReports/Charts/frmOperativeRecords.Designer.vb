<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperativeRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOperativeRecords))
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.tsprintoptions = New System.Windows.Forms.ToolStripDropDownButton()
        Me.OperativeRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ORNursingRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreOperativeChecklistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SafetyChecklistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreAnestheticAssessmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsentForProcedureOperationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsClose = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnoperativediagnosis = New System.Windows.Forms.Button()
        Me.btnpreoperativediagnosis = New System.Windows.Forms.Button()
        Me.btnanesthesiologist = New System.Windows.Forms.Button()
        Me.btnsecondassistant = New System.Windows.Forms.Button()
        Me.btnfirstassistant = New System.Windows.Forms.Button()
        Me.btnsurgeon = New System.Windows.Forms.Button()
        Me.txtoperationdescription = New System.Windows.Forms.RichTextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txthisthopathologydiagnosis = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtmaterialforlab = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtoperativediagnosis = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtpreoperativediagnosis = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtanesthetic = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblanesthesiologist = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblsecondassistant = New System.Windows.Forms.Label()
        Me.lblfirstassistant = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblsurgeon = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btninstrumentnurse = New System.Windows.Forms.Button()
        Me.btnsurgicalnurse = New System.Windows.Forms.Button()
        Me.txtmedicines = New System.Windows.Forms.RichTextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtsutures = New System.Windows.Forms.RichTextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txtivfluids = New System.Windows.Forms.RichTextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtsyringes = New System.Windows.Forms.RichTextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtothersupplies = New System.Windows.Forms.RichTextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.dtpoperationend = New System.Windows.Forms.DateTimePicker()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.dtpoperationbegin = New System.Windows.Forms.DateTimePicker()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdisminor = New System.Windows.Forms.RadioButton()
        Me.rdismajor = New System.Windows.Forms.RadioButton()
        Me.txtdrains = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.chkspongecountverified = New System.Windows.Forms.CheckBox()
        Me.dtptimeend = New System.Windows.Forms.DateTimePicker()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.dtptimebegin = New System.Windows.Forms.DateTimePicker()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.lblinstrumentnurse = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lblsurgicalnurse = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.chkconfirmkeyconcerns = New System.Windows.Forms.CheckBox()
        Me.chkconfirmequipmentproblems = New System.Windows.Forms.CheckBox()
        Me.chkconfirmspecimenlabled = New System.Windows.Forms.CheckBox()
        Me.chkconfirmpinstrumentcountcorrect = New System.Windows.Forms.CheckBox()
        Me.chkconfirmprocedurename = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.rdantibioticprophylaxisno = New System.Windows.Forms.RadioButton()
        Me.rdantibioticprophylaxis = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.rdisimagingdisplayed = New System.Windows.Forms.RadioButton()
        Me.rdisimagingdisplayedno = New System.Windows.Forms.RadioButton()
        Me.chknurseteamreview = New System.Windows.Forms.CheckBox()
        Me.chkanesthersiareview = New System.Windows.Forms.CheckBox()
        Me.chksurgeonreview = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.chkverballyconfirmprocedure = New System.Windows.Forms.CheckBox()
        Me.chkverballyconfirmsite = New System.Windows.Forms.CheckBox()
        Me.chkverballyconfirmpatient = New System.Windows.Forms.CheckBox()
        Me.chkverballyconfirm = New System.Windows.Forms.CheckBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.chkintroducedmembers = New System.Windows.Forms.CheckBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.rdbloodlossriskno = New System.Windows.Forms.RadioButton()
        Me.rdbloodlossrisk = New System.Windows.Forms.RadioButton()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.rdaspirationriskno = New System.Windows.Forms.RadioButton()
        Me.rdaspirationrisk = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.rdknownallergyno = New System.Windows.Forms.RadioButton()
        Me.rdknownallergy = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.chkpulseoximeter = New System.Windows.Forms.CheckBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.chkanaesthesiasafetycheck = New System.Windows.Forms.CheckBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.chksitemarked = New System.Windows.Forms.CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.chkconfirmpatientconsent = New System.Windows.Forms.CheckBox()
        Me.chkconfirmpatientprocedure = New System.Windows.Forms.CheckBox()
        Me.chkconfirmpatientsite = New System.Windows.Forms.CheckBox()
        Me.chkconfirmpatientidentity = New System.Windows.Forms.CheckBox()
        Me.chkpatientconfirmed = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabpreoperative = New System.Windows.Forms.TabPage()
        Me.txtbpdiastolic = New System.Windows.Forms.TextBox()
        Me.dtptimeofmedication = New System.Windows.Forms.DateTimePicker()
        Me.txtrr = New System.Windows.Forms.TextBox()
        Me.txtcr = New System.Windows.Forms.TextBox()
        Me.txtamountcatheterized = New System.Windows.Forms.TextBox()
        Me.txtamountvoided = New System.Windows.Forms.TextBox()
        Me.dtptimebp = New System.Windows.Forms.DateTimePicker()
        Me.txtpreoperativemedication = New System.Windows.Forms.TextBox()
        Me.txtbpsystolic = New System.Windows.Forms.TextBox()
        Me.txttemp = New System.Windows.Forms.TextBox()
        Me.dtptimecatheterized = New System.Windows.Forms.DateTimePicker()
        Me.dtptimevoided = New System.Windows.Forms.DateTimePicker()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.chkcatheterized = New System.Windows.Forms.CheckBox()
        Me.chkvoided = New System.Windows.Forms.CheckBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.txtxrayreports = New System.Windows.Forms.TextBox()
        Me.txturine = New System.Windows.Forms.TextBox()
        Me.txtroutinebloodreps = New System.Windows.Forms.TextBox()
        Me.txtxmatching = New System.Windows.Forms.TextBox()
        Me.txtconsentsigned = New System.Windows.Forms.TextBox()
        Me.txtdenturesremoved = New System.Windows.Forms.TextBox()
        Me.txtjewelryremoved = New System.Windows.Forms.TextBox()
        Me.txtnailpolishremoved = New System.Windows.Forms.TextBox()
        Me.txtheadcap = New System.Windows.Forms.TextBox()
        Me.txthairpinremoved = New System.Windows.Forms.TextBox()
        Me.txtunderwearremoved = New System.Windows.Forms.TextBox()
        Me.txtpatientgowned = New System.Windows.Forms.TextBox()
        Me.txtsiteinspectedbyhn = New System.Windows.Forms.TextBox()
        Me.txtsiteshaved = New System.Windows.Forms.TextBox()
        Me.Panel56 = New System.Windows.Forms.Panel()
        Me.chkxrayreports = New System.Windows.Forms.CheckBox()
        Me.Panel55 = New System.Windows.Forms.Panel()
        Me.chkurine = New System.Windows.Forms.CheckBox()
        Me.Panel53 = New System.Windows.Forms.Panel()
        Me.chkroutinebloodreps = New System.Windows.Forms.CheckBox()
        Me.Panel54 = New System.Windows.Forms.Panel()
        Me.chkxmatching = New System.Windows.Forms.CheckBox()
        Me.Panel52 = New System.Windows.Forms.Panel()
        Me.chkconsentsigned = New System.Windows.Forms.CheckBox()
        Me.Panel48 = New System.Windows.Forms.Panel()
        Me.chkdenturesremoved = New System.Windows.Forms.CheckBox()
        Me.Panel49 = New System.Windows.Forms.Panel()
        Me.chkjewelryremoved = New System.Windows.Forms.CheckBox()
        Me.Panel50 = New System.Windows.Forms.Panel()
        Me.chknailpolishremoved = New System.Windows.Forms.CheckBox()
        Me.Panel46 = New System.Windows.Forms.Panel()
        Me.chkheadcap = New System.Windows.Forms.CheckBox()
        Me.Panel47 = New System.Windows.Forms.Panel()
        Me.chkhairpinremoved = New System.Windows.Forms.CheckBox()
        Me.Panel44 = New System.Windows.Forms.Panel()
        Me.chkunderwearremoved = New System.Windows.Forms.CheckBox()
        Me.Panel45 = New System.Windows.Forms.Panel()
        Me.chkpatientgowned = New System.Windows.Forms.CheckBox()
        Me.Panel42 = New System.Windows.Forms.Panel()
        Me.chksiteinspectedbyhn = New System.Windows.Forms.CheckBox()
        Me.Panel41 = New System.Windows.Forms.Panel()
        Me.chksiteshaved = New System.Windows.Forms.CheckBox()
        Me.Panel39 = New System.Windows.Forms.Panel()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Panel40 = New System.Windows.Forms.Panel()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Panel38 = New System.Windows.Forms.Panel()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Panel37 = New System.Windows.Forms.Panel()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Panel35 = New System.Windows.Forms.Panel()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Panel36 = New System.Windows.Forms.Panel()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Panel33 = New System.Windows.Forms.Panel()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel97 = New System.Windows.Forms.Panel()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.Panel96 = New System.Windows.Forms.Panel()
        Me.txtpreoperativemedication2 = New System.Windows.Forms.TextBox()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.Panel95 = New System.Windows.Forms.Panel()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.Panel94 = New System.Windows.Forms.Panel()
        Me.txtphysicalexam = New System.Windows.Forms.TextBox()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.Panel93 = New System.Windows.Forms.Panel()
        Me.txtsignificanthistory = New System.Windows.Forms.TextBox()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.Panel92 = New System.Windows.Forms.Panel()
        Me.txtotherphysicalstatus = New System.Windows.Forms.TextBox()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.txtbiochem = New System.Windows.Forms.TextBox()
        Me.Panel91 = New System.Windows.Forms.Panel()
        Me.txtec = New System.Windows.Forms.TextBox()
        Me.txtcxr = New System.Windows.Forms.TextBox()
        Me.txthb = New System.Windows.Forms.TextBox()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.Panel84 = New System.Windows.Forms.Panel()
        Me.txtweight = New System.Windows.Forms.TextBox()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.Panel89 = New System.Windows.Forms.Panel()
        Me.chkispregnant = New System.Windows.Forms.CheckBox()
        Me.Panel90 = New System.Windows.Forms.Panel()
        Me.chkhasallergies = New System.Windows.Forms.CheckBox()
        Me.Panel85 = New System.Windows.Forms.Panel()
        Me.chkhasrheumaticfever = New System.Windows.Forms.CheckBox()
        Me.Panel86 = New System.Windows.Forms.Panel()
        Me.chkhasepilepsy = New System.Windows.Forms.CheckBox()
        Me.Panel87 = New System.Windows.Forms.Panel()
        Me.chkhasdiabetes = New System.Windows.Forms.CheckBox()
        Me.Panel88 = New System.Windows.Forms.Panel()
        Me.chkhaskidneydisease = New System.Windows.Forms.CheckBox()
        Me.Panel80 = New System.Windows.Forms.Panel()
        Me.chkhashepatitis = New System.Windows.Forms.CheckBox()
        Me.Panel81 = New System.Windows.Forms.Panel()
        Me.chkhasasthma = New System.Windows.Forms.CheckBox()
        Me.Panel82 = New System.Windows.Forms.Panel()
        Me.chkhaschroniclungdisease = New System.Windows.Forms.CheckBox()
        Me.Panel78 = New System.Windows.Forms.Panel()
        Me.chkhasangina = New System.Windows.Forms.CheckBox()
        Me.Panel79 = New System.Windows.Forms.Panel()
        Me.chkhasstroke = New System.Windows.Forms.CheckBox()
        Me.Panel76 = New System.Windows.Forms.Panel()
        Me.chkhashighblood = New System.Windows.Forms.CheckBox()
        Me.Panel77 = New System.Windows.Forms.Panel()
        Me.Panel75 = New System.Windows.Forms.Panel()
        Me.Panel73 = New System.Windows.Forms.Panel()
        Me.Panel74 = New System.Windows.Forms.Panel()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.Panel72 = New System.Windows.Forms.Panel()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.Panel68 = New System.Windows.Forms.Panel()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.Panel69 = New System.Windows.Forms.Panel()
        Me.txtdrugstaken = New System.Windows.Forms.TextBox()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Panel70 = New System.Windows.Forms.Panel()
        Me.txtotherdiseases = New System.Windows.Forms.TextBox()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Panel71 = New System.Windows.Forms.Panel()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.Panel65 = New System.Windows.Forms.Panel()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Panel66 = New System.Windows.Forms.Panel()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Panel67 = New System.Windows.Forms.Panel()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.Panel62 = New System.Windows.Forms.Panel()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Panel63 = New System.Windows.Forms.Panel()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Panel64 = New System.Windows.Forms.Panel()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Panel61 = New System.Windows.Forms.Panel()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Panel60 = New System.Windows.Forms.Panel()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Panel59 = New System.Windows.Forms.Panel()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Panel58 = New System.Windows.Forms.Panel()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Panel57 = New System.Windows.Forms.Panel()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Panel51 = New System.Windows.Forms.Panel()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Panel43 = New System.Windows.Forms.Panel()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbprocedurename = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtpproceduredate = New System.Windows.Forms.DateTimePicker()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.chkhaspreviousanesthesia = New System.Windows.Forms.CheckBox()
        Me.chkhasheartattack = New System.Windows.Forms.CheckBox()
        Me.chkhasesthesiaproblem = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tabpreoperative.SuspendLayout()
        Me.Panel56.SuspendLayout()
        Me.Panel55.SuspendLayout()
        Me.Panel53.SuspendLayout()
        Me.Panel54.SuspendLayout()
        Me.Panel52.SuspendLayout()
        Me.Panel48.SuspendLayout()
        Me.Panel49.SuspendLayout()
        Me.Panel50.SuspendLayout()
        Me.Panel46.SuspendLayout()
        Me.Panel47.SuspendLayout()
        Me.Panel44.SuspendLayout()
        Me.Panel45.SuspendLayout()
        Me.Panel42.SuspendLayout()
        Me.Panel41.SuspendLayout()
        Me.Panel39.SuspendLayout()
        Me.Panel40.SuspendLayout()
        Me.Panel38.SuspendLayout()
        Me.Panel37.SuspendLayout()
        Me.Panel35.SuspendLayout()
        Me.Panel36.SuspendLayout()
        Me.Panel34.SuspendLayout()
        Me.Panel33.SuspendLayout()
        Me.Panel32.SuspendLayout()
        Me.Panel30.SuspendLayout()
        Me.Panel31.SuspendLayout()
        Me.Panel29.SuspendLayout()
        Me.Panel28.SuspendLayout()
        Me.Panel27.SuspendLayout()
        Me.Panel26.SuspendLayout()
        Me.Panel25.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel97.SuspendLayout()
        Me.Panel96.SuspendLayout()
        Me.Panel95.SuspendLayout()
        Me.Panel94.SuspendLayout()
        Me.Panel93.SuspendLayout()
        Me.Panel92.SuspendLayout()
        Me.Panel91.SuspendLayout()
        Me.Panel84.SuspendLayout()
        Me.Panel89.SuspendLayout()
        Me.Panel90.SuspendLayout()
        Me.Panel85.SuspendLayout()
        Me.Panel86.SuspendLayout()
        Me.Panel87.SuspendLayout()
        Me.Panel88.SuspendLayout()
        Me.Panel80.SuspendLayout()
        Me.Panel81.SuspendLayout()
        Me.Panel82.SuspendLayout()
        Me.Panel78.SuspendLayout()
        Me.Panel79.SuspendLayout()
        Me.Panel76.SuspendLayout()
        Me.Panel77.SuspendLayout()
        Me.Panel75.SuspendLayout()
        Me.Panel73.SuspendLayout()
        Me.Panel74.SuspendLayout()
        Me.Panel72.SuspendLayout()
        Me.Panel68.SuspendLayout()
        Me.Panel69.SuspendLayout()
        Me.Panel70.SuspendLayout()
        Me.Panel71.SuspendLayout()
        Me.Panel65.SuspendLayout()
        Me.Panel66.SuspendLayout()
        Me.Panel67.SuspendLayout()
        Me.Panel62.SuspendLayout()
        Me.Panel63.SuspendLayout()
        Me.Panel64.SuspendLayout()
        Me.Panel61.SuspendLayout()
        Me.Panel60.SuspendLayout()
        Me.Panel59.SuspendLayout()
        Me.Panel58.SuspendLayout()
        Me.Panel57.SuspendLayout()
        Me.Panel51.SuspendLayout()
        Me.Panel43.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(12, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1132, 50)
        Me.Panel1.TabIndex = 256
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label28.Location = New System.Drawing.Point(488, 2)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(77, 13)
        Me.Label28.TabIndex = 247
        Me.Label28.Text = "Date Admitted:"
        '
        'lblDateAdmitted
        '
        Me.lblDateAdmitted.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblDateAdmitted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateAdmitted.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.lblDateAdmitted.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDateAdmitted.Location = New System.Drawing.Point(489, 18)
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
        Me.lblage.Location = New System.Drawing.Point(757, 18)
        Me.lblage.Name = "lblage"
        Me.lblage.Size = New System.Drawing.Size(50, 20)
        Me.lblage.TabIndex = 245
        Me.lblage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label303
        '
        Me.Label303.AutoSize = True
        Me.Label303.Location = New System.Drawing.Point(757, 5)
        Me.Label303.Name = "Label303"
        Me.Label303.Size = New System.Drawing.Size(29, 13)
        Me.Label303.TabIndex = 244
        Me.Label303.Text = "Age:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(610, 5)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(57, 13)
        Me.Label30.TabIndex = 226
        Me.Label30.Text = "Birth Date:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(120, 5)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(43, 13)
        Me.Label29.TabIndex = 227
        Me.Label29.Text = "Patient:"
        '
        'lblSex
        '
        Me.lblSex.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSex.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.lblSex.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblSex.Location = New System.Drawing.Point(813, 18)
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
        Me.lblPno.Size = New System.Drawing.Size(63, 13)
        Me.lblPno.TabIndex = 231
        Me.lblPno.Text = "Patient No.:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(813, 5)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(45, 13)
        Me.Label26.TabIndex = 239
        Me.Label26.Text = "Gender:"
        '
        'lblBirthDate
        '
        Me.lblBirthDate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblBirthDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBirthDate.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.lblBirthDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblBirthDate.Location = New System.Drawing.Point(613, 18)
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
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.tsSave, Me.tsprintoptions, Me.ToolStripSeparator3, Me.tsClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1272, 37)
        Me.ToolStrip1.TabIndex = 257
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
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
        'tsprintoptions
        '
        Me.tsprintoptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperativeRecordToolStripMenuItem, Me.ORNursingRecordToolStripMenuItem, Me.PreOperativeChecklistToolStripMenuItem, Me.SafetyChecklistToolStripMenuItem, Me.PreAnestheticAssessmentToolStripMenuItem, Me.ConsentForProcedureOperationToolStripMenuItem})
        Me.tsprintoptions.Image = Global.HISReports.My.Resources.Resources.printer
        Me.tsprintoptions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsprintoptions.Name = "tsprintoptions"
        Me.tsprintoptions.Size = New System.Drawing.Size(45, 34)
        Me.tsprintoptions.Text = "Print"
        Me.tsprintoptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'OperativeRecordToolStripMenuItem
        '
        Me.OperativeRecordToolStripMenuItem.Name = "OperativeRecordToolStripMenuItem"
        Me.OperativeRecordToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.OperativeRecordToolStripMenuItem.Text = "Operative Record"
        '
        'ORNursingRecordToolStripMenuItem
        '
        Me.ORNursingRecordToolStripMenuItem.Name = "ORNursingRecordToolStripMenuItem"
        Me.ORNursingRecordToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.ORNursingRecordToolStripMenuItem.Text = "OR Nursing Record"
        '
        'PreOperativeChecklistToolStripMenuItem
        '
        Me.PreOperativeChecklistToolStripMenuItem.Name = "PreOperativeChecklistToolStripMenuItem"
        Me.PreOperativeChecklistToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.PreOperativeChecklistToolStripMenuItem.Text = "Pre-Operative Checklist"
        '
        'SafetyChecklistToolStripMenuItem
        '
        Me.SafetyChecklistToolStripMenuItem.Name = "SafetyChecklistToolStripMenuItem"
        Me.SafetyChecklistToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.SafetyChecklistToolStripMenuItem.Text = "Safety Checklist"
        '
        'PreAnestheticAssessmentToolStripMenuItem
        '
        Me.PreAnestheticAssessmentToolStripMenuItem.Name = "PreAnestheticAssessmentToolStripMenuItem"
        Me.PreAnestheticAssessmentToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.PreAnestheticAssessmentToolStripMenuItem.Text = "Pre-Anesthetic Assessment"
        '
        'ConsentForProcedureOperationToolStripMenuItem
        '
        Me.ConsentForProcedureOperationToolStripMenuItem.Name = "ConsentForProcedureOperationToolStripMenuItem"
        Me.ConsentForProcedureOperationToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.ConsentForProcedureOperationToolStripMenuItem.Text = "Consent for Procedure/Operation"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 37)
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
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.tabpreoperative)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 125)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1248, 576)
        Me.TabControl1.TabIndex = 258
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnoperativediagnosis)
        Me.TabPage1.Controls.Add(Me.btnpreoperativediagnosis)
        Me.TabPage1.Controls.Add(Me.btnanesthesiologist)
        Me.TabPage1.Controls.Add(Me.btnsecondassistant)
        Me.TabPage1.Controls.Add(Me.btnfirstassistant)
        Me.TabPage1.Controls.Add(Me.btnsurgeon)
        Me.TabPage1.Controls.Add(Me.txtoperationdescription)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.txthisthopathologydiagnosis)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.txtmaterialforlab)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.txtoperativediagnosis)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.txtpreoperativediagnosis)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.txtanesthetic)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.lblanesthesiologist)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.lblsecondassistant)
        Me.TabPage1.Controls.Add(Me.lblfirstassistant)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.lblsurgeon)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1240, 549)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Operative Record"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnoperativediagnosis
        '
        Me.btnoperativediagnosis.Image = Global.HISReports.My.Resources.Resources.search_glyph
        Me.btnoperativediagnosis.Location = New System.Drawing.Point(802, 145)
        Me.btnoperativediagnosis.Name = "btnoperativediagnosis"
        Me.btnoperativediagnosis.Size = New System.Drawing.Size(29, 26)
        Me.btnoperativediagnosis.TabIndex = 25
        Me.btnoperativediagnosis.UseVisualStyleBackColor = True
        '
        'btnpreoperativediagnosis
        '
        Me.btnpreoperativediagnosis.Image = Global.HISReports.My.Resources.Resources.search_glyph
        Me.btnpreoperativediagnosis.Location = New System.Drawing.Point(386, 145)
        Me.btnpreoperativediagnosis.Name = "btnpreoperativediagnosis"
        Me.btnpreoperativediagnosis.Size = New System.Drawing.Size(29, 26)
        Me.btnpreoperativediagnosis.TabIndex = 24
        Me.btnpreoperativediagnosis.UseVisualStyleBackColor = True
        '
        'btnanesthesiologist
        '
        Me.btnanesthesiologist.Image = Global.HISReports.My.Resources.Resources.search_glyph
        Me.btnanesthesiologist.Location = New System.Drawing.Point(387, 91)
        Me.btnanesthesiologist.Name = "btnanesthesiologist"
        Me.btnanesthesiologist.Size = New System.Drawing.Size(29, 26)
        Me.btnanesthesiologist.TabIndex = 23
        Me.btnanesthesiologist.UseVisualStyleBackColor = True
        '
        'btnsecondassistant
        '
        Me.btnsecondassistant.Image = Global.HISReports.My.Resources.Resources.search_glyph
        Me.btnsecondassistant.Location = New System.Drawing.Point(1201, 38)
        Me.btnsecondassistant.Name = "btnsecondassistant"
        Me.btnsecondassistant.Size = New System.Drawing.Size(29, 26)
        Me.btnsecondassistant.TabIndex = 22
        Me.btnsecondassistant.UseVisualStyleBackColor = True
        '
        'btnfirstassistant
        '
        Me.btnfirstassistant.Image = Global.HISReports.My.Resources.Resources.search_glyph
        Me.btnfirstassistant.Location = New System.Drawing.Point(802, 38)
        Me.btnfirstassistant.Name = "btnfirstassistant"
        Me.btnfirstassistant.Size = New System.Drawing.Size(29, 26)
        Me.btnfirstassistant.TabIndex = 21
        Me.btnfirstassistant.UseVisualStyleBackColor = True
        '
        'btnsurgeon
        '
        Me.btnsurgeon.Image = Global.HISReports.My.Resources.Resources.search_glyph
        Me.btnsurgeon.Location = New System.Drawing.Point(387, 38)
        Me.btnsurgeon.Name = "btnsurgeon"
        Me.btnsurgeon.Size = New System.Drawing.Size(29, 26)
        Me.btnsurgeon.TabIndex = 20
        Me.btnsurgeon.UseVisualStyleBackColor = True
        '
        'txtoperationdescription
        '
        Me.txtoperationdescription.Location = New System.Drawing.Point(16, 317)
        Me.txtoperationdescription.Name = "txtoperationdescription"
        Me.txtoperationdescription.Size = New System.Drawing.Size(1197, 217)
        Me.txtoperationdescription.TabIndex = 19
        Me.txtoperationdescription.Text = ""
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(13, 300)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(140, 14)
        Me.Label31.TabIndex = 18
        Me.Label31.Text = "Description of Operation"
        '
        'txthisthopathologydiagnosis
        '
        Me.txthisthopathologydiagnosis.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthisthopathologydiagnosis.Location = New System.Drawing.Point(431, 225)
        Me.txthisthopathologydiagnosis.Multiline = True
        Me.txthisthopathologydiagnosis.Name = "txthisthopathologydiagnosis"
        Me.txthisthopathologydiagnosis.Size = New System.Drawing.Size(370, 53)
        Me.txthisthopathologydiagnosis.TabIndex = 17
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(428, 211)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(145, 14)
        Me.Label27.TabIndex = 16
        Me.Label27.Text = "Histopathology Diagnosis:"
        '
        'txtmaterialforlab
        '
        Me.txtmaterialforlab.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmaterialforlab.Location = New System.Drawing.Point(16, 225)
        Me.txtmaterialforlab.Multiline = True
        Me.txtmaterialforlab.Name = "txtmaterialforlab"
        Me.txtmaterialforlab.Size = New System.Drawing.Size(370, 53)
        Me.txtmaterialforlab.TabIndex = 15
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(13, 211)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(280, 14)
        Me.Label25.TabIndex = 14
        Me.Label25.Text = "Material Forwarded to Laboratory for Examination:"
        '
        'txtoperativediagnosis
        '
        Me.txtoperativediagnosis.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoperativediagnosis.Location = New System.Drawing.Point(431, 145)
        Me.txtoperativediagnosis.Multiline = True
        Me.txtoperativediagnosis.Name = "txtoperativediagnosis"
        Me.txtoperativediagnosis.Size = New System.Drawing.Size(370, 53)
        Me.txtoperativediagnosis.TabIndex = 13
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(428, 131)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(117, 14)
        Me.Label24.TabIndex = 12
        Me.Label24.Text = "Operative Diagnosis:"
        '
        'txtpreoperativediagnosis
        '
        Me.txtpreoperativediagnosis.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpreoperativediagnosis.Location = New System.Drawing.Point(15, 145)
        Me.txtpreoperativediagnosis.Multiline = True
        Me.txtpreoperativediagnosis.Name = "txtpreoperativediagnosis"
        Me.txtpreoperativediagnosis.Size = New System.Drawing.Size(370, 53)
        Me.txtpreoperativediagnosis.TabIndex = 11
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(12, 131)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(135, 14)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "PreOperative Diagnosis:"
        '
        'txtanesthetic
        '
        Me.txtanesthetic.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtanesthetic.Location = New System.Drawing.Point(431, 91)
        Me.txtanesthetic.Name = "txtanesthetic"
        Me.txtanesthetic.Size = New System.Drawing.Size(370, 23)
        Me.txtanesthetic.TabIndex = 9
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(428, 77)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(70, 14)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Anesthetic:"
        '
        'lblanesthesiologist
        '
        Me.lblanesthesiologist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblanesthesiologist.Location = New System.Drawing.Point(16, 91)
        Me.lblanesthesiologist.Name = "lblanesthesiologist"
        Me.lblanesthesiologist.Size = New System.Drawing.Size(370, 26)
        Me.lblanesthesiologist.TabIndex = 7
        Me.lblanesthesiologist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(13, 77)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(103, 14)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Anesthesiologist :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(840, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 14)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "2nd Assistant :"
        '
        'lblsecondassistant
        '
        Me.lblsecondassistant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblsecondassistant.Location = New System.Drawing.Point(843, 38)
        Me.lblsecondassistant.Name = "lblsecondassistant"
        Me.lblsecondassistant.Size = New System.Drawing.Size(357, 26)
        Me.lblsecondassistant.TabIndex = 4
        Me.lblsecondassistant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblfirstassistant
        '
        Me.lblfirstassistant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblfirstassistant.Location = New System.Drawing.Point(431, 38)
        Me.lblfirstassistant.Name = "lblfirstassistant"
        Me.lblfirstassistant.Size = New System.Drawing.Size(370, 26)
        Me.lblfirstassistant.TabIndex = 3
        Me.lblfirstassistant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(428, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 14)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "1st Assistant :"
        '
        'lblsurgeon
        '
        Me.lblsurgeon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblsurgeon.Location = New System.Drawing.Point(16, 38)
        Me.lblsurgeon.Name = "lblsurgeon"
        Me.lblsurgeon.Size = New System.Drawing.Size(370, 26)
        Me.lblsurgeon.TabIndex = 1
        Me.lblsurgeon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 14)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Surgeon :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btninstrumentnurse)
        Me.TabPage2.Controls.Add(Me.btnsurgicalnurse)
        Me.TabPage2.Controls.Add(Me.txtmedicines)
        Me.TabPage2.Controls.Add(Me.Label44)
        Me.TabPage2.Controls.Add(Me.txtsutures)
        Me.TabPage2.Controls.Add(Me.Label45)
        Me.TabPage2.Controls.Add(Me.txtivfluids)
        Me.TabPage2.Controls.Add(Me.Label43)
        Me.TabPage2.Controls.Add(Me.txtsyringes)
        Me.TabPage2.Controls.Add(Me.Label42)
        Me.TabPage2.Controls.Add(Me.txtothersupplies)
        Me.TabPage2.Controls.Add(Me.Label41)
        Me.TabPage2.Controls.Add(Me.dtpoperationend)
        Me.TabPage2.Controls.Add(Me.Label39)
        Me.TabPage2.Controls.Add(Me.dtpoperationbegin)
        Me.TabPage2.Controls.Add(Me.Label40)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.txtdrains)
        Me.TabPage2.Controls.Add(Me.Label38)
        Me.TabPage2.Controls.Add(Me.chkspongecountverified)
        Me.TabPage2.Controls.Add(Me.dtptimeend)
        Me.TabPage2.Controls.Add(Me.Label37)
        Me.TabPage2.Controls.Add(Me.dtptimebegin)
        Me.TabPage2.Controls.Add(Me.Label36)
        Me.TabPage2.Controls.Add(Me.lblinstrumentnurse)
        Me.TabPage2.Controls.Add(Me.Label35)
        Me.TabPage2.Controls.Add(Me.lblsurgicalnurse)
        Me.TabPage2.Controls.Add(Me.Label33)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1240, 549)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Nursing Record"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btninstrumentnurse
        '
        Me.btninstrumentnurse.Image = Global.HISReports.My.Resources.Resources.search_glyph
        Me.btninstrumentnurse.Location = New System.Drawing.Point(802, 37)
        Me.btninstrumentnurse.Name = "btninstrumentnurse"
        Me.btninstrumentnurse.Size = New System.Drawing.Size(29, 26)
        Me.btninstrumentnurse.TabIndex = 31
        Me.btninstrumentnurse.UseVisualStyleBackColor = True
        '
        'btnsurgicalnurse
        '
        Me.btnsurgicalnurse.Image = Global.HISReports.My.Resources.Resources.search_glyph
        Me.btnsurgicalnurse.Location = New System.Drawing.Point(387, 38)
        Me.btnsurgicalnurse.Name = "btnsurgicalnurse"
        Me.btnsurgicalnurse.Size = New System.Drawing.Size(29, 26)
        Me.btnsurgicalnurse.TabIndex = 30
        Me.btnsurgicalnurse.UseVisualStyleBackColor = True
        '
        'txtmedicines
        '
        Me.txtmedicines.Location = New System.Drawing.Point(843, 374)
        Me.txtmedicines.Name = "txtmedicines"
        Me.txtmedicines.Size = New System.Drawing.Size(370, 160)
        Me.txtmedicines.TabIndex = 29
        Me.txtmedicines.Text = ""
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(840, 357)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(105, 14)
        Me.Label44.TabIndex = 28
        Me.Label44.Text = "Medications Order"
        '
        'txtsutures
        '
        Me.txtsutures.Location = New System.Drawing.Point(843, 185)
        Me.txtsutures.Name = "txtsutures"
        Me.txtsutures.Size = New System.Drawing.Size(370, 160)
        Me.txtsutures.TabIndex = 27
        Me.txtsutures.Text = ""
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(840, 168)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(49, 14)
        Me.Label45.TabIndex = 26
        Me.Label45.Text = "Sutures"
        '
        'txtivfluids
        '
        Me.txtivfluids.Location = New System.Drawing.Point(431, 374)
        Me.txtivfluids.Name = "txtivfluids"
        Me.txtivfluids.Size = New System.Drawing.Size(370, 160)
        Me.txtivfluids.TabIndex = 25
        Me.txtivfluids.Text = ""
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(428, 357)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(60, 14)
        Me.Label43.TabIndex = 24
        Me.Label43.Text = "I.V. Fluids"
        '
        'txtsyringes
        '
        Me.txtsyringes.Location = New System.Drawing.Point(431, 185)
        Me.txtsyringes.Name = "txtsyringes"
        Me.txtsyringes.Size = New System.Drawing.Size(370, 160)
        Me.txtsyringes.TabIndex = 23
        Me.txtsyringes.Text = ""
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(428, 168)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(52, 14)
        Me.Label42.TabIndex = 22
        Me.Label42.Text = "Syringes"
        '
        'txtothersupplies
        '
        Me.txtothersupplies.Location = New System.Drawing.Point(16, 185)
        Me.txtothersupplies.Name = "txtothersupplies"
        Me.txtothersupplies.Size = New System.Drawing.Size(370, 349)
        Me.txtothersupplies.TabIndex = 21
        Me.txtothersupplies.Text = ""
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(13, 168)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(118, 14)
        Me.Label41.TabIndex = 20
        Me.Label41.Text = "Other Supplies Used"
        '
        'dtpoperationend
        '
        Me.dtpoperationend.CustomFormat = "hh:mm tt"
        Me.dtpoperationend.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpoperationend.Location = New System.Drawing.Point(969, 99)
        Me.dtpoperationend.Name = "dtpoperationend"
        Me.dtpoperationend.Size = New System.Drawing.Size(103, 22)
        Me.dtpoperationend.TabIndex = 19
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(966, 83)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(104, 14)
        Me.Label39.TabIndex = 18
        Me.Label39.Text = "Operation Ended:"
        '
        'dtpoperationbegin
        '
        Me.dtpoperationbegin.CustomFormat = "hh:mm tt"
        Me.dtpoperationbegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpoperationbegin.Location = New System.Drawing.Point(843, 99)
        Me.dtpoperationbegin.Name = "dtpoperationbegin"
        Me.dtpoperationbegin.Size = New System.Drawing.Size(104, 22)
        Me.dtpoperationbegin.TabIndex = 17
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(840, 83)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(103, 14)
        Me.Label40.TabIndex = 16
        Me.Label40.Text = "Operation Began:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdisminor)
        Me.GroupBox1.Controls.Add(Me.rdismajor)
        Me.GroupBox1.Location = New System.Drawing.Point(431, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 67)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type of Operation"
        '
        'rdisminor
        '
        Me.rdisminor.AutoSize = True
        Me.rdisminor.Location = New System.Drawing.Point(203, 31)
        Me.rdisminor.Name = "rdisminor"
        Me.rdisminor.Size = New System.Drawing.Size(54, 18)
        Me.rdisminor.TabIndex = 1
        Me.rdisminor.TabStop = True
        Me.rdisminor.Text = "Minor"
        Me.rdisminor.UseVisualStyleBackColor = True
        '
        'rdismajor
        '
        Me.rdismajor.AutoSize = True
        Me.rdismajor.Location = New System.Drawing.Point(67, 31)
        Me.rdismajor.Name = "rdismajor"
        Me.rdismajor.Size = New System.Drawing.Size(54, 18)
        Me.rdismajor.TabIndex = 0
        Me.rdismajor.TabStop = True
        Me.rdismajor.Text = "Major"
        Me.rdismajor.UseVisualStyleBackColor = True
        '
        'txtdrains
        '
        Me.txtdrains.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdrains.Location = New System.Drawing.Point(16, 97)
        Me.txtdrains.Multiline = True
        Me.txtdrains.Name = "txtdrains"
        Me.txtdrains.Size = New System.Drawing.Size(370, 53)
        Me.txtdrains.TabIndex = 13
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(13, 83)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(147, 14)
        Me.Label38.TabIndex = 12
        Me.Label38.Text = "Drains (Kind and Number)"
        '
        'chkspongecountverified
        '
        Me.chkspongecountverified.AutoSize = True
        Me.chkspongecountverified.Location = New System.Drawing.Point(1086, 42)
        Me.chkspongecountverified.Name = "chkspongecountverified"
        Me.chkspongecountverified.Size = New System.Drawing.Size(150, 18)
        Me.chkspongecountverified.TabIndex = 10
        Me.chkspongecountverified.Text = "Sponge Count Verified"
        Me.chkspongecountverified.UseVisualStyleBackColor = True
        '
        'dtptimeend
        '
        Me.dtptimeend.CustomFormat = "hh:mm tt"
        Me.dtptimeend.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptimeend.Location = New System.Drawing.Point(969, 40)
        Me.dtptimeend.Name = "dtptimeend"
        Me.dtptimeend.Size = New System.Drawing.Size(103, 22)
        Me.dtptimeend.TabIndex = 9
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(966, 24)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(63, 14)
        Me.Label37.TabIndex = 8
        Me.Label37.Text = "Time End:"
        '
        'dtptimebegin
        '
        Me.dtptimebegin.CustomFormat = "hh:mm tt"
        Me.dtptimebegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptimebegin.Location = New System.Drawing.Point(843, 40)
        Me.dtptimebegin.Name = "dtptimebegin"
        Me.dtptimebegin.Size = New System.Drawing.Size(104, 22)
        Me.dtptimebegin.TabIndex = 7
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(840, 24)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 14)
        Me.Label36.TabIndex = 6
        Me.Label36.Text = "Time Begin:"
        '
        'lblinstrumentnurse
        '
        Me.lblinstrumentnurse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblinstrumentnurse.Location = New System.Drawing.Point(431, 38)
        Me.lblinstrumentnurse.Name = "lblinstrumentnurse"
        Me.lblinstrumentnurse.Size = New System.Drawing.Size(370, 26)
        Me.lblinstrumentnurse.TabIndex = 5
        Me.lblinstrumentnurse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(428, 24)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(107, 14)
        Me.Label35.TabIndex = 4
        Me.Label35.Text = "Instrument Nurse:"
        '
        'lblsurgicalnurse
        '
        Me.lblsurgicalnurse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblsurgicalnurse.Location = New System.Drawing.Point(16, 38)
        Me.lblsurgicalnurse.Name = "lblsurgicalnurse"
        Me.lblsurgicalnurse.Size = New System.Drawing.Size(370, 26)
        Me.lblsurgicalnurse.TabIndex = 3
        Me.lblsurgicalnurse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(13, 24)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(87, 14)
        Me.Label33.TabIndex = 2
        Me.Label33.Text = "Surgical Nurse:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel21)
        Me.TabPage3.Controls.Add(Me.Panel19)
        Me.TabPage3.Controls.Add(Me.Panel20)
        Me.TabPage3.Controls.Add(Me.Panel16)
        Me.TabPage3.Controls.Add(Me.Panel15)
        Me.TabPage3.Controls.Add(Me.Panel14)
        Me.TabPage3.Controls.Add(Me.Panel12)
        Me.TabPage3.Controls.Add(Me.Panel13)
        Me.TabPage3.Controls.Add(Me.Panel8)
        Me.TabPage3.Controls.Add(Me.Panel7)
        Me.TabPage3.Controls.Add(Me.Panel6)
        Me.TabPage3.Controls.Add(Me.Panel5)
        Me.TabPage3.Controls.Add(Me.Panel4)
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1240, 549)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Safety Checklist"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel21
        '
        Me.Panel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel21.Controls.Add(Me.chkconfirmkeyconcerns)
        Me.Panel21.Controls.Add(Me.chkconfirmequipmentproblems)
        Me.Panel21.Controls.Add(Me.chkconfirmspecimenlabled)
        Me.Panel21.Controls.Add(Me.chkconfirmpinstrumentcountcorrect)
        Me.Panel21.Controls.Add(Me.chkconfirmprocedurename)
        Me.Panel21.Controls.Add(Me.Label6)
        Me.Panel21.Location = New System.Drawing.Point(820, 67)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(403, 402)
        Me.Panel21.TabIndex = 14
        '
        'chkconfirmkeyconcerns
        '
        Me.chkconfirmkeyconcerns.Location = New System.Drawing.Point(3, 205)
        Me.chkconfirmkeyconcerns.Name = "chkconfirmkeyconcerns"
        Me.chkconfirmkeyconcerns.Size = New System.Drawing.Size(395, 57)
        Me.chkconfirmkeyconcerns.TabIndex = 19
        Me.chkconfirmkeyconcerns.Text = "SURGEON, ANAESTHESIA PROFESSIONAL AND NURSES REVIEW THE KEY CONCERNS FOR RECOVERY" & _
    " AND MANAGEMENT OF THIS PATIENT"
        Me.chkconfirmkeyconcerns.UseVisualStyleBackColor = True
        '
        'chkconfirmequipmentproblems
        '
        Me.chkconfirmequipmentproblems.Location = New System.Drawing.Point(3, 157)
        Me.chkconfirmequipmentproblems.Name = "chkconfirmequipmentproblems"
        Me.chkconfirmequipmentproblems.Size = New System.Drawing.Size(395, 42)
        Me.chkconfirmequipmentproblems.TabIndex = 18
        Me.chkconfirmequipmentproblems.Text = "WHETHER THERE ARE ANY EQUIPMENT PROBLEMS TO BE ADDRESSED"
        Me.chkconfirmequipmentproblems.UseVisualStyleBackColor = True
        '
        'chkconfirmspecimenlabled
        '
        Me.chkconfirmspecimenlabled.Location = New System.Drawing.Point(3, 106)
        Me.chkconfirmspecimenlabled.Name = "chkconfirmspecimenlabled"
        Me.chkconfirmspecimenlabled.Size = New System.Drawing.Size(395, 52)
        Me.chkconfirmspecimenlabled.TabIndex = 17
        Me.chkconfirmspecimenlabled.Text = "HOW THE SPECIMEN IS LABELLED(INCLUDING PATIENT NAME)"
        Me.chkconfirmspecimenlabled.UseVisualStyleBackColor = True
        '
        'chkconfirmpinstrumentcountcorrect
        '
        Me.chkconfirmpinstrumentcountcorrect.Location = New System.Drawing.Point(3, 63)
        Me.chkconfirmpinstrumentcountcorrect.Name = "chkconfirmpinstrumentcountcorrect"
        Me.chkconfirmpinstrumentcountcorrect.Size = New System.Drawing.Size(395, 42)
        Me.chkconfirmpinstrumentcountcorrect.TabIndex = 16
        Me.chkconfirmpinstrumentcountcorrect.Text = "THAT INSTRUMENT, SPONGE && NEEDLE COUNTS ARE CORRECT (OR NOT APPLICABLE)"
        Me.chkconfirmpinstrumentcountcorrect.UseVisualStyleBackColor = True
        '
        'chkconfirmprocedurename
        '
        Me.chkconfirmprocedurename.Location = New System.Drawing.Point(3, 20)
        Me.chkconfirmprocedurename.Name = "chkconfirmprocedurename"
        Me.chkconfirmprocedurename.Size = New System.Drawing.Size(395, 42)
        Me.chkconfirmprocedurename.TabIndex = 15
        Me.chkconfirmprocedurename.Text = "THE NAME OF THE PROCEDURE RECORDED"
        Me.chkconfirmprocedurename.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(269, 14)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "NURSE VERBALLY CONFIRMS WITH THE TEAM:"
        '
        'Panel19
        '
        Me.Panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel19.Controls.Add(Me.Label4)
        Me.Panel19.Location = New System.Drawing.Point(820, 43)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(403, 25)
        Me.Panel19.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(168, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 14)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "SIGN OUT"
        '
        'Panel20
        '
        Me.Panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel20.Controls.Add(Me.Label5)
        Me.Panel20.Location = New System.Drawing.Point(820, 19)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(403, 25)
        Me.Panel20.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Before Patient Leaves Operating Room"
        '
        'Panel16
        '
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel16.Controls.Add(Me.Label17)
        Me.Panel16.Controls.Add(Me.Panel17)
        Me.Panel16.Controls.Add(Me.Label15)
        Me.Panel16.Controls.Add(Me.Panel18)
        Me.Panel16.Controls.Add(Me.chknurseteamreview)
        Me.Panel16.Controls.Add(Me.chkanesthersiareview)
        Me.Panel16.Controls.Add(Me.chksurgeonreview)
        Me.Panel16.Controls.Add(Me.Label7)
        Me.Panel16.Location = New System.Drawing.Point(418, 205)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(403, 264)
        Me.Panel16.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 205)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(210, 14)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "IS ESSENTIAL IMAGING DISPLAYED?"
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.rdantibioticprophylaxisno)
        Me.Panel17.Controls.Add(Me.rdantibioticprophylaxis)
        Me.Panel17.Location = New System.Drawing.Point(27, 168)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(298, 25)
        Me.Panel17.TabIndex = 19
        '
        'rdantibioticprophylaxisno
        '
        Me.rdantibioticprophylaxisno.AutoSize = True
        Me.rdantibioticprophylaxisno.Location = New System.Drawing.Point(85, 3)
        Me.rdantibioticprophylaxisno.Name = "rdantibioticprophylaxisno"
        Me.rdantibioticprophylaxisno.Size = New System.Drawing.Size(121, 18)
        Me.rdantibioticprophylaxisno.TabIndex = 11
        Me.rdantibioticprophylaxisno.TabStop = True
        Me.rdantibioticprophylaxisno.Text = "NOT APPLICABLE"
        Me.rdantibioticprophylaxisno.UseVisualStyleBackColor = True
        '
        'rdantibioticprophylaxis
        '
        Me.rdantibioticprophylaxis.AutoSize = True
        Me.rdantibioticprophylaxis.Location = New System.Drawing.Point(12, 3)
        Me.rdantibioticprophylaxis.Name = "rdantibioticprophylaxis"
        Me.rdantibioticprophylaxis.Size = New System.Drawing.Size(47, 18)
        Me.rdantibioticprophylaxis.TabIndex = 10
        Me.rdantibioticprophylaxis.TabStop = True
        Me.rdantibioticprophylaxis.Text = "YES"
        Me.rdantibioticprophylaxis.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 138)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(392, 38)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "HAS ANTIBIOTIC PROPHYLAXIS BEEN GIVEN WITHIN THE LAST 60 MINUTES?"
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.rdisimagingdisplayed)
        Me.Panel18.Controls.Add(Me.rdisimagingdisplayedno)
        Me.Panel18.Location = New System.Drawing.Point(27, 222)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(298, 28)
        Me.Panel18.TabIndex = 21
        '
        'rdisimagingdisplayed
        '
        Me.rdisimagingdisplayed.AutoSize = True
        Me.rdisimagingdisplayed.Location = New System.Drawing.Point(12, 3)
        Me.rdisimagingdisplayed.Name = "rdisimagingdisplayed"
        Me.rdisimagingdisplayed.Size = New System.Drawing.Size(47, 18)
        Me.rdisimagingdisplayed.TabIndex = 10
        Me.rdisimagingdisplayed.TabStop = True
        Me.rdisimagingdisplayed.Text = "YES"
        Me.rdisimagingdisplayed.UseVisualStyleBackColor = True
        '
        'rdisimagingdisplayedno
        '
        Me.rdisimagingdisplayedno.AutoSize = True
        Me.rdisimagingdisplayedno.Location = New System.Drawing.Point(85, 3)
        Me.rdisimagingdisplayedno.Name = "rdisimagingdisplayedno"
        Me.rdisimagingdisplayedno.Size = New System.Drawing.Size(121, 18)
        Me.rdisimagingdisplayedno.TabIndex = 11
        Me.rdisimagingdisplayedno.TabStop = True
        Me.rdisimagingdisplayedno.Text = "NOT APPLICABLE"
        Me.rdisimagingdisplayedno.UseVisualStyleBackColor = True
        '
        'chknurseteamreview
        '
        Me.chknurseteamreview.Location = New System.Drawing.Point(3, 87)
        Me.chknurseteamreview.Name = "chknurseteamreview"
        Me.chknurseteamreview.Size = New System.Drawing.Size(395, 52)
        Me.chknurseteamreview.TabIndex = 17
        Me.chknurseteamreview.Text = "NURSING TEAM REVIEWS: HAS STERILITY INCLUDING INDICATOR RESULTS) BEEN CONFIRMED? " & _
    "ARE THERE EQUIPMENT ISSUES OR ANY CONCERNS?"
        Me.chknurseteamreview.UseVisualStyleBackColor = True
        '
        'chkanesthersiareview
        '
        Me.chkanesthersiareview.Location = New System.Drawing.Point(3, 52)
        Me.chkanesthersiareview.Name = "chkanesthersiareview"
        Me.chkanesthersiareview.Size = New System.Drawing.Size(395, 42)
        Me.chkanesthersiareview.TabIndex = 16
        Me.chkanesthersiareview.Text = "ANAESTHESIA TEAM REVIEWS: ARE THERE ANY PATIENT-SPECIFIC CONCERNS?"
        Me.chkanesthersiareview.UseVisualStyleBackColor = True
        '
        'chksurgeonreview
        '
        Me.chksurgeonreview.Location = New System.Drawing.Point(3, 17)
        Me.chksurgeonreview.Name = "chksurgeonreview"
        Me.chksurgeonreview.Size = New System.Drawing.Size(395, 42)
        Me.chksurgeonreview.TabIndex = 15
        Me.chksurgeonreview.Text = "SURGEON REVIEWS: WHAT ARE THE CRITICAL OR UNEXPECTED STEPS, OPERATIVE DURATION, A" & _
    "NTICIPATED BLOOD LOSS?"
        Me.chksurgeonreview.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 14)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "ANTICIPATED CRITICAL EVENTS"
        '
        'Panel15
        '
        Me.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel15.Controls.Add(Me.chkverballyconfirmprocedure)
        Me.Panel15.Controls.Add(Me.chkverballyconfirmsite)
        Me.Panel15.Controls.Add(Me.chkverballyconfirmpatient)
        Me.Panel15.Controls.Add(Me.chkverballyconfirm)
        Me.Panel15.Location = New System.Drawing.Point(418, 109)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(403, 97)
        Me.Panel15.TabIndex = 10
        '
        'chkverballyconfirmprocedure
        '
        Me.chkverballyconfirmprocedure.AutoSize = True
        Me.chkverballyconfirmprocedure.Location = New System.Drawing.Point(39, 73)
        Me.chkverballyconfirmprocedure.Name = "chkverballyconfirmprocedure"
        Me.chkverballyconfirmprocedure.Size = New System.Drawing.Size(93, 18)
        Me.chkverballyconfirmprocedure.TabIndex = 9
        Me.chkverballyconfirmprocedure.Text = "PROCEDURE"
        Me.chkverballyconfirmprocedure.UseVisualStyleBackColor = True
        '
        'chkverballyconfirmsite
        '
        Me.chkverballyconfirmsite.AutoSize = True
        Me.chkverballyconfirmsite.Location = New System.Drawing.Point(39, 56)
        Me.chkverballyconfirmsite.Name = "chkverballyconfirmsite"
        Me.chkverballyconfirmsite.Size = New System.Drawing.Size(52, 18)
        Me.chkverballyconfirmsite.TabIndex = 8
        Me.chkverballyconfirmsite.Text = "SITE"
        Me.chkverballyconfirmsite.UseVisualStyleBackColor = True
        '
        'chkverballyconfirmpatient
        '
        Me.chkverballyconfirmpatient.AutoSize = True
        Me.chkverballyconfirmpatient.Location = New System.Drawing.Point(39, 39)
        Me.chkverballyconfirmpatient.Name = "chkverballyconfirmpatient"
        Me.chkverballyconfirmpatient.Size = New System.Drawing.Size(76, 18)
        Me.chkverballyconfirmpatient.TabIndex = 7
        Me.chkverballyconfirmpatient.Text = "PATIENT"
        Me.chkverballyconfirmpatient.UseVisualStyleBackColor = True
        '
        'chkverballyconfirm
        '
        Me.chkverballyconfirm.Location = New System.Drawing.Point(3, 0)
        Me.chkverballyconfirm.Name = "chkverballyconfirm"
        Me.chkverballyconfirm.Size = New System.Drawing.Size(395, 42)
        Me.chkverballyconfirm.TabIndex = 3
        Me.chkverballyconfirm.Text = "SURGEON, ANAESTHESIA PROFESSIONAL AND NURSE VERBALLY CONFIRM"
        Me.chkverballyconfirm.UseVisualStyleBackColor = True
        '
        'Panel14
        '
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.chkintroducedmembers)
        Me.Panel14.Location = New System.Drawing.Point(418, 67)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(403, 43)
        Me.Panel14.TabIndex = 9
        '
        'chkintroducedmembers
        '
        Me.chkintroducedmembers.Location = New System.Drawing.Point(3, 4)
        Me.chkintroducedmembers.Name = "chkintroducedmembers"
        Me.chkintroducedmembers.Size = New System.Drawing.Size(395, 35)
        Me.chkintroducedmembers.TabIndex = 3
        Me.chkintroducedmembers.Text = "CONFIRM ALL TEAM MEMBERS HAVE INTRODUCED THEMSELVES BY NAME AND ROLE"
        Me.chkintroducedmembers.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.Label12)
        Me.Panel12.Location = New System.Drawing.Point(418, 43)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(403, 25)
        Me.Panel12.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(168, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 14)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "TIME OUT"
        '
        'Panel13
        '
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.Label13)
        Me.Panel13.Location = New System.Drawing.Point(418, 19)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(403, 25)
        Me.Panel13.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(144, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 14)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Before Skin Incision"
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Panel11)
        Me.Panel8.Controls.Add(Me.Panel10)
        Me.Panel8.Controls.Add(Me.Label11)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Controls.Add(Me.Label10)
        Me.Panel8.Controls.Add(Me.Label9)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Location = New System.Drawing.Point(16, 278)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(403, 191)
        Me.Panel8.TabIndex = 6
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.rdbloodlossriskno)
        Me.Panel11.Controls.Add(Me.rdbloodlossrisk)
        Me.Panel11.Location = New System.Drawing.Point(19, 137)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(370, 51)
        Me.Panel11.TabIndex = 14
        '
        'rdbloodlossriskno
        '
        Me.rdbloodlossriskno.AutoSize = True
        Me.rdbloodlossriskno.Location = New System.Drawing.Point(12, 3)
        Me.rdbloodlossriskno.Name = "rdbloodlossriskno"
        Me.rdbloodlossriskno.Size = New System.Drawing.Size(42, 18)
        Me.rdbloodlossriskno.TabIndex = 10
        Me.rdbloodlossriskno.TabStop = True
        Me.rdbloodlossriskno.Text = "NO"
        Me.rdbloodlossriskno.UseVisualStyleBackColor = True
        '
        'rdbloodlossrisk
        '
        Me.rdbloodlossrisk.AutoSize = True
        Me.rdbloodlossrisk.Location = New System.Drawing.Point(12, 27)
        Me.rdbloodlossrisk.Name = "rdbloodlossrisk"
        Me.rdbloodlossrisk.Size = New System.Drawing.Size(351, 18)
        Me.rdbloodlossrisk.TabIndex = 11
        Me.rdbloodlossrisk.TabStop = True
        Me.rdbloodlossrisk.Text = "YES, && ADEQUATE INTRAVENOUS ACCESS && FLUID PLANS"
        Me.rdbloodlossrisk.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.rdaspirationriskno)
        Me.Panel10.Controls.Add(Me.rdaspirationrisk)
        Me.Panel10.Location = New System.Drawing.Point(19, 81)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(370, 28)
        Me.Panel10.TabIndex = 13
        '
        'rdaspirationriskno
        '
        Me.rdaspirationriskno.AutoSize = True
        Me.rdaspirationriskno.Location = New System.Drawing.Point(12, 3)
        Me.rdaspirationriskno.Name = "rdaspirationriskno"
        Me.rdaspirationriskno.Size = New System.Drawing.Size(42, 18)
        Me.rdaspirationriskno.TabIndex = 10
        Me.rdaspirationriskno.TabStop = True
        Me.rdaspirationriskno.Text = "NO"
        Me.rdaspirationriskno.UseVisualStyleBackColor = True
        '
        'rdaspirationrisk
        '
        Me.rdaspirationrisk.AutoSize = True
        Me.rdaspirationrisk.Location = New System.Drawing.Point(83, 3)
        Me.rdaspirationrisk.Name = "rdaspirationrisk"
        Me.rdaspirationrisk.Size = New System.Drawing.Size(284, 18)
        Me.rdaspirationrisk.TabIndex = 11
        Me.rdaspirationrisk.TabStop = True
        Me.rdaspirationrisk.Text = "YES, && EQUIPMENT/ ASSISTANCE AVAILABLE "
        Me.rdaspirationrisk.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(314, 14)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "RISK OF >500ML BLOOD LOSS (70ML/KG IN CHILDREN)"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.rdknownallergyno)
        Me.Panel9.Controls.Add(Me.rdknownallergy)
        Me.Panel9.Location = New System.Drawing.Point(129, 28)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(200, 31)
        Me.Panel9.TabIndex = 9
        '
        'rdknownallergyno
        '
        Me.rdknownallergyno.AutoSize = True
        Me.rdknownallergyno.Location = New System.Drawing.Point(8, 4)
        Me.rdknownallergyno.Name = "rdknownallergyno"
        Me.rdknownallergyno.Size = New System.Drawing.Size(42, 18)
        Me.rdknownallergyno.TabIndex = 6
        Me.rdknownallergyno.TabStop = True
        Me.rdknownallergyno.Text = "NO"
        Me.rdknownallergyno.UseVisualStyleBackColor = True
        '
        'rdknownallergy
        '
        Me.rdknownallergy.AutoSize = True
        Me.rdknownallergy.Location = New System.Drawing.Point(81, 4)
        Me.rdknownallergy.Name = "rdknownallergy"
        Me.rdknownallergy.Size = New System.Drawing.Size(47, 18)
        Me.rdknownallergy.TabIndex = 7
        Me.rdknownallergy.TabStop = True
        Me.rdknownallergy.Text = "YES"
        Me.rdknownallergy.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(232, 14)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "DIFFICULT AIRWAYS/ASPIRATION RISK?"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 14)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "KNOWN ALLERGY?"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(126, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 14)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "DOES PATIENT HAVE A:"
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.chkpulseoximeter)
        Me.Panel7.Location = New System.Drawing.Point(16, 244)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(403, 35)
        Me.Panel7.TabIndex = 5
        '
        'chkpulseoximeter
        '
        Me.chkpulseoximeter.AutoSize = True
        Me.chkpulseoximeter.Location = New System.Drawing.Point(3, 10)
        Me.chkpulseoximeter.Name = "chkpulseoximeter"
        Me.chkpulseoximeter.Size = New System.Drawing.Size(308, 18)
        Me.chkpulseoximeter.TabIndex = 3
        Me.chkpulseoximeter.Text = "PULSE OXIMETER ON PATIENT AND FUNCTIONING"
        Me.chkpulseoximeter.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.chkanaesthesiasafetycheck)
        Me.Panel6.Location = New System.Drawing.Point(16, 210)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(403, 35)
        Me.Panel6.TabIndex = 4
        '
        'chkanaesthesiasafetycheck
        '
        Me.chkanaesthesiasafetycheck.AutoSize = True
        Me.chkanaesthesiasafetycheck.Location = New System.Drawing.Point(3, 10)
        Me.chkanaesthesiasafetycheck.Name = "chkanaesthesiasafetycheck"
        Me.chkanaesthesiasafetycheck.Size = New System.Drawing.Size(266, 18)
        Me.chkanaesthesiasafetycheck.TabIndex = 3
        Me.chkanaesthesiasafetycheck.Text = "ANAESTHESIA SAFETY CHECK COMPLETED"
        Me.chkanaesthesiasafetycheck.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.chksitemarked)
        Me.Panel5.Location = New System.Drawing.Point(16, 176)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(403, 35)
        Me.Panel5.TabIndex = 3
        '
        'chksitemarked
        '
        Me.chksitemarked.AutoSize = True
        Me.chksitemarked.Location = New System.Drawing.Point(3, 10)
        Me.chksitemarked.Name = "chksitemarked"
        Me.chksitemarked.Size = New System.Drawing.Size(203, 18)
        Me.chksitemarked.TabIndex = 3
        Me.chksitemarked.Text = "SITE MARKED/NOT APPLICABLE"
        Me.chksitemarked.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.chkconfirmpatientconsent)
        Me.Panel4.Controls.Add(Me.chkconfirmpatientprocedure)
        Me.Panel4.Controls.Add(Me.chkconfirmpatientsite)
        Me.Panel4.Controls.Add(Me.chkconfirmpatientidentity)
        Me.Panel4.Controls.Add(Me.chkpatientconfirmed)
        Me.Panel4.Location = New System.Drawing.Point(16, 67)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(403, 110)
        Me.Panel4.TabIndex = 2
        '
        'chkconfirmpatientconsent
        '
        Me.chkconfirmpatientconsent.AutoSize = True
        Me.chkconfirmpatientconsent.Location = New System.Drawing.Point(39, 85)
        Me.chkconfirmpatientconsent.Name = "chkconfirmpatientconsent"
        Me.chkconfirmpatientconsent.Size = New System.Drawing.Size(80, 18)
        Me.chkconfirmpatientconsent.TabIndex = 10
        Me.chkconfirmpatientconsent.Text = "CONSENT"
        Me.chkconfirmpatientconsent.UseVisualStyleBackColor = True
        '
        'chkconfirmpatientprocedure
        '
        Me.chkconfirmpatientprocedure.AutoSize = True
        Me.chkconfirmpatientprocedure.Location = New System.Drawing.Point(39, 66)
        Me.chkconfirmpatientprocedure.Name = "chkconfirmpatientprocedure"
        Me.chkconfirmpatientprocedure.Size = New System.Drawing.Size(93, 18)
        Me.chkconfirmpatientprocedure.TabIndex = 9
        Me.chkconfirmpatientprocedure.Text = "PROCEDURE"
        Me.chkconfirmpatientprocedure.UseVisualStyleBackColor = True
        '
        'chkconfirmpatientsite
        '
        Me.chkconfirmpatientsite.AutoSize = True
        Me.chkconfirmpatientsite.Location = New System.Drawing.Point(39, 48)
        Me.chkconfirmpatientsite.Name = "chkconfirmpatientsite"
        Me.chkconfirmpatientsite.Size = New System.Drawing.Size(52, 18)
        Me.chkconfirmpatientsite.TabIndex = 8
        Me.chkconfirmpatientsite.Text = "SITE"
        Me.chkconfirmpatientsite.UseVisualStyleBackColor = True
        '
        'chkconfirmpatientidentity
        '
        Me.chkconfirmpatientidentity.AutoSize = True
        Me.chkconfirmpatientidentity.Location = New System.Drawing.Point(39, 30)
        Me.chkconfirmpatientidentity.Name = "chkconfirmpatientidentity"
        Me.chkconfirmpatientidentity.Size = New System.Drawing.Size(81, 18)
        Me.chkconfirmpatientidentity.TabIndex = 7
        Me.chkconfirmpatientidentity.Text = "IDENTITY"
        Me.chkconfirmpatientidentity.UseVisualStyleBackColor = True
        '
        'chkpatientconfirmed
        '
        Me.chkpatientconfirmed.AutoSize = True
        Me.chkpatientconfirmed.Location = New System.Drawing.Point(3, 6)
        Me.chkpatientconfirmed.Name = "chkpatientconfirmed"
        Me.chkpatientconfirmed.Size = New System.Drawing.Size(172, 18)
        Me.chkpatientconfirmed.TabIndex = 3
        Me.chkpatientconfirmed.Text = "PATIENT HAS CONFIRMED"
        Me.chkpatientconfirmed.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(16, 43)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(403, 25)
        Me.Panel3.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(174, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "SIGN IN"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(16, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(403, 25)
        Me.Panel2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Before Induction of Anaesthesia"
        '
        'tabpreoperative
        '
        Me.tabpreoperative.Controls.Add(Me.txtbpdiastolic)
        Me.tabpreoperative.Controls.Add(Me.dtptimeofmedication)
        Me.tabpreoperative.Controls.Add(Me.txtrr)
        Me.tabpreoperative.Controls.Add(Me.txtcr)
        Me.tabpreoperative.Controls.Add(Me.txtamountcatheterized)
        Me.tabpreoperative.Controls.Add(Me.txtamountvoided)
        Me.tabpreoperative.Controls.Add(Me.dtptimebp)
        Me.tabpreoperative.Controls.Add(Me.txtpreoperativemedication)
        Me.tabpreoperative.Controls.Add(Me.txtbpsystolic)
        Me.tabpreoperative.Controls.Add(Me.txttemp)
        Me.tabpreoperative.Controls.Add(Me.dtptimecatheterized)
        Me.tabpreoperative.Controls.Add(Me.dtptimevoided)
        Me.tabpreoperative.Controls.Add(Me.Label75)
        Me.tabpreoperative.Controls.Add(Me.Label74)
        Me.tabpreoperative.Controls.Add(Me.Label73)
        Me.tabpreoperative.Controls.Add(Me.Label72)
        Me.tabpreoperative.Controls.Add(Me.Label71)
        Me.tabpreoperative.Controls.Add(Me.Label70)
        Me.tabpreoperative.Controls.Add(Me.Label69)
        Me.tabpreoperative.Controls.Add(Me.Label68)
        Me.tabpreoperative.Controls.Add(Me.Label67)
        Me.tabpreoperative.Controls.Add(Me.chkcatheterized)
        Me.tabpreoperative.Controls.Add(Me.chkvoided)
        Me.tabpreoperative.Controls.Add(Me.Label66)
        Me.tabpreoperative.Controls.Add(Me.Label65)
        Me.tabpreoperative.Controls.Add(Me.Label64)
        Me.tabpreoperative.Controls.Add(Me.Label63)
        Me.tabpreoperative.Controls.Add(Me.txtxrayreports)
        Me.tabpreoperative.Controls.Add(Me.txturine)
        Me.tabpreoperative.Controls.Add(Me.txtroutinebloodreps)
        Me.tabpreoperative.Controls.Add(Me.txtxmatching)
        Me.tabpreoperative.Controls.Add(Me.txtconsentsigned)
        Me.tabpreoperative.Controls.Add(Me.txtdenturesremoved)
        Me.tabpreoperative.Controls.Add(Me.txtjewelryremoved)
        Me.tabpreoperative.Controls.Add(Me.txtnailpolishremoved)
        Me.tabpreoperative.Controls.Add(Me.txtheadcap)
        Me.tabpreoperative.Controls.Add(Me.txthairpinremoved)
        Me.tabpreoperative.Controls.Add(Me.txtunderwearremoved)
        Me.tabpreoperative.Controls.Add(Me.txtpatientgowned)
        Me.tabpreoperative.Controls.Add(Me.txtsiteinspectedbyhn)
        Me.tabpreoperative.Controls.Add(Me.txtsiteshaved)
        Me.tabpreoperative.Controls.Add(Me.Panel56)
        Me.tabpreoperative.Controls.Add(Me.Panel55)
        Me.tabpreoperative.Controls.Add(Me.Panel53)
        Me.tabpreoperative.Controls.Add(Me.Panel54)
        Me.tabpreoperative.Controls.Add(Me.Panel52)
        Me.tabpreoperative.Controls.Add(Me.Panel48)
        Me.tabpreoperative.Controls.Add(Me.Panel49)
        Me.tabpreoperative.Controls.Add(Me.Panel50)
        Me.tabpreoperative.Controls.Add(Me.Panel46)
        Me.tabpreoperative.Controls.Add(Me.Panel47)
        Me.tabpreoperative.Controls.Add(Me.Panel44)
        Me.tabpreoperative.Controls.Add(Me.Panel45)
        Me.tabpreoperative.Controls.Add(Me.Panel42)
        Me.tabpreoperative.Controls.Add(Me.Panel41)
        Me.tabpreoperative.Controls.Add(Me.Panel39)
        Me.tabpreoperative.Controls.Add(Me.Panel40)
        Me.tabpreoperative.Controls.Add(Me.Panel38)
        Me.tabpreoperative.Controls.Add(Me.Panel37)
        Me.tabpreoperative.Controls.Add(Me.Panel35)
        Me.tabpreoperative.Controls.Add(Me.Panel36)
        Me.tabpreoperative.Controls.Add(Me.Panel34)
        Me.tabpreoperative.Controls.Add(Me.Panel33)
        Me.tabpreoperative.Controls.Add(Me.Panel32)
        Me.tabpreoperative.Controls.Add(Me.Panel30)
        Me.tabpreoperative.Controls.Add(Me.Panel31)
        Me.tabpreoperative.Controls.Add(Me.Panel29)
        Me.tabpreoperative.Controls.Add(Me.Panel28)
        Me.tabpreoperative.Controls.Add(Me.Panel27)
        Me.tabpreoperative.Controls.Add(Me.Panel26)
        Me.tabpreoperative.Controls.Add(Me.Panel25)
        Me.tabpreoperative.Controls.Add(Me.Panel24)
        Me.tabpreoperative.Controls.Add(Me.Panel23)
        Me.tabpreoperative.Controls.Add(Me.Panel22)
        Me.tabpreoperative.Controls.Add(Me.Label76)
        Me.tabpreoperative.Location = New System.Drawing.Point(4, 23)
        Me.tabpreoperative.Name = "tabpreoperative"
        Me.tabpreoperative.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpreoperative.Size = New System.Drawing.Size(1240, 549)
        Me.tabpreoperative.TabIndex = 3
        Me.tabpreoperative.Text = "Pre-Operative CheckList"
        Me.tabpreoperative.UseVisualStyleBackColor = True
        '
        'txtbpdiastolic
        '
        Me.txtbpdiastolic.Location = New System.Drawing.Point(354, 502)
        Me.txtbpdiastolic.Name = "txtbpdiastolic"
        Me.txtbpdiastolic.Size = New System.Drawing.Size(67, 22)
        Me.txtbpdiastolic.TabIndex = 79
        '
        'dtptimeofmedication
        '
        Me.dtptimeofmedication.CustomFormat = "hh:mm tt"
        Me.dtptimeofmedication.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptimeofmedication.Location = New System.Drawing.Point(649, 525)
        Me.dtptimeofmedication.Name = "dtptimeofmedication"
        Me.dtptimeofmedication.Size = New System.Drawing.Size(161, 22)
        Me.dtptimeofmedication.TabIndex = 78
        '
        'txtrr
        '
        Me.txtrr.Location = New System.Drawing.Point(649, 479)
        Me.txtrr.Name = "txtrr"
        Me.txtrr.Size = New System.Drawing.Size(161, 22)
        Me.txtrr.TabIndex = 77
        '
        'txtcr
        '
        Me.txtcr.Location = New System.Drawing.Point(472, 479)
        Me.txtcr.Name = "txtcr"
        Me.txtcr.Size = New System.Drawing.Size(88, 22)
        Me.txtcr.TabIndex = 76
        '
        'txtamountcatheterized
        '
        Me.txtamountcatheterized.Enabled = False
        Me.txtamountcatheterized.Location = New System.Drawing.Point(649, 454)
        Me.txtamountcatheterized.Name = "txtamountcatheterized"
        Me.txtamountcatheterized.Size = New System.Drawing.Size(161, 22)
        Me.txtamountcatheterized.TabIndex = 75
        '
        'txtamountvoided
        '
        Me.txtamountvoided.Enabled = False
        Me.txtamountvoided.Location = New System.Drawing.Point(649, 430)
        Me.txtamountvoided.Name = "txtamountvoided"
        Me.txtamountvoided.Size = New System.Drawing.Size(161, 22)
        Me.txtamountvoided.TabIndex = 74
        '
        'dtptimebp
        '
        Me.dtptimebp.CustomFormat = "hh:mm tt"
        Me.dtptimebp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptimebp.Location = New System.Drawing.Point(512, 502)
        Me.dtptimebp.Name = "dtptimebp"
        Me.dtptimebp.Size = New System.Drawing.Size(96, 22)
        Me.dtptimebp.TabIndex = 73
        '
        'txtpreoperativemedication
        '
        Me.txtpreoperativemedication.Location = New System.Drawing.Point(321, 525)
        Me.txtpreoperativemedication.Multiline = True
        Me.txtpreoperativemedication.Name = "txtpreoperativemedication"
        Me.txtpreoperativemedication.Size = New System.Drawing.Size(287, 22)
        Me.txtpreoperativemedication.TabIndex = 72
        '
        'txtbpsystolic
        '
        Me.txtbpsystolic.Location = New System.Drawing.Point(274, 502)
        Me.txtbpsystolic.Name = "txtbpsystolic"
        Me.txtbpsystolic.Size = New System.Drawing.Size(67, 22)
        Me.txtbpsystolic.TabIndex = 71
        '
        'txttemp
        '
        Me.txttemp.Location = New System.Drawing.Point(264, 479)
        Me.txttemp.Name = "txttemp"
        Me.txttemp.Size = New System.Drawing.Size(157, 22)
        Me.txttemp.TabIndex = 70
        '
        'dtptimecatheterized
        '
        Me.dtptimecatheterized.CustomFormat = "hh:mm tt"
        Me.dtptimecatheterized.Enabled = False
        Me.dtptimecatheterized.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptimecatheterized.Location = New System.Drawing.Point(402, 451)
        Me.dtptimecatheterized.Name = "dtptimecatheterized"
        Me.dtptimecatheterized.Size = New System.Drawing.Size(104, 22)
        Me.dtptimecatheterized.TabIndex = 69
        '
        'dtptimevoided
        '
        Me.dtptimevoided.CustomFormat = "hh:mm tt"
        Me.dtptimevoided.Enabled = False
        Me.dtptimevoided.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptimevoided.Location = New System.Drawing.Point(402, 429)
        Me.dtptimevoided.Name = "dtptimevoided"
        Me.dtptimevoided.Size = New System.Drawing.Size(104, 22)
        Me.dtptimevoided.TabIndex = 68
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Location = New System.Drawing.Point(573, 483)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(70, 14)
        Me.Label75.TabIndex = 67
        Me.Label75.Text = "Respiration:"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Location = New System.Drawing.Point(590, 458)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(55, 14)
        Me.Label74.TabIndex = 66
        Me.Label74.Text = "Amount:"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(590, 433)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(55, 14)
        Me.Label73.TabIndex = 65
        Me.Label73.Text = "Amount:"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Location = New System.Drawing.Point(609, 529)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(38, 14)
        Me.Label72.TabIndex = 64
        Me.Label72.Text = "Time:"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(430, 505)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(76, 14)
        Me.Label71.TabIndex = 63
        Me.Label71.Text = "Time Taken:"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(155, 528)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(168, 14)
        Me.Label70.TabIndex = 61
        Me.Label70.Text = "13. Pre-operative Medication:"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(429, 483)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(39, 14)
        Me.Label69.TabIndex = 60
        Me.Label69.Text = "Pulse:"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(358, 454)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(38, 14)
        Me.Label68.TabIndex = 59
        Me.Label68.Text = "Time:"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(358, 432)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(38, 14)
        Me.Label67.TabIndex = 58
        Me.Label67.Text = "Time:"
        '
        'chkcatheterized
        '
        Me.chkcatheterized.AutoSize = True
        Me.chkcatheterized.Location = New System.Drawing.Point(183, 456)
        Me.chkcatheterized.Name = "chkcatheterized"
        Me.chkcatheterized.Size = New System.Drawing.Size(95, 18)
        Me.chkcatheterized.TabIndex = 55
        Me.chkcatheterized.Text = "Catheterized"
        Me.chkcatheterized.UseVisualStyleBackColor = True
        '
        'chkvoided
        '
        Me.chkvoided.AutoSize = True
        Me.chkvoided.Location = New System.Drawing.Point(183, 433)
        Me.chkvoided.Name = "chkvoided"
        Me.chkvoided.Size = New System.Drawing.Size(64, 18)
        Me.chkvoided.TabIndex = 1
        Me.chkvoided.Text = "Voided"
        Me.chkvoided.UseVisualStyleBackColor = True
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(155, 505)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(113, 14)
        Me.Label66.TabIndex = 54
        Me.Label66.Text = "12. Blood Pressure:"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(155, 483)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(105, 14)
        Me.Label65.TabIndex = 53
        Me.Label65.Text = "11. Temperature:"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(155, 457)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(25, 14)
        Me.Label64.TabIndex = 52
        Me.Label64.Text = "10."
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(155, 434)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(18, 14)
        Me.Label63.TabIndex = 4
        Me.Label63.Text = "9."
        '
        'txtxrayreports
        '
        Me.txtxrayreports.Location = New System.Drawing.Point(689, 402)
        Me.txtxrayreports.Multiline = True
        Me.txtxrayreports.Name = "txtxrayreports"
        Me.txtxrayreports.Size = New System.Drawing.Size(409, 25)
        Me.txtxrayreports.TabIndex = 51
        '
        'txturine
        '
        Me.txturine.Location = New System.Drawing.Point(689, 378)
        Me.txturine.Multiline = True
        Me.txturine.Name = "txturine"
        Me.txturine.Size = New System.Drawing.Size(409, 25)
        Me.txturine.TabIndex = 50
        '
        'txtroutinebloodreps
        '
        Me.txtroutinebloodreps.Location = New System.Drawing.Point(689, 354)
        Me.txtroutinebloodreps.Multiline = True
        Me.txtroutinebloodreps.Name = "txtroutinebloodreps"
        Me.txtroutinebloodreps.Size = New System.Drawing.Size(409, 25)
        Me.txtroutinebloodreps.TabIndex = 49
        '
        'txtxmatching
        '
        Me.txtxmatching.Location = New System.Drawing.Point(689, 330)
        Me.txtxmatching.Multiline = True
        Me.txtxmatching.Name = "txtxmatching"
        Me.txtxmatching.Size = New System.Drawing.Size(409, 25)
        Me.txtxmatching.TabIndex = 48
        '
        'txtconsentsigned
        '
        Me.txtconsentsigned.Location = New System.Drawing.Point(689, 282)
        Me.txtconsentsigned.Multiline = True
        Me.txtconsentsigned.Name = "txtconsentsigned"
        Me.txtconsentsigned.Size = New System.Drawing.Size(409, 25)
        Me.txtconsentsigned.TabIndex = 46
        '
        'txtdenturesremoved
        '
        Me.txtdenturesremoved.Location = New System.Drawing.Point(689, 258)
        Me.txtdenturesremoved.Multiline = True
        Me.txtdenturesremoved.Name = "txtdenturesremoved"
        Me.txtdenturesremoved.Size = New System.Drawing.Size(409, 25)
        Me.txtdenturesremoved.TabIndex = 45
        '
        'txtjewelryremoved
        '
        Me.txtjewelryremoved.Location = New System.Drawing.Point(689, 234)
        Me.txtjewelryremoved.Multiline = True
        Me.txtjewelryremoved.Name = "txtjewelryremoved"
        Me.txtjewelryremoved.Size = New System.Drawing.Size(409, 25)
        Me.txtjewelryremoved.TabIndex = 44
        '
        'txtnailpolishremoved
        '
        Me.txtnailpolishremoved.Location = New System.Drawing.Point(689, 210)
        Me.txtnailpolishremoved.Multiline = True
        Me.txtnailpolishremoved.Name = "txtnailpolishremoved"
        Me.txtnailpolishremoved.Size = New System.Drawing.Size(409, 25)
        Me.txtnailpolishremoved.TabIndex = 43
        '
        'txtheadcap
        '
        Me.txtheadcap.Location = New System.Drawing.Point(689, 186)
        Me.txtheadcap.Multiline = True
        Me.txtheadcap.Name = "txtheadcap"
        Me.txtheadcap.Size = New System.Drawing.Size(409, 25)
        Me.txtheadcap.TabIndex = 42
        '
        'txthairpinremoved
        '
        Me.txthairpinremoved.Location = New System.Drawing.Point(689, 162)
        Me.txthairpinremoved.Multiline = True
        Me.txthairpinremoved.Name = "txthairpinremoved"
        Me.txthairpinremoved.Size = New System.Drawing.Size(409, 25)
        Me.txthairpinremoved.TabIndex = 41
        '
        'txtunderwearremoved
        '
        Me.txtunderwearremoved.Location = New System.Drawing.Point(689, 138)
        Me.txtunderwearremoved.Multiline = True
        Me.txtunderwearremoved.Name = "txtunderwearremoved"
        Me.txtunderwearremoved.Size = New System.Drawing.Size(409, 25)
        Me.txtunderwearremoved.TabIndex = 40
        '
        'txtpatientgowned
        '
        Me.txtpatientgowned.Location = New System.Drawing.Point(689, 114)
        Me.txtpatientgowned.Multiline = True
        Me.txtpatientgowned.Name = "txtpatientgowned"
        Me.txtpatientgowned.Size = New System.Drawing.Size(409, 25)
        Me.txtpatientgowned.TabIndex = 39
        '
        'txtsiteinspectedbyhn
        '
        Me.txtsiteinspectedbyhn.Location = New System.Drawing.Point(689, 68)
        Me.txtsiteinspectedbyhn.Multiline = True
        Me.txtsiteinspectedbyhn.Name = "txtsiteinspectedbyhn"
        Me.txtsiteinspectedbyhn.Size = New System.Drawing.Size(409, 23)
        Me.txtsiteinspectedbyhn.TabIndex = 37
        '
        'txtsiteshaved
        '
        Me.txtsiteshaved.Location = New System.Drawing.Point(689, 28)
        Me.txtsiteshaved.Multiline = True
        Me.txtsiteshaved.Name = "txtsiteshaved"
        Me.txtsiteshaved.Size = New System.Drawing.Size(409, 41)
        Me.txtsiteshaved.TabIndex = 36
        '
        'Panel56
        '
        Me.Panel56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel56.Controls.Add(Me.chkxrayreports)
        Me.Panel56.Location = New System.Drawing.Point(613, 402)
        Me.Panel56.Name = "Panel56"
        Me.Panel56.Size = New System.Drawing.Size(77, 25)
        Me.Panel56.TabIndex = 35
        '
        'chkxrayreports
        '
        Me.chkxrayreports.AutoSize = True
        Me.chkxrayreports.Location = New System.Drawing.Point(29, 6)
        Me.chkxrayreports.Name = "chkxrayreports"
        Me.chkxrayreports.Size = New System.Drawing.Size(15, 14)
        Me.chkxrayreports.TabIndex = 0
        Me.chkxrayreports.UseVisualStyleBackColor = True
        '
        'Panel55
        '
        Me.Panel55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel55.Controls.Add(Me.chkurine)
        Me.Panel55.Location = New System.Drawing.Point(613, 378)
        Me.Panel55.Name = "Panel55"
        Me.Panel55.Size = New System.Drawing.Size(77, 25)
        Me.Panel55.TabIndex = 34
        '
        'chkurine
        '
        Me.chkurine.AutoSize = True
        Me.chkurine.Location = New System.Drawing.Point(29, 6)
        Me.chkurine.Name = "chkurine"
        Me.chkurine.Size = New System.Drawing.Size(15, 14)
        Me.chkurine.TabIndex = 0
        Me.chkurine.UseVisualStyleBackColor = True
        '
        'Panel53
        '
        Me.Panel53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel53.Controls.Add(Me.chkroutinebloodreps)
        Me.Panel53.Location = New System.Drawing.Point(613, 354)
        Me.Panel53.Name = "Panel53"
        Me.Panel53.Size = New System.Drawing.Size(77, 25)
        Me.Panel53.TabIndex = 33
        '
        'chkroutinebloodreps
        '
        Me.chkroutinebloodreps.AutoSize = True
        Me.chkroutinebloodreps.Location = New System.Drawing.Point(29, 6)
        Me.chkroutinebloodreps.Name = "chkroutinebloodreps"
        Me.chkroutinebloodreps.Size = New System.Drawing.Size(15, 14)
        Me.chkroutinebloodreps.TabIndex = 0
        Me.chkroutinebloodreps.UseVisualStyleBackColor = True
        '
        'Panel54
        '
        Me.Panel54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel54.Controls.Add(Me.chkxmatching)
        Me.Panel54.Location = New System.Drawing.Point(613, 330)
        Me.Panel54.Name = "Panel54"
        Me.Panel54.Size = New System.Drawing.Size(77, 25)
        Me.Panel54.TabIndex = 32
        '
        'chkxmatching
        '
        Me.chkxmatching.AutoSize = True
        Me.chkxmatching.Location = New System.Drawing.Point(29, 6)
        Me.chkxmatching.Name = "chkxmatching"
        Me.chkxmatching.Size = New System.Drawing.Size(15, 14)
        Me.chkxmatching.TabIndex = 0
        Me.chkxmatching.UseVisualStyleBackColor = True
        '
        'Panel52
        '
        Me.Panel52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel52.Controls.Add(Me.chkconsentsigned)
        Me.Panel52.Location = New System.Drawing.Point(613, 282)
        Me.Panel52.Name = "Panel52"
        Me.Panel52.Size = New System.Drawing.Size(77, 25)
        Me.Panel52.TabIndex = 30
        '
        'chkconsentsigned
        '
        Me.chkconsentsigned.AutoSize = True
        Me.chkconsentsigned.Location = New System.Drawing.Point(29, 6)
        Me.chkconsentsigned.Name = "chkconsentsigned"
        Me.chkconsentsigned.Size = New System.Drawing.Size(15, 14)
        Me.chkconsentsigned.TabIndex = 0
        Me.chkconsentsigned.UseVisualStyleBackColor = True
        '
        'Panel48
        '
        Me.Panel48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel48.Controls.Add(Me.chkdenturesremoved)
        Me.Panel48.Location = New System.Drawing.Point(613, 258)
        Me.Panel48.Name = "Panel48"
        Me.Panel48.Size = New System.Drawing.Size(77, 25)
        Me.Panel48.TabIndex = 29
        '
        'chkdenturesremoved
        '
        Me.chkdenturesremoved.AutoSize = True
        Me.chkdenturesremoved.Location = New System.Drawing.Point(29, 6)
        Me.chkdenturesremoved.Name = "chkdenturesremoved"
        Me.chkdenturesremoved.Size = New System.Drawing.Size(15, 14)
        Me.chkdenturesremoved.TabIndex = 0
        Me.chkdenturesremoved.UseVisualStyleBackColor = True
        '
        'Panel49
        '
        Me.Panel49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel49.Controls.Add(Me.chkjewelryremoved)
        Me.Panel49.Location = New System.Drawing.Point(613, 234)
        Me.Panel49.Name = "Panel49"
        Me.Panel49.Size = New System.Drawing.Size(77, 25)
        Me.Panel49.TabIndex = 28
        '
        'chkjewelryremoved
        '
        Me.chkjewelryremoved.AutoSize = True
        Me.chkjewelryremoved.Location = New System.Drawing.Point(29, 6)
        Me.chkjewelryremoved.Name = "chkjewelryremoved"
        Me.chkjewelryremoved.Size = New System.Drawing.Size(15, 14)
        Me.chkjewelryremoved.TabIndex = 0
        Me.chkjewelryremoved.UseVisualStyleBackColor = True
        '
        'Panel50
        '
        Me.Panel50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel50.Controls.Add(Me.chknailpolishremoved)
        Me.Panel50.Location = New System.Drawing.Point(613, 210)
        Me.Panel50.Name = "Panel50"
        Me.Panel50.Size = New System.Drawing.Size(77, 25)
        Me.Panel50.TabIndex = 27
        '
        'chknailpolishremoved
        '
        Me.chknailpolishremoved.AutoSize = True
        Me.chknailpolishremoved.Location = New System.Drawing.Point(29, 6)
        Me.chknailpolishremoved.Name = "chknailpolishremoved"
        Me.chknailpolishremoved.Size = New System.Drawing.Size(15, 14)
        Me.chknailpolishremoved.TabIndex = 0
        Me.chknailpolishremoved.UseVisualStyleBackColor = True
        '
        'Panel46
        '
        Me.Panel46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel46.Controls.Add(Me.chkheadcap)
        Me.Panel46.Location = New System.Drawing.Point(613, 186)
        Me.Panel46.Name = "Panel46"
        Me.Panel46.Size = New System.Drawing.Size(77, 25)
        Me.Panel46.TabIndex = 26
        '
        'chkheadcap
        '
        Me.chkheadcap.AutoSize = True
        Me.chkheadcap.Location = New System.Drawing.Point(29, 6)
        Me.chkheadcap.Name = "chkheadcap"
        Me.chkheadcap.Size = New System.Drawing.Size(15, 14)
        Me.chkheadcap.TabIndex = 0
        Me.chkheadcap.UseVisualStyleBackColor = True
        '
        'Panel47
        '
        Me.Panel47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel47.Controls.Add(Me.chkhairpinremoved)
        Me.Panel47.Location = New System.Drawing.Point(613, 162)
        Me.Panel47.Name = "Panel47"
        Me.Panel47.Size = New System.Drawing.Size(77, 25)
        Me.Panel47.TabIndex = 25
        '
        'chkhairpinremoved
        '
        Me.chkhairpinremoved.AutoSize = True
        Me.chkhairpinremoved.Location = New System.Drawing.Point(29, 6)
        Me.chkhairpinremoved.Name = "chkhairpinremoved"
        Me.chkhairpinremoved.Size = New System.Drawing.Size(15, 14)
        Me.chkhairpinremoved.TabIndex = 0
        Me.chkhairpinremoved.UseVisualStyleBackColor = True
        '
        'Panel44
        '
        Me.Panel44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel44.Controls.Add(Me.chkunderwearremoved)
        Me.Panel44.Location = New System.Drawing.Point(613, 138)
        Me.Panel44.Name = "Panel44"
        Me.Panel44.Size = New System.Drawing.Size(77, 25)
        Me.Panel44.TabIndex = 24
        '
        'chkunderwearremoved
        '
        Me.chkunderwearremoved.AutoSize = True
        Me.chkunderwearremoved.Location = New System.Drawing.Point(29, 6)
        Me.chkunderwearremoved.Name = "chkunderwearremoved"
        Me.chkunderwearremoved.Size = New System.Drawing.Size(15, 14)
        Me.chkunderwearremoved.TabIndex = 0
        Me.chkunderwearremoved.UseVisualStyleBackColor = True
        '
        'Panel45
        '
        Me.Panel45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel45.Controls.Add(Me.chkpatientgowned)
        Me.Panel45.Location = New System.Drawing.Point(613, 114)
        Me.Panel45.Name = "Panel45"
        Me.Panel45.Size = New System.Drawing.Size(77, 25)
        Me.Panel45.TabIndex = 23
        '
        'chkpatientgowned
        '
        Me.chkpatientgowned.AutoSize = True
        Me.chkpatientgowned.Location = New System.Drawing.Point(29, 5)
        Me.chkpatientgowned.Name = "chkpatientgowned"
        Me.chkpatientgowned.Size = New System.Drawing.Size(15, 14)
        Me.chkpatientgowned.TabIndex = 0
        Me.chkpatientgowned.UseVisualStyleBackColor = True
        '
        'Panel42
        '
        Me.Panel42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel42.Controls.Add(Me.chksiteinspectedbyhn)
        Me.Panel42.Location = New System.Drawing.Point(613, 68)
        Me.Panel42.Name = "Panel42"
        Me.Panel42.Size = New System.Drawing.Size(77, 23)
        Me.Panel42.TabIndex = 21
        '
        'chksiteinspectedbyhn
        '
        Me.chksiteinspectedbyhn.AutoSize = True
        Me.chksiteinspectedbyhn.Location = New System.Drawing.Point(29, 5)
        Me.chksiteinspectedbyhn.Name = "chksiteinspectedbyhn"
        Me.chksiteinspectedbyhn.Size = New System.Drawing.Size(15, 14)
        Me.chksiteinspectedbyhn.TabIndex = 0
        Me.chksiteinspectedbyhn.UseVisualStyleBackColor = True
        '
        'Panel41
        '
        Me.Panel41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel41.Controls.Add(Me.chksiteshaved)
        Me.Panel41.Location = New System.Drawing.Point(613, 28)
        Me.Panel41.Name = "Panel41"
        Me.Panel41.Size = New System.Drawing.Size(77, 41)
        Me.Panel41.TabIndex = 20
        '
        'chksiteshaved
        '
        Me.chksiteshaved.AutoSize = True
        Me.chksiteshaved.Location = New System.Drawing.Point(29, 15)
        Me.chksiteshaved.Name = "chksiteshaved"
        Me.chksiteshaved.Size = New System.Drawing.Size(15, 14)
        Me.chksiteshaved.TabIndex = 0
        Me.chksiteshaved.UseVisualStyleBackColor = True
        '
        'Panel39
        '
        Me.Panel39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel39.Controls.Add(Me.Label61)
        Me.Panel39.Location = New System.Drawing.Point(151, 402)
        Me.Panel39.Name = "Panel39"
        Me.Panel39.Size = New System.Drawing.Size(463, 25)
        Me.Panel39.TabIndex = 19
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(40, 5)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(95, 14)
        Me.Label61.TabIndex = 3
        Me.Label61.Text = "d. X-ray Reports"
        '
        'Panel40
        '
        Me.Panel40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel40.Controls.Add(Me.Label62)
        Me.Panel40.Location = New System.Drawing.Point(151, 378)
        Me.Panel40.Name = "Panel40"
        Me.Panel40.Size = New System.Drawing.Size(463, 25)
        Me.Panel40.TabIndex = 18
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(40, 5)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(95, 14)
        Me.Label62.TabIndex = 3
        Me.Label62.Text = "c. Urine Reports"
        '
        'Panel38
        '
        Me.Panel38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel38.Controls.Add(Me.Label60)
        Me.Panel38.Location = New System.Drawing.Point(151, 354)
        Me.Panel38.Name = "Panel38"
        Me.Panel38.Size = New System.Drawing.Size(463, 25)
        Me.Panel38.TabIndex = 17
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(40, 5)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(144, 14)
        Me.Label60.TabIndex = 3
        Me.Label60.Text = "b. Routine Blood Reports"
        '
        'Panel37
        '
        Me.Panel37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel37.Controls.Add(Me.Label59)
        Me.Panel37.Location = New System.Drawing.Point(151, 330)
        Me.Panel37.Name = "Panel37"
        Me.Panel37.Size = New System.Drawing.Size(463, 25)
        Me.Panel37.TabIndex = 16
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(40, 5)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(135, 14)
        Me.Label59.TabIndex = 3
        Me.Label59.Text = "a. X-matching && Typing"
        '
        'Panel35
        '
        Me.Panel35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel35.Controls.Add(Me.Label57)
        Me.Panel35.Location = New System.Drawing.Point(151, 306)
        Me.Panel35.Name = "Panel35"
        Me.Panel35.Size = New System.Drawing.Size(947, 25)
        Me.Panel35.TabIndex = 15
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(3, 4)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(126, 14)
        Me.Label57.TabIndex = 2
        Me.Label57.Text = "8. Laboratory Reports"
        '
        'Panel36
        '
        Me.Panel36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel36.Controls.Add(Me.Label58)
        Me.Panel36.Location = New System.Drawing.Point(151, 282)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Size = New System.Drawing.Size(463, 25)
        Me.Panel36.TabIndex = 14
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(3, 4)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(181, 14)
        Me.Label58.TabIndex = 2
        Me.Label58.Text = "7. Consent for operation signed"
        '
        'Panel34
        '
        Me.Panel34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel34.Controls.Add(Me.Label56)
        Me.Panel34.Location = New System.Drawing.Point(151, 258)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(463, 25)
        Me.Panel34.TabIndex = 13
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(3, 4)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(127, 14)
        Me.Label56.TabIndex = 2
        Me.Label56.Text = "6. Dentures Removed"
        '
        'Panel33
        '
        Me.Panel33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel33.Controls.Add(Me.Label55)
        Me.Panel33.Location = New System.Drawing.Point(151, 234)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(463, 25)
        Me.Panel33.TabIndex = 12
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(3, 4)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(208, 14)
        Me.Label55.TabIndex = 2
        Me.Label55.Text = "5. Jewelry and Accessories Removed"
        '
        'Panel32
        '
        Me.Panel32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel32.Controls.Add(Me.Label54)
        Me.Panel32.Location = New System.Drawing.Point(151, 210)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(463, 25)
        Me.Panel32.TabIndex = 11
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(3, 4)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(129, 14)
        Me.Label54.TabIndex = 2
        Me.Label54.Text = "4. Nail Polish Removed"
        '
        'Panel30
        '
        Me.Panel30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel30.Controls.Add(Me.Label52)
        Me.Panel30.Location = New System.Drawing.Point(151, 186)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(463, 25)
        Me.Panel30.TabIndex = 10
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(6, 4)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(70, 14)
        Me.Label52.TabIndex = 3
        Me.Label52.Text = "   Head cap"
        '
        'Panel31
        '
        Me.Panel31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel31.Controls.Add(Me.Label53)
        Me.Panel31.Location = New System.Drawing.Point(151, 162)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(463, 25)
        Me.Panel31.TabIndex = 9
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(3, 4)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(118, 14)
        Me.Label53.TabIndex = 2
        Me.Label53.Text = "3. Hairpins Removed"
        '
        'Panel29
        '
        Me.Panel29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel29.Controls.Add(Me.Label51)
        Me.Panel29.Location = New System.Drawing.Point(151, 138)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(463, 25)
        Me.Panel29.TabIndex = 8
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(40, 5)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(141, 14)
        Me.Label51.TabIndex = 3
        Me.Label51.Text = "> Under wears removed"
        '
        'Panel28
        '
        Me.Panel28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel28.Controls.Add(Me.Label48)
        Me.Panel28.Location = New System.Drawing.Point(151, 114)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(463, 25)
        Me.Panel28.TabIndex = 7
        '
        'Panel27
        '
        Me.Panel27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel27.Controls.Add(Me.Label50)
        Me.Panel27.Location = New System.Drawing.Point(151, 90)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(947, 25)
        Me.Panel27.TabIndex = 6
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(3, 3)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(115, 14)
        Me.Label50.TabIndex = 2
        Me.Label50.Text = "2. Personal Hygiene"
        '
        'Panel26
        '
        Me.Panel26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel26.Controls.Add(Me.Label49)
        Me.Panel26.Location = New System.Drawing.Point(151, 68)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(463, 23)
        Me.Panel26.TabIndex = 5
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(3, 4)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(202, 14)
        Me.Label49.TabIndex = 2
        Me.Label49.Text = "   Operative Field inspected by H.N."
        '
        'Panel25
        '
        Me.Panel25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel25.Controls.Add(Me.Label47)
        Me.Panel25.Controls.Add(Me.Label46)
        Me.Panel25.Location = New System.Drawing.Point(151, 28)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(463, 41)
        Me.Panel25.TabIndex = 4
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(40, 22)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(140, 14)
        Me.Label47.TabIndex = 3
        Me.Label47.Text = "> Operative Site shaved"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(3, 4)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(156, 14)
        Me.Label46.TabIndex = 2
        Me.Label46.Text = "1. Operative Field Prepared"
        '
        'Panel24
        '
        Me.Panel24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel24.Controls.Add(Me.Label34)
        Me.Panel24.Location = New System.Drawing.Point(689, 6)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(409, 23)
        Me.Panel24.TabIndex = 3
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(3, 2)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(405, 18)
        Me.Label34.TabIndex = 2
        Me.Label34.Text = "Remarks"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel23
        '
        Me.Panel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel23.Controls.Add(Me.Label32)
        Me.Panel23.Location = New System.Drawing.Point(613, 6)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(77, 23)
        Me.Panel23.TabIndex = 2
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(7, 4)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(51, 21)
        Me.Label32.TabIndex = 2
        Me.Label32.Text = "Yes/No"
        '
        'Panel22
        '
        Me.Panel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel22.Controls.Add(Me.Label20)
        Me.Panel22.Location = New System.Drawing.Point(151, 6)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(463, 23)
        Me.Panel22.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(3, 4)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(405, 21)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "To be checked and signed by the person  performing procedure"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Location = New System.Drawing.Point(341, 505)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(12, 14)
        Me.Label76.TabIndex = 80
        Me.Label76.Text = "/"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Panel97)
        Me.TabPage4.Controls.Add(Me.Panel96)
        Me.TabPage4.Controls.Add(Me.Panel95)
        Me.TabPage4.Controls.Add(Me.Panel94)
        Me.TabPage4.Controls.Add(Me.Panel93)
        Me.TabPage4.Controls.Add(Me.Panel92)
        Me.TabPage4.Controls.Add(Me.Panel91)
        Me.TabPage4.Controls.Add(Me.Panel84)
        Me.TabPage4.Controls.Add(Me.Panel89)
        Me.TabPage4.Controls.Add(Me.Panel90)
        Me.TabPage4.Controls.Add(Me.Panel85)
        Me.TabPage4.Controls.Add(Me.Panel86)
        Me.TabPage4.Controls.Add(Me.Panel87)
        Me.TabPage4.Controls.Add(Me.Panel88)
        Me.TabPage4.Controls.Add(Me.Panel80)
        Me.TabPage4.Controls.Add(Me.Panel81)
        Me.TabPage4.Controls.Add(Me.Panel82)
        Me.TabPage4.Controls.Add(Me.Panel78)
        Me.TabPage4.Controls.Add(Me.Panel79)
        Me.TabPage4.Controls.Add(Me.Panel76)
        Me.TabPage4.Controls.Add(Me.Panel77)
        Me.TabPage4.Controls.Add(Me.Panel75)
        Me.TabPage4.Controls.Add(Me.Panel73)
        Me.TabPage4.Controls.Add(Me.Panel74)
        Me.TabPage4.Controls.Add(Me.Panel72)
        Me.TabPage4.Controls.Add(Me.Panel68)
        Me.TabPage4.Controls.Add(Me.Panel69)
        Me.TabPage4.Controls.Add(Me.Panel70)
        Me.TabPage4.Controls.Add(Me.Panel71)
        Me.TabPage4.Controls.Add(Me.Panel65)
        Me.TabPage4.Controls.Add(Me.Panel66)
        Me.TabPage4.Controls.Add(Me.Panel67)
        Me.TabPage4.Controls.Add(Me.Panel62)
        Me.TabPage4.Controls.Add(Me.Panel63)
        Me.TabPage4.Controls.Add(Me.Panel64)
        Me.TabPage4.Controls.Add(Me.Panel61)
        Me.TabPage4.Controls.Add(Me.Panel60)
        Me.TabPage4.Controls.Add(Me.Panel59)
        Me.TabPage4.Controls.Add(Me.Panel58)
        Me.TabPage4.Controls.Add(Me.Panel57)
        Me.TabPage4.Controls.Add(Me.Panel51)
        Me.TabPage4.Controls.Add(Me.Panel43)
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1240, 549)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "Pre-Anesthetic Assessment"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel97
        '
        Me.Panel97.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel97.Controls.Add(Me.TextBox11)
        Me.Panel97.Controls.Add(Me.Label110)
        Me.Panel97.Location = New System.Drawing.Point(589, 425)
        Me.Panel97.Name = "Panel97"
        Me.Panel97.Size = New System.Drawing.Size(451, 84)
        Me.Panel97.TabIndex = 93
        '
        'TextBox11
        '
        Me.TextBox11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(3, 20)
        Me.TextBox11.Multiline = True
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(440, 60)
        Me.TextBox11.TabIndex = 42
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label110.Location = New System.Drawing.Point(3, 4)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(116, 14)
        Me.Label110.TabIndex = 2
        Me.Label110.Text = "Special Instructions:"
        '
        'Panel96
        '
        Me.Panel96.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel96.Controls.Add(Me.txtpreoperativemedication2)
        Me.Panel96.Controls.Add(Me.Label108)
        Me.Panel96.Location = New System.Drawing.Point(589, 356)
        Me.Panel96.Name = "Panel96"
        Me.Panel96.Size = New System.Drawing.Size(451, 70)
        Me.Panel96.TabIndex = 92
        '
        'txtpreoperativemedication2
        '
        Me.txtpreoperativemedication2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpreoperativemedication2.Location = New System.Drawing.Point(3, 20)
        Me.txtpreoperativemedication2.Multiline = True
        Me.txtpreoperativemedication2.Name = "txtpreoperativemedication2"
        Me.txtpreoperativemedication2.Size = New System.Drawing.Size(440, 45)
        Me.txtpreoperativemedication2.TabIndex = 42
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label108.Location = New System.Drawing.Point(3, 4)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(88, 14)
        Me.Label108.TabIndex = 2
        Me.Label108.Text = "Premedication:"
        '
        'Panel95
        '
        Me.Panel95.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel95.Controls.Add(Me.TextBox10)
        Me.Panel95.Controls.Add(Me.Label107)
        Me.Panel95.Location = New System.Drawing.Point(589, 296)
        Me.Panel95.Name = "Panel95"
        Me.Panel95.Size = New System.Drawing.Size(451, 61)
        Me.Panel95.TabIndex = 91
        '
        'TextBox10
        '
        Me.TextBox10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(3, 20)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(440, 35)
        Me.TextBox10.TabIndex = 42
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.Location = New System.Drawing.Point(3, 4)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(152, 14)
        Me.Label107.TabIndex = 2
        Me.Label107.Text = "Pre-operative Instructions:"
        '
        'Panel94
        '
        Me.Panel94.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel94.Controls.Add(Me.txtphysicalexam)
        Me.Panel94.Controls.Add(Me.Label106)
        Me.Panel94.Location = New System.Drawing.Point(589, 236)
        Me.Panel94.Name = "Panel94"
        Me.Panel94.Size = New System.Drawing.Size(451, 61)
        Me.Panel94.TabIndex = 90
        '
        'txtphysicalexam
        '
        Me.txtphysicalexam.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphysicalexam.Location = New System.Drawing.Point(3, 20)
        Me.txtphysicalexam.Multiline = True
        Me.txtphysicalexam.Name = "txtphysicalexam"
        Me.txtphysicalexam.Size = New System.Drawing.Size(440, 35)
        Me.txtphysicalexam.TabIndex = 42
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label106.Location = New System.Drawing.Point(3, 4)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(121, 14)
        Me.Label106.TabIndex = 2
        Me.Label106.Text = "Physical Examination:"
        '
        'Panel93
        '
        Me.Panel93.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel93.Controls.Add(Me.txtsignificanthistory)
        Me.Panel93.Controls.Add(Me.Label105)
        Me.Panel93.Location = New System.Drawing.Point(589, 178)
        Me.Panel93.Name = "Panel93"
        Me.Panel93.Size = New System.Drawing.Size(451, 59)
        Me.Panel93.TabIndex = 89
        '
        'txtsignificanthistory
        '
        Me.txtsignificanthistory.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsignificanthistory.Location = New System.Drawing.Point(3, 20)
        Me.txtsignificanthistory.Multiline = True
        Me.txtsignificanthistory.Name = "txtsignificanthistory"
        Me.txtsignificanthistory.Size = New System.Drawing.Size(440, 34)
        Me.txtsignificanthistory.TabIndex = 42
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label105.Location = New System.Drawing.Point(3, 4)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(107, 14)
        Me.Label105.TabIndex = 2
        Me.Label105.Text = "Significant History:"
        '
        'Panel92
        '
        Me.Panel92.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel92.Controls.Add(Me.txtotherphysicalstatus)
        Me.Panel92.Controls.Add(Me.Label109)
        Me.Panel92.Location = New System.Drawing.Point(589, 152)
        Me.Panel92.Name = "Panel92"
        Me.Panel92.Size = New System.Drawing.Size(451, 27)
        Me.Panel92.TabIndex = 88
        '
        'txtotherphysicalstatus
        '
        Me.txtotherphysicalstatus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtotherphysicalstatus.Location = New System.Drawing.Point(54, 1)
        Me.txtotherphysicalstatus.Name = "txtotherphysicalstatus"
        Me.txtotherphysicalstatus.Size = New System.Drawing.Size(389, 23)
        Me.txtotherphysicalstatus.TabIndex = 42
        '
        'Label109
        '
        Me.Label109.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label109.Location = New System.Drawing.Point(3, 4)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(57, 21)
        Me.Label109.TabIndex = 2
        Me.Label109.Text = "Others:"
        '
        'txtbiochem
        '
        Me.txtbiochem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbiochem.Location = New System.Drawing.Point(265, 27)
        Me.txtbiochem.Name = "txtbiochem"
        Me.txtbiochem.Size = New System.Drawing.Size(178, 23)
        Me.txtbiochem.TabIndex = 87
        '
        'Panel91
        '
        Me.Panel91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel91.Controls.Add(Me.txtbiochem)
        Me.Panel91.Controls.Add(Me.txtec)
        Me.Panel91.Controls.Add(Me.txtcxr)
        Me.Panel91.Controls.Add(Me.txthb)
        Me.Panel91.Controls.Add(Me.Label104)
        Me.Panel91.Controls.Add(Me.Label103)
        Me.Panel91.Controls.Add(Me.Label102)
        Me.Panel91.Controls.Add(Me.Label100)
        Me.Panel91.Controls.Add(Me.Label101)
        Me.Panel91.Location = New System.Drawing.Point(589, 66)
        Me.Panel91.Name = "Panel91"
        Me.Panel91.Size = New System.Drawing.Size(451, 87)
        Me.Panel91.TabIndex = 86
        '
        'txtec
        '
        Me.txtec.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtec.Location = New System.Drawing.Point(235, 58)
        Me.txtec.Name = "txtec"
        Me.txtec.Size = New System.Drawing.Size(208, 23)
        Me.txtec.TabIndex = 45
        '
        'txtcxr
        '
        Me.txtcxr.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcxr.Location = New System.Drawing.Point(35, 58)
        Me.txtcxr.Name = "txtcxr"
        Me.txtcxr.Size = New System.Drawing.Size(171, 23)
        Me.txtcxr.TabIndex = 43
        '
        'txthb
        '
        Me.txthb.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthb.Location = New System.Drawing.Point(25, 27)
        Me.txthb.Name = "txthb"
        Me.txthb.Size = New System.Drawing.Size(181, 23)
        Me.txthb.TabIndex = 42
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Location = New System.Drawing.Point(210, 62)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(25, 14)
        Me.Label104.TabIndex = 7
        Me.Label104.Text = "EC:"
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Location = New System.Drawing.Point(3, 62)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(29, 14)
        Me.Label103.TabIndex = 6
        Me.Label103.Text = "CXr:"
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Location = New System.Drawing.Point(208, 29)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(57, 14)
        Me.Label102.TabIndex = 5
        Me.Label102.Text = "Biochem:"
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Location = New System.Drawing.Point(3, 31)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(26, 14)
        Me.Label100.TabIndex = 4
        Me.Label100.Text = "HB:"
        '
        'Label101
        '
        Me.Label101.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(3, 4)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(307, 21)
        Me.Label101.TabIndex = 2
        Me.Label101.Text = "Physical Status:"
        '
        'Panel84
        '
        Me.Panel84.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel84.Controls.Add(Me.txtweight)
        Me.Panel84.Controls.Add(Me.Label98)
        Me.Panel84.Controls.Add(Me.Label99)
        Me.Panel84.Location = New System.Drawing.Point(589, 14)
        Me.Panel84.Name = "Panel84"
        Me.Panel84.Size = New System.Drawing.Size(451, 53)
        Me.Panel84.TabIndex = 85
        '
        'txtweight
        '
        Me.txtweight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtweight.Location = New System.Drawing.Point(51, 27)
        Me.txtweight.Name = "txtweight"
        Me.txtweight.Size = New System.Drawing.Size(262, 23)
        Me.txtweight.TabIndex = 41
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Location = New System.Drawing.Point(3, 31)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(51, 14)
        Me.Label98.TabIndex = 3
        Me.Label98.Text = "Weight:"
        '
        'Label99
        '
        Me.Label99.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.Location = New System.Drawing.Point(3, 4)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(240, 21)
        Me.Label99.TabIndex = 2
        Me.Label99.Text = "MEDICAL OFFICER ASSESSMENT"
        '
        'Panel89
        '
        Me.Panel89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel89.Controls.Add(Me.chkispregnant)
        Me.Panel89.Location = New System.Drawing.Point(513, 479)
        Me.Panel89.Name = "Panel89"
        Me.Panel89.Size = New System.Drawing.Size(77, 30)
        Me.Panel89.TabIndex = 84
        '
        'chkispregnant
        '
        Me.chkispregnant.AutoSize = True
        Me.chkispregnant.Location = New System.Drawing.Point(30, 7)
        Me.chkispregnant.Name = "chkispregnant"
        Me.chkispregnant.Size = New System.Drawing.Size(15, 14)
        Me.chkispregnant.TabIndex = 1
        Me.chkispregnant.UseVisualStyleBackColor = True
        '
        'Panel90
        '
        Me.Panel90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel90.Controls.Add(Me.chkhasallergies)
        Me.Panel90.Location = New System.Drawing.Point(513, 450)
        Me.Panel90.Name = "Panel90"
        Me.Panel90.Size = New System.Drawing.Size(77, 30)
        Me.Panel90.TabIndex = 83
        '
        'chkhasallergies
        '
        Me.chkhasallergies.AutoSize = True
        Me.chkhasallergies.Location = New System.Drawing.Point(30, 7)
        Me.chkhasallergies.Name = "chkhasallergies"
        Me.chkhasallergies.Size = New System.Drawing.Size(15, 14)
        Me.chkhasallergies.TabIndex = 1
        Me.chkhasallergies.UseVisualStyleBackColor = True
        '
        'Panel85
        '
        Me.Panel85.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel85.Controls.Add(Me.chkhasrheumaticfever)
        Me.Panel85.Location = New System.Drawing.Point(513, 368)
        Me.Panel85.Name = "Panel85"
        Me.Panel85.Size = New System.Drawing.Size(77, 25)
        Me.Panel85.TabIndex = 81
        '
        'chkhasrheumaticfever
        '
        Me.chkhasrheumaticfever.AutoSize = True
        Me.chkhasrheumaticfever.Location = New System.Drawing.Point(30, 5)
        Me.chkhasrheumaticfever.Name = "chkhasrheumaticfever"
        Me.chkhasrheumaticfever.Size = New System.Drawing.Size(15, 14)
        Me.chkhasrheumaticfever.TabIndex = 1
        Me.chkhasrheumaticfever.UseVisualStyleBackColor = True
        '
        'Panel86
        '
        Me.Panel86.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel86.Controls.Add(Me.chkhasepilepsy)
        Me.Panel86.Location = New System.Drawing.Point(513, 344)
        Me.Panel86.Name = "Panel86"
        Me.Panel86.Size = New System.Drawing.Size(77, 25)
        Me.Panel86.TabIndex = 80
        '
        'chkhasepilepsy
        '
        Me.chkhasepilepsy.AutoSize = True
        Me.chkhasepilepsy.Location = New System.Drawing.Point(30, 7)
        Me.chkhasepilepsy.Name = "chkhasepilepsy"
        Me.chkhasepilepsy.Size = New System.Drawing.Size(15, 14)
        Me.chkhasepilepsy.TabIndex = 1
        Me.chkhasepilepsy.UseVisualStyleBackColor = True
        '
        'Panel87
        '
        Me.Panel87.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel87.Controls.Add(Me.chkhasdiabetes)
        Me.Panel87.Location = New System.Drawing.Point(513, 320)
        Me.Panel87.Name = "Panel87"
        Me.Panel87.Size = New System.Drawing.Size(318, 25)
        Me.Panel87.TabIndex = 79
        '
        'chkhasdiabetes
        '
        Me.chkhasdiabetes.AutoSize = True
        Me.chkhasdiabetes.Location = New System.Drawing.Point(30, 7)
        Me.chkhasdiabetes.Name = "chkhasdiabetes"
        Me.chkhasdiabetes.Size = New System.Drawing.Size(15, 14)
        Me.chkhasdiabetes.TabIndex = 1
        Me.chkhasdiabetes.UseVisualStyleBackColor = True
        '
        'Panel88
        '
        Me.Panel88.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel88.Controls.Add(Me.chkhaskidneydisease)
        Me.Panel88.Location = New System.Drawing.Point(513, 296)
        Me.Panel88.Name = "Panel88"
        Me.Panel88.Size = New System.Drawing.Size(77, 25)
        Me.Panel88.TabIndex = 78
        '
        'chkhaskidneydisease
        '
        Me.chkhaskidneydisease.AutoSize = True
        Me.chkhaskidneydisease.Location = New System.Drawing.Point(30, 7)
        Me.chkhaskidneydisease.Name = "chkhaskidneydisease"
        Me.chkhaskidneydisease.Size = New System.Drawing.Size(15, 14)
        Me.chkhaskidneydisease.TabIndex = 1
        Me.chkhaskidneydisease.UseVisualStyleBackColor = True
        '
        'Panel80
        '
        Me.Panel80.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel80.Controls.Add(Me.chkhashepatitis)
        Me.Panel80.Location = New System.Drawing.Point(513, 272)
        Me.Panel80.Name = "Panel80"
        Me.Panel80.Size = New System.Drawing.Size(77, 25)
        Me.Panel80.TabIndex = 77
        '
        'chkhashepatitis
        '
        Me.chkhashepatitis.AutoSize = True
        Me.chkhashepatitis.Location = New System.Drawing.Point(30, 7)
        Me.chkhashepatitis.Name = "chkhashepatitis"
        Me.chkhashepatitis.Size = New System.Drawing.Size(15, 14)
        Me.chkhashepatitis.TabIndex = 1
        Me.chkhashepatitis.UseVisualStyleBackColor = True
        '
        'Panel81
        '
        Me.Panel81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel81.Controls.Add(Me.chkhasasthma)
        Me.Panel81.Location = New System.Drawing.Point(513, 248)
        Me.Panel81.Name = "Panel81"
        Me.Panel81.Size = New System.Drawing.Size(77, 25)
        Me.Panel81.TabIndex = 76
        '
        'chkhasasthma
        '
        Me.chkhasasthma.AutoSize = True
        Me.chkhasasthma.Location = New System.Drawing.Point(30, 7)
        Me.chkhasasthma.Name = "chkhasasthma"
        Me.chkhasasthma.Size = New System.Drawing.Size(15, 14)
        Me.chkhasasthma.TabIndex = 1
        Me.chkhasasthma.UseVisualStyleBackColor = True
        '
        'Panel82
        '
        Me.Panel82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel82.Controls.Add(Me.chkhaschroniclungdisease)
        Me.Panel82.Location = New System.Drawing.Point(513, 224)
        Me.Panel82.Name = "Panel82"
        Me.Panel82.Size = New System.Drawing.Size(77, 25)
        Me.Panel82.TabIndex = 75
        '
        'chkhaschroniclungdisease
        '
        Me.chkhaschroniclungdisease.AutoSize = True
        Me.chkhaschroniclungdisease.Location = New System.Drawing.Point(30, 7)
        Me.chkhaschroniclungdisease.Name = "chkhaschroniclungdisease"
        Me.chkhaschroniclungdisease.Size = New System.Drawing.Size(15, 14)
        Me.chkhaschroniclungdisease.TabIndex = 1
        Me.chkhaschroniclungdisease.UseVisualStyleBackColor = True
        '
        'Panel78
        '
        Me.Panel78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel78.Controls.Add(Me.chkhasangina)
        Me.Panel78.Location = New System.Drawing.Point(513, 200)
        Me.Panel78.Name = "Panel78"
        Me.Panel78.Size = New System.Drawing.Size(77, 25)
        Me.Panel78.TabIndex = 74
        '
        'chkhasangina
        '
        Me.chkhasangina.AutoSize = True
        Me.chkhasangina.Location = New System.Drawing.Point(30, 7)
        Me.chkhasangina.Name = "chkhasangina"
        Me.chkhasangina.Size = New System.Drawing.Size(15, 14)
        Me.chkhasangina.TabIndex = 1
        Me.chkhasangina.UseVisualStyleBackColor = True
        '
        'Panel79
        '
        Me.Panel79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel79.Controls.Add(Me.chkhasstroke)
        Me.Panel79.Location = New System.Drawing.Point(513, 176)
        Me.Panel79.Name = "Panel79"
        Me.Panel79.Size = New System.Drawing.Size(77, 25)
        Me.Panel79.TabIndex = 73
        '
        'chkhasstroke
        '
        Me.chkhasstroke.AutoSize = True
        Me.chkhasstroke.Location = New System.Drawing.Point(30, 7)
        Me.chkhasstroke.Name = "chkhasstroke"
        Me.chkhasstroke.Size = New System.Drawing.Size(15, 14)
        Me.chkhasstroke.TabIndex = 1
        Me.chkhasstroke.UseVisualStyleBackColor = True
        '
        'Panel76
        '
        Me.Panel76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel76.Controls.Add(Me.chkhashighblood)
        Me.Panel76.Location = New System.Drawing.Point(513, 152)
        Me.Panel76.Name = "Panel76"
        Me.Panel76.Size = New System.Drawing.Size(77, 25)
        Me.Panel76.TabIndex = 72
        '
        'chkhashighblood
        '
        Me.chkhashighblood.AutoSize = True
        Me.chkhashighblood.Location = New System.Drawing.Point(30, 7)
        Me.chkhashighblood.Name = "chkhashighblood"
        Me.chkhashighblood.Size = New System.Drawing.Size(15, 14)
        Me.chkhashighblood.TabIndex = 1
        Me.chkhashighblood.UseVisualStyleBackColor = True
        '
        'Panel77
        '
        Me.Panel77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel77.Controls.Add(Me.chkhasheartattack)
        Me.Panel77.Location = New System.Drawing.Point(513, 113)
        Me.Panel77.Name = "Panel77"
        Me.Panel77.Size = New System.Drawing.Size(77, 40)
        Me.Panel77.TabIndex = 71
        '
        'Panel75
        '
        Me.Panel75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel75.Controls.Add(Me.chkhasesthesiaproblem)
        Me.Panel75.Location = New System.Drawing.Point(513, 90)
        Me.Panel75.Name = "Panel75"
        Me.Panel75.Size = New System.Drawing.Size(77, 25)
        Me.Panel75.TabIndex = 70
        '
        'Panel73
        '
        Me.Panel73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel73.Controls.Add(Me.chkhaspreviousanesthesia)
        Me.Panel73.Location = New System.Drawing.Point(513, 66)
        Me.Panel73.Name = "Panel73"
        Me.Panel73.Size = New System.Drawing.Size(77, 25)
        Me.Panel73.TabIndex = 69
        '
        'Panel74
        '
        Me.Panel74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel74.Controls.Add(Me.Label97)
        Me.Panel74.Location = New System.Drawing.Point(513, 14)
        Me.Panel74.Name = "Panel74"
        Me.Panel74.Size = New System.Drawing.Size(77, 53)
        Me.Panel74.TabIndex = 68
        '
        'Label97
        '
        Me.Label97.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.Location = New System.Drawing.Point(12, 15)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(51, 21)
        Me.Label97.TabIndex = 3
        Me.Label97.Text = "Yes/No"
        Me.Label97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel72
        '
        Me.Panel72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel72.Controls.Add(Me.Label96)
        Me.Panel72.Location = New System.Drawing.Point(196, 479)
        Me.Panel72.Name = "Panel72"
        Me.Panel72.Size = New System.Drawing.Size(318, 30)
        Me.Panel72.TabIndex = 67
        '
        'Label96
        '
        Me.Label96.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.Location = New System.Drawing.Point(3, 5)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(405, 21)
        Me.Label96.TabIndex = 2
        Me.Label96.Text = "Could you be pregnant?"
        '
        'Panel68
        '
        Me.Panel68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel68.Controls.Add(Me.Label92)
        Me.Panel68.Location = New System.Drawing.Point(196, 450)
        Me.Panel68.Name = "Panel68"
        Me.Panel68.Size = New System.Drawing.Size(318, 30)
        Me.Panel68.TabIndex = 66
        '
        'Label92
        '
        Me.Label92.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.Location = New System.Drawing.Point(3, 5)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(405, 21)
        Me.Label92.TabIndex = 2
        Me.Label92.Text = "Do you allergies?"
        '
        'Panel69
        '
        Me.Panel69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel69.Controls.Add(Me.txtdrugstaken)
        Me.Panel69.Controls.Add(Me.Label93)
        Me.Panel69.Location = New System.Drawing.Point(196, 421)
        Me.Panel69.Name = "Panel69"
        Me.Panel69.Size = New System.Drawing.Size(394, 30)
        Me.Panel69.TabIndex = 65
        '
        'txtdrugstaken
        '
        Me.txtdrugstaken.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdrugstaken.Location = New System.Drawing.Point(152, 2)
        Me.txtdrugstaken.Name = "txtdrugstaken"
        Me.txtdrugstaken.Size = New System.Drawing.Size(238, 23)
        Me.txtdrugstaken.TabIndex = 41
        '
        'Label93
        '
        Me.Label93.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.Location = New System.Drawing.Point(3, 5)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(163, 21)
        Me.Label93.TabIndex = 2
        Me.Label93.Text = "What Drugs do you take?"
        '
        'Panel70
        '
        Me.Panel70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel70.Controls.Add(Me.txtotherdiseases)
        Me.Panel70.Controls.Add(Me.Label94)
        Me.Panel70.Location = New System.Drawing.Point(196, 392)
        Me.Panel70.Name = "Panel70"
        Me.Panel70.Size = New System.Drawing.Size(394, 30)
        Me.Panel70.TabIndex = 64
        '
        'txtotherdiseases
        '
        Me.txtotherdiseases.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtotherdiseases.Location = New System.Drawing.Point(152, 2)
        Me.txtotherdiseases.Name = "txtotherdiseases"
        Me.txtotherdiseases.Size = New System.Drawing.Size(238, 23)
        Me.txtotherdiseases.TabIndex = 40
        '
        'Label94
        '
        Me.Label94.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.Location = New System.Drawing.Point(3, 5)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(163, 21)
        Me.Label94.TabIndex = 2
        Me.Label94.Text = "Other diseases (Describe)"
        '
        'Panel71
        '
        Me.Panel71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel71.Controls.Add(Me.Label95)
        Me.Panel71.Location = New System.Drawing.Point(196, 368)
        Me.Panel71.Name = "Panel71"
        Me.Panel71.Size = New System.Drawing.Size(318, 25)
        Me.Panel71.TabIndex = 63
        '
        'Label95
        '
        Me.Label95.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.Location = New System.Drawing.Point(3, 5)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(296, 21)
        Me.Label95.TabIndex = 2
        Me.Label95.Text = "Rheumatic Fever"
        '
        'Panel65
        '
        Me.Panel65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel65.Controls.Add(Me.Label89)
        Me.Panel65.Location = New System.Drawing.Point(196, 344)
        Me.Panel65.Name = "Panel65"
        Me.Panel65.Size = New System.Drawing.Size(318, 25)
        Me.Panel65.TabIndex = 62
        '
        'Label89
        '
        Me.Label89.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(3, 5)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(296, 21)
        Me.Label89.TabIndex = 2
        Me.Label89.Text = "Epilepsy"
        '
        'Panel66
        '
        Me.Panel66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel66.Controls.Add(Me.Label90)
        Me.Panel66.Location = New System.Drawing.Point(196, 320)
        Me.Panel66.Name = "Panel66"
        Me.Panel66.Size = New System.Drawing.Size(318, 25)
        Me.Panel66.TabIndex = 61
        '
        'Label90
        '
        Me.Label90.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.Location = New System.Drawing.Point(3, 5)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(296, 21)
        Me.Label90.TabIndex = 2
        Me.Label90.Text = "Diabetes"
        '
        'Panel67
        '
        Me.Panel67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel67.Controls.Add(Me.Label91)
        Me.Panel67.Location = New System.Drawing.Point(196, 296)
        Me.Panel67.Name = "Panel67"
        Me.Panel67.Size = New System.Drawing.Size(318, 25)
        Me.Panel67.TabIndex = 60
        '
        'Label91
        '
        Me.Label91.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.Location = New System.Drawing.Point(3, 5)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(296, 21)
        Me.Label91.TabIndex = 2
        Me.Label91.Text = "Kidney Disease"
        '
        'Panel62
        '
        Me.Panel62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel62.Controls.Add(Me.Label86)
        Me.Panel62.Location = New System.Drawing.Point(196, 272)
        Me.Panel62.Name = "Panel62"
        Me.Panel62.Size = New System.Drawing.Size(318, 25)
        Me.Panel62.TabIndex = 59
        '
        'Label86
        '
        Me.Label86.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(3, 5)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(296, 21)
        Me.Label86.TabIndex = 2
        Me.Label86.Text = "Hepatitis"
        '
        'Panel63
        '
        Me.Panel63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel63.Controls.Add(Me.Label87)
        Me.Panel63.Location = New System.Drawing.Point(196, 248)
        Me.Panel63.Name = "Panel63"
        Me.Panel63.Size = New System.Drawing.Size(318, 25)
        Me.Panel63.TabIndex = 58
        '
        'Label87
        '
        Me.Label87.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.Location = New System.Drawing.Point(3, 5)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(296, 21)
        Me.Label87.TabIndex = 2
        Me.Label87.Text = "Asthma"
        '
        'Panel64
        '
        Me.Panel64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel64.Controls.Add(Me.Label88)
        Me.Panel64.Location = New System.Drawing.Point(196, 224)
        Me.Panel64.Name = "Panel64"
        Me.Panel64.Size = New System.Drawing.Size(318, 25)
        Me.Panel64.TabIndex = 57
        '
        'Label88
        '
        Me.Label88.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.Location = New System.Drawing.Point(3, 5)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(296, 21)
        Me.Label88.TabIndex = 2
        Me.Label88.Text = "Chronic Lung Disease"
        '
        'Panel61
        '
        Me.Panel61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel61.Controls.Add(Me.Label85)
        Me.Panel61.Location = New System.Drawing.Point(196, 200)
        Me.Panel61.Name = "Panel61"
        Me.Panel61.Size = New System.Drawing.Size(318, 25)
        Me.Panel61.TabIndex = 56
        '
        'Label85
        '
        Me.Label85.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.Location = New System.Drawing.Point(3, 5)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(296, 21)
        Me.Label85.TabIndex = 2
        Me.Label85.Text = "Angina"
        '
        'Panel60
        '
        Me.Panel60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel60.Controls.Add(Me.Label84)
        Me.Panel60.Location = New System.Drawing.Point(196, 176)
        Me.Panel60.Name = "Panel60"
        Me.Panel60.Size = New System.Drawing.Size(318, 25)
        Me.Panel60.TabIndex = 55
        '
        'Label84
        '
        Me.Label84.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(3, 5)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(296, 21)
        Me.Label84.TabIndex = 2
        Me.Label84.Text = "Stroke"
        '
        'Panel59
        '
        Me.Panel59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel59.Controls.Add(Me.Label83)
        Me.Panel59.Location = New System.Drawing.Point(196, 152)
        Me.Panel59.Name = "Panel59"
        Me.Panel59.Size = New System.Drawing.Size(318, 25)
        Me.Panel59.TabIndex = 54
        '
        'Label83
        '
        Me.Label83.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(3, 5)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(296, 21)
        Me.Label83.TabIndex = 2
        Me.Label83.Text = "High Blood Pressure"
        '
        'Panel58
        '
        Me.Panel58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel58.Controls.Add(Me.Label82)
        Me.Panel58.Controls.Add(Me.Label81)
        Me.Panel58.Location = New System.Drawing.Point(196, 113)
        Me.Panel58.Name = "Panel58"
        Me.Panel58.Size = New System.Drawing.Size(318, 40)
        Me.Panel58.TabIndex = 53
        '
        'Label82
        '
        Me.Label82.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(3, 21)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(405, 16)
        Me.Label82.TabIndex = 3
        Me.Label82.Text = "Heart Attack"
        '
        'Label81
        '
        Me.Label81.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(3, 2)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(307, 16)
        Me.Label81.TabIndex = 2
        Me.Label81.Text = "Have you ever suffered from:"
        '
        'Panel57
        '
        Me.Panel57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel57.Controls.Add(Me.Label79)
        Me.Panel57.Location = New System.Drawing.Point(196, 90)
        Me.Panel57.Name = "Panel57"
        Me.Panel57.Size = New System.Drawing.Size(318, 25)
        Me.Panel57.TabIndex = 52
        '
        'Label79
        '
        Me.Label79.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(3, 5)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(250, 21)
        Me.Label79.TabIndex = 2
        Me.Label79.Text = "Did you have any problem?"
        '
        'Panel51
        '
        Me.Panel51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel51.Controls.Add(Me.Label80)
        Me.Panel51.Location = New System.Drawing.Point(196, 66)
        Me.Panel51.Name = "Panel51"
        Me.Panel51.Size = New System.Drawing.Size(318, 25)
        Me.Panel51.TabIndex = 51
        '
        'Label80
        '
        Me.Label80.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(3, 3)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(296, 21)
        Me.Label80.TabIndex = 2
        Me.Label80.Text = "Have you had anesthesia for operations previously?"
        '
        'Panel43
        '
        Me.Panel43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel43.Controls.Add(Me.Label78)
        Me.Panel43.Controls.Add(Me.Label77)
        Me.Panel43.Location = New System.Drawing.Point(196, 14)
        Me.Panel43.Name = "Panel43"
        Me.Panel43.Size = New System.Drawing.Size(318, 53)
        Me.Panel43.TabIndex = 50
        '
        'Label78
        '
        Me.Label78.Location = New System.Drawing.Point(17, 25)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(405, 21)
        Me.Label78.TabIndex = 3
        Me.Label78.Text = "Please answer the questions YES or No"
        '
        'Label77
        '
        Me.Label77.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(3, 4)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(307, 21)
        Me.Label77.TabIndex = 2
        Me.Label77.Text = "Patient Information:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(13, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 259
        Me.Label1.Text = "Operation : "
        '
        'cmbprocedurename
        '
        Me.cmbprocedurename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbprocedurename.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbprocedurename.FormattingEnabled = True
        Me.cmbprocedurename.Location = New System.Drawing.Point(97, 97)
        Me.cmbprocedurename.Name = "cmbprocedurename"
        Me.cmbprocedurename.Size = New System.Drawing.Size(398, 24)
        Me.cmbprocedurename.TabIndex = 260
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(511, 101)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(140, 16)
        Me.Label18.TabIndex = 261
        Me.Label18.Text = "Date of Procedure : "
        '
        'dtpproceduredate
        '
        Me.dtpproceduredate.CustomFormat = "hh:mm tt"
        Me.dtpproceduredate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpproceduredate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpproceduredate.Location = New System.Drawing.Point(650, 98)
        Me.dtpproceduredate.Name = "dtpproceduredate"
        Me.dtpproceduredate.Size = New System.Drawing.Size(152, 22)
        Me.dtpproceduredate.TabIndex = 262
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(40, 4)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(109, 14)
        Me.Label48.TabIndex = 3
        Me.Label48.Text = "> Patient Gowned"
        '
        'chkhaspreviousanesthesia
        '
        Me.chkhaspreviousanesthesia.AutoSize = True
        Me.chkhaspreviousanesthesia.Location = New System.Drawing.Point(30, 4)
        Me.chkhaspreviousanesthesia.Name = "chkhaspreviousanesthesia"
        Me.chkhaspreviousanesthesia.Size = New System.Drawing.Size(15, 14)
        Me.chkhaspreviousanesthesia.TabIndex = 2
        Me.chkhaspreviousanesthesia.UseVisualStyleBackColor = True
        '
        'chkhasheartattack
        '
        Me.chkhasheartattack.AutoSize = True
        Me.chkhasheartattack.Location = New System.Drawing.Point(30, 12)
        Me.chkhasheartattack.Name = "chkhasheartattack"
        Me.chkhasheartattack.Size = New System.Drawing.Size(15, 14)
        Me.chkhasheartattack.TabIndex = 2
        Me.chkhasheartattack.UseVisualStyleBackColor = True
        '
        'chkhasesthesiaproblem
        '
        Me.chkhasesthesiaproblem.AutoSize = True
        Me.chkhasesthesiaproblem.Location = New System.Drawing.Point(30, 4)
        Me.chkhasesthesiaproblem.Name = "chkhasesthesiaproblem"
        Me.chkhasesthesiaproblem.Size = New System.Drawing.Size(15, 14)
        Me.chkhasesthesiaproblem.TabIndex = 2
        Me.chkhasesthesiaproblem.UseVisualStyleBackColor = True
        '
        'frmOperativeRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 701)
        Me.Controls.Add(Me.dtpproceduredate)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cmbprocedurename)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmOperativeRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operative Record"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel21.ResumeLayout(False)
        Me.Panel21.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tabpreoperative.ResumeLayout(False)
        Me.tabpreoperative.PerformLayout()
        Me.Panel56.ResumeLayout(False)
        Me.Panel56.PerformLayout()
        Me.Panel55.ResumeLayout(False)
        Me.Panel55.PerformLayout()
        Me.Panel53.ResumeLayout(False)
        Me.Panel53.PerformLayout()
        Me.Panel54.ResumeLayout(False)
        Me.Panel54.PerformLayout()
        Me.Panel52.ResumeLayout(False)
        Me.Panel52.PerformLayout()
        Me.Panel48.ResumeLayout(False)
        Me.Panel48.PerformLayout()
        Me.Panel49.ResumeLayout(False)
        Me.Panel49.PerformLayout()
        Me.Panel50.ResumeLayout(False)
        Me.Panel50.PerformLayout()
        Me.Panel46.ResumeLayout(False)
        Me.Panel46.PerformLayout()
        Me.Panel47.ResumeLayout(False)
        Me.Panel47.PerformLayout()
        Me.Panel44.ResumeLayout(False)
        Me.Panel44.PerformLayout()
        Me.Panel45.ResumeLayout(False)
        Me.Panel45.PerformLayout()
        Me.Panel42.ResumeLayout(False)
        Me.Panel42.PerformLayout()
        Me.Panel41.ResumeLayout(False)
        Me.Panel41.PerformLayout()
        Me.Panel39.ResumeLayout(False)
        Me.Panel39.PerformLayout()
        Me.Panel40.ResumeLayout(False)
        Me.Panel40.PerformLayout()
        Me.Panel38.ResumeLayout(False)
        Me.Panel38.PerformLayout()
        Me.Panel37.ResumeLayout(False)
        Me.Panel37.PerformLayout()
        Me.Panel35.ResumeLayout(False)
        Me.Panel35.PerformLayout()
        Me.Panel36.ResumeLayout(False)
        Me.Panel36.PerformLayout()
        Me.Panel34.ResumeLayout(False)
        Me.Panel34.PerformLayout()
        Me.Panel33.ResumeLayout(False)
        Me.Panel33.PerformLayout()
        Me.Panel32.ResumeLayout(False)
        Me.Panel32.PerformLayout()
        Me.Panel30.ResumeLayout(False)
        Me.Panel30.PerformLayout()
        Me.Panel31.ResumeLayout(False)
        Me.Panel31.PerformLayout()
        Me.Panel29.ResumeLayout(False)
        Me.Panel29.PerformLayout()
        Me.Panel28.ResumeLayout(False)
        Me.Panel28.PerformLayout()
        Me.Panel27.ResumeLayout(False)
        Me.Panel27.PerformLayout()
        Me.Panel26.ResumeLayout(False)
        Me.Panel26.PerformLayout()
        Me.Panel25.ResumeLayout(False)
        Me.Panel25.PerformLayout()
        Me.Panel24.ResumeLayout(False)
        Me.Panel23.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.Panel97.ResumeLayout(False)
        Me.Panel97.PerformLayout()
        Me.Panel96.ResumeLayout(False)
        Me.Panel96.PerformLayout()
        Me.Panel95.ResumeLayout(False)
        Me.Panel95.PerformLayout()
        Me.Panel94.ResumeLayout(False)
        Me.Panel94.PerformLayout()
        Me.Panel93.ResumeLayout(False)
        Me.Panel93.PerformLayout()
        Me.Panel92.ResumeLayout(False)
        Me.Panel92.PerformLayout()
        Me.Panel91.ResumeLayout(False)
        Me.Panel91.PerformLayout()
        Me.Panel84.ResumeLayout(False)
        Me.Panel84.PerformLayout()
        Me.Panel89.ResumeLayout(False)
        Me.Panel89.PerformLayout()
        Me.Panel90.ResumeLayout(False)
        Me.Panel90.PerformLayout()
        Me.Panel85.ResumeLayout(False)
        Me.Panel85.PerformLayout()
        Me.Panel86.ResumeLayout(False)
        Me.Panel86.PerformLayout()
        Me.Panel87.ResumeLayout(False)
        Me.Panel87.PerformLayout()
        Me.Panel88.ResumeLayout(False)
        Me.Panel88.PerformLayout()
        Me.Panel80.ResumeLayout(False)
        Me.Panel80.PerformLayout()
        Me.Panel81.ResumeLayout(False)
        Me.Panel81.PerformLayout()
        Me.Panel82.ResumeLayout(False)
        Me.Panel82.PerformLayout()
        Me.Panel78.ResumeLayout(False)
        Me.Panel78.PerformLayout()
        Me.Panel79.ResumeLayout(False)
        Me.Panel79.PerformLayout()
        Me.Panel76.ResumeLayout(False)
        Me.Panel76.PerformLayout()
        Me.Panel77.ResumeLayout(False)
        Me.Panel77.PerformLayout()
        Me.Panel75.ResumeLayout(False)
        Me.Panel75.PerformLayout()
        Me.Panel73.ResumeLayout(False)
        Me.Panel73.PerformLayout()
        Me.Panel74.ResumeLayout(False)
        Me.Panel72.ResumeLayout(False)
        Me.Panel68.ResumeLayout(False)
        Me.Panel69.ResumeLayout(False)
        Me.Panel69.PerformLayout()
        Me.Panel70.ResumeLayout(False)
        Me.Panel70.PerformLayout()
        Me.Panel71.ResumeLayout(False)
        Me.Panel65.ResumeLayout(False)
        Me.Panel66.ResumeLayout(False)
        Me.Panel67.ResumeLayout(False)
        Me.Panel62.ResumeLayout(False)
        Me.Panel63.ResumeLayout(False)
        Me.Panel64.ResumeLayout(False)
        Me.Panel61.ResumeLayout(False)
        Me.Panel60.ResumeLayout(False)
        Me.Panel59.ResumeLayout(False)
        Me.Panel58.ResumeLayout(False)
        Me.Panel57.ResumeLayout(False)
        Me.Panel51.ResumeLayout(False)
        Me.Panel43.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Public WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsprintoptions As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents tsClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbprocedurename As System.Windows.Forms.ComboBox
    Friend WithEvents OperativeRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ORNursingRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SafetyChecklistToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents rdbloodlossriskno As System.Windows.Forms.RadioButton
    Friend WithEvents rdbloodlossrisk As System.Windows.Forms.RadioButton
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents rdaspirationriskno As System.Windows.Forms.RadioButton
    Friend WithEvents rdaspirationrisk As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents rdknownallergyno As System.Windows.Forms.RadioButton
    Friend WithEvents rdknownallergy As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents chkpulseoximeter As System.Windows.Forms.CheckBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents chkanaesthesiasafetycheck As System.Windows.Forms.CheckBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents chksitemarked As System.Windows.Forms.CheckBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents chkpatientconfirmed As System.Windows.Forms.CheckBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents chkintroducedmembers As System.Windows.Forms.CheckBox
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chkconfirmpatientconsent As System.Windows.Forms.CheckBox
    Friend WithEvents chkconfirmpatientprocedure As System.Windows.Forms.CheckBox
    Friend WithEvents chkconfirmpatientsite As System.Windows.Forms.CheckBox
    Friend WithEvents chkconfirmpatientidentity As System.Windows.Forms.CheckBox
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents rdisimagingdisplayed As System.Windows.Forms.RadioButton
    Friend WithEvents rdisimagingdisplayedno As System.Windows.Forms.RadioButton
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents rdantibioticprophylaxis As System.Windows.Forms.RadioButton
    Friend WithEvents rdantibioticprophylaxisno As System.Windows.Forms.RadioButton
    Friend WithEvents chknurseteamreview As System.Windows.Forms.CheckBox
    Friend WithEvents chkanesthersiareview As System.Windows.Forms.CheckBox
    Friend WithEvents chksurgeonreview As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents chkverballyconfirmprocedure As System.Windows.Forms.CheckBox
    Friend WithEvents chkverballyconfirmsite As System.Windows.Forms.CheckBox
    Friend WithEvents chkverballyconfirmpatient As System.Windows.Forms.CheckBox
    Friend WithEvents chkverballyconfirm As System.Windows.Forms.CheckBox
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents chkconfirmkeyconcerns As System.Windows.Forms.CheckBox
    Friend WithEvents chkconfirmequipmentproblems As System.Windows.Forms.CheckBox
    Friend WithEvents chkconfirmspecimenlabled As System.Windows.Forms.CheckBox
    Friend WithEvents chkconfirmpinstrumentcountcorrect As System.Windows.Forms.CheckBox
    Friend WithEvents chkconfirmprocedurename As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtoperationdescription As System.Windows.Forms.RichTextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txthisthopathologydiagnosis As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtmaterialforlab As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtoperativediagnosis As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtpreoperativediagnosis As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtanesthetic As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblanesthesiologist As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblsecondassistant As System.Windows.Forms.Label
    Friend WithEvents lblfirstassistant As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblsurgeon As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtsyringes As System.Windows.Forms.RichTextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtothersupplies As System.Windows.Forms.RichTextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents dtpoperationend As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents dtpoperationbegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdisminor As System.Windows.Forms.RadioButton
    Friend WithEvents rdismajor As System.Windows.Forms.RadioButton
    Friend WithEvents txtdrains As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents chkspongecountverified As System.Windows.Forms.CheckBox
    Friend WithEvents dtptimeend As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents dtptimebegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents lblinstrumentnurse As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents lblsurgicalnurse As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtmedicines As System.Windows.Forms.RichTextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txtsutures As System.Windows.Forms.RichTextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtivfluids As System.Windows.Forms.RichTextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents btnsurgeon As System.Windows.Forms.Button
    Friend WithEvents btnoperativediagnosis As System.Windows.Forms.Button
    Friend WithEvents btnpreoperativediagnosis As System.Windows.Forms.Button
    Friend WithEvents btnanesthesiologist As System.Windows.Forms.Button
    Friend WithEvents btnsecondassistant As System.Windows.Forms.Button
    Friend WithEvents btnfirstassistant As System.Windows.Forms.Button
    Friend WithEvents btninstrumentnurse As System.Windows.Forms.Button
    Friend WithEvents btnsurgicalnurse As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpproceduredate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tabpreoperative As System.Windows.Forms.TabPage
    Friend WithEvents Panel24 As System.Windows.Forms.Panel
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel39 As System.Windows.Forms.Panel
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Panel40 As System.Windows.Forms.Panel
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Panel38 As System.Windows.Forms.Panel
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Panel37 As System.Windows.Forms.Panel
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Panel35 As System.Windows.Forms.Panel
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Panel36 As System.Windows.Forms.Panel
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Panel34 As System.Windows.Forms.Panel
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Panel33 As System.Windows.Forms.Panel
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Panel32 As System.Windows.Forms.Panel
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Panel30 As System.Windows.Forms.Panel
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Panel31 As System.Windows.Forms.Panel
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Panel29 As System.Windows.Forms.Panel
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Panel28 As System.Windows.Forms.Panel
    Friend WithEvents Panel27 As System.Windows.Forms.Panel
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Panel26 As System.Windows.Forms.Panel
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Panel25 As System.Windows.Forms.Panel
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Panel56 As System.Windows.Forms.Panel
    Friend WithEvents chkxrayreports As System.Windows.Forms.CheckBox
    Friend WithEvents Panel55 As System.Windows.Forms.Panel
    Friend WithEvents chkurine As System.Windows.Forms.CheckBox
    Friend WithEvents Panel53 As System.Windows.Forms.Panel
    Friend WithEvents chkroutinebloodreps As System.Windows.Forms.CheckBox
    Friend WithEvents Panel54 As System.Windows.Forms.Panel
    Friend WithEvents chkxmatching As System.Windows.Forms.CheckBox
    Friend WithEvents Panel52 As System.Windows.Forms.Panel
    Friend WithEvents chkconsentsigned As System.Windows.Forms.CheckBox
    Friend WithEvents Panel48 As System.Windows.Forms.Panel
    Friend WithEvents chkdenturesremoved As System.Windows.Forms.CheckBox
    Friend WithEvents Panel49 As System.Windows.Forms.Panel
    Friend WithEvents chkjewelryremoved As System.Windows.Forms.CheckBox
    Friend WithEvents Panel50 As System.Windows.Forms.Panel
    Friend WithEvents chknailpolishremoved As System.Windows.Forms.CheckBox
    Friend WithEvents Panel46 As System.Windows.Forms.Panel
    Friend WithEvents chkheadcap As System.Windows.Forms.CheckBox
    Friend WithEvents Panel47 As System.Windows.Forms.Panel
    Friend WithEvents chkhairpinremoved As System.Windows.Forms.CheckBox
    Friend WithEvents Panel44 As System.Windows.Forms.Panel
    Friend WithEvents chkunderwearremoved As System.Windows.Forms.CheckBox
    Friend WithEvents Panel45 As System.Windows.Forms.Panel
    Friend WithEvents chkpatientgowned As System.Windows.Forms.CheckBox
    Friend WithEvents Panel42 As System.Windows.Forms.Panel
    Friend WithEvents chksiteinspectedbyhn As System.Windows.Forms.CheckBox
    Friend WithEvents Panel41 As System.Windows.Forms.Panel
    Friend WithEvents chksiteshaved As System.Windows.Forms.CheckBox
    Friend WithEvents txtxrayreports As System.Windows.Forms.TextBox
    Friend WithEvents txturine As System.Windows.Forms.TextBox
    Friend WithEvents txtroutinebloodreps As System.Windows.Forms.TextBox
    Friend WithEvents txtxmatching As System.Windows.Forms.TextBox
    Friend WithEvents txtconsentsigned As System.Windows.Forms.TextBox
    Friend WithEvents txtdenturesremoved As System.Windows.Forms.TextBox
    Friend WithEvents txtjewelryremoved As System.Windows.Forms.TextBox
    Friend WithEvents txtnailpolishremoved As System.Windows.Forms.TextBox
    Friend WithEvents txtheadcap As System.Windows.Forms.TextBox
    Friend WithEvents txthairpinremoved As System.Windows.Forms.TextBox
    Friend WithEvents txtunderwearremoved As System.Windows.Forms.TextBox
    Friend WithEvents txtpatientgowned As System.Windows.Forms.TextBox
    Friend WithEvents txtsiteinspectedbyhn As System.Windows.Forms.TextBox
    Friend WithEvents txtsiteshaved As System.Windows.Forms.TextBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents chkcatheterized As System.Windows.Forms.CheckBox
    Friend WithEvents chkvoided As System.Windows.Forms.CheckBox
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents txtpreoperativemedication As System.Windows.Forms.TextBox
    Friend WithEvents txtbpsystolic As System.Windows.Forms.TextBox
    Friend WithEvents txttemp As System.Windows.Forms.TextBox
    Friend WithEvents dtptimecatheterized As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtptimevoided As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtptimeofmedication As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtrr As System.Windows.Forms.TextBox
    Friend WithEvents txtcr As System.Windows.Forms.TextBox
    Friend WithEvents txtamountcatheterized As System.Windows.Forms.TextBox
    Friend WithEvents txtamountvoided As System.Windows.Forms.TextBox
    Friend WithEvents dtptimebp As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtbpdiastolic As System.Windows.Forms.TextBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Panel96 As System.Windows.Forms.Panel
    Friend WithEvents txtpreoperativemedication2 As System.Windows.Forms.TextBox
    Friend WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents Panel95 As System.Windows.Forms.Panel
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label107 As System.Windows.Forms.Label
    Friend WithEvents Panel94 As System.Windows.Forms.Panel
    Friend WithEvents txtphysicalexam As System.Windows.Forms.TextBox
    Friend WithEvents Label106 As System.Windows.Forms.Label
    Friend WithEvents Panel93 As System.Windows.Forms.Panel
    Friend WithEvents txtsignificanthistory As System.Windows.Forms.TextBox
    Friend WithEvents Label105 As System.Windows.Forms.Label
    Friend WithEvents Panel92 As System.Windows.Forms.Panel
    Friend WithEvents txtotherphysicalstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label109 As System.Windows.Forms.Label
    Friend WithEvents txtbiochem As System.Windows.Forms.TextBox
    Friend WithEvents Panel91 As System.Windows.Forms.Panel
    Friend WithEvents txtec As System.Windows.Forms.TextBox
    Friend WithEvents txtcxr As System.Windows.Forms.TextBox
    Friend WithEvents txthb As System.Windows.Forms.TextBox
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents Panel84 As System.Windows.Forms.Panel
    Friend WithEvents txtweight As System.Windows.Forms.TextBox
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents Panel89 As System.Windows.Forms.Panel
    Friend WithEvents chkispregnant As System.Windows.Forms.CheckBox
    Friend WithEvents Panel90 As System.Windows.Forms.Panel
    Friend WithEvents chkhasallergies As System.Windows.Forms.CheckBox
    Friend WithEvents Panel85 As System.Windows.Forms.Panel
    Friend WithEvents chkhasrheumaticfever As System.Windows.Forms.CheckBox
    Friend WithEvents Panel86 As System.Windows.Forms.Panel
    Friend WithEvents chkhasepilepsy As System.Windows.Forms.CheckBox
    Friend WithEvents Panel87 As System.Windows.Forms.Panel
    Friend WithEvents chkhasdiabetes As System.Windows.Forms.CheckBox
    Friend WithEvents Panel88 As System.Windows.Forms.Panel
    Friend WithEvents chkhaskidneydisease As System.Windows.Forms.CheckBox
    Friend WithEvents Panel80 As System.Windows.Forms.Panel
    Friend WithEvents chkhashepatitis As System.Windows.Forms.CheckBox
    Friend WithEvents Panel81 As System.Windows.Forms.Panel
    Friend WithEvents chkhasasthma As System.Windows.Forms.CheckBox
    Friend WithEvents Panel82 As System.Windows.Forms.Panel
    Friend WithEvents chkhaschroniclungdisease As System.Windows.Forms.CheckBox
    Friend WithEvents Panel78 As System.Windows.Forms.Panel
    Friend WithEvents chkhasangina As System.Windows.Forms.CheckBox
    Friend WithEvents Panel79 As System.Windows.Forms.Panel
    Friend WithEvents chkhasstroke As System.Windows.Forms.CheckBox
    Friend WithEvents Panel76 As System.Windows.Forms.Panel
    Friend WithEvents chkhashighblood As System.Windows.Forms.CheckBox
    Friend WithEvents Panel77 As System.Windows.Forms.Panel
    Friend WithEvents Panel75 As System.Windows.Forms.Panel
    Friend WithEvents Panel73 As System.Windows.Forms.Panel
    Friend WithEvents Panel74 As System.Windows.Forms.Panel
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents Panel72 As System.Windows.Forms.Panel
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents Panel68 As System.Windows.Forms.Panel
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents Panel69 As System.Windows.Forms.Panel
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents Panel70 As System.Windows.Forms.Panel
    Friend WithEvents txtotherdiseases As System.Windows.Forms.TextBox
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents Panel71 As System.Windows.Forms.Panel
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents Panel65 As System.Windows.Forms.Panel
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents Panel66 As System.Windows.Forms.Panel
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Panel67 As System.Windows.Forms.Panel
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents Panel62 As System.Windows.Forms.Panel
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Panel63 As System.Windows.Forms.Panel
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents Panel64 As System.Windows.Forms.Panel
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents Panel61 As System.Windows.Forms.Panel
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Panel60 As System.Windows.Forms.Panel
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Panel59 As System.Windows.Forms.Panel
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Panel58 As System.Windows.Forms.Panel
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Panel57 As System.Windows.Forms.Panel
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Panel51 As System.Windows.Forms.Panel
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Panel43 As System.Windows.Forms.Panel
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Panel97 As System.Windows.Forms.Panel
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label110 As System.Windows.Forms.Label
    Friend WithEvents txtdrugstaken As System.Windows.Forms.TextBox
    Friend WithEvents PreOperativeChecklistToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreAnestheticAssessmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsentForProcedureOperationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents chkhasheartattack As System.Windows.Forms.CheckBox
    Friend WithEvents chkhasesthesiaproblem As System.Windows.Forms.CheckBox
    Friend WithEvents chkhaspreviousanesthesia As System.Windows.Forms.CheckBox
End Class
