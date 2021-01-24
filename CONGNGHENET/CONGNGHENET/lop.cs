using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CONGNGHENET
{
    public class lop
    {
        private string tenlop;
         private int manganh;
        //private string manganh;
        public lop ( string tl, int mk)
        {
            tenlop = tl ;
             manganh = mk;
        }

        
        public string TenLop
        {
            get { return tenlop; }
            set { tenlop = value; }
        }
        
        public int MaNganh
        {
            get { return manganh; }
            set { manganh = value; }
        } 
       /* public string MaNganh
        {
            get { return manganh; }
            set { manganh = value; }
        } */
    }
}