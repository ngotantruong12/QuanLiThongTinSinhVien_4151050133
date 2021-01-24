using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CONGNGHENET
{
    public class SINHVIENDAO
    {
        string connectString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

        public bool add_SV (SINHVIEN sv)
        {
            SqlConnection conn = new SqlConnection(connectString);
            string sql = "INSERT INTO SINHVIEN(TenSV, GioiTinh, NgaySinh, SoCMND, TonGiao, SDT, QueQuan, KhoaHoc, MaTT, MaLop,MaGV) VALUES (@ten, @gioitinh, @ngay, @cmnd, @tongiao, @sdt, @quequan, @khoahoc, @matt, @malop, @magv)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ten",sv.TenSV);
            cmd.Parameters.AddWithValue("@gioitinh",sv.GioiTinh);
            cmd.Parameters.AddWithValue("@ngay",sv.NgaySinh);
            cmd.Parameters.AddWithValue("@cmnd",sv.SoCMND);
            cmd.Parameters.AddWithValue("@tongiao",sv.TonGiao);
            cmd.Parameters.AddWithValue("@sdt",sv.SDT);
            cmd.Parameters.AddWithValue("@quequan",sv.QueQuan);
            cmd.Parameters.AddWithValue("@khoahoc",sv.KhoaHoc);
            cmd.Parameters.AddWithValue("@matt",sv.MaTinhTrang);
            cmd.Parameters.AddWithValue("@malop",sv.MaLop);
            cmd.Parameters.AddWithValue("@magv",sv.MaGV);
            conn.Open();
            int dem = cmd.ExecuteNonQuery();
            conn.Close();
            return (dem >= 1);
        }


        public bool edit_SV (SINHVIEN sv, string masv)
        {
            SqlConnection conn = new SqlConnection(connectString);
            string sql = "UPDATE SINHVIEN SET TenSV=@ten , GioiTinh=@gioitinh, NgaySinh=@ngay, SoCMND=@cmnd, TonGiao= @tongiao, SDT=@sdt, QueQuan=@quequan, KhoaHoc=@khoahoc, MaTT= @matt, MaLop= @malop,MaGV=@magv WHERE MaSV= @masv";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@masv", masv);
            cmd.Parameters.AddWithValue("@ten", sv.TenSV);
            cmd.Parameters.AddWithValue("@gioitinh", sv.GioiTinh);
            cmd.Parameters.AddWithValue("@ngay", sv.NgaySinh);
            cmd.Parameters.AddWithValue("@cmnd", sv.SoCMND);
            cmd.Parameters.AddWithValue("@tongiao", sv.TonGiao);
            cmd.Parameters.AddWithValue("@sdt", sv.SDT);
            cmd.Parameters.AddWithValue("@quequan", sv.QueQuan);
            cmd.Parameters.AddWithValue("@khoahoc", sv.KhoaHoc);
            cmd.Parameters.AddWithValue("@matt", sv.MaTinhTrang);
            cmd.Parameters.AddWithValue("@malop", sv.MaLop);
            cmd.Parameters.AddWithValue("@magv", sv.MaGV);
            conn.Open();
            int dem = cmd.ExecuteNonQuery();
            conn.Close();
            return (dem >= 1);
        }




        public bool deletesv(string msv)
        {
            SqlConnection conn = new SqlConnection(connectString);
            string sql = "delete from SINHVIEN where MaSV= @msv";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@msv", msv);
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
        public DataSet dataset (string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connectString);
            DataSet ds = new DataSet("result");
            da.Fill(ds, "result");
            return ds;
        }
    }
}