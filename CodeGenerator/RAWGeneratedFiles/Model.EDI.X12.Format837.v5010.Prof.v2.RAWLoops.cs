public class Loop1000ACollection : LoopCollection<Loop1000A> {
public Loop1000ACollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop1000A : LoopEntity{
public Loop1000A(){}
public Nm1Collection Name = new Nm1Collection();
public PerCollection EDIContact = new PerCollection();
}
public class Loop1000BCollection : LoopCollection<Loop1000B> {
public Loop1000BCollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop1000B : LoopEntity{
public Loop1000B(){}
public Nm1Collection Name = new Nm1Collection();
}
public class Loop2000ACollection : LoopCollection<Loop2000A> {
public Loop2000ACollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2000A : LoopEntity{
public Loop2000A(){}
public HlCollection Level = new HlCollection();
public PrvCollection SpecialtyInfo = new PrvCollection();
public CurCollection Currency = new CurCollection();
}
public class Loop2010AACollection : LoopCollection<Loop2010AA> {
public Loop2010AACollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2010AA : LoopEntity{
public Loop2010AA(){}
public Nm1Collection Name = new Nm1Collection();
public N3Collection Address = new N3Collection();
public N4Collection Location = new N4Collection();
public RefCollection TaxId = new RefCollection();
public RefCollection UPINLicense = new RefCollection();
public PerCollection ContactInfo = new PerCollection();
}
public class Loop2010ABCollection : LoopCollection<Loop2010AB> {
public Loop2010ABCollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2010AB : LoopEntity{
public Loop2010AB(){}
public Nm1Collection Name = new Nm1Collection();
public N3Collection Address = new N3Collection();
public N4Collection Location = new N4Collection();
}
public class Loop2010ACCollection : LoopCollection<Loop2010AC> {
public Loop2010ACCollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2010AC : LoopEntity{
public Loop2010AC(){}
public Nm1Collection Name = new Nm1Collection();
public N3Collection Address = new N3Collection();
public N4Collection Location = new N4Collection();
public RefCollection SecondaryId = new RefCollection();
public RefCollection TaxID = new RefCollection();
}
public class Loop2000BCollection : LoopCollection<Loop2000B> {
public Loop2000BCollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2000B : LoopEntity{
public Loop2000B(){}
public HlCollection Level = new HlCollection();
public SbrCollection SubscriberInfo = new SbrCollection();
public PatCollection PationInfo = new PatCollection();
}
public class Loop2010BACollection : LoopCollection<Loop2010BA> {
public Loop2010BACollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2010BA : LoopEntity{
public Loop2010BA(){}
public Nm1Collection Name = new Nm1Collection();
public N3Collection Address = new N3Collection();
public N4Collection Location = new N4Collection();
public DmgCollection Demographic = new DmgCollection();
public RefCollection SecondaryId = new RefCollection();
public RefCollection PropertyCausualtyClaimNumber = new RefCollection();
public PerCollection PropertyCausualtySubscriberContact = new PerCollection();
}
public class Loop2010BBCollection : LoopCollection<Loop2010BB> {
public Loop2010BBCollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2010BB : LoopEntity{
public Loop2010BB(){}
public Nm1Collection Name = new Nm1Collection();
public N3Collection Address = new N3Collection();
public N4Collection Location = new N4Collection();
public RefCollection SecondaryId = new RefCollection();
public RefCollection BillingProviderSecondaryId = new RefCollection();
}
public class Loop2000CCollection : LoopCollection<Loop2000C> {
public Loop2000CCollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2000C : LoopEntity{
public Loop2000C(){}
public HlCollection Level = new HlCollection();
public PatCollection Info = new PatCollection();
}
public class Loop2010CACollection : LoopCollection<Loop2010CA> {
public Loop2010CACollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2010CA : LoopEntity{
public Loop2010CA(){}
public Nm1Collection Name = new Nm1Collection();
public N3Collection Address = new N3Collection();
public N4Collection Location = new N4Collection();
public DmgCollection Demographic = new DmgCollection();
public RefCollection PropertyCausualtyClaimNumber = new RefCollection();
public RefCollection PropertyCausualtyPatientId = new RefCollection();
public PerCollection PropertyCausualtySubscriberContact = new PerCollection();
}
public class Loop2300Collection : LoopCollection<Loop2300> {
public Loop2300Collection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2300 : LoopEntity{
public Loop2300(){}
public ClmCollection Claim = new ClmCollection();
public DtpCollection Onset = new DtpCollection();
public DtpCollection Initialtreatment = new DtpCollection();
public DtpCollection LastSeen = new DtpCollection();
public DtpCollection AcuteManifestation = new DtpCollection();
public DtpCollection Accident = new DtpCollection();
public DtpCollection LastMenstrual = new DtpCollection();
public DtpCollection LastXRay = new DtpCollection();
public DtpCollection HearingVisionPrescription = new DtpCollection();
public DtpCollection DisabilityDates = new DtpCollection();
public DtpCollection LastWored = new DtpCollection();
public DtpCollection AuthorizedReturnWork = new DtpCollection();
public DtpCollection Admission = new DtpCollection();
public DtpCollection Discharge = new DtpCollection();
public DtpCollection AssumedRelinquishedCare = new DtpCollection();
public DtpCollection PropertyCasualtyFirstContact = new DtpCollection();
public DtpCollection RepricerReceived = new DtpCollection();
public PwkCollection SupplementalInfomation = new PwkCollection();
public Cn1Collection Contact = new Cn1Collection();
public AmtCollection PatientAmountPaid = new AmtCollection();
public RefCollection ServiceAuthorizationException = new RefCollection();
public RefCollection MandatoryMedicareCrossover = new RefCollection();
public RefCollection MammographCertificationNumber = new RefCollection();
public RefCollection ReferalNumber = new RefCollection();
public RefCollection PriorAuthorizaiton = new RefCollection();
public RefCollection PayerClaimControlNumer = new RefCollection();
public RefCollection CLIANumber = new RefCollection();
public RefCollection RepricedClaimNumber = new RefCollection();
public RefCollection AdjustedRepricedClaimNumber = new RefCollection();
public RefCollection InvestigativeDeviceExemption = new RefCollection();
public RefCollection ClaimIdForTransmissionIntermediaries = new RefCollection();
public RefCollection MedicalRecordNumber = new RefCollection();
public RefCollection DemonstrationProjectId = new RefCollection();
public RefCollection CarePlanOversight = new RefCollection();
public K3Collection FileInfo = new K3Collection();
public NteCollection Note = new NteCollection();
public Cr1Collection AmbulanceInfo = new Cr1Collection();
public Cr2Collection SpinalManipulaiton = new Cr2Collection();
public CrcCollection AmbulanceCertification = new CrcCollection();
public CrcCollection PationConditionVision = new CrcCollection();
public CrcCollection HomeboundIndicator = new CrcCollection();
public CrcCollection EPSDTReferral = new CrcCollection();
public HiCollection HealthCareDiagnosisCode = new HiCollection();
public HiCollection AnesthesiaRelatedProcedure = new HiCollection();
public HiCollection ConditionInfomation = new HiCollection();
public HcpCollection ClaimPricingInfo = new HcpCollection();
}
public class Loop2310ACollection : LoopCollection<Loop2310A> {
public Loop2310ACollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2310A : LoopEntity{
public Loop2310A(){}
public Nm1Collection Name = new Nm1Collection();
public RefCollection SecondaryId = new RefCollection();
}
public class Loop2310BCollection : LoopCollection<Loop2310B> {
public Loop2310BCollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2310B : LoopEntity{
public Loop2310B(){}
public Nm1Collection Name = new Nm1Collection();
public PrvCollection SpecialtyInfo = new PrvCollection();
public RefCollection SecondaryId = new RefCollection();
}
public class Loop2310CCollection : LoopCollection<Loop2310C> {
public Loop2310CCollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2310C : LoopEntity{
public Loop2310C(){}
public Nm1Collection Name = new Nm1Collection();
public N3Collection Address = new N3Collection();
public N4Collection Location = new N4Collection();
public RefCollection SecondaryId = new RefCollection();
public PerCollection ContactInfo = new PerCollection();
}
public class Loop2310DCollection : LoopCollection<Loop2310D> {
public Loop2310DCollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2310D : LoopEntity{
public Loop2310D(){}
public Nm1Collection Name = new Nm1Collection();
public RefCollection SecondaryId = new RefCollection();
}
public class Loop2310ECollection : LoopCollection<Loop2310E> {
public Loop2310ECollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2310E : LoopEntity{
public Loop2310E(){}
public Nm1Collection Name = new Nm1Collection();
public N3Collection Address = new N3Collection();
public N3Collection Locaiton = new N3Collection();
}
public class Loop2310FCollection : LoopCollection<Loop2310F> {
public Loop2310FCollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2310F : LoopEntity{
public Loop2310F(){}
public Nm1Collection Name = new Nm1Collection();
public N3Collection Address = new N3Collection();
public N3Collection Locaiton = new N3Collection();
}
public class Loop2320Collection : LoopCollection<Loop2320> {
public Loop2320Collection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2320 : LoopEntity{
public Loop2320(){}
public SbrCollection Info = new SbrCollection();
public CasCollection Adjustments = new CasCollection();
public AmtCollection COBPayerPaid = new AmtCollection();
public AmtCollection COBTotalNonCovered = new AmtCollection();
public AmtCollection RemainingPatientLiability = new AmtCollection();
public OiCollection OtherCoverageInfo = new OiCollection();
public MoaCollection OutpatientAdjudicaiton = new MoaCollection();
}
public class Loop2330ACollection : LoopCollection<Loop2330A> {
public Loop2330ACollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2330A : LoopEntity{
public Loop2330A(){}
public Nm1Collection Name = new Nm1Collection();
public N3Collection Address = new N3Collection();
public N4Collection Location = new N4Collection();
public RefCollection SecondaryId = new RefCollection();
}
public class Loop2330BCollection : LoopCollection<Loop2330B> {
public Loop2330BCollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2330B : LoopEntity{
public Loop2330B(){}
public Nm1Collection Name = new Nm1Collection();
public N3Collection Address = new N3Collection();
public N4Collection Location = new N4Collection();
public DtpCollection CheckRemittanceDate = new DtpCollection();
public RefCollection SecondaryId = new RefCollection();
public RefCollection AuthorizationNumber = new RefCollection();
public RefCollection ReferalNumber = new RefCollection();
public RefCollection AdjustmentIndicator = new RefCollection();
public RefCollection ControlNumber = new RefCollection();
}
public class Loop2330CCollection : LoopCollection<Loop2330C> {
public Loop2330CCollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2330C : LoopEntity{
public Loop2330C(){}
public Nm1Collection Name = new Nm1Collection();
public RefCollection SecondaryId = new RefCollection();
}
public class Loop2330DCollection : LoopCollection<Loop2330D> {
public Loop2330DCollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2330D : LoopEntity{
public Loop2330D(){}
public Nm1Collection Name = new Nm1Collection();
public RefCollection SecondaryId = new RefCollection();
}
public class Loop2330ECollection : LoopCollection<Loop2330E> {
public Loop2330ECollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2330E : LoopEntity{
public Loop2330E(){}
public Nm1Collection Name = new Nm1Collection();
public RefCollection SecondaryId = new RefCollection();
}
public class Loop2330FCollection : LoopCollection<Loop2330F> {
public Loop2330FCollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2330F : LoopEntity{
public Loop2330F(){}
public Nm1Collection Name = new Nm1Collection();
public RefCollection SecondaryId = new RefCollection();
}
public class Loop2330GCollection : LoopCollection<Loop2330G> {
public Loop2330GCollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2330G : LoopEntity{
public Loop2330G(){}
public Nm1Collection Name = new Nm1Collection();
public RefCollection SecondaryId = new RefCollection();
}
public class Loop2400Collection : LoopCollection<Loop2400> {
public Loop2400Collection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2400 : LoopEntity{
public Loop2400(){}
public LxCollection LineNumber = new LxCollection();
public Sv1Collection ProfessionalService = new Sv1Collection();
public Sv5Collection MedicalEqupmentService = new Sv5Collection();
public PwkCollection LineSupplemental = new PwkCollection();
public PwkCollection EquipmentCertificateIndicator = new PwkCollection();
public Cr1Collection AmbulanceTransport = new Cr1Collection();
public Cr3Collection MedicalEquipmentCertification = new Cr3Collection();
public CrcCollection AmbulanceCertification = new CrcCollection();
public CrcCollection HospiceEmployeeIndicator = new CrcCollection();
public CrcCollection EquipmentConditionIndicator = new CrcCollection();
public DtpCollection ServiceDate = new DtpCollection();
public DtpCollection Perscription = new DtpCollection();
public DtpCollection CertificationRevision = new DtpCollection();
public DtpCollection BeginTherapy = new DtpCollection();
public DtpCollection LastCertificationDate = new DtpCollection();
public DtpCollection LastSeen = new DtpCollection();
public DtpCollection Test = new DtpCollection();
public DtpCollection Shipped = new DtpCollection();
public DtpCollection LastXRay = new DtpCollection();
public DtpCollection InitialTreatment = new DtpCollection();
public QtyCollection AmbulancePatientcount = new QtyCollection();
public QtyCollection ObstetricAnesthesiaAdditionalUnits = new QtyCollection();
public MeaCollection TestResults = new MeaCollection();
public Cn1Collection Contact = new Cn1Collection();
public RefCollection RepricdLineItemNumber = new RefCollection();
public RefCollection AdujstedRepricedLineNumber = new RefCollection();
public RefCollection PriorAuthorization = new RefCollection();
public RefCollection LineItemControlNumber = new RefCollection();
public RefCollection MammographyCertificationNumber = new RefCollection();
public RefCollection CLIANumber = new RefCollection();
public RefCollection CLIAId = new RefCollection();
public RefCollection ImmunizationBatch = new RefCollection();
public RefCollection ReferralNumber = new RefCollection();
public AmtCollection SalesTax = new AmtCollection();
public AmtCollection PostageClaimed = new AmtCollection();
public K3Collection FileInfo = new K3Collection();
public NteCollection LineNote = new NteCollection();
public NteCollection ThirdPartyNotes = new NteCollection();
public Ps1Collection PurchasedServiceInfo = new Ps1Collection();
public HcpCollection LinePricing = new HcpCollection();
}
public class Loop2410Collection : LoopCollection<Loop2410> {
public Loop2410Collection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2410 : LoopEntity{
public Loop2410(){}
public LinCollection Indentification = new LinCollection();
public CtpCollection Quantity = new CtpCollection();
public RefCollection Perscription = new RefCollection();
}
public class Loop2420ACollection : LoopCollection<Loop2420A> {
public Loop2420ACollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2420A : LoopEntity{
public Loop2420A(){}
public Nm1Collection Name = new Nm1Collection();
public PrvCollection Specialty = new PrvCollection();
public RefCollection SecondaryId = new RefCollection();
}
public class Loop2420BCollection : LoopCollection<Loop2420B> {
public Loop2420BCollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2420B : LoopEntity{
public Loop2420B(){}
public Nm1Collection Name = new Nm1Collection();
public RefCollection SecondaryInfo = new RefCollection();
}
public class Loop2420CCollection : LoopCollection<Loop2420C> {
public Loop2420CCollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2420C : LoopEntity{
public Loop2420C(){}
public Nm1Collection Name = new Nm1Collection();
public N3Collection Address = new N3Collection();
public N4Collection Location = new N4Collection();
public RefCollection SecondaryId = new RefCollection();
}
public class Loop2420DCollection : LoopCollection<Loop2420D> {
public Loop2420DCollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2420D : LoopEntity{
public Loop2420D(){}
public Nm1Collection Name = new Nm1Collection();
public RefCollection SecondaryId = new RefCollection();
}
public class Loop2420ECollection : LoopCollection<Loop2420E> {
public Loop2420ECollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2420E : LoopEntity{
public Loop2420E(){}
public Nm1Collection Name = new Nm1Collection();
public N3Collection Address = new N3Collection();
public N4Collection Location = new N4Collection();
public RefCollection SecondaryId = new RefCollection();
public PerCollection Contact = new PerCollection();
}
public class Loop2420FCollection : LoopCollection<Loop2420F> {
public Loop2420FCollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2420F : LoopEntity{
public Loop2420F(){}
public Nm1Collection Name = new Nm1Collection();
public RefCollection SecondaryId = new RefCollection();
}
public class Loop2420GCollection : LoopCollection<Loop2420G> {
public Loop2420GCollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2420G : LoopEntity{
public Loop2420G(){}
public Nm1Collection Name = new Nm1Collection();
public N3Collection Address = new N3Collection();
public N4Collection Location = new N4Collection();
}
public class Loop2420HCollection : LoopCollection<Loop2420H> {
public Loop2420HCollection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2420H : LoopEntity{
public Loop2420H(){}
public Nm1Collection Name = new Nm1Collection();
public N3Collection Address = new N3Collection();
public N4Collection Location = new N4Collection();
}
public class Loop2430Collection : LoopCollection<Loop2430> {
public Loop2430Collection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2430 : LoopEntity{
public Loop2430(){}
public SvdCollection Info = new SvdCollection();
public CasCollection LineAdjustment = new CasCollection();
public DtpCollection CheckRemittanceDate = new DtpCollection();
public AmtCollection RemainingPatientLiability = new AmtCollection();
}
public class Loop2440Collection : LoopCollection<Loop2440> {
public Loop2440Collection(){}
public override bool Validate(){ throw new System.NotImplementedException();}
public override void SetUpDefinition(){throw new System.NotImplementedException();}
}
public class Loop2440 : LoopEntity{
public Loop2440(){}
public LqCollection Code = new LqCollection();
public FrmCollection SupportingDocumentation = new FrmCollection();
}
