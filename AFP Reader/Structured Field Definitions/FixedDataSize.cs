using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class FixedDataSize
    {
        public const string Code = "FDS";
        public const string Name = "Fixed Data Size";
        public const string Description = "The Fixed Data Size structured field specifies the number of bytes of text found in the following Fixed Data Text (FDX) structured fields.";
        public const string Reference = "AFP Programming Guide and Line Data Reference.pdf - pg 103";

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
