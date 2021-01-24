using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace CONGNGHENET
{
    public partial class dangnhap : System.Web.UI.Page
    {
      //  DangnhapDao dangNhapDao = new DangnhapDao();
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btndangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RTQ2N2T\SQLEXPRESS;Initial Catalog=KTGK222;Integrated Security=True");

            {
                conn.Open();
                string tk = txttaikhoan.Text;
                string mk = txtmatkhau.Text;
                string sql = "select * from Login where TaiKhoan='" + tk + "' and MatKhau='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    Response.Redirect("TrangChu.aspx");
                }
                else
                {
                    lbthongbao.Text = "Dang nhap that bai";
                }


            }
        }
    }
}