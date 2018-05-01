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
    public class SunnetSekeriSiparisController : Controller
    {
        private SiparisContext db = new SiparisContext();
        private SunnetSekeriSiparisRepository SSRep = new SunnetSekeriSiparisRepository();

        // GET: SunnetSekeriSiparis
        public ActionResult Index()
        {
            return View(SSRep.GetAll());
        }

        // GET: SunnetSekeriSiparis/Detaylar/5
        public ActionResult Detaylar(int id)
        {

            SunnetSekeriSiparis sunnetSekeriSiparis = SSRep.GetById(id);
            if (sunnetSekeriSiparis == null)
            {
                return HttpNotFound();
            }
            return View(sunnetSekeriSiparis);
        }

        // GET: SunnetSekeriSiparis/SiparisOlustur
        public ActionResult SiparisOlustur()
        {
            return View();
        }

        // POST: SunnetSekeriSiparis/SiparisOlustur
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SiparisOlustur([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,SekerKodu,CocukAdi,EtiketeYazilacakYazi,Not")] SunnetSekeriSiparis sunnetSekeriSiparis)
        {
            if (ModelState.IsValid)
            {
                SSRep.Insert(sunnetSekeriSiparis);
                return RedirectToAction("Index");
            }

            return View(sunnetSekeriSiparis);
        }

        // GET: SunnetSekeriSiparis/SiparisDuzenle/5
        public ActionResult SiparisDuzenle(int id)
        {
            SunnetSekeriSiparis sunnetSekeriSiparis = SSRep.GetById(id);
            if (sunnetSekeriSiparis == null)
            {
                return HttpNotFound();
            }
            return View(sunnetSekeriSiparis);
        }

        // POST: SunnetSekeriSiparis/SiparisDuzenle/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SiparisDuzenle([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,SekerKodu,CocukAdi,EtiketeYazilacakYazi,Not")] SunnetSekeriSiparis sunnetSekeriSiparis)
        {
            if (ModelState.IsValid)
            {
                SSRep.Update(sunnetSekeriSiparis);
                return RedirectToAction("Index");
            }
            return View(sunnetSekeriSiparis);
        }

        // GET: SunnetSekeriSiparis/Delete/5
        public ActionResult Sil(int id)
        {
            
            SunnetSekeriSiparis sunnetSekeriSiparis = SSRep.GetById(id);
            if (sunnetSekeriSiparis == null)
            {
                return HttpNotFound();
            }
            return View(sunnetSekeriSiparis);
        }

        // POST: SunnetSekeriSiparis/Delete/5
        [HttpPost, ActionName("Sil")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SunnetSekeriSiparis sunnetSekeriSiparis = db.SunnetSekeriSiparisler.Find(id);
            db.Siparisler.Remove(sunnetSekeriSiparis);
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
