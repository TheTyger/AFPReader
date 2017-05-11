using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class PageDescriptor
    {
        public const string Code = "PGD";
        public const string Name = "Page Descriptor";
        public const string Description = "The Page Descriptor structured field specifies the size and attributes of a page or overlay presentation space.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 337";

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
