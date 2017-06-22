public partial class Loop01GECollection : LoopCollection<Loop01GE> {
public Loop01GECollection(){}
}
public partial class Loop01GE : LoopEntity{
public Loop01GE(){}
public GsCollection FunctionalGroupHeader = new GsCollection();
public GeCollection FunctionalGroupTrailer = new GeCollection();
}
public partial class Loop1000ACollection : LoopCollection<Loop1000A> {
public Loop1000ACollection(){}
}
public partial class Loop1000A : LoopEntity{
public Loop1000A(){}
public Nm1Collection SubmitterName = new Nm1Collection();
public PerCollection SubmitterEDIContactInformation = new PerCollection();
}
public partial class Loop1000BCollection : LoopCollection<Loop1000B> {
public Loop1000BCollection(){}
}
public partial class Loop1000B : LoopEntity{
public Loop1000B(){}
public Nm1Collection ReceiverName = new Nm1Collection();
}
public partial class Loop2000ACollection : LoopCollection<Loop2000A> {
public Loop2000ACollection(){}
}
public partial class Loop2000A : LoopEntity{
public Loop2000A(){}
public HlCollection BillingProviderHierarchicalLevel = new HlCollection();
public PrvCollection BillingProviderSpecialtyInformation = new PrvCollection();
public CurCollection ForeignCurrencyInformation = new CurCollection();
}
public partial class Loop2010AACollection : LoopCollection<Loop2010AA> {
public Loop2010AACollection(){}
}
public partial class Loop2010AA : LoopEntity{
public Loop2010AA(){}
public Nm1Collection BillingProviderName = new Nm1Collection();
public N3Collection BillingProviderAddress = new N3Collection();
public N4Collection "BillingProviderCity,State,ZIPCode" = new N4Collection();
public RefCollection BillingProviderTaxIdentification = new RefCollection();
public RefCollection BillingProviderUPIN/LicenseInformation = new RefCollection();
public PerCollection BillingProviderContactInformation = new PerCollection();
}
public partial class Loop2010ABCollection : LoopCollection<Loop2010AB> {
public Loop2010ABCollection(){}
}
public partial class Loop2010AB : LoopEntity{
public Loop2010AB(){}
public Nm1Collection Pay-toAddressName = new Nm1Collection();
public N3Collection Pay-toAddress-ADDRESS = new N3Collection();
public N4Collection "Pay-ToAddressCity,State,ZIPCode" = new N4Collection();
}
public partial class Loop2010ACCollection : LoopCollection<Loop2010AC> {
public Loop2010ACCollection(){}
}
public partial class Loop2010AC : LoopEntity{
public Loop2010AC(){}
public Nm1Collection Pay-ToPlanName = new Nm1Collection();
public N3Collection Pay-toPlanAddress = new N3Collection();
public N4Collection "Pay-ToPlanCity,State,ZIPCode" = new N4Collection();
public RefCollection Pay-toPlanSecondaryIdentification = new RefCollection();
public RefCollection Pay-ToPlanTaxIdentificationNumber = new RefCollection();
}
public partial class Loop2000BCollection : LoopCollection<Loop2000B> {
public Loop2000BCollection(){}
}
public partial class Loop2000B : LoopEntity{
public Loop2000B(){}
public HlCollection SubscriberHierarchicalLevel = new HlCollection();
public SbrCollection SubscriberInformation = new SbrCollection();
public PatCollection PatientInformation = new PatCollection();
}
public partial class Loop2010BACollection : LoopCollection<Loop2010BA> {
public Loop2010BACollection(){}
}
public partial class Loop2010BA : LoopEntity{
public Loop2010BA(){}
public Nm1Collection SubscriberName = new Nm1Collection();
public N3Collection SubscriberAddress = new N3Collection();
public N4Collection "SubscriberCity,State,ZIPCode" = new N4Collection();
public DmgCollection SubscriberDemographicInformation = new DmgCollection();
public RefCollection SubscriberSecondaryIdentification = new RefCollection();
public RefCollection PropertyandCasualtyClaimNumber = new RefCollection();
public PerCollection PropertyandCasualtySubscriberContactInformation = new PerCollection();
}
public partial class Loop2010BBCollection : LoopCollection<Loop2010BB> {
public Loop2010BBCollection(){}
}
public partial class Loop2010BB : LoopEntity{
public Loop2010BB(){}
public Nm1Collection PayerName = new Nm1Collection();
public N3Collection PayerAddress = new N3Collection();
public N4Collection "PayerCity,State,ZIPCode" = new N4Collection();
public RefCollection PayerSecondaryIdentification = new RefCollection();
public RefCollection BillingProviderSecondaryIdentification = new RefCollection();
}
public partial class Loop2000CCollection : LoopCollection<Loop2000C> {
public Loop2000CCollection(){}
}
public partial class Loop2000C : LoopEntity{
public Loop2000C(){}
public HlCollection PatientHierarchicalLevel = new HlCollection();
public PatCollection PatientInformation = new PatCollection();
}
public partial class Loop2010CACollection : LoopCollection<Loop2010CA> {
public Loop2010CACollection(){}
}
public partial class Loop2010CA : LoopEntity{
public Loop2010CA(){}
public Nm1Collection PatientName = new Nm1Collection();
public N3Collection PatientAddress = new N3Collection();
public N4Collection "PatientCity,State,ZIPCode" = new N4Collection();
public DmgCollection PatientDemographicInformation = new DmgCollection();
public RefCollection PropertyandCasualtyClaimNumber = new RefCollection();
public RefCollection PropertyandCasualtyPatientIdentifier = new RefCollection();
public PerCollection PropertyandCasualtyPatientContactInformation = new PerCollection();
}
public partial class Loop2300Collection : LoopCollection<Loop2300> {
public Loop2300Collection(){}
}
public partial class Loop2300 : LoopEntity{
public Loop2300(){}
public ClmCollection ClaimInformation = new ClmCollection();
public DtpCollection Date-OnsetofCurrentIllnessorSymptom = new DtpCollection();
public DtpCollection Date-InitialTreatmentDate = new DtpCollection();
public DtpCollection Date-LastSeenDate = new DtpCollection();
public DtpCollection Date-AcuteManifestation = new DtpCollection();
public DtpCollection Date-Accident = new DtpCollection();
public DtpCollection Date-LastMenstrualPeriod = new DtpCollection();
public DtpCollection Date-LastX-rayDate = new DtpCollection();
public DtpCollection Date-HearingandVisionPrescriptionDate = new DtpCollection();
public DtpCollection Date-DisabilityDates = new DtpCollection();
public DtpCollection Date-LastWorked = new DtpCollection();
public DtpCollection Date-AuthorizedReturntoWork = new DtpCollection();
public DtpCollection Date-Admission = new DtpCollection();
public DtpCollection Date-Discharge = new DtpCollection();
public DtpCollection Date-AssumedandRelinquishedCareDates = new DtpCollection();
public DtpCollection Date-PropertyandCasualtyDateofFirstContact = new DtpCollection();
public DtpCollection Date-RepricerReceivedDate = new DtpCollection();
public PwkCollection ClaimSupplementalInformation = new PwkCollection();
public Cn1Collection ContractInformation = new Cn1Collection();
public AmtCollection PatientAmountPaid = new AmtCollection();
public RefCollection ServiceAuthorizationExceptionCode = new RefCollection();
public RefCollection MandatoryMedicare(Section4081)CrossoverIndicator = new RefCollection();
public RefCollection MammographyCertificationNumber = new RefCollection();
public RefCollection ReferralNumber = new RefCollection();
public RefCollection PriorAuthorization = new RefCollection();
public RefCollection PayerClaimControlNumber = new RefCollection();
public RefCollection ClinicalLaboratoryImprovementAmendment(CLIA) = new RefCollection();
public RefCollection RepricedClaimNumber = new RefCollection();
public RefCollection AdjustedRepricedClaimNumber = new RefCollection();
public RefCollection InvestigationalDeviceExemptionNumber = new RefCollection();
public RefCollection ClaimIdentifierForTransmissionIntermediaries = new RefCollection();
public RefCollection MedicalRecordNumber = new RefCollection();
public RefCollection DemonstrationProjectIdentifier = new RefCollection();
public RefCollection CarePlanOversight = new RefCollection();
public K3Collection FileInformation = new K3Collection();
public NteCollection ClaimNote = new NteCollection();
public Cr1Collection AmbulanceTransportInformation = new Cr1Collection();
public Cr2Collection SpinalManipulationServiceInformation = new Cr2Collection();
public CrcCollection AmbulanceCertification = new CrcCollection();
public CrcCollection PatientConditionInformation:Vision = new CrcCollection();
public CrcCollection HomeboundIndicator = new CrcCollection();
public CrcCollection EPSDTReferral = new CrcCollection();
public HiCollection HealthCareDiagnosisCode = new HiCollection();
public HiCollection AnesthesiaRelatedProcedure = new HiCollection();
public HiCollection ConditionInformation = new HiCollection();
public HcpCollection ClaimPricing/RepricingInformation = new HcpCollection();
}
public partial class Loop2310ACollection : LoopCollection<Loop2310A> {
public Loop2310ACollection(){}
}
public partial class Loop2310A : LoopEntity{
public Loop2310A(){}
public Nm1Collection ReferringProviderName = new Nm1Collection();
public RefCollection ReferringProviderSecondaryIdentification = new RefCollection();
}
public partial class Loop2310BCollection : LoopCollection<Loop2310B> {
public Loop2310BCollection(){}
}
public partial class Loop2310B : LoopEntity{
public Loop2310B(){}
public Nm1Collection RenderingProviderName = new Nm1Collection();
public PrvCollection RenderingProviderSpecialtyInformation = new PrvCollection();
public RefCollection RenderingProviderSecondaryIdentification = new RefCollection();
}
public partial class Loop2310CCollection : LoopCollection<Loop2310C> {
public Loop2310CCollection(){}
}
public partial class Loop2310C : LoopEntity{
public Loop2310C(){}
public Nm1Collection ServiceFacilityLocationName = new Nm1Collection();
public N3Collection ServiceFacilityLocationAddress = new N3Collection();
public N4Collection "ServiceFacilityLocationCity,State,ZIPCode" = new N4Collection();
public RefCollection ServiceFacilityLocationSecondaryIdentification = new RefCollection();
public PerCollection ServiceFacilityContactInformation = new PerCollection();
}
public partial class Loop2310DCollection : LoopCollection<Loop2310D> {
public Loop2310DCollection(){}
}
public partial class Loop2310D : LoopEntity{
public Loop2310D(){}
public Nm1Collection SupervisingProviderName = new Nm1Collection();
public RefCollection SupervisingProviderSecondaryIdentification = new RefCollection();
}
public partial class Loop2310ECollection : LoopCollection<Loop2310E> {
public Loop2310ECollection(){}
}
public partial class Loop2310E : LoopEntity{
public Loop2310E(){}
public Nm1Collection AmbulancePick-upLocation = new Nm1Collection();
public N3Collection AmbulancePick-upLocationAddress = new N3Collection();
public N4Collection "AmbulancePick-upLocationCity,State,ZIPCode" = new N4Collection();
}
public partial class Loop2310FCollection : LoopCollection<Loop2310F> {
public Loop2310FCollection(){}
}
public partial class Loop2310F : LoopEntity{
public Loop2310F(){}
public Nm1Collection AmbulanceDrop-offLocation = new Nm1Collection();
public N3Collection AmbulanceDrop-offLocationAddress = new N3Collection();
public N4Collection "AmbulanceDrop-offLocationCity,State,ZIPCode" = new N4Collection();
}
public partial class Loop2320Collection : LoopCollection<Loop2320> {
public Loop2320Collection(){}
}
public partial class Loop2320 : LoopEntity{
public Loop2320(){}
public SbrCollection OtherSubscriberInformation = new SbrCollection();
public CasCollection ClaimLevelAdjustments = new CasCollection();
public AmtCollection CoordinationofBenefits(COB)PayerPaidAmount = new AmtCollection();
public AmtCollection CoordinationofBenefits(COB)TotalNon-Covered = new AmtCollection();
public AmtCollection RemainingPatientLiability = new AmtCollection();
public OiCollection OtherInsuranceCoverageInformation = new OiCollection();
public MoaCollection OutpatientAdjudicationInformation = new MoaCollection();
}
public partial class Loop2330ACollection : LoopCollection<Loop2330A> {
public Loop2330ACollection(){}
}
public partial class Loop2330A : LoopEntity{
public Loop2330A(){}
public Nm1Collection OtherSubscriberName = new Nm1Collection();
public N3Collection OtherSubscriberAddress = new N3Collection();
public N4Collection "OtherSubscriberCity,State,ZIPCode" = new N4Collection();
public RefCollection OtherSubscriberSecondaryIdentification = new RefCollection();
}
public partial class Loop2330BCollection : LoopCollection<Loop2330B> {
public Loop2330BCollection(){}
}
public partial class Loop2330B : LoopEntity{
public Loop2330B(){}
public Nm1Collection OtherPayerName = new Nm1Collection();
public N3Collection OtherPayerAddress = new N3Collection();
public N4Collection "OtherPayerCity,State,ZIPCode" = new N4Collection();
public DtpCollection ClaimCheckorRemittanceDate = new DtpCollection();
public RefCollection OtherPayerSecondaryIdentifier = new RefCollection();
public RefCollection OtherPayerPriorAuthorizationNumber = new RefCollection();
public RefCollection OtherPayerReferralNumber = new RefCollection();
public RefCollection OtherPayerClaimAdjustmentIndicator = new RefCollection();
public RefCollection OtherPayerClaimControlNumber = new RefCollection();
}
public partial class Loop2330CCollection : LoopCollection<Loop2330C> {
public Loop2330CCollection(){}
}
public partial class Loop2330C : LoopEntity{
public Loop2330C(){}
public Nm1Collection OtherPayerReferringProvider = new Nm1Collection();
public RefCollection OtherPayerReferringProviderSecondaryIdentification = new RefCollection();
}
public partial class Loop2330DCollection : LoopCollection<Loop2330D> {
public Loop2330DCollection(){}
}
public partial class Loop2330D : LoopEntity{
public Loop2330D(){}
public Nm1Collection OtherPayerRenderingProvider = new Nm1Collection();
public RefCollection OtherPayerRenderingProviderSecondaryIdentification = new RefCollection();
}
public partial class Loop2330ECollection : LoopCollection<Loop2330E> {
public Loop2330ECollection(){}
}
public partial class Loop2330E : LoopEntity{
public Loop2330E(){}
public Nm1Collection OtherPayerServiceFacilityLocation = new Nm1Collection();
public RefCollection OtherPayerServiceFacilityLocationSecondary = new RefCollection();
}
public partial class Loop2330FCollection : LoopCollection<Loop2330F> {
public Loop2330FCollection(){}
}
public partial class Loop2330F : LoopEntity{
public Loop2330F(){}
public Nm1Collection OtherPayerSupervisingProvider = new Nm1Collection();
public RefCollection OtherPayerSupervisingProviderSecondaryIdentification = new RefCollection();
}
public partial class Loop2330GCollection : LoopCollection<Loop2330G> {
public Loop2330GCollection(){}
}
public partial class Loop2330G : LoopEntity{
public Loop2330G(){}
public Nm1Collection OtherPayerBillingProvider = new Nm1Collection();
public RefCollection OtherPayerBillingProviderSecondaryIdentification = new RefCollection();
}
public partial class Loop2400Collection : LoopCollection<Loop2400> {
public Loop2400Collection(){}
}
public partial class Loop2400 : LoopEntity{
public Loop2400(){}
public LxCollection ServiceLineNumber = new LxCollection();
public Sv1Collection ProfessionalService = new Sv1Collection();
public Sv5Collection DurableMedicalEquipmentService = new Sv5Collection();
public PwkCollection LineSupplementalInformation = new PwkCollection();
public PwkCollection DurableMedicalEquipmentCertificateofMedical = new PwkCollection();
public Cr1Collection AmbulanceTransportInformation = new Cr1Collection();
public Cr3Collection DurableMedicalEquipmentCertification = new Cr3Collection();
public CrcCollection AmbulanceCertification = new CrcCollection();
public CrcCollection HospiceEmployeeIndicator = new CrcCollection();
public CrcCollection ConditionIndicator/DurableMedicalEquipment = new CrcCollection();
public DtpCollection Date-ServiceDate = new DtpCollection();
public DtpCollection Date-PrescriptionDate = new DtpCollection();
public DtpCollection DATE-CertificationRevision/RecertificationDate = new DtpCollection();
public DtpCollection Date-BeginTherapyDate = new DtpCollection();
public DtpCollection Date-LastCertificationDate = new DtpCollection();
public DtpCollection Date-LastSeenDate = new DtpCollection();
public DtpCollection Date-TestDate = new DtpCollection();
public DtpCollection Date-ShippedDate = new DtpCollection();
public DtpCollection Date-LastX-rayDate = new DtpCollection();
public DtpCollection Date-InitialTreatmentDate = new DtpCollection();
public QtyCollection AmbulancePatientCount = new QtyCollection();
public QtyCollection ObstetricAnesthesiaAdditionalUnits = new QtyCollection();
public MeaCollection TestResult = new MeaCollection();
public Cn1Collection ContractInformation = new Cn1Collection();
public RefCollection RepricedLineItemReferenceNumber = new RefCollection();
public RefCollection AdjustedRepricedLineItemReferenceNumber = new RefCollection();
public RefCollection PriorAuthorization = new RefCollection();
public RefCollection LineItemControlNumber = new RefCollection();
public RefCollection MammographyCertificationNumber = new RefCollection();
public RefCollection ClinicalLaboratoryImprovementAmendment(CLIA) = new RefCollection();
public RefCollection ReferringClinicalLaboratoryImprovementAmendment = new RefCollection();
public RefCollection ImmunizationBatchNumber = new RefCollection();
public RefCollection ReferralNumber = new RefCollection();
public AmtCollection SalesTaxAmount = new AmtCollection();
public AmtCollection PostageClaimedAmount = new AmtCollection();
public K3Collection FileInformation = new K3Collection();
public NteCollection LineNote = new NteCollection();
public NteCollection ThirdPartyOrganizationNotes = new NteCollection();
public Ps1Collection PurchasedServiceInformation = new Ps1Collection();
public HcpCollection LinePricing/RepricingInformation = new HcpCollection();
}
public partial class Loop2410Collection : LoopCollection<Loop2410> {
public Loop2410Collection(){}
}
public partial class Loop2410 : LoopEntity{
public Loop2410(){}
public LinCollection DrugIdentification = new LinCollection();
public CtpCollection DrugQuantity = new CtpCollection();
public RefCollection PrescriptionorCompoundDrugAssociationNumber = new RefCollection();
}
public partial class Loop2420ACollection : LoopCollection<Loop2420A> {
public Loop2420ACollection(){}
}
public partial class Loop2420A : LoopEntity{
public Loop2420A(){}
public Nm1Collection RenderingProviderName = new Nm1Collection();
public PrvCollection RenderingProviderSpecialtyInformation = new PrvCollection();
public RefCollection RenderingProviderSecondaryIdentification = new RefCollection();
}
public partial class Loop2420BCollection : LoopCollection<Loop2420B> {
public Loop2420BCollection(){}
}
public partial class Loop2420B : LoopEntity{
public Loop2420B(){}
public Nm1Collection PurchasedServiceProviderName = new Nm1Collection();
public RefCollection PurchasedServiceProviderSecondaryIdentification = new RefCollection();
}
public partial class Loop2420CCollection : LoopCollection<Loop2420C> {
public Loop2420CCollection(){}
}
public partial class Loop2420C : LoopEntity{
public Loop2420C(){}
public Nm1Collection ServiceFacilityLocationName = new Nm1Collection();
public N3Collection ServiceFacilityLocationAddress = new N3Collection();
public N4Collection "ServiceFacilityLocationCity,State,ZIPCode" = new N4Collection();
public RefCollection ServiceFacilityLocationSecondaryIdentification = new RefCollection();
}
public partial class Loop2420DCollection : LoopCollection<Loop2420D> {
public Loop2420DCollection(){}
}
public partial class Loop2420D : LoopEntity{
public Loop2420D(){}
public Nm1Collection SupervisingProviderName = new Nm1Collection();
public RefCollection SupervisingProviderSecondaryIdentification = new RefCollection();
}
public partial class Loop2420ECollection : LoopCollection<Loop2420E> {
public Loop2420ECollection(){}
}
public partial class Loop2420E : LoopEntity{
public Loop2420E(){}
public Nm1Collection OrderingProviderName = new Nm1Collection();
public N3Collection OrderingProviderAddress = new N3Collection();
public N4Collection "OrderingProviderCity,State,ZIPCode" = new N4Collection();
public RefCollection OrderingProviderSecondaryIdentification = new RefCollection();
public PerCollection OrderingProviderContactInformation = new PerCollection();
}
public partial class Loop2420FCollection : LoopCollection<Loop2420F> {
public Loop2420FCollection(){}
}
public partial class Loop2420F : LoopEntity{
public Loop2420F(){}
public Nm1Collection ReferringProviderName = new Nm1Collection();
public RefCollection ReferringProviderSecondaryIdentification = new RefCollection();
}
public partial class Loop2420GCollection : LoopCollection<Loop2420G> {
public Loop2420GCollection(){}
}
public partial class Loop2420G : LoopEntity{
public Loop2420G(){}
public Nm1Collection AmbulancePick-upLocation = new Nm1Collection();
public N3Collection AmbulancePick-upLocationAddress = new N3Collection();
public N4Collection "AmbulancePick-upLocationCity,State,ZIPCode" = new N4Collection();
}
public partial class Loop2420HCollection : LoopCollection<Loop2420H> {
public Loop2420HCollection(){}
}
public partial class Loop2420H : LoopEntity{
public Loop2420H(){}
public Nm1Collection AmbulanceDrop-offLocation = new Nm1Collection();
public N3Collection AmbulanceDrop-offLocationAddress = new N3Collection();
public N4Collection "AmbulanceDrop-offLocationCity,State,ZIPCode" = new N4Collection();
}
public partial class Loop2430Collection : LoopCollection<Loop2430> {
public Loop2430Collection(){}
}
public partial class Loop2430 : LoopEntity{
public Loop2430(){}
public SvdCollection LineAdjudicationInformation = new SvdCollection();
public CasCollection LineAdjustment = new CasCollection();
public DtpCollection LineCheckorRemittanceDate = new DtpCollection();
public AmtCollection RemainingPatientLiability = new AmtCollection();
}
public partial class Loop2440Collection : LoopCollection<Loop2440> {
public Loop2440Collection(){}
}
public partial class Loop2440 : LoopEntity{
public Loop2440(){}
public LqCollection FormIdentificationCode = new LqCollection();
public FrmCollection SupportingDocumentation = new FrmCollection();
public SeCollection TransactionSetTrailer = new SeCollection();
}
