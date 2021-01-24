using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CONGNGHENET
{
    public class DangKi
    {
       
            private string Taikhoan;
            private string Matkhau;
       
            public DangKi(string tk, string mk)
            {
                Taikhoan = tk;
                Matkhau = mk;
            }
            public string taiKhoan { 
                get { return Taikhoan; }
                set { Taikhoan = value; }
            }

            public string matKhau
            {
                get { return Matkhau; }
                set { Matkhau = value; }
            }
            
        
    }
}