using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebNangCao.Dal;

namespace WebNangCao.display.News
{
    public partial class dNewsList : System.Web.UI.UserControl
    {
        clsTinTuc _clsTinTuc = new clsTinTuc();
        private CommonConnect cc = new CommonConnect();
        private SqlConnection conn = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = cc.Connected("WebNC");

            if (!IsPostBack)
            {
                LoadList();
            }
        }
        void LoadList()
        {
            rptNewsDetailsnn.DataSource = _clsTinTuc.GetListTinTucDisplay(conn);
            rptNewsDetailsnn.DataBind();
        }
    }
}