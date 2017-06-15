using Model.EDI.X12.v2.Base; 

namespace Model.EDI.X12.Format277.v5010.v2
{
    public sealed class X12_277_5010:X12Doc
    {
        public readonly Loop2000ACollection InformationSourceLevelLoop;
        //public readonly Loop2000BCollection InformationReiverDetail = new Loop2000BCollection("Loop2000B", "InformationReiverDetail");
        //public readonly Loop2000CCollection ServiceProviderDetail = new Loop2000CCollection("Loop2000C", "ServiceProviderDetail");
        //public readonly Loop2000DECollection SubscriberDetail = new Loop2000DECollection("Loop2000D", "SubscriberDetail");
        //public readonly Loop2000DECollection DependentDetail = new Loop2000DECollection("Loop2000E", "DependentDetail");

        public X12_277_5010(bool includeDefinition):base(includeDefinition)
        {
            InformationSourceLevelLoop = new Loop2000ACollection("Loop2000A", "InformationSourceLevelLoop", this, 999, null, null );

            TopLevelLoops.Add(InformationSourceLevelLoop);

            if (includeDefinition)
                SetUpDefinitions();
        } 

        public override void SetUpDefinitions()
        {
            InformationSourceLevelLoop.SetUpDefinition();
        }
    }
}
