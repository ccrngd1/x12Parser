using System.Collections;
using System.Collections.Generic;
using LawsonCS.Model.EDI.X12.v2.Base;
using LawsonCS.Model.EDI.X12.v2;

namespace LawsonCS.Model.EDI.X12.Format277.v5010.v2
{
    public class Loop2000ACollection : LoopCollection<Loop2000A>
    {
        public Loop2000ACollection()
        {
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

    public class Loop2000A : LoopEntity
    {
        public HlCollection InformationSourceLevel = new HlCollection();

        public Loop2100A loop2100a = new Loop2100A(); 
    }

    public class Loop2100ACollection : LoopCollection
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

    public class Loop2100A : LoopEntity
    {
        public Nm1Collection InformationSourceName; 

        public Loop2100A()
        {
        }
    }

    public class Loop2200ACollection : LoopCollection
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

    public class Loop2200A : LoopEntity
    {
        public TrnCollection TransmissionReceiptControlIdentifier;
        public DtpCollection InformationSourceReceiptDate;
        public DtpCollection InformationSourceProcessDate;
    }


    public class Loop2000BCollection : LoopCollection
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

    public class Loop2000B : LoopEntity
    {
        public HlCollection InformationReceiverLevel;

        public Loop2100BCollection InformationReceiverNameLoop = new Loop2100BCollection();
        public Loop2200BCollection InformationReiverApplicationTraceIdentifierLoop = new Loop2200BCollection();
    }


    public class Loop2100BCollection : LoopCollection
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

    public class Loop2100B : LoopEntity
    {
        public Nm1Collection InformationReceiverName;
    }


    public class Loop2200BCollection : LoopCollection
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

    public class Loop2200B : LoopEntity
    {
        public TrnCollection InformationReceiverApplicationTraceIdentifier;
        public StcCollection InformationReceiverStatusInformation;
        public QtyCollection TotalAcceptedQuantity;
        public QtyCollection TotalRejectedQuantity;
        public AmtCollection TotalAcceptedAmount;
        public AmtCollection TotlaRejectedAmount;
    }

    public class Loop2000CCollection : LoopCollection
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

    public class Loop2000C : LoopEntity
    {
        public HlCollection BillingProviderOfServiceLevel;
        public Loop2100CCollection loop2100c = new Loop2100CCollection();
        public Loop2200CCollection loop2200c = new Loop2200CCollection();

    }
    public class Loop2100CCollection : LoopCollection
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

    public class Loop2100C : LoopEntity
    {
        public Nm1Collection BillingProviderName; 
    }

    public class Loop2200CCollection : LoopCollection
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
    public class Loop2200C : LoopEntity
    {
        public TrnCollection ProviderOfServiceInformationTraceIdentifier;
        public StcCollection BillingProviderStatusInformation;
        public RefCollection ProviderSecondaryIdentifier;
        public QtyCollection TotalAcceptedQuantity;
        public QtyCollection TotalRejectedQuantity;
        public AmtCollection TotalAcceptedAmount;
        public AmtCollection TotlaRejectedAmount;
    }

    public class Loop2000DECollection : LoopCollection
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

    public class Loop2000DE : LoopEntity
    {
        public HlCollection SubDepLevel;

        public Loop2100DECollection loop2100DE = new Loop2100DECollection();

        public Loop2200DECollection loop2200DE = new Loop2200DECollection(); 
    }

    public class Loop2100DECollection : LoopCollection
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

    public class Loop2100DE : LoopEntity
    {
        public Nm1Collection SubDepName;
    }

    public class Loop2200DECollection : LoopCollection
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

    public class Loop2200DE : LoopEntity
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

    public class Loop2220DECollection : LoopCollection
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

    public class Loop2220DE : LoopEntity
    {
        public SvcCollection ServiceLineInformation;
        public StcCollection ServiceLineStatusInformation;
        public RefCollection ServiceLineItemIdentification;
        public DtpCollection ServiceLineDate; 
    }

}
