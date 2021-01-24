using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CONGNGHENET
{
    public class NGANHDAO
    {
        string connectString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;



        public bool ADDNganh(nganh nh)
        {
            SqlConnection connection = new SqlConnection(connectString);
            string sql = @"insert into NGANH (TenNganh, MaKhoa) values(@tenng ,@makh)";

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@tenng", nh.TenNganh);
            command.Parameters.AddWithValue("@makh", nh.MaKhoa);
            connection.Open();
            int count = command.ExecuteNonQuery();
            connection.Close();
            return (count >= 1);
        }
            public bool EditNGANH(nganh nh , string manganh)
            {
                SqlConnection conn = new SqlConnection(connectString);
            string sql = @"UPDATE NGANH SET TenNganh = @tennganh, MaKhoa= @makhoa WHERE MaNganh= @manganh";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tennganh", nh.TenNganh);
                cmd.Parameters.AddWithValue("@makhoa", nh.MaKhoa);
            cmd.Parameters.AddWithValue("@manganh", manganh);
                
                conn.Open();
                int dem = cmd.ExecuteNonQuery();
                conn.Close();
                return (dem >= 1);
            }

            public bool DELETEnganh( string manganh) // xóa là cần mã
            {
                SqlConnection conn = new SqlConnection(connectString);
                string sql = "delete from NGANH where MaNganh= @mang";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@mang", manganh);
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



