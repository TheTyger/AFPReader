using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndIMImageObject
    {
        public const string Code = "EII";
        public const string Name = "End IM Image Object";
        public const string Description = "The End IM Image Object structured field terminates the current IM image object initiated by a Begin IM Image Object structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 643";

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
