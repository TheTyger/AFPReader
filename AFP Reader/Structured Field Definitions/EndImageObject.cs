using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndImageObject
    {
        public const string Code = "EIM";
        public const string Name = "End Image Object";
        public const string Description = "The End Image Object structured field terminates the current image object initiated by a Begin Image Object structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 207";

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
