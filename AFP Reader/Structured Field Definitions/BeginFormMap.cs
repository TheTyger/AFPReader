using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginFormMap
    {
        public const string Code = "BFM";
        public const string Name = "Begin Form Map";
        public const string Description = "The Begin Form Map structured field begins a form map object, also called a form definition or formdef.A form map " +
            "is a print control resource object that contains one or more medium map resource objects that are invokable on document and page "+
            "boundaries and that specify a complete set of presentation controls.It also contains an optional document environment group(DEG) that defines the presentation environment for the form map.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 158";

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
