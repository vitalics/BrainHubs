using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParserAndOther;

namespace BH.Parse
{
    class MainParser
    {
        public MainParser()
        {
            ParsTUTBY parsTutby = new ParsTUTBY();
            parsTutby.Pars();

            ParsNavinyBy parsNavinyBy = new ParsNavinyBy();
            parsNavinyBy.Pars();

            ParsTproger parsTproger = new ParsTproger();
            parsTproger.Pars();
        }
    }
}
