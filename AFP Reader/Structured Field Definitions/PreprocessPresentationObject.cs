using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class PreprocessPresentationObject
    {
        public const string Code = "PPO";
        public const string Name = "Preprocess Presentation Object";
        public const string Description = "The Preprocess Presentation Object structured field specifies presentation parameters for " + 
            "a data object that has been mapped as a resource.These parameters allow the presentation device to preprocess and cache " + 
            "the object so that it is in presentation-ready format when it is included with a subsequent include structured field " + 
            "in the document. Such preprocessing may involve a rasterization or RIP of the object, but is not limited to that. The " + 
            "resource is identified with a file name, the identifier of a begin structured field for the resource, or any other " + 
            "identifier associated with the resource. The referenced resource and all required secondary resources must previously have " + 
            "been mapped with an MDR or an MPO in the same environment group. \r\n " + 
            "Preprocessing is not supported for objects that are included with structures that are outside the document. " + 
            "Examples of such objects are medium overlays and PMC overlays, both of which are included with structures in the form map.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 357";

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
