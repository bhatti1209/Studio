<%@ Page Language="C#" MasterPageFile="~/UI/AdminFolder/Logo.master" AutoEventWireup="true" CodeFile="Siteregistration.aspx.cs" Inherits="UI_AdminFolder_Default" Title="Site Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Names="Perpetua Titling MT"
        Font-Size="Medium" ForeColor="Red" ReadOnly="True" Style="left: 232px; top: 263px"
        Width="781px">    Site Registration</asp:TextBox><br />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="White" Style="left: 275px;
        position: absolute; top: 351px" Text="Location Code :"></asp:Label>
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="White" Style="left: 669px;
        position: absolute; top: 349px" Text="Site Name :" Width="90px"></asp:Label>
    <asp:TextBox ID="locationcodebox" runat="server" Style="left: 394px; position: absolute;
        top: 348px"></asp:TextBox>
    <asp:TextBox ID="personnamebox" runat="server" Style="left: 235px; position: absolute;
        top: 610px"></asp:TextBox>
    <asp:TextBox ID="personphonebox" runat="server" Style="left: 455px; position: absolute;
        top: 611px" Width="195px"></asp:TextBox>
    <asp:TextBox ID="sitenamebox" runat="server" Style="left: 758px; position: absolute;
        top: 347px"></asp:TextBox>
    <asp:TextBox ID="locationbox" runat="server" Style="left: 394px; position: absolute;
        top: 411px"></asp:TextBox>
    &nbsp;<br />
    <br />
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server" Style="left: 758px; position: absolute;
        top: 411px" Width="157px">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>Dump Yard Office</asp:ListItem>
        <asp:ListItem>Compression Station Office</asp:ListItem>
        <asp:ListItem>Spread Office</asp:ListItem>
        <asp:ListItem>Near Port Warehouse Office</asp:ListItem>
        <asp:ListItem>Closed Warehouse Office</asp:ListItem>
    </asp:DropDownList>
    <br />
    &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="White" Style="left: 310px;
        position: absolute; top: 413px" Text="Location :"></asp:Label>
    <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="White" Style="left: 640px;
        position: absolute; top: 414px" Text="Type Of Office :" Width="115px"></asp:Label>
    <br />
    <br />
    <br />
    <asp:TextBox ID="locationaddbox" runat="server" Height="83px" Style="left: 391px;
        position: absolute; top: 458px" TextMode="MultiLine" Width="517px"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="White" Style="left: 247px;
        position: absolute; top: 483px" Text="Location Address :" Width="130px"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="White" Style="left: 231px;
        position: absolute; top: 573px" Text="Contact Person Name :" Width="161px"></asp:Label>
    <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="White" Style="left: 448px;
        position: absolute; top: 574px" Text="Contact Person Phone Number :" Width="222px"></asp:Label>
    <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="White" Style="left: 731px;
        position: absolute; top: 574px" Text="E-Mail ID :" Width="82px"></asp:Label>
    <asp:Label ID="Label9" runat="server" Font-Bold="True" ForeColor="White" Style="left: 242px;
        position: absolute; top: 658px" Text="Network IP Address :" Width="149px"></asp:Label>
    <asp:Label ID="Label10" runat="server" Font-Bold="True" ForeColor="White" Style="left: 484px;
        position: absolute; top: 658px" Text="Gateway IP Address :" Width="151px"></asp:Label>
    <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="White" Style="left: 713px;
        position: absolute; top: 657px" Text="Submask Value :" Width="118px"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:TextBox ID="networkipbox" runat="server" Style="left: 237px; position: absolute;
        top: 698px"></asp:TextBox>
    <asp:TextBox ID="gatewayipbox" runat="server" Style="left: 481px; position: absolute;
        top: 698px"></asp:TextBox>
    <br />
    <br />
    <br />
    <asp:TextBox ID="emailbox" runat="server" Style="left: 699px; position: absolute;
        top: 612px" Width="195px"></asp:TextBox>
    <br />
    <asp:TextBox ID="submaskbox" runat="server" Style="left: 702px; position: absolute;
        top: 698px"></asp:TextBox>
    <br />
    <br />
    <br />
    <asp:Button ID="registerbutton" runat="server" Style="left: 500px; position: absolute;
        top: 755px" Text="Register" Width="122px" />
    &nbsp;
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

