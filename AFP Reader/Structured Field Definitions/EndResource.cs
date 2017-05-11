using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndResource
    {
        public const string Code = "ERS";
        public const string Name = "End Resource";
        public const string Description = "The End Resource structured field terminates an envelope that is used to carry resource objects " + 
            "in external(print file level) resource groups.The envelope is initiated by a Begin Resource (BRS) structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 219";

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
