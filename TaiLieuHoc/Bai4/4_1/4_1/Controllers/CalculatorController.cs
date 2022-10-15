using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_1.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult XuLy(double a, double b, string op = "+")
        {

            switch (op)
            {
                case "+":
                    ViewBag.kq = a + b;
                    break;
                case "-":
                    ViewBag.kq = a - b;
                    break;
                case "*":
                    ViewBag.kq = a * b;
                    break;
                case "/":
                    if (b == 0)
                        ViewBag.kq = "Khong chia duoc cho 0.";
                    else
                        ViewBag.kq = a / b;
                    break;
            }

            return View("Index");
        }
    }
}