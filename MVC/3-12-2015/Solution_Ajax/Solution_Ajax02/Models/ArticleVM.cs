using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solution_Ajax02.Models
{
    public class ArticleVM
    {

        public List<Article> AllArticles
        {
            get
            {
                ArticleContext db = new ArticleContext();
                List<Article> _Articles = new List<Article>();
                foreach (Article a in db.Articles)
                {
                    _Articles.Add(a);
                }
                return _Articles;
            }
        }
    }
}