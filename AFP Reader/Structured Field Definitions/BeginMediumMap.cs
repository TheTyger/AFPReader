using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginMediumMap
    {
        public const string Code = "BMM";
        public const string Name = "Begin Medium Map";
        public const string Description = "The Begin Medium Map structured field begins a medium map resource object. A " +
            "medium map is a print control resource object that contains a complete set of " +
            "controls for presenting pages on physical media such as sheets and for generating " +
            "multiple copies of sheets with selectable modifications.These controls may be " +
            "grouped into two categories: Medium level controls, Page level controls /r/n" +
            "Medium level controls are controls that affect the medium, such as the specification " +
        "of medium overlays, medium size, medium orientation, medium copies, simplex or " +
        "duplex, medium finishing, media type, and media source and destination selection. " +
        "These controls are defined by the Map Medium Overlay (MMO), Medium " +
        "Descriptor(MDD), Medium Copy Count(MCC), Medium Finishing Control " +
        "(MFC), Map Media Type(MMT), Map Media Destination(MMD), Presentation " +
        "Environment Control(PEC), and Medium Modification Control(MMC) structured " +
        "fields.Page level controls are controls that affect the pages that are placed on the " +
        "medium, such as the specification of page modifications, page position, and page "  +
        "orientation.These controls are defined by the Map Page Overlay (MPO), Page " +
        "Position(PGP), and Page Modification Control(PMC) structured fields.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 164";

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
