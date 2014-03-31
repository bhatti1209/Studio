<%@ Page language="c#" Inherits="E_HELP_DESK1.UI.Vender_Registration" CodeFile="Vender_Registration.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Vender_Registration</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#ebedf3">
		<form id="Form1" style="LEFT: 0px; WIDTH: 796px; POSITION: absolute; TOP: 0px; HEIGHT: 480px"
			method="post" runat="server">
			<table style="WIDTH: 792px; HEIGHT: 516px">
				<tr>
					<td style="FONT-WEIGHT: bold; HEIGHT: 40px" align="center">Vendor Registration
						<HR width="100%" SIZE="1">
					</td>
				<tr>
					<td>
						<table style="WIDTH: 784px; HEIGHT: 25px">
							<tr>
								<td style="WIDTH: 130px" align="center">Vendor Name :-
								</td>
								<td style="WIDTH: 197px" align="left"><asp:textbox id="TxtVndrName" runat="server" MaxLength="30"></asp:textbox>
									<asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" ValidationExpression="^[a-zA-Z\s]+$"
										ControlToValidate="TxtVndrName" ErrorMessage="*" Width="18px"></asp:RegularExpressionValidator></td>
								<td style="WIDTH: 146px" align="left">Vendor E-Mail Id :-
								</td>
								<td align="left"><asp:textbox id="TxtVndrMail" runat="server" MaxLength="30" Width="192px"></asp:textbox>
									<asp:RegularExpressionValidator id="RegularExpressionValidator3" runat="server" ErrorMessage="*" ControlToValidate="TxtVndrMail"
										ValidationExpression="^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*\.(\w{2}|(com|net|org|edu|int|mil|gov|arpa|biz|aero|name|coop|info|pro|museum))$"></asp:RegularExpressionValidator></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td>
						<table style="WIDTH: 784px; HEIGHT: 16px">
							<tr>
								<td style="WIDTH: 129px" align="center">Contact No 1 :-
								</td>
								<td style="WIDTH: 200px" align="left"><asp:textbox id="TxtPhno1" runat="server" MaxLength="15"></asp:textbox>
									<asp:regularexpressionvalidator id="RegularExpressionValidator2" runat="server" ValidationExpression="^[0-9]+$"
										ControlToValidate="TxtPhno1" ErrorMessage="*"></asp:regularexpressionvalidator></td>
								<td style="WIDTH: 142px">Contact No 2 :-
								</td>
								<td align="left"><asp:textbox id="TxtPhno2" runat="server" MaxLength="15" Width="192px"></asp:textbox>
									<asp:regularexpressionvalidator id="Regularexpressionvalidator4" runat="server" ValidationExpression="^[0-9]+$"
										ControlToValidate="TxtPhno2" ErrorMessage="*"></asp:regularexpressionvalidator></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td align="center">
						<table style="WIDTH: 784px; HEIGHT: 30px">
							<tr>
								<td style="WIDTH: 128px" align="center">Vendor Location:-
								</td>
								<td style="WIDTH: 454px" align="left"><asp:textbox id="TxtVndrLoc" runat="server" MaxLength="200" Width="424px" TextMode="MultiLine"
										Height="80px" ontextchanged="TxtVndrLoc_TextChanged"></asp:textbox>
									<asp:RegularExpressionValidator id="RegularExpressionValidator5" runat="server" ValidationExpression='^[a-zA-Z0-9\s-+,.:"<>?*=$@.]+$'
										ControlToValidate="TxtVndrLoc" ErrorMessage="*"></asp:RegularExpressionValidator></td>
								<td></td>
							</tr>
						</table>
						<HR width="100%" SIZE="1">
						<asp:button id="BtnvndrReg" runat="server" Width="115px" BackColor="#EBEDF3" Text="Register" onclick="BtnvndrReg_Click"></asp:button><asp:button id="btnupdate" runat="server" Width="114px" BackColor="#EBEDF3" Text="Update" Enabled="False" onclick="btnupdate_Click"></asp:button></td>
				</tr>
				<tr>
					<td align="center"><asp:datagrid id="DGVender" runat="server" Width="784px" Height="192px" BackColor="White" AllowPaging="True"
							DataKeyField="VENDOR_ID" PageSize="5" AutoGenerateColumns="False" ForeColor="Black" GridLines="Vertical"
							CellPadding="3" BorderWidth="1px" BorderStyle="Solid" BorderColor="#999999" OnPageIndexChanged="ChangeGridPage" onselectedindexchanged="DGVender_SelectedIndexChanged">
							<FooterStyle BackColor="#CCCCCC"></FooterStyle>
							<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#000099"></SelectedItemStyle>
							<AlternatingItemStyle BackColor="#CCCCCC"></AlternatingItemStyle>
							<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
							<Columns>
								<asp:BoundColumn DataField="VENDOR_ID" HeaderText="ID"></asp:BoundColumn>
								<asp:ButtonColumn DataTextField="VENDOR_NAME" HeaderText="NAME" CommandName="NAME"></asp:ButtonColumn>
								<asp:BoundColumn DataField="VENDOR_MAIL_ID" HeaderText="MAIL_ID"></asp:BoundColumn>
								<asp:BoundColumn DataField="VENDOR_CONT_NO1" HeaderText="CONTACT NO"></asp:BoundColumn>
								<asp:BoundColumn DataField="VENDOR_CONT_NO2" HeaderText="CONTACT_NO"></asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
						</asp:datagrid><asp:button id="btnedit" runat="server" Width="96px" BackColor="#EBEDF3" Text="Edit" Enabled="False" onclick="btnedit_Click"></asp:button><asp:button id="btndel" runat="server" Width="89px" BackColor="#EBEDF3" Text="Delete" Enabled="False"
							BorderColor="#EBEDF3" onclick="btndel_Click"></asp:button></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
