using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DAL;
using Entity;

namespace DukkanSiparisUygulamasi.Controllers
{
    public class DavetiyeKatalogsController : Controller
    {
        private SiparisContext db = new SiparisContext();

        // GET: DavetiyeKatalogs
        public ActionResult Index()
        {
            return View(db.DavetiyeKataloglar.ToList());
        }

        // GET: DavetiyeKatalogs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DavetiyeKatalog davetiyeKatalog = db.DavetiyeKataloglar.Find(id);
            if (davetiyeKatalog == null)
            {
                return HttpNotFound();
            }
            return View(davetiyeKatalog);
        }

        // GET: DavetiyeKatalogs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DavetiyeKatalogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,KatalogAdi")] DavetiyeKatalog davetiyeKatalog)
        {
            if (ModelState.IsValid)
            {
                db.DavetiyeKataloglar.Add(davetiyeKatalog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(davetiyeKatalog);
        }

        // GET: DavetiyeKatalogs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DavetiyeKatalog davetiyeKatalog = db.DavetiyeKataloglar.Find(id);
            if (davetiyeKatalog == null)
            {
                return HttpNotFound();
            }
            return View(davetiyeKatalog);
        }

        // POST: DavetiyeKatalogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,KatalogAdi")] DavetiyeKatalog davetiyeKatalog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(davetiyeKatalog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(davetiyeKatalog);
        }

        // GET: DavetiyeKatalogs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DavetiyeKatalog davetiyeKatalog = db.DavetiyeKataloglar.Find(id);
            if (davetiyeKatalog == null)
            {
                return HttpNotFound();
            }
            return View(davetiyeKatalog);
        }

        // POST: DavetiyeKatalogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DavetiyeKatalog davetiyeKatalog = db.DavetiyeKataloglar.Find(id);
            db.DavetiyeKataloglar.Remove(davetiyeKatalog);
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
