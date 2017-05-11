using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader
{
    public static class AFPFormatHelper
    {
        public static List<AFPDataLine> Lines(byte[] rawafp) {
            List<AFPDataLine> result = new List<AFPDataLine>();
            for (int curIndex = 0; curIndex < rawafp.Length-1;) {
                if (rawafp[curIndex] == 90)
                {
                    int rowEndIndex = getEndIndex(curIndex, rawafp[curIndex + 1], rawafp[curIndex + 2]);
                    if (rowEndIndex == -1) rowEndIndex = rawafp.Length - 1;

                    result.Add(new AFPDataLine(rawafp, curIndex, rowEndIndex));
                    curIndex = rowEndIndex+1;
                }
                else {
                    curIndex++;
                }
            }
            return result;
        }

        public static int getEndIndex(int start, byte l1, byte l2) {
            int length = (256 * l1) + l2;
            return start + length;
        }
    }
}
