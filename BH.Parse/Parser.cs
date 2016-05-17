using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;
using System.IO;
using System.Web;

namespace TestParserAndOther
{
    public class Parser : IParser
    {
        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
        string url;

        private string GetRequest(string url)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.AllowAutoRedirect = false;
                httpWebRequest.Method = "GET";
                httpWebRequest.Referer = "http://google.com";
                using (var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    using (var stream = httpWebResponse.GetResponseStream())
                    {
                        using (var reader = new StreamReader(stream, Encoding.GetEncoding(httpWebResponse.CharacterSet)))
                        {
                            return reader.ReadToEnd();
                        }
                    }
                }
            }
            catch
            {
                return String.Empty;
            }
        }

        public string ParserString(string requestName)
        {
            string str;
            var bodyNode = doc.DocumentNode.SelectSingleNode(requestName);
            str = bodyNode.InnerText;
            return str;
        }

        public string ParserStringByAttributes(string requestName, string attribut)
        {
            string information;
            var bodyNode = doc.DocumentNode.SelectSingleNode(requestName);
            information = bodyNode.Attributes[attribut].Value;
            return information;
        }

        public string ParserText(string requestName, string tag)
        {
            ArrayList line = new ArrayList();
            var bodyNode = doc.DocumentNode.SelectSingleNode(requestName);
            string text = bodyNode.InnerText.Trim(); 
            return text;
        }

        public Parser(string url)
        {
            this.url = url;
            doc.LoadHtml(GetRequest(url));
        }

        public ArrayList ParserArrayByAttributes(string requestName, string attribut)
        {
            ArrayList list = new ArrayList();
            var bodyNode = doc.DocumentNode.SelectNodes(requestName);
            for (int i = 0; i < bodyNode.Count; i++)
            {
                list.Add(bodyNode[i].Attributes[attribut].Value);
            }
            return list;
        }

        public ArrayList ParserArrayByTag(string requestName, string tag)
        {
            ArrayList list = new ArrayList();
            int i = 1;
            HtmlNode bodyNode;
            while (true)
            {
                bodyNode = doc.DocumentNode.SelectSingleNode(requestName + tag + "[" + i + "]");
                if (bodyNode ==null)
                {
                    break;
                }
                list.Add(bodyNode.InnerText);
                i++;
            }
            return list;
        }
    }
}
