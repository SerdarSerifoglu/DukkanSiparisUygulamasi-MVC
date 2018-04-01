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
    public class DavetiyeKatalogsController : Controller
    {
        private SiparisContext db = new SiparisContext();
        private DavetiyeKatalogRepository DKRep = new DavetiyeKatalogRepository();
        // GET: DavetiyeKatalogs
        public ActionResult Index()
        {
            return View(DKRep.GetAll());
        }

        // GET: DavetiyeKatalogs/Detaylar/5
        public ActionResult Detaylar(int id)
        {
            DavetiyeKatalog davetiyeKatalog = DKRep.GetById(id);
            if (davetiyeKatalog == null)
            {
                return HttpNotFound();
            }
            return View(davetiyeKatalog);
        }

        // GET: DavetiyeKatalogs/KatalogOlustur
        public ActionResult KatalogOlustur()
        {
            return View();
        }

        // POST: DavetiyeKatalogs/KatalogOlustur
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult KatalogOlustur([Bind(Include = "Id,KatalogAdi")] DavetiyeKatalog davetiyeKatalog)
        {
            if (ModelState.IsValid)
            {
                DKRep.Insert(davetiyeKatalog);
                return RedirectToAction("Index");
            }

            return View(davetiyeKatalog);
        }

        // GET: DavetiyeKatalogs/KatalogDuzenle/5
        public ActionResult KatalogDuzenle(int id)
        {
           
            DavetiyeKatalog davetiyeKatalog = DKRep.GetById(id);
            if (davetiyeKatalog == null)
            {
                return HttpNotFound();
            }
            return View(davetiyeKatalog);
        }

        // POST: DavetiyeKatalogs/KatalogDuzenle/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult KatalogDuzenle([Bind(Include = "Id,KatalogAdi")] DavetiyeKatalog davetiyeKatalog)
        {
            if (ModelState.IsValid)
            {
                DavetiyeKatalog degisenkatalog = DKRep.GetById(davetiyeKatalog.KatalogId);
                degisenkatalog.KatalogAdi = davetiyeKatalog.KatalogAdi;
                DKRep.Update(degisenkatalog);
                return RedirectToAction("Index");
            }
            return View(davetiyeKatalog);
        }

        // GET: DavetiyeKatalogs/KatalogSil/5
        public ActionResult KatalogSil(int id)
        {

            DavetiyeKatalog davetiyeKatalog = DKRep.GetById(id);
            if (davetiyeKatalog == null)
            {
                return HttpNotFound();
            }
            return View(davetiyeKatalog);
        }

        // POST: DavetiyeKatalogs/KatalogSil/5
        [HttpPost, ActionName("KatalogSil")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DKRep.Delete(id);
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
