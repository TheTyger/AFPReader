using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndGraphicsObject
    {
        public const string Code = "EGR";
        public const string Name = "End Graphics Object";
        public const string Description = "The End Graphics Object structured field terminates the current graphics object initiated by a Begin Graphics Object structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 206";

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
