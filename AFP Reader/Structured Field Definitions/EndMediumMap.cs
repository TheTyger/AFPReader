using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndMediumMap
    {
        public const string Code = "EMM";
        public const string Name = "End Medium Map";
        public const string Description = "The End Medium Map structured field terminates the medium map object initiated by a Begin Medium Map structured field";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 208";

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
