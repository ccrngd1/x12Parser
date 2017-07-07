 
public partial class Loop2000ACollection
{
public override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 999;
SegmentDefinitions.Add(new HL(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "InformationSourceLevel",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"20")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Required
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
SegmentDefinitionName = "PayerName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"PR")},
SyntaxRules = new List<string>(){ "P0809","C1110","C1203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new PER(){
OwningLoopCollection = this,
SegmentDefinitionName = "PayerContactInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"IC")},
SyntaxRules = new List<string>(){ "P0304","P0506","P0708" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
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
SegmentDefinitionName = "InformationReceiverLevel",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"21")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Required
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
SegmentDefinitionName = "InformationReceiverName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"41")},
SyntaxRules = new List<string>(){ "P0809","C1110","C1203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
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
SegmentDefinitionName = "InformationReceiverTraceIdentifier",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"2")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new STC(){
OwningLoopCollection = this,
SegmentDefinitionName = "InformationReceiverStatusInformation",
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
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
SegmentDefinitionName = "ServiceProviderLevel",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"19")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
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
SegmentDefinitionName = "ProviderName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"1P")},
SyntaxRules = new List<string>(){ "P0809","C1110","C1203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
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
SegmentDefinitionName = "ProviderOfServiceTraceIdentifier",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"1")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new STC(){
OwningLoopCollection = this,
SegmentDefinitionName = "ProviderStatusInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"1P")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
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
SegmentDefinitionName = "SubscriberLevel",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"22")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
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
SegmentDefinitionName = "SubscriberName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"IL")},
SyntaxRules = new List<string>(){ "P0809","C1110","C1203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
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
SegmentDefinitionName = "ClaimStatusTrackingNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"2")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new STC(){
OwningLoopCollection = this,
SegmentDefinitionName = "ClaimLevelStatusInformation",
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "PayerClaimControlNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"1K")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "InstitutionalBillTypeIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"BLT")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "PatientControlNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"EJ")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "PharmacyPrescriptionNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"XZ")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "VoucherIdentifier",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"VV")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "ClaimIdentificationNumberForClearinghousesAnd",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"D9")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new DTP(){
OwningLoopCollection = this,
SegmentDefinitionName = "ClaimServiceDate",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"472")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
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
SegmentDefinitionName = "ServiceLineInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"AD","ER","HC","HP","IV","N4","NU","WK")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new STC(){
OwningLoopCollection = this,
SegmentDefinitionName = "ServiceLineStatusInformation",
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "ServiceLineItemIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"FJ")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new DTP(){
OwningLoopCollection = this,
SegmentDefinitionName = "ServiceLineDate",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"472")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Required
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
SegmentDefinitionName = "DependentLevel",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"23")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
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
SegmentDefinitionName = "DependentName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"QC")},
SyntaxRules = new List<string>(){ "P0809","C1110","C1203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
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
SegmentDefinitionName = "ClaimStatusTrackingNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"2")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new STC(){
OwningLoopCollection = this,
SegmentDefinitionName = "ClaimLevelStatusInformation",
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "PayerClaimControlNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"1K")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "InstitutionalBillTypeIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"BLT")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "PatientControlNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"EJ")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "PharmacyPrescriptionNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"XZ")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "VoucherIdentifier",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"VV")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "ClaimIdentificationNumberForClearinghousesAnd",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"D9")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new DTP(){
OwningLoopCollection = this,
SegmentDefinitionName = "ClaimServiceDate",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"472")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
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
SegmentDefinitionName = "ServiceLineInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"AD","ER","HC","HP","IV","N4","NU","WK")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new STC(){
OwningLoopCollection = this,
SegmentDefinitionName = "ServiceLineStatusInformation",
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "ServiceLineItemIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"FJ")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new DTP(){
OwningLoopCollection = this,
SegmentDefinitionName = "ServiceLineDate",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"472")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new SE(){
OwningLoopCollection = this,
SegmentDefinitionName = "TransactionSetTrailer",
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
}
}
