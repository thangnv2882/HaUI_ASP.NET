using proj7_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proj7_2.Controllers
{
    public class RegistrationFormController : Controller
    {
        // GET: RegistrationForm
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Regis(Person person)
        {
            return View(person);
        }
    }
}