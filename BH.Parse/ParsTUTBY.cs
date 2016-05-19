using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParserAndOther
{
    class ParsTUTBY : IPars
    {
        BD.BD db = new BD.BD();
        private string url = "http://news.tut.by/";
        private string[] categories = { "politics", "economics", "society", "world", "sport" };
        const string site = "tut.by";
        private int numberCategory;

        public void Pars()
        {   
            for (int i = 0; i < categories.Length; i++)
            {
                numberCategory = i;
                Parser parsTut = new Parser(url + categories[i]);
                ArrayList list = parsTut.ParserArrayByAttributes("//*[@class='b-lists']/li/div[1]/a", "href");
                list = SelectURL(list, url + categories[i]);
                EntryList(list);
            }
        }

        private ArrayList SelectURL(ArrayList list, string url)
        {
            ArrayList newList = new ArrayList();
            for (int i = 0; i < list.Count; i++)
            {
                string str =list[i].ToString();
                if (str.IndexOf(url)>=0)
                {
                    newList.Add(list[i]);
                }
            }
            return newList;
        }

        private DataNews GetDataNews(string urlNews)
        {
            Parser parsUrlParser = new Parser(urlNews);
            string headline = parsUrlParser.ParserString("//*[@class='m_header']/h1");
            string text = parsUrlParser.ParserText("//*[@id='article_body']", "/p");
            string imageURL = parsUrlParser.ParserStringByAttributes("//*[@id='article_body']/p[2]/img", "src");
            string keyword = parsUrlParser.ParserStringByAttributes("//*[@name='news_keywords']", "content");
            DataNews news = new DataNews(headline,imageURL,text,keyword,categories[numberCategory],site);
            return news;
        }

        private void Add(DataNews news)
        {
            int[] refirence = null;
            db.RecordNewsOne(news.Headline, news.Text, news.Keyword,
                             news.ImageURL, news.Site, news.Categore, refirence);
        }

        private void EntryList(ArrayList list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                DataNews news = GetDataNews(list[i].ToString());
                Add(news);
            }
        }
    }
}
