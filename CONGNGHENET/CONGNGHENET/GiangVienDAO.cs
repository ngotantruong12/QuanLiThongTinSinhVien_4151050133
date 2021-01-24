using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CONGNGHENET
{
    public class GiangVienDAO
    {
        string connectString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        public bool ADDGIANGVIEN( string tengv, int gioitinh, string email, int sdt)
        {
            SqlConnection connection = new SqlConnection(connectString);
            string sql = @"insert into GIANGVIEN (TenGV, GioiTinh, Email, SDT) values(@tengv, @gt, @email, @sdt)";
            SqlCommand command = new SqlCommand(sql ,connection);
            command.Parameters.AddWithValue("@tengv", tengv);
            command.Parameters.AddWithValue("@gt", gioitinh );
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@sdt", sdt);
            // command.Parameters.AddWithValue("@makh", nh.MaKhoa);
            connection.Open();
            int count = command.ExecuteNonQuery();
            connection.Close();
            return (count >= 1);
        }
        public bool EditGIANGVIEN(string magiangvien, string tengv, int gioitinh, string email, int sdt)
        {
            SqlConnection conn = new SqlConnection(connectString);
            string sql = @"UPDATE GIANGVIEN SET TenGV = @tengv, GioiTinh =@gt, Email = @email, SDT= @sdt WHERE MaGV= @magv";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@gt", gioitinh);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Parameters.AddWithValue("@tengv", tengv);
            cmd.Parameters.AddWithValue("@magv", magiangvien);

            conn.Open();
            int dem = cmd.ExecuteNonQuery();
            conn.Close();
            return (dem >= 1);
        }
        public bool DELETEGIANGVIEN(string magiangvien)
        {
            SqlConnection conn = new SqlConnection(connectString);
            string sql = "delete from GIANGVIEN where MaGV = @magv";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@magv", magiangvien);
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
