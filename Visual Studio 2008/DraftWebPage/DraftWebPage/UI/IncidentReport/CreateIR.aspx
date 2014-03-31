<%@ Page Title="" Language="C#" MasterPageFile="../PageDesign.Master" AutoEventWireup="true"
    CodeBehind="CreateIR.aspx.cs" Inherits="DraftWebPage.UI.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="DisplayData" runat="server">
    <div style="z-index: 1; left: 2px; top: 3px; position: absolute; height: 478px; width: 720px">
        <asp:Label ID="Label1" runat="server" Style="z-index: 1; left: 239px; top: 27px;
            position: absolute; height: 22px; width: 222px" Text="Welcome To Report Creation !!"
            Font-Italic="True" Font-Names="Calibri" Font-Overline="False" Font-Underline="True"
            ForeColor="#8AD338"></asp:Label>
        <asp:Panel ID="Panel1" runat="server" BackColor="#E0F2B5" BorderColor="#999999" BorderStyle="Solid"
            BorderWidth="1px" Style="z-index: 1; left: 14px; top: 63px; position: absolute;
            height: 357px; width: 692px">
            <asp:Label ID="Label2" runat="server" Style="z-index: 1; left: 149px; top: 26px;
                position: absolute; width: 370px" Text="Please Select Item(s) From The List Below And Press Next"></asp:Label>
            <asp:Panel ID="Panel4" runat="server" Style="z-index: 1; left: 81px; top: 167px;
                position: absolute; height: 83px; width: 506px" BackColor="#EFF3B6" BorderColor="#999999"
                BorderStyle="Solid" BorderWidth="1px">
                <asp:CheckBoxList ID="CheckBoxList5" runat="server" Style="z-index: 1; left: 271px;
                    top: 10px; position: absolute; height: 57px; width: 106px">
                    <asp:ListItem>BNM</asp:ListItem>
                    <asp:ListItem>RTY</asp:ListItem>
                </asp:CheckBoxList>
                <asp:CheckBoxList ID="CheckBoxList4" runat="server" Style="z-index: 1; left: 151px;
                    top: 12px; position: absolute; height: 57px; width: 106px">
                    <asp:ListItem>BNM</asp:ListItem>
                    <asp:ListItem>RTY</asp:ListItem>
                </asp:CheckBoxList>
                <asp:CheckBoxList ID="CheckBoxList3" runat="server" Style="z-index: 1; left: 18px;
                    top: 13px; position: absolute; height: 57px; width: 106px">
                    <asp:ListItem>BNM</asp:ListItem>
                    <asp:ListItem>RTY</asp:ListItem>
                </asp:CheckBoxList>
            </asp:Panel>
            <asp:Panel ID="Panel3" runat="server" BackColor="#EFF3B6" BorderColor="#999999" BorderStyle="Solid"
                BorderWidth="1px" Style="z-index: 1; left: 419px; top: 64px; position: absolute;
                height: 83px; width: 126px">
                <asp:CheckBoxList ID="CheckBoxList2" runat="server" Style="z-index: 1; left: 18px;
                    top: 13px; position: absolute; height: 57px; width: 106px">
                    <asp:ListItem>ASD</asp:ListItem>
                    <asp:ListItem>QWE</asp:ListItem>
                </asp:CheckBoxList>
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server" BackColor="#EFF3B6" BorderColor="#999999" BorderStyle="Solid"
                BorderWidth="1px" Style="z-index: 1; left: 137px; top: 67px; position: absolute;
                height: 83px; width: 126px">
                <asp:CheckBoxList ID="CheckBoxList1" runat="server" Style="z-index: 1; left: 18px;
                    top: 13px; position: absolute; height: 57px; width: 106px">
                    <asp:ListItem>Injury</asp:ListItem>
                    <asp:ListItem>Illness</asp:ListItem>
                </asp:CheckBoxList>
            </asp:Panel>
            <asp:ImageButton ID="NextButton" runat="server" ImageUrl="~/Images/Buttons/FrwdArrow2.jpg"
                Style="z-index: 3; left: 520px; top: 292px; position: absolute; height: 44px;
                width: 48px" OnClick="NextButton_Click" ToolTip="Next" />
            <asp:ImageButton ID="PreviousButton" runat="server" ImageUrl="~/Images/Buttons/BackButton2.jpg"
                Style="z-index: 3; left: 100px; top: 292px; position: absolute; height: 44px;
                width: 48px" OnClick="PreviousButton_Click" ToolTip="Previous" />
            <asp:ImageButton ID="HelpButton" runat="server" ImageUrl="~/Images/Buttons/HelpButton3.jpg"
                Style="z-index: 3; left: 250px; top: 292px; position: absolute; height: 44px;
                width: 48px" ToolTip="Help !!" />
            <asp:ImageButton ID="CancelButton" runat="server" ImageUrl="~/Images/Buttons/CancelButton4.jpg"
                Style="z-index: 3; left: 400px; top: 292px; position: absolute; height: 44px;
                width: 48px" OnClick="CancelButton_Click" ToolTip="Cancel" />
        </asp:Panel>
    </div>
</asp:Content>
