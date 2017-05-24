public partial class Loop1000A : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "41".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
Nm1Def.UnusedFields.AddRange(new []{ "1,2,3,8,9" }.ToList());
Nm1Def.SyntaxRuleList.AddRange(""10,11,12"".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var PerDef = new SegmentDefinition(
SegmentUsageType.Required, 
2, 
typeof(Per), 
EDIContact
);
PerDef.Qualifiers.Add(new SegmentQualifiers(1, "IC".Split(',').ToList()); 
PerDef.RequiredFields.AddRange(new []{  }.ToList());
PerDef.UnusedFields.AddRange(new []{ "1,3,4" }.ToList());
PerDef.SyntaxRuleList.AddRange("9".Split(',').ToList());
EDIContact.Definition = PerDef;
docDef.segments.Add(PerDef);
}
}
public partial class Loop1000B : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "40".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
Nm1Def.UnusedFields.AddRange(new []{ "1,2,3,8,9" }.ToList());
Nm1Def.SyntaxRuleList.AddRange(""4,5,6,7,10,11,12"".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
}
}
public partial class Loop2000A : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition999
docDef.loops.Add(this.Definition)
var HlDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Hl), 
Level
);
HlDef.Qualifiers.Add(new SegmentQualifiers(1, "20".Split(',').ToList()); 
HlDef.RequiredFields.AddRange(new []{  }.ToList());
HlDef.UnusedFields.AddRange(new []{ "1,3,4" }.ToList());
HlDef.SyntaxRuleList.AddRange("2".Split(',').ToList());
Level.Definition = HlDef;
docDef.segments.Add(HlDef);
var PrvDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Prv), 
SpecialtyInfo
);
PrvDef.Qualifiers.Add(new SegmentQualifiers(1, "BI".Split(',').ToList()); 
PrvDef.RequiredFields.AddRange(new []{  }.ToList());
PrvDef.UnusedFields.AddRange(new []{ "1,2,3" }.ToList());
PrvDef.SyntaxRuleList.AddRange(""4,6"".Split(',').ToList());
SpecialtyInfo.Definition = PrvDef;
docDef.segments.Add(PrvDef);
var CurDef = new SegmentDefinition(
SegmentUsageType.Optional, 
1, 
typeof(Cur), 
Currency
);
CurDef.Qualifiers.Add(new SegmentQualifiers(1, "85".Split(',').ToList()); 
CurDef.RequiredFields.AddRange(new []{  }.ToList());
CurDef.UnusedFields.AddRange(new []{ "1,2" }.ToList());
CurDef.SyntaxRuleList.AddRange(""3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21"".Split(',').ToList());
Currency.Definition = CurDef;
docDef.segments.Add(CurDef);
}
}
public partial class Loop2010AA : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "85".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
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
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N3Def.RequiredFields.AddRange(new []{  }.ToList());
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
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N4Def.RequiredFields.AddRange(new []{  }.ToList());
N4Def.UnusedFields.AddRange(new []{ 1 }.ToList());
N4Def.SyntaxRuleList.AddRange(""5,6"".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
TaxId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""EI,SY,"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
TaxId.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
2, 
typeof(Ref), 
UPINLicense
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,1G,"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
UPINLicense.Definition = RefDef;
docDef.segments.Add(RefDef);
var PerDef = new SegmentDefinition(
SegmentUsageType.Required, 
2, 
typeof(Per), 
ContactInfo
);
PerDef.Qualifiers.Add(new SegmentQualifiers(1, "IC".Split(',').ToList()); 
PerDef.RequiredFields.AddRange(new []{  }.ToList());
PerDef.UnusedFields.AddRange(new []{  }.ToList());
PerDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ContactInfo.Definition = PerDef;
docDef.segments.Add(PerDef);
}
}
public partial class Loop2010AB : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "87".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
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
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N3Def.RequiredFields.AddRange(new []{  }.ToList());
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
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N4Def.RequiredFields.AddRange(new []{  }.ToList());
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
}
}
public partial class Loop2010AC : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "PE".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
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
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N3Def.RequiredFields.AddRange(new []{  }.ToList());
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
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N4Def.RequiredFields.AddRange(new []{  }.ToList());
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""2U,FY,NF"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
TaxID
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "EI".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
TaxID.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2000B : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var HlDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Hl), 
Level
);
HlDef.Qualifiers.Add(new SegmentQualifiers(1, "22".Split(',').ToList()); 
HlDef.RequiredFields.AddRange(new []{  }.ToList());
HlDef.UnusedFields.AddRange(new []{  }.ToList());
HlDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Level.Definition = HlDef;
docDef.segments.Add(HlDef);
var SbrDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Sbr), 
SubscriberInfo
);
SbrDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
SbrDef.RequiredFields.AddRange(new []{  }.ToList());
SbrDef.UnusedFields.AddRange(new []{  }.ToList());
SbrDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SubscriberInfo.Definition = SbrDef;
docDef.segments.Add(SbrDef);
var PatDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Pat), 
PationInfo
);
PatDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
PatDef.RequiredFields.AddRange(new []{  }.ToList());
PatDef.UnusedFields.AddRange(new []{  }.ToList());
PatDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PationInfo.Definition = PatDef;
docDef.segments.Add(PatDef);
}
}
public partial class Loop2010BA : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "IL".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
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
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N3Def.RequiredFields.AddRange(new []{  }.ToList());
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
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N4Def.RequiredFields.AddRange(new []{  }.ToList());
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
var DmgDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dmg), 
Demographic
);
DmgDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
DmgDef.RequiredFields.AddRange(new []{  }.ToList());
DmgDef.UnusedFields.AddRange(new []{  }.ToList());
DmgDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Demographic.Definition = DmgDef;
docDef.segments.Add(DmgDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "SY".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
PropertyCausualtyClaimNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "Y4".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PropertyCausualtyClaimNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var PerDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Per), 
PropertyCausualtySubscriberContact
);
PerDef.Qualifiers.Add(new SegmentQualifiers(1, "IC".Split(',').ToList()); 
PerDef.RequiredFields.AddRange(new []{  }.ToList());
PerDef.UnusedFields.AddRange(new []{  }.ToList());
PerDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PropertyCausualtySubscriberContact.Definition = PerDef;
docDef.segments.Add(PerDef);
}
}
public partial class Loop2010BB : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "PR".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
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
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N3Def.RequiredFields.AddRange(new []{  }.ToList());
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
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N4Def.RequiredFields.AddRange(new []{  }.ToList());
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
3, 
typeof(Ref), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""2U,EI,FY,NF,"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
2, 
typeof(Ref), 
BillingProviderSecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""G2,LU,"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
BillingProviderSecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2000C : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var HlDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Hl), 
Level
);
HlDef.Qualifiers.Add(new SegmentQualifiers(1, "23".Split(',').ToList()); 
HlDef.RequiredFields.AddRange(new []{  }.ToList());
HlDef.UnusedFields.AddRange(new []{  }.ToList());
HlDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Level.Definition = HlDef;
docDef.segments.Add(HlDef);
var PatDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Pat), 
Info
);
PatDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
PatDef.RequiredFields.AddRange(new []{  }.ToList());
PatDef.UnusedFields.AddRange(new []{  }.ToList());
PatDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Info.Definition = PatDef;
docDef.segments.Add(PatDef);
}
}
public partial class Loop2010CA : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "QC".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
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
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N3Def.RequiredFields.AddRange(new []{  }.ToList());
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
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N4Def.RequiredFields.AddRange(new []{  }.ToList());
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
var DmgDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dmg), 
Demographic
);
DmgDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
DmgDef.RequiredFields.AddRange(new []{  }.ToList());
DmgDef.UnusedFields.AddRange(new []{  }.ToList());
DmgDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Demographic.Definition = DmgDef;
docDef.segments.Add(DmgDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
PropertyCausualtyClaimNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "Y4".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PropertyCausualtyClaimNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
PropertyCausualtyPatientId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""1W,SY,"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PropertyCausualtyPatientId.Definition = RefDef;
docDef.segments.Add(RefDef);
var PerDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Per), 
PropertyCausualtySubscriberContact
);
PerDef.Qualifiers.Add(new SegmentQualifiers(1, "IC".Split(',').ToList()); 
PerDef.RequiredFields.AddRange(new []{  }.ToList());
PerDef.UnusedFields.AddRange(new []{  }.ToList());
PerDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PropertyCausualtySubscriberContact.Definition = PerDef;
docDef.segments.Add(PerDef);
}
}
public partial class Loop2300 : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition999
docDef.loops.Add(this.Definition)
var ClmDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Clm), 
Claim
);
ClmDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
ClmDef.RequiredFields.AddRange(new []{  }.ToList());
ClmDef.UnusedFields.AddRange(new []{  }.ToList());
ClmDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Claim.Definition = ClmDef;
docDef.segments.Add(ClmDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
Onset
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "431".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Onset.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
Initialtreatment
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "454".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Initialtreatment.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
LastSeen
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "304".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LastSeen.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
AcuteManifestation
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "453".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
AcuteManifestation.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
Accident
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "439".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Accident.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
LastMenstrual
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "484".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LastMenstrual.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
LastXRay
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "455".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LastXRay.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
HearingVisionPrescription
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "471".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
HearingVisionPrescription.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
DisabilityDates
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, ""314,360,361"".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
DisabilityDates.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
LastWored
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "297".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LastWored.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
AuthorizedReturnWork
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "296".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
AuthorizedReturnWork.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
Admission
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "435".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Admission.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
Discharge
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "96".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Discharge.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
AssumedRelinquishedCare
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, ""090,091,"".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
AssumedRelinquishedCare.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
PropertyCasualtyFirstContact
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "444".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PropertyCasualtyFirstContact.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
RepricerReceived
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "50".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
RepricerReceived.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var PwkDef = new SegmentDefinition(
SegmentUsageType.Required, 
10, 
typeof(Pwk), 
SupplementalInfomation
);
PwkDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
PwkDef.RequiredFields.AddRange(new []{  }.ToList());
PwkDef.UnusedFields.AddRange(new []{  }.ToList());
PwkDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SupplementalInfomation.Definition = PwkDef;
docDef.segments.Add(PwkDef);
var Cn1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Cn1), 
Contact
);
Cn1Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
Cn1Def.RequiredFields.AddRange(new []{  }.ToList());
Cn1Def.UnusedFields.AddRange(new []{  }.ToList());
Cn1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Contact.Definition = Cn1Def;
docDef.segments.Add(Cn1Def);
var AmtDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Amt), 
PatientAmountPaid
);
AmtDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
AmtDef.RequiredFields.AddRange(new []{  }.ToList());
AmtDef.UnusedFields.AddRange(new []{  }.ToList());
AmtDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PatientAmountPaid.Definition = AmtDef;
docDef.segments.Add(AmtDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
ServiceAuthorizationException
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "4N".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ServiceAuthorizationException.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
MandatoryMedicareCrossover
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "F5".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
MandatoryMedicareCrossover.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
MammographCertificationNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "EW".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
MammographCertificationNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
ReferalNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "9F".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ReferalNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
PriorAuthorizaiton
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "G1".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PriorAuthorizaiton.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
PayerClaimControlNumer
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "F8".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PayerClaimControlNumer.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
CLIANumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "X4".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
CLIANumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
RepricedClaimNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "9A".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
RepricedClaimNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
AdjustedRepricedClaimNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "9C".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
AdjustedRepricedClaimNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
InvestigativeDeviceExemption
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "LX".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
InvestigativeDeviceExemption.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
ClaimIdForTransmissionIntermediaries
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "D9".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ClaimIdForTransmissionIntermediaries.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
MedicalRecordNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "EA".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
MedicalRecordNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
DemonstrationProjectId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "P4".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
DemonstrationProjectId.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
CarePlanOversight
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "1J".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
CarePlanOversight.Definition = RefDef;
docDef.segments.Add(RefDef);
var K3Def = new SegmentDefinition(
SegmentUsageType.Required, 
10, 
typeof(K3), 
FileInfo
);
K3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
K3Def.RequiredFields.AddRange(new []{  }.ToList());
K3Def.UnusedFields.AddRange(new []{  }.ToList());
K3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
FileInfo.Definition = K3Def;
docDef.segments.Add(K3Def);
var NteDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nte), 
Note
);
NteDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
NteDef.RequiredFields.AddRange(new []{  }.ToList());
NteDef.UnusedFields.AddRange(new []{  }.ToList());
NteDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Note.Definition = NteDef;
docDef.segments.Add(NteDef);
var Cr1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Cr1), 
AmbulanceInfo
);
Cr1Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
Cr1Def.RequiredFields.AddRange(new []{  }.ToList());
Cr1Def.UnusedFields.AddRange(new []{  }.ToList());
Cr1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
AmbulanceInfo.Definition = Cr1Def;
docDef.segments.Add(Cr1Def);
var Cr2Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Cr2), 
SpinalManipulaiton
);
Cr2Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
Cr2Def.RequiredFields.AddRange(new []{  }.ToList());
Cr2Def.UnusedFields.AddRange(new []{  }.ToList());
Cr2Def.SyntaxRuleList.AddRange("".Split(',').ToList());
SpinalManipulaiton.Definition = Cr2Def;
docDef.segments.Add(Cr2Def);
var CrcDef = new SegmentDefinition(
SegmentUsageType.Required, 
3, 
typeof(Crc), 
AmbulanceCertification
);
CrcDef.Qualifiers.Add(new SegmentQualifiers(1, "7".Split(',').ToList()); 
CrcDef.RequiredFields.AddRange(new []{  }.ToList());
CrcDef.UnusedFields.AddRange(new []{  }.ToList());
CrcDef.SyntaxRuleList.AddRange("".Split(',').ToList());
AmbulanceCertification.Definition = CrcDef;
docDef.segments.Add(CrcDef);
var CrcDef = new SegmentDefinition(
SegmentUsageType.Required, 
3, 
typeof(Crc), 
PationConditionVision
);
CrcDef.Qualifiers.Add(new SegmentQualifiers(1, ""E1,E2,E3"".Split(',').ToList()); 
CrcDef.RequiredFields.AddRange(new []{  }.ToList());
CrcDef.UnusedFields.AddRange(new []{  }.ToList());
CrcDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PationConditionVision.Definition = CrcDef;
docDef.segments.Add(CrcDef);
var CrcDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Crc), 
HomeboundIndicator
);
CrcDef.Qualifiers.Add(new SegmentQualifiers(1, "75".Split(',').ToList()); 
CrcDef.RequiredFields.AddRange(new []{  }.ToList());
CrcDef.UnusedFields.AddRange(new []{  }.ToList());
CrcDef.SyntaxRuleList.AddRange("".Split(',').ToList());
HomeboundIndicator.Definition = CrcDef;
docDef.segments.Add(CrcDef);
var CrcDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Crc), 
EPSDTReferral
);
CrcDef.Qualifiers.Add(new SegmentQualifiers(1, "ZZ".Split(',').ToList()); 
CrcDef.RequiredFields.AddRange(new []{  }.ToList());
CrcDef.UnusedFields.AddRange(new []{  }.ToList());
CrcDef.SyntaxRuleList.AddRange("".Split(',').ToList());
EPSDTReferral.Definition = CrcDef;
docDef.segments.Add(CrcDef);
var HiDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Hi), 
HealthCareDiagnosisCode
);
HiDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
HiDef.RequiredFields.AddRange(new []{  }.ToList());
HiDef.UnusedFields.AddRange(new []{  }.ToList());
HiDef.SyntaxRuleList.AddRange("".Split(',').ToList());
HealthCareDiagnosisCode.Definition = HiDef;
docDef.segments.Add(HiDef);
var HiDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Hi), 
AnesthesiaRelatedProcedure
);
HiDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
HiDef.RequiredFields.AddRange(new []{  }.ToList());
HiDef.UnusedFields.AddRange(new []{  }.ToList());
HiDef.SyntaxRuleList.AddRange("".Split(',').ToList());
AnesthesiaRelatedProcedure.Definition = HiDef;
docDef.segments.Add(HiDef);
var HiDef = new SegmentDefinition(
SegmentUsageType.Required, 
2, 
typeof(Hi), 
ConditionInfomation
);
HiDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
HiDef.RequiredFields.AddRange(new []{  }.ToList());
HiDef.UnusedFields.AddRange(new []{  }.ToList());
HiDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ConditionInfomation.Definition = HiDef;
docDef.segments.Add(HiDef);
var HcpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Hcp), 
ClaimPricingInfo
);
HcpDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
HcpDef.RequiredFields.AddRange(new []{  }.ToList());
HcpDef.UnusedFields.AddRange(new []{  }.ToList());
HcpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ClaimPricingInfo.Definition = HcpDef;
docDef.segments.Add(HcpDef);
}
}
public partial class Loop2310A : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition999
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, ""DN,P3"".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
3, 
typeof(Ref), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,1G,"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2310B : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "82".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var PrvDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Prv), 
SpecialtyInfo
);
PrvDef.Qualifiers.Add(new SegmentQualifiers(1, "PE".Split(',').ToList()); 
PrvDef.RequiredFields.AddRange(new []{  }.ToList());
PrvDef.UnusedFields.AddRange(new []{  }.ToList());
PrvDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SpecialtyInfo.Definition = PrvDef;
docDef.segments.Add(PrvDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
4, 
typeof(Ref), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,1G,G2,LU,"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2310C : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "77".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
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
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N3Def.RequiredFields.AddRange(new []{  }.ToList());
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
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N4Def.RequiredFields.AddRange(new []{  }.ToList());
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
3, 
typeof(Ref), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,G2,LU"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
var PerDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Per), 
ContactInfo
);
PerDef.Qualifiers.Add(new SegmentQualifiers(1, "IC".Split(',').ToList()); 
PerDef.RequiredFields.AddRange(new []{  }.ToList());
PerDef.UnusedFields.AddRange(new []{  }.ToList());
PerDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ContactInfo.Definition = PerDef;
docDef.segments.Add(PerDef);
}
}
public partial class Loop2310D : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "DQ".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
4, 
typeof(Ref), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,1G,G2,LU,"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2310E : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "PW".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
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
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N3Def.RequiredFields.AddRange(new []{  }.ToList());
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
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N3Def.RequiredFields.AddRange(new []{  }.ToList());
N3Def.UnusedFields.AddRange(new []{  }.ToList());
N3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Locaiton.Definition = N3Def;
docDef.segments.Add(N3Def);
}
}
public partial class Loop2310F : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "45".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
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
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N3Def.RequiredFields.AddRange(new []{  }.ToList());
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
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N3Def.RequiredFields.AddRange(new []{  }.ToList());
N3Def.UnusedFields.AddRange(new []{  }.ToList());
N3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Locaiton.Definition = N3Def;
docDef.segments.Add(N3Def);
}
}
public partial class Loop2320 : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition999
docDef.loops.Add(this.Definition)
var SbrDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Sbr), 
Info
);
SbrDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
SbrDef.RequiredFields.AddRange(new []{  }.ToList());
SbrDef.UnusedFields.AddRange(new []{  }.ToList());
SbrDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Info.Definition = SbrDef;
docDef.segments.Add(SbrDef);
var CasDef = new SegmentDefinition(
SegmentUsageType.Required, 
5, 
typeof(Cas), 
Adjustments
);
CasDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
CasDef.RequiredFields.AddRange(new []{  }.ToList());
CasDef.UnusedFields.AddRange(new []{  }.ToList());
CasDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Adjustments.Definition = CasDef;
docDef.segments.Add(CasDef);
var AmtDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Amt), 
COBPayerPaid
);
AmtDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
AmtDef.RequiredFields.AddRange(new []{  }.ToList());
AmtDef.UnusedFields.AddRange(new []{  }.ToList());
AmtDef.SyntaxRuleList.AddRange("".Split(',').ToList());
COBPayerPaid.Definition = AmtDef;
docDef.segments.Add(AmtDef);
var AmtDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Amt), 
COBTotalNonCovered
);
AmtDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
AmtDef.RequiredFields.AddRange(new []{  }.ToList());
AmtDef.UnusedFields.AddRange(new []{  }.ToList());
AmtDef.SyntaxRuleList.AddRange("".Split(',').ToList());
COBTotalNonCovered.Definition = AmtDef;
docDef.segments.Add(AmtDef);
var AmtDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Amt), 
RemainingPatientLiability
);
AmtDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
AmtDef.RequiredFields.AddRange(new []{  }.ToList());
AmtDef.UnusedFields.AddRange(new []{  }.ToList());
AmtDef.SyntaxRuleList.AddRange("".Split(',').ToList());
RemainingPatientLiability.Definition = AmtDef;
docDef.segments.Add(AmtDef);
var OiDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Oi), 
OtherCoverageInfo
);
OiDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
OiDef.RequiredFields.AddRange(new []{  }.ToList());
OiDef.UnusedFields.AddRange(new []{  }.ToList());
OiDef.SyntaxRuleList.AddRange("".Split(',').ToList());
OtherCoverageInfo.Definition = OiDef;
docDef.segments.Add(OiDef);
var MoaDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Moa), 
OutpatientAdjudicaiton
);
MoaDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
MoaDef.RequiredFields.AddRange(new []{  }.ToList());
MoaDef.UnusedFields.AddRange(new []{  }.ToList());
MoaDef.SyntaxRuleList.AddRange("".Split(',').ToList());
OutpatientAdjudicaiton.Definition = MoaDef;
docDef.segments.Add(MoaDef);
}
}
public partial class Loop2330A : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "IL".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
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
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N3Def.RequiredFields.AddRange(new []{  }.ToList());
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
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N4Def.RequiredFields.AddRange(new []{  }.ToList());
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "SY".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2330B : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "PR".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
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
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N3Def.RequiredFields.AddRange(new []{  }.ToList());
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
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N4Def.RequiredFields.AddRange(new []{  }.ToList());
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
CheckRemittanceDate
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "573".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
CheckRemittanceDate.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
2, 
typeof(Ref), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""2U,EI,FY,NF,"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
AuthorizationNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "G1".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
AuthorizationNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
ReferalNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "9F".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ReferalNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
AdjustmentIndicator
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "T4".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
AdjustmentIndicator.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
ControlNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "F8".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ControlNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2330C : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition999
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, ""DN,P3,"".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
3, 
typeof(Ref), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,1G,G2"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2330D : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "82".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
3, 
typeof(Ref), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,1G,G2,LU,"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2330E : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "77".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
3, 
typeof(Ref), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,G2,LU"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2330F : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "DQ".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
3, 
typeof(Ref), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,1G,G2,LU,"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2330G : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "85".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
2, 
typeof(Ref), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""G2,LU,"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2400 : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition999
docDef.loops.Add(this.Definition)
var LxDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Lx), 
LineNumber
);
LxDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
LxDef.RequiredFields.AddRange(new []{  }.ToList());
LxDef.UnusedFields.AddRange(new []{  }.ToList());
LxDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LineNumber.Definition = LxDef;
docDef.segments.Add(LxDef);
var Sv1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Sv1), 
ProfessionalService
);
Sv1Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
Sv1Def.RequiredFields.AddRange(new []{  }.ToList());
Sv1Def.UnusedFields.AddRange(new []{  }.ToList());
Sv1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
ProfessionalService.Definition = Sv1Def;
docDef.segments.Add(Sv1Def);
var Sv5Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Sv5), 
MedicalEqupmentService
);
Sv5Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
Sv5Def.RequiredFields.AddRange(new []{  }.ToList());
Sv5Def.UnusedFields.AddRange(new []{  }.ToList());
Sv5Def.SyntaxRuleList.AddRange("".Split(',').ToList());
MedicalEqupmentService.Definition = Sv5Def;
docDef.segments.Add(Sv5Def);
var PwkDef = new SegmentDefinition(
SegmentUsageType.Required, 
10, 
typeof(Pwk), 
LineSupplemental
);
PwkDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
PwkDef.RequiredFields.AddRange(new []{  }.ToList());
PwkDef.UnusedFields.AddRange(new []{  }.ToList());
PwkDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LineSupplemental.Definition = PwkDef;
docDef.segments.Add(PwkDef);
var PwkDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Pwk), 
EquipmentCertificateIndicator
);
PwkDef.Qualifiers.Add(new SegmentQualifiers(1, "CT".Split(',').ToList()); 
PwkDef.RequiredFields.AddRange(new []{  }.ToList());
PwkDef.UnusedFields.AddRange(new []{  }.ToList());
PwkDef.SyntaxRuleList.AddRange("".Split(',').ToList());
EquipmentCertificateIndicator.Definition = PwkDef;
docDef.segments.Add(PwkDef);
var Cr1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Cr1), 
AmbulanceTransport
);
Cr1Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
Cr1Def.RequiredFields.AddRange(new []{  }.ToList());
Cr1Def.UnusedFields.AddRange(new []{  }.ToList());
Cr1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
AmbulanceTransport.Definition = Cr1Def;
docDef.segments.Add(Cr1Def);
var Cr3Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Cr3), 
MedicalEquipmentCertification
);
Cr3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
Cr3Def.RequiredFields.AddRange(new []{  }.ToList());
Cr3Def.UnusedFields.AddRange(new []{  }.ToList());
Cr3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
MedicalEquipmentCertification.Definition = Cr3Def;
docDef.segments.Add(Cr3Def);
var CrcDef = new SegmentDefinition(
SegmentUsageType.Required, 
3, 
typeof(Crc), 
AmbulanceCertification
);
CrcDef.Qualifiers.Add(new SegmentQualifiers(1, "7".Split(',').ToList()); 
CrcDef.RequiredFields.AddRange(new []{  }.ToList());
CrcDef.UnusedFields.AddRange(new []{  }.ToList());
CrcDef.SyntaxRuleList.AddRange("".Split(',').ToList());
AmbulanceCertification.Definition = CrcDef;
docDef.segments.Add(CrcDef);
var CrcDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Crc), 
HospiceEmployeeIndicator
);
CrcDef.Qualifiers.Add(new SegmentQualifiers(1, "70".Split(',').ToList()); 
CrcDef.RequiredFields.AddRange(new []{  }.ToList());
CrcDef.UnusedFields.AddRange(new []{  }.ToList());
CrcDef.SyntaxRuleList.AddRange("".Split(',').ToList());
HospiceEmployeeIndicator.Definition = CrcDef;
docDef.segments.Add(CrcDef);
var CrcDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Crc), 
EquipmentConditionIndicator
);
CrcDef.Qualifiers.Add(new SegmentQualifiers(1, "9".Split(',').ToList()); 
CrcDef.RequiredFields.AddRange(new []{  }.ToList());
CrcDef.UnusedFields.AddRange(new []{  }.ToList());
CrcDef.SyntaxRuleList.AddRange("".Split(',').ToList());
EquipmentConditionIndicator.Definition = CrcDef;
docDef.segments.Add(CrcDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
ServiceDate
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "472".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ServiceDate.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
Perscription
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "471".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Perscription.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
CertificationRevision
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "607".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
CertificationRevision.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
BeginTherapy
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "463".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
BeginTherapy.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
LastCertificationDate
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "461".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LastCertificationDate.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
LastSeen
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "304".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LastSeen.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
2, 
typeof(Dtp), 
Test
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, ""738,739,"".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Test.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
Shipped
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "11".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Shipped.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
LastXRay
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "455".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LastXRay.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
InitialTreatment
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "454".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
InitialTreatment.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var QtyDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Qty), 
AmbulancePatientcount
);
QtyDef.Qualifiers.Add(new SegmentQualifiers(1, "PT".Split(',').ToList()); 
QtyDef.RequiredFields.AddRange(new []{  }.ToList());
QtyDef.UnusedFields.AddRange(new []{  }.ToList());
QtyDef.SyntaxRuleList.AddRange("".Split(',').ToList());
AmbulancePatientcount.Definition = QtyDef;
docDef.segments.Add(QtyDef);
var QtyDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Qty), 
ObstetricAnesthesiaAdditionalUnits
);
QtyDef.Qualifiers.Add(new SegmentQualifiers(1, "FL".Split(',').ToList()); 
QtyDef.RequiredFields.AddRange(new []{  }.ToList());
QtyDef.UnusedFields.AddRange(new []{  }.ToList());
QtyDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ObstetricAnesthesiaAdditionalUnits.Definition = QtyDef;
docDef.segments.Add(QtyDef);
var MeaDef = new SegmentDefinition(
SegmentUsageType.Required, 
5, 
typeof(Mea), 
TestResults
);
MeaDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
MeaDef.RequiredFields.AddRange(new []{  }.ToList());
MeaDef.UnusedFields.AddRange(new []{  }.ToList());
MeaDef.SyntaxRuleList.AddRange("".Split(',').ToList());
TestResults.Definition = MeaDef;
docDef.segments.Add(MeaDef);
var Cn1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Cn1), 
Contact
);
Cn1Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
Cn1Def.RequiredFields.AddRange(new []{  }.ToList());
Cn1Def.UnusedFields.AddRange(new []{  }.ToList());
Cn1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Contact.Definition = Cn1Def;
docDef.segments.Add(Cn1Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
RepricdLineItemNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "9B".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
RepricdLineItemNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
AdujstedRepricedLineNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "9D".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
AdujstedRepricedLineNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
PriorAuthorization
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "G1".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PriorAuthorization.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
LineItemControlNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "6R".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LineItemControlNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
MammographyCertificationNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "EW".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
MammographyCertificationNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
CLIANumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "X4".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
CLIANumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
CLIAId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "F4".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
CLIAId.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
ImmunizationBatch
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "BT".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ImmunizationBatch.Definition = RefDef;
docDef.segments.Add(RefDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
5, 
typeof(Ref), 
ReferralNumber
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, "9F".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ReferralNumber.Definition = RefDef;
docDef.segments.Add(RefDef);
var AmtDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Amt), 
SalesTax
);
AmtDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
AmtDef.RequiredFields.AddRange(new []{  }.ToList());
AmtDef.UnusedFields.AddRange(new []{  }.ToList());
AmtDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SalesTax.Definition = AmtDef;
docDef.segments.Add(AmtDef);
var AmtDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Amt), 
PostageClaimed
);
AmtDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
AmtDef.RequiredFields.AddRange(new []{  }.ToList());
AmtDef.UnusedFields.AddRange(new []{  }.ToList());
AmtDef.SyntaxRuleList.AddRange("".Split(',').ToList());
PostageClaimed.Definition = AmtDef;
docDef.segments.Add(AmtDef);
var K3Def = new SegmentDefinition(
SegmentUsageType.Required, 
10, 
typeof(K3), 
FileInfo
);
K3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
K3Def.RequiredFields.AddRange(new []{  }.ToList());
K3Def.UnusedFields.AddRange(new []{  }.ToList());
K3Def.SyntaxRuleList.AddRange("".Split(',').ToList());
FileInfo.Definition = K3Def;
docDef.segments.Add(K3Def);
var NteDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nte), 
LineNote
);
NteDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
NteDef.RequiredFields.AddRange(new []{  }.ToList());
NteDef.UnusedFields.AddRange(new []{  }.ToList());
NteDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LineNote.Definition = NteDef;
docDef.segments.Add(NteDef);
var NteDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nte), 
ThirdPartyNotes
);
NteDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
NteDef.RequiredFields.AddRange(new []{  }.ToList());
NteDef.UnusedFields.AddRange(new []{  }.ToList());
NteDef.SyntaxRuleList.AddRange("".Split(',').ToList());
ThirdPartyNotes.Definition = NteDef;
docDef.segments.Add(NteDef);
var Ps1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ps1), 
PurchasedServiceInfo
);
Ps1Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
Ps1Def.RequiredFields.AddRange(new []{  }.ToList());
Ps1Def.UnusedFields.AddRange(new []{  }.ToList());
Ps1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
PurchasedServiceInfo.Definition = Ps1Def;
docDef.segments.Add(Ps1Def);
var HcpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Hcp), 
LinePricing
);
HcpDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
HcpDef.RequiredFields.AddRange(new []{  }.ToList());
HcpDef.UnusedFields.AddRange(new []{  }.ToList());
HcpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LinePricing.Definition = HcpDef;
docDef.segments.Add(HcpDef);
}
}
public partial class Loop2410 : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var LinDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Lin), 
Indentification
);
LinDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
LinDef.RequiredFields.AddRange(new []{  }.ToList());
LinDef.UnusedFields.AddRange(new []{  }.ToList());
LinDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Indentification.Definition = LinDef;
docDef.segments.Add(LinDef);
var CtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ctp), 
Quantity
);
CtpDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
CtpDef.RequiredFields.AddRange(new []{  }.ToList());
CtpDef.UnusedFields.AddRange(new []{  }.ToList());
CtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Quantity.Definition = CtpDef;
docDef.segments.Add(CtpDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Ref), 
Perscription
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""VY,XZ,"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Perscription.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2420A : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "82".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var PrvDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Prv), 
Specialty
);
PrvDef.Qualifiers.Add(new SegmentQualifiers(1, "PE".Split(',').ToList()); 
PrvDef.RequiredFields.AddRange(new []{  }.ToList());
PrvDef.UnusedFields.AddRange(new []{  }.ToList());
PrvDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Specialty.Definition = PrvDef;
docDef.segments.Add(PrvDef);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
20, 
typeof(Ref), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,1G,G2,LU,"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2420B : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "QB".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
20, 
typeof(Ref), 
SecondaryInfo
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""OB,1G,G2"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryInfo.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2420C : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "77".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
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
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N3Def.RequiredFields.AddRange(new []{  }.ToList());
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
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N4Def.RequiredFields.AddRange(new []{  }.ToList());
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
3, 
typeof(Ref), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""G2,LU,"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2420D : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "DQ".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
20, 
typeof(Ref), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""OB,1G,G2,LU,"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2420E : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "DK".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
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
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N3Def.RequiredFields.AddRange(new []{  }.ToList());
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
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N4Def.RequiredFields.AddRange(new []{  }.ToList());
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
20, 
typeof(Ref), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,1G,G2"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
var PerDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Per), 
Contact
);
PerDef.Qualifiers.Add(new SegmentQualifiers(1, "IC".Split(',').ToList()); 
PerDef.RequiredFields.AddRange(new []{  }.ToList());
PerDef.UnusedFields.AddRange(new []{  }.ToList());
PerDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Contact.Definition = PerDef;
docDef.segments.Add(PerDef);
}
}
public partial class Loop2420F : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition999
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, ""DN,P3,"".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
Nm1Def.UnusedFields.AddRange(new []{  }.ToList());
Nm1Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Name.Definition = Nm1Def;
docDef.segments.Add(Nm1Def);
var RefDef = new SegmentDefinition(
SegmentUsageType.Required, 
20, 
typeof(Ref), 
SecondaryId
);
RefDef.Qualifiers.Add(new SegmentQualifiers(1, ""0B,1G,G2"".Split(',').ToList()); 
RefDef.RequiredFields.AddRange(new []{  }.ToList());
RefDef.UnusedFields.AddRange(new []{  }.ToList());
RefDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SecondaryId.Definition = RefDef;
docDef.segments.Add(RefDef);
}
}
public partial class Loop2420G : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "PW".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
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
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N3Def.RequiredFields.AddRange(new []{  }.ToList());
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
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N4Def.RequiredFields.AddRange(new []{  }.ToList());
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
}
}
public partial class Loop2420H : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition1
docDef.loops.Add(this.Definition)
var Nm1Def = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Nm1), 
Name
);
Nm1Def.Qualifiers.Add(new SegmentQualifiers(1, "45".Split(',').ToList()); 
Nm1Def.RequiredFields.AddRange(new []{  }.ToList());
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
N3Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N3Def.RequiredFields.AddRange(new []{  }.ToList());
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
N4Def.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
N4Def.RequiredFields.AddRange(new []{  }.ToList());
N4Def.UnusedFields.AddRange(new []{  }.ToList());
N4Def.SyntaxRuleList.AddRange("".Split(',').ToList());
Location.Definition = N4Def;
docDef.segments.Add(N4Def);
}
}
public partial class Loop2430 : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition999
docDef.loops.Add(this.Definition)
var SvdDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Svd), 
Info
);
SvdDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
SvdDef.RequiredFields.AddRange(new []{  }.ToList());
SvdDef.UnusedFields.AddRange(new []{  }.ToList());
SvdDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Info.Definition = SvdDef;
docDef.segments.Add(SvdDef);
var CasDef = new SegmentDefinition(
SegmentUsageType.Required, 
5, 
typeof(Cas), 
LineAdjustment
);
CasDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
CasDef.RequiredFields.AddRange(new []{  }.ToList());
CasDef.UnusedFields.AddRange(new []{  }.ToList());
CasDef.SyntaxRuleList.AddRange("".Split(',').ToList());
LineAdjustment.Definition = CasDef;
docDef.segments.Add(CasDef);
var DtpDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Dtp), 
CheckRemittanceDate
);
DtpDef.Qualifiers.Add(new SegmentQualifiers(1, "573".Split(',').ToList()); 
DtpDef.RequiredFields.AddRange(new []{  }.ToList());
DtpDef.UnusedFields.AddRange(new []{  }.ToList());
DtpDef.SyntaxRuleList.AddRange("".Split(',').ToList());
CheckRemittanceDate.Definition = DtpDef;
docDef.segments.Add(DtpDef);
var AmtDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Amt), 
RemainingPatientLiability
);
AmtDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
AmtDef.RequiredFields.AddRange(new []{  }.ToList());
AmtDef.UnusedFields.AddRange(new []{  }.ToList());
AmtDef.SyntaxRuleList.AddRange("".Split(',').ToList());
RemainingPatientLiability.Definition = AmtDef;
docDef.segments.Add(AmtDef);
}
}
public partial class Loop2440 : LoopEntity{
public void SetUpDefinition(X12DocDefinition docDef){
this.Definition = new LoopDefinition999
docDef.loops.Add(this.Definition)
var LqDef = new SegmentDefinition(
SegmentUsageType.Required, 
1, 
typeof(Lq), 
Code
);
LqDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
LqDef.RequiredFields.AddRange(new []{  }.ToList());
LqDef.UnusedFields.AddRange(new []{  }.ToList());
LqDef.SyntaxRuleList.AddRange("".Split(',').ToList());
Code.Definition = LqDef;
docDef.segments.Add(LqDef);
var FrmDef = new SegmentDefinition(
SegmentUsageType.Required, 
99, 
typeof(Frm), 
SupportingDocumentation
);
FrmDef.Qualifiers.Add(new SegmentQualifiers(1, "".Split(',').ToList()); 
FrmDef.RequiredFields.AddRange(new []{  }.ToList());
FrmDef.UnusedFields.AddRange(new []{  }.ToList());
FrmDef.SyntaxRuleList.AddRange("".Split(',').ToList());
SupportingDocumentation.Definition = FrmDef;
docDef.segments.Add(FrmDef);
}
}
