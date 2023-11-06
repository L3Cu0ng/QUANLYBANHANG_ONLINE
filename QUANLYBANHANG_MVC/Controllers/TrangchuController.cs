using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QUANLYBANHANG_MVC.Controllers
{
    public class TrangchuController : Controller
    {
        // GET: Trangchu
        private dbQUANLYBANHANGEntities db = new dbQUANLYBANHANGEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(int? id) { 
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            tbSANPHAM tbsanpham = db.tbSANPHAM.Find(id);
            if (tbsanpham == null)
            {
                return HttpNotFound();
            }
            return View(tbsanpham);
        }
    }
}