
public partial class Loop1000ACollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "SubmitterName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"41")},
SyntaxRules = new List<string>(){ "P0809","C1110","C1203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new PER(){
OwningLoopCollection = this,
SegmentDefinitionName = "SubmitterEdiContactInformation",
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
SegmentUsage = SegmentUsageTypeNames.Required
});
}
}
public partial class Loop1000BCollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "ReceiverName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"40")},
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
}
}
public partial class Loop2000ACollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 999;
SegmentDefinitions.Add(new HL(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "BillingProviderHierarchicalLevel",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"20","H")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new PRV(){
OwningLoopCollection = this,
SegmentDefinitionName = "BillingProviderSpecialtyInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"BI")},
SyntaxRules = new List<string>(){ "P0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new CUR(){
OwningLoopCollection = this,
SegmentDefinitionName = "ForeignCurrencyInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"85")},
SyntaxRules = new List<string>(){ "C0807","C0907","L101112","C1110","C1210","L131415","C1413","C1513","L161718","C1716","C1816","L192021","C2019","C2119" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
}
}
public partial class Loop2010AACollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "BillingProviderName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"85")},
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
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new N3(){
OwningLoopCollection = this,
SegmentDefinitionName = "BillingProviderAddress",
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new N4(){
OwningLoopCollection = this,
SegmentDefinitionName = "billingProviderCity,State,ZipCode"",
SyntaxRules = new List<string>(){ "E0207","C0605","C0704" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "BillingProviderTaxIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"EI")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new PER(){
OwningLoopCollection = this,
SegmentDefinitionName = "BillingProviderContactInformation",
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
public partial class Loop2010ABCollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "Pay-toAddressName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"87","NM")},
SyntaxRules = new List<string>(){ "P0809","C1110","C1203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new N3(){
OwningLoopCollection = this,
SegmentDefinitionName = "Pay-toAddress
Address",
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new N4(){
OwningLoopCollection = this,
SegmentDefinitionName = "pay-toAddressCity,State,ZipCode"",
SyntaxRules = new List<string>(){ "E0207","C0605","C0704" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
}
}
public partial class Loop2010ACCollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "Pay-toPlanName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"PE")},
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
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new N3(){
OwningLoopCollection = this,
SegmentDefinitionName = "Pay-toPlanAddress",
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new N4(){
OwningLoopCollection = this,
SegmentDefinitionName = "pay-toPlanCity,State,ZipCode"",
SyntaxRules = new List<string>(){ "E0207","C0605","C0704" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "Pay-toPlanSecondaryIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"2U","FY","NF")},
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
SegmentDefinitionName = "Pay-toPlanTaxIdentificationNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"EI")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
}
}
public partial class Loop2000BCollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 999;
SegmentDefinitions.Add(new HL(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "SubscriberHierarchicalLevel",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"22")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new SBR(){
OwningLoopCollection = this,
SegmentDefinitionName = "SubscriberInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"A","B","C","D","E","F","G","H","P","S","T","U")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
}
}
public partial class Loop2010BACollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "SubscriberName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"IL","NM")},
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
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new N3(){
OwningLoopCollection = this,
SegmentDefinitionName = "SubscriberAddress",
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new N4(){
OwningLoopCollection = this,
SegmentDefinitionName = "subscriberCity,State,ZipCode"",
SyntaxRules = new List<string>(){ "E0207","C0605","C0704" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new DMG(){
OwningLoopCollection = this,
SegmentDefinitionName = "SubscriberDemographicInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"D8")},
SyntaxRules = new List<string>(){ "P0102","P1011","C1105" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "SubscriberSecondaryIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"SY")},
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
SegmentDefinitionName = "PropertyAndCasualtyClaimNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"Y4")},
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
}
}
public partial class Loop2010BBCollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "PayerName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"PR","NM")},
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
SegmentDefinitions.Add(new N3(){
OwningLoopCollection = this,
SegmentDefinitionName = "PayerAddress",
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new N4(){
OwningLoopCollection = this,
SegmentDefinitionName = "payerCity,State,ZipCode"",
SyntaxRules = new List<string>(){ "E0207","C0605","C0704" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "PayerSecondaryIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"2U","EI","FY","NF")},
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
SegmentDefinitionName = "BillingProviderSecondaryIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"G2","LU")},
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
}
}
public partial class Loop2000CCollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 999;
SegmentDefinitions.Add(new HL(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "PatientHierarchicalLevel",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"23")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new PAT(){
OwningLoopCollection = this,
SegmentDefinitionName = "PatientInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"01","19","20","21","39","40","53","G8")},
SyntaxRules = new List<string>(){ "P0506","P0708" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
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
public partial class Loop2010CACollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "PatientName",
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
SegmentDefinitions.Add(new N3(){
OwningLoopCollection = this,
SegmentDefinitionName = "PatientAddress",
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new N4(){
OwningLoopCollection = this,
SegmentDefinitionName = "patientCity,State,ZipCode"",
SyntaxRules = new List<string>(){ "E0207","C0605","C0704" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new DMG(){
OwningLoopCollection = this,
SegmentDefinitionName = "PatientDemographicInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"D8")},
SyntaxRules = new List<string>(){ "P0102","P1011","C1105" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "PropertyAndCasualtyClaimNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"Y4")},
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
SegmentDefinitionName = "PropertyAndCasualtyPatientIdentifier",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"1W","SY")},
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
}
}
public partial class Loop2300Collection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 999;
SegmentDefinitions.Add(new CLM(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "ClaimInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"A")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new DTP(){
OwningLoopCollection = this,
SegmentDefinitionName = "DischargeHour",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"096")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new DTP(){
OwningLoopCollection = this,
SegmentDefinitionName = "StatementDates",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"434")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new DTP(){
OwningLoopCollection = this,
SegmentDefinitionName = "AdmissionDate/hour",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"435")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new DTP(){
OwningLoopCollection = this,
SegmentDefinitionName = "Date
RepricerReceivedDate",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"050")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new CL1(){
OwningLoopCollection = this,
SegmentDefinitionName = "InstitutionalClaimCode",
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new PWK(){
OwningLoopCollection = this,
SegmentDefinitionName = "ClaimSupplementalInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"03","04","05","06","07","08","09","10","11","13","15","21","A3","A4","AM","AS","B2","B3","B4","BR","BS","BT","CB","CK","CT","D2","DA","DB","DG","DJ","DS","EB","HC","HR","I5","IR","LA","M1","MT","NN","OB","OC","OD","OE","OX","OZ","P4","P5","PE","PN","PO","PQ","PY","PZ","RB","RR","RT","RX","SG","V5","XP")},
SyntaxRules = new List<string>(){ "P0506" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new CN1(){
OwningLoopCollection = this,
SegmentDefinitionName = "ContractInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"01","02","03","04","05","06","09")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new AMT(){
OwningLoopCollection = this,
SegmentDefinitionName = "PatientEstimatedAmountDue",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"F3")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "ServiceAuthorizationExceptionCode",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"4N")},
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
SegmentDefinitionName = "ReferralNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"9F")},
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
SegmentDefinitionName = "PriorAuthorization",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"G1","RE")},
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
SegmentDefinitionName = "PayerClaimControlNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"F8")},
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
SegmentDefinitionName = "RepricedClaimNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"9A")},
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
SegmentDefinitionName = "AdjustedRepricedClaimNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"9C")},
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
SegmentDefinitionName = "InvestigationalDeviceExemptionNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"LX")},
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
SegmentDefinitionName = "ClaimIdentifierForTransmissionIntermediaries",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"D9","RE")},
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
SegmentDefinitionName = "AutoAccidentState",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"LU")},
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
SegmentDefinitionName = "MedicalRecordNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"EA")},
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
SegmentDefinitionName = "DemonstrationProjectIdentifier",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"P4")},
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
SegmentDefinitionName = "PeerReviewOrganizationpro)ApprovalNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"G4")},
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
SegmentDefinitions.Add(new K3(){
OwningLoopCollection = this,
SegmentDefinitionName = "FileInformation",
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new NTE(){
OwningLoopCollection = this,
SegmentDefinitionName = "ClaimNote",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"ALG","DCP","DGN","DME","NT","MED","NTR","ODT","RHB","RLH","RNH","SET","SFM","SPT","UPI")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new NTE(){
OwningLoopCollection = this,
SegmentDefinitionName = "BillingNote",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"ADD")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new CRC(){
OwningLoopCollection = this,
SegmentDefinitionName = "EpsdtReferral",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"ZZ")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new HI(){
OwningLoopCollection = this,
SegmentDefinitionName = "PrincipalDiagnosis",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"ABK","BK")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new HI(){
OwningLoopCollection = this,
SegmentDefinitionName = "AdmittingDiagnosis",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"ABJ","BJ")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new HI(){
OwningLoopCollection = this,
SegmentDefinitionName = "Patient�sReasonForVisit",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"APR","PR")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
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
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new HI(){
OwningLoopCollection = this,
SegmentDefinitionName = "ExternalCauseOfInjury",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"ABN","BN")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new HI(){
OwningLoopCollection = this,
SegmentDefinitionName = "DiagnosisRelatedGroupdrg)Information",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"DR","HI")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new HI(){
OwningLoopCollection = this,
SegmentDefinitionName = "OtherDiagnosisInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"ABF","BF")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new HI(){
OwningLoopCollection = this,
SegmentDefinitionName = "PrincipalProcedureInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"BBR","BR","CAH")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new HI(){
OwningLoopCollection = this,
SegmentDefinitionName = "OtherProcedureInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"BBQ","BQ")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new HI(){
OwningLoopCollection = this,
SegmentDefinitionName = "OccurrenceSpanInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"BI")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new HI(){
OwningLoopCollection = this,
SegmentDefinitionName = "OccurrenceInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"BH")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new HI(){
OwningLoopCollection = this,
SegmentDefinitionName = "ValueInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"BE")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new HI(){
OwningLoopCollection = this,
SegmentDefinitionName = "ConditionInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"BG")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
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
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
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
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
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
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new HI(){
OwningLoopCollection = this,
SegmentDefinitionName = "TreatmentCodeInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"TC","HI")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
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
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
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
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
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
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new HCP(){
OwningLoopCollection = this,
SegmentDefinitionName = "ClaimPricing/repricingInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"00","01","02","03","04","05","06","07","08","09","10","11","12","13","14")},
SyntaxRules = new List<string>(){ "R0113","P0910","P1112" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
}
}
public partial class Loop2310ACollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "AttendingProviderName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"71")},
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
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new PRV(){
OwningLoopCollection = this,
SegmentDefinitionName = "AttendingProviderSpecialtyInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"AT")},
SyntaxRules = new List<string>(){ "P0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "AttendingProviderSecondaryIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"0B","1G","G2","LU","RE")},
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
}
}
public partial class Loop2310BCollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "OperatingPhysicianName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"72")},
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
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "OperatingPhysicianSecondaryIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"0B","1G","G2","LU")},
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
}
}
public partial class Loop2310CCollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "OtherOperatingPhysicianName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"ZZ")},
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
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "OtherOperatingPhysicianSecondaryIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"0B","1G","G2","LU","RE")},
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
}
}
public partial class Loop2310DCollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "RenderingProviderName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"82")},
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
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "RenderingProviderSecondaryIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"0B","1G","G2","LU")},
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
}
}
public partial class Loop2310ECollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "ServiceFacilityLocationName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"77")},
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
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new N3(){
OwningLoopCollection = this,
SegmentDefinitionName = "ServiceFacilityLocationAddress",
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new N4(){
OwningLoopCollection = this,
SegmentDefinitionName = "serviceFacilityLocationCity,State,ZipCode"",
SyntaxRules = new List<string>(){ "E0207","C0605","C0704" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "ServiceFacilityLocationSecondaryIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"0B","G2","LU")},
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
}
}
public partial class Loop2310FCollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "ReferringProviderName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"DN")},
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
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "ReferringProviderSecondaryIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"0B","1G","RE","G2")},
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
}
}
public partial class Loop2320Collection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 999;
SegmentDefinitions.Add(new SBR(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "OtherSubscriberInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"A","B","C","D","E","F","G","H","P","S","T","U")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new CAS(){
OwningLoopCollection = this,
SegmentDefinitionName = "ClaimLevelAdjustments",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"CO","CR","OA","PI","PR")},
SyntaxRules = new List<string>(){ "L050607","C0605","C0705","L080910","C0908","C1008","L111213","C1211","C1311","L141516","C1514","C1614","L171819","C1817","C1917" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new AMT(){
OwningLoopCollection = this,
SegmentDefinitionName = "CoordinationOfBenefitscob)PayerPaidAmount",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"D")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new AMT(){
OwningLoopCollection = this,
SegmentDefinitionName = "RemainingPatientLiability",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"EAF")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new AMT(){
OwningLoopCollection = this,
SegmentDefinitionName = "CoordinationOfBenefitscob)TotalNon-covered",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"A8")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new OI(){
OwningLoopCollection = this,
SegmentDefinitionName = "OtherInsuranceCoverageInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"N","W","Y")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new MIA(){
OwningLoopCollection = this,
SegmentDefinitionName = "InpatientAdjudicationInformation",
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new MOA(){
OwningLoopCollection = this,
SegmentDefinitionName = "OutpatientAdjudicationInformation",
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
}
}
public partial class Loop2330ACollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "OtherSubscriberName",
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
SegmentDefinitions.Add(new N3(){
OwningLoopCollection = this,
SegmentDefinitionName = "OtherSubscriberAddress",
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new N4(){
OwningLoopCollection = this,
SegmentDefinitionName = "otherSubscriberCity,State,ZipCode"",
SyntaxRules = new List<string>(){ "E0207","C0605","C0704" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "OtherSubscriberSecondaryIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"SY")},
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
}
}
public partial class Loop2330BCollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "OtherPayerName",
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
SegmentDefinitions.Add(new N3(){
OwningLoopCollection = this,
SegmentDefinitionName = "OtherPayerAddress",
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new N4(){
OwningLoopCollection = this,
SegmentDefinitionName = "otherPayerCity,State,ZipCode"",
SyntaxRules = new List<string>(){ "E0207","C0605","C0704" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new DTP(){
OwningLoopCollection = this,
SegmentDefinitionName = "ClaimCheckOrRemittanceDate",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"573")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "OtherPayerSecondaryIdentifier",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"2U","EI","FY","NF","RE")},
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
SegmentDefinitionName = "OtherPayerPriorAuthorizationNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"G1")},
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
SegmentDefinitionName = "OtherPayerReferralNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"9F")},
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
SegmentDefinitionName = "OtherPayerClaimAdjustmentIndicator",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"T4")},
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
SegmentDefinitionName = "OtherPayerClaimControlNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"F8")},
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
}
}
public partial class Loop2330CCollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "OtherPayerAttendingProvider",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"71")},
SyntaxRules = new List<string>(){ "P0809","C1110","C1203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "OtherPayerAttendingProviderSecondaryIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"0B","1G","G2","LU","RE")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
}
}
public partial class Loop2330DCollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "OtherPayerOperatingPhysician",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"72")},
SyntaxRules = new List<string>(){ "P0809","C1110","C1203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "OtherPayerOperatingPhysicianSecondaryIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"0B","1G","G2","LU","RE")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
}
}
public partial class Loop2330ECollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "OtherPayerOtherOperatingPhysician",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"ZZ")},
SyntaxRules = new List<string>(){ "P0809","C1110","C1203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
}
}
public partial class Loop2330FCollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "OtherPayerServiceFacilityLocation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"77")},
SyntaxRules = new List<string>(){ "P0809","C1110","C1203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "OtherPayerServiceFacilityLocationSecondary",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"0B","G2","LU")},
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
}
}
public partial class Loop2330GCollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "OtherPayerRenderingProviderName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"82")},
SyntaxRules = new List<string>(){ "P0809","C1110","C1203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "OtherPayerRenderingProviderSecondaryIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"0B","1G","G2","LU","RE")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
}
}
public partial class Loop2330HCollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "OtherPayerReferringProvider",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"DN")},
SyntaxRules = new List<string>(){ "P0809","C1110","C1203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "OtherPayerReferringProviderSecondaryIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"0B","1G","G2","RE")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
}
}
public partial class Loop2330ICollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "OtherPayerBillingProvider",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"85")},
SyntaxRules = new List<string>(){ "P0809","C1110","C1203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "OtherPayerBillingProviderSecondaryIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"G2","LU")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
}
}
public partial class Loop2400Collection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 999;
SegmentDefinitions.Add(new LX(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "ServiceLineNumber",
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new SV2(){
OwningLoopCollection = this,
SegmentDefinitionName = "InstitutionalServiceLine",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"ER","HC","HP","IV","WK")},
SyntaxRules = new List<string>(){ "R0102","P0405" },
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
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new PWK(){
OwningLoopCollection = this,
SegmentDefinitionName = "LineSupplementalInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"03","04","05","06","07","08","09","10","11","13","15","21","A3","A4","AM","AS","B2","B3","B4","BR","BS","BT","CB","CK","CT","D2","DA","DB","DG","DJ","DS","EB","HC","HR","I5","P","IR","LA","M1","MT","NN","OB","OC","OD","OE","OX","OZ","P4","P5","PE","PN","PO","PQ","PY","PZ","RB","RR","RT","RX","SG","V5","XP")},
SyntaxRules = new List<string>(){ "P0506" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new DTP(){
OwningLoopCollection = this,
SegmentDefinitionName = "Date
ServiceDate",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"472")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "LineItemControlNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"6R")},
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
SegmentDefinitionName = "RepricedLineItemReferenceNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"9B")},
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
SegmentDefinitionName = "AdjustedRepricedLineItemReferenceNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"9D")},
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
SegmentDefinitions.Add(new AMT(){
OwningLoopCollection = this,
SegmentDefinitionName = "ServiceTaxAmount",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"GT")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new AMT(){
OwningLoopCollection = this,
SegmentDefinitionName = "FacilityTaxAmount",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"N8")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new NTE(){
OwningLoopCollection = this,
SegmentDefinitionName = "ThirdPartyOrganizationNotes",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"TPO")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new HCP(){
OwningLoopCollection = this,
SegmentDefinitionName = "LinePricing/repricingInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"00","01","02","03","04","05","06","07","08","09","10","11","12","13","14")},
SyntaxRules = new List<string>(){ "R0113","P0910","P1112" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
}
}
public partial class Loop2410Collection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new LIN(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "DrugIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"N4")},
SyntaxRules = new List<string>(){ "P0405","P0607","P0809","P1011","P1213","P1415","P1617","P1819","P2021","P2223","P2425","P2627","P2829","P3031" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new CTP(){
OwningLoopCollection = this,
SegmentDefinitionName = "DrugQuantity",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"F2","GR","ME","ML","UN")},
SyntaxRules = new List<string>(){ "P0405","C0607","C0902","C1002","C1103" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "PrescriptionOrCompoundDrugAssociationNumber",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"VY","XZ","RE")},
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
}
}
public partial class Loop2420ACollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "OperatingPhysicianName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"72")},
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
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "OperatingPhysicianSecondaryIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"0B","1G","G2","LU")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
}
}
public partial class Loop2420BCollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "OtherOperatingPhysicianName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"ZZ")},
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
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "OtherOperatingPhysicianSecondaryIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"0B","1G","RE","G2","LU")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
}
}
public partial class Loop2420CCollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "RenderingProviderName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"82")},
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
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "RenderingProviderSecondaryIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"0B","1G","G2","LU")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
}
}
public partial class Loop2420DCollection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 1;
SegmentDefinitions.Add(new NM1(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "ReferringProviderName",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"DN")},
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
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new REF(){
OwningLoopCollection = this,
SegmentDefinitionName = "ReferringProviderSecondaryIdentification",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"0B","1G","RE","G2")},
SyntaxRules = new List<string>(){ "R0203" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
}
}
public partial class Loop2430Collection
{
internal override void SetUpDefinition(){ 
SetUpChildDefinitions=true;
RepitionLimit = 999;
SegmentDefinitions.Add(new SVD(){
OwningLoopCollection = this,
IsLoopStarter=true,
SegmentDefinitionName = "LineAdjudicationInformation",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"ER","HC","HP","IV","WK")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.Optional,
FieldUsageTypeNames.UnUsed,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new CAS(){
OwningLoopCollection = this,
SegmentDefinitionName = "LineAdjustment",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"CO","CR","OA","PI","PR")},
SyntaxRules = new List<string>(){ "L050607","C0605","C0705","L080910","C0908","C1008","L111213","C1211","C1311","L141516","C1514","C1614","L171819","C1817","C1917" },
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Optional
});
SegmentDefinitions.Add(new DTP(){
OwningLoopCollection = this,
SegmentDefinitionName = "LineCheckOrRemittanceDate",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"573")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
},
SegmentUsage = SegmentUsageTypeNames.Required
});
SegmentDefinitions.Add(new AMT(){
OwningLoopCollection = this,
SegmentDefinitionName = "RemainingPatientLiability",
SegmentQualifierValues = new List<SegmentQualifiers>(){ new SegmentQualifiers(1,"EAF")},
FieldUsage = new List<FieldUsageTypeNames>(){
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.Mandatory,
FieldUsageTypeNames.UnUsed,
},
SegmentUsage = SegmentUsageTypeNames.Optional
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
