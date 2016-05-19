using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParserAndOther
{
    class ParsNavinyBy : IPars
    {
        BD.BD db = new BD.BD();
        private string url = "http://naviny.by/rubrics/";
        private string[] categories = { "politic", "economic", "society", "abroad", "sport" };
        const string site = "naviny.by";
        private int numberCategory;

        public void Pars()
        {
            for (int i = 0; i < categories.Length; i++)
            {
                numberCategory = i;
                Parser parsNaviny = new Parser(url + categories[i]);
                ArrayList list = parsNaviny.ParserArrayByAttributes("//*[@class='news']/li/a", "href"); ;
                list = SelectURL(list, url + categories[i]);
                EntryList(list);
            }
        }

        private ArrayList SelectURL(ArrayList list, string url)
        {
            ArrayList newList = new ArrayList();
            for (int i = 0; i < list.Count; i++)
            {
                string str = list[i].ToString();
                if (str.IndexOf(url) >= 0)
                {
                    newList.Add(list[i]);
                }
            }
            return newList;
        }

        private DataNews GetDataNews(string urlNews)
        {
            Parser parsUrlParser = new Parser(urlNews);
            string headline = parsUrlParser.ParserString("//*[@class='entry-title']");
            string text = "";
            ArrayList textsArrayList = parsUrlParser.ParserArrayByTag("//*[@class='hentry']", "/p");
            text = string.Join(null, textsArrayList.ToArray());
            string imageURL = parsUrlParser.ParserStringByAttributes("//*[@align='justify']/img", "src");
            string keyword = parsUrlParser.ParserStringByAttributes("//*[@name='keywords']", "content");
            DataNews news = new DataNews(headline, imageURL, text, keyword, categories[numberCategory], site);
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
