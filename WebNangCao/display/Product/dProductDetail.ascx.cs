using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebNangCao.Dal;

namespace WebNangCao.display.Product
{
    public partial class dProductDetail : System.Web.UI.UserControl
    {
        clsSanPham _clsSanPham = new clsSanPham();
        clsProductCart _clsProductCart = new clsProductCart();
        string id = "";
        private CommonConnect cc = new CommonConnect();
        private SqlConnection conn = null;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request["id"];
            dt= new DataTable();
            conn = cc.Connected("WebNC");
          
            if (!IsPostBack)
            {
                LoadDetail();
                LoadSoLuong();
                if(lbTrangThai.Text== "Còn Hàng")
                {
                    txtSoLuong.Visible = true;
                }
                else
                {
                    txtSoLuong.Visible = false;
                }

            }
        }
        void LoadSoLuong()
        {
            int x = int.Parse(dt.Rows[0]["iSoLuong"].ToString());
            if (x > 0)
            {
                lbTrangThai.Text = "Còn Hàng";
                lbTrangThai.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                lbTrangThai.Text = "Hết Hàng";
                lbTrangThai.ForeColor = System.Drawing.Color.Red;
            }
        }
        void LoadDetail()
        {
            
            string id = Request["id"];
            dt = _clsSanPham.GetListChiTietSanPhambyID(conn, int.Parse(id));
            if (dt.Rows.Count > 0)
            {
                ltName.Text = dt.Rows[0]["sName"].ToString();
                ltImage.Text = "<image src='/" + dt.Rows[0]["sImage"].ToString() + "'/>";
                ltDesc.Text = dt.Rows[0]["sDesc"].ToString();
                int gia = int.Parse(dt.Rows[0]["fGia"].ToString());
                lbPrice.Text = string.Format("{0:N0}", gia) + " VNĐ";
                ltContent.Text = dt.Rows[0]["sMoTa"].ToString();
            }
        }

        protected void lnkCart_Click(object sender, EventArgs e)
        {
               if(Session["usernamedisplay"]==null){
                   Response.Redirect("TrangChu.aspx?f=users&fs=login");
               }
               else 
            if (lbTrangThai.Text.ToString().Trim().Equals("Còn Hàng") ==true)
            {
                _clsProductCart.ShoppingCart_AddCart(conn, int.Parse(id), int.Parse(txtSoLuong.Text.ToString()));
                Response.Redirect("/SanPham.aspx?f=product&fs=cart");
            }
           
        }
    }
}