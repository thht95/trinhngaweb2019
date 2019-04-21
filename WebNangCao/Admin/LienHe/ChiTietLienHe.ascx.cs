using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebNangCao.Dal;

namespace WebNangCao.Admin.LienHe
{
    public partial class ChiTietLienHe : System.Web.UI.UserControl
    {
        clsContact _clsContact = new clsContact();
        private CommonConnect cc = new CommonConnect();
        private SqlConnection conn = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = cc.Connected("WebNC");
            if (!IsPostBack)
            {
               
                LoadNewsDetail();

            }
        }
        void LoadNewsDetail()
        {
            rptNewsDetails.DataSource = _clsContact.GetListChiTietLienHe(conn);
            rptNewsDetails.DataBind();
        }
    }
}