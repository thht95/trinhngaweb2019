using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNangCao.Dal
{
    
   public class clsTinTuc
    {
        public DataTable GetList(SqlConnection conn,int id)
        {
            using (SqlCommand cmd = new SqlCommand("spSelectDanhMucTinTuc", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
        public void ThemDanhMucTinTuc(SqlConnection conn,String ten,bool trangthai)
        {
            SqlCommand cmd = new SqlCommand("spInsertDanhMucTinTuc", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", ten);
            cmd.Parameters.AddWithValue("@trangthai", trangthai);
            cmd.ExecuteNonQuery();
           
        }
        public void UpdateDanhMucTinTuc(SqlConnection conn,int id, String ten, bool trangthai)
        {
            SqlCommand cmd = new SqlCommand("UpdateDanhMucTinTuc", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@name", ten);
            cmd.Parameters.AddWithValue("@trangthai", trangthai);
            cmd.ExecuteNonQuery();

        }
        public void DeleteDanhMucTinTuc(SqlConnection conn, int id)
        {
            SqlCommand cmd = new SqlCommand("DeleteDanhMucTinTuc", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);
            
            cmd.ExecuteNonQuery();

        }
        public DataTable GetListChiTietTinTuc(SqlConnection conn, int id)
        {
            using (SqlCommand cmd = new SqlCommand("spSelectChiTietTinTuc", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
        public DataTable GetChiTietTinTuc(SqlConnection conn, int id)
        {
            using (SqlCommand cmd = new SqlCommand("spSelectChiTietTinTucbyID", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
        public void ThemChiTietTinTuc(SqlConnection conn,int id_danhmuc,String title,String Content,String img,String tacgia, bool trangthai,DateTime ngaytao)
        {
            SqlCommand cmd = new SqlCommand("spInsertChiTietTinTuc", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_danhmuc", id_danhmuc);
            cmd.Parameters.AddWithValue("@tile", title);
            cmd.Parameters.AddWithValue("@noidung", Content);
            cmd.Parameters.AddWithValue("@img", img);
            cmd.Parameters.AddWithValue("@tacgia", tacgia);
            cmd.Parameters.AddWithValue("@trangthai", trangthai);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.ExecuteNonQuery();

        }
        public void DeleteChiTietTinTuc(SqlConnection conn, int id)
        {
            SqlCommand cmd = new SqlCommand("DeleteChiTietTinTuc", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();

        }
        public void UpdateChiTietTinTuc(SqlConnection conn, int id,int id_danhmuc, String title, String Content, String img, String tacgia, bool trangthai, DateTime ngaytao)
        {
            SqlCommand cmd = new SqlCommand("UpdateChiTietTinTuc", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_danhmuc", id_danhmuc);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@noidung", Content);
            cmd.Parameters.AddWithValue("@anh", img);
            cmd.Parameters.AddWithValue("@tacgia", tacgia);
            cmd.Parameters.AddWithValue("@trangthai", trangthai);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

        }
        public DataTable GetListTinTucDisplay(SqlConnection conn)
        {
            using (SqlCommand cmd = new SqlCommand("spSelectListTinTucDisPlay", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
        public DataTable GetChiTietTinTucDisplay(SqlConnection conn,int id)
        {
            using (SqlCommand cmd = new SqlCommand("spSelectChiTietTinTucDisPlay", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
        
         public DataTable GetChiTietTinTucKhacDisplay(SqlConnection conn, int id)
        {
            using (SqlCommand cmd = new SqlCommand("spSelectChiTietTinTucKhacDisPlay", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
    }
}
