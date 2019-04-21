using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNangCao.display.users
{
    public partial class dUserDisplayControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            switch (Request["fs"])
            {
                case "register":
                    if (Session["usernamedisplay"] != null || Session["username"]!=null)
                        Response.Redirect("TrangChu.aspx    ");
                    else
                        Controls.Add(LoadControl("/display/users/dUserDangKy.ascx"));
                    break;
                case "login":
                    if (Session["usernamedisplay"] != null || Session["username"] != null)
                        Response.Redirect("TrangChu.aspx");
                    else
                        Controls.Add(LoadControl("/display/users/dUserLogin.ascx"));
                    break;
                case "kenhban":
                    if (Session["usernamedisplay"] != null && Session["username"] == null)
                        Controls.Add(LoadControl("/display/users/dUserKenhBan.ascx"));

                    else if (Session["usernamedisplay"] == null && Session["username"] != null)
                        Response.Redirect("TrangChu.aspx");

                    else if (Session["usernamedisplay"] == null || Session["username"] == null)
                       
                    Controls.Add(LoadControl("/display/users/dUserLogin.ascx"));
                    break;
                default:
                   
                    break;
            }
        }
    }
}