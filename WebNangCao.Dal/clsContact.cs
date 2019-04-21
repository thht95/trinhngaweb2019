using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNangCao.Dal
{
    public class clsContact
    {
        public void clsInsertContact(SqlConnection conn, string name,string email,string company,string subject)
        {
            SqlCommand cmd = new SqlCommand("spInsertContact", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@company", company);
            cmd.Parameters.AddWithValue("@subject", subject);
            cmd.ExecuteNonQuery();

        }
        public DataTable GetListChiTietLienHe(SqlConnection conn)
        {
            using (SqlCommand cmd = new SqlCommand("spSelctChiTietLienHe", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table2 = new DataTable();
                com.Fill(table2);
                return table2;
            }
        }
    }
}
