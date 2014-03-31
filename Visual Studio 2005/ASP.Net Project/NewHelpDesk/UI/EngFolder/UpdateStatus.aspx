<%@ Page Language="C#" MasterPageFile="~/UI/EngFolder/Logo.master" AutoEventWireup="true" CodeFile="UpdateStatus.aspx.cs" Inherits="UI_EngFolder_Default" Title="Update Status" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Names="Perpetua Titling MT"
        Font-Size="Medium" ForeColor="Red" ReadOnly="True" Style="left: 232px; top: 263px"
        Width="794px">    Update Status</asp:TextBox><br />
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
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White"
        BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="refsearch"
        GridLines="Vertical" Height="91px" OnSelectedIndexChanged="LinkButton1_Click"
        PageSize="1" SelectedIndex="0" Style="left: 211px; position: absolute; top: 601px"
        Visible="False" Width="732px">
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
    <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 506px;
        position: absolute; top: 407px" Text="*" Width="9px"></asp:Label>
    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="White" Style="left: 394px;
        position: absolute; top: 407px" Text="Reference ID :" Width="105px"></asp:Label>
    <asp:TextBox ID="refidbox" runat="server" Style="left: 548px; position: absolute;
        top: 405px"></asp:TextBox>
    <asp:Button ID="ResolveButton" runat="server" Enabled="False" OnClick="ResolveButton_Click"
        Style="left: 575px; position: absolute; top: 450px" Text="Mark Resolved" Width="109px" />
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 719px;
        position: absolute; top: 404px" Text="Please Enter The Reference ID !!" Visible="False"
        Width="243px"></asp:Label>
    <asp:TextBox ID="RemarkBox" runat="server" Height="69px" Style="left: 357px; position: absolute;
        top: 512px" TextMode="MultiLine" Visible="False" Width="432px">Please Enter Remark Here</asp:TextBox>
    <asp:Button ID="SearchButton" runat="server" Style="left: 437px; position: absolute;
        top: 450px" Text="Search" Width="109px" />
    <asp:TextBox ID="probdescbox" runat="server" Height="86px" Style="left: 211px; position: absolute;
        top: 692px" TextMode="MultiLine" Visible="False" Width="727px"></asp:TextBox>
    <asp:SqlDataSource ID="refsearch" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>" SelectCommand="SELECT TCK_ID, CAT, SUBCAT, TCK_SUBMITER, PROB_SUB,  ASSGN_TO, STATUS, LOG_DATE FROM NHD_CMPTBL WHERE (TCK_ID = :TCK)">
        <SelectParameters>
            <asp:ControlParameter ControlID="refidbox" Name="TCK" PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>

