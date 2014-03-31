<%@ Page Language="C#" MasterPageFile="~/UI/AdminFolder/Logo.master" AutoEventWireup="true" CodeFile="EditDB.aspx.cs" Inherits="UI_AdminFolder_Default" Title="Edit DataBase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label6" runat="server" ForeColor="White" Style="left: 434px; position: absolute;
        top: 249px" Text="( Please Select Vendor Name To Edit )" Width="368px"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None"
        BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource1" GridLines="Vertical"
        OnSelectedIndexChanged="LinkButton1_Click" SelectedIndex="0" Style="left: 285px;
        position: absolute; top: 277px">
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <Columns>
            <asp:TemplateField HeaderText="Name" ShowHeader="False" SortExpression="NAME">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select"
                        OnClick="LinkButton1_Click" Text='<%# Eval("NAME") %>'></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="E-Mail ID" SortExpression="EMAIL">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("EMAIL") %>' Width="111px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("EMAIL") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Contact #1" SortExpression="CONTACTNO1">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("CONTACTNO1") %>' Width="99px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("CONTACTNO1") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Contact #2" SortExpression="CONTACTNO2">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("CONTACTNO2") %>' Width="97px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("CONTACTNO2") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Address" SortExpression="ADDRESS">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("ADDRESS") %>' TextMode="MultiLine" Width="91px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("ADDRESS") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                    <asp:Button ID="Button1" runat="server" CausesValidation="True" OnClick="Button1_Click"
                        Text="Update" />
                    <asp:Button ID="Button2" runat="server" CausesValidation="False" CommandName="Cancel"
                        Text="Cancel" />
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Button ID="Button2" runat="server" CausesValidation="False" CommandName="Edit"
                        Text="Edit" Visible="False" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="Gainsboro" />
    </asp:GridView>
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
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT NHD_VENDORDB.* FROM NHD_VENDORDB">
    </asp:SqlDataSource>
</asp:Content>

