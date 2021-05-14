<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim.Master" AutoEventWireup="true" CodeBehind="yAnasayfasi.aspx.cs" Inherits="Arasınav.yAnasayfasi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblYanasayfa" runat="server" Height="300px" Width="100%" Font-Size="25pt"></asp:Label><br />
    <asp:TextBox ID="txtAnasayfa" runat="server" Visible="False" Height="300px" Width="100%"></asp:TextBox><br />
<asp:Button ID="btnDuzen" runat="server" OnClick="Button1_Click" Text="Düzenle" Height="34px" Width="125px" />
<asp:Button ID="btnGncll" runat="server" OnClick="Button2_Click" Text="Güncelle" Visible="False" Height="34px" Width="125px" />
    
</asp:Content>
    