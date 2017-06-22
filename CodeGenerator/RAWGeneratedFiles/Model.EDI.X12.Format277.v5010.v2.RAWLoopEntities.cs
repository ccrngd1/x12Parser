	public IsaCollection Interchangecontrolheader {get;set;}
	public IeaCollection Interchangecontroltrailer {get;set;}
public Loop(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
Interchangecontrolheader = new IsaCollection(this, nameof(Interchangecontrolheader));
SegmentCollections.Add(Interchangecontrolheader);
Interchangecontroltrailer = new IeaCollection(this, nameof(Interchangecontroltrailer));
SegmentCollections.Add(Interchangecontroltrailer);
 
}
}
public partial class Loop01GE : LoopEntity{
	public GsCollection Functionalgroupheader {get;set;}
	public GeCollection Functionalgrouptrailer {get;set;}
	public Collection Transactionsetheader {get;set;}
	public StCollection Empty {get;set;}
	public TableCollection Empty {get;set;}
public Loop01GE(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
Functionalgroupheader = new GsCollection(this, nameof(Functionalgroupheader));
SegmentCollections.Add(Functionalgroupheader);
Functionalgrouptrailer = new GeCollection(this, nameof(Functionalgrouptrailer));
SegmentCollections.Add(Functionalgrouptrailer);
Transactionsetheader = new Collection(this, nameof(Transactionsetheader));
SegmentCollections.Add(Transactionsetheader);
Empty = new StCollection(this, nameof(Empty));
SegmentCollections.Add(Empty);
Empty = new TableCollection(this, nameof(Empty));
SegmentCollections.Add(Empty);
 
}
}
public partial class Loop2000A : LoopEntity{
	public HlCollection Informationsourcelevel {get;set;}
public Loop2000A(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
Informationsourcelevel = new HlCollection(this, nameof(Informationsourcelevel));
SegmentCollections.Add(Informationsourcelevel);
 
}
}
public partial class Loop2100A : LoopEntity{
	public Nm1Collection Payername {get;set;}
	public PerCollection Payercontactinformation {get;set;}
public Loop2100A(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
Payername = new Nm1Collection(this, nameof(Payername));
SegmentCollections.Add(Payername);
Payercontactinformation = new PerCollection(this, nameof(Payercontactinformation));
SegmentCollections.Add(Payercontactinformation);
 
}
}
public partial class Loop2000B : LoopEntity{
	public HlCollection Informationreceiverlevel {get;set;}
public Loop2000B(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
Informationreceiverlevel = new HlCollection(this, nameof(Informationreceiverlevel));
SegmentCollections.Add(Informationreceiverlevel);
 
}
}
public partial class Loop2100B : LoopEntity{
	public Nm1Collection Informationreceivername {get;set;}
public Loop2100B(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
Informationreceivername = new Nm1Collection(this, nameof(Informationreceivername));
SegmentCollections.Add(Informationreceivername);
 
}
}
public partial class Loop2200B : LoopEntity{
	public TrnCollection Informationreceivertraceidentifier {get;set;}
	public StcCollection Informationreceiverstatusinformation {get;set;}
	public Loop2000CCollecction Serviceproviderlevel {get;set;}
	public Loop2100CCollecction Providername {get;set;}
	public Loop2200CCollecction Providerofservicetraceidentifier {get;set;}
public Loop2200B(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
Informationreceivertraceidentifier = new TrnCollection(this, nameof(Informationreceivertraceidentifier));
SegmentCollections.Add(Informationreceivertraceidentifier);
Informationreceiverstatusinformation = new StcCollection(this, nameof(Informationreceiverstatusinformation));
SegmentCollections.Add(Informationreceiverstatusinformation);
 
Serviceproviderlevel = new Loop2000CCollection("Loop2000C", nameof(Serviceproviderlevel), OwningDoc, parent, parent);
ChildLoopCollections.Add(Serviceproviderlevel)
Providername = new Loop2100CCollection("Loop2100C", nameof(Providername), OwningDoc, parent, parent);
ChildLoopCollections.Add(Providername)
Providerofservicetraceidentifier = new Loop2200CCollection("Loop2200C", nameof(Providerofservicetraceidentifier), OwningDoc, parent, parent);
ChildLoopCollections.Add(Providerofservicetraceidentifier)
}
}
public partial class Loop2000C : LoopEntity{
	public HlCollection Serviceproviderlevel {get;set;}
public Loop2000C(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
Serviceproviderlevel = new HlCollection(this, nameof(Serviceproviderlevel));
SegmentCollections.Add(Serviceproviderlevel);
 
}
}
public partial class Loop2100C : LoopEntity{
	public Nm1Collection Providername {get;set;}
public Loop2100C(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
Providername = new Nm1Collection(this, nameof(Providername));
SegmentCollections.Add(Providername);
 
}
}
public partial class Loop2200C : LoopEntity{
	public TrnCollection Providerofservicetraceidentifier {get;set;}
	public StcCollection Providerstatusinformation {get;set;}
	public Loop2000DCollecction Subscriberlevel {get;set;}
	public Loop2100DCollecction Subscribername {get;set;}
public Loop2200C(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
Providerofservicetraceidentifier = new TrnCollection(this, nameof(Providerofservicetraceidentifier));
SegmentCollections.Add(Providerofservicetraceidentifier);
Providerstatusinformation = new StcCollection(this, nameof(Providerstatusinformation));
SegmentCollections.Add(Providerstatusinformation);
 
Subscriberlevel = new Loop2000DCollection("Loop2000D", nameof(Subscriberlevel), OwningDoc, parent, parent);
ChildLoopCollections.Add(Subscriberlevel)
Subscribername = new Loop2100DCollection("Loop2100D", nameof(Subscribername), OwningDoc, parent, parent);
ChildLoopCollections.Add(Subscribername)
}
}
public partial class Loop2000D : LoopEntity{
	public HlCollection Subscriberlevel {get;set;}
public Loop2000D(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
Subscriberlevel = new HlCollection(this, nameof(Subscriberlevel));
SegmentCollections.Add(Subscriberlevel);
 
}
}
public partial class Loop2100D : LoopEntity{
	public Nm1Collection Subscribername {get;set;}
	public Loop2200DCollecction Claimstatustrackingnumber {get;set;}
public Loop2100D(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
Subscribername = new Nm1Collection(this, nameof(Subscribername));
SegmentCollections.Add(Subscribername);
 
Claimstatustrackingnumber = new Loop2200DCollection("Loop2200D", nameof(Claimstatustrackingnumber), OwningDoc, parent, parent);
ChildLoopCollections.Add(Claimstatustrackingnumber)
}
}
public partial class Loop2200D : LoopEntity{
	public TrnCollection Claimstatustrackingnumber {get;set;}
	public StcCollection Claimlevelstatusinformation {get;set;}
	public RefCollection Payerclaimcontrolnumber {get;set;}
	public RefCollection Institutionalbilltypeidentification {get;set;}
	public RefCollection Patientcontrolnumber {get;set;}
	public RefCollection Pharmacyprescriptionnumber {get;set;}
	public RefCollection Voucheridentifier {get;set;}
	public RefCollection Claimidentificationnumberforclearinghousesand {get;set;}
	public DtpCollection Claimservicedate {get;set;}
	public Loop2220DCollecction Servicelineinformation {get;set;}
	public Loop2000ECollecction Dependentlevel {get;set;}
	public Loop2100ECollecction Dependentname {get;set;}
	public Loop2200ECollecction Claimstatustrackingnumber {get;set;}
public Loop2200D(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
Claimstatustrackingnumber = new TrnCollection(this, nameof(Claimstatustrackingnumber));
SegmentCollections.Add(Claimstatustrackingnumber);
Claimlevelstatusinformation = new StcCollection(this, nameof(Claimlevelstatusinformation));
SegmentCollections.Add(Claimlevelstatusinformation);
Payerclaimcontrolnumber = new RefCollection(this, nameof(Payerclaimcontrolnumber));
SegmentCollections.Add(Payerclaimcontrolnumber);
Institutionalbilltypeidentification = new RefCollection(this, nameof(Institutionalbilltypeidentification));
SegmentCollections.Add(Institutionalbilltypeidentification);
Patientcontrolnumber = new RefCollection(this, nameof(Patientcontrolnumber));
SegmentCollections.Add(Patientcontrolnumber);
Pharmacyprescriptionnumber = new RefCollection(this, nameof(Pharmacyprescriptionnumber));
SegmentCollections.Add(Pharmacyprescriptionnumber);
Voucheridentifier = new RefCollection(this, nameof(Voucheridentifier));
SegmentCollections.Add(Voucheridentifier);
Claimidentificationnumberforclearinghousesand = new RefCollection(this, nameof(Claimidentificationnumberforclearinghousesand));
SegmentCollections.Add(Claimidentificationnumberforclearinghousesand);
Claimservicedate = new DtpCollection(this, nameof(Claimservicedate));
SegmentCollections.Add(Claimservicedate);
 
Servicelineinformation = new Loop2220DCollection("Loop2220D", nameof(Servicelineinformation), OwningDoc, parent, parent);
ChildLoopCollections.Add(Servicelineinformation)
Dependentlevel = new Loop2000ECollection("Loop2000E", nameof(Dependentlevel), OwningDoc, parent, parent);
ChildLoopCollections.Add(Dependentlevel)
Dependentname = new Loop2100ECollection("Loop2100E", nameof(Dependentname), OwningDoc, parent, parent);
ChildLoopCollections.Add(Dependentname)
Claimstatustrackingnumber = new Loop2200ECollection("Loop2200E", nameof(Claimstatustrackingnumber), OwningDoc, parent, parent);
ChildLoopCollections.Add(Claimstatustrackingnumber)
}
}
public partial class Loop2220D : LoopEntity{
	public SvcCollection Servicelineinformation {get;set;}
	public StcCollection Servicelinestatusinformation {get;set;}
	public RefCollection Servicelineitemidentification {get;set;}
	public DtpCollection Servicelinedate {get;set;}
public Loop2220D(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
Servicelineinformation = new SvcCollection(this, nameof(Servicelineinformation));
SegmentCollections.Add(Servicelineinformation);
Servicelinestatusinformation = new StcCollection(this, nameof(Servicelinestatusinformation));
SegmentCollections.Add(Servicelinestatusinformation);
Servicelineitemidentification = new RefCollection(this, nameof(Servicelineitemidentification));
SegmentCollections.Add(Servicelineitemidentification);
Servicelinedate = new DtpCollection(this, nameof(Servicelinedate));
SegmentCollections.Add(Servicelinedate);
 
}
}
public partial class Loop2000E : LoopEntity{
	public HlCollection Dependentlevel {get;set;}
public Loop2000E(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
Dependentlevel = new HlCollection(this, nameof(Dependentlevel));
SegmentCollections.Add(Dependentlevel);
 
}
}
public partial class Loop2100E : LoopEntity{
	public Nm1Collection Dependentname {get;set;}
public Loop2100E(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
Dependentname = new Nm1Collection(this, nameof(Dependentname));
SegmentCollections.Add(Dependentname);
 
}
}
public partial class Loop2200E : LoopEntity{
	public TrnCollection Claimstatustrackingnumber {get;set;}
	public StcCollection Claimlevelstatusinformation {get;set;}
	public RefCollection Payerclaimcontrolnumber {get;set;}
	public RefCollection Institutionalbilltypeidentification {get;set;}
	public RefCollection Patientcontrolnumber {get;set;}
	public RefCollection Pharmacyprescriptionnumber {get;set;}
	public RefCollection Voucheridentifier {get;set;}
	public RefCollection Claimidentificationnumberforclearinghousesand {get;set;}
	public DtpCollection Claimservicedate {get;set;}
	public Loop2220ECollecction Servicelineinformation {get;set;}
public Loop2200E(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
Claimstatustrackingnumber = new TrnCollection(this, nameof(Claimstatustrackingnumber));
SegmentCollections.Add(Claimstatustrackingnumber);
Claimlevelstatusinformation = new StcCollection(this, nameof(Claimlevelstatusinformation));
SegmentCollections.Add(Claimlevelstatusinformation);
Payerclaimcontrolnumber = new RefCollection(this, nameof(Payerclaimcontrolnumber));
SegmentCollections.Add(Payerclaimcontrolnumber);
Institutionalbilltypeidentification = new RefCollection(this, nameof(Institutionalbilltypeidentification));
SegmentCollections.Add(Institutionalbilltypeidentification);
Patientcontrolnumber = new RefCollection(this, nameof(Patientcontrolnumber));
SegmentCollections.Add(Patientcontrolnumber);
Pharmacyprescriptionnumber = new RefCollection(this, nameof(Pharmacyprescriptionnumber));
SegmentCollections.Add(Pharmacyprescriptionnumber);
Voucheridentifier = new RefCollection(this, nameof(Voucheridentifier));
SegmentCollections.Add(Voucheridentifier);
Claimidentificationnumberforclearinghousesand = new RefCollection(this, nameof(Claimidentificationnumberforclearinghousesand));
SegmentCollections.Add(Claimidentificationnumberforclearinghousesand);
Claimservicedate = new DtpCollection(this, nameof(Claimservicedate));
SegmentCollections.Add(Claimservicedate);
 
Servicelineinformation = new Loop2220ECollection("Loop2220E", nameof(Servicelineinformation), OwningDoc, parent, parent);
ChildLoopCollections.Add(Servicelineinformation)
}
}
public partial class Loop2220E : LoopEntity{
	public SvcCollection Servicelineinformation {get;set;}
	public StcCollection Servicelinestatusinformation {get;set;}
	public RefCollection Servicelineitemidentification {get;set;}
	public DtpCollection Servicelinedate {get;set;}
	public SeCollection Transactionsettrailer {get;set;}
public Loop2220E(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent){
Servicelineinformation = new SvcCollection(this, nameof(Servicelineinformation));
SegmentCollections.Add(Servicelineinformation);
Servicelinestatusinformation = new StcCollection(this, nameof(Servicelinestatusinformation));
SegmentCollections.Add(Servicelinestatusinformation);
Servicelineitemidentification = new RefCollection(this, nameof(Servicelineitemidentification));
SegmentCollections.Add(Servicelineitemidentification);
Servicelinedate = new DtpCollection(this, nameof(Servicelinedate));
SegmentCollections.Add(Servicelinedate);
Transactionsettrailer = new SeCollection(this, nameof(Transactionsettrailer));
SegmentCollections.Add(Transactionsettrailer);
 
}
}
