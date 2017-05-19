using System.Collections;
using System.Collections.Generic;
using LawsonCS.Model.EDI.X12.v2.Base;
using LawsonCS.Model.EDI.X12.v2;

namespace LawsonCS.Model.EDI.X12.Format277.v5010.v2
{
    public class Loop2000ACollection : ILoopList<Loop2000A>
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
        public HLCollection InformationSourceLevel = new HLCollection();

        public Loop2100A loop2100a = new Loop2100A(); 
    }

    public class Loop2100ACollection : LoopList
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
        public NM1Collection InformationSourceName; 

        public Loop2100A()
        {
        }
    }

    public class Loop2200ACollection : LoopList
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
        public TRNCollection TransmissionReceiptControlIdentifier;
        public DTPCollection InformationSourceReceiptDate;
        public DTPCollection InformationSourceProcessDate;
    }


    public class Loop2000BCollection : LoopList
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
        public HLCollection InformationReceiverLevel;

        public Loop2100BCollection InformationReceiverNameLoop = new Loop2100BCollection();
        public Loop2200BCollection InformationReiverApplicationTraceIdentifierLoop = new Loop2200BCollection();
    }


    public class Loop2100BCollection : LoopList
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
        public NM1Collection InformationReceiverName;
    }


    public class Loop2200BCollection : LoopList
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
        public TRNCollection InformationReceiverApplicationTraceIdentifier;
        public STCCollection InformationReceiverStatusInformation;
        public QTYCollection TotalAcceptedQuantity;
        public QTYCollection TotalRejectedQuantity;
        public AMTCollection TotalAcceptedAmount;
        public AMTCollection TotlaRejectedAmount;
    }

    public class Loop2000CCollection : LoopList
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
        public HLCollection BillingProviderOfServiceLevel;
        public Loop2100CCollection loop2100c = new Loop2100CCollection();
        public Loop2200CCollection loop2200c = new Loop2200CCollection();

    }
    public class Loop2100CCollection : LoopList
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
        public NM1Collection BillingProviderName; 
    }

    public class Loop2200CCollection : LoopList
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
        public TRNCollection ProviderOfServiceInformationTraceIdentifier;
        public STCCollection BillingProviderStatusInformation;
        public REFCollection ProviderSecondaryIdentifier;
        public QTYCollection TotalAcceptedQuantity;
        public QTYCollection TotalRejectedQuantity;
        public AMTCollection TotalAcceptedAmount;
        public AMTCollection TotlaRejectedAmount;
    }

    public class Loop2000DECollection : LoopList
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
        public HLCollection SubDepLevel;

        public Loop2100DECollection loop2100DE = new Loop2100DECollection();

        public Loop2200DECollection loop2200DE = new Loop2200DECollection(); 
    }

    public class Loop2100DECollection : LoopList
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
        public NM1Collection SubDepName;
    }

    public class Loop2200DECollection : LoopList
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
        TRNCollection ClaimStatusTrackingNumber;
        STCCollection ClaimLevelStatusInformation;
        REFCollection PayerClaimControlNumber;
        REFCollection InstitutionalBillTypeIdentification;
        REFCollection PatientControlNumber;
        REFCollection PharmacyPrescriptionNumber;
        REFCollection VoucherIdentifier;
        REFCollection ClaimIdentificationNumberForClearinghousesAnd;
        DTPCollection ClaimServiceDate;

        Loop2220DECollection Loop2220 = new Loop2220DECollection();
    }

    public class Loop2220DECollection : LoopList
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
        public SVCCollection ServiceLineInformation;
        public STCCollection ServiceLineStatusInformation;
        public REFCollection ServiceLineItemIdentification;
        public DTPCollection ServiceLineDate; 
    }

}
