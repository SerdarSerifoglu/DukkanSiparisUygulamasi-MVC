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

        // GET: BebekSekeriSiparis/Details/5
        public ActionResult Details(int id)
        {
            
               BSSRep.GetById(id);
            
            if (BSSRep.GetById(id) == null)
            {
                return HttpNotFound();
            }
            return View(BSSRep.GetById(id));
        }

        // GET: BebekSekeriSiparis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BebekSekeriSiparis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,SekerKodu,CocukAdi,EtiketeYazilacakYazi,Not")] BebekSekeriSiparis bebekSekeriSiparis)
        {
            if (ModelState.IsValid)
            {
                db.Siparisler.Add(bebekSekeriSiparis);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bebekSekeriSiparis);
        }

        // GET: BebekSekeriSiparis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BebekSekeriSiparis bebekSekeriSiparis = db.BebekSekeriSiparisler.Find(id);
            if (bebekSekeriSiparis == null)
            {
                return HttpNotFound();
            }
            return View(bebekSekeriSiparis);
        }

        // POST: BebekSekeriSiparis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SiparisId,SiparisTuru,SiparisVerenAdi,SiparisVerenTel,SiparisVerenEmail,SiparisAdet,SiparisTarihi,TeslimTarihi,TeslimEdildiMi,SiparisToplamTutari,SiparisAlan,SekerKodu,CocukAdi,EtiketeYazilacakYazi,Not")] BebekSekeriSiparis bebekSekeriSiparis)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bebekSekeriSiparis).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bebekSekeriSiparis);
        }

        // GET: BebekSekeriSiparis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BebekSekeriSiparis bebekSekeriSiparis = db.BebekSekeriSiparisler.Find(id);
            if (bebekSekeriSiparis == null)
            {
                return HttpNotFound();
            }
            return View(bebekSekeriSiparis);
        }

        // POST: BebekSekeriSiparis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BebekSekeriSiparis bebekSekeriSiparis = db.BebekSekeriSiparisler.Find(id);
            db.Siparisler.Remove(bebekSekeriSiparis);
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
