using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNangCao.Admin.SanPham
{
    public partial class SanPhamControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null) Response.Redirect("TrangChu.aspx");
            string fs = Request["fs"];
            switch (fs)
            {
                case "danhmuc":
                    Controls.Add(LoadControl("danhmucsanpham.ascx"));
                    break;

                case "chitietsanpham":
                    Controls.Add(LoadControl("chitietsanpham.ascx"));
                    break;
                case "duyetsanpham":
                    Controls.Add(LoadControl("DuyetSanPham.ascx"));
                    break;
            }
        }
    }
}