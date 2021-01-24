using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CONGNGHENET
{
    public class dangkiDao
    {
        string connectString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        public bool add_taikhoan(DangKi dk)
        {
            SqlConnection conn = new SqlConnection(connectString);
            string sql = @"insert into Login(TaiKhoan,MatKhau) values (@taik,@matK)";
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.Parameters.AddWithValue("@taik",dk.taiKhoan);

            cmd.Parameters.AddWithValue("@matk",dk.matKhau);
            conn.Open();
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return (count >= 1);

        }
        public bool check_taikHoan(string taikHoan)
        {
            SqlConnection conn = new SqlConnection(connectString);
            string sql = "select count (*) from Login where TaiKhoan= @taikhoan";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@taikhoan", taikHoan);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count >= 1;
        }
    }
}