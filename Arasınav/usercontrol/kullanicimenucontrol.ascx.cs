using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Arasınav.usercontrol
{
    public partial class kullanicimenucontrol : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Response.Redirect("anasayfa.aspx");
        }

        protected void btnBelgeler_Click(object sender, EventArgs e)
        {
            Response.Redirect("belgeler.aspx");
        }

        protected void btnResimler_Click(object sender, EventArgs e)
        {
            Response.Redirect("resimler.aspx");
        }

        protected void btnVideolar_Click(object sender, EventArgs e)
        {
            Response.Redirect("videolar.aspx");
        }

        protected void btnHakkimda_Click(object sender, EventArgs e)
        {
            Response.Redirect("hakkimda.aspx");
        }

        protected void btnIletisim_Click(object sender, EventArgs e)
        {
            Response.Redirect("iletisim.aspx");
        }
    }
}