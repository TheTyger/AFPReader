using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndDocumentIndex
    {
        public const string Code = "EDI";
        public const string Name = "End Document Index";
        public const string Description = "The End Document Index structured field terminates the document index initiated by a Begin Document Index structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 203";

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
