<%@ Reference Page="~/ui/complain.aspx" %>
<%@ Page language="c#" Inherits="E_HELP_DESK1.UI.complainstatus" CodeFile="complainstatus.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>complainstatus</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#ebedf3">
		<form id="Form1" style="LEFT: 0px; WIDTH: 793px; POSITION: absolute; TOP: 0px; HEIGHT: 416px"
			method="post" runat="server">
			<table style="WIDTH: 792px; HEIGHT: 416px">
				<tr>
					<td vAlign="top">
						<table style="WIDTH: 785px; HEIGHT: 392px">
							<tr>
								<td style="FONT-WEIGHT: bold; HEIGHT: 20px" align="center" height="20">Registered 
									Complain Section
								</td>
							</tr>
							<tr>
								<td style="HEIGHT: 201px"><asp:datagrid id="DataGrid1" runat="server" OnPageIndexChanged="ChangeGridPage" AllowPaging="True"
										Width="776px" BorderColor="#999999" BorderWidth="1px" BackColor="White" CellPadding="0" GridLines="Vertical" ForeColor="Black"
										BorderStyle="Solid" AutoGenerateColumns="False" DataKeyField="COMP_NO" Height="192px" PageSize="5" onselectedindexchanged="DataGrid1_SelectedIndexChanged">
										<FooterStyle BackColor="#CCCCCC"></FooterStyle>
										<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#000099"></SelectedItemStyle>
										<AlternatingItemStyle BackColor="#CCCCCC"></AlternatingItemStyle>
										<HeaderStyle Font-Size="Smaller" Font-Names="Times New Roman" Font-Bold="True" HorizontalAlign="Justify"
											ForeColor="White" VerticalAlign="Middle" BackColor="Black"></HeaderStyle>
										<Columns>
											<asp:BoundColumn DataField="COMP_NO" HeaderText="NUMBER">
												<HeaderStyle Width="70px"></HeaderStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="COMP_TYPE" HeaderText="TYPE">
												<HeaderStyle Width="100px"></HeaderStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="SITE_NAME" HeaderText="SITE">
												<HeaderStyle Width="70px"></HeaderStyle>
											</asp:BoundColumn>
											<asp:ButtonColumn Text="Button" DataTextField="CMPSUB" HeaderText="SUBJECT" CommandName="CMPSUB1">
												<HeaderStyle Width="300px"></HeaderStyle>
											</asp:ButtonColumn>
											<asp:BoundColumn DataField="COMP_STATUS" HeaderText="STATUS">
												<HeaderStyle Width="70px"></HeaderStyle>
											</asp:BoundColumn>
										</Columns>
										<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
									</asp:datagrid></td>
							</tr>
							<tr>
								<td>
									<table style="WIDTH: 742px; HEIGHT: 30px">
										<tr>
											<td style="WIDTH: 469px"><asp:textbox id="Txtdtl" runat="server" Width="400px" Height="101px" TextMode="MultiLine" ReadOnly="True"></asp:textbox></td>
											<td><asp:textbox id="txtdtl2" runat="server" Width="364px" BackColor="#EBEDF3" ForeColor="Black"
													Height="98px" TextMode="MultiLine" ReadOnly="True"></asp:textbox></td>
										</tr>
									</table>
								</td>
							</tr>
							<tr>
								<td align="center"><asp:button id="Btnundertaken" runat="server" BackColor="#EBEDF3" Text="Undertaken" Enabled="False" onclick="Btnundertaken_Click"></asp:button></td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
