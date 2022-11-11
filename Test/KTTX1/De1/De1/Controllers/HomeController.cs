using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace De1.Controllers
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

        public ActionResult KetQua()
        {
            ViewBag.maHang = Request["maHang"];
            ViewBag.tenHang = Request["tenhang"];
            var thanhtien = "";
            var soluong = 0;
            var dongia = 0f;

                soluong = Request["SoLuong"].AsInt();
                dongia = Request["DonGia"].AsFloat();
                if (soluong >= 100)
                {
                ViewBag.thanhtien = (soluong * dongia * 0.9f).ToString();
                }
                else
                {
                ViewBag.thanhtien = (soluong * dongia).ToString();
                }
                return View();
        }

    }
}