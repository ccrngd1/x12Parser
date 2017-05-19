using System.Collections;
using System.Collections.Generic;
using LawsonCS.Model.EDI.X12.v2.Base;
using LawsonCS.Model.EDI.X12.v2;

namespace LawsonCS.Model.EDI.X12.Format277.v5010.v2
{
    public class Loop2000ACollection : LoopList, IList<Loop2000A>
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

        #region IList
        public IEnumerator<Loop2000A> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Loop2000A item)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(Loop2000A item)
        {
            throw new System.NotImplementedException();
        }

        public void CopyTo(Loop2000A[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(Loop2000A item)
        {
            throw new System.NotImplementedException();
        }

        public int Count { get; }
        public bool IsReadOnly { get; }
        public int IndexOf(Loop2000A item)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(int index, Loop2000A item)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new System.NotImplementedException();
        }

        public Loop2000A this[int index]
        {
            get { return LoopEntities[index] as Loop2000A; }
            set { LoopEntities[index] = value; }
        }
        #endregion
    }

    public class Loop2000A : LoopEntity
    {
        public baseSegmentCollection InformationSourceLevel = new baseSegmentCollection(typeof(HL));

        public Loop2100A loop2100a = new Loop2100A();
    }

    public class Loop2100A : LoopList
    {
        public baseSegmentCollection PayerName;
        public baseSegmentCollection PayerContactInformation;

        public Loop2100A()
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

    public class Loop2000B : LoopList
    {
        public baseSegmentCollection InformationReceiverLeverl;
        public Loop2100B loop2100b = new Loop2100B();
        public Loop2200B loop2200b = new Loop2200B();
        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Loop2100B : LoopList
    {
        public baseSegmentCollection InformationReceiverName;
        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Loop2200B : LoopList
    {
        public baseSegmentCollection InformationReceiverTraceIdentifier;
        public baseSegmentCollection InformationReceriverStatusInformation;
        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Loop2000C : LoopList
    {
        public baseSegmentCollection ServiceProviderLevel;
        public Loop2100C loop2100c = new Loop2100C();
        public Loop2200C loop2200c = new Loop2200C();
        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Loop2100C : LoopList
    {
        public baseSegmentCollection ProviderName;
        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Loop2200C : LoopList
    {
        public baseSegmentCollection ProviderOfServiceTraceIdentifier;
        public baseSegmentCollection ProviderStatusInformation;
        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        }
    } 
    
    public class Loop2000DE : LoopList
    {
        public baseSegmentCollection SubDepLevel;

        public Loop2100DE loop2100 = new Loop2100DE();

        public Loop2200DE loop2200 = new Loop2200DE();
        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Loop2100DE : LoopList
    {
        public baseSegmentCollection SubDepName;
        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Loop2200DE : LoopList
    {
        baseSegmentCollection ClaimStatusTrackingNumber;
        baseSegmentCollection ClaimLevelStatusInformation;
        baseSegmentCollection PayerClaimControlNumber;
        baseSegmentCollection InstitutionalBillTypeIdentification;
        baseSegmentCollection PatientControlNumber;
        baseSegmentCollection PharmacyPrescriptionNumber;
        baseSegmentCollection VoucherIdentifier;
        baseSegmentCollection ClaimIdentificationNumberForClearinghousesAnd;
        baseSegmentCollection ClaimServiceDate;
        Loop2220DE Loop2220 = new Loop2220DE();
        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        }
    }
    
    public class Loop2220DE : LoopList
    {
        public baseSegmentCollection ServiceLineInformation;
        public baseSegmentCollection ServiceLineStatusInformation;
        public baseSegmentCollection ServiceLineItemIdentification;
        public baseSegmentCollection ServiceLineDate;
        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public override void SetUpDefinition()
        {
            throw new System.NotImplementedException();
        }
    }

}
