using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebNangCao.Dal;

namespace WebNangCao
{
    public partial class Contact : System.Web.UI.Page
    {
        clsContact _clsContact = new clsContact();
        private CommonConnect cc = new CommonConnect();
        private SqlConnection conn = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = cc.Connected("WebNC");
            if (!IsPostBack)
            {

               

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Value)!=true&& string.IsNullOrEmpty(txtSubJect.Value) != true&& string.IsNullOrEmpty(txtCompany.Value) != true&& string.IsNullOrEmpty(txtEmail.Value) != true)
            {
                _clsContact.clsInsertContact(conn, txtName.Value, txtEmail.Value, txtCompany.Value, txtSubJect.Value);
               
             //   Response.Write("<script>alert('Cảm ơn bạn đã liên hệ với chúng tôi')</script>");
                txtSubJect.Value = "";
                txtName.Value = "";
                txtCompany.Value = "";
                txtEmail.Value = "";
            }
           
        }
    }
}