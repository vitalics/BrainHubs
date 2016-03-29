using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Parse
{
     public interface IParser
    {
         string ParserLine(string requestName);

         string ParserAttributes(string requestName, string attribut);

         string ParserText(string requestName, string tag);

        ArrayList ParserArrayByAttributes(string requestName, string attribut);

    }
}
