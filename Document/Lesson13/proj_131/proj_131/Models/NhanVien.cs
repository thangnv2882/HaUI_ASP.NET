using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proj_131.Models
{
    public class NhanVien
    {
        public string maNV { get; set; }
        public string hoTen { get; set; }
        public int soNgayCong { get; set; }
        public double motNgayCong { get; set; }
        public double luong { get; set; }
    }
}