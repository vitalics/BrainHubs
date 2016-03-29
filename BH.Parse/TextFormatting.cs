using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Parse
{
    class TextFormatting
    {
        public static string DelSubString(string str)
        {
            int startPosition = 0;
            int finaliPosition = 0;
            int length;
            while (true)
            {
                startPosition = str.IndexOf('&', startPosition);
                finaliPosition = str.IndexOf(';', finaliPosition);
                if (startPosition == -1 || finaliPosition == -1)
                {
                    break;
                }
                length = finaliPosition - startPosition + 1;
                string subString = str.Substring(startPosition, length);
                str = str.Replace(subString, " ");
            }
            return str;
        }
    }
}
