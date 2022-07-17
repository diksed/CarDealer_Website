<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AddCars.aspx.cs" Inherits="CarDealer_Website.AddCars" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server" style="height: 313px">
    <table class="nav-justified">
        <tr>
            <td class="modal-lg" style="height: 22px; width: 141px">Brand :</td>
            <td style="height: 22px">
                <asp:DropDownList ID="combobox" runat="server" Height="30px" Width="177px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="modal-lg" style="width: 141px; height: 22px">Model :</td>
            <td style="height: 22px">
                <asp:TextBox ID="tboxModel" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-lg" style="width: 141px; height: 22px">Photo :</td>
            <td style="height: 22px">
                <asp:TextBox ID="tboxPhoto" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 20px; width: 141px">Fuel Type :</td>
            <td style="height: 20px">
                <asp:TextBox ID="tboxFuel" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-lg" style="width: 141px; height: 20px">Description :</td>
            <td style="height: 20px">
                <asp:TextBox ID="tboxDescription" runat="server" Height="92px" TextMode="MultiLine" Width="177px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-lg" style="height: 20px; width: 141px">Car Dealer :</td>
            <td style="height: 20px">
                <asp:TextBox ID="tboxDealer" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-lg" style="width: 141px; height: 22px">Car Dealer&#39;s Phone :</td>
            <td style="height: 22px">
                <asp:TextBox ID="tboxContact" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-lg" style="width: 141px; height: 72px">Price :</td>
            <td style="height: 72px">
                <asp:TextBox ID="tboxPrice" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="buttonSend" runat="server" Height="50px" OnClick="buttonSend_Click" Text="Submit Advert" Width="147px" />
            </td>
        </tr>
    </table>
</form>
</asp:Content>
