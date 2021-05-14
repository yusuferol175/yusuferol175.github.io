using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace Arasınav
{
    public partial class anasayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            
            if (Session["anasayfa"]!=null)

            {
                lblAnasayfa.Text = Session["anasayfa"].ToString();
                
            }
            else
            {
                string a = "Bu web sitesi Yusuf Erol'un kişisel bilgilerini barındırmak amacıyla Yusuf EROL tarafından 27.04.2021 tarihinde asp.net ile oluşturulmuştur. Sitemizde belgeler, resimler, videolar, hakkımda, iletişim gibi içerikler bulunmaktadır. Yönetim yetkisi bulunan kişiler yönetim giriş yaparak içerikleri düzenleyebilmektedir. Sitemizde keyifli vakitler geçirmenizi temenni ederim. İyi günler. ";
                lblAnasayfa.Text = a;
            }
           
        }
    }
}