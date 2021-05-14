using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Arasınav
{
    public partial class yVideolar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["vdveri"] != null)
            {
                lblYvdlr.Text = Session["vdveri"].ToString();


            }
            else
            {
                string a = "Bu web sitesinde videolar bölümünde projelerimin ve sunumlarımın videoları bulunmaktadır. ";
                lblYvdlr.Text = a;
            }
        }

        protected void btnDzn_Click(object sender, EventArgs e)
        {
            textVdlr.Text = lblYvdlr.Text;
            textVdlr.Visible = true;
            lblYvdlr.Visible = false;
            btnGncl.Visible = true;
            btnDzn.Visible = false;
        }

        protected void btnGncl_Click(object sender, EventArgs e)
        {
            lblYvdlr.Text = textVdlr.Text;
            Session.Add("vdveri", textVdlr.Text);
            textVdlr.Visible = false;
            lblYvdlr.Visible = true;
            btnGncl.Visible = false;
            btnDzn.Visible = true;
        }
    }
}