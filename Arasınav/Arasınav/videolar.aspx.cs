using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Arasınav
{
    public partial class videolar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["vdveri"] != null)

            {
                lblVdlr.Text = Session["vdveri"].ToString();

            }
            else
            {
                string a = "Bu web sitesinde videolar bölümünde projelerimin ve sunumlarımın videoları bulunmaktadır.";
                lblVdlr.Text = a;
            }
        }
    }
}