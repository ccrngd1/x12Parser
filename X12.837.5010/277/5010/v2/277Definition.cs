using Model.EDI.X12.v2.Base;

namespace Model.EDI.X12.Format277.v5010.v2
{
    public sealed class X12_277_5010 : X12Doc
    {
        public readonly Loop2000ACollection InformationSourceLevelLoop;
        public readonly Loop2000BCollection InformationReiverDetailLoop ;
        public readonly Loop2000CCollection ServiceProviderDetailLoop;
        public readonly Loop2000DCollection SubscriberDetailLoop;
        public readonly Loop2000ECollection DependentDetailLoop;

        public X12_277_5010() : this(false)
        {
        }

        public X12_277_5010(bool includeDefinition) : base(includeDefinition)
        {
            InformationSourceLevelLoop = new Loop2000ACollection("Loop2000A", "InformationSourceLevelLoop", this, null, null);
            TopLevelLoops.Add(InformationSourceLevelLoop);

            InformationReiverDetailLoop = new Loop2000BCollection("Loop2000B", "InformationReiverDetailLoop",this,null,InformationSourceLevelLoop);
            TopLevelLoops.Add(InformationReiverDetailLoop);

            ServiceProviderDetailLoop = new Loop2000CCollection("Loop2000C", "ServiceProviderDetailLoop",this,null, InformationReiverDetailLoop);
            TopLevelLoops.Add(ServiceProviderDetailLoop);

            SubscriberDetailLoop = new Loop2000DCollection("Loop2000D", "SubscriberDetailLoop", this, null, ServiceProviderDetailLoop);
            TopLevelLoops.Add(SubscriberDetailLoop);

            DependentDetailLoop = new Loop2000ECollection("Loop2000E", "DependentDetailLoop",this, null, SubscriberDetailLoop);
            TopLevelLoops.Add(DependentDetailLoop);

            if (includeDefinition)
                SetUpDefinitions();
        }

        public override void SetUpDefinitions()
        {
            InformationSourceLevelLoop.SetUpDefinition();
        }
    }
}
