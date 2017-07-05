using Model.EDI.X12.v2.Base;

namespace Model.EDI.X12.Format277.v5010.v2
{
    public sealed class X12_277_5010 : X12Doc
    {
        public readonly Loop2000ACollectionBase InformationSourceLevelLoop;
        public readonly Loop2000BCollectionBase InformationReiverDetailLoop ;
        public readonly Loop2000CCollectionBase ServiceProviderDetailLoop;
        public readonly Loop2000DCollectionBase SubscriberDetailLoop;
        public readonly Loop2000ECollectionBase DependentDetailLoop;

        public X12_277_5010() : this(false)
        {
        }

        public X12_277_5010(bool includeDefinition) : base(includeDefinition)
        {
            InformationSourceLevelLoop = new Loop2000ACollectionBase("Loop2000A", "InformationSourceLevelLoop", this, null, null);
            TopLevelLoops.Add(InformationSourceLevelLoop);

            InformationReiverDetailLoop = new Loop2000BCollectionBase("Loop2000B", "InformationReiverDetailLoop",this,null,null);
            TopLevelLoops.Add(InformationReiverDetailLoop);

            ServiceProviderDetailLoop = new Loop2000CCollectionBase("Loop2000C", "ServiceProviderDetailLoop",this,null, null);
            TopLevelLoops.Add(ServiceProviderDetailLoop);

            SubscriberDetailLoop = new Loop2000DCollectionBase("Loop2000D", "SubscriberDetailLoop", this, null, null);
            TopLevelLoops.Add(SubscriberDetailLoop);

            DependentDetailLoop = new Loop2000ECollectionBase("Loop2000E", "DependentDetailLoop",this, null, null);
            TopLevelLoops.Add(DependentDetailLoop);

            if (includeDefinition)
                SetUpDefinitions();
        }

        public override void SetUpDefinitions()
        {
            foreach (LoopCollectionBase loopCollection in TopLevelLoops)
            {
                loopCollection.SetUpDefinition();
            }
        }
    }
}
