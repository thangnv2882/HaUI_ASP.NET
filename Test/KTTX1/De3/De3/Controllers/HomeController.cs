using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace De3.Controllers
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
            ViewBag.maNV = Request["maNV"];
            ViewBag.hoTen = Request["hoTen"];

            var luongNgay = Request["luongNgay"].AsFloat();
            var soNgay = Request["soNgay"].AsInt();

            if (soNgay >= 25)
            {
                ViewBag.thuNhap = (luongNgay * soNgay + 500000).ToString();
            }
            else
            {
                ViewBag.thuNhap = (luongNgay * soNgay).ToString();
            }
            return View();
        }


    }
}