using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndDocument
    {
        public const string Code = "EDT";
        public const string Name = "End Document";
        public const string Description = "The End Document structured field terminates the MO:DCA document data stream initiated by a Begin Document structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 204";

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
