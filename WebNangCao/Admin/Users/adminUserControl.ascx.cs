using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebNangCao.Dal;

namespace WebNangCao.Admin.Users
{
    public partial class adminUserControl : System.Web.UI.UserControl
    {
        clsAdminUser _clsAdminUser = new clsAdminUser();
        private CommonConnect cc = new CommonConnect();
        private SqlConnection conn = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = cc.Connected("WebNC");
            if (!IsPostBack)
            {

            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text.Trim()) && !string.IsNullOrEmpty(txtPassWord.Text.Trim()))
            {
                DataTable dt = new DataTable();
                dt = _clsAdminUser.SelectUser(conn, txtUserName.Text.Trim());
                if (dt.Rows.Count <= 0)
                {
                    _clsAdminUser.Insert(conn, txtUserName.Text.Trim(), txtPassWord.Text.Trim(),txtEmail.Text.Trim(),txtPhone.Text.Trim(), txtFullName.Text.Trim(), txtAddress.Text.Trim(), DateTime.Now);
                }

                Response.Redirect(Request.Url.ToString());
            }
        }
    }
}