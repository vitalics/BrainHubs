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
    public class Parser : IParser
    {
        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
        string url;

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

        public string ParserLine(string requestName)
        {
            string headLine;
            var bodyNode = doc.DocumentNode.SelectSingleNode(requestName);
            headLine = bodyNode.InnerText;
            return headLine;
        }

        public string ParserAttributes(string requestName, string attribut)
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

        //string GetRequest(string url)
        //{
        //    try
        //    {
        //        var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
        //        httpWebRequest.AllowAutoRedirect = false;
        //        httpWebRequest.Method = "GET";
        //        httpWebRequest.Referer = "http://google.com";
        //        using (var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
        //        {
        //            using (var stream = httpWebResponse.GetResponseStream())
        //            {
        //                using (var reader = new StreamReader(stream, Encoding.GetEncoding(httpWebResponse.CharacterSet)))
        //                {
        //                    return reader.ReadToEnd();
        //                }
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        return String.Empty;
        //    }
        //}

        //public string ParserHeadLine(string nameClass)
        //{
        //    string headLine;
        //    doc.LoadHtml(GetRequest(uRL));
        //    string reference = "//*[@class='" + nameClass + "']";
        //    var bodyNode = doc.DocumentNode.SelectSingleNode(reference);

        //    for (int i = 1; i < 7; i++)
        //    {
        //        if (doc.DocumentNode.SelectSingleNode(reference + "/h" + i) != null)
        //        {
        //            bodyNode = doc.DocumentNode.SelectSingleNode(reference + "/h" + i);
        //            break;
        //        }
        //    }


        //    if (doc.DocumentNode.SelectSingleNode(reference + "/a") != null)
        //    {
        //        bodyNode = doc.DocumentNode.SelectSingleNode(reference + "/a");
        //    }
        //    if (doc.DocumentNode.SelectSingleNode(reference + "/b") != null)
        //    {
        //        bodyNode = doc.DocumentNode.SelectSingleNode(reference + "/b");
        //    }

        //    headLine = bodyNode.InnerText;
        //    return headLine;
        //}

        //public string ParserImage(string nameClass)
        //{
        //    string refernceImg;
        //    doc.LoadHtml(GetRequest(uRL));
        //    string reference = "//*[@class='" + nameClass + "']/img";
        //    var bodyNode = doc.DocumentNode.SelectSingleNode(reference);
        //    refernceImg = bodyNode.Attributes["src"].Value;
        //    return refernceImg;
        //}

        //public string ParserKeywords(string nameClass)
        //{
        //    string refernceKeywords;
        //    doc.LoadHtml(GetRequest(uRL));
        //    string reference = "//*[@name='" + nameClass + "']/content";
        //    var bodyNode = doc.DocumentNode.SelectSingleNode(reference);
        //    refernceKeywords = bodyNode.Attributes["content"].Value;
        //    return refernceKeywords;
        //}

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
