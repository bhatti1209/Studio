<%@ Reference Control="~/ui/menu.ascx" %>
<%@ Page language="c#" Inherits="E_HELP_DESK1.UI.Home" CodeFile="Home.aspx.cs" %>
<%@ Register TagPrefix="uc1" TagName="Menu" Src="Menu.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Home</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<table style="WIDTH: 992px; HEIGHT: 610px" cellSpacing="0" cellPadding="0" width="992"
				border="0">
				<TBODY>
					<tr>
						<td colSpan="2"><IMG style="WIDTH: 982px; HEIGHT: 88px" height="88" alt="" src="../images/top.jpg" width="982"></td>
					</tr>
					<tr>
						<TD style="BACKGROUND: none transparent scroll repeat 0% 0%" vAlign="top"><IMG height="24" src="../images/b1.jpg" width="176"></TD>
						<td style="HEIGHT: 12px" vAlign="middle"><uc1:menu id="Menu1" runat="server"></uc1:menu></td>
					</tr>
					<tr>
						<td style="HEIGHT: 501px" vAlign="top" background="../images/leftbg.jpg"><br>
							<br>
							<br>
							<br>
							<br>
							<br>
						</td>
						<td style="HEIGHT: 501px" vAlign="top" width="807">
							<table style="WIDTH: 814px; HEIGHT: 499px" borderColor="#4f5c7d" height="499" cellSpacing="0"
								cellPadding="0" width="814" border="2">
								<TBODY>
									<tr>
										<td style="HEIGHT: 424px" width="807"><iframe id="MyHelpDeskFrame" style="WIDTH: 807px; HEIGHT: 495px" name="HelpDeskFrame" width="807"
												runat="server"> </iframe>
										</td>
									</tr>
								</TBODY>
							</table>
						</td>
					</tr>
				</TBODY>
			</table>
		</form>
	</body>
</HTML>
