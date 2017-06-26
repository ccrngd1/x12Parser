public partial class Loop01GECollection
{
public override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 999;
SegmentDefinitions.Add(new GS(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "FunctionalGroupHeader"
});
SegmentDefinitions.Add(new GE(){
OwningLoopCollection = this,
SegmentDefinitionName = "FunctionalGroupTrailer"
});
SegmentDefinitions.Add(new (){
OwningLoopCollection = this,
SegmentDefinitionName = "TransactionSetHeader"
});
SegmentDefinitions.Add(new ST(){
OwningLoopCollection = this,
SegmentDefinitionName = ""
});
SegmentDefinitions.Add(new TABLE(){
OwningLoopCollection = this,
SegmentDefinitionName = ""
});
}
}
public partial class Loop2000ACollection
{
public override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 999;
SegmentDefinitions.Add(new HL(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "InformationSourceLevel"
});
}
}
public partial class Loop2100ACollection
{
public override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "PayerName"
});
SegmentDefinitions.Add(new PER(){
OwningLoopCollection = this,
SegmentDefinitionName = "PayerContactInformation"
});
}
}
public partial class Loop2000BCollection
{
public override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 999;
SegmentDefinitions.Add(new HL(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "InformationReceiverLevel"
});
}
}
public partial class Loop2100BCollection
{
public override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "InformationReceiverName"
});
}
}
public partial class Loop2200BCollection
{
public override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new TRN(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "InformationReceiverTraceIdentifier"
});
SegmentDefinitions.Add(new STC(){
OwningLoopCollection = this,
SegmentDefinitionName = "InformationReceiverStatusInformation"
});
}
}
public partial class Loop2000CCollection
{
public override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 999;
SegmentDefinitions.Add(new HL(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "ServiceProviderLevel"
});
}
}
public partial class Loop2100CCollection
{
public override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 2;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "ProviderName"
});
}
}
public partial class Loop2200CCollection
{
public override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new TRN(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "ProviderofServiceTraceIdentifier"
});
SegmentDefinitions.Add(new STC(){
OwningLoopCollection = this,
SegmentDefinitionName = "ProviderStatusInformation"
});
}
}
public partial class Loop2000DCollection
{
public override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 999;
SegmentDefinitions.Add(new HL(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "SubscriberLevel"
});
}
}
public partial class Loop2100DCollection
{
public override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "SubscriberName"
});
}
}
public partial class Loop2200DCollection
{
public override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 999;
SegmentDefinitions.Add(new TRN(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "ClaimStatusTrackingNumber"
});
SegmentDefinitions.Add(new STC(){
OwningLoopCollection = this,
SegmentDefinitionName = "ClaimLevelStatusInformation"
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "PayerClaimControlNumber"
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "InstitutionalBillTypeIdentification"
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "PatientControlNumber"
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "PharmacyPrescriptionNumber"
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "VoucherIdentifier"
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "ClaimIdentificationNumberForClearinghousesand"
});
SegmentDefinitions.Add(new DTP(){
OwningLoopCollection = this,
SegmentDefinitionName = "ClaimServiceDate"
});
}
}
public partial class Loop2220DCollection
{
public override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 999;
SegmentDefinitions.Add(new SVC(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "ServiceLineInformation"
});
SegmentDefinitions.Add(new STC(){
OwningLoopCollection = this,
SegmentDefinitionName = "ServiceLineStatusInformation"
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "ServiceLineItemIdentification"
});
SegmentDefinitions.Add(new DTP(){
OwningLoopCollection = this,
SegmentDefinitionName = "ServiceLineDate"
});
}
}
public partial class Loop2000ECollection
{
public override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 999;
SegmentDefinitions.Add(new HL(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "DependentLevel"
});
}
}
public partial class Loop2100ECollection
{
public override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "DependentName"
});
}
}
public partial class Loop2200ECollection
{
public override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 999;
SegmentDefinitions.Add(new TRN(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "ClaimStatusTrackingNumber"
});
SegmentDefinitions.Add(new STC(){
OwningLoopCollection = this,
SegmentDefinitionName = "ClaimLevelStatusInformation"
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "PayerClaimControlNumber"
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "InstitutionalBillTypeIdentification"
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "PatientControlNumber"
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "PharmacyPrescriptionNumber"
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "VoucherIdentifier"
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "ClaimIdentificationNumberForClearinghousesand"
});
SegmentDefinitions.Add(new DTP(){
OwningLoopCollection = this,
SegmentDefinitionName = "ClaimServiceDate"
});
}
}
public partial class Loop2220ECollection
{
public override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 999;
SegmentDefinitions.Add(new SVC(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "ServiceLineInformation"
});
SegmentDefinitions.Add(new STC(){
OwningLoopCollection = this,
SegmentDefinitionName = "ServiceLineStatusInformation"
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "ServiceLineItemIdentification"
});
SegmentDefinitions.Add(new DTP(){
OwningLoopCollection = this,
SegmentDefinitionName = "ServiceLineDate"
});
SegmentDefinitions.Add(new SE(){
OwningLoopCollection = this,
SegmentDefinitionName = "TransactionSetTrailer"
});
}
}
