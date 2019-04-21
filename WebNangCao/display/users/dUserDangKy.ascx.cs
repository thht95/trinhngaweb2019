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
    public partial class dUserDangKy : System.Web.UI.UserControl
    {
        clsUserDisplay _clsUserDisplay = new clsUserDisplay();
        private CommonConnect cc = new CommonConnect();
        private SqlConnection conn = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = cc.Connected("WebNC");
        }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                DataTable dt = new DataTable();
                dt = _clsUserDisplay.SelectUser(conn, txtName.Text.Trim());
                if (dt.Rows.Count <= 0)
                {
                    _clsUserDisplay.Insert(conn, txtName.Text.Trim(), txtPassWord.Text.Trim(), txtEmail.Text.Trim(), txtPhone.Text.Trim(), txtFullName.Text.Trim(), txtDiaChi.Text.Trim(), DateTime.Now);
                    Response.Redirect("/TrangChu.aspx?f=users&fs=login");
                }
                else
                {
                    lbError.Text = "Đã có tên đăng nhập vui lòng chọn tên khác";
                }
                //Response.Redirect(Request.Url.ToString());
            }
        }



       
    }
}