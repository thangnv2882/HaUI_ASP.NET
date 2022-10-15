using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGrease.Activities;

namespace _4_1.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Caculator
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calculate()
        {
            double a = double.Parse(Request["soA"]);
            double b = double.Parse(Request["soB"]);

            System.Diagnostics.Debug.WriteLine(a);

            ViewBag.kq = a;

            return View("Index");
        }
    }
}