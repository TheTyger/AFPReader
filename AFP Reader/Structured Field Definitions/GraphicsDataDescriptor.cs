using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class GraphicsDataDescriptor
    {
        public const string Code = "GDD";
        public const string Name = "Graphics Data Descriptor";
        public const string Description = "The Graphics Data Descriptor structured field contains the descriptor data for a graphics object.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 222";

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
