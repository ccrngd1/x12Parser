using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EDI.X12.v2;
using Model.EDI.X12.v2.Base;

namespace Model.EDI.X12.Format277.v5010.v2
{


    public partial class Loop2000A : LoopEntity
    {
        public HlCollection InformationSourceLevel { get; set; }

        public Loop2100ACollection PayerNameLoop { get; set; }

        public Loop2000A(X12Doc owningDoc, LoopEntity prev, LoopCollectionBase parent) : base(owningDoc, parent)
        {
            InformationSourceLevel = new HlCollection(this, nameof(InformationSourceLevel));
            SegmentCollections.Add(InformationSourceLevel);

            PayerNameLoop = new Loop2100ACollection("Loop2100A", nameof(PayerNameLoop), owningDoc, parent, parent);
            ChildLoopCollections.Add(PayerNameLoop);
        }
    }

    public partial class Loop2100A : LoopEntity
    {
        public Nm1Collection PayerName { get; set; }
        public PerCollection PayerContactInformation { get; set; }

        public Loop2100A(X12Doc owningDoc, LoopEntity prev, LoopCollectionBase parent) : base(owningDoc, parent)
        {
            PayerName = new Nm1Collection(this, nameof(PayerName));
            SegmentCollections.Add(PayerName);
            PayerContactInformation = new PerCollection(this, nameof(PayerContactInformation));
            SegmentCollections.Add(PayerContactInformation);

        }
    }

    public partial class Loop2000B : LoopEntity
    {
        public HlCollection InformationReceiverLevel { get; set; }

        public Loop2100BCollection InformationRecieverNameLoop { get; set; }
        public Loop2200BCollection InformationReceiverTraceIdentifierLoop { get; set; }

        public Loop2000B(X12Doc owningDoc, LoopEntity prev, LoopCollectionBase parent) : base(owningDoc, parent)
        {
            InformationReceiverLevel = new HlCollection(this, nameof(InformationReceiverLevel));
            SegmentCollections.Add(InformationReceiverLevel);

            InformationRecieverNameLoop = new Loop2100BCollection("Loop2100B", nameof(InformationRecieverNameLoop), owningDoc, parent, parent);
            ChildLoopCollections.Add(InformationRecieverNameLoop);
            InformationReceiverTraceIdentifierLoop = new Loop2200BCollection("Loop2200B", nameof(InformationReceiverTraceIdentifierLoop), owningDoc, parent, parent);
            ChildLoopCollections.Add(InformationReceiverTraceIdentifierLoop);
        }
    }

    public partial class Loop2100B : LoopEntity
    {
        public Nm1Collection InformationReceiverName { get; set; }

        public Loop2100B(X12Doc owningDoc, LoopEntity prev, LoopCollectionBase parent) : base(owningDoc, parent)
        {
            InformationReceiverName = new Nm1Collection(this, nameof(InformationReceiverName));
            SegmentCollections.Add(InformationReceiverName);

        }
    }

    public partial class Loop2200B : LoopEntity
    {
        public TrnCollection InformationReceiverTraceIdentifier { get; set; }
        public StcCollection InformationReceiverStatusInformation { get; set; } 

        public Loop2200B(X12Doc owningDoc, LoopEntity prev, LoopCollectionBase parent) : base(owningDoc, parent)
        {
            InformationReceiverTraceIdentifier = new TrnCollection(this, nameof(InformationReceiverTraceIdentifier));
            SegmentCollections.Add(InformationReceiverTraceIdentifier);
            InformationReceiverStatusInformation =
                new StcCollection(this, nameof(InformationReceiverStatusInformation));
            SegmentCollections.Add(InformationReceiverStatusInformation); 
        }
    }

    public partial class Loop2000C : LoopEntity
    {
        public HlCollection ServiceProviderLevel { get; set; }

        public Loop2100CCollection ProviderNameLoop { get; set; }
        public Loop2200CCollection ProviderOfServiceTraceIdentifierLoop { get; set; }

        public Loop2000C(X12Doc owningDoc, LoopEntity prev, LoopCollectionBase parent) : base(owningDoc, parent)
        {
            ServiceProviderLevel = new HlCollection(this, nameof(ServiceProviderLevel));
            SegmentCollections.Add(ServiceProviderLevel);

            ProviderNameLoop = new Loop2100CCollection("Loop2100C", nameof(ProviderNameLoop), OwningDoc, parent, parent);
            ChildLoopCollections.Add(ProviderNameLoop);
            ProviderOfServiceTraceIdentifierLoop = new Loop2200CCollection("Loop2200C",nameof(ProviderOfServiceTraceIdentifierLoop), OwningDoc, parent, parent);
            ChildLoopCollections.Add(ProviderOfServiceTraceIdentifierLoop);
        }
    }

    public partial class Loop2100C : LoopEntity
    {
        public Nm1Collection ProviderName { get; set; }

        public Loop2100C(X12Doc owningDoc, LoopEntity prev, LoopCollectionBase parent) : base(owningDoc, parent)
        {
            ProviderName = new Nm1Collection(this, nameof(ProviderName));
            SegmentCollections.Add(ProviderName);

        }
    }

    public partial class Loop2200C : LoopEntity
    {
        public TrnCollection ProviderOfServiceTraceIdentifier { get; set; }
        public StcCollection ProviderStatusInformation { get; set; }  

        public Loop2200C(X12Doc owningDoc, LoopEntity prev, LoopCollectionBase parent) : base(owningDoc, parent)
        {
            ProviderOfServiceTraceIdentifier = new TrnCollection(this, nameof(ProviderOfServiceTraceIdentifier));
            SegmentCollections.Add(ProviderOfServiceTraceIdentifier);
            ProviderStatusInformation = new StcCollection(this, nameof(ProviderStatusInformation));
            SegmentCollections.Add(ProviderStatusInformation);
        }
    }

    public partial class Loop2000D : LoopEntity
    {
        public HlCollection SubscriberLevel { get; set; }
        public Loop2100DCollection SubscriberNameLoop { get; set; }
        public Loop2200DCollection ClaimStatusTrackingNumberLoop { get; set; }

        public Loop2000D(X12Doc owningDoc, LoopEntity prev, LoopCollectionBase parent) : base(owningDoc, parent)
        {
            SubscriberLevel = new HlCollection(this, nameof(SubscriberLevel));
            SegmentCollections.Add(SubscriberLevel);
            
            SubscriberNameLoop = new Loop2100DCollection("Loop2100D", nameof(SubscriberNameLoop), OwningDoc, parent,parent);
            ChildLoopCollections.Add(SubscriberNameLoop);
            ClaimStatusTrackingNumberLoop = new Loop2200DCollection("Loop2200D", nameof(ClaimStatusTrackingNumberLoop),OwningDoc, parent, parent);
            ChildLoopCollections.Add(ClaimStatusTrackingNumberLoop);
        }
    }

    public partial class Loop2100D : LoopEntity
    {
        public Nm1Collection SubscriberName { get; set; }

        public Loop2100D(X12Doc owningDoc, LoopEntity prev, LoopCollectionBase parent) : base(owningDoc, parent)
        {
            SubscriberName = new Nm1Collection(this, nameof(SubscriberName));
            SegmentCollections.Add(SubscriberName);
        }
    }

    public partial class Loop2200D : LoopEntity
    {
        public TrnCollection ClaimStatusTrackingNumber { get; set; }
        public StcCollection ClaimLevelStatusInformation { get; set; }
        public RefCollection PayerClaimControlNumber { get; set; }
        public RefCollection InstitutionalBillTypeIdentification { get; set; }
        public RefCollection PatientControlNumber { get; set; }
        public RefCollection PharmacyPrescriptionNumber { get; set; }
        public RefCollection VoucherIdentifier { get; set; }
        public RefCollection ClaimIdentificationNumberForClearinghousesAnd { get; set; }
        public DtpCollection ClaimServiceDate { get; set; }

        public Loop2220DCollection ServiceLineInformationLoop { get; set; }


        public Loop2200D(X12Doc owningDoc, LoopEntity prev, LoopCollectionBase parent) : base(owningDoc, parent)
        {
            ClaimStatusTrackingNumber = new TrnCollection(this, nameof(ClaimStatusTrackingNumber));
            SegmentCollections.Add(ClaimStatusTrackingNumber);
            ClaimLevelStatusInformation = new StcCollection(this, nameof(ClaimLevelStatusInformation));
            SegmentCollections.Add(ClaimLevelStatusInformation);
            PayerClaimControlNumber = new RefCollection(this, nameof(PayerClaimControlNumber));
            SegmentCollections.Add(PayerClaimControlNumber);
            InstitutionalBillTypeIdentification = new RefCollection(this, nameof(InstitutionalBillTypeIdentification));
            SegmentCollections.Add(InstitutionalBillTypeIdentification);
            PatientControlNumber = new RefCollection(this, nameof(PatientControlNumber));
            SegmentCollections.Add(PatientControlNumber);
            PharmacyPrescriptionNumber = new RefCollection(this, nameof(PharmacyPrescriptionNumber));
            SegmentCollections.Add(PharmacyPrescriptionNumber);
            VoucherIdentifier = new RefCollection(this, nameof(VoucherIdentifier));
            SegmentCollections.Add(VoucherIdentifier);
            ClaimIdentificationNumberForClearinghousesAnd =
                new RefCollection(this, nameof(ClaimIdentificationNumberForClearinghousesAnd));
            SegmentCollections.Add(ClaimIdentificationNumberForClearinghousesAnd);
            ClaimServiceDate = new DtpCollection(this, nameof(ClaimServiceDate));
            SegmentCollections.Add(ClaimServiceDate);

            ServiceLineInformationLoop = new Loop2220DCollection("Loop2220D", nameof(ServiceLineInformationLoop),
                OwningDoc, parent, parent);
            ChildLoopCollections.Add(ServiceLineInformationLoop); 
        }
    }

    public partial class Loop2220D : LoopEntity
    {
        public SvcCollection ServiceLineInformation { get; set; }
        public StcCollection ServiceLineStatusInformation { get; set; }
        public RefCollection ServiceLineItemIdentification { get; set; }
        public DtpCollection ServiceLineDate { get; set; }

        public Loop2220D(X12Doc owningDoc, LoopEntity prev, LoopCollectionBase parent) : base(owningDoc, parent)
        {
            ServiceLineInformation = new SvcCollection(this, nameof(ServiceLineInformation));
            SegmentCollections.Add(ServiceLineInformation);
            ServiceLineStatusInformation = new StcCollection(this, nameof(ServiceLineStatusInformation));
            SegmentCollections.Add(ServiceLineStatusInformation);
            ServiceLineItemIdentification = new RefCollection(this, nameof(ServiceLineItemIdentification));
            SegmentCollections.Add(ServiceLineItemIdentification);
            ServiceLineDate = new DtpCollection(this, nameof(ServiceLineDate));
            SegmentCollections.Add(ServiceLineDate);

        }
    }

    public partial class Loop2000E : LoopEntity
    {
        public HlCollection DependentLevel { get; set; }

        public Loop2100ECollection DependentNameLoop { get; set; }
        public Loop2200ECollection ClaimStatusTrackingNumberLoop { get; set; }

        public Loop2000E(X12Doc owningDoc, LoopEntity prev, LoopCollectionBase parent) : base(owningDoc, parent)
        {
            DependentLevel = new HlCollection(this, nameof(DependentLevel));
            SegmentCollections.Add(DependentLevel);

            DependentNameLoop = new Loop2100ECollection("Loop2100E", nameof(DependentNameLoop), OwningDoc, parent,
                parent);
            ChildLoopCollections.Add(DependentNameLoop);
            ClaimStatusTrackingNumberLoop = new Loop2200ECollection("Loop2200E", nameof(ClaimStatusTrackingNumberLoop),
                OwningDoc, parent, parent);
            ChildLoopCollections.Add(ClaimStatusTrackingNumberLoop);
        }
    }

    public partial class Loop2100E : LoopEntity
    {
        public Nm1Collection DependentName { get; set; }

        public Loop2100E(X12Doc owningDoc, LoopEntity prev, LoopCollectionBase parent) : base(owningDoc, parent)
        {
            DependentName = new Nm1Collection(this, nameof(DependentName));
            SegmentCollections.Add(DependentName);

        }
    }

