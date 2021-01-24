using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace CONGNGHENET
{
    public partial class dangki : System.Web.UI.Page
        
    {
        dangkiDao DangKidao = new dangkiDao();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btndangki_Click(object sender, EventArgs e)
        {


            if (DangKidao.check_taikHoan(txttaikhoan.Text))
            {
                Label5.Text = "Tài khoản đã có";

            }
            else
            {  
                DangKi dK = new DangKi(txttaikhoan.Text, txtmatkhau.Text);
                if (DangKidao.add_taikhoan(dK))
                {
                    Label5.Text = "Đã đăng kí";
   
                   
                }
                else
                {
                    Label5.Text = "ERROR ";
                }


            }


        }
    }
}