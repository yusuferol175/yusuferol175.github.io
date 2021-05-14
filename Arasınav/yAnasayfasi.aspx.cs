using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Arasınav
{
    public partial class yAnasayfasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["anasayfa"]!=null)
            {
                lblYanasayfa.Text = Session["anasayfa"].ToString();
                
            }
            else
            {
                string a = "Bu web sitesi Yusuf Erol'un kişisel bilgilerini barındırmak amacıyla Yusuf EROL tarafından 27.04.2021 tarihinde asp.net ile oluşturulmuştur. Sitemizde belgeler, resimler, videolar, hakkımda, iletişim gibi içerikler bulunmaktadır. Yönetim yetkisi bulunan kişiler yönetim giriş yaparak içerikleri düzenleyebilmektedir. Sitemizde keyifli vakitler geçirmenizi temenni ederim. İyi günler. ";
            lblYanasayfa.Text = a;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            txtAnasayfa.Text = lblYanasayfa.Text;
            txtAnasayfa.Visible = true;
            lblYanasayfa.Visible = false;
            btnGncll.Visible = true;
            btnDuzen.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            lblYanasayfa.Text = txtAnasayfa.Text;
            Session.Add("anasayfa", txtAnasayfa.Text);
            txtAnasayfa.Visible = false;
            lblYanasayfa.Visible = true;
            btnGncll.Visible = false;
            btnDuzen.Visible = true;
           
        }
    }
}