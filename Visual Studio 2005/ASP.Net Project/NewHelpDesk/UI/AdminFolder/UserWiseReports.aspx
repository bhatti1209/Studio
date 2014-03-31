<%@ Page Language="C#" MasterPageFile="~/UI/AdminFolder/Logo.master" AutoEventWireup="true" CodeFile="UserWiseReports.aspx.cs" Inherits="UI_AdminFolder_Default" Title="User Wise Reports" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=10.2.3600.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Names="Perpetua Titling MT"
        Font-Size="Medium" ForeColor="Red" ReadOnly="True" Style="left: 250px; top: 279px; position: absolute;"
        Width="705px">    User Wise Reports</asp:TextBox><br />
    <br />
    <br />
    <br />
    <asp:TextBox ID="fromdatebox" runat="server" ReadOnly="True" Style="left: 431px;
        position: absolute; top: 358px" Width="117px"></asp:TextBox>
    <asp:TextBox ID="todatebox" runat="server" ReadOnly="True" Style="left: 727px; position: absolute;
        top: 358px" Width="98px"></asp:TextBox>
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/cal.gif" OnClick="ImageButton1_Click"
        Style="left: 408px; position: absolute; top: 361px" />
    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/cal.gif" OnClick="ImageButton2_Click"
        Style="left: 704px; position: absolute; top: 361px" />
    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC"
        BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"
        Font-Size="8pt" ForeColor="#003399" Height="157px" OnSelectionChanged="Calendar1_SelectionChanged"
        Style="left: 428px; position: absolute; top: 256px" Visible="False" Width="183px">
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
        Font-Size="8pt" ForeColor="#003399" Height="155px" OnSelectionChanged="Calendar2_SelectionChanged"
        Style="left: 724px; position: absolute; top: 257px" Visible="False" Width="178px">
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
    <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="White" Style="left: 315px;
        position: absolute; top: 359px" Text="From Date :" Width="83px"></asp:Label>
    <asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Italic="False" ForeColor="White"
        Style="z-index: 2; left: 623px; position: absolute; top: 359px" Text="To Date :"
        Width="72px"></asp:Label>
    &nbsp;<br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    &nbsp;<br />
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
    &nbsp; 
    <asp:DropDownList ID="usernamebox" runat="server" DataSourceID="ObjectDataSource1"
        DataTextField="USER_NAME" DataValueField="USER_NAME" Style="left: 415px; position: absolute;
        top: 534px" Width="138px">
    </asp:DropDownList>
    <br />
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true"
        EnableDatabaseLogonPrompt="False" />
    <br />
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
    <asp:SqlDataSource ID="SqlDataSourceSiteID" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT SITEID FROM NHD_SITEDB ORDER BY SITEID">
    </asp:SqlDataSource>
    &nbsp;
    &nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="White" Style="left: 319px;
        position: absolute; top: 417px" Text="HelpDesk :" Width="78px"></asp:Label>
    &nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Style="z-index: 2;
        left: 418px; position: absolute; top: 415px" TabIndex="1" Width="137px">
        <asp:ListItem>All</asp:ListItem>
        <asp:ListItem>IT</asp:ListItem>
        <asp:ListItem>GIS</asp:ListItem>
        <asp:ListItem>Application</asp:ListItem>
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="AccessDataSourceSC1"
        DataTextField="Blank_Field" DataValueField="Blank_Field" Style="left: 415px;
        position: absolute; top: 474px" TabIndex="3" Width="140px" Visible="False">
    </asp:DropDownList><asp:DropDownList ID="DropDownList7" runat="server" Style="left: 415px;
        position: absolute; top: 474px" TabIndex="3" Width="140px">
    </asp:DropDownList>
    &nbsp;&nbsp;
    <asp:Label ID="Label15" runat="server" Font-Bold="True" ForeColor="White" Style="left: 310px;
        position: absolute; top: 536px" Text="User Name :" Width="103px"></asp:Label>
    <asp:Label ID="Label19" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 399px;
        position: absolute; top: 536px" Text="*" Width="10px"></asp:Label>
    <asp:Label ID="Label10" runat="server" Font-Bold="True" ForeColor="White" Style="left: 296px;
        position: absolute; top: 476px" Text="Sub-Category :" Width="103px"></asp:Label>
    <asp:Label ID="Label12" runat="server" Font-Bold="True" ForeColor="White" Style="left: 633px;
        position: absolute; top: 478px" Text="Site Id :" Width="57px"></asp:Label>
    <asp:DropDownList ID="DropDownList4" runat="server" DataSourceID="SqlDataSourceSiteID"
        DataTextField="SITEID" DataValueField="SITEID" Style="left: 701px; position: absolute;
        top: 476px" TabIndex="5" Width="139px" Visible="False">
    </asp:DropDownList><asp:DropDownList ID="DropDownList6" runat="server" Style="left: 700px; position: absolute;
        top: 475px" TabIndex="5" Width="139px">
    </asp:DropDownList>
    &nbsp;
    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="AccessDataSource1"
        DataTextField="Blank_Field" DataValueField="Blank_Field" Style="left: 700px;
        position: absolute; top: 415px" TabIndex="2" Width="140px" Visible="False">
        <asp:ListItem>All</asp:ListItem>
    </asp:DropDownList><asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="True" Style="left: 699px;
        position: absolute; top: 415px" TabIndex="2" Width="140px">
        <asp:ListItem>All</asp:ListItem>
    </asp:DropDownList>
    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="False" ForeColor="White"
        Style="left: 616px; position: absolute; top: 417px" Text="Category :" Width="72px"></asp:Label>
    &nbsp;
    <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 687px;
        position: absolute; top: 417px" Text="*" Width="10px"></asp:Label>
    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 395px;
        position: absolute; top: 476px" Text="*" Width="10px"></asp:Label>
    <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 685px;
        position: absolute; top: 478px" Text="*" Width="10px"></asp:Label>
    <asp:Button ID="submitbutton" runat="server" OnClick="submitbutton_Click" Style="left: 471px;
        position: absolute; top: 704px" TabIndex="7" Text="Submit" Width="95px" />
    <asp:Button ID="resetbutton" runat="server" OnClick="resetbutton_Click" Style="left: 627px;
        position: absolute; top: 704px" TabIndex="8" Text="Reset" Width="95px" />
    <asp:Label ID="Label17" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 314px;
        position: absolute; top: 597px" Text="Please Select From Date !!" Visible="False"
        Width="205px"></asp:Label>
    <asp:Label ID="Label18" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 580px;
        position: absolute; top: 599px" Text="Please Select To Date !!" Visible="False"
        Width="214px"></asp:Label>
    <asp:Label ID="Label9" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 314px;
        position: absolute; top: 635px" Text="Please Select Category !!" Visible="False"
        Width="175px"></asp:Label>
    <asp:Label ID="Label20" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 580px;
        position: absolute; top: 671px" Text="Please Select Username !!" Visible="False"
        Width="195px"></asp:Label>
    <asp:Label ID="Label14" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 580px;
        position: absolute; top: 637px" Text="Please Select Sub-Category !!" Visible="False"
        Width="214px"></asp:Label>
    <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 315px;
        position: absolute; top: 670px" Text="Please Select SiteID !!" Visible="False"
        Width="214px"></asp:Label>
    &nbsp; &nbsp;<br />
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
    &nbsp;
</asp:Content>
