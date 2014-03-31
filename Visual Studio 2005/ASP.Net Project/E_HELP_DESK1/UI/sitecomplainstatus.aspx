<%@ Page language="c#" Inherits="E_HELP_DESK1.UI.SiteComplainStatus" CodeFile="SiteComplainStatus.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>SiteComplainStatus</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<table style="WIDTH: 985px; HEIGHT: 570px" cellSpacing="0" cellPadding="0" width="985"
				border="0">
				<TBODY>
					<tr>
						<td style="HEIGHT: 88px" colSpan="2"><IMG style="WIDTH: 982px; HEIGHT: 103px" height="20" alt="" src="../images/top.jpg" width="982"></td>
					</tr>
					<tr>
						<td style="HEIGHT: 420px" vAlign="top" background="../images/leftbg.jpg">
							<asp:LinkButton id="Linkhome" runat="server" Width="168px" BackColor="Transparent" onclick="LinkButton1_Click">Home</asp:LinkButton><br>
							<asp:LinkButton id="Linkhelp" runat="server" Width="168px" BackColor="Transparent" onclick="Linkhelp_Click">Help</asp:LinkButton><br>
							<asp:LinkButton id="Linklogout" runat="server" Width="168px" BackColor="Transparent" onclick="Linklogout_Click">Logout</asp:LinkButton><br>
							<br>
							<br>
							<br>
							<br>
						</td>
						<td style="HEIGHT: 420px" vAlign="top" width="807" bgColor="#ebedf3">
							<asp:DataGrid id="dghome" runat="server" Width="802px" Height="456px" BorderColor="#999999" BorderStyle="Solid"
								BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Vertical" ForeColor="Black"
								AllowPaging="True" PageSize="15" AutoGenerateColumns="False" OnPageIndexChanged="ChangeGridPage"
								Font-Size="Smaller" onselectedindexchanged="dghome_SelectedIndexChanged">
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
						</td>
					</tr>
				</TBODY>
			</table>
		</form>
	</body>
</HTML>
