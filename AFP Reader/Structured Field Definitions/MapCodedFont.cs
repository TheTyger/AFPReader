using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class MapCodedFont
    {
        public const string Code = "MCF";
        public const string Name = "Map Coded Format (Format 2)";
        public const string Description = "The Map Coded Font structured field maps a unique coded font resource local ID, which " + 
            "may be embedded one or more times within an object's data and descriptor, to the identifier of a coded font " + 
            "resource object. This identifier may be specified in one of the following formats: A coded font Global Resource " + 
            "Identifier(GRID), A coded font name, A combination of code page name and font character set name";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 262";

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
