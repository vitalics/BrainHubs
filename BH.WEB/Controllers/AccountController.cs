using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BH.WEB.Controllers
{
    public class AccountController : ApiController
    {
        BD.BD bd = new BD.BD();
        public bool Get(string login, string password)
        {
            if (bd.ChekAccount(login,password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PutRegistor(string header, string textNews, string keyword,
         string image, string link, string nameCategory, int idReference)
        {
            bd.RecordNewsOne(header, textNews, keyword,
                image, link, nameCategory, idReference);
        }
    }
}