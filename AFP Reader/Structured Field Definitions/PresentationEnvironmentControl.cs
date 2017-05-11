using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class PresentationEnvironmentControl
    {
        public const string Code = "PEC";
        public const string Name = "Presentation Environment Control";
        public const string Description = "The Presentation Environment Control structured field specifies parameters that " +
        "affect the rendering of presentation data and the appearance that is to be assumed by the presentation device.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 333";

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
