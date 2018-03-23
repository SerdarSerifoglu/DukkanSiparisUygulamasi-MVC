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
    public class SunnetDavetiyeSiparisController : Controller
    {
        private SiparisContext db = new SiparisContext();

        // GET: SunnetDavetiyeSiparis
        public ActionResult Index()
        {
            return View(db.SunnetDavetiyeSiparisler.ToList());
        }

        // GET: SunnetDavetiyeSiparis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SunnetDavetiyeSiparis sunnetDavetiyeSiparis = db.SunnetDavetiyeSiparisler.Find(id);
            if (sunnetDavetiyeSiparis == null)
            {
                return HttpNotFound();
            }
            return View(sunnetDavetiyeSiparis);
        }

        // GET: SunnetDavetiyeSiparis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SunnetDavetiyeSiparis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,DavetiyeKodu,CocugunAdi,CocugunAnneAdi,CocugunAnneSoyadi,CocugunBabaAdi,CocugunBabaSoyadi,DavetiyeYazisi,TorenTarihi,TorenSaati,AdresBilgileri,Not")] SunnetDavetiyeSiparis sunnetDavetiyeSiparis)
        {
            if (ModelState.IsValid)
            {
                db.Siparisler.Add(sunnetDavetiyeSiparis);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sunnetDavetiyeSiparis);
        }

        // GET: SunnetDavetiyeSiparis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SunnetDavetiyeSiparis sunnetDavetiyeSiparis = db.SunnetDavetiyeSiparisler.Find(id);
            if (sunnetDavetiyeSiparis == null)
            {
                return HttpNotFound();
            }
            return View(sunnetDavetiyeSiparis);
        }

        // POST: SunnetDavetiyeSiparis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,DavetiyeKodu,CocugunAdi,CocugunAnneAdi,CocugunAnneSoyadi,CocugunBabaAdi,CocugunBabaSoyadi,DavetiyeYazisi,TorenTarihi,TorenSaati,AdresBilgileri,Not")] SunnetDavetiyeSiparis sunnetDavetiyeSiparis)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sunnetDavetiyeSiparis).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sunnetDavetiyeSiparis);
        }

        // GET: SunnetDavetiyeSiparis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SunnetDavetiyeSiparis sunnetDavetiyeSiparis = db.SunnetDavetiyeSiparisler.Find(id);
            if (sunnetDavetiyeSiparis == null)
            {
                return HttpNotFound();
            }
            return View(sunnetDavetiyeSiparis);
        }

        // POST: SunnetDavetiyeSiparis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SunnetDavetiyeSiparis sunnetDavetiyeSiparis = db.SunnetDavetiyeSiparisler.Find(id);
            db.Siparisler.Remove(sunnetDavetiyeSiparis);
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
