public partial class Loop2000A : LoopEntity{
	public HlCollection InformationSourceLevel {get;set;}
public Loop2000A(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
InformationSourceLevel = new HlCollection(this, nameof(InformationSourceLevel));
SegmentCollections.Add(InformationSourceLevel);
 
}
}
public partial class Loop2100A : LoopEntity{
	public Nm1Collection PayerName {get;set;}
public Loop2100A(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
PayerName = new Nm1Collection(this, nameof(PayerName));
SegmentCollections.Add(PayerName);
 
}
}
public partial class Loop2000B : LoopEntity{
	public HlCollection InformationReceiverLevel {get;set;}
public Loop2000B(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
InformationReceiverLevel = new HlCollection(this, nameof(InformationReceiverLevel));
SegmentCollections.Add(InformationReceiverLevel);
 
}
}
public partial class Loop2100B : LoopEntity{
	public Nm1Collection InformationReceiverName {get;set;}
	public Loop2000CCollection ServiceProviderLevelLoop {get;set;}
	public Loop2100CCollection ProviderNameLoop {get;set;}
public Loop2100B(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
InformationReceiverName = new Nm1Collection(this, nameof(InformationReceiverName));
SegmentCollections.Add(InformationReceiverName);
 
ServiceProviderLevelLoop = new Loop2000CCollection("Loop2000C", nameof(ServiceProviderLevelLoop), OwningDoc, parent, parent);
ChildLoopCollections.Add(ServiceProviderLevelLoop);
ProviderNameLoop = new Loop2100CCollection("Loop2100C", nameof(ProviderNameLoop), OwningDoc, parent, parent);
ChildLoopCollections.Add(ProviderNameLoop);
}
}
public partial class Loop2000C : LoopEntity{
	public HlCollection ServiceProviderLevel {get;set;}
public Loop2000C(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
ServiceProviderLevel = new HlCollection(this, nameof(ServiceProviderLevel));
SegmentCollections.Add(ServiceProviderLevel);
 
}
}
public partial class Loop2100C : LoopEntity{
	public Nm1Collection ProviderName {get;set;}
	public Loop2000DCollection SubscriberLevelLoop {get;set;}
	public Loop2100DCollection SubscriberNameLoop {get;set;}
public Loop2100C(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
ProviderName = new Nm1Collection(this, nameof(ProviderName));
SegmentCollections.Add(ProviderName);
 
SubscriberLevelLoop = new Loop2000DCollection("Loop2000D", nameof(SubscriberLevelLoop), OwningDoc, parent, parent);
ChildLoopCollections.Add(SubscriberLevelLoop);
SubscriberNameLoop = new Loop2100DCollection("Loop2100D", nameof(SubscriberNameLoop), OwningDoc, parent, parent);
ChildLoopCollections.Add(SubscriberNameLoop);
}
}
public partial class Loop2000D : LoopEntity{
	public HlCollection SubscriberLevel {get;set;}
	public DmgCollection SubscriberDemographicInformation {get;set;}
public Loop2000D(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
SubscriberLevel = new HlCollection(this, nameof(SubscriberLevel));
SegmentCollections.Add(SubscriberLevel);
SubscriberDemographicInformation = new DmgCollection(this, nameof(SubscriberDemographicInformation));
SegmentCollections.Add(SubscriberDemographicInformation);
 
}
}
public partial class Loop2100D : LoopEntity{
	public Nm1Collection SubscriberName {get;set;}
	public Loop2200DCollection ClaimStatusTrackingNumberLoop {get;set;}
public Loop2100D(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
SubscriberName = new Nm1Collection(this, nameof(SubscriberName));
SegmentCollections.Add(SubscriberName);
 
ClaimStatusTrackingNumberLoop = new Loop2200DCollection("Loop2200D", nameof(ClaimStatusTrackingNumberLoop), OwningDoc, parent, parent);
ChildLoopCollections.Add(ClaimStatusTrackingNumberLoop);
}
}
public partial class Loop2200D : LoopEntity{
	public TrnCollection ClaimStatusTrackingNumber {get;set;}
	public RefCollection PayerClaimControlNumber {get;set;}
	public RefCollection InstitutionalBillTypeIdentification {get;set;}
	public RefCollection ApplicationOrLocationSystemIdentifier {get;set;}
	public RefCollection GroupNumber {get;set;}
	public RefCollection PatientControlNumber {get;set;}
	public RefCollection PharmacyPrescriptionNumber {get;set;}
	public RefCollection ClaimIdentificationNumberForClearinghousesAnd {get;set;}
	public AmtCollection ClaimSubmittedCharges {get;set;}
	public DtpCollection ClaimServiceDate {get;set;}
	public Loop2210DCollection ServiceLineInformationLoop {get;set;}
	public Loop2000ECollection DependentLevelLoop {get;set;}
	public Loop2100ECollection DependentNameLoop {get;set;}
	public Loop2200ECollection ClaimStatusTrackingNumberLoop {get;set;}
public Loop2200D(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
ClaimStatusTrackingNumber = new TrnCollection(this, nameof(ClaimStatusTrackingNumber));
SegmentCollections.Add(ClaimStatusTrackingNumber);
PayerClaimControlNumber = new RefCollection(this, nameof(PayerClaimControlNumber));
SegmentCollections.Add(PayerClaimControlNumber);
InstitutionalBillTypeIdentification = new RefCollection(this, nameof(InstitutionalBillTypeIdentification));
SegmentCollections.Add(InstitutionalBillTypeIdentification);
ApplicationOrLocationSystemIdentifier = new RefCollection(this, nameof(ApplicationOrLocationSystemIdentifier));
SegmentCollections.Add(ApplicationOrLocationSystemIdentifier);
GroupNumber = new RefCollection(this, nameof(GroupNumber));
SegmentCollections.Add(GroupNumber);
PatientControlNumber = new RefCollection(this, nameof(PatientControlNumber));
SegmentCollections.Add(PatientControlNumber);
PharmacyPrescriptionNumber = new RefCollection(this, nameof(PharmacyPrescriptionNumber));
SegmentCollections.Add(PharmacyPrescriptionNumber);
ClaimIdentificationNumberForClearinghousesAnd = new RefCollection(this, nameof(ClaimIdentificationNumberForClearinghousesAnd));
SegmentCollections.Add(ClaimIdentificationNumberForClearinghousesAnd);
ClaimSubmittedCharges = new AmtCollection(this, nameof(ClaimSubmittedCharges));
SegmentCollections.Add(ClaimSubmittedCharges);
ClaimServiceDate = new DtpCollection(this, nameof(ClaimServiceDate));
SegmentCollections.Add(ClaimServiceDate);
 
ServiceLineInformationLoop = new Loop2210DCollection("Loop2210D", nameof(ServiceLineInformationLoop), OwningDoc, parent, parent);
ChildLoopCollections.Add(ServiceLineInformationLoop);
DependentLevelLoop = new Loop2000ECollection("Loop2000E", nameof(DependentLevelLoop), OwningDoc, parent, parent);
ChildLoopCollections.Add(DependentLevelLoop);
DependentNameLoop = new Loop2100ECollection("Loop2100E", nameof(DependentNameLoop), OwningDoc, parent, parent);
ChildLoopCollections.Add(DependentNameLoop);
ClaimStatusTrackingNumberLoop = new Loop2200ECollection("Loop2200E", nameof(ClaimStatusTrackingNumberLoop), OwningDoc, parent, parent);
ChildLoopCollections.Add(ClaimStatusTrackingNumberLoop);
}
}
public partial class Loop2210D : LoopEntity{
	public SvcCollection ServiceLineInformation {get;set;}
	public RefCollection ServiceLineItemIdentification {get;set;}
	public DtpCollection ServiceLineDate {get;set;}
public Loop2210D(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
ServiceLineInformation = new SvcCollection(this, nameof(ServiceLineInformation));
SegmentCollections.Add(ServiceLineInformation);
ServiceLineItemIdentification = new RefCollection(this, nameof(ServiceLineItemIdentification));
SegmentCollections.Add(ServiceLineItemIdentification);
ServiceLineDate = new DtpCollection(this, nameof(ServiceLineDate));
SegmentCollections.Add(ServiceLineDate);
 
}
}
public partial class Loop2000E : LoopEntity{
	public HlCollection DependentLevel {get;set;}
	public DmgCollection DependentDemographicInformation {get;set;}
public Loop2000E(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
DependentLevel = new HlCollection(this, nameof(DependentLevel));
SegmentCollections.Add(DependentLevel);
DependentDemographicInformation = new DmgCollection(this, nameof(DependentDemographicInformation));
SegmentCollections.Add(DependentDemographicInformation);
 
}
}
public partial class Loop2100E : LoopEntity{
	public Nm1Collection DependentName {get;set;}
public Loop2100E(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
DependentName = new Nm1Collection(this, nameof(DependentName));
SegmentCollections.Add(DependentName);
 
}
}
public partial class Loop2200E : LoopEntity{
	public TrnCollection ClaimStatusTrackingNumber {get;set;}
	public RefCollection PayerClaimControlNumber {get;set;}
	public RefCollection InstitutionalBillTypeIdentification {get;set;}
	public RefCollection ApplicationOrLocationSystemIdentifier {get;set;}
	public RefCollection GroupNumber {get;set;}
	public RefCollection PatientControlNumber {get;set;}
	public RefCollection PharmacyPrescriptionNumber {get;set;}
	public RefCollection ClaimIdentificationNumberForClearinghousesAnd {get;set;}
	public AmtCollection ClaimSubmittedCharges {get;set;}
	public DtpCollection ClaimServiceDate {get;set;}
	public Loop2210ECollection ServiceLineInformationLoop {get;set;}
public Loop2200E(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
ClaimStatusTrackingNumber = new TrnCollection(this, nameof(ClaimStatusTrackingNumber));
SegmentCollections.Add(ClaimStatusTrackingNumber);
PayerClaimControlNumber = new RefCollection(this, nameof(PayerClaimControlNumber));
SegmentCollections.Add(PayerClaimControlNumber);
InstitutionalBillTypeIdentification = new RefCollection(this, nameof(InstitutionalBillTypeIdentification));
SegmentCollections.Add(InstitutionalBillTypeIdentification);
ApplicationOrLocationSystemIdentifier = new RefCollection(this, nameof(ApplicationOrLocationSystemIdentifier));
SegmentCollections.Add(ApplicationOrLocationSystemIdentifier);
GroupNumber = new RefCollection(this, nameof(GroupNumber));
SegmentCollections.Add(GroupNumber);
PatientControlNumber = new RefCollection(this, nameof(PatientControlNumber));
SegmentCollections.Add(PatientControlNumber);
PharmacyPrescriptionNumber = new RefCollection(this, nameof(PharmacyPrescriptionNumber));
SegmentCollections.Add(PharmacyPrescriptionNumber);
ClaimIdentificationNumberForClearinghousesAnd = new RefCollection(this, nameof(ClaimIdentificationNumberForClearinghousesAnd));
SegmentCollections.Add(ClaimIdentificationNumberForClearinghousesAnd);
ClaimSubmittedCharges = new AmtCollection(this, nameof(ClaimSubmittedCharges));
SegmentCollections.Add(ClaimSubmittedCharges);
ClaimServiceDate = new DtpCollection(this, nameof(ClaimServiceDate));
SegmentCollections.Add(ClaimServiceDate);
 
ServiceLineInformationLoop = new Loop2210ECollection("Loop2210E", nameof(ServiceLineInformationLoop), OwningDoc, parent, parent);
ChildLoopCollections.Add(ServiceLineInformationLoop);
}
}
public partial class Loop2210E : LoopEntity{
	public SvcCollection ServiceLineInformation {get;set;}
	public RefCollection ServiceLineItemIdentification {get;set;}
	public DtpCollection ServiceLineDate {get;set;}
	public TableCollection TransactionSetTrailer {get;set;}
public Loop2210E(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
ServiceLineInformation = new SvcCollection(this, nameof(ServiceLineInformation));
SegmentCollections.Add(ServiceLineInformation);
ServiceLineItemIdentification = new RefCollection(this, nameof(ServiceLineItemIdentification));
SegmentCollections.Add(ServiceLineItemIdentification);
ServiceLineDate = new DtpCollection(this, nameof(ServiceLineDate));
SegmentCollections.Add(ServiceLineDate);
TransactionSetTrailer = new TableCollection(this, nameof(TransactionSetTrailer));
SegmentCollections.Add(TransactionSetTrailer);
 
}
}
