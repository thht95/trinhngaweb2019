using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNangCao.Admin.Users
{
    public partial class UserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"].Equals("admin")!=true) Response.Redirect("Administrator.aspx");
            Controls.Add(LoadControl("adminUserControl.ascx"));
        }
    }
}