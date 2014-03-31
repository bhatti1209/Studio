<%@ Page Language="C#" MasterPageFile="~/UI/AdminFolder/Logo.master" AutoEventWireup="true" CodeFile="EmailIDCreation.aspx.cs" Inherits="UI_AdminFolder_Default" Title="Email Id Creation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Names="Perpetua Titling MT"
        Font-Size="Medium" ForeColor="Red" ReadOnly="True" Style="left: 232px; top: 263px"
        Width="705px">    E-Mail ID Creation Request</asp:TextBox><br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="White" Style="left: 327px;
        position: absolute; top: 357px" Text="Date :"></asp:Label>
    <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="White" Style="left: 578px;
        position: absolute; top: 436px" Text="Suggested Name :" Width="133px"></asp:Label>
    <asp:TextBox ID="suggestednamebox" runat="server" Style="left: 722px; position: absolute;
        top: 435px" Width="127px" TabIndex="4"></asp:TextBox>
    <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="White" Style="left: 553px;
        position: absolute; top: 517px" Text="Forward For Approval :" Width="158px"></asp:Label>
    <asp:TextBox ID="forwardbox" runat="server" Style="left: 725px; position: absolute;
        top: 516px" TabIndex="6" Width="127px"></asp:TextBox>
    <asp:TextBox ID="Datetextbox" runat="server" ReadOnly="True" Style="left: 401px;
        position: absolute; top: 356px" Width="112px" TabIndex="1"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="White" Style="left: 638px;
        position: absolute; top: 357px" Text="Site ID :" Width="65px"></asp:Label>
    <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="White" Style="left: 327px;
        position: absolute; top: 435px" Text="Type :"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSourceSiteID"
        DataTextField="SITEID" DataValueField="SITEID" Style="left: 721px; position: absolute;
        top: 356px" Width="133px" TabIndex="2" Visible="False">
    </asp:DropDownList><asp:DropDownList ID="DropDownList4" runat="server" Style="left: 722px; position: absolute;
        top: 356px" Width="133px" TabIndex="2">
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList2" runat="server" Style="left: 403px; position: absolute;
        top: 432px" Width="116px" TabIndex="3">
        <asp:ListItem>User</asp:ListItem>
        <asp:ListItem>Generic</asp:ListItem>
        <asp:ListItem>Site</asp:ListItem>
    </asp:DropDownList>
    <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="White" Style="left: 274px;
        position: absolute; top: 517px" Text="Submitted By :"></asp:Label>
    <asp:Label ID="Label15" runat="server" Font-Bold="True" ForeColor="White" Style="left: 287px;
        position: absolute; top: 555px" Text="Upload File :"></asp:Label>
    <asp:DropDownList ID="DropDownList3" runat="server" Style="left: 403px; position: absolute;
        top: 514px" Width="115px" TabIndex="5" DataSourceID="ObjectDataSource1" DataTextField="USER_NAME" DataValueField="USER_NAME">
    </asp:DropDownList>
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 372px;
        position: absolute; top: 517px" Text="*" Width="9px"></asp:Label>
    <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 710px;
        position: absolute; top: 517px" Text="*" Width="9px"></asp:Label>
    <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 706px;
        position: absolute; top: 437px" Text="*" Width="9px"></asp:Label>
    <asp:Label ID="Label9" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 698px;
        position: absolute; top: 358px" Text="*" Width="9px"></asp:Label>
    <br />
    <br />
    <asp:FileUpload ID="FileUpload1" runat="server" Style="left: 404px; position: absolute;
        top: 554px" Width="455px" />
    <br />
    <br />
    <br />
    <asp:Label ID="Label10" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 340px;
        position: absolute; top: 590px" Text="Please Select SiteID !!" Visible="False"
        Width="181px"></asp:Label>
    <asp:Label ID="Label13" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 340px;
        position: absolute; top: 630px" Text="Please Select Submitted By !!" Visible="False"
        Width="224px"></asp:Label>
    <asp:Label ID="Label12" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 583px;
        position: absolute; top: 590px" Text="Please Enter Suggested Name !!" Visible="False"
        Width="251px"></asp:Label>
    <asp:Label ID="Label14" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 583px;
        position: absolute; top: 629px" Text="Please Enter Forward Address!!" Visible="False"
        Width="251px"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Button ID="submitbutton" runat="server" Style="left: 471px; position: absolute;
        top: 676px" Text="Submit" Width="95px" />
    <asp:Button ID="resetbutton" runat="server" OnClick="resetbutton_Click" Style="left: 627px;
        position: absolute; top: 676px" Text="Reset" Width="95px" />
    <br />
    <br />
    <br />
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
    <br />
    <br />
</asp:Content>
