using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WebNangCao.Dal
{
    public class clsProductCart
    {
        clsSanPham _clsSanPham = new clsSanPham();
        public  void ShoppingCart_CreateCart()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("sName", typeof(string));
            dt.Columns.Add("fGia", typeof(float));
            dt.Columns.Add("iSoLuong", typeof(int));
            dt.Columns.Add("Money", typeof(float));
            System.Web.HttpContext.Current.Session["cart"] = dt;
        }

        public  void ShoppingCart_AddCart(SqlConnection conn, int id,int quantity)
        {
            if (System.Web.HttpContext.Current.Session["cart"] == null)// Khi chưa có giỏ hàng
            {
                ShoppingCart_CreateCart();
                ShoppingCart_AddCart(conn,id, quantity);
            }
            else//nếu đã có giỏ hàng 
            {
                DataTable dt = new DataTable();
                dt = _clsSanPham.GetListChiTietSanPhambyID(conn, id);
                if (dt.Rows.Count > 0)
                {
                    string name = dt.Rows[0]["sName"].ToString();
                    float price = float.Parse(dt.Rows[0]["fGia"].ToString());
                    float money = (price * quantity);

                    DataTable dtCart = new DataTable();
                    dtCart = (DataTable)System.Web.HttpContext.Current.Session["cart"];
                    bool hdInsert = false;
                    for(int i = 0; i < dtCart.Rows.Count; i++)
                    {
                        if (dtCart.Rows[i]["ID"].ToString()==id.ToString())
                        {
                            hdInsert = true;
                            quantity += Convert.ToInt32(dtCart.Rows[i]["iSoLuong"].ToString());
                            dtCart.Rows[i]["iSoLuong"] = quantity;
                            dtCart.Rows[i]["Money"] = quantity * Convert.ToSingle(dtCart.Rows[0]["fGia"].ToString());
                            System.Web.HttpContext.Current.Session["cart"] = dtCart;
                            break;
                        }
                    }
                    if (hdInsert == false)
                    {
                        if (dtCart != null)
                        {
                            DataRow dr = dtCart.NewRow();
                            dr["ID"] = id;
                            dr["sName"] = name;
                            dr["iSoLuong"] = quantity;
                            dr["fGia"] = price;
                            dr["Money"] = money;

                            dtCart.Rows.Add(dr);
                            System.Web.HttpContext.Current.Session["cart"] = dtCart;
                        }
                    }
                  

                }

            }
        }
        public void ShoppingCart_RemoveCart(int id)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)System.Web.HttpContext.Current.Session["cart"];
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if(dt.Rows[i]["ID"].ToString()==id.ToString())
                {
                    dt.Rows.RemoveAt(i);
                    break;
                }
            }
            System.Web.HttpContext.Current.Session["cart"] = dt;
        }
        public void XoaGioHang()
        {
            DataTable dt = new DataTable();
            dt = (DataTable)System.Web.HttpContext.Current.Session["cart"];
            dt.Clear();
            System.Web.HttpContext.Current.Session["CountSP"] = 0;
            System.Web.HttpContext.Current.Session["Total"] = 0;
            
            System.Web.HttpContext.Current.Session["cart"] = dt;
        }

        public DataTable TaoHoaDon(SqlConnection conn,string nguoimua,float tongtien)
        {
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("spInsertGioHang", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nguoimua", nguoimua);
                cmd.Parameters.AddWithValue("@tongtien", tongtien);
                cmd.Parameters.AddWithValue("@ngaytao", DateTime.Now);
                int x=cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    using (SqlCommand cmd2 = new SqlCommand("spSelectDongCuoiTrongHoaDon", conn))
                    {
                        cmd2.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter com = new SqlDataAdapter(cmd2);
                       
                        com.Fill(table);
                       
                       
                    }

                }


            }
            return table;
    



        }
        public void ThemChiTietGioHang(SqlConnection conn, int idgiohang,int idsp,int soluong,float money)
        {
            using (SqlCommand cmd = new SqlCommand("spInsertChiTietGioHang", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idgiohang", idgiohang);
                cmd.Parameters.AddWithValue("@idsp", idsp);
                cmd.Parameters.AddWithValue("@soluong", soluong);
                cmd.Parameters.AddWithValue("@money", money);
                cmd.ExecuteNonQuery();
            }
            

        }
    }
}
