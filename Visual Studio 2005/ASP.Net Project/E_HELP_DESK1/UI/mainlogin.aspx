<%@ Page language="c#" Inherits="E_HELP_DESK1.UI.MainLogin" CodeFile="MainLogin.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>MainLogin</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script language="JavaScript">
		
		function funValidate()
			{
				var userid = document.getElementById("TextBox1");
				var password = document.getElementById("TextBox2");			
			
			if (userid.value == ""){
				alert("Please enter userid!");
				return false;
			}
			if (password.value == ""){
				alert("Please enter password!");
				return false;
			}
			return true;
		}
		</script>
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<table cellSpacing="0" cellPadding="0" width="750" border="0">
				<TBODY>
					<tr>
						<td style="HEIGHT: 77px" colSpan="2"><IMG style="WIDTH: 982px; HEIGHT: 88px" height="88" alt="" src="../images/top.jpg" width="982"></td>
					</tr>
					<tr>
						<td style="HEIGHT: 493px" vAlign="top" background="../images/leftbg.jpg">
							<asp:LinkButton id="LinkButton1" runat="server" Width="168px" BackColor="Transparent" onclick="LinkButton1_Click">      MainPage</asp:LinkButton><br>
							<br>
							User Id&nbsp;&nbsp; &nbsp;<asp:textbox id="txtloginname" runat="server" Width="97px" MaxLength="15"></asp:textbox>
							<br>
							<br>
							Password
							<asp:textbox id="txtpass" runat="server" Width="97px" MaxLength="15" TextMode="Password"></asp:textbox>&nbsp;
							<br>
							&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							<br>
							&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							<asp:button id="Button1" runat="server" BackColor="#ebedf3" Text="Login" onclick="Button1_Click"></asp:button>
							<br>
							<P><FONT color="#ff0000"><SPAN id="Label4" style="FONT-SIZE: smaller">Software Version : 
										RIL-PL-HDK-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
										Beta</SPAN><SPAN style="FONT-SIZE: smaller">-20-03-2007</SPAN></FONT></P>
						</td>
						<td style="HEIGHT: 493px" vAlign="top" width="807">
							<table borderColor="#4f5c7d" height="492" cellSpacing="0" cellPadding="0" width="807" border="2">
								<TBODY>
									<tr>
										<td style="HEIGHT: 424px" vAlign="middle" align="center" width="807">
											<P><FONT color="#ff0000"><SPAN style="FONT-SIZE: smaller"></SPAN></FONT>&nbsp;</P>
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
