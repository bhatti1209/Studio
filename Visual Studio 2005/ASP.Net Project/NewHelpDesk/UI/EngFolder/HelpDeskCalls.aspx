<%@ Page Language="C#" MasterPageFile="~/UI/EngFolder/Logo.master" AutoEventWireup="true" CodeFile="HelpDeskCalls.aspx.cs" Inherits="UI_AdminFolder_Default" Title="Help Desk Calls" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <input id="Hidden1" runat="server" type="hidden" /><br /><asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Names="Perpetua Titling MT"
        Font-Size="Medium" ForeColor="Red" ReadOnly="True" Width="781px">    HELPDESK CALLS</asp:TextBox>
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    <br />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="White" Height="16px"
        Style="left: 332px; position: absolute; top: 355px" Text="Category :"></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="White" Style="left: 625px;
        position: absolute; top: 355px" Text="Sub-Category :" Width="104px"></asp:Label>
    <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 401px;
        position: absolute; top: 355px" Text="*" Width="9px"></asp:Label>
    <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 729px;
        position: absolute; top: 355px" Text="*" Width="13px"></asp:Label>
    <asp:Label ID="Label9" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 404px;
        position: absolute; top: 416px" Text="*" Width="9px"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownList3" runat="server" Style="left: 434px; position: absolute;
        top: 413px" TabIndex="3">
        <asp:ListItem>All</asp:ListItem>
        <asp:ListItem>Open</asp:ListItem>
        <asp:ListItem>Assigned</asp:ListItem>
        <asp:ListItem>Re-Assigned</asp:ListItem>
        <asp:ListItem>Req. For Re-Assign</asp:ListItem>
        <asp:ListItem>Esclated</asp:ListItem>
        <asp:ListItem>Resolved</asp:ListItem>
        <asp:ListItem>Closed</asp:ListItem>
        <asp:ListItem>Bogus</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server" Style="left: 433px; position: absolute;
        top: 355px" AutoPostBack="True" Width="143px" TabIndex="1">
        <asp:ListItem>All</asp:ListItem>
        <asp:ListItem>IT-Enterprise Server</asp:ListItem>
        <asp:ListItem>IT-Hardware</asp:ListItem>
        <asp:ListItem>IT-Intel Server</asp:ListItem>
        <asp:ListItem>IT-Networking</asp:ListItem>
        <asp:ListItem>IT-Telecom</asp:ListItem>
        <asp:ListItem>IT-Software</asp:ListItem>
    </asp:DropDownList>
    <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="White" Style="left: 324px;
        position: absolute; top: 415px" Text="Call Status :"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownList2" runat="server" Style="left: 743px; position: absolute;
        top: 355px" TabIndex="2">
        <asp:ListItem>All</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="White" Style="left: 669px;
        position: absolute; top: 415px" Text="Site ID :" Width="60px"></asp:Label>
    <asp:DropDownList ID="DropDownList4" runat="server" Style="left: 742px; position: absolute;
        top: 413px" DataSourceID="SqlDataSourceSiteID" DataTextField="SITEID" DataValueField="SITEID" TabIndex="4" Visible="False">
    </asp:DropDownList><asp:DropDownList ID="DropDownList6" runat="server" Style="left: 742px; position: absolute;
        top: 413px" TabIndex="4" Width="90px">
    </asp:DropDownList>
    &nbsp;
    &nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 334px;
        position: absolute; top: 456px" Text="Please Select The Category !!" Visible="False"
        Width="250px"></asp:Label>
    <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 332px;
        position: absolute; top: 505px" Text="Please Select The Call Status !!" Visible="False"
        Width="280px"></asp:Label>
    <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 333px;
        position: absolute; top: 480px" Text="Please Select The Sub-Category !!" Visible="False"
        Width="282px"></asp:Label>
    <br />
    <asp:Button ID="resetbutton" runat="server" Style="left: 703px; position: absolute; top: 528px"
        Text="Reset" Width="76px" OnClick="resetbutton_Click" TabIndex="6" />
    <br />
    <asp:Button ID="Button1" runat="server" Style="left: 555px; position: absolute; top: 528px"
        Text="Search" Width="76px" OnClick="Button1_Click" TabIndex="5" />
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
    <asp:TextBox ID="probdescbox" runat="server" Height="108px" Style="left: 170px; position: absolute;
        top: 879px" Visible="False" Width="802px"></asp:TextBox>
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="assignbutton" runat="server" OnClick="assignbutton_Click" Style="left: 339px;
        position: absolute; top: 527px" Text="Assign" Visible="False" Width="142px" />
    &nbsp;&nbsp;&nbsp;<br />
    <br />
    <br />
    <br />
    <asp:Button ID="downloadbutton" runat="server" Enabled="False" OnClick="downloadbutton_Click"
        Style="left: 458px; position: absolute; top: 1031px" Text="Download Uploaded File"
        Visible="False" />
    <br />
    <br />
    <br />
    <asp:SqlDataSource ID="SqlDataSourceSiteID" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT SITEID FROM NHD_SITEDB ORDER BY SITEID">
    </asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True"
        AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None"
        BorderWidth="1px" CellPadding="3" GridLines="Vertical"
        Height="156px" Style="left: 170px; position: absolute; top: 597px" Width="804px" Visible="False" DataSourceID="categoryselected1" OnSelectedIndexChanged="LinkButton1_Click" PageSize="6" SelectedIndex="0">
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="Gainsboro" />
        <Columns>
            <asp:TemplateField HeaderText="Select">
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="TCK_ID" HeaderText="Ticket ID" SortExpression="TCK_ID" />
            <asp:BoundField DataField="CAT" HeaderText="Category" SortExpression="CAT" />
            <asp:TemplateField HeaderText="Problem Subject" ShowHeader="False" SortExpression="PROB_SUB">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select"
                        OnClick="LinkButton1_Click" Text='<%# Eval("PROB_SUB") %>'></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Assign To">
                <ItemTemplate>
                    <asp:DropDownList ID="DropDownList5" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Self</asp:ListItem>
                    </asp:DropDownList>&nbsp;
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="STATUS" HeaderText="Status" SortExpression="STATUS" />
            <asp:BoundField DataField="TCK_COMP_NAME" HeaderText="Ticket Submiter" SortExpression="TCK_COMP_NAME" />
            <asp:BoundField DataField="SITE_ID" HeaderText="Site ID" SortExpression="SITE_ID" />
            <asp:BoundField DataField="LOG_DATE" HeaderText="Log Date" SortExpression="LOG_DATE" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="categoryselected1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT TCK_ID, CAT, PROB_SUB, TCK_COMP_NAME, STATUS, SITE_ID, LOG_DATE FROM NHD_CMPTBL WHERE (CAT = :cat) AND (SUBCAT = :subcat)">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="cat" PropertyName="Text" />
            <asp:ControlParameter ControlID="DropDownList2" Name="subcat" PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="categoryselected2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT TCK_ID, CAT, PROB_SUB, TCK_COMP_NAME, STATUS, SITE_ID, LOG_DATE FROM NHD_CMPTBL WHERE (CAT = :cat) AND (SUBCAT = :subcat) AND (SITE_ID = :siteid)">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="cat" PropertyName="Text" />
            <asp:ControlParameter ControlID="DropDownList2" Name="subcat" PropertyName="Text" />
            <asp:ControlParameter ControlID="DropDownList6" Name="siteid" PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="bothselected1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT TCK_ID, CAT, PROB_SUB, TCK_COMP_NAME, STATUS, SITE_ID, LOG_DATE FROM NHD_CMPTBL WHERE (CAT = :cat) AND (SUBCAT = :subcat) AND (STATUS = :status)">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="cat" PropertyName="Text" />
            <asp:ControlParameter ControlID="DropDownList2" Name="subcat" PropertyName="Text" />
            <asp:ControlParameter ControlID="DropDownList3" Name="status" PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="bothselected2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT TCK_ID, CAT ,PROB_SUB, TCK_COMP_NAME, STATUS, SITE_ID, LOG_DATE FROM NHD_CMPTBL WHERE (CAT = :cat) AND (SUBCAT = :subcat) AND (STATUS = :status) AND (SITE_ID = :siteid)">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="cat" PropertyName="Text" />
            <asp:ControlParameter ControlID="DropDownList2" Name="subcat" PropertyName="Text" />
            <asp:ControlParameter ControlID="DropDownList3" Name="status" PropertyName="Text" />
            <asp:ControlParameter ControlID="DropDownList6" Name="siteid" PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="statusselected1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT TCK_ID, CAT ,PROB_SUB, TCK_COMP_NAME, TCK_SUBMITER, STATUS, SITE_ID, LOG_DATE FROM NHD_CMPTBL WHERE (STATUS = :status)">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList3" Name="status" PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="statusselected2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT TCK_ID, CAT ,PROB_SUB, TCK_COMP_NAME, TCK_SUBMITER, STATUS, SITE_ID, LOG_DATE FROM NHD_CMPTBL WHERE (STATUS = :status) AND (SITE_ID = :siteid)">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList3" Name="status" PropertyName="Text" />
            <asp:ControlParameter ControlID="DropDownList6" Name="siteid" PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="noneselected1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT TCK_ID, CAT,PROB_SUB, TCK_COMP_NAME, TCK_SUBMITER, STATUS, SITE_ID, LOG_DATE FROM NHD_CMPTBL">
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="noneselected2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT TCK_ID, CAT, PROB_SUB, TCK_COMP_NAME, TCK_SUBMITER, STATUS, SITE_ID, LOG_DATE FROM NHD_CMPTBL WHERE (SITE_ID = :siteid)">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList6" Name="siteid" PropertyName="Text" />
        </SelectParameters>
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
    &nbsp;
    <br />
    <br />
</asp:Content>
