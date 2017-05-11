using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class IncludeObject
    {
        public const string Code = "IOB";
        public const string Name = "Include Object";
        public const string Description = "An Include Object structured field references an object on a page or overlay. It optionally " + 
            "contains parameters that identify the object and that specify presentation parameters such as object position, size, " + 
            "orientation, mapping, and default color. Where the presentation parameters conflict with parameters specified in the "+ 
            "object's environment group (OEG), the parameters in the Include Object structured field override. If the referenced " + 
            "object is a page segment, the IOB parameters override the corresponding environment group parameters on all data objects " + 
            "in the page segment.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 228";

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
