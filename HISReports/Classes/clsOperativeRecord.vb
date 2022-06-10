Public Class clsOperativeRecord

    Public admissionid As Long
    Public rvscode As String
    Public rvsdesc As String
    Public proceduredate As Date
    Public surgeonid As Long
    Public firstassistant As Long
    Public secondassistant As Long
    Public anesthesiologist As Long
    Public anesthetic As String
    Public preoperativediagnosis As String
    Public operativediagnosis As String
    Public materialforlab As String
    Public histhopathologydiagnosis As String
    Public operationdescription As String
    Public surgicalnurse As Long
    Public instrumentnurse As Long
    Public timebegin As Date
    Public timeend As Date
    Public spongecountverified As Boolean
    Public drains As String
    Public ismajor As Boolean
    Public operationbegin As Date
    Public operationend As Date
    Public othersupplies As String
    Public syringes As String
    Public ivfluids As String
    Public sutures As String
    Public medicines As String
    Public confirmpatientidentity As Boolean
    Public confirmpatientsite As Boolean
    Public confirmpatientprocedure As Boolean
    Public confirmpatientconsent As Boolean
    Public sitemarked As Boolean
    Public anaesthesiasafetycheck As Boolean
    Public pulseoximeter As Boolean
    Public knownallergy As Boolean
    Public aspirationrisk As Boolean
    Public bloodlossrisk As Boolean
    Public introducedmembers As Boolean
    Public verballyconfirmpatient As Boolean
    Public verballyconfirmsite As Boolean
    Public verballyconfirmprocedure As Boolean
    Public surgeonreview As Boolean
    Public anesthersiareview As Boolean
    Public nurseteamreview As Boolean
    Public antibioticprophylaxis As Boolean
    Public isimagingdisplayed As Boolean
    Public confirmprocedurename As Boolean
    Public confirmpinstrumentcountcorrect As Boolean
    Public confirmspecimenlabled As Boolean
    Public confirmequipmentproblems As Boolean
    Public confirmkeyconcerns As Boolean

    Public operatiionsiteshaved As Boolean
    Public operatiionsiteshavedremarks As String
    Public siteinspectedbyhn As Boolean
    Public siteinspectedbyhnremarks As String
    Public patientgowned As Boolean
    Public patientgownedremarks As String
    Public underwearremoved As Boolean
    Public underwearremovedremarks As String
    Public hairpinsremoved As Boolean
    Public hairpinsremovedremarks As String
    Public headcap As Boolean
    Public headcapremarks As String
    Public nailpolishremoved As Boolean
    Public nailpolishremovedremarks As String
    Public jewelryremoved As Boolean
    Public jewelryremovedremarks As String
    Public denturesremoved As Boolean
    Public denturesremovedremarks As String
    Public consentsigned As Boolean
    Public consentsignedremarks As String
    Public xmatchingdone As Boolean
    Public xmatchingdoneremarks As String
    Public routinebloodreps As Boolean
    Public routinebloodrepsremarks As String
    Public urinereports As Boolean
    Public urinereportsremarks As String
    Public xrayreports As Boolean
    Public xrayreportsremarks As String

    Public voided As Boolean
    Public timevoided As DateTime
    Public amountvoided As String
    Public catheterized As Boolean
    Public timecatheterized As DateTime
    Public amountcatheterized As String
    Public temp As Double
    Public cr As Integer
    Public rr As Integer
    Public bpsystolic As Integer
    Public bpdiastolic As Integer
    Public timebp As DateTime
    Public preoperativemedication As String
    Public timeofmedication As DateTime

    Public haspreviousanesthesia As Boolean
    Public hasesthesiaproblem As Boolean
    Public hasheartattack As Boolean
    Public hashighblood As Boolean
    Public hasstroke As Boolean
    Public hasangina As Boolean
    Public haschroniclungdisease As Boolean
    Public hasasthma As Boolean
    Public hashepatitis As Boolean
    Public haskidneydisease As Boolean
    Public hasdiabetes As Boolean
    Public hasepilepsy As Boolean
    Public hasrheumaticfever As Boolean
    Public otherdiseases As String
    Public drugstaken As String
    Public hasallergies As Boolean
    Public ispregnant As Boolean
    Public weight As String
    Public hb As String
    Public biochem As String
    Public cxr As String
    Public ec As String
    Public otherphysicalstatus As String
    Public significanthistory As String
    Public physicalexam As String
    Public preoperativeinstructions As String
    Public specialinstructions As String

    Public Shared Function genericcls(ByVal sop As Integer, ByVal search As String, Optional ByVal rvscode As String = "")
        Dim strPar() As String = {"operation", "soperation", "search", "rvscode"}
        Dim strVal() As String = {0, sop, search, rvscode}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spOperativeRecord", 0)
    End Function

    Public Sub Save()
        Dim strPar() As String = {"operation", "soperation", "admissionid", "rvscode", "rvsdesc", "proceduredate", "surgeonid", "firstassistant",
                                  "secondassistant", "anesthesiologist", "anesthetic", "preoperativediagnosis", "operativediagnosis",
                                  "materialforlab", "histhopathologydiagnosis", "operationdescription", "surgicalnurse", "instrumentnurse",
                                  "timebegin", "timeend", "spongecountverified", "drains", "ismajor", "operationbegin", "operationend",
                                  "othersupplies", "syringes", "ivfluids", "sutures", "medicines", "confirmpatientidentity", "confirmpatientsite",
                                  "confirmpatientprocedure", "confirmpatientconsent", "sitemarked", "anaesthesiasafetycheck", "pulseoximeter",
                                  "knownallergy", "aspirationrisk", "bloodlossrisk", "introducedmembers", "verballyconfirmpatient",
                                  "verballyconfirmsite", "verballyconfirmprocedure", "surgeonreview", "anesthersiareview", "nurseteamreview",
                                  "antibioticprophylaxis", "isimagingdisplayed", "confirmprocedurename", "confirmpinstrumentcountcorrect",
                                  "confirmspecimenlabled", "confirmequipmentproblems", "confirmkeyconcerns", "operatiionsiteshaved",
                                  "operatiionsiteshavedremarks", "siteinspectedbyhn", "siteinspectedbyhnremarks", "patientgowned",
                                  "patientgownedremarks", "underwearremoved", "underwearremovedremarks", "hairpinsremoved", "hairpinsremovedremarks",
                                  "headcap", "headcapremarks", "nailpolishremoved", "nailpolishremovedremarks", "jewelryremoved", "jewelryremovedremarks",
                                  "denturesremoved", "denturesremovedremarks", "consentsigned", "consentsignedremarks", "xmatchingdone",
                                  "xmatchingdoneremarks", "routinebloodreps", "routinebloodrepsremarks", "urinereports", "urinereportsremarks",
                                  "xrayreports", "xrayreportsremarks", "voided", "timevoided", "amountvoided", "catheterized", "timecatheterized", "amountcatheterized",
                                  "temp", "cr", "rr", "bpsystolic", "bpdiastolic", "timebp", "preoperativemedication", "timeofmedication",
                                  "haspreviousanesthesia", "hasesthesiaproblem", "hasheartattack", "hashighblood", "hasstroke", "hasangina",
                                  "haschroniclungdisease", "hasasthma", "hashepatitis", "haskidneydisease", "hasdiabetes", "hasepilepsy",
                                  "hasrheumaticfever", "otherdiseases", "drugstaken", "hasallergies", "ispregnant", "weight", "hb", "biochem", "cxr",
                                  "ec", "otherphysicalstatus", "significanthistory", "physicalexam", "preoperativeinstructions", "specialinstructions"}
        Dim strVal() As String = {1, 0, admissionid, rvscode, rvsdesc, proceduredate, surgeonid, firstassistant,
                                  secondassistant, anesthesiologist, anesthetic, preoperativediagnosis, operativediagnosis,
                                  materialforlab, histhopathologydiagnosis, operationdescription, surgicalnurse, instrumentnurse,
                                  timebegin, timeend, spongecountverified, drains, ismajor, operationbegin, operationend,
                                  othersupplies, syringes, ivfluids, sutures, medicines, confirmpatientidentity, confirmpatientsite,
                                  confirmpatientprocedure, confirmpatientconsent, sitemarked, anaesthesiasafetycheck, pulseoximeter,
                                  knownallergy, aspirationrisk, bloodlossrisk, introducedmembers, verballyconfirmpatient,
                                  verballyconfirmsite, verballyconfirmprocedure, surgeonreview, anesthersiareview, nurseteamreview,
                                  antibioticprophylaxis, isimagingdisplayed, confirmprocedurename, confirmpinstrumentcountcorrect,
                                  confirmspecimenlabled, confirmequipmentproblems, confirmkeyconcerns, operatiionsiteshaved,
                                  operatiionsiteshavedremarks, siteinspectedbyhn, siteinspectedbyhnremarks, patientgowned,
                                  patientgownedremarks, underwearremoved, underwearremovedremarks, hairpinsremoved, hairpinsremovedremarks,
                                  headcap, headcapremarks, nailpolishremoved, nailpolishremovedremarks, jewelryremoved, jewelryremovedremarks,
                                  denturesremoved, denturesremovedremarks, consentsigned, consentsignedremarks, xmatchingdone,
                                  xmatchingdoneremarks, routinebloodreps, routinebloodrepsremarks, urinereports, urinereportsremarks,
                                  xrayreports, xrayreportsremarks, voided, timevoided, amountvoided, catheterized, timecatheterized, amountcatheterized,
                                  temp, cr, rr, bpsystolic, bpdiastolic, timebp, preoperativemedication, timeofmedication,
                                  haspreviousanesthesia, hasesthesiaproblem, hasheartattack, hashighblood, hasstroke, hasangina,
                                  haschroniclungdisease, hasasthma, hashepatitis, haskidneydisease, hasdiabetes, hasepilepsy,
                                  hasrheumaticfever, otherdiseases, drugstaken, hasallergies, ispregnant, weight, hb, biochem, cxr,
                                  ec, otherphysicalstatus, significanthistory, physicalexam, preoperativeinstructions, specialinstructions}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : s.SetParam(strPar, strVal, "spOperativeRecord", 1)
    End Sub
End Class
