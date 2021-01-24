using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CONGNGHENET
{
    public class tinhtrangDau
    {
        string connectString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        public DataTable getTalbe(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, connectString);
            da.Fill(dt);
            return dt;
        }
        public bool add_Tinhtrang(tinhtrang tt)
        {
            SqlConnection conn = new SqlConnection(connectString);
            string sql = "insert into TINHTRANG values  (@ma ,@ten)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma", tt.Matinhtrang);
            cmd.Parameters.AddWithValue("@ten", tt.Tentinhtrang);
            conn.Open();
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count >= 1;
        }

        public bool check_Matt(string maTT)
        {
            SqlConnection conn = new SqlConnection(connectString);
            string sql = "select count (*) from TINHTRANG where MaTT= @ma";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma", maTT);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count >= 1;
        }
        public bool delete_MA(string maTT)
        {
            SqlConnection conn = new SqlConnection(connectString);
            string sql = "delete from TINHTRANG where MaTT= @mtt";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mtt", maTT);
            conn.Open();
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count >= 1;
        }
        public bool edit_MA(tinhtrang maTT)
        {
            SqlConnection conn = new SqlConnection(connectString);
            string sql = "update TINHTRANG set TinhTrang= @ten Where MaTT= @ma";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma", maTT.Matinhtrang);
            cmd.Parameters.AddWithValue("@ten", maTT.Tentinhtrang);
            conn.Open();
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count >= 1;
        }

    }
}