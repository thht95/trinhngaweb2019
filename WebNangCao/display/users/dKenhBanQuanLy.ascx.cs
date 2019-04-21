using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebNangCao.Dal;

namespace WebNangCao.display.users
{
    public partial class dKenhBanQuanLy : System.Web.UI.UserControl
    {
        clsSanPham _clsSanPham = new clsSanPham();
        private CommonConnect cc = new CommonConnect();
        private SqlConnection conn = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = cc.Connected("WebNC");
            if (!IsPostBack)
            {
               
                LoadDataDropDownList();

                LoadNewsDetail();

            }
        }
        void LoadDataDropDownList()
        {
            drpSanPhamCategory1.DataSource = _clsSanPham.GetList(conn, 0);
            drpSanPhamCategory1.DataValueField = "ID";
            drpSanPhamCategory1.DataTextField = "sName";
            drpSanPhamCategory1.DataBind();
        }
      
        void LoadNewsDetail()
        {
            rptSanPhamDetails.DataSource = _clsSanPham.GetListChiTietSanPhambyIDdanhmucNguoiTao(conn, int.Parse(drpSanPhamCategory1.SelectedValue.ToString()), Session["usernamedisplay"].ToString());
            rptSanPhamDetails.DataBind();
        }
    


        protected void drpSanPhamCategory1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNewsDetail();
        }

        //protected void rptSanPhamDetails_ItemCommand(object source, RepeaterCommandEventArgs e)
        //{
        //    DataTable dt = new DataTable();
        //    dt = _clsSanPham.GetListChiTietSanPhambyIDdanhmucNguoiTao(conn, int.Parse(e.CommandArgument.ToString()), Session["usernamedisplay"].ToString());
        //    switch (e.CommandName.ToString())
        //    {
        //        case "update":
        //            if (dt.Rows.Count > 0)
        //            {
        //                bool trangthai = (bool)dt.Rows[0]["bActive"];
        //                txtTitle.Text = dt.Rows[0]["sTitle"].ToString();
        //                txtChitiet.Text = dt.Rows[0]["sContent"].ToString();

        //                hdImage.Value = dt.Rows[0]["sImage"].ToString();
        //                drpNewsCategory.SelectedValue = dt.Rows[0]["id_danhmuc"].ToString();
        //                chkActive.Checked = trangthai;
        //                hdDelID.Value = e.CommandArgument.ToString();

        //                hdInsert.Value = "update";
        //                mul.ActiveViewIndex = 1;
        //            }
        //            break;
        //        case "delete":

        //            if (dt.Rows.Count > 0)
        //            {
        //                _clsTinTuc.DeleteChiTietTinTuc(conn, int.Parse(e.CommandArgument.ToString()));
        //                Response.Redirect(Request.Url.ToString());
        //            }
        //            break;
        //    }
        //}
    }
}