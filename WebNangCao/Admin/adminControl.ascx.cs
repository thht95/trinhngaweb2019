using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNangCao.Admin
{
    public partial class adminControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null) Response.Redirect("TrangChu.aspx");
            if (Session["username"].ToString().Equals("admin"))
            {
                plMenu.Controls.Add(LoadControl("~/Admin/MenuAdmin.ascx"));
            }
            else
            {
                plMenu.Controls.Add(LoadControl("~/admin/MenuHeThong.ascx"));
            }

            string s = Request["f"];
            switch (s)
            {
                case "tintuc":
                    plLoad.Controls.Add(LoadControl("TinTuc/TinTucControl.ascx"));
                    break;
                case "sanpham":
                    plLoad.Controls.Add(LoadControl("SanPham/SanPhamControl.ascx"));
                    break;
                case "user":
                    plLoad.Controls.Add(LoadControl("Users/UserControl.ascx"));
                    break;
                case "contact":
                    plLoad.Controls.Add(LoadControl("contacts/contactControl.ascx"));
                    break;
            }
        }
        protected void lnkExit_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("~/Administrator.aspx");
        }
    }
}