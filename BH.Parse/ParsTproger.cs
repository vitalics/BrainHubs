using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Parse;

namespace TestParserAndOther
{
    class ParsTproger : IPars
    {
        private string url = "https://tproger.ru/";
        const string category = "IT";
        const string site = "tproger.ru";

        public void Pars()
        {

            Parser parsTproger = new Parser(url);
            ArrayList list = parsTproger.ParserArrayByAttributes("//*[@id='main_columns']/article/div[1]/div[1]/h1/a", "href");
            list = SelectURL(list, url);
            EntryList(list);
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
            ArrayList textsArrayList = parsUrlParser.ParserArrayByTag("//*[@class='entry-content']", "/p");
            text = string.Join(null, textsArrayList.ToArray());
            string imageURL = parsUrlParser.ParserStringByAttributes("//*[@class='entry-image']/a/img", "src");
            SearchKeywords searchKeywords = new SearchKeywords(text);

            string keyword = CreateStringKeywords(searchKeywords.GetKeywords);
            DataNews news = new DataNews(headline, imageURL, text, keyword, category, site);
            return news;
        }

        private void Add(DataNews news)
        {

        }

        private void EntryList(ArrayList list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                DataNews news = GetDataNews(list[i].ToString());
                Add(news);
            }
        }

        private string CreateStringKeywords(Dictionary<string, double> keywords)
        {
            string stringKeywords;

            string[] arrayKeyword = new string[keywords.Count];

            for (int i = 0; i < arrayKeyword.Length; i++)
            {
                arrayKeyword[i] = keywords[i].Key;
            }
            stringKeywords = string.Join(null, arrayKeyword);

            return stringKeywords;
        }
    }
}
