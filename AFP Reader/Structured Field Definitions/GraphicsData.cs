using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class GraphicsData
    {
        public const string Code = "GAD";
        public const string Name = "Graphics Data";
        public const string Description = "The Graphics Data structured field contains the data for a graphics object.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 221";

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
