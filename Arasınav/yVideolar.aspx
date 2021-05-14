<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim.Master" AutoEventWireup="true" CodeBehind="yVideolar.aspx.cs" Inherits="Arasınav.yVideolar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblYvdlr" runat="server" Font-Size="25pt" Height="200px" Width="100%"></asp:Label>
    <asp:Button ID="btnDzn" runat="server" Height="34px" OnClick="btnDzn_Click" Text="Düzenle" Width="125px" />
    <asp:TextBox ID="textVdlr" runat="server" Height="200px" Visible="False" Width="100%"></asp:TextBox>
    <asp:Button ID="btnGncl" runat="server" Height="34px" OnClick="btnGncl_Click" Text="Güncelle" Visible="False" Width="125px" />
</asp:Content>
