using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNangCao.Dal
{
    public class clsSanPham
    {
        public DataTable GetList(SqlConnection conn, int id)
        {
            using (SqlCommand cmd = new SqlCommand("spSelectDanhMucSanPham", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
        public DataTable GetListChiTietSanPhambyIDdanhmuc(SqlConnection conn, int id)
        {
            using (SqlCommand cmd = new SqlCommand("spSelectChiTietSanPhambyIDdanhmuc", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_danhmuc", id);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
        public DataTable GetListChiTietSanPhambyIDdanhmucNguoiTao(SqlConnection conn, int id,string nguoitao)
        {
            using (SqlCommand cmd = new SqlCommand("spSelectChiTietSanPhambyIDdanhmucNguoiTao", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_danhmuc", id);
                cmd.Parameters.AddWithValue("@nguoitao", nguoitao);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
        public DataTable GetListChiTietSanPhambyID(SqlConnection conn, int id)
        {
            using (SqlCommand cmd = new SqlCommand("spSelectChiTietSanPhambyID", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
        public void ActiveSanPham(SqlConnection conn, int id, bool trangthai)
        {
            SqlCommand cmd = new SqlCommand("spActiveSanPham", conn);
            cmd.CommandType = CommandType.StoredProcedure;
           
            cmd.Parameters.AddWithValue("@trangthai", trangthai);
       
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

        }
        public DataTable GetListDisPlay(SqlConnection conn)
        {
            using (SqlCommand cmd = new SqlCommand("spSelectDanhMucSanPhamDisplay", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
               
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
        public DataTable GetSanPhamMoiNhat(SqlConnection conn)
        {
            using (SqlCommand cmd = new SqlCommand("spSelectSanPhamMoiNhatDisplay", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
        public DataTable GetSanPhamBanChay(SqlConnection conn)
        {
            using (SqlCommand cmd = new SqlCommand("spSelectSanPhamBanChayDisplay", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
        public DataTable GetListChiTietSanPhambyIDdanhmucDisplay(SqlConnection conn, int id)
        {
            using (SqlCommand cmd = new SqlCommand("spSelectChiTietSanPhambyIDdanhmucDisplay", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_danhmuc", id);
                
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
        public DataTable GetListChiTietSanPhambySearchTen(SqlConnection conn, string name)
        {
            using (SqlCommand cmd = new SqlCommand("spTimKiemTenSP", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ten", name);

                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
        public DataTable GetListChiTietSanPhambySearchTen2(SqlConnection conn, string name,int page)
        {
            using (SqlCommand cmd = new SqlCommand("spTimKiemTenSP2", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ten", name);
                cmd.Parameters.AddWithValue("@page", page);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
        public DataTable GetListChiTietSanPhambyIDdanhmucDisplay2(SqlConnection conn, int id,int page)
        {
            using (SqlCommand cmd = new SqlCommand("spSelectChiTietSanPhambyIDdanhmucDisplay2", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_danhmuc", id);
                cmd.Parameters.AddWithValue("@page", page);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
        public DataTable GetListChiTietSanPhamChuaDuocDuyetbyIDdanhmuc(SqlConnection conn, int id)
        {
            using (SqlCommand cmd = new SqlCommand("spSelectChiTietSanPhamChuaDuocDuyetbyIDdanhmuc", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_danhmuc", id);

                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
        public void ThemChiTietSanPhamDisPlay(SqlConnection conn, int id_danhmuc,string ten,DateTime ngaytao,float gia,int soluong,string mota,string img, string nguoitao)
        {
            using (SqlCommand cmd = new SqlCommand("spInsertChiTietSanPhamDisPlay", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_danhmuc", id_danhmuc);
                cmd.Parameters.AddWithValue("@name", ten);
                cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
                cmd.Parameters.AddWithValue("@gia", gia);
                cmd.Parameters.AddWithValue("@soluong", soluong);
                cmd.Parameters.AddWithValue("@mota", mota);
                cmd.Parameters.AddWithValue("@img", img);
                cmd.Parameters.AddWithValue("@nguoitao", nguoitao);
                cmd.ExecuteNonQuery();
            }
        }
        public void ThemDanhMucSanPham(SqlConnection conn, String ten, bool trangthai)
        {
            SqlCommand cmd = new SqlCommand("spInsertDanhMucSanPham", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ten", ten);
            cmd.Parameters.AddWithValue("@trangthai", trangthai);
            cmd.ExecuteNonQuery();

        }
        public void UpdateDanhMucSanPham(SqlConnection conn, int id, String ten, bool trangthai)
        {
            SqlCommand cmd = new SqlCommand("spUpdateDanhMucSanPham", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@ten", ten);
            cmd.Parameters.AddWithValue("@trangthai", trangthai);
            cmd.ExecuteNonQuery();

        }
    }
}
