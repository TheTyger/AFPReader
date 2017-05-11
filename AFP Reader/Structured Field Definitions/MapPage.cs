using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class MapPage
    {
        public const string Code = "BDT";
        public const string Name = "Map Page";
        public const string Description = "The Map Page structured field identifies a page that is to be merged with " + 
            "data specified for the current page by using an Include Page(IPG) structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 319";

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
