using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class MapMediaType
    {
        public const string Code = "MMT";
        public const string Name = "Map Media Type";
        public const string Description = "The Map Media Type structured field maps a media type local ID to the name or OID " +
            "of a media type.See 'Media Type Identifiers' on page 639 for a list of media types registered by their name and their OID.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 316";

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
