using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CONGNGHENET
{
    public class khoa
    {
        private string tenkhoa;
        private int sodienthoai;
        private string email;
        public khoa(string tk, int sdt, string eml)
        {
            tenkhoa = tk;
            sodienthoai = sdt;
            email = eml;
        }
        public string TenKhoa
        {
            get { return tenkhoa; }
            set { tenkhoa = value; }
        }
        public int SDT
        {
            get { return sodienthoai; }
            set { sodienthoai = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}