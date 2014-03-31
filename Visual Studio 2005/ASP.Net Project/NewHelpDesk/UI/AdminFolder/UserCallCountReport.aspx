<%@ Page Language="C#" MasterPageFile="~/UI/AdminFolder/Logo.master" AutoEventWireup="true" CodeFile="UserCallCountReport.aspx.cs" Inherits="UI_AdminFolder_Default" Title="User Call Count Report" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=10.2.3600.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Names="Perpetua Titling MT"
        Font-Size="Medium" ForeColor="Red" ReadOnly="True" Style="left: 246px; top: 277px; position: absolute;"
        Width="721px">    User Call Count Report</asp:TextBox><br />
    <br />
    <br />
    <br />
    <asp:TextBox ID="fromdatebox" runat="server" ReadOnly="True" Style="left: 434px; position: absolute;
        top: 409px" Width="121px"></asp:TextBox>
    <asp:TextBox ID="todatebox" runat="server" ReadOnly="True" Style="left: 774px; position: absolute;
        top: 409px" Width="125px"></asp:TextBox>
    <br />
    <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 397px;
        position: absolute; top: 503px" Text="*" Width="10px"></asp:Label>
    <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 397px;
        position: absolute; top: 411px" Text="*" Width="10px"></asp:Label>
    <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 731px;
        position: absolute; top: 411px" Text="*" Width="10px"></asp:Label>
    <br />
    <br />
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/cal.gif" OnClick="ImageButton1_Click"
        Style="left: 408px; position: absolute; top: 413px" />
    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/cal.gif" OnClick="ImageButton2_Click"
        Style="left: 745px; position: absolute; top: 413px" />
    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC"
        BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"
        Font-Size="8pt" ForeColor="#003399" Height="155px" OnSelectionChanged="Calendar1_SelectionChanged"
        Style="left: 430px; position: absolute; top: 315px; z-index: 2;" Visible="False" Width="195px">
        <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
        <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
        <WeekendDayStyle BackColor="#CCCCFF" />
        <OtherMonthDayStyle ForeColor="#999999" />
        <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
        <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
        <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True"
            Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
    </asp:Calendar>
    <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="#3366CC"
        BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"
        Font-Size="8pt" ForeColor="#003399" Height="160px" OnSelectionChanged="Calendar2_SelectionChanged"
        Style="left: 763px; position: absolute; top: 315px; z-index: 2;" Visible="False" Width="180px">
        <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
        <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
        <WeekendDayStyle BackColor="#CCCCFF" />
        <OtherMonthDayStyle ForeColor="#999999" />
        <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
        <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
        <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True"
            Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
    </asp:Calendar>
    <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="White" Style="left: 314px;
        position: absolute; top: 411px" Text="From Date :" Width="83px"></asp:Label>
    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="White" Style="left: 271px;
        position: absolute; top: 504px" Text="Submitters Name :" Width="128px"></asp:Label>
    <asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Italic="False" ForeColor="White"
        Style="z-index: 2; left: 664px; position: absolute; top: 411px" Text="To Date :"
        Width="72px"></asp:Label>
    <asp:Button ID="submitbutton" runat="server" Style="left: 490px;
        position: absolute; top: 627px" TabIndex="7" Text="Submit" Width="95px" OnClick="submitbutton_Click" />
    <asp:Button ID="resetbutton" runat="server" OnClick="resetbutton_Click" Style="left: 648px;
        position: absolute; top: 627px" TabIndex="8" Text="Reset" Width="95px" />
    &nbsp;<br />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="White" Style="left: 620px;
        position: absolute; top: 505px" Text="Minimum Calls :" Width="117px"></asp:Label>
    <asp:TextBox ID="minimumcallbox" runat="server" Style="left: 751px; position: absolute;
        top: 503px" Width="152px">1</asp:TextBox>
    <br />
    <br />
    <br />
    <asp:DropDownList ID="submitternamebox" runat="server" DataSourceID="ObjectDataSource1"
        DataTextField="USER_NAME" DataValueField="USER_NAME" Style="left: 417px; position: absolute;
        top: 503px" Width="177px">
    </asp:DropDownList>
    <br />
    <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 376px;
        position: absolute; top: 556px" Text="Please Enter Submitters Name !!" Visible="False"
        Width="260px"></asp:Label>
    <asp:Label ID="Label17" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 377px;
        position: absolute; top: 589px" Text="Please Select From Date !!" Visible="False"
        Width="205px"></asp:Label>
    <asp:Label ID="Label18" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 643px;
        position: absolute; top: 589px" Text="Please Select To Date !!" Visible="False"
        Width="214px"></asp:Label>
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
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true"
        EnableDatabaseLogonPrompt="False" />
    <br />
    <br />
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" InsertMethod="Insert"
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetDataByUsername"
        TypeName="LoginTableAdapters.NHD_USERDATATableAdapter">
        <InsertParameters>
            <asp:Parameter Name="USER_NAME" Type="String" />
            <asp:Parameter Name="USER_LOGIN_ID" Type="String" />
            <asp:Parameter Name="USER_MAIL_ID" Type="String" />
            <asp:Parameter Name="USER_CONTACT_NO" Type="String" />
            <asp:Parameter Name="USER_DEPARTMENT" Type="String" />
            <asp:Parameter Name="USER_SITE_ID" Type="String" />
            <asp:Parameter Name="USER_LOGIN_TYPE" Type="String" />
        </InsertParameters>
    </asp:ObjectDataSource>
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

