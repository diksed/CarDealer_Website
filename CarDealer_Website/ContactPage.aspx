<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ContactPage.aspx.cs" Inherits="CarDealer_Website.ContactPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <asp:TextBox ID="tboxName" runat="server" OnTextChanged="TextBox1_TextChanged" ToolTip="Type your name"></asp:TextBox>
    <br />
    <br />
    <asp:TextBox ID="tboxMail" runat="server" ToolTip="Type your mail"></asp:TextBox>
    <br />
    <br />
    <asp:TextBox ID="tboxMessage" runat="server" Height="173px" TextMode="MultiLine" ToolTip="Type your message" Width="449px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnSend" runat="server" Height="38px" OnClick="btnSend_Click" Text="Send Message" Width="127px" />
</form>
</asp:Content>
