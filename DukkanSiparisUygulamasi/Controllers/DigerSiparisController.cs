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
    public class DigerSiparisController : Controller
    {
        private SiparisContext db = new SiparisContext();
        private DigerSiparisRepository DSRep = new DigerSiparisRepository();

        // GET: DigerSiparis
        public ActionResult Index()
        {
            return View(DSRep.GetAll());
        }

        // GET: DigerSiparis/Detaylar/5
        public ActionResult Detaylar(int id)
        {
            DigerSiparis digerSiparis = DSRep.GetById(id);
            if (digerSiparis == null)
            {
                return HttpNotFound();
            }
            return View(digerSiparis);
        }

        // GET: DigerSiparis/SiparisOlustur
        public ActionResult SiparisOlustur()
        {
            return View();
        }

        // POST: DigerSiparis/SiparisOlustur
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SiparisOlustur([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,UrunAdi,Not")] DigerSiparis digerSiparis)
        {
            if (ModelState.IsValid)
            {
                DSRep.Insert(digerSiparis);
                return RedirectToAction("Index");
            }

            return View(digerSiparis);
        }

        // GET: DigerSiparis/SiparisDuzenle/5
        public ActionResult SiparisDuzenle(int id)
        {
            DigerSiparis digerSiparis = DSRep.GetById(id);
            if (digerSiparis == null)
            {
                return HttpNotFound();
            }
            return View(digerSiparis);
        }

        // POST: DigerSiparis/SiparisDuzenle/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SiparisDuzenle([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,UrunAdi,Not")] DigerSiparis digerSiparis)
        {
            if (ModelState.IsValid)
            {
                DSRep.Update(digerSiparis);
                return RedirectToAction("Index");
            }
            return View(digerSiparis);
        }

        // GET: DigerSiparis/Sil/5
        public ActionResult Sil(int id)
        {
            DigerSiparis digerSiparis = DSRep.GetById(id);
            if (digerSiparis == null)
            {
                return HttpNotFound();
            }
            return View(digerSiparis);
        }

        // POST: DigerSiparis/Delete/5
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
