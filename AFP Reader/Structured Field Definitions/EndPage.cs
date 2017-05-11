using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndPage
    {
        public const string Code = "EPG";
        public const string Name = "End Page";
        public const string Description = "The End Page structured field terminates the current presentation page definition initiated by a Begin Page structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 214";

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
