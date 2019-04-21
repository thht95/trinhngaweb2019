using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebNangCao.Dal;

namespace WebNangCao
{
    public partial class ThanhToan : System.Web.UI.Page
    {
        clsProductCart _clsProductCart = new clsProductCart();
        private CommonConnect cc = new CommonConnect();
        private SqlConnection conn = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = cc.Connected("WebNC");
            if (Session["usernamedisplay"] == null)
            {
                Response.Redirect("TrangChu.aspx?f=users&fs=login");
            }
            else
            {
                if (Session["cart"] != null)
                {
                    DataTable dtCart = (DataTable)Session["cart"];
                    rptProductCart.DataSource = dtCart;
                    rptProductCart.DataBind();

                    float total = 0;
                    for (int i = 0; i < dtCart.Rows.Count; i++)
                    {
                        total += Convert.ToSingle(dtCart.Rows[i]["Money"]);
                    }
                    ltTotal.Text = string.Format("{0:N0}", total);
                    Session["Total"] = total;
                    Session["CountSP"] = dtCart.Rows.Count.ToString();
                    if (dtCart.Rows.Count > 0)
                    {
                        txtText.Visible = false;
                        giohang.Visible = true;
                    }

                    else
                    {
                        txtText.Visible = true;
                        giohang.Visible = false;
                    }


                }
                else
                {
                    txtText.Visible = true;
                    giohang.Visible = false;
                }


            }


        }

        protected void rptProductCart_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            _clsProductCart.ShoppingCart_RemoveCart(int.Parse(e.CommandArgument.ToString()));
            Response.Redirect(Request.Url.ToString());
        }
        protected void msgDelete(object sender, System.EventArgs e)
        {
            ((LinkButton)sender).Attributes["onclick"] = "return confirm('Bạn có muốn xóa sản phẩm này ??')";
        }
        protected void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (Session["cart"] != null)
            {

                DataTable dtCart = (DataTable)Session["cart"];
                DataTable dtHoaDon = _clsProductCart.TaoHoaDon(conn, Session["usernamedisplay"].ToString(), float.Parse(Session["Total"].ToString()));
                if (dtHoaDon.Rows.Count > 0)
                {
                   
             
                    int idhoadon = int.Parse(dtHoaDon.Rows[0]["ID"].ToString());
                    for (int i = 0; i < dtCart.Rows.Count; i++)
                    {
                        _clsProductCart.ThemChiTietGioHang(conn, idhoadon, int.Parse(dtCart.Rows[i]["ID"].ToString()), int.Parse(dtCart.Rows[i]["iSoLuong"].ToString()), float.Parse(dtCart.Rows[i]["Money"].ToString()));
                    }

                    mul.ActiveViewIndex = 1;
                    //Response.Redirect(Request.Url.ToString());
                    DataTable dt = new clsUserDisplay().SelectUser(conn, Session["usernamedisplay"].ToString());
                    lbMaHoaDon.Text = idhoadon.ToString();
                    lbNguoiMua.Text = dt.Rows[0]["sFullName"].ToString();
                    lbDiaChi.Text = dt.Rows[0]["sDiaChi"].ToString();
                    lbDienThoai.Text = dt.Rows[0]["sPhone"].ToString();
                    lbTongTien.Text = dtHoaDon.Rows[0]["fTongTien"].ToString();
                    _clsProductCart.XoaGioHang();


                }

            }


        }

        protected void btnThanhToan_Load(object sender, EventArgs e)
        {

        }
    }
}