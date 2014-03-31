<%@ Page language="c#" Inherits="E_HELP_DESK1.UI.Complain" CodeFile="Complain.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Complain</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#ebedf3">
		<form id="Form1" style="Z-INDEX: 101; LEFT: 0px; WIDTH: 801px; POSITION: absolute; TOP: 0px; HEIGHT: 400px"
			method="post" runat="server">
			<table style="WIDTH: 800px; HEIGHT: 448px" bgColor="#ebedf3" border="0">
				<tr>
					<td style="FONT-WEIGHT: bold; HEIGHT: 40px" align="center">Complaint Section
						<HR width="100%" SIZE="1">
					</td>
				</tr>
				<tr>
					<td style="HEIGHT: 27px">
						<table style="WIDTH: 784px; HEIGHT: 32px">
							<tr>
								<td style="WIDTH: 134px" align="left">Type Of Complaint :-</td>
								<td style="WIDTH: 165px" align="left"><asp:dropdownlist id="DDTypeCmpln" runat="server" BackColor="#EBEDF3" Width="104px">
										<asp:ListItem Value="Please Select" Selected="True">Please Select</asp:ListItem>
										<asp:ListItem Value="H/W Complaint">H/W Complaint</asp:ListItem>
										<asp:ListItem Value="S/W Complaint">S/W Complaint</asp:ListItem>
										<asp:ListItem Value="N/W Complaint">N/W Complaint</asp:ListItem>
									</asp:dropdownlist></td>
								<td style="WIDTH: 80px" align="left">User Name&nbsp;</td>
								<td style="WIDTH: 177px" align="center"><asp:textbox id="TxtUsrName" runat="server" Width="141px"></asp:textbox><asp:regularexpressionvalidator id="RegularExpressionValidator3" runat="server" Width="18px" ValidationExpression="^[a-zA-Z\s]+$"
										ErrorMessage="*" ControlToValidate="TxtUsrName"></asp:regularexpressionvalidator></td>
								<td style="WIDTH: 57px" align="left">Site&nbsp;Name
								</td>
								<td align="left"><asp:dropdownlist id="DDSiteName" runat="server" BackColor="#EBEDF3" Width="120px" AutoPostBack="True" onselectedindexchanged="ddsitename_SelectedIndexChanged"></asp:dropdownlist></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td style="HEIGHT: 27px">
						<table style="WIDTH: 784px; HEIGHT: 40px">
							<tr>
								<td style="WIDTH: 174px" align="center">SITE PH No1
								</td>
								<td align="center">Complainer ph no
								</td>
								<td style="WIDTH: 199px" align="center">
									<P class="MsoNormal">Complainer Mob no&nbsp;
									</P>
								</td>
								<td align="center">&nbsp;E-MAIL-Id
								</td>
							</tr>
							<tr>
								<td style="WIDTH: 174px" align="center"><asp:textbox id="TxtSitePhNo" runat="server" Width="108px" ReadOnly="True"></asp:textbox></td>
								<td align="center"><asp:textbox id="TxtCmplnerPhNo" runat="server" Width="108px" MaxLength="15"></asp:textbox><asp:regularexpressionvalidator id="RegularExpressionValidator2" runat="server" ValidationExpression="^[0-9]+$"
										ErrorMessage="*" ControlToValidate="TxtCmplnerPhNo"></asp:regularexpressionvalidator></td>
								<td style="WIDTH: 199px" align="center"><asp:textbox id="TxtCmplnerCellNo" runat="server" Width="125px" MaxLength="11"></asp:textbox><asp:regularexpressionvalidator id="RegularExpressionValidator1" runat="server" ValidationExpression="^[0-9]+$"
										ErrorMessage="*" ControlToValidate="TxtCmplnerCellNo"></asp:regularexpressionvalidator></td>
								<td align="left"><asp:textbox id="TxtSiteEMail" runat="server" Width="132px" ReadOnly="True"></asp:textbox></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td style="HEIGHT: 40px">
						<table style="WIDTH: 784px; HEIGHT: 24px">
							<tr>
								<td style="WIDTH: 155px" align="center">Complaint Subject :- &nbsp;
								</td>
								<td align="left"><asp:textbox id="TxtCpmSub" runat="server" Width="368px" MaxLength="100"></asp:textbox><asp:regularexpressionvalidator id="RegularExpressionValidator4" runat="server" ValidationExpression='^[a-zA-Z0-9\s-,.:"?*]+$'
										ErrorMessage="*" ControlToValidate="TxtCpmSub"></asp:regularexpressionvalidator></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td style="HEIGHT: 205px">
						<table style="WIDTH: 736px; HEIGHT: 177px">
							<tr>
								<td style="WIDTH: 156px" align="center">Complaint Detail :-
								</td>
								<td vAlign="middle" align="left"><asp:textbox id="TxtCmpDtl" runat="server" Width="544px" MaxLength="500" TextMode="MultiLine"
										Height="169px" ontextchanged="TxtCmpDtl_TextChanged"></asp:textbox><asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TxtCmpDtl"></asp:requiredfieldvalidator></td>
							</tr>
						</table>
						<HR width="100%" SIZE="1">
					</td>
				</tr>
				<tr>
					<td>
						<table style="WIDTH: 792px; HEIGHT: 30px">
							<tr>
								<td align="center"><asp:button id="BtnRegCmp" runat="server" BackColor="#EBEDF3" Width="111px" Text="Send Complaint" onclick="BtnRegCmp_Click"></asp:button></td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
