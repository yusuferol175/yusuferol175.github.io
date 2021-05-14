using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Arasınav
{
    public partial class iletisim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["iletisimveri"] != null)

            {
                lbliletisim.Text = Session["iletisimveri"].ToString();

            }
            else
            {
                string a = "İletişim Bilgilerim:"+ "<br/>"+"<br/>"  + "Telefon numarası: 0 507 906 47 34 " + "<br/>" + "<br/>" +
                    "Eposta adresi: yusuferol175@gmail.com  "+ "<br/>"+ "<br/>"+ "İnstagram: yusufer.ol ";

                lbliletisim.Text = a;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Add("adsoyad", textAdsoyad.Text);
            Session.Add("konu", textKonu.Text);
            Session.Add("msj", textMsj.Text);
            Session.Add("egtm", rEgtm.Text);
            string dıller = "";
            if (cIng.SelectedValue == "İngilizce")
            {

                dıller = cIng.SelectedValue + " " + dıller;

            }
            if (cAlm.SelectedValue == "Almanca")
            {

                dıller = cAlm.SelectedValue + " " + dıller;

            }
            if (cFrnsz.SelectedValue == "Fransızca")
            {

                dıller = cFrnsz.SelectedValue + " " + dıller;

            }

            Session.Add("dllr", dıller);
        }

        
    }
}