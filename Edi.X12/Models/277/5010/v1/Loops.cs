using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EDI.X12.v1;
using Model.EDI.X12.v1.Base;

namespace Model.EDI.X12.Format277.v5010.v1
{
    public class Loop2000A
    {
        public HL InformationSourceLevel;
        public string InformationSourceLevelQaulifier = "20";

        public Loop2100A Loop2100A;
    }

    public class Loop2100A
    {
        public NM1 PayerName;
        public string PayerNameQaulifier = "PR";
        public PER PayerContactInformation;
        public string PayerContactInformationQaulifier = "IC";
    }
    public class Loop2000B
    {
        public HL InformationReceiverLevel;
        public string InformationReceiverLevelQaulifier = "21";
        public Loop2100B Loop2100B;
        public Loop2200B Loop2200B;
    }
    public class Loop2100B
    {
        public NM1 InformationReceiverName;
        public string InformationReceiverNameQaulifier = "41";
    }
    public class Loop2200B
    {
        public TRN InformationReceiverTraceIdentifier;
        public string InformationReceiverTraceIdentifierQaulifier = "2";
        public STC InformationReceiverStatusInformation;
        public string InformationReceiverStatusInformationQaulifier = "41,AY,PR";
    }
    public class Loop2000C
    {
        public HL ServiceProviderLevel;
        public string ServiceProviderLevelQaulifier = "19";

        public LoopList<Loop2100C> Loop2100C = new LoopList<Loop2100C>();
        public Loop2200C Loop2200C;
    }
    public class Loop2100C
    {
        public NM1 ProviderName;
        public string ProviderNameQaulifier = "1P";
    }
    public class Loop2200C
    {
        public TRN ProviderOfServiceTraceIdentifier;
        public string ProviderOfServiceTraceIdentifierQaulifier = "1";
        public STC ProviderStatusInformation;
        public string ProviderStatusInformationQaulifier = "1P";
    }
    public interface ILoop2200SubDepDetailBase
    {
        TRN ClaimStatusTrackingNumber { get; }
        STC ClaimLevelStatusInformation { get; }
        REF PayerClaimControlNumber { get; }
        REF InstitutionalBillTypeIdentification { get; }
        REF PatientControlNumber { get; }
        REF PharmacyPrescriptionNumber { get; }
        REF VoucherIdentifier { get; }
        REF ClaimIdentificationNumberForClearinghousesAnd { get; }
        DTP ClaimServiceDate { get; }
        IEnumerable<ILoop2220ServiceLineBase> Loop2220 { get; }
    }

    public interface ILoop2220ServiceLineBase
    {
        SVC ServiceLineInformation { get; }
        STC ServiceLineStatusInformation { get; }
        REF ServiceLineItemIdentification { get; }
        DTP ServiceLineDate { get; }
    }

    public interface ILoop2100SubDepName
    {
        NM1 SubDepName { get; }
    }

    public interface ILoop2000SubDepLevel
    {
        HL SubDepLevel { get; }

        ILoop2100SubDepName Loop2100 { get; }

        IEnumerable<ILoop2200SubDepDetailBase> Loop2200 { get; }
    }

    public class Loop2000D : ILoop2000SubDepLevel
    {
        public HL SubscriberLevel;

        public string SubscriberLevelQaulifier = "22";

        public Loop2100D Loop2100D;

        public LoopList<Loop2200D> Loop2200D = new LoopList<Loop2200D>();

        public HL SubDepLevel { get { return SubscriberLevel; } }

        public string SubDepLevelQualifier { get { return SubscriberLevelQaulifier; } }

        public ILoop2100SubDepName Loop2100 { get { return Loop2100D; } }

        public IEnumerable<ILoop2200SubDepDetailBase> Loop2200 { get { return Loop2200D; } }
    }

    public class Loop2100D : ILoop2100SubDepName
    {
        public NM1 SubscriberName;

        public string SubscriberNameQaulifier = "IL";


        public NM1 SubDepName { get { return SubscriberName; } }

        public string SubDepQaulifier { get { return SubscriberNameQaulifier; } }
    }

