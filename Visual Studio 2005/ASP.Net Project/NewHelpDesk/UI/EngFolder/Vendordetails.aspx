<%@ Page Language="C#" MasterPageFile="~/UI/EngFolder/Logo.master" AutoEventWireup="true" CodeFile="Vendordetails.aspx.cs" Inherits="UI_UserFolder_Default" Title="Vendor Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Names="Perpetua Titling MT"
        Font-Size="Medium" ForeColor="Red" ReadOnly="True"
        Style="left: 232px; top: 263px" Width="781px">    VENDOR DETAILS</asp:TextBox><br />
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
    <br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp;&nbsp;<br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None"
        BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource2" GridLines="Vertical"
        SelectedIndex="0" Width="558px" style="left: 294px; position: absolute; top: 333px">
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <Columns>
            <asp:BoundField DataField="NAME" HeaderText="Name" SortExpression="NAME" />
            <asp:BoundField DataField="EMAIL" HeaderText="E-Mail" SortExpression="EMAIL" />
            <asp:BoundField DataField="CONTACTNO1" HeaderText="Contact #1" SortExpression="CONTACTNO1" />
            <asp:BoundField DataField="CONTACTNO2" HeaderText="Contact #2" SortExpression="CONTACTNO2" />
            <asp:BoundField DataField="ADDRESS" HeaderText="Address" SortExpression="ADDRESS" />
        </Columns>
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="Gainsboro" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT NHD_VENDORDB.* FROM NHD_VENDORDB">
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
</asp:Content>
