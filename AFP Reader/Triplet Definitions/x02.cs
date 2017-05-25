using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Triplet_Definitions
{
    class x02: Base
    {
        public string FQNFmt { get; set; }
        public string FQNType { get; set; }
        public string FQName { get; set; }

        x02(AFPDataLine d) {
            byte[] data = d.data.ToArray();
            Length = data[0];
            Tid = "x02";
            Name = "Fully Qualified Name";
            Type = GetTripType(data[2]);
            Data = GetParseDataByFormat(data[3], data.Skip(4).Take(data.Length - 4));
        }


        private string GetTripType(byte b)
        {
            string r;
            switch (b) {
                case 0x01:
                    r = "Replace First GID Name";
                    break;
                case 0x07:
                    r = "Font Family Name";
                    break;
                case 0x08:
                    r = "Font Typeface Name";
                    break;
                case 0x09:
                    r = "MO:DCA Resource Hierarchy Reference";
                    break;
                case 0x0A:
                    r = "Begin Resource Group Reference";
                    break;
                case 0x0B:
                    r = "Attribute GID";
                    break;
                case 0x0C:
                    r = "Process Element GID";
                    break;
                case 0x0D:
                    r = "Begin Page Group Reference";
                    break;
                case 0x11:
                    r = "Media Type Reference";
                    break;
                case 0x12:
                    r = "Media Destination Reference";
                    break;
                case 0x41:
                    r = "Color Management Resource Reference";
                    break;
                case 0x6E:
                    r = "Data-object Font Base Font Identifier";
                    break;
                case 0x7E:
                    r = "Data-object Font Linked Font Identifier";
                    break;
                case 0x83:
                    r = "Begin Document Reference";
                    break;
                case 0x84:
                    r = "Resource Object Reference";
                    break;
                case 0x85:
                    r = "Code Page Name Reference";
                    break;
                case 0x86:
                    r = "Font Character Set Name Reference";
                    break;
                case 0x87:
                    r = "Begin Page Reference";
                    break;
                case 0x8D:
                    r = "Begin Medium Map Reference";
                    break;
                case 0x8E:
                    r = "Coded Font Name Reference";
                    break;
                case 0x98:
                    r = "Begin Document Index Reference";
                    break;
                case 0xB0:
                    r = "Begin Overlay Reference";
                    break;
                case 0xBE:
                    r = "Data Object Internal Resource Reference";
                    break;
                case 0xCA:
                    r = "Index Element GID";
                    break;
                case 0xCE:
                    r = "Other Object Data Reference";
                    break;
                case 0xDE:
                    r = "Data Object External Resource Reference";
                    break;
                default:
                    r = "UNDEFINED";
                    break;
            }
            return r;
        }

        private string GetParseDataByFormat(byte format, IEnumerable<byte> data) {
            string result = "";
            if (format == 0x00)
            {
                result = ConvertToEBSIDIC((byte[])data);
            }
            else if (format == 0x10) {
                // NOT DONE YET
            }
            else if (format == 0x20)
            {
                // NOT DONE YET
            }

            return result;
        }
        
        
    }
}
