<%@ Page language="c#" Inherits="E_HELP_DESK1.UI.HomeFrame" CodeFile="HomeFrame.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>HomeFrame</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body bgColor="#ebedf3">
		<form id="Form1" method="post" runat="server" style="Z-INDEX: 101; LEFT: 0px; WIDTH: 801px; POSITION: absolute; TOP: 0px; HEIGHT: 464px">
			<asp:DataGrid id="dghome" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Width="792px" Height="456px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" BackColor="White"
				CellPadding="3" GridLines="Vertical" ForeColor="Black" AllowPaging="True" PageSize="15" AutoGenerateColumns="False"
				OnPageIndexChanged="ChangeGridPage" Font-Size="Smaller">
				<FooterStyle BackColor="#CCCCCC"></FooterStyle>
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#000099"></SelectedItemStyle>
				<AlternatingItemStyle BackColor="#CCCCCC"></AlternatingItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
				<Columns>
					<asp:BoundColumn DataField="COMP_NO" HeaderText="CMP NO">
						<HeaderStyle Width="60px"></HeaderStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="COMP_TYPE" HeaderText="TYPE">
						<HeaderStyle Width="100px"></HeaderStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="SITE_NAME" HeaderText="SITE">
						<HeaderStyle Width="100px"></HeaderStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="COMP_REG_DATE_TIME" HeaderText="REG TIME">
						<HeaderStyle Width="150px"></HeaderStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="COMP_HANDLE_BY" HeaderText="HANDLE BY">
						<HeaderStyle Width="100px"></HeaderStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="COMP_STATUS" HeaderText="STATUS">
						<HeaderStyle Width="60px"></HeaderStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="COMP_HANDLE_DATE_TIME" HeaderText="HANDLE DATE-TIME">
						<HeaderStyle Width="150px"></HeaderStyle>
					</asp:BoundColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid>
		</form>
	</body>
</HTML>
