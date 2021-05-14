using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Arasınav
{
    public partial class yHakkimda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["hkkmdveri"] != null)
            {
                lblYhkkmd.Text = Session["hkkmdveri"].ToString();


            }
            else
            {
                string a = "Merhaba ben Yusuf EROL 21 yaşındayım. Burdur Mehmet Akif Üniversitesi Gölhisar Uygulamalı Bilimler" + " " +
                    "Yüksek Okulunda Bilgisayar Teknolojisi Ve Bilişim Sistemleri 2.Sınıf Öğrencisiyim. Bildiğim Diller olarak sadece " + " " +
                   "ingilizce var. Bildiğim ve üzerinde çalıştığım yazılım dilleri ve programlar; c#, html, css, asp.net, c ve unity'dir.";
                lblYhkkmd.Text = a;
            }
        }

        protected void btnDzn_Click(object sender, EventArgs e)
        {
            textYhkkmd.Text = lblYhkkmd.Text;
            textYhkkmd.Visible = true;
            lblYhkkmd.Visible = false;
            btnGncl.Visible = true;
            btnDzn.Visible = false;
        }

        protected void btnGncl_Click(object sender, EventArgs e)
        {
            lblYhkkmd.Text = textYhkkmd.Text;
            Session.Add("hkkmdveri", textYhkkmd.Text);
            textYhkkmd.Visible = false;
            lblYhkkmd.Visible = true;
            btnGncl.Visible = false;
            btnDzn.Visible = true;
        }
    }
}