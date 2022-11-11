using De4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Web.WebPages;

namespace De4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Cau1()
        {

            return View();
        }
        public ActionResult Cau2()
        {

            return View();
        }
        public ActionResult KetQua(GiangVien gv)
        {
            gv.luongGio = Request["luongGio"].AsFloat();
            gv.soGio = Request["soGio"].AsInt();
            gv.maGV = Request["maGV"];
            gv.hoTen = Request["hoTen"];

            if (gv.soGio >= 120)
            {
                gv.luongThang = gv.luongGio * gv.soGio * 1.1f;
            }
            else
            {
                gv.luongThang = gv.luongGio * gv.soGio;
            }
            return View(gv);
        }

    }
}