using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebNangCao.Dal;

namespace WebNangCao.display
{
    public partial class dMenuDisplay : System.Web.UI.UserControl
    {
        clsSanPham _clsSanPham = new clsSanPham();
       
        private CommonConnect cc = new CommonConnect();
        private SqlConnection conn = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = cc.Connected("WebNC");
            if (!IsPostBack)
            {
                LoadMenu();

            }
        }
        void LoadMenu()
        {
            rptProductList.DataSource = _clsSanPham.GetListDisPlay(conn);
            rptProductList.DataBind();
        }
    }
}