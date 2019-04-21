using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNangCao.display.users
{
    public partial class dKenhBanQuanLyDonHang : System.Web.UI.UserControl
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
          
                string select = "select ID,fTongTien,convert(varchar(10), dNgayTao, 105)AS[dNgayTao] from GioHang where sNguoiMua='" + Session["usernamedisplay"].ToString() + "'";
                DataTable dtdn = new DataTable();
                SqlDataAdapter dadn = new SqlDataAdapter(select, conn);
                dadn.Fill(dtdn);
                gvHoaDon.DataSource = dtdn;
                gvHoaDon.DataBind();
            

        }
        void ChiTietHoaDon(int x)
        {
            using (SqlCommand cmd = new SqlCommand("spChiTietHoaDonbyIDgiohang", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_giohang", x);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                
                ListView1.DataSource = table2;
                ListView1.DataBind();

                lbTongTien.Text = table2.Rows[0]["Tổng tiền"].ToString();

            }
           
        }

        protected void lnkHoaDon_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32((sender as LinkButton).CommandArgument);
            ChiTietHoaDon(x);
            lbMaDonHang.Text = x.ToString();
            mul.ActiveViewIndex = 1;
        }

protected void gvHoaDon_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvHoaDon.PageIndex = e.NewPageIndex;
            LoadHoaDon();
        }
     
        protected void gvHoaDon_Sorting(object sender, GridViewSortEventArgs e)
        {

            string orderby = "";
            if(e.SortExpression=="fTongTien")
            {
                orderby = "fTongTien " + hdshort.Value;
                if (hdshort.Value == "ASC")
                    hdshort.Value = "DESC";
                else
                    hdshort.Value = "ASC";
            }
            string select = "select ID,fTongTien,convert(varchar(10), dNgayTao, 105)AS[dNgayTao] from GioHang where sNguoiMua='" + Session["usernamedisplay"].ToString() + "'";
            DataTable dtdn = new DataTable();
            SqlDataAdapter dadn = new SqlDataAdapter(select, conn);
            dadn.Fill(dtdn);
            dtdn.DefaultView.Sort = orderby;
            gvHoaDon.DataSource = dtdn;
            gvHoaDon.DataBind();
        }
   
    }
}