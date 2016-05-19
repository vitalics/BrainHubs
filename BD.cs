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
            string image, string link,string nameCategory, int idReference)
        {
            builder(BDNews.InsertNewsOne(header, textNews, keyword, image, link, nameCategory, idReference));
            
        }

        public string[] GetNewsOne(int id)
        {
             return	builder(BDNews.SelectNewsOne(id));
        }
        public string[] GetlastForCategory(string NameCategory)
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

        public void RecordReferens(string reference)
        {
        	builder(BDNews.InsertReference(reference));

        }
        public void RecordNewMan(string post, string login, string password)
        {
          	builder(BDNews.Insertuser(post,login,password));

        }
        public bool ChekLogin(string login)
        {
        	bool result=false;
           if (builder(BDNews.SelectedLogin(login))!=null)
           result=true;
           
           return resulte;
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
        	return builder(BDNews.Selectedreference(idNews)); 
        }
    }
}
