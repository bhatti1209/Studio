<%@ Page Language="C#" MasterPageFile="~/UI/UserFolder/Logo.master" AutoEventWireup="true" CodeFile="SiteDetails.aspx.cs" Inherits="UI_UserFolder_Default" Title="Site Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Names="Perpetua Titling MT"
        Font-Size="Medium" ForeColor="Red" ReadOnly="True" Style="left: 232px; top: 263px"
        Width="813px">    SITE Details</asp:TextBox><br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:FormView ID="FormView1" runat="server" AllowPaging="True" CellPadding="4" DataSourceID="SqlDataSource1" Height="260px" Width="709px" style="left: 267px; position: absolute; top: 352px" ForeColor="#333333">
        <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
        <EditRowStyle BackColor="#999999" />
        <EditItemTemplate>
            SITEID:
            <asp:TextBox ID="SITEIDTextBox" runat="server" Text='<%# Bind("SITEID") %>'>
            </asp:TextBox><br />
            SITENAME:
            <asp:TextBox ID="SITENAMETextBox" runat="server" Text='<%# Bind("SITENAME") %>'>
            </asp:TextBox><br />
            LOCATION:
            <asp:TextBox ID="LOCATIONTextBox" runat="server" Text='<%# Bind("LOCATION") %>'>
            </asp:TextBox><br />
            TYPEOFOFFICE:
            <asp:TextBox ID="TYPEOFOFFICETextBox" runat="server" Text='<%# Bind("TYPEOFOFFICE") %>'>
            </asp:TextBox><br />
            LOCATIONADDRESS:
            <asp:TextBox ID="LOCATIONADDRESSTextBox" runat="server" Text='<%# Bind("LOCATIONADDRESS") %>'>
            </asp:TextBox><br />
            CONTACTNAME:
            <asp:TextBox ID="CONTACTNAMETextBox" runat="server" Text='<%# Bind("CONTACTNAME") %>'>
            </asp:TextBox><br />
            CONTACTPHONENO:
            <asp:TextBox ID="CONTACTPHONENOTextBox" runat="server" Text='<%# Bind("CONTACTPHONENO") %>'>
            </asp:TextBox><br />
            CONTACTEMAILID:
            <asp:TextBox ID="CONTACTEMAILIDTextBox" runat="server" Text='<%# Bind("CONTACTEMAILID") %>'>
            </asp:TextBox><br />
            NETWORKIP:
            <asp:TextBox ID="NETWORKIPTextBox" runat="server" Text='<%# Bind("NETWORKIP") %>'>
            </asp:TextBox><br />
            GATEWAYIP:
            <asp:TextBox ID="GATEWAYIPTextBox" runat="server" Text='<%# Bind("GATEWAYIP") %>'>
            </asp:TextBox><br />
            SUBMASK:
            <asp:TextBox ID="SUBMASKTextBox" runat="server" Text='<%# Bind("SUBMASK") %>'>
            </asp:TextBox><br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update"
                Text="Update">
            </asp:LinkButton>
            <asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel"
                Text="Cancel">
            </asp:LinkButton>
        </EditItemTemplate>
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <InsertItemTemplate>
            SITEID:
            <asp:TextBox ID="SITEIDTextBox" runat="server" Text='<%# Bind("SITEID") %>'>
            </asp:TextBox><br />
            SITENAME:
            <asp:TextBox ID="SITENAMETextBox" runat="server" Text='<%# Bind("SITENAME") %>'>
            </asp:TextBox><br />
            LOCATION:
            <asp:TextBox ID="LOCATIONTextBox" runat="server" Text='<%# Bind("LOCATION") %>'>
            </asp:TextBox><br />
            TYPEOFOFFICE:
            <asp:TextBox ID="TYPEOFOFFICETextBox" runat="server" Text='<%# Bind("TYPEOFOFFICE") %>'>
            </asp:TextBox><br />
            LOCATIONADDRESS:
            <asp:TextBox ID="LOCATIONADDRESSTextBox" runat="server" Text='<%# Bind("LOCATIONADDRESS") %>'>
            </asp:TextBox><br />
            CONTACTNAME:
            <asp:TextBox ID="CONTACTNAMETextBox" runat="server" Text='<%# Bind("CONTACTNAME") %>'>
            </asp:TextBox><br />
            CONTACTPHONENO:
            <asp:TextBox ID="CONTACTPHONENOTextBox" runat="server" Text='<%# Bind("CONTACTPHONENO") %>'>
            </asp:TextBox><br />
            CONTACTEMAILID:
            <asp:TextBox ID="CONTACTEMAILIDTextBox" runat="server" Text='<%# Bind("CONTACTEMAILID") %>'>
            </asp:TextBox><br />
            NETWORKIP:
            <asp:TextBox ID="NETWORKIPTextBox" runat="server" Text='<%# Bind("NETWORKIP") %>'>
            </asp:TextBox><br />
            GATEWAYIP:
            <asp:TextBox ID="GATEWAYIPTextBox" runat="server" Text='<%# Bind("GATEWAYIP") %>'>
            </asp:TextBox><br />
            SUBMASK:
            <asp:TextBox ID="SUBMASKTextBox" runat="server" Text='<%# Bind("SUBMASK") %>'>
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
            <asp:Label ID="SITEIDLabel" runat="server" Style="left: 106px; position: absolute;
                top: 27px" Text='<%# Bind("SITEID") %>' Width="193px"></asp:Label>
            <asp:Label ID="Label1" runat="server" Style="left: 59px; position: absolute; top: 27px"
                Text="Site Id :"></asp:Label>
            <asp:Label ID="Label2" runat="server" Style="left: 22px; position: absolute; top: 80px"
                Text="Site Address  :"></asp:Label>
            <asp:Label ID="Label3" runat="server" Style="left: 16px; position: absolute; top: 138px"
                Text="Contact Name  :"></asp:Label>
            <asp:Label ID="Label4" runat="server" Style="left: 33px; position: absolute; top: 203px"
                Text="Network IP  :"></asp:Label>
            <asp:Label ID="Label5" runat="server" Style="left: 336px; position: absolute; top: 26px"
                Text="Site Id :" Width="50px"></asp:Label>
            <asp:Label ID="Label9" runat="server" Style="left: 563px; position: absolute; top: 81px"
                Text="Site Type :" Width="67px"></asp:Label>
            <asp:Label ID="Label10" runat="server" Style="left: 546px; position: absolute; top: 138px"
                Text="Contact No. :" Width="84px"></asp:Label>
            <asp:Label ID="Label11" runat="server" Style="left: 569px; position: absolute; top: 203px"
                Text="Submask  :"></asp:Label>
            <asp:Label ID="Label6" runat="server" Style="left: 300px; position: absolute; top: 81px"
                Text="Site Location :" Width="89px"></asp:Label>
            <br />
            &nbsp;
            <asp:Label ID="SITENAMELabel" runat="server" Style="left: 390px; position: absolute;
                top: 26px" Text='<%# Bind("SITENAME") %>' Width="183px"></asp:Label>
            <br />
            &nbsp;
            <asp:Label ID="LOCATIONLabel" runat="server" Style="left: 391px; position: absolute;
                top: 80px" Text='<%# Bind("LOCATION") %>' Width="131px"></asp:Label>
            <asp:Label ID="Label8" runat="server" Style="left: 306px; position: absolute; top: 204px"
                Text="Gateway IP  :" Width="83px"></asp:Label>
            <asp:Label ID="Label7" runat="server" Style="left: 278px; position: absolute; top: 138px"
                Text="Contact Mail Id  :" Width="110px"></asp:Label>
            &nbsp;<br />
            &nbsp;
            <asp:Label ID="TYPEOFOFFICELabel" runat="server" Style="left: 635px; position: absolute;
                top: 81px" Text='<%# Bind("TYPEOFOFFICE") %>' Width="162px"></asp:Label>
            <br />
            &nbsp;
            <asp:Label ID="LOCATIONADDRESSLabel" runat="server" Style="left: 104px; position: absolute;
                top: 80px" Text='<%# Bind("LOCATIONADDRESS") %>' Width="181px"></asp:Label>
            <br />
            &nbsp;
            <asp:Label ID="CONTACTNAMELabel" runat="server" Style="left: 108px; position: absolute;
                top: 138px" Text='<%# Bind("CONTACTNAME") %>' Width="177px"></asp:Label>
            <br />
            &nbsp;
            <asp:Label ID="CONTACTPHONENOLabel" runat="server" Style="left: 629px; position: absolute;
                top: 138px" Text='<%# Bind("CONTACTPHONENO") %>'></asp:Label>
            <br />
            &nbsp;
            <asp:Label ID="CONTACTEMAILIDLabel" runat="server" Style="left: 395px; position: absolute;
                top: 137px" Text='<%# Bind("CONTACTEMAILID") %>'></asp:Label>
            <br />
            &nbsp;
            <asp:Label ID="NETWORKIPLabel" runat="server" Style="left: 110px; position: absolute;
                top: 204px" Text='<%# Bind("NETWORKIP") %>' Width="143px"></asp:Label>
            <br />
            &nbsp;
            <asp:Label ID="GATEWAYIPLabel" runat="server" Style="left: 394px; position: absolute;
                top: 203px" Text='<%# Bind("GATEWAYIP") %>' Width="138px"></asp:Label>
            <br />
            &nbsp;
            <asp:Label ID="SUBMASKLabel" runat="server" Style="left: 633px; position: absolute;
                top: 203px" Text='<%# Bind("SUBMASK") %>' Width="130px"></asp:Label>
            <br />
        </ItemTemplate>
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    </asp:FormView>
    <br />
    <br />
    &nbsp;<br />
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
        ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT NHD_SITEDB.* FROM NHD_SITEDB">
    </asp:SqlDataSource>
</asp:Content>
