Public Class clsAdmissiondetails

#Region "Variables"
    '------Admission
    Public operation As Integer
    Private mPatientID As Integer
    Private mAdmissionType As String
    Private mDocumentNo As String
    Private mHospitalNo As String
    Private mRoomId As Integer
    Private mOldRoomID As Integer
    Private mDateDischarge As DateTime
    Private mDateofAdmin As DateTime
    Private mAdmissionTime As DateTime
    Private mAdmissionDate As DateTime
    Private mNotify As String
    Private mNotifyRelationship As String
    Private mNotifyAddress As String
    Private mNotifyTelNo As String
    Private mPhilhealthNo As String
    Private mPhilhealthMember As String
    Private mInformant As String
    Private mInformantRelationship As String
    Private mAttendingPhysician As Long
    Private mAdmittingPhysician As Long
    Private mDoctorId As Integer
    Private mDeposit As String
    Private mHC As String
    Private mPC As String
    Private mKindOfOperation As String
    Private mMemberPHID As Integer
    Private mAccreditationNo As String
    Private mHospitalPlan As Integer
    Private mCaseType As String
    Private mHistoryofpresentillness As String
    Private mPhysicalExam As String
    Private mCourseInTheWards As String
    Private mPLPDF As String
    Private mConditionDischarge As String
    Private mSODateTime As String
    Private mSOAnesthesiaType As String
    Private mSOSurgeonName As String
    Private mSOAnesthesiologist As String
    Private mReference As String
    Private mIsDischarge As Boolean
    Private mPhilHealthCaseType As Char
    Private mEncodedBy As Integer
    Private mUpdatedBy As Integer
    Private mDateEncoded As DateTime
    Private mRoomRate As Decimal
    Private misAvailable As Boolean
    Private mNoOfDays As Integer
    Private mRCharge As Decimal
    Private mDCharge As Decimal
    Private mPcharge As Decimal
    Private mPHIC As Decimal
    Private mHMO As Decimal
    Private mDiscount As Decimal
    Private mExcess As Decimal
    Private mTypeID As Integer
    Private mStartDate As DateTime
    Private mDateEnded As DateTime
    Private misAdmitPatient As Boolean
    Private mphysicianchargetype As Integer
    Private mischargeable As Boolean
    Private mprocedurecode As String
    Private mCaseNo As Long
    Private mAdmissionStatus As String
    Private mFinalDiagnosis As String
    Private mAdmittingDiagnosis As String
    Private mChiefComplaints As String
    Private mReasonForAdmission As String
    Private mfamilyhistory As String
    Private madmittingimpression As String
    Private mpasthistory As String
    Private mpastillness As String
    Private mOfficecode As String
    Private mMGH As DateTime
    Private mDateofDeath As DateTime
    Private mReasonForRefferal As Integer
    Private mDischargeStatus As Char
    Private moldAttendingPhysician As Integer
    Private moldAdmittingPhysician As Integer
    Private mPhoto As Object

    Public isnewborn As Boolean
    Public isexpired As Boolean
    'Private misAdmitPatient As Boolean
    '------Admission Details
    Private madmissionid As Long
    Private mptno As Integer
    Private mgravida As Integer
    Private mpara As Integer
    Private mabortion As Integer
    Private mterm As Integer
    Private mpremature As Integer
    Private mline As Integer
    Private mpreviousmenstrualperiod As DateTime
    Private mpmpdurationcharacter As String
    Private mlastmenstrualperiod As DateTime
    Private mlmpdurationcharacter As String
    Private mestimateddateofconfinement As DateTime
    Private mageofgestation As String
    Private mmenarche As DateTime
    Private minterval As Integer
    Private mduration As String
    Private mamount As String
    Private mcontraception As String
    Private mdysmenorrhea As String
    Private mprenatalcoursepvtmd As Boolean
    Private mprenatalcoursedhiopd As Boolean
    Private mprenatalcoursehealthctr As Boolean
    Private mmidwife As Boolean
    Private mhilot As Boolean
    Private mnone As Boolean
    Private mfreqofcheckupdoneby As String
    Private mbp As String
    Private mcomplications As String
    Private mprenatalmedstaken As String
    Private mchildhooddiseases As String
    Private mprevioushospitalizations As String
    Private mpreviousoperations As String
    Private mmedicalillness As String
    Private mallergies As String
    Private mmedications As String
    Private mfamilyhistorydm As Boolean
    Private mfamilyhistoryhpn As Boolean
    Private mfamilyhistoryheartdse As Boolean
    Private mfamilyhistoryptb As Boolean
    Private mfamilyhistoryca As Boolean
    Private mfamilyhistoryothers As Boolean
    Private mrr As String
    Private mht As String
    Private mcr As String
    Private mt As String
    Private mwt As String
    Private mheadneck As String
    Private mheart As String
    Private mbreasts As String
    Private mlungs As String
    Private mabdomenfh As String
    Private mabdomenefw As String
    Private mabdomenfht As String
    Private mabdomenfhtcharacter As String
    Private mabdomenfhtlocation As String
    Private mextremeties As String
    Private mieby As String
    Private mdilatation As String
    Private meffacement As String
    Private mneurologicposition As String
    Private mstation As String
    Private mbow As String
    Private mbowleakingsince As Double
    Private mprespart As String
    Private mcharacterofdischargemucoi As String
    Private mcharacterofdischargebloody As String
    Private mcharacterofdischargewatery As String
    Private mcharacterofdischargecolor As String
    Private mcharacterofdischargeodor As String
    Private mspeculumexam As String
    Private mabnormalities As String
    Private mclinicalpelvimetryischialspines As String
    Private mclinicalpelvimetrysidewalls As String
    Private mclinicalpelvimetrypubicarch As String
    Private mclinicalpelvimetrysacrumcontour As String
    Private mclinicalpelvimetrysacrosciaticnotch As String
    Private mclinicalpelvimetryischialtuberosities As String
    Private mepcadequate As String
    Private mepcborderline As String
    Private mepcnarrow As String
    Private mimpression As String
    Private mdateofquickening As DateTime
    Private multrasoundAOG As String
    Private madjustedEDC As String
    Private multrasounddate As DateTime
    Private mprenatalvisits As Char
    Private mContraceptivesHistory As String
    Private mhealthcareprovider As String
    Private mimmunizationstetanus As Boolean
    Private mimmunizationstetanusdoses As String
    Private mimmunizationstetanusdate As DateTime
    Private mimmunizationshepatitisb As Boolean
    Private mimmunizationsothers As String
    Private mtotalgainweight As String
    Private mhb As String
    Private murinealb As String
    Private msugar As String
    Private mantenatalproblemsmb98ms As Boolean
    Private mantenatalproblemsprevcssurgery As Boolean
    Private mantenatalproblemsuti As Boolean
    Private mantenatalproblemsinfectiontracts As Boolean
    Private mantenatalproblemsnutritional As Boolean
    Private mantenatalproblemshpnpidchvd As Boolean
    Private mantenatalproblemscardiac As Boolean
    Private mantenatalproblemsrenal As Boolean
    Private mantenatalproblemsdmmetabolic As Boolean
    Private mantenatalproblemsrespiratory As Boolean
    Private mantenatalproblemsfetalwastage As Boolean
    Private mantenatalproblemsprematurelabor As Boolean
    Private mantenatalproblemsiugr As Boolean
    Private mantenatalproblemsinfertility As Boolean
    Private mantenatalproblemsothers As Boolean
    Private mriskstatus As String
    Private mphysicalexamdate As DateTime
    Private mphysicalexaminer As String
    Private mphysicalexamgeneralstatus As String
    Private mlevelofsensorium As String
    Private meent As String
    Private mchestheart As String
    Private mchestlungs As String
    Private mchestbreast As String
    Private mabdomenlsk As String
    Private mabdomenfundicheight As String
    Private mabdomenpresentation As String
    Private mabdomenfloatingengaged As String
    Private mabdomenother As String
    Private mpelvicexamexternalgenitalia As String
    Private mpelvicexamuterus As String
    Private mpelvicexamvaginacervixlength As String
    Private mpelvicexampositionant As String
    Private mpelvicexampositionmidline As String
    Private mpelvicexampositionpost As String
    Private mpresentationposition As String
    Private mpresentationstation As String
    Private mpresentationmembranes As String
    Private mpresentationamnioticfld As String
    Private mpresentationsutures As String
    Private mpelvimetrycontracted As Boolean
    Private mpelvimetrycontractedinlet As Boolean
    Private mpelvimetrycontractedinlettxt As String
    Private mpelvimetrycontractedmidline As Boolean
    Private mpelvimetrycontractedmidlinetxt As String
    Private mpelvimetrycontractedoutlet As Boolean
    Private mpelvimetrycontractedoutlettxt As String
    Private mpelvimetryborderline As Boolean
    Private mpelvimetryborderlinetriallabor As Boolean
    Private mgeneralstatus As String
    Private mpelvimetryadequate As Boolean
    Private mremarks As String
    Private mpresentillness As String
    Private mprenatalinfection As String
    Private mprenatalexposuretodrugs As String
    Private mprenatalsmokingalcohol As String
    Private mnataltypeofdelivery As String
    Private mnatalnsd As String
    Private mnatalcs As String
    Private mnatalyo As String
    Private mnatalgestationalage As String
    Private mnatalbodyweight As String
    Private mnatalapgarscore As String
    Private mnatalanomalies As String
    Private mnatalresuscitation As String
    Private mnatalcomplication As String
    Private mfeedinghistorybreastfeeding As String
    Private mfeedinghistorymilkformula As String
    Private mfeedinghistorysupplemental As String
    Private mfeedinghistoryallergies As String
    Private mgrowthdevelopmentmotor As String
    Private mgrowthdevelopmentlanguage As String
    Private mgrowthdevelopmenttoilettraining As String
    Private mgrowthdevelopmentschool As String
    Private mimmunizationbcg As String
    Private mimmunizationdpt As String
    Private mimmunizationopv As String
    Private mimmunizationboosterdoses As String
    Private mimmunizationmeascles As String
    Private mimmunizationhib As String
    Private mimmunizationhepatitis As String
    Private mgeneralappearance As String
    Private msheent As String
    Private mcl As String
    Private mcvs As String
    Private mabdomin As String
    Private mneurologicexam As String
    Private mpregnancyorder As String
    Private mpregnancyoutcome As String
    Private mgestationcompleted As String
    Private mbirth As String
    Private mpresent As String
    Private mobgyneno As String
    Private mobgyneyear As DateTime
    Private mobgynesex As String
    Private mobgynetypeofdelivery As String
    Private mobgyneplaceofdelivery As String
    Private mobgyneattending As String
    Private mobgynebw As String
    Private mobgynecomplications As String
    Private mMenstrualCycle1 As String
    Private mMenstrualCycle2 As String
    Private mMenstrualCycle3 As String
    Private mPogsGravida As Integer = 0
    Private mPogspara As Integer = 0
    Private mPogsabortion As Integer = 0
    Private mPogsterm As Integer = 0
    Private mPogspremature As Integer = 0
    Private mPogsline As Integer = 0
    Private mPediaGravida As Integer = 0
    Private mPediapara As Integer = 0
    Private mPediaabortion As Integer = 0
    Private mpogsdilatation As String
    Private mpogseffacement As String
    Private mpogsfht As String
    Private mpogsefw As String
    Private mPogsExtremities As String
    Private mObspogid As Integer
    Private mpogsyear As DateTime
    Private mpogssex As String
    Private mpogscomplications As String
    Private mPhilRelationshiptoMember As String
    Private mPhilReferredFrom As String
    Private mPhilRepresentative As String
    Private mPhilRelationshiptoRep As String
    Private mPhilContactnoRep As String
    Private mPhilTypeofDelivery As String
    Private mPhilNurseonDuty As String
    Private mPhilWithMedPack As Boolean
    Private mPhilRemarks As String
    Private mPhilisPhilhealthApprove As Boolean
    Private mPhilHealthApprovalRemarks As String
    '------Vital Signs
    Private amBloodPressure As String
    Private amDiastolic As String
    Private amBreathing As String
    Private amPulse As String
    Private amTemp As String
    Private amHeight As String
    Private amWeight As String
    Private amHeent As String
    Private amChest As String
    Private amCVs As String
    Private amAbdomen As String
    Private amGU As String
    Private amskinExtrem As String
    Private amNeuro As String
    '------PhilHealth
    Private mPhilHealth As String
    Private mPhilLastName As String
    Private mPhilFirstName As String
    Private mPhilMiddleName As String
    Private mPhilMembershipCatCode As Integer
    Private mPhilAvailmentType As Char
    Private mPhilHouseNo As String
    Private mPhilBarangay As Char
    Private mPhilCityMunicipality As String
    Private mPhilProvince As String
    Private mPhilZipCode As String
    Private mPhilDateofBirth As DateTime
    Private mPhilEmailAdd As String
    Private mPhilMobileNo As String
    Private mPhilLandLineNo As String
    Private mPhilEmpNo As String
    Private mPhilEmpContactNo As String
    Private mPhilEmpBusName As String
    Private mPhilEmpBldgNo As String
    Private mPhilEmpCityMunicipality As String
    Private mPhilEmpProvince As String
    Private mPhilEmpZipCode As String

    Public mreferringid As Long
    Public referringreason As String
    Public mreferralid As Long
    Public packagecaseno As Long

    Public alteredmentalsensorium As Boolean
    Public abdominalcramp_pain As Boolean
    Public anorexia As Boolean
    Public bleedinggums As Boolean
    Public bodyweakness As Boolean
    Public blurringofvision As Boolean
    Public constipation As Boolean
    Public chestpain_discomfort As Boolean
    Public cough_dry As Boolean
    Public cough_productive As Boolean
    Public diarrhea As Boolean
    Public dizziness As Boolean
    Public dysphagia As Boolean
    Public dyspnea As Boolean
    Public dysuria As Boolean
    Public epistaxis As Boolean
    Public fever As Boolean
    Public frequencyofurination As Boolean
    Public headache As Boolean
    Public hematemesis As Boolean
    Public hematuria As Boolean
    Public hemoptysis As Boolean
    Public increaseirritability As Boolean
    Public jaundice As Boolean
    Public lowerextremityedema As Boolean
    Public myalgia As Boolean
    Public orthopnea As Boolean
    Public palpitations As Boolean
    Public skinrashes As Boolean
    Public stool_bloody_blacktarry_mucoid As Boolean
    Public sweating As Boolean
    Public seizures As Boolean
    Public urgency As Boolean
    Public vomiting As Boolean
    Public weightloss As Boolean
    Public others As String
    Public pain As String

    Public survey_awakeandalert As Boolean
    Public survey_alteredsensorium As String
    Public heent_essentiallynormal As Boolean
    Public heent_abnormalpupillaryreaction As Boolean
    Public heent_cervicallympadenopathy As Boolean
    Public heent_drymucousmembrane As Boolean
    Public heent_ictericsclerae As Boolean
    Public heent_paleconjunctivae As Boolean
    Public heent_sunkeneyeballs As Boolean
    Public heent_sunkenfontanelle As Boolean
    Public chest_essentiallynormal As Boolean
    Public chest_asymmetricalexpansion As Boolean
    Public chest_decreasedbreathsounds As Boolean
    Public chest_wheezes As Boolean
    Public chest_lumpsoverbreast As Boolean
    Public chest_ralescracklesrhonchi As Boolean
    Public chest_intercostalribretraction As Boolean
    Public cvs_essentiallynormal As Boolean
    Public cvs_displacedapexbeat As Boolean
    Public cvs_heaves As Boolean
    Public cvs_irregularrhythm As Boolean
    Public cvs_muffledheartsounds As Boolean
    Public cvs_murmur As Boolean
    Public cvs_pericardialbulge As Boolean
    Public abdomen_essentiallynormal As Boolean
    Public abdomen_abdominalrigidity As Boolean
    Public abdomen_abdominaltenderness As Boolean
    Public abdomen_hyperactivebowelsounds As Boolean
    Public abdomen_palpablemass As Boolean
    Public abdomen_tympaniticdullabdomen As Boolean
    Public abdomen_uterinecontraction As Boolean
    Public gu_essentiallynormal As Boolean
    Public gu_bloodstainedfinger As Boolean
    Public gu_cervicaldilatation As Boolean
    Public gu_presenceofabnormaldischarge As Boolean
    Public skin_essentiallynormal As Boolean
    Public skin_clubbing As Boolean
    Public skin_coldclammy As Boolean
    Public skin_cyanosis As Boolean
    Public skin_edema As Boolean
    Public skin_muscles As Boolean
    Public skin_palenailbeds As Boolean
    Public skin_poorskinturgor As Boolean
    Public skin_rashespetechiae As Boolean
    Public skin_weakpulses As Boolean
    Public neuro_essentiallynormal As Boolean
    Public neuro_abnormalgait As Boolean
    Public neuro_abnormalposition As Boolean
    Public neuro_abnormalsensation As Boolean
    Public neuro_presenceofabnormalreflex As Boolean
    Public neuro_pooralteredmemory As Boolean
    Public neuro_poormuscletone As Boolean
    Public neuro_poorcoordination As Boolean

    Public interviewedbyid As Long
    Public dischargedbyid As Long
    Public conditiononarrival As Integer
#End Region

#Region "Properties"
    '------Admission property
    Public Property Photo() As Object
        Get
            Return mPhoto
        End Get
        Set(ByVal value As Object)
            mPhoto = value
        End Set
    End Property
    Public Property PhysicianChargeType() As Integer
        Get
            Return mphysicianchargetype
        End Get
        Set(ByVal value As Integer)
            mphysicianchargetype = value
        End Set
    End Property
    Public Property isChargeable() As Boolean
        Get
            Return mischargeable
        End Get
        Set(ByVal value As Boolean)
            mischargeable = value
        End Set
    End Property
    Public Property PtNo() As Integer
        Get
            Return mptno
        End Get
        Set(ByVal value As Integer)
            mptno = value
        End Set
    End Property
    Public Property PatientID() As Integer
        Get
            Return mPatientID
        End Get
        Set(ByVal value As Integer)
            mPatientID = value
        End Set
    End Property
    Public Property RoomID() As Integer
        Get
            Return mRoomId
        End Get
        Set(ByVal value As Integer)
            mRoomId = value
        End Set
    End Property
    Public Property OldRoomID() As Integer
        Get
            Return mOldRoomID
        End Get
        Set(ByVal value As Integer)
            mOldRoomID = value
        End Set
    End Property
    Public Property AdmittingPhysician() As Long
        Get
            Return mAdmittingPhysician
        End Get
        Set(ByVal value As Long)
            mAdmittingPhysician = value
        End Set
    End Property
    Public Property AttendingPhysician() As Integer
        Get
            Return mAttendingPhysician
        End Get
        Set(ByVal value As Integer)
            mAttendingPhysician = value
        End Set
    End Property
    Public Property OldAttendingPhysician() As Integer
        Get
            Return moldAttendingPhysician
        End Get
        Set(ByVal value As Integer)
            moldAttendingPhysician = value
        End Set
    End Property
    Public Property OldAdmittingPhysician() As Integer
        Get
            Return moldAdmittingPhysician
        End Get
        Set(ByVal value As Integer)
            moldAdmittingPhysician = value
        End Set
    End Property
    Public Property DateofAdmin() As DateTime
        Get
            Return mDateofAdmin
        End Get
        Set(ByVal value As DateTime)
            mDateofAdmin = value
        End Set
    End Property
    Public Property AdmissionTime() As DateTime
        Get
            Return mAdmissionTime
        End Get
        Set(ByVal value As DateTime)
            mAdmissionTime = value
        End Set
    End Property
    Public Property MGHDate() As DateTime
        Get
            Return mMGH
        End Get
        Set(ByVal value As DateTime)
            mMGH = value
        End Set
    End Property
    Public Property DateofDeath() As DateTime
        Get
            Return mDateofDeath
        End Get
        Set(ByVal value As DateTime)
            mDateofDeath = value
        End Set
    End Property
    Public Property DischargeStatus() As Char
        Get
            Return mDischargeStatus
        End Get
        Set(ByVal value As Char)
            mDischargeStatus = value
        End Set
    End Property
    Public Property ReasonRefferalNo() As Integer
        Get
            Return mReasonForRefferal
        End Get
        Set(ByVal value As Integer)
            mReasonForRefferal = value
        End Set
    End Property
    Public Property AdmissionDate() As DateTime
        Get
            Return mAdmissionDate
        End Get
        Set(ByVal value As DateTime)
            mAdmissionDate = value
        End Set
    End Property
    Public Property CaseNo() As Long
        Get
            Return mCaseNo
        End Get
        Set(ByVal value As Long)
            mCaseNo = value
        End Set
    End Property
    Public Property DateDischarge() As DateTime
        Get
            Return mDateDischarge
        End Get
        Set(ByVal value As DateTime)
            mDateDischarge = value
        End Set
    End Property
    Public Property Notify() As String
        Get
            Return mNotify
        End Get
        Set(ByVal value As String)
            mNotify = value
        End Set
    End Property
    Public Property HospitalNo() As String
        Get
            Return mHospitalNo
        End Get
        Set(ByVal value As String)
            mHospitalNo = value
        End Set
    End Property
    Public Property Officecode() As String
        Get
            Return mOfficecode
        End Get
        Set(ByVal value As String)
            mOfficecode = value
        End Set
    End Property
    Public Property AdmissionType() As String
        Get
            Return mAdmissionType
        End Get
        Set(ByVal value As String)
            mAdmissionType = value
        End Set
    End Property
    Public Property ProcedureCode() As String
        Get
            Return mprocedurecode
        End Get
        Set(ByVal value As String)
            mprocedurecode = value
        End Set
    End Property
    Public Property AdmissionStatus() As String
        Get
            Return mAdmissionStatus
        End Get
        Set(ByVal value As String)
            mAdmissionStatus = value
        End Set
    End Property
    Public Property NotifyRelationship() As String
        Get
            Return mNotifyRelationship
        End Get
        Set(ByVal value As String)
            mNotifyRelationship = value
        End Set
    End Property
    Public Property NotifyAddress() As String
        Get
            Return mNotifyAddress
        End Get
        Set(ByVal value As String)
            mNotifyAddress = value
        End Set
    End Property
    Public Property NotifyNo() As String
        Get
            Return mNotifyTelNo
        End Get
        Set(ByVal value As String)
            mNotifyTelNo = value
        End Set
    End Property
    Public Property PhilHealthNo() As String
        Get
            Return mPhilhealthNo
        End Get
        Set(ByVal value As String)
            mPhilhealthNo = value
        End Set
    End Property
    Public Property PhilHealthMember() As String
        Get
            Return mPhilhealthMember
        End Get
        Set(ByVal value As String)
            mPhilhealthMember = value
        End Set
    End Property
    Public Property Informant() As String
        Get
            Return mInformant
        End Get
        Set(ByVal value As String)
            mInformant = value
        End Set
    End Property
    Public Property InformantRelationship() As String
        Get
            Return mInformantRelationship
        End Get
        Set(ByVal value As String)
            mInformantRelationship = value
        End Set
    End Property
    Public Property DoctorID() As Integer
        Get
            Return mDoctorId
        End Get
        Set(ByVal value As Integer)
            mDoctorId = value
        End Set
    End Property
    Public Property Deposit() As String
        Get
            Return mDeposit
        End Get
        Set(ByVal value As String)
            mDeposit = value
        End Set
    End Property
    Public Property KindOfOperation() As String
        Get
            Return mKindOfOperation
        End Get
        Set(ByVal value As String)
            mKindOfOperation = value
        End Set
    End Property
    Public Property MemberPHID() As String
        Get
            Return mMemberPHID
        End Get
        Set(ByVal value As String)
            mMemberPHID = value
        End Set
    End Property
    Public Property AccreditationNo() As String
        Get
            Return mAccreditationNo
        End Get
        Set(ByVal value As String)
            mAccreditationNo = value
        End Set
    End Property
    Public Property CaseType() As String
        Get
            Return mCaseType
        End Get
        Set(ByVal value As String)
            mCaseType = value
        End Set
    End Property
    Public Property FinalDiagnosis() As String
        Get
            Return mFinalDiagnosis
        End Get
        Set(ByVal value As String)
            mFinalDiagnosis = value
        End Set
    End Property
    Public Property AdmittingDiagnosis() As String
        Get
            Return mAdmittingDiagnosis
        End Get
        Set(ByVal value As String)
            mAdmittingDiagnosis = value
        End Set
    End Property
    Public Property ChiefComplaints() As String
        Get
            Return mChiefComplaints
        End Get
        Set(ByVal value As String)
            mChiefComplaints = value
        End Set
    End Property
    Public Property ReasonForAdmission() As String
        Get
            Return mReasonForAdmission
        End Get
        Set(ByVal value As String)
            mReasonForAdmission = value
        End Set
    End Property
    Public Property Historyofpresentillness() As String
        Get
            Return mHistoryofpresentillness
        End Get
        Set(ByVal value As String)
            mHistoryofpresentillness = value
        End Set
    End Property
    Public Property PhysicalExam() As String
        Get
            Return mPhysicalExam
        End Get
        Set(ByVal value As String)
            mPhysicalExam = value
        End Set
    End Property
    Public Property CourseInTheWards() As String
        Get
            Return mCourseInTheWards
        End Get
        Set(ByVal value As String)
            mCourseInTheWards = value
        End Set
    End Property
    Public Property PLPDF() As String
        Get
            Return mPLPDF
        End Get
        Set(ByVal value As String)
            mPLPDF = value
        End Set
    End Property
    Public Property ConditionOnDischarge() As String
        Get
            Return mConditionDischarge
        End Get
        Set(ByVal value As String)
            mConditionDischarge = value
        End Set
    End Property
    Public Property SODateTime() As String
        Get
            Return mSODateTime
        End Get
        Set(ByVal value As String)
            mSODateTime = value
        End Set
    End Property
    Public Property SOAnesthesiaType() As String
        Get
            Return mSOAnesthesiaType
        End Get
        Set(ByVal value As String)
            mSOAnesthesiaType = value
        End Set
    End Property
    Public Property SOSurgeonName() As String
        Get
            Return mSOSurgeonName
        End Get
        Set(ByVal value As String)
            mSOSurgeonName = value
        End Set
    End Property
    Public Property SOAnesthesiologist() As String
        Get
            Return mSOAnesthesiologist
        End Get
        Set(ByVal value As String)
            mSOAnesthesiologist = value
        End Set
    End Property
    Public Property Reference() As String
        Get
            Return mReference
        End Get
        Set(ByVal value As String)
            mReference = value
        End Set
    End Property
    Public Property IsDischarge() As Boolean
        Get
            Return mIsDischarge
        End Get
        Set(ByVal value As Boolean)
            mIsDischarge = value
        End Set
    End Property
    Public Property HospitalPlan() As Integer
        Get
            Return mHospitalPlan
        End Get
        Set(ByVal value As Integer)
            mHospitalPlan = value
        End Set
    End Property
    Public Property PhilHealthCaseType() As Char
        Get
            Return mPhilHealthCaseType
        End Get
        Set(ByVal value As Char)
            mPhilHealthCaseType = value
        End Set
    End Property
    Public Property EncodedBy() As Integer
        Get
            Return mEncodedBy
        End Get
        Set(ByVal value As Integer)
            mEncodedBy = value
        End Set
    End Property
    Public Property DateEncoded() As DateTime
        Get
            Return mDateEncoded
        End Get
        Set(ByVal value As DateTime)
            mDateEncoded = value
        End Set
    End Property

    Public Property UpdatedBy() As Integer
        Get
            Return mUpdatedBy
        End Get
        Set(ByVal value As Integer)
            mUpdatedBy = value
        End Set
    End Property

    Public Property RoomRate() As Decimal
        Get
            Return mRoomRate
        End Get
        Set(ByVal value As Decimal)
            mRoomRate = value
        End Set
    End Property
    Public Property isAvailable() As Boolean
        Get
            Return misAvailable
        End Get
        Set(ByVal value As Boolean)
            misAvailable = value
        End Set
    End Property
    Public Property NoOfDays() As Integer
        Get
            Return mNoOfDays
        End Get
        Set(ByVal value As Integer)
            mNoOfDays = value
        End Set
    End Property
    Public Property RCharge() As Decimal
        Get
            Return mRCharge
        End Get
        Set(ByVal value As Decimal)
            mRCharge = value
        End Set
    End Property
    Public Property DCharge() As Decimal
        Get
            Return mDCharge
        End Get
        Set(ByVal value As Decimal)
            mDCharge = value
        End Set
    End Property
    Public Property PCharge() As Decimal
        Get
            Return mPcharge
        End Get
        Set(ByVal value As Decimal)
            mPcharge = value
        End Set
    End Property
    Public Property PHIC() As Decimal
        Get
            Return mPHIC
        End Get
        Set(ByVal value As Decimal)
            mPHIC = value
        End Set
    End Property
    Public Property HMO() As Decimal
        Get
            Return mHMO
        End Get
        Set(ByVal value As Decimal)
            mHMO = value
        End Set
    End Property
    Public Property Discount() As Decimal
        Get
            Return mDiscount
        End Get
        Set(ByVal value As Decimal)
            mDiscount = value
        End Set
    End Property
    Public Property Excess() As Decimal
        Get
            Return mExcess
        End Get
        Set(ByVal value As Decimal)
            mExcess = value
        End Set
    End Property
    Public Property TypeID() As Integer
        Get
            Return mTypeID
        End Get
        Set(ByVal value As Integer)
            mTypeID = value
        End Set
    End Property
    Public Property StartDAte() As DateTime
        Get
            Return mStartDate
        End Get
        Set(ByVal value As DateTime)
            mStartDate = value
        End Set
    End Property
    Public Property DateEnded() As DateTime
        Get
            Return mDateEnded
        End Get
        Set(ByVal value As DateTime)
            mDateEnded = value
        End Set
    End Property

    '------vital signs property
    Public Property aBloodPressure() As String
        Get
            Return amBloodPressure
        End Get
        Set(ByVal value As String)
            amBloodPressure = value
        End Set
    End Property
    Public Property aDiastolic() As String
        Get
            Return amDiastolic
        End Get
        Set(ByVal value As String)
            amDiastolic = value
        End Set
    End Property
    Public Property aBreathing() As String
        Get
            Return amBreathing
        End Get
        Set(ByVal value As String)
            amBreathing = value
        End Set
    End Property
    Public Property aPulse() As String
        Get
            Return amPulse
        End Get
        Set(ByVal value As String)
            amPulse = value
        End Set
    End Property
    Public Property aTemp() As String
        Get
            Return amtemp
        End Get
        Set(ByVal value As String)
            amtemp = value
        End Set
    End Property
    Public Property aHeight() As String
        Get
            Return amheight
        End Get
        Set(ByVal value As String)
            amheight = value
        End Set
    End Property
    Public Property aWeight() As String
        Get
            Return amweight
        End Get
        Set(ByVal value As String)
            amweight = value
        End Set
    End Property
    Public Property aHeent() As String
        Get
            Return amHeent
        End Get
        Set(ByVal value As String)
            amHeent = value
        End Set
    End Property
    Public Property aChest() As String
        Get
            Return amchest
        End Get
        Set(ByVal value As String)
            amchest = value
        End Set
    End Property
    Public Property aCVs() As String
        Get
            Return amcvs
        End Get
        Set(ByVal value As String)
            amcvs = value
        End Set
    End Property
    Public Property aAbdomen() As String
        Get
            Return amabdomen
        End Get
        Set(ByVal value As String)
            amabdomen = value
        End Set
    End Property
    Public Property aSkinExtrem() As String
        Get
            Return amSkinExtrem
        End Get
        Set(ByVal value As String)
            amSkinExtrem = value
        End Set
    End Property
    Public Property aNeuro() As String
        Get
            Return amneuro
        End Get
        Set(ByVal value As String)
            amneuro = value
        End Set
    End Property
    Public Property aGU() As String
        Get
            Return amGU
        End Get
        Set(ByVal value As String)
            amGU = value
        End Set
    End Property

    '-----admission detail property
    Public Property Admissionid() As Long
        Get
            Return madmissionid
        End Get
        Set(ByVal value As Long)
            madmissionid = value
        End Set
    End Property
    Public Property DocumentNo() As String
        Get
            Return mDocumentNo
        End Get
        Set(ByVal value As String)
            mDocumentNo = value
        End Set
    End Property
    Public Property AdmittingImpression() As String
        Get
            Return madmittingimpression
        End Get
        Set(ByVal value As String)
            madmittingimpression = value
        End Set
    End Property
    Public Property PastHistory() As String
        Get
            Return mpasthistory
        End Get
        Set(ByVal value As String)
            mpasthistory = value
        End Set
    End Property
    Public Property PastIllness() As String
        Get
            Return mpastillness
        End Get
        Set(ByVal value As String)
            mpastillness = value
        End Set
    End Property
    Public Property Gravida() As Integer
        Get
            Return mgravida
        End Get
        Set(ByVal value As Integer)
            mgravida = value
        End Set
    End Property
    Public Property Para() As Integer
        Get
            Return mpara
        End Get
        Set(ByVal value As Integer)
            mpara = value
        End Set
    End Property
    Public Property Abortion() As Integer
        Get
            Return mabortion
        End Get
        Set(ByVal value As Integer)
            mabortion = value
        End Set
    End Property
    Public Property Term() As Integer
        Get
            Return mterm
        End Get
        Set(ByVal value As Integer)
            mterm = value
        End Set
    End Property
    Public Property Premature() As Integer
        Get
            Return mpremature
        End Get
        Set(ByVal value As Integer)
            mpremature = value
        End Set
    End Property
    Public Property Line() As Integer
        Get
            Return mline
        End Get
        Set(ByVal value As Integer)
            mline = value
        End Set
    End Property
    Public Property PreviousMenstrualPeriod() As DateTime
        Get
            Return mPreviousMenstrualPeriod
        End Get
        Set(ByVal value As DateTime)
            mpreviousmenstrualperiod = value
        End Set
    End Property
    Public Property PMPDurationCharacter() As String
        Get
            Return mpmpdurationcharacter
        End Get
        Set(ByVal value As String)
            mpmpdurationcharacter = value
        End Set
    End Property
    Public Property LastmenstrualPeriod() As DateTime
        Get
            Return mlastmenstrualperiod
        End Get
        Set(ByVal value As DateTime)
            mlastmenstrualperiod = value
        End Set
    End Property
    Public Property LmpDurationCharacter() As String
        Get
            Return mlmpdurationcharacter
        End Get
        Set(ByVal value As String)
            mlmpdurationcharacter = value
        End Set
    End Property
    Public Property EstimatedDateofConfinement() As DateTime
        Get
            Return mestimateddateofconfinement
        End Get
        Set(ByVal value As DateTime)
            mestimateddateofconfinement = value
        End Set
    End Property
    Public Property AgeofGestation() As String
        Get
            Return mageofgestation
        End Get
        Set(ByVal value As String)
            mageofgestation = value
        End Set
    End Property
    Public Property Menarche() As DateTime
        Get
            Return mmenarche
        End Get
        Set(ByVal value As DateTime)
            mmenarche = value
        End Set
    End Property
    Public Property Interval() As Integer
        Get
            Return minterval
        End Get
        Set(ByVal value As Integer)
            minterval = value
        End Set
    End Property
    Public Property Duration() As String
        Get
            Return mduration
        End Get
        Set(ByVal value As String)
            mduration = value
        End Set
    End Property
    Public Property Amount() As String
        Get
            Return mamount
        End Get
        Set(ByVal value As String)
            mamount = value
        End Set
    End Property
    Public Property Contraception() As String
        Get
            Return mcontraception
        End Get
        Set(ByVal value As String)
            mcontraception = value
        End Set
    End Property
    Public Property Dysmenorrhea() As String
        Get
            Return mdysmenorrhea
        End Get
        Set(ByVal value As String)
            mdysmenorrhea = value
        End Set
    End Property
    Public Property PrenatalCoursePvtmd() As Boolean
        Get
            Return mprenatalcoursepvtmd
        End Get
        Set(ByVal value As Boolean)
            mprenatalcoursepvtmd = value
        End Set
    End Property
    Public Property PrenatalCourseDHIOPD() As Boolean
        Get
            Return mprenatalcoursedhiopd
        End Get
        Set(ByVal value As Boolean)
            mprenatalcoursedhiopd = value
        End Set
    End Property
    Public Property PrenatalCourseHealthCtr() As Boolean
        Get
            Return mprenatalcoursehealthctr
        End Get
        Set(ByVal value As Boolean)
            mprenatalcoursehealthctr = value
        End Set
    End Property
    Public Property PrenatalCourseMidwife() As Boolean
        Get
            Return mmidwife
        End Get
        Set(ByVal value As Boolean)
            mmidwife = value
        End Set
    End Property
    Public Property PrenatalCourseHilot() As Boolean
        Get
            Return mhilot
        End Get
        Set(ByVal value As Boolean)
            mhilot = value
        End Set
    End Property
    Public Property PrenatalCourseNone() As Boolean
        Get
            Return mnone
        End Get
        Set(ByVal value As Boolean)
            mnone = value
        End Set
    End Property
    Public Property FreqofChekUpDoneBy() As String
        Get
            Return mfreqofcheckupdoneby
        End Get
        Set(ByVal value As String)
            mfreqofcheckupdoneby = value
        End Set
    End Property
    Public Property BP() As String
        Get
            Return mbp
        End Get
        Set(ByVal value As String)
            mbp = value
        End Set
    End Property
    Public Property Complications() As String
        Get
            Return mcomplications
        End Get
        Set(ByVal value As String)
            mcomplications = value
        End Set
    End Property
    Public Property PrenatalMedsTaken() As String
        Get
            Return mprenatalmedstaken
        End Get
        Set(ByVal value As String)
            mprenatalmedstaken = value
        End Set
    End Property
    Public Property ChildhoodDiseases() As String
        Get
            Return mchildhooddiseases
        End Get
        Set(ByVal value As String)
            mchildhooddiseases = value
        End Set
    End Property
    Public Property PrevHospitalizations() As String
        Get
            Return mprevioushospitalizations
        End Get
        Set(ByVal value As String)
            mprevioushospitalizations = value
        End Set
    End Property
    Public Property PrevOperations() As String
        Get
            Return mpreviousoperations
        End Get
        Set(ByVal value As String)
            mpreviousoperations = value
        End Set
    End Property
    Public Property MedicalIllness() As String
        Get
            Return mmedicalillness
        End Get
        Set(ByVal value As String)
            mmedicalillness = value
        End Set
    End Property
    Public Property Allergies() As String
        Get
            Return mallergies
        End Get
        Set(ByVal value As String)
            mallergies = value
        End Set
    End Property
    Public Property FamilyHistoryDM() As Boolean
        Get
            Return mfamilyhistorydm
        End Get
        Set(ByVal value As Boolean)
            mfamilyhistorydm = value
        End Set
    End Property
    Public Property FamilyHistoryHPN() As Boolean
        Get
            Return mfamilyhistoryhpn
        End Get
        Set(ByVal value As Boolean)
            mfamilyhistoryhpn = value
        End Set
    End Property
    Public Property FamilyHistoryDse() As Boolean
        Get
            Return mfamilyhistoryheartdse
        End Get
        Set(ByVal value As Boolean)
            mfamilyhistoryheartdse = value
        End Set
    End Property
    Public Property FamilyHistoryPTB() As Boolean
        Get
            Return mfamilyhistoryptb
        End Get
        Set(ByVal value As Boolean)
            mfamilyhistoryptb = value
        End Set
    End Property
    Public Property FamilyHistoryCA() As Boolean
        Get
            Return mfamilyhistoryca
        End Get
        Set(ByVal value As Boolean)
            mfamilyhistoryca = value
        End Set
    End Property
    Public Property FamilyHistoryOthers() As Boolean
        Get
            Return mfamilyhistoryothers
        End Get
        Set(ByVal value As Boolean)
            mfamilyhistoryothers = value
        End Set
    End Property
    Public Property Medications() As String
        Get
            Return mmedications
        End Get
        Set(ByVal value As String)
            mmedications = value
        End Set
    End Property
    Public Property FamilyHistory() As String
        Get
            Return mfamilyhistory
        End Get
        Set(ByVal value As String)
            mfamilyhistory = value
        End Set
    End Property
    Public Property RR() As String
        Get
            Return mrr
        End Get
        Set(ByVal value As String)
            mrr = value
        End Set
    End Property
    Public Property HT() As String
        Get
            Return mht
        End Get
        Set(ByVal value As String)
            mht = value
        End Set
    End Property
    Public Property CR() As String
        Get
            Return mcr
        End Get
        Set(ByVal value As String)
            mcr = value
        End Set
    End Property
    Public Property T() As String
        Get
            Return mt
        End Get
        Set(ByVal value As String)
            mt = value
        End Set
    End Property
    Public Property WT() As String
        Get
            Return mwt
        End Get
        Set(ByVal value As String)
            mwt = value
        End Set
    End Property
    Public Property HeadNeck() As String
        Get
            Return mheadneck
        End Get
        Set(ByVal value As String)
            mheadneck = value
        End Set
    End Property
    Public Property Heart() As String
        Get
            Return mheart
        End Get
        Set(ByVal value As String)
            mheart = value
        End Set
    End Property
    Public Property Breasts() As String
        Get
            Return mbreasts
        End Get
        Set(ByVal value As String)
            mbreasts = value
        End Set
    End Property
    Public Property Lungs() As String
        Get
            Return mlungs
        End Get
        Set(ByVal value As String)
            mlungs = value
        End Set
    End Property
    Public Property AbdomenFh() As String
        Get
            Return mabdomenfh
        End Get
        Set(ByVal value As String)
            mabdomenfh = value
        End Set
    End Property
    Public Property AbdomenEFW() As String
        Get
            Return mabdomenefw
        End Get
        Set(ByVal value As String)
            mabdomenefw = value
        End Set
    End Property
    Public Property AbdomenFHt() As String
        Get
            Return mabdomenfht
        End Get
        Set(ByVal value As String)
            mabdomenfht = value
        End Set
    End Property
    Public Property AbdomenFHtCharacter() As String
        Get
            Return mabdomenfhtcharacter
        End Get
        Set(ByVal value As String)
            mabdomenfhtcharacter = value
        End Set
    End Property
    Public Property AbdomenFHtLocation() As String
        Get
            Return mabdomenfhtlocation
        End Get
        Set(ByVal value As String)
            mabdomenfhtlocation = value
        End Set
    End Property
    Public Property Extremeties() As String
        Get
            Return mextremeties
        End Get
        Set(ByVal value As String)
            mextremeties = value
        End Set
    End Property
    Public Property IEBy() As String
        Get
            Return mieby
        End Get
        Set(ByVal value As String)
            mieby = value
        End Set
    End Property
    Public Property Dilatation() As String
        Get
            Return mdilatation
        End Get
        Set(ByVal value As String)
            mdilatation = value
        End Set
    End Property
    Public Property NeurologicPosition() As String
        Get
            Return mneurologicposition
        End Get
        Set(ByVal value As String)
            mneurologicposition = value
        End Set
    End Property
    Public Property Effacement() As String
        Get
            Return meffacement
        End Get
        Set(ByVal value As String)
            meffacement = value
        End Set
    End Property
    Public Property Station() As String
        Get
            Return mstation
        End Get
        Set(ByVal value As String)
            mstation = value
        End Set
    End Property
    Public Property BOW() As String
        Get
            Return mbow
        End Get
        Set(ByVal value As String)
            mbow = value
        End Set
    End Property
    Public Property BOWLeakingSince() As Double
        Get
            Return mbowleakingsince
        End Get
        Set(ByVal value As Double)
            mbowleakingsince = value
        End Set
    End Property
    Public Property PresPart() As String
        Get
            Return mprespart
        End Get
        Set(ByVal value As String)
            mprespart = value
        End Set
    End Property
    Public Property CharacterofDischargeMucoid() As String
        Get
            Return mcharacterofdischargemucoi
        End Get
        Set(ByVal value As String)
            mcharacterofdischargemucoi = value
        End Set
    End Property
    Public Property CharacterofDischargeBloody() As String
        Get
            Return mcharacterofdischargebloody
        End Get
        Set(ByVal value As String)
            mcharacterofdischargebloody = value
        End Set
    End Property
    Public Property CharacterofDischargeWatery() As String
        Get
            Return mcharacterofdischargewatery
        End Get
        Set(ByVal value As String)
            mcharacterofdischargewatery = value
        End Set
    End Property
    Public Property CharacterofDischargeColor() As String
        Get
            Return mcharacterofdischargecolor
        End Get
        Set(ByVal value As String)
            mcharacterofdischargecolor = value
        End Set
    End Property
    Public Property CharacterofDischargeOdor() As String
        Get
            Return mcharacterofdischargeodor
        End Get
        Set(ByVal value As String)
            mcharacterofdischargeodor = value
        End Set
    End Property
    Public Property SpeculumExam() As String
        Get
            Return mspeculumexam
        End Get
        Set(ByVal value As String)
            mspeculumexam = value
        End Set
    End Property
    Public Property Abnormalities() As String
        Get
            Return mabnormalities
        End Get
        Set(ByVal value As String)
            mabnormalities = value
        End Set
    End Property
    Public Property ClinicalPelvimetryIschialSpines() As String
        Get
            Return mclinicalpelvimetryischialspines
        End Get
        Set(ByVal value As String)
            mclinicalpelvimetryischialspines = value
        End Set
    End Property
    Public Property ClinicalPelvimetrySideWalls() As String
        Get
            Return mclinicalpelvimetrysidewalls
        End Get
        Set(ByVal value As String)
            mclinicalpelvimetrysidewalls = value
        End Set
    End Property
    Public Property ClinicalPelvimetryPubicArch() As String
        Get
            Return mclinicalpelvimetrypubicarch
        End Get
        Set(ByVal value As String)
            mclinicalpelvimetrypubicarch = value
        End Set
    End Property
    Public Property ClinicalPelvimetrySacrumContour() As String
        Get
            Return mclinicalpelvimetrysacrumcontour
        End Get
        Set(ByVal value As String)
            mclinicalpelvimetrysacrumcontour = value
        End Set
    End Property
    Public Property ClinicalPelvimetrySacrosciaticNotch() As String
        Get
            Return mclinicalpelvimetrysacrosciaticnotch
        End Get
        Set(ByVal value As String)
            mclinicalpelvimetrysacrosciaticnotch = value
        End Set
    End Property
    Public Property ClinicalPelvimetryIschialTuberosities() As String
        Get
            Return mclinicalpelvimetryischialtuberosities
        End Get
        Set(ByVal value As String)
            mclinicalpelvimetryischialtuberosities = value
        End Set
    End Property
    Public Property EPCAdequate() As String
        Get
            Return mepcadequate
        End Get
        Set(ByVal value As String)
            mepcadequate = value
        End Set
    End Property
    Public Property EPCBorderLine() As String
        Get
            Return mepcborderline
        End Get
        Set(ByVal value As String)
            mepcborderline = value
        End Set
    End Property
    Public Property EPCNarrow() As String
        Get
            Return mepcnarrow
        End Get
        Set(ByVal value As String)
            mepcnarrow = value
        End Set
    End Property
    Public Property Impression() As String
        Get
            Return mimpression
        End Get
        Set(ByVal value As String)
            mimpression = value
        End Set
    End Property
    Public Property DateOfQuickening() As DateTime
        Get
            Return mdateofquickening
        End Get
        Set(ByVal value As DateTime)
            mdateofquickening = value
        End Set
    End Property
    Public Property UltrasoundAOG() As String
        Get
            Return multrasoundAOG
        End Get
        Set(ByVal value As String)
            multrasoundAOG = value
        End Set
    End Property
    Public Property AdjustedEDC() As String
        Get
            Return madjustedEDC
        End Get
        Set(ByVal value As String)
            madjustedEDC = value
        End Set
    End Property
    Public Property UltrasoundDate() As DateTime
        Get
            Return multrasounddate
        End Get
        Set(ByVal value As DateTime)
            multrasounddate = value
        End Set
    End Property
    Public Property PrenatalVisits() As Char
        Get
            Return mprenatalvisits
        End Get
        Set(ByVal value As Char)
            mprenatalvisits = value
        End Set
    End Property
    Public Property ContraceptivesHistory() As String
        Get
            Return mContraceptivesHistory
        End Get
        Set(ByVal value As String)
            mContraceptivesHistory = value
        End Set
    End Property
    Public Property HealthCareProvider() As String
        Get
            Return mhealthcareprovider
        End Get
        Set(ByVal value As String)
            mhealthcareprovider = value
        End Set
    End Property
    Public Property ImmunizationsTetanus() As Boolean
        Get
            Return mimmunizationstetanus
        End Get
        Set(ByVal value As Boolean)
            mimmunizationstetanus = value
        End Set
    End Property
    Public Property ImmunizationsTetanusDoses() As String
        Get
            Return mimmunizationstetanusdoses
        End Get
        Set(ByVal value As String)
            mimmunizationstetanusdoses = value
        End Set
    End Property
    Public Property ImmunizationsTetanusDate() As DateTime
        Get
            Return mimmunizationstetanusdate
        End Get
        Set(ByVal value As DateTime)
            mimmunizationstetanusdate = value
        End Set
    End Property
    Public Property ImmunizationsHepatitisB() As Boolean
        Get
            Return mimmunizationshepatitisb
        End Get
        Set(ByVal value As Boolean)
            mimmunizationshepatitisb = value
        End Set
    End Property
    Public Property ImmunizationsOthers() As String
        Get
            Return mimmunizationsothers
        End Get
        Set(ByVal value As String)
            mimmunizationsothers = value
        End Set
    End Property
    Public Property TotalGainWeight() As String
        Get
            Return mtotalgainweight
        End Get
        Set(ByVal value As String)
            mtotalgainweight = value
        End Set
    End Property
    Public Property HB() As String
        Get
            Return mhb
        End Get
        Set(ByVal value As String)
            mhb = value
        End Set
    End Property
    Public Property UrineALB() As String
        Get
            Return murinealb
        End Get
        Set(ByVal value As String)
            murinealb = value
        End Set
    End Property
    Public Property Sugar() As String
        Get
            Return msugar
        End Get
        Set(ByVal value As String)
            msugar = value
        End Set
    End Property
    Public Property AntenatalProblemsMB98ms() As Boolean
        Get
            Return mantenatalproblemsmb98ms
        End Get
        Set(ByVal value As Boolean)
            mantenatalproblemsmb98ms = value
        End Set
    End Property
    Public Property AntenatalProblemsPrevCSSurgery() As Boolean
        Get
            Return mantenatalproblemsprevcssurgery
        End Get
        Set(ByVal value As Boolean)
            mantenatalproblemsprevcssurgery = value
        End Set
    End Property
    Public Property AntenatalProblemsUTI() As Boolean
        Get
            Return mantenatalproblemsuti
        End Get
        Set(ByVal value As Boolean)
            mantenatalproblemsuti = value
        End Set
    End Property
    Public Property AntenatalProblemsInfectionTracts() As Boolean
        Get
            Return mantenatalproblemsinfectiontracts
        End Get
        Set(ByVal value As Boolean)
            mantenatalproblemsinfectiontracts = value
        End Set
    End Property
    Public Property AntenatalProblemsNutritional() As Boolean
        Get
            Return mantenatalproblemsnutritional
        End Get
        Set(ByVal value As Boolean)
            mantenatalproblemsnutritional = value
        End Set
    End Property
    Public Property AntenatalProblemsHPNPIDCHVD() As Boolean
        Get
            Return mantenatalproblemshpnpidchvd
        End Get
        Set(ByVal value As Boolean)
            mantenatalproblemshpnpidchvd = value
        End Set
    End Property
    Public Property AntenatalProblemsCardiac() As Boolean
        Get
            Return mantenatalproblemscardiac
        End Get
        Set(ByVal value As Boolean)
            mantenatalproblemscardiac = value
        End Set
    End Property
    Public Property AntenatalProblemsRenal() As Boolean
        Get
            Return mantenatalproblemsrenal
        End Get
        Set(ByVal value As Boolean)
            mantenatalproblemsrenal = value
        End Set
    End Property
    Public Property AntenatalProblemsPrematureLabor() As Boolean
        Get
            Return mantenatalproblemsprematurelabor
        End Get
        Set(ByVal value As Boolean)
            mantenatalproblemsprematurelabor = value
        End Set
    End Property
    Public Property AntenatalProblemsDMMetabolic() As Boolean
        Get
            Return mantenatalproblemsdmmetabolic
        End Get
        Set(ByVal value As Boolean)
            mantenatalproblemsdmmetabolic = value
        End Set
    End Property
    Public Property AntenatalProblemsRespiratory() As Boolean
        Get
            Return mantenatalproblemsrespiratory
        End Get
        Set(ByVal value As Boolean)
            mantenatalproblemsrespiratory = value
        End Set
    End Property
    Public Property AntenatalProblemsFetalWastage() As Boolean
        Get
            Return mantenatalproblemsfetalwastage
        End Get
        Set(ByVal value As Boolean)
            mantenatalproblemsfetalwastage = value
        End Set
    End Property
    Public Property AntenatalProblemsIUGR() As Boolean
        Get
            Return mantenatalproblemsiugr
        End Get
        Set(ByVal value As Boolean)
            mantenatalproblemsiugr = value
        End Set
    End Property
    Public Property AntenatalProblemsInfertility() As Boolean
        Get
            Return mantenatalproblemsinfertility
        End Get
        Set(ByVal value As Boolean)
            mantenatalproblemsinfertility = value
        End Set
    End Property
    Public Property AntenatalProblemsOthers() As Boolean
        Get
            Return mantenatalproblemsothers
        End Get
        Set(ByVal value As Boolean)
            mantenatalproblemsothers = value
        End Set
    End Property
    Public Property RiskStatus() As String
        Get
            Return mriskstatus
        End Get
        Set(ByVal value As String)
            mriskstatus = value
        End Set
    End Property
    Public Property PhysicalExamDate() As DateTime
        Get
            Return mphysicalexamdate
        End Get
        Set(ByVal value As DateTime)
            mphysicalexamdate = value
        End Set
    End Property
    Public Property PhysicalExaminer() As String
        Get
            Return mphysicalexaminer
        End Get
        Set(ByVal value As String)
            mphysicalexaminer = value
        End Set
    End Property
    Public Property PhysicalExamGeneralStatus() As String
        Get
            Return mphysicalexamgeneralstatus
        End Get
        Set(ByVal value As String)
            mphysicalexamgeneralstatus = value
        End Set
    End Property
    Public Property LevelofSensorium() As String
        Get
            Return mlevelofsensorium
        End Get
        Set(ByVal value As String)
            mlevelofsensorium = value
        End Set
    End Property
    Public Property EENT() As String
        Get
            Return meent
        End Get
        Set(ByVal value As String)
            meent = value
        End Set
    End Property
    Public Property ChestHeart() As String
        Get
            Return mchestheart
        End Get
        Set(ByVal value As String)
            mchestheart = value
        End Set
    End Property
    Public Property ChestLungs() As String
        Get
            Return mchestlungs
        End Get
        Set(ByVal value As String)
            mchestlungs = value
        End Set
    End Property
    Public Property ChestBreast() As String
        Get
            Return mchestbreast
        End Get
        Set(ByVal value As String)
            mchestbreast = value
        End Set
    End Property
    Public Property AbdomenLSK() As String
        Get
            Return mabdomenlsk
        End Get
        Set(ByVal value As String)
            mabdomenlsk = value
        End Set
    End Property
    Public Property AbdomenFundicHeight() As String
        Get
            Return mabdomenfundicheight
        End Get
        Set(ByVal value As String)
            mabdomenfundicheight = value
        End Set
    End Property
    Public Property AbdomenPresentation() As String
        Get
            Return mabdomenpresentation
        End Get
        Set(ByVal value As String)
            mabdomenpresentation = value
        End Set
    End Property
    Public Property AbdomenFloatingEngaged() As String
        Get
            Return mabdomenfloatingengaged
        End Get
        Set(ByVal value As String)
            mabdomenfloatingengaged = value
        End Set
    End Property
    Public Property AbdomenOther() As String
        Get
            Return mabdomenother
        End Get
        Set(ByVal value As String)
            mabdomenother = value
        End Set
    End Property
    Public Property PelvicExamExternalGenitalia() As String
        Get
            Return mpelvicexamexternalgenitalia
        End Get
        Set(ByVal value As String)
            mpelvicexamexternalgenitalia = value
        End Set
    End Property
    Public Property PelvicExamUterus() As String
        Get
            Return mpelvicexamuterus
        End Get
        Set(ByVal value As String)
            mpelvicexamuterus = value
        End Set
    End Property
    Public Property PelvicExamVaginaCervixLength() As String
        Get
            Return mpelvicexamvaginacervixlength
        End Get
        Set(ByVal value As String)
            mpelvicexamvaginacervixlength = value
        End Set
    End Property
    Public Property PelvicExamPositionAnt() As String
        Get
            Return mpelvicexampositionant
        End Get
        Set(ByVal value As String)
            mpelvicexampositionant = value
        End Set
    End Property
    Public Property PelvicExamPositionMidLine() As String
        Get
            Return mpelvicexampositionmidline
        End Get
        Set(ByVal value As String)
            mpelvicexampositionmidline = value
        End Set
    End Property
    Public Property PelvicExamPositionPost() As String
        Get
            Return mpelvicexampositionpost
        End Get
        Set(ByVal value As String)
            mpelvicexampositionpost = value
        End Set
    End Property
    Public Property PresentationPosition() As String
        Get
            Return mpresentationposition
        End Get
        Set(ByVal value As String)
            mpresentationposition = value
        End Set
    End Property
    Public Property PresentationStation() As String
        Get
            Return mpresentationstation
        End Get
        Set(ByVal value As String)
            mpresentationstation = value
        End Set
    End Property
    Public Property PresentationAmnioticFld() As String
        Get
            Return mpresentationamnioticfld
        End Get
        Set(ByVal value As String)
            mpresentationamnioticfld = value
        End Set
    End Property
    Public Property PresentationMembranes() As String
        Get
            Return mpresentationmembranes
        End Get
        Set(ByVal value As String)
            mpresentationmembranes = value
        End Set
    End Property
    Public Property PresentationSutures() As String
        Get
            Return mpresentationsutures
        End Get
        Set(ByVal value As String)
            mpresentationsutures = value
        End Set
    End Property
    Public Property PelvimetryContracted() As Boolean
        Get
            Return mpelvimetrycontracted
        End Get
        Set(ByVal value As Boolean)
            mpelvimetrycontracted = value
        End Set
    End Property
    Public Property PelvimetryContractedInlet() As Boolean
        Get
            Return mpelvimetrycontractedinlet
        End Get
        Set(ByVal value As Boolean)
            mpelvimetrycontractedinlet = value
        End Set
    End Property
    Public Property PelvimetryContractedInletTxt() As String
        Get
            Return mpelvimetrycontractedinlettxt
        End Get
        Set(ByVal value As String)
            mpelvimetrycontractedinlettxt = value
        End Set
    End Property
    Public Property PelvimetryContractedMidLine() As Boolean
        Get
            Return mpelvimetrycontractedmidline
        End Get
        Set(ByVal value As Boolean)
            mpelvimetrycontractedmidline = value
        End Set
    End Property
    Public Property PelvimetryContractedMidLineTxt() As String
        Get
            Return mpelvimetrycontractedmidlinetxt
        End Get
        Set(ByVal value As String)
            mpelvimetrycontractedmidlinetxt = value
        End Set
    End Property
    Public Property PelvimetryContractedOutlet() As Boolean
        Get
            Return mpelvimetrycontractedoutlet
        End Get
        Set(ByVal value As Boolean)
            mpelvimetrycontractedoutlet = value
        End Set
    End Property
    Public Property PelvimetryContractedOutletTxt() As String
        Get
            Return mpelvimetrycontractedoutlettxt
        End Get
        Set(ByVal value As String)
            mpelvimetrycontractedoutlettxt = value
        End Set
    End Property
    Public Property PelvimetryBorderLine() As Boolean
        Get
            Return mpelvimetryborderline
        End Get
        Set(ByVal value As Boolean)
            mpelvimetryborderline = value
        End Set
    End Property
    Public Property PelvimetryBorderLineTrialLabor() As Boolean
        Get
            Return mpelvimetryborderlinetriallabor
        End Get
        Set(ByVal value As Boolean)
            mpelvimetryborderlinetriallabor = value
        End Set
    End Property
    Public Property GeneralStatus() As String
        Get
            Return mgeneralstatus
        End Get
        Set(ByVal value As String)
            mgeneralstatus = value
        End Set
    End Property
    Public Property PelvimetryAdequate() As Boolean
        Get
            Return mpelvimetryadequate
        End Get
        Set(ByVal value As Boolean)
            mpelvimetryadequate = value
        End Set
    End Property
    Public Property Remarks() As String
        Get
            Return mremarks
        End Get
        Set(ByVal value As String)
            mremarks = value
        End Set
    End Property
    Public Property PresentIllness() As String
        Get
            Return mpresentillness
        End Get
        Set(ByVal value As String)
            mpresentillness = value
        End Set
    End Property
    Public Property PrenatalInfection() As String
        Get
            Return mprenatalinfection
        End Get
        Set(ByVal value As String)
            mprenatalinfection = value
        End Set
    End Property
    Public Property PrenatalExposureToDrugs() As String
        Get
            Return mprenatalexposuretodrugs
        End Get
        Set(ByVal value As String)
            mprenatalexposuretodrugs = value
        End Set
    End Property
    Public Property PrenatalSmokingAlcohol() As String
        Get
            Return mprenatalsmokingalcohol
        End Get
        Set(ByVal value As String)
            mprenatalsmokingalcohol = value
        End Set
    End Property
    Public Property NatalTypeofDelivery() As String
        Get
            Return mnataltypeofdelivery
        End Get
        Set(ByVal value As String)
            mnataltypeofdelivery = value
        End Set
    End Property
    Public Property NatalNSD() As String
        Get
            Return mnatalnsd
        End Get
        Set(ByVal value As String)
            mnatalnsd = value
        End Set
    End Property
    Public Property NatalCS() As String
        Get
            Return mnatalcs
        End Get
        Set(ByVal value As String)
            mnatalcs = value
        End Set
    End Property
    Public Property NatalYO() As String
        Get
            Return mnatalyo
        End Get
        Set(ByVal value As String)
            mnatalyo = value
        End Set
    End Property
    Public Property NatalGestationalAge() As String
        Get
            Return mnatalgestationalage
        End Get
        Set(ByVal value As String)
            mnatalgestationalage = value
        End Set
    End Property
    Public Property NatalBodyWeight() As String
        Get
            Return mnatalbodyweight
        End Get
        Set(ByVal value As String)
            mnatalbodyweight = value
        End Set
    End Property
    Public Property NatalApgarScore() As String
        Get
            Return mnatalapgarscore
        End Get
        Set(ByVal value As String)
            mnatalapgarscore = value
        End Set
    End Property
    Public Property NatalAnomalies() As String
        Get
            Return mnatalanomalies
        End Get
        Set(ByVal value As String)
            mnatalanomalies = value
        End Set
    End Property
    Public Property NatalResuscitation() As String
        Get
            Return mnatalresuscitation
        End Get
        Set(ByVal value As String)
            mnatalresuscitation = value
        End Set
    End Property
    Public Property NatalComplication() As String
        Get
            Return mnatalcomplication
        End Get
        Set(ByVal value As String)
            mnatalcomplication = value
        End Set
    End Property
    Public Property FeedingHistoryBreastFeeding() As String
        Get
            Return mfeedinghistorybreastfeeding
        End Get
        Set(ByVal value As String)
            mfeedinghistorybreastfeeding = value
        End Set
    End Property
    Public Property FeedingHistoryMilkFormula() As String
        Get
            Return mfeedinghistorymilkformula
        End Get
        Set(ByVal value As String)
            mfeedinghistorymilkformula = value
        End Set
    End Property
    Public Property FeedingHistorySupplemental() As String
        Get
            Return mfeedinghistorysupplemental
        End Get
        Set(ByVal value As String)
            mfeedinghistorysupplemental = value
        End Set
    End Property
    Public Property FeedingHistoryAllergies() As String
        Get
            Return mfeedinghistoryallergies
        End Get
        Set(ByVal value As String)
            mfeedinghistoryallergies = value
        End Set
    End Property
    Public Property GrowthDevelopmentMotor() As String
        Get
            Return mgrowthdevelopmentmotor
        End Get
        Set(ByVal value As String)
            mgrowthdevelopmentmotor = value
        End Set
    End Property
    Public Property GrowthDevelopmentLanguage() As String
        Get
            Return mgrowthdevelopmentlanguage
        End Get
        Set(ByVal value As String)
            mgrowthdevelopmentlanguage = value
        End Set
    End Property
    Public Property GrowthDevelopmentToiletTraining() As String
        Get
            Return mgrowthdevelopmenttoilettraining
        End Get
        Set(ByVal value As String)
            mgrowthdevelopmenttoilettraining = value
        End Set
    End Property
    Public Property GrowthDevelopmentSchool() As String
        Get
            Return mgrowthdevelopmentschool
        End Get
        Set(ByVal value As String)
            mgrowthdevelopmentschool = value
        End Set
    End Property
    Public Property ImmunizationBCG() As String
        Get
            Return mimmunizationbcg
        End Get
        Set(ByVal value As String)
            mimmunizationbcg = value
        End Set
    End Property
    Public Property ImmunizationDPT() As String
        Get
            Return mimmunizationdpt
        End Get
        Set(ByVal value As String)
            mimmunizationdpt = value
        End Set
    End Property
    Public Property ImmunizationOPV() As String
        Get
            Return mimmunizationopv
        End Get
        Set(ByVal value As String)
            mimmunizationopv = value
        End Set
    End Property
    Public Property ImmunizationBoosterDoses() As String
        Get
            Return mimmunizationboosterdoses
        End Get
        Set(ByVal value As String)
            mimmunizationboosterdoses = value
        End Set
    End Property
    Public Property ImmunizationMeascles() As String
        Get
            Return mimmunizationmeascles
        End Get
        Set(ByVal value As String)
            mimmunizationmeascles = value
        End Set
    End Property
    Public Property ImmunizationHIB() As String
        Get
            Return mimmunizationhib
        End Get
        Set(ByVal value As String)
            mimmunizationhib = value
        End Set
    End Property
    Public Property ImmunizationHepatitis() As String
        Get
            Return mimmunizationhepatitis
        End Get
        Set(ByVal value As String)
            mimmunizationhepatitis = value
        End Set
    End Property
    Public Property GeneralAppearance() As String
        Get
            Return mgeneralappearance
        End Get
        Set(ByVal value As String)
            mgeneralappearance = value
        End Set
    End Property
    Public Property Sheent() As String
        Get
            Return msheent
        End Get
        Set(ByVal value As String)
            msheent = value
        End Set
    End Property
    Public Property CL() As String
        Get
            Return mcl
        End Get
        Set(ByVal value As String)
            mcl = value
        End Set
    End Property
    Public Property CVS() As String
        Get
            Return mcvs
        End Get
        Set(ByVal value As String)
            mcvs = value
        End Set
    End Property
    Public Property Abdomin() As String
        Get
            Return mabdomin
        End Get
        Set(ByVal value As String)
            mabdomin = value
        End Set
    End Property
    Public Property NeurologicExam() As String
        Get
            Return mneurologicexam
        End Get
        Set(ByVal value As String)
            mneurologicexam = value
        End Set
    End Property
    Public Property PregnancyOrder() As String
        Get
            Return mpregnancyorder
        End Get
        Set(ByVal value As String)
            mpregnancyorder = value
        End Set
    End Property
    Public Property PregnancyOutcome() As String
        Get
            Return mpregnancyoutcome
        End Get
        Set(ByVal value As String)
            mpregnancyoutcome = value
        End Set
    End Property
    Public Property GestationalCompleted() As String
        Get
            Return mgestationcompleted
        End Get
        Set(ByVal value As String)
            mgestationcompleted = value
        End Set
    End Property
    Public Property Birth() As String
        Get
            Return mbirth
        End Get
        Set(ByVal value As String)
            mbirth = value
        End Set
    End Property
    Public Property Present() As String
        Get
            Return mpresent
        End Get
        Set(ByVal value As String)
            mpresent = value
        End Set
    End Property
    Public Property ObgyneNo() As String
        Get
            Return mobgyneno
        End Get
        Set(ByVal value As String)
            mobgyneno = value
        End Set
    End Property
    Public Property ObgyneYear() As DateTime
        Get
            Return mobgyneyear
        End Get
        Set(ByVal value As DateTime)
            mobgyneyear = value
        End Set
    End Property
    Public Property ObgyneSex() As String
        Get
            Return mobgynesex
        End Get
        Set(ByVal value As String)
            mobgynesex = value
        End Set
    End Property
    Public Property ObgyneTypeofDelivery() As String
        Get
            Return mobgynetypeofdelivery
        End Get
        Set(ByVal value As String)
            mobgynetypeofdelivery = value
        End Set
    End Property
    Public Property ObgynePlaceofDelivery() As String
        Get
            Return mobgyneplaceofdelivery
        End Get
        Set(ByVal value As String)
            mobgyneplaceofdelivery = value
        End Set
    End Property
    Public Property ObgyneAttending() As String
        Get
            Return mobgyneattending
        End Get
        Set(ByVal value As String)
            mobgyneattending = value
        End Set
    End Property
    Public Property ObgyneBW() As String
        Get
            Return mobgynebw
        End Get
        Set(ByVal value As String)
            mobgynebw = value
        End Set
    End Property
    Public Property ObgyneComplications() As String
        Get
            Return mobgynecomplications
        End Get
        Set(ByVal value As String)
            mobgynecomplications = value
        End Set
    End Property
    Public Property MenstrualCycle1() As String
        Get
            Return mMenstrualCycle1
        End Get
        Set(ByVal value As String)
            mMenstrualCycle1 = value
        End Set
    End Property
    Public Property MenstrualCycle2() As String
        Get
            Return mMenstrualCycle2
        End Get
        Set(ByVal value As String)
            mMenstrualCycle2 = value
        End Set
    End Property
    Public Property MenstrualCycle3() As String
        Get
            Return mMenstrualCycle3
        End Get
        Set(ByVal value As String)
            mMenstrualCycle3 = value
        End Set
    End Property
    Public Property PogsGravida() As Integer
        Get
            Return mPogsGravida
        End Get
        Set(ByVal value As Integer)
            mPogsGravida = value
        End Set
    End Property
    Public Property Pogspara() As Integer
        Get
            Return mPogspara
        End Get
        Set(ByVal value As Integer)
            mPogspara = value
        End Set
    End Property
    Public Property Pogsabortion() As Integer
        Get
            Return mPogsabortion
        End Get
        Set(ByVal value As Integer)
            mPogsabortion = value
        End Set
    End Property
    Public Property Pogsterm() As Integer
        Get
            Return mPogsterm
        End Get
        Set(ByVal value As Integer)
            mPogsterm = value
        End Set
    End Property
    Public Property Pogspremature() As Integer
        Get
            Return mPogspremature
        End Get
        Set(ByVal value As Integer)
            mPogspremature = value
        End Set
    End Property
    Public Property Pogsline() As Integer
        Get
            Return mPogsline
        End Get
        Set(ByVal value As Integer)
            mPogsline = value
        End Set
    End Property
    Public Property PediaGravida() As Integer
        Get
            Return mPediaGravida
        End Get
        Set(ByVal value As Integer)
            mPediaGravida = value
        End Set
    End Property
    Public Property Pediapara() As Integer
        Get
            Return mPediapara
        End Get
        Set(ByVal value As Integer)
            mPediapara = value
        End Set
    End Property
    Public Property Pediaabortion() As Integer
        Get
            Return mPediaabortion
        End Get
        Set(ByVal value As Integer)
            mPediaabortion = value
        End Set
    End Property
    Public Property PogsDilatation() As String
        Get
            Return mpogsdilatation
        End Get
        Set(ByVal value As String)
            mpogsdilatation = value
        End Set
    End Property
    Public Property PogsEffacement() As String
        Get
            Return mpogseffacement
        End Get
        Set(ByVal value As String)
            mpogseffacement = value
        End Set
    End Property
    Public Property Pogsefw() As String
        Get
            Return mpogsefw
        End Get
        Set(ByVal value As String)
            mpogsefw = value
        End Set
    End Property
    Public Property Pogsfht() As String
        Get
            Return mpogsfht
        End Get
        Set(ByVal value As String)
            mpogsfht = value
        End Set
    End Property
    Public Property PogsExtremities() As String
        Get
            Return mPogsExtremities
        End Get
        Set(ByVal value As String)
            mPogsExtremities = value
        End Set
    End Property
    Public Property ObsPogID() As Integer
        Get
            Return mObspogid
        End Get
        Set(ByVal value As Integer)
            mObspogid = value
        End Set
    End Property
    Public Property PogsComplications() As String
        Get
            Return mpogscomplications
        End Get
        Set(ByVal value As String)
            mpogscomplications = value
        End Set
    End Property
    Public Property PogsYear() As DateTime
        Get
            Return mpogsyear
        End Get
        Set(ByVal value As DateTime)
            mpogsyear = value
        End Set
    End Property
    Public Property PogsSex() As String
        Get
            Return mpogssex
        End Get
        Set(ByVal value As String)
            mpogssex = value
        End Set
    End Property
    Public Property PhilRelationshiptoMember() As String
        Get
            Return mPhilRelationshiptoMember
        End Get
        Set(ByVal value As String)
            mPhilRelationshiptoMember = value
        End Set
    End Property
    Public Property PhilReferredFrom() As String
        Get
            Return mPhilReferredFrom
        End Get
        Set(ByVal value As String)
            mPhilReferredFrom = value
        End Set
    End Property
    Public Property PhilRepresentative() As String
        Get
            Return mPhilRepresentative
        End Get
        Set(ByVal value As String)
            mPhilRepresentative = value
        End Set
    End Property
    Public Property PhilRelationshiptoRep() As String
        Get
            Return mPhilRelationshiptoRep
        End Get
        Set(ByVal value As String)
            mPhilRelationshiptoRep = value
        End Set
    End Property
    Public Property PhilContactnoRep() As String
        Get
            Return mPhilContactnoRep
        End Get
        Set(ByVal value As String)
            mPhilContactnoRep = value
        End Set
    End Property
    Public Property PhilTypeofDelivery() As String
        Get
            Return mPhilTypeofDelivery
        End Get
        Set(ByVal value As String)
            mPhilTypeofDelivery = value
        End Set
    End Property
    Public Property PhilNurseonDuty() As String
        Get
            Return mPhilNurseonDuty
        End Get
        Set(ByVal value As String)
            mPhilNurseonDuty = value
        End Set
    End Property
    Public Property PhilWithMedPack() As Boolean
        Get
            Return mPhilWithMedPack
        End Get
        Set(ByVal value As Boolean)
            mPhilWithMedPack = value
        End Set
    End Property
    Public Property PhilRemarks() As String
        Get
            Return mPhilRemarks
        End Get
        Set(ByVal value As String)
            mPhilRemarks = value
        End Set
    End Property
    Public Property PhilisPhilhealthApprove() As Boolean
        Get
            Return mPhilisPhilhealthApprove
        End Get
        Set(ByVal value As Boolean)
            mPhilisPhilhealthApprove = value
        End Set
    End Property
    Public Property PhilHealthApprovalRemarks() As String
        Get
            Return mPhilHealthApprovalRemarks
        End Get
        Set(ByVal value As String)
            mPhilHealthApprovalRemarks = value
        End Set
    End Property
    '---------PhilHealth Properties
    Public Property PhilHealth() As String
        Get
            Return mPhilHealth
        End Get
        Set(ByVal value As String)
            mPhilHealth = value
        End Set
    End Property
    Public Property PhilLastName() As String
        Get
            Return mPhilLastName
        End Get
        Set(ByVal value As String)
            mPhilLastName = value
        End Set
    End Property
    Public Property PhilFirstName() As String
        Get
            Return mPhilFirstName
        End Get
        Set(ByVal value As String)
            mPhilFirstName = value
        End Set
    End Property
    Public Property PhilMiddleName() As String
        Get
            Return mPhilMiddleName
        End Get
        Set(ByVal value As String)
            mPhilMiddleName = value
        End Set
    End Property
    Public Property PhilMembershipCatCode() As Integer
        Get
            Return mPhilMembershipCatCode
        End Get
        Set(ByVal value As Integer)
            mPhilMembershipCatCode = value
        End Set
    End Property
    Public Property PhilAvailmentType() As Char
        Get
            Return mPhilAvailmentType
        End Get
        Set(ByVal value As Char)
            mPhilAvailmentType = value
        End Set
    End Property
    Public Property PhilHouseNo() As String
        Get
            Return mPhilHouseNo
        End Get
        Set(ByVal value As String)
            mPhilHouseNo = value
        End Set
    End Property
    Public Property PhilBarangay() As Char
        Get
            Return mPhilBarangay
        End Get
        Set(ByVal value As Char)
            mPhilBarangay = value
        End Set
    End Property
    Public Property PhilCityMunicipality() As String
        Get
            Return mPhilCityMunicipality
        End Get
        Set(ByVal value As String)
            mPhilCityMunicipality = value
        End Set
    End Property
    Public Property PhilProvince() As String
        Get
            Return mPhilProvince
        End Get
        Set(ByVal value As String)
            mPhilProvince = value
        End Set
    End Property
    Public Property PhilZipCode() As String
        Get
            Return mPhilZipCode
        End Get
        Set(ByVal value As String)
            mPhilZipCode = value
        End Set
    End Property
    Public Property PhilDateofBirth() As DateTime
        Get
            Return mPhilDateofBirth
        End Get
        Set(ByVal value As DateTime)
            mPhilDateofBirth = value
        End Set
    End Property
    Public Property PhilEmailAdd() As String
        Get
            Return mPhilEmailAdd
        End Get
        Set(ByVal value As String)
            mPhilEmailAdd = value
        End Set
    End Property
    Public Property PhilMobileNo() As String
        Get
            Return mPhilMobileNo
        End Get
        Set(ByVal value As String)
            mPhilMobileNo = value
        End Set
    End Property
    Public Property PhilLandLineNo() As String
        Get
            Return mPhilLandLineNo
        End Get
        Set(ByVal value As String)
            mPhilLandLineNo = value
        End Set
    End Property
    Public Property PhilEmpNo() As String
        Get
            Return mPhilEmpNo
        End Get
        Set(ByVal value As String)
            mPhilEmpNo = value
        End Set
    End Property
    Public Property PhilEmpContactNo() As String
        Get
            Return mPhilEmpContactNo
        End Get
        Set(ByVal value As String)
            mPhilEmpContactNo = value
        End Set
    End Property
    Public Property PhilEmpBusName() As String
        Get
            Return mPhilEmpBusName
        End Get
        Set(ByVal value As String)
            mPhilEmpBusName = value
        End Set
    End Property
    Public Property PhilEmpBldgNo() As String
        Get
            Return mPhilEmpBldgNo
        End Get
        Set(ByVal value As String)
            mPhilEmpBldgNo = value
        End Set
    End Property
    Public Property PhilEmpCityMunicipality() As String
        Get
            Return mPhilEmpCityMunicipality
        End Get
        Set(ByVal value As String)
            mPhilEmpCityMunicipality = value
        End Set
    End Property
    Public Property PhilEmpProvince() As String
        Get
            Return mPhilEmpProvince
        End Get
        Set(ByVal value As String)
            mPhilEmpProvince = value
        End Set
    End Property
    Public Property PhilEmpZipCode() As String
        Get
            Return mPhilEmpZipCode
        End Get
        Set(ByVal value As String)
            mPhilEmpZipCode = value
        End Set
    End Property
    Public Property isAdmitPatient() As Boolean
        Get
            Return misAdmitPatient
        End Get
        Set(ByVal value As Boolean)
            misAdmitPatient = value
        End Set
    End Property
