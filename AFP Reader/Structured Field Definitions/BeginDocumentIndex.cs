using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginDocumentIndex
    {
        public const string Code = "BDI";
        public const string Name = "Begin Document Index";
        public const string Description = "The Begin Document Index structured field begins the document index.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 154";

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
