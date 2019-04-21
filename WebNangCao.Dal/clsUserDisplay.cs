using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WebNangCao.Dal
{
    public class clsUserDisplay
    {
        protected string BuildPassword(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; ++i)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }
        public DataTable Login(SqlConnection conn, string name, string pass)
        {
            using (SqlCommand cmd = new SqlCommand("spLoginDisplay", conn))
            {
                string password = BuildPassword(pass);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", name);
                cmd.Parameters.AddWithValue("@pass", (password));
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
        public DataTable SelectUser(SqlConnection conn, string name)
        {
            using (SqlCommand cmd = new SqlCommand("spSelectUserDisplay", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", name);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
        public void Insert(SqlConnection conn, string username, string password, string email, string phone, string fullname, string diachi, DateTime ngaytao)
        {
            string pass = BuildPassword(password);
            SqlCommand cmd = new SqlCommand("spInsertUserDisplay", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@fullname", fullname);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.ExecuteNonQuery();
        }
    }
}
