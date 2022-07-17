<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CarDealer_Website.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:TextBox ID="tboxMail" runat="server" Height="30px" TextMode="Email" Width="241px"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="tboxPassword" runat="server" Height="30px" TextMode="Password" Width="241px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnRegister" runat="server" Height="44px" OnClick="btnRegister_Click" Text="Register" Width="143px" />
    </form>
</asp:Content>
