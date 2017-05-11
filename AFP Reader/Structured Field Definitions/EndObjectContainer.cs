using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndObjectContainer
    {
        public const string Code = "EOC";
        public const string Name = "End Object Container";
        public const string Description = "The End Object Container structured field terminates an object container initiated by a Begin Object Container structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 211";

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
