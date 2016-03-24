using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Parse
{
    class SearchKeywords
    {
        string text;
        int countWords = 0;
        Dictionary<string, double> keywords = new Dictionary<string, double>();
        List<string> listWords = new List<string>();


        public SearchKeywords(string text)
        {
            this.text = text;
        }


        void CreateKeyword()
        {
            int i = 1;
            while (text.IndexOf(" ",i) != 0)
            {
                string word = text.Substring(i, text.IndexOf(" ", i));
                listWords.Add(word);
                i = text.IndexOf(" ", i)+1;
                countWords++;
            }
        }


        void CheckKeyword()
        {
            RepeadTest();
            DeleteNoKeyWords();
        }

        void RepeadTest()
        {
            for (int i = 0; i < keywords.Count; i++)
            {
                string word = listWords[i];
                int count = 0;
                for (int j = 0; j < keywords.Count; j++)
                {
                    if (word == listWords[j])
                    {
                        count++;
                        listWords.RemoveAt(j);
                        j--;
                    }
                }
                keywords.Add(word, count / countWords);
            }
        }
        void DeleteNoKeyWords()
        {
            string[] captcha = Captcha.GetCaptch;
            for (int i = 0; i < captcha.Length; i++)
            {
                keywords.Remove(captcha[i]);
            } 
        }

        public Dictionary<string,double> GetKeywords
        {
            get
            {
                CheckKeyword();
                return keywords;
            }
        }
    }
}
