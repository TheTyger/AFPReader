using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class MapSuppression
    {
        public const string Code = "MSU";
        public const string Name = "Map Suppression";
        public const string Description = "The Map Suppression structured field maps one-byte text suppression local identifiers " + 
            " to text suppression names.Suppressible text is identified in presentation text objects with a local identifier " + 
            "and is bracketed with control sequences that specify the beginning and the end of the suppression.  A " + 
            "text suppression is activated by specifying its local identifier in a Medium Modification Control (MMC) structured field in a medium map.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 324";

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
