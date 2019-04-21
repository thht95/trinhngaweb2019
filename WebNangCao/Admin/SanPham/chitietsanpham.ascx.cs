using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebNangCao.Dal;

namespace WebNangCao.Admin.SanPham
{
    public partial class chitietsanpham : System.Web.UI.UserControl
    {
        clsSanPham _clssanpham = new clsSanPham();
        private CommonConnect cc = new CommonConnect();
        private SqlConnection conn = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = cc.Connected("WebNC");
            if (!IsPostBack)
            {

                LoadDataDropDownList();
                LoadSanPhamDetail();
            }

        }
        void LoadDataDropDownList()
        {
            drpSanPhamCategory.DataSource = _clssanpham.GetListDisPlay(conn);
            drpSanPhamCategory.DataValueField = "ID";
            drpSanPhamCategory.DataTextField = "sName";
            drpSanPhamCategory.DataBind();
        }
        void LoadSanPhamDetail()
        {
            rptSanPhamNewsDetails.DataSource = _clssanpham.GetListChiTietSanPhambyIDdanhmucDisplay(conn, int.Parse(drpSanPhamCategory.SelectedValue.ToString()));
            rptSanPhamNewsDetails.DataBind();
        }
        protected void Delete_Load(object sender, System.EventArgs e)
        {
            ((LinkButton)sender).Attributes["onclick"] = "return confirm('Bạn muốn ẩn sản phẩm này ?')";
        }

        protected void drpSanPhamCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSanPhamDetail();
        }

        protected void rptSanPhamNewsDetails_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = _clssanpham.GetListChiTietSanPhambyID(conn, int.Parse(e.CommandArgument.ToString()));
            switch (e.CommandName.ToString())
            {
                case "update":
                    if (dt.Rows.Count > 0)
                    {

                        DataTable dt2 = new DataTable();
                        dt2 = _clssanpham.GetList(conn, int.Parse(dt.Rows[0]["id_danhmuc"].ToString()));
                        txtTenSP.Text = dt.Rows[0]["sName"].ToString();
                        txtMoTa.Text = dt.Rows[0]["sMoTa"].ToString();
                        txtGia.Text = dt.Rows[0]["fGia"].ToString();
                        txtSoLuong.Text = dt.Rows[0]["iSoLuong"].ToString();
                        lbLoaiSanPham.Text = dt2.Rows[0]["sName"].ToString();
                        txtNgayTao.Text = dt.Rows[0]["dNgayTao"].ToString();
                        imgHinhHanh.ImageUrl = dt.Rows[0]["sImage"].ToString();

                        hdDelID.Value = e.CommandArgument.ToString();

                        hdInsert.Value = "update";
                        mul.ActiveViewIndex = 1;
                    }
                    break;
                case "thaydoi":

                    if (dt.Rows.Count > 0)
                    {


                        {
                            _clssanpham.ActiveSanPham(conn, int.Parse(e.CommandArgument.ToString()), false);
                        }
                        Response.Redirect(Request.Url.ToString());
                    }
                    break;
            }
        }


    }
}