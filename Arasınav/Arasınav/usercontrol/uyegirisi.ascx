<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uyegirisi.ascx.cs" Inherits="Arasınav.usercontrol.uyegirisi" %>
<asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
    <asp:View ID="View1" runat="server">

        Kullanıcı Adı: <asp:TextBox ID="txtkullanici" runat="server"></asp:TextBox>
        Şifre: <asp:TextBox ID="txtsifre" runat="server"></asp:TextBox>
        <asp:Button ID="btnkaydol" runat="server" Text="Kaydol" OnClick="btnkaydol_Click" />
        
        

        <asp:Button ID="Button2" runat="server" OnClick="btngiris_Click" Text="Giris Yap" />
        
        

    </asp:View>
    <asp:View ID="View2" runat="server">

        Hoş Geldin <asp:Label ID="lblkullaniciad" runat="server" Text=""></asp:Label>
        <asp:Button ID="btncıkıs" runat="server" Text="Çıkış Yap" OnClick="btncıkıs_Click" />
        <asp:Button ID="btnyntm" runat="server" Text="Yönetim Giriş" OnClick="btnyntm_Click" />
    </asp:View>
    
    <asp:View ID="View3" runat="server">
        Yönetim yetkiniz bulunmamaktadır. <asp:Button ID="btngeri" runat="server" Text="Geri dön" OnClick="btngeri_Click" />

        </asp:View>

   

</asp:MultiView>