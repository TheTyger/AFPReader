namespace AFP_Reader.Structured_Field_Definitions
{
    public static class BeginDocument
    {
        public const string Code = "BDT";
        public const string Name = "Begin Document";
        public const string Description = "The Begin Document structured field names and begins the document.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 156";

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
