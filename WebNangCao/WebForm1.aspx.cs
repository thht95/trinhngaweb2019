using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNangCao
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private CommonConnect cc = new CommonConnect();
        private SqlConnection conn = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = cc.Connected("WebNC");
            if (!IsPostBack)
            {
                LoadHoaDon();
            }
        }
        void LoadHoaDon()
        {
            string select = "select ID,fTongTien,convert(varchar(10), dNgayTao, 105)AS[dNgayTao] from GioHang where sNguoiMua='sonhoang23'";
            DataTable dtdn = new DataTable();
            SqlDataAdapter dadn = new SqlDataAdapter(select, conn);

            dadn.Fill(dtdn);
            gvHoaDon.DataSource = dtdn;
            gvHoaDon.DataBind();
        }
        void ChiTietHoaDon(int x)
        {
            string select = "select * from ChiTietGioHang where id_giohang=" + x;
            DataTable dtdn = new DataTable();
            SqlDataAdapter dadn = new SqlDataAdapter(select, conn);
            dadn.Fill(dtdn);
            ListView1.DataSource = dtdn;
            ListView1.DataBind();
        }

        protected void lnkHoaDon_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32((sender as LinkButton).CommandArgument);
            txt.Text = x.ToString();
            ChiTietHoaDon(x);
            mul.ActiveViewIndex = 1;
        }
    }
}