using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFPParser.AFPDefinitions
{
    class StructuredField
    {
        public string Type { get; set; }
        public string TypeDescription { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string CategoryDescription { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public List<Offset> Offsets { get; set; }


        public StructuredField(byte f, byte s, byte t) {
            if (f != 0xD3) {
                //TODO: Build bad input handler
            }
            string temp; string temp2;
            Type = GetSFType(s, out temp);
            TypeDescription = temp;
            Category = GetSFCategory(t, out temp);
            CategoryDescription = temp;
            Name = GetSFDetails(f.ToString("x2") + s.ToString("x2") + t.ToString("x2"), out temp, out temp2);
            Code = temp;
            Description = temp2;
            
        }

        private string GetSFType(byte b, out string d) {
            d = "";
            string t = "";
            switch (b) {
                case 0xA0:
                    t = "Attribute";
                    d = "An Attribute structured Field Defined an Attribute with paramaters such as Name and Value";
                    break;
                case 0xA2:
                    t = "Copy Count";
                    d = "A Copy Count structured field specifies groups of sheet copies, called copy subgroups, that are to be generated, and " 
                        + "identifies modification control structured fields that specify modifications to be applied to each group";
                    break;
                case 0xA6:
                    t = "Descriptor";
                    d = "A Descriptor structured field defines the initial characteristics and, optionally, the formatting directives for all "
                        + "objects, object areas, and pages. Depending on the specific descriptor structured field type, it may contain some "
                        + "set of parameters that identify The size of the page of object, Measurement units, and/or Initial presentation conditions";
                    break;
                case 0xA7:
                    t = "Control";
                    d = "A Control Structured field specifies the type of modifications that are to be applied to a group of sheet copies, or a copy subgroup";
                    break;
                case 0xA8:
                    t = "Begin";
                    d = "A Begin structured field introduces and identifies a document conponent.  In general, a begin structured field may contain a parameter "
                        + "that identifies the name of the component.";
                    break;
                case 0xA9:
                    t = "End";
                    d = "An End structured field identifies the end of a document component.  In general, an end structured field may contain a parameter that "
                        + "identifies the name of a component.";
                    break;
                case 0xAB:
                    t = "Map";
                    d = "A Map Structured field provides the following functions in the MO:DCA Architechture: -All occurances of a variable embedded in " 
                        + "structured field parameter data can be iven a new value by changing only one reference in the mapping. -The presence of the "
                        + "map structured field in a MO:DCA environment group indicates the use of the named resource within the scope of the environment group.";
                    break;
                case 0xAC:
                    t = "Position";
                    d = "A Position structured field specifies the coordinate offset value and orientation for the presentation spaces.";
                    break;
                case 0xAD:
                    t = "Process";
                    d = "A Process structured field specifies the processing to be performed on an object";
                    break;
                case 0xAF:
                    t = "Include";
                    d = "An Include structured field selects a named resource which is to be iembedded in the invluding data stream as if it appeared inline." 
                        + "External resource object names on the begin structured field may or may not coincide with the library name of that object.";
                    break;
                case 0xB0:
                    t = "Reserved";
                    d = "SEE MO:DCA-L: The OS/2 Presentation Manager Metafile Format";
                    break;
                case 0xB1:
                    t = "Migration";
                    d = "A Migration structured field is used to distinguish the MO:DCA structured field from a structured field with the same Acronym from "
                        + "an earlier data-stream architecture";
                    break;
                case 0xB2:
                    t = "Variable";
                    d = "A Variable structured field defines or contains variable information";
                    break;
                case 0xB4:
                    t = "Link";
                    d = "A Link structured field defines a logical connection between two document components.";
                    break;
                case 0xEE:
                    t = "Data";
                    d = "A Data structured field consists of data whose meaning and interpretation is governed by the architecture of the particular data object";
                    break;
                default:
                    t = "UNKNOWN";
                    break;
            }
            return t;
        }

        private string GetSFCategory(byte b, out string d) {
            string t = "";
            d = "";
            switch (b) {
                case 0x5F:
                    t = "Page Segment";
                    d = "Page segments are resource objects that contain data objects but that do not define their own environment parameters";
                    break;
                case 0x6B:
                    t = "Object Area";
                    d = "The object area is the space on a page that is used to present the data object.";
                    break;
                case 0x77:
                    t = "Reserved";
                    d = "SEE MO:DCA-L The OS/2 Presentation Manager Metafile Format";
                    break;
                case 0x7B:
                    t = "IM Image";
                    d = "An IM image data object specifies the contents of a raster image and its placement on a page, overlay, or page segment";
                    break;
                case 0x88:
                    t = "Medium";
                    d = "Specifies information about the physical medium of the print document (?)";
                    break;
                case 0x8A:
                    t = "Coded Font";
                    d = "Description to come later";
                    break;
                case 0x90:
                    t = "Process Element";
                    d = "Process elements are document structures that facilitate particular forms of document processing";
                    break;
                case 0x92:
                    t = "Object Container";
                    d = "An object container is an envelope for object data";
                    break;
                case 0x9B:
                    t = "Presentation Text";
                    d = "Presentation text data consists of graphic character code points and the controls required to position and present the corresponding graphic characters";
                    break;
                case 0xA5:
                    t = "Print File";
                    d = "The print file is an object that contains one or more documents to be printed.";
                    break;
                case 0xA7:
                    t = "Index";
                    d = "A document index is an object that provides functions for indexing the document based on document structure and on application - defined document tags.";
                    break;
                case 0xA8:
                    t = "Document";
                    d = "The document is the highest level object in the MO:DCA document component hierarchy.A document is delimited by Begin Document and End Document structured fields.";
                    break;
                case 0xAD:
                    t = "Page Group";
                    d = "A page group is used in the data stream to define a named, logical grouping of sequential pages.";
                    break;
                case 0xAF:
                    t = "Page";
                    d = "A page is an object that contains the data objects to be presented";
                    break;
                case 0xBB:
                    t = "Graphics";
                    d = "Graphics data consists of controls and parameters to generate pictures based on lines, characters, and shaded areas";
                    break;
                case 0xC3:
                    t = "Data Resource";
                    d = "Resource objects are named objects or named collections of objects that can be referenced from within the document.";
                    break;
                case 0xC4:
                    t = "Document Environment Group";
                    d = "The document environment group (DEG), when present, establishes the presentation environment for a form map resource object.";
                    break;
                case 0xC6:
                    t = "Resource Group";
                    d = "A resource group is an object that contains a collection of resource objects, including: Overlays, Page segments, Fonts, Form maps, Referenced data objects, " 
                        +" Object containers Color Mapping Table(CMT).";
                    break;
                case 0xC7:
                    t = "Object Environment Group";
                    d = "An Object Environment Group (OEG) may be associated with an object and is contained within the object's begin-end envelope";
                    break;
                case 0xC9:
                    t = "Active Environment Group";
                    d = "An Active Environment Group (AEG) is associated with each page, and is contained in the page's begin-end envelope in the data stream.";
                    break;
                case 0xCC:
                    t = "Medium Map";
                    d = "A medium map is a print control resource object that contains the print control parameters for presenting pages on a physical medium " 
                        + "and for generating copies of the physical medium";
                    break;
                case 0xCD:
                    t = "Form Map";
                    d = "A form map is a print control resource object that consists of: an optional Document Environment Group, and One or more medium map resource objects";
                    break;
                case 0xCE:
                    t = "Name Resource";
                    d = "Structured fields that define resources may be encountered in the named resource state.";
                    break;
                case 0xD8:
                    t = "Page Overlay";
                    d = "Overlays are page-like resource objects that contain data objects and that define their own environment parameters.";
                    break;
                case 0xD9:
                    t = "Resource Environment Group";
                    d = "A Resource Environment Group (REG) is associated with a document or a group of pages in a document.";
                    break;
                case 0xDF:
                    t = "Overlay";
                    d = "Overlays are page-like resource objects that contain data objects and that define their own environment parameters.";
                    break;
                case 0xAE:
                    t = "Data Suppression";
                    d = "Description to come later";
                    break;
                case 0xEB:
                    t = "Bar Code";
                    d = "Bar code data consists of patterns of bars and spaces that represent alphanumeric information";
                    break;
                case 0xEE:
                    t = "No Operation";
                    d = "The No Operation structured field performs no function.";
                    break;
                case 0xFB:
                    t = "Image";
                    d = "Image data consists of an electronic representation of a picture in the form of an array of raster data, along with the controls to present this data.";
                    break;
                default:
                    t = "UNKNOWN";
                    d = "The Category listed was not contained within the Lookup";
                    break;
            }
            return t;
        }

        private string GetSFDetails(string hex, out string c, out string d) {
            string r = "";
            c = "";
            d = "";
            switch (hex.ToUpper())
            {
                case "D3A088":
                    c = "MFC";
                    r = "Medium Finishing Control";
                    d = "The Medium Finishing Control structured field specifies the finishing requirements for physical media. " +
                           "Finishing can be specified for a media collection at the print file level or at the document level by placing the MFC in the document environment group(DEG)" +
                           " of the form map.Finishing can be specified for a media collection at the medium map level by placing the MFC in a medium map.Finishing can be specified for " +
                           "individual media, or sheets, at the medium map level by placing the MFC in a medium map.";
                    break;
                case "D3A090":
                    c = "TLE";
                    r = "Tag Logical Element";
                    d = "A Tag Logical Element structured field assigns an attribute name and an attribute " +
                                   "value to a page or page group.The Tag Logical Element structured field may be " +
                                   "embedded directly in the page or page group, or it may reference the page or page " +
                                   "group from a document index.";
                    break;
                case "D3A288":
                    c = "MCC";
                    r =  "Medium Copy Count";
                    d =  "The Medium Copy Count structured field specifies the number of copies of each" +
                   " medium, or sheet, to be presented, and the modifications that apply to each copy. " +
                   "This specification is called a copy group.The MCC contains repeating groups that " +
                   "specify copy subgroups, such that each copy subgroup may be specified " +
                   "independently of any other copy subgroup. For each copy subgroup, the number " +
                   "of copies, as well as the modifications to be applied to each copy, is specified by " +
                   "the repeating group.If the modifications for a copy subgroup specify duplexing, " +
                   "that copy subgroup and all successive copy subgroups are paired such that the " +
                   "first copy subgroup in the pair specifies the copy count as well as the" +
                   "modifications to be applied to the front side of each copy, and the second copy " +
                   "subgroup in the pair specifies the same copy count as well as an independent set " +
                   "of modifications to be applied to the back side of each copy.The pairing of copy " +
                   "subgroups continues as long as duplexing is specified.";
                    break;
                case "D3A66B":
                    c = "OBD";
                    r = "Object Area Descriptor";
                    d = "The Object Area Descriptor structured field specifies the size and attributes of an object area presentation space.";
                    break;
                case "D3A67B":
                    c = "IID";
                    r = "Image Input Descriptor";
                    d = "The IM Image Input Descriptor structured field contains the descriptor data for an " +
                        "IM image data object. This data specifies the resolution, size, and color of the IM image.";
                    break;
                case "D3A688":
                    c = "MDD";
                    r = "Medium Descriptor";
                    d = "The Medium Descriptor structured field specifies the size and orientation of the " +
                   "medium presentation space for all sheets that are generated by the medium map " +
                   "that contains the Medium Descriptor structured field.";
                    break;
                case "D3A68D":
                    c = "RCD";
                    r = "Record Descriptor";
                    d = "The Record Descriptor structured field contains information, such as record position, " +
                        "text orientation, font selection, field selection, and conditional processing identification, used to format line data that consists of records tagged with record identifiers.";
                    break;
                case "D3A68E":
                    c = "XMD";
                    r = "XML Descriptor";
                    d = "The XML Descriptor structured field contains information, such as data position, text orientation, font selection, " +
                        "field selection, and conditional processing identification, used to format XML data that consists of text delimited by start and end tags. \r\n" +
                        "Note: The XMDs in a Data Map are numbered sequentially, starting with 1.";
                    break;
                case "D3A692":
                    c = "CDD";
                    r = "Container Data Descriptor";
                    d = "The Container Data Descriptor structured field specifies control information for a " +
                    "presentation data object that is carried in an object container.";
                    break;
                case "D3A69B":
                    c = "PTX";
                    r = "Presentation Text Data Descriptor (Format 2)";
                    d = "The Presentation Text Data Descriptor structured field contains the descriptor data for a presentation text data object.";
                    break;
                case "D3A6AF":
                    c = "PGD";
                    r = "Page Descriptor";
                    d = "The Page Descriptor structured field specifies the size and attributes of a page or overlay presentation space.";
                    break;
                case "D3A6BB":
                    c = "GDD";
                    r = "Graphics Data Descriptor";
                    d = "The Graphics Data Descriptor structured field contains the descriptor data for a graphics object.";
                    break;
                case "D3A6C5":
                    c = "FGD";
                    r = "Form Environment Group Descriptor";
                    d = "OBSOLETE STRUCTURED FIELD";
                    break;
                case "D3A6E3":
                    c = "DXD";
                    r = "Data Map Transmission Descriptor";
                    d = "The Data Map Transmission Subcase Descriptor structured field is supported only for migration purposes.";
                    break;
                case "D3A6E7":
                    c = "LND";
                    r = "Line Descriptor";
                    d = "The Line Descriptor structured field contains information, such as line position, text orientation, font selection, " +
                        "field selection, and conditional processing identification, used to format line data." +
                        "\r\n Note: The LNDs in a Data Map are numbered sequentially, starting with 1. Values from 1 through the number of LNDs are allowed.";
                    break;
                case "D3A6EB":
                    c = "BDD";
                    r = "Bar Code Data Descriptor";
                    d = "The Bar Code Data Descriptor structured field contains the descriptor data for a bar code data object.";
                    break;
                case "D3A6FB":
                    c = "IDD";
                    r = "Image Data Descriptor";
                    d = "The Image Data Descriptor structured field contains the descriptor data for an image data object.";
                    break;
                case "D3A77B":
                    c = "IOC";
                    r = "Image Output control";
                    d = "The IM Image Output Control structured field specifies the position and " +
                    "orientation of the IM image object area and the mapping of the image points to presentation device pels.";
                    break;
                case "D3A788":
                    c = "MMC";
                    r = "Medium Modification control";
                    d = "The Medium Modification Control structured field specifies the medium " +
                    "modifications to be applied for a copy subgroup specified in the Medium Copy Count(MCC) structured field.";
                    break;
                case "D3A79B":
                    c = "CTC";
                    r = "Composed Text Control";
                    d = "OBSOLETE STRUCTURED FIELD";
                    break;
                case "D3A7AF":
                    c = "PMC";
                    r = "Page Modification Control";
                    d = "The Page Modification Control structured field specifies modifications to be " +
                    "applied to a page presented on a physical medium. \r\n" +
                    "If the ID of a specific PMC is selected in the PGP structured field of the active medium map in N-up mode, only the modifications specified by that PMC are " +
                    "applied to pages placed on the medium.If a specific PMC is not selected in N-up mode, all modifications specified by all PMCs in the active medium map are " +
                    "applied to pages placed on the medium.";
                    break;
                case "D3A7A8":
                    c = "PEC";
                    r = "Presentation Environment Control";
                    d = "The Presentation Environment Control structured field specifies parameters that " +
                    "affect the rendering of presentation data and the appearance that is to be assumed by the presentation device.";
                    break;
                case "D3A7CA":
                    c = "CCP";
                    r = "Conditional Processing Control";
                    d = "The Conditional Processing Control structured field defines tests to be performed on " +
                        "selected input records in line data and specifies the actions to take based on the test results. This optional structured field is " +
                        "selected with LND, RCD or XMD structured fields in the Page Definition. An LND, RCD or XMD can have a unique CCP associated with it or " +
                        "it can reference a CCP that has already been used. In either case, the CCP is referenced with the CCPID field of the LND, RCD or XMD. " +
                        "If a CCP structured field is included in a Page Definition, it must appear before the Data Maps in the Page Definition.";
                    break;
                case "D3A85F":
                    c = "BPS";
                    r = "Begin Page Segment";
                    d = "The Begin Page Segment structured field begins a page segment. A page segment " +
                    "is a resource object that can be referenced from a page or overlay and that contains any mixture of: Bar code objects(BCOCA), " +
                    "Graphics objects(GOCA), v Image objects(IOCA). \r\n" +
                    "Objects in a page segment must specify an object area offset of zero so that they are positioned either at the origin of the " +
                    "including page or overlay coordinate system or at a reference point that is defined on the including page or overlay coordinate system by the Include Page Segment(IPS) structured field. \r\n" +
                    "A page segment does not contain an active environment group.The environment for a page segment is defined by the active environment group of the including page or overlay.";
                    break;
                case "D3A87B":
                    c = "BII";
                    r = "Begin IM Image Object";
                    d = "The Begin IM Image Object structured field begins an IM image data object, which becomes the current data object.";
                    break;
                case "D3A892":
                    c = "BOC";
                    r = "Begin Object Container";
                    d = "The Begin Object Container structured field begins an object container, which may be used " +
                        "to envelop and carry object data.The object data may or may not bedefined by an AFP presentation architecture.";
                    break;
                case "D3A89B":
                    c = "BPT";
                    r = "Begin Presentation Text Block";
                    d = "NOTHING HELPFUL IN DESCRIPTION";
                    break;
                case "D3A8A7":
                    c = "BDI";
                    r = "Begin Document Index";
                    d = "The Begin Document Index structured field begins the document index.";
                    break;
                case "D3A8A8":
                    c = "BDT";
                    r = "Begin Document";
                    d = "The Begin Document structured field names and begins the document.";
                    break;
                case "D3A8AD":
                    c = "BNG";
                    r = "Begin Named Page Group";
                    d = "The Begin Named Page Group structured field begins a page group, which is a " +
                    "named, logical grouping of sequential pages.A page group may contain other nested page groups.All pages in the page group and all other page groups that are " +
                    "nested in the page group inherit the attributes that are assigned to the page group using TLE structured fields.";
                    break;
                case "D3A8AF":
                    c = "BPG";
                    r = "Begin Page";
                    d = "The Begin Page structured field begins a presentation page. A presentation page contains an active environment group " +
                    "to establish parameters such as the size of the page's presentation space and the fonts to be used by the data objects. It may also contain any mixture of: " +
                    "Bar code objects, Graphics objects, Image objects, Object containers, Presentation text objects";
                    break;
                case "D3A8BB":
                    c = "BGR";
                    r = "Begin Graphics Object";
                    d = "The Begin Graphics Object structured field begins a graphics data object which becomes the current data object.";
                    break;
                case "D3A8C4":
                    c = "BDG";
                    r = "Begin Document Environment Group";
                    d = "The Begin Document Environment Group structured field begins a document environment group, which establishes the " +
                        "environment parameters for the form map object. The scope of the document environment group is the containing form map.";
                    break;
                case "D3A8C5":
                    c = "BFG";
                    r = "Begin Form Environment Group";
                    d = "OBSOLETE FIELD";
                    break;
                case "D3A8C6":
                    c = "BRG";
                    r = "Begin Resource Group";
                    d = "The Begin Resource Group structured field begins a resource group, which becomes the current resource group at the same level in the document hierarchy.";
                    break;
                case "D3A8C7":
                    c = "BOG";
                    r = "Begin Object Environment Group";
                    d = "The Begin Document structured field names and begins the documentThe Begin Object Environment Group structured field begins an Object " +
                    "Environment Group, which establishes the environment parameters for the object. The scope of an object environment group is its containing object..";
                    break;
                case "D3A8C9":
                    c = "BAG";
                    r = "Begin Active Environment Group";
                    d = "The Begin Active Environment Group structured field begins an Active Environment Group, " +
                        "which establishes the environment parameters for the page or overlay.The scope of the active environment group is the containing page or overlay.";
                    break;
                case "D3A8CA":
                    c = "BDM";
                    r = "Begin Data Map";
                    d = "The Begin Data Map structured field begins a Data Map resource object.";
                    break;
                case "D3A8CB":
                    c = "BPM";
                    r = "Begin Page Map";
                    d = "The Begin Page Map structured field begins a Page Map resource object, also called a Page Definition or PageDef. " +
                        "A Page Definition is a print control resource object used to compose line data into pages for printing on page printers.";
                    break;
                case "D3A8CC":
                    c = "BMM";
                    r = "Begin Medium Map";
                    d = "The Begin Medium Map structured field begins a medium map resource object. A " +
                        "medium map is a print control resource object that contains a complete set of " +
                        "controls for presenting pages on physical media such as sheets and for generating " +
                        "multiple copies of sheets with selectable modifications.These controls may be " +
                        "grouped into two categories: Medium level controls, Page level controls \r\n" +
                        "Medium level controls are controls that affect the medium, such as the specification " +
                    "of medium overlays, medium size, medium orientation, medium copies, simplex or " +
                    "duplex, medium finishing, media type, and media source and destination selection. " +
                    "These controls are defined by the Map Medium Overlay (MMO), Medium " +
                    "Descriptor(MDD), Medium Copy Count(MCC), Medium Finishing Control " +
                    "(MFC), Map Media Type(MMT), Map Media Destination(MMD), Presentation " +
                    "Environment Control(PEC), and Medium Modification Control(MMC) structured " +
                    "fields.Page level controls are controls that affect the pages that are placed on the " +
                    "medium, such as the specification of page modifications, page position, and page " +
                    "orientation.These controls are defined by the Map Page Overlay (MPO), Page " +
                    "Position(PGP), and Page Modification Control(PMC) structured fields.";
                    break;
                case "D3A8CD":
                    c = "BFM";
                    r = "Begin Form Map";
                    d = "The Begin Form Map structured field begins a form map object, also called a form definition or formdef.A form map " +
                        "is a print control resource object that contains one or more medium map resource objects that are invokable on document and page " +
                        "boundaries and that specify a complete set of presentation controls.It also contains an optional document environment group(DEG) that defines the presentation environment for the form map.";
                    break;
                case "D3A8CE":
                    c = "BRS";
                    r = "Begin Resource";
                    d = "The Begin Resource structured field begins an envelope that is used to carry resource objects in print file " +
                        "level(external) resource groups.Resource references in the data stream are matched against the resource identifier specified by the Begin Resource structured field.";
                    break;
                case "D3A8D9":
                    c = "BSG";
                    r = "Begin Resource Environment Group";
                    d = "The Begin Resource Environment Group structured field begins a Resource Environment Group(REG), " +
                        "which defines a subset of the resources required for a document or for a group of pages in a document.The scope of the Resource " +
                        "Environment Group is the group of pages that follow, up to the next REG, which is a complete replacement for the current REG, or the end of the document, whichever occurs first.";
                    break;
                case "D3A8DF":
                    c = "BMO";
                    r = "Begin Overlay";
                    d = "The Begin Overlay structured field begins an overlay. An overlay contains an active environment " +
                       "group to establish parameters such as the size of the overlay's presentation space and the fonts to be used by the data objects.It may also contain " +
                       "any mixture of: Bar code objects, Graphics objects, Image objects, Object containers, Presentation text objects";
                    break;
                case "D3A8E3":
                    c = "BDX";
                    r = "Begin Data Map Transmission Subcase";
                    d = "The Begin Data Map Transmission Subcase structured " +
                        "field begins a Data Map Transmission Subcase object, which contains the structured fields used to map lines of data to the page.";
                    break;
                case "D3A8EB":
                    c = "BBC";
                    r = "Begin Bar Code Object";
                    d = "The Begin Bar Code Object structured field begins a bar code data object, which becomes the current data object.";
                    break;
                case "D3A8FB":
                    c = "BIM";
                    r = "Begin Image Object IO";
                    d = "The Begin Image Object structured field begins an IOCA image data object, which becomes the current data object.";
                    break;
                case "D3A95F":
                    c = "EPS";
                    r = "End Page Segment";
                    d = "The End Page Segment structured field terminates the page segment resource object initiated by a Begin Page Segment structured field.";
                    break;
                case "D3A97B":
                    c = "EII";
                    r = "End IM Image Object";
                    d = "The End IM Image Object structured field terminates the current IM image object initiated by a Begin IM Image Object structured field.";
                    break;
                case "D3A992":
                    c = "EOC";
                    r = "End Object Container";
                    d = "The End Object Container structured field terminates an object container initiated by a Begin Object Container structured field.";
                    break;
                case "D3A99B":
                    c = "EPT";
                    r = "End Presentation Text Object";
                    d = "The End Presentation Text Object structured field terminates the current " +
                        "presentation text object initiated by a Begin Presentation Text Object structured field.";
                    break;
                case "D3A9A7":
                    c = "EDI";
                    r = "End Document Index";
                    d = "The End Document Index structured field terminates the document index initiated by a Begin Document Index structured field.";
                    break;
                case "D3A9A8":
                    c = "EDT";
                    r = "End Document";
                    d = "The End Document structured field terminates the MO:DCA document data stream initiated by a Begin Document structured field.";
                    break;
                case "D3A9AD":
                    c = "ENG";
                    r = "End Named Page Group";
                    d = "The End Named Page Group structured field terminates a page group that was initiated by a Begin Named Page Group structured field.";
                    break;
                case "D3A9AF":
                    c = "EPG";
                    r = "End Page";
                    d = "The End Page structured field terminates the current presentation page definition initiated by a Begin Page structured field.";
                    break;
                case "D3A9BB":
                    c = "EGR";
                    r = "End Graphics Object";
                    d = "The End Graphics Object structured field terminates the current graphics object initiated by a Begin Graphics Object structured field.";
                    break;
                case "D3A9C4":
                    c = "EDG";
                    r = "End Document Environment Group";
                    d = "The End Document Environment Group structured field terminates the definition of a document " +
                        "environment group initiated by a Begin Document Environment Group structured field.";
                    break;
                case "D3A9C5":
                    c = "EFG";
                    r = "End Form Environment Group";
                    d = "Documentation for this does not have a description...";
                    break;
                case "D3A9C6":
                    c = "ERG";
                    r = "End Resource group";
                    d = "The End Resource Group structured field terminates the definition of a resource group initiated by a Begin Resource Group structured field.";
                    break;
                case "D3A9C7":
                    c = "EOG";
                    r = "End Object Environment Group";
                    d = "The End Object Environment Group structured field terminates the definition of an Object " +
                        "Environment Group initiated by a Begin Object Environment Group structured field.";
                    break;
                case "D3A9C9":
                    c = "EAG";
                    r = "End Active Environment Group";
                    d = "The End Active Environment Group structured field terminates the definition of an Active " +
                        "Environment Group initiated by a Begin Active Environment Group structured field.";
                    break;
                case "D3A9CA":
                    c = "EDM";
                    r = "End Data Map";
                    d = "The End Data Map structured field terminates the Data Map object initiated by a Begin Data Map structured field.";
                    break;
                case "D3A9CB":
                    c = "EPM";
                    r = "End Page Map";
                    d = "The End Page Map structured field terminates the Page Map object initiated by a Begin Page Map structured field.";
                    break;
                case "D3A9CC":
                    c = "EMM";
                    r = "End Medium Map";
                    d = "The End Medium Map structured field terminates the medium map object initiated by a Begin Medium Map structured field";
                    break;
                case "D3A9CD":
                    c = "EFM";
                    r = "End Form Map";
                    d = "The End Form Map structured field terminates the form map object initiated by a Begin Form Map structured field";
                    break;
                case "D3A9CE":
                    c = "ERS";
                    r = "End Resource";
                    d = "The End Resource structured field terminates an envelope that is used to carry resource objects " +
                        "in external(print file level) resource groups.The envelope is initiated by a Begin Resource (BRS) structured field.";
                    break;
                case "D3A9D9":
                    c = "ESG";
                    r = "End Resource Environment Group";
                    d = "The End Resource Environment Group structured field terminates the definition of a Resource " +
                        "Environment Group initiated by a Begin Resource Environment Group structured field.";
                    break;
                case "D3A9DF":
                    c = "EMO";
                    r = "End Overlay";
                    d = "The End Overlay structured field terminates the overlay resource object initiated by a Begin Overlay structured field.";
                    break;
                case "D3A9E3":
                    c = "EDX";
                    r = "End Data Map Transmission Subcase";
                    d = "The End Data Map Transmission Subcase structured field " +
                        "terminates the Data Map Transmission Subcase initiated by a Begin Data Map Transmission Subcase structured field.";
                    break;
                case "D3A9EB":
                    c = "EBC";
                    r = "End Bar Code Object";
                    d = "The End Bar Code Object structured field terminates the current bar code object initiated by a Begin Bar Code Object structured field.";
                    break;
                case "D3A9FB":
                    c = "EIM";
                    r = "End Image Object";
                    d = "The End Image Object structured field terminates the current image object initiated by a Begin Image Object structured field.";
                    break;
                case "D3AAE7":
                    c = "LNC";
                    r = "Line Descriptor Count";
                    d = "The Line Descriptor Count structured field specifies the number of Line Descriptor " +
                        "(LND), Record Descriptor (RCD) or XML Descriptor (XMD) structured fields in the Data Map Transmission Subcase.";
                    break;
                case "D3AAEC":
                    c = "FDS";
                    r = "Fixed Data Size";
                    d = "The Fixed Data Size structured field specifies the number of bytes of text found in the following Fixed Data Text (FDX) structured fields.";
                    break;
                case "D3AB88":
                    c = "MMT";
                    r = "Map Media Type";
                    d = "The Map Media Type structured field maps a media type local ID to the name or OID " +
                        "of a media type.See 'Media Type Identifiers' on page 639 for a list of media types registered by their name and their OID.";
                    break;
                case "D3AB92":
                    c = "MCD";
                    r = "Map Container Data";
                    d = "The Map Container Data structured field specifies how a presentation data object " +
                        "that is carried within an object container is mapped into its object area.";
                    break;
                case "D3ABAF":
                    c = "BDT";
                    r = "Map Page";
                    d = "The Map Page structured field identifies a page that is to be merged with " +
                        "data specified for the current page by using an Include Page(IPG) structured field.";
                    break;
                case "D3ABBB":
                    c = "MGO";
                    r = "Map Graphics Object";
                    d = "The Map Graphics Object structured field specifies how a graphics data object is mapped into its object area.";
                    break;
                case "D3ABC3":
                    c = "MDR";
                    r = "Map Data Resource";
                    d = "The Map Data Resource structured field specifies resources that are required for presentation. " +
                        "Each resource reference is defined in a repeating group and is identified with a file name, the identifier of a begin structured field for the " +
                        "resource, or any other identifier associated with the resource.The MDR repeating group may additionally " +
                        "specify a local or internal identifier for the resource object. Such a local identifier may be embedded one or more times within an object's data.";
                    break;
                case "D3ABCA":
                    c = "IDM";
                    r = "Invoke Data Map";
                    d = "The Invoke Data Map structured field selects a new Data Map for printing line data and ends the " +
                        "current line-format page. With LND Data Maps, processing begins with the first Line Descriptor (LND) structured field of the invoked " +
                        "Data Map for the next line-format page. With RCD Data Maps, processing begins with the first Record Descriptor (RCD) structured field " +
                        "that matches the Record ID of the current line-data record. With XMD Data Maps, processing begins with the first XML Descriptor (XMD) " +
                        "structured field that matches the current Qualified Tag.";
                    break;
                case "D3ABCC":
                    c = "IMM";
                    r = "Invoke Medium Map";
                    d = "The Invoke Medium Map structured field identifies the medium map that is to become active " +
                        "for the document.An Invoke Medium Map structured field affects the document's current environment. The medium map's " +
                        "effect on current environment parameter values lasts until a new medium map is invoked. The processing system's " +
                        "form map is searched for the specified medium map unless the IMM directly follows an internal medium map, in which case the IMM " +
                        "can reference and activate that internal medium map.An IMM that does not follow an internal medium map cannot be used to " +
                        "reference an internal medium map elsewhere in the document and is assumed to reference a medium map in the " +
                        "processing system's form map. If a document does not invoke a medium map by name, and if it does not include an " +
                        "internal medium map, the first medium map in the selected form map controls document presentation.";
                    break;
                case "D3ABD8":
                    c = "MPO";
                    r = "Map Page Overlay";
                    d = "The Map Page Overlay structured field maps local identifiers to page overlay names.";
                    break;
                case "D3ABEA":
                    c = "MSU";
                    r = "Map Suppression";
                    d = "The Map Suppression structured field maps one-byte text suppression local identifiers " +
                        " to text suppression names.Suppressible text is identified in presentation text objects with a local identifier " +
                        "and is bracketed with control sequences that specify the beginning and the end of the suppression.  A " +
                        "text suppression is activated by specifying its local identifier in a Medium Modification Control (MMC) structured field in a medium map.";
                    break;
                case "D3ABEB":
                    c = "MBC";
                    r = "Map Bar Code";
                    d = "The Map Bar Code Object structured field specifies how a bar code data object is to be mapped into its object area.";
                    break;
                case "D3ABFB":
                    c = "MIO";
                    r = "Map Image Object";
                    d = "The Map Image Object structured field specifies how an image data object is mapped into its object area.";
                    break;
                case "D3AC6B":
                    c = "BOP";
                    r = "Object Area Position";
                    d = "The Object Area Position structured field specifies the origin and orientation of the object " +
                        "area, and the origin and orientation of the object content within the object area.";
                    break;
                case "D3AC7B":
                    c = "ICP";
                    r = "Image Cell Position";
                    d = "The IM Image Cell Position structured field specifies the placement, size, and replication of IM image cells.";
                    break;
                case "D3ACAF":
                    c = "PGP";
                    r = "Page Position (Format 1)";
                    d = "The Page Position structured field specifies the position and orientation of a page's presentation " +
                       "space on the medium presentation space for the physical medium. The PGP may be located in a medium map or in the document environment " +
                       "group of a form map.When present in the active medium map, it overrides a PGP in the document environment group of the form map. If " +
                       "N-up partitioning is specified by the Medium Modification Control structured field in the active medium map, the medium presentation " +
                       "spaces on the front and back sides of a sheet are divided into N partitions; and the Page Position structured field specifies the " +
                       "partition into  which each page is mapped and with respect to which the page presentation space is positioned and oriented.  Read More on Docs";
                    break;
                case "D3ADC3":
                    c = "PPO";
                    r = "Preprocess Presentation Object";
                    d = "The Preprocess Presentation Object structured field specifies presentation parameters for " +
                        "a data object that has been mapped as a resource.These parameters allow the presentation device to preprocess and cache " +
                        "the object so that it is in presentation-ready format when it is included with a subsequent include structured field " +
                        "in the document. Such preprocessing may involve a rasterization or RIP of the object, but is not limited to that. The " +
                        "resource is identified with a file name, the identifier of a begin structured field for the resource, or any other " +
                        "identifier associated with the resource. The referenced resource and all required secondary resources must previously have " +
                        "been mapped with an MDR or an MPO in the same environment group. \r\n " +
                        "Preprocessing is not supported for objects that are included with structures that are outside the document. " +
                        "Examples of such objects are medium overlays and PMC overlays, both of which are included with structures in the form map.";
                    break;
                case "D3AF5F":
                    c = "IPS";
                    r = "Include Page Segment";
                    d = "The Include Page Segment structured field references a page segment resource object that " +
                        "is to be presented on the page or overlay presentation space.The IPS specifies a reference point on the including " +
                        "page or overlay coordinate system that may be used to position objects contained in the page segment.A page segment " +
                        "can be referenced at any time during page or overlay state, but not during an object state. The page segment inherits " +
                        "the active environment group definition of the including page or overlay.";
                    break;
                case "D3AFAF":
                    c = "IPG";
                    r = "Include Page";
                    d = "The Include Page structured field references a page that is to be included in the document. " +
                                "The Include Page structured field may occur in document state, page-group state, or page state.In all three cases the " +
                                "referenced page is positioned on the media using the (Xm, Ym) offsets specified in the PGP structured field in the " +
                                "active medium map.The referenced page must not contain another Include Page structured field.";
                    break;
                case "D3AFC3":
                    c = "IOB";
                    r = "Include Object";
                    d = "An Include Object structured field references an object on a page or overlay. It optionally " +
                        "contains parameters that identify the object and that specify presentation parameters such as object position, size, " +
                        "orientation, mapping, and default color. Where the presentation parameters conflict with parameters specified in the " +
                        "object's environment group (OEG), the parameters in the Include Object structured field override. If the referenced " +
                        "object is a page segment, the IOB parameters override the corresponding environment group parameters on all data objects " +
                        "in the page segment.";
                    break;
                case "D3AFD8":
                    c = "IPO";
                    r = "Include Page Overlay";
                    d = "The Include Page Overlay structured field references an overlay resource definition " +
                        "that is to be positioned on the page.A page overlay can be referenced at any time during the page state, but " +
                        "not during an object state. The overlay contains its own active environment group definition. The current environment " +
                        "of the page that included the overlay is restored when the Include Page Overlay has been completed.";
                    break;
                case "D3B15F":
                    c = "MPS";
                    r = "Map Page Segment";
                    d = "The Map Page Segment structured field identifies page segments that are required to present a page on a physical medium.";
                    break;
                case "D3B18A":
                    c = "MCF";
                    r = "Map Coded Format (Format 2)";
                    d = "The Map Coded Font structured field maps a unique coded font resource local ID, which " +
                        "may be embedded one or more times within an object's data and descriptor, to the identifier of a coded font " +
                        "resource object. This identifier may be specified in one of the following formats: A coded font Global Resource " +
                        "Identifier(GRID), A coded font name, A combination of code page name and font character set name";
                    break;
                case "D3B19B":
                    c = "PTD";
                    r = "Presentation Text Descriptor";
                    d = "The Presentation Text Data Descriptor structured field contains the descriptor data for a presentation text data object.";
                    break;
                case "D3B1AF":
                    c = "PGP-2";
                    r = "Page Position (Format 2)";
                    d = "The Page Position structured field specifies the position and orientation of a page's presentation " +
                        "space on the medium presentation space for the physical medium. The PGP may be located in a medium map or in the document environment group " +
                        "of a form map.When present in the active medium map, it overrides a PGP in the document environment group of the form map. If " +
                        "N-up partitioning is specified by the Medium Modification Control structured field in the active medium map, the medium presentation " +
                        "spaces on the front and back sides of a sheet are divided into N partitions; and the Page Position structured field specifies the partition into " +
                        "which each page is mapped and with respect to which the page presentation space is positioned and oriented. Read More in docs";
                    break;
                case "D3B1DF":
                    c = "MMO";
                    r = "Map Medium Overlay";
                    d = "The Map Medium Overlay structured field maps one-byte medium overlay local identifiers " +
                        "that are specified by keywords in the Medium Modification Control (MMC) structured field to medium overlay names.";
                    break;
                case "D3B288":
                    c = "PFC";
                    r = "Presentation Fidelity Control";
                    d = "The Presentation Fidelity Control structured field specifies the user fidelity requirements for data " +
                        "presented on physical media and for operations performed on physical media.The scope of the Presentation Fidelity Control structured field " +
                        "is the document or print file controlled by the form map that contains this structured field.";
                    break;
                case "D3B2A7":
                    c = "IEL";
                    r = "Index Element";
                    d = "The Index Element structured field identifies begin structured fields for use within a document index.";
                    break;
                case "D3B490":
                    c = "LLE";
                    r = "Link Logical Element";
                    d = "A Link Logical Element structured field specifies the linkage from a source document component " +
                        "to a target document component.The LLE identifies the source and target and indicates the purpose of the linkage by specifying " +
                        "a link type.The link source and link target may be in the same document component or in different document components, " +
                        "and they need not be of the same document component type.The linkage may involve a complete document component, or it " +
                        "may be restricted to a rectangular area on the presentation space associated with the document component. The " +
                        "Link Logical Element structured field can be embedded in the document that contains the link source, in the document that " +
                        "contains the link target, in the document index for either document, or in any combination of these structures. Link " +
                        "Logical Element parameters do not provide any presentation specifications.";
                    break;
                case "D3EE7B":
                    c = "IRD";
                    r = "Image Raster Data";
                    d = "The IM Image Raster Data structured field contains the image points that define the raster pattern for an IM image data object.";
                    break;
                case "D3EE92":
                    c = "OCD";
                    r = "Object Container Data";
                    d = "The Object Container Data structured field contains the data for an object carried in " +
                        "an object container.See “Object Type Identifiers” on page 623 for the list of object types that may be carried in an object container.";
                    break;
                case "D3EEBB":
                    c = "GAD";
                    r = "Graphics Data";
                    d = "The Graphics Data structured field contains the data for a graphics object.";
                    break;
                case "D3EE9B":
                    c = "PTX";
                    r = "Presentation Text Data";
                    d = "The Presentation Text Data structured field contains the data for a presentation text data object.";
                    break;
                case "D3EEEB":
                    c = "BDA";
                    r = "Bar Code Data";
                    d = "The Bar Code Data structured field contains the data for a bar code object.";
                    break;
                case "D3EEEC":
                    c = "FDX";
                    r = "Fixed Data Text";
                    d = "The Fixed Data Text structured field contains text that can be selected and presented " +
                        "with LND, RCD or XMD structured fields in the Page Definition. This text is used when flag bit 7 of the LND, RCD or " +
                        "XMD is set to B'1'. Any number of FDX structured fields can appear, but the total number of data bytes must match " +
                        "bytes 0–1 of the Fixed Data Size (FDS) structured field. The output should fit on the page, and the fit can be affected by the size of the font used";
                    break;
                case "D3EEEE":
                    c = "NOP";
                    r = "No Operation";
                    d = "The No Operation structured field performs no function.";
                    break;
                case "D3EEFB":
                    c = "IPD";
                    r = "Image Pictue Data";
                    d = "The Image Picture Data structured field contains the data for an image data object.";
                    break;
                default:
                    c = "UNK";
                    r = "Unknown";
                    d = "This Field has not been mapped";
                    break;
            }
            return r;
        }
       
    }
}
