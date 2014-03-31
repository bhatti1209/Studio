<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PageDesign.Master" AutoEventWireup="true"
    CodeBehind="HomePage.aspx.cs" Inherits="DraftWebPage.WebForm1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="DisplayData" runat="server">
    <div style="z-index: 1; left: 2px; top: 3px; position: absolute; height: 478px; width: 720px">
         <asp:Label ID="Label1" runat="server" Style="z-index: 1; left: 175px; top: 27px;
                position: absolute; height: 22px; width: 242px" Text="Welcome To Incident Report !!"
                Font-Italic="True" Font-Names="Calibri" Font-Overline="False" Font-Underline="True"
                ForeColor="#8AD338"></asp:Label>
        <asp:Panel ID="Panel1" runat="server" BackColor="#E0F2B5" BorderColor="#999999" BorderStyle="Solid"
            BorderWidth="1px" Style="z-index: 1; left: 14px; top: 63px; position: absolute;
            height: 323px; width: 692px">
            <asp:Label ID="Label2" runat="server" Style="z-index: 1; left: 115px; top: 31px;
                position: absolute; width: 259px" 
                Text="Please Select A Link Below To Continue :"></asp:Label>
            <asp:HyperLink ID="ReportsIRLink" runat="server" Style="z-index: 1; left: 147px;
                top: 190px; position: absolute; width: 175px" 
                NavigateUrl="~/UI/IncidentReport/ReportsIR.aspx">Get Report(s)</asp:HyperLink>
            <asp:HyperLink ID="SearchIRLink" runat="server" Style="z-index: 1; left: 146px; top: 142px;
                position: absolute; width: 175px" 
                NavigateUrl="~/UI/IncidentReport/SearchIR.aspx">Search Incident Reports</asp:HyperLink>
            <asp:HyperLink ID="CreateIRLink" runat="server" Style="z-index: 1; left: 146px; top: 95px;
                position: absolute; width: 175px" 
                NavigateUrl="~/UI/IncidentReport/CreateIR.aspx">Create Incident Report</asp:HyperLink>
        </asp:Panel>
    </div>
</asp:Content>
