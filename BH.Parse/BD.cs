using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;


namespace BD
{ 
    class BD
    {
	
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        public BD() {
            builder["Data Source"] = "(local)";
            builder["integrated Security"] = true;
            builder["Initial Catalog"] = "BDNews";
        }

    
        public void RecordNewsOne(string header, string textNews, string keyword ,
            string image, string link,string nameCategory, int[] idReference)
        {
            builder(BDNews.InsertNewsOne(header, textNews, keyword, image, link, nameCategory, idReference));
            
        }

        public string[] GetNewsOne(int id)
        {
             return	builder(BDNews.SelectNewsOne(id));
        }
        public string[] GetLastForCategory(string NameCategory)
        {  
        	int id=builder(BDNews.SelectedIdLastNews());
        	string[] result;
        	for(int i=0;i<50;i++)
        	{
        	if(builder(BDNews.SelectNewsOneCategory(id-i,NameCategory))!=null)
        	{
        	result[i]=builder(BDNews.SelectNewsOneCategory(id-i,NameCategory));
        	}
        	else break;
        	}
        	return result;
        }

        public void RecordReferens(int id, int idReference)
        {
        	builder(BDNews.InsertReference(id, idReference));

        }
        public void RecordLikeNews(string email, int id)
        {
            builder(BDNews.InsertReferenceLikeNews(email,id));

        }
        public void RecordNewMan(string email, string login, string password)
        {
          	builder(BDNews.InsertUser(email,login,password));

        }
        public void RecordFavouritCategory(string email, string favouriteCategory)
        {
            builder(BDNews.InsertFavouritCategory(email, favouriteCategory));

        }
        public bool ChekAccount(string login, string password)
        {
        	bool result=false;
            if (builder(BDNews.SelectedLogin(login)) && builder(BDNews.SelectedPassword(password)))
            {
                result = true;
            }
            return result;
        }

        public string[] GetNewsLast()
        {
        	int id=builder(BDNews.SelectedIdLastNews());
        	string[] result;
        	for(int i=0;i<50;i++)
        	{
        	if(builder(BDNews.SelectNewsOne(id))!=null)
        	{
        	result[i]=builder(BDNews.SelectNewsOne(id-i));
        	}
        	else break;
        	}
        	return result;
        }
        public int GetReferens(int idNews)
        {
        	return builder(BDNews.SelectedReference(idNews)); 
        }

        public int[] GetFavouritesNews(string email)
        {
            return builder(BDNews.SelectedFavouritesNews(email));
        }

        public string GetCategory(int id)
        {
            return uilder(BDNews.SelectedCategory(id));
        }
    }
}
