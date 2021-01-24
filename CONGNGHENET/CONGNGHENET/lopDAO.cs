using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CONGNGHENET
{
    public class lopDAO
    {
        string connectString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        //string tenlop , string manganh
        public bool addLOP (lop lp)
        {
            SqlConnection conn = new SqlConnection(connectString);
           
            string sql = @"INSERT INTO LOP (TenLop, MaNganh) VALUES (@tenlop, @manganh)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tenlop", lp.TenLop);
            cmd.Parameters.AddWithValue("@manganh",lp.MaNganh);
            conn.Open();
            int dem = cmd.ExecuteNonQuery();
            conn.Close();
            return (dem >= 1);
        }
      

        public bool EditLOP (lop lp, string malop)
        {
            SqlConnection conn = new SqlConnection(connectString);
            string sql = @"UPDATE LOP SET TenLop= @tenlop, MaNganh= @manganh WHERE MaLop= @malop";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@malop", malop);
            cmd.Parameters.AddWithValue("@tenlop", lp.TenLop);
            cmd.Parameters.AddWithValue("@manganh", lp.MaNganh);
            conn.Open();
            int dem = cmd.ExecuteNonQuery();
            conn.Close();
            return (dem >= 1);
        }

        public bool deleteLOP(string malop)
        {
            SqlConnection conn = new SqlConnection(connectString);
            string sql = "delete from LOP where MaLop= @malop";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@malop", malop);
            conn.Open();
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count >= 1;
        }

        public DataTable getTalbe(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, connectString);
            da.Fill(dt);
            return dt;
        }

    }
}