namespace EDI.X12.Format277.v5010
{
    //Example of Validation override
    public partial class Loop2000ACollection
    {
        public override bool Validate() { return base.Validate() && true; }//ToDo: add real validation
    } 

}
