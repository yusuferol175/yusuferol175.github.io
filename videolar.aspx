<%@ Page Title="" Language="C#" MasterPageFile="~/kullanici.Master" AutoEventWireup="true" CodeBehind="videolar.aspx.cs" Inherits="Arasınav.videolar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblVdlr" runat="server" Font-Size="25pt" Height="200px" Width="100%"></asp:Label>
  <div class="rsmyazi">Okulda raspberry pi hakkında yaptığım sunumun videosu:
  </div>
    <div class="vid"><video  controls="controls">   <source src="video.mp4" type="video/mp4" />   </video><br /><br /></div><br /><br /><br />
   <div class="rsmyazi"> Pardus İşletim Sistemini ve Virtual Box'ın kurulumunu anlattığım videonun linki:
       <a href="https://www.youtube.com/watch?v=44XPnmjgn2E">https://www.youtube.com/watch?v=44XPnmjgn2E</a>
   </div>
        
</asp:Content>
