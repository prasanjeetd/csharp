using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApp.Models.DBModels;

namespace WebApp.Controllers
{
    public class BrandController : Controller
    {
        private EMarketEntities db = new EMarketEntities();

        // GET: Brand
        public ActionResult Index()
        {
            var brandMasts = db.BrandMasts.Include(b => b.CompanyMast);
            return View(brandMasts.ToList());
        }

        // GET: Brand/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BrandMast brandMast = db.BrandMasts.Find(id);
            if (brandMast == null)
            {
                return HttpNotFound();
            }
            return View(brandMast);
        }

        // GET: Brand/Create
        public ActionResult Create()
        {
            ViewBag.CompanyID = new SelectList(db.CompanyMasts, "CompanyID", "CompanyName");
            return View();
        }

        // POST: Brand/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BrandName,CompanyID,IsGlobal")] BrandMast brandMast)
        {
            if (ModelState.IsValid)
            {
                db.BrandMasts.Add(brandMast);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CompanyID = new SelectList(db.CompanyMasts, "CompanyID", "CompanyName", brandMast.CompanyID);
            return View(brandMast);
        }

        // GET: Brand/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BrandMast brandMast = db.BrandMasts.Find(id);
            if (brandMast == null)
            {
                return HttpNotFound();
            }
            ViewBag.CompanyID = new SelectList(db.CompanyMasts, "CompanyID", "CompanyName", brandMast.CompanyID);
            return View(brandMast);
        }

        // POST: Brand/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BrandID,BrandName,CompanyID,IsGlobal")] BrandMast brandMast)
        {
            if (ModelState.IsValid)
            {
                db.Entry(brandMast).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CompanyID = new SelectList(db.CompanyMasts, "CompanyID", "CompanyName", brandMast.CompanyID);
            return View(brandMast);
        }

        // GET: Brand/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BrandMast brandMast = db.BrandMasts.Find(id);
            if (brandMast == null)
            {
                return HttpNotFound();
            }
            return View(brandMast);
        }

        // POST: Brand/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            BrandMast brandMast = db.BrandMasts.Find(id);
            db.BrandMasts.Remove(brandMast);
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
