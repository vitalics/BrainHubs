using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Parse
{
    class SearchFavouritesCategory
    {
        BD.BD db = new BD.BD();
        int[]favouritestNews;
        Dictionary<string, int> countCategories = new Dictionary<string, int>();
        string favouritCategory = "IT";
        private string[] categories = { "politics", "economics", "society", "world", "sport", "IT" };
        public SearchFavouritesCategory(string email)
        {
            favouritestNews = db.GetFavouritesNews(email);
            if (favouritestNews.Length<10)
            {
                AddFavouritCategory(email,"IT");
            }
            CountFavouriteCategories();
        }

        private void CountFavouriteCategories()
        {
            int maxCount = int.MinValue;
            
            for (int i = 0; i < categories.Length; i++)
            {
                countCategories.Add(categories[i],0);
            }

            for (int i = 0; i < favouritestNews.Length; i++)
            {
                string category = db.GetCategory(favouritestNews[i]);
                int count = countCategories[category].GetHashCode();
                count++;
                countCategories.Remove(category);
                countCategories.Add(category,count);
                if (count>=maxCount)
                {
                    maxCount = count;
                }
            }
            if (maxCount>0)
            {
                string favouritCategory = countCategories[maxCount].GetHashCode();
                AddFavouritCategory(email,favouritCategory);
            }
        }

        private void AddFavouritCategory(string email, string category)
        {
            db.RecordFavouritCategory(email, category);
        }

    }
}
