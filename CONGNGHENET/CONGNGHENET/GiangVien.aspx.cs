using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CONGNGHENET
{
    public partial class GiangVien : System.Web.UI.Page
    {
        GiangVienDAO giangVienDAO = new GiangVienDAO();
        protected void Page_Load(object sender, EventArgs e)
        {

            grvGiangVien.DataSource = giangVienDAO.getTable("select * from GIANGVIEN");
            grvGiangVien.DataBind();
        }

        protected void btnADD_Click(object sender, EventArgs e)
        {

            int gt = int.Parse(ddlgioitinh.SelectedValue);
            int sdt = int.Parse(txtsdt.Text);
            if (giangVienDAO.ADDGIANGVIEN(txtten.Text, gt, txtemail.Text, sdt)) 
            {
                grvGiangVien.DataSource = giangVienDAO.getTable("select * from GIANGVIEN");
                grvGiangVien.DataBind();
                // khi them thanh công thì load lại grview và thông báo
                lblthongbao.Text = "DA ADD";
            }
            else
            {
                lblthongbao.Text = "ERROR ADD";
            }    
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (giangVienDAO.DELETEGIANGVIEN(txtmagv.Text))
            {
                grvGiangVien.DataSource = giangVienDAO.getTable("select * from GIANGVIEN");
                grvGiangVien.DataBind();
                lblthongbao.Text = "DA DELETE";
            }
            else
            {
                lblthongbao.Text = "ERROR DELETE";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            int gt = int.Parse(ddlgioitinh.SelectedValue);
            int sdt = int.Parse(txtsdt.Text);
            if (giangVienDAO.EditGIANGVIEN(txtmagv.Text, txtten.Text, gt, txtemail.Text, sdt))
            {
                grvGiangVien.DataSource = giangVienDAO.getTable("select * from GIANGVIEN");
                grvGiangVien.DataBind();
                lblthongbao.Text = "DA EDIT";
            }
            else
            {
                lblthongbao.Text = "ERROR EDIT";
            }
        }

        protected void btnEMTY_Click(object sender, EventArgs e)
        {
            txtten.Text = "";
            txtmagv.Text = "";
            txtemail.Text = "";
            txtsdt.Text = "";
        }

        
    }
}