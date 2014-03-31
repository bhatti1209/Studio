<%@ Page Language="C#" MasterPageFile="~/UI/AdminFolder/Logo.master" AutoEventWireup="true" CodeFile="RegistrationMainPage.aspx.cs" Inherits="UI_AdminFolder_Default" Title="Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Names="Perpetua Titling MT"
        Font-Size="Medium" ForeColor="Red" ReadOnly="True" Style="left: 232px; top: 263px"
        Width="705px">    Registration</asp:TextBox><br />
    <br />
    <br />
    <br />
    <br />
    <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="False" ForeColor="White"
        Style="left: 443px; position: absolute; top: 394px" Width="152px" PostBackUrl="~/UI/AdminFolder/VendorRegistration.aspx">Vendor Registration</asp:LinkButton>
    <asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="False" ForeColor="White"
        Style="left: 446px; position: absolute; top: 461px" Width="143px" PostBackUrl="~/UI/AdminFolder/Siteregistration.aspx">Site  Registration</asp:LinkButton>
    <asp:LinkButton ID="LinkButton3" runat="server" Font-Bold="False" ForeColor="White"
        Style="left: 444px; position: absolute; top: 527px" Width="147px" PostBackUrl="~/UI/AdminFolder/UserRegistration.aspx">User Registration</asp:LinkButton>
    <br />
    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="White" Style="left: 427px;
        position: absolute; top: 322px" Text="Please Select An Option" Width="175px"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

