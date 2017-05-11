using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginResource
    {
        public const string Code = "BRS";
        public const string Name = "Begin Resource";
        public const string Description = "The Begin Resource structured field begins an envelope that is used to carry resource objects in print file " +
            "level(external) resource groups.Resource references in the data stream are matched against the resource identifier specified by the Begin Resource structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 188";

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
