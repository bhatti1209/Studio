<%@ Page Language="C#" MasterPageFile="~/UI/AdminFolder/Logo.master" AutoEventWireup="true" CodeFile="VendorRegistration.aspx.cs" Inherits="UI_AdminFolder_Default" Title="Vendor Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Names="Perpetua Titling MT"
        Font-Size="Medium" ForeColor="Red" ReadOnly="True" Style="left: 232px; top: 263px"
        Width="781px">    Vendor Registration</asp:TextBox><br />
    <br />
    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="White" Height="15px"
        Style="left: 228px; position: absolute; top: 361px" Text="Vendor Name :" Width="103px"></asp:Label>
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="White" Style="left: 219px;
        position: absolute; top: 535px" Text="Vendor Address :" Width="122px"></asp:Label>
    <asp:TextBox ID="vennamebox" runat="server" Style="left: 354px; position: absolute;
        top: 360px"></asp:TextBox>
    <asp:TextBox ID="vendoremailbox" runat="server" Style="left: 657px; position: absolute;
        top: 358px"></asp:TextBox>
    <br />
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="White" Style="left: 542px;
        position: absolute; top: 430px" Text="Contact No.2 :" Width="105px"></asp:Label>
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    <br />
    <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="White" Style="left: 232px;
        position: absolute; top: 429px" Text="Contact No.1 :" Width="98px"></asp:Label>
    <asp:TextBox ID="contact1box" runat="server" Style="left: 352px; position: absolute;
        top: 428px"></asp:TextBox>
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp;
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="White" Style="left: 528px;
        position: absolute; top: 361px" Text="Vendor Email Id :" Width="120px"></asp:Label>
    <asp:TextBox ID="contact2box" runat="server" Style="left: 661px; position: absolute;
        top: 429px" Width="144px"></asp:TextBox>
    <br />
    <strong style="left: 333px; color: red; position: absolute; top: 362px">*</strong>
    <br />
    <asp:TextBox ID="vendorlocationbox" runat="server" Height="93px" Style="left: 358px;
        position: absolute; top: 496px" TextMode="MultiLine" Width="459px"></asp:TextBox>
    &nbsp;<br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label17" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 443px;
        position: absolute; top: 615px" Text="Please Enter User Name  !!" Visible="False"
        Width="205px"></asp:Label>
    <br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
    <asp:Button ID="registerbutton" runat="server" OnClick="registerbutton_Click" Style="left: 479px;
        position: absolute; top: 642px" Text="Register" Width="110px" />
    &nbsp;&nbsp;<br />
    <br />
</asp:Content>

