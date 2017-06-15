using System.Collections.Generic;
using Model.EDI.X12.v2.Base;
using Model.EDI.X12.v2;

namespace Model.EDI.X12.Format277.v5010.v2
{
    public partial class Loop2000ACollection : LoopCollection<Loop2000A>
    {
        public Loop2000ACollection(string loopName, string loopNameDescription, X12Doc owningDoc, int repLimit, LoopCollection parent, LoopCollection prev) 
            : base(loopName, loopNameDescription, owningDoc, repLimit, parent, prev) { }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            SegmentDefinitions.Add(new HL()
            {
                SegmentQualifierValues = new List<SegmentQualifiers>()
            }); 
        }  
    }

    public partial class Loop2000A : LoopEntity
    {
        public HlCollection InformationSourceLevel;
        
        public Loop2100ACollection PayerName;

        public Loop2000A(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc, prev, parent)
        {
            InformationSourceLevel = new HlCollection(this);
            
            PayerName = new Loop2100ACollection("Loop2100A", nameof(PayerName), OwningDoc, 1,parent, parent );
        }
    }

    public partial class Loop2100ACollection : LoopCollection<Loop2100A>
    {
        public Loop2100ACollection(string loopName, string loopNameDescription, X12Doc owningDoc, int repLimit, LoopCollection parent, LoopCollection prev) : base(loopName, loopNameDescription, owningDoc, repLimit, parent, prev) { }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        }
    }

    public partial class Loop2100A : LoopEntity
    {
        public Nm1Collection InformationSourceName;
        
        public Loop2100A(X12Doc owningDoc, LoopEntity prev, LoopCollection parent):base(owningDoc,prev,parent)
        { 
        } 
    }

    //#region other loops 
    //public partial class Loop2000BCollection : LoopCollection<Loop2000B>
    //{
    //    public Loop2000BCollection(string loopName, string loopNameDescription, X12Doc owningDoc) : base(loopName, loopNameDescription, owningDoc) { }
        


    //    public override bool Validate()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void SetUpDefinition(LoopCollection parentLoopCollection)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}

    //public partial class Loop2000B : LoopEntity
    //{
    //    public HlCollection InformationReceiverLevel;

    //    public Loop2100BCollection InformationReceiverNameLoop = new Loop2100BCollection("Loop2100B", "InformationReceiverNameLoop");
    //    public Loop2200BCollection InformationReiverApplicationTraceIdentifierLoop = new Loop2200BCollection("Loop2200B", "InformationReiverApplicationTraceIdentifierLoop");
    //}


    //public partial class Loop2100BCollection : LoopCollection<Loop2100B>
    //{
    //    public Loop2100BCollection(string loopName, string loopNameDescription, X12Doc owningDoc) : base(loopName, loopNameDescription, owningDoc) { }

    //    public override bool Validate()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void SetUpDefinition(LoopCollection parentLoopCollection)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}

    //public partial class Loop2100B : LoopEntity
    //{
    //    public Nm1Collection InformationReceiverName;
    //}


    //public partial class Loop2200BCollection : LoopCollection<Loop2200B>
    //{
    //    public Loop2200BCollection(string loopName, string loopNameDescription, X12Doc owningDoc) : base(loopName, loopNameDescription, owningDoc) { }

    //    public override bool Validate()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void SetUpDefinition(LoopCollection parentLoopCollection)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}

    //public partial class Loop2200B : LoopEntity
    //{
    //    public TrnCollection InformationReceiverApplicationTraceIdentifier;
    //    public StcCollection InformationReceiverStatusInformation;
    //    public QtyCollection TotalAcceptedQuantity;
    //    public QtyCollection TotalRejectedQuantity;
    //    public AmtCollection TotalAcceptedAmount;
    //    public AmtCollection TotlaRejectedAmount;
    //}

    //public partial class Loop2000CCollection : LoopCollection<Loop2000C>
    //{
    //    public Loop2000CCollection(string loopName, string loopNameDescription, X12Doc owningDoc) : base(loopName, loopNameDescription, owningDoc) { }

    //    public override bool Validate()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void SetUpDefinition(LoopCollection parentLoopCollection)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}

    //public partial class Loop2000C : LoopEntity
    //{
    //    public HlCollection BillingProviderOfServiceLevel;
    //    public Loop2100CCollection ProviderName = new Loop2100CCollection("Loop2100C", "ProviderName");
    //    public Loop2200CCollection ProviderOfServiceTraceIdentifier = new Loop2200CCollection("Loop2200C", "ProviderOfServiceTraceIdentifier");

    //}
    //public partial class Loop2100CCollection : LoopCollection<Loop2100C>
    //{
    //    public Loop2100CCollection(string loopName, string loopNameDescription, X12Doc owningDoc) : base(loopName, loopNameDescription, owningDoc) { }

    //    public override bool Validate()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void SetUpDefinition(LoopCollection parentLoopCollection)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}

    //public partial class Loop2100C : LoopEntity
    //{
    //    public Nm1Collection BillingProviderName; 
    //}

    //public partial class Loop2200CCollection : LoopCollection<Loop2200C>
    //{
    //    public Loop2200CCollection(string loopName, string loopNameDescription, X12Doc owningDoc) : base(loopName, loopNameDescription, owningDoc) { }

    //    public override bool Validate()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void SetUpDefinition(LoopCollection parentLoopCollection)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}
    //public partial class Loop2200C : LoopEntity
    //{
    //    public TrnCollection ProviderOfServiceInformationTraceIdentifier;
    //    public StcCollection BillingProviderStatusInformation;
    //    public RefCollection ProviderSecondaryIdentifier;
    //    public QtyCollection TotalAcceptedQuantity;
    //    public QtyCollection TotalRejectedQuantity;
    //    public AmtCollection TotalAcceptedAmount;
    //    public AmtCollection TotlaRejectedAmount;
    //}

    //public partial class Loop2000DECollection : LoopCollection<Loop2000DE>
    //{
    //    public Loop2000DECollection(string loopName, string loopNameDescription, X12Doc owningDoc) : base(loopName, loopNameDescription, owningDoc) { }

    //    public override bool Validate()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void SetUpDefinition(LoopCollection parentLoopCollection)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}

    //public partial class Loop2000DE : LoopEntity
    //{
    //    public HlCollection SubDepLevel;

    //    public Loop2100DECollection SubDepName = new Loop2100DECollection("Loop2200DE","SubDepName");

    //    public Loop2200DECollection ClaimStatusTrackingNumber = new Loop2200DECollection("Loop2200DE","ClaimsStatusTrackingNumber"); 
    //}

    //public partial class Loop2100DECollection : LoopCollection<Loop2100DE>
    //{
    //    public Loop2100DECollection(string loopName, string loopNameDescription, X12Doc owningDoc) : base(loopName, loopNameDescription, owningDoc) { }

    //    public override bool Validate()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void SetUpDefinition(LoopCollection parentLoopCollection)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}

    //public partial class Loop2100DE : LoopEntity
    //{
    //    public Nm1Collection SubDepName;
    //}

    //public partial class Loop2200DECollection : LoopCollection<Loop2200DE>
    //{
    //    public Loop2200DECollection(string loopName, string loopNameDescription, X12Doc owningDoc) : base(loopName, loopNameDescription, owningDoc) { }

    //    public override bool Validate()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void SetUpDefinition(LoopCollection parentLoopCollection)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}

    //public partial class Loop2200DE : LoopEntity
    //{
    //    TrnCollection ClaimStatusTrackingNumber;
    //    StcCollection ClaimLevelStatusInformation;
    //    RefCollection PayerClaimControlNumber;
    //    RefCollection InstitutionalBillTypeIdentification;
    //    RefCollection PatientControlNumber;
    //    RefCollection PharmacyPrescriptionNumber;
    //    RefCollection VoucherIdentifier;
    //    RefCollection ClaimIdentificationNumberForClearinghousesAnd;
    //    DtpCollection ClaimServiceDate;

    //    Loop2220DECollection ServiceLineInformation = new Loop2220DECollection("Loop2220DE", "ServiceLineInformation");
    //}

    //public partial class Loop2220DECollection : LoopCollection<Loop2220DE>
    //{
    //    public Loop2220DECollection(string loopName, string loopNameDescription, X12Doc owningDoc) : base(loopName, loopNameDescription, owningDoc) { }

    //    public override bool Validate()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void SetUpDefinition(LoopCollection parentLoopCollection)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}

    //public partial class Loop2220DE : LoopEntity
    //{
    //    public SvcCollection ServiceLineInformation;
    //    public StcCollection ServiceLineStatusInformation;
    //    public RefCollection ServiceLineItemIdentification;
    //    public DtpCollection ServiceLineDate; 
    //}
    //#endregion
}
