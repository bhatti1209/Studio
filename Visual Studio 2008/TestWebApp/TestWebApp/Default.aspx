<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestWebApp._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 488px">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="buttonupdate" runat="server" UpdateMode="Always">
            <ContentTemplate>
                <asp:Label ID="Label1" Style="z-index: 1; left: 394px; top: 50px; position: absolute;
                    height: 20px; width: 169px;" runat="server" Text="Label"></asp:Label>
                <asp:Table ID="Table1" runat="server" Style="z-index: 1; left: 280px; top: 113px;
                    position: absolute; height: 139px; width: 472px">
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server"></asp:TableCell>
                        <asp:TableCell runat="server" Wrap="False">Name</asp:TableCell>
                        <asp:TableCell runat="server">Age</asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server"></asp:TableCell>
                        <asp:TableCell runat="server">
                        </asp:TableCell>
                        <asp:TableCell runat="server">
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell ColumnSpan="3">
                            <asp:Button ID="AddButton" runat="server" Text="Button" OnClick="AddButton_Click" />
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:AccessDataSource ID="DDInfo2" runat="server" DataFile="~/App_Data/Database1.mdb"
            SelectCommand="SELECT [Names] FROM [Names]"></asp:AccessDataSource>
    </div>
    </form>
</body>
</html>
