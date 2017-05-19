using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawsonCS.Model.EDI.X12.v1;
using LawsonCS.Model.EDI.X12.v1.Base;

namespace LawsonCS.Model.EDI.X12.Format277.v5010.v1
{
    [ProtoBuf.ProtoContract]
    public class Loop2000A
    {
        [ProtoBuf.ProtoMember(1)]
        public HL InformationSourceLevel;
        //    [ProtoBuf.ProtoMember(2)]
        public string InformationSourceLevelQaulifier = "20";

        [ProtoBuf.ProtoMember(3)]
        public Loop2100A Loop2100A;
    }
    [ProtoBuf.ProtoContract]
    public class Loop2100A
    {
        [ProtoBuf.ProtoMember(1)]
        public NM1 PayerName;
        //    [ProtoBuf.ProtoMember(2)]
        public string PayerNameQaulifier = "PR";
        [ProtoBuf.ProtoMember(3)]
        public PER PayerContactInformation;
        //     [ProtoBuf.ProtoMember(4)]
        public string PayerContactInformationQaulifier = "IC";
    }
    [ProtoBuf.ProtoContract]
    public class Loop2000B
    {
        [ProtoBuf.ProtoMember(1)]
        public HL InformationReceiverLevel;
        //      [ProtoBuf.ProtoMember(2)]
        public string InformationReceiverLevelQaulifier = "21";

        [ProtoBuf.ProtoMember(3)]
        public Loop2100B Loop2100B;
        [ProtoBuf.ProtoMember(4)]
        public Loop2200B Loop2200B;
    }
    [ProtoBuf.ProtoContract]
    public class Loop2100B
    {
        [ProtoBuf.ProtoMember(1)]
        public NM1 InformationReceiverName;
        //       [ProtoBuf.ProtoMember(2)]
        public string InformationReceiverNameQaulifier = "41";
    }
    [ProtoBuf.ProtoContract]
    public class Loop2200B
    {
        [ProtoBuf.ProtoMember(1)]
        public TRN InformationReceiverTraceIdentifier;
        //        [ProtoBuf.ProtoMember(2)]
        public string InformationReceiverTraceIdentifierQaulifier = "2";
        [ProtoBuf.ProtoMember(3)]
        public STC InformationReceiverStatusInformation;
        //        [ProtoBuf.ProtoMember(4)]
        public string InformationReceiverStatusInformationQaulifier = "41,AY,PR";
    }
    [ProtoBuf.ProtoContract]
    public class Loop2000C
    {
        [ProtoBuf.ProtoMember(1)]
        public HL ServiceProviderLevel;
        //        [ProtoBuf.ProtoMember(2)]
        public string ServiceProviderLevelQaulifier = "19";

        [ProtoBuf.ProtoMember(3)]
        public LoopList<Loop2100C> Loop2100C = new LoopList<Loop2100C>();
        [ProtoBuf.ProtoMember(4)]
        public Loop2200C Loop2200C;
    }
    [ProtoBuf.ProtoContract]
    public class Loop2100C
    {
        [ProtoBuf.ProtoMember(1)]
        public NM1 ProviderName;
        //[ProtoBuf.ProtoMember(2)]
        public string ProviderNameQaulifier = "1P";
    }
    [ProtoBuf.ProtoContract]
    public class Loop2200C
    {
        [ProtoBuf.ProtoMember(1)]
        public TRN ProviderOfServiceTraceIdentifier;
        //        [ProtoBuf.ProtoMember(2)]
        public string ProviderOfServiceTraceIdentifierQaulifier = "1";
        [ProtoBuf.ProtoMember(3)]
        public STC ProviderStatusInformation;
        //        [ProtoBuf.ProtoMember(4)]
        public string ProviderStatusInformationQaulifier = "1P";
    }
    [ProtoBuf.ProtoContract]
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

    [ProtoBuf.ProtoContract]
    public interface ILoop2220ServiceLineBase
    {
        SVC ServiceLineInformation { get; }
        STC ServiceLineStatusInformation { get; }
        REF ServiceLineItemIdentification { get; }
        DTP ServiceLineDate { get; }
    }

    [ProtoBuf.ProtoContract]
    public interface ILoop2100SubDepName
    {
        NM1 SubDepName { get; }
    }

    [ProtoBuf.ProtoContract]
    public interface ILoop2000SubDepLevel
    {
        HL SubDepLevel { get; }

        ILoop2100SubDepName Loop2100 { get; }

        IEnumerable<ILoop2200SubDepDetailBase> Loop2200 { get; }
    }

    [ProtoBuf.ProtoContract]
    public class Loop2000D : ILoop2000SubDepLevel
    {
        [ProtoBuf.ProtoMember(1)]
        public HL SubscriberLevel;

        //        [ProtoBuf.ProtoMember(2)]
        public string SubscriberLevelQaulifier = "22";

        [ProtoBuf.ProtoMember(3)]
        public Loop2100D Loop2100D;

        [ProtoBuf.ProtoMember(4)]
        public LoopList<Loop2200D> Loop2200D = new LoopList<Loop2200D>();

        [ProtoBuf.ProtoIgnore]
        public HL SubDepLevel { get { return SubscriberLevel; } }

        [ProtoBuf.ProtoIgnore]
        public string SubDepLevelQualifier { get { return SubscriberLevelQaulifier; } }

        [ProtoBuf.ProtoIgnore]
        public ILoop2100SubDepName Loop2100 { get { return Loop2100D; } }

        [ProtoBuf.ProtoIgnore]
        public IEnumerable<ILoop2200SubDepDetailBase> Loop2200 { get { return Loop2200D; } }
    }

    [ProtoBuf.ProtoContract]
    public class Loop2100D : ILoop2100SubDepName
    {
        [ProtoBuf.ProtoMember(1)]
        public NM1 SubscriberName;

        //       [ProtoBuf.ProtoMember(2)]
        public string SubscriberNameQaulifier = "IL";


        [ProtoBuf.ProtoIgnore]
        public NM1 SubDepName { get { return SubscriberName; } }

        [ProtoBuf.ProtoIgnore]
        public string SubDepQaulifier { get { return SubscriberNameQaulifier; } }
    }

    [ProtoBuf.ProtoContract]
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

        [ProtoBuf.ProtoMember(1)]
        public TRN ClaimStatusTrackingNumber { get; set; }
        [ProtoBuf.ProtoMember(3)]
        public STC ClaimLevelStatusInformation { get; set; }
        [ProtoBuf.ProtoMember(5)]
        public REF PayerClaimControlNumber { get; set; }
        [ProtoBuf.ProtoMember(7)]
        public REF InstitutionalBillTypeIdentification { get; set; }
        [ProtoBuf.ProtoMember(9)]
        public REF PatientControlNumber { get; set; }
        [ProtoBuf.ProtoMember(11)]
        public REF PharmacyPrescriptionNumber { get; set; }
        [ProtoBuf.ProtoMember(13)]
        public REF VoucherIdentifier { get; set; }
        [ProtoBuf.ProtoMember(15)]
        public REF ClaimIdentificationNumberForClearinghousesAnd { get; set; }
        [ProtoBuf.ProtoMember(17)]
        public DTP ClaimServiceDate { get; set; }

        [ProtoBuf.ProtoMember(19)]
        public LoopList<Loop2220D> Loop2220D = new LoopList<Loop2220D>();


        [ProtoBuf.ProtoIgnore]
        public IEnumerable<ILoop2220ServiceLineBase> Loop2220 { get { return Loop2220D; } }
    }

    [ProtoBuf.ProtoContract]
    public class Loop2220D : ILoop2220ServiceLineBase
    {
        public const string ServiceLineInformationQaulifier = "AD,ER,HC,HP,IV,N4,NU,WK";
        public const string ServiceLineStatusInformationQaulifier = "03 ,13 ,17 ,1E ,1G ,1H ,1I ,1O ,1P ,1Q ,1R ,1S ,1T ,1U ,1V ,1W ,1X ,1Y ,1Z ,28 ,2A ,2B ,2D ,2E ,2I ,2K ,2P ,2Q ,2S ,2Z ,30 ,36 ,3A ,3C ,3D ,3E ,3F ,3G ,3H ,3I ,3J ,3K ,3L ,3M ,3N ,3O ,3P ,3Q ,3R ,3S ,3T ,3U ,3V ,3W ,3Y ,3Z ,40 ,43 ,44 ,4A ,4B ,4C ,4D ,4E ,4F ,4G ,4H ,4I ,4J ,4L ,4M ,4N ,4O ,4P ,4Q ,4R ,4S ,4U ,4V ,4W ,4X ,4Y ,4Z ,5A ,5B ,5C ,5D ,5E ,5F ,5G ,5H ,5I ,5J ,5K ,5L ,5N ,5O ,5P ,5Q ,5R ,5S ,5T ,5U ,5V ,5W ,5X ,5Y ,5Z ,61 ,6A ,6B ,6C ,6D ,6E ,6F ,6G ,6H ,6I ,6J ,6K ,6L ,6M ,6N ,6O ,6P ,6Q ,6R ,6S ,6U ,6V ,6W ,6X ,6Y ,71 ,72 ,73 ,74 ,7C ,80 ,82 ,84 ,85 ,87 ,95 ,CK ,CZ ,D2 ,DD ,DJ ,DK ,DN ,DO ,DQ ,E1 ,E2 ,E7 ,E9 ,FA ,FD ,FE ,G0 ,G3 ,GB ,GD ,GI ,GJ ,GK ,GM ,GY ,HF ,HH ,I3 ,IJ ,IL ,IN ,LI ,LR ,MR ,MSC,OB ,OD ,OX ,P0 ,P2 ,P3 ,P4 ,P6 ,P7 ,PRP,PT ,PV ,PW ,QA ,QB ,QC ,QD ,QE ,QH ,QK ,QL ,QN ,QO ,QS ,QV ,QY ,RC ,RW ,S4 ,SEP,SJ ,SU ,T4 ,TL ,TQ ,TT ,TTP,TU ,UH ,X3 ,X5 ,ZZ";
        public const string ServiceLineItemIdentificationQaulifier = "FJ";
        public const string ServiceLineDateQaulifier = "472";

        [ProtoBuf.ProtoMember(1)]
        public SVC ServiceLineInformation { get; set; }
        [ProtoBuf.ProtoMember(3)]
        public STC ServiceLineStatusInformation { get; set; }
        [ProtoBuf.ProtoMember(5)]
        public REF ServiceLineItemIdentification { get; set; }
        [ProtoBuf.ProtoMember(7)]
        public DTP ServiceLineDate { get; set; }
    }
    [ProtoBuf.ProtoContract]
    public class Loop2000E : ILoop2000SubDepLevel
    {
        public const string DependentLevelQaulifier = "23";

        [ProtoBuf.ProtoMember(1)]
        public HL DependentLevel;

        [ProtoBuf.ProtoMember(3)]
        public Loop2100E Loop2100E;
        [ProtoBuf.ProtoMember(4)]
        public LoopList<Loop2200E> Loop2200E = new LoopList<Loop2200E>();


        [ProtoBuf.ProtoIgnore]
        public HL SubDepLevel { get { return DependentLevel; } }

        [ProtoBuf.ProtoIgnore]
        public ILoop2100SubDepName Loop2100 { get { return Loop2100E; } }

        [ProtoBuf.ProtoIgnore]
        public IEnumerable<ILoop2200SubDepDetailBase> Loop2200 { get { return Loop2200E; } }
    }
    [ProtoBuf.ProtoContract]
    public class Loop2100E : ILoop2100SubDepName
    {
        public const string DependentNameQaulifier = "QC";

        [ProtoBuf.ProtoMember(1)]
        public NM1 DependentName;

        [ProtoBuf.ProtoIgnore]
        public NM1 SubDepName { get { return DependentName; } }
    }
    [ProtoBuf.ProtoContract]
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

        [ProtoBuf.ProtoMember(1)]
        public TRN ClaimStatusTrackingNumber { get; set; }
        [ProtoBuf.ProtoMember(3)]
        public STC ClaimLevelStatusInformation { get; set; }
        [ProtoBuf.ProtoMember(5)]
        public REF PayerClaimControlNumber { get; set; }
        [ProtoBuf.ProtoMember(7)]
        public REF InstitutionalBillTypeIdentification { get; set; }
        [ProtoBuf.ProtoMember(9)]
        public REF PatientControlNumber { get; set; }
        [ProtoBuf.ProtoMember(11)]
        public REF PharmacyPrescriptionNumber { get; set; }
        [ProtoBuf.ProtoMember(13)]
        public REF VoucherIdentifier { get; set; }
        [ProtoBuf.ProtoMember(15)]
        public REF ClaimIdentificationNumberForClearinghousesAnd { get; set; }
        [ProtoBuf.ProtoMember(17)]
        public DTP ClaimServiceDate { get; set; }

        [ProtoBuf.ProtoMember(19)]
        public LoopList<Loop2220E> Loop2220E = new LoopList<Loop2220E>();

        [ProtoBuf.ProtoIgnore]
        public IEnumerable<ILoop2220ServiceLineBase> Loop2220 { get { return Loop2220E; } }
    }

    [ProtoBuf.ProtoContract]
    public class Loop2220E : ILoop2220ServiceLineBase
    {
        public string ServiceLineDateQaulifier = "472";
        public string ServiceLineInformationQaulifier = "AD,ER,HC,HP,IV,N4,NU,WK";
        public string ServiceLineStatusInformationQaulifier = "03 ,13 ,17 ,1E ,1G ,1H ,1I ,1O ,1P ,1Q ,1R ,1S ,1T ,1U ,1V ,1W ,1X ,1Y ,1Z ,28 ,2A ,2B ,2D ,2E ,2I ,2K ,2P ,2Q ,2S ,2Z ,30 ,36 ,3A ,3C ,3D ,3E ,3F ,3G ,3H ,3I ,3J ,3K ,3L ,3M ,3N ,3O ,3P ,3Q ,3R ,3S ,3T ,3U ,3V ,3W ,3Y ,3Z ,40 ,43 ,44 ,4A ,4B ,4C ,4D ,4E ,4F ,4G ,4H ,4I ,4J ,4L ,4M ,4N ,4O ,4P ,4Q ,4R ,4S ,4U ,4V ,4W ,4X ,4Y ,4Z ,5A ,5B ,5C ,5D ,5E ,5F ,5G ,5H ,5I ,5J ,5K ,5L ,5N ,5O ,5P ,5Q ,5R ,5S ,5T ,5U ,5V ,5W ,5X ,5Y ,5Z ,61 ,6A ,6B ,6C ,6D ,6E ,6F ,6G ,6H ,6I ,6J ,6K ,6L ,6M ,6N ,6O ,6P ,6Q ,6R ,6S ,6U ,6V ,6W ,6X ,6Y ,71 ,72 ,73 ,74 ,7C ,80 ,82 ,84 ,85 ,87 ,95 ,CK ,CZ ,D2 ,DD ,DJ ,DK ,DN ,DO ,DQ ,E1 ,E2 ,E7 ,E9 ,FA ,FD ,FE ,G0 ,G3 ,GB ,GD ,GI ,GJ ,GK ,GM ,GY ,HF ,HH ,I3 ,IJ ,IL ,IN ,LI ,LR ,MR ,MSC,OB ,OD ,OX ,P0 ,P2 ,P3 ,P4 ,P6 ,P7 ,PRP,PT ,PV ,PW ,QA ,QB ,QC ,QD ,QE ,QH ,QK ,QL ,QN ,QO ,QS ,QV ,QY ,RC ,RW ,S4 ,SEP,SJ ,SU ,T4 ,TL ,TQ ,TT ,TTP,TU ,UH ,X3 ,X5 ,ZZ";
        public string ServiceLineItemIdentificationQaulifier = "FJ";

        [ProtoBuf.ProtoMember(1)]
        public SVC ServiceLineInformation { get; set; }
        [ProtoBuf.ProtoMember(3)]
        public STC ServiceLineStatusInformation { get; set; }
        [ProtoBuf.ProtoMember(5)]
        public REF ServiceLineItemIdentification { get; set; }
        [ProtoBuf.ProtoMember(7)]
        public DTP ServiceLineDate { get; set; }

        [ProtoBuf.ProtoMember(9)]
        public SE TransactionSetTrailer;
    }
}

