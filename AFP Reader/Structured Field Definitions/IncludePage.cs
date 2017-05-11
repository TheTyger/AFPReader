using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class IncludePage
    {
        public const string Code = "IPG";
        public const string Name = "Include Page";
        public const string Description = "The Include Page structured field references a page that is to be included in the document. "+ 
            "The Include Page structured field may occur in document state, page-group state, or page state.In all three cases the " + 
            "referenced page is positioned on the media using the (Xm, Ym) offsets specified in the PGP structured field in the " + 
            "active medium map.The referenced page must not contain another Include Page structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 242";

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
