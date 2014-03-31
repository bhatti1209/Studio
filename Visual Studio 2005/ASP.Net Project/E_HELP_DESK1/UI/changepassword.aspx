<%@ Page language="c#" Inherits="E_HELP_DESK1.UI.WebForm1" CodeFile="ChangePassword.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" style="Z-INDEX: 101; LEFT: 0px; WIDTH: 801px; POSITION: absolute; TOP: 0px; HEIGHT: 472px"
			method="post" runat="server">
			<table style="WIDTH: 800px; HEIGHT: 480px" bgColor="#ebedf3" border="0">
				<tr>
					<td style="HEIGHT: 224px" align="center">
						<table style="WIDTH: 277px; HEIGHT: 207px" bgColor="#67758f" border="0">
							<tr>
								<td style="HEIGHT: 137px" align="center">
									<table style="WIDTH: 267px; HEIGHT: 136px" align="center">
										<tr>
											<td style="WIDTH: 123px; HEIGHT: 48px" align="center">Old password</td>
											<td style="HEIGHT: 48px"><asp:textbox id="txtoldpass" runat="server" Width="104px" MaxLength="15" TextMode="Password" ontextchanged="txtoldpass_TextChanged"></asp:textbox>
												<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtoldpass"></asp:RequiredFieldValidator></td>
										</tr>
										<tr>
											<td style="WIDTH: 123px; HEIGHT: 33px" align="center">New password</td>
											<td style="HEIGHT: 36px"><asp:textbox id="txtnewpass" runat="server" Width="104px" MaxLength="15" TextMode="Password" ontextchanged="txtnewpass_TextChanged"></asp:textbox></td>
										</tr>
										<tr>
											<td style="WIDTH: 123px; HEIGHT: 62px" align="center">Confirm password</td>
											<td style="HEIGHT: 33px"><asp:textbox id="txtcnfpass" runat="server" Width="104px" MaxLength="15" TextMode="Password" ontextchanged="txtcnfpass_TextChanged"></asp:textbox></td>
										</tr>
									</table>
								</td>
							</tr>
							<tr>
								<td align="center"><asp:button id="btnchange" runat="server" BackColor="#ebedf3" Text="Change" onclick="btnchange_Click"></asp:button></td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
