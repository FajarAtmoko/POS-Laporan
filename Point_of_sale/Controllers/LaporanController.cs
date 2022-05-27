using Point_of_sale.Entitas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Point_of_sale.Controllers
{
    public class LaporanController : Controller
    {
        // GET: Laporan
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Getlist()
        {
            using (DBModels db = new DBModels())
            {
                var empList = db.TB_Laporan.ToList<TB_Laporan>();
                return Json(new { data = empList }, JsonRequestBehavior.AllowGet);
            }
        }

    }
}