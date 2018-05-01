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
    public class NikahSekeriSiparisController : Controller
    {
        private SiparisContext db = new SiparisContext();
        private NikahSekeriSiparisRepository NSRep = new NikahSekeriSiparisRepository();
        // GET: NikahSekeriSiparis
        public ActionResult Index()
        {
            return View(NSRep.GetAll());
        }

        // GET: NikahSekeriSiparis/Detaylar/5
        public ActionResult Detaylar(int id)
        {
            NikahSekeriSiparis nikahSekeriSiparis = NSRep.GetById(id);
            if (nikahSekeriSiparis == null)
            {
                return HttpNotFound();
            }
            return View(nikahSekeriSiparis);
        }

        // GET: NikahSekeriSiparis/SiparisOlustur
        public ActionResult SiparisOlustur()
        {
            return View();
        }

        // POST: NikahSekeriSiparis/SiparisOlustur
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SiparisOlustur([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,SekerKodu,GelinAdi,DamatAdi,SekerYazisi,Not")] NikahSekeriSiparis nikahSekeriSiparis)
        {
            if (ModelState.IsValid)
            {
                NSRep.Insert(nikahSekeriSiparis);
                return RedirectToAction("Index");
            }

            return View(nikahSekeriSiparis);
        }

        // GET: NikahSekeriSiparis/SiparisDuzenle/5
        public ActionResult SiparisDuzenle(int id)
        {
            NikahSekeriSiparis nikahSekeriSiparis = NSRep.GetById(id);
            if (nikahSekeriSiparis == null)
            {
                return HttpNotFound();
            }
            return View(nikahSekeriSiparis);
        }

        // POST: NikahSekeriSiparis/SiparisDuzenle/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SiparisDuzenle([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,SekerKodu,GelinAdi,DamatAdi,SekerYazisi,Not")] NikahSekeriSiparis nikahSekeriSiparis)
        {
            if (ModelState.IsValid)
            {
                NSRep.Update(nikahSekeriSiparis);
                return RedirectToAction("Index");
            }
            return View(nikahSekeriSiparis);
        }

        // GET: NikahSekeriSiparis/Sil/5
        public ActionResult Sil(int id)
        {
            NikahSekeriSiparis nikahSekeriSiparis = NSRep.GetById(id);
            if (nikahSekeriSiparis == null)
            {
                return HttpNotFound();
            }
            return View(nikahSekeriSiparis);
        }

        // POST: NikahSekeriSiparis/Sil/5
        [HttpPost, ActionName("Sil")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NSRep.Delete(id);
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
