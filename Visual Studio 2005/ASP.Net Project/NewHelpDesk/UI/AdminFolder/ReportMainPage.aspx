<%@ Page Language="C#" MasterPageFile="~/UI/AdminFolder/Logo.master" AutoEventWireup="true" CodeFile="ReportMainPage.aspx.cs" Inherits="UI_AdminFolder_Default" Title="Reports" %>
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
    <br />
    <br />
    <br />
    <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="False" ForeColor="White"
        Style="left: 443px; position: absolute; top: 394px" Width="152px" PostBackUrl="~/UI/AdminFolder/DailyReports.aspx">Daily Reports</asp:LinkButton>
    <asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="False" ForeColor="White"
        Style="left: 441px; position: absolute; top: 436px" Width="152px" PostBackUrl="~/UI/AdminFolder/UserCallCountReport.aspx">User Call Count Reports</asp:LinkButton>
    <asp:LinkButton ID="LinkButton3" runat="server" Font-Bold="False" ForeColor="White"
        Style="left: 440px; position: absolute; top: 477px" Width="152px" PostBackUrl="~/UI/AdminFolder/EngineerWiseReport.aspx">Engineer Wise Reports</asp:LinkButton>
    <asp:LinkButton ID="LinkButton4" runat="server" Font-Bold="False" ForeColor="White"
        Style="left: 440px; position: absolute; top: 521px" Width="152px" PostBackUrl="~/UI/AdminFolder/CategoryWiseReport.aspx">Category Wise Reports</asp:LinkButton>
    <asp:LinkButton ID="LinkButton5" runat="server" Font-Bold="False" ForeColor="White"
        Style="left: 438px; position: absolute; top: 568px" Width="152px" PostBackUrl="~/UI/AdminFolder/UserWiseReports.aspx">User Wise  Reports</asp:LinkButton>
    <asp:LinkButton ID="LinkButton6" runat="server" Font-Bold="False" ForeColor="White"
        Style="left: 437px; position: absolute; top: 614px" Width="152px" PostBackUrl="~/UI/AdminFolder/GraphicalReports.aspx">Graphical Reports</asp:LinkButton>
    <asp:LinkButton ID="LinkButton7" runat="server" Font-Bold="False" ForeColor="White"
        Style="left: 437px; position: absolute; top: 662px" Width="152px" PostBackUrl="~/UI/AdminFolder/LocationWiseReports.aspx">Location Wise Reports</asp:LinkButton>
    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="White" Style="left: 436px;
        position: absolute; top: 334px" Text="Please Select An Option" Width="175px"></asp:Label>
</asp:Content>
