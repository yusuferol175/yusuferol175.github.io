using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Arasınav
{
    public partial class yResimler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["rsmveri"] != null)
            {
                lblYrsmlr.Text = Session["rsmveri"].ToString();


            }
            else
            {
                string a = "Bu web sitesinde resimler bölümünde kişisel resimlerim, yaptığım projelerin resimleri bulunmaktadır. ";
                lblYrsmlr.Text = a;
            }
        }

        protected void btnDzn_Click(object sender, EventArgs e)
        {
            textRsmlr.Text = lblYrsmlr.Text;
            textRsmlr.Visible = true;
            lblYrsmlr.Visible = false;
            btnGncl.Visible = true;
            btnDzn.Visible = false;
        }

        protected void btnGncl_Click(object sender, EventArgs e)
        {
            lblYrsmlr.Text = textRsmlr.Text;
            Session.Add("rsmveri", textRsmlr.Text);
            textRsmlr.Visible = false;
            lblYrsmlr.Visible = true;
            btnGncl.Visible = false;
            btnDzn.Visible = true;

        }
    }
}