using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace CONGNGHENET
{
    public class KhoaDAO
    {
        string connectString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        public bool addKhoa(khoa kh)
        {
            SqlConnection conn = new SqlConnection(connectString);
            //  khoa kh = new khoa( txtTK.Text,sdt ,txteml.Text);
            string sql = @"INSERT INTO KHOA(TenKhoa, SDT, Email) VALUES (@tenkhoa, @sdt, @email)";
            SqlCommand cmd = new SqlCommand(sql, conn);
             cmd.Parameters.AddWithValue("@tenkhoa", kh.TenKhoa);

            cmd.Parameters.AddWithValue("@sdt", kh.SDT);
           
            cmd.Parameters.AddWithValue("@email", kh.Email);
            conn.Open();
            int dem = cmd.ExecuteNonQuery();
            conn.Close();
            return (dem >= 1);
        }

        public bool editKhoa(khoa mk, string makhoa)
        {
            SqlConnection conn = new SqlConnection(connectString);
            string sql = "update KHOA set TenKhoa= @tenkhoa, SDT = @sodienthoai, Email = @email  Where MaKhoa= @makhoa";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@makhoa", makhoa);
            cmd.Parameters.AddWithValue("@tenkhoa", mk.TenKhoa);
            cmd.Parameters.AddWithValue("@sodienthoai", mk.SDT);
            cmd.Parameters.AddWithValue("@email", mk.Email);
            conn.Open();
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count >= 1;
        }
        public bool deleteKhoa(string makhoa)
        {
            SqlConnection conn = new SqlConnection(connectString);
            string sql = "delete from KHOA where MaKhoa= @makhoa";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@makhoa", makhoa);
            conn.Open();
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count >= 1;
        }
        public DataTable getTable(string sql)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, connectString);
                da.Fill(dt);
                return dt;
            }
        }
}