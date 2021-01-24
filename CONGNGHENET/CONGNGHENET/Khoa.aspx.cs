using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CONGNGHENET
{
    public partial class Khoa : System.Web.UI.Page
    {
        KhoaDAO khoadao = new KhoaDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            gvKhoa.DataSource = khoadao.getTable("select * from KHOA");
            DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        { 
            int sdt = int.Parse(txtSDT.Text.ToString());
            khoa kh = new khoa( txtTK.Text,sdt ,txteml.Text);
            if (khoadao.addKhoa(kh))
            {
                lblTB.Text = "Successfully";
                gvKhoa.DataSource = khoadao.getTable("select * from KHOA");
                Page.DataBind();
            }
            else
            {
                lblTB.Text = "Failed ";

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int SDT = int.Parse(txtSDT.Text);
            khoa kh = new khoa(txtTK.Text, SDT, txteml.Text);
            if (khoadao.editKhoa(kh, txtMK.Text))
            {
                lblTB.Text = "Đã EDIT";
                gvKhoa.DataSource = khoadao.getTable("select * from KHOA");
                gvKhoa.DataBind();
            }
            else
            {
                lblTB.Text = "ERROR";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if(khoadao.deleteKhoa(txtMK.Text))
             { 
                lblTB.Text = "DELETED";
                gvKhoa.DataSource = khoadao.getTable("select * from KHOA");
                DataBind();
            }
            else
            {
                lblTB.Text = "ERROR";
            }    
        }

        protected void btnEty_Click(object sender, EventArgs e)
        {
            txtMK.Text = "";
            txtSDT.Text = "";
            txtTK.Text = "";
            txteml.Text = "";
            lblTB.Text = "";
        }
    }
}
        
