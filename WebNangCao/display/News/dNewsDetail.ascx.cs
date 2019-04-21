using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebNangCao.Dal;

namespace WebNangCao.display.News
{
    public partial class dNewsDetail : System.Web.UI.UserControl
    {
        clsTinTuc _clsTinTuc = new clsTinTuc();
        private CommonConnect cc = new CommonConnect();
        private SqlConnection conn = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = cc.Connected("WebNC");
            if (!IsPostBack)
            {
                LoadDetail();
            }
        }
        void LoadDetail()
        {
            String id = Request["id"];
            if (id != null)
            {
                DataTable dt = new DataTable();
                dt = _clsTinTuc.GetChiTietTinTucDisplay(conn, int.Parse(id));
                if (dt.Rows.Count > 0)
                {
                    ltTitle.Text = dt.Rows[0]["sTitle"].ToString();
                    ltNgayTao.Text = dt.Rows[0]["dNgayTao"].ToString();
                    ltContent.Text = dt.Rows[0]["sContent"].ToString();
                    ltAuthor.Text = dt.Rows[0]["sAuthor"].ToString();

                    DataTable dt2 = new DataTable();
                    dt2 = _clsTinTuc.GetChiTietTinTucKhacDisplay(conn, int.Parse(id));
                    if (dt2.Rows.Count > 0)
                    {
                        rptNewsList.DataSource = dt2;
                        rptNewsList.DataBind();
                    }

                }
            }

        }
    }
}