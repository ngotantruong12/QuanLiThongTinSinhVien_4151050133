using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CONGNGHENET
{
    public class tinhtrang
    {
        private int maTinhtrang;
        private string tenTinhtrang;
        public tinhtrang(int mtt, string ttt)
        {
            maTinhtrang = mtt;
            tenTinhtrang = ttt;
        }
        public int Matinhtrang
        {
            get { return maTinhtrang; }
            set { maTinhtrang = value; }
        }
        public string Tentinhtrang
        {
            get { return tenTinhtrang; }
            set { tenTinhtrang = value; }
        }
    }
}