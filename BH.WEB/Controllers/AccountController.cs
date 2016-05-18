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
        BD.BD db = new BD.BD();
        public bool Get(string login, string password)
        {
            if (db.ChekAccount(login,password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PutRegistor(string email, string login, string password)
        {
            db.RecordNewMan(email, login, password);
        }
    }
}