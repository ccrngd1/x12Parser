using System.Collections.Generic;
using Model.EDI.X12.v1;
using Model.EDI.X12.v1.Base;

namespace Model.EDI.X12.Format837.v5010.Prof.v1
{

    public class X12_837P_5010NL : X12DocumentBase
    {
        public Loop1000A Loop1000A;
        public Loop1000B Loop1000B;
        public Loop2000A Loop2000A;
        public Loop2000B Loop2000B;
        public Loop2000C Loop2000C;

        public X12_837P_5010NL()
        {
            Loop1000A = new Loop1000A();
            Loops.Add(Loop1000A);

            Loop1000B = new Loop1000B();
            Loops.Add(Loop1000B);

            Loop2000A = new Loop2000A();
            Loops.Add(Loop2000A);

            Loop2000B = new Loop2000B();
            Loops.Add(Loop2000B);

            Loop2000C = new Loop2000C();
            Loops.Add(Loop2000C);
        }
    }

    public class Loop1000A : LoopsList
    {
        public NM1 SubmitterName;
        public PER SubmitterContact;

        public Loop1000A() : base(null, 1, "Submitter Name")
        {
            SubmitterName.DefinedSeg = new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "41") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1));

            SubmitterContact.DefinedSeg = new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "IC") },
                SegmentUsageTypeNames.Required, 2, typeof(PER));
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "41") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "IC") },
                SegmentUsageTypeNames.Required, 2, typeof(PER)));
        }
    }

    public class Loop1000B : LoopsList
    {
        public Loop1000B() : base(null, 1, "Receiver Name")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "40") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
        }
    }

    public class Loop2000A : LoopsList
    {
        public Loop2010AA Loop2010AA;
        public Loop2010AB Loop2010AB;
        public Loop2010AC Loop2010AC;

        public Loop2000A() : base(null, 1, "Billing Provider")
        {
            Loop2010AA = new Loop2010AA(this);
            SubLoops.Add(Loop2010AA);

            Loop2010AB = new Loop2010AB(this);
            SubLoops.Add(Loop2010AB);

            Loop2010AC = new Loop2010AC(this);
            SubLoops.Add(Loop2010AC);
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(3, "20") },
                SegmentUsageTypeNames.Required, 1, typeof(HL)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "BI") },
                SegmentUsageTypeNames.Required, 1, typeof(PRV)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "85") },
                SegmentUsageTypeNames.Situational, 1, typeof(CUR)));
        }
    }

    public class Loop2010AA : LoopsList
    {
        public Loop2010AA(Loop2000A parent) : base(parent, 1, "Billing Provider Name")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "85") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Required, 1, typeof(N3)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N4)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "EI", "SY") },
                    SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "0B", "1G") },
                    SegmentUsageTypeNames.Situational, 2, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "IC") },
                SegmentUsageTypeNames.Situational, 2, typeof(PER)));
        }
    }

    public class Loop2010AB : LoopsList
    {
        public Loop2010AB(Loop2000A parent) : base(parent, 1, "Pay-To Address")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "87") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N3)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N4)));
        }
    }

    public class Loop2010AC : LoopsList
    {
        public Loop2010AC(Loop2000A parent) : base(parent, 1, "Pay-To-Plan")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "PE") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N3)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N4)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "2U,FY,NF") },
                    SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "EI") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
        }
    }

    public class Loop2000B : LoopsList
    {
        public Loop2010BA Loop2010BA;
        public Loop2010BB Loop2010BB;
        public Loop2300 Loop2300;

        public Loop2000B() : base(null, 1, "Subscriber")
        {
            Loop2010BA = new Loop2010BA(this);
            SubLoops.Add(Loop2010BA);

            Loop2010BB = new Loop2010BB(this);
            SubLoops.Add(Loop2010BB);

            Loop2300 = new Loop2300(this);
            SubLoops.Add(Loop2300);
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(3, "22") },
                SegmentUsageTypeNames.Required, 1, typeof(HL)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(SBR)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(PAT)));
        }
    }

    public class Loop2010BA : LoopsList
    {
        public Loop2010BA(Loop2000B parent) : base(parent, 1, "Subscriber Name")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "IL") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N3)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N4)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(DMG)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "SY") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "Y4") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "IC") },
                SegmentUsageTypeNames.Situational, 1, typeof(PER)));
        }
    }

    public class Loop2010BB : LoopsList
    {
        public Loop2010BB(Loop2000B parent) : base(parent, 1, "Payer Name")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "PR") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N3)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N4)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "2U", "EI", "FY", "NF") },
                    SegmentUsageTypeNames.Situational, 3, typeof(REF)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "G2", "LU") },
                    SegmentUsageTypeNames.Situational, 2, typeof(REF)));
        }
    }

    public class Loop2000C : LoopsList
    {
        public Loop2010CA Loop2010CA;
        public Loop2300 Loop2300;

        public Loop2000C() : base(null, 1, "Patient ")
        {
            Loop2010CA = new Loop2010CA(this);
            Loop2300 = new Loop2300(this);

            SubLoops.Add(Loop2010CA);
            SubLoops.Add(Loop2300);
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(3, "23") },
                SegmentUsageTypeNames.Required, 1, typeof(HL)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(PAT)));
        }
    }

    public class Loop2010CA : LoopsList
    {
        public Loop2010CA(Loop2000C parent) : base(parent, 1, "Patient Name")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "QC") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N3)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N4)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(DMG)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "Y4") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "1W,SY,") },
                    SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "IC") },
                SegmentUsageTypeNames.Situational, 1, typeof(PER)));
        }
    }

    public class Loop2300 : LoopsList
    {
        public Loop2310A Loop2310A;
        public Loop2310B Loop2310B;
        public Loop2310C Loop2310C;
        public Loop2310D Loop2310D;
        public Loop2310E Loop2310E;
        public Loop2310F Loop2310F;
        public Loop2320 Loop2320;
        public Loop2400 Loop2400;

        public Loop2300(Loop2000C parent) : base(parent, 1, "Claim Info")
        {
            Loop2310A = new Loop2310A(this);
            Loop2310B = new Loop2310B(this);
            Loop2310C = new Loop2310C(this);
            Loop2310D = new Loop2310D(this);
            Loop2310E = new Loop2310E(this);
            Loop2310F = new Loop2310F(this);
            Loop2320 = new Loop2320(this);
            Loop2400 = new Loop2400(this);

            SubLoops.Add(Loop2310A);
            SubLoops.Add(Loop2310B);
            SubLoops.Add(Loop2310C);
            SubLoops.Add(Loop2310D);
            SubLoops.Add(Loop2310E);
            SubLoops.Add(Loop2310F);
            SubLoops.Add(Loop2320);
            SubLoops.Add(Loop2400);
        }

        public Loop2300(Loop2000B parent) : base(parent, 1, "Claim Info")
        {
            Loop2310A = new Loop2310A(this);
            Loop2310B = new Loop2310B(this);
            Loop2310C = new Loop2310C(this);
            Loop2310D = new Loop2310D(this);
            Loop2310E = new Loop2310E(this);
            Loop2310F = new Loop2310F(this);
            Loop2320 = new Loop2320(this);
            Loop2400 = new Loop2400(this);

            SubLoops.Add(Loop2310A);
            SubLoops.Add(Loop2310B);
            SubLoops.Add(Loop2310C);
            SubLoops.Add(Loop2310D);
            SubLoops.Add(Loop2310E);
            SubLoops.Add(Loop2310F);
            SubLoops.Add(Loop2320);
            SubLoops.Add(Loop2400);
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Required, 1, typeof(CLM)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "431") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "454") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "304") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "453") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "439") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "484") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "455") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "471") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "314", "360", "361") },
                    SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "297") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "296") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "435") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "096") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "090", "091") },
                    SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "444") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "050") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 10, typeof(PWK)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(CN1)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(AMT)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "4N") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "F5") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "EW") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "9F") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "G1") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "F8") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "X4") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "9A") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "9C") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "LX") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "D9") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "EA") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "P4") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "1J") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 10, typeof(K3)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(NTE)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(CR1)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(CR2)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "7") },
                SegmentUsageTypeNames.Situational, 3, typeof(CRC)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "E1", "E2", "E3") },
                    SegmentUsageTypeNames.Situational, 3, typeof(CRC)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "75") },
                SegmentUsageTypeNames.Situational, 1, typeof(CRC)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "ZZ") },
                SegmentUsageTypeNames.Situational, 1, typeof(CRC)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(HI)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(HI)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 2, typeof(HI)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(HCP)));
        }
    }

    public class Loop2310A : LoopsList
    {
        public Loop2310A(Loop2300 parent) : base(parent, 1, "Refering Provider")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(
                new List<SegmentQualifiers> { new SegmentQualifiers(1, "DN", "P3") }, SegmentUsageTypeNames.Required, 1,
                typeof(NM1)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "0B", "1G,") },
                    SegmentUsageTypeNames.Situational, 3, typeof(REF)));
        }
    }

    public class Loop2310B : LoopsList
    {
        public Loop2310B(Loop2300 parent) : base(parent, 1, "RenderingProvider")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "82") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "PE") },
                SegmentUsageTypeNames.Situational, 1, typeof(PRV)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "0B", "1G", "G2", "LU") },
                    SegmentUsageTypeNames.Situational, 4, typeof(REF)));
        }
    }

    public class Loop2310C : LoopsList
    {
        public Loop2310C(Loop2300 parent) : base(parent, 1, "ServiceFacility")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "77") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N3)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N4)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "0B", "G2", "LU") },
                    SegmentUsageTypeNames.Situational, 3, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "IC") },
                SegmentUsageTypeNames.Situational, 1, typeof(PER)));
        }
    }

    public class Loop2310D : LoopsList
    {
        public Loop2310D(Loop2300 parent) : base(parent, 1, "SupervisingProvider")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "DQ") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "0B", "1G", "G2", "LU") },
                    SegmentUsageTypeNames.Situational, 4, typeof(REF)));
        }
    }

    public class Loop2310E : LoopsList
    {
        public Loop2310E(Loop2300 parent) : base(parent, 1, "AmbulancePickUp")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "PW") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N3)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N3)));
        }
    }

    public class Loop2310F : LoopsList
    {
        public Loop2310F(Loop2300 parent) : base(parent, 1, "AmbulanceDropOff")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "45") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N3)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N3)));
        }
    }

    public class Loop2320 : LoopsList
    {
        public Loop2330A Loop2330A;
        public Loop2330B Loop2330B;
        public Loop2330C Loop2330C;
        public Loop2330D Loop2330D;
        public Loop2330E Loop2330E;
        public Loop2330F Loop2330F;
        public Loop2330G Loop2330G;

        public Loop2320(Loop2300 parent) : base(parent, 1, "OtherSubscriberInfo")
        {
            Loop2330A = new Loop2330A(this);
            Loop2330B = new Loop2330B(this);
            Loop2330C = new Loop2330C(this);
            Loop2330D = new Loop2330D(this);
            Loop2330E = new Loop2330E(this);
            Loop2330F = new Loop2330F(this);
            Loop2330G = new Loop2330G(this);

            SubLoops.Add(Loop2330A);
            SubLoops.Add(Loop2330B);
            SubLoops.Add(Loop2330C);
            SubLoops.Add(Loop2330D);
            SubLoops.Add(Loop2330E);
            SubLoops.Add(Loop2330F);
            SubLoops.Add(Loop2330G);
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Required, 1, typeof(SBR)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 5, typeof(CAS)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(AMT)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(AMT)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(AMT)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(OI)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(MOA)));
        }
    }

    public class Loop2330A : LoopsList
    {
        public Loop2330A(Loop2320 parent) : base(parent, 1, "OtherSubscriberName")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "IL") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N3)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N4)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "SY") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
        }
    }

    public class Loop2330B : LoopsList
    {
        public Loop2330B(Loop2320 parent) : base(parent, 1, "OtherPayer")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "PR") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N3)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N4)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "573") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "2U", "EI", "FY", "NF") },
                    SegmentUsageTypeNames.Situational, 2, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "G1") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "9F") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "T4") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "F8") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
        }
    }

    public class Loop2330C : LoopsList
    {
        public Loop2330C(Loop2320 parent) : base(parent, 1, "OtherPayerReferringProvider")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "DN", "P3") },
                    SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "0B", "1G", "G2") },
                    SegmentUsageTypeNames.Situational, 3, typeof(REF)));
        }
    }

    public class Loop2330D : LoopsList
    {
        public Loop2330D(Loop2320 parent) : base(parent, 1, "OtherPayerRenderingProvider")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "82") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "0B", "1G", "G2", "LU") },
                    SegmentUsageTypeNames.Situational, 3, typeof(REF)));
        }
    }

    public class Loop2330E : LoopsList
    {
        public Loop2330E(Loop2320 parent) : base(parent, 1, "OtherPayerServiceFacility")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "77") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "0B", "G2", "LU") },
                    SegmentUsageTypeNames.Situational, 3, typeof(REF)));
        }
    }

    public class Loop2330F : LoopsList
    {
        public Loop2330F(Loop2320 parent) : base(parent, 1, "OtherPayerSupervisingProvider")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "DQ") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "0B", "1G", "G2", "LU") },
                    SegmentUsageTypeNames.Situational, 3, typeof(REF)));
        }
    }

    public class Loop2330G : LoopsList
    {
        public Loop2330G(Loop2320 parent) : base(parent, 1, "OtherPayerBillingProvider")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "85") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "G2", "LU") },
                    SegmentUsageTypeNames.Situational, 2, typeof(REF)));
        }
    }

    public class Loop2400 : LoopsList
    {
        public Loop2410 Loop2410;
        public Loop2420A Loop2420A;
        public Loop2420B Loop2420B;
        public Loop2420C Loop2420C;
        public Loop2420D Loop2420D;
        public Loop2420E Loop2420E;
        public Loop2420F Loop2420F;
        public Loop2420G Loop2420G;
        public Loop2420H Loop2420H;
        public Loop2430 Loop2430;
        public Loop2440 Loop2440;

        public Loop2400(Loop2300 parent) : base(parent, 1, "ServiceLine")
        {
            Loop2410 = new Loop2410(this);
            Loop2420A = new Loop2420A(this);
            Loop2420B = new Loop2420B(this);
            Loop2420C = new Loop2420C(this);
            Loop2420D = new Loop2420D(this);
            Loop2420E = new Loop2420E(this);
            Loop2420F = new Loop2420F(this);
            Loop2420G = new Loop2420G(this);
            Loop2420H = new Loop2420H(this);
            Loop2430 = new Loop2430(this);
            Loop2440 = new Loop2440(this);

            SubLoops.Add(Loop2410);
            SubLoops.Add(Loop2420A);
            SubLoops.Add(Loop2420B);
            SubLoops.Add(Loop2420C);
            SubLoops.Add(Loop2420D);
            SubLoops.Add(Loop2420E);
            SubLoops.Add(Loop2420F);
            SubLoops.Add(Loop2420G);
            SubLoops.Add(Loop2420H);
            SubLoops.Add(Loop2430);
            SubLoops.Add(Loop2440);
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Required, 1, typeof(LX)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(SV1)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(SV5)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 10, typeof(PWK)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "CT") },
                SegmentUsageTypeNames.Situational, 1, typeof(PWK)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(CR1)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(CR3)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "7") },
                SegmentUsageTypeNames.Situational, 3, typeof(CRC)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "70") },
                SegmentUsageTypeNames.Situational, 1, typeof(CRC)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "9") },
                SegmentUsageTypeNames.Situational, 1, typeof(CRC)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "472") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "471") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "607") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "463") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "461") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "304") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "738", "739") },
                    SegmentUsageTypeNames.Situational, 2, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "11") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "455") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "454") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "PT") },
                SegmentUsageTypeNames.Situational, 1, typeof(QTY)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "FL") },
                SegmentUsageTypeNames.Situational, 1, typeof(QTY)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 5, typeof(MEA)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(CN1)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "9B") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "9D") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "G1") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "6R") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "EW") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "X4") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "F4") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "BT") },
                SegmentUsageTypeNames.Situational, 1, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "9F") },
                SegmentUsageTypeNames.Situational, 5, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(AMT)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(AMT)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 10, typeof(K3)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(NTE)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(NTE)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(PS1)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(HCP)));
        }
    }

    public class Loop2410 : LoopsList
    {
        public Loop2410(Loop2400 parent) : base(parent, 1, "DrugIdentification")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Required, 1, typeof(LIN)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(CTP)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "VY", "XZ") },
                    SegmentUsageTypeNames.Situational, 1, typeof(REF)));
        }
    }

    public class Loop2420A : LoopsList
    {
        public Loop2420A(Loop2400 parent) : base(parent, 1, "RenderingProvider")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "82") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "PE") },
                SegmentUsageTypeNames.Situational, 1, typeof(PRV)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "0B", "1G", "G2", "LU") },
                    SegmentUsageTypeNames.Situational, 20, typeof(REF)));
        }
    }

    public class Loop2420B : LoopsList
    {
        public Loop2420B(Loop2400 parent) : base(parent, 1, "PurchasedServiceProvider")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "QB") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "OB", "1G", "G2") },
                    SegmentUsageTypeNames.Situational, 20, typeof(REF)));
        }
    }

    public class Loop2420C : LoopsList
    {
        public Loop2420C(Loop2400 parent) : base(parent, 1, "ServiceFacility")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "77") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N3)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N4)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "G2", "LU") },
                    SegmentUsageTypeNames.Situational, 3, typeof(REF)));
        }
    }

    public class Loop2420D : LoopsList
    {
        public Loop2420D(Loop2400 parent) : base(parent, 1, "SupervisingProviderName")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "DQ") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "OB", "1G", "G2", "LU") },
                    SegmentUsageTypeNames.Situational, 20, typeof(REF)));
        }
    }

    public class Loop2420E : LoopsList
    {
        public Loop2420E(Loop2400 parent) : base(parent, 1, "OrderingProviderName")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "DK") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N3)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N4)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "0B", "1G", "G2") },
                    SegmentUsageTypeNames.Situational, 20, typeof(REF)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "IC") },
                SegmentUsageTypeNames.Situational, 1, typeof(PER)));
        }
    }

    public class Loop2420F : LoopsList
    {
        public Loop2420F(Loop2400 parent) : base(parent, 1, "ReferringProviderName")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "DN", "P3") },
                    SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(
                new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "0B", "1G", "G2") },
                    SegmentUsageTypeNames.Situational, 20, typeof(REF)));
        }
    }

    public class Loop2420G : LoopsList
    {
        public Loop2420G(Loop2400 parent) : base(parent, 1, "AmbulancePickUpLocation")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "PW") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N3)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N4)));
        }
    }

    public class Loop2420H : LoopsList
    {
        public Loop2420H(Loop2400 parent) : base(parent, 1, "AmbulanceDropOffLocaiton")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "45") },
                SegmentUsageTypeNames.Required, 1, typeof(NM1)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N3)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(N4)));
        }
    }

    public class Loop2430 : LoopsList
    {
        public Loop2430(Loop2400 parent) : base(parent, 1, "LineAdjudication")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Required, 1, typeof(SVD)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 5, typeof(CAS)));
            SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "573") },
                SegmentUsageTypeNames.Situational, 1, typeof(DTP)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 1, typeof(AMT)));
        }
    }

    public class Loop2440 : LoopsList
    {
        public Loop2440(Loop2400 parent) : base(parent, 1, "FormIdentificationCode")
        {
        }

        public override void DefineSegmentDefinition()
        {
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Required, 1, typeof(LQ)));
            SegmentDefinitions.Add(new SegmentDefinition(null, SegmentUsageTypeNames.Situational, 99, typeof(FRM)));
        }
    }
}
