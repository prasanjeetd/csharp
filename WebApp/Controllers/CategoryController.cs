using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models.DBModels;

namespace WebApp.Controllers
{
    public class CategoryController : Controller
    {
        private EMarketEntities db = new EMarketEntities();

        // GET: Category
        public ActionResult Index()
        {
            return View(db.CategoryMasts.ToList());
        }

        public string Welcome(string name, int numOfTimes = 1)
        {
            return HttpUtility.HtmlEncode("Welcome " + name + " to the web app " + numOfTimes);
        }

        public ActionResult Greet(string name, int numOfTimes = 1)
        {
            ViewBag.Name = name;
            ViewBag.NumOfTimes = numOfTimes;
            ViewBag.Title = "Greet Category";

            return View();
        }

        public ActionResult Add()
        {

            return View(new CategoryMast());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoryId,CategoryName")] CategoryMast category)
        {


            if (ModelState.IsValid)
            {

                //db.Entry(category).State = EntityState.Modified;

                CategoryMast categoryEntity = db.CategoryMasts.Find(category.CategoryID);
                categoryEntity.CategoryName = category.CategoryName;
                db.SaveChanges();

                return RedirectToAction("Index");

            }

            return View(category);
        }

        public ActionResult Edit(int id)
        {

            CategoryMast category = db.CategoryMasts.Find(id);

            return View(category);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                //return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
                return RedirectToAction("Index");
            }

            CategoryMast category = db.CategoryMasts.Find(id);

            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult  DeleteCategory(int id)
        {

            CategoryMast category = db.CategoryMasts.Find(id);
            db.CategoryMasts.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add([Bind(Include = "CategoryName")] CategoryMast category)
        {
            if (ModelState.IsValid)
            {
                db.CategoryMasts.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(category);
        }
    }
}