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
using static BLL.Repository;

namespace DukkanSiparisUygulamasi.Controllers
{
    public class DavetiyeSiparisController : Controller
    {
        private SiparisContext db = new SiparisContext();

        private DavetiyeSiparisRepository DSRep = new DavetiyeSiparisRepository();
        private DavetiyeKatalogRepository DKRep = new DavetiyeKatalogRepository();

        // GET: DavetiyeSiparis
        public ActionResult Index()
        {
            return View(DSRep.GetAll());
        }

        // GET: DavetiyeSiparis/Detaylar/5
        public ActionResult Detaylar(int id)
        {
            DavetiyeSiparis davetiyeSiparis = DSRep.GetById(id);
            if (davetiyeSiparis == null)
            {
                return HttpNotFound();
            }
            return View(davetiyeSiparis);
        }

        // GET: DavetiyeSiparis/SiparisOlustur
        public ActionResult SiparisOlustur()
        {
            ViewBag.KatalogId = new SelectList (DKRep.GetAll(),"KatalogId","KatalogAdi") ;
            return View();
        }

        // POST: DavetiyeSiparis/SiparisOlustur
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SiparisOlustur([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,KatalogId,DavetiyeKodu,GelinAdi,DamatAdi,GelininAnneAdi,GelininAnneSoyadi,GelininBabaAdi,GelininBabaSoyadi,DamadinAnneAdi,DamadinAnneSoyadi,DamadinBabaAdi,DamadinBabaSoyadi,DavetiyeYazisi,TorenTarihi,TorenSaati,AdresBilgileri,Not")] DavetiyeSiparis davetiyeSiparis)
        {
            if (ModelState.IsValid)
            {
                ViewBag.KatalogId = new SelectList(DKRep.GetAll(), "KatalogId", "KatalogAdi",davetiyeSiparis.KatalogId);
                DSRep.Insert(davetiyeSiparis);
                return RedirectToAction("Index");
            }

            return View(davetiyeSiparis);
        }

        // GET: DavetiyeSiparis/SiparisDuzenle/5
        public ActionResult SiparisDuzenle(int id)
        {

            DavetiyeSiparis davetiyeSiparis = DSRep.GetById(id);
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
                DSRep.Update(davetiyeSiparis);
                return RedirectToAction("Index");
            }
            return View(davetiyeSiparis);
        }

        // GET: DavetiyeSiparis/Sil/5
        public ActionResult Sil(int id)
        {
            
            DavetiyeSiparis davetiyeSiparis = DSRep.GetById(id);
            if (davetiyeSiparis == null)
            {
                return HttpNotFound();
            }
            return View(davetiyeSiparis);
        }

        // POST: DavetiyeSiparis/Delete/5
        [HttpPost, ActionName("Sil")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DSRep.Delete(id);
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
