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

        // GET: DavetiyeSiparis/Detaylar/5
        public ActionResult Detaylar(int? id)
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

        // GET: DavetiyeSiparis/SiparisOlustur
        public ActionResult SiparisOlustur()
        {
            return View();
        }

        // POST: DavetiyeSiparis/SiparisOlustur
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SiparisOlustur([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,DavetiyeKodu,GelinAdi,DamatAdi,GelininAnneAdi,GelininAnneSoyadi,GelininBabaAdi,GelininBabaSoyadi,DamadinAnneAdi,DamadinAnneSoyadi,DamadinBabaAdi,DamadinBabaSoyadi,DavetiyeYazisi,TorenTarihi,TorenSaati,AdresBilgileri,Not")] DavetiyeSiparis davetiyeSiparis)
        {
            if (ModelState.IsValid)
            {
                db.Siparisler.Add(davetiyeSiparis);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(davetiyeSiparis);
        }

        // GET: DavetiyeSiparis/SiparisDuzenle/5
        public ActionResult SiparisDuzenle(int? id)
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

        // POST: DavetiyeSiparis/SiparisDuzenle/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SiparisDuzenle([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,DavetiyeKodu,GelinAdi,DamatAdi,GelininAnneAdi,GelininAnneSoyadi,GelininBabaAdi,GelininBabaSoyadi,DamadinAnneAdi,DamadinAnneSoyadi,DamadinBabaAdi,DamadinBabaSoyadi,DavetiyeYazisi,TorenTarihi,TorenSaati,AdresBilgileri,Not")] DavetiyeSiparis davetiyeSiparis)
        {
            if (ModelState.IsValid)
            {
                db.Entry(davetiyeSiparis).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(davetiyeSiparis);
        }

        // GET: DavetiyeSiparis/Sil/5
        public ActionResult Sil(int? id)
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

        // POST: DavetiyeSiparis/Sil/5
        [HttpPost, ActionName("Sil")]
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
