using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CONGNGHENET
{
    public partial class Lop : System.Web.UI.Page
    {
        lopDAO lopdao = new lopDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            grvlop.DataSource = lopdao.getTalbe("select * from LOP ");
            grvlop.DataBind();

          //  ddlnganh2.DataSourceID = "SqlDataSourceDDL";

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
           
            // int nganh = int.Parse(ddllop2.Text);
            //  int mn = Convert.ToInt32(ddlnghanh.SelectedValue.ToString());
           int  ddlng = int.Parse(ddlnganh2.SelectedValue);
            //string mn = ddlnghanh.SelectedValue.ToString();
            lop lp = new lop(txtlop.Text, ddlng);
            if (lopdao.addLOP(lp))
            {
                Label1.Text = "DA THEM";
                grvlop.DataSource = lopdao.getTalbe("select * from LOP ");
                grvlop.DataBind();
            }
            else
            {
                Label1.Text = "ERROR Them";
            }
        }

       

       protected void Button2_Click(object sender, EventArgs e)
        {
            int ddlng = int.Parse(ddlnganh2.SelectedValue);
            //string mn = ddlnghanh.SelectedValue.ToString();
            lop lp = new lop(txtlop.Text, ddlng);
            if(lopdao.EditLOP(lp, txtmalop.Text))
            {
                Label1.Text = "DA EDIT";
                grvlop.DataSource = lopdao.getTalbe("select * from LOP ");
                grvlop.DataBind();

            }
            else
            {
                Label1.Text = "ERROR EDIT";
            }
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            if (lopdao.deleteLOP(txtmalop.Text))
            {
                Label1.Text = "DA DELETE";
                grvlop.DataSource = lopdao.getTalbe("select * from LOP");
                Page.DataBind();
            }
            else
                Label1.Text = "ERROR DELETE";
        }

        protected void btnempty_Click(object sender, EventArgs e)
        {
            txtmalop.Text = "";
            txtlop.Text = "";
            Label1.Text = "";
            Label1.Text = "";
        }

    }
}