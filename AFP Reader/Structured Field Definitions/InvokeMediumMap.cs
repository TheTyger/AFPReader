
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class InvokeMediumMap
    {
        public const string Code = "IMM";
        public const string Name = "Invoke Medium Map";
        public const string Description = "The Invoke Medium Map structured field identifies the medium map that is to become active " + 
            "for the document.An Invoke Medium Map structured field affects the document's current environment. The medium map's " + 
            "effect on current environment parameter values lasts until a new medium map is invoked. The processing system's " + 
            "form map is searched for the specified medium map unless the IMM directly follows an internal medium map, in which case the IMM " + 
            "can reference and activate that internal medium map.An IMM that does not follow an internal medium map cannot be used to " + 
            "reference an internal medium map elsewhere in the document and is assumed to reference a medium map in the " + 
            "processing system's form map. If a document does not invoke a medium map by name, and if it does not include an " + 
            "internal medium map, the first medium map in the selected form map controls document presentation.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 226";

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
