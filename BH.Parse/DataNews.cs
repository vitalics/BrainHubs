using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParserAndOther
{
    class DataNews
    {
        string headline;
        string imageURL;
        string text;
        string keyword;
        string category;
        string site;

        public DataNews(string headline, string imageURL,string text, string keyword,
                         string category, string site)
        {
            this.headline = headline;
            this.imageURL = imageURL;
            this.text = text;
            this.keyword = keyword;
            this.category = category;
            this.site = site;
        }

        public string Site
        {
            get
            {
                return site;
            }
        }

        public string Categore
        {
            get
            {
                return category;
            }
        }

        public string Keyword
        {
            get
            {
                return keyword;
            }
        }

        public string Text
        {
            get
            {
                return text;
            }

        }

        public string ImageURL
        {
            get
            {
                return imageURL;
            }
        }

        public string Headline
        {
            get
            {
                return headline;
            }
        }
    }
}
