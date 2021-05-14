using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Arasınav
{
    public partial class belgeler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["blgveri"] != null)

            {
                lblBlglr.Text = Session["blgveri"].ToString();

            }
            else
            {
                string a = "Bu web sitesinde belgeler bölümünde yaptığım projeler ve sertifikalarımın dökümanları bulunmaktadır.";
                lblBlglr.Text = a;
            }

        }
    }
}