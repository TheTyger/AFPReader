namespace AFP_Reader.Structured_Field_Definitions
{
    public class TagLogicalElement
    {
        public const string Code = "TLE";
        public const string Name = "Tag Logical Element";
        public const string Description = "A Tag Logical Element structured field assigns an attribute name and an attribute " +
                        "value to a page or page group.The Tag Logical Element structured field may be " +
                        "embedded directly in the page or page group, or it may reference the page or page " +
                        "group from a document index.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 370";
        public static SFIData ConvertToSFIData()
        {
            return new SFIData
            {
                Name = Name,
                Code = Code,
                Description = Description,
                Reference = Reference
            };
        }
    }
}
