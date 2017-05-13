using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawsonCS.Model.EDI.X12.v2.Base;
using LawsonCS.Model.EDI.X12.v2;

namespace LawsonCS.Model.EDI.X12.Format277.v5010.v2
{
    public class Loop2000A : LoopEntity
    {
        public baseSegmentCollection<HL> InformationSourceLevel;

        public LoopList<Loop2100A> loop2100a = new LoopList<Loop2100A>(1);

        public Loop2000A() { }
    }

    public class Loop2100A : LoopEntity
    {
        public baseSegmentCollection<NM1> PayerName;
        public baseSegmentCollection<PER> PayerContactInformation;
    }

    public class Loop2000B : LoopEntity
    {
        public baseSegmentCollection<HL> InformationReceiverLeverl;
        public LoopList<Loop2100B> loop2100b = new LoopList<Loop2100B>(1);
        public LoopList<Loop2200B> loop2200b = new LoopList<Loop2200B>(1);
    }

    public class Loop2100B : LoopEntity
    {
        public baseSegmentCollection<NM1> InformationReceiverName;
    }

    public class Loop2200B : LoopEntity
    {
        public baseSegmentCollection<TRN> InformationReceiverTraceIdentifier;
        public baseSegmentCollection<STC> InformationReceriverStatusInformation;
    }

    public class Loop2000C : LoopEntity
    {
        public baseSegmentCollection<HL> ServiceProviderLevel;
        public LoopList<Loop2100C> loop2100c = new LoopList<Loop2100C>(1);
        public LoopList<Loop2200C> loop2200c = new LoopList<Loop2200C>(1);
    }

    public class Loop2100C : LoopEntity
    {
        public baseSegmentCollection<NM1> ProviderName;
    }

    public class Loop2200C : LoopEntity
    {
        public baseSegmentCollection<TRN> ProviderOfServiceTraceIdentifier;
        public baseSegmentCollection<STC> ProviderStatusInformation;
    } 
    
    public class Loop2000DE : LoopEntity
    {
        public baseSegmentCollection<HL> SubDepLevel;

        public LoopList<Loop2100DE> loop2100 = new LoopList<Loop2100DE>(999);

        public LoopList<Loop2200DE> loop2200 = new LoopList<Loop2200DE>(999);
    }

    public class Loop2100DE : LoopEntity
    {
        public baseSegmentCollection<NM1> SubDepName;
    }

    public class Loop2200DE : LoopEntity
    {
        baseSegmentCollection<TRN> ClaimStatusTrackingNumber;
        baseSegmentCollection<STC> ClaimLevelStatusInformation;
        baseSegmentCollection<REF> PayerClaimControlNumber;
        baseSegmentCollection<REF> InstitutionalBillTypeIdentification;
        baseSegmentCollection<REF> PatientControlNumber;
        baseSegmentCollection<REF> PharmacyPrescriptionNumber;
        baseSegmentCollection<REF> VoucherIdentifier;
        baseSegmentCollection<REF> ClaimIdentificationNumberForClearinghousesAnd;
        baseSegmentCollection<DTP> ClaimServiceDate;
        LoopList<Loop2220DE> Loop2220 = new LoopList<Loop2220DE>(999);
    }
    
    public class Loop2220DE : LoopEntity
    {
        public baseSegmentCollection<SVC> ServiceLineInformation;
        public baseSegmentCollection<STC> ServiceLineStatusInformation;
        public baseSegmentCollection<REF> ServiceLineItemIdentification;
        public baseSegmentCollection<DTP> ServiceLineDate;
    }

}
