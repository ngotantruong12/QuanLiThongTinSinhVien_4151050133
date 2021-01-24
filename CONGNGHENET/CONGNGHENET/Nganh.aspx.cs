using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CONGNGHENET
{
    public partial class Nganh : System.Web.UI.Page
    {
        NGANHDAO nGANHDAO = new NGANHDAO(); // tạo 1 đối tượng tên ...... để lấy các hàm add edit deelete bên NGANHDAO
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grvNganh.DataSource = nGANHDAO.getTable("select * from NGANH"); // load grv
                DDLMaKhoa.DataSource = nGANHDAO.getTable("select * from KHOA"); // load ddl
                DDLMaKhoa.DataTextField = "TenKhoa"; // hiển thi tên các khoa lên ddl
                DDLMaKhoa.DataValueField = "MaKhoa"; // giá trị của ddl

                Page.DataBind();

            }

        }

        protected void BtnADD_Click(object sender, EventArgs e)
        {
            //string mn = DDLMaKhoa.SelectedValue;
            int khoa = int.Parse(DDLMaKhoa.SelectedValue);
            //tạo 1 biến tên khoa có kiểu là int,  ép kiểu ddlmakhoa kiểu string thanh kiểu int
            nganh ng = new nganh(txtnganh.Text, khoa);
            if (nGANHDAO.ADDNganh(ng))
            {
                grvNganh.DataSource = nGANHDAO.getTable("select * from NGANH");
                grvNganh.DataBind();
                // khi them thanh công thì load lại grview và thông báo
                lbthongbao.Text = "DA ADD";
            }
            else
            {
                lbthongbao.Text = "ERROR ADD";
            }

        }

        protected void BtnDl_Click(object sender, EventArgs e)
        {
            int nganh = int.Parse(DDLMaKhoa.SelectedValue);
            if (nGANHDAO.DELETEnganh(txtmanganh.Text))
            {
                grvNganh.DataSource = nGANHDAO.getTable("select * from NGANH");
                grvNganh.DataBind();
                lbthongbao.Text = "DA DELETE";
            }
            else
            {
                lbthongbao.Text = "ERROR DELETE";
            }
        }

        protected void btnedit_Click(object sender, EventArgs e)
        {

            int khoa = int.Parse(DDLMaKhoa.SelectedValue);
            nganh lp = new nganh(txtnganh.Text, khoa);
            if (nGANHDAO.EditNGANH(lp, txtmanganh.Text))
            {
                grvNganh.DataSource = nGANHDAO.getTable("select * from NGANH");
                grvNganh.DataBind();
                lbthongbao.Text = "DA EDIT";



            }
            else
            {
                lbthongbao.Text = "ERORR EDIT ";
                
            }


        }

        protected void btnempty_Click(object sender, EventArgs e)
        {
            txtmanganh.Text = "";
            txtnganh.Text = "";
            lbthongbao.Text = "";
        }
    }
}