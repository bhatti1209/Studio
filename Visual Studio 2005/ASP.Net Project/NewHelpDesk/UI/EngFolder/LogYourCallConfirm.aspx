<%@ Page Language="C#" MasterPageFile="~/UI/EngFolder/Logo.master" AutoEventWireup="true" CodeFile="LogYourCallConfirm.aspx.cs" Inherits="UI_AdminFolder_Default" Title="Log Your Call Confirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="White" Style="left: 312px;
        position: absolute; top: 342px" Text="Date :"></asp:Label>
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="White" Style="left: 283px;
        position: absolute; top: 452px" Text="HelpDesk :"></asp:Label>
    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="False" ForeColor="White"
        Style="left: 529px; position: absolute; top: 452px" Text="Category :"></asp:Label>
    <asp:Label ID="Label10" runat="server" Font-Bold="True" ForeColor="White" Style="left: 740px;
        position: absolute; top: 452px" Text="Sub-Category :" Width="102px"></asp:Label>
    <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="White" Style="left: 300px;
        position: absolute; top: 399px" Text="Site ID :"></asp:Label>
    <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Italic="False" ForeColor="White"
        Style="left: 487px; position: absolute; top: 397px" Text="Ticket Submiter :"
        Width="116px"></asp:Label>
    <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="White" Style="left: 784px;
        position: absolute; top: 395px" Text="Status :" Width="57px"></asp:Label>
    <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="White" Style="left: 747px;
        position: absolute; top: 342px" Text="Ticket ID :" Width="77px"></asp:Label>
    <asp:Label ID="Label15" runat="server" Font-Bold="True" ForeColor="White" Style="left: 541px;
        position: absolute; top: 343px" Text="Priority :"></asp:Label>
    <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="White" Style="left: 296px;
        position: absolute; top: 507px" Text="Subject :"></asp:Label>
    <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="White" Style="left: 275px;
        position: absolute; top: 723px" Text="Assign To :"></asp:Label>
    <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="White" Style="left: 267px;
        position: absolute; top: 594px" Text="Problem Description :" Width="72px"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Names="Perpetua Titling MT"
        Font-Size="Medium" ForeColor="Red" ReadOnly="True" Style="left: 232px; position: absolute;
        top: 263px" Width="725px">    Confrim Call</asp:TextBox>
    &nbsp;<br />
    <br />
    <asp:Label ID="ticketidlabel" runat="server" ForeColor="White" Style="left: 835px;
        position: absolute; top: 340px" Width="152px"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label12" runat="server" ForeColor="White" Style="left: 373px; position: absolute;
        top: 342px" Width="76px"></asp:Label>
    &nbsp;<br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
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
    <asp:DropDownList ID="assignbox" runat="server" DataSourceID="ObjectDataSource1"
        DataTextField="USER_NAME" DataValueField="USER_NAME" Enabled="False" Style="left: 359px;
        position: absolute; top: 721px" Width="443px">
    </asp:DropDownList>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" InsertMethod="Insert"
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetDataByEngUser"
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
    <br />
    <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" Font-Bold="True"
        ForeColor="White" Style="left: 273px; position: absolute; top: 696px" Text="Check This To Assign The Problem"
        Width="283px" />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString5 %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString5.ProviderName %>" SelectCommand="SELECT TCK_ID, CAT, SUBCAT, STATUS, SITE_ID, TCK_COMP_NAME, HLPDEK, PRIORITY, PROB_SUB, PROB_DESC, LOG_DATE FROM NHD_CMPTBL WHERE (TCK_ID = :ticket)">
        <SelectParameters>
            <asp:ControlParameter ControlID="ticketidlabel" Name="ticket" PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <br />
    <br />
    <asp:Button ID="Assignbutton" runat="server" Style="left: 560px; position: absolute;
        top: 799px" Text="Submit" OnClick="Assignbutton_Click" />
    <br />
    <asp:FormView ID="FormView1" runat="server" DataSourceID="SqlDataSource1">
        <EditItemTemplate>
            TCK_ID:
            <asp:TextBox ID="TCK_IDTextBox" runat="server" Text='<%# Bind("TCK_ID") %>'>
            </asp:TextBox><br />
            CAT:
            <asp:TextBox ID="CATTextBox" runat="server" Text='<%# Bind("CAT") %>'>
            </asp:TextBox><br />
            SUBCAT:
            <asp:TextBox ID="SUBCATTextBox" runat="server" Text='<%# Bind("SUBCAT") %>'>
            </asp:TextBox><br />
            STATUS:
            <asp:TextBox ID="STATUSTextBox" runat="server" Text='<%# Bind("STATUS") %>'>
            </asp:TextBox><br />
            SITE_ID:
            <asp:TextBox ID="SITE_IDTextBox" runat="server" Text='<%# Bind("SITE_ID") %>'>
            </asp:TextBox><br />
            TCK_COMP_NAME:
            <asp:TextBox ID="TCK_COMP_NAMETextBox" runat="server" Text='<%# Bind("TCK_COMP_NAME") %>'>
            </asp:TextBox><br />
            HLPDEK:
            <asp:TextBox ID="HLPDEKTextBox" runat="server" Text='<%# Bind("HLPDEK") %>'>
            </asp:TextBox><br />
            PRIORITY:
            <asp:TextBox ID="PRIORITYTextBox" runat="server" Text='<%# Bind("PRIORITY") %>'>
            </asp:TextBox><br />
            PROB_SUB:
            <asp:TextBox ID="PROB_SUBTextBox" runat="server" Text='<%# Bind("PROB_SUB") %>'>
            </asp:TextBox><br />
            PROB_DESC:
            <asp:TextBox ID="PROB_DESCTextBox" runat="server" Text='<%# Bind("PROB_DESC") %>'>
            </asp:TextBox><br />
            LOG_DATE:
            <asp:TextBox ID="LOG_DATETextBox" runat="server" Text='<%# Bind("LOG_DATE") %>'>
            </asp:TextBox><br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update"
                Text="Update">
            </asp:LinkButton>
            <asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel"
                Text="Cancel">
            </asp:LinkButton>
        </EditItemTemplate>
        <InsertItemTemplate>
            TCK_ID:
            <asp:TextBox ID="TCK_IDTextBox" runat="server" Text='<%# Bind("TCK_ID") %>'>
            </asp:TextBox><br />
            CAT:
            <asp:TextBox ID="CATTextBox" runat="server" Text='<%# Bind("CAT") %>'>
            </asp:TextBox><br />
            SUBCAT:
            <asp:TextBox ID="SUBCATTextBox" runat="server" Text='<%# Bind("SUBCAT") %>'>
            </asp:TextBox><br />
            STATUS:
            <asp:TextBox ID="STATUSTextBox" runat="server" Text='<%# Bind("STATUS") %>'>
            </asp:TextBox><br />
            SITE_ID:
            <asp:TextBox ID="SITE_IDTextBox" runat="server" Text='<%# Bind("SITE_ID") %>'>
            </asp:TextBox><br />
            TCK_COMP_NAME:
            <asp:TextBox ID="TCK_COMP_NAMETextBox" runat="server" Text='<%# Bind("TCK_COMP_NAME") %>'>
            </asp:TextBox><br />
            HLPDEK:
            <asp:TextBox ID="HLPDEKTextBox" runat="server" Text='<%# Bind("HLPDEK") %>'>
            </asp:TextBox><br />
            PRIORITY:
            <asp:TextBox ID="PRIORITYTextBox" runat="server" Text='<%# Bind("PRIORITY") %>'>
            </asp:TextBox><br />
            PROB_SUB:
            <asp:TextBox ID="PROB_SUBTextBox" runat="server" Text='<%# Bind("PROB_SUB") %>'>
            </asp:TextBox><br />
            PROB_DESC:
            <asp:TextBox ID="PROB_DESCTextBox" runat="server" Text='<%# Bind("PROB_DESC") %>'>
            </asp:TextBox><br />
            LOG_DATE:
            <asp:TextBox ID="LOG_DATETextBox" runat="server" Text='<%# Bind("LOG_DATE") %>'>
            </asp:TextBox><br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert"
                Text="Insert">
            </asp:LinkButton>
            <asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel"
                Text="Cancel">
            </asp:LinkButton>
        </InsertItemTemplate>
        <ItemTemplate>
            &nbsp;
            <asp:Label ID="CATLabel" runat="server" ForeColor="White" Style="left: 615px; position: absolute;
                top: 451px" Text='<%# Bind("CAT") %>' Width="115px"></asp:Label>
            <br />
            &nbsp;
            <asp:Label ID="SUBCATLabel" runat="server" ForeColor="White" Style="left: 856px;
                position: absolute; top: 452px" Text='<%# Bind("SUBCAT") %>' Width="131px"></asp:Label>
            <br />
            <asp:Label ID="STATUSLabel" runat="server" ForeColor="White" Style="left: 856px;
                position: absolute; top: 393px" Text='<%# Bind("STATUS") %>'></asp:Label>
            <br />
            <asp:Label ID="SITE_IDLabel" runat="server" ForeColor="White" Style="left: 371px;
                position: absolute; top: 396px" Text='<%# Bind("SITE_ID") %>' Width="108px"></asp:Label>
            <br />
            &nbsp;
            <asp:Label ID="TCK_COMP_NAMELabel" runat="server" ForeColor="White" Style="left: 614px;
                position: absolute; top: 395px" Text='<%# Bind("TCK_COMP_NAME") %>' Width="210px"></asp:Label>
            <br />
            &nbsp;
            <asp:Label ID="HLPDEKLabel" runat="server" ForeColor="White" Style="left: 374px;
                position: absolute; top: 450px" Text='<%# Bind("HLPDEK") %>' Width="128px"></asp:Label>
            <br />
            &nbsp;
            <asp:Label ID="PRIORITYLabel" runat="server" ForeColor="White" Style="left: 616px;
                position: absolute; top: 341px" Text='<%# Bind("PRIORITY") %>'></asp:Label>
            <br />
            &nbsp;
            <asp:Label ID="PROB_SUBLabel" runat="server" ForeColor="White" Height="25px" Style="left: 374px;
                position: absolute; top: 505px" Text='<%# Bind("PROB_SUB") %>' Width="597px"></asp:Label>
            <br />
            &nbsp;
            <asp:Label ID="PROB_DESCLabel" runat="server" ForeColor="White" Height="86px" Style="left: 374px;
                position: absolute; top: 593px" Text='<%# Bind("PROB_DESC") %>' Width="593px"></asp:Label>
            &nbsp;<br />
            &nbsp;
            <br />
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
