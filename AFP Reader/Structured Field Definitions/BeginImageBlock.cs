using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginImageBlock
    {
        public const string Code = "BII";
        public const string Name = "Begin IM Image Object";
        public const string Description = "The Begin IM Image Object structured field begins an IM image data object, which becomes the current data object.";
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
