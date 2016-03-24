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

namespace BH.Parse
{
    public class Parser
    {
        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
        string uRL;
        public Parser(string uRL)
        {
            this.uRL = uRL;
        }

        string GetRequest(string url)
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

        public string ParserHeadLine(string nameClass)
        {
            string headLine;
            doc.LoadHtml(GetRequest(uRL));
            string reference = "//*[@class='" + nameClass + "']";
            var bodyNode = doc.DocumentNode.SelectSingleNode(reference);

            for (int i = 1; i < 7; i++)
            {
                if (doc.DocumentNode.SelectSingleNode(reference + "/h" + i) != null)
                {
                    bodyNode = doc.DocumentNode.SelectSingleNode(reference + "/h" + i);
                    break;
                }
            }


            if (doc.DocumentNode.SelectSingleNode(reference + "/a") != null)
            {
                bodyNode = doc.DocumentNode.SelectSingleNode(reference + "/a");
            }
            if (doc.DocumentNode.SelectSingleNode(reference + "/b") != null)
            {
                bodyNode = doc.DocumentNode.SelectSingleNode(reference + "/b");
            }

            headLine = bodyNode.InnerText;
            return headLine;
        }

        public string ParserImage(string nameClass)
        {
            string refernceImg;
            doc.LoadHtml(GetRequest(uRL));
            string reference = "//*[@class='" + nameClass + "']/img";
            var bodyNode = doc.DocumentNode.SelectSingleNode(reference);
            refernceImg = bodyNode.Attributes["src"].Value;
            return refernceImg;
        }

        public string ParserKeywords(string nameClass)
        {
            string refernceKeywords;
            doc.LoadHtml(GetRequest(uRL));
            string reference = "//*[@name='" + nameClass + "']/content";
            var bodyNode = doc.DocumentNode.SelectSingleNode(reference);
            refernceKeywords = bodyNode.Attributes["content"].Value;
            return refernceKeywords;
        }

        //public string ParserText(string nameClass)
        //{
        //    string refernceText;
        //    doc.LoadHtml(GetRequest(uRL));
        //    string reference = "//*[@class='" + nameClass + "']";
        //    var bodyNode = doc.DocumentNode.SelectSingleNode(reference);
        //    int i = 0;
        //    ArrayList list = new ArrayList(); 
        //    while (doc.DocumentNode.SelectSingleNode(reference + "/p[" + i +"]"))
        //    {

        //        if (true)
        //        {

        //        }
        //        i++;
        //    }

        //    return refernceText;
        //}


    }
}
