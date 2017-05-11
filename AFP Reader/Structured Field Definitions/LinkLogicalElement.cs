using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class LinkLogicalElement
    {
        public const string Code = "LLE";
        public const string Name = "Link Logical Element";
        public const string Description = "A Link Logical Element structured field specifies the linkage from a source document component " + 
            "to a target document component.The LLE identifies the source and target and indicates the purpose of the linkage by specifying " + 
            "a link type.The link source and link target may be in the same document component or in different document components, " + 
            "and they need not be of the same document component type.The linkage may involve a complete document component, or it " + 
            "may be restricted to a rectangular area on the presentation space associated with the document component. The " + 
            "Link Logical Element structured field can be embedded in the document that contains the link source, in the document that "+ 
            "contains the link target, in the document index for either document, or in any combination of these structures. Link " + 
            "Logical Element parameters do not provide any presentation specifications.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 250";

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
