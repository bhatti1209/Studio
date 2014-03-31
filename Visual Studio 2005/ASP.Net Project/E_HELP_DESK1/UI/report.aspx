<%@ Page language="c#" Inherits="E_HELP_DESK1.UI.Report" CodeFile="Report.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Report</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script language="JavaScript" src="date-picker.js"></script>
		<script language="JavaScript">
		  function shownewwindow()
         {
	  		var t1 = 'Report1.aspx';
			j = window.open(t1,null,"width=800,height=600,scrollbars=yes");
			window.j.focus()
			return false;
        }
		</script>
	</HEAD>
	<BODY bgColor="#ebedf3">
		<form id="Form1" style="Z-INDEX: 101; LEFT: 0px; WIDTH: 800px; POSITION: absolute; TOP: 0px; HEIGHT: 304px"
			method="post" runat="server">
			<table style="WIDTH: 799px; HEIGHT: 280px">
				<tr>
					<td style="HEIGHT: 38px">
						<table style="WIDTH: 792px; HEIGHT: 16px">
							<tr>
								<td style="FONT-WEIGHT: bold; HEIGHT: 20px" vAlign="top" align="center">Report
								</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td style="HEIGHT: 83px">
						<table style="WIDTH: 792px; HEIGHT: 84px" border="1">
							<tr>
								<td style="HEIGHT: 40px" vAlign="top"><asp:radiobutton id="optbtnitspt" runat="server" AutoPostBack="True" Text="INDIVIDUAL REPORT" GroupName="report" oncheckedchanged="optbtnitspt_CheckedChanged"></asp:radiobutton></td>
								<td style="HEIGHT: 40px" align="left">
									<table id="tableitspt" style="WIDTH: 558px; HEIGHT: 24px">
										<tr>
											<td style="WIDTH: 68px; HEIGHT: 17px" align="center">From</td>
											<td style="WIDTH: 137px; HEIGHT: 17px"><asp:textbox id="txtdatfrmitspt" runat="server" CssClass="stextbox" Width="98px" ReadOnly="True"></asp:textbox><A onmouseover="window.status ='Date Picker';return true;" onmouseout="window.status='';return true;"
													href="javascript:show_calendar('Form1.txtdatfrmitspt');"><asp:image id="imgdatfrmitspt" Runat="server" ImageUrl="../images/cal.gif" EnableViewState="False"
														Visible="False"></asp:image></A></td>
											<td style="WIDTH: 56px; HEIGHT: 17px" align="center">To<A onmouseover="window.status ='Date Picker';return true;" onmouseout="window.status='';return true;"
													href="javascript:show_calendar('Form1.txtdatfrmitspt');"></A></td>
											<td style="HEIGHT: 17px"><asp:textbox id="txtdattoitspt" runat="server" CssClass="stextbox" Width="98px" ReadOnly="True"></asp:textbox><A onmouseover="window.status ='Date Picker';return true;" onmouseout="window.status='';return true;"
													href="javascript:show_calendar('Form1.txtdattoitspt');"><asp:image id="imgdattoitspt" runat="server" ImageUrl="../images/cal.gif" EnableViewState="False"
														Visible="False"></asp:image></A></td>
										</tr>
									</table>
								</td>
							</tr>
							<tr>
								<td></td>
								<td align="center"><asp:button id="btnrptitspt" runat="server" Text="Get Report" Enabled="False" Width="115px"
										BackColor="#EBEDF3" onclick="btnrptitspt_Click"></asp:button></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td style="HEIGHT: 86px">
						<table style="WIDTH: 792px; HEIGHT: 72px" border="1">
							<tr>
								<td style="WIDTH: 188px; HEIGHT: 42px" vAlign="top"><asp:radiobutton id="optbtnsite" runat="server" AutoPostBack="True" Text="SITE REPORT" GroupName="report" oncheckedchanged="optbtnsite_CheckedChanged"></asp:radiobutton></td>
								<td style="HEIGHT: 42px">
									<table style="WIDTH: 560px; HEIGHT: 23px">
										<tr>
											<td style="WIDTH: 73px; HEIGHT: 16px" align="center">From</td>
											<td style="WIDTH: 137px; HEIGHT: 16px"><asp:textbox id="txtdatfrmsite" runat="server" CssClass="stextbox" Width="98px" ReadOnly="True"></asp:textbox><A onmouseover="window.status ='Date Picker';return true;" onmouseout="window.status='';return true;"
													href="javascript:show_calendar('Form1.txtdatfrmsite');"><asp:image id="imgdatfrmsite" runat="server" ImageUrl="../images/cal.gif" EnableViewState="False"
														Visible="False"></asp:image></A></td>
											<td style="WIDTH: 52px; HEIGHT: 16px" align="center">To<A onmouseover="window.status ='Date Picker';return true;" onmouseout="window.status='';return true;"
													href="javascript:show_calendar('Form1.txtdatfrmsite');"></A></td>
											<td style="HEIGHT: 16px"><asp:textbox id="txtdattosite" runat="server" CssClass="stextbox" Width="98px" ReadOnly="True"></asp:textbox><A onmouseover="window.status ='Date Picker';return true;" onmouseout="window.status='';return true;"
													href="javascript:show_calendar('Form1.txtdattosite');"><asp:image id="imgdattosite" runat="server" ImageUrl="../images/cal.gif" EnableViewState="False"
														Visible="False"></asp:image></A></td>
										</tr>
									</table>
								</td>
							</tr>
							<tr>
								<td></td>
								<td align="center"><asp:button id="btnrptsite" runat="server" Text="Get Report" Enabled="False" Width="115px" BackColor="#EBEDF3" onclick="btnrptsite_Click"></asp:button></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td></td>
				</tr>
			</table>
		</form>
		&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	</BODY>
</HTML>
