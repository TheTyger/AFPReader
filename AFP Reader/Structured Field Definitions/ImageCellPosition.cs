using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class ImageCellPosition
    {
        public const string Code = "ICP";
        public const string Name = "Image Cell Position";
        public const string Description = "The IM Image Cell Position structured field specifies the placement, size, and replication of IM image cells.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 616";

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
