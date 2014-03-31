<%@ Page Language="C#" MasterPageFile="~/UI/EngFolder/Logo.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="UI_AdminFolder_Default" Title="Change Password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <asp:Label ID="Label1" runat="server" Style="left: 353px; position: absolute; top: 389px"
        Text="Enter Username :" Font-Bold="True" Font-Italic="False" ForeColor="White"></asp:Label>
    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="False" ForeColor="White"
        Style="left: 330px; position: absolute; top: 452px" Text="Enter Old Password :"></asp:Label>
    <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Italic="False" ForeColor="White"
        Style="left: 289px; position: absolute; top: 568px" Text="Re-Confirm New Password :"></asp:Label>
    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="False" ForeColor="White"
        Style="left: 327px; position: absolute; top: 511px" Text="Enter New Password :"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Names="Perpetua Titling MT"
        Font-Size="Medium" ForeColor="Red" ReadOnly="True" Style="left: 232px; top: 263px"
        Width="705px">    Change Password</asp:TextBox><br />
    <br />
    <br />
    <asp:TextBox ID="usernamebox" runat="server" Style="left: 504px; position: absolute;
        top: 386px" Width="140px" TabIndex="1"></asp:TextBox>
    <asp:TextBox ID="oldpassbox1" runat="server" Style="left: 504px; position: absolute;
        top: 448px" TextMode="Password" TabIndex="2"></asp:TextBox>
    <asp:TextBox ID="newpassbox2" runat="server" Style="left: 505px; position: absolute;
        top: 569px" TextMode="Password" TabIndex="4"></asp:TextBox>
    <asp:TextBox ID="newpassbox1" runat="server" Style="left: 506px; position: absolute;
        top: 509px" TextMode="Password" TabIndex="3"></asp:TextBox>
    &nbsp;<br />
    <br />
    <br />
    <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 505px;
        position: absolute; top: 420px" Text="Please Enter User Name" Visible="False"
        Width="178px"></asp:Label>
    <br />
    <br />
    &nbsp;<br />
    <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 506px;
        position: absolute; top: 479px" Text="Please Enter User Name" Visible="False"
        Width="178px"></asp:Label>
    <asp:Label ID="Label9" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 504px;
        position: absolute; top: 541px" Text="Please Enter New Password" Visible="False"
        Width="222px"></asp:Label>
    <br />
    &nbsp;<br />
    <br />
    <asp:Label ID="Label10" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 504px;
        position: absolute; top: 603px" Text="Please Re-Confirm New Password" Visible="False"
        Width="233px"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="Red" Height="12px"
        Style="left: 316px; position: absolute; top: 643px" Text="Please Check If The Re-Confrim Passwords Are Same !!"
        Width="390px" Visible="False"></asp:Label>
    <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="Red" Height="12px"
        Style="left: 316px; position: absolute; top: 673px" Text="Please Enter Correct Username And Password !!"
        Visible="False" Width="390px"></asp:Label>
    &nbsp;
    <br />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Style="left: 418px; position: absolute; top: 699px"
        Text="Change Password !!" />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
