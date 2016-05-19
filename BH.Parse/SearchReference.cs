using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParserAndOther;

namespace BH.Parse
{
    class SearchReference
    {
        BD.BD db = new BD.BD();
        private DataNews[] news = new DataNews[50];
        private string[] categories = { "politics", "economics", "society", "world", "sport","IT" };

        public SearchReference()
        {
            for (int i = 0; i < categories.Length; i++)
            {
                news[i] = db.GetLastForCategory(categories[i]);

            }
        }

        private void CheckKeyword()
        {
            for (int i = 0; i < news.Length; i++)
            {
                for (int j = 1; j < news.Length; j++)
                {
                    double coefficient = 0;
                    for (int k = 0; k < news[i].Keyword.Length; k++)
                    {
                        if (news[i].Keyword[k] == news[j].Keyword[k])
                        {
                            coefficient++;
                        }
                    }

                    if (coefficient>=0.6)
                    {
                        AddInDB(news[i].Id,news[j].Id);
                        AddInDB(news[j].Id, news[i].Id);
                    }
                }
            }
        }

        private void AddInDB(int id, int idReference)
        {
            db.RecordReferens(id,idReference);
        }
    }
}
