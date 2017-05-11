using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndDocumentEnvironment
    {
        public const string Code = "BDT";
        public const string Name = "End Document Environment Group";
        public const string Description = "The End Document Environment Group structured field terminates the definition of a document "+ 
            "environment group initiated by a Begin Document Environment Group structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 202";

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
