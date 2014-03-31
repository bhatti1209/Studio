<%@ Page Language="C#" MasterPageFile="~/UI/UserFolder/Logo.master" AutoEventWireup="true" CodeFile="MyCallStatus.aspx.cs" Inherits="UI_AdminFolder_Default2" Title="My Call Status" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Names="Perpetua Titling MT" Font-Size="Medium" ForeColor="Red" ReadOnly="True" Width="778px">    MY CALL STATUS</asp:TextBox><br />
    <br />
    <input id="Hidden1" runat="server" style="left: 238px; position: absolute; top: 252px"
        type="hidden" />
    <br />
    <br />
    <br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    <br />
    <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 670px;
        position: absolute; top: 381px" Text="*" Width="9px"></asp:Label>
    <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 383px;
        position: absolute; top: 378px" Text="*" Width="9px"></asp:Label>
    <br />
    &nbsp; &nbsp; &nbsp;
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="White" Style="position: absolute; left: 304px; top: 379px;"
        Text="HelpDesk :"></asp:Label>
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" Style="position: absolute; left: 414px; top: 378px;" TabIndex="3">
        <asp:ListItem>All</asp:ListItem>
        <asp:ListItem>IT</asp:ListItem>
        <asp:ListItem>GIS</asp:ListItem>
        <asp:ListItem>Application</asp:ListItem>
    </asp:DropDownList>
    <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="White" Style="position: absolute; left: 582px; top: 380px;"
        Text="Call Status :" Width="88px"></asp:Label>
    
    <asp:DropDownList ID="DropDownList2" runat="server" Style="position: absolute; left: 691px; top: 379px;" TabIndex="2">
        <asp:ListItem>All</asp:ListItem>
        <asp:ListItem>Open</asp:ListItem>
        <asp:ListItem>Assigned</asp:ListItem>
        <asp:ListItem>Re-Assigned</asp:ListItem>
        <asp:ListItem>Req. For Re-Assign</asp:ListItem>
        <asp:ListItem>Escalated</asp:ListItem>
        <asp:ListItem>Resolved</asp:ListItem>
        <asp:ListItem>Closed</asp:ListItem>
        <asp:ListItem>Bogus</asp:ListItem>
    </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="SubmitButton" runat="server" Style="left: 484px;
        position: absolute; top: 436px" TabIndex="11" Text="Submit" />
    <asp:Button ID="ResetButton" runat="server" OnClick="ResetButton_Click" Style="left: 605px;
        position: absolute; top: 436px" TabIndex="12" Text="Reset" />
    <br />
    <br />
    <br />
    &nbsp; &nbsp; &nbsp;
    <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="Red" Text="Please Select Call Status !!"
        Visible="False" style="position: absolute; left: 582px; top: 478px;" Width="213px"></asp:Label><br />
    &nbsp; &nbsp; &nbsp;
    <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="Red" Text="Please Select HelpDesk !!"
        Visible="False" style="position: absolute; left: 333px; top: 478px;" Width="211px"></asp:Label>
    &nbsp;&nbsp;&nbsp;<br />
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
    <asp:TextBox ID="probdescbox" runat="server" Height="86px" Style="left: 228px; position: absolute;
        top: 871px" TextMode="MultiLine" Visible="False" Width="696px"></asp:TextBox>
    <br />
    &nbsp; &nbsp; 
    <br />
    <br />
    <br />
    &nbsp;&nbsp;
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None"
        BorderWidth="1px" CellPadding="3" GridLines="Vertical"
        Height="1px" Style="left: 229px; position: absolute; top: 528px" Width="702px" Visible="False" DataSourceID="noneselected" OnSelectedIndexChanged="LinkButton1_Click" SelectedIndex="0" PageSize="6" >
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="Gainsboro" />
        <Columns>
            <asp:BoundField DataField="TCK_ID" HeaderText="Ticket ID" SortExpression="TCK_ID" />
            <asp:BoundField DataField="HLPDEK" HeaderText="HelpDesk" SortExpression="HLPDEK" />
            <asp:BoundField DataField="CAT" HeaderText="Category" SortExpression="CAT" />
            <asp:BoundField DataField="SUBCAT" HeaderText="Sub-Category" SortExpression="SUBCAT" />
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
            <asp:BoundField DataField="SITE_ID" HeaderText="Site ID" SortExpression="SITE_ID" />
        </Columns>
    </asp:GridView>
    &nbsp;<asp:SqlDataSource ID="noneselected" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>" SelectCommand="SELECT TCK_ID, CAT, SUBCAT, ASSGN_TO, STATUS, SITE_ID, HLPDEK, LOG_DATE, PROB_SUB FROM NHD_CMPTBL WHERE (TCK_COMP_NAME = :submiter)">
        <SelectParameters>
            <asp:ControlParameter ControlID="Hidden1" Name="submiter" PropertyName="Value" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="bothselected" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>" SelectCommand="SELECT TCK_ID, CAT, SUBCAT, ASSGN_TO, STATUS, SITE_ID, HLPDEK, LOG_DATE, PROB_SUB FROM NHD_CMPTBL WHERE (TCK_COMP_NAME = :submiter) AND (STATUS = :status) AND (HLPDEK = :helpdesk)">
        <SelectParameters>
            <asp:ControlParameter ControlID="Hidden1" Name="submiter" PropertyName="Value" />
            <asp:ControlParameter ControlID="DropDownList2" Name="status" PropertyName="Text" />
            <asp:ControlParameter ControlID="DropDownList1" Name="helpdesk" PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="callstatusselected" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>" SelectCommand="SELECT TCK_ID, CAT, SUBCAT, ASSGN_TO,STATUS, SITE_ID, HLPDEK, LOG_DATE, PROB_SUB FROM NHD_CMPTBL WHERE (TCK_COMP_NAME = :submiter) AND (STATUS = :status)">
        <SelectParameters>
            <asp:ControlParameter ControlID="Hidden1" Name="submiter" PropertyName="Value" />
            <asp:ControlParameter ControlID="DropDownList2" Name="status" PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="helpdeskselected" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>" SelectCommand="SELECT TCK_ID, CAT, SUBCAT, ASSGN_TO,STATUS, SITE_ID, HLPDEK, LOG_DATE, PROB_SUB FROM NHD_CMPTBL WHERE (TCK_COMP_NAME = :submiter) AND (HLPDEK = :helpdesk)">
        <SelectParameters>
            <asp:ControlParameter ControlID="Hidden1" Name="submiter" PropertyName="Value" />
            <asp:ControlParameter ControlID="DropDownList1" Name="helpdesk" PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
</asp:Content>
