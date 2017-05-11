using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    public static class MediumFinishingControl
    {
        public const string Code = "MFC";
        public const string Name = "Medium Finishing Control";
        public const string Description = "The Medium Finishing Control structured field specifies the finishing requirements for physical media. " +
                "Finishing can be specified for a media collection at the print file level or at the document level by placing the MFC in the document environment group(DEG)" +
                " of the form map.Finishing can be specified for a media collection at the medium map level by placing the MFC in a medium map.Finishing can be specified for " +
                "individual media, or sheets, at the medium map level by placing the MFC in a medium map.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 290";
        
        public static SFIData ConvertToSFIData() {
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
