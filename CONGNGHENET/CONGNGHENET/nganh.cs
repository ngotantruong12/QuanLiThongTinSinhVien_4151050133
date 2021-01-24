using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace CONGNGHENET
{
    public class nganh
    {
        
        private string tenNganh;
        private int maKhoa;
        public nganh(string tn, int mk)
        {
            tenNganh = tn;
            maKhoa = mk;
        }
        public string TenNganh
        {
            get { return tenNganh; }
            set { tenNganh = value; }
        }
        public int MaKhoa
        { 
           get { return maKhoa; }
            set { maKhoa = value; }
        }

    }
}