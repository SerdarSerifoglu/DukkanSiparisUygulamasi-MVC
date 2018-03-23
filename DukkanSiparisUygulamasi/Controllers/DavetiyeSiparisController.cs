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
    public class DavetiyeSiparisController : Controller
    {
        private SiparisContext db = new SiparisContext();

        // GET: DavetiyeSiparis
        public ActionResult Index()
        {
            return View(db.DavetiyeSiparisler.ToList());
        }

        // GET: DavetiyeSiparis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DavetiyeSiparis davetiyeSiparis = db.DavetiyeSiparisler.Find(id);
            if (davetiyeSiparis == null)
            {
                return HttpNotFound();
            }
            return View(davetiyeSiparis);
        }

        // GET: DavetiyeSiparis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DavetiyeSiparis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,DavetiyeKodu,GelinAdi,DamatAdi,GelininAnneAdi,GelininAnneSoyadi,GelininBabaAdi,GelininBabaSoyadi,DamadinAnneAdi,DamadinAnneSoyadi,DamadinBabaAdi,DamadinBabaSoyadi,DavetiyeYazisi,TorenTarihi,TorenSaati,AdresBilgileri,Not")] DavetiyeSiparis davetiyeSiparis)
        {
            if (ModelState.IsValid)
            {
                db.Siparisler.Add(davetiyeSiparis);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(davetiyeSiparis);
        }

        // GET: DavetiyeSiparis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DavetiyeSiparis davetiyeSiparis = db.DavetiyeSiparisler.Find(id);
            if (davetiyeSiparis == null)
            {
                return HttpNotFound();
            }
            return View(davetiyeSiparis);
        }

        // POST: DavetiyeSiparis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,DavetiyeKodu,GelinAdi,DamatAdi,GelininAnneAdi,GelininAnneSoyadi,GelininBabaAdi,GelininBabaSoyadi,DamadinAnneAdi,DamadinAnneSoyadi,DamadinBabaAdi,DamadinBabaSoyadi,DavetiyeYazisi,TorenTarihi,TorenSaati,AdresBilgileri,Not")] DavetiyeSiparis davetiyeSiparis)
        {
            if (ModelState.IsValid)
            {
                db.Entry(davetiyeSiparis).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(davetiyeSiparis);
        }

        // GET: DavetiyeSiparis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DavetiyeSiparis davetiyeSiparis = db.DavetiyeSiparisler.Find(id);
            if (davetiyeSiparis == null)
            {
                return HttpNotFound();
            }
            return View(davetiyeSiparis);
        }

        // POST: DavetiyeSiparis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DavetiyeSiparis davetiyeSiparis = db.DavetiyeSiparisler.Find(id);
            db.Siparisler.Remove(davetiyeSiparis);
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