    public class Loop2200D : ILoop2200SubDepDetailBase
    {
        public const string ClaimLevelStatusInformationQaulifier = "03,13,17,1E,1G,1H,1I,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,28,2A,2B,2D,2E,2I,2K,2P,2Q,2S,2Z,30,36,3A,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3Q,3R,3S,3T,3U,3V,3W,3Y,3Z,40,43,44,4A,4B,4C,4D,4E ,4F ,4G ,4H ,4I ,4J ,4L ,4M ,4N ,4O ,4P ,4Q ,4R ,4S ,4U ,4V ,4W ,4X ,4Y ,4Z ,5A ,5B ,5C ,5D ,5E ,5F ,5G ,5H ,5I ,5J ,5K ,5L ,5N ,5O ,5P ,5Q ,5R ,5S ,5T ,5U ,5V ,5W ,5X ,5Y ,5Z ,61 ,6A ,6B ,6C ,6D ,6E ,6F ,6G ,6H ,6I ,6J ,6K ,6L ,6M ,6N ,6O ,6P ,6Q ,6R ,6S ,6U ,6V ,6W ,6X ,6Y ,71 ,72 ,73 ,74 ,7C ,80 ,82 ,84 ,85 ,87 ,95 ,CK ,CZ ,D2 ,DD ,DJ ,DK ,DN ,DO ,DQ ,E1 ,E2 ,E7 ,E9 ,FA ,FD ,FE ,G0 ,G3 ,GB ,GD ,GI ,GJ ,GK ,GM ,GY ,HF ,HH ,I3 ,IJ ,IL ,IN ,LI ,LR ,MR ,MSC,OB ,OD ,OX ,P0 ,P2 ,P3 ,P4 ,P6 ,P7 ,PRP,PT ,PV ,PW ,QA ,QB ,QC ,QD ,QE ,QH ,QK ,QL ,QN ,QO ,QS ,QV ,QY ,RC ,RW ,S4 ,SEP,SJ ,SU ,T4 ,TL ,TQ ,TT ,TTP,TU ,UH ,X3 ,X5 ,ZZ";
        public const string ClaimStatusTrackingNumberQaulifier = "2";
        public const string PayerClaimControlNumberQaulifier = "1K";
        public const string InstitutionalBillTypeIdentificationQaulifier = "BLT";
        public const string PatientControlNumberQaulifier = "EJ";
        public const string PharmacyPrescriptionNumberQaulifier = "XZ";
        public const string VoucherIdentifierQaulifier = "VV";
        public const string ClaimIdentificationNumberForClearinghousesAndQaulifier = "D9";
        public const string ClaimServiceDateQaulifier = "472";

        public TRN ClaimStatusTrackingNumber { get; set; }
        public STC ClaimLevelStatusInformation { get; set; }
        public REF PayerClaimControlNumber { get; set; }
        public REF InstitutionalBillTypeIdentification { get; set; }
        public REF PatientControlNumber { get; set; }
        public REF PharmacyPrescriptionNumber { get; set; }
        public REF VoucherIdentifier { get; set; }
        public REF ClaimIdentificationNumberForClearinghousesAnd { get; set; }
        public DTP ClaimServiceDate { get; set; }

        public LoopList<Loop2220D> Loop2220D = new LoopList<Loop2220D>();


        public IEnumerable<ILoop2220ServiceLineBase> Loop2220 { get { return Loop2220D; } }
    }

    public class Loop2220D : ILoop2220ServiceLineBase
    {
        public const string ServiceLineInformationQaulifier = "AD,ER,HC,HP,IV,N4,NU,WK";
        public const string ServiceLineStatusInformationQaulifier = "03 ,13 ,17 ,1E ,1G ,1H ,1I ,1O ,1P ,1Q ,1R ,1S ,1T ,1U ,1V ,1W ,1X ,1Y ,1Z ,28 ,2A ,2B ,2D ,2E ,2I ,2K ,2P ,2Q ,2S ,2Z ,30 ,36 ,3A ,3C ,3D ,3E ,3F ,3G ,3H ,3I ,3J ,3K ,3L ,3M ,3N ,3O ,3P ,3Q ,3R ,3S ,3T ,3U ,3V ,3W ,3Y ,3Z ,40 ,43 ,44 ,4A ,4B ,4C ,4D ,4E ,4F ,4G ,4H ,4I ,4J ,4L ,4M ,4N ,4O ,4P ,4Q ,4R ,4S ,4U ,4V ,4W ,4X ,4Y ,4Z ,5A ,5B ,5C ,5D ,5E ,5F ,5G ,5H ,5I ,5J ,5K ,5L ,5N ,5O ,5P ,5Q ,5R ,5S ,5T ,5U ,5V ,5W ,5X ,5Y ,5Z ,61 ,6A ,6B ,6C ,6D ,6E ,6F ,6G ,6H ,6I ,6J ,6K ,6L ,6M ,6N ,6O ,6P ,6Q ,6R ,6S ,6U ,6V ,6W ,6X ,6Y ,71 ,72 ,73 ,74 ,7C ,80 ,82 ,84 ,85 ,87 ,95 ,CK ,CZ ,D2 ,DD ,DJ ,DK ,DN ,DO ,DQ ,E1 ,E2 ,E7 ,E9 ,FA ,FD ,FE ,G0 ,G3 ,GB ,GD ,GI ,GJ ,GK ,GM ,GY ,HF ,HH ,I3 ,IJ ,IL ,IN ,LI ,LR ,MR ,MSC,OB ,OD ,OX ,P0 ,P2 ,P3 ,P4 ,P6 ,P7 ,PRP,PT ,PV ,PW ,QA ,QB ,QC ,QD ,QE ,QH ,QK ,QL ,QN ,QO ,QS ,QV ,QY ,RC ,RW ,S4 ,SEP,SJ ,SU ,T4 ,TL ,TQ ,TT ,TTP,TU ,UH ,X3 ,X5 ,ZZ";
        public const string ServiceLineItemIdentificationQaulifier = "FJ";
        public const string ServiceLineDateQaulifier = "472";

        public SVC ServiceLineInformation { get; set; }
        public STC ServiceLineStatusInformation { get; set; }
        public REF ServiceLineItemIdentification { get; set; }
        public DTP ServiceLineDate { get; set; }
    }
    public class Loop2000E : ILoop2000SubDepLevel
    {
        public const string DependentLevelQaulifier = "23";

        public HL DependentLevel;

        public Loop2100E Loop2100E;
        public LoopList<Loop2200E> Loop2200E = new LoopList<Loop2200E>();


        public HL SubDepLevel { get { return DependentLevel; } }

        public ILoop2100SubDepName Loop2100 { get { return Loop2100E; } }

        public IEnumerable<ILoop2200SubDepDetailBase> Loop2200 { get { return Loop2200E; } }
    }
    public class Loop2100E : ILoop2100SubDepName
    {
        public const string DependentNameQaulifier = "QC";

        public NM1 DependentName;

        public NM1 SubDepName { get { return DependentName; } }
    }
    public class Loop2200E : ILoop2200SubDepDetailBase
    {
        public string ClaimStatusTrackingNumberQaulifier = "2";
        public string ClaimLevelStatusInformationQaulifier = "03 ,13 ,17 ,1E ,1G ,1H ,1I ,1O ,1P ,1Q ,1R ,1S ,1T ,1U ,1V ,1W ,1X ,1Y ,1Z ,28 ,2A ,2B ,2D ,2E ,2I ,2K ,2P ,2Q ,2S ,2Z ,30 ,36 ,3A ,3C ,3D ,3E ,3F ,3G ,3H ,3I ,3J ,3K ,3L ,3M ,3N ,3O ,3P ,3Q ,3R ,3S ,3T ,3U ,3V ,3W ,3Y ,3Z ,40 ,43 ,44 ,4A ,4B ,4C ,4D ,4E ,4F ,4G ,4H ,4I ,4J ,4L ,4M ,4N ,4O ,4P ,4Q ,4R ,4S ,4U ,4V ,4W ,4X ,4Y ,4Z ,5A ,5B ,5C ,5D ,5E ,5F ,5G ,5H ,5I ,5J ,5K ,5L ,5N ,5O ,5P ,5Q ,5R ,5S ,5T ,5U ,5V ,5W ,5X ,5Y ,5Z ,61 ,6A ,6B ,6C ,6D ,6E ,6F ,6G ,6H ,6I ,6J ,6K ,6L ,6M ,6N ,6O ,6P ,6Q ,6R ,6S ,6U ,6V ,6W ,6X ,6Y ,71 ,72 ,73 ,74 ,7C ,80 ,82 ,84 ,85 ,87 ,95 ,CK ,CZ ,D2 ,DD ,DJ ,DK ,DN ,DO ,DQ ,E1 ,E2 ,E7 ,E9 ,FA ,FD ,FE ,G0 ,G3 ,GB ,GD ,GI ,GJ ,GK ,GM ,GY ,HF ,HH ,I3 ,IJ ,IL ,IN ,LI ,LR ,MR ,MSC,OB ,OD ,OX ,P0 ,P2 ,P3 ,P4 ,P6 ,P7 ,PRP,PT ,PV ,PW ,QA ,QB ,QC ,QD ,QE ,QH ,QK ,QL ,QN ,QO ,QS ,QV ,QY ,RC ,RW ,S4 ,SEP,SJ ,SU ,T4 ,TL ,TQ ,TT ,TTP,TU ,UH ,X3 ,X5 ,ZZ";
        public string PayerClaimControlNumberQaulifier = "1K";
        public string InstitutionalBillTypeIdentificationQaulifier = "BLT";
        public string PatientControlNumberQaulifier = "EJ";
        public string PharmacyPrescriptionNumberQaulifier = "XZ";
        public string VoucherIdentifierQaulifier = "VV";
        public string ClaimIdentificationNumberForClearinghousesAndQaulifier = "D9";
        public string ClaimServiceDateQaulifier = "472";

        public TRN ClaimStatusTrackingNumber { get; set; }
        public STC ClaimLevelStatusInformation { get; set; }
        public REF PayerClaimControlNumber { get; set; }
        public REF InstitutionalBillTypeIdentification { get; set; }
        public REF PatientControlNumber { get; set; }
        public REF PharmacyPrescriptionNumber { get; set; }
        public REF VoucherIdentifier { get; set; }
        public REF ClaimIdentificationNumberForClearinghousesAnd { get; set; }
        public DTP ClaimServiceDate { get; set; }

        public LoopList<Loop2220E> Loop2220E = new LoopList<Loop2220E>();

        public IEnumerable<ILoop2220ServiceLineBase> Loop2220 { get { return Loop2220E; } }
    }

    public class Loop2220E : ILoop2220ServiceLineBase
    {
        public string ServiceLineDateQaulifier = "472";
        public string ServiceLineInformationQaulifier = "AD,ER,HC,HP,IV,N4,NU,WK";
        public string ServiceLineStatusInformationQaulifier = "03 ,13 ,17 ,1E ,1G ,1H ,1I ,1O ,1P ,1Q ,1R ,1S ,1T ,1U ,1V ,1W ,1X ,1Y ,1Z ,28 ,2A ,2B ,2D ,2E ,2I ,2K ,2P ,2Q ,2S ,2Z ,30 ,36 ,3A ,3C ,3D ,3E ,3F ,3G ,3H ,3I ,3J ,3K ,3L ,3M ,3N ,3O ,3P ,3Q ,3R ,3S ,3T ,3U ,3V ,3W ,3Y ,3Z ,40 ,43 ,44 ,4A ,4B ,4C ,4D ,4E ,4F ,4G ,4H ,4I ,4J ,4L ,4M ,4N ,4O ,4P ,4Q ,4R ,4S ,4U ,4V ,4W ,4X ,4Y ,4Z ,5A ,5B ,5C ,5D ,5E ,5F ,5G ,5H ,5I ,5J ,5K ,5L ,5N ,5O ,5P ,5Q ,5R ,5S ,5T ,5U ,5V ,5W ,5X ,5Y ,5Z ,61 ,6A ,6B ,6C ,6D ,6E ,6F ,6G ,6H ,6I ,6J ,6K ,6L ,6M ,6N ,6O ,6P ,6Q ,6R ,6S ,6U ,6V ,6W ,6X ,6Y ,71 ,72 ,73 ,74 ,7C ,80 ,82 ,84 ,85 ,87 ,95 ,CK ,CZ ,D2 ,DD ,DJ ,DK ,DN ,DO ,DQ ,E1 ,E2 ,E7 ,E9 ,FA ,FD ,FE ,G0 ,G3 ,GB ,GD ,GI ,GJ ,GK ,GM ,GY ,HF ,HH ,I3 ,IJ ,IL ,IN ,LI ,LR ,MR ,MSC,OB ,OD ,OX ,P0 ,P2 ,P3 ,P4 ,P6 ,P7 ,PRP,PT ,PV ,PW ,QA ,QB ,QC ,QD ,QE ,QH ,QK ,QL ,QN ,QO ,QS ,QV ,QY ,RC ,RW ,S4 ,SEP,SJ ,SU ,T4 ,TL ,TQ ,TT ,TTP,TU ,UH ,X3 ,X5 ,ZZ";
        public string ServiceLineItemIdentificationQaulifier = "FJ";

        public SVC ServiceLineInformation { get; set; }
        public STC ServiceLineStatusInformation { get; set; }
        public REF ServiceLineItemIdentification { get; set; }
        public DTP ServiceLineDate { get; set; }

        public SE TransactionSetTrailer;
    }
}

