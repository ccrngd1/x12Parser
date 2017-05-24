public partial class Loop01GECollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(999);
docDef.loops.Add(this.Definition);
var GsDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(GS), 
FunctionalGroupHeader
);
GsDef.Qualifiers.Add(new SegmentQualifiers(1, "X".Split(','))); 
GsDef.RequiredFields.Add("1);
GsDef.RequiredFields.Add(2);
GsDef.RequiredFields.Add(3);
GsDef.RequiredFields.Add(4);
GsDef.RequiredFields.Add(5);
GsDef.RequiredFields.Add(6);
GsDef.RequiredFields.Add(7);
GsDef.RequiredFields.Add(8");
GsDef.RequiredFields.AddRange(new []{ "1,2,3,4,5,6,7,8" }.ToList());
GsDef.UnusedFields.AddRange(new []{  }.ToList());
GsDef.SyntaxRuleList.AddRange("".Split(',').ToList());
FunctionalGroupHeader.Definition = GsDef;
docDef.segments.Add(GsDef);
var GeDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(GE), 
FunctionalGroupTrailer
);
GeDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
GeDef.RequiredFields.Add("1);
GeDef.RequiredFields.Add(2");
GeDef.RequiredFields.AddRange(new []{ "1,2" }.ToList());
GeDef.UnusedFields.AddRange(new []{  }.ToList());
GeDef.SyntaxRuleList.AddRange("".Split(',').ToList());
FunctionalGroupTrailer.Definition = GeDef;
docDef.segments.Add(GeDef);
}
}
public partial class Loop2000ACollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(999);
docDef.loops.Add(this.Definition);
var HlDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(HL), 
InformationSourceLevel
);
HlDef.Qualifiers.Add(new SegmentQualifiers(1, "20".Split(','))); 
HlDef.RequiredFields.Add("1);
HlDef.RequiredFields.Add(3);
HlDef.RequiredFields.Add(4");
HlDef.RequiredFields.AddRange(new []{ "1,3,4" }.ToList());
HlDef.UnusedFields.AddRange(new []{ 2 }.ToList());
HlDef.SyntaxRuleList.AddRange("".Split(',').ToList());
InformationSourceLevel.Definition = HlDef;
docDef.segments.Add(HlDef);
}
}
public partial class Loop2100ACollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
PayerName
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "PR".Split(','))); 
Nm1Def.RequiredFields.Add("1);
Nm1Def.RequiredFields.Add(2);
Nm1Def.RequiredFields.Add(3);
Nm1Def.RequiredFields.Add(8);
Nm1Def.RequiredFields.Add(9");
Nm1Def.RequiredFields.AddRange(new []{ "1,2,3,8,9" }.ToList());
Nm1Def.UnusedFields.AddRange(new []{ "4,5,6,7,10,11,12" }.ToList());
Nm1Def.SyntaxRuleList.AddRange(""P0809,C1110,C1203"".Split(',').ToList());
PayerName.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var PerDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(PER), 
PayerContactInformation
);
PerDef.Qualifiers.Add(new SegmentQualifiers(1, "IC".Split(','))); 
PerDef.RequiredFields.Add("1);
PerDef.RequiredFields.Add(3);
PerDef.RequiredFields.Add(4");
PerDef.RequiredFields.AddRange(new []{ "1,3,4" }.ToList());
PerDef.UnusedFields.AddRange(new []{ 9 }.ToList());
PerDef.SyntaxRuleList.AddRange(""P0304,P0506,P0708"".Split(',').ToList());
PayerContactInformation.Definition = PerDef;
docDef.segments.Add(PerDef);
}
}
public partial class Loop2000BCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(999);
docDef.loops.Add(this.Definition);
var HlDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(HL), 
InformationReceiverLevel
);
HlDef.Qualifiers.Add(new SegmentQualifiers(1, "21".Split(','))); 
HlDef.RequiredFields.Add("1);
HlDef.RequiredFields.Add(2);
HlDef.RequiredFields.Add(3);
HlDef.RequiredFields.Add(4");
HlDef.RequiredFields.AddRange(new []{ "1,2,3,4" }.ToList());
HlDef.UnusedFields.AddRange(new []{  }.ToList());
HlDef.SyntaxRuleList.AddRange("".Split(',').ToList());
InformationReceiverLevel.Definition = HlDef;
docDef.segments.Add(HlDef);
}
}
public partial class Loop2100BCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
InformationReceiverName
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "41".Split(','))); 
Nm1Def.RequiredFields.Add("1);
Nm1Def.RequiredFields.Add(2);
Nm1Def.RequiredFields.Add(8);
Nm1Def.RequiredFields.Add(9");
Nm1Def.RequiredFields.AddRange(new []{ "1,2,8,9" }.ToList());
Nm1Def.UnusedFields.AddRange(new []{ "6,7,10,11,12" }.ToList());
Nm1Def.SyntaxRuleList.AddRange(""P0809,C1110,C1203"".Split(',').ToList());
InformationReceiverName.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
}
}
public partial class Loop2200BCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var TrnDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(TRN), 
InformationReceiverTraceIdentifier
);
TrnDef.Qualifiers.Add(new SegmentQualifiers(1, "2".Split(','))); 
TrnDef.RequiredFields.Add("1);
TrnDef.RequiredFields.Add(2");
TrnDef.RequiredFields.AddRange(new []{ "1,2" }.ToList());
TrnDef.UnusedFields.AddRange(new []{ "3,4" }.ToList());
TrnDef.SyntaxRuleList.AddRange("".Split(',').ToList());
InformationReceiverTraceIdentifier.Definition = TrnDef;
docDef.segments.Add(TrnDef);
var StcDef = new SegmentDefinition(
SegmentUsageType.Required, 
0, 
typeof(STC), 
InformationReceiverStatusInformation
);
StcDef.Qualifiers.Add(new SegmentQualifiers(1, ""41,AY,PR"".Split(','))); 
StcDef.RequiredFields.Add("1);
StcDef.RequiredFields.Add(2);
StcDef.RequiredFields.Add(3);
StcDef.RequiredFields.Add(6);
StcDef.RequiredFields.Add(15);
StcDef.RequiredFields.Add(16);
StcDef.RequiredFields.Add(20);
StcDef.RequiredFields.Add(21");
StcDef.RequiredFields.AddRange(new []{ "1,2,3,6,15,16,20,21" }.ToList());
StcDef.UnusedFields.AddRange(new []{ "5,7,8,9,10,11,12,13,18,23,24" }.ToList());
StcDef.SyntaxRuleList.AddRange("".Split(',').ToList());
InformationReceiverStatusInformation.Definition = StcDef;
docDef.segments.Add(StcDef);
}
}
public partial class Loop2000CCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(999);
docDef.loops.Add(this.Definition);
var HlDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(HL), 
ServiceProviderLevel
);
HlDef.Qualifiers.Add(new SegmentQualifiers(1, "19".Split(','))); 
HlDef.RequiredFields.Add("1);
HlDef.RequiredFields.Add(2);
HlDef.RequiredFields.Add(3);
HlDef.RequiredFields.Add(4");
HlDef.RequiredFields.AddRange(new []{ "1,2,3,4" }.ToList());
HlDef.UnusedFields.AddRange(new []{  }.ToList());
HlDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ServiceProviderLevel.Definition = HlDef;
docDef.segments.Add(HlDef);
}
}
public partial class Loop2100CCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(999);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
ProviderName
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "1P".Split(','))); 
Nm1Def.RequiredFields.Add("1);
Nm1Def.RequiredFields.Add(2);
Nm1Def.RequiredFields.Add(8);
Nm1Def.RequiredFields.Add(9");
Nm1Def.RequiredFields.AddRange(new []{ "1,2,8,9" }.ToList());
Nm1Def.UnusedFields.AddRange(new []{ "6,10,11,12" }.ToList());
Nm1Def.SyntaxRuleList.AddRange(""P0809,C1110,C1203"".Split(',').ToList());
ProviderName.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
}
}
public partial class Loop2200CCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var TrnDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(TRN), 
ProviderofServiceTraceIdentifier
);
TrnDef.Qualifiers.Add(new SegmentQualifiers(1, "1".Split(','))); 
TrnDef.RequiredFields.Add("1);
TrnDef.RequiredFields.Add(2");
TrnDef.RequiredFields.AddRange(new []{ "1,2" }.ToList());
TrnDef.UnusedFields.AddRange(new []{ "3,4" }.ToList());
TrnDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ProviderofServiceTraceIdentifier.Definition = TrnDef;
docDef.segments.Add(TrnDef);
var StcDef = new SegmentDefinition(
SegmentUsageType.Required, 
0, 
typeof(STC), 
ProviderStatusInformation
);
StcDef.Qualifiers.Add(new SegmentQualifiers(1, "1P".Split(','))); 
StcDef.RequiredFields.Add("1);
StcDef.RequiredFields.Add(2);
StcDef.RequiredFields.Add(3);
StcDef.RequiredFields.Add(6);
StcDef.RequiredFields.Add(15);
StcDef.RequiredFields.Add(16);
StcDef.RequiredFields.Add(20);
StcDef.RequiredFields.Add(21");
StcDef.RequiredFields.AddRange(new []{ "1,2,3,6,15,16,20,21" }.ToList());
StcDef.UnusedFields.AddRange(new []{ "5,7,8,9,10,11,12,13,18,22,23" }.ToList());
StcDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ProviderStatusInformation.Definition = StcDef;
docDef.segments.Add(StcDef);
}
}
public partial class Loop2000DCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(999);
docDef.loops.Add(this.Definition);
var HlDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(HL), 
SubscriberLevel
);
HlDef.Qualifiers.Add(new SegmentQualifiers(1, "22".Split(','))); 
HlDef.RequiredFields.Add("1);
HlDef.RequiredFields.Add(2);
HlDef.RequiredFields.Add(3);
HlDef.RequiredFields.Add(4");
HlDef.RequiredFields.AddRange(new []{ "1,2,3,4" }.ToList());
HlDef.UnusedFields.AddRange(new []{  }.ToList());
HlDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SubscriberLevel.Definition = HlDef;
docDef.segments.Add(HlDef);
}
}
public partial class Loop2100DCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
SubscriberName
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "IL".Split(','))); 
Nm1Def.RequiredFields.Add("1);
Nm1Def.RequiredFields.Add(2);
Nm1Def.RequiredFields.Add(3);
Nm1Def.RequiredFields.Add(8);
Nm1Def.RequiredFields.Add(9");
Nm1Def.RequiredFields.AddRange(new []{ "1,2,3,8,9" }.ToList());
Nm1Def.UnusedFields.AddRange(new []{ "6,10,11,12" }.ToList());
Nm1Def.SyntaxRuleList.AddRange(""P0809,C1110,C1203"".Split(',').ToList());
SubscriberName.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
}
}
public partial class Loop2200DCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(999);
docDef.loops.Add(this.Definition);
var TrnDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(TRN), 
ClaimStatusTrackingNumber
);
TrnDef.Qualifiers.Add(new SegmentQualifiers(1, "2".Split(','))); 
TrnDef.RequiredFields.Add("1);
TrnDef.RequiredFields.Add(2");
TrnDef.RequiredFields.AddRange(new []{ "1,2" }.ToList());
TrnDef.UnusedFields.AddRange(new []{ "3,4" }.ToList());
TrnDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ClaimStatusTrackingNumber.Definition = TrnDef;
docDef.segments.Add(TrnDef);
var StcDef = new SegmentDefinition(
SegmentUsageType.Required, 
0, 
typeof(STC), 
ClaimLevelStatusInformation
);
StcDef.Qualifiers.Add(new SegmentQualifiers(1, ""03,13,17,1E,1G,1H,1I,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,28,2A,2B,2D,2E,2I,2K,2P,2Q,2S,2Z,30,36,3A,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3Q,3R,3S,3T,3U,3V,3W,3Y,3Z,40,43,44,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4L,4M,4N,4O,4P,4Q,4R,4S,4U,4V,4W,4X,4Y,4Z,5A,5B,5C,5D,5E,5F,5G,5H,5I,5J,5K,5L,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X,5Y,5Z,61,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6O,6P,6Q,6R,6S,6U,6V,6W,6X,6Y,71,72,73,74,7C,80,82,84,85,87,95,CK,CZ,D2,DD,DJ,DK,DN,DO,DQ,E1,E2,E7,E9,FA,FD,FE,G0,G3,GB,GD,GI,GJ,GK,GM,GY,HF,HH,I3,IJ,IL,IN,LI,LR,MR,MSC,OB,OD,OX,P0,P2,P3,P4,P6,P7,PRP,PT,PV,PW,QA,QB,QC,QD,QE,QH,QK,QL,QN,QO,QS,QV,QY,RC,RW,S4,SEP,SJ,SU,T4,TL,TQ,TT,TTP,TU,UH,X3,X5,ZZ"".Split(','))); 
StcDef.RequiredFields.Add("1);
StcDef.RequiredFields.Add(2);
StcDef.RequiredFields.Add(3);
StcDef.RequiredFields.Add(6);
StcDef.RequiredFields.Add(15);
StcDef.RequiredFields.Add(19);
StcDef.RequiredFields.Add(20");
StcDef.RequiredFields.AddRange(new []{ "1,2,3,6,15,19,20" }.ToList());
StcDef.UnusedFields.AddRange(new []{ "7,11,23" }.ToList());
StcDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ClaimLevelStatusInformation.Definition = StcDef;
docDef.segments.Add(StcDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(REF), 
PayerClaimControlNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "1K".Split(','))); 
RefDef.RequiredFields.Add("1);
RefDef.RequiredFields.Add(2");
RefDef.RequiredFields.AddRange(new []{ "1,2" }.ToList());
RefDef.UnusedFields.AddRange(new []{ "3,4" }.ToList());
RefDef.SyntaxRuleList.AddRange("R0203".Split(',').ToList());
PayerClaimControlNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(REF), 
InstitutionalBillTypeIdentification
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "BLT".Split(','))); 
RefDef.RequiredFields.Add("1);
RefDef.RequiredFields.Add(2");
RefDef.RequiredFields.AddRange(new []{ "1,2" }.ToList());
RefDef.UnusedFields.AddRange(new []{ "3,4" }.ToList());
RefDef.SyntaxRuleList.AddRange("R0203".Split(',').ToList());
InstitutionalBillTypeIdentification.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(REF), 
PatientControlNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "EJ".Split(','))); 
RefDef.RequiredFields.Add("1);
RefDef.RequiredFields.Add(2");
RefDef.RequiredFields.AddRange(new []{ "1,2" }.ToList());
RefDef.UnusedFields.AddRange(new []{ "3,4" }.ToList());
RefDef.SyntaxRuleList.AddRange("R0203".Split(',').ToList());
PatientControlNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(REF), 
PharmacyPrescriptionNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "XZ".Split(','))); 
RefDef.RequiredFields.Add("1);
RefDef.RequiredFields.Add(2");
RefDef.RequiredFields.AddRange(new []{ "1,2" }.ToList());
RefDef.UnusedFields.AddRange(new []{ "3,4" }.ToList());
RefDef.SyntaxRuleList.AddRange("R0203".Split(',').ToList());
PharmacyPrescriptionNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(REF), 
VoucherIdentifier
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "VV".Split(','))); 
RefDef.RequiredFields.Add("1);
RefDef.RequiredFields.Add(2");
RefDef.RequiredFields.AddRange(new []{ "1,2" }.ToList());
RefDef.UnusedFields.AddRange(new []{ "3,4" }.ToList());
RefDef.SyntaxRuleList.AddRange("R0203".Split(',').ToList());
VoucherIdentifier.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Optional, 
0, 
typeof(REF), 
ClaimIdentificationNumberForClearinghousesand
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "D9".Split(','))); 
RefDef.RequiredFields.Add("1);
RefDef.RequiredFields.Add(2");
RefDef.RequiredFields.AddRange(new []{ "1,2" }.ToList());
RefDef.UnusedFields.AddRange(new []{ "3,4" }.ToList());
RefDef.SyntaxRuleList.AddRange("R0203".Split(',').ToList());
ClaimIdentificationNumberForClearinghousesand.Definition = RefDef;
docDef.segments.Add(RefDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(DTP), 
ClaimServiceDate
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "472".Split(','))); 
DtpDef.RequiredFields.Add("1);
DtpDef.RequiredFields.Add(2);
DtpDef.RequiredFields.Add(3");
DtpDef.RequiredFields.AddRange(new []{ "1,2,3" }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ClaimServiceDate.Definition = DtpDef;
docDef.segments.Add(DtpDef);
}
}
public partial class Loop2220DCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(999);
docDef.loops.Add(this.Definition);
var SvcDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(SVC), 
ServiceLineInformation
);
SvcDef.Qualifiers.Add(new SegmentQualifiers(1, ""AD,ER,HC,HP,IV,N4,NU,WK"".Split(','))); 
SvcDef.RequiredFields.Add("1);
SvcDef.RequiredFields.Add(2);
SvcDef.RequiredFields.Add(3);
SvcDef.RequiredFields.Add(10);
SvcDef.RequiredFields.Add(11);
SvcDef.RequiredFields.Add(15");
SvcDef.RequiredFields.AddRange(new []{ "1,2,3,10,11,15" }.ToList());
SvcDef.UnusedFields.AddRange(new []{ "8,9,13,14" }.ToList());
SvcDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ServiceLineInformation.Definition = SvcDef;
docDef.segments.Add(SvcDef);
var StcDef = new SegmentDefinition(
SegmentUsageType.Required, 
0, 
typeof(STC), 
ServiceLineStatusInformation
);
StcDef.Qualifiers.Add(new SegmentQualifiers(1, ""03,13,17,1E,1G,1H,1I,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,28,2A,2B,2D,2E,2I,2K,2P,2Q,2S,2Z,30,36,3A,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3Q,3R,3S,3T,3U,3V,3W,3Y,3Z,40,43,44,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4L,4M,4N,4O,4P,4Q,4R,4S,4U,4V,4W,4X,4Y,4Z,5A,5B,5C,5D,5E,5F,5G,5H,5I,5J,5K,5L,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X,5Y,5Z,61,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6O,6P,6Q,6R,6S,6U,6V,6W,6X,6Y,71,72,73,74,7C,80,82,84,85,87,95,CK,CZ,D2,DD,DJ,DK,DN,DO,DQ,E1,E2,E7,E9,FA,FD,FE,G0,G3,GB,GD,GI,GJ,GK,GM,GY,HF,HH,I3,IJ,IL,IN,LI,LR,MR,MSC,OB,OD,OX,P0,P2,P3,P4,P6,P7,PRP,PT,PV,PW,QA,QB,QC,QD,QE,QH,QK,QL,QN,QO,QS,QV,QY,RC,RW,S4,SEP,SJ,SU,T4,TL,TQ,TT,TTP,TU,UH,X3,X5,ZZ"".Split(','))); 
StcDef.RequiredFields.Add("1);
StcDef.RequiredFields.Add(2);
StcDef.RequiredFields.Add(3);
StcDef.RequiredFields.Add(6);
StcDef.RequiredFields.Add(15);
StcDef.RequiredFields.Add(16);
StcDef.RequiredFields.Add(20);
StcDef.RequiredFields.Add(21");
StcDef.RequiredFields.AddRange(new []{ "1,2,3,6,15,16,20,21" }.ToList());
StcDef.UnusedFields.AddRange(new []{ "7,8,9,10,11,12,13,24" }.ToList());
StcDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ServiceLineStatusInformation.Definition = StcDef;
docDef.segments.Add(StcDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(REF), 
ServiceLineItemIdentification
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "FJ".Split(','))); 
RefDef.RequiredFields.Add("1);
RefDef.RequiredFields.Add(2");
RefDef.RequiredFields.AddRange(new []{ "1,2" }.ToList());
RefDef.UnusedFields.AddRange(new []{ "3,4" }.ToList());
RefDef.SyntaxRuleList.AddRange("R0203".Split(',').ToList());
ServiceLineItemIdentification.Definition = RefDef;
docDef.segments.Add(RefDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
ServiceLineDate
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "472".Split(','))); 
DtpDef.RequiredFields.Add("1);
DtpDef.RequiredFields.Add(2);
DtpDef.RequiredFields.Add(3");
DtpDef.RequiredFields.AddRange(new []{ "1,2,3" }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ServiceLineDate.Definition = DtpDef;
docDef.segments.Add(DtpDef);
}
}
public partial class Loop2000ECollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(999);
docDef.loops.Add(this.Definition);
var HlDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(HL), 
DependentLevel
);
HlDef.Qualifiers.Add(new SegmentQualifiers(1, "23".Split(','))); 
HlDef.RequiredFields.Add("1);
HlDef.RequiredFields.Add(2);
HlDef.RequiredFields.Add(3");
HlDef.RequiredFields.AddRange(new []{ "1,2,3" }.ToList());
HlDef.UnusedFields.AddRange(new []{ 4 }.ToList());
HlDef.SyntaxRuleList.AddRange("".Split(',').ToList());
DependentLevel.Definition = HlDef;
docDef.segments.Add(HlDef);
}
}
public partial class Loop2100ECollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
DependentName
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "QC".Split(','))); 
Nm1Def.RequiredFields.Add("1);
Nm1Def.RequiredFields.Add(2);
Nm1Def.RequiredFields.Add(3");
Nm1Def.RequiredFields.AddRange(new []{ "1,2,3" }.ToList());
Nm1Def.UnusedFields.AddRange(new []{ "6,8,9,10,11,12" }.ToList());
Nm1Def.SyntaxRuleList.AddRange(""P0809,C1110,C1203"".Split(',').ToList());
DependentName.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
}
}
public partial class Loop2200ECollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(999);
docDef.loops.Add(this.Definition);
var TrnDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(TRN), 
ClaimStatusTrackingNumber
);
TrnDef.Qualifiers.Add(new SegmentQualifiers(1, "2".Split(','))); 
TrnDef.RequiredFields.Add("1);
TrnDef.RequiredFields.Add(2");
TrnDef.RequiredFields.AddRange(new []{ "1,2" }.ToList());
TrnDef.UnusedFields.AddRange(new []{ "3,4" }.ToList());
TrnDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ClaimStatusTrackingNumber.Definition = TrnDef;
docDef.segments.Add(TrnDef);
var StcDef = new SegmentDefinition(
SegmentUsageType.Required, 
0, 
typeof(STC), 
ClaimLevelStatusInformation
);
StcDef.Qualifiers.Add(new SegmentQualifiers(1, ""03,13,17,1E,1G,1H,1I,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,28,2A,2B,2D,2E,2I,2K,2P,2Q,2S,2Z,30,36,3A,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3Q,3R,3S,3T,3U,3V,3W,3Y,3Z,40,43,44,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4L,4M,4N,4O,4P,4Q,4R,4S,4U,4V,4W,4X,4Y,4Z,5A,5B,5C,5D,5E,5F,5G,5H,5I,5J,5K,5L,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X,5Y,5Z,61,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6O,6P,6Q,6R,6S,6U,6V,6W,6X,6Y,71,72,73,74,7C,80,82,84,85,87,95,CK,CZ,D2,DD,DJ,DK,DN,DO,DQ,E1,E2,E7,E9,FA,FD,FE,G0,G3,GB,GD,GI,GJ,GK,GM,GY,HF,HH,I3,IJ,IL,IN,LI,LR,MR,MSC,OB,OD,OX,P0,P2,P3,P4,P6,P7,PRP,PT,PV,PW,QA,QB,QC,QD,QE,QH,QK,QL,QN,QO,QS,QV,QY,RC,RW,S4,SEP,SJ,SU,T4,TL,TQ,TT,TTP,TU,UH,X3,X5,ZZ"".Split(','))); 
StcDef.RequiredFields.Add("1);
StcDef.RequiredFields.Add(2);
StcDef.RequiredFields.Add(3);
StcDef.RequiredFields.Add(6);
StcDef.RequiredFields.Add(15);
StcDef.RequiredFields.Add(19);
StcDef.RequiredFields.Add(20");
StcDef.RequiredFields.AddRange(new []{ "1,2,3,6,15,19,20" }.ToList());
StcDef.UnusedFields.AddRange(new []{ "7,11,23" }.ToList());
StcDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ClaimLevelStatusInformation.Definition = StcDef;
docDef.segments.Add(StcDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(REF), 
PayerClaimControlNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "1K".Split(','))); 
RefDef.RequiredFields.Add("1);
RefDef.RequiredFields.Add(2");
RefDef.RequiredFields.AddRange(new []{ "1,2" }.ToList());
RefDef.UnusedFields.AddRange(new []{ "3,4" }.ToList());
RefDef.SyntaxRuleList.AddRange("R0203".Split(',').ToList());
PayerClaimControlNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(REF), 
InstitutionalBillTypeIdentification
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "BLT".Split(','))); 
RefDef.RequiredFields.Add("1);
RefDef.RequiredFields.Add(2");
RefDef.RequiredFields.AddRange(new []{ "1,2" }.ToList());
RefDef.UnusedFields.AddRange(new []{ "3,4" }.ToList());
RefDef.SyntaxRuleList.AddRange("R0203".Split(',').ToList());
InstitutionalBillTypeIdentification.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(REF), 
PatientControlNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "EJ".Split(','))); 
RefDef.RequiredFields.Add("1);
RefDef.RequiredFields.Add(2");
RefDef.RequiredFields.AddRange(new []{ "1,2" }.ToList());
RefDef.UnusedFields.AddRange(new []{ "3,4" }.ToList());
RefDef.SyntaxRuleList.AddRange("R0203".Split(',').ToList());
PatientControlNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(REF), 
PharmacyPrescriptionNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "XZ".Split(','))); 
RefDef.RequiredFields.Add("1);
RefDef.RequiredFields.Add(2");
RefDef.RequiredFields.AddRange(new []{ "1,2" }.ToList());
RefDef.UnusedFields.AddRange(new []{ "3,4" }.ToList());
RefDef.SyntaxRuleList.AddRange("R0203".Split(',').ToList());
PharmacyPrescriptionNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(REF), 
VoucherIdentifier
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "VV".Split(','))); 
RefDef.RequiredFields.Add("1);
RefDef.RequiredFields.Add(2");
RefDef.RequiredFields.AddRange(new []{ "1,2" }.ToList());
RefDef.UnusedFields.AddRange(new []{ "3,4" }.ToList());
RefDef.SyntaxRuleList.AddRange("R0203".Split(',').ToList());
VoucherIdentifier.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Optional, 
0, 
typeof(REF), 
ClaimIdentificationNumberForClearinghousesand
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "D9".Split(','))); 
RefDef.RequiredFields.Add("1);
RefDef.RequiredFields.Add(2");
RefDef.RequiredFields.AddRange(new []{ "1,2" }.ToList());
RefDef.UnusedFields.AddRange(new []{ "3,4" }.ToList());
RefDef.SyntaxRuleList.AddRange("R0203".Split(',').ToList());
ClaimIdentificationNumberForClearinghousesand.Definition = RefDef;
docDef.segments.Add(RefDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(DTP), 
ClaimServiceDate
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "472".Split(','))); 
DtpDef.RequiredFields.Add("1);
DtpDef.RequiredFields.Add(2);
DtpDef.RequiredFields.Add(3");
DtpDef.RequiredFields.AddRange(new []{ "1,2,3" }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ClaimServiceDate.Definition = DtpDef;
docDef.segments.Add(DtpDef);
}
}
public partial class Loop2220ECollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(999);
docDef.loops.Add(this.Definition);
var SvcDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(SVC), 
ServiceLineInformation
);
SvcDef.Qualifiers.Add(new SegmentQualifiers(1, ""AD,ER,HC,HP,IV,N4,NU,WK"".Split(','))); 
SvcDef.RequiredFields.Add("1);
SvcDef.RequiredFields.Add(2);
SvcDef.RequiredFields.Add(3);
SvcDef.RequiredFields.Add(10);
SvcDef.RequiredFields.Add(11);
SvcDef.RequiredFields.Add(15");
SvcDef.RequiredFields.AddRange(new []{ "1,2,3,10,11,15" }.ToList());
SvcDef.UnusedFields.AddRange(new []{ "8,9,13,14" }.ToList());
SvcDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ServiceLineInformation.Definition = SvcDef;
docDef.segments.Add(SvcDef);
var StcDef = new SegmentDefinition(
SegmentUsageType.Required, 
0, 
typeof(STC), 
ServiceLineStatusInformation
);
StcDef.Qualifiers.Add(new SegmentQualifiers(1, ""03,13,17,1E,1G,1H,1I,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,28,2A,2B,2D,2E,2I,2K,2P,2Q,2S,2Z,30,36,3A,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3Q,3R,3S,3T,3U,3V,3W,3Y,3Z,40,43,44,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4L,4M,4N,4O,4P,4Q,4R,4S,4U,4V,4W,4X,4Y,4Z,5A,5B,5C,5D,5E,5F,5G,5H,5I,5J,5K,5L,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X,5Y,5Z,61,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6O,6P,6Q,6R,6S,6U,6V,6W,6X,6Y,71,72,73,74,7C,80,82,84,85,87,95,CK,CZ,D2,DD,DJ,DK,DN,DO,DQ,E1,E2,E7,E9,FA,FD,FE,G0,G3,GB,GD,GI,GJ,GK,GM,GY,HF,HH,I3,IJ,IL,IN,LI,LR,MR,MSC,OB,OD,OX,P0,P2,P3,P4,P6,P7,PRP,PT,PV,PW,QA,QB,QC,QD,QE,QH,QK,QL,QN,QO,QS,QV,QY,RC,RW,S4,SEP,SJ,SU,T4,TL,TQ,TT,TTP,TU,UH,X3,X5,ZZ"".Split(','))); 
StcDef.RequiredFields.Add("1);
StcDef.RequiredFields.Add(2);
StcDef.RequiredFields.Add(3);
StcDef.RequiredFields.Add(6);
StcDef.RequiredFields.Add(15);
StcDef.RequiredFields.Add(16);
StcDef.RequiredFields.Add(20);
StcDef.RequiredFields.Add(21");
StcDef.RequiredFields.AddRange(new []{ "1,2,3,6,15,16,20,21" }.ToList());
StcDef.UnusedFields.AddRange(new []{ "7,8,9,10,11,12,13,24" }.ToList());
StcDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ServiceLineStatusInformation.Definition = StcDef;
docDef.segments.Add(StcDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(REF), 
ServiceLineItemIdentification
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "FJ".Split(','))); 
RefDef.RequiredFields.Add("1);
RefDef.RequiredFields.Add(2");
RefDef.RequiredFields.AddRange(new []{ "1,2" }.ToList());
RefDef.UnusedFields.AddRange(new []{ "3,4" }.ToList());
RefDef.SyntaxRuleList.AddRange("R0203".Split(',').ToList());
ServiceLineItemIdentification.Definition = RefDef;
docDef.segments.Add(RefDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
ServiceLineDate
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "472".Split(','))); 
DtpDef.RequiredFields.Add("1);
DtpDef.RequiredFields.Add(2);
DtpDef.RequiredFields.Add(3");
DtpDef.RequiredFields.AddRange(new []{ "1,2,3" }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ServiceLineDate.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var SeDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(SE), 
TransactionSetTrailer
);
SeDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
SeDef.RequiredFields.Add("1);
SeDef.RequiredFields.Add(2");
SeDef.RequiredFields.AddRange(new []{ "1,2" }.ToList());
SeDef.UnusedFields.AddRange(new []{  }.ToList());
SeDef.SyntaxRuleList.AddRange("".Split(',').ToList());
TransactionSetTrailer.Definition = SeDef;
docDef.segments.Add(SeDef);
}
}
