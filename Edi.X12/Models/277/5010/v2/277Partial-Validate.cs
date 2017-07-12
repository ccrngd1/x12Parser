namespace EDI.X12.Format277.v5010
{
    //Example of Validation override
    public partial class Loop2000ACollection
    {
        //todo: add any logic specific to this loop validation here
        //do not define Validate methods that do not need to override for specific checks
        public override bool Validate() { return base.Validate() && true; } 
    } 

}
