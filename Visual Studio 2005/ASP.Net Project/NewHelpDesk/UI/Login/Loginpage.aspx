<%@ Page Language="C#" MasterPageFile="~/UI/Login/Logo.master" AutoEventWireup="true" CodeFile="Loginpage.aspx.cs" Inherits="UI_Login_Default" Title="Login Page " %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    <asp:Button ID="loginbutton" runat="server" Style="position: absolute; left: 467px; top: 230px;" Text="Login" Width="82px" />
    <table style="top:7%; left: 30%; position:absolute; width: 312px; border-left-color: silver; border-bottom-color: silver; border-top-style: ridge; border-top-color: silver; border-right-style: ridge; border-left-style: ridge; border-right-color: silver; border-bottom-style: ridge; height: 48px;">
        <tr>
            <td style="font-weight: bold; color: #ffffff; height: 36px;">Please LogIn : </td>
        </tr>
    </table>    
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
    <table style="top:13%; left: 30%; position:absolute; width: 311px; border-left-color: silver; border-bottom-color: silver; border-top-style: ridge; border-top-color: silver; border-right-style: ridge; border-left-style: ridge; border-right-color: silver; border-bottom-style: ridge; height: 107px;">
        <tr>
            <td style="font-weight: bold; color: #ffffff; border-right: white thin ridge; border-top: white thin ridge; border-left: white thin ridge; width: 124px; border-bottom: white thin ridge; vertical-align: middle; text-align: center;">User Name : </td>
            <td style="border-right: white thin ridge; border-top: white thin ridge; vertical-align: middle; border-left: white thin ridge; width: 187px; border-bottom: white thin ridge; text-align: center">
                <asp:TextBox ID="TextBox1" runat="server" Style="left: 140px; position: absolute;
                    top: 13px" Width="149px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-weight: bold; color: #ffffff; border-right: white thin ridge; border-top: white thin ridge; border-left: white thin ridge; width: 124px; border-bottom: white thin ridge; vertical-align: middle; text-align: center;">Password : </td>
            <td style="border-right: white thin ridge; border-top: white thin ridge; vertical-align: middle; border-left: white thin ridge; width: 187px; border-bottom: white thin ridge; text-align: center">
                <asp:TextBox ID="TextBox2" runat="server" Style="left: 140px; position: absolute;
                    top: 60px" TextMode="Password" Width="148px"></asp:TextBox>
            </td>
        </tr>
    </table>
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
