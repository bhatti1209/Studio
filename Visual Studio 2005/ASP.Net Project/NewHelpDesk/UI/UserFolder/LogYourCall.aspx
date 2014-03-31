<%@ Page Language="C#" MasterPageFile="~/UI/UserFolder/Logo.master" AutoEventWireup="true" CodeFile="LogYourCall.aspx.cs" Inherits="UI_AdminFolder_Default2" Title="Log Your Call" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Names="Perpetua Titling MT"
        Font-Size="Medium" ForeColor="Red" Width="725px" ReadOnly="True" style="left: 232px; position: absolute; top: 263px">    Log Call</asp:TextBox><br />
    <br />
    &nbsp;
    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="White" Text="Date :" style="position: absolute; left: 268px; top: 325px;"></asp:Label>
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp;&nbsp;<asp:TextBox ID="Datetextbox"
        runat="server" ReadOnly="True" style="position: absolute; left: 344px; top: 322px;" Width="74px" TabIndex="1"></asp:TextBox>
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp;<br />
    &nbsp;
    <br />
    &nbsp;
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="White" Text="HelpDesk :" style="position: absolute; left: 238px; top: 422px;"></asp:Label>
    &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;
    &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" style="position: absolute; left: 344px; top: 422px;" TabIndex="5">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>IT</asp:ListItem>
        <asp:ListItem>GIS</asp:ListItem>
        <asp:ListItem>Application</asp:ListItem>
    </asp:DropDownList><asp:DropDownList ID="DropDownList2" runat="server" style="left: 542px; position: absolute; top: 422px;" AutoPostBack="True" DataSourceID="AccessDataSource1" DataTextField="Blank_Field" DataValueField="Blank_Field" TabIndex="6">
    </asp:DropDownList>
    &nbsp;
     <asp:DropDownList ID="DropDownList3" runat="server" Style="left: 822px; position: absolute; top: 421px;" DataSourceID="AccessDataSourceSC1" DataTextField="Blank_Field" DataValueField="Blank_Field" TabIndex="7">
    </asp:DropDownList>
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:Label
        ID="Label3" runat="server" Font-Bold="True" Font-Italic="False" ForeColor="White"
        Text="Category" style="position: absolute; left: 463px; top: 424px;"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp; &nbsp;&nbsp;
    <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="Red" Height="21px"
        Style="left: 805px; position: absolute; top: 422px" Text="*"></asp:Label>
    <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 528px;
        position: absolute; top: 424px" Text="*" Width="9px"></asp:Label>
    <asp:Label ID="Label10" runat="server" Font-Bold="True" ForeColor="White" Style="left: 703px;
        position: absolute; top: 423px" Text="Sub-Category :" Width="102px"></asp:Label>
    <asp:Label ID="Label12" runat="server" Font-Bold="True" ForeColor="White" Style="left: 492px;
        position: absolute; top: 324px;" Text="Site Id :" Width="56px"></asp:Label>
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;
    <asp:DropDownList ID="DropDownList4" runat="server" Style="left: 555px; position: absolute;
        top: 322px;" DataSourceID="SqlDataSourceSiteID" DataTextField="SITEID" DataValueField="SITEID" TabIndex="2" Visible="False">
    </asp:DropDownList><asp:DropDownList ID="DropDownList6" runat="server" Style="left: 555px; position: absolute;
        top: 322px;" TabIndex="2" Width="89px">
    </asp:DropDownList>
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; 
    <asp:Label ID="Label15" runat="server" Font-Bold="True" ForeColor="White" Style="left: 254px;
        position: absolute; top: 377px" Text="Priority :"></asp:Label>
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp;&nbsp; <strong style="left: 315px; color: red; position: absolute; top: 503px">
        *</strong>
    <asp:Label ID="Label13" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 634px;
        position: absolute; top: 900px" Text="Please Enter Problem Subject !!" Visible="False"
        Width="215px"></asp:Label>
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp;&nbsp;
    <br />
    <asp:DropDownList ID="DropDownList5" runat="server" Style="left: 344px; position: absolute;
        top: 374px" Width="92px" TabIndex="4">
        <asp:ListItem Selected="True">Low</asp:ListItem>
        <asp:ListItem>Medium</asp:ListItem>
        <asp:ListItem>High</asp:ListItem>
    </asp:DropDownList>
    <br />
                &nbsp;
                <asp:Label ID="Label5" runat="server" Text="Subject :" Font-Bold="True" ForeColor="White" style="position: absolute; left: 254px; top: 502px;"></asp:Label>
    &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
    &nbsp;
    <asp:TextBox ID="SubjectBox" runat="server" Width="543px" style="position: absolute; left: 342px; top: 500px;" TabIndex="8" ></asp:TextBox><br />
    <br />
    <br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp;
    <asp:TextBox ID="problembox" runat="server" Height="193px" Width="542px" style="position: absolute; left: 345px; top: 553px;" TextMode="MultiLine" TabIndex="9"></asp:TextBox><br />
    &nbsp;&nbsp;
    <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="White" Text="Problem Description"
        Width="72px" style="left: 241px; position: absolute; top: 641px"></asp:Label><strong style="color:Red; position:absolute; top:647px; left:324px">*</strong>&nbsp;<br />
    &nbsp; &nbsp;<br />
    &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;<br />
    <br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp;&nbsp;
    <br />
    <br />
    <br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp;&nbsp;
    <br />
    <br />
    <br />
    <br />
    &nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="White" Style="position: absolute; left: 246px; top: 774px;"
        Text="Attach File :"></asp:Label>
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
    <asp:FileUpload ID="FileUpload1" runat="server" Style="position: absolute; left: 348px; top: 773px;" Width="552px" TabIndex="10" />
    <br />
    <br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp;&nbsp; &nbsp;
    <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True" Style="position: absolute; left: 351px; top: 805px;"
        Width="287px">*Max Attachment Size Can Be 2MB (JPEG Only)</asp:TextBox>
    &nbsp;<br />
    <br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp;&nbsp;
    <asp:Label ID="Label9" runat="server" Font-Bold="True" ForeColor="Red" Style="position: absolute; left: 351px; top: 847px;"
        Text="Please Select Category !!" Visible="False" Width="175px"></asp:Label>
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    <br />
    <br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp;
    <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="Red" Style="position: absolute; left: 351px; top: 901px;"
        Text="Please Enter The Problem Description !!" Visible="False" Width="278px"></asp:Label>
    <asp:Label ID="Label14" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 351px;
        position: absolute; top: 874px" Text="Please Select Sub-Category !!" Visible="False"
        Width="214px"></asp:Label>
    &nbsp;<br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
    <asp:Button ID="SubmitButton" runat="server" Style="position: absolute; left: 534px; top: 932px;" Text="Submit" OnClick="SubmitButton_Click" TabIndex="11" />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp;
    <asp:Button ID="ResetButton" runat="server" Style="position: absolute; left: 633px; top: 932px;" Text="Reset" OnClick="ResetButton_Click" TabIndex="12" />
    &nbsp;<br />
    <br />
    <br />
    <asp:SqlDataSource ID="SqlDataSourceSiteID" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT SITEID FROM NHD_SITEDB ORDER BY SITEID">
    </asp:SqlDataSource>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/DropDownList.mdb"
        SelectCommand="SELECT [IT-Category] AS column1, [Blank Field] AS Blank_Field FROM [IT-Category]">
    </asp:AccessDataSource>
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
</asp:Content>
