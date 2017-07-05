using System;
using System.Collections.Generic;
using System.Linq;
using Model.EDI.X12.v1.Base;

namespace Model.EDI.X12.v1
{
    public class IEA : baseStdSegment
    {
        public string numOfInclFunctGroup;
        public string interCtrlNumber;

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }

    public class GS : baseStdSegment
    {
        public string functionalIdCode;
        public string applicaitonSendsCode;
        public string applicationRecsCode;
        public string date;
        public string time;
        public string groupCtrlNumber;
        public string responsibleAgencyCode;
        public string verReleaseIdCode;

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class ISA : baseStdSegment
    {
        public string autherInfoQualifier;
        public string autherInformation;
        public string securityInfoQual;
        public string securityInformation;
        public string interchangeIdQual;
        public string interchangeSenderId;
        public string interchangeIdQual2;
        public string interchangeReceiverId;
        public string interchangeDate;
        public string interchangeTime;
        public string repetitionSeparator;
        public string interCtrlVersionNumber;
        public string interCtrlNumber;
        public string ackRequestion;
        public string usageIndicator;
        public string componentElemSepara;

        public ISA()
        {
        }


        public override void Populate()
        { 
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class GE : baseStdSegment
    {
        public string numberOfTransactionSetsIncluded;
        public string groupControlNumber;

        public GE() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class ST : baseStdSegment
    {
        public string transactionSetId;
        public string transactionSetControlNum;
        public string implementationConvRef;

        public ST() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class BHT : baseStdSegment
    {
        public string structureCode;
        public string transactionSetPurposeCode;
        public string refId;
        public string date;
        public string time;
        public string transactionTypeCode;

        public BHT() { }

        public BHT(string[] splitX12Line) : this(splitX12Line.ToList())
        {
        }

        public BHT(List<string> splitX12Line)
        {

        }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class HL : baseStdSegment
    {
        public string id;
        public string parentId;
        public string levelCode;
        public string childCode;

        public HL()
        {
        }

        public HL(string[] splitX12Line) : this(splitX12Line.ToList())
        {
        }

        public HL(List<string> splitX12Line)
        {
            childCode = splitX12Line[4];

            id = splitX12Line[1];

            levelCode = splitX12Line[3];

            parentId = splitX12Line[2];
        }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class NM1 : baseStdSegment
    {
        public string entityIdCode;
        public string entityTypeQualifier;
        public string lastNameOrgName;
        public string firstName;
        public string middleName;
        public string namePrefix;
        public string nameSuffix;
        public string idCodeQualifier;
        public string idCode;
        public string entityRelatCode;
        public string entityIdCode2;
        public string lastNameOrgName2;

        public NM1() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class DMG : baseStdSegment
    {
        public string dtFormatQual;
        public string dtPeriod;
        public string genderCode;
        public string maritalStatusCode;
        public string compRace;
        public string citizenStatusCode;
        public string countryCode;
        public string basisOfVerifCode;
        public string quantity;
        public string codeListQualCode;
        public string industryCode;

        public DMG() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class TRN : baseStdSegment
    {
        public string traceTypeCode;
        public string referenceIdent;
        public string origCompanyId;
        public string referenceIdent2;

        public TRN() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class REF : baseStdSegment
    {
        public string refIdQualifier;
        public string refIdent;
        public string description;
        public string refIdent2;

        public REF() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class AMT : baseStdSegment
    {
        public string amountQualifierCode;
        public string monetaryAmount;
        public string creditDebitFlagCode;

        public AMT() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class DTP : baseStdSegment
    {
        public string dtQual;
        public string dtFormatQual;
        public string dtPeriod;

        public DTP() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class SVC : baseStdSegment
    {
        public string compositMedProcId;
        public string monetaryAmount;
        public string monetaryAmount2;
        public string productServiceId;
        public string quantity;
        public string compositMedProcId2;
        public string quantity2;

        public SVC() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class SE : baseStdSegment
    {
        public string numberIncludedSegments;
        public string TSControlNumber;

        public SE() { }

        public override void Populate()
        {
        }

        public override string ToString()
        {
            return "";
        }

        public override bool Validate()
        {
            return true;
        }
    }

    public class STC : baseStdSegment
    {
        public string healthCareStatClaim;
        public string date;
        public string actionCode;
        public string monetaryAmount;
        public string monetaryAmount2;
        public string date2;
        public string paymentMethodCode;
        public string date3;
        public string checkNumber;
        public string healthCareStatClaim2;
        public string healthCareStatClaim3;
        public STC() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class PER : baseStdSegment
    {
        public string contactFunctCode;
        public string name;
        public string commNumberQual;
        public string commNumber;
        public string commNumberQual2;
        public string commNumber2;
        public string commNumberQual3;
        public string commNumber3;
        public string contactInqRef;
        public PER() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }

    //new start

    public class SBR : baseStdSegment
    {
        public string PayerResponseSeqNo;
        public string IndividualrelatCode;
        public string ReferenceIdent;
        public string Name;
        public string InsuranceTypeCode;
        public string BenefitsCoordCode;
        public string YesNoCondResponseCode;
        public string EmploymentStatusCode;
        public string ClaimFileIndCode;
        public SBR() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class PAT : baseStdSegment
    {
        public string IndividualRelatCode;
        public string PatientLocationCode;
        public string EmploymentStatusCode;
        public string StudentStatusCode;
        public string DateTimeFormatQualifier;
        public string DeathDate;
        public string UnitOfWeight;
        public string PatientWeight;
        public string Pregnant;
        public PAT() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }

    public class N3 : baseStdSegment
    {
        public string AddressLine1;
        public string AddressLine2;
        public N3() { }

        public override void Populate()
        {
        }

        public override string ToString()
        {
            return "";
        }

        public override bool Validate()
        {
            return true;
        }
    }
    public class N4 : baseStdSegment
    {
        public string City;
        public string State;
        public string PostalCode;
        public string CountryCode;
        public string LocationQualifier;
        public string LocationId;
        public string CountrySubCode;
        public N4() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }

    public class CLM : baseStdSegment
    {
        public string ClaimSubmitterId;
        public string MonentaryAmount;
        public string ClaimFilintIndicatorCode;
        public string NonInstitutionalCllaimTypeCode;
        public string HealthCareLocation;
        public string SignatureOnFileYesNo;
        public string ProviderAcceptAssignmentCode;
        public string AuthorizedYesNo;
        public string ReleaseOfnfomaitonCode;
        public string PatientSignatureSourceCode;
        public string RelatedCausesInfo;
        public string SpecialProgramCode;
        public string YesNo1;
        public string LevelOfServiceCode;
        public string YesNo2;
        public string ProviderAgreementCode;
        public string ClaimStatusCode;
        public string YesNo3;
        public string ClaimSubmissionReasonCode;
        public string DelayReasonCode;
        public CLM() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }

    public class PRV : baseStdSegment
    {
        public string Code;
        public string ReferenceIdQualifier;
        public string ReferenceIdentification;
        public string StateCode;
        public string SpecialtyInfo;
        public string OrganizationCode;
        public PRV() { }
        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class CUR : baseStdSegment
    {
        public string IdCode;
        public string CurrencyCode;
        public string ExchangeRate;
        public string EntitytIdCode;
        public string CurrencyCode2;
        public string CurrMarkgetExchgCode;
        public string DateTimeQualifier;
        public string Date;
        public string Time;
        public string DateTimeQualifier2;
        public string Date2;
        public string Time2;
        public string DateTimeQualifier3;
        public string Date3;
        public string Time3;
        public string DateTimeQualifier4;
        public string Date4;
        public string Time4;
        public string DateTimeQualifier5;
        public string Date5;
        public string Time5;

        public CUR() { }
        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class PWK : baseStdSegment
    {
        public string ReportType;
        public string ReportTransmissionCode;
        public string ReportCopiesNeeded;
        public string EntityIdCode;
        public string IdCodeQualifier;
        public string IdCode;
        public string Descripiton;
        public string ActionsIndicated;
        public string RequestCategoryCode;
        public PWK() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class CN1 : baseStdSegment
    {
        public string ContractTypeCode;
        public string MonetaryAmount;
        public string Percent;
        public string ReferenceIdentifier;
        public string TermsDiscountPercent;
        public string VersionId;
        public CN1() { }

        public override void Populate()
        {
        }

        public override string ToString()
        {
            return "";
        }

        public override bool Validate()
        {
            return true;
        }
    }

    public class K3 : baseStdSegment
    {
        public string FixedFormatInfomation;
        public K3() { }

        public override void Populate()
        {
        }

        public override string ToString()
        {
            return "";
        }

        public override bool Validate()
        {
            return true;
        }
    }
    public class NTE : baseStdSegment
    {
        public string ReferenceCode;
        public string Description;
        public NTE() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class CR1 : baseStdSegment
    {
        public string UnitOfMeasurement;
        public string Weight;
        public string TransportCode;
        public string TransportReason;
        public string DistanceUnit;
        public string Distance;
        public string AddressLine1;
        public string AddressLine2;
        public string Description;
        public string Description2;
        public CR1() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class CR2 : baseStdSegment
    {
        public string Count;
        public string Quantity;
        public string LevelCode1;
        public string LevelCode2;
        public string Unit;
        public string Quantity2;
        public string Quantity3;
        public string NatureOfCoditionCode;
        public string YesNo;
        public string Description1;
        public string Description2;
        public string YesNo2;
        public CR2() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class CRC : baseStdSegment
    {
        public string CodeCategory;
        public string YesNo;
        public string ConditionIndicator1;
        public string ConditionIndicator2;
        public string ConditionIndicator3;
        public string ConditionIndicator4;
        public string ConditionIndicator5;
        public CRC() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class HI : baseStdSegment
    {
        public string CodeInfomation1;
        public string CodeInfomation2;
        public string CodeInfomation3;
        public string CodeInfomation4;
        public string CodeInfomation5;
        public string CodeInfomation6;
        public string CodeInfomation7;
        public string CodeInfomation8;
        public string CodeInfomation9;
        public string CodeInfomation10;
        public string CodeInfomation11;
        public string CodeInfomation12;

        public HI() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class HCP : baseStdSegment
    {
        public string Methodology;
        public string Amount;
        public string SavingAmount;
        public string ReferenceIdentifier;
        public string Rate;
        public string ReferenceIdentifier2;
        public string Amount2;
        public string ProductServiceId;
        public string ProductServiceIdQualifier;
        public string ProductServiceId2;
        public string UnitOfMeasurementCode;
        public string quantity;
        public string RejectReasonCode;
        public string PolicyComplianceCode;
        public string ExceptionCode;
        public HCP() { }
        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class CAS : baseStdSegment
    {
        public string AdjustmentGroupCode1;
        public string ReasonCode1;
        public string Amount1;
        public string Quantity1;
        public string AdjustmentGroupCode2;
        public string ReasonCode2;
        public string Amount2;
        public string Quantity2;
        public string AdjustmentGroupCode3;
        public string ReasonCode3;
        public string Amount3;
        public string Quantity3;
        public string AdjustmentGroupCode4;
        public string ReasonCode4;
        public string Amount4;
        public string Quantity4;
        public string AdjustmentGroupCode5;
        public string ReasonCode5;
        public string Amount5;
        public string Quantity5;
        public string AdjustmentGroupCode6;
        public string ReasonCode6;
        public string Amount6;
        public CAS() { }
        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class OI : baseStdSegment
    {
        public string IdicatorCode;
        public string ReasonCode;
        public string YesNo;
        public string SignatureSourceCode;
        public string ProviderAgreementCode;
        public string ReleaseOfInfomationCode;
        public OI() { }
        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class MOA : baseStdSegment
    {
        public string Percent;
        public string Amount1;
        public string ReferenceId1;
        public string ReferenceId2;
        public string ReferenceId3;
        public string ReferenceId4;
        public string ReferenceId5;
        public string Amount2;
        public string Amount3;
        public MOA() { }
        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class LX : baseStdSegment
    {
        public string AssignedNumber;
        public LX() { }

        public override void Populate()
        {
        }

        public override string ToString()
        {
            return "";
        }

        public override bool Validate()
        {
            return true;
        }
    }
    public class SV1 : baseStdSegment
    {
        public string MedicalProcedureId;
        public string Amount;
        public string UnitOfMeasure;
        public string Quantity;
        public string FacilityCodeValue;
        public string ServiceTypeCode;
        public string DiagnosisCode;
        public string Amount2;
        public string YesNo;
        public string MutiProcedureCode;
        public string YesNo2;
        public string YesNo3;
        public string ReviewCode;
        public string NationalLocalReviewCode;
        public string CopayStatusCode;
        public string ProfessionalShortageAreaCode;
        public string ReferenceId;
        public string PostalCode;
        public string Amount3;
        public string LevelOfCareCode;
        public string ProviderAgreementCode;
        public SV1() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class SV5 : baseStdSegment
    {
        public string SV501MedicalProcedureId;
        public string Unit;
        public string Quantity;
        public string Amount1;
        public string Amount2;
        public string FrequencyCode;
        public string PrognosisCode;
        public SV5() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class CR3 : baseStdSegment
    {
        public string TypeCode;
        public string Unit;
        public string Quantity;
        public string InsulidDependentCode;
        public string Description;
        public CR3() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }

    public class QTY : baseStdSegment
    {
        public string Qualifier;
        public string Quantity;
        public string CompositeUnit;
        public string Message;

        public QTY() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }

    public class MEA : baseStdSegment
    {
        public string ReferenceCode;
        public string Qualifier;
        public string Value;
        public MEA() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class PS1 : baseStdSegment
    {
        public string ReferenceId;
        public string Amount;
        public string StateCode;
        public PS1() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class LIN : baseStdSegment
    {
        public string AssignedId;
        public string ProductServiceQualifier;
        public string ProductServiceId;
        public LIN() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class CTP : baseStdSegment
    {
        public string ClassOfTradeCode;
        public string PriceIdCode;
        public string UnitPrice;
        public string Quantity;
        public string CompositeUnitOfMeasure;
        public CTP() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class SVD : baseStdSegment
    {
        public string IDCode;
        public string Amount;
        public string MedicalProcedureId;
        public string ProductServiceID;
        public string Quantity;
        public string AssignedNumber;
        public SVD() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class LQ : baseStdSegment
    {
        public string QualifierCode;
        public string IndustryCode;
        public LQ() { }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
    public class FRM : baseStdSegment
    {
        public string AssignedId;
        public string YesNo;
        public string ReferenceId;
        public string Date;
        public string PercentFormat;

        public FRM()
        {
        }

        public FRM(string value, Delimiters delims, LoopsList parent)
        {
        }

        public override void Populate()
        {
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }



}
