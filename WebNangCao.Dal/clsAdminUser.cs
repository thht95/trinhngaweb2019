﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WebNangCao.Dal
{
    public class clsAdminUser

    {
        public void Insert(SqlConnection conn,string username,string password,string email,string phone,string fullname,string diachi,DateTime ngaytao)
        {
            string pass = BuildPassword(password);
            SqlCommand cmd = new SqlCommand("spInsertAdminUser", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@fullname", fullname);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.ExecuteNonQuery();
        }
        protected string BuildPassword(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = 0; i <data.Length; ++i)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }
        public DataTable SelectUser(SqlConnection conn,string name)
        {
            using (SqlCommand cmd = new SqlCommand("spSelectUser", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", name);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
        public DataTable Login(SqlConnection conn, string name,string pass)
        {
            using (SqlCommand cmd = new SqlCommand("spLogin", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", name);
                cmd.Parameters.AddWithValue("@pass", BuildPassword(pass));
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
    }
}
