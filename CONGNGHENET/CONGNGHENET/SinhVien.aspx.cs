using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CONGNGHENET
{
    public partial class SinhVien : System.Web.UI.Page
    {
        SINHVIENDAO sinhviendao = new SINHVIENDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            grvsinhvien.DataSource = sinhviendao.dataset("select SINHVIEN.MaSV,TenSV,GioiTinh,NgaySinh,SoCMND, SINHVIEN.SDT , TonGiao,QueQuan,KhoaHoc, SINHVIEN.MaTT, TINHTRANG.TinhTrang, SINHVIEN.MaLop,MaGV, LOP.TenLop, NGANH.MaNganh,TenNganh , KHOA.MaKhoa,TenKhoa from SINHVIEN, LOP , NGANH , KhOA, TINHTRANG  where SINHVIEN.MaLop = LOP.MaLop and SINHVIEN.MaTT = TINHTRANG.MaTT and LOP.MaNganh = NGANH.MaNganh and NGANH.MaKhoa = KHOA.MaKhoa ");
          //  grvsinhvien.DataSource = sinhviendao.dataset("select * from SINHVIEN");
            grvsinhvien.DataBind();



        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            // string gt = ddlgioitinh.SelectedValue;
            //int gt = int(ddlgioitinh.SelectedValue);
            //int gt = int.ddlgioitinh.SelectedValue;
            DateTime dt = DateTime.Parse(txtngaysinh.Text);
          //  int gioit = int(ddlgioitinh.SelectedValue);
            int gt = int.Parse(ddlgioitinh.SelectedValue);
            int ml = int.Parse(ddlmalop.SelectedValue);
            int sdt = int.Parse(txtsdt.Text);
            int cmnd = int.Parse(txtcmnd.Text);
            int mgv = int.Parse(ddlmagv.SelectedValue);
            int mtt = Convert.ToInt32(ddlmatinhtrang.SelectedValue);

           // SINHVIEN sv = new SINHVIEN(txttensv.Text, ddlgioitinh.SelectedValue, dt, cmnd, txttongiao.Text, sdt, txtquequan.Text, txtkhoahoc.Text, mtt, ml, mgv);
            SINHVIEN sv = new SINHVIEN(txttensv.Text,gt, dt,cmnd, txttongiao.Text,sdt, txtquequan.Text, txtkhoahoc.Text, mtt, ml, mgv);
            if (sinhviendao.add_SV(sv))
            {
                grvsinhvien.DataSource = sinhviendao.dataset("select SINHVIEN.MaSV,TenSV,GioiTinh,NgaySinh,SoCMND, SINHVIEN.SDT , TonGiao,QueQuan,KhoaHoc, SINHVIEN.MaTT, TINHTRANG.TinhTrang, SINHVIEN.MaLop,MaGV, LOP.TenLop, NGANH.MaNganh,TenNganh , KHOA.MaKhoa,TenKhoa from SINHVIEN, LOP , NGANH , KhOA, TINHTRANG  where SINHVIEN.MaLop = LOP.MaLop and SINHVIEN.MaTT = TINHTRANG.MaTT and LOP.MaNganh = NGANH.MaNganh and NGANH.MaKhoa = KHOA.MaKhoa  ");
                grvsinhvien.DataBind();
                Label1.Text ="DA ADD";
            }
            else
            {
                Label1.Text = "ERROR ADD";
            }
        }

        protected void btnedit_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Parse(txtngaysinh.Text);
            int gt = int.Parse(ddlgioitinh.SelectedValue);
            int ml = int.Parse(ddlmalop.SelectedValue);
            int cmnd = int.Parse(txtcmnd.Text);
            int sdt = int.Parse(txtsdt.Text);
            int mgv = int.Parse(ddlmagv.SelectedValue);
            int mtt = int.Parse(ddlmatinhtrang.SelectedValue);
            SINHVIEN sv = new SINHVIEN(txttensv.Text, gt, dt, cmnd, txttongiao.Text, sdt, txtquequan.Text, txtkhoahoc.Text, mtt, ml, mgv);
            
            if(sinhviendao.edit_SV(sv, txtmasv.Text))
            {
                grvsinhvien.DataSource = sinhviendao.dataset("select SINHVIEN.MaSV,TenSV,GioiTinh,NgaySinh,SoCMND, SINHVIEN.SDT , TonGiao,QueQuan,KhoaHoc, SINHVIEN.MaTT, TINHTRANG.TinhTrang, SINHVIEN.MaLop,MaGV, LOP.TenLop, NGANH.MaNganh,TenNganh , KHOA.MaKhoa,TenKhoa from SINHVIEN, LOP , NGANH , KhOA, TINHTRANG  where SINHVIEN.MaLop = LOP.MaLop and SINHVIEN.MaTT = TINHTRANG.MaTT and LOP.MaNganh = NGANH.MaNganh and NGANH.MaKhoa = KHOA.MaKhoa  ");
                grvsinhvien.DataBind();
                Label1.Text = "DA EDIT";
            }
            else
            {
                Label1.Text = "ERROR EDIT";
            }
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            if (sinhviendao.deletesv(txtmasv.Text))
            {
                Label1.Text = "DELETED";
                grvsinhvien.DataSource = sinhviendao.dataset("select SINHVIEN.MaSV,TenSV,GioiTinh,NgaySinh,SoCMND, SINHVIEN.SDT , TonGiao,QueQuan,KhoaHoc, SINHVIEN.MaTT, TINHTRANG.TinhTrang, SINHVIEN.MaLop,MaGV, LOP.TenLop, NGANH.MaNganh,TenNganh , KHOA.MaKhoa,TenKhoa from SINHVIEN, LOP , NGANH , KhOA, TINHTRANG  where SINHVIEN.MaLop = LOP.MaLop and SINHVIEN.MaTT = TINHTRANG.MaTT and LOP.MaNganh = NGANH.MaNganh and NGANH.MaKhoa = KHOA.MaKhoa  ");
                //  grvsinhvien.DataSource = sinhviendao.dataset("select * from SINHVIEN");
                grvsinhvien.DataBind();
            }
            else
                Label1.Text = "ERROR";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txttensv.Text = "";
            txtngaysinh.Text = "";
            txtcmnd.Text = "";
            txttongiao.Text = "";
            txtsdt.Text = "";
            txtquequan.Text = "";
            txtkhoahoc.Text = "";
            txtmasv.Text = "";
            Label1.Text = "";
        }
    }
}