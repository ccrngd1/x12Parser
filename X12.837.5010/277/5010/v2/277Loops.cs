using Model.EDI.X12.v2.Base;
using Model.EDI.X12.v2;

namespace Model.EDI.X12.Format277.v5010.v2
{
    public partial class Loop2000ACollection : LoopCollection<Loop2000A>
    {
        public Loop2000ACollection()
        {
            Definition = new LoopDefinition(999);
            Definition.ParentLoop = null;
            Definition.ParentLoopCollection = null;
            //Definition.SubLoops
        }
        
        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        } 
    }

    public partial class Loop2000A : LoopEntity
    {
        public HlCollection InformationSourceLevel = new HlCollection();

        public Loop2100ACollection loop2100a = new Loop2100ACollection(); 
    }

    public partial class Loop2100ACollection : LoopCollection<Loop2100A>
    {
        public Loop2100ACollection() { }

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

        public Loop2100A()
        {
        }
    }

    public partial class Loop2200ACollection : LoopCollection<Loop2200A>
    {
        public Loop2200ACollection() { }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        }
    }

    public partial class Loop2200A : LoopEntity
    {
        public TrnCollection TransmissionReceiptControlIdentifier;
        public DtpCollection InformationSourceReceiptDate;
        public DtpCollection InformationSourceProcessDate;
    }


    public partial class Loop2000BCollection : LoopCollection<Loop2000B>
    {
        public Loop2000BCollection() { }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        }
    }

    public partial class Loop2000B : LoopEntity
    {
        public HlCollection InformationReceiverLevel;

        public Loop2100BCollection InformationReceiverNameLoop = new Loop2100BCollection();
        public Loop2200BCollection InformationReiverApplicationTraceIdentifierLoop = new Loop2200BCollection();
    }


    public partial class Loop2100BCollection : LoopCollection<Loop2100B>
    {
        public Loop2100BCollection() { }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        }
    }

    public partial class Loop2100B : LoopEntity
    {
        public Nm1Collection InformationReceiverName;
    }


    public partial class Loop2200BCollection : LoopCollection<Loop2200B>
    {
        public Loop2200BCollection() { }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        }
    }

    public partial class Loop2200B : LoopEntity
    {
        public TrnCollection InformationReceiverApplicationTraceIdentifier;
        public StcCollection InformationReceiverStatusInformation;
        public QtyCollection TotalAcceptedQuantity;
        public QtyCollection TotalRejectedQuantity;
        public AmtCollection TotalAcceptedAmount;
        public AmtCollection TotlaRejectedAmount;
    }

    public partial class Loop2000CCollection : LoopCollection<Loop2000C>
    {
        public Loop2000CCollection() { }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        }
    }

    public partial class Loop2000C : LoopEntity
    {
        public HlCollection BillingProviderOfServiceLevel;
        public Loop2100CCollection loop2100c = new Loop2100CCollection();
        public Loop2200CCollection loop2200c = new Loop2200CCollection();

    }
    public partial class Loop2100CCollection : LoopCollection<Loop2100C>
    {
        public Loop2100CCollection() { }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        }
    }

    public partial class Loop2100C : LoopEntity
    {
        public Nm1Collection BillingProviderName; 
    }

    public partial class Loop2200CCollection : LoopCollection<Loop2200C>
    {
        public Loop2200CCollection() { }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        }
    }
    public partial class Loop2200C : LoopEntity
    {
        public TrnCollection ProviderOfServiceInformationTraceIdentifier;
        public StcCollection BillingProviderStatusInformation;
        public RefCollection ProviderSecondaryIdentifier;
        public QtyCollection TotalAcceptedQuantity;
        public QtyCollection TotalRejectedQuantity;
        public AmtCollection TotalAcceptedAmount;
        public AmtCollection TotlaRejectedAmount;
    }

    public partial class Loop2000DECollection : LoopCollection<Loop2000DE>
    {
        public Loop2000DECollection() { }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        }
    }

    public partial class Loop2000DE : LoopEntity
    {
        public HlCollection SubDepLevel;

        public Loop2100DECollection loop2100DE = new Loop2100DECollection();

        public Loop2200DECollection loop2200DE = new Loop2200DECollection(); 
    }

    public partial class Loop2100DECollection : LoopCollection<Loop2100DE>
    {
        public Loop2100DECollection() { }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        }
    }

    public partial class Loop2100DE : LoopEntity
    {
        public Nm1Collection SubDepName;
    }

    public partial class Loop2200DECollection : LoopCollection<Loop2200DE>
    {
        public Loop2200DECollection() { }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        }
    }

    public partial class Loop2200DE : LoopEntity
    {
        TrnCollection ClaimStatusTrackingNumber;
        StcCollection ClaimLevelStatusInformation;
        RefCollection PayerClaimControlNumber;
        RefCollection InstitutionalBillTypeIdentification;
        RefCollection PatientControlNumber;
        RefCollection PharmacyPrescriptionNumber;
        RefCollection VoucherIdentifier;
        RefCollection ClaimIdentificationNumberForClearinghousesAnd;
        DtpCollection ClaimServiceDate;

        Loop2220DECollection Loop2220 = new Loop2220DECollection();
    }

    public partial class Loop2220DECollection : LoopCollection<Loop2220DE>
    {
        public Loop2220DECollection() { }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        }
    }

    public partial class Loop2220DE : LoopEntity
    {
        public SvcCollection ServiceLineInformation;
        public StcCollection ServiceLineStatusInformation;
        public RefCollection ServiceLineItemIdentification;
        public DtpCollection ServiceLineDate; 
    }

}
