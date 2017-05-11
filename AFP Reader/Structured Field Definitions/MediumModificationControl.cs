using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class MediumModificationControl
    {
        public const string Code = "MMC";
        public const string Name = "Medium Modification control";
        public const string Description = "The Medium Modification Control structured field specifies the medium " +
        "modifications to be applied for a copy subgroup specified in the Medium Copy Count(MCC) structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 302";

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
