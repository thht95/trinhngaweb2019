using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNangCao
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usernamedisplay"] != null)
            {
                    divdangki.Visible = false;
                    taikhoan.Visible = true;
                txtKenhBan.Visible = true;
                txtKenhHeThong.Visible = false;
            }
            else if (Session["username"] != null)
            {
                
                    divdangki.Visible = false;
                    taikhoan.Visible = false;
                    txtKenhBan.Visible = false;
                    txtKenhHeThong.Visible = true;

            }
            else if (Session["username"] == null && Session["usernamedisplay"] == null)
            {

                divdangki.Visible = true;
                taikhoan.Visible = false;
                txtKenhBan.Visible = true;
                txtKenhHeThong.Visible = false;
            }
            //switch (Request["fs"])
            //{
            //    case "kenhban":
            //        bannerkenhban.Visible = true;
            //        plLoad.Controls.Add(LoadControl("/display/dMenuKenhBan.ascx"));
                  
            //        break;
            //    default:
            //        plLoad.Controls.Clear();
            //        bannerkenhban.Visible = false;
            //        break;
            //}

        }
        protected void lnkExit_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("~/TrangChu.aspx");
        }
        protected void lnkExit2_Click(object sender, EventArgs e)
        {
         
            Response.Redirect("~/SanPham.aspx");
        }
   

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //if(search.Text.ToString().Equals("")!=true)
            //Response.Redirect("TimKiem2.aspx?key="+search.Text.ToString());
        }
    }
}