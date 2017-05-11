using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class MapDataResource
    {
        public const string Code = "MDR";
        public const string Name = "Map Data Resource";
        public const string Description = "The Map Data Resource structured field specifies resources that are required for presentation. "+
            "Each resource reference is defined in a repeating group and is identified with a file name, the identifier of a begin structured field for the " +
            "resource, or any other identifier associated with the resource.The MDR repeating group may additionally " + 
            "specify a local or internal identifier for the resource object. Such a local identifier may be embedded one or more times within an object's data.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 271";

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
