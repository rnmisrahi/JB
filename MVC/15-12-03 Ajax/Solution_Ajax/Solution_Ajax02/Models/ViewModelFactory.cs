using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Solution_Ajax02.Models;

namespace Solution_Ajax02.Models
{
    public class ViewModelFactory
    {
        private List<Article> _Articles;

        public List<Article> GetAllArtcles()
        {
            _Articles = new List<Article>();
            ArticleContext db = new ArticleContext();
            foreach(Article a in db.Articles)
            {
                _Articles.Add(a);
            }
            return _Articles;
        }
    }
}