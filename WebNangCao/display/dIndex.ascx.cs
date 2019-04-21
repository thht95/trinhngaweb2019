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
    public partial class dIndex : System.Web.UI.UserControl
    {
        clsSanPham _clsSanPham = new clsSanPham();
        private CommonConnect cc = new CommonConnect();
        private SqlConnection conn = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = cc.Connected("WebNC");
            plLoad.Controls.Add(LoadControl("/display/dMenuDisplay.ascx"));
     
            if (!IsPostBack)
            {
                LoadNewSanPham();
               

            }
        }
        void LoadNewSanPham()
        {
            rptNewProduct.DataSource = _clsSanPham.GetSanPhamMoiNhat(conn);
            rptNewProduct.DataBind();
            rptHotProduct.DataSource = _clsSanPham.GetSanPhamBanChay(conn);
            rptHotProduct.DataBind();
        }
    }
}