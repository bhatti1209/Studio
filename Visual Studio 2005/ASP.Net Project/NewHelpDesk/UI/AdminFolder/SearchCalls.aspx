<%@ Page Language="C#" MasterPageFile="~/UI/AdminFolder/Logo.master" AutoEventWireup="true" CodeFile="SearchCalls.aspx.cs" Inherits="UI_AdminFolder_Default" Title="Search Calls" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Names="Perpetua Titling MT"
        Font-Size="Medium" ForeColor="Red" ReadOnly="True" Style="left: 232px; top: 263px" Width="781px">    Search Calls</asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 512px;
        position: absolute; top: 347px" Text="*" Width="9px"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="White" Style="left: 403px;
        position: absolute; top: 347px" Text="Reference ID :" Width="122px"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="refidbox" runat="server" Style="left: 585px; position: absolute;
        top: 345px"></asp:TextBox>
    <br />
    <asp:Button ID="SearchButton" runat="server" Style="left: 505px; position: absolute;
        top: 447px" Text="Search" Width="109px" />
    <br />
    <br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    <br />
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 449px;
        position: absolute; top: 402px" Text="Please Enter The Reference ID !!" Visible="False"
        Width="303px"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server"
        AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None"
        BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="91px" Style="left: 215px;
        position: absolute; top: 529px" Visible="False" Width="732px" DataSourceID="refsearch" SelectedIndex="0" OnSelectedIndexChanged="LinkButton1_Click">
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="Gainsboro" />
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
    <asp:TextBox ID="probdescbox" runat="server" Height="86px" Style="left: 215px; position: absolute;
        top: 637px" TextMode="MultiLine" Visible="False" Width="727px"></asp:TextBox>
    <br />
    <br />
    <br />
    <br />
    <asp:SqlDataSource ID="refsearch" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>" SelectCommand="SELECT TCK_ID, CAT, SUBCAT, TCK_SUBMITER, PROB_SUB,  ASSGN_TO, STATUS, LOG_DATE FROM NHD_CMPTBL WHERE (TCK_ID = :TCK)">
        <SelectParameters>
            <asp:ControlParameter ControlID="refidbox" Name="TCK" PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <br />
    <br />
</asp:Content>
