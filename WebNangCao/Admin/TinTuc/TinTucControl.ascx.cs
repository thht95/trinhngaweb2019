using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNangCao.Admin.TinTuc
{
    public partial class TinTucControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null) Response.Redirect("TrangChu.aspx");
            string fs = Request["fs"];
            switch (fs)
            {
                case "danhmuc":
                    Controls.Add(LoadControl("DanhMucTinTuc.ascx"));
                    break;
                case "chitiettintuc":
                    Controls.Add(LoadControl("ChiTietTinTuc.ascx"));
                    break;
            }

        }
    }
}