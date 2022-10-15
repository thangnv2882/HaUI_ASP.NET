using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_2.Controllers
{
    public class TinhTienDienController : Controller
    {
        // GET: TinhTienDien
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult XuLy()
        {
            string chuHo = Request["hoTen"];

            int cu = int.Parse(Request["chiSoCu"]);
            int moi = int.Parse(Request["chiSoMoi"]);
            ViewBag.chuHo = cu;

            int tieuThu = moi - cu;
            ViewBag.tieuThu = tieuThu;

            double phaiTra = 0;
            if(tieuThu <= 100)
            {
                phaiTra = tieuThu * 2000;
            }
            else if (tieuThu <= 150)
            {
                phaiTra = 100 * 2000 + (tieuThu - 100) * 2500;
            }
            else if (tieuThu <= 200)
            {
                phaiTra = 100 * 2000 + 50 * 2500 + (tieuThu - 150) * 3000;
            }
            else
            {
                phaiTra = 100 * 2000 + 50 * 2500 + 50 * 3000 + (tieuThu - 200) * 4000;
            }

            string loai = Request["loai"];
            if(loai.CompareTo("Kinh doanh") == 0)
            {
                phaiTra *= 1.2;
            }
            else if(loai.CompareTo("Sản xuất") == 0)
            {
                phaiTra *= 1.3;
            }


            string checkUuTien = Request["checkUuTien"];
            if(checkUuTien == "on")
            {
                phaiTra *= 0.9;
            }
            ViewBag.phaiTra = phaiTra;

            return View();
        }
    }
}