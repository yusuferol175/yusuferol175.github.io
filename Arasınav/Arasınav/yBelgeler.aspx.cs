using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace Arasınav
{
    public partial class yBelgeler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["blgveri"] != null)
            {
                lblBlglr.Text = Session["blgveri"].ToString();
                

            }
            else
            {
                string a= "Bu web sitesinde belgeler bölümünde yaptığım projeler ve sertifikalarımın dökümanları bulunmaktadır.";
                lblBlglr.Text = a;
            }
           
        }

        

        protected void btnDzn_Click(object sender, EventArgs e)
        {
            textYblglr.Text = lblBlglr.Text;
            textYblglr.Visible = true;
            lblBlglr.Visible = false;
            btnGncl.Visible = true;
            btnDzn.Visible = false;

        }

        protected void btnDzn2_Click(object sender, EventArgs e)
        {
            lblBlglr.Text = textYblglr.Text;
            Session.Add("blgveri", textYblglr.Text);
            textYblglr.Visible = false;
            lblBlglr.Visible = true;
            btnGncl.Visible = false;
            btnDzn.Visible = true;
           

            
        }
    }
}