using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X12.Data;
using X12.Data.Loops;
using ZirMed.Claims.Objects.Transactions;
using ZirMed.Claims.Objects.Transactions.CLP;

namespace X12._837._5010
{
    class LoopToClp
    {
        public static void ConvertGroupStart(Loop loop, BatchData state)
        {
            foreach (var subloop in loop.GetLoops("Segment Start"))
                ConvertSegmentStart(subloop, state);
          
        }
        public static void ConvertSegmentStart(Loop loop, BatchData state)
        {
            if (loop == null) return;           
            state.clp = new clp();
            ConvertHeader(loop.GetLoop("Header"), state);
        }

        private static string InternalDateTimeString(string dateString, string timeString)
        {
            if (dateString.Length == 6)
                dateString = DateTime.Now.Year.ToString().Substring(0, 2) + dateString;//to avoid the dreaded y2k1 assume its in the same centry
            var sb = new StringBuilder();
            if (dateString[4] != '0')
                sb.Append(dateString[4]);
            sb.Append(dateString[5]);
            sb.Append('/');
            if (dateString[6] != '0')
                sb.Append(dateString[6]);
            sb.Append(dateString[7]);
            sb.Append('/');
            sb.Append(dateString.Substring(0, 4));
            sb.Append(' ');
            sb.Append(timeString[0]);
            sb.Append(timeString[1]);
            sb.Append(':');
            sb.Append(timeString[2]);
            sb.Append(timeString[3]);
            sb.Append(':');
            if (timeString.Length == 4)
            {
                sb.Append("00");
            }
            else
            {
                if (timeString.Length >= 6)
                {
                    sb.Append(timeString[4]);
                    sb.Append(timeString[5]);
                }
                if (timeString.Length > 6)
                {
                    sb.Append('.');
                    for (int i = 6; i < timeString.Length; i++)
                        sb.Append(timeString[i]);
                }

            }
            return sb.ToString();
          
        }
        public static void ConvertHeader(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var bht = loop.GetElement(0) as BHT;
            state.clp.header = new header();
            state.clp.header.transtype = bht.TransactionTypeCode;
            state.clp.header.origsubdate = InternalDateTimeString(bht.Date, bht.Time);

            Convert1000A(loop.GetLoop("1000A"), state);
            Convert1000B(loop.GetLoop("1000B"), state);
            ///hmmmmmm think it should be 2000B as child of 2000A
            var clp = state.clp.Clone();
            foreach (var subloop in loop.GetLoops("2000A"))
            {
                state.clp = clp.Clone();
                Convert2000A(subloop, state);
            }
          
        }
        public static void Convert1000A(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var name = loop.GetElement(0) as NM1;
            var perContact = loop.GetElement(1) as PER;

            if (state.clp.bill == null)
                state.clp.bill = new bill();
            state.clp.bill.entitytype =  name.EntityIdentifierCode;
            state.clp.bill.lname = name.LastName;
            state.clp.bill.fname = name.FirstName;
            state.clp.bill.mname = name.MiddleName;
            state.clp.bill.suffix = name.NameSuffix;
            state.clp.bill.npi = name.IdCode;

            if(perContact!=null)
            {
                state.clp.bill.contact = new List<contact>();
                state.clp.bill.contact.Add( PERToContact(perContact));                
            }
        }

        public static contact PERToContact(PER perContact)
        {
            var contact = new contact { name = perContact.Name, contactnum = new List<contactnum>() };
            if (perContact.CommunicationNumberQualifier != null)
            {
                if (perContact.CommunicationNumberQualifier == "EX")
                {
                    var phone = contact.contactnum.FirstOrDefault(a => a.qual == "TE");
                    if (phone != null)
                        phone.ext = perContact.CommunicationNumber;
                }
                else
                    contact.contactnum.Add(new contactnum
                    {
                        qual = perContact.CommunicationNumberQualifier,
                        num = perContact.CommunicationNumber
                    });
                if (perContact.CommunicationNumberQualifier2 != null)
                {
                    if (perContact.CommunicationNumberQualifier2 == "EX")
                    {
                        var phone = contact.contactnum.FirstOrDefault(a => a.qual == "TE");
                        if (phone != null)
                            phone.ext = perContact.CommunicationNumber2;
                    }
                    else
                        contact.contactnum.Add(new contactnum
                        {
                            qual = perContact.CommunicationNumberQualifier2,
                            num = perContact.CommunicationNumber2
                        });
                    if (perContact.CommunicationNumberQualifier3 != null)
                    {
                        if (perContact.CommunicationNumberQualifier3 == "EX")
                        {
                            var phone = contact.contactnum.FirstOrDefault(a => a.qual == "TE");
                            if (phone != null)
                                phone.ext = perContact.CommunicationNumber3;
                        }
                        else
                            contact.contactnum.Add(new contactnum
                            {
                                qual = perContact.CommunicationNumberQualifier3,
                                num = perContact.CommunicationNumber3
                            });
                    }
                }
            }
            return contact;
        }
        public static void Convert1000B(Loop loop, BatchData state)
        {
            //TODO:  dont think we do anything since we break out the reciever when we outbound. 
        }
        public static void Convert2000A(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var specialtyInfo = loop.GetElement(1) as PRV;
            if (specialtyInfo != null)
            {
                if (state.clp.bill == null)
                    state.clp.bill = new bill();
                state.clp.bill.taxonomy = specialtyInfo.ReferenceIdentification;
            }
            var currency = loop.GetElement(2) as CUR;
            if (currency != null)
            {
                if (state.clp.bill == null)
                    state.clp.bill = new bill();
                state.clp.bill.currencycode = currency.CurrencyCode;
            }
            Convert2010AA(loop.GetLoop("2010AA"), state);
            Convert2010AB(loop.GetLoop("2010AB"), state);
            Convert2010AC(loop.GetLoop("2010AC"), state);

            var clp = state.clp.Clone();
            foreach (var subloop in loop.GetLoops("2000B"))
            {
                state.clp = clp.Clone();
                Convert2000B(subloop, state);
            }
        }
        public static void Convert2010AA(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var name = loop.GetElement(0) as NM1;
            if (name != null)
            {
                if (state.clp.bill == null)
                    state.clp.bill = new bill();
                state.clp.bill.entitytype = name.EntityTypeQualifier;
                state.clp.bill.lname = name.LastName;
                state.clp.bill.fname = name.FirstName;
                state.clp.bill.mname = name.MiddleName;
                state.clp.bill.suffix = name.NameSuffix;
                state.clp.bill.npi = name.IdCode;
            }
            var address = loop.GetElement(1) as N3;
            if (address != null)
            {
                if (state.clp.bill == null)
                    state.clp.bill = new bill();
                state.clp.bill.add1 = address.AddressLine1;
                state.clp.bill.add2 = address.AddressLine2;
            }
            var location = loop.GetElement(2) as N4;
            if (location != null)
            {
                if (state.clp.bill == null)
                    state.clp.bill = new bill();
                state.clp.bill.city = location.City;
                state.clp.bill.state = location.State;
                state.clp.bill.zip = location.PostalCode;
                state.clp.bill.country = location.CountryCode;
                state.clp.bill.countrysub = location.CountrySubCode;
            }
            var contactInfos = loop.GetElements(5) as PER[];
            if (contactInfos != null)
                foreach (var contactInfo in contactInfos)
                {
                    if (state.clp.bill.contact == null)
                        state.clp.bill.contact = new List<contact>();
                    state.clp.bill.contact.Add(new contact());
                    state.clp.bill.contact[state.clp.bill.contact.Count - 1].name = contactInfo.Name;
                    if (state.clp.bill.contact[state.clp.bill.contact.Count - 1].contactnum == null)
                        state.clp.bill.contact[state.clp.bill.contact.Count - 1].contactnum = new List<contactnum>();
                    state.clp.bill.contact[state.clp.bill.contact.Count - 1].contactnum.Add(new contactnum());
                    state.clp.bill.contact[state.clp.bill.contact.Count - 1].contactnum[state.clp.bill.contact[state.clp.bill.contact.Count - 1].contactnum.Count - 1].qual = contactInfo.CommunicationNumberQualifier;
                    state.clp.bill.contact[state.clp.bill.contact.Count - 1].contactnum[state.clp.bill.contact[state.clp.bill.contact.Count - 1].contactnum.Count - 1].num = contactInfo.CommunicationNumber;
                    state.clp.bill.contact[state.clp.bill.contact.Count - 1].contactnum[state.clp.bill.contact[state.clp.bill.contact.Count - 1].contactnum.Count - 1].qual = contactInfo.CommunicationNumberQualifier2;
                    state.clp.bill.contact[state.clp.bill.contact.Count - 1].contactnum[state.clp.bill.contact[state.clp.bill.contact.Count - 1].contactnum.Count - 1].num = contactInfo.CommunicationNumber2;
                    state.clp.bill.contact[state.clp.bill.contact.Count - 1].contactnum[state.clp.bill.contact[state.clp.bill.contact.Count - 1].contactnum.Count - 1].qual = contactInfo.CommunicationNumberQualifier3;
                    state.clp.bill.contact[state.clp.bill.contact.Count - 1].contactnum[state.clp.bill.contact[state.clp.bill.contact.Count - 1].contactnum.Count - 1].num = contactInfo.CommunicationNumber3;
                }
        }
        public static void Convert2010AB(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var name = loop.GetElement(0) as NM1;
            if (name != null)
            {
                if (state.clp.payto == null)
                    state.clp.payto = new payto();
                state.clp.payto.entitytype = Convert.ToSByte(name.EntityTypeQualifier);
            }
            var address = loop.GetElement(1) as N3;
            if (address != null)
            {
                if (state.clp.payto == null)
                    state.clp.payto = new payto();
                state.clp.payto.add1 = address.AddressLine1;
                state.clp.payto.add2 = address.AddressLine2;
            }
            var location = loop.GetElement(2) as N4;
            if (location != null)
            {
                if (state.clp.payto == null)
                    state.clp.payto = new payto();
                state.clp.payto.city = location.City;
                state.clp.payto.state = location.State;
                state.clp.payto.zip = location.PostalCode;
                state.clp.payto.country = location.CountryCode;
                state.clp.payto.countrysub = location.CountrySubCode;
            }
        }
        public static void Convert2010AC(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var name = loop.GetElement(0) as NM1;
            if (name != null)
            {
                if (state.clp.paytoplan == null)
                    state.clp.paytoplan = new paytoplan();
                state.clp.paytoplan.lname = name.LastName;
            }
            var address = loop.GetElement(1) as N3;
            if (address != null)
            {
                if (state.clp.paytoplan == null)
                    state.clp.paytoplan = new paytoplan();
                state.clp.paytoplan.add1 = address.AddressLine1;
                state.clp.paytoplan.add2 = address.AddressLine2;
            }
            var location = loop.GetElement(2) as N4;
            if (location != null)
            {
                if (state.clp.paytoplan == null)
                    state.clp.paytoplan = new paytoplan();
                state.clp.paytoplan.city = location.City;
                state.clp.paytoplan.state = location.State;
                state.clp.paytoplan.zip = location.PostalCode;
                state.clp.paytoplan.country = location.CountryCode;
                state.clp.paytoplan.countrysub = location.CountrySubCode;
            }
            var secondaryId = loop.GetElement(3) as REF;
            if (secondaryId != null)
            {
                if (state.clp.paytoplan == null)
                    state.clp.paytoplan = new paytoplan();
                state.clp.paytoplan.id = secondaryId.Id;
            }
            var taxID = loop.GetElement(4) as REF;
            if (taxID != null)
            {
                if (state.clp.paytoplan == null)
                    state.clp.paytoplan = new paytoplan();
                state.clp.paytoplan.tin = taxID.Id;
            }
        }
        public static void Convert2000B(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var subscriberInfo = loop.GetElement(1) as SBR;
            if (subscriberInfo != null)
            {
                if (state.clp.ins == null)
                    state.clp.ins = new List<ins>();
                state.clp.ins.Add(new ins());
                state.clp.ins[state.clp.ins.Count - 1].inscode = subscriberInfo.PayerResponseSeqNo;
                if (state.clp.ins[state.clp.ins.Count - 1].insinfo == null)
                    state.clp.ins[state.clp.ins.Count - 1].insinfo = new insinfo();
                state.clp.ins[state.clp.ins.Count - 1].insinfo.groupnum = subscriberInfo.ReferenceIdent;
                state.clp.ins[state.clp.ins.Count - 1].insinfo.groupname = subscriberInfo.Name;
                state.clp.ins[state.clp.ins.Count - 1].insinfo.type = subscriberInfo.InsuranceTypeCode;
                if (state.clp.ins[state.clp.ins.Count - 1].payer == null)
                    state.clp.ins[state.clp.ins.Count - 1].payer = new List<payer>();

                state.clp.ins[state.clp.ins.Count - 1].payer.Add(new payer());
                state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].type = subscriberInfo.ClaimFileIndCode;
            }
            var pationInfo = loop.GetElement(2) as PAT;
            if (pationInfo != null)
            {
                if (state.clp.pat == null)
                    state.clp.pat = new pat();
                state.clp.pat.deathdate = pationInfo.DeathDate;
                state.clp.pat.weight = pationInfo.PatientWeight;
                state.clp.pat.pregnant = pationInfo.Pregnant;
            }
            Convert2010BA(loop.GetLoop("2010BA"), state);
            Convert2010BB(loop.GetLoop("2010BB"), state);
            var patientLoop = loop.GetLoop("2000C");
            if (patientLoop == null)
            {
                var clp = state.clp.Clone();
                foreach (var subloop in loop.GetLoops("2300"))
                {
                    state.clp = clp.Clone();
                    Convert2300(subloop, state);
                }
            }
            else
            {
                Convert2000C(loop.GetLoop("2000C"), state);
            }

        
          
        }
        public static void Convert2010BA(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var name = loop.GetElement(0) as NM1;
            if (name != null)
            {
                if (state.clp.ins[state.clp.ins.Count - 1].sbr == null)
                    state.clp.ins[state.clp.ins.Count - 1].sbr = new sbr();
                state.clp.ins[state.clp.ins.Count - 1].sbr.entitytype = Convert.ToSByte(name.EntityTypeQualifier);
                if (state.clp.pat == null)
                    state.clp.pat = new pat();
                state.clp.pat.lname = name.LastName;
                state.clp.ins[state.clp.ins.Count - 1].sbr.lname = name.LastName;
                state.clp.pat.fname = name.FirstName;
                state.clp.ins[state.clp.ins.Count - 1].sbr.fname = name.FirstName;
                state.clp.pat.mname = name.MiddleName;
                state.clp.ins[state.clp.ins.Count - 1].sbr.mname = name.MiddleName;
                state.clp.pat.suffix = name.NameSuffix;
                state.clp.ins[state.clp.ins.Count - 1].sbr.suffix = name.NameSuffix;
            }
            var address = loop.GetElement(1) as N3;
            if (address != null)
            {
                if (state.clp.pat == null)
                    state.clp.pat = new pat();
                state.clp.pat.add1 = address.AddressLine1;
                state.clp.pat.add2 = address.AddressLine2;
            }
            var location = loop.GetElement(2) as N4;
            if (location != null)
            {
                if (state.clp.pat == null)
                    state.clp.pat = new pat();
                state.clp.pat.city = location.City;
                state.clp.pat.state = location.State;
                state.clp.pat.zip = location.PostalCode;
                state.clp.pat.country = location.CountryCode;
                state.clp.pat.countrysub = location.CountrySubCode;
            }
            var demographic = loop.GetElement(3) as DMG;
            if (demographic != null)
            {
                if (state.clp.pat == null)
                    state.clp.pat = new pat();
                state.clp.pat.birthdate = demographic.DateOfBirth;
                state.clp.pat.sex = demographic.Gender;
            }
            var secondaryId = loop.GetElement(4) as REF;
            if (secondaryId != null)
            {
                if (state.clp.ins[state.clp.ins.Count - 1].sbr == null)
                    state.clp.ins[state.clp.ins.Count - 1].sbr = new sbr();
                state.clp.ins[state.clp.ins.Count - 1].sbr.tin = secondaryId.Id;
            }
            var propertyCausualtyClaimNumber = loop.GetElement(5) as REF;
            if (propertyCausualtyClaimNumber != null)
            {
                if (state.clp.pat.propcasualty == null)
                    state.clp.pat.propcasualty = new List<propcasualty>();
                state.clp.pat.propcasualty.Add(new propcasualty());
                state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].claimnum = propertyCausualtyClaimNumber.Id;
            }
            var propertyCausualtySubscriberContact = loop.GetElement(6) as PER;
            if (propertyCausualtySubscriberContact != null)
            {
                if( state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty==null)
                     state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty = new propcasualty();
                if (state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact == null)
                    state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact = new List<contact>();
                state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact.Add(new contact());
                state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact[state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact.Count - 1].name = propertyCausualtySubscriberContact.Name;
                if (state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact[state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact.Count - 1].contactnum == null)
                    state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact[state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact.Count - 1].contactnum = new List<contactnum>();
                state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact[state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact.Count - 1].contactnum.Add(new contactnum());
                state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact[state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact.Count - 1].contactnum[state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact[state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact.Count - 1].contactnum.Count - 1].qual = propertyCausualtySubscriberContact.CommunicationNumberQualifier;
                state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact[state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact.Count - 1].contactnum[state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact[state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact.Count - 1].contactnum.Count - 1].num = propertyCausualtySubscriberContact.CommunicationNumber;
                state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact[state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact.Count - 1].contactnum[state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact[state.clp.ins[state.clp.ins.Count - 1].sbr.propcasualty.contact.Count - 1].contactnum.Count - 1].ext = propertyCausualtySubscriberContact.CommunicationNumber2;
            }
        }
        public static void Convert2010BB(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var name = loop.GetElement(0) as NM1;
            if (name != null)
            {
                if (state.clp.ins[state.clp.ins.Count - 1].payer == null)
                    state.clp.ins[state.clp.ins.Count - 1].payer = new List<payer>();
                state.clp.ins[state.clp.ins.Count - 1].payer.Add(new payer());
                state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].name = name.LastName;
            }
            var address = loop.GetElement(1) as N3;
            if (address != null)
            {
                if (state.clp.ins[state.clp.ins.Count - 1].payer == null)
                    state.clp.ins[state.clp.ins.Count - 1].payer = new List<payer>();
                state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].add1 = address.AddressLine1;
                state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].add2 = address.AddressLine2;
            }
            var location = loop.GetElement(2) as N4;
            if (location != null)
            {
                if (state.clp.ins[state.clp.ins.Count - 1].payer == null)
                    state.clp.ins[state.clp.ins.Count - 1].payer = new List<payer>();
                state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].city = location.City;
                state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].state = location.State;
                state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].zip = location.PostalCode;
                state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].country = location.CountryCode;
                state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].countrysub = location.CountrySubCode;
            }
            var secondaryId = loop.GetElement(3) as REF;
            if (secondaryId != null)
            {
                switch (secondaryId.IdQualifier)
                {
                    case "G2":
                    case "LU":
                        if (state.clp.bill.secid == null)
                            state.clp.bill.secid = new List<secid>();

                        state.clp.bill.secid.Add(new secid
                        {
                            qual = secondaryId.IdQualifier,
                            num = secondaryId.Id
                        });
                        break;
                    case "FY":
                    case "NF":
                        if (state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].secid == null)
                            state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].secid = new List<secid>();

                        state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].secid.Add(new secid
                        {
                            qual = secondaryId.IdQualifier,
                            num = secondaryId.Id
                        });
                        break;
                    case "2U":
                        state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].payerid = secondaryId.Id;
                        break;
                    case "EI":
                        state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].tin = secondaryId.Id;
                        break;
                }
            }
        }
        public static void Convert2000C(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var info = loop.GetElement(1) as PAT;
            if (info != null)
            {
                if (state.clp.pat == null)
                    state.clp.pat = new pat();
                state.clp.pat.deathdate = info.DeathDate;
                state.clp.pat.weight = info.PatientWeight;
                state.clp.pat.pregnant = info.Pregnant;
            }
            Convert2010CA(loop.GetLoop("2010CA"), state);
            var clp = state.clp.Clone();
            foreach (var subloop in loop.GetLoops("2300"))
            {
                state.clp = clp.Clone();
                Convert2300(subloop, state);
            }
        }
        public static void Convert2010CA(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var name = loop.GetElement(0) as NM1;
            if (name != null)
            {
                if (state.clp.pat == null)
                    state.clp.pat = new pat();
                state.clp.pat.lname = name.LastName;
                state.clp.pat.fname = name.FirstName;
                state.clp.pat.mname = name.MiddleName;
                state.clp.pat.suffix = name.NameSuffix;
            }
            var address = loop.GetElement(1) as N3;
            if (address != null)
            {
                if (state.clp.pat == null)
                    state.clp.pat = new pat();
                state.clp.pat.add1 = address.AddressLine1;
                state.clp.pat.add2 = address.AddressLine2;
            }
            var location = loop.GetElement(2) as N4;
            if (location != null)
            {
                if (state.clp.pat == null)
                    state.clp.pat = new pat();
                state.clp.pat.city = location.City;
                state.clp.pat.state = location.State;
                state.clp.pat.zip = location.PostalCode;
                state.clp.pat.country = location.CountryCode;
                state.clp.pat.countrysub = location.CountrySubCode;
            }
            var demographic = loop.GetElement(3) as DMG;
            if (demographic != null)
            {
                if (state.clp.pat == null)
                    state.clp.pat = new pat();
                state.clp.pat.birthdate = demographic.DateOfBirth;
                state.clp.pat.sex = demographic.Gender;
            }
            var propertyCausualtyClaimNumber = loop.GetElement(4) as REF;
            if (propertyCausualtyClaimNumber != null)
            {
                if (state.clp.pat.propcasualty == null)
                    state.clp.pat.propcasualty = new List<propcasualty>();
                state.clp.pat.propcasualty.Add(new propcasualty());
                state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].claimnum = propertyCausualtyClaimNumber.Id;
            }
            var propertyCausualtySubscriberContact = loop.GetElement(6) as PER;
            if (propertyCausualtySubscriberContact != null)
            {
                if (state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact == null)
                    state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact = new List<contact>();
                state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact.Add(new contact());
                state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact[state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact.Count - 1].name = propertyCausualtySubscriberContact.Name;
                if (state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact[state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact.Count - 1].contactnum == null)
                    state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact[state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact.Count - 1].contactnum = new List<contactnum>();
                state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact[state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact.Count - 1].contactnum.Add(new contactnum());
                state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact[state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact.Count - 1].contactnum[state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact[state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact.Count - 1].contactnum.Count - 1].qual = propertyCausualtySubscriberContact.CommunicationNumberQualifier;
                state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact[state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact.Count - 1].contactnum[state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact[state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact.Count - 1].contactnum.Count - 1].num = propertyCausualtySubscriberContact.CommunicationNumber;
                state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact[state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact.Count - 1].contactnum[state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact[state.clp.pat.propcasualty[state.clp.pat.propcasualty.Count - 1].contact.Count - 1].contactnum.Count - 1].ext = propertyCausualtySubscriberContact.CommunicationNumber2;
            }
        }
        public static void Convert2300(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var claim = loop.GetElement(0) as CLM;
            if (claim != null)
            {
                if (state.clp.header == null)
                    state.clp.header = new header();
                state.clp.header.@ref = claim.ClaimSubmitterId;
                if (state.clp.claim == null)
                    state.clp.claim = new claim();
                state.clp.claim.provsignature = claim.SignatureOnFileYesNo;
                state.clp.claim.provassignment = claim.ProviderAcceptAssignmentCode;
                if (state.clp.ins[state.clp.ins.Count - 1].insinfo == null)
                    state.clp.ins[state.clp.ins.Count - 1].insinfo = new insinfo();
                state.clp.ins[state.clp.ins.Count - 1].insinfo.assignbenefits = claim.AuthorizedYesNo;
                state.clp.ins[state.clp.ins.Count - 1].insinfo.releaseinfo = claim.ReleaseOfnfomaitonCode;
                state.clp.ins[state.clp.ins.Count - 1].insinfo.patsignsource = claim.PatientSignatureSourceCode;
                state.clp.claim.specprogram = claim.SpecialProgramCode;
                state.clp.claim.delayreason = claim.DelayReasonCode;
            }
            var onset = loop.GetElement(1) as DTP;
            if (onset != null)
            {
                if (state.clp.claim == null)
                    state.clp.claim = new claim();
                state.clp.claim.illnessdate = onset.TimePeriod;
            }
            var initialtreatment = loop.GetElement(2) as DTP;
            if (initialtreatment != null)
            {
                if (state.clp.claim == null)
                    state.clp.claim = new claim();
                state.clp.claim.inittreatdate = initialtreatment.TimePeriod;
            }
            var lastSeen = loop.GetElement(3) as DTP;
            if (lastSeen != null)
            {
                if (state.clp.claim == null)
                    state.clp.claim = new claim();
                state.clp.claim.lastseendate = lastSeen.TimePeriod;
            }
            var acuteManifestation = loop.GetElement(4) as DTP;
            if (acuteManifestation != null)
            {
                if (state.clp.claim.acutemanifest == null)
                    state.clp.claim.acutemanifest = new acutemanifest();
                state.clp.claim.acutemanifest.date = acuteManifestation.TimePeriod;
            }
            var accident = loop.GetElement(5) as DTP;
            if (accident != null)
            {
                if (state.clp.claim.acc == null)
                    state.clp.claim.acc = new acc();
                if (state.clp.claim.acc.acciddt == null)
                    state.clp.claim.acc.acciddt = new acciddt();
                state.clp.claim.acc.acciddt.datetime = accident.TimePeriod;
            }
            var lastMenstrual = loop.GetElement(6) as DTP;
            if (lastMenstrual != null)
            {
                if (state.clp.claim == null)
                    state.clp.claim = new claim();
                state.clp.claim.lmpdate = lastMenstrual.TimePeriod;
            }
            var lastXRay = loop.GetElement(7) as DTP;
            if (lastXRay != null)
            {
                if (state.clp.claim == null)
                    state.clp.claim = new claim();
                state.clp.claim.xraydate = lastXRay.TimePeriod;
            }
            var hearingVisionPrescription = loop.GetElement(8) as DTP;
            if (hearingVisionPrescription != null)
            {
                if (state.clp.claim == null)
                    state.clp.claim = new claim();
                state.clp.claim.prescriptiondate = hearingVisionPrescription.TimePeriod;
            }
            var lastWored = loop.GetElement(10) as DTP;
            if (lastWored != null)
            {
                if (state.clp.claim == null)
                    state.clp.claim = new claim();
                state.clp.claim.lastworkeddate = lastWored.TimePeriod;
            }
            var authorizedReturnWork = loop.GetElement(11) as DTP;
            if (authorizedReturnWork != null)
            {
                if (state.clp.claim == null)
                    state.clp.claim = new claim();
                state.clp.claim.returntoworkdate = authorizedReturnWork.TimePeriod;
            }
            var admission = loop.GetElement(12) as DTP;
            if (admission != null)
            {
                if (state.clp.claim == null)
                    state.clp.claim = new claim();
                state.clp.claim.admissiondate = admission.TimePeriod;
            }
            var discharge = loop.GetElement(13) as DTP;
            if (discharge != null)
            {
                if (state.clp.claim == null)
                    state.clp.claim = new claim();
                state.clp.claim.dischargedate = discharge.TimePeriod;
            }
            var assumedRelinquishedCare = loop.GetElement(14) as DTP;
            if (assumedRelinquishedCare != null)
            {
                if (state.clp.claim == null)
                    state.clp.claim = new claim();
                state.clp.claim.assumedcaredate = assumedRelinquishedCare.TimePeriod;
                //state.clp.claim.relinquishedcaredate = assumedRelinquishedCare.TimePeriod;
            }

            var propertyCasualtyFirstContact = loop.GetElement(15) as DTP;
            if (propertyCasualtyFirstContact != null)
            {
                if (state.clp.claim == null)
                    state.clp.claim = new claim();
                state.clp.claim.propcasualtyfirstvisitdate = propertyCasualtyFirstContact.TimePeriod;
            }
            var repricerReceived = loop.GetElement(16) as DTP;
            if (repricerReceived != null)
            {
                if (state.clp.claim == null)
                    state.clp.claim = new claim();
                state.clp.claim.repricerreceiveddate = repricerReceived.TimePeriod;
            }
            var supplementalInfomations = loop.GetElements(17) as PWK[];
            if (supplementalInfomations != null)
                foreach (var supplementalInfomation in supplementalInfomations)
                {
                    if (state.clp.claim.attach == null)
                        state.clp.claim.attach = new List<attach>();
                    state.clp.claim.attach.Add(new attach());
                    state.clp.claim.attach[state.clp.claim.attach.Count - 1].type = supplementalInfomation.ReportType;
                    state.clp.claim.attach[state.clp.claim.attach.Count - 1].trans = supplementalInfomation.ReportTransmissionCode;
                    state.clp.claim.attach[state.clp.claim.attach.Count - 1].num = supplementalInfomation.IdCode;
                }
            var contact = loop.GetElement(18) as CN1;
            if (contact != null)
            {
                if (state.clp.claim.contract == null)
                    state.clp.claim.contract = new contract();
                state.clp.claim.contract.type = contact.TypeCode;
                state.clp.claim.contract.amt = contact.MonetaryAmount;
                state.clp.claim.contract.percent = contact.Percent;
                state.clp.claim.contract.code = contact.ReferenceIdentifier;
                state.clp.claim.contract.discount = contact.TermsDiscountPercent;
                state.clp.claim.contract.version = contact.VersionId;
            }
            var serviceAuthorizationException = loop.GetElement(20) as REF;
            if (serviceAuthorizationException != null)
            {
                if (state.clp.claim == null)
                    state.clp.claim = new claim();
                state.clp.claim.authexcept = serviceAuthorizationException.Id;
            }
            var mandatoryMedicareCrossover = loop.GetElement(21) as REF;
            if (mandatoryMedicareCrossover != null)
            {
                if (state.clp.claim == null)
                    state.clp.claim = new claim();
                state.clp.claim.crossoverind = mandatoryMedicareCrossover.Id;
            }
            var mammographCertificationNumber = loop.GetElement(22) as REF;
            if (mammographCertificationNumber != null)
            {
                if (state.clp.claim == null)
                    state.clp.claim = new claim();
                state.clp.claim.mamcert = mammographCertificationNumber.Id;
            }
            var referalNumber = loop.GetElement(23) as REF;
            if (referalNumber != null)
            {
                if (state.clp.ins[state.clp.ins.Count - 1].insinfo == null)
                    state.clp.ins[state.clp.ins.Count - 1].insinfo = new insinfo();
                state.clp.ins[state.clp.ins.Count - 1].insinfo.referralnum = referalNumber.Id;
            }
            var priorAuthorizaiton = loop.GetElement(24) as REF;
            if (priorAuthorizaiton != null)
            {
                if (state.clp.ins[state.clp.ins.Count - 1].insinfo == null)
                    state.clp.ins[state.clp.ins.Count - 1].insinfo = new insinfo();
                state.clp.ins[state.clp.ins.Count - 1].insinfo.priorauth = priorAuthorizaiton.Id;
            }
            var payerClaimControlNumer = loop.GetElement(25) as REF;
            if (payerClaimControlNumer != null)
            {
                if (state.clp.claim == null)
                    state.clp.claim = new claim();
                state.clp.claim.origref = payerClaimControlNumer.Id;
            }
            var cLIANumber = loop.GetElement(26) as REF;
            if (cLIANumber != null)
            {
                if (state.clp.claim.clia == null)
                    state.clp.claim.clia = new clia();
                state.clp.claim.clia.number = cLIANumber.Id;
            }
            var repricedClaimNumber = loop.GetElement(27) as REF;
            if (repricedClaimNumber != null)
            {
                if (state.clp.claim.reprice == null)
                    state.clp.claim.reprice = new reprice();
                state.clp.claim.reprice.claimref = repricedClaimNumber.Id;
            }
            var adjustedRepricedClaimNumber = loop.GetElement(28) as REF;
            if (adjustedRepricedClaimNumber != null)
            {
                if (state.clp.claim.reprice == null)
                    state.clp.claim.reprice = new reprice();
                state.clp.claim.reprice.adjclaimref = adjustedRepricedClaimNumber.Id;
            }
            var investigativeDeviceExemption = loop.GetElement(29) as REF;
            if (investigativeDeviceExemption != null)
            {
                if (state.clp.claim == null)
                    state.clp.claim = new claim();
                state.clp.claim.idenum = investigativeDeviceExemption.Id;
            }
            var medicalRecordNumber = loop.GetElement(31) as REF;
            if (medicalRecordNumber != null)
            {
                if (state.clp.claim == null)
                    state.clp.claim = new claim();
                state.clp.claim.medrecnum = medicalRecordNumber.Id;
            }
            var demonstrationProjectId = loop.GetElement(32) as REF;
            if (demonstrationProjectId != null)
            {
                if (state.clp.ins[state.clp.ins.Count - 1].insinfo == null)
                    state.clp.ins[state.clp.ins.Count - 1].insinfo = new insinfo();
                state.clp.ins[state.clp.ins.Count - 1].insinfo.demoproject = demonstrationProjectId.Id;
            }
            var carePlanOversight = loop.GetElement(33) as REF;
            if (carePlanOversight != null)
            {
                if (state.clp.claim == null)
                    state.clp.claim = new claim();
                state.clp.claim.cpo = carePlanOversight.Id;
            }
            var fileInfos = loop.GetElements(34) as K3[];
            if (fileInfos != null)
                foreach (var fileInfo in fileInfos)
                {
                    if (state.clp.claim.k3note == null)
                        state.clp.claim.k3note = new k3note();
                    state.clp.claim.k3note.note = fileInfo.FixedFormatInfomation;
                }
            var note = loop.GetElement(35) as NTE;
            if (note != null)
            {
                if (state.clp.claim == null)
                    state.clp.claim = new claim();
                state.clp.claim.notequal = note.ReferenceCode;
                state.clp.claim.note = note.Description;
            }
            var ambulanceInfo = loop.GetElement(36) as CR1;
            if (ambulanceInfo != null)
            {
                if (state.clp.claim.amb == null)
                    state.clp.claim.amb = new amb();
                state.clp.claim.amb.weight = ambulanceInfo.Weight;
                state.clp.claim.amb.transreason = ambulanceInfo.TransportReason;
                state.clp.claim.amb.distance = ambulanceInfo.Distance;
                state.clp.claim.amb.roundtrip = ambulanceInfo.Description;
                state.clp.claim.amb.stretcher = ambulanceInfo.Description2;
            }
            var spinalManipulaiton = loop.GetElement(37) as CR2;
            if (spinalManipulaiton != null)
            {
                if (state.clp.claim.spine == null)
                    state.clp.claim.spine = new spine();
                state.clp.claim.spine.treatseriesnum = spinalManipulaiton.Count;
                state.clp.claim.spine.treatseriesqty = spinalManipulaiton.Quantity;
                state.clp.claim.spine.treatperioduom = spinalManipulaiton.Unit;
                state.clp.claim.spine.monthtreatqty = spinalManipulaiton.Quantity3;
                state.clp.claim.spine.patcondition = spinalManipulaiton.NatureOfCoditionCode;
                state.clp.claim.spine.complication = spinalManipulaiton.YesNo;
                state.clp.claim.spine.patconditiondesc = spinalManipulaiton.Description1;
                state.clp.claim.spine.patconditiondesc2 = spinalManipulaiton.Description2;
            }
            var ambulanceCertifications = loop.GetElements(38) as CRC[];
            if (ambulanceCertifications != null)
                foreach (var ambulanceCertification in ambulanceCertifications)
                {
                    if (state.clp.claim.amb.condition == null)
                        state.clp.claim.amb.condition = new List<condition>();
                    state.clp.claim.amb.condition.Add(new condition());
                    state.clp.claim.amb.condition[state.clp.claim.amb.condition.Count - 1].applies = ambulanceCertification.YesNo;
                }
            //var ambulanceCertifications = loop.GetElements(38) as CRC[];
            //if(ambulanceCertifications != null)
            //    foreach(var ambulanceCertification in ambulanceCertifications)
            //    {
            //    if(state.clp.claim.spectaclelens == null)
            //        state.clp.claim.spectaclelens = new List<spectaclelens>();
            //    state.clp.claim.spectaclelens.Add(new spectaclelens());
            //    state.clp.claim.spectaclelens[state.clp.claim.spectaclelens.Count -1].applies = ambulanceCertification.YesNo;
            //    state.clp.claim.spectaclelens[state.clp.claim.spectaclelens.Count -1].condition = ambulanceCertification.ConditionIndicator1;
            //    if(state.clp.claim.contactlens == null)
            //        state.clp.claim.contactlens = new contactlens();
            //    state.clp.claim.contactlens.condition = ambulanceCertification.ConditionIndicator1;
            //    if(state.clp.claim.spectacleframe == null)
            //        state.clp.claim.spectacleframe = new spectacleframe();
            //    state.clp.claim.spectacleframe.condition = ambulanceCertification.ConditionIndicator1;
            //    if(state.clp.claim.epsdt == null)
            //        state.clp.claim.epsdt = new List<epsdt>();
            //    state.clp.claim.epsdt.Add(new epsdt());
            //    state.clp.claim.epsdt[state.clp.claim.epsdt.Count -1].condition = ambulanceCertification.ConditionIndicator1;
            //    state.clp.claim.spectaclelens[state.clp.claim.spectaclelens.Count -1].condition = ambulanceCertification.ConditionIndicator2;
            //    state.clp.claim.contactlens.condition = ambulanceCertification.ConditionIndicator2;
            //    state.clp.claim.spectacleframe.condition = ambulanceCertification.ConditionIndicator2;
            //    state.clp.claim.spectaclelens[state.clp.claim.spectaclelens.Count -1].condition = ambulanceCertification.ConditionIndicator3;
            //    state.clp.claim.contactlens.condition = ambulanceCertification.ConditionIndicator3;
            //    state.clp.claim.spectacleframe.condition = ambulanceCertification.ConditionIndicator3;
            //    state.clp.claim.spectaclelens[state.clp.claim.spectaclelens.Count -1].condition = ambulanceCertification.ConditionIndicator4;
            //    state.clp.claim.contactlens.condition = ambulanceCertification.ConditionIndicator4;
            //    state.clp.claim.spectacleframe.condition = ambulanceCertification.ConditionIndicator4;
            //    state.clp.claim.spectaclelens[state.clp.claim.spectaclelens.Count -1].condition = ambulanceCertification.ConditionIndicator5;
            //    state.clp.claim.contactlens.condition = ambulanceCertification.ConditionIndicator5;
            //    state.clp.claim.spectacleframe.condition = ambulanceCertification.ConditionIndicator5;
            //    }
            //var pationConditionVisions = loop.GetElements(39) as CRC[];
            //if(pationConditionVisions != null)
            //    foreach(var pationConditionVision in pationConditionVisions)
            //    {
            //    if(state.clp.claim.contactlens == null)
            //        state.clp.claim.contactlens = new contactlens();
            //    state.clp.claim.contactlens.applies = pationConditionVision.YesNo;
            //    }
            var pationConditionVisions = loop.GetElements(39) as CRC[];
            if (pationConditionVisions != null)
                foreach (var pationConditionVision in pationConditionVisions)
                {
                    if (state.clp.claim.spectacleframe == null)
                        state.clp.claim.spectacleframe = new spectacleframe();
                    state.clp.claim.spectacleframe.applies = pationConditionVision.YesNo;
                }
            var claimPricingInfo = loop.GetElement(45) as HCP;
            if (claimPricingInfo != null)
            {
                if (state.clp.claim.reprice == null)
                    state.clp.claim.reprice = new reprice();
                state.clp.claim.reprice.method = claimPricingInfo.Methodology;
                state.clp.claim.reprice.allowedamt = claimPricingInfo.Amount;
                state.clp.claim.reprice.savingsamt = claimPricingInfo.SavingAmount;
                state.clp.claim.reprice.organizationid = claimPricingInfo.ReferenceIdentifier;
                state.clp.claim.reprice.rate = claimPricingInfo.Rate;
                state.clp.claim.reprice.approvedapgcode = claimPricingInfo.ReferenceIdentifier2;
                state.clp.claim.reprice.approvedapgamt = claimPricingInfo.Amount2;
                state.clp.claim.reprice.rejectreason = claimPricingInfo.RejectReasonCode;
                state.clp.claim.reprice.policycompliance = claimPricingInfo.PolicyComplianceCode;
                state.clp.claim.reprice.exceptioncode = claimPricingInfo.ExceptionCode;
            }
            Convert2310A(loop.GetLoop("2310A"), state);
            Convert2310B(loop.GetLoop("2310B"), state);
            Convert2310C(loop.GetLoop("2310C"), state);
            Convert2310D(loop.GetLoop("2310D"), state);
            Convert2310E(loop.GetLoop("2310E"), state);
            Convert2310F(loop.GetLoop("2310F"), state);
            Convert2320(loop.GetLoop("2320"), state);
            foreach (var subloop in loop.GetLoops("2400"))
                Convert2400(subloop, state);
            state.Add(state.clp);
        }
        public static void Convert2310A(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var name = loop.GetElement(0) as NM1;
            if (name != null)
            {
                if (state.clp.@ref == null)
                    state.clp.@ref = new List<@ref>();
                state.clp.@ref.Add(new @ref());
                state.clp.@ref[state.clp.@ref.Count - 1].entitytype = Convert.ToSByte(name.EntityTypeQualifier);
                if (state.clp.pcp == null)
                    state.clp.pcp = new pcp();
                state.clp.pcp.entitytype = Convert.ToSByte(name.EntityTypeQualifier);
                state.clp.@ref[state.clp.@ref.Count - 1].lname = name.LastName;
                state.clp.pcp.lname = name.LastName;
                state.clp.@ref[state.clp.@ref.Count - 1].fname = name.FirstName;
                state.clp.pcp.fname = name.FirstName;
                state.clp.@ref[state.clp.@ref.Count - 1].mname = name.MiddleName;
                state.clp.pcp.mname = name.MiddleName;
                state.clp.@ref[state.clp.@ref.Count - 1].suffix = name.NameSuffix;
                state.clp.pcp.suffix = name.NameSuffix;
                state.clp.@ref[state.clp.@ref.Count - 1].npi = name.IdCode;
                state.clp.pcp.npi = name.IdCode;
            }
            var secondaryIds = loop.GetElements(1) as REF[];
            if (secondaryIds != null)
                foreach (var secondaryId in secondaryIds)
                {
                    if (state.clp.@ref == null)
                        state.clp.@ref = new List<@ref>();
                    state.clp.@ref.Add(new @ref());
                    state.clp.@ref[state.clp.@ref.Count - 1].provnumqual = secondaryId.IdQualifier;
                    if (state.clp.@ref[state.clp.@ref.Count - 1].secid == null)
                        state.clp.@ref[state.clp.@ref.Count - 1].secid = new List<secid>();
                    state.clp.@ref[state.clp.@ref.Count - 1].secid.Add(new secid());
                    state.clp.@ref[state.clp.@ref.Count - 1].secid[state.clp.@ref[state.clp.@ref.Count - 1].secid.Count - 1].qual = secondaryId.IdQualifier;
                    if (state.clp.pcp == null)
                        state.clp.pcp = new pcp();
                    state.clp.pcp.provnumqual = secondaryId.IdQualifier;
                    if (state.clp.pcp.secid == null)
                        state.clp.pcp.secid = new List<secid>();
                    state.clp.pcp.secid.Add(new secid());
                    state.clp.pcp.secid[state.clp.pcp.secid.Count - 1].qual = secondaryId.IdQualifier;
                    state.clp.@ref[state.clp.@ref.Count - 1].provnum = secondaryId.Id;
                    state.clp.@ref[state.clp.@ref.Count - 1].secid[state.clp.@ref[state.clp.@ref.Count - 1].secid.Count - 1].num = secondaryId.Id;
                    state.clp.pcp.provnum = secondaryId.Id;
                    state.clp.pcp.secid[state.clp.pcp.secid.Count - 1].num = secondaryId.Id;
                }
        }
        public static void Convert2310B(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var name = loop.GetElement(0) as NM1;
            if (name != null)
            {
                if (state.clp.ren == null)
                    state.clp.ren = new List<ren>();
                state.clp.ren.Add(new ren());
                state.clp.ren[state.clp.ren.Count - 1].entitytype = Convert.ToSByte(name.EntityTypeQualifier);
                state.clp.ren[state.clp.ren.Count - 1].lname = name.LastName;
                state.clp.ren[state.clp.ren.Count - 1].fname = name.FirstName;
                state.clp.ren[state.clp.ren.Count - 1].mname = name.MiddleName;
                state.clp.ren[state.clp.ren.Count - 1].suffix = name.NameSuffix;
                state.clp.ren[state.clp.ren.Count - 1].npi = name.IdCode;
            }
            var specialtyInfo = loop.GetElement(1) as PRV;
            if (specialtyInfo != null)
            {
                if (state.clp.ren == null)
                    state.clp.ren = new List<ren>();
                state.clp.ren.Add(new ren());
                state.clp.ren[state.clp.ren.Count - 1].taxonomy = specialtyInfo.ReferenceIdentification;
            }
            var secondaryIds = loop.GetElements(2) as REF[];
            if (secondaryIds != null)
                foreach (var secondaryId in secondaryIds)
                {
                    if (state.clp.ren == null)
                        state.clp.ren = new List<ren>();
                    state.clp.ren.Add(new ren());
                    state.clp.ren[state.clp.ren.Count - 1].provnumqual = secondaryId.IdQualifier;
                    if (state.clp.ren[state.clp.ren.Count - 1].secid == null)
                        state.clp.ren[state.clp.ren.Count - 1].secid = new List<secid>();
                    state.clp.ren[state.clp.ren.Count - 1].secid.Add(new secid());
                    state.clp.ren[state.clp.ren.Count - 1].secid[state.clp.ren[state.clp.ren.Count - 1].secid.Count - 1].qual = secondaryId.IdQualifier;
                    state.clp.ren[state.clp.ren.Count - 1].provnum = secondaryId.Id;
                    state.clp.ren[state.clp.ren.Count - 1].secid[state.clp.ren[state.clp.ren.Count - 1].secid.Count - 1].num = secondaryId.Id;
                }
        }
        public static void Convert2310C(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var name = loop.GetElement(0) as NM1;
            if (name != null)
            {
                if (state.clp.fac == null)
                    state.clp.fac = new fac();
                state.clp.fac.type = name.EntityIdCode;
                state.clp.fac.name = name.LastName;
                state.clp.fac.npi = name.IdCode;
            }
            var address = loop.GetElement(1) as N3;
            if (address != null)
            {
                if (state.clp.fac == null)
                    state.clp.fac = new fac();
                state.clp.fac.add1 = address.AddressLine1;
                state.clp.fac.add2 = address.AddressLine2;
            }
            var location = loop.GetElement(2) as N4;
            if (location != null)
            {
                if (state.clp.fac == null)
                    state.clp.fac = new fac();
                state.clp.fac.city = location.City;
                state.clp.fac.state = location.State;
                state.clp.fac.zip = location.PostalCode;
                state.clp.fac.country = location.CountryCode;
                state.clp.fac.countrysub = location.CountrySubCode;
            }
            var secondaryId = loop.GetElement(3) as REF;
            if (secondaryId != null)
            {
                if (state.clp.fac == null)
                    state.clp.fac = new fac();
                state.clp.fac.provnumqual = secondaryId.IdQualifier;
                if (state.clp.fac.secid == null)
                    state.clp.fac.secid = new List<secid>();
                state.clp.fac.secid.Add(new secid());
                state.clp.fac.secid[state.clp.fac.secid.Count - 1].qual = secondaryId.IdQualifier;
                state.clp.fac.provnum = secondaryId.Id;
                state.clp.fac.secid[state.clp.fac.secid.Count - 1].num = secondaryId.Id;
            }
            var contactInfo = loop.GetElement(4) as PER;
            if (contactInfo != null)
            {
                if (state.clp.fac.contact == null)
                    state.clp.fac.contact = new List<contact>();
                state.clp.fac.contact.Add(new contact());
                state.clp.fac.contact[state.clp.fac.contact.Count - 1].name = contactInfo.Name;
                if (state.clp.fac.contact[state.clp.fac.contact.Count - 1].contactnum == null)
                    state.clp.fac.contact[state.clp.fac.contact.Count - 1].contactnum = new List<contactnum>();
                state.clp.fac.contact[state.clp.fac.contact.Count - 1].contactnum.Add(new contactnum());
                state.clp.fac.contact[state.clp.fac.contact.Count - 1].contactnum[state.clp.fac.contact[state.clp.fac.contact.Count - 1].contactnum.Count - 1].num = contactInfo.CommunicationNumberQualifier;
                state.clp.fac.contact[state.clp.fac.contact.Count - 1].contactnum[state.clp.fac.contact[state.clp.fac.contact.Count - 1].contactnum.Count - 1].qual = contactInfo.CommunicationNumber;
                state.clp.fac.contact[state.clp.fac.contact.Count - 1].contactnum[state.clp.fac.contact[state.clp.fac.contact.Count - 1].contactnum.Count - 1].ext = contactInfo.CommunicationNumber2;
            }
        }
        public static void Convert2310D(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var name = loop.GetElement(0) as NM1;
            if (name != null)
            {
                if (state.clp.sup == null)
                    state.clp.sup = new sup();
                state.clp.sup.entitytype = Convert.ToSByte(name.EntityTypeQualifier);
                state.clp.sup.lname = name.LastName;
                state.clp.sup.fname = name.FirstName;
                state.clp.sup.mname = name.MiddleName;
                state.clp.sup.suffix = name.NameSuffix;
                state.clp.sup.npi = name.IdCode;
            }
            var secondaryIds = loop.GetElements(1) as REF[];
            if (secondaryIds != null)
                foreach (var secondaryId in secondaryIds)
                {
                    if (state.clp.sup == null)
                        state.clp.sup = new sup();
                    state.clp.sup.provnumqual = secondaryId.IdQualifier;
                    if (state.clp.sup.secid == null)
                        state.clp.sup.secid = new List<secid>();
                    state.clp.sup.secid.Add(new secid());
                    state.clp.sup.secid[state.clp.sup.secid.Count - 1].num = secondaryId.IdQualifier;
                    state.clp.sup.provnum = secondaryId.Id;
                    state.clp.sup.secid[state.clp.sup.secid.Count - 1].qual = secondaryId.Id;
                }
        }
        public static void Convert2310E(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var address = loop.GetElement(1) as N3;
            if (address != null)
            {
                if (state.clp.claim.amb.pickup == null)
                    state.clp.claim.amb.pickup = new pickup();
                state.clp.claim.amb.pickup.add1 = address.AddressLine1;
                state.clp.claim.amb.pickup.add2 = address.AddressLine2;
            }
            var locaiton = loop.GetElement(2) as N4;
            if (locaiton != null)
            {
                if (state.clp.claim.amb.pickup == null)
                    state.clp.claim.amb.pickup = new pickup();
                state.clp.claim.amb.pickup.city = locaiton.City;
                state.clp.claim.amb.pickup.state = locaiton.State;
                state.clp.claim.amb.pickup.zip = locaiton.PostalCode;
                state.clp.claim.amb.pickup.country = locaiton.CountryCode;
                state.clp.claim.amb.pickup.countrysub = locaiton.CountrySubCode;
            }
        }
        public static void Convert2310F(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var name = loop.GetElement(0) as NM1;
            if (name != null)
            {
                if (state.clp.claim.amb.dropoff == null)
                    state.clp.claim.amb.dropoff = new dropoff();
                state.clp.claim.amb.dropoff.name = name.LastName;
            }
            var address = loop.GetElement(1) as N3;
            if (address != null)
            {
                if (state.clp.claim.amb.dropoff == null)
                    state.clp.claim.amb.dropoff = new dropoff();
                state.clp.claim.amb.dropoff.add1 = address.AddressLine1;
                state.clp.claim.amb.dropoff.add2 = address.AddressLine2;
            }
            var locaiton = loop.GetElement(2) as N4;
            if (locaiton != null)
            {
                if (state.clp.claim.amb.dropoff == null)
                    state.clp.claim.amb.dropoff = new dropoff();
                state.clp.claim.amb.dropoff.city = locaiton.City;
                state.clp.claim.amb.dropoff.state = locaiton.State;
                state.clp.claim.amb.dropoff.zip = locaiton.PostalCode;
                state.clp.claim.amb.dropoff.country = locaiton.CountryCode;
                state.clp.claim.amb.dropoff.countrysub = locaiton.CountrySubCode;
            }
        }
        public static void Convert2320(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var info = loop.GetElement(0) as SBR;
            if (info != null)
            {
                if (state.clp.ins == null)
                    state.clp.ins = new List<ins>();
                state.clp.ins.Add(new ins());
                state.clp.ins[state.clp.ins.Count - 1].inscode = info.PayerResponseSeqNo;
                if (state.clp.ins[state.clp.ins.Count - 1].insinfo == null)
                    state.clp.ins[state.clp.ins.Count - 1].insinfo = new insinfo();
                state.clp.ins[state.clp.ins.Count - 1].insinfo.groupnum = info.ReferenceIdent;
                state.clp.ins[state.clp.ins.Count - 1].insinfo.groupname = info.Name;
                state.clp.ins[state.clp.ins.Count - 1].insinfo.type = info.InsuranceTypeCode;
                if (state.clp.ins[state.clp.ins.Count - 1].payer == null)
                    state.clp.ins[state.clp.ins.Count - 1].payer = new List<payer>();
                state.clp.ins[state.clp.ins.Count - 1].payer.Add(new payer());
                state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].type = info.ClaimFileIndCode;
            }
            var adjustmentss = loop.GetElements(1) as CAS[];
            if (adjustmentss != null)
                foreach (var adjustments in adjustmentss)
                {
                    if (state.clp.ins[state.clp.ins.Count - 1].insinfo.adj == null)
                        state.clp.ins[state.clp.ins.Count - 1].insinfo.adj = new List<adj>();
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.adj.Add(new adj());
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.adj[state.clp.ins[state.clp.ins.Count - 1].insinfo.adj.Count - 1].group = adjustments.AdjustmentGroupCode1;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.adj[state.clp.ins[state.clp.ins.Count - 1].insinfo.adj.Count - 1].reason = adjustments.ReasonCode1;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.adj[state.clp.ins[state.clp.ins.Count - 1].insinfo.adj.Count - 1].amt = adjustments.Amount1;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.adj[state.clp.ins[state.clp.ins.Count - 1].insinfo.adj.Count - 1].qty = adjustments.Quantity1;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.adj[state.clp.ins[state.clp.ins.Count - 1].insinfo.adj.Count - 1].reason = adjustments.AdjustmentGroupCode2;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.adj[state.clp.ins[state.clp.ins.Count - 1].insinfo.adj.Count - 1].amt = adjustments.ReasonCode2;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.adj[state.clp.ins[state.clp.ins.Count - 1].insinfo.adj.Count - 1].qty = adjustments.Amount2;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.adj[state.clp.ins[state.clp.ins.Count - 1].insinfo.adj.Count - 1].reason = adjustments.Quantity2;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.adj[state.clp.ins[state.clp.ins.Count - 1].insinfo.adj.Count - 1].amt = adjustments.AdjustmentGroupCode3;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.adj[state.clp.ins[state.clp.ins.Count - 1].insinfo.adj.Count - 1].qty = adjustments.ReasonCode3;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.adj[state.clp.ins[state.clp.ins.Count - 1].insinfo.adj.Count - 1].reason = adjustments.Amount3;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.adj[state.clp.ins[state.clp.ins.Count - 1].insinfo.adj.Count - 1].amt = adjustments.Quantity3;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.adj[state.clp.ins[state.clp.ins.Count - 1].insinfo.adj.Count - 1].qty = adjustments.AdjustmentGroupCode4;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.adj[state.clp.ins[state.clp.ins.Count - 1].insinfo.adj.Count - 1].reason = adjustments.ReasonCode4;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.adj[state.clp.ins[state.clp.ins.Count - 1].insinfo.adj.Count - 1].amt = adjustments.Amount4;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.adj[state.clp.ins[state.clp.ins.Count - 1].insinfo.adj.Count - 1].qty = adjustments.Quantity4;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.adj[state.clp.ins[state.clp.ins.Count - 1].insinfo.adj.Count - 1].reason = adjustments.AdjustmentGroupCode5;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.adj[state.clp.ins[state.clp.ins.Count - 1].insinfo.adj.Count - 1].amt = adjustments.ReasonCode5;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.adj[state.clp.ins[state.clp.ins.Count - 1].insinfo.adj.Count - 1].qty = adjustments.Amount5;
                }
            var otherCoverageInfo = loop.GetElement(5) as OI;
            if (otherCoverageInfo != null)
            {
                if (state.clp.ins[state.clp.ins.Count - 1].insinfo == null)
                    state.clp.ins[state.clp.ins.Count - 1].insinfo = new insinfo();
                state.clp.ins[state.clp.ins.Count - 1].insinfo.assignbenefits = otherCoverageInfo.YesNo;
                state.clp.ins[state.clp.ins.Count - 1].insinfo.patsignsource = otherCoverageInfo.SignatureSourceCode;
                state.clp.ins[state.clp.ins.Count - 1].insinfo.releaseinfo = otherCoverageInfo.ReleaseOfInfomationCode;
            }
            var outpatientAdjudicaiton = loop.GetElement(6) as MOA;
            if (outpatientAdjudicaiton != null)
            {
                if (state.clp.ins[state.clp.ins.Count - 1].insinfo == null)
                    state.clp.ins[state.clp.ins.Count - 1].insinfo = new insinfo();
                state.clp.ins[state.clp.ins.Count - 1].insinfo.reimburserate = outpatientAdjudicaiton.Percent;
                state.clp.ins[state.clp.ins.Count - 1].insinfo.hcpcspayable = outpatientAdjudicaiton.Amount1;
                if (state.clp.ins[state.clp.ins.Count - 1].insinfo.payment == null)
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.payment = new List<payment>();
                state.clp.ins[state.clp.ins.Count - 1].insinfo.payment.Add(new payment());
                state.clp.ins[state.clp.ins.Count - 1].insinfo.payment[state.clp.ins[state.clp.ins.Count - 1].insinfo.payment.Count - 1].remark = outpatientAdjudicaiton.ReferenceId1;
                state.clp.ins[state.clp.ins.Count - 1].insinfo.payment[state.clp.ins[state.clp.ins.Count - 1].insinfo.payment.Count - 1].remark = outpatientAdjudicaiton.ReferenceId2;
                state.clp.ins[state.clp.ins.Count - 1].insinfo.payment[state.clp.ins[state.clp.ins.Count - 1].insinfo.payment.Count - 1].remark = outpatientAdjudicaiton.ReferenceId3;
                state.clp.ins[state.clp.ins.Count - 1].insinfo.payment[state.clp.ins[state.clp.ins.Count - 1].insinfo.payment.Count - 1].remark = outpatientAdjudicaiton.ReferenceId4;
                state.clp.ins[state.clp.ins.Count - 1].insinfo.payment[state.clp.ins[state.clp.ins.Count - 1].insinfo.payment.Count - 1].remark = outpatientAdjudicaiton.ReferenceId5;
                state.clp.ins[state.clp.ins.Count - 1].insinfo.esrdpaidamt = outpatientAdjudicaiton.Amount2;
                state.clp.ins[state.clp.ins.Count - 1].insinfo.profcompbillamt = outpatientAdjudicaiton.Amount3;
            }
            Convert2330A(loop.GetLoop("2330A"), state);
            Convert2330B(loop.GetLoop("2330B"), state);
            Convert2330C(loop.GetLoop("2330C"), state);
            Convert2330D(loop.GetLoop("2330D"), state);
            Convert2330E(loop.GetLoop("2330E"), state);
            Convert2330F(loop.GetLoop("2330F"), state);
            Convert2330G(loop.GetLoop("2330G"), state);
        }
        public static void Convert2330A(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var name = loop.GetElement(0) as NM1;
            if (name != null)
            {
                if (state.clp.ins[state.clp.ins.Count - 1].sbr == null)
                    state.clp.ins[state.clp.ins.Count - 1].sbr = new sbr();
                state.clp.ins[state.clp.ins.Count - 1].sbr.entitytype = Convert.ToSByte(name.EntityTypeQualifier);
                state.clp.ins[state.clp.ins.Count - 1].sbr.lname = name.LastName;
                state.clp.ins[state.clp.ins.Count - 1].sbr.fname = name.FirstName;
                state.clp.ins[state.clp.ins.Count - 1].sbr.mname = name.MiddleName;
                state.clp.ins[state.clp.ins.Count - 1].sbr.suffix = name.NameSuffix;
            }
            var address = loop.GetElement(1) as N3;
            if (address != null)
            {
                if (state.clp.ins[state.clp.ins.Count - 1].sbr == null)
                    state.clp.ins[state.clp.ins.Count - 1].sbr = new sbr();
                state.clp.ins[state.clp.ins.Count - 1].sbr.add1 = address.AddressLine1;
                state.clp.ins[state.clp.ins.Count - 1].sbr.add2 = address.AddressLine2;
            }
            var location = loop.GetElement(2) as N4;
            if (location != null)
            {
                if (state.clp.ins[state.clp.ins.Count - 1].sbr == null)
                    state.clp.ins[state.clp.ins.Count - 1].sbr = new sbr();
                state.clp.ins[state.clp.ins.Count - 1].sbr.city = location.City;
                state.clp.ins[state.clp.ins.Count - 1].sbr.state = location.State;
                state.clp.ins[state.clp.ins.Count - 1].sbr.zip = location.PostalCode;
                state.clp.ins[state.clp.ins.Count - 1].sbr.country = location.CountryCode;
                state.clp.ins[state.clp.ins.Count - 1].sbr.countrysub = location.CountrySubCode;
            }
            var secondaryId = loop.GetElement(3) as REF;
            if (secondaryId != null)
            {
                if (state.clp.ins[state.clp.ins.Count - 1].sbr == null)
                    state.clp.ins[state.clp.ins.Count - 1].sbr = new sbr();
                state.clp.ins[state.clp.ins.Count - 1].sbr.tin = secondaryId.Id;
            }
        }
        public static void Convert2330B(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var name = loop.GetElement(0) as NM1;
            if (name != null)
            {
                if (state.clp.ins[state.clp.ins.Count - 1].payer == null)
                    state.clp.ins[state.clp.ins.Count - 1].payer = new List<payer>();
                state.clp.ins[state.clp.ins.Count - 1].payer.Add(new payer());
                state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].name = name.LastName;
            }
            var address = loop.GetElement(1) as N3;
            if (address != null)
            {
                if (state.clp.ins[state.clp.ins.Count - 1].payer == null)
                    state.clp.ins[state.clp.ins.Count - 1].payer = new List<payer>();
                state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].add1 = address.AddressLine1;
                state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].add2 = address.AddressLine2;
            }
            var location = loop.GetElement(2) as N4;
            if (location != null)
            {
                if (state.clp.ins[state.clp.ins.Count - 1].payer == null)
                    state.clp.ins[state.clp.ins.Count - 1].payer = new List<payer>();
                state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].city = location.City;
                state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].state = location.State;
                state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].zip = location.PostalCode;
                state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].country = location.CountryCode;
                state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].countrysub = location.CountrySubCode;
            }
            var checkRemittanceDate = loop.GetElement(3) as DTP;
            if (checkRemittanceDate != null)
            {
                if (state.clp.ins[state.clp.ins.Count - 1].insinfo == null)
                    state.clp.ins[state.clp.ins.Count - 1].insinfo = new insinfo();
                state.clp.ins[state.clp.ins.Count - 1].insinfo.claimpaiddate = checkRemittanceDate.TimePeriod;
            }
            var secondaryIds = loop.GetElements(4) as REF[];
            if (secondaryIds != null)
                foreach (var secondaryId in secondaryIds)
                {
                    if (state.clp.ins[state.clp.ins.Count - 1].payer == null)
                        state.clp.ins[state.clp.ins.Count - 1].payer = new List<payer>();
                    state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].extpayerid = secondaryId.Id;
                }
            //var secondaryIds = loop.GetElements(4) as REF[];
            //if (secondaryIds != null)
            //    foreach (var secondaryId in secondaryIds)
            //    {
            //        if (state.clp.ins[state.clp.ins.Count - 1].payer == null)
            //            state.clp.ins[state.clp.ins.Count - 1].payer = new List<payer>();
            //        state.clp.ins[state.clp.ins.Count - 1].payer[state.clp.ins[state.clp.ins.Count - 1].payer.Count - 1].tin = secondaryId.Id;
            //    }
            var authorizationNumber = loop.GetElement(5) as REF;
            if (authorizationNumber != null)
            {
                if (state.clp.ins[state.clp.ins.Count - 1].insinfo == null)
                    state.clp.ins[state.clp.ins.Count - 1].insinfo = new insinfo();
                state.clp.ins[state.clp.ins.Count - 1].insinfo.priorauth = authorizationNumber.Id;
            }
            var referalNumber = loop.GetElement(6) as REF;
            if (referalNumber != null)
            {
                if (state.clp.ins[state.clp.ins.Count - 1].insinfo == null)
                    state.clp.ins[state.clp.ins.Count - 1].insinfo = new insinfo();
                state.clp.ins[state.clp.ins.Count - 1].insinfo.referralnum = referalNumber.Id;
            }
            var adjustmentIndicator = loop.GetElement(7) as REF;
            if (adjustmentIndicator != null)
            {
                if (state.clp.ins[state.clp.ins.Count - 1].insinfo == null)
                    state.clp.ins[state.clp.ins.Count - 1].insinfo = new insinfo();
                state.clp.ins[state.clp.ins.Count - 1].insinfo.claimadjustind = adjustmentIndicator.Id;
            }
        }
        public static void Convert2330C(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var secondaryIds = loop.GetElements(1) as REF[];
            if (secondaryIds != null)
                foreach (var secondaryId in secondaryIds)
                {
                    if (state.clp.ins[state.clp.ins.Count - 1].insinfo.@ref.secid == null)
                        state.clp.ins[state.clp.ins.Count - 1].insinfo.@ref.secid = new List<secid>();
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.@ref.secid.Add(new secid());
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.@ref.secid[state.clp.ins[state.clp.ins.Count - 1].insinfo.@ref.secid.Count - 1].qual = secondaryId.IdQualifier;
                    if (state.clp.ins[state.clp.ins.Count - 1].insinfo.pcp.secid == null)
                        state.clp.ins[state.clp.ins.Count - 1].insinfo.pcp.secid = new List<secid>();
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.pcp.secid.Add(new secid());
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.pcp.secid[state.clp.ins[state.clp.ins.Count - 1].insinfo.pcp.secid.Count - 1].qual = secondaryId.IdQualifier;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.@ref.secid[state.clp.ins[state.clp.ins.Count - 1].insinfo.@ref.secid.Count - 1].num = secondaryId.Id;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.pcp.secid[state.clp.ins[state.clp.ins.Count - 1].insinfo.pcp.secid.Count - 1].num = secondaryId.Id;
                }
        }
        public static void Convert2330D(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var secondaryIds = loop.GetElements(1) as REF[];
            if (secondaryIds != null)
                foreach (var secondaryId in secondaryIds)
                {
                    if (state.clp.ins[state.clp.ins.Count - 1].insinfo.ren.secid == null)
                        state.clp.ins[state.clp.ins.Count - 1].insinfo.ren.secid = new List<secid>();
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.ren.secid.Add(new secid());
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.ren.secid[state.clp.ins[state.clp.ins.Count - 1].insinfo.ren.secid.Count - 1].qual = secondaryId.IdQualifier;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.ren.secid[state.clp.ins[state.clp.ins.Count - 1].insinfo.ren.secid.Count - 1].num = secondaryId.Id;
                }
        }
        public static void Convert2330E(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var secondaryIds = loop.GetElements(1) as REF[];
            if (secondaryIds != null)
                foreach (var secondaryId in secondaryIds)
                {
                    if (state.clp.ins[state.clp.ins.Count - 1].insinfo.fac.secid == null)
                        state.clp.ins[state.clp.ins.Count - 1].insinfo.fac.secid = new List<secid>();
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.fac.secid.Add(new secid());
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.fac.secid[state.clp.ins[state.clp.ins.Count - 1].insinfo.fac.secid.Count - 1].qual = secondaryId.IdQualifier;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.fac.secid[state.clp.ins[state.clp.ins.Count - 1].insinfo.fac.secid.Count - 1].num = secondaryId.Id;
                }
        }
        public static void Convert2330F(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var secondaryIds = loop.GetElements(1) as REF[];
            if (secondaryIds != null)
                foreach (var secondaryId in secondaryIds)
                {
                    if (state.clp.ins[state.clp.ins.Count - 1].insinfo.sup.secid == null)
                        state.clp.ins[state.clp.ins.Count - 1].insinfo.sup.secid = new List<secid>();
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.sup.secid.Add(new secid());
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.sup.secid[state.clp.ins[state.clp.ins.Count - 1].insinfo.sup.secid.Count - 1].qual = secondaryId.IdQualifier;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.sup.secid[state.clp.ins[state.clp.ins.Count - 1].insinfo.sup.secid.Count - 1].num = secondaryId.Id;
                }
        }
        public static void Convert2330G(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var secondaryIds = loop.GetElements(1) as REF[];
            if (secondaryIds != null)
                foreach (var secondaryId in secondaryIds)
                {
                    if (state.clp.ins[state.clp.ins.Count - 1].insinfo.bill.secid == null)
                        state.clp.ins[state.clp.ins.Count - 1].insinfo.bill.secid = new List<secid>();
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.bill.secid.Add(new secid());
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.bill.secid[state.clp.ins[state.clp.ins.Count - 1].insinfo.bill.secid.Count - 1].qual = secondaryId.IdQualifier;
                    state.clp.ins[state.clp.ins.Count - 1].insinfo.bill.secid[state.clp.ins[state.clp.ins.Count - 1].insinfo.bill.secid.Count - 1].num = secondaryId.Id;
                }
        }
        public static void Convert2400(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var lineNumber = loop.GetElement(0) as LX;
            if (lineNumber != null)
            {
                if (state.clp.ln == null)
                    state.clp.ln = new List<ln>();
                state.clp.ln.Add(new ln());
                state.clp.ln[state.clp.ln.Count - 1].seq = Convert.ToInt32(lineNumber.AssignedNumber);
            }
            var professionalService = loop.GetElement(1) as SV1;
            if (professionalService != null)
            {
                if (state.clp.ln == null)
                    state.clp.ln = new List<ln>();
                state.clp.ln.Add(new ln());
                state.clp.ln[state.clp.ln.Count - 1].chg = professionalService.Amount;
                state.clp.ln[state.clp.ln.Count - 1].uom = professionalService.UnitOfMeasure;
                state.clp.ln[state.clp.ln.Count - 1].qty = professionalService.Quantity;
                state.clp.ln[state.clp.ln.Count - 1].pos = professionalService.FacilityCodeValue;
                state.clp.ln[state.clp.ln.Count - 1].emergency = professionalService.YesNo;
                state.clp.ln[state.clp.ln.Count - 1].epsdt = professionalService.YesNo2;
                state.clp.ln[state.clp.ln.Count - 1].familyplan = professionalService.YesNo3;
                state.clp.ln[state.clp.ln.Count - 1].copaystatus = professionalService.CopayStatusCode;
            }
            var medicalEqupmentService = loop.GetElement(2) as SV5;
            if (medicalEqupmentService != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].dme == null)
                    state.clp.ln[state.clp.ln.Count - 1].dme = new dme();
                state.clp.ln[state.clp.ln.Count - 1].dme.qty = medicalEqupmentService.Quantity;
                state.clp.ln[state.clp.ln.Count - 1].dme.rentalamt = medicalEqupmentService.Amount1;
                state.clp.ln[state.clp.ln.Count - 1].dme.purchaseamt = medicalEqupmentService.Amount2;
                state.clp.ln[state.clp.ln.Count - 1].dme.frequency = medicalEqupmentService.FrequencyCode;
            }
            var lineSupplementals = loop.GetElements(3) as PWK[];
            if (lineSupplementals != null)
                foreach (var lineSupplemental in lineSupplementals)
                {
                    if (state.clp.ln[state.clp.ln.Count - 1].attach == null)
                        state.clp.ln[state.clp.ln.Count - 1].attach = new List<attach>();
                    state.clp.ln[state.clp.ln.Count - 1].attach.Add(new attach());
                    state.clp.ln[state.clp.ln.Count - 1].attach[state.clp.ln[state.clp.ln.Count - 1].attach.Count - 1].type = lineSupplemental.ReportType;
                    state.clp.ln[state.clp.ln.Count - 1].attach[state.clp.ln[state.clp.ln.Count - 1].attach.Count - 1].trans = lineSupplemental.ReportTransmissionCode;
                    state.clp.ln[state.clp.ln.Count - 1].attach[state.clp.ln[state.clp.ln.Count - 1].attach.Count - 1].num = lineSupplemental.IdCode;
                }
            var equipmentCertificateIndicator = loop.GetElement(4) as PWK;
            if (equipmentCertificateIndicator != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].dme == null)
                    state.clp.ln[state.clp.ln.Count - 1].dme = new dme();
                state.clp.ln[state.clp.ln.Count - 1].dme.transcode = equipmentCertificateIndicator.ReportTransmissionCode;
            }
            var ambulanceTransport = loop.GetElement(5) as CR1;
            if (ambulanceTransport != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].amb == null)
                    state.clp.ln[state.clp.ln.Count - 1].amb = new amb();
                state.clp.ln[state.clp.ln.Count - 1].amb.weight = ambulanceTransport.Weight;
                state.clp.ln[state.clp.ln.Count - 1].amb.transreason = ambulanceTransport.TransportReason;
                state.clp.ln[state.clp.ln.Count - 1].amb.distance = ambulanceTransport.Distance;
                state.clp.ln[state.clp.ln.Count - 1].amb.roundtrip = ambulanceTransport.Description;
                state.clp.ln[state.clp.ln.Count - 1].amb.stretcher = ambulanceTransport.Description2;
            }
            var medicalEquipmentCertification = loop.GetElement(6) as CR3;
            if (medicalEquipmentCertification != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].dme == null)
                    state.clp.ln[state.clp.ln.Count - 1].dme = new dme();
                state.clp.ln[state.clp.ln.Count - 1].dme.certtype = medicalEquipmentCertification.TypeCode;
                state.clp.ln[state.clp.ln.Count - 1].dme.duration = medicalEquipmentCertification.Quantity;
            }
            var ambulanceCertifications = loop.GetElements(7) as CRC[];
            if (ambulanceCertifications != null)
                foreach (var ambulanceCertification in ambulanceCertifications)
                {
                    if (state.clp.ln[state.clp.ln.Count - 1].dme.condition == null)
                        state.clp.ln[state.clp.ln.Count - 1].dme.condition = new List<condition>();
                    state.clp.ln[state.clp.ln.Count - 1].dme.condition.Add(new condition());
                    state.clp.ln[state.clp.ln.Count - 1].dme.condition[state.clp.ln[state.clp.ln.Count - 1].dme.condition.Count - 1].applies = ambulanceCertification.YesNo;
                    if (state.clp.ln[state.clp.ln.Count - 1].amb.condition == null)
                        state.clp.ln[state.clp.ln.Count - 1].amb.condition = new List<condition>();
                    state.clp.ln[state.clp.ln.Count - 1].amb.condition.Add(new condition());
                    state.clp.ln[state.clp.ln.Count - 1].amb.condition[state.clp.ln[state.clp.ln.Count - 1].amb.condition.Count - 1].code = ambulanceCertification.ConditionIndicator1;
                    state.clp.ln[state.clp.ln.Count - 1].amb.condition[state.clp.ln[state.clp.ln.Count - 1].amb.condition.Count - 1].code = ambulanceCertification.ConditionIndicator2;
                    state.clp.ln[state.clp.ln.Count - 1].amb.condition[state.clp.ln[state.clp.ln.Count - 1].amb.condition.Count - 1].code = ambulanceCertification.ConditionIndicator3;
                    state.clp.ln[state.clp.ln.Count - 1].amb.condition[state.clp.ln[state.clp.ln.Count - 1].amb.condition.Count - 1].code = ambulanceCertification.ConditionIndicator4;
                    state.clp.ln[state.clp.ln.Count - 1].amb.condition[state.clp.ln[state.clp.ln.Count - 1].amb.condition.Count - 1].code = ambulanceCertification.ConditionIndicator5;
                }
            var serviceDate = loop.GetElement(10) as DTP;
            if (serviceDate != null)
            {
                if (state.clp.ln == null)
                    state.clp.ln = new List<ln>();
                state.clp.ln.Add(new ln());
                state.clp.ln[state.clp.ln.Count - 1].servicefromdate = serviceDate.TimePeriod;
                state.clp.ln[state.clp.ln.Count - 1].servicetodate = serviceDate.TimePeriod;
            }
            var perscription = loop.GetElement(11) as DTP;
            if (perscription != null)
            {
                if (state.clp.ln == null)
                    state.clp.ln = new List<ln>();
                state.clp.ln.Add(new ln());
                state.clp.ln[state.clp.ln.Count - 1].prescriptiondate = perscription.TimePeriod;
            }
            var certificationRevision = loop.GetElement(12) as DTP;
            if (certificationRevision != null)
            {
                if (state.clp.ln == null)
                    state.clp.ln = new List<ln>();
                state.clp.ln.Add(new ln());
                state.clp.ln[state.clp.ln.Count - 1].certrevisiondate = certificationRevision.TimePeriod;
            }
            var lastSeen = loop.GetElement(15) as DTP;
            if (lastSeen != null)
            {
                if (state.clp.ln == null)
                    state.clp.ln = new List<ln>();
                state.clp.ln.Add(new ln());
                state.clp.ln[state.clp.ln.Count - 1].lastseendate = lastSeen.TimePeriod;
            }
            var tests = loop.GetElements(16) as DTP[];
            if (tests != null)
                foreach (var test in tests)
                {
                    if (test.Qualifier == "738")
                        state.clp.ln[state.clp.ln.Count - 1].hemtestdate = test.TimePeriod;
                    else
                        state.clp.ln[state.clp.ln.Count - 1].serumtestdate = test.TimePeriod;
                }
            var lastXRay = loop.GetElement(18) as DTP;
            if (lastXRay != null)
            {
                if (state.clp.ln == null)
                    state.clp.ln = new List<ln>();
                state.clp.ln.Add(new ln());
                state.clp.ln[state.clp.ln.Count - 1].xraydate = lastXRay.TimePeriod;
            }
            var initialTreatment = loop.GetElement(19) as DTP;
            if (initialTreatment != null)
            {
                if (state.clp.ln == null)
                    state.clp.ln = new List<ln>();
                state.clp.ln.Add(new ln());
                state.clp.ln[state.clp.ln.Count - 1].inittreatdate = initialTreatment.TimePeriod;
            }
            var ambulancePatientcount = loop.GetElement(20) as QTY;
            if (ambulancePatientcount != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].amb == null)
                    state.clp.ln[state.clp.ln.Count - 1].amb = new amb();
                state.clp.ln[state.clp.ln.Count - 1].amb.qty = ambulancePatientcount.Quantity;
            }
            var obstetricAnesthesiaAdditionalUnits = loop.GetElement(21) as QTY;
            if (obstetricAnesthesiaAdditionalUnits != null)
            {
                if (state.clp.ln == null)
                    state.clp.ln = new List<ln>();
                state.clp.ln.Add(new ln());
                state.clp.ln[state.clp.ln.Count - 1].anesthesiaqty = obstetricAnesthesiaAdditionalUnits.Quantity;
            }
            var contact = loop.GetElement(23) as CN1;
            if (contact != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].contract == null)
                    state.clp.ln[state.clp.ln.Count - 1].contract = new contract();
                state.clp.ln[state.clp.ln.Count - 1].contract.type = contact.TypeCode;
                state.clp.ln[state.clp.ln.Count - 1].contract.amt = contact.MonetaryAmount;
                state.clp.ln[state.clp.ln.Count - 1].contract.percent = contact.Percent;
                state.clp.ln[state.clp.ln.Count - 1].contract.code = contact.ReferenceIdentifier;
                state.clp.ln[state.clp.ln.Count - 1].contract.discount = contact.TermsDiscountPercent;
                state.clp.ln[state.clp.ln.Count - 1].contract.version = contact.VersionId;
            }
            var repricdLineItemNumber = loop.GetElement(24) as REF;
            if (repricdLineItemNumber != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].reprice == null)
                    state.clp.ln[state.clp.ln.Count - 1].reprice = new reprice();
                state.clp.ln[state.clp.ln.Count - 1].reprice.lineref = repricdLineItemNumber.Id;
            }
            var adujstedRepricedLineNumber = loop.GetElement(25) as REF;
            if (adujstedRepricedLineNumber != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].reprice == null)
                    state.clp.ln[state.clp.ln.Count - 1].reprice = new reprice();
                state.clp.ln[state.clp.ln.Count - 1].reprice.adjlineref = adujstedRepricedLineNumber.Id;
            }
            var priorAuthorization = loop.GetElement(26) as REF;
            if (priorAuthorization != null)
            {
                state.clp.ins[state.clp.ins.Count - 1].insinfo.priorauth = priorAuthorization.Id;
               
            }
            var lineItemControlNumber = loop.GetElement(27) as REF;
            if (lineItemControlNumber != null)
            {
                if (state.clp.ln == null)
                    state.clp.ln = new List<ln>();
                state.clp.ln.Add(new ln());
                state.clp.ln[state.clp.ln.Count - 1].lineref = lineItemControlNumber.Id;
            }
            var mammographyCertificationNumber = loop.GetElement(28) as REF;
            if (mammographyCertificationNumber != null)
            {
                if (state.clp.ln == null)
                    state.clp.ln = new List<ln>();
                state.clp.ln.Add(new ln());
                state.clp.ln[state.clp.ln.Count - 1].mamcert = mammographyCertificationNumber.Id;
            }
            var cLIANumber = loop.GetElement(29) as REF;
            if (cLIANumber != null)
            {
                if (state.clp.ln == null)
                    state.clp.ln = new List<ln>();
                state.clp.ln.Add(new ln());
                state.clp.ln[state.clp.ln.Count - 1].clia = cLIANumber.Id;
            }
            var cLIAId = loop.GetElement(30) as REF;
            if (cLIAId != null)
            {
                if (state.clp.ln == null)
                    state.clp.ln = new List<ln>();
                state.clp.ln.Add(new ln());
                state.clp.ln[state.clp.ln.Count - 1].referclia = cLIAId.Id;
            }
            var immunizationBatch = loop.GetElement(31) as REF;
            if (immunizationBatch != null)
            {
                if (state.clp.ln == null)
                    state.clp.ln = new List<ln>();
                state.clp.ln.Add(new ln());
                state.clp.ln[state.clp.ln.Count - 1].immbatnum = immunizationBatch.Id;
            }
            var referralNumbers = loop.GetElements(32) as REF[];
            if (referralNumbers != null)
                foreach (var referralNumber in referralNumbers)
                {
                    if (state.clp.lnins[state.clp.lnins.Count - 1].referral == null)
                        state.clp.lnins[state.clp.lnins.Count - 1].referral = new referral();
                    state.clp.lnins[state.clp.lnins.Count - 1].referral.number = referralNumber.Id;
                }
            var fileInfos = loop.GetElements(35) as K3[];
            if (fileInfos != null)
                foreach (var fileInfo in fileInfos)
                {
                    if (state.clp.ln[state.clp.ln.Count - 1].k3note == null)
                        state.clp.ln[state.clp.ln.Count - 1].k3note = new k3note();
                    state.clp.ln[state.clp.ln.Count - 1].k3note.note = fileInfo.FixedFormatInfomation;
                }
            var lineNote = loop.GetElement(36) as NTE;
            if (lineNote != null)
            {
                if (state.clp.ln == null)
                    state.clp.ln = new List<ln>();
                state.clp.ln.Add(new ln());
                state.clp.ln[state.clp.ln.Count - 1].notequal = lineNote.ReferenceCode;
                state.clp.ln[state.clp.ln.Count - 1].note = lineNote.Description;
            }
            var purchasedServiceInfo = loop.GetElement(38) as PS1;
            if (purchasedServiceInfo != null)
            {
                if (state.clp.ln == null)
                    state.clp.ln = new List<ln>();
                state.clp.ln.Add(new ln());
                state.clp.ln[state.clp.ln.Count - 1].purchprovid = purchasedServiceInfo.ReferenceId;
                state.clp.ln[state.clp.ln.Count - 1].purchamt = purchasedServiceInfo.Amount;
            }
            var linePricing = loop.GetElement(39) as HCP;
            if (linePricing != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].reprice == null)
                    state.clp.ln[state.clp.ln.Count - 1].reprice = new reprice();
                state.clp.ln[state.clp.ln.Count - 1].reprice.method = linePricing.Methodology;
                state.clp.ln[state.clp.ln.Count - 1].reprice.allowedamt = linePricing.Amount;
                state.clp.ln[state.clp.ln.Count - 1].reprice.savingsamt = linePricing.SavingAmount;
                state.clp.ln[state.clp.ln.Count - 1].reprice.organizationid = linePricing.ReferenceIdentifier;
                state.clp.ln[state.clp.ln.Count - 1].reprice.rate = linePricing.Rate;
                state.clp.ln[state.clp.ln.Count - 1].reprice.approvedapgcode = linePricing.ReferenceIdentifier2;
                state.clp.ln[state.clp.ln.Count - 1].reprice.approvedapgamt = linePricing.Amount2;
                state.clp.ln[state.clp.ln.Count - 1].reprice.proctype = linePricing.ProductServiceIdQualifier;
                state.clp.ln[state.clp.ln.Count - 1].reprice.proccode = linePricing.ProductServiceId2;
                state.clp.ln[state.clp.ln.Count - 1].reprice.uom = linePricing.UnitOfMeasurementCode;
                state.clp.ln[state.clp.ln.Count - 1].reprice.qty = linePricing.quantity;
                state.clp.ln[state.clp.ln.Count - 1].reprice.rejectreason = linePricing.RejectReasonCode;
                state.clp.ln[state.clp.ln.Count - 1].reprice.policycompliance = linePricing.PolicyComplianceCode;
                state.clp.ln[state.clp.ln.Count - 1].reprice.exceptioncode = linePricing.ExceptionCode;
            }
            Convert2410(loop.GetLoop("2410"), state);
            Convert2420A(loop.GetLoop("2420A"), state);
            Convert2420B(loop.GetLoop("2420B"), state);
            Convert2420C(loop.GetLoop("2420C"), state);
            Convert2420D(loop.GetLoop("2420D"), state);
            Convert2420E(loop.GetLoop("2420E"), state);
            Convert2420F(loop.GetLoop("2420F"), state);
            Convert2420G(loop.GetLoop("2420G"), state);
            Convert2420H(loop.GetLoop("2420H"), state);
            Convert2430(loop.GetLoop("2430"), state);
            Convert2440(loop.GetLoop("2440"), state);
        }
        public static void Convert2410(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var indentification = loop.GetElement(0) as LIN;
            if (indentification != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].drug == null)
                    state.clp.ln[state.clp.ln.Count - 1].drug = new List<drug>();
                state.clp.ln[state.clp.ln.Count - 1].drug.Add(new drug());
                state.clp.ln[state.clp.ln.Count - 1].drug[state.clp.ln[state.clp.ln.Count - 1].drug.Count - 1].ndcqual = indentification.ProductServiceQualifier;
                state.clp.ln[state.clp.ln.Count - 1].drug[state.clp.ln[state.clp.ln.Count - 1].drug.Count - 1].ndccode = indentification.ProductServiceId;
            }
            var quantity = loop.GetElement(1) as CTP;
            if (quantity != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].drug == null)
                    state.clp.ln[state.clp.ln.Count - 1].drug = new List<drug>();
                state.clp.ln[state.clp.ln.Count - 1].drug.Add(new drug());
                state.clp.ln[state.clp.ln.Count - 1].drug[state.clp.ln[state.clp.ln.Count - 1].drug.Count - 1].qty = quantity.Quantity;
            }
            var perscription = loop.GetElement(2) as REF;
            if (perscription != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].drug == null)
                    state.clp.ln[state.clp.ln.Count - 1].drug = new List<drug>();
                state.clp.ln[state.clp.ln.Count - 1].drug.Add(new drug());
                state.clp.ln[state.clp.ln.Count - 1].drug[state.clp.ln[state.clp.ln.Count - 1].drug.Count - 1].prescriptionnumqual = perscription.IdQualifier;
                state.clp.ln[state.clp.ln.Count - 1].drug[state.clp.ln[state.clp.ln.Count - 1].drug.Count - 1].prescriptionnum = perscription.Id;
            }
        }
        public static void Convert2420A(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var name = loop.GetElement(0) as NM1;
            if (name != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].ren == null)
                    state.clp.ln[state.clp.ln.Count - 1].ren = new ren();
                state.clp.ln[state.clp.ln.Count - 1].ren.entitytype = Convert.ToSByte(name.EntityTypeQualifier);
                state.clp.ln[state.clp.ln.Count - 1].ren.lname = name.LastName;
                state.clp.ln[state.clp.ln.Count - 1].ren.fname = name.FirstName;
                state.clp.ln[state.clp.ln.Count - 1].ren.mname = name.MiddleName;
                state.clp.ln[state.clp.ln.Count - 1].ren.suffix = name.NameSuffix;
                state.clp.ln[state.clp.ln.Count - 1].ren.npi = name.IdCode;
            }
            var secondaryIds = loop.GetElements(2) as REF[];
            if (secondaryIds != null)
                foreach (var secondaryId in secondaryIds)
                {
                    if (state.clp.ln[state.clp.ln.Count - 1].ren == null)
                        state.clp.ln[state.clp.ln.Count - 1].ren = new ren();
                    state.clp.ln[state.clp.ln.Count - 1].ren.provnumqual = secondaryId.IdQualifier;
                    if (state.clp.ln[state.clp.ln.Count - 1].ren.secid == null)
                        state.clp.ln[state.clp.ln.Count - 1].ren.secid = new List<secid>();
                    state.clp.ln[state.clp.ln.Count - 1].ren.secid.Add(new secid());
                    state.clp.ln[state.clp.ln.Count - 1].ren.secid[state.clp.ln[state.clp.ln.Count - 1].ren.secid.Count - 1].qual = secondaryId.IdQualifier;
                    state.clp.ln[state.clp.ln.Count - 1].ren.provnum = secondaryId.Id;
                    state.clp.ln[state.clp.ln.Count - 1].ren.secid[state.clp.ln[state.clp.ln.Count - 1].ren.secid.Count - 1].num = secondaryId.Id;
                }
        }
        public static void Convert2420B(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var name = loop.GetElement(0) as NM1;
            if (name != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].purch == null)
                    state.clp.ln[state.clp.ln.Count - 1].purch = new purch();
                state.clp.ln[state.clp.ln.Count - 1].purch.entitytype = Convert.ToSByte(name.EntityTypeQualifier);
                state.clp.ln[state.clp.ln.Count - 1].purch.npi = name.IdCode;
            }
            var secondaryInfos = loop.GetElements(1) as REF[];
            if (secondaryInfos != null)
                foreach (var secondaryInfo in secondaryInfos)
                {
                    if (state.clp.ln[state.clp.ln.Count - 1].purch == null)
                        state.clp.ln[state.clp.ln.Count - 1].purch = new purch();
                    state.clp.ln[state.clp.ln.Count - 1].purch.provnumqual = secondaryInfo.IdQualifier;
                    if (state.clp.ln[state.clp.ln.Count - 1].purch.secid == null)
                        state.clp.ln[state.clp.ln.Count - 1].purch.secid = new List<secid>();
                    state.clp.ln[state.clp.ln.Count - 1].purch.secid.Add(new secid());
                    state.clp.ln[state.clp.ln.Count - 1].purch.secid[state.clp.ln[state.clp.ln.Count - 1].purch.secid.Count - 1].qual = secondaryInfo.IdQualifier;
                    state.clp.ln[state.clp.ln.Count - 1].purch.provnum = secondaryInfo.Id;
                    state.clp.ln[state.clp.ln.Count - 1].purch.secid[state.clp.ln[state.clp.ln.Count - 1].purch.secid.Count - 1].num = secondaryInfo.Id;
                }
        }
        public static void Convert2420C(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var name = loop.GetElement(0) as NM1;
            if (name != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].fac == null)
                    state.clp.ln[state.clp.ln.Count - 1].fac = new fac();
                state.clp.ln[state.clp.ln.Count - 1].fac.type = name.EntityIdCode;
                state.clp.ln[state.clp.ln.Count - 1].fac.name = name.LastName;
                state.clp.ln[state.clp.ln.Count - 1].fac.npi = name.IdCode;
            }
            var address = loop.GetElement(1) as N3;
            if (address != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].fac == null)
                    state.clp.ln[state.clp.ln.Count - 1].fac = new fac();
                state.clp.ln[state.clp.ln.Count - 1].fac.add1 = address.AddressLine1;
                state.clp.ln[state.clp.ln.Count - 1].fac.add2 = address.AddressLine2;
            }
            var location = loop.GetElement(2) as N4;
            if (location != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].fac == null)
                    state.clp.ln[state.clp.ln.Count - 1].fac = new fac();
                state.clp.ln[state.clp.ln.Count - 1].fac.city = location.City;
                state.clp.ln[state.clp.ln.Count - 1].fac.state = location.State;
                state.clp.ln[state.clp.ln.Count - 1].fac.zip = location.PostalCode;
                state.clp.ln[state.clp.ln.Count - 1].fac.country = location.CountryCode;
                state.clp.ln[state.clp.ln.Count - 1].fac.countrysub = location.CountrySubCode;
            }
            var secondaryIds = loop.GetElements(3) as REF[];
            if (secondaryIds != null)
                foreach (var secondaryId in secondaryIds)
                {
                    if (state.clp.ln[state.clp.ln.Count - 1].fac == null)
                        state.clp.ln[state.clp.ln.Count - 1].fac = new fac();
                    state.clp.ln[state.clp.ln.Count - 1].fac.provnumqual = secondaryId.IdQualifier;
                    if (state.clp.ln[state.clp.ln.Count - 1].fac.secid == null)
                        state.clp.ln[state.clp.ln.Count - 1].fac.secid = new List<secid>();
                    state.clp.ln[state.clp.ln.Count - 1].fac.secid.Add(new secid());
                    state.clp.ln[state.clp.ln.Count - 1].fac.secid[state.clp.ln[state.clp.ln.Count - 1].fac.secid.Count - 1].qual = secondaryId.IdQualifier;
                    state.clp.ln[state.clp.ln.Count - 1].fac.provnum = secondaryId.Id;
                    state.clp.ln[state.clp.ln.Count - 1].fac.secid[state.clp.ln[state.clp.ln.Count - 1].fac.secid.Count - 1].num = secondaryId.Id;
                }
        }
        public static void Convert2420D(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var name = loop.GetElement(0) as NM1;
            if (name != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].sup == null)
                    state.clp.ln[state.clp.ln.Count - 1].sup = new sup();
                state.clp.ln[state.clp.ln.Count - 1].sup.entitytype = Convert.ToSByte(name.EntityTypeQualifier);
                state.clp.ln[state.clp.ln.Count - 1].sup.lname = name.LastName;
                state.clp.ln[state.clp.ln.Count - 1].sup.fname = name.FirstName;
                state.clp.ln[state.clp.ln.Count - 1].sup.mname = name.MiddleName;
                state.clp.ln[state.clp.ln.Count - 1].sup.suffix = name.NameSuffix;
                state.clp.ln[state.clp.ln.Count - 1].sup.npi = name.IdCode;
            }
            var secondaryIds = loop.GetElements(1) as REF[];
            if (secondaryIds != null)
                foreach (var secondaryId in secondaryIds)
                {
                    if (state.clp.ln[state.clp.ln.Count - 1].sup == null)
                        state.clp.ln[state.clp.ln.Count - 1].sup = new sup();
                    state.clp.ln[state.clp.ln.Count - 1].sup.provnumqual = secondaryId.IdQualifier;
                    if (state.clp.ln[state.clp.ln.Count - 1].sup.secid == null)
                        state.clp.ln[state.clp.ln.Count - 1].sup.secid = new List<secid>();
                    state.clp.ln[state.clp.ln.Count - 1].sup.secid.Add(new secid());
                    state.clp.ln[state.clp.ln.Count - 1].sup.secid[state.clp.ln[state.clp.ln.Count - 1].sup.secid.Count - 1].qual = secondaryId.IdQualifier;
                    state.clp.ln[state.clp.ln.Count - 1].sup.provnum = secondaryId.Id;
                    state.clp.ln[state.clp.ln.Count - 1].sup.secid[state.clp.ln[state.clp.ln.Count - 1].sup.secid.Count - 1].num = secondaryId.Id;
                }
        }
        public static void Convert2420E(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var name = loop.GetElement(0) as NM1;
            if (name != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].ord == null)
                    state.clp.ln[state.clp.ln.Count - 1].ord = new ord();
                state.clp.ln[state.clp.ln.Count - 1].ord.entitytype = Convert.ToSByte(name.EntityTypeQualifier);
                state.clp.ln[state.clp.ln.Count - 1].ord.lname = name.LastName;
                state.clp.ln[state.clp.ln.Count - 1].ord.fname = name.FirstName;
                state.clp.ln[state.clp.ln.Count - 1].ord.mname = name.MiddleName;
                state.clp.ln[state.clp.ln.Count - 1].ord.suffix = name.NameSuffix;
                state.clp.ln[state.clp.ln.Count - 1].ord.npi = name.IdCode;
            }
            var address = loop.GetElement(1) as N3;
            if (address != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].ord == null)
                    state.clp.ln[state.clp.ln.Count - 1].ord = new ord();
                state.clp.ln[state.clp.ln.Count - 1].ord.add1 = address.AddressLine1;
                state.clp.ln[state.clp.ln.Count - 1].ord.add2 = address.AddressLine2;
            }
            var location = loop.GetElement(2) as N4;
            if (location != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].ord == null)
                    state.clp.ln[state.clp.ln.Count - 1].ord = new ord();
                state.clp.ln[state.clp.ln.Count - 1].ord.city = location.City;
                state.clp.ln[state.clp.ln.Count - 1].ord.state = location.State;
                state.clp.ln[state.clp.ln.Count - 1].ord.zip = location.PostalCode;
                state.clp.ln[state.clp.ln.Count - 1].ord.country = location.CountryCode;
                state.clp.ln[state.clp.ln.Count - 1].ord.countrysub = location.CountrySubCode;
            }
            var secondaryIds = loop.GetElements(3) as REF[];
            if (secondaryIds != null)
                foreach (var secondaryId in secondaryIds)
                {
                    if (state.clp.ln[state.clp.ln.Count - 1].ord == null)
                        state.clp.ln[state.clp.ln.Count - 1].ord = new ord();
                    state.clp.ln[state.clp.ln.Count - 1].ord.provnumqual = secondaryId.IdQualifier;
                    if (state.clp.ln[state.clp.ln.Count - 1].ord.secid == null)
                        state.clp.ln[state.clp.ln.Count - 1].ord.secid = new List<secid>();
                    state.clp.ln[state.clp.ln.Count - 1].ord.secid.Add(new secid());
                    state.clp.ln[state.clp.ln.Count - 1].ord.secid[state.clp.ln[state.clp.ln.Count - 1].ord.secid.Count - 1].qual = secondaryId.IdQualifier;
                    state.clp.ln[state.clp.ln.Count - 1].ord.provnum = secondaryId.Id;
                    state.clp.ln[state.clp.ln.Count - 1].ord.secid[state.clp.ln[state.clp.ln.Count - 1].ord.secid.Count - 1].num = secondaryId.Id;
                }
            var contact = loop.GetElement(4) as PER;
            if (contact != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].ord.contact == null)
                    state.clp.ln[state.clp.ln.Count - 1].ord.contact = new List<contact>();
                state.clp.ln[state.clp.ln.Count - 1].ord.contact.Add(new contact());
                state.clp.ln[state.clp.ln.Count - 1].ord.contact[state.clp.ln[state.clp.ln.Count - 1].ord.contact.Count - 1].name = contact.Name;
                if (state.clp.ln[state.clp.ln.Count - 1].ord.contact[state.clp.ln[state.clp.ln.Count - 1].ord.contact.Count - 1].contactnum == null)
                    state.clp.ln[state.clp.ln.Count - 1].ord.contact[state.clp.ln[state.clp.ln.Count - 1].ord.contact.Count - 1].contactnum = new List<contactnum>();
                state.clp.ln[state.clp.ln.Count - 1].ord.contact[state.clp.ln[state.clp.ln.Count - 1].ord.contact.Count - 1].contactnum.Add(new contactnum());
                state.clp.ln[state.clp.ln.Count - 1].ord.contact[state.clp.ln[state.clp.ln.Count - 1].ord.contact.Count - 1].contactnum[state.clp.ln[state.clp.ln.Count - 1].ord.contact[state.clp.ln[state.clp.ln.Count - 1].ord.contact.Count - 1].contactnum.Count - 1].qual = contact.CommunicationNumberQualifier;
                state.clp.ln[state.clp.ln.Count - 1].ord.contact[state.clp.ln[state.clp.ln.Count - 1].ord.contact.Count - 1].contactnum[state.clp.ln[state.clp.ln.Count - 1].ord.contact[state.clp.ln[state.clp.ln.Count - 1].ord.contact.Count - 1].contactnum.Count - 1].num = contact.CommunicationNumber;
                state.clp.ln[state.clp.ln.Count - 1].ord.contact[state.clp.ln[state.clp.ln.Count - 1].ord.contact.Count - 1].contactnum[state.clp.ln[state.clp.ln.Count - 1].ord.contact[state.clp.ln[state.clp.ln.Count - 1].ord.contact.Count - 1].contactnum.Count - 1].qual = contact.CommunicationNumberQualifier2;
                state.clp.ln[state.clp.ln.Count - 1].ord.contact[state.clp.ln[state.clp.ln.Count - 1].ord.contact.Count - 1].contactnum[state.clp.ln[state.clp.ln.Count - 1].ord.contact[state.clp.ln[state.clp.ln.Count - 1].ord.contact.Count - 1].contactnum.Count - 1].num = contact.CommunicationNumber2;
                state.clp.ln[state.clp.ln.Count - 1].ord.contact[state.clp.ln[state.clp.ln.Count - 1].ord.contact.Count - 1].contactnum[state.clp.ln[state.clp.ln.Count - 1].ord.contact[state.clp.ln[state.clp.ln.Count - 1].ord.contact.Count - 1].contactnum.Count - 1].qual = contact.CommunicationNumberQualifier3;
                state.clp.ln[state.clp.ln.Count - 1].ord.contact[state.clp.ln[state.clp.ln.Count - 1].ord.contact.Count - 1].contactnum[state.clp.ln[state.clp.ln.Count - 1].ord.contact[state.clp.ln[state.clp.ln.Count - 1].ord.contact.Count - 1].contactnum.Count - 1].num = contact.CommunicationNumber3;
            }
        }
        public static void Convert2420F(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var name = loop.GetElement(0) as NM1;
            if (name != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].@ref == null)
                    state.clp.ln[state.clp.ln.Count - 1].@ref = new @ref();
                state.clp.ln[state.clp.ln.Count - 1].@ref.entitytype = Convert.ToSByte(name.EntityTypeQualifier);
                if (state.clp.ln[state.clp.ln.Count - 1].pcp == null)
                    state.clp.ln[state.clp.ln.Count - 1].pcp = new pcp();
                state.clp.ln[state.clp.ln.Count - 1].pcp.entitytype = Convert.ToSByte(name.EntityTypeQualifier);
                state.clp.ln[state.clp.ln.Count - 1].@ref.lname = name.LastName;
                state.clp.ln[state.clp.ln.Count - 1].pcp.lname = name.LastName;
                state.clp.ln[state.clp.ln.Count - 1].@ref.fname = name.FirstName;
                state.clp.ln[state.clp.ln.Count - 1].pcp.fname = name.FirstName;
                state.clp.ln[state.clp.ln.Count - 1].@ref.mname = name.MiddleName;
                state.clp.ln[state.clp.ln.Count - 1].pcp.mname = name.MiddleName;
                state.clp.ln[state.clp.ln.Count - 1].@ref.suffix = name.NameSuffix;
                state.clp.ln[state.clp.ln.Count - 1].pcp.suffix = name.NameSuffix;
                state.clp.ln[state.clp.ln.Count - 1].@ref.npi = name.IdCode;
                state.clp.ln[state.clp.ln.Count - 1].pcp.npi = name.IdCode;
            }
            var secondaryId = loop.GetElement(1) as REF;
            if (secondaryId != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].@ref == null)
                    state.clp.ln[state.clp.ln.Count - 1].@ref = new @ref();
                state.clp.ln[state.clp.ln.Count - 1].@ref.provnumqual = secondaryId.IdQualifier;
                if (state.clp.ln[state.clp.ln.Count - 1].@ref.secid == null)
                    state.clp.ln[state.clp.ln.Count - 1].@ref.secid = new List<secid>();
                state.clp.ln[state.clp.ln.Count - 1].@ref.secid.Add(new secid());
                state.clp.ln[state.clp.ln.Count - 1].@ref.secid[state.clp.ln[state.clp.ln.Count - 1].@ref.secid.Count - 1].num = secondaryId.IdQualifier;
                if (state.clp.ln[state.clp.ln.Count - 1].pcp == null)
                    state.clp.ln[state.clp.ln.Count - 1].pcp = new pcp();
                state.clp.ln[state.clp.ln.Count - 1].pcp.provnumqual = secondaryId.IdQualifier;
                if (state.clp.ln[state.clp.ln.Count - 1].pcp.secid == null)
                    state.clp.ln[state.clp.ln.Count - 1].pcp.secid = new List<secid>();
                state.clp.ln[state.clp.ln.Count - 1].pcp.secid.Add(new secid());
                state.clp.ln[state.clp.ln.Count - 1].pcp.secid[state.clp.ln[state.clp.ln.Count - 1].pcp.secid.Count - 1].num = secondaryId.IdQualifier;
                state.clp.ln[state.clp.ln.Count - 1].@ref.provnum = secondaryId.Id;
                state.clp.ln[state.clp.ln.Count - 1].@ref.secid[state.clp.ln[state.clp.ln.Count - 1].@ref.secid.Count - 1].qual = secondaryId.Id;
                state.clp.ln[state.clp.ln.Count - 1].pcp.provnum = secondaryId.Id;
                state.clp.ln[state.clp.ln.Count - 1].pcp.secid[state.clp.ln[state.clp.ln.Count - 1].pcp.secid.Count - 1].qual = secondaryId.Id;
            }
        }
        public static void Convert2420G(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var address = loop.GetElement(1) as N3;
            if (address != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].amb.pickup == null)
                    state.clp.ln[state.clp.ln.Count - 1].amb.pickup = new pickup();
                state.clp.ln[state.clp.ln.Count - 1].amb.pickup.add1 = address.AddressLine1;
                state.clp.ln[state.clp.ln.Count - 1].amb.pickup.add2 = address.AddressLine2;
            }
            var location = loop.GetElement(2) as N4;
            if (location != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].amb.pickup == null)
                    state.clp.ln[state.clp.ln.Count - 1].amb.pickup = new pickup();
                state.clp.ln[state.clp.ln.Count - 1].amb.pickup.city = location.City;
                state.clp.ln[state.clp.ln.Count - 1].amb.pickup.state = location.State;
                state.clp.ln[state.clp.ln.Count - 1].amb.pickup.zip = location.PostalCode;
                state.clp.ln[state.clp.ln.Count - 1].amb.pickup.country = location.CountryCode;
                state.clp.ln[state.clp.ln.Count - 1].amb.pickup.countrysub = location.CountrySubCode;
            }
        }
        public static void Convert2420H(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var name = loop.GetElement(0) as NM1;
            if (name != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].amb.dropoff == null)
                    state.clp.ln[state.clp.ln.Count - 1].amb.dropoff = new dropoff();
                state.clp.ln[state.clp.ln.Count - 1].amb.dropoff.name = name.LastName;
            }
            var address = loop.GetElement(1) as N3;
            if (address != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].amb.dropoff == null)
                    state.clp.ln[state.clp.ln.Count - 1].amb.dropoff = new dropoff();
                state.clp.ln[state.clp.ln.Count - 1].amb.dropoff.add1 = address.AddressLine1;
                state.clp.ln[state.clp.ln.Count - 1].amb.dropoff.add2 = address.AddressLine2;
            }
            var location = loop.GetElement(2) as N4;
            if (location != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].amb.dropoff == null)
                    state.clp.ln[state.clp.ln.Count - 1].amb.dropoff = new dropoff();
                state.clp.ln[state.clp.ln.Count - 1].amb.dropoff.city = location.City;
                state.clp.ln[state.clp.ln.Count - 1].amb.dropoff.state = location.State;
                state.clp.ln[state.clp.ln.Count - 1].amb.dropoff.zip = location.PostalCode;
                state.clp.ln[state.clp.ln.Count - 1].amb.dropoff.country = location.CountryCode;
                state.clp.ln[state.clp.ln.Count - 1].amb.dropoff.countrysub = location.CountrySubCode;
            }
        }
        public static void Convert2430(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var info = loop.GetElement(0) as SVD;
            if (info != null)
            {
                if (state.clp.lnins == null)
                    state.clp.lnins = new List<lnins>();
                state.clp.lnins.Add(new lnins());
                if (state.clp.lnins[state.clp.lnins.Count - 1].adjinfo == null)
                    state.clp.lnins[state.clp.lnins.Count - 1].adjinfo = new List<adjinfo>();
                state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Add(new adjinfo());
                state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].payerpaid = info.Amount;
                state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].qty = info.Quantity;
                state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].bundlelineref = info.AssignedNumber;
            }
            var lineAdjustments = loop.GetElements(1) as CAS[];
            if (lineAdjustments != null)
                foreach (var lineAdjustment in lineAdjustments)
                {
                    if (state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj == null)
                        state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj = new List<adj>();
                    state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj.Add(new adj());
                    state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj.Count - 1].group = lineAdjustment.AdjustmentGroupCode1;
                    state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj.Count - 1].reason = lineAdjustment.ReasonCode1;
                    state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj.Count - 1].amt = lineAdjustment.Amount1;
                    state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj.Count - 1].qty = lineAdjustment.Quantity1;
                    state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj.Count - 1].reason = lineAdjustment.AdjustmentGroupCode2;
                    state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj.Count - 1].amt = lineAdjustment.ReasonCode2;
                    state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj.Count - 1].qty = lineAdjustment.Amount2;
                    state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj.Count - 1].reason = lineAdjustment.Quantity2;
                    state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj.Count - 1].amt = lineAdjustment.AdjustmentGroupCode3;
                    state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj.Count - 1].qty = lineAdjustment.ReasonCode3;
                    state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj.Count - 1].reason = lineAdjustment.Amount3;
                    state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj.Count - 1].amt = lineAdjustment.Quantity3;
                    state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj.Count - 1].qty = lineAdjustment.AdjustmentGroupCode4;
                    state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj.Count - 1].reason = lineAdjustment.ReasonCode4;
                    state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj.Count - 1].amt = lineAdjustment.Amount4;
                    state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj.Count - 1].qty = lineAdjustment.Quantity4;
                    state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj.Count - 1].reason = lineAdjustment.AdjustmentGroupCode5;
                    state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj.Count - 1].amt = lineAdjustment.ReasonCode5;
                    state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].adj.Count - 1].qty = lineAdjustment.Amount5;
                }
            var checkRemittanceDate = loop.GetElement(2) as DTP;
            if (checkRemittanceDate != null)
            {
                if (state.clp.lnins[state.clp.lnins.Count - 1].adjinfo == null)
                    state.clp.lnins[state.clp.lnins.Count - 1].adjinfo = new List<adjinfo>();
                state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Add(new adjinfo());
                state.clp.lnins[state.clp.lnins.Count - 1].adjinfo[state.clp.lnins[state.clp.lnins.Count - 1].adjinfo.Count - 1].claimpaiddate = checkRemittanceDate.TimePeriod;
            }
        }
        public static void Convert2440(Loop loop, BatchData state)
        {
            if (loop == null) return;
            var code = loop.GetElement(0) as LQ;
            if (code != null)
            {
                if (state.clp.ln[state.clp.ln.Count - 1].form == null)
                    state.clp.ln[state.clp.ln.Count - 1].form = new List<form>();
                state.clp.ln[state.clp.ln.Count - 1].form.Add(new form());
                state.clp.ln[state.clp.ln.Count - 1].form[state.clp.ln[state.clp.ln.Count - 1].form.Count - 1].type = code.QualifierCode;
                state.clp.ln[state.clp.ln.Count - 1].form[state.clp.ln[state.clp.ln.Count - 1].form.Count - 1].id = code.IndustryCode;
            }
            var supportingDocumentations = loop.GetElements(1) as FRM[];
            if (supportingDocumentations != null)
                foreach (var supportingDocumentation in supportingDocumentations)
                {
                    if (state.clp.ln[state.clp.ln.Count - 1].form[state.clp.ln[state.clp.ln.Count - 1].form.Count - 1].line == null)
                        state.clp.ln[state.clp.ln.Count - 1].form[state.clp.ln[state.clp.ln.Count - 1].form.Count - 1].line = new List<line>();
                    state.clp.ln[state.clp.ln.Count - 1].form[state.clp.ln[state.clp.ln.Count - 1].form.Count - 1].line.Add(new line());
                    state.clp.ln[state.clp.ln.Count - 1].form[state.clp.ln[state.clp.ln.Count - 1].form.Count - 1].line[state.clp.ln[state.clp.ln.Count - 1].form[state.clp.ln[state.clp.ln.Count - 1].form.Count - 1].line.Count - 1].question = supportingDocumentation.AssignedId;
                    state.clp.ln[state.clp.ln.Count - 1].form[state.clp.ln[state.clp.ln.Count - 1].form.Count - 1].line[state.clp.ln[state.clp.ln.Count - 1].form[state.clp.ln[state.clp.ln.Count - 1].form.Count - 1].line.Count - 1].response = supportingDocumentation.YesNo;
                    state.clp.ln[state.clp.ln.Count - 1].form[state.clp.ln[state.clp.ln.Count - 1].form.Count - 1].line[state.clp.ln[state.clp.ln.Count - 1].form[state.clp.ln[state.clp.ln.Count - 1].form.Count - 1].line.Count - 1].response = supportingDocumentation.ReferenceId;
                    state.clp.ln[state.clp.ln.Count - 1].form[state.clp.ln[state.clp.ln.Count - 1].form.Count - 1].line[state.clp.ln[state.clp.ln.Count - 1].form[state.clp.ln[state.clp.ln.Count - 1].form.Count - 1].line.Count - 1].response = supportingDocumentation.Date;
                    state.clp.ln[state.clp.ln.Count - 1].form[state.clp.ln[state.clp.ln.Count - 1].form.Count - 1].line[state.clp.ln[state.clp.ln.Count - 1].form[state.clp.ln[state.clp.ln.Count - 1].form.Count - 1].line.Count - 1].response = supportingDocumentation.PercentFormat;
                }
        }

    }
}
