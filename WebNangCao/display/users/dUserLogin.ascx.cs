using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebNangCao.Dal;

namespace WebNangCao.display.users
{
    public partial class dUserLogin : System.Web.UI.UserControl
    {
        clsUserDisplay _clsUserDisplay = new clsUserDisplay();
        private CommonConnect cc = new CommonConnect();
        private SqlConnection conn = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = cc.Connected("WebNC");
        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
          
                DataTable dt = new DataTable();
                dt = _clsUserDisplay.Login(conn, txtName.Text.Trim(),txtPassWord.Text.Trim());
                if (dt.Rows.Count > 0)
                {
                    int trangthai =int.Parse(dt.Rows[0]["iQuyen"].ToString());
                    if (trangthai == 0)
                    {
                        Session["usernamedisplay"] = txtName.Text.Trim();
                    }
                    else 
                    {
                        Session["username"] = txtName.Text.Trim();
                    }
                Response.Redirect(Request.Url.ToString());
                }
            else
            {
                lbError.Text = "user name or password is wrong";
            }

                
            }
        
    }
}