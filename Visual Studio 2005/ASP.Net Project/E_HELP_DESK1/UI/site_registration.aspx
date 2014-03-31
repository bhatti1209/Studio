<%@ Page language="c#" Inherits="E_HELP_DESK1.UI.Site_registration" CodeFile="Site_registration.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Site_registration</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#ebedf3">
		<form id="Form1" style="LEFT: 0px; WIDTH: 793px; POSITION: absolute; TOP: 0px; HEIGHT: 472px"
			method="post" runat="server">
			<table width="792" bgColor="#ebedf3">
				<tr>
					<td style="FONT-WEIGHT: bold; HEIGHT: 40px" align="center">Pipeline Site 
						Registration
						<HR width="100%" SIZE="1">
					</td>
				</tr>
				<tr>
					<td style="HEIGHT: 40px">
						<table style="WIDTH: 784px; HEIGHT: 30px">
							<tr>
								<td style="WIDTH: 114px" align="center">Site Name
								</td>
								<td style="WIDTH: 242px" align="left"><asp:textbox id="TxtSiteName" runat="server" MaxLength="15"></asp:textbox>
									<asp:RegularExpressionValidator id="RegularExpressionValidator10" runat="server" ControlToValidate="TxtSiteName"
										ErrorMessage="*" ValidationExpression="^[a-zA-Z0-9\s]+$"></asp:RegularExpressionValidator></td>
								<td style="WIDTH: 137px" align="center">Location Code
								</td>
								<td align="left"><asp:textbox id="TxtCode" runat="server" Width="144px" MaxLength="15"></asp:textbox>
									<asp:RegularExpressionValidator id="RegularExpressionValidator11" runat="server" ControlToValidate="TxtCode" ErrorMessage="*"
										ValidationExpression="^[a-zA-Z0-9\s]+$"></asp:RegularExpressionValidator></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td>
						<table style="WIDTH: 784px; HEIGHT: 30px">
							<tr>
								<td style="WIDTH: 114px" align="center">Location
								</td>
								<td style="WIDTH: 241px" align="left"><asp:textbox id="txtLoc" runat="server" Width="216px" MaxLength="50"></asp:textbox>
									<asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" ValidationExpression='^[a-zA-Z0-9\s-+,.:"<>?*=$@.]+$'
										ErrorMessage="*" ControlToValidate="txtLoc"></asp:RegularExpressionValidator></td>
								<td style="WIDTH: 141px" align="center">Type of office
								</td>
								<td align="left"><asp:dropdownlist id="DDOfficeType" runat="server" Width="144px"></asp:dropdownlist></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td>
						<table style="WIDTH: 784px; HEIGHT: 88px">
							<tr>
								<td style="WIDTH: 182px" align="center">Location address
								</td>
								<td align="left"><asp:textbox id="TxtAdd" runat="server" Width="464px" Height="80px" TextMode="MultiLine" MaxLength="200"></asp:textbox>
									<asp:RegularExpressionValidator id="RegularExpressionValidator2" runat="server" ValidationExpression='^[a-zA-Z0-9\s-+,.:"<>?*=$@.]+$'
										ErrorMessage="*" ControlToValidate="TxtAdd"></asp:RegularExpressionValidator></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td align="center">
						<table style="WIDTH: 768px; HEIGHT: 53px">
							<tr>
								<td align="left">Contact person Name
								</td>
								<td align="left">Contact person phone no
								</td>
								<td align="left">Site Contact no
								</td>
								<td align="left">
									Email Id
								</td>
							</tr>
							<tr>
								<td align="left"><asp:textbox id="TxtContPName" runat="server" MaxLength="30"></asp:textbox>
									<asp:RegularExpressionValidator id="RegularExpressionValidator3" runat="server" ErrorMessage="*" ControlToValidate="TxtContPName"
										ValidationExpression="^[a-zA-Z'.\s]+$"></asp:RegularExpressionValidator></td>
								<td align="left"><asp:textbox id="TxtContPhNo" runat="server" MaxLength="15"></asp:textbox>
									<asp:regularexpressionvalidator id="Regularexpressionvalidator4" runat="server" ValidationExpression="^[0-9]+$"
										ErrorMessage="*" ControlToValidate="TxtContPhNo"></asp:regularexpressionvalidator></td>
								<td align="left"><asp:textbox id="TxtSitePhNo" runat="server" MaxLength="15"></asp:textbox>
									<asp:regularexpressionvalidator id="Regularexpressionvalidator5" runat="server" ValidationExpression="^[0-9]+$"
										ErrorMessage="*" ControlToValidate="TxtSitePhNo"></asp:regularexpressionvalidator></td>
								<td align="left"><asp:textbox id="TxtEmail" runat="server" MaxLength="30" ontextchanged="TxtEmail_TextChanged"></asp:textbox>
									<asp:RegularExpressionValidator id="RegularExpressionValidator6" runat="server" ErrorMessage="*" ControlToValidate="TxtEmail"
										ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td align="center">
						<table style="WIDTH: 776px; HEIGHT: 53px">
							<tr>
								<td align="left" style="WIDTH: 259px">
									Network IP Address
								</td>
								<td align="left" style="WIDTH: 259px">
									Gateway IP Address
								</td>
								<td align="left">
									Subnet Mask
								</td>
							</tr>
							<tr>
								<td align="left" style="WIDTH: 259px"><asp:textbox id="TxtTmpNWIP" runat="server" MaxLength="30"></asp:textbox>
									<asp:RegularExpressionValidator id="RegularExpressionValidator7" runat="server" ErrorMessage="*" ControlToValidate="TxtTmpNWIP"
										ValidationExpression="^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$"></asp:RegularExpressionValidator></td>
								<td align="left" style="WIDTH: 259px"><asp:textbox id="TxtGIP" runat="server" MaxLength="30"></asp:textbox>
									<asp:RegularExpressionValidator id="RegularExpressionValidator8" runat="server" ErrorMessage="*" ControlToValidate="TxtGIP"
										ValidationExpression="^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$"></asp:RegularExpressionValidator></td>
								<td align="left"><asp:textbox id="TxtSubIP" runat="server" MaxLength="30"></asp:textbox>
									<asp:RegularExpressionValidator id="RegularExpressionValidator9" runat="server" ErrorMessage="*" ControlToValidate="TxtSubIP"
										ValidationExpression="^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$"></asp:RegularExpressionValidator></td>
							</tr>
						</table>
						<HR width="100%" SIZE="1">
						<asp:button id="BtnRgstrSite" runat="server" BackColor="#EBEDF3" Text="Register" Width="100px" onclick="BtnRgstrSite_Click"></asp:button>
						<asp:Button id="btnupdate" runat="server" Width="100px" Text="Update" BackColor="#EBEDF3" Enabled="False" onclick="btnupdate_Click"></asp:Button>
					</td>
				</tr>
				<tr>
					<td align="center">
						<asp:DataGrid id="DGsite" runat="server" Width="782px" BackColor="White" BorderColor="#999999"
							BorderStyle="Solid" BorderWidth="1px" CellPadding="3" GridLines="Vertical" ForeColor="Black"
							AutoGenerateColumns="False" DataKeyField="SITE_ID" AllowPaging="True" PageSize="5" OnPageIndexChanged="ChangeGridPage" onselectedindexchanged="DGsite_SelectedIndexChanged">
							<FooterStyle BackColor="#CCCCCC"></FooterStyle>
							<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#000099"></SelectedItemStyle>
							<AlternatingItemStyle BackColor="#CCCCCC"></AlternatingItemStyle>
							<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
							<Columns>
								<asp:BoundColumn DataField="SITE_ID" HeaderText="ID">
									<HeaderStyle Width="40px"></HeaderStyle>
								</asp:BoundColumn>
								<asp:ButtonColumn Text="Button" DataTextField="SITE_NAME" HeaderText="NAME" CommandName="NAME"></asp:ButtonColumn>
								<asp:BoundColumn DataField="SITE_OFFICE_TYPE" HeaderText="OFFICE TYPE"></asp:BoundColumn>
								<asp:BoundColumn DataField="SITE_CONT_PERSON_NAME" HeaderText="PERSON NAME"></asp:BoundColumn>
								<asp:BoundColumn DataField="SITE_CONT_PERSON_PHNO" HeaderText="PERSON PH NO"></asp:BoundColumn>
								<asp:BoundColumn DataField="SITE_CONT_NO" HeaderText="SITE PH NO"></asp:BoundColumn>
								<asp:BoundColumn DataField="SITE_LOTUS_NOTE_EMAIL" HeaderText="E-MAIL"></asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
						</asp:DataGrid>
						<asp:Button id="btnedit" runat="server" Width="100px" Text="Edit" BackColor="#EBEDF3" Enabled="False" onclick="btnedit_Click"></asp:Button>
						<asp:Button id="btndelete" runat="server" Width="100px" Text="Delete" BackColor="#EBEDF3" Enabled="False" onclick="btndelete_Click"></asp:Button></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
