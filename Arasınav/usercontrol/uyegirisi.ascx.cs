using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Arasınav.usercontrol
{
    public partial class uyegirisi : System.Web.UI.UserControl
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["kullanıcı"] != null)
            {
                MultiView1.ActiveViewIndex = 1;
                lblkullaniciad.Text = Session["kullanıcı"].ToString();
            }
        }

        protected void btngiris_Click(object sender, EventArgs e)
        {
            
            lblkullaniciad.Text = txtkullanici.Text;
            if (Session["kullanıcı"] == null)
            {
                MultiView1.ActiveViewIndex = 0;
            }
            else if (Session["kullanıcı"].ToString()==txtkullanici.Text)
            {
                
                MultiView1.ActiveViewIndex = 1;
            }
        }

        protected void btncıkıs_Click(object sender, EventArgs e)
        {
            
            Session.Remove("kullanıcı");
            MultiView1.ActiveViewIndex = 0;
            Response.Redirect("anasayfa.aspx");

        }

        protected void btnkaydol_Click(object sender, EventArgs e)
        {
            

            if (txtkullanici.Text==null && txtkullanici.Text=="" && txtsifre.Text==null && txtsifre.Text=="")
            {
                MultiView1.ActiveViewIndex = 0;
            }
            else if(txtkullanici.Text!=null && txtkullanici.Text != "" && txtsifre.Text != null && txtsifre.Text != "")
            {
                Session["kullanıcı"] = txtkullanici.Text;
                Session["sifre"] = txtsifre.Text;
                MultiView1.ActiveViewIndex = 0;

            }
            
        }

        protected void btnyntm_Click(object sender, EventArgs e)
        {
            
            string[] yKllncad = new string[] {"Kamil","Yusuf"};
            string[] ySifre = new string[] { "Özcan", "Erol" };
        
            for (int i = 0; i < yKllncad.Length; i++)
            {
                if (yKllncad[i] == Session["kullanıcı"].ToString() && ySifre[i] == Session["sifre"].ToString())
                {
                   
                    Response.Redirect("yAnasayfasi.aspx");
                    
                    
                }
                else
                {
                    MultiView1.ActiveViewIndex = 2;
                }
               
            }
             

        }

        protected void btngeri_Click(object sender, EventArgs e)
        {
            Response.Redirect("anasayfa.aspx");
            MultiView1.ActiveViewIndex = 1;
        }

       
    }
}