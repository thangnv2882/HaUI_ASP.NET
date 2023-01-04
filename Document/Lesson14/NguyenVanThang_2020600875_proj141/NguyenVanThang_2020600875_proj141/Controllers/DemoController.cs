using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenVanThang_2020600875_proj141.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Math(int n1, int n2)
        {
            var x = n1 + n2;
            var result = n1 + " + " + n2 + " = " + x;
            var data = new {status  = "ok", result= result};
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}