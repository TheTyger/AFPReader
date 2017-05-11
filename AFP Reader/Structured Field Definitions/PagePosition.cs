using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class PagePosition
    {
        public const string Code = "PGP";
        public const string Name = "Page Position (Format 1)";
        public const string Description = "The Page Position structured field specifies the position and orientation of a page's presentation " + 
            "space on the medium presentation space for the physical medium. The PGP may be located in a medium map or in the document environment " + 
            "group of a form map.When present in the active medium map, it overrides a PGP in the document environment group of the form map. If " + 
            "N-up partitioning is specified by the Medium Modification Control structured field in the active medium map, the medium presentation " + 
            "spaces on the front and back sides of a sheet are divided into N partitions; and the Page Position structured field specifies the " + 
            "partition into  which each page is mapped and with respect to which the page presentation space is positioned and oriented.  Read More on Docs";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 340";

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
