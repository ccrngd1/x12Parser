using System.Collections.Generic; 
using Model.EDI.X12.v2.Base;
using Model.EDI.X12.v2; 

namespace Model.EDI.X12.Format277.v5010.v2
{
    public partial class Loop2000ACollection
    {

        public override void SetUpDefinition()
        {
            SetUpChildDefinitions = true; 
            RepitionLimit = 1;
            SegmentDefinitions.Add(new HL()
            {
                SegmentQualifierValues = new List<SegmentQualifiers>(),
                OwningLoopCollection = this,
                IsLoopStarter = true,
                SegmentDefinitionName = "InformationSourceLevel",
                
            });


        }
    } 

    public partial class Loop2100ACollection
    {
        public override void SetUpDefinition()
        {
            SegmentDefinitions.Add(new NM1()
            {
                SegmentQualifierValues = new List<SegmentQualifiers>(),
                OwningLoopCollection = this,
                IsLoopStarter = true,
                SegmentDefinitionName = "InformationSourceName"
            });
        }
    }
}
