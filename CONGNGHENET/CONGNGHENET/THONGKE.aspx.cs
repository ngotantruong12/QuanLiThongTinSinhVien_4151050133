using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CONGNGHENET
{
    public partial class THONGKE : System.Web.UI.Page
    {
        thke tk = new thke();
        protected void Page_Load(object sender, EventArgs e)
        {
            grvthongke.DataSource = tk.dataset("select LOP.MaLop, TenLop, TINHTRANG.TinhTrang, count(*) as SoLuong from SINHVIEN , LOP, TINHTRANG where SINHVIEN.MaLop = LOP.MaLop and SINHVIEN.MaTT = TINHTRANG.MaTT group by  LOP.MaLop, TenLop, TINHTRANG.TinhTrang order by MaLop desc");
            grvthongke.DataBind();
        }
    }
}