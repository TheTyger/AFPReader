using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class FixedDataText
    {
        public const string Code = "FDX";
        public const string Name = "Fixed Data Text";
        public const string Description = "The Fixed Data Text structured field contains text that can be selected and presented " + 
            "with LND, RCD or XMD structured fields in the Page Definition. This text is used when flag bit 7 of the LND, RCD or " + 
            "XMD is set to B'1'. Any number of FDX structured fields can appear, but the total number of data bytes must match " + 
            "bytes 0–1 of the Fixed Data Size (FDS) structured field. The output should fit on the page, and the fit can be affected by the size of the font used";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 104";

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
