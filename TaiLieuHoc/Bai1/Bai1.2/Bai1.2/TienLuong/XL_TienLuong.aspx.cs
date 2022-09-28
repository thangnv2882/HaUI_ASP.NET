using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai1._2.TienLuong
{
    public partial class XL_TienLuong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtMaNV2.Text = Request.Form.Get("txtMaNV");
            txtNgayCong2.Text = Request.Form.Get("txtNgayCong");
            txtTienLinh2.Text = Request.Form.Get("txtTienLinh");
        }
    }
}