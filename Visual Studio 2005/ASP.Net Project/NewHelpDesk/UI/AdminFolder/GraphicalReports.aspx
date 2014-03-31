<%@ Page Language="C#" MasterPageFile="~/UI/AdminFolder/Logo.master" AutoEventWireup="true" CodeFile="GraphicalReports.aspx.cs" Inherits="UI_AdminFolder_Default" Title="Graphical Reports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Names="Perpetua Titling MT"
        Font-Size="Medium" ForeColor="Red" ReadOnly="True" Style="left: 245px; top: 278px; position: absolute;"
        Width="800px">    Graphical Reports</asp:TextBox><br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/cal.gif" OnClick="ImageButton1_Click"
        Style="left: 408px; position: absolute; top: 413px" />
    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/cal.gif" OnClick="ImageButton2_Click"
        Style="left: 745px; position: absolute; top: 413px" />
    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC"
        BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"
        Font-Size="8pt" ForeColor="#003399" Height="166px" OnSelectionChanged="Calendar1_SelectionChanged"
        Style="z-index: 2; left: 432px; position: absolute; top: 301px" Visible="False"
        Width="202px">
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
        Font-Size="8pt" ForeColor="#003399" Height="168px" OnSelectionChanged="Calendar2_SelectionChanged"
        Style="z-index: 2; left: 766px; position: absolute; top: 300px" Visible="False"
        Width="196px">
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
    <asp:TextBox ID="fromdatebox" runat="server" ReadOnly="True" Style="left: 434px;
        position: absolute; top: 409px" Width="121px"></asp:TextBox>
    <asp:TextBox ID="todatebox" runat="server" ReadOnly="True" Style="left: 774px; position: absolute;
        top: 409px" Width="125px"></asp:TextBox>
    <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="White" Style="left: 314px;
        position: absolute; top: 411px" Text="From Date :" Width="83px"></asp:Label>
    <asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Italic="False" ForeColor="White"
        Style="z-index: 2; left: 664px; position: absolute; top: 411px" Text="To Date :"
        Width="72px"></asp:Label>
    <asp:Button ID="submitbutton" runat="server" OnClick="submitbutton_Click" Style="left: 490px;
        position: absolute; top: 591px" TabIndex="7" Text="Submit" Width="95px" />
    <asp:Button ID="resetbutton" runat="server" OnClick="resetbutton_Click" Style="left: 648px;
        position: absolute; top: 591px" TabIndex="8" Text="Reset" Width="95px" />
    <asp:Label ID="Label17" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 377px;
        position: absolute; top: 553px" Text="Please Select From Date !!" Visible="False"
        Width="205px"></asp:Label>
    <asp:Label ID="Label18" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 643px;
        position: absolute; top: 553px" Text="Please Select To Date !!" Visible="False"
        Width="214px"></asp:Label>
    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 730px;
        position: absolute; top: 411px" Text="*" Width="10px"></asp:Label>
    <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 402px;
        position: absolute; top: 484px" Text="*" Width="10px"></asp:Label>
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="White" Style="left: 276px;
        position: absolute; top: 485px" Text="Engineers Name :" Width="128px"></asp:Label>
    &nbsp;
    <asp:DropDownList ID="engnamebox" runat="server" DataSourceID="ObjectDataSource1"
        DataTextField="USER_NAME" DataValueField="USER_NAME" Style="left: 422px; position: absolute;
        top: 483px" Width="200px">
    </asp:DropDownList>
    <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 376px;
        position: absolute; top: 520px" Text="Please Enter Engineers Name !!" Visible="False"
        Width="260px"></asp:Label>
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
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetDataByEngUser"
        TypeName="LoginTableAdapters.NHD_USERDATATableAdapter">
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
    <br />
</asp:Content>