    public partial class Loop2200E : LoopEntity
    {
        public TrnCollection ClaimStatusTrackingNumber { get; set; }
        public StcCollection ClaimLevelStatusInformation { get; set; }
        public RefCollection PayerClaimControlNumber { get; set; }
        public RefCollection InstitutionalBillTypeIdentification { get; set; }
        public RefCollection PatientControlNumber { get; set; }
        public RefCollection PharmacyPrescriptionNumber { get; set; }
        public RefCollection VoucherIdentifier { get; set; }
        public RefCollection ClaimIdentificationNumberForClearinghousesAnd { get; set; }
        public DtpCollection ClaimServiceDate { get; set; }

        public Loop2220ECollection ServiceLineInformationLoop { get; set; }

        public Loop2200E(X12Doc owningDoc, LoopEntity prev, LoopCollectionBase parent) : base(owningDoc, parent)
        {
            ClaimStatusTrackingNumber = new TrnCollection(this, nameof(ClaimStatusTrackingNumber));
            SegmentCollections.Add(ClaimStatusTrackingNumber);
            ClaimLevelStatusInformation = new StcCollection(this, nameof(ClaimLevelStatusInformation));
            SegmentCollections.Add(ClaimLevelStatusInformation);
            PayerClaimControlNumber = new RefCollection(this, nameof(PayerClaimControlNumber));
            SegmentCollections.Add(PayerClaimControlNumber);
            InstitutionalBillTypeIdentification = new RefCollection(this, nameof(InstitutionalBillTypeIdentification));
            SegmentCollections.Add(InstitutionalBillTypeIdentification);
            PatientControlNumber = new RefCollection(this, nameof(PatientControlNumber));
            SegmentCollections.Add(PatientControlNumber);
            PharmacyPrescriptionNumber = new RefCollection(this, nameof(PharmacyPrescriptionNumber));
            SegmentCollections.Add(PharmacyPrescriptionNumber);
            VoucherIdentifier = new RefCollection(this, nameof(VoucherIdentifier));
            SegmentCollections.Add(VoucherIdentifier);
            ClaimIdentificationNumberForClearinghousesAnd =
                new RefCollection(this, nameof(ClaimIdentificationNumberForClearinghousesAnd));
            SegmentCollections.Add(ClaimIdentificationNumberForClearinghousesAnd);
            ClaimServiceDate = new DtpCollection(this, nameof(ClaimServiceDate));
            SegmentCollections.Add(ClaimServiceDate);

            ServiceLineInformationLoop = new Loop2220ECollection("Loop2220E", nameof(ServiceLineInformationLoop),
                OwningDoc, parent, parent);
            ChildLoopCollections.Add(ServiceLineInformationLoop);
        }
    }

    public partial class Loop2220E : LoopEntity
    {
        public SvcCollection ServiceLineInformation { get; set; }
        public StcCollection ServiceLineStatusInformation { get; set; }
        public RefCollection ServiceLineItemIdentification { get; set; }
        public DtpCollection ServiceLineDate { get; set; }
        public SeCollection TransactionSetTrailer { get; set; }

        public Loop2220E(X12Doc owningDoc, LoopEntity prev, LoopCollectionBase parent) : base(owningDoc, parent)
        {
            ServiceLineInformation = new SvcCollection(this, nameof(ServiceLineInformation));
            SegmentCollections.Add(ServiceLineInformation);
            ServiceLineStatusInformation = new StcCollection(this, nameof(ServiceLineStatusInformation));
            SegmentCollections.Add(ServiceLineStatusInformation);
            ServiceLineItemIdentification = new RefCollection(this, nameof(ServiceLineItemIdentification));
            SegmentCollections.Add(ServiceLineItemIdentification);
            ServiceLineDate = new DtpCollection(this, nameof(ServiceLineDate));
            SegmentCollections.Add(ServiceLineDate);
            TransactionSetTrailer = new SeCollection(this, nameof(TransactionSetTrailer));
            SegmentCollections.Add(TransactionSetTrailer);

        }
    }



}