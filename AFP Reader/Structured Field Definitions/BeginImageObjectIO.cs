using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginImageObjectIO
    {
        public const string Code = "BIM";
        public const string Name = "Begin Image Object IO";
        public const string Description = "The Begin Image Object structured field begins an IOCA image data object, which becomes the current data object.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 162";

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
