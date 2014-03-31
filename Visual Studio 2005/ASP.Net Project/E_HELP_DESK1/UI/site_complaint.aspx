<%@ Reference Page="~/ui/complain.aspx" %>
<%@ Page language="c#" Inherits="E_HELP_DESK1.UI.Site_Complaint" CodeFile="Site_Complaint.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Site_Complaint</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<table style="WIDTH: 986px; HEIGHT: 624px" cellSpacing="0" cellPadding="0" width="986"
				border="0">
				<TBODY>
					<tr>
						<td style="HEIGHT: 77px" colSpan="2"><IMG style="WIDTH: 982px; HEIGHT: 88px" height="88" alt="" src="../images/top.jpg" width="982"></td>
					</tr>
					<tr>
						<td style="HEIGHT: 515px" vAlign="top" background="../images/leftbg.jpg">
							<asp:LinkButton id="lnkview" runat="server" Width="168px" BackColor="Transparent" onclick="lnkview_Click">View Status</asp:LinkButton><br>
							<asp:LinkButton id="lnkhlp" runat="server" Width="168px" BackColor="Transparent" onclick="lnkhlp_Click">Help</asp:LinkButton><BR>
							<asp:LinkButton id="Lnklogout" runat="server" Width="168px" BackColor="Transparent" onclick="Lnklogout_Click">LogOut</asp:LinkButton><BR>
							<br>
							<br>
							<br>
						</td>
						<td style="HEIGHT: 515px" vAlign="top" width="807" bgColor="#ebedf3">
							<table style="WIDTH: 807px; HEIGHT: 472px" height="472" cellSpacing="0" cellPadding="0"
								width="807" border="2">
								<TBODY>
									<tr>
										<td style="HEIGHT: 424px" vAlign="top" align="center" width="807">
											<table style="WIDTH: 800px; HEIGHT: 472px" bgColor="#ebedf3" border="0">
												<tr>
													<td style="FONT-WEIGHT: bold; HEIGHT: 18px" vAlign="top" align="center">Complaint 
														Section
													</td>
												</tr>
												<tr>
													<td style="HEIGHT: 38px" vAlign="top">
														<table style="WIDTH: 784px; HEIGHT: 16px">
															<tr>
																<td style="WIDTH: 154px" align="center" vAlign="top">Type Of Complaint :-</td>
																<td style="WIDTH: 137px" align="left" vAlign="top"><asp:dropdownlist id="DDTypeCmpln" runat="server" Width="112px" BackColor="#EBEDF3" Height="24px">
																		<asp:ListItem Value="Please Select" Selected="True">Please Select</asp:ListItem>
																		<asp:ListItem Value="H/W Complaint">H/W Complaint</asp:ListItem>
																		<asp:ListItem Value="S/W Complaint">S/W Complaint</asp:ListItem>
																		<asp:ListItem Value="N/W Complaint">N/W Complaint</asp:ListItem>
																	</asp:dropdownlist><FONT color="#ff3300"></FONT></td>
																<td style="WIDTH: 81px" align="center" vAlign="top">User Name&nbsp;</td>
																<td style="WIDTH: 162px" align="left" vAlign="top"><asp:textbox id="TxtUsrName" runat="server" Width="136px" MaxLength="25"></asp:textbox><asp:regularexpressionvalidator id="RegularExpressionValidator3" runat="server" Width="18px" ValidationExpression="^[a-zA-Z\s]+$"
																		ErrorMessage="*" ControlToValidate="TxtUsrName"></asp:regularexpressionvalidator></td>
																<td align="center"></td>
															</tr>
														</table>
													</td>
												</tr>
												<tr>
													<td style="HEIGHT: 46px">
														<table style="WIDTH: 780px; HEIGHT: 16px">
															<tr>
																<td style="WIDTH: 154px" align="center" vAlign="top"><asp:label id="Label1" runat="server">PH NO :- </asp:label></td>
																<td style="WIDTH: 136px" vAlign="top"><asp:textbox id="TxtCmplnerPhNo" runat="server" Height="22px" Width="113px" MaxLength="15"></asp:textbox><asp:regularexpressionvalidator id="RegularExpressionValidator2" runat="server" ValidationExpression="^[0-9]+$"
																		ErrorMessage="*" ControlToValidate="TxtCmplnerPhNo"></asp:regularexpressionvalidator></td>
																<td style="WIDTH: 83px" vAlign="top"><asp:label id="Label2" runat="server">MOB NO:-</asp:label></td>
																<td vAlign="top"><asp:textbox id="TxtCmplnerCellNo" runat="server" Width="136px" MaxLength="11"></asp:textbox><asp:regularexpressionvalidator id="RegularExpressionValidator1" runat="server" ValidationExpression="^[0-9]+$"
																		ErrorMessage="*" ControlToValidate="TxtCmplnerCellNo"></asp:regularexpressionvalidator></td>
															</tr>
														</table>
													</td>
												</tr>
												<tr>
													<td style="HEIGHT: 6px"></td>
												</tr>
												<tr>
													<td style="HEIGHT: 38px" vAlign="top">
														<table style="WIDTH: 688px; HEIGHT: 30px">
															<tr>
																<td style="WIDTH: 156px" align="center">Complaint Subject :- &nbsp;
																</td>
																<td align="left"><asp:textbox id="TxtCpmSub" runat="server" Width="368px" MaxLength="100"></asp:textbox><asp:regularexpressionvalidator id="RegularExpressionValidator4" runat="server" ValidationExpression='^[a-zA-Z0-9\s-,.:"?*]+$'
																		ErrorMessage="*" ControlToValidate="TxtCpmSub"></asp:regularexpressionvalidator></td>
															</tr>
														</table>
													</td>
												</tr>
												<tr>
													<td style="HEIGHT: 169px" align="center">
														<table style="WIDTH: 792px; HEIGHT: 228px">
															<tr>
																<td style="WIDTH: 156px" align="center">Complaint Detail :-
																</td>
																<td align="left"><asp:textbox id="TxtCmpDtl" runat="server" Height="217px" Width="624px" MaxLength="10" TextMode="MultiLine"></asp:textbox></td>
															</tr>
														</table>
														<asp:button id="Button2" runat="server" Width="111px" BackColor="#EBEDF3" Text="Send Complaint" onclick="Button2_Click"></asp:button>
													</td>
												</tr>
												<tr>
													<td>
													</td>
												</tr>
											</table>
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
