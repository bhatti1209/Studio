<%@ Page Language="C#" MasterPageFile="~/UI/AdminFolder/Logo.master" AutoEventWireup="true" CodeFile="UsersCalls.aspx.cs" Inherits="UI_AdminFolder_Default" Title="User Calls" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Names="Perpetua Titling MT"
        Font-Size="Medium" ForeColor="Red" ReadOnly="True" Style="left: 232px; top: 263px"
        Width="788px">    Users Calls</asp:TextBox><br />
    <br />
    <br />
    <asp:DropDownList ID="usernamebox" runat="server" DataSourceID="ObjectDataSource1"
        DataTextField="USER_NAME" DataValueField="USER_NAME" Style="left: 582px; position: absolute;
        top: 348px" Width="154px">
    </asp:DropDownList>
    &nbsp;&nbsp;
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
    <br />
    <asp:TextBox ID="probdescbox" runat="server" Height="86px" Style="left: 167px; position: absolute;
        top: 798px" TextMode="MultiLine" Visible="False" Width="780px"></asp:TextBox>
    <br />
    <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 512px;
        position: absolute; top: 348px" Text="*" Width="9px"></asp:Label>
    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="White" Style="left: 424px;
        position: absolute; top: 348px" Text="User Name :" Width="90px"></asp:Label>
    &nbsp;
    <asp:Button ID="SearchButton" runat="server" OnClick="SearchButton_Click" Style="left: 505px;
        position: absolute; top: 447px" Text="Search" Width="109px" />
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 449px;
        position: absolute; top: 402px" Text="Please Enter The User Name !!" Visible="False"
        Width="303px"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None"
        BorderWidth="1px" CellPadding="3" DataSourceID="usernamesearch" GridLines="Vertical"
        Height="107px" Style="left: 166px; position: absolute; top: 485px" Visible="False"
        Width="787px" OnSelectedIndexChanged="LinkButton1_Click" SelectedIndex="0">
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <Columns>
            <asp:BoundField DataField="TCK_ID" HeaderText="Ticket ID" SortExpression="TCK_ID" />
            <asp:BoundField DataField="CAT" HeaderText="Category" SortExpression="CAT" />
            <asp:BoundField DataField="SUBCAT" HeaderText="Sub-Category" SortExpression="SUBCAT" />
            <asp:BoundField DataField="TCK_SUBMITER" HeaderText="Ticket Submitter" SortExpression="TCK_SUBMITER" />
            <asp:TemplateField HeaderText="Problem Subject" ShowHeader="False" SortExpression="PROB_SUB">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select"
                        OnClick="LinkButton1_Click" Text='<%# Eval("PROB_SUB") %>'></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ASSGN_TO" HeaderText="Assigned To" SortExpression="ASSGN_TO" />
            <asp:BoundField DataField="STATUS" HeaderText="Status" SortExpression="STATUS" />
            <asp:TemplateField HeaderText="Log Date" SortExpression="LOG_DATE">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("LOG_DATE") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("LOG_DATE") %>'></asp:Label>&nbsp;
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="Gainsboro" />
    </asp:GridView>
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
    <asp:SqlDataSource ID="usernamesearch" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>" SelectCommand="SELECT TCK_ID, CAT, SUBCAT, TCK_SUBMITER, PROB_SUB, ASSGN_TO, STATUS, LOG_DATE FROM NHD_CMPTBL WHERE (TCK_SUBMITER = :Username)">
        <SelectParameters>
            <asp:ControlParameter ControlID="usernamebox" Name="Username" PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>

