using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxNews.Models
{
    public static class NewsRepository
    {
        public static List<NewsReport> AllNews { get; set; }

        static NewsRepository()
        {
            AllNews = new List<NewsReport>
            {
                new NewsReport {News="WCF course is here in a moment"},
                new NewsReport {News="Hanuka Sameach"},
            };
        }
    }
}