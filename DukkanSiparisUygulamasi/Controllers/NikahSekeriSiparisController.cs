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
    public class NikahSekeriSiparisController : Controller
    {
        private SiparisContext db = new SiparisContext();

        // GET: NikahSekeriSiparis
        public ActionResult Index()
        {
            return View(db.NikahSekeriSiparisler.ToList());
        }

        // GET: NikahSekeriSiparis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NikahSekeriSiparis nikahSekeriSiparis = db.NikahSekeriSiparisler.Find(id);
            if (nikahSekeriSiparis == null)
            {
                return HttpNotFound();
            }
            return View(nikahSekeriSiparis);
        }

        // GET: NikahSekeriSiparis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NikahSekeriSiparis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,SekerKodu,GelinAdi,DamatAdi,SekerYazisi,Not")] NikahSekeriSiparis nikahSekeriSiparis)
        {
            if (ModelState.IsValid)
            {
                db.Siparisler.Add(nikahSekeriSiparis);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nikahSekeriSiparis);
        }

        // GET: NikahSekeriSiparis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NikahSekeriSiparis nikahSekeriSiparis = db.NikahSekeriSiparisler.Find(id);
            if (nikahSekeriSiparis == null)
            {
                return HttpNotFound();
            }
            return View(nikahSekeriSiparis);
        }

        // POST: NikahSekeriSiparis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,SekerKodu,GelinAdi,DamatAdi,SekerYazisi,Not")] NikahSekeriSiparis nikahSekeriSiparis)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nikahSekeriSiparis).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nikahSekeriSiparis);
        }

        // GET: NikahSekeriSiparis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NikahSekeriSiparis nikahSekeriSiparis = db.NikahSekeriSiparisler.Find(id);
            if (nikahSekeriSiparis == null)
            {
                return HttpNotFound();
            }
            return View(nikahSekeriSiparis);
        }

        // POST: NikahSekeriSiparis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NikahSekeriSiparis nikahSekeriSiparis = db.NikahSekeriSiparisler.Find(id);
            db.Siparisler.Remove(nikahSekeriSiparis);
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
