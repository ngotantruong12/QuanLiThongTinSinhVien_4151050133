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
    public partial class TinhTrang : System.Web.UI.Page
    {
        tinhtrangDau TinhTrangdau = new tinhtrangDau();
        protected void Page_Load(object sender, EventArgs e)
        {

            grvtinhtrang.DataSource = TinhTrangdau.getTalbe("select * from TINHTRANG ");     
            Page.DataBind();
        }

        protected void btnthem_Click(object sender, EventArgs e)
        {

            if(TinhTrangdau.check_Matt(txtmaTrang.Text))
            {
                Label4.Text = "Trung MA. vui long nhap MA khac";

            }
            else
            {
                int matt = int.Parse(txtmaTrang.Text.ToString());
                tinhtrang TT = new tinhtrang(matt, txttenTrang.Text);
                if (TinhTrangdau.add_Tinhtrang(TT))
                {
                    Label4.Text = "DA ADD";
                    grvtinhtrang.DataSource = TinhTrangdau.getTalbe("select * from TINHTRANG ");
                    Page.DataBind();
                }
                else
                {
                    Label4.Text = "ERROR ADD";
                }
            }


        }

        protected void btnxoa_Click(object sender, EventArgs e)
        {
            if (TinhTrangdau.delete_MA(txtmaTrang.Text))
            {
                Label4.Text = "DELETED";
                grvtinhtrang.DataSource = TinhTrangdau.getTalbe("select * from TINHTRANG ");
                Page.DataBind();
            }
            else Label4.Text = "NO DELETE";
        }

        protected void btnsua_Click(object sender, EventArgs e)
        {
            int matt = int.Parse(txtmaTrang.Text.ToString());
            tinhtrang TT = new tinhtrang(matt, txttenTrang.Text);
            if (TinhTrangdau.edit_MA(TT))
            {
                Label4.Text = "EDIT SUCCESS";
                grvtinhtrang.DataSource = TinhTrangdau.getTalbe("select * from TINHTRANG ");
                Page.DataBind();
            }
            else Label4.Text = " ERROR EDIT";
        }

        protected void btnET_Click(object sender, EventArgs e)
        {
            txtmaTrang.Text = "";
            txttenTrang.Text = "";
            Label4.Text = "";
        }

       
    }
}