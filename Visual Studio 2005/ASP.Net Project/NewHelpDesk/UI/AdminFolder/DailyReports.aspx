<%@ Page Language="C#" MasterPageFile="~/UI/AdminFolder/Logo.master" AutoEventWireup="true" CodeFile="DailyReports.aspx.cs" Inherits="UI_AdminFolder_Default" Title="Daily Reports" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=10.2.3600.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Names="Perpetua Titling MT"
        Font-Size="Medium" ForeColor="Red" ReadOnly="True" Style="left: 259px; top: 280px; position: absolute;"
        Width="705px">    Daily Reports</asp:TextBox><br />
    <br />
    <br />
    <asp:TextBox ID="fromdatebox" runat="server" ReadOnly="True" Style="left: 431px;
        position: absolute; top: 358px" Width="117px"></asp:TextBox>
    <asp:TextBox ID="todatebox" runat="server" ReadOnly="True" Style="left: 727px; position: absolute;
        top: 358px" Width="98px"></asp:TextBox>
    <br />
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/cal.gif" OnClick="ImageButton1_Click"
        Style="left: 408px; position: absolute; top: 361px" />
    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/cal.gif" OnClick="ImageButton2_Click"
        Style="left: 704px; position: absolute; top: 361px" />
    <br />
    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC"
        BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"
        Font-Size="8pt" ForeColor="#003399" Height="172px"
         Style="left: 428px; position: absolute;
        top: 242px" Visible="False" Width="197px" OnSelectionChanged="Calendar1_SelectionChanged">
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
        Font-Size="8pt" ForeColor="#003399" Height="173px" OnSelectionChanged="Calendar2_SelectionChanged"
        Style="left: 724px; position: absolute; top: 241px" Visible="False" Width="199px">
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
    <br />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="White" Style="left: 319px;
        position: absolute; top: 417px" Text="HelpDesk :" Width="78px"></asp:Label>
    <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="White" Style="left: 314px;
        position: absolute; top: 359px" Text="From Date :" Width="83px"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Style="left: 418px;
        position: absolute; top: 415px; z-index: 2;" TabIndex="1" Width="137px">
        <asp:ListItem>All</asp:ListItem>
        <asp:ListItem>IT</asp:ListItem>
        <asp:ListItem>GIS</asp:ListItem>
        <asp:ListItem>Application</asp:ListItem>
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="AccessDataSourceSC1"
        DataTextField="Blank_Field" DataValueField="Blank_Field" Style="left: 415px;
        position: absolute; top: 474px" TabIndex="3" Width="140px" Visible="False">
    </asp:DropDownList>
    <asp:Label ID="Label10" runat="server" Font-Bold="True" ForeColor="White" Style="left: 296px;
        position: absolute; top: 476px" Text="Sub-Category :" Width="103px"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownList8" runat="server" Style="left: 701px; position: absolute;
        top: 416px" Width="133px" AutoPostBack="True">
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList9" runat="server" Style="left: 415px; position: absolute;
        top: 475px" Width="140px" AutoPostBack="True">
    </asp:DropDownList>
    <br />
    <asp:Label ID="Label12" runat="server" Font-Bold="True" ForeColor="White" Style="left: 346px;
        position: absolute; top: 531px" Text="Site Id :" Width="57px"></asp:Label>
    <asp:DropDownList ID="DropDownList4" runat="server" DataSourceID="SqlDataSourceSiteID"
        DataTextField="SITEID" DataValueField="SITEID" Style="left: 414px; position: absolute;
        top: 529px" TabIndex="5" Width="139px" AutoPostBack="True" Visible="False">
    </asp:DropDownList>
    &nbsp;
    <br />
    <br />
    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="AccessDataSource1"
        DataTextField="Blank_Field" DataValueField="Blank_Field" Style="left: 701px; position: absolute;
        top: 446px" TabIndex="2" Width="128px" Visible="False">
        <asp:ListItem>All</asp:ListItem>
    </asp:DropDownList>
    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="False" ForeColor="White"
        Style="left: 616px; position: absolute; top: 417px" Text="Category :" Width="72px"></asp:Label>
    <asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Italic="False" ForeColor="White"
        Style="left: 623px; position: absolute; top: 359px; z-index: 2;" Text="To Date :" Width="72px"></asp:Label>
    <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 687px;
        position: absolute; top: 417px" Text="*" Width="10px"></asp:Label>
    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 395px;
        position: absolute; top: 476px" Text="*" Width="10px"></asp:Label>
    <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 686px;
        position: absolute; top: 476px" Text="*" Width="10px"></asp:Label>
    <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 398px;
        position: absolute; top: 531px" Text="*" Width="9px"></asp:Label>
    <br />
    <asp:Label ID="Label15" runat="server" Font-Bold="True" ForeColor="White" Style="left: 628px;
        position: absolute; top: 476px" Text="Priority :" Width="60px"></asp:Label>
    <asp:DropDownList ID="DropDownList5" runat="server" Style="left: 702px; position: absolute;
        top: 474px" TabIndex="4" Width="129px">
        <asp:ListItem Selected="True">All</asp:ListItem>
        <asp:ListItem>Low</asp:ListItem>
        <asp:ListItem>Medium</asp:ListItem>
        <asp:ListItem>High</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label13" runat="server" Font-Bold="True" ForeColor="White" Style="left: 605px;
        position: absolute; top: 533px" Text="Call Status :" Width="91px"></asp:Label>
    <asp:DropDownList ID="DropDownList6" runat="server" Style="left: 703px; position: absolute;
        top: 531px" TabIndex="6" Width="128px">
        <asp:ListItem>All</asp:ListItem>
        <asp:ListItem>Assigned</asp:ListItem>
        <asp:ListItem>Re-Assigned</asp:ListItem>
        <asp:ListItem>Req. For Re-Assign</asp:ListItem>
        <asp:ListItem>Escalated</asp:ListItem>
        <asp:ListItem>Resolved</asp:ListItem>
        <asp:ListItem>Closed</asp:ListItem>
        <asp:ListItem>Bogus</asp:ListItem>
    </asp:DropDownList><asp:DropDownList ID="DropDownList7" runat="server" Style="left: 414px; position: absolute;
        top: 529px" TabIndex="5" Width="139px" AutoPostBack="True">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="submitbutton" runat="server" Style="left: 471px; position: absolute;
        top: 684px" Text="Submit" Width="95px" OnClick="submitbutton_Click" TabIndex="7" />
    <asp:Button ID="resetbutton" runat="server" Style="left: 627px;
        position: absolute; top: 684px" Text="Reset" Width="95px" OnClick="resetbutton_Click" TabIndex="8" />
    <br />
    <br />
    <asp:Label ID="Label9" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 346px;
        position: absolute; top: 615px" Text="Please Select Category !!" Visible="False"
        Width="175px"></asp:Label>
    <asp:Label ID="Label17" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 346px;
        position: absolute; top: 588px" Text="Please Select From Date !!" Visible="False"
        Width="205px"></asp:Label>
    <asp:Label ID="Label14" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 346px;
        position: absolute; top: 645px" Text="Please Select Sub-Category !!" Visible="False"
        Width="214px"></asp:Label>
    <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 612px;
        position: absolute; top: 644px" Text="Please Select SiteID !!" Visible="False"
        Width="214px"></asp:Label>
    <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 612px;
        position: absolute; top: 615px" Text="Please Select Priority !!" Visible="False"
        Width="214px"></asp:Label>
    <asp:Label ID="Label18" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 612px;
        position: absolute; top: 589px" Text="Please Select To Date !!" Visible="False"
        Width="214px"></asp:Label>
    &nbsp;<br />
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
    <br />
    &nbsp;<br />
    <asp:SqlDataSource ID="SqlDataSourceSiteID" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT SITEID FROM NHD_SITEDB ORDER BY SITEID">
    </asp:SqlDataSource>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/DropDownList.mdb"
        SelectCommand="SELECT [IT-Category] AS column1, [Blank Field] AS Blank_Field FROM [IT-Category]">
    </asp:AccessDataSource>
    <asp:AccessDataSource ID="AccessDataSourceSC6" runat="server" DataFile="~/DropDownList.mdb"
        SelectCommand="SELECT [IT-SubCategory6] AS column1, [Blank Field] AS Blank_Field FROM [IT-SubCategory6]">
    </asp:AccessDataSource>
    <asp:AccessDataSource ID="AccessDataSourceSC5" runat="server" DataFile="~/DropDownList.mdb"
        SelectCommand="SELECT [IT-SubCategory5] AS column1, [Blank Field] AS Blank_Field FROM [IT-SubCategory5]">
    </asp:AccessDataSource>
    <asp:AccessDataSource ID="AccessDataSourceSC4" runat="server" DataFile="~/DropDownList.mdb"
        SelectCommand="SELECT [IT-SubCategory4] AS column1, [Blank Field] AS Blank_Field FROM [IT-SubCategory4]">
    </asp:AccessDataSource>
    <asp:AccessDataSource ID="AccessDataSourceSC3" runat="server" DataFile="~/DropDownList.mdb"
        SelectCommand="SELECT [IT-SubCategory3] AS column1, [Blank Field] AS Blank_Field FROM [IT-SubCategory3]">
    </asp:AccessDataSource>
    <asp:AccessDataSource ID="AccessDataSourceSC2" runat="server" DataFile="~/DropDownList.mdb"
        SelectCommand="SELECT [IT-SubCategory2] AS column1, [Blank Field] AS Blank_Field FROM [IT-SubCategory2]">
    </asp:AccessDataSource>
    <asp:AccessDataSource ID="AccessDataSourceSC1" runat="server" DataFile="~/DropDownList.mdb"
        SelectCommand="SELECT [IT-SubCategory1] AS column1, [Blank Field] AS Blank_Field FROM [IT-SubCategory1]">
    </asp:AccessDataSource>
</asp:Content>

