<%@ Page language="c#" Inherits="E_HELP_DESK1.UI.MyComplain" CodeFile="MyComplain.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>MyComplain</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script language="JavaScript">
		</script>
	</HEAD>
	<body bgColor="#ebedf3">
		<FORM id="Form1" style="LEFT: 0px; WIDTH: 793px; POSITION: absolute; TOP: 0px; HEIGHT: 504px"
			method="post" runat="server">
			<TABLE id="Table1" style="WIDTH: 792px; HEIGHT: 504px">
				<TR>
					<TD>
						<TABLE id="Table2" style="WIDTH: 784px; HEIGHT: 472px">
							<TR>
								<TD style="FONT-WEIGHT: bold; HEIGHT: 40px" align="center" height="10"><asp:label id="Lblusrname" runat="server">Label</asp:label>&nbsp;
									<HR width="100%" SIZE="1">
									<asp:datagrid id="DGMyCmp" runat="server" OnItemCommand="DGMyCmp_ItemCommand" PageSize="5" Height="192px"
										DataKeyField="COMP_NO" AutoGenerateColumns="False" BorderStyle="Solid" ForeColor="Black" GridLines="Vertical"
										CellPadding="3" BackColor="White" BorderWidth="1px" BorderColor="#999999" Width="776px" AllowPaging="True"
										OnPageIndexChanged="ChangeGridPage" onselectedindexchanged="DGMyCmp_SelectedIndexChanged">
										<FooterStyle BackColor="#CCCCCC"></FooterStyle>
										<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#000099"></SelectedItemStyle>
										<AlternatingItemStyle BackColor="#CCCCCC"></AlternatingItemStyle>
										<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
										<Columns>
											<asp:BoundColumn DataField="COMP_NO" HeaderText="NUMBER">
												<HeaderStyle Font-Size="Smaller" Width="70px"></HeaderStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="COMP_TYPE" HeaderText="TYPE">
												<HeaderStyle Font-Size="Smaller" Width="100px"></HeaderStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="SITE_NAME" HeaderText="SITE">
												<HeaderStyle Font-Size="Smaller" Width="70px"></HeaderStyle>
											</asp:BoundColumn>
											<asp:ButtonColumn Text="Button" DataTextField="CMPSUB" HeaderText="SUBJECT" CommandName="CMPSUB1">
												<HeaderStyle Font-Size="Smaller" Width="300px"></HeaderStyle>
											</asp:ButtonColumn>
											<asp:BoundColumn DataField="COMP_STATUS" HeaderText="STATUS">
												<HeaderStyle Font-Size="Smaller" Width="70px"></HeaderStyle>
											</asp:BoundColumn>
										</Columns>
										<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
									</asp:datagrid></TD>
							</TR>
							<TR>
								<TD><asp:textbox id="txtcmpdtl" runat="server" Height="114px" Width="392px" ReadOnly="True" TextMode="MultiLine"></asp:textbox><asp:textbox id="TxtCmpdtl2" runat="server" Height="114px" Width="376px" ReadOnly="True" TextMode="MultiLine"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 35px" vAlign="middle" align="center"><asp:label id="Label1" runat="server">Remark</asp:label><asp:textbox id="TxtRemark" runat="server" Height="25px" Width="683px" Enabled="False" MaxLength="200"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 19px" align="center">
									<TABLE style="WIDTH: 775px; HEIGHT: 25px">
										<TR>
											<td style="WIDTH: 132px"><asp:button id="btnsendback" runat="server" BackColor="#EBEDF3" Width="100px" Enabled="False"
													Text="Send Back" onclick="btnsendback_Click"></asp:button></td>
											<td style="WIDTH: 59px"><asp:button id="BtnChkcmp" runat="server" BackColor="#EBEDF3" Width="86px" Enabled="False" Text="Check" onclick="BtnChkcmp_Click"></asp:button></td>
											<TD style="WIDTH: 183px" align="center"><asp:button id="btndone" runat="server" BackColor="#EBEDF3" Width="100px" Enabled="False" Text="Resolved" onclick="btndone_Click"></asp:button></TD>
											<TD style="WIDTH: 148px"><asp:button id="btnforward" runat="server" BackColor="#EBEDF3" Width="100px" Enabled="False"
													Text="Forward" onclick="btnforward_Click"></asp:button></TD>
											<TD><asp:dropdownlist id="DDvndrname" runat="server" BackColor="#EBEDF3" Width="152px" Enabled="False"
													AutoPostBack="True" onselectedindexchanged="DDvndrname_SelectedIndexChanged"></asp:dropdownlist><asp:button id="btnsend" runat="server" Height="23px" BackColor="#EBEDF3" Enabled="False" Text="Send" onclick="btnsend_Click"></asp:button></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
							<tr>
								<td></td>
							</tr>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</FORM>
	</body>
</HTML>
