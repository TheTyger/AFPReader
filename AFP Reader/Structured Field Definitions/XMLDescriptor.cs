using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class XMLDescriptor
    {
        public const string Code = "XMD";
        public const string Name = "XML Descriptor";
        public const string Description = "The XML Descriptor structured field contains information, such as data position, text orientation, font selection, " +
            "field selection, and conditional processing identification, used to format XML data that consists of text delimited by start and end tags. \r\n" +
            "Note: The XMDs in a Data Map are numbered sequentially, starting with 1.";
        public const string Reference = "AFP Programming guide and Line Data Reference.pdf - pg 161";

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
