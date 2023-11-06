using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QUANLYBANHANG_MVC;

namespace QUANLYBANHANG_MVC.Controllers
{
    public class QUANLYDANHMUCController : Controller
    {
        private dbQUANLYBANHANGEntities db = new dbQUANLYBANHANGEntities();

        // GET: QUANLYDANHMUC
        public ActionResult Index()
        {
            return View(db.tbDANHMUC.ToList());
        }

        // GET: QUANLYDANHMUC/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbDANHMUC tbDANHMUC = db.tbDANHMUC.Find(id);
            if (tbDANHMUC == null)
            {
                return HttpNotFound();
            }
            return View(tbDANHMUC);
        }

        // GET: QUANLYDANHMUC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QUANLYDANHMUC/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MADANHMUC,TENDANHMUC,DANHMUCCHA,MOTA")] tbDANHMUC tbDANHMUC)
        {
            if (ModelState.IsValid)
            {
                db.tbDANHMUC.Add(tbDANHMUC);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbDANHMUC);
        }

        // GET: QUANLYDANHMUC/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbDANHMUC tbDANHMUC = db.tbDANHMUC.Find(id);
            if (tbDANHMUC == null)
            {
                return HttpNotFound();
            }
            return View(tbDANHMUC);
        }

        // POST: QUANLYDANHMUC/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MADANHMUC,TENDANHMUC,DANHMUCCHA,MOTA")] tbDANHMUC tbDANHMUC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbDANHMUC).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbDANHMUC);
        }

        // GET: QUANLYDANHMUC/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbDANHMUC tbDANHMUC = db.tbDANHMUC.Find(id);
            if (tbDANHMUC == null)
            {
                return HttpNotFound();
            }
            return View(tbDANHMUC);
        }

        // POST: QUANLYDANHMUC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbDANHMUC tbDANHMUC = db.tbDANHMUC.Find(id);
            db.tbDANHMUC.Remove(tbDANHMUC);
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
