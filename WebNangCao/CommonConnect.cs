using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebNangCao
{
    public class CommonConnect
    {
        private SqlConnection conn;
        public SqlConnection Connected(string tendatabase)
        {

            string source = @"Data Source=THUYTRANG\SQLEXPRESS;Initial Catalog=WebNC;Integrated Security=True";
            conn = new SqlConnection(source);
            conn.Open();
            return conn;
        }
        //Data Source = STAR; Initial Catalog = WebNC; Integrated Security = True
    }
}