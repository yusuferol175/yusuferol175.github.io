using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Arasınav.usercontrol
{
    public partial class yonetimusercontrol : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnYanasayfa_Click(object sender, EventArgs e)
        {
            Response.Redirect("yAnasayfasi.aspx");
        }

        protected void btnYbelgeler_Click(object sender, EventArgs e)
        {
            Response.Redirect("yBelgeler.aspx");
        }

        protected void btnYresimler_Click(object sender, EventArgs e)
        {
            Response.Redirect("yResimler.aspx");
        }

        protected void btnYvideolar_Click(object sender, EventArgs e)
        {
            Response.Redirect("yVideolar.aspx");
        }

        protected void btnYhakkimda_Click(object sender, EventArgs e)
        {
            Response.Redirect("yHakkimda.aspx");
        }

        protected void btnYiletisim_Click(object sender, EventArgs e)
        {
            Response.Redirect("yIletisim.aspx");
        }

        protected void btnYanasayfadon_Click(object sender, EventArgs e)
        {
            Response.Redirect("anasayfa.aspx");
        }
    }
}