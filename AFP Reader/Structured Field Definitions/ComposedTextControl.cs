using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class ComposedTextControl
    {
        public const string Code = "CTC";
        public const string Name = "Composed Text Control";
        public const string Description = "OBSOLETE STRUCTURED FIELD";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 594";

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
