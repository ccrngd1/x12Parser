using EDI.X12.Base;

namespace EDI.X12.Format277.v5010
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

            InformationReiverDetailLoop = new Loop2000BCollection("Loop2000B", "InformationReiverDetailLoop",this,null,null);
            TopLevelLoops.Add(InformationReiverDetailLoop);

            ServiceProviderDetailLoop = new Loop2000CCollection("Loop2000C", "ServiceProviderDetailLoop",this,null, null);
            TopLevelLoops.Add(ServiceProviderDetailLoop);

            SubscriberDetailLoop = new Loop2000DCollection("Loop2000D", "SubscriberDetailLoop", this, null, null);
            TopLevelLoops.Add(SubscriberDetailLoop);

            DependentDetailLoop = new Loop2000ECollection("Loop2000E", "DependentDetailLoop",this, null, null);
            TopLevelLoops.Add(DependentDetailLoop);

            if (includeDefinition)
                SetUpDefinitions();
        }

        internal override void SetUpDefinitions()
        {
            foreach (LoopCollectionBase loopCollection in TopLevelLoops)
            {
                loopCollection.SetUpDefinition();
            }
        }
    }
}
