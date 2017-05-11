using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginResourceEnvironmentGroup
    {
        public const string Code = "BSG";
        public const string Name = "Begin Resource Environment Group";
        public const string Description = "The Begin Resource Environment Group structured field begins a Resource Environment Group(REG), " + 
            "which defines a subset of the resources required for a document or for a group of pages in a document.The scope of the Resource " +
            "Environment Group is the group of pages that follow, up to the next REG, which is a complete replacement for the current REG, or the end of the document, whichever occurs first.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 197";

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
