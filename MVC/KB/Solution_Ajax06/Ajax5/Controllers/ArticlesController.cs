using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ajax5.Models;

namespace Ajax5.Controllers
{
    public class ArticlesController : Controller
    {
        private ArticleContext db = new ArticleContext();

        // GET: Articles
        public ActionResult Index()
        {
            return View(db.Articles.ToList());
        }

        [HttpPost]
        public ActionResult Index(string id)
        {
            try
            {
                Article a = new Article { Headline = id };
                string[] words = a.Headline.Split(' ');
                if ((words.Length < 3) || (words.Length > 15))
                    throw new Exception("Article must have from 3 to 15 words");
                db.Articles.Add(a);
                db.SaveChanges();
                return PartialView("_Headlines", db.Articles.ToList());
            }
            catch (Exception ex)
            {
                return PartialView("Error", new HandleErrorInfo(ex, "ArticlesController", "Index"));
            }
        }

        private int countWords(String s)
        {
            string[] split = s.Split(' ');
            return split.Length;
        }

        private bool passes(string min, string max, Article a)
        {
            try
            {
                int m = int.Parse(min);
                int n = int.Parse(max);
                int count = countWords(a.Headline);
                return ((count >= m) && (count <= n));
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult Filter(string minChars, string maxChars)
        {
            try
            {
                List<Article> filtered = new List<Article>();
                foreach (Article a in db.Articles.ToList())
                {
                    if (passes(minChars, maxChars, a))
                    {
                        filtered.Add(a);
                    }
                }
                return PartialView("_Headlines", filtered);
            }
            catch (Exception ex)
            {
                return PartialView("Error", new HandleErrorInfo(ex, "ArticlesController", "Index"));
            }
        }

        // GET: Articles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        // GET: Articles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Articles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ArticleId,Headline,Content")] Article article)
        {
            if (ModelState.IsValid)
            {
                db.Articles.Add(article);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(article);
        }

        // GET: Articles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ArticleId,Headline,Content")] Article article)
        {
            if (ModelState.IsValid)
            {
                db.Entry(article).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(article);
        }

        // GET: Articles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        // POST: Articles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Article article = db.Articles.Find(id);
            db.Articles.Remove(article);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
