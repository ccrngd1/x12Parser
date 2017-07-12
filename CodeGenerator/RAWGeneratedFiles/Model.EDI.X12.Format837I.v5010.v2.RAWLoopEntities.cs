public partial class Loop1000A : LoopEntity{
	public Nm1Collection SubmitterName {get;set;}
	public PerCollection SubmitterEdiContactInformation {get;set;}
public Loop1000A(LoopCollectionBase parent):base(parent){
SubmitterName = new Nm1Collection(this, nameof(SubmitterName));
SegmentCollections.Add(SubmitterName);
SubmitterEdiContactInformation = new PerCollection(this, nameof(SubmitterEdiContactInformation));
SegmentCollections.Add(SubmitterEdiContactInformation);
 
}
}
public partial class Loop1000B : LoopEntity{
	public Nm1Collection ReceiverName {get;set;}
public Loop1000B(LoopCollectionBase parent):base(parent){
ReceiverName = new Nm1Collection(this, nameof(ReceiverName));
SegmentCollections.Add(ReceiverName);
 
}
}
public partial class Loop2000A : LoopEntity{
	public HlCollection BillingProviderHierarchicalLevel {get;set;}
	public PrvCollection BillingProviderSpecialtyInformation {get;set;}
	public CurCollection ForeignCurrencyInformation {get;set;}
	public Loop2010AACollection BillingProviderNameLoop {get;set;}
	public Loop2010ABCollection Pay-toAddressNameLoop {get;set;}
public Loop2000A(LoopCollectionBase parent):base(parent){
BillingProviderHierarchicalLevel = new HlCollection(this, nameof(BillingProviderHierarchicalLevel));
SegmentCollections.Add(BillingProviderHierarchicalLevel);
BillingProviderSpecialtyInformation = new PrvCollection(this, nameof(BillingProviderSpecialtyInformation));
SegmentCollections.Add(BillingProviderSpecialtyInformation);
ForeignCurrencyInformation = new CurCollection(this, nameof(ForeignCurrencyInformation));
SegmentCollections.Add(ForeignCurrencyInformation);
 
BillingProviderNameLoop = new Loop2010AACollection("Loop2010AA", nameof(BillingProviderNameLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(BillingProviderNameLoop);
Pay-toAddressNameLoop = new Loop2010ABCollection("Loop2010AB", nameof(Pay-toAddressNameLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(Pay-toAddressNameLoop);
}
}
public partial class Loop2010AA : LoopEntity{
	public Nm1Collection BillingProviderName {get;set;}
	public N3Collection BillingProviderAddress {get;set;}
	public N4Collection billingProviderCity,State,ZipCode" {get;set;}
	public RefCollection BillingProviderTaxIdentification {get;set;}
	public PerCollection BillingProviderContactInformation {get;set;}
public Loop2010AA(LoopCollectionBase parent):base(parent){
BillingProviderName = new Nm1Collection(this, nameof(BillingProviderName));
SegmentCollections.Add(BillingProviderName);
BillingProviderAddress = new N3Collection(this, nameof(BillingProviderAddress));
SegmentCollections.Add(BillingProviderAddress);
billingProviderCity,State,ZipCode" = new N4Collection(this, nameof(billingProviderCity,State,ZipCode"));
SegmentCollections.Add(billingProviderCity,State,ZipCode");
BillingProviderTaxIdentification = new RefCollection(this, nameof(BillingProviderTaxIdentification));
SegmentCollections.Add(BillingProviderTaxIdentification);
BillingProviderContactInformation = new PerCollection(this, nameof(BillingProviderContactInformation));
SegmentCollections.Add(BillingProviderContactInformation);
 
}
}
public partial class Loop2010AB : LoopEntity{
	public Nm1Collection Pay-toAddressName {get;set;}
	public N3Collection Pay-toAddress
Address {get;set;}
	public N4Collection pay-toAddressCity,State,ZipCode" {get;set;}
	public Loop2010ACCollection Pay-toPlanNameLoop {get;set;}
	public Loop2000BCollection SubscriberHierarchicalLevelLoop {get;set;}
public Loop2010AB(LoopCollectionBase parent):base(parent){
Pay-toAddressName = new Nm1Collection(this, nameof(Pay-toAddressName));
SegmentCollections.Add(Pay-toAddressName);
Pay-toAddress
Address = new N3Collection(this, nameof(Pay-toAddress
Address));
SegmentCollections.Add(Pay-toAddress
Address);
pay-toAddressCity,State,ZipCode" = new N4Collection(this, nameof(pay-toAddressCity,State,ZipCode"));
SegmentCollections.Add(pay-toAddressCity,State,ZipCode");
 
Pay-toPlanNameLoop = new Loop2010ACCollection("Loop2010AC", nameof(Pay-toPlanNameLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(Pay-toPlanNameLoop);
SubscriberHierarchicalLevelLoop = new Loop2000BCollection("Loop2000B", nameof(SubscriberHierarchicalLevelLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(SubscriberHierarchicalLevelLoop);
}
}
public partial class Loop2010AC : LoopEntity{
	public Nm1Collection Pay-toPlanName {get;set;}
	public N3Collection Pay-toPlanAddress {get;set;}
	public N4Collection pay-toPlanCity,State,ZipCode" {get;set;}
	public RefCollection Pay-toPlanSecondaryIdentification {get;set;}
	public RefCollection Pay-toPlanTaxIdentificationNumber {get;set;}
public Loop2010AC(LoopCollectionBase parent):base(parent){
Pay-toPlanName = new Nm1Collection(this, nameof(Pay-toPlanName));
SegmentCollections.Add(Pay-toPlanName);
Pay-toPlanAddress = new N3Collection(this, nameof(Pay-toPlanAddress));
SegmentCollections.Add(Pay-toPlanAddress);
pay-toPlanCity,State,ZipCode" = new N4Collection(this, nameof(pay-toPlanCity,State,ZipCode"));
SegmentCollections.Add(pay-toPlanCity,State,ZipCode");
Pay-toPlanSecondaryIdentification = new RefCollection(this, nameof(Pay-toPlanSecondaryIdentification));
SegmentCollections.Add(Pay-toPlanSecondaryIdentification);
Pay-toPlanTaxIdentificationNumber = new RefCollection(this, nameof(Pay-toPlanTaxIdentificationNumber));
SegmentCollections.Add(Pay-toPlanTaxIdentificationNumber);
 
}
}
public partial class Loop2000B : LoopEntity{
	public HlCollection SubscriberHierarchicalLevel {get;set;}
	public SbrCollection SubscriberInformation {get;set;}
	public Loop2010BACollection SubscriberNameLoop {get;set;}
	public Loop2010BBCollection PayerNameLoop {get;set;}
	public Loop2310ACollection AttendingProviderNameLoop {get;set;}
	public Loop2310CCollection OtherOperatingPhysicianNameLoop {get;set;}
	public Loop2310ECollection ServiceFacilityLocationNameLoop {get;set;}
public Loop2000B(LoopCollectionBase parent):base(parent){
SubscriberHierarchicalLevel = new HlCollection(this, nameof(SubscriberHierarchicalLevel));
SegmentCollections.Add(SubscriberHierarchicalLevel);
SubscriberInformation = new SbrCollection(this, nameof(SubscriberInformation));
SegmentCollections.Add(SubscriberInformation);
 
SubscriberNameLoop = new Loop2010BACollection("Loop2010BA", nameof(SubscriberNameLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(SubscriberNameLoop);
PayerNameLoop = new Loop2010BBCollection("Loop2010BB", nameof(PayerNameLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(PayerNameLoop);
AttendingProviderNameLoop = new Loop2310ACollection("Loop2310A", nameof(AttendingProviderNameLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(AttendingProviderNameLoop);
OtherOperatingPhysicianNameLoop = new Loop2310CCollection("Loop2310C", nameof(OtherOperatingPhysicianNameLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(OtherOperatingPhysicianNameLoop);
ServiceFacilityLocationNameLoop = new Loop2310ECollection("Loop2310E", nameof(ServiceFacilityLocationNameLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(ServiceFacilityLocationNameLoop);
}
}
public partial class Loop2010BA : LoopEntity{
	public Nm1Collection SubscriberName {get;set;}
	public N3Collection SubscriberAddress {get;set;}
	public N4Collection subscriberCity,State,ZipCode" {get;set;}
	public DmgCollection SubscriberDemographicInformation {get;set;}
	public RefCollection SubscriberSecondaryIdentification {get;set;}
	public RefCollection PropertyAndCasualtyClaimNumber {get;set;}
public Loop2010BA(LoopCollectionBase parent):base(parent){
SubscriberName = new Nm1Collection(this, nameof(SubscriberName));
SegmentCollections.Add(SubscriberName);
SubscriberAddress = new N3Collection(this, nameof(SubscriberAddress));
SegmentCollections.Add(SubscriberAddress);
subscriberCity,State,ZipCode" = new N4Collection(this, nameof(subscriberCity,State,ZipCode"));
SegmentCollections.Add(subscriberCity,State,ZipCode");
SubscriberDemographicInformation = new DmgCollection(this, nameof(SubscriberDemographicInformation));
SegmentCollections.Add(SubscriberDemographicInformation);
SubscriberSecondaryIdentification = new RefCollection(this, nameof(SubscriberSecondaryIdentification));
SegmentCollections.Add(SubscriberSecondaryIdentification);
PropertyAndCasualtyClaimNumber = new RefCollection(this, nameof(PropertyAndCasualtyClaimNumber));
SegmentCollections.Add(PropertyAndCasualtyClaimNumber);
 
}
}
public partial class Loop2010BB : LoopEntity{
	public Nm1Collection PayerName {get;set;}
	public N3Collection PayerAddress {get;set;}
	public N4Collection payerCity,State,ZipCode" {get;set;}
	public RefCollection PayerSecondaryIdentification {get;set;}
	public RefCollection BillingProviderSecondaryIdentification {get;set;}
	public Loop2000CCollection PatientHierarchicalLevelLoop {get;set;}
	public Loop2010CACollection PatientNameLoop {get;set;}
	public Loop2300Collection ClaimInformationLoop {get;set;}
public Loop2010BB(LoopCollectionBase parent):base(parent){
PayerName = new Nm1Collection(this, nameof(PayerName));
SegmentCollections.Add(PayerName);
PayerAddress = new N3Collection(this, nameof(PayerAddress));
SegmentCollections.Add(PayerAddress);
payerCity,State,ZipCode" = new N4Collection(this, nameof(payerCity,State,ZipCode"));
SegmentCollections.Add(payerCity,State,ZipCode");
PayerSecondaryIdentification = new RefCollection(this, nameof(PayerSecondaryIdentification));
SegmentCollections.Add(PayerSecondaryIdentification);
BillingProviderSecondaryIdentification = new RefCollection(this, nameof(BillingProviderSecondaryIdentification));
SegmentCollections.Add(BillingProviderSecondaryIdentification);
 
PatientHierarchicalLevelLoop = new Loop2000CCollection("Loop2000C", nameof(PatientHierarchicalLevelLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(PatientHierarchicalLevelLoop);
PatientNameLoop = new Loop2010CACollection("Loop2010CA", nameof(PatientNameLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(PatientNameLoop);
ClaimInformationLoop = new Loop2300Collection("Loop2300", nameof(ClaimInformationLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(ClaimInformationLoop);
}
}
public partial class Loop2000C : LoopEntity{
	public HlCollection PatientHierarchicalLevel {get;set;}
	public PatCollection PatientInformation {get;set;}
public Loop2000C(LoopCollectionBase parent):base(parent){
PatientHierarchicalLevel = new HlCollection(this, nameof(PatientHierarchicalLevel));
SegmentCollections.Add(PatientHierarchicalLevel);
PatientInformation = new PatCollection(this, nameof(PatientInformation));
SegmentCollections.Add(PatientInformation);
 
}
}
public partial class Loop2010CA : LoopEntity{
	public Nm1Collection PatientName {get;set;}
	public N3Collection PatientAddress {get;set;}
	public N4Collection patientCity,State,ZipCode" {get;set;}
	public DmgCollection PatientDemographicInformation {get;set;}
	public RefCollection PropertyAndCasualtyClaimNumber {get;set;}
	public RefCollection PropertyAndCasualtyPatientIdentifier {get;set;}
public Loop2010CA(LoopCollectionBase parent):base(parent){
PatientName = new Nm1Collection(this, nameof(PatientName));
SegmentCollections.Add(PatientName);
PatientAddress = new N3Collection(this, nameof(PatientAddress));
SegmentCollections.Add(PatientAddress);
patientCity,State,ZipCode" = new N4Collection(this, nameof(patientCity,State,ZipCode"));
SegmentCollections.Add(patientCity,State,ZipCode");
PatientDemographicInformation = new DmgCollection(this, nameof(PatientDemographicInformation));
SegmentCollections.Add(PatientDemographicInformation);
PropertyAndCasualtyClaimNumber = new RefCollection(this, nameof(PropertyAndCasualtyClaimNumber));
SegmentCollections.Add(PropertyAndCasualtyClaimNumber);
PropertyAndCasualtyPatientIdentifier = new RefCollection(this, nameof(PropertyAndCasualtyPatientIdentifier));
SegmentCollections.Add(PropertyAndCasualtyPatientIdentifier);
 
}
}
public partial class Loop2300 : LoopEntity{
	public ClmCollection ClaimInformation {get;set;}
	public DtpCollection DischargeHour {get;set;}
	public DtpCollection StatementDates {get;set;}
	public DtpCollection AdmissionDate/hour {get;set;}
	public DtpCollection Date
RepricerReceivedDate {get;set;}
	public Cl1Collection InstitutionalClaimCode {get;set;}
	public PwkCollection ClaimSupplementalInformation {get;set;}
	public Cn1Collection ContractInformation {get;set;}
	public AmtCollection PatientEstimatedAmountDue {get;set;}
	public RefCollection ServiceAuthorizationExceptionCode {get;set;}
	public RefCollection ReferralNumber {get;set;}
	public RefCollection PriorAuthorization {get;set;}
	public RefCollection PayerClaimControlNumber {get;set;}
	public RefCollection RepricedClaimNumber {get;set;}
	public RefCollection AdjustedRepricedClaimNumber {get;set;}
	public RefCollection InvestigationalDeviceExemptionNumber {get;set;}
	public RefCollection ClaimIdentifierForTransmissionIntermediaries {get;set;}
	public RefCollection AutoAccidentState {get;set;}
	public RefCollection MedicalRecordNumber {get;set;}
	public RefCollection DemonstrationProjectIdentifier {get;set;}
	public RefCollection PeerReviewOrganizationpro)ApprovalNumber {get;set;}
	public K3Collection FileInformation {get;set;}
	public NteCollection ClaimNote {get;set;}
	public NteCollection BillingNote {get;set;}
	public CrcCollection EpsdtReferral {get;set;}
	public HiCollection PrincipalDiagnosis {get;set;}
	public HiCollection AdmittingDiagnosis {get;set;}
	public HiCollection Patient�sReasonForVisit {get;set;}
	public HiCollection ExternalCauseOfInjury {get;set;}
	public HiCollection DiagnosisRelatedGroupdrg)Information {get;set;}
	public HiCollection OtherDiagnosisInformation {get;set;}
	public HiCollection PrincipalProcedureInformation {get;set;}
	public HiCollection OtherProcedureInformation {get;set;}
	public HiCollection OccurrenceSpanInformation {get;set;}
	public HiCollection OccurrenceInformation {get;set;}
	public HiCollection ValueInformation {get;set;}
	public HiCollection ConditionInformation {get;set;}
	public HiCollection TreatmentCodeInformation {get;set;}
	public HcpCollection ClaimPricing/repricingInformation {get;set;}
public Loop2300(LoopCollectionBase parent):base(parent){
ClaimInformation = new ClmCollection(this, nameof(ClaimInformation));
SegmentCollections.Add(ClaimInformation);
DischargeHour = new DtpCollection(this, nameof(DischargeHour));
SegmentCollections.Add(DischargeHour);
StatementDates = new DtpCollection(this, nameof(StatementDates));
SegmentCollections.Add(StatementDates);
AdmissionDate/hour = new DtpCollection(this, nameof(AdmissionDate/hour));
SegmentCollections.Add(AdmissionDate/hour);
Date
RepricerReceivedDate = new DtpCollection(this, nameof(Date
RepricerReceivedDate));
SegmentCollections.Add(Date
RepricerReceivedDate);
InstitutionalClaimCode = new Cl1Collection(this, nameof(InstitutionalClaimCode));
SegmentCollections.Add(InstitutionalClaimCode);
ClaimSupplementalInformation = new PwkCollection(this, nameof(ClaimSupplementalInformation));
SegmentCollections.Add(ClaimSupplementalInformation);
ContractInformation = new Cn1Collection(this, nameof(ContractInformation));
SegmentCollections.Add(ContractInformation);
PatientEstimatedAmountDue = new AmtCollection(this, nameof(PatientEstimatedAmountDue));
SegmentCollections.Add(PatientEstimatedAmountDue);
ServiceAuthorizationExceptionCode = new RefCollection(this, nameof(ServiceAuthorizationExceptionCode));
SegmentCollections.Add(ServiceAuthorizationExceptionCode);
ReferralNumber = new RefCollection(this, nameof(ReferralNumber));
SegmentCollections.Add(ReferralNumber);
PriorAuthorization = new RefCollection(this, nameof(PriorAuthorization));
SegmentCollections.Add(PriorAuthorization);
PayerClaimControlNumber = new RefCollection(this, nameof(PayerClaimControlNumber));
SegmentCollections.Add(PayerClaimControlNumber);
RepricedClaimNumber = new RefCollection(this, nameof(RepricedClaimNumber));
SegmentCollections.Add(RepricedClaimNumber);
AdjustedRepricedClaimNumber = new RefCollection(this, nameof(AdjustedRepricedClaimNumber));
SegmentCollections.Add(AdjustedRepricedClaimNumber);
InvestigationalDeviceExemptionNumber = new RefCollection(this, nameof(InvestigationalDeviceExemptionNumber));
SegmentCollections.Add(InvestigationalDeviceExemptionNumber);
ClaimIdentifierForTransmissionIntermediaries = new RefCollection(this, nameof(ClaimIdentifierForTransmissionIntermediaries));
SegmentCollections.Add(ClaimIdentifierForTransmissionIntermediaries);
AutoAccidentState = new RefCollection(this, nameof(AutoAccidentState));
SegmentCollections.Add(AutoAccidentState);
MedicalRecordNumber = new RefCollection(this, nameof(MedicalRecordNumber));
SegmentCollections.Add(MedicalRecordNumber);
DemonstrationProjectIdentifier = new RefCollection(this, nameof(DemonstrationProjectIdentifier));
SegmentCollections.Add(DemonstrationProjectIdentifier);
PeerReviewOrganizationpro)ApprovalNumber = new RefCollection(this, nameof(PeerReviewOrganizationpro)ApprovalNumber));
SegmentCollections.Add(PeerReviewOrganizationpro)ApprovalNumber);
FileInformation = new K3Collection(this, nameof(FileInformation));
SegmentCollections.Add(FileInformation);
ClaimNote = new NteCollection(this, nameof(ClaimNote));
SegmentCollections.Add(ClaimNote);
BillingNote = new NteCollection(this, nameof(BillingNote));
SegmentCollections.Add(BillingNote);
EpsdtReferral = new CrcCollection(this, nameof(EpsdtReferral));
SegmentCollections.Add(EpsdtReferral);
PrincipalDiagnosis = new HiCollection(this, nameof(PrincipalDiagnosis));
SegmentCollections.Add(PrincipalDiagnosis);
AdmittingDiagnosis = new HiCollection(this, nameof(AdmittingDiagnosis));
SegmentCollections.Add(AdmittingDiagnosis);
Patient�sReasonForVisit = new HiCollection(this, nameof(Patient�sReasonForVisit));
SegmentCollections.Add(Patient�sReasonForVisit);
ExternalCauseOfInjury = new HiCollection(this, nameof(ExternalCauseOfInjury));
SegmentCollections.Add(ExternalCauseOfInjury);
DiagnosisRelatedGroupdrg)Information = new HiCollection(this, nameof(DiagnosisRelatedGroupdrg)Information));
SegmentCollections.Add(DiagnosisRelatedGroupdrg)Information);
OtherDiagnosisInformation = new HiCollection(this, nameof(OtherDiagnosisInformation));
SegmentCollections.Add(OtherDiagnosisInformation);
PrincipalProcedureInformation = new HiCollection(this, nameof(PrincipalProcedureInformation));
SegmentCollections.Add(PrincipalProcedureInformation);
OtherProcedureInformation = new HiCollection(this, nameof(OtherProcedureInformation));
SegmentCollections.Add(OtherProcedureInformation);
OccurrenceSpanInformation = new HiCollection(this, nameof(OccurrenceSpanInformation));
SegmentCollections.Add(OccurrenceSpanInformation);
OccurrenceInformation = new HiCollection(this, nameof(OccurrenceInformation));
SegmentCollections.Add(OccurrenceInformation);
ValueInformation = new HiCollection(this, nameof(ValueInformation));
SegmentCollections.Add(ValueInformation);
ConditionInformation = new HiCollection(this, nameof(ConditionInformation));
SegmentCollections.Add(ConditionInformation);
TreatmentCodeInformation = new HiCollection(this, nameof(TreatmentCodeInformation));
SegmentCollections.Add(TreatmentCodeInformation);
ClaimPricing/repricingInformation = new HcpCollection(this, nameof(ClaimPricing/repricingInformation));
SegmentCollections.Add(ClaimPricing/repricingInformation);
 
}
}
public partial class Loop2310A : LoopEntity{
	public Nm1Collection AttendingProviderName {get;set;}
	public PrvCollection AttendingProviderSpecialtyInformation {get;set;}
	public RefCollection AttendingProviderSecondaryIdentification {get;set;}
	public Loop2310BCollection OperatingPhysicianNameLoop {get;set;}
public Loop2310A(LoopCollectionBase parent):base(parent){
AttendingProviderName = new Nm1Collection(this, nameof(AttendingProviderName));
SegmentCollections.Add(AttendingProviderName);
AttendingProviderSpecialtyInformation = new PrvCollection(this, nameof(AttendingProviderSpecialtyInformation));
SegmentCollections.Add(AttendingProviderSpecialtyInformation);
AttendingProviderSecondaryIdentification = new RefCollection(this, nameof(AttendingProviderSecondaryIdentification));
SegmentCollections.Add(AttendingProviderSecondaryIdentification);
 
OperatingPhysicianNameLoop = new Loop2310BCollection("Loop2310B", nameof(OperatingPhysicianNameLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(OperatingPhysicianNameLoop);
}
}
public partial class Loop2310B : LoopEntity{
	public Nm1Collection OperatingPhysicianName {get;set;}
	public RefCollection OperatingPhysicianSecondaryIdentification {get;set;}
public Loop2310B(LoopCollectionBase parent):base(parent){
OperatingPhysicianName = new Nm1Collection(this, nameof(OperatingPhysicianName));
SegmentCollections.Add(OperatingPhysicianName);
OperatingPhysicianSecondaryIdentification = new RefCollection(this, nameof(OperatingPhysicianSecondaryIdentification));
SegmentCollections.Add(OperatingPhysicianSecondaryIdentification);
 
}
}
public partial class Loop2310C : LoopEntity{
	public Nm1Collection OtherOperatingPhysicianName {get;set;}
	public RefCollection OtherOperatingPhysicianSecondaryIdentification {get;set;}
	public Loop2310DCollection RenderingProviderNameLoop {get;set;}
public Loop2310C(LoopCollectionBase parent):base(parent){
OtherOperatingPhysicianName = new Nm1Collection(this, nameof(OtherOperatingPhysicianName));
SegmentCollections.Add(OtherOperatingPhysicianName);
OtherOperatingPhysicianSecondaryIdentification = new RefCollection(this, nameof(OtherOperatingPhysicianSecondaryIdentification));
SegmentCollections.Add(OtherOperatingPhysicianSecondaryIdentification);
 
RenderingProviderNameLoop = new Loop2310DCollection("Loop2310D", nameof(RenderingProviderNameLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(RenderingProviderNameLoop);
}
}
public partial class Loop2310D : LoopEntity{
	public Nm1Collection RenderingProviderName {get;set;}
	public RefCollection RenderingProviderSecondaryIdentification {get;set;}
public Loop2310D(LoopCollectionBase parent):base(parent){
RenderingProviderName = new Nm1Collection(this, nameof(RenderingProviderName));
SegmentCollections.Add(RenderingProviderName);
RenderingProviderSecondaryIdentification = new RefCollection(this, nameof(RenderingProviderSecondaryIdentification));
SegmentCollections.Add(RenderingProviderSecondaryIdentification);
 
}
}
public partial class Loop2310E : LoopEntity{
	public Nm1Collection ServiceFacilityLocationName {get;set;}
	public N3Collection ServiceFacilityLocationAddress {get;set;}
	public N4Collection serviceFacilityLocationCity,State,ZipCode" {get;set;}
	public RefCollection ServiceFacilityLocationSecondaryIdentification {get;set;}
	public Loop2310FCollection ReferringProviderNameLoop {get;set;}
	public Loop2320Collection OtherSubscriberInformationLoop {get;set;}
	public Loop2330CCollection OtherPayerAttendingProviderLoop {get;set;}
	public Loop2330DCollection OtherPayerOperatingPhysicianLoop {get;set;}
	public Loop2330ECollection OtherPayerOtherOperatingPhysicianLoop {get;set;}
	public Loop2330FCollection OtherPayerServiceFacilityLocationLoop {get;set;}
	public Loop2330GCollection OtherPayerRenderingProviderNameLoop {get;set;}
	public Loop2330HCollection OtherPayerReferringProviderLoop {get;set;}
	public Loop2420BCollection OtherOperatingPhysicianNameLoop {get;set;}
public Loop2310E(LoopCollectionBase parent):base(parent){
ServiceFacilityLocationName = new Nm1Collection(this, nameof(ServiceFacilityLocationName));
SegmentCollections.Add(ServiceFacilityLocationName);
ServiceFacilityLocationAddress = new N3Collection(this, nameof(ServiceFacilityLocationAddress));
SegmentCollections.Add(ServiceFacilityLocationAddress);
serviceFacilityLocationCity,State,ZipCode" = new N4Collection(this, nameof(serviceFacilityLocationCity,State,ZipCode"));
SegmentCollections.Add(serviceFacilityLocationCity,State,ZipCode");
ServiceFacilityLocationSecondaryIdentification = new RefCollection(this, nameof(ServiceFacilityLocationSecondaryIdentification));
SegmentCollections.Add(ServiceFacilityLocationSecondaryIdentification);
 
ReferringProviderNameLoop = new Loop2310FCollection("Loop2310F", nameof(ReferringProviderNameLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(ReferringProviderNameLoop);
OtherSubscriberInformationLoop = new Loop2320Collection("Loop2320", nameof(OtherSubscriberInformationLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(OtherSubscriberInformationLoop);
OtherPayerAttendingProviderLoop = new Loop2330CCollection("Loop2330C", nameof(OtherPayerAttendingProviderLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(OtherPayerAttendingProviderLoop);
OtherPayerOperatingPhysicianLoop = new Loop2330DCollection("Loop2330D", nameof(OtherPayerOperatingPhysicianLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(OtherPayerOperatingPhysicianLoop);
OtherPayerOtherOperatingPhysicianLoop = new Loop2330ECollection("Loop2330E", nameof(OtherPayerOtherOperatingPhysicianLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(OtherPayerOtherOperatingPhysicianLoop);
OtherPayerServiceFacilityLocationLoop = new Loop2330FCollection("Loop2330F", nameof(OtherPayerServiceFacilityLocationLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(OtherPayerServiceFacilityLocationLoop);
OtherPayerRenderingProviderNameLoop = new Loop2330GCollection("Loop2330G", nameof(OtherPayerRenderingProviderNameLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(OtherPayerRenderingProviderNameLoop);
OtherPayerReferringProviderLoop = new Loop2330HCollection("Loop2330H", nameof(OtherPayerReferringProviderLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(OtherPayerReferringProviderLoop);
OtherOperatingPhysicianNameLoop = new Loop2420BCollection("Loop2420B", nameof(OtherOperatingPhysicianNameLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(OtherOperatingPhysicianNameLoop);
}
}
public partial class Loop2310F : LoopEntity{
	public Nm1Collection ReferringProviderName {get;set;}
	public RefCollection ReferringProviderSecondaryIdentification {get;set;}
public Loop2310F(LoopCollectionBase parent):base(parent){
ReferringProviderName = new Nm1Collection(this, nameof(ReferringProviderName));
SegmentCollections.Add(ReferringProviderName);
ReferringProviderSecondaryIdentification = new RefCollection(this, nameof(ReferringProviderSecondaryIdentification));
SegmentCollections.Add(ReferringProviderSecondaryIdentification);
 
}
}
public partial class Loop2320 : LoopEntity{
	public SbrCollection OtherSubscriberInformation {get;set;}
	public CasCollection ClaimLevelAdjustments {get;set;}
	public AmtCollection CoordinationOfBenefitscob)PayerPaidAmount {get;set;}
	public AmtCollection RemainingPatientLiability {get;set;}
	public AmtCollection CoordinationOfBenefitscob)TotalNon-covered {get;set;}
	public OiCollection OtherInsuranceCoverageInformation {get;set;}
	public MiaCollection InpatientAdjudicationInformation {get;set;}
	public MoaCollection OutpatientAdjudicationInformation {get;set;}
	public Loop2330ACollection OtherSubscriberNameLoop {get;set;}
public Loop2320(LoopCollectionBase parent):base(parent){
OtherSubscriberInformation = new SbrCollection(this, nameof(OtherSubscriberInformation));
SegmentCollections.Add(OtherSubscriberInformation);
ClaimLevelAdjustments = new CasCollection(this, nameof(ClaimLevelAdjustments));
SegmentCollections.Add(ClaimLevelAdjustments);
CoordinationOfBenefitscob)PayerPaidAmount = new AmtCollection(this, nameof(CoordinationOfBenefitscob)PayerPaidAmount));
SegmentCollections.Add(CoordinationOfBenefitscob)PayerPaidAmount);
RemainingPatientLiability = new AmtCollection(this, nameof(RemainingPatientLiability));
SegmentCollections.Add(RemainingPatientLiability);
CoordinationOfBenefitscob)TotalNon-covered = new AmtCollection(this, nameof(CoordinationOfBenefitscob)TotalNon-covered));
SegmentCollections.Add(CoordinationOfBenefitscob)TotalNon-covered);
OtherInsuranceCoverageInformation = new OiCollection(this, nameof(OtherInsuranceCoverageInformation));
SegmentCollections.Add(OtherInsuranceCoverageInformation);
InpatientAdjudicationInformation = new MiaCollection(this, nameof(InpatientAdjudicationInformation));
SegmentCollections.Add(InpatientAdjudicationInformation);
OutpatientAdjudicationInformation = new MoaCollection(this, nameof(OutpatientAdjudicationInformation));
SegmentCollections.Add(OutpatientAdjudicationInformation);
 
OtherSubscriberNameLoop = new Loop2330ACollection("Loop2330A", nameof(OtherSubscriberNameLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(OtherSubscriberNameLoop);
}
}
public partial class Loop2330A : LoopEntity{
	public Nm1Collection OtherSubscriberName {get;set;}
	public N3Collection OtherSubscriberAddress {get;set;}
	public N4Collection otherSubscriberCity,State,ZipCode" {get;set;}
	public RefCollection OtherSubscriberSecondaryIdentification {get;set;}
	public Loop2330BCollection OtherPayerNameLoop {get;set;}
public Loop2330A(LoopCollectionBase parent):base(parent){
OtherSubscriberName = new Nm1Collection(this, nameof(OtherSubscriberName));
SegmentCollections.Add(OtherSubscriberName);
OtherSubscriberAddress = new N3Collection(this, nameof(OtherSubscriberAddress));
SegmentCollections.Add(OtherSubscriberAddress);
otherSubscriberCity,State,ZipCode" = new N4Collection(this, nameof(otherSubscriberCity,State,ZipCode"));
SegmentCollections.Add(otherSubscriberCity,State,ZipCode");
OtherSubscriberSecondaryIdentification = new RefCollection(this, nameof(OtherSubscriberSecondaryIdentification));
SegmentCollections.Add(OtherSubscriberSecondaryIdentification);
 
OtherPayerNameLoop = new Loop2330BCollection("Loop2330B", nameof(OtherPayerNameLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(OtherPayerNameLoop);
}
}
public partial class Loop2330B : LoopEntity{
	public Nm1Collection OtherPayerName {get;set;}
	public N3Collection OtherPayerAddress {get;set;}
	public N4Collection otherPayerCity,State,ZipCode" {get;set;}
	public DtpCollection ClaimCheckOrRemittanceDate {get;set;}
	public RefCollection OtherPayerSecondaryIdentifier {get;set;}
	public RefCollection OtherPayerPriorAuthorizationNumber {get;set;}
	public RefCollection OtherPayerReferralNumber {get;set;}
	public RefCollection OtherPayerClaimAdjustmentIndicator {get;set;}
	public RefCollection OtherPayerClaimControlNumber {get;set;}
public Loop2330B(LoopCollectionBase parent):base(parent){
OtherPayerName = new Nm1Collection(this, nameof(OtherPayerName));
SegmentCollections.Add(OtherPayerName);
OtherPayerAddress = new N3Collection(this, nameof(OtherPayerAddress));
SegmentCollections.Add(OtherPayerAddress);
otherPayerCity,State,ZipCode" = new N4Collection(this, nameof(otherPayerCity,State,ZipCode"));
SegmentCollections.Add(otherPayerCity,State,ZipCode");
ClaimCheckOrRemittanceDate = new DtpCollection(this, nameof(ClaimCheckOrRemittanceDate));
SegmentCollections.Add(ClaimCheckOrRemittanceDate);
OtherPayerSecondaryIdentifier = new RefCollection(this, nameof(OtherPayerSecondaryIdentifier));
SegmentCollections.Add(OtherPayerSecondaryIdentifier);
OtherPayerPriorAuthorizationNumber = new RefCollection(this, nameof(OtherPayerPriorAuthorizationNumber));
SegmentCollections.Add(OtherPayerPriorAuthorizationNumber);
OtherPayerReferralNumber = new RefCollection(this, nameof(OtherPayerReferralNumber));
SegmentCollections.Add(OtherPayerReferralNumber);
OtherPayerClaimAdjustmentIndicator = new RefCollection(this, nameof(OtherPayerClaimAdjustmentIndicator));
SegmentCollections.Add(OtherPayerClaimAdjustmentIndicator);
OtherPayerClaimControlNumber = new RefCollection(this, nameof(OtherPayerClaimControlNumber));
SegmentCollections.Add(OtherPayerClaimControlNumber);
 
}
}
public partial class Loop2330C : LoopEntity{
	public Nm1Collection OtherPayerAttendingProvider {get;set;}
	public RefCollection OtherPayerAttendingProviderSecondaryIdentification {get;set;}
public Loop2330C(LoopCollectionBase parent):base(parent){
OtherPayerAttendingProvider = new Nm1Collection(this, nameof(OtherPayerAttendingProvider));
SegmentCollections.Add(OtherPayerAttendingProvider);
OtherPayerAttendingProviderSecondaryIdentification = new RefCollection(this, nameof(OtherPayerAttendingProviderSecondaryIdentification));
SegmentCollections.Add(OtherPayerAttendingProviderSecondaryIdentification);
 
}
}
public partial class Loop2330D : LoopEntity{
	public Nm1Collection OtherPayerOperatingPhysician {get;set;}
	public RefCollection OtherPayerOperatingPhysicianSecondaryIdentification {get;set;}
public Loop2330D(LoopCollectionBase parent):base(parent){
OtherPayerOperatingPhysician = new Nm1Collection(this, nameof(OtherPayerOperatingPhysician));
SegmentCollections.Add(OtherPayerOperatingPhysician);
OtherPayerOperatingPhysicianSecondaryIdentification = new RefCollection(this, nameof(OtherPayerOperatingPhysicianSecondaryIdentification));
SegmentCollections.Add(OtherPayerOperatingPhysicianSecondaryIdentification);
 
}
}
public partial class Loop2330E : LoopEntity{
	public Nm1Collection OtherPayerOtherOperatingPhysician {get;set;}
public Loop2330E(LoopCollectionBase parent):base(parent){
OtherPayerOtherOperatingPhysician = new Nm1Collection(this, nameof(OtherPayerOtherOperatingPhysician));
SegmentCollections.Add(OtherPayerOtherOperatingPhysician);
 
}
}
public partial class Loop2330F : LoopEntity{
	public Nm1Collection OtherPayerServiceFacilityLocation {get;set;}
	public RefCollection OtherPayerServiceFacilityLocationSecondary {get;set;}
public Loop2330F(LoopCollectionBase parent):base(parent){
OtherPayerServiceFacilityLocation = new Nm1Collection(this, nameof(OtherPayerServiceFacilityLocation));
SegmentCollections.Add(OtherPayerServiceFacilityLocation);
OtherPayerServiceFacilityLocationSecondary = new RefCollection(this, nameof(OtherPayerServiceFacilityLocationSecondary));
SegmentCollections.Add(OtherPayerServiceFacilityLocationSecondary);
 
}
}
public partial class Loop2330G : LoopEntity{
	public Nm1Collection OtherPayerRenderingProviderName {get;set;}
	public RefCollection OtherPayerRenderingProviderSecondaryIdentification {get;set;}
public Loop2330G(LoopCollectionBase parent):base(parent){
OtherPayerRenderingProviderName = new Nm1Collection(this, nameof(OtherPayerRenderingProviderName));
SegmentCollections.Add(OtherPayerRenderingProviderName);
OtherPayerRenderingProviderSecondaryIdentification = new RefCollection(this, nameof(OtherPayerRenderingProviderSecondaryIdentification));
SegmentCollections.Add(OtherPayerRenderingProviderSecondaryIdentification);
 
}
}
public partial class Loop2330H : LoopEntity{
	public Nm1Collection OtherPayerReferringProvider {get;set;}
	public RefCollection OtherPayerReferringProviderSecondaryIdentification {get;set;}
	public Loop2330ICollection OtherPayerBillingProviderLoop {get;set;}
public Loop2330H(LoopCollectionBase parent):base(parent){
OtherPayerReferringProvider = new Nm1Collection(this, nameof(OtherPayerReferringProvider));
SegmentCollections.Add(OtherPayerReferringProvider);
OtherPayerReferringProviderSecondaryIdentification = new RefCollection(this, nameof(OtherPayerReferringProviderSecondaryIdentification));
SegmentCollections.Add(OtherPayerReferringProviderSecondaryIdentification);
 
OtherPayerBillingProviderLoop = new Loop2330ICollection("Loop2330I", nameof(OtherPayerBillingProviderLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(OtherPayerBillingProviderLoop);
}
}
public partial class Loop2330I : LoopEntity{
	public Nm1Collection OtherPayerBillingProvider {get;set;}
	public RefCollection OtherPayerBillingProviderSecondaryIdentification {get;set;}
	public Loop2400Collection ServiceLineNumberLoop {get;set;}
	public Loop2410Collection DrugIdentificationLoop {get;set;}
	public Loop2420ACollection OperatingPhysicianNameLoop {get;set;}
public Loop2330I(LoopCollectionBase parent):base(parent){
OtherPayerBillingProvider = new Nm1Collection(this, nameof(OtherPayerBillingProvider));
SegmentCollections.Add(OtherPayerBillingProvider);
OtherPayerBillingProviderSecondaryIdentification = new RefCollection(this, nameof(OtherPayerBillingProviderSecondaryIdentification));
SegmentCollections.Add(OtherPayerBillingProviderSecondaryIdentification);
 
ServiceLineNumberLoop = new Loop2400Collection("Loop2400", nameof(ServiceLineNumberLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(ServiceLineNumberLoop);
DrugIdentificationLoop = new Loop2410Collection("Loop2410", nameof(DrugIdentificationLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(DrugIdentificationLoop);
OperatingPhysicianNameLoop = new Loop2420ACollection("Loop2420A", nameof(OperatingPhysicianNameLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(OperatingPhysicianNameLoop);
}
}
public partial class Loop2400 : LoopEntity{
	public LxCollection ServiceLineNumber {get;set;}
	public Sv2Collection InstitutionalServiceLine {get;set;}
	public PwkCollection LineSupplementalInformation {get;set;}
	public DtpCollection Date
ServiceDate {get;set;}
	public RefCollection LineItemControlNumber {get;set;}
	public RefCollection RepricedLineItemReferenceNumber {get;set;}
	public RefCollection AdjustedRepricedLineItemReferenceNumber {get;set;}
	public AmtCollection ServiceTaxAmount {get;set;}
	public AmtCollection FacilityTaxAmount {get;set;}
	public NteCollection ThirdPartyOrganizationNotes {get;set;}
	public HcpCollection LinePricing/repricingInformation {get;set;}
public Loop2400(LoopCollectionBase parent):base(parent){
ServiceLineNumber = new LxCollection(this, nameof(ServiceLineNumber));
SegmentCollections.Add(ServiceLineNumber);
InstitutionalServiceLine = new Sv2Collection(this, nameof(InstitutionalServiceLine));
SegmentCollections.Add(InstitutionalServiceLine);
LineSupplementalInformation = new PwkCollection(this, nameof(LineSupplementalInformation));
SegmentCollections.Add(LineSupplementalInformation);
Date
ServiceDate = new DtpCollection(this, nameof(Date
ServiceDate));
SegmentCollections.Add(Date
ServiceDate);
LineItemControlNumber = new RefCollection(this, nameof(LineItemControlNumber));
SegmentCollections.Add(LineItemControlNumber);
RepricedLineItemReferenceNumber = new RefCollection(this, nameof(RepricedLineItemReferenceNumber));
SegmentCollections.Add(RepricedLineItemReferenceNumber);
AdjustedRepricedLineItemReferenceNumber = new RefCollection(this, nameof(AdjustedRepricedLineItemReferenceNumber));
SegmentCollections.Add(AdjustedRepricedLineItemReferenceNumber);
ServiceTaxAmount = new AmtCollection(this, nameof(ServiceTaxAmount));
SegmentCollections.Add(ServiceTaxAmount);
FacilityTaxAmount = new AmtCollection(this, nameof(FacilityTaxAmount));
SegmentCollections.Add(FacilityTaxAmount);
ThirdPartyOrganizationNotes = new NteCollection(this, nameof(ThirdPartyOrganizationNotes));
SegmentCollections.Add(ThirdPartyOrganizationNotes);
LinePricing/repricingInformation = new HcpCollection(this, nameof(LinePricing/repricingInformation));
SegmentCollections.Add(LinePricing/repricingInformation);
 
}
}
public partial class Loop2410 : LoopEntity{
	public LinCollection DrugIdentification {get;set;}
	public CtpCollection DrugQuantity {get;set;}
	public RefCollection PrescriptionOrCompoundDrugAssociationNumber {get;set;}
public Loop2410(LoopCollectionBase parent):base(parent){
DrugIdentification = new LinCollection(this, nameof(DrugIdentification));
SegmentCollections.Add(DrugIdentification);
DrugQuantity = new CtpCollection(this, nameof(DrugQuantity));
SegmentCollections.Add(DrugQuantity);
PrescriptionOrCompoundDrugAssociationNumber = new RefCollection(this, nameof(PrescriptionOrCompoundDrugAssociationNumber));
SegmentCollections.Add(PrescriptionOrCompoundDrugAssociationNumber);
 
}
}
public partial class Loop2420A : LoopEntity{
	public Nm1Collection OperatingPhysicianName {get;set;}
	public RefCollection OperatingPhysicianSecondaryIdentification {get;set;}
public Loop2420A(LoopCollectionBase parent):base(parent){
OperatingPhysicianName = new Nm1Collection(this, nameof(OperatingPhysicianName));
SegmentCollections.Add(OperatingPhysicianName);
OperatingPhysicianSecondaryIdentification = new RefCollection(this, nameof(OperatingPhysicianSecondaryIdentification));
SegmentCollections.Add(OperatingPhysicianSecondaryIdentification);
 
}
}
public partial class Loop2420B : LoopEntity{
	public Nm1Collection OtherOperatingPhysicianName {get;set;}
	public RefCollection OtherOperatingPhysicianSecondaryIdentification {get;set;}
	public Loop2420CCollection RenderingProviderNameLoop {get;set;}
	public Loop2430Collection LineAdjudicationInformationLoop {get;set;}
public Loop2420B(LoopCollectionBase parent):base(parent){
OtherOperatingPhysicianName = new Nm1Collection(this, nameof(OtherOperatingPhysicianName));
SegmentCollections.Add(OtherOperatingPhysicianName);
OtherOperatingPhysicianSecondaryIdentification = new RefCollection(this, nameof(OtherOperatingPhysicianSecondaryIdentification));
SegmentCollections.Add(OtherOperatingPhysicianSecondaryIdentification);
 
RenderingProviderNameLoop = new Loop2420CCollection("Loop2420C", nameof(RenderingProviderNameLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(RenderingProviderNameLoop);
LineAdjudicationInformationLoop = new Loop2430Collection("Loop2430", nameof(LineAdjudicationInformationLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(LineAdjudicationInformationLoop);
}
}
public partial class Loop2420C : LoopEntity{
	public Nm1Collection RenderingProviderName {get;set;}
	public RefCollection RenderingProviderSecondaryIdentification {get;set;}
	public Loop2420DCollection ReferringProviderNameLoop {get;set;}
public Loop2420C(LoopCollectionBase parent):base(parent){
RenderingProviderName = new Nm1Collection(this, nameof(RenderingProviderName));
SegmentCollections.Add(RenderingProviderName);
RenderingProviderSecondaryIdentification = new RefCollection(this, nameof(RenderingProviderSecondaryIdentification));
SegmentCollections.Add(RenderingProviderSecondaryIdentification);
 
ReferringProviderNameLoop = new Loop2420DCollection("Loop2420D", nameof(ReferringProviderNameLoop), parent.OwningX12Doc, parent);
ChildLoopCollections.Add(ReferringProviderNameLoop);
}
}
public partial class Loop2420D : LoopEntity{
	public Nm1Collection ReferringProviderName {get;set;}
	public RefCollection ReferringProviderSecondaryIdentification {get;set;}
public Loop2420D(LoopCollectionBase parent):base(parent){
ReferringProviderName = new Nm1Collection(this, nameof(ReferringProviderName));
SegmentCollections.Add(ReferringProviderName);
ReferringProviderSecondaryIdentification = new RefCollection(this, nameof(ReferringProviderSecondaryIdentification));
SegmentCollections.Add(ReferringProviderSecondaryIdentification);
 
}
}
public partial class Loop2430 : LoopEntity{
	public SvdCollection LineAdjudicationInformation {get;set;}
	public CasCollection LineAdjustment {get;set;}
	public DtpCollection LineCheckOrRemittanceDate {get;set;}
	public AmtCollection RemainingPatientLiability {get;set;}
	public SeCollection TransactionSetTrailer {get;set;}
public Loop2430(LoopCollectionBase parent):base(parent){
LineAdjudicationInformation = new SvdCollection(this, nameof(LineAdjudicationInformation));
SegmentCollections.Add(LineAdjudicationInformation);
LineAdjustment = new CasCollection(this, nameof(LineAdjustment));
SegmentCollections.Add(LineAdjustment);
LineCheckOrRemittanceDate = new DtpCollection(this, nameof(LineCheckOrRemittanceDate));
SegmentCollections.Add(LineCheckOrRemittanceDate);
RemainingPatientLiability = new AmtCollection(this, nameof(RemainingPatientLiability));
SegmentCollections.Add(RemainingPatientLiability);
TransactionSetTrailer = new SeCollection(this, nameof(TransactionSetTrailer));
SegmentCollections.Add(TransactionSetTrailer);
 
}
}
