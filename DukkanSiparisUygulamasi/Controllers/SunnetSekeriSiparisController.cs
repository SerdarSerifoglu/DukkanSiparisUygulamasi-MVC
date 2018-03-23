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
    public class SunnetSekeriSiparisController : Controller
    {
        private SiparisContext db = new SiparisContext();

        // GET: SunnetSekeriSiparis
        public ActionResult Index()
        {
            return View(db.SunnetSekeriSiparisler.ToList());
        }

        // GET: SunnetSekeriSiparis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SunnetSekeriSiparis sunnetSekeriSiparis = db.SunnetSekeriSiparisler.Find(id);
            if (sunnetSekeriSiparis == null)
            {
                return HttpNotFound();
            }
            return View(sunnetSekeriSiparis);
        }

        // GET: SunnetSekeriSiparis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SunnetSekeriSiparis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,SekerKodu,CocukAdi,EtiketeYazilacakYazi,Not")] SunnetSekeriSiparis sunnetSekeriSiparis)
        {
            if (ModelState.IsValid)
            {
                db.Siparisler.Add(sunnetSekeriSiparis);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sunnetSekeriSiparis);
        }

        // GET: SunnetSekeriSiparis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SunnetSekeriSiparis sunnetSekeriSiparis = db.SunnetSekeriSiparisler.Find(id);
            if (sunnetSekeriSiparis == null)
            {
                return HttpNotFound();
            }
            return View(sunnetSekeriSiparis);
        }

        // POST: SunnetSekeriSiparis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,SekerKodu,CocukAdi,EtiketeYazilacakYazi,Not")] SunnetSekeriSiparis sunnetSekeriSiparis)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sunnetSekeriSiparis).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sunnetSekeriSiparis);
        }

        // GET: SunnetSekeriSiparis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SunnetSekeriSiparis sunnetSekeriSiparis = db.SunnetSekeriSiparisler.Find(id);
            if (sunnetSekeriSiparis == null)
            {
                return HttpNotFound();
            }
            return View(sunnetSekeriSiparis);
        }

        // POST: SunnetSekeriSiparis/Delete/5
        [HttpPost, ActionName("Delete")]
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
