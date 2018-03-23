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
    public class DigerSiparisController : Controller
    {
        private SiparisContext db = new SiparisContext();

        // GET: DigerSiparis
        public ActionResult Index()
        {
            return View(db.DigerSiparisler.ToList());
        }

        // GET: DigerSiparis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DigerSiparis digerSiparis = db.DigerSiparisler.Find(id);
            if (digerSiparis == null)
            {
                return HttpNotFound();
            }
            return View(digerSiparis);
        }

        // GET: DigerSiparis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DigerSiparis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,UrunAdi,Not")] DigerSiparis digerSiparis)
        {
            if (ModelState.IsValid)
            {
                db.Siparisler.Add(digerSiparis);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(digerSiparis);
        }

        // GET: DigerSiparis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DigerSiparis digerSiparis = db.DigerSiparisler.Find(id);
            if (digerSiparis == null)
            {
                return HttpNotFound();
            }
            return View(digerSiparis);
        }

        // POST: DigerSiparis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,UrunAdi,Not")] DigerSiparis digerSiparis)
        {
            if (ModelState.IsValid)
            {
                db.Entry(digerSiparis).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(digerSiparis);
        }

        // GET: DigerSiparis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DigerSiparis digerSiparis = db.DigerSiparisler.Find(id);
            if (digerSiparis == null)
            {
                return HttpNotFound();
            }
            return View(digerSiparis);
        }

        // POST: DigerSiparis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DigerSiparis digerSiparis = db.DigerSiparisler.Find(id);
            db.Siparisler.Remove(digerSiparis);
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
