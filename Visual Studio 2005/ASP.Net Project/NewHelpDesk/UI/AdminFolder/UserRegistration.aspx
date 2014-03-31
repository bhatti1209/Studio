<%@ Page Language="C#" MasterPageFile="~/UI/AdminFolder/Logo.master" AutoEventWireup="true" CodeFile="UserRegistration.aspx.cs" Inherits="UI_AdminFolder_Default" Title="User Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Names="Perpetua Titling MT"
        Font-Size="Medium" ForeColor="Red" ReadOnly="True" Style="left: 232px; top: 263px"
        Width="781px">    User Registration</asp:TextBox><br />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="White" Style="left: 281px;
        position: absolute; top: 375px" Text="User Name :" Width="93px"></asp:Label>
    <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="White" Style="left: 613px;
        position: absolute; top: 562px" Text="User Site Id  :" Width="93px"></asp:Label>
    &nbsp;
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="White" Style="left: 273px;
        position: absolute; top: 436px" Text="User Mail Id :" Width="99px"></asp:Label>
    <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="White" Style="left: 576px;
        position: absolute; top: 435px" Text="User  Department :" Width="129px"></asp:Label>
    <asp:TextBox ID="usernamebox" runat="server" Style="left: 392px; position: absolute;
        top: 373px"></asp:TextBox>
    <asp:TextBox ID="userloginidbox" runat="server" Style="left: 734px; position: absolute;
        top: 375px"></asp:TextBox>
    <asp:TextBox ID="userdepartmentbox" runat="server" Style="left: 733px; position: absolute;
        top: 432px"></asp:TextBox>
    <asp:TextBox ID="usersiteidbox" runat="server" Style="left: 734px; position: absolute;
        top: 556px"></asp:TextBox>
    &nbsp;<br />
    <asp:TextBox ID="usermailidbox" runat="server" Style="left: 393px;
        position: absolute; top: 434px"></asp:TextBox>
    <br />
    <asp:Label ID="Label12" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 375px;
        position: absolute; top: 375px" Text="*" Width="9px"></asp:Label>
    <asp:Label ID="Label13" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 707px;
        position: absolute; top: 378px" Text="*" Width="9px"></asp:Label>
    <asp:Label ID="Label14" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 708px;
        position: absolute; top: 501px" Text="*" Width="9px"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="White" Style="left: 275px;
        position: absolute; top: 558px" Text="User DOB  :" Width="93px"></asp:Label>
    <asp:TextBox ID="dob1" runat="server" Style="left: 396px; position: absolute;
        top: 557px" Width="29px"></asp:TextBox>
    <asp:TextBox ID="dob2" runat="server" Style="left: 440px; position: absolute;
        top: 557px" Width="30px"></asp:TextBox>
    <asp:TextBox ID="dob3" runat="server" Style="left: 484px; position: absolute;
        top: 557px" Width="58px"></asp:TextBox>
    <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="White" Style="left: 243px;
        position: absolute; top: 500px" Text="User Contact No.  :" Width="128px"></asp:Label>
    <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="White" Style="left: 597px;
        position: absolute; top: 378px" Text="User Login Id :" Width="109px"></asp:Label>
    <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="White" Style="left: 586px;
        position: absolute; top: 500px" Text="User Login Type  :" Width="121px"></asp:Label>
    <br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
    <br />
    <br />
    <br />
    <asp:TextBox ID="usercontactnobox" runat="server" Style="left: 394px; position: absolute;
        top: 497px"></asp:TextBox>
    &nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" Style="left: 734px; position: absolute;
        top: 499px" Width="155px">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>Administrator</asp:ListItem>
        <asp:ListItem>IT-Engineer</asp:ListItem>
        <asp:ListItem>User</asp:ListItem>
    </asp:DropDownList>
    <br />
    &nbsp;<br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label9" runat="server" ForeColor="White" Style="left: 399px; position: absolute;
        top: 590px" Text="( DD / MM / YYYY )" Width="138px"></asp:Label>
    &nbsp;<br />
    <br />
    <asp:Button ID="Button1" runat="server" Style="left: 537px; position: absolute; top: 664px"
        Text="Register User" Width="103px" />
    <br />
    <br />
    <asp:Label ID="Label10" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 303px;
        position: absolute; top: 632px" Text="Please Enter Username !!" Visible="False"
        Width="174px"></asp:Label>
    <asp:Label ID="Label15" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 723px;
        position: absolute; top: 631px" Text="Please Select Login Type !!" Visible="False"
        Width="202px"></asp:Label>
    <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 519px;
        position: absolute; top: 632px" Text="Please Enter Login ID !!" Visible="False"
        Width="174px"></asp:Label>
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
