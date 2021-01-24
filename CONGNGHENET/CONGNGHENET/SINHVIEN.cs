using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CONGNGHENET
{
    public class SINHVIEN
    {
        private string ten;
        private int gioitinh;
        private DateTime ngaysinh;
        private int cmnd;
        private string tongiao;
        private int sdt;
        private string quequan;
        private string khoahoc;
        private int matinhtrang;
        private int malop;
        private int magv;

        public SINHVIEN (string tn , int gt, DateTime ns , int cm, string tg, int dt, string qq, string kh, int tt, int ml, int gv)
        {
            ten = tn;
            gioitinh = gt;
            ngaysinh = ns;
            cmnd = cm;
            tongiao = tg;
            sdt = dt;
            quequan = qq;
            khoahoc = kh;
            matinhtrang = tt;
            malop = ml;
            magv = gv;

        }
        public string TenSV
        {
            get { return ten; }
            set { ten = value; }
        }
        public int GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public int SoCMND
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        public string TonGiao
        {
            get { return tongiao; }
            set { tongiao = value; }
        }
        public int SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public string QueQuan
        {
            get { return quequan; }
            set { quequan = value; }
        }
        public string KhoaHoc
        {
            get { return khoahoc; }
            set { khoahoc = value; }
        }
        public int MaTinhTrang
        {
            get { return matinhtrang; }
            set { matinhtrang = value; }
        }
        public int MaLop
        {
            get { return malop; }
            set { malop = value; }
        }
        public int MaGV
        {
            get { return magv; }
            set { magv = value; }
        }
    }

}