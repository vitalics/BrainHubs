using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Parse
{
    class BindingNews
    {
       private struct News
        {
           int id;
           string[] liststring;

          public int Id
            {
                get
                {
                    return id;
                }
                set
                {
                    id = value;
                }
            }

           public string[] ListString
            {
                get
                {
                    return liststring;
                }
                set
                {
                    liststring = value;
                }
            }
        }

        Reference[] listBindingNews;
        News[] listNews;

        public void Binding()
        {
           listNews = RequestNews();
            PreparationForBunding();
            for (int i = 0; i < listNews.Length; i++)
            {
                listBindingNews[i].Id = listNews[i].Id;
                for (int j = i; j < listNews.Length; j++)
                {
                    if(ReviseKeyword(i,j))
                    {
                        listBindingNews[i].ReferenceId += listNews[j].Id + " ";

                        listBindingNews[j].ReferenceId += listNews[i].Id + " ";
                    }
                }
            }
        }

        private News[ ] RequestNews()
        {
            News[] news = new News[200];
            //loading news in DB
            return news;
        }

        private void ResponseOnBindingNews()
        {
            //response on DB of listBindingNews
        }

        private void PreparationForBunding()
        {
            listBindingNews = new Reference[200];
            for (int i = 0; i < listNews.Length; i++)
            {              
                for (int j = 0; j < listNews[i].ListString.Length; j++)
                {
                    listNews[i].ListString[j].ToLower();
                    string str = listNews[i].ListString[j];
                    int length;
                    if (str.Length >= 5)
                    {
                        length = 5;
                    }
                    else
                    {
                        length = str.Length;
                    }

                    str = str.Substring(0, length);
                    listNews[i].ListString[j] = str;
                }
            }
        }

        private bool ReviseKeyword(int i,int j)
        {
            string[] listReviewer = listNews[i].ListString;
            string[] listVerifiable = listNews[j].ListString;
            Array.Sort(listReviewer);
            Array.Sort(listVerifiable);
            int count = 0;

            for (int n = 0; n < listReviewer.Length; n++)
            {
                if(listReviewer[n] == listVerifiable[n])
                {
                    count++;
                }
            }
            double coefficient = count / listReviewer.Length;

            if(coefficient>=0.6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private struct Reference
        {
            int id;
            string referenceId;

            public int Id
            {
                get
                {
                    return id;
                }
                set
                {
                    id = value;
                }
            }

            public string ReferenceId
            {
                get
                {
                    return referenceId;
                }
                set
                {
                    referenceId = value;
                }
            }
        }
    }
}
