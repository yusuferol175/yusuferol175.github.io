using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Arasınav
{
    public partial class yIletisim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["iletisimveri"] != null)
            {
                lblYiletisim.Text = Session["iletisimveri"].ToString();


            }
            else
            {
                string a = "İletişim Bilgilerim" + "<br/>"  + "Telefon numarası: 0 507 906 47 34 " + "<br/>" +
                    "Eposta adresi: yusuferol175@gmail.com  "  + "<br/>" + "İnstagram: yusufer.ol ";
                lblYiletisim.Text = a;
            }
            
           
        }

        protected void btnDzn_Click(object sender, EventArgs e)
        {
            textYiletisim.Text = lblYiletisim.Text;
            textYiletisim.Visible = true;
            lblYiletisim.Visible = false;
            btnGncl.Visible = true;
            btnDzn.Visible = false;
        }

        protected void btnGncl_Click(object sender, EventArgs e)
        {
            lblYiletisim.Text = textYiletisim.Text;
            Session.Add("iletisimveri", textYiletisim.Text);
            textYiletisim.Visible = false;
            lblYiletisim.Visible = true;
            btnGncl.Visible = false;
            btnDzn.Visible = true;
        }

        protected void btnMsj_Click(object sender, EventArgs e)
        {
            if (Session["adsoyad"] == null || Session["konu"] == null || Session["msj"] == null || Session["egtm"] == null || Session["dllr"] == null)
            {
                lblMsjyok.Visible = true;
            }
            else
            {
                lblAdsoyad.Visible = true;
                lblAdsoyad1.Visible = true;
                lblKonu.Visible = true;
                lblKonu1.Visible = true;
                lblMesaj.Visible = true;
                lblMesaj1.Visible = true;
                lblEgtm1.Visible = true;
                lblEgtm.Visible = true;
                lblDllr.Visible = true;
                lblDiller.Visible = true;

                lblAdsoyad.Text = Session["adsoyad"].ToString();
                lblKonu.Text = Session["konu"].ToString();
                lblMesaj.Text = Session["msj"].ToString();
                lblEgtm.Text = Session["egtm"].ToString();
                lblDllr.Text = Session["dllr"].ToString();
            }
            
            
        }
    }
}