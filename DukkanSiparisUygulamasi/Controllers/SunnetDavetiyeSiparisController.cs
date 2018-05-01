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
    public class SunnetDavetiyeSiparisController : Controller
    {
        private SiparisContext db = new SiparisContext();
        private SunnetDavetiyeSiparisRepository SDSRep = new SunnetDavetiyeSiparisRepository();
        private DavetiyeKatalogRepository DKRep = new DavetiyeKatalogRepository();

        // GET: SunnetDavetiyeSiparis
        public ActionResult Index()
        {
            return View(SDSRep.GetAll());
        } 

        // GET: SunnetDavetiyeSiparis/Details/5
        public ActionResult Detaylar(int id)
        {
           
            SunnetDavetiyeSiparis sunnetDavetiyeSiparis = SDSRep.GetById(id);
            if (sunnetDavetiyeSiparis == null)
            {
                return HttpNotFound();
            }
            return View(sunnetDavetiyeSiparis);
        }

        // GET: SunnetDavetiyeSiparis/Create
        public ActionResult SiparisOlustur()
        {
            ViewBag.KatalogId = new SelectList(DKRep.GetAll(), "KatalogId", "KatalogAdi");
            return View();
        }

        // POST: SunnetDavetiyeSiparis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SiparisOlustur(SunnetDavetiyeSiparis sunnetDavetiyeSiparis)
        {
            if (ModelState.IsValid)
            {
                ViewBag.KatalogId = new SelectList(DKRep.GetAll(), "KatalogId", "KatalogAdi", sunnetDavetiyeSiparis.KatalogId);
                SDSRep.Insert(sunnetDavetiyeSiparis);
                return RedirectToAction("Index");
            }

            return View(sunnetDavetiyeSiparis);
        }

        // GET: SunnetDavetiyeSiparis/Edit/5
        public ActionResult SiparisDuzenle(int id)
        {
            SunnetDavetiyeSiparis sunnetDavetiyeSiparis = SDSRep.GetById(id);
            if (sunnetDavetiyeSiparis == null)
            {
                return HttpNotFound();
            }
            return View(sunnetDavetiyeSiparis);
        }

        // POST: SunnetDavetiyeSiparis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SiparisDuzenle(SunnetDavetiyeSiparis sunnetDavetiyeSiparis)
        {
            if (ModelState.IsValid)
            {
                SDSRep.Update(sunnetDavetiyeSiparis);
                return RedirectToAction("Index");
            }
            return View(sunnetDavetiyeSiparis);
        }

        // GET: SunnetDavetiyeSiparis/Sil/5
        public ActionResult Sil(int id)
        {
            SunnetDavetiyeSiparis sunnetDavetiyeSiparis = SDSRep.GetById(id);
            if (sunnetDavetiyeSiparis == null)
            {
                return HttpNotFound();
            }
            return View(sunnetDavetiyeSiparis);
        }

        // POST: SunnetDavetiyeSiparis/Delete/5
        [HttpPost, ActionName("Sil")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SDSRep.Delete(id);
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
