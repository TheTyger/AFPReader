using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginDocumentEnvironmentGroup
    {
        public const string Code = "BDG";
        public const string Name = "Begin Document Environment Group";
        public const string Description = "The Begin Document Environment Group structured field begins a document environment group, which establishes the " +
            "environment parameters for the form map object. The scope of the document environment group is the containing form map.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 153";

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
