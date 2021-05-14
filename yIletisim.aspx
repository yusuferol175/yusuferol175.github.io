<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim.Master" AutoEventWireup="true" CodeBehind="yIletisim.aspx.cs" Inherits="Arasınav.yIletisim" ValidateRequest="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblYiletisim" runat="server" Font-Size="25pt" Height="200px" Width="100%"></asp:Label>
<asp:Button ID="btnDzn" runat="server" Height="34px" OnClick="btnDzn_Click" Text="Düzenle" Width="125px" />
<asp:TextBox ID="textYiletisim" runat="server" Height="200px" Visible="False" Width="100%"></asp:TextBox>
<asp:Button ID="btnGncl" runat="server" Height="34px" OnClick="btnGncl_Click" Text="Güncelle" Visible="False" Width="125px" /><br /><br /><br /><br />
    <div class="msjyazi">Kullanıcalardan gelen mesajları görmek için tıklayın:<asp:Button ID="btnMsj" runat="server" Text="Mesajlar" Height="34px" style="margin-left: 2px" Width="125px" OnClick="btnMsj_Click" />
    
        <br />
    <asp:Label ID="lblAdsoyad1" runat="server" Font-Size="25pt" Height="34px" Width="153px" Font-Bold="True" ForeColor="Black" Visible="False">Ad Soyad:</asp:Label>
    <asp:Label ID="lblAdsoyad" runat="server" Font-Size="25pt" Height="34px" Width="300px" Visible="False"></asp:Label>
        <br />
    <asp:Label ID="lblKonu1" runat="server" Font-Size="25pt" Height="34px" Width="137px" Font-Bold="True" ForeColor="Black" Visible="False">Konu:</asp:Label>
    <asp:Label ID="lblKonu" runat="server" Font-Size="25pt" Height="34px" Width="300px" Visible="False"></asp:Label>
        <br />
    <asp:Label ID="lblMesaj1" runat="server" Font-Size="25pt" Height="34px" Width="102px" Font-Bold="True" ForeColor="Black" Visible="False">Mesaj:</asp:Label>
        <br />
    <asp:Label ID="lblMesaj" runat="server" Font-Size="25pt" Height="100px" Width="143%" Visible="False"></asp:Label>
        <br />
    <asp:Label ID="lblEgtm1" runat="server" Font-Size="25pt" Height="34px" Width="264px" Font-Bold="True" ForeColor="Black" Visible="False">Eğitim Durumu:</asp:Label>
    <asp:Label ID="lblEgtm" runat="server" Font-Size="25pt" Height="34px" Width="200px" Visible="False"></asp:Label>
        <br />
    <asp:Label ID="lblDiller" runat="server" Font-Size="25pt" Height="34px" Width="220px" Font-Bold="True" ForeColor="Black" Visible="False">Bildiği Diller:</asp:Label>
        <br />
    <asp:Label ID="lblDllr" runat="server" Font-Size="25pt" Height="70px" Width="131%" Visible="False"></asp:Label>
        <br />
    <asp:Label ID="lblMsjyok" runat="server" Font-Size="25pt" Height="34px" Width="475px" Visible="False">Mesajınız Bulunmamaktadır.</asp:Label>
    </div>
    <br />
    
</asp:Content>
