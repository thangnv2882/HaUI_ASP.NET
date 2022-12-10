using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenVanThang_2020600875_proj12.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HttpCookie sv = new HttpCookie("sv");
            sv["maSV"] = "2020600875";
            sv["hoTen"] = "Nguyen Van Thang";
            sv["queQuan"] = "Dan Phuong";
            sv.Expires.Add(new TimeSpan(0, 5, 0));
            HttpContext.Response.Cookies.Add(sv);
            return View();
        }

        public ActionResult getCookie()
        {
            ViewBag.maSV = HttpContext.Request.Cookies.Get("sv").Values.Get("maSV");
            ViewBag.hoTen = HttpContext.Request.Cookies.Get("sv").Values.Get("hoTen");
            ViewBag.queQuan = HttpContext.Request.Cookies.Get("sv").Values.Get("queQuan");
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
    }
}