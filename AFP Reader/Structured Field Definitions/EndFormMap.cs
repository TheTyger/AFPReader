using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndFormMap
    {
        public const string Code = "EFM";
        public const string Name = "End From Map";
        public const string Description = "The End Form Map structured field terminates the form map object initiated by a Begin Form Map structured field";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 205";

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
