using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader
{
    public class AFPDataLine
    {
        public string prefix { get; set; }
        public int length { get; set; }
        public string[] SFIdentifier { get; set; }
        public string SFICode { get; set; }
        public string SFIString { get; set; }
        public string SFIDesc { get; set; }
        public string SFIReference { get; set; }
        public string flags { get; set; }
        public string[] reserved { get; set; }
        public List<byte> data { get; set; }


        public AFPDataLine(byte[] data, int start, int end) {
            prefix = data[start].ToString("X2");
            length = data[start+2] + (data[start + 1] * 256);
            SFIdentifier = new string[] { data[start + 3].ToString("X2"), data[start + 4].ToString("X2"), data[start + 5].ToString("X2") };
            flags = data[start + 6].ToString("X2");
            reserved = new string[] { data[start + 7].ToString("X2"), data[start + 8].ToString("X2") };
            this.data = new List<byte>();
            for (int i = start+9; i < end; i++) {
                this.data.Add(data[i]);
            }
            SFIString = GetReadableSFI(SFIdentifier);
            SFIDesc = GetSFIDescription(SFIdentifier);
            SFIReference = GetSFIRef(SFIdentifier);
            SFICode = GetSFICode(SFIdentifier);
        }
        
        public string GetReadableSFI(string[] SFIhex) {
            string joinedString = SFIhex[0] + SFIhex[1] + SFIhex[2];
            return SFILooksups.StandardFieldInfo[joinedString].Name;
        }
        public string GetSFIDescription(string[] SFIhex) {
            string joinedString = SFIhex[0] + SFIhex[1] + SFIhex[2];
            return SFILooksups.StandardFieldInfo[joinedString].Description;
        }
        public string GetSFIRef(string[] SFIhex) {
            string joinedString = SFIhex[0] + SFIhex[1] + SFIhex[2];
            return SFILooksups.StandardFieldInfo[joinedString].Reference;
        }
        public string GetSFICode(string[] SFIhex)
        {
            string joinedString = SFIhex[0] + SFIhex[1] + SFIhex[2];
            return SFILooksups.StandardFieldInfo[joinedString].Code;
        }
    }
}
