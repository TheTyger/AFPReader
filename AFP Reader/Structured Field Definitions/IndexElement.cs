using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class IndexElement
    {
        public const string Code = "IEL";
        public const string Name = "Index Element";
        public const string Description = "The Index Element structured field identifies begin structured fields for use within a document index.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 224";

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
