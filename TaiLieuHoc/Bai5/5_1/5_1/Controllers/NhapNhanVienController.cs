using _5_1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5_1.Controllers
{
    public class NhapNhanVienController : Controller
    {
        // GET: NhapNhanVien
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(FormCollection f)
        {
            // Lấy thông tin từ input type = size
            var fhinh = Request.Files["myfileImage"];
            // Save hinh về server
            var pathhinh = Server.MapPath("~/Images/" + fhinh.FileName);
            fhinh.SaveAs(pathhinh);
            string path = Server.MapPath("~/Staffinfo.txt");
            string[] info = { f["txtID"], f["txtName"], f["txtDate"], f["txtSalary"], fhinh.FileName };
            // Ghi file Staffinfo.txt
            System.IO.File.WriteAllLines(path, info);
            return View("Index");
        }

        public ActionResult Open()
        {
            // Đọc lại file từ server
            string path = Server.MapPath("~/Staffinfo.txt");
            string[] info = System.IO.File.ReadAllLines(path);
            Staff s = new Staff();
            s.StaffId = int.Parse(info[0]);
            s.StaffName = info[1];
            s.BirthOfDate = DateTime.Parse(info[2]);
            s.Salary = decimal.Parse(info[3]);
            s.StaffImage = info[4];

            // Chuyển các thông tin sang view từ các biến ViewBag
            ViewBag.id = s.StaffId;
            ViewBag.name = s.StaffName;
            ViewBag.birthday = s.BirthOfDate.ToString("yyyy-MM-dd");
            ViewBag.salary = s.Salary;
            ViewBag.image = "../../Images" + s.StaffImage;
            return View("Index");
        }
    }
}