using proj10_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace proj10_1.Controllers
{
    public class HomeController : Controller
    {
        private FShopDB db = new FShopDB();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DisplaySupplier(int? page)
        {
            var supplies = db.Nha_CC.Select(s => s);
            // Sap xep truoc khi phan trang
            supplies = supplies.OrderBy(s => s.MaNCC);
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(supplies.ToPagedList(pageNumber, pageSize));
        }
    }
}