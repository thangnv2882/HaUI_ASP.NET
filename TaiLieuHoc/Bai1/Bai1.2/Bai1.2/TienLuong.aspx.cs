using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai1._2
{
    public partial class TienLuong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btTinh_Click(object sender, EventArgs e)
        {
            int nctl = 25;
            int ngayCong = int.Parse(txtNgayCong.Text);
            if (ngayCong >= 25)
            {
                nctl = (ngayCong - 25) * 2 + 25;
            }

            int phuCap;
            if(chucvu.Text.CompareTo("Trưởng phòng") == 0)
            {
                phuCap = 500000;
            }
            else if(chucvu.Text.CompareTo("Phó phòng") == 0)
            {
                phuCap = 300000;
            }
            else
            {
                phuCap = 100000;
            }

            int tienLinh = int.Parse(txtBacLuong.Text) * 650000 * nctl + phuCap;

            txtTienLinh.Text = tienLinh.ToString();


        }

        protected void btXoa_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtBacLuong.Text = "";
            txtNgayCong.Text = "";
        }
    }
}