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
        
        BD.BD db = new BD.BD();

        public IEnumerable<DataNews> GetLastNews()
        {
            return db.GetNewsLast();
        }

        public IEnumerable<DataNews> GetLastNewsFoCategory(string category)
        {
            return db.GetLastForCategory(category);
        }

        public void PutLikeNews(int id, string email)
        {
            db.RecordLikeNews(email, id);
        }
    }
}