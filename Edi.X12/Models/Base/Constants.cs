namespace EDI.X12.Enums
{
    /// <summary>
    /// Usage types at a segment level
    /// </summary>
    public enum SegmentUsageTypeNames
    {
        ERROR=0,
        Optional=1,
        Required=2,
        Situational=3,
        Relational=4
    } 

    /// <summary>
    /// Usage types at a field level (human friendly version)
    /// </summary>
    public enum FieldUsageTypeNames
    {
        ERROR = 0,
        Mandatory = SegmentUsageTypeNames.Required,
        Optional = SegmentUsageTypeNames.Optional,
        Relational = SegmentUsageTypeNames.Relational,
        UnUsed =  10,
    }


    /// <summary>
    /// Usage types at a field level (matching X12 documentation)
    /// </summary>
    public enum FieldUsageTypes
    {
        ERROR = 0,
        M = FieldUsageTypeNames.Mandatory,
        O = FieldUsageTypeNames.Optional,
        X = FieldUsageTypeNames.Relational,
        U = FieldUsageTypeNames.UnUsed
    }

    /// <summary>
    /// Types of errors that can be encountered with an x12 document - meant for simplified reporting
    /// </summary>
    public enum X12ErrorTypes
    {
        Unknown = 0,
        NotDefined=1,
        RepeatsNotAllowed=2,
        RepeatLimitReached=3,
        MultipleDefintions=4,
        UnknownIntendedLoop=5,
        ValidationFailed=6,
    }

    /// <summary>
    /// Levels where an error can occur in an document - mean for simplified reporting
    /// </summary>
    public enum X12ErrorLevel
    {
        Unknown = 0,
        Document = 1,
        Loop=2,
        Segment=3,
    }

    /// <summary>
    /// What level to attempt qualification
    /// Currently only two options as fully recursive does not make sense given the test files so far encountered
    /// </summary>
    public enum QulificationLevel
    {
        ERROR=0,
        TopMost =1,
        FirstChild=2
    }

    /// <summary>
    /// Data types an element/field may have (matching x12 document)
    /// </summary>
    public enum DataElementTypes
    {
        ERROR=0,
        Nn=1,
        R=2,
        ID=3,
        AN=4,
        DT=5,
        TM=6,
        B=7
    }

    /// <summary>
    /// Data types an element/field may have (human friendly version)
    /// </summary>
    public enum DataElementTypeNames
    {
        ERROR = 0,
        Number =DataElementTypes.Nn,
        Decimal= DataElementTypes.R,
        Identifier= DataElementTypes.ID,
        String = DataElementTypes.AN,
        Date = DataElementTypes.DT,
        Time = DataElementTypes.TM,
        Binary = DataElementTypes.B,
    }
}
