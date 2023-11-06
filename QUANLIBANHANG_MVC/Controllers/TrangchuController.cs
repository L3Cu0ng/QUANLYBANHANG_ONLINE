using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QUANLIBANHANG_MVC.Controllers
{
    public class TrangchuController : Controller
    {

        private dbQUANLYBANHANGEntities db = new  dbQUANLYBANHANGEntities();

        // GET: Trangchu
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int? id)
        {
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