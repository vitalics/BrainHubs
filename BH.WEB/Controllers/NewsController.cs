using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BH.Parse;

namespace BH.WEB.Controllers
{
    public class NewsController : ApiController
    {
        
        BD.BD bd = new BD.BD();

        public IEnumerable<DataNews> GetLastNews()
        {
            return bd.GetNewsLast();
        }

        public IEnumerable<DataNews> GetLastNewsFoCategory(string category)
        {
            return bd.GetLastForCategory(category);
        }

        public void PutLikeNews(int id, string email)
        {
            bd.RecordLikeNews(email, id);
        }
    }
}