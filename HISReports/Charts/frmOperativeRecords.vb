Public Class frmOperativeRecords

    Private Sub frmOperativeRecords_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call LoadAdmissionInfo()
    End Sub
#Region "Vars"
    Public admissionid As Long = 120442
    Private mRecord As New clsOperativeRecord
    Private afterload As Boolean = False
    Private Erp As New ErrorProvider
#End Region
#Region "Methods"
    Private Sub LoadAdmissionInfo()
        Dim dtAdmissions As New DataTable
        dtAdmissions = clsAdmissiondetails.loadAdmission(admissionid)
        Me.lblPatientNo.Text = Utility.NullToZero(dtAdmissions.Rows(0).Item("ptno"))
        Me.lblDateAdmitted.Text = dtAdmissions.Rows(0).Item("dateadmitted")
        Call LoadPatient(dtAdmissions.Rows(0).Item("PatientID"))

        afterload = False
        With Me.cmbprocedurename
            .DataSource = clsOperativeRecord.genericcls(0, Me.admissionid)
            .DisplayMember = "diagnosis"
            .ValueMember = "icd10code"
            .SelectedIndex = -1
        End With
        afterload = True
        If Me.cmbprocedurename.Items.Count > 0 Then
            Me.cmbprocedurename.SelectedIndex = 0
        End If
    End Sub
    Private Sub LoadPatient(ByVal PatientID As Integer)
        Dim mHospno As String
        Dim dtpat As New DataTable
        dtpat = clsAdmissiondetails.getPatientDetails(PatientID)
        mHospno = Utility.NullToEmptyString(dtpat.Rows(0).Item("HospitalNo"))
        Me.lblLastName.Text = dtpat.Rows(0).Item("lastname") & " " & Utility.NullToEmptyString(dtpat.Rows(0).Item("suffixname")) & ", " & dtpat.Rows(0).Item("FirstName") & " " & dtpat.Rows(0).Item("MiddleName")
        Me.lblBirthDate.Text = dtpat.Rows(0).Item("BirthDate")
        Me.lblage.Text = Utility.NullToZero(dtpat.Rows(0).Item("age"))
        Dim gender As String = UCase(dtpat.Rows(0).Item("Gender").ToString)
        If Trim(gender) = "M" Then
            Me.lblSex.Text = "Male"
        Else
            Me.lblSex.Text = "Female"
        End If
    End Sub

    Private Sub LoadRecord(ByVal rvscode As String)
        Dim dt As DataTable = clsOperativeRecord.genericcls(1, Me.admissionid, rvscode)
        If dt.Rows.Count = 0 Then
            Exit Sub
        End If
        With dt.Rows(0)
            Me.dtpproceduredate.Value = Utility.NullToDefaultDateFormat(.Item("dateofprocedure"), .Item("dateadmitted"))
            Me.mRecord.surgeonid = Utility.NullToZero(.Item("surgeonid"))
            Me.lblsurgeon.Text = Utility.NullToEmptyString(.Item("surgeonname"))
            Me.mRecord.firstassistant = Utility.NullToZero(.Item("firstassistant"))
            Me.lblfirstassistant.Text = Utility.NullToEmptyString(.Item("firstassistantname"))
            Me.mRecord.secondassistant = Utility.NullToZero(.Item("secondassistant"))
            Me.lblsecondassistant.Text = Utility.NullToEmptyString(.Item("secondassistantname"))
            Me.mRecord.anesthesiologist = Utility.NullToZero(.Item("anesthesiologist"))
            Me.lblanesthesiologist.Text = Utility.NullToEmptyString(.Item("anesthesiologistname"))
            Me.txtanesthetic.Text = Utility.NullToEmptyString(.Item("anesthetic"))
            Me.txtpreoperativediagnosis.Text = Utility.NullToEmptyString(.Item("preoperativediagnosis"))
            Me.txtoperativediagnosis.Text = Utility.NullToEmptyString(.Item("operativediagnosis"))
            Me.txtmaterialforlab.Text = Utility.NullToEmptyString(.Item("materialforlab"))
            Me.txthisthopathologydiagnosis.Text = Utility.NullToEmptyString(.Item("histhopathologydiagnosis"))
            Me.txtoperationdescription.Text = Utility.NullToEmptyString(.Item("operationdescription"))
            Me.mRecord.surgicalnurse = Utility.NullToZero(.Item("surgicalnurse"))
            Me.lblsurgicalnurse.Text = Utility.NullToEmptyString(.Item("surgicalnursename"))
            Me.mRecord.instrumentnurse = Utility.NullToZero(.Item("instrumentnurse"))
            Me.lblinstrumentnurse.Text = Utility.NullToEmptyString(.Item("instrumentnursename"))
            Me.dtptimebegin.Value = Utility.NullToDefaultDateFormat(.Item("timebegin"))
            Me.dtptimeend.Value = Utility.NullToDefaultDateFormat(.Item("timeend"))
            Me.chkspongecountverified.Checked = Utility.NullToBoolean(.Item("spongecountverified"))
            Me.txtdrains.Text = Utility.NullToEmptyString(.Item("drains"))
            Me.rdismajor.Checked = Utility.NullToBoolean(.Item("ismajor"))
            If Not Me.rdismajor.Checked Then
                Me.rdisminor.Checked = True
            End If
            Me.dtpoperationbegin.Value = Utility.NullToDefaultDateFormat(.Item("operationbegin"))
            Me.dtpoperationend.Value = Utility.NullToDefaultDateFormat(.Item("operationend"))
            Me.txtothersupplies.Text = Utility.NullToEmptyString(.Item("othersupplies"))
            Me.txtsyringes.Text = Utility.NullToEmptyString(.Item("syringes"))
            Me.txtivfluids.Text = Utility.NullToEmptyString(.Item("ivfluids"))
            Me.txtsutures.Text = Utility.NullToEmptyString(.Item("sutures"))
            Me.txtmedicines.Text = Utility.NullToEmptyString(.Item("medicines"))
            Me.chkconfirmpatientidentity.Checked = Utility.NullToBoolean(.Item("confirmpatientidentity"))
            Me.chkconfirmpatientsite.Checked = Utility.NullToBoolean(.Item("confirmpatientsite"))
            Me.chkconfirmpatientprocedure.Checked = Utility.NullToBoolean(.Item("confirmpatientprocedure"))
            Me.chkconfirmpatientconsent.Checked = Utility.NullToBoolean(.Item("confirmpatientconsent"))
            Me.chksitemarked.Checked = Utility.NullToBoolean(.Item("sitemarked"))
            Me.chkanaesthesiasafetycheck.Checked = Utility.NullToBoolean(.Item("anaesthesiasafetycheck"))
            Me.chkpulseoximeter.Checked = Utility.NullToBoolean(.Item("pulseoximeter"))
            Me.rdknownallergy.Checked = Utility.NullToBoolean(.Item("knownallergy"))
            If Not Me.rdknownallergy.Checked Then
                Me.rdknownallergyno.Checked = True
            End If
            Me.rdaspirationrisk.Checked = Utility.NullToBoolean(.Item("aspirationrisk"))
            If Not Me.rdaspirationrisk.Checked Then
                Me.rdaspirationriskno.Checked = True
            End If
            Me.rdbloodlossrisk.Checked = Utility.NullToBoolean(.Item("bloodlossrisk"))
            If Not Me.rdbloodlossrisk.Checked Then
                Me.rdbloodlossriskno.Checked = True
            End If
            Me.chkintroducedmembers.Checked = Utility.NullToBoolean(.Item("introducedmembers"))
            Me.chkverballyconfirmpatient.Checked = Utility.NullToBoolean(.Item("verballyconfirmpatient"))
            Me.chkverballyconfirmsite.Checked = Utility.NullToBoolean(.Item("verballyconfirmsite"))
            Me.chkverballyconfirmprocedure.Checked = Utility.NullToBoolean(.Item("verballyconfirmprocedure"))
            Me.chksurgeonreview.Checked = Utility.NullToBoolean(.Item("surgeonreview"))
            Me.chkanesthersiareview.Checked = Utility.NullToBoolean(.Item("anesthersiareview"))
            Me.chknurseteamreview.Checked = Utility.NullToBoolean(.Item("nurseteamreview"))
            Me.rdantibioticprophylaxis.Checked = Utility.NullToBoolean(.Item("antibioticprophylaxis"))
            If Not Me.rdantibioticprophylaxis.Checked Then
                Me.rdantibioticprophylaxisno.Checked = True
            End If
            Me.rdisimagingdisplayed.Checked = Utility.NullToBoolean(.Item("isimagingdisplayed"))
            If Not Me.rdisimagingdisplayed.Checked Then
                Me.rdisimagingdisplayedno.Checked = True
            End If
            Me.chkconfirmprocedurename.Checked = Utility.NullToBoolean(.Item("confirmprocedurename"))
            Me.chkconfirmpinstrumentcountcorrect.Checked = Utility.NullToBoolean(.Item("confirmpinstrumentcountcorrect"))
            Me.chkconfirmspecimenlabled.Checked = Utility.NullToBoolean(.Item("confirmspecimenlabled"))
            Me.chkconfirmequipmentproblems.Checked = Utility.NullToBoolean(.Item("confirmequipmentproblems"))
            Me.chkconfirmkeyconcerns.Checked = Utility.NullToBoolean(.Item("confirmkeyconcerns"))

            Me.chksiteshaved.Checked = Utility.NullToBoolean(.Item("operatiionsiteshaved"))
            Me.txtsiteshaved.Text = Utility.NullToEmptyString(.Item("operatiionsiteshavedremarks"))
            Me.chksiteinspectedbyhn.Checked = Utility.NullToBoolean(.Item("siteinspectedbyhn"))
            Me.txtsiteinspectedbyhn.Text = Utility.NullToEmptyString(.Item("siteinspectedbyhnremarks"))
            Me.chkpatientgowned.Checked = Utility.NullToBoolean(.Item("patientgowned"))
            Me.txtpatientgowned.Text = Utility.NullToEmptyString(.Item("patientgownedremarks"))
            Me.chkunderwearremoved.Checked = Utility.NullToBoolean(.Item("underwearremoved"))
            Me.txtunderwearremoved.Text = Utility.NullToEmptyString(.Item("underwearremovedremarks"))
            Me.chkhairpinremoved.Checked = Utility.NullToBoolean(.Item("hairpinsremoved"))
            Me.txthairpinremoved.Text = Utility.NullToEmptyString(.Item("hairpinsremovedremarks"))
            Me.chkheadcap.Checked = Utility.NullToBoolean(.Item("headcap"))
            Me.txtheadcap.Text = Utility.NullToEmptyString(.Item("headcapremarks"))
            Me.chknailpolishremoved.Checked = Utility.NullToBoolean(.Item("nailpolishremoved"))
            Me.txtnailpolishremoved.Text = Utility.NullToEmptyString(.Item("nailpolishremovedremarks"))
            Me.chkjewelryremoved.Checked = Utility.NullToBoolean(.Item("jewelryremoved"))
            Me.txtjewelryremoved.Text = Utility.NullToEmptyString(.Item("jewelryremovedremarks"))
            Me.chkdenturesremoved.Checked = Utility.NullToBoolean(.Item("denturesremoved"))
            Me.txtdenturesremoved.Text = Utility.NullToEmptyString(.Item("denturesremovedremarks"))
            Me.chkconsentsigned.Checked = Utility.NullToBoolean(.Item("consentsigned"))
            Me.txtconsentsigned.Text = Utility.NullToEmptyString(.Item("consentsignedremarks"))
            Me.chkxmatching.Checked = Utility.NullToBoolean(.Item("xmatchingdone"))
            Me.txtxmatching.Text = Utility.NullToEmptyString(.Item("xmatchingdoneremarks"))
            Me.chkroutinebloodreps.Checked = Utility.NullToBoolean(.Item("routinebloodreps"))
            Me.txtroutinebloodreps.Text = Utility.NullToEmptyString(.Item("routinebloodrepsremarks"))
            Me.chkurine.Checked = Utility.NullToBoolean(.Item("urinereports"))
            Me.txturine.Text = Utility.NullToEmptyString(.Item("urinereportsremarks"))
            Me.chkxrayreports.Checked = Utility.NullToBoolean(.Item("xrayreports"))
            Me.txtxrayreports.Text = Utility.NullToEmptyString(.Item("xrayreportsremarks"))
            Me.chkvoided.Checked = Utility.NullToBoolean(.Item("voided"))
            Me.dtptimevoided.Value = Utility.NullToDefaultDateFormat(.Item("timevoided"))
            Me.txtamountvoided.Text = Utility.NullToEmptyString(.Item("amountvoided"))
            Me.chkcatheterized.Checked = Utility.NullToBoolean(.Item("catheterized"))
            Me.dtptimecatheterized.Value = Utility.NullToDefaultDateFormat(.Item("timecatheterized"))
            Me.txtamountcatheterized.Text = Utility.NullToEmptyString(.Item("amountcatheterized"))
            Me.txttemp.Text = Utility.NullToEmptyString(.Item("temp"))
            Me.txtcr.text = Utility.NullToEmptyString(.Item("cr"))
            Me.txtrr.text = Utility.NullToEmptyString(.Item("rr"))
            Me.txtbpsystolic.text = Utility.NullToEmptyString(.Item("bpsystolic"))
            Me.txtbpdiastolic.text = Utility.NullToEmptyString(.Item("bpdiastolic"))
            Me.dtptimebp.Text = Utility.NullToDefaultDateFormat(.Item("timebp"))
            Me.txtpreoperativemedication.text = Utility.NullToEmptyString(.Item("preoperativemedication"))
            Me.dtptimeofmedication.Value = Utility.NullToDefaultDateFormat(.Item("timeofmedication"))

            Me.chkhaspreviousanesthesia.Checked = Utility.NullToBoolean(.Item("haspreviousanesthesia"))
            Me.chkhasesthesiaproblem.Checked = Utility.NullToBoolean(.Item("hasesthesiaproblem"))
            Me.chkhasheartattack.Checked = Utility.NullToBoolean(.Item("hasheartattack"))
            Me.chkhashighblood.Checked = Utility.NullToBoolean(.Item("hashighblood"))
            Me.chkhasstroke.Checked = Utility.NullToBoolean(.Item("hasstroke"))
            Me.chkhasangina.Checked = Utility.NullToBoolean(.Item("hasangina"))
            Me.chkhaschroniclungdisease.Checked = Utility.NullToBoolean(.Item("haschroniclungdisease"))
            Me.chkhasasthma.Checked = Utility.NullToBoolean(.Item("hasasthma"))
            Me.chkhashepatitis.Checked = Utility.NullToBoolean(.Item("hashepatitis"))
            Me.chkhaskidneydisease.Checked = Utility.NullToBoolean(.Item("haskidneydisease"))
            Me.chkhasdiabetes.Checked = Utility.NullToBoolean(.Item("hasdiabetes"))
            Me.chkhasepilepsy.Checked = Utility.NullToBoolean(.Item("hasepilepsy"))
            Me.chkhasrheumaticfever.Checked = Utility.NullToBoolean(.Item("hasrheumaticfever"))
            Me.txtotherdiseases.Text = Utility.NullToEmptyString(.Item("otherdiseases"))
            Me.txtdrugstaken.Text = Utility.NullToEmptyString(.Item("drugstaken"))
            Me.chkhasallergies.Checked = Utility.NullToBoolean(.Item("hasallergies"))
            Me.chkispregnant.Checked = Utility.NullToBoolean(.Item("ispregnant"))
            Me.txtweight.Text = Utility.NullToEmptyString(.Item("weight"))
            Me.txthb.Text = Utility.NullToEmptyString(.Item("hb"))
            Me.txtbiochem.Text = Utility.NullToEmptyString(.Item("biochem"))
            Me.txtcxr.Text = Utility.NullToEmptyString(.Item("cxr"))
            Me.txtec.Text = Utility.NullToEmptyString(.Item("ec"))
            Me.txtotherphysicalstatus.Text = Utility.NullToEmptyString(.Item("otherphysicalstatus"))
            Me.txtsignificanthistory.Text = Utility.NullToEmptyString(.Item("significanthistory"))
            Me.txtphysicalexam.Text = Utility.NullToEmptyString(.Item("physicalexam"))
            Me.TextBox10.Text = Utility.NullToEmptyString(.Item("preoperativeinstructions"))
            Me.TextBox11.Text = Utility.NullToEmptyString(.Item("specialinstructions"))
        End With
    End Sub

    Private Sub setError(ByVal ctl As Control, Optional ByVal strErrorMessage As String = "")
        Erp.SetError(ctl, strErrorMessage)
    End Sub
    Private Function isFieldValidDecimal(ByVal ctl As TextBox) As Boolean
        Dim dec As Double
        If ctl.Text = "" Then
            setError(ctl)
            Return True
        End If
        If Double.TryParse(ctl.Text, dec) Then
            setError(ctl)
            Return True
        Else
            setError(ctl, "Invalid Entry")
            Return False
        End If
    End Function
    Private Function isFieldValidInt(ByVal ctl As TextBox) As Boolean
        Dim i As Integer
        If ctl.Text = "" Then
            setError(ctl)
            Return True
        End If
        If Integer.TryParse(ctl.Text, i) Then
            setError(ctl)
            Return True
        Else
            setError(ctl, "Invalid Entry")
            Return False
        End If
    End Function
#End Region


    Private Sub btnsurgeon_Click(sender As System.Object, e As System.EventArgs) Handles btnsurgeon.Click
        Dim f As New frmSearchEngine
        f.mModuleName = frmSearchEngine.ModuleName.Physician
        f.ShowDialog()
        If f.issave Then
            mRecord.surgeonid = f.mKey
            Me.lblsurgeon.Text = Utility.NullToEmptyString(clsAdmissiondetails.getDoctors(f.mKey).Rows(0).Item("Physician"))
        End If
    End Sub

    Private Sub btnfirstassistant_Click(sender As System.Object, e As System.EventArgs) Handles btnfirstassistant.Click
        Dim f As New frmSearchEngine
        f.mModuleName = frmSearchEngine.ModuleName.Physician
        f.ShowDialog()
        If f.issave Then
            mRecord.firstassistant = f.mKey
            Me.lblfirstassistant.Text = Utility.NullToEmptyString(clsAdmissiondetails.getDoctors(f.mKey).Rows(0).Item("Physician"))
        End If
    End Sub

    Private Sub btnsecondassistant_Click(sender As System.Object, e As System.EventArgs) Handles btnsecondassistant.Click
        Dim f As New frmSearchEngine
        f.mModuleName = frmSearchEngine.ModuleName.Physician
        f.ShowDialog()
        If f.issave Then
            mRecord.secondassistant = f.mKey
            Me.lblsecondassistant.Text = Utility.NullToEmptyString(clsAdmissiondetails.getDoctors(f.mKey).Rows(0).Item("Physician"))
        End If
    End Sub

    Private Sub btnanesthesiologist_Click(sender As System.Object, e As System.EventArgs) Handles btnanesthesiologist.Click
        Dim f As New frmSearchEngine
        f.mModuleName = frmSearchEngine.ModuleName.Physician
        f.ShowDialog()
        If f.issave Then
            mRecord.anesthesiologist = f.mKey
            Me.lblanesthesiologist.Text = Utility.NullToEmptyString(clsAdmissiondetails.getDoctors(f.mKey).Rows(0).Item("Physician"))
        End If
    End Sub

    Private Sub btnpreoperativediagnosis_Click(sender As System.Object, e As System.EventArgs) Handles btnpreoperativediagnosis.Click
        Dim f As New frmSearchEngine
        f.mModuleName = frmSearchEngine.ModuleName.ICD10Diagnosis
        f.ShowDialog()
        If f.issave Then
            Me.txtpreoperativediagnosis.Text = f.mrow.Cells("diagnosisdesc").Value
        End If
    End Sub

    Private Sub btnoperativediagnosis_Click(sender As System.Object, e As System.EventArgs) Handles btnoperativediagnosis.Click
        Dim f As New frmSearchEngine
        f.mModuleName = frmSearchEngine.ModuleName.ICD10Diagnosis
        f.ShowDialog()
        If f.issave Then
            Me.txtoperativediagnosis.Text = f.mrow.Cells("diagnosisdesc").Value
        End If
    End Sub

    Private Sub tsSave_Click(sender As System.Object, e As System.EventArgs) Handles tsSave.Click
        If Not validation() Then
            Me.TabControl1.SelectedTab = tabpreoperative
            Exit Sub
        End If
        With Me.mRecord
            .admissionid = Me.admissionid
            .rvscode = Me.cmbprocedurename.SelectedValue
            .rvsdesc = Me.cmbprocedurename.Text
            .proceduredate = Me.dtpproceduredate.Value
            .anesthetic = Me.txtanesthetic.Text
            .preoperativediagnosis = Me.txtpreoperativediagnosis.Text
            .operativediagnosis = Me.txtoperativediagnosis.Text
            .materialforlab = Me.txtmaterialforlab.Text
            .histhopathologydiagnosis = Me.txthisthopathologydiagnosis.Text
            .operationdescription = Me.txtoperationdescription.Text
            .timebegin = Me.dtptimebegin.Value
            .timeend = Me.dtptimeend.Value
            .spongecountverified = Me.chkspongecountverified.Checked
            .drains = Me.txtdrains.Text
            .ismajor = Me.rdismajor.Checked
            .operationbegin = Me.dtpoperationbegin.Value
            .operationend = Me.dtpoperationend.Value
            .othersupplies = Me.txtothersupplies.Text
            .syringes = Me.txtsyringes.Text
            .ivfluids = Me.txtivfluids.Text
            .sutures = Me.txtsutures.Text
            .medicines = Me.txtmedicines.Text
            .confirmpatientidentity = Me.chkconfirmpatientidentity.Checked
            .confirmpatientsite = Me.chkconfirmpatientsite.Checked
            .confirmpatientprocedure = Me.chkconfirmpatientprocedure.Checked
            .confirmpatientconsent = Me.chkconfirmpatientconsent.Checked
            .sitemarked = Me.chksitemarked.Checked
            .anaesthesiasafetycheck = Me.chkanaesthesiasafetycheck.Checked
            .pulseoximeter = Me.chkpulseoximeter.Checked
            .knownallergy = Me.rdknownallergy.Checked
            .aspirationrisk = Me.rdaspirationrisk.Checked
            .bloodlossrisk = Me.rdbloodlossrisk.Checked
            .introducedmembers = Me.chkintroducedmembers.Checked
            .verballyconfirmpatient = Me.chkverballyconfirmpatient.Checked
            .verballyconfirmsite = Me.chkverballyconfirmsite.Checked
            .verballyconfirmprocedure = Me.chkverballyconfirmprocedure.Checked
            .surgeonreview = Me.chksurgeonreview.Checked
            .anesthersiareview = Me.chkanesthersiareview.Checked
            .nurseteamreview = Me.chknurseteamreview.Checked
            .antibioticprophylaxis = Me.rdantibioticprophylaxis.Checked
            .isimagingdisplayed = Me.rdisimagingdisplayed.Checked
            .confirmprocedurename = Me.chkconfirmprocedurename.Checked
            .confirmpinstrumentcountcorrect = Me.chkconfirmpinstrumentcountcorrect.Checked
            .confirmspecimenlabled = Me.chkconfirmspecimenlabled.Checked
            .confirmequipmentproblems = Me.chkconfirmequipmentproblems.Checked
            .confirmkeyconcerns = Me.chkconfirmkeyconcerns.Checked
            .operatiionsiteshaved = Me.chksiteshaved.Checked
            .operatiionsiteshavedremarks = Me.txtsiteshaved.Text
            .siteinspectedbyhn = Me.chksiteinspectedbyhn.Checked
            .siteinspectedbyhnremarks = Me.txtsiteinspectedbyhn.Text
            .patientgowned = Me.chkpatientgowned.Checked
            .patientgownedremarks = Me.txtpatientgowned.Text
            .underwearremoved = Me.chkunderwearremoved.Checked
            .underwearremovedremarks = Me.txtunderwearremoved.Text
            .hairpinsremoved = Me.chkhairpinremoved.Checked
            .hairpinsremovedremarks = Me.txthairpinremoved.Text
            .headcap = Me.chkheadcap.Checked
            .headcapremarks = Me.txtheadcap.Text
            .nailpolishremoved = Me.chknailpolishremoved.Checked
            .nailpolishremovedremarks = Me.txtnailpolishremoved.Text
            .jewelryremoved = Me.chkjewelryremoved.Checked
            .jewelryremovedremarks = Me.txtjewelryremoved.Text
            .denturesremoved = Me.chkdenturesremoved.Checked
            .denturesremovedremarks = Me.txtdenturesremoved.Text
            .consentsigned = Me.chkconsentsigned.Checked
            .consentsignedremarks = Me.txtconsentsigned.Text
            .xmatchingdone = Me.chkxmatching.Checked
            .xmatchingdoneremarks = Me.txtxmatching.Text
            .routinebloodreps = Me.chkroutinebloodreps.Checked
            .routinebloodrepsremarks = Me.txtroutinebloodreps.Text
            .urinereports = Me.chkurine.Checked
            .urinereportsremarks = Me.txturine.Text
            .xrayreports = Me.chkxrayreports.Checked
            .xrayreportsremarks = Me.txtxrayreports.Text
            .voided = Me.chkvoided.Checked
            .timevoided = Me.dtptimevoided.Value
            .amountvoided = Me.txtamountvoided.Text
            If Not .voided Then
                .amountvoided = ""
            End If
            .catheterized = Me.chkcatheterized.Checked
            .timecatheterized = Me.dtptimecatheterized.Value
            .amountcatheterized = Me.txtamountcatheterized.Text
            If Not .catheterized Then
                .amountcatheterized = ""
            End If
            .temp = IIf(Me.txttemp.Text = "", 0, Me.txttemp.Text)
            .cr = IIf(Me.txtcr.Text = "", 0, Me.txtcr.Text)
            .rr = IIf(Me.txtrr.Text = "", 0, Me.txtrr.Text)
            .bpsystolic = IIf(Me.txtbpsystolic.Text = "", 0, Me.txtbpsystolic.Text)
            .bpdiastolic = IIf(Me.txtbpdiastolic.Text = "", 0, Me.txtbpdiastolic.Text)
            .timebp = Me.dtptimebp.Value
            .preoperativemedication = Me.txtpreoperativemedication.Text
            .timeofmedication = Me.dtptimeofmedication.Value
            .haspreviousanesthesia = Me.chkhaspreviousanesthesia.Checked
            .hasesthesiaproblem = Me.chkhasesthesiaproblem.Checked
            .hasheartattack = Me.chkhasheartattack.Checked
            .hashighblood = Me.chkhashighblood.Checked
            .hasstroke = Me.chkhasstroke.Checked
            .hasangina = Me.chkhasangina.Checked
            .haschroniclungdisease = Me.chkhaschroniclungdisease.Checked
            .hasasthma = Me.chkhasasthma.Checked
            .hashepatitis = Me.chkhashepatitis.Checked
            .haskidneydisease = Me.chkhaskidneydisease.Checked
            .hasdiabetes = Me.chkhasdiabetes.Checked
            .hasepilepsy = Me.chkhasepilepsy.Checked
            .hasrheumaticfever = Me.chkhasrheumaticfever.Checked
            .otherdiseases = Me.txtotherdiseases.Text
            .drugstaken = Me.txtdrugstaken.Text
            .hasallergies = Me.chkhasallergies.Checked
            .ispregnant = Me.chkispregnant.Checked
            .weight = Me.txtweight.Text
            .hb = Me.txthb.Text
            .biochem = Me.txtbiochem.Text
            .cxr = Me.txtcxr.Text
            .ec = Me.txtec.Text
            .otherphysicalstatus = Me.txtotherphysicalstatus.Text
            .significanthistory = Me.txtsignificanthistory.Text
            .physicalexam = Me.txtphysicalexam.Text
            .preoperativeinstructions = Me.TextBox10.Text
            .specialinstructions = Me.TextBox11.Text
            .Save()
            MessageBox.Show("Record saved successful")
        End With
    End Sub
    Private Function validation() As Boolean
        Dim isvalid As Boolean = True
        isvalid = isFieldValidDecimal(Me.txttemp) And isFieldValidInt(Me.txtcr) And isFieldValidInt(Me.txtrr) And isFieldValidInt(Me.txtbpsystolic) And isFieldValidInt(Me.txtbpdiastolic)
        Return isvalid
    End Function

    Private Sub cmbprocedurename_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cmbprocedurename.SelectedValueChanged
        If afterload Then
                Call LoadRecord(Me.cmbprocedurename.SelectedValue)
        End If
    End Sub

    Private Sub tsClose_Click(sender As System.Object, e As System.EventArgs) Handles tsClose.Click
        Me.Close()
    End Sub

    Private Sub btnsurgicalnurse_Click(sender As System.Object, e As System.EventArgs) Handles btnsurgicalnurse.Click
        Dim f As New frmSearchEngine
        f.mModuleName = frmSearchEngine.ModuleName.Nurses
        f.ShowDialog()
        If f.issave Then
            mRecord.surgicalnurse = f.mKey
            Me.lblsurgicalnurse.Text = Utility.NullToEmptyString(clsAdmissiondetails.getDoctors(f.mKey).Rows(0).Item("Physician"))
        End If
    End Sub

    Private Sub btninstrumentnurse_Click(sender As System.Object, e As System.EventArgs) Handles btninstrumentnurse.Click
        Dim f As New frmSearchEngine
        f.mModuleName = frmSearchEngine.ModuleName.Nurses
        f.ShowDialog()
        If f.issave Then
            mRecord.instrumentnurse = f.mKey
            Me.lblinstrumentnurse.Text = Utility.NullToEmptyString(clsAdmissiondetails.getDoctors(f.mKey).Rows(0).Item("Physician"))
        End If
    End Sub


    Private Sub chkpatientconfirmed_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkpatientconfirmed.CheckedChanged
        If Me.chkpatientconfirmed.Checked And
            (Not Me.chkconfirmpatientidentity.Checked Or Not chkconfirmpatientsite.Checked Or
             Not Me.chkconfirmpatientconsent.Checked Or Not chkconfirmpatientprocedure.Checked) Then
            Me.chkconfirmpatientidentity.Checked = True
            Me.chkconfirmpatientsite.Checked = True
            Me.chkconfirmpatientconsent.Checked = True
            Me.chkconfirmpatientprocedure.Checked = True
        End If
    End Sub

    Private Sub chkconfirmpatientidentity_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkconfirmpatientsite.CheckedChanged, chkconfirmpatientprocedure.CheckedChanged, chkconfirmpatientidentity.CheckedChanged, chkconfirmpatientconsent.CheckedChanged
        If Me.chkconfirmpatientidentity.Checked And chkconfirmpatientsite.Checked And
             Me.chkconfirmpatientconsent.Checked And chkconfirmpatientprocedure.Checked Then
            Me.chkpatientconfirmed.Checked = True
        Else
            Me.chkpatientconfirmed.Checked = False
        End If
    End Sub

    Private Sub chkverballyconfirm_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkverballyconfirm.CheckedChanged
        If Me.chkverballyconfirm.Checked And
            (Not Me.chkverballyconfirmpatient.Checked Or Not chkverballyconfirmsite.Checked Or Not Me.chkverballyconfirmprocedure.Checked) Then
            Me.chkverballyconfirmpatient.Checked = True
            Me.chkverballyconfirmsite.Checked = True
            Me.chkverballyconfirmprocedure.Checked = True
        End If
    End Sub

    Private Sub chkverballyconfirmpatient_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkverballyconfirmsite.CheckedChanged, chkverballyconfirmprocedure.CheckedChanged, chkverballyconfirmpatient.CheckedChanged
        If Me.chkverballyconfirmpatient.Checked And chkverballyconfirmsite.Checked And Me.chkverballyconfirmprocedure.Checked Then
            Me.chkverballyconfirm.Checked = True
        Else
            Me.chkverballyconfirm.Checked = False
        End If
    End Sub

    Private Sub OperativeRecordToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OperativeRecordToolStripMenuItem.Click
        'Dim f As New frmReportHandler
        'Dim cr As New crptOperativeRecord
        'Dim dt As DataTable = clsOperativeRecord.genericcls(1, Me.admissionid, Me.cmbprocedurename.SelectedValue)
        'cr.SetDataSource(dt)
        'f.crvPrinting.ReportSource = cr
        'f.ShowDialog()
    End Sub

    Private Sub ORNursingRecordToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ORNursingRecordToolStripMenuItem.Click
        'Dim f As New frmReportHandler
        'Dim cr As New crptORNursingRecord
        'Dim dt As DataTable = clsOperativeRecord.genericcls(1, Me.admissionid, Me.cmbprocedurename.SelectedValue)
        'cr.SetDataSource(dt)
        'f.crvPrinting.ReportSource = cr
        'f.ShowDialog()
    End Sub

    Private Sub SafetyChecklistToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SafetyChecklistToolStripMenuItem.Click
        'Dim f As New frmReportHandler
        'Dim cr As New crptSurgicalSafetyChecklist
        'Dim dt As DataTable = clsOperativeRecord.genericcls(1, Me.admissionid, Me.cmbprocedurename.SelectedValue)
        'cr.SetDataSource(dt)
        'f.crvPrinting.ReportSource = cr
        'f.ShowDialog()
    End Sub

    Private Sub chkvoided_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkvoided.CheckedChanged
        Me.dtptimevoided.Enabled = chkvoided.Checked
        Me.txtamountvoided.Enabled = chkvoided.Checked
    End Sub

    Private Sub chkcatheterized_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkcatheterized.CheckedChanged
        Me.dtptimecatheterized.Enabled = chkcatheterized.Checked
        Me.txtamountcatheterized.Enabled = chkcatheterized.Checked
    End Sub

    Private Sub txtpreoperativemedication2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtpreoperativemedication2.TextChanged
        If Me.txtpreoperativemedication2.Text <> Me.txtpreoperativemedication.Text Then
            Me.txtpreoperativemedication.Text = Me.txtpreoperativemedication2.Text
        End If
    End Sub

    Private Sub txtpreoperativemedication_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtpreoperativemedication.TextChanged
        If Me.txtpreoperativemedication2.Text <> Me.txtpreoperativemedication.Text Then
            Me.txtpreoperativemedication2.Text = Me.txtpreoperativemedication.Text
        End If
    End Sub

    Private Sub PreOperativeChecklistToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PreOperativeChecklistToolStripMenuItem.Click
        'Dim f As New frmReportHandler
        'Dim cr As New crptPreOperativeChecklist
        'Dim dt As DataTable = clsOperativeRecord.genericcls(1, Me.admissionid, Me.cmbprocedurename.SelectedValue)
        'cr.SetDataSource(dt)
        'f.crvPrinting.ReportSource = cr
        'f.ShowDialog()
    End Sub

    Private Sub PreAnestheticAssessmentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PreAnestheticAssessmentToolStripMenuItem.Click
        'Dim f As New frmReportHandler
        'Dim cr As New crptPreAnestheticAssessment
        'Dim dt As DataTable = clsOperativeRecord.genericcls(1, Me.admissionid, Me.cmbprocedurename.SelectedValue)
        'cr.SetDataSource(dt)
        'f.crvPrinting.ReportSource = cr
        'f.ShowDialog()
    End Sub

    Private Sub ConsentForProcedureOperationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsentForProcedureOperationToolStripMenuItem.Click
        'Dim f As New frmReportHandler
        'Dim crpt As Object
        'Dim dtReport = clsReportDashboard.getHISReports(2, 15)
        'crpt = Activator.CreateInstance(Type.GetType(Me.GetType().Namespace & "." & dtReport.Rows(0).Item("reportfilename")))
        'Dim dt As DataTable = clsReportDashboard.getReport(dtReport.Rows(0).Item("soperation"), Me.cmbprocedurename.SelectedValue, Me.admissionid)
        'crpt.SetDataSource(dt)
        'f.crvPrinting.ReportSource = crpt
        'f.ShowDialog()
    End Sub
End Class