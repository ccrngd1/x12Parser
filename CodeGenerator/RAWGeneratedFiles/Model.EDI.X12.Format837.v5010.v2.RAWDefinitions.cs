public partial class Loop1000ACollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "41".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{ "1,2,3,8,9" }.ToList());
Nm1Def.SyntaxRuleList.AddRange(""10,11,12"".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var PerDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(PER), 
EDIContact
);
PerDef.Qualifiers.Add(new SegmentQualifiers(1, "IC".Split(','))); 
PerDef.UnusedFields.AddRange(new []{ "1,3,4" }.ToList());
PerDef.SyntaxRuleList.AddRange("9".Split(',').ToList());
EDIContact.Definition = PerDef;
docDef.segments.Add(PerDef);
}
}
public partial class Loop1000BCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "40".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{ "1,2,3,8,9" }.ToList());
Nm1Def.SyntaxRuleList.AddRange(""4,5,6,7,10,11,12"".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
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
Level
);
HlDef.Qualifiers.Add(new SegmentQualifiers(1, "20".Split(','))); 
HlDef.UnusedFields.AddRange(new []{ "1,3,4" }.ToList());
HlDef.SyntaxRuleList.AddRange("2".Split(',').ToList());
Level.Definition = HlDef;
docDef.segments.Add(HlDef);
var PrvDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(PRV), 
SpecialtyInfo
);
PrvDef.Qualifiers.Add(new SegmentQualifiers(1, "BI".Split(','))); 
PrvDef.UnusedFields.AddRange(new []{ "1,2,3" }.ToList());
PrvDef.SyntaxRuleList.AddRange(""4,6"".Split(',').ToList());
SpecialtyInfo.Definition = PrvDef;
docDef.segments.Add(PrvDef);
var CurDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(CUR), 
Currency
);
CurDef.Qualifiers.Add(new SegmentQualifiers(1, "85".Split(','))); 
CurDef.UnusedFields.AddRange(new []{ "1,2" }.ToList());
CurDef.SyntaxRuleList.AddRange(""3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21"".Split(',').ToList());
Currency.Definition = CurDef;
docDef.segments.Add(CurDef);
}
}
public partial class Loop2010AACollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "85".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{ "1,2,3" }.ToList());
Nm1Def.SyntaxRuleList.AddRange(""6,10,11,12"".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var N3Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N3), 
Address
);
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N3Def.UnusedFields.AddRange(new []{ 1 }.ToList());
N3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Address.Definition = N3Def;
docDef.segments.Add(N3Def);
var N4Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N4), 
Location
);
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N4Def.UnusedFields.AddRange(new []{ 1 }.ToList());
N4Def.SyntaxRuleList.AddRange(""5,6"".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
TaxId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""EI,SY,"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
TaxId.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(REF), 
UPINLicense
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,1G,"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
UPINLicense.Definition = RefDef;
docDef.segments.Add(RefDef);
var PerDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(PER), 
ContactInfo
);
PerDef.Qualifiers.Add(new SegmentQualifiers(1, "IC".Split(','))); 
PerDef.UnusedFields.AddRange(new []{  }.ToList());
PerDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ContactInfo.Definition = PerDef;
docDef.segments.Add(PerDef);
}
}
public partial class Loop2010ABCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "87".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var N3Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N3), 
Address
);
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N3Def.UnusedFields.AddRange(new []{  }.ToList());
N3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Address.Definition = N3Def;
docDef.segments.Add(N3Def);
var N4Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N4), 
Location
);
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
}
}
public partial class Loop2010ACCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "PE".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var N3Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N3), 
Address
);
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N3Def.UnusedFields.AddRange(new []{  }.ToList());
N3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Address.Definition = N3Def;
docDef.segments.Add(N3Def);
var N4Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N4), 
Location
);
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""2U,FY,NF"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
TaxID
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "EI".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
TaxID.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2000BCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var HlDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(HL), 
Level
);
HlDef.Qualifiers.Add(new SegmentQualifiers(1, "22".Split(','))); 
HlDef.UnusedFields.AddRange(new []{  }.ToList());
HlDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Level.Definition = HlDef;
docDef.segments.Add(HlDef);
var SbrDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(SBR), 
SubscriberInfo
);
SbrDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
SbrDef.UnusedFields.AddRange(new []{  }.ToList());
SbrDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SubscriberInfo.Definition = SbrDef;
docDef.segments.Add(SbrDef);
var PatDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(PAT), 
PationInfo
);
PatDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
PatDef.UnusedFields.AddRange(new []{  }.ToList());
PatDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PationInfo.Definition = PatDef;
docDef.segments.Add(PatDef);
}
}
public partial class Loop2010BACollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "IL".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var N3Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N3), 
Address
);
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N3Def.UnusedFields.AddRange(new []{  }.ToList());
N3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Address.Definition = N3Def;
docDef.segments.Add(N3Def);
var N4Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N4), 
Location
);
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
var DmgDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DMG), 
Demographic
);
DmgDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
DmgDef.UnusedFields.AddRange(new []{  }.ToList());
DmgDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Demographic.Definition = DmgDef;
docDef.segments.Add(DmgDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "SY".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
PropertyCausualtyClaimNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "Y4".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PropertyCausualtyClaimNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var PerDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(PER), 
PropertyCausualtySubscriberContact
);
PerDef.Qualifiers.Add(new SegmentQualifiers(1, "IC".Split(','))); 
PerDef.UnusedFields.AddRange(new []{  }.ToList());
PerDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PropertyCausualtySubscriberContact.Definition = PerDef;
docDef.segments.Add(PerDef);
}
}
public partial class Loop2010BBCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "PR".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var N3Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N3), 
Address
);
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N3Def.UnusedFields.AddRange(new []{  }.ToList());
N3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Address.Definition = N3Def;
docDef.segments.Add(N3Def);
var N4Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N4), 
Location
);
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(REF), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""2U,EI,FY,NF,"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(REF), 
BillingProviderSecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""G2,LU,"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
BillingProviderSecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2000CCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var HlDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(HL), 
Level
);
HlDef.Qualifiers.Add(new SegmentQualifiers(1, "23".Split(','))); 
HlDef.UnusedFields.AddRange(new []{  }.ToList());
HlDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Level.Definition = HlDef;
docDef.segments.Add(HlDef);
var PatDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(PAT), 
Info
);
PatDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
PatDef.UnusedFields.AddRange(new []{  }.ToList());
PatDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Info.Definition = PatDef;
docDef.segments.Add(PatDef);
}
}
public partial class Loop2010CACollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "QC".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var N3Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N3), 
Address
);
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N3Def.UnusedFields.AddRange(new []{  }.ToList());
N3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Address.Definition = N3Def;
docDef.segments.Add(N3Def);
var N4Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N4), 
Location
);
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
var DmgDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DMG), 
Demographic
);
DmgDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
DmgDef.UnusedFields.AddRange(new []{  }.ToList());
DmgDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Demographic.Definition = DmgDef;
docDef.segments.Add(DmgDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
PropertyCausualtyClaimNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "Y4".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PropertyCausualtyClaimNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
PropertyCausualtyPatientId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""1W,SY,"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PropertyCausualtyPatientId.Definition = RefDef;
docDef.segments.Add(RefDef);
var PerDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(PER), 
PropertyCausualtySubscriberContact
);
PerDef.Qualifiers.Add(new SegmentQualifiers(1, "IC".Split(','))); 
PerDef.UnusedFields.AddRange(new []{  }.ToList());
PerDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PropertyCausualtySubscriberContact.Definition = PerDef;
docDef.segments.Add(PerDef);
}
}
public partial class Loop2300Collection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(999);
docDef.loops.Add(this.Definition);
var ClmDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(CLM), 
Claim
);
ClmDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
ClmDef.UnusedFields.AddRange(new []{  }.ToList());
ClmDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Claim.Definition = ClmDef;
docDef.segments.Add(ClmDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
Onset
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "431".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Onset.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
Initialtreatment
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "454".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Initialtreatment.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
LastSeen
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "304".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LastSeen.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
AcuteManifestation
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "453".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
AcuteManifestation.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
Accident
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "439".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Accident.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
LastMenstrual
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "484".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LastMenstrual.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
LastXRay
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "455".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LastXRay.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
HearingVisionPrescription
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "471".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
HearingVisionPrescription.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
DisabilityDates
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, ""314,360,361"".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
DisabilityDates.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
LastWored
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "297".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LastWored.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
AuthorizedReturnWork
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "296".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
AuthorizedReturnWork.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
Admission
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "435".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Admission.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
Discharge
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "96".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Discharge.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
AssumedRelinquishedCare
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, ""090,091,"".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
AssumedRelinquishedCare.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
PropertyCasualtyFirstContact
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "444".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PropertyCasualtyFirstContact.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
RepricerReceived
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "50".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
RepricerReceived.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var PwkDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(PWK), 
SupplementalInfomation
);
PwkDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
PwkDef.UnusedFields.AddRange(new []{  }.ToList());
PwkDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SupplementalInfomation.Definition = PwkDef;
docDef.segments.Add(PwkDef);
var Cn1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(CN1), 
Contact
);
Cn1Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
Cn1Def.UnusedFields.AddRange(new []{  }.ToList());
Cn1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Contact.Definition = Cn1Def;
docDef.segments.Add(Cn1Def);
var AmtDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(AMT), 
PatientAmountPaid
);
AmtDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
AmtDef.UnusedFields.AddRange(new []{  }.ToList());
AmtDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PatientAmountPaid.Definition = AmtDef;
docDef.segments.Add(AmtDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
ServiceAuthorizationException
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "4N".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ServiceAuthorizationException.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
MandatoryMedicareCrossover
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "F5".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
MandatoryMedicareCrossover.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
MammographCertificationNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "EW".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
MammographCertificationNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
ReferalNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "9F".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ReferalNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
PriorAuthorizaiton
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "G1".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PriorAuthorizaiton.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
PayerClaimControlNumer
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "F8".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PayerClaimControlNumer.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
CLIANumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "X4".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
CLIANumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
RepricedClaimNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "9A".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
RepricedClaimNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
AdjustedRepricedClaimNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "9C".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
AdjustedRepricedClaimNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
InvestigativeDeviceExemption
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "LX".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
InvestigativeDeviceExemption.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
ClaimIdForTransmissionIntermediaries
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "D9".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ClaimIdForTransmissionIntermediaries.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
MedicalRecordNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "EA".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
MedicalRecordNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
DemonstrationProjectId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "P4".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
DemonstrationProjectId.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
CarePlanOversight
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "1J".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
CarePlanOversight.Definition = RefDef;
docDef.segments.Add(RefDef);
var K3Def = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(K3), 
FileInfo
);
K3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
K3Def.UnusedFields.AddRange(new []{  }.ToList());
K3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
FileInfo.Definition = K3Def;
docDef.segments.Add(K3Def);
var NteDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NTE), 
Note
);
NteDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
NteDef.UnusedFields.AddRange(new []{  }.ToList());
NteDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Note.Definition = NteDef;
docDef.segments.Add(NteDef);
var Cr1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(CR1), 
AmbulanceInfo
);
Cr1Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
Cr1Def.UnusedFields.AddRange(new []{  }.ToList());
Cr1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
AmbulanceInfo.Definition = Cr1Def;
docDef.segments.Add(Cr1Def);
var Cr2Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(CR2), 
SpinalManipulaiton
);
Cr2Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
Cr2Def.UnusedFields.AddRange(new []{  }.ToList());
Cr2Def.SyntaxRuleList.AddRange("".Split(',').ToList());
SpinalManipulaiton.Definition = Cr2Def;
docDef.segments.Add(Cr2Def);
var CrcDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(CRC), 
AmbulanceCertification
);
CrcDef.Qualifiers.Add(new SegmentQualifiers(1, "7".Split(','))); 
CrcDef.UnusedFields.AddRange(new []{  }.ToList());
CrcDef.SyntaxRuleList.AddRange("".Split(',').ToList());
AmbulanceCertification.Definition = CrcDef;
docDef.segments.Add(CrcDef);
var CrcDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(CRC), 
PationConditionVision
);
CrcDef.Qualifiers.Add(new SegmentQualifiers(1, ""E1,E2,E3"".Split(','))); 
CrcDef.UnusedFields.AddRange(new []{  }.ToList());
CrcDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PationConditionVision.Definition = CrcDef;
docDef.segments.Add(CrcDef);
var CrcDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(CRC), 
HomeboundIndicator
);
CrcDef.Qualifiers.Add(new SegmentQualifiers(1, "75".Split(','))); 
CrcDef.UnusedFields.AddRange(new []{  }.ToList());
CrcDef.SyntaxRuleList.AddRange("".Split(',').ToList());
HomeboundIndicator.Definition = CrcDef;
docDef.segments.Add(CrcDef);
var CrcDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(CRC), 
EPSDTReferral
);
CrcDef.Qualifiers.Add(new SegmentQualifiers(1, "ZZ".Split(','))); 
CrcDef.UnusedFields.AddRange(new []{  }.ToList());
CrcDef.SyntaxRuleList.AddRange("".Split(',').ToList());
EPSDTReferral.Definition = CrcDef;
docDef.segments.Add(CrcDef);
var HiDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(HI), 
HealthCareDiagnosisCode
);
HiDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
HiDef.UnusedFields.AddRange(new []{  }.ToList());
HiDef.SyntaxRuleList.AddRange("".Split(',').ToList());
HealthCareDiagnosisCode.Definition = HiDef;
docDef.segments.Add(HiDef);
var HiDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(HI), 
AnesthesiaRelatedProcedure
);
HiDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
HiDef.UnusedFields.AddRange(new []{  }.ToList());
HiDef.SyntaxRuleList.AddRange("".Split(',').ToList());
AnesthesiaRelatedProcedure.Definition = HiDef;
docDef.segments.Add(HiDef);
var HiDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(HI), 
ConditionInfomation
);
HiDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
HiDef.UnusedFields.AddRange(new []{  }.ToList());
HiDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ConditionInfomation.Definition = HiDef;
docDef.segments.Add(HiDef);
var HcpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(HCP), 
ClaimPricingInfo
);
HcpDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
HcpDef.UnusedFields.AddRange(new []{  }.ToList());
HcpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ClaimPricingInfo.Definition = HcpDef;
docDef.segments.Add(HcpDef);
}
}
public partial class Loop2310ACollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(999);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, ""DN,P3"".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(REF), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,1G,"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2310BCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "82".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var PrvDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(PRV), 
SpecialtyInfo
);
PrvDef.Qualifiers.Add(new SegmentQualifiers(1, "PE".Split(','))); 
PrvDef.UnusedFields.AddRange(new []{  }.ToList());
PrvDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SpecialtyInfo.Definition = PrvDef;
docDef.segments.Add(PrvDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(REF), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,1G,G2,LU,"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2310CCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "77".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var N3Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N3), 
Address
);
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N3Def.UnusedFields.AddRange(new []{  }.ToList());
N3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Address.Definition = N3Def;
docDef.segments.Add(N3Def);
var N4Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N4), 
Location
);
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(REF), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,G2,LU"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
var PerDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(PER), 
ContactInfo
);
PerDef.Qualifiers.Add(new SegmentQualifiers(1, "IC".Split(','))); 
PerDef.UnusedFields.AddRange(new []{  }.ToList());
PerDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ContactInfo.Definition = PerDef;
docDef.segments.Add(PerDef);
}
}
public partial class Loop2310DCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "DQ".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(REF), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,1G,G2,LU,"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2310ECollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "PW".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var N3Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N3), 
Address
);
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N3Def.UnusedFields.AddRange(new []{  }.ToList());
N3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Address.Definition = N3Def;
docDef.segments.Add(N3Def);
var N3Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N3), 
Locaiton
);
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N3Def.UnusedFields.AddRange(new []{  }.ToList());
N3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Locaiton.Definition = N3Def;
docDef.segments.Add(N3Def);
}
}
public partial class Loop2310FCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "45".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var N3Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N3), 
Address
);
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N3Def.UnusedFields.AddRange(new []{  }.ToList());
N3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Address.Definition = N3Def;
docDef.segments.Add(N3Def);
var N3Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N3), 
Locaiton
);
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N3Def.UnusedFields.AddRange(new []{  }.ToList());
N3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Locaiton.Definition = N3Def;
docDef.segments.Add(N3Def);
}
}
public partial class Loop2320Collection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(999);
docDef.loops.Add(this.Definition);
var SbrDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(SBR), 
Info
);
SbrDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
SbrDef.UnusedFields.AddRange(new []{  }.ToList());
SbrDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Info.Definition = SbrDef;
docDef.segments.Add(SbrDef);
var CasDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(CAS), 
Adjustments
);
CasDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
CasDef.UnusedFields.AddRange(new []{  }.ToList());
CasDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Adjustments.Definition = CasDef;
docDef.segments.Add(CasDef);
var AmtDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(AMT), 
COBPayerPaid
);
AmtDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
AmtDef.UnusedFields.AddRange(new []{  }.ToList());
AmtDef.SyntaxRuleList.AddRange("".Split(',').ToList());
COBPayerPaid.Definition = AmtDef;
docDef.segments.Add(AmtDef);
var AmtDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(AMT), 
COBTotalNonCovered
);
AmtDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
AmtDef.UnusedFields.AddRange(new []{  }.ToList());
AmtDef.SyntaxRuleList.AddRange("".Split(',').ToList());
COBTotalNonCovered.Definition = AmtDef;
docDef.segments.Add(AmtDef);
var AmtDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(AMT), 
RemainingPatientLiability
);
AmtDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
AmtDef.UnusedFields.AddRange(new []{  }.ToList());
AmtDef.SyntaxRuleList.AddRange("".Split(',').ToList());
RemainingPatientLiability.Definition = AmtDef;
docDef.segments.Add(AmtDef);
var OiDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(OI), 
OtherCoverageInfo
);
OiDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
OiDef.UnusedFields.AddRange(new []{  }.ToList());
OiDef.SyntaxRuleList.AddRange("".Split(',').ToList());
OtherCoverageInfo.Definition = OiDef;
docDef.segments.Add(OiDef);
var MoaDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(MOA), 
OutpatientAdjudicaiton
);
MoaDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
MoaDef.UnusedFields.AddRange(new []{  }.ToList());
MoaDef.SyntaxRuleList.AddRange("".Split(',').ToList());
OutpatientAdjudicaiton.Definition = MoaDef;
docDef.segments.Add(MoaDef);
}
}
public partial class Loop2330ACollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "IL".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var N3Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N3), 
Address
);
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N3Def.UnusedFields.AddRange(new []{  }.ToList());
N3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Address.Definition = N3Def;
docDef.segments.Add(N3Def);
var N4Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N4), 
Location
);
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "SY".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2330BCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "PR".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var N3Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N3), 
Address
);
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N3Def.UnusedFields.AddRange(new []{  }.ToList());
N3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Address.Definition = N3Def;
docDef.segments.Add(N3Def);
var N4Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N4), 
Location
);
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
CheckRemittanceDate
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "573".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
CheckRemittanceDate.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(REF), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""2U,EI,FY,NF,"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
AuthorizationNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "G1".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
AuthorizationNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
ReferalNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "9F".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ReferalNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
AdjustmentIndicator
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "T4".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
AdjustmentIndicator.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
ControlNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "F8".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ControlNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2330CCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(999);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, ""DN,P3,"".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(REF), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,1G,G2"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2330DCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "82".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(REF), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,1G,G2,LU,"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2330ECollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "77".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(REF), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,G2,LU"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2330FCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "DQ".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(REF), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,1G,G2,LU,"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2330GCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "85".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(REF), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""G2,LU,"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2400Collection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(999);
docDef.loops.Add(this.Definition);
var LxDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(LX), 
LineNumber
);
LxDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
LxDef.UnusedFields.AddRange(new []{  }.ToList());
LxDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LineNumber.Definition = LxDef;
docDef.segments.Add(LxDef);
var Sv1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(SV1), 
ProfessionalService
);
Sv1Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
Sv1Def.UnusedFields.AddRange(new []{  }.ToList());
Sv1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
ProfessionalService.Definition = Sv1Def;
docDef.segments.Add(Sv1Def);
var Sv5Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(SV5), 
MedicalEqupmentService
);
Sv5Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
Sv5Def.UnusedFields.AddRange(new []{  }.ToList());
Sv5Def.SyntaxRuleList.AddRange("".Split(',').ToList());
MedicalEqupmentService.Definition = Sv5Def;
docDef.segments.Add(Sv5Def);
var PwkDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(PWK), 
LineSupplemental
);
PwkDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
PwkDef.UnusedFields.AddRange(new []{  }.ToList());
PwkDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LineSupplemental.Definition = PwkDef;
docDef.segments.Add(PwkDef);
var PwkDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(PWK), 
EquipmentCertificateIndicator
);
PwkDef.Qualifiers.Add(new SegmentQualifiers(1, "CT".Split(','))); 
PwkDef.UnusedFields.AddRange(new []{  }.ToList());
PwkDef.SyntaxRuleList.AddRange("".Split(',').ToList());
EquipmentCertificateIndicator.Definition = PwkDef;
docDef.segments.Add(PwkDef);
var Cr1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(CR1), 
AmbulanceTransport
);
Cr1Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
Cr1Def.UnusedFields.AddRange(new []{  }.ToList());
Cr1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
AmbulanceTransport.Definition = Cr1Def;
docDef.segments.Add(Cr1Def);
var Cr3Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(CR3), 
MedicalEquipmentCertification
);
Cr3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
Cr3Def.UnusedFields.AddRange(new []{  }.ToList());
Cr3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
MedicalEquipmentCertification.Definition = Cr3Def;
docDef.segments.Add(Cr3Def);
var CrcDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(CRC), 
AmbulanceCertification
);
CrcDef.Qualifiers.Add(new SegmentQualifiers(1, "7".Split(','))); 
CrcDef.UnusedFields.AddRange(new []{  }.ToList());
CrcDef.SyntaxRuleList.AddRange("".Split(',').ToList());
AmbulanceCertification.Definition = CrcDef;
docDef.segments.Add(CrcDef);
var CrcDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(CRC), 
HospiceEmployeeIndicator
);
CrcDef.Qualifiers.Add(new SegmentQualifiers(1, "70".Split(','))); 
CrcDef.UnusedFields.AddRange(new []{  }.ToList());
CrcDef.SyntaxRuleList.AddRange("".Split(',').ToList());
HospiceEmployeeIndicator.Definition = CrcDef;
docDef.segments.Add(CrcDef);
var CrcDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(CRC), 
EquipmentConditionIndicator
);
CrcDef.Qualifiers.Add(new SegmentQualifiers(1, "9".Split(','))); 
CrcDef.UnusedFields.AddRange(new []{  }.ToList());
CrcDef.SyntaxRuleList.AddRange("".Split(',').ToList());
EquipmentConditionIndicator.Definition = CrcDef;
docDef.segments.Add(CrcDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
ServiceDate
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "472".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ServiceDate.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
Perscription
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "471".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Perscription.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
CertificationRevision
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "607".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
CertificationRevision.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
BeginTherapy
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "463".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
BeginTherapy.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
LastCertificationDate
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "461".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LastCertificationDate.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
LastSeen
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "304".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LastSeen.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(DTP), 
Test
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, ""738,739,"".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Test.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
Shipped
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "11".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Shipped.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
LastXRay
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "455".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LastXRay.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
InitialTreatment
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "454".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
InitialTreatment.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var QtyDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(QTY), 
AmbulancePatientcount
);
QtyDef.Qualifiers.Add(new SegmentQualifiers(1, "PT".Split(','))); 
QtyDef.UnusedFields.AddRange(new []{  }.ToList());
QtyDef.SyntaxRuleList.AddRange("".Split(',').ToList());
AmbulancePatientcount.Definition = QtyDef;
docDef.segments.Add(QtyDef);
var QtyDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(QTY), 
ObstetricAnesthesiaAdditionalUnits
);
QtyDef.Qualifiers.Add(new SegmentQualifiers(1, "FL".Split(','))); 
QtyDef.UnusedFields.AddRange(new []{  }.ToList());
QtyDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ObstetricAnesthesiaAdditionalUnits.Definition = QtyDef;
docDef.segments.Add(QtyDef);
var MeaDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(MEA), 
TestResults
);
MeaDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
MeaDef.UnusedFields.AddRange(new []{  }.ToList());
MeaDef.SyntaxRuleList.AddRange("".Split(',').ToList());
TestResults.Definition = MeaDef;
docDef.segments.Add(MeaDef);
var Cn1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(CN1), 
Contact
);
Cn1Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
Cn1Def.UnusedFields.AddRange(new []{  }.ToList());
Cn1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Contact.Definition = Cn1Def;
docDef.segments.Add(Cn1Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
RepricdLineItemNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "9B".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
RepricdLineItemNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
AdujstedRepricedLineNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "9D".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
AdujstedRepricedLineNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
PriorAuthorization
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "G1".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PriorAuthorization.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
LineItemControlNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "6R".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LineItemControlNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
MammographyCertificationNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "EW".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
MammographyCertificationNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
CLIANumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "X4".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
CLIANumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
CLIAId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "F4".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
CLIAId.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
ImmunizationBatch
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "BT".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ImmunizationBatch.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(REF), 
ReferralNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "9F".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ReferralNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var AmtDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(AMT), 
SalesTax
);
AmtDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
AmtDef.UnusedFields.AddRange(new []{  }.ToList());
AmtDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SalesTax.Definition = AmtDef;
docDef.segments.Add(AmtDef);
var AmtDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(AMT), 
PostageClaimed
);
AmtDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
AmtDef.UnusedFields.AddRange(new []{  }.ToList());
AmtDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PostageClaimed.Definition = AmtDef;
docDef.segments.Add(AmtDef);
var K3Def = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(K3), 
FileInfo
);
K3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
K3Def.UnusedFields.AddRange(new []{  }.ToList());
K3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
FileInfo.Definition = K3Def;
docDef.segments.Add(K3Def);
var NteDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NTE), 
LineNote
);
NteDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
NteDef.UnusedFields.AddRange(new []{  }.ToList());
NteDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LineNote.Definition = NteDef;
docDef.segments.Add(NteDef);
var NteDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NTE), 
ThirdPartyNotes
);
NteDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
NteDef.UnusedFields.AddRange(new []{  }.ToList());
NteDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ThirdPartyNotes.Definition = NteDef;
docDef.segments.Add(NteDef);
var Ps1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(PS1), 
PurchasedServiceInfo
);
Ps1Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
Ps1Def.UnusedFields.AddRange(new []{  }.ToList());
Ps1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
PurchasedServiceInfo.Definition = Ps1Def;
docDef.segments.Add(Ps1Def);
var HcpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(HCP), 
LinePricing
);
HcpDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
HcpDef.UnusedFields.AddRange(new []{  }.ToList());
HcpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LinePricing.Definition = HcpDef;
docDef.segments.Add(HcpDef);
}
}
public partial class Loop2410Collection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var LinDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(LIN), 
Indentification
);
LinDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
LinDef.UnusedFields.AddRange(new []{  }.ToList());
LinDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Indentification.Definition = LinDef;
docDef.segments.Add(LinDef);
var CtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(CTP), 
Quantity
);
CtpDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
CtpDef.UnusedFields.AddRange(new []{  }.ToList());
CtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Quantity.Definition = CtpDef;
docDef.segments.Add(CtpDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(REF), 
Perscription
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""VY,XZ,"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Perscription.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2420ACollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "82".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var PrvDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(PRV), 
Specialty
);
PrvDef.Qualifiers.Add(new SegmentQualifiers(1, "PE".Split(','))); 
PrvDef.UnusedFields.AddRange(new []{  }.ToList());
PrvDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Specialty.Definition = PrvDef;
docDef.segments.Add(PrvDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(REF), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,1G,G2,LU,"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2420BCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "QB".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(REF), 
SecondaryInfo
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""OB,1G,G2"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryInfo.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2420CCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "77".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var N3Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N3), 
Address
);
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N3Def.UnusedFields.AddRange(new []{  }.ToList());
N3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Address.Definition = N3Def;
docDef.segments.Add(N3Def);
var N4Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N4), 
Location
);
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(REF), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""G2,LU,"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2420DCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "DQ".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(REF), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""OB,1G,G2,LU,"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2420ECollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "DK".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var N3Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N3), 
Address
);
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N3Def.UnusedFields.AddRange(new []{  }.ToList());
N3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Address.Definition = N3Def;
docDef.segments.Add(N3Def);
var N4Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N4), 
Location
);
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(REF), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,1G,G2"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
var PerDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(PER), 
Contact
);
PerDef.Qualifiers.Add(new SegmentQualifiers(1, "IC".Split(','))); 
PerDef.UnusedFields.AddRange(new []{  }.ToList());
PerDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Contact.Definition = PerDef;
docDef.segments.Add(PerDef);
}
}
public partial class Loop2420FCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(999);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, ""DN,P3,"".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(REF), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,1G,G2"".Split(','))); 
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2420GCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "PW".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var N3Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N3), 
Address
);
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N3Def.UnusedFields.AddRange(new []{  }.ToList());
N3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Address.Definition = N3Def;
docDef.segments.Add(N3Def);
var N4Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N4), 
Location
);
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
}
}
public partial class Loop2420HCollection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(1);
docDef.loops.Add(this.Definition);
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(NM1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "45".Split(','))); 
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var N3Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N3), 
Address
);
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N3Def.UnusedFields.AddRange(new []{  }.ToList());
N3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Address.Definition = N3Def;
docDef.segments.Add(N3Def);
var N4Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(N4), 
Location
);
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
}
}
public partial class Loop2430Collection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(999);
docDef.loops.Add(this.Definition);
var SvdDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(SVD), 
Info
);
SvdDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
SvdDef.UnusedFields.AddRange(new []{  }.ToList());
SvdDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Info.Definition = SvdDef;
docDef.segments.Add(SvdDef);
var CasDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(CAS), 
LineAdjustment
);
CasDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
CasDef.UnusedFields.AddRange(new []{  }.ToList());
CasDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LineAdjustment.Definition = CasDef;
docDef.segments.Add(CasDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(DTP), 
CheckRemittanceDate
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "573".Split(','))); 
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
CheckRemittanceDate.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var AmtDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(AMT), 
RemainingPatientLiability
);
AmtDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
AmtDef.UnusedFields.AddRange(new []{  }.ToList());
AmtDef.SyntaxRuleList.AddRange("".Split(',').ToList());
RemainingPatientLiability.Definition = AmtDef;
docDef.segments.Add(AmtDef);
}
}
public partial class Loop2440Collection{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition(999);
docDef.loops.Add(this.Definition);
var LqDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(LQ), 
Code
);
LqDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
LqDef.UnusedFields.AddRange(new []{  }.ToList());
LqDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Code.Definition = LqDef;
docDef.segments.Add(LqDef);
var FrmDef = new SegmentDefinition(
SegmentUsageType.Required, 
999, 
typeof(FRM), 
SupportingDocumentation
);
FrmDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(','))); 
FrmDef.UnusedFields.AddRange(new []{  }.ToList());
FrmDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SupportingDocumentation.Definition = FrmDef;
docDef.segments.Add(FrmDef);
}
}
