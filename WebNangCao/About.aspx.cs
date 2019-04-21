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
    public partial class About : System.Web.UI.Page
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
            rptNewsList.DataSource = _clsSanPham.GetListDisPlay(conn);
            rptNewsList.DataBind();
        }
    }
}