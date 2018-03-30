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
    public class BebekSekeriSiparisController : Controller
    {
        private SiparisContext db = new SiparisContext();
        private BebekSekeriSiparisRepository BSSRep = new BebekSekeriSiparisRepository();
        // GET: BebekSekeriSiparis
        public ActionResult Index()
        {
             return View(BSSRep.GetAll());
        }

        // GET: BebekSekeriSiparis/Detaylar/5
        public ActionResult Detaylar(int id)
        {
            
               BSSRep.GetById(id);
            
            if (BSSRep.GetById(id) == null)
            {
                return HttpNotFound();
            }
            return View(BSSRep.GetById(id));
        }

        // GET: BebekSekeriSiparis/SiparisOlustur
        public ActionResult SiparisOlustur()
        {
            return View();
        }

        // POST: BebekSekeriSiparis/SiparisOlustur
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SiparisOlustur([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,SekerKodu,CocukAdi,EtiketeYazilacakYazi,Not")] BebekSekeriSiparis bebekSekeriSiparis)
        {
            if (ModelState.IsValid)
            {
                BSSRep.Insert(bebekSekeriSiparis);
                //db.Siparisler.Add(bebekSekeriSiparis);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bebekSekeriSiparis);
        }

        // GET: BebekSekeriSiparis/SiparisDuzenle/5
        public ActionResult SiparisDuzenle(int id)
        {
            BebekSekeriSiparis bebekSekeriSiparis = BSSRep.GetById(id);
            if (bebekSekeriSiparis == null)
            {
                return HttpNotFound();
            }
            return View(bebekSekeriSiparis);
        }

        // POST: BebekSekeriSiparis/SiparisDuzenle/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SiparisDuzenle([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,SekerKodu,CocukAdi,EtiketeYazilacakYazi,Not")] BebekSekeriSiparis bebekSekeriSiparis)
        {
            if (ModelState.IsValid)
            {
                BebekSekeriSiparis degisenSiparis = BSSRep.GetById(bebekSekeriSiparis.SiparisId);
                degisenSiparis.SiparisTuru = bebekSekeriSiparis.SiparisTuru;
                degisenSiparis.SiparisVerenAdi = bebekSekeriSiparis.SiparisVerenAdi;
                degisenSiparis.SiparisVerenTel = bebekSekeriSiparis.SiparisVerenTel;
                degisenSiparis.SiparisVerenEmail = bebekSekeriSiparis.SiparisVerenEmail;
                degisenSiparis.SiparisAdet = bebekSekeriSiparis.SiparisAdet;
                degisenSiparis.SiparisTarihi = bebekSekeriSiparis.SiparisTarihi;
                degisenSiparis.TeslimTarihi = bebekSekeriSiparis.TeslimTarihi;
                degisenSiparis.TeslimEdildiMi = bebekSekeriSiparis.TeslimEdildiMi;
                degisenSiparis.SiparisToplamTutari = bebekSekeriSiparis.SiparisToplamTutari;
                degisenSiparis.SiparisAlan = bebekSekeriSiparis.SiparisAlan;
                degisenSiparis.SekerKodu = bebekSekeriSiparis.SekerKodu;
                degisenSiparis.CocukAdi = bebekSekeriSiparis.CocukAdi;
                degisenSiparis.EtiketeYazilacakYazi = bebekSekeriSiparis.EtiketeYazilacakYazi;
                degisenSiparis.Not = bebekSekeriSiparis.Not;
                BSSRep.Update(degisenSiparis);
                //db.Entry(bebekSekeriSiparis).State = EntityState.Modified;
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bebekSekeriSiparis);
        }

        // GET: BebekSekeriSiparis/Sil/5
        public ActionResult Sil(int id)
        {
            BebekSekeriSiparis bebekSekeriSiparis = BSSRep.GetById(id);
            if (bebekSekeriSiparis == null)
            {
                return HttpNotFound();
            }
            return View(bebekSekeriSiparis);
        }

        // POST: BebekSekeriSiparis/Sil/5
        [HttpPost, ActionName("Sil")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BSSRep.Delete(id);
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
