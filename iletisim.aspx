<%@ Page Title="" Language="C#" MasterPageFile="~/kullanici.Master" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="Arasınav.iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbliletisim" runat="server" Font-Overline="False" Font-Size="25pt" Font-Strikeout="False" Font-Underline="False" Height="200px" Width="100%"></asp:Label>
    <h1>&nbsp;Bize Mesaj Gönderin</h1>
    
    <h2>Ad Soyad:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="textAdsoyad" runat="server" Width="200px"></asp:TextBox>
    </h2>
    <h2>Konu:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="textKonu" runat="server" Width="200px"></asp:TextBox>
    </h2>
    <h2>Mesaj:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="textMsj" runat="server" Width="400px"></asp:TextBox>
    </h2>
    <h2>Eğitim Durumu:</h2>
    <h2>
        <asp:RadioButtonList ID="rEgtm" runat="server" Width="141px">
            <asp:ListItem>Orta Okul</asp:ListItem>
            <asp:ListItem>Lise</asp:ListItem>
            <asp:ListItem>Üniversite</asp:ListItem>
            <asp:ListItem>Doktora</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="btnGndr" runat="server" Height="34px" OnClick="Button1_Click" style="margin-left: 455px" Text="Gönder" Width="125px" />
        <br />
        Bildiğiniz Diller:<asp:CheckBoxList ID="cIng" runat="server">
            <asp:ListItem>İngilizce</asp:ListItem>
        </asp:CheckBoxList>
        <asp:CheckBoxList ID="cAlm" runat="server">
            <asp:ListItem>Almanca</asp:ListItem>
        </asp:CheckBoxList>
        <asp:CheckBoxList ID="cFrnsz" runat="server">
            <asp:ListItem>Fransızca</asp:ListItem>
        </asp:CheckBoxList>
    </h2>
    </asp:Content>