#End Region

#Region "Methods"
    Public Shared Function genericcls(ByVal sop As Integer, Optional ByVal patno As String = "", Optional ByVal madmissiontype As String = "") As DataTable
        Dim strPar() As String = {"operation", "sOperation", "search", "admissiontype"}
        Dim strVal() As String = {0, sop, patno, madmissiontype}
        Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    End Function
    Public Function IsExist(ByVal mPatID As Integer, Optional ByRef mAdmissionType As String = "") As Boolean
        Dim dt As New DataTable
        Dim par() As String = {"operation", "sOperation", "PatientID"}
        Dim parVal() As String = {0, 0, mPatID}
        dt = GenericDA.ManageQuery(par, parVal, "spAdmissionDetails", 0)
        Return CBool(dt.Rows(0).Item("isExist").ToString)
    End Function
    Public Function PatientInfor(ByRef sop As Integer, Optional ByVal search As String = "", Optional ByVal vactive As Boolean = False) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "search", "isactive", "isnewborn", "isexpired"}
        Dim strVal() As Object = {0, sop, search, vactive, isnewborn, isexpired}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spAdmissionDetails", 0)
    End Function
    Public Shared Function GetAllRecord(ByVal SearchValue As String) As DataTable
        Dim arrFieldName() As String = {"Operation", "sOperation", "Search"}
        Dim arrFieldValue() As String = {0, 2, SearchValue}
        Return GenericDA.ManageQuery(arrFieldName, arrFieldValue, "spAdmissionDetails", "0")
    End Function
    Public Shared Function getDoctors(ByVal mEmployeeID As String) As DataTable
        Dim strPar() As String = {"operation", "soperation", "EmployeeID"}
        Dim strVal() As String = {0, 3, mEmployeeID}
        Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    End Function
    Public Shared Function getRoom(ByVal vroomid As Integer) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "Search"}
        Dim strVal() As String = {0, 4, vroomid}
        Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    End Function
    Public Shared Function getRooms(ByVal search As String, Optional ByVal misAvailable As Boolean = True) As DataTable    '-------Load Record to Search Engine
        Dim strPar() As String = {"operation", "sOperation", "Search", "isAvailable"}
        Dim strVal() As String = {0, 5, search, misAvailable}
        Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    End Function
    'Public Shared Function loadAdmission(ByVal mAdmissionID As String) As DataTable
    '    Dim strPar() As String = {"operation", "sOperation", "AdmissionID"}
    '    Dim strVal() As String = {0, 9, mAdmissionID}
    '    Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    'End Function
    Public Shared Function getPatientBalance(ByVal vPatientID As Long) As Double
        Dim strPar() As String = {"operation", "soperation", "PatientID"}
        Dim strVal() As String = {0, 26, vPatientID}
        Dim dt As DataTable = GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
        Return dt.Rows(0).Item("Balance")
    End Function
    Public Shared Function getPatientDetails(Optional ByVal mPatID As Long = 0) As DataTable
        Dim strPar() As String = {"operation", "soperation", "PatientID"}
        Dim strVal() As String = {0, 6, mPatID}
        Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    End Function
    Public Shared Function getAdmissionId(ByVal mPtNo As String, Optional ByVal vadmissiontype As String = "") As DataTable
        If vadmissiontype = "Inpatients" Then
            vadmissiontype = "IPD"
        ElseIf vadmissiontype = "Outpatients" Then
            vadmissiontype = "OPD"
        ElseIf vadmissiontype = "Emergency" Then
            vadmissiontype = "ER"
        End If
        Dim strPar() As String = {"operation", "sOperation", "ptno", "admissiontype"}
        Dim strVal() As String = {0, 7, mPtNo, vadmissiontype}
        Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    End Function
    Public Shared Function getPatientId(ByVal vAdmissionID As Long) As Long
        Dim strPar() As String = {"operation", "sOperation", "AdmissionID"}
        Dim strVal() As String = {0, 25, vAdmissionID}
        Dim dt As DataTable = GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
        Return dt.Rows(0).Item("patientid")
    End Function
    Public Shared Function getAdmissionInfo(ByVal strSearch As String, Optional ByVal vAdmissionType As String = " ", Optional ByVal vAdmissionStatus As Integer = 0) As DataTable
        'Dim xOperation As Integer
        Select Case vAdmissionType
            Case "Inpatients", "NursingServices"
                vAdmissionType = "IPD"
            Case "Outpatients"
                vAdmissionType = "OPD"
                'xOperation = 1
                'If vAdmissionStatus = 1 Then
                '    vAdmissionStatus = 2
                'End If
            Case "Emergency"
                vAdmissionType = "ER"
                'If vAdmissionStatus = 1 Then   ---REMOVE 10/11/2013
                '    vAdmissionStatus = 1
                'End If
        End Select
        Dim strPar() As String = {"operation", "sOperation", "Search", "AdmissionType", "AdmissionStatus"}
        Dim strVal() As String = {0, 8, strSearch, vAdmissionType, vAdmissionStatus}
        Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    End Function
    Public Shared Function loadAdmission(ByVal mAdmissionID As String) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "AdmissionID"}
        Dim strVal() As String = {0, 9, mAdmissionID}
        Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    End Function
    Public Shared Function loadtoGrid(ByVal mPtNo As String) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "PtNo"}
        Dim strVal() As String = {0, 10, mPtNo}
        Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    End Function
    Public Function isExist() As Boolean
        Dim dt As New DataTable
        Dim par() As String = {"operation", "sOperation", "ptno", "obspogid"}
        Dim parVal() As String = {0, 11, Me.PtNo, Me.ObsPogID}
        dt = GenericDA.ManageQuery(par, parVal, "spAdmissionDetails", 0)
        Return CBool(dt.Rows(0).Item("isExist").ToString)
    End Function
    Public Shared Function getDocRoom() As DataTable
        Dim strPar() As String = {"operation", "soperation"}
        Dim strVal() As String = {0, 14}
        Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    End Function
    Public Shared Function getadmissionid() As DataTable
        Dim strPar() As String = {"operation", "soperation"}
        Dim strVal() As String = {0, 27}
        Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    End Function
    Public Function GetAdmissionRecord(Optional ByVal mSearch As String = "", Optional ByVal visActive As Integer = 0) As DataTable
        If visActive = 0 Then
            visActive = 1
        Else
            visActive = 0
        End If
        Dim strPar() As String = {"operation", "sOperation", "SearchValue", "isActive", "isnewborn", "isexpired"}
        Dim strVal() As String = {0, 15, mSearch, visActive, isnewborn, isexpired}
        Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    End Function
    Public Sub DelPtNo(ByVal mPtNo As String, Optional ByVal mNo As String = "", Optional ByVal mPregnancyOrder As String = "")
        Dim strPar() As String = {"operation", "sOperation", "PtNo", "ObgyneNo", "PregnancyOrder"}
        Dim strVal() As String = {0, 16, mPtNo, mNo, mPregnancyOrder}
        GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    End Sub
    Public Shared Function getNursesonDuty() As DataTable
        Dim strPar() As String = {"operation", "sOperation"}
        Dim strVal() As String = {0, 17}
        Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    End Function
    Public Shared Function GetPhilHealthMembers(ByVal vSearch As String) As DataTable
        Dim arrFieldName() As String = {"Operation", "sOperation", "search"}
        Dim arrFieldValue() As String = {0, 18, vSearch}
        Return GenericDA.ManageQuery(arrFieldName, arrFieldValue, "spAdmissionDetails", "0")
    End Function
    Public Shared Function getDepartment() As DataTable
        Dim strPar() As String = {"operation", "sOperation"}
        Dim strVal() As String = {0, 19}
        Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    End Function
    Public Function isTagtoDischarge(ByVal vAdmissionID As String, Optional ByVal vAdmissionStatus As Integer = 0) As Boolean
        Dim dt As New DataTable
        Dim par() As String = {"operation", "sOperation", "AdmissionID", "AdmissionStatus"}
        Dim parVal() As String = {0, 20, vAdmissionID, vAdmissionStatus}
        dt = GenericDA.ManageQuery(par, parVal, "spAdmissionDetails", 0)
        Return CBool(dt.Rows(0).Item("isTagtoMGH").ToString)
    End Function
    Public Function isTagtoMGH(ByVal vAdmissionID As String) As Boolean
        Dim dt As New DataTable
        Dim par() As String = {"operation", "sOperation", "AdmissionID"}
        Dim parVal() As String = {0, 21, vAdmissionID}
        dt = GenericDA.ManageQuery(par, parVal, "spAdmissionDetails", 0)
        Return CBool(dt.Rows(0).Item("isTagtoMGH").ToString)
    End Function
    Public Shared Function getRefferalNo() As DataTable
        Dim strPar() As String = {"operation", "sOperation"}
        Dim strVal() As String = {0, 22}
        Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    End Function
    Public Function isPtNoExist(ByVal mPtNo As Integer, Optional ByVal vadmissiontype As String = "") As Boolean
        Dim dt As New DataTable
        Dim par() As String = {"operation", "sOperation", "PtNo", "admissiontype"}
        Dim parVal() As String = {0, 23, mPtNo, vadmissiontype}
        dt = GenericDA.ManageQuery(par, parVal, "spAdmissionDetails", 0)
        Return CBool(dt.Rows(0).Item("isPtNo").ToString)
    End Function
    Public Function isAdmissionIDExist(ByVal mAdmissionID As Integer) As Boolean
        Dim dt As New DataTable
        Dim par() As String = {"operation", "sOperation", "AdmissionID"}
        Dim parVal() As String = {0, 24, mAdmissionID}
        dt = GenericDA.ManageQuery(par, parVal, "spAdmissionDetails", 0)
        Return CBool(dt.Rows(0).Item("pvAdmissionID").ToString)
    End Function
    Public Shared Function gethospptno(Optional ByVal madmissiontype As String = "") As DataTable
        If madmissiontype = "Inpatients" Or madmissiontype = "Inpatient" Or madmissiontype = "IPD" Then
            madmissiontype = "ptnoIPD"
        ElseIf madmissiontype = "Outpatients" Or madmissiontype = "Outpatient" Or madmissiontype = "OPD" Then
            madmissiontype = "ptnoOPD"
        ElseIf madmissiontype = "Emergency" Or madmissiontype = "ER" Then
            madmissiontype = "ptnoER"
        Else
            madmissiontype = "hospno"
        End If

        Dim strPar() As String = {"operation", "soperation", "admissiontype"}
        Dim strVal() As String = {0, 28, madmissiontype}
        Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    End Function
    Public Function updateptno(ByVal madmissiontype As String)
        If madmissiontype = "Inpatients" Or madmissiontype = "Inpatient" Or madmissiontype = "IPD" Then
            madmissiontype = "ptnoIPD"
        End If
        Dim strPar() As String = {"operation", "admissiontype", "NewPK"}
        Dim strVal() As String = {11, madmissiontype, 1}
        Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 2)
    End Function
    Public Shared Function getNursingServices(ByVal strSearch As String, Optional ByVal vAdmissionStatus As Integer = 0, Optional ByVal vofficecode As String = "") As DataTable

        Dim strPar() As String = {"operation", "sOperation", "Search", "AdmissionStatus", "Officecode"}
        Dim strVal() As String = {0, 29, strSearch, vAdmissionStatus, vofficecode}
        Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    End Function
    Public Shared Function getofficecode(ByVal vemployeeid As String) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "EmployeeID"}
        Dim strVal() As String = {0, 30, vemployeeid}
        Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    End Function
    Public Shared Function getEncoderName(ByVal vEmployeeid As String) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "EmployeeID"}
        Dim strVal() As String = {0, 31, vEmployeeid}
        Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    End Function

    Public Shared Function getAdmissionRecordDetails(ByVal admissionid As String) As DataTable
        Dim strPar() As String = {"operation", "sOperation", "search"}
        Dim strVal() As String = {0, 35, admissionid}
        Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    End Function


    Public Function Save(ByVal isNew As Boolean, Optional ByVal mPatType As String = "") As Long
        If isNew Then
            operation = 1
        Else
            operation = 2
        End If
        Dim strPar() As String = {"Operation", "sOperation", "CaseNo", "isAdmitPatient", "AdmissionId", "HospitalNo", "PatientId", "PtNo", "AdmissionType", "AdmissionStatus", _
                                  "DateAdmitted", "RoomId", "OldRoomID", "admittingphysicianid", "oldAdmittinghysicianid", "attendingphysicianid", "oldattendingphysicianid", _
                                  "Notify", "NotifyRelationship", "NotifyAddress", "NotifyTelNo", _
                                  "Informant", "InformantRelationship", "Deposit", "KindOfOperation", _
                                  "MemberPHID", "AccreditationNo", "CaseType", "FinalDiagnosis", "AdmittingDiagnosis", "packagecaseno", _
                                  "Historyofpresentillness", "PhysicalExamination", "Courseinthewards", "PLPDF", "ConditiononDischarge", _
                                  "SODatetime", "soanethesiatype", "SOSurgeonName", "SOAnesthesiologist", "Reference", "isDischarge", _
                                  "HospitalPlan", "PhilhealthCaseType", "EncodedBy", "DateEncoded", "RoomRate", "DCharge", "StartDAte", "dateended", "reasonforadmission", _
                                  "admittingimpression", "familyhistory", "pasthistory", "pastillness", "chiefcomplaints", "abloodpressure", "adiastolic", "abreathing", "apulse", _
                                  "atemperature", "aheight", "aweight", "aheent", "achest", "aCVS", "aAbdomen", "askinextremities", "aneuroexamination", "agu", "documentno", _
                                  "gravida", "para", "abortion", "term", "premature", "line", "previousmenstrualperiod", "pmpdurationcharacter", "lastmenstrualperiod", _
                                  "lmpdurationcharacter", "estimateddateofconfinement", "ageofgestation", "menarche", "interval", "duration", _
                                  "amount", "contraception", "dysmenorrhea", "prenatalcoursepvtmd", "prenatalcoursedhiopd", "prenatalcoursehealthctr", _
                                  "midwife", "hilot", "none", "freqofcheckupdoneby", "bp", "complications", "prenatalmedstaken", "childhooddiseases", "previoushospitalizations", _
                                  "previousoperations", "medicalillness", "allergies", "medications", "familyhistorydm", "familyhistoryhpn", "familyhistoryheartdse", "familyhistoryptb", "familyhistoryca", "familyhistoryothers", _
                                  "rr", "ht", "cr", "t", "wt", "headneck", "heart", "breasts", "lungs", "abdomenfh", "abdomenefw", "abdomenfht", "abdomenfhtcharacter", "abdomenfhtlocation", "extremeties", _
                                  "ieby", "neurologicposition", "dilatation", "effacement", "station", "bow", "bowleakingsince", "prespart", "characterofdischargemucoid", "characterofdischargebloody", _
                                  "characterofdischargewatery", "characterofdischargecolor", "characterofdischargeodor", "speculumexam", "abnormalities", _
                                  "clinicalpelvimetryischialspines", "clinicalpelvimetrysidewalls", "clinicalpelvimetrypubicarch", "clinicalpelvimetrysacrumcontour", _
                                  "clinicalpelvimetrysacrosciaticnotch", "clinicalpelvimetryischialtuberosities", "epcadequate", "epcborderline", "epcnarrow", _
                                  "impression", "dateofquickening", "ultrasoundAOG", "adjustedEDC", "ultrasounddate", "prenatalvisits", "contraceptiveshistory", _
                                  "healthcareprovider", "immunizationstetanus", "immunizationstetanusdoses", "immunizationstetanusdate", "immunizationshepatitisb", _
                                  "immunizationsothers", "totalgainweight", "hb", "urinealb", "sugar", "antenatalproblemsmb98ms", "antenatalproblemsprevcssurgery", _
                                  "antenatalproblemsuti", "antenatalproblemsinfectiontracts", "antenatalproblemsnutritional", "antenatalproblemshpnpidchvd", _
                                  "antenatalproblemscardiac", "antenatalproblemsrenal", "antenatalproblemsdmmetabolic", "antenatalproblemsrespiratory", _
                                  "antenatalproblemsfetalwastage", "antenatalproblemsprematurelabor", "antenatalproblemsiugr", "antenatalproblemsinfertility", _
                                  "antenatalproblemsothers", "riskstatus", "physicalexamdate", "physicalexaminer", "physicalexamgeneralstatus", "levelofsensorium", _
                                  "eent", "chestheart", "chestlungs", "chestbreast", "abdomenlsk", "abdomenfundicheight", "abdomenpresentation", "abdomenfloatingengaged", _
                                  "abdomenother", "pelvicexamexternalgenitalia", "pelvicexamuterus", "pelvicexamvaginacervixlength", "pelvicexampositionant", _
                                  "pelvicexampositionmidline", "pelvicexampositionpost", "presentationposition", "presentationstation", "presentationmembranes", _
                                  "presentationamnioticfld", "presentationsutures", "pelvimetrycontracted", "pelvimetrycontractedinlet", _
                                  "pelvimetrycontractedinlettxt", "pelvimetrycontractedmidline", "pelvimetrycontractedmidlinetxt", "pelvimetrycontractedoutlet", _
                                  "pelvimetrycontractedoutlettxt", "pelvimetryborderline", "pelvimetryborderlinetriallabor", "generalstatus", _
                                  "pelvimetryadequate", "remarks", "presentillness", "prenatalinfection", "prenatalexposuretodrugs", _
                                  "prenatalsmokingalcohol", "nataltypeofdelivery", "natalnsd", "natalcs", "natalyo", "natalgestationalage", "natalbodyweight", _
                                  "natalapgarscore", "natalanomalies", "natalresuscitation", "natalcomplication", "feedinghistorybreastfeeding", _
                                  "feedinghistorymilkformula", "feedinghistorysupplemental", "feedinghistoryallergies", "growthdevelopmentmotor", _
                                  "growthdevelopmentlanguage", "growthdevelopmenttoilettraining", "growthdevelopmentschool", "immunizationbcg", _
                                  "immunizationdpt", "immunizationopv", "immunizationboosterdoses", "immunizationmeascles", "immunizationhib", _
                                  "immunizationhepatitis", "generalappearance", "sheent", "cl", "cvs", "abdomin", "neurologicexam", _
                                  "MenstrualCycle1", "MenstrualCycle2", "MenstrualCycle3", "pogsgravida", "pogspara", "pogsabortion", "pogsterm", "pogspremature", "pogsline", _
                                  "pediagravida", "pediapara", "pediaabortion", "pogsdilatation", "pogseffacement", "pogsfht", "pogsefw", "PogsExtremities", _
                                   "Officecode", "mghdate", "isAvailable", "NoOfDays", "Charge", "referralID", "alteredmentalsensorium", "abdominalcramp_pain",
                                  "anorexia", "bleedinggums", "bodyweakness", "blurringofvision", "constipation", "chestpain_discomfort", "cough_dry",
                                  "cough_productive", "diarrhea", "dizziness", "dysphagia", "dyspnea", "dysuria", "epistaxis", "fever", "frequencyofurination",
                                  "headache", "hematemesis", "hematuria", "hemoptysis", "increaseirritability", "jaundice", "lowerextremityedema", "myalgia",
                                  "orthopnea", "palpitations", "skinrashes", "stool_bloody_blacktarry_mucoid",
                                  "sweating", "seizures", "urgency", "vomiting", "weightloss", "others", "pain",
                                  "survey_awakeandalert", "survey_alteredsensorium", "heent_essentiallynormal", "heent_abnormalpupillaryreaction",
                                  "heent_cervicallympadenopathy", "heent_drymucousmembrane", "heent_ictericsclerae", "heent_paleconjunctivae",
                                  "heent_sunkeneyeballs", "heent_sunkenfontanelle", "chest_essentiallynormal", "chest_asymmetricalexpansion",
                                  "chest_decreasedbreathsounds", "chest_wheezes", "chest_lumpsoverbreast", "chest_ralescracklesrhonchi",
                                  "chest_intercostalribretraction", "cvs_essentiallynormal", "cvs_displacedapexbeat", "cvs_heaves",
                                  "cvs_irregularrhythm", "cvs_muffledheartsounds", "cvs_murmur", "cvs_pericardialbulge",
                                  "abdomen_essentiallynormal", "abdomen_abdominalrigidity", "abdomen_abdominaltenderness", "abdomen_hyperactivebowelsounds",
                                  "abdomen_palpablemass", "abdomen_tympaniticdullabdomen", "abdomen_uterinecontraction", "gu_essentiallynormal",
                                  "gu_bloodstainedfinger", "gu_cervicaldilatation", "gu_presenceofabnormaldischarge", "skin_essentiallynormal",
                                  "skin_clubbing", "skin_coldclammy", "skin_cyanosis", "skin_edema", "skin_muscles", "skin_palenailbeds",
                                  "skin_poorskinturgor", "skin_rashespetechiae", "skin_weakpulses", "neuro_essentiallynormal",
                                  "neuro_abnormalgait", "neuro_abnormalposition", "neuro_abnormalsensation", "neuro_presenceofabnormalreflex",
                                  "neuro_pooralteredmemory", "neuro_poormuscletone", "neuro_poorcoordination", "referringreason", "interviewedbyid", "conditiononarrival", "NewPK"}
        Dim strVar() As Object = {operation, 0, CaseNo, isAdmitPatient, Admissionid, HospitalNo, PatientID, PtNo, AdmissionType, AdmissionStatus, DateofAdmin, _
                                  RoomID, OldRoomID, AdmittingPhysician, OldAdmittingPhysician, AttendingPhysician, OldAttendingPhysician, Notify, NotifyRelationship, NotifyAddress, NotifyNo, _
                                  Informant, InformantRelationship, Deposit, KindOfOperation, _
                                  MemberPHID, AccreditationNo, CaseType, FinalDiagnosis, AdmittingDiagnosis, packagecaseno, _
                                  Historyofpresentillness, PhysicalExam, CourseInTheWards, PLPDF, ConditionOnDischarge, _
                                  SODateTime, SOAnesthesiaType, SOSurgeonName, SOAnesthesiologist, Reference, IsDischarge, _
                                  HospitalPlan, PhilHealthCaseType, EncodedBy, DateEncoded, RoomRate, PCharge, StartDAte, "1/1/1900", ReasonForAdmission, _
                                  AdmittingImpression, FamilyHistory, PastHistory, PastIllness, ChiefComplaints, aBloodPressure, aDiastolic, aBreathing, aPulse, _
                                  aTemp, aHeight, aWeight, aHeent, aChest, aCVs, aAbdomen, aSkinExtrem, aNeuro, aGU, DocumentNo, _
                                  Gravida, Para, Abortion, Term, Premature, Line, PreviousMenstrualPeriod, PMPDurationCharacter, LastmenstrualPeriod, _
                                  LmpDurationCharacter, EstimatedDateofConfinement, AgeofGestation, Menarche, Interval, Duration, _
                                  Amount, Contraception, Dysmenorrhea, PrenatalCoursePvtmd, PrenatalCourseDHIOPD, PrenatalCourseHealthCtr, _
                                  PrenatalCourseMidwife, PrenatalCourseHilot, PrenatalCourseNone, FreqofChekUpDoneBy, BP, Complications, PrenatalMedsTaken, ChildhoodDiseases, PrevHospitalizations, _
                                  PrevOperations, MedicalIllness, Allergies, Medications, FamilyHistoryDM, FamilyHistoryHPN, FamilyHistoryDse, FamilyHistoryPTB, FamilyHistoryCA, FamilyHistoryOthers, _
                                  RR, HT, CR, T, WT, HeadNeck, Heart, Breasts, Lungs, AbdomenFh, AbdomenEFW, AbdomenFHt, AbdomenFHtCharacter, AbdomenFHtLocation, Extremeties, _
                                  IEBy, NeurologicPosition, Dilatation, Effacement, Station, BOW, BOWLeakingSince, PresPart, CharacterofDischargeMucoid, CharacterofDischargeBloody, _
                                  CharacterofDischargeWatery, CharacterofDischargeColor, CharacterofDischargeOdor, SpeculumExam, Abnormalities, _
                                  ClinicalPelvimetryIschialSpines, ClinicalPelvimetrySideWalls, ClinicalPelvimetryPubicArch, ClinicalPelvimetrySacrumContour, _
                                  ClinicalPelvimetrySacrosciaticNotch, ClinicalPelvimetryIschialTuberosities, EPCAdequate, EPCBorderLine, EPCNarrow, _
                                  Impression, DateOfQuickening, UltrasoundAOG, AdjustedEDC, UltrasoundDate, PrenatalVisits, ContraceptivesHistory, _
                                  HealthCareProvider, ImmunizationsTetanus, ImmunizationsTetanusDoses, ImmunizationsTetanusDate, ImmunizationsHepatitisB, _
                                  ImmunizationsOthers, TotalGainWeight, HB, UrineALB, Sugar, AntenatalProblemsMB98ms, AntenatalProblemsPrevCSSurgery, _
                                  AntenatalProblemsUTI, AntenatalProblemsInfectionTracts, AntenatalProblemsNutritional, AntenatalProblemsHPNPIDCHVD, _
                                  AntenatalProblemsCardiac, AntenatalProblemsRenal, AntenatalProblemsDMMetabolic, AntenatalProblemsRespiratory, _
                                  AntenatalProblemsFetalWastage, AntenatalProblemsPrematureLabor, AntenatalProblemsIUGR, AntenatalProblemsInfertility, _
                                  AntenatalProblemsOthers, RiskStatus, "1/1/1900", PhysicalExaminer, PhysicalExamGeneralStatus, LevelofSensorium, _
                                  EENT, ChestHeart, ChestLungs, ChestBreast, AbdomenLSK, AbdomenFundicHeight, AbdomenPresentation, AbdomenFloatingEngaged, _
                                  AbdomenOther, PelvicExamExternalGenitalia, PelvicExamUterus, PelvicExamVaginaCervixLength, PelvicExamPositionAnt, _
                                  PelvicExamPositionMidLine, PelvicExamPositionPost, PresentationPosition, PresentationStation, PresentationMembranes, _
                                  PresentationAmnioticFld, PresentationSutures, PelvimetryContracted, PelvimetryContractedInlet, _
                                  PelvimetryContractedInletTxt, PelvimetryContractedMidLine, PelvimetryContractedMidLineTxt, PelvimetryContractedOutlet, _
                                  PelvimetryContractedOutletTxt, PelvimetryBorderLine, PelvimetryBorderLineTrialLabor, GeneralStatus, _
                                  PelvimetryAdequate, Remarks, PresentIllness, PrenatalInfection, PrenatalExposureToDrugs, _
                                  PrenatalSmokingAlcohol, NatalTypeofDelivery, NatalNSD, NatalCS, NatalYO, NatalGestationalAge, NatalBodyWeight, _
                                  NatalApgarScore, NatalAnomalies, NatalResuscitation, NatalComplication, FeedingHistoryBreastFeeding, _
                                  FeedingHistoryMilkFormula, FeedingHistorySupplemental, FeedingHistoryAllergies, GrowthDevelopmentMotor, _
                                  GrowthDevelopmentLanguage, GrowthDevelopmentToiletTraining, GrowthDevelopmentSchool, ImmunizationBCG, _
                                  ImmunizationDPT, ImmunizationOPV, ImmunizationBoosterDoses, ImmunizationMeascles, ImmunizationHIB, _
                                  ImmunizationHepatitis, GeneralAppearance, Sheent, CL, CVS, Abdomin, NeurologicExam, MenstrualCycle1, MenstrualCycle2, MenstrualCycle3, _
                                  PogsGravida, Pogspara, Pogsabortion, Pogsterm, Pogspremature, Pogsline, PediaGravida, Pediapara, Pediaabortion, _
                                  PogsDilatation, PogsEffacement, Pogsfht, Pogsefw, PogsExtremities, Me.Officecode, MGHDate, misAvailable, NoOfDays, PCharge, mreferringid,
                                  alteredmentalsensorium, abdominalcramp_pain, anorexia, bleedinggums, bodyweakness, blurringofvision,
                                  constipation, chestpain_discomfort, cough_dry, cough_productive, diarrhea, dizziness, dysphagia, dyspnea,
                                  dysuria, epistaxis, fever, frequencyofurination, headache, hematemesis, hematuria, hemoptysis,
                                  increaseirritability, jaundice, lowerextremityedema, myalgia, orthopnea, palpitations, skinrashes,
                                  stool_bloody_blacktarry_mucoid, sweating, seizures, urgency, vomiting, weightloss, others, pain,
                                  survey_awakeandalert, survey_alteredsensorium, heent_essentiallynormal, heent_abnormalpupillaryreaction,
                                  heent_cervicallympadenopathy, heent_drymucousmembrane, heent_ictericsclerae, heent_paleconjunctivae,
                                  heent_sunkeneyeballs, heent_sunkenfontanelle, chest_essentiallynormal, chest_asymmetricalexpansion,
                                  chest_decreasedbreathsounds, chest_wheezes, chest_lumpsoverbreast, chest_ralescracklesrhonchi,
                                  chest_intercostalribretraction, cvs_essentiallynormal, cvs_displacedapexbeat, cvs_heaves,
                                  cvs_irregularrhythm, cvs_muffledheartsounds, cvs_murmur, cvs_pericardialbulge,
                                  abdomen_essentiallynormal, abdomen_abdominalrigidity, abdomen_abdominaltenderness, abdomen_hyperactivebowelsounds,
                                  abdomen_palpablemass, abdomen_tympaniticdullabdomen, abdomen_uterinecontraction, gu_essentiallynormal,
                                  gu_bloodstainedfinger, gu_cervicaldilatation, gu_presenceofabnormaldischarge, skin_essentiallynormal,
                                  skin_clubbing, skin_coldclammy, skin_cyanosis, skin_edema, skin_muscles, skin_palenailbeds,
                                  skin_poorskinturgor, skin_rashespetechiae, skin_weakpulses, neuro_essentiallynormal,
                                  neuro_abnormalgait, neuro_abnormalposition, neuro_abnormalsensation, neuro_presenceofabnormalreflex,
                                  neuro_pooralteredmemory, neuro_poormuscletone, neuro_poorcoordination, referringreason, interviewedbyid, conditiononarrival, operation}
        Return GenericDA.ManageQuery(strPar, strVar, "spAdmissionDetails", 2)
    End Function
    Public Sub reSave()
        Dim strPar() As String = {"Operation", "AdmissionID", "AdmittingDiagnosis", "Historyofpresentillness", "PhysicalExamination", "reasonforadmission", _
                                  "admittingimpression", "familyhistory", "pasthistory", "pastillness", "chiefcomplaints", "abloodpressure", "adiastolic", "abreathing", "apulse", _
                                  "atemperature", "aheight", "aweight", "aheent", "achest", "aCVS", "aAbdomen", "askinextremities", "aneuroexamination", "agu", "documentno", _
                                  "gravida", "para", "abortion", "term", "premature", "line", "previousmenstrualperiod", "pmpdurationcharacter", "lastmenstrualperiod", _
                                  "lmpdurationcharacter", "estimateddateofconfinement", "ageofgestation", "menarche", "interval", "duration", _
                                  "amount", "contraception", "dysmenorrhea", "prenatalcoursepvtmd", "prenatalcoursedhiopd", "prenatalcoursehealthctr", _
                                  "midwife", "hilot", "none", "freqofcheckupdoneby", "bp", "complications", "prenatalmedstaken", "childhooddiseases", "previoushospitalizations", _
                                  "previousoperations", "medicalillness", "allergies", "medications", "familyhistorydm", "familyhistoryhpn", "familyhistoryheartdse", "familyhistoryptb", "familyhistoryca", "familyhistoryothers", _
                                  "rr", "ht", "cr", "t", "wt", "headneck", "heart", "breasts", "lungs", "abdomenfh", "abdomenefw", "abdomenfht", "abdomenfhtcharacter", "abdomenfhtlocation", "extremeties", _
                                  "ieby", "neurologicposition", "dilatation", "effacement", "station", "bow", "bowleakingsince", "prespart", "characterofdischargemucoid", "characterofdischargebloody", _
                                  "characterofdischargewatery", "characterofdischargecolor", "characterofdischargeodor", "speculumexam", "abnormalities", _
                                  "clinicalpelvimetryischialspines", "clinicalpelvimetrysidewalls", "clinicalpelvimetrypubicarch", "clinicalpelvimetrysacrumcontour", _
                                  "clinicalpelvimetrysacrosciaticnotch", "clinicalpelvimetryischialtuberosities", "epcadequate", "epcborderline", "epcnarrow", _
                                  "impression", "dateofquickening", "ultrasoundAOG", "adjustedEDC", "ultrasounddate", "prenatalvisits", "contraceptiveshistory", _
                                  "healthcareprovider", "immunizationstetanus", "immunizationstetanusdoses", "immunizationstetanusdate", "immunizationshepatitisb", _
                                  "immunizationsothers", "totalgainweight", "hb", "urinealb", "sugar", "antenatalproblemsmb98ms", "antenatalproblemsprevcssurgery", _
                                  "antenatalproblemsuti", "antenatalproblemsinfectiontracts", "antenatalproblemsnutritional", "antenatalproblemshpnpidchvd", _
                                  "antenatalproblemscardiac", "antenatalproblemsrenal", "antenatalproblemsdmmetabolic", "antenatalproblemsrespiratory", _
                                  "antenatalproblemsfetalwastage", "antenatalproblemsprematurelabor", "antenatalproblemsiugr", "antenatalproblemsinfertility", _
                                  "antenatalproblemsothers", "riskstatus", "physicalexamdate", "physicalexaminer", "physicalexamgeneralstatus", "levelofsensorium", _
                                  "eent", "chestheart", "chestlungs", "chestbreast", "abdomenlsk", "abdomenfundicheight", "abdomenpresentation", "abdomenfloatingengaged", _
                                  "abdomenother", "pelvicexamexternalgenitalia", "pelvicexamuterus", "pelvicexamvaginacervixlength", "pelvicexampositionant", _
                                  "pelvicexampositionmidline", "pelvicexampositionpost", "presentationposition", "presentationstation", "presentationmembranes", _
                                  "presentationamnioticfld", "presentationsutures", "pelvimetrycontracted", "pelvimetrycontractedinlet", _
                                  "pelvimetrycontractedinlettxt", "pelvimetrycontractedmidline", "pelvimetrycontractedmidlinetxt", "pelvimetrycontractedoutlet", _
                                  "pelvimetrycontractedoutlettxt", "pelvimetryborderline", "pelvimetryborderlinetriallabor", "generalstatus", _
                                  "pelvimetryadequate", "remarks", "presentillness", "prenatalinfection", "prenatalexposuretodrugs", _
                                  "prenatalsmokingalcohol", "nataltypeofdelivery", "natalnsd", "natalcs", "natalyo", "natalgestationalage", "natalbodyweight", _
                                  "natalapgarscore", "natalanomalies", "natalresuscitation", "natalcomplication", "feedinghistorybreastfeeding", _
                                  "feedinghistorymilkformula", "feedinghistorysupplemental", "feedinghistoryallergies", "growthdevelopmentmotor", _
                                  "growthdevelopmentlanguage", "growthdevelopmenttoilettraining", "growthdevelopmentschool", "immunizationbcg", _
                                  "immunizationdpt", "immunizationopv", "immunizationboosterdoses", "immunizationmeascles", "immunizationhib", _
                                  "immunizationhepatitis", "generalappearance", "sheent", "cl", "cvs", "abdomin", "neurologicexam", _
                                  "MenstrualCycle1", "MenstrualCycle2", "MenstrualCycle3", "pogsgravida", "pogspara", "pogsabortion", "pogsterm", "pogspremature", "pogsline", _
                                  "pediagravida", "pediapara", "pediaabortion", "pogsdilatation", "pogseffacement", "pogsfht", "pogsefw", "PogsExtremities", _
                                   "Officecode", "alteredmentalsensorium", "abdominalcramp_pain",
                                  "anorexia", "bleedinggums", "bodyweakness", "blurringofvision", "constipation", "chestpain_discomfort", "cough_dry",
                                  "cough_productive", "diarrhea", "dizziness", "dysphagia", "dyspnea", "dysuria", "epistaxis", "fever", "frequencyofurination",
                                  "headache", "hematemesis", "hematuria", "hemoptysis", "increaseirritability", "jaundice", "lowerextremityedema", "myalgia",
                                  "orthopnea", "palpitations", "skinrashes", "stool_bloody_blacktarry_mucoid",
                                  "sweating", "seizures", "urgency", "vomiting", "weightloss", "others", "pain",
                                  "survey_awakeandalert", "survey_alteredsensorium", "heent_essentiallynormal", "heent_abnormalpupillaryreaction",
                                  "heent_cervicallympadenopathy", "heent_drymucousmembrane", "heent_ictericsclerae", "heent_paleconjunctivae",
                                  "heent_sunkeneyeballs", "heent_sunkenfontanelle", "chest_essentiallynormal", "chest_asymmetricalexpansion",
                                  "chest_decreasedbreathsounds", "chest_wheezes", "chest_lumpsoverbreast", "chest_ralescracklesrhonchi",
                                  "chest_intercostalribretraction", "cvs_essentiallynormal", "cvs_displacedapexbeat", "cvs_heaves",
                                  "cvs_irregularrhythm", "cvs_muffledheartsounds", "cvs_murmur", "cvs_pericardialbulge",
                                  "abdomen_essentiallynormal", "abdomen_abdominalrigidity", "abdomen_abdominaltenderness", "abdomen_hyperactivebowelsounds",
                                  "abdomen_palpablemass", "abdomen_tympaniticdullabdomen", "abdomen_uterinecontraction", "gu_essentiallynormal",
                                  "gu_bloodstainedfinger", "gu_cervicaldilatation", "gu_presenceofabnormaldischarge", "skin_essentiallynormal",
                                  "skin_clubbing", "skin_coldclammy", "skin_cyanosis", "skin_edema", "skin_muscles", "skin_palenailbeds",
                                  "skin_poorskinturgor", "skin_rashespetechiae", "skin_weakpulses", "neuro_essentiallynormal",
                                  "neuro_abnormalgait", "neuro_abnormalposition", "neuro_abnormalsensation", "neuro_presenceofabnormalreflex",
                                  "neuro_pooralteredmemory", "neuro_poormuscletone", "neuro_poorcoordination", "referringreason"}
        Dim strVar() As Object = {9, Admissionid, AdmittingDiagnosis, Historyofpresentillness, PhysicalExam, ReasonForAdmission, _
                                  AdmittingImpression, FamilyHistory, PastHistory, PastIllness, ChiefComplaints, aBloodPressure, aDiastolic, aBreathing, aPulse, _
                                  aTemp, aHeight, aWeight, aHeent, aChest, aCVs, aAbdomen, aSkinExtrem, aNeuro, aGU, DocumentNo, _
                                  Gravida, Para, Abortion, Term, Premature, Line, PreviousMenstrualPeriod, PMPDurationCharacter, LastmenstrualPeriod, _
                                  LmpDurationCharacter, EstimatedDateofConfinement, AgeofGestation, Menarche, Interval, Duration, _
                                  Amount, Contraception, Dysmenorrhea, PrenatalCoursePvtmd, PrenatalCourseDHIOPD, PrenatalCourseHealthCtr, _
                                  PrenatalCourseMidwife, PrenatalCourseHilot, PrenatalCourseNone, FreqofChekUpDoneBy, BP, Complications, PrenatalMedsTaken, ChildhoodDiseases, PrevHospitalizations, _
                                  PrevOperations, MedicalIllness, Allergies, Medications, FamilyHistoryDM, FamilyHistoryHPN, FamilyHistoryDse, FamilyHistoryPTB, FamilyHistoryCA, FamilyHistoryOthers, _
                                  RR, HT, CR, T, WT, HeadNeck, Heart, Breasts, Lungs, AbdomenFh, AbdomenEFW, AbdomenFHt, AbdomenFHtCharacter, AbdomenFHtLocation, Extremeties, _
                                  IEBy, NeurologicPosition, Dilatation, Effacement, Station, BOW, BOWLeakingSince, PresPart, CharacterofDischargeMucoid, CharacterofDischargeBloody, _
                                  CharacterofDischargeWatery, CharacterofDischargeColor, CharacterofDischargeOdor, SpeculumExam, Abnormalities, _
                                  ClinicalPelvimetryIschialSpines, ClinicalPelvimetrySideWalls, ClinicalPelvimetryPubicArch, ClinicalPelvimetrySacrumContour, _
                                  ClinicalPelvimetrySacrosciaticNotch, ClinicalPelvimetryIschialTuberosities, EPCAdequate, EPCBorderLine, EPCNarrow, _
                                  Impression, DateOfQuickening, UltrasoundAOG, AdjustedEDC, UltrasoundDate, PrenatalVisits, ContraceptivesHistory, _
                                  HealthCareProvider, ImmunizationsTetanus, ImmunizationsTetanusDoses, ImmunizationsTetanusDate, ImmunizationsHepatitisB, _
                                  ImmunizationsOthers, TotalGainWeight, HB, UrineALB, Sugar, AntenatalProblemsMB98ms, AntenatalProblemsPrevCSSurgery, _
                                  AntenatalProblemsUTI, AntenatalProblemsInfectionTracts, AntenatalProblemsNutritional, AntenatalProblemsHPNPIDCHVD, _
                                  AntenatalProblemsCardiac, AntenatalProblemsRenal, AntenatalProblemsDMMetabolic, AntenatalProblemsRespiratory, _
                                  AntenatalProblemsFetalWastage, AntenatalProblemsPrematureLabor, AntenatalProblemsIUGR, AntenatalProblemsInfertility, _
                                  AntenatalProblemsOthers, RiskStatus, "1/1/1900", PhysicalExaminer, PhysicalExamGeneralStatus, LevelofSensorium, _
                                  EENT, ChestHeart, ChestLungs, ChestBreast, AbdomenLSK, AbdomenFundicHeight, AbdomenPresentation, AbdomenFloatingEngaged, _
                                  AbdomenOther, PelvicExamExternalGenitalia, PelvicExamUterus, PelvicExamVaginaCervixLength, PelvicExamPositionAnt, _
                                  PelvicExamPositionMidLine, PelvicExamPositionPost, PresentationPosition, PresentationStation, PresentationMembranes, _
                                  PresentationAmnioticFld, PresentationSutures, PelvimetryContracted, PelvimetryContractedInlet, _
                                  PelvimetryContractedInletTxt, PelvimetryContractedMidLine, PelvimetryContractedMidLineTxt, PelvimetryContractedOutlet, _
                                  PelvimetryContractedOutletTxt, PelvimetryBorderLine, PelvimetryBorderLineTrialLabor, GeneralStatus, _
                                  PelvimetryAdequate, Remarks, PresentIllness, PrenatalInfection, PrenatalExposureToDrugs, _
                                  PrenatalSmokingAlcohol, NatalTypeofDelivery, NatalNSD, NatalCS, NatalYO, NatalGestationalAge, NatalBodyWeight, _
                                  NatalApgarScore, NatalAnomalies, NatalResuscitation, NatalComplication, FeedingHistoryBreastFeeding, _
                                  FeedingHistoryMilkFormula, FeedingHistorySupplemental, FeedingHistoryAllergies, GrowthDevelopmentMotor, _
                                  GrowthDevelopmentLanguage, GrowthDevelopmentToiletTraining, GrowthDevelopmentSchool, ImmunizationBCG, _
                                  ImmunizationDPT, ImmunizationOPV, ImmunizationBoosterDoses, ImmunizationMeascles, ImmunizationHIB, _
                                  ImmunizationHepatitis, GeneralAppearance, Sheent, CL, CVS, Abdomin, NeurologicExam, MenstrualCycle1, MenstrualCycle2, MenstrualCycle3, _
                                  PogsGravida, Pogspara, Pogsabortion, Pogsterm, Pogspremature, Pogsline, PediaGravida, Pediapara, Pediaabortion, _
                                  PogsDilatation, PogsEffacement, Pogsfht, Pogsefw, PogsExtremities, Me.Officecode, alteredmentalsensorium, abdominalcramp_pain, anorexia, bleedinggums, bodyweakness, blurringofvision,
                                  constipation, chestpain_discomfort, cough_dry, cough_productive, diarrhea, dizziness, dysphagia, dyspnea,
                                  dysuria, epistaxis, fever, frequencyofurination, headache, hematemesis, hematuria, hemoptysis,
                                  increaseirritability, jaundice, lowerextremityedema, myalgia, orthopnea, palpitations, skinrashes,
                                  stool_bloody_blacktarry_mucoid, sweating, seizures, urgency, vomiting, weightloss, others, pain,
                                  survey_awakeandalert, survey_alteredsensorium, heent_essentiallynormal, heent_abnormalpupillaryreaction,
                                  heent_cervicallympadenopathy, heent_drymucousmembrane, heent_ictericsclerae, heent_paleconjunctivae,
                                  heent_sunkeneyeballs, heent_sunkenfontanelle, chest_essentiallynormal, chest_asymmetricalexpansion,
                                  chest_decreasedbreathsounds, chest_wheezes, chest_lumpsoverbreast, chest_ralescracklesrhonchi,
                                  chest_intercostalribretraction, cvs_essentiallynormal, cvs_displacedapexbeat, cvs_heaves,
                                  cvs_irregularrhythm, cvs_muffledheartsounds, cvs_murmur, cvs_pericardialbulge,
                                  abdomen_essentiallynormal, abdomen_abdominalrigidity, abdomen_abdominaltenderness, abdomen_hyperactivebowelsounds,
                                  abdomen_palpablemass, abdomen_tympaniticdullabdomen, abdomen_uterinecontraction, gu_essentiallynormal,
                                  gu_bloodstainedfinger, gu_cervicaldilatation, gu_presenceofabnormaldischarge, skin_essentiallynormal,
                                  skin_clubbing, skin_coldclammy, skin_cyanosis, skin_edema, skin_muscles, skin_palenailbeds,
                                  skin_poorskinturgor, skin_rashespetechiae, skin_weakpulses, neuro_essentiallynormal,
                                  neuro_abnormalgait, neuro_abnormalposition, neuro_abnormalsensation, neuro_presenceofabnormalreflex,
                                  neuro_pooralteredmemory, neuro_poormuscletone, neuro_poorcoordination, referringreason}
        GenericDA.ManageQuery(strPar, strVar, "spAdmissionDetails", 1)
    End Sub
    Public Sub SavePhoto(ByVal patientid As Integer)
        Dim strPar() As String = {"Operation", "PatientID", "Photo"}
        Dim strVar() As Object = {8, patientid, Photo}
        GenericDA.ManageQuery(strPar, strVar, "spAdmissionDetails", 1)
    End Sub
    Public Function SaveObgyne(Optional ByVal mPtno As String = "", Optional ByVal mObspogID As Integer = 0) As Long
        'If isNew Then
        '    operation = 3
        'Else
        '    operation = 4
        'End If
        Dim strPar() As String = {"Operation", "ptno", "obgyneno", "obgyneyear", "obgynesex", "obgynetypeofdelivery", "obgyneplaceofdelivery", "obgyneattending", "obgynebw", "obgynecomplications", "pregnancyorder", "pregnancyoutcome", "gestationalcompleted", "birth", "present", "PogsYear", "PogsSex", "PogsComplications"}
        Dim strVar() As String = {3, Me.PtNo, Me.ObgyneNo, Me.ObgyneYear, Me.ObgyneSex, Me.ObgyneTypeofDelivery, Me.ObgynePlaceofDelivery, Me.ObgyneAttending, Me.ObgyneBW, Me.ObgyneComplications, Me.PregnancyOrder, Me.PregnancyOutcome, Me.GestationalCompleted, Me.Birth, Me.Present, Me.PogsYear, Me.PogsSex, Me.PogsComplications}
        Return GenericDA.ManageQuery(strPar, strVar, "spAdmissionDetails", 1)
    End Function
    Public Function ApprovedPhilhealth(ByVal vAdmissionId As Integer) As Long
        Dim strPar() As String = {"Operation", "PhilisPhilhealthApprove", "philhealthapprovalremarks", "AdmissionID", "PhilHealthNo", _
                                  "PhilRelationshiptoMember", "PhilReferredFrom", "PhilRepresentative", "PhilRelationshiptoRep", _
                                  "PhilContactnoRep", "PhilTypeofDelivery", "PhilNurseonDuty", "PhilWithMedPack", "PhilRemarks"}
        Dim strVar() As String = {7, PhilisPhilhealthApprove, PhilHealthApprovalRemarks, vAdmissionId, PhilHealthNo, PhilRelationshiptoMember, _
                                  PhilReferredFrom, PhilRepresentative, PhilRelationshiptoRep, PhilContactnoRep, PhilTypeofDelivery, PhilNurseonDuty, PhilWithMedPack}
        Return GenericDA.ManageQuery(strPar, strVar, "spAdmissionDetails", 1)
    End Function
    Public Function updateRoomStatus(ByVal roomid As Integer, Optional ByVal misAvailable As Boolean = True, Optional ByRef vadmissionid As Long = 0)
        Dim strPar() As String = {"Operation", "RoomID", "isAvailable", "AdmissionID"}
        Dim strVar() As String = {5, roomid, misAvailable, vadmissionid}
        Return GenericDA.ManageQuery(strPar, strVar, "spAdmissionDetails", 1)
    End Function
    Public Function updateisActive(ByVal vPatientid As Integer)
        Dim strPar() As String = {"Operation", "PatientID"}
        Dim strVar() As String = {10, vPatientid}
        Return GenericDA.ManageQuery(strPar, strVar, "spAdmissionDetails", 1)
    End Function
    Public Function genericOP(ByVal op As Integer, Optional ByVal patno As String = "", Optional ByVal philhealthno As String = "", Optional ByVal admissionid As String = "")
        'Dim dt As New DataTable
        Dim strPar() As String = {"operation", "search", "philhealthno", "AdmissionID"}
        Dim strVal() As String = {op, patno, philhealthno, admissionid}
        Return GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 1)
    End Function
    Public Function UpdateAdmissionStatus(ByVal vAdmissionId As Integer, ByVal sNew As Boolean)
        Dim sOperation As Integer
        If sNew = True Then
            sOperation = 1
        Else
            sOperation = 2
        End If

        Dim strPar() As String = {"Operation", "sOperation", "MghDate", "DateDischarged", "AdmissionStatus", "isDischarge", "AdmissionID", "Dischargestatus", "dateofdeath", "reasonrefferalno", "referralID ", "dischargedbyid "}
        Dim strVar() As String = {6, sOperation, MGHDate, DateDischarge, AdmissionStatus, IsDischarge, vAdmissionId, DischargeStatus, DateofDeath, ReasonRefferalNo, mreferralid, dischargedbyid}
        Return GenericDA.ManageQuery(strPar, strVar, "spAdmissionDetails", 1)
    End Function

    Public Sub CancelAdmission(ByVal admissionid As Long)
        Dim strPar() As String = {"operation", "encodedby", "admissionid"}
        Dim strVal() As String = {12, userid, admissionid}
        Call GenericDA.ManageQuery(strPar, strVal, "spAdmissionDetails", 0)
    End Sub
#End Region
End Class


