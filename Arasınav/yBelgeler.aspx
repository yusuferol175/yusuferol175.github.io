<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim.Master" AutoEventWireup="true" CodeBehind="yBelgeler.aspx.cs" Inherits="Arasınav.yBelgeler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblBlglr" runat="server" Height="200px" Width="100%" Font-Size="25pt"></asp:Label>
    <asp:Button ID="btnDzn" runat="server" OnClick="btnDzn_Click" style="margin-left: 0px" Text="Düzenle" Height="34px" Width="125px" />
    <br />
    <asp:TextBox ID="textYblglr" runat="server" Height="200px" Visible="False" Width="100%"></asp:TextBox>
    <br />
    <asp:Button ID="btnGncl" runat="server" Text="Güncelle" OnClick="btnDzn2_Click" Visible="False" Height="34px" Width="125px" />
    </asp:Content>
