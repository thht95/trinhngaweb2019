using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNangCao.Admin
{
    public partial class Administrator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
                plLoad.Controls.Add(LoadControl("~/Admin/adminControl.ascx"));
            else
                Response.Redirect("TrangChu.aspx");
        }
    }
}