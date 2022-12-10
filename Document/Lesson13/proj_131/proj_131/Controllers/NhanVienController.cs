using proj_131.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proj_131.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: NhanVien
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Input()
        {
            return View();
        }


        public ActionResult Process(NhanVien nv)
        {
            List<NhanVien> nhanviens = (List<NhanVien>)Session["nhanvien"];

            if (nhanviens == null)
            {
                nhanviens = new List<NhanVien>();
            }
            nv.luong = nv.soNgayCong * nv.motNgayCong;

            if (nv.soNgayCong >= 25)
            {
                nv.luong += nv.luong * 0.15;
            }
            else if (nv.soNgayCong < 20)
            {
                nv.luong -= nv.luong * 0.05;
            }

            nhanviens.Add(nv);
            Session["nhanvien"] = nhanviens;
            return RedirectToAction("Output");
        }

        public ActionResult Output()
        {
            List<NhanVien> nhanviens = (List<NhanVien>)Session["nhanvien"];
            if (nhanviens == null)
            {
                nhanviens = new List<NhanVien>();
            }
            return View(nhanviens);
        }

        public ActionResult Add()
        {
            return View("Input");
        }
    }
}