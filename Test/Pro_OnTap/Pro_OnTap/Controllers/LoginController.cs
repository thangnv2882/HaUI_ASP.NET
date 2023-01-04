using Pro_OnTap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pro_OnTap.Controllers
{
    public class LoginController : Controller
    {
        private Model1 db = new Model1();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username,string password)
        {
            var user = db.tblUsers.Where(u => u.username == username 
            && u.password == password).FirstOrDefault();
            if (user == null)
            {
                ViewBag.errLogin = "Sai tên đăng nhập hoặc mật khẩu";
                return View("Login");
            } else
            {
                Session["username"] = username;
                return RedirectToAction("Index", "NhanViens");
            }
        }
 
        public ActionResult Logout()
        {
            Session["username"] = null;
            return RedirectToAction("Index", "NhanViens");
        }
    }
}