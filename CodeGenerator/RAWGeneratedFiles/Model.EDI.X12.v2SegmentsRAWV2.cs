public partial class AMT : BaseStdSegment{
public string AmountQualifierCode  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string MonetaryAmount  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string CreditDebitFlagCode  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public AMT():base(){}
public AMT(string[] splitX12Line) : this(splitX12Line.ToList()){}
public AMT(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class BHT : BaseStdSegment{
public string StructureCode {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string TransactionSetPurposeCode {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string RefId {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string Date {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string Time {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string TransactionTypeCode {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public BHT():base(){}
public BHT(string[] splitX12Line) : this(splitX12Line.ToList()){}
public BHT(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class CAS : BaseStdSegment{
public string AdjustmentGroupCode1  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string ReasonCode1  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string Amount1  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string Quantity1  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string AdjustmentGroupCode2  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string ReasonCode2  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public string Amount2  {get {return GetFieldValue(7);} set {SetFieldValue(7, value);} }
public string Quantity2  {get {return GetFieldValue(8);} set {SetFieldValue(8, value);} }
public string AdjustmentGroupCode3  {get {return GetFieldValue(9);} set {SetFieldValue(9, value);} }
public string ReasonCode3  {get {return GetFieldValue(10);} set {SetFieldValue(10, value);} }
public string Amount3  {get {return GetFieldValue(11);} set {SetFieldValue(11, value);} }
public string Quantity3  {get {return GetFieldValue(12);} set {SetFieldValue(12, value);} }
public string AdjustmentGroupCode4  {get {return GetFieldValue(13);} set {SetFieldValue(13, value);} }
public string ReasonCode4  {get {return GetFieldValue(14);} set {SetFieldValue(14, value);} }
public string Amount4  {get {return GetFieldValue(15);} set {SetFieldValue(15, value);} }
public string Quantity4  {get {return GetFieldValue(16);} set {SetFieldValue(16, value);} }
public string AdjustmentGroupCode5  {get {return GetFieldValue(17);} set {SetFieldValue(17, value);} }
public string ReasonCode5  {get {return GetFieldValue(18);} set {SetFieldValue(18, value);} }
public string Amount5  {get {return GetFieldValue(19);} set {SetFieldValue(19, value);} }
public string Quantity5  {get {return GetFieldValue(20);} set {SetFieldValue(20, value);} }
public string AdjustmentGroupCode6  {get {return GetFieldValue(21);} set {SetFieldValue(21, value);} }
public string ReasonCode6  {get {return GetFieldValue(22);} set {SetFieldValue(22, value);} }
public string Amount6  {get {return GetFieldValue(23);} set {SetFieldValue(23, value);} }
public CAS():base(){}
public CAS(string[] splitX12Line) : this(splitX12Line.ToList()){}
public CAS(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class CLM : BaseStdSegment{
public string ClaimSubmitterId  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string MonentaryAmount  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string ClaimFilintIndicatorCode  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string NonInstitutionalCllaimTypeCode  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string HealthCareLocation  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string SignatureOnFileYesNo  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public string ProviderAcceptAssignmentCode  {get {return GetFieldValue(7);} set {SetFieldValue(7, value);} }
public string AuthorizedYesNo  {get {return GetFieldValue(8);} set {SetFieldValue(8, value);} }
public string ReleaseOfnfomaitonCode  {get {return GetFieldValue(9);} set {SetFieldValue(9, value);} }
public string PatientSignatureSourceCode  {get {return GetFieldValue(10);} set {SetFieldValue(10, value);} }
public string RelatedCausesInfo  {get {return GetFieldValue(11);} set {SetFieldValue(11, value);} }
public string SpecialProgramCode  {get {return GetFieldValue(12);} set {SetFieldValue(12, value);} }
public string YesNo1  {get {return GetFieldValue(13);} set {SetFieldValue(13, value);} }
public string LevelOfServiceCode  {get {return GetFieldValue(14);} set {SetFieldValue(14, value);} }
public string YesNo2  {get {return GetFieldValue(15);} set {SetFieldValue(15, value);} }
public string ProviderAgreementCode  {get {return GetFieldValue(16);} set {SetFieldValue(16, value);} }
public string ClaimStatusCode  {get {return GetFieldValue(17);} set {SetFieldValue(17, value);} }
public string YesNo3  {get {return GetFieldValue(18);} set {SetFieldValue(18, value);} }
public string ClaimSubmissionReasonCode  {get {return GetFieldValue(19);} set {SetFieldValue(19, value);} }
public string DelayReasonCode  {get {return GetFieldValue(20);} set {SetFieldValue(20, value);} }
public CLM():base(){}
public CLM(string[] splitX12Line) : this(splitX12Line.ToList()){}
public CLM(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class CN1 : BaseStdSegment{
public string ContractTypeCode  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string MonetaryAmount  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string Percent  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string ReferenceIdentifier  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string TermsDiscountPercent  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string VersionId  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public CN1():base(){}
public CN1(string[] splitX12Line) : this(splitX12Line.ToList()){}
public CN1(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class CR1 : BaseStdSegment{
public string UnitOfMeasurement  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string Weight  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string TransportCode  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string TransportReason  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string DistanceUnit  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string Distance  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public string AddressLine1  {get {return GetFieldValue(7);} set {SetFieldValue(7, value);} }
public string AddressLine2  {get {return GetFieldValue(8);} set {SetFieldValue(8, value);} }
public string Description  {get {return GetFieldValue(9);} set {SetFieldValue(9, value);} }
public string Description2  {get {return GetFieldValue(10);} set {SetFieldValue(10, value);} }
public CR1():base(){}
public CR1(string[] splitX12Line) : this(splitX12Line.ToList()){}
public CR1(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class CR2 : BaseStdSegment{
public string Count  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string Quantity  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string LevelCode1  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string LevelCode2  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string Unit  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string Quantity2  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public string Quantity3  {get {return GetFieldValue(7);} set {SetFieldValue(7, value);} }
public string NatureOfCoditionCode  {get {return GetFieldValue(8);} set {SetFieldValue(8, value);} }
public string YesNo  {get {return GetFieldValue(9);} set {SetFieldValue(9, value);} }
public string Description1  {get {return GetFieldValue(10);} set {SetFieldValue(10, value);} }
public string Description2  {get {return GetFieldValue(11);} set {SetFieldValue(11, value);} }
public string YesNo2  {get {return GetFieldValue(12);} set {SetFieldValue(12, value);} }
public CR2():base(){}
public CR2(string[] splitX12Line) : this(splitX12Line.ToList()){}
public CR2(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class CR3 : BaseStdSegment{
public string TypeCode  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string Unit  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string Quantity  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string InsulidDependentCode  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string Description  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public CR3():base(){}
public CR3(string[] splitX12Line) : this(splitX12Line.ToList()){}
public CR3(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class CRC : BaseStdSegment{
public string CodeCategory  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string YesNo  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string ConditionIndicator1  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string ConditionIndicator2  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string ConditionIndicator3  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string ConditionIndicator4  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public string ConditionIndicator5  {get {return GetFieldValue(7);} set {SetFieldValue(7, value);} }
public CRC():base(){}
public CRC(string[] splitX12Line) : this(splitX12Line.ToList()){}
public CRC(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class CTP : BaseStdSegment{
public string ClassOfTradeCode  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string PriceIdCode  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string UnitPrice  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string Quantity  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string CompositeUnitOfMeasure  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public CTP():base(){}
public CTP(string[] splitX12Line) : this(splitX12Line.ToList()){}
public CTP(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class CUR : BaseStdSegment{
public string IdCode  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string CurrencyCode  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string ExchangeRate  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string EntitytIdCode  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string CurrencyCode2  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string CurrMarkgetExchgCode  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public string DateTimeQualifier  {get {return GetFieldValue(7);} set {SetFieldValue(7, value);} }
public string Date  {get {return GetFieldValue(8);} set {SetFieldValue(8, value);} }
public string Time  {get {return GetFieldValue(9);} set {SetFieldValue(9, value);} }
public string DateTimeQualifier2  {get {return GetFieldValue(10);} set {SetFieldValue(10, value);} }
public string Date2  {get {return GetFieldValue(11);} set {SetFieldValue(11, value);} }
public string Time2  {get {return GetFieldValue(12);} set {SetFieldValue(12, value);} }
public string DateTimeQualifier3  {get {return GetFieldValue(13);} set {SetFieldValue(13, value);} }
public string Date3  {get {return GetFieldValue(14);} set {SetFieldValue(14, value);} }
public string Time3  {get {return GetFieldValue(15);} set {SetFieldValue(15, value);} }
public string DateTimeQualifier4  {get {return GetFieldValue(16);} set {SetFieldValue(16, value);} }
public string Date4  {get {return GetFieldValue(17);} set {SetFieldValue(17, value);} }
public string Time4  {get {return GetFieldValue(18);} set {SetFieldValue(18, value);} }
public string DateTimeQualifier5  {get {return GetFieldValue(19);} set {SetFieldValue(19, value);} }
public string Date5  {get {return GetFieldValue(20);} set {SetFieldValue(20, value);} }
public string Time5  {get {return GetFieldValue(21);} set {SetFieldValue(21, value);} }
public CUR():base(){}
public CUR(string[] splitX12Line) : this(splitX12Line.ToList()){}
public CUR(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class DMG : BaseStdSegment{
public string DtFormatQual  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string DtPeriod  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string GenderCode  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string MaritalStatusCode  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string CompRace  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string CitizenStatusCode  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public string CountryCode  {get {return GetFieldValue(7);} set {SetFieldValue(7, value);} }
public string BasisOfVerifCode  {get {return GetFieldValue(8);} set {SetFieldValue(8, value);} }
public string Quantity  {get {return GetFieldValue(9);} set {SetFieldValue(9, value);} }
public string CodeListQualCode  {get {return GetFieldValue(10);} set {SetFieldValue(10, value);} }
public string IndustryCode  {get {return GetFieldValue(11);} set {SetFieldValue(11, value);} }
public DMG():base(){}
public DMG(string[] splitX12Line) : this(splitX12Line.ToList()){}
public DMG(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class DTP : BaseStdSegment{
public string DtQual  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string DtFormatQual  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string DtPeriod  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public DTP():base(){}
public DTP(string[] splitX12Line) : this(splitX12Line.ToList()){}
public DTP(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class FRM : BaseStdSegment{
public string AssignedId  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string YesNo  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string ReferenceId  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string Date  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string PercentFormat  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public FRM():base(){}
public FRM(string[] splitX12Line) : this(splitX12Line.ToList()){}
public FRM(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class GE : BaseStdSegment{
public string NumberOfTransactionSetsIncluded  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string GroupControlNumber  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public GE():base(){}
public GE(string[] splitX12Line) : this(splitX12Line.ToList()){}
public GE(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class GS : BaseStdSegment{
public string FunctionalIdCode  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string ApplicaitonSendsCode  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string ApplicationRecsCode  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string Date  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string Time  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string GroupCtrlNumber  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public string ResponsibleAgencyCode  {get {return GetFieldValue(7);} set {SetFieldValue(7, value);} }
public string VerReleaseIdCode  {get {return GetFieldValue(8);} set {SetFieldValue(8, value);} }
public GS():base(){}
public GS(string[] splitX12Line) : this(splitX12Line.ToList()){}
public GS(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class HCP : BaseStdSegment{
public string Methodology  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string Amount  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string SavingAmount  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string ReferenceIdentifier  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string Rate  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string ReferenceIdentifier2  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public string Amount2  {get {return GetFieldValue(7);} set {SetFieldValue(7, value);} }
public string ProductServiceId  {get {return GetFieldValue(8);} set {SetFieldValue(8, value);} }
public string ProductServiceIdQualifier  {get {return GetFieldValue(9);} set {SetFieldValue(9, value);} }
public string ProductServiceId2  {get {return GetFieldValue(10);} set {SetFieldValue(10, value);} }
public string UnitOfMeasurementCode  {get {return GetFieldValue(11);} set {SetFieldValue(11, value);} }
public string Quantity  {get {return GetFieldValue(12);} set {SetFieldValue(12, value);} }
public string RejectReasonCode  {get {return GetFieldValue(13);} set {SetFieldValue(13, value);} }
public string PolicyComplianceCode  {get {return GetFieldValue(14);} set {SetFieldValue(14, value);} }
public string ExceptionCode  {get {return GetFieldValue(15);} set {SetFieldValue(15, value);} }
public HCP():base(){}
public HCP(string[] splitX12Line) : this(splitX12Line.ToList()){}
public HCP(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class HI : BaseStdSegment{
public string CodeInfomation1  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string CodeInfomation2  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string CodeInfomation3  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string CodeInfomation4  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string CodeInfomation5  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string CodeInfomation6  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public string CodeInfomation7  {get {return GetFieldValue(7);} set {SetFieldValue(7, value);} }
public string CodeInfomation8  {get {return GetFieldValue(8);} set {SetFieldValue(8, value);} }
public string CodeInfomation9  {get {return GetFieldValue(9);} set {SetFieldValue(9, value);} }
public string CodeInfomation10  {get {return GetFieldValue(10);} set {SetFieldValue(10, value);} }
public string CodeInfomation11  {get {return GetFieldValue(11);} set {SetFieldValue(11, value);} }
public string CodeInfomation12  {get {return GetFieldValue(12);} set {SetFieldValue(12, value);} }
public HI():base(){}
public HI(string[] splitX12Line) : this(splitX12Line.ToList()){}
public HI(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class HL : BaseStdSegment{
public string HierarchIdNumber  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string HierarchParentId  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string HierarchLevelCode  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string HierarchChildCode  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public HL():base(){}
public HL(string[] splitX12Line) : this(splitX12Line.ToList()){}
public HL(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class IEA : BaseStdSegment{
public string NumOfInclFunctGroup  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string InterCtrlNumber  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public IEA():base(){}
public IEA(string[] splitX12Line) : this(splitX12Line.ToList()){}
public IEA(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class ISA : BaseStdSegment{
public string AuthInformationQualifier {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string AuthorizationInformation {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string SecurityInformationQualifier {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string SecurityInformation {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string InterchangeIDQualifier {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string InterchangeSenderID {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public string InterchangeIDQualifier_2 {get {return GetFieldValue(7);} set {SetFieldValue(7, value);} }
public string InterchangeReceiverID {get {return GetFieldValue(8);} set {SetFieldValue(8, value);} }
public string InterchangeDate {get {return GetFieldValue(9);} set {SetFieldValue(9, value);} }
public string InterchangeTime {get {return GetFieldValue(10);} set {SetFieldValue(10, value);} }
public string RepetitionSeparator {get {return GetFieldValue(11);} set {SetFieldValue(11, value);} }
public string InterchangeControlVersion {get {return GetFieldValue(12);} set {SetFieldValue(12, value);} }
public string InterchangeControlNo {get {return GetFieldValue(13);} set {SetFieldValue(13, value);} }
public string AcknowledgmentRequested {get {return GetFieldValue(14);} set {SetFieldValue(14, value);} }
public string UsageIndicator {get {return GetFieldValue(15);} set {SetFieldValue(15, value);} }
public string LineSeperator {get {return GetFieldValue(16);} set {SetFieldValue(16, value);} }
public string ComponentElementSeparator {get {return GetFieldValue(17);} set {SetFieldValue(17, value);} }
public ISA():base(){}
public ISA(string[] splitX12Line) : this(splitX12Line.ToList()){}
public ISA(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class K3 : BaseStdSegment{
public string FixedFormatInfomation  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public K3():base(){}
public K3(string[] splitX12Line) : this(splitX12Line.ToList()){}
public K3(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class LIN : BaseStdSegment{
public string AssignedId  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string ProductServiceQualifier  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string ProductServiceId  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public LIN():base(){}
public LIN(string[] splitX12Line) : this(splitX12Line.ToList()){}
public LIN(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class LQ : BaseStdSegment{
public string QualifierCode  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string IndustryCode  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public LQ():base(){}
public LQ(string[] splitX12Line) : this(splitX12Line.ToList()){}
public LQ(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class LX : BaseStdSegment{
public string AssignedNumber  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public LX():base(){}
public LX(string[] splitX12Line) : this(splitX12Line.ToList()){}
public LX(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class MEA : BaseStdSegment{
public string ReferenceCode  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string Qualifier  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string Value  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public MEA():base(){}
public MEA(string[] splitX12Line) : this(splitX12Line.ToList()){}
public MEA(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class MOA : BaseStdSegment{
public string Percent  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string Amount1  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string ReferenceId1  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string ReferenceId2  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string ReferenceId3  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string ReferenceId4  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public string ReferenceId5  {get {return GetFieldValue(7);} set {SetFieldValue(7, value);} }
public string Amount2  {get {return GetFieldValue(8);} set {SetFieldValue(8, value);} }
public string Amount3  {get {return GetFieldValue(9);} set {SetFieldValue(9, value);} }
public MOA():base(){}
public MOA(string[] splitX12Line) : this(splitX12Line.ToList()){}
public MOA(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class N3 : BaseStdSegment{
public string AddressLine1  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string AddressLine2  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public N3():base(){}
public N3(string[] splitX12Line) : this(splitX12Line.ToList()){}
public N3(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class N4 : BaseStdSegment{
public string City  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string State  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string PostalCode  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string CountryCode  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string LocationQualifier  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string LocationId  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public string CountrySubCode  {get {return GetFieldValue(7);} set {SetFieldValue(7, value);} }
public N4():base(){}
public N4(string[] splitX12Line) : this(splitX12Line.ToList()){}
public N4(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class NM1 : BaseStdSegment{
public string EntityIdCode  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string EntityTypeQualifier  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string LastNameOrgName  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string FirstName  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string MiddleName  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string NamePrefix  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public string NameSuffix  {get {return GetFieldValue(7);} set {SetFieldValue(7, value);} }
public string IdCodeQualifier  {get {return GetFieldValue(8);} set {SetFieldValue(8, value);} }
public string IdCode  {get {return GetFieldValue(9);} set {SetFieldValue(9, value);} }
public string EntityRelatCode  {get {return GetFieldValue(10);} set {SetFieldValue(10, value);} }
public string EntityIdCode2  {get {return GetFieldValue(11);} set {SetFieldValue(11, value);} }
public string LastNameOrgName2  {get {return GetFieldValue(12);} set {SetFieldValue(12, value);} }
public NM1():base(){}
public NM1(string[] splitX12Line) : this(splitX12Line.ToList()){}
public NM1(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class NTE : BaseStdSegment{
public string ReferenceCode  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string Description  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public NTE():base(){}
public NTE(string[] splitX12Line) : this(splitX12Line.ToList()){}
public NTE(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class OI : BaseStdSegment{
public string IdicatorCode  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string ReasonCode  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string YesNo  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string SignatureSourceCode  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string ProviderAgreementCode  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string ReleaseOfInfomationCode  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public OI():base(){}
public OI(string[] splitX12Line) : this(splitX12Line.ToList()){}
public OI(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class PAT : BaseStdSegment{
public string IndividualRelatCode  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string PatientLocationCode  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string EmploymentStatusCode  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string StudentStatusCode  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string DateTimeFormatQualifier  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string DeathDate  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public string UnitOfWeight  {get {return GetFieldValue(7);} set {SetFieldValue(7, value);} }
public string PatientWeight  {get {return GetFieldValue(8);} set {SetFieldValue(8, value);} }
public string Pregnant  {get {return GetFieldValue(9);} set {SetFieldValue(9, value);} }
public PAT():base(){}
public PAT(string[] splitX12Line) : this(splitX12Line.ToList()){}
public PAT(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class PER : BaseStdSegment{
public string ContactFunctCode  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string Name  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string CommNumberQual  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string CommNumber  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string CommNumberQual2  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string CommNumber2  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public string CommNumberQual3  {get {return GetFieldValue(7);} set {SetFieldValue(7, value);} }
public string CommNumber3  {get {return GetFieldValue(8);} set {SetFieldValue(8, value);} }
public string ContactInqRef  {get {return GetFieldValue(9);} set {SetFieldValue(9, value);} }
public PER():base(){}
public PER(string[] splitX12Line) : this(splitX12Line.ToList()){}
public PER(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class PRV : BaseStdSegment{
public string Code  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string ReferenceIdQualifier  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string ReferenceIdentification  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string StateCode  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string SpecialtyInfo  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string OrganizationCode  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public PRV():base(){}
public PRV(string[] splitX12Line) : this(splitX12Line.ToList()){}
public PRV(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class PS1 : BaseStdSegment{
public string ReferenceId  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string Amount  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string StateCode  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public PS1():base(){}
public PS1(string[] splitX12Line) : this(splitX12Line.ToList()){}
public PS1(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class PWK : BaseStdSegment{
public string ReportType  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string ReportTransmissionCode  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string ReportCopiesNeeded  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string EntityIdCode  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string IdCodeQualifier  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string IdCode  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public string Descripiton  {get {return GetFieldValue(7);} set {SetFieldValue(7, value);} }
public string ActionsIndicated  {get {return GetFieldValue(8);} set {SetFieldValue(8, value);} }
public string RequestCategoryCode  {get {return GetFieldValue(9);} set {SetFieldValue(9, value);} }
public PWK():base(){}
public PWK(string[] splitX12Line) : this(splitX12Line.ToList()){}
public PWK(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class QTY : BaseStdSegment{
public string Qualifier  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string Quantity  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string CompositeUnit  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string Message  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public QTY():base(){}
public QTY(string[] splitX12Line) : this(splitX12Line.ToList()){}
public QTY(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class REF : BaseStdSegment{
public string RefIdQualifier  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string RefIdent  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string Description  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string RefIdent2  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public REF():base(){}
public REF(string[] splitX12Line) : this(splitX12Line.ToList()){}
public REF(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class SBR : BaseStdSegment{
public string PayerResponseSeqNo  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string IndividualrelatCode  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string ReferenceIdent  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string Name  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string InsuranceTypeCode  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string BenefitsCoordCode  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public string YesNoCondResponseCode  {get {return GetFieldValue(7);} set {SetFieldValue(7, value);} }
public string EmploymentStatusCode  {get {return GetFieldValue(8);} set {SetFieldValue(8, value);} }
public string ClaimFileIndCode  {get {return GetFieldValue(9);} set {SetFieldValue(9, value);} }
public SBR():base(){}
public SBR(string[] splitX12Line) : this(splitX12Line.ToList()){}
public SBR(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class SE : BaseStdSegment{
public string NumberIncludedSegments  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string TSControlNumber  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public SE():base(){}
public SE(string[] splitX12Line) : this(splitX12Line.ToList()){}
public SE(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class ST : BaseStdSegment{
public string TransactionSetId  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string TransactionSetControlNum  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string ImplementationConvRef  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public ST():base(){}
public ST(string[] splitX12Line) : this(splitX12Line.ToList()){}
public ST(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class STC : BaseStdSegment{
public string HealthCareStatClaim  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string Date  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string ActionCode  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string MonetaryAmount  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string MonetaryAmount2  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string Date2  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public string PaymentMethodCode  {get {return GetFieldValue(7);} set {SetFieldValue(7, value);} }
public string Date3  {get {return GetFieldValue(8);} set {SetFieldValue(8, value);} }
public string CheckNumber  {get {return GetFieldValue(9);} set {SetFieldValue(9, value);} }
public string HealthCareStatClaim2  {get {return GetFieldValue(10);} set {SetFieldValue(10, value);} }
public string HealthCareStatClaim3  {get {return GetFieldValue(11);} set {SetFieldValue(11, value);} }
public STC():base(){}
public STC(string[] splitX12Line) : this(splitX12Line.ToList()){}
public STC(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class SV1 : BaseStdSegment{
public string MedicalProcedureId  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string Amount  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string UnitOfMeasure  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string Quantity  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string FacilityCodeValue  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string ServiceTypeCode  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public string DiagnosisCode  {get {return GetFieldValue(7);} set {SetFieldValue(7, value);} }
public string Amount2  {get {return GetFieldValue(8);} set {SetFieldValue(8, value);} }
public string YesNo  {get {return GetFieldValue(9);} set {SetFieldValue(9, value);} }
public string MutiProcedureCode  {get {return GetFieldValue(10);} set {SetFieldValue(10, value);} }
public string YesNo2  {get {return GetFieldValue(11);} set {SetFieldValue(11, value);} }
public string YesNo3  {get {return GetFieldValue(12);} set {SetFieldValue(12, value);} }
public string ReviewCode  {get {return GetFieldValue(13);} set {SetFieldValue(13, value);} }
public string NationalLocalReviewCode  {get {return GetFieldValue(14);} set {SetFieldValue(14, value);} }
public string CopayStatusCode  {get {return GetFieldValue(15);} set {SetFieldValue(15, value);} }
public string ProfessionalShortageAreaCode  {get {return GetFieldValue(16);} set {SetFieldValue(16, value);} }
public string ReferenceId  {get {return GetFieldValue(17);} set {SetFieldValue(17, value);} }
public string PostalCode  {get {return GetFieldValue(18);} set {SetFieldValue(18, value);} }
public string Amount3  {get {return GetFieldValue(19);} set {SetFieldValue(19, value);} }
public string LevelOfCareCode  {get {return GetFieldValue(20);} set {SetFieldValue(20, value);} }
public string ProviderAgreementCode  {get {return GetFieldValue(21);} set {SetFieldValue(21, value);} }
public SV1():base(){}
public SV1(string[] splitX12Line) : this(splitX12Line.ToList()){}
public SV1(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class SV5 : BaseStdSegment{
public string SV501MedicalProcedureId  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string Unit  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string Quantity  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string Amount1  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string Amount2  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string FrequencyCode  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public string PrognosisCode  {get {return GetFieldValue(7);} set {SetFieldValue(7, value);} }
public SV5():base(){}
public SV5(string[] splitX12Line) : this(splitX12Line.ToList()){}
public SV5(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class SVC : BaseStdSegment{
public string CompositMedProcId  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string MonetaryAmount  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string MonetaryAmount2  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string ProductServiceId  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string Quantity  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string CompositMedProcId2  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public string Quantity2  {get {return GetFieldValue(7);} set {SetFieldValue(7, value);} }
public SVC():base(){}
public SVC(string[] splitX12Line) : this(splitX12Line.ToList()){}
public SVC(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class SVD : BaseStdSegment{
public string IDCode  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string Amount  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string MedicalProcedureId  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string ProductServiceID  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public string Quantity  {get {return GetFieldValue(5);} set {SetFieldValue(5, value);} }
public string AssignedNumber  {get {return GetFieldValue(6);} set {SetFieldValue(6, value);} }
public SVD():base(){}
public SVD(string[] splitX12Line) : this(splitX12Line.ToList()){}
public SVD(List<string> splitX12Line) :base(splitX12Line){}
}
public partial class TRN : BaseStdSegment{
public string TraceTypeCode  {get {return GetFieldValue(1);} set {SetFieldValue(1, value);} }
public string ReferenceIdent  {get {return GetFieldValue(2);} set {SetFieldValue(2, value);} }
public string OrigCompanyId  {get {return GetFieldValue(3);} set {SetFieldValue(3, value);} }
public string ReferenceIdent2  {get {return GetFieldValue(4);} set {SetFieldValue(4, value);} }
public TRN():base(){}
public TRN(string[] splitX12Line) : this(splitX12Line.ToList()){}
public TRN(List<string> splitX12Line) :base(splitX12Line){}
}
