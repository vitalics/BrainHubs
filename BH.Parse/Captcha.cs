using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Parse
{
    static class Captcha
    {
       static string[] captcha =new string[] {"и","а","но","или","он","они","она","если","да","то","ли"};
       static public string[] GetCaptch
        {
            get
            {
                return captcha;
            }
        }
    }
}
