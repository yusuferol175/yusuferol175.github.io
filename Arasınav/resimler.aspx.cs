using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Arasınav
{
    public partial class resimler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["rsmveri"] != null)

            {
                lblRsmlr.Text = Session["rsmveri"].ToString();

            }
            else
            {
                string a = "Bu web sitesinde resimler bölümünde kişisel resimlerim, yaptığım projelerin resimleri bulunmaktadır.";
                lblRsmlr.Text = a;
            }
        }
    }
}