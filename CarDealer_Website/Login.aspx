<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CarDealer_Website.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:TextBox ID="tboxMail" runat="server" Height="30px" TextMode="Email" Width="241px"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="tboxPassword" runat="server" Height="30px" TextMode="Password" Width="241px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnLogin" runat="server" Height="44px" Text="Login" Width="143px" OnClick="btnLogin_Click" />
    </form>
</asp:Content>
