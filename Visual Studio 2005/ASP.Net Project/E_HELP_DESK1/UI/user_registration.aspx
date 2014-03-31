<%@ Page language="c#" Inherits="E_HELP_DESK1.UI.user_Registration" CodeFile="user_Registration.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>user_Registration</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script language="JavaScript" src="date-picker.js"></script>
	</HEAD>
	<body bgColor="#ebedf3">
		<form id="Form1" style="LEFT: 0px; WIDTH: 798px; POSITION: absolute; TOP: 0px; HEIGHT: 448px"
			method="post" runat="server">
			<table style="WIDTH: 797px; HEIGHT: 432px">
				<tr>
					<td style="FONT-WEIGHT: bold; HEIGHT: 40px" align="center">User Registration
						<HR width="100%" SIZE="1">
					</td>
				</tr>
				<tr>
					<td style="HEIGHT: 43px">
						<table style="WIDTH: 784px; HEIGHT: 16px">
							<tr>
								<td style="WIDTH: 85px" align="left">User Name :-
								</td>
								<td style="WIDTH: 215px"><asp:textbox id="TxtUsrName" runat="server" MaxLength="30" Width="171px"></asp:textbox>
									<asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" Width="18px" ValidationExpression="^[a-zA-Z\s]+$"
										ControlToValidate="TxtUsrName" ErrorMessage="*"></asp:RegularExpressionValidator></td>
								<td style="WIDTH: 71px">Login&nbsp;Id :-&nbsp;
								</td>
								<td style="WIDTH: 153px"><asp:textbox id="TxtLgnName" runat="server" MaxLength="15" Width="128px"></asp:textbox>
									<asp:RegularExpressionValidator id="RegularExpressionValidator3" runat="server" Width="16px" ErrorMessage="*" ControlToValidate="TxtLgnName"
										ValidationExpression="^[a-zA-Z0-9._]+$"></asp:RegularExpressionValidator></td>
								<td style="WIDTH: 83px" align="left">Emp Code:-
								</td>
								<td style="WIDTH: 129px"><asp:textbox id="TxtEmpCode" runat="server" MaxLength="10" Width="104px"></asp:textbox>
									<asp:RegularExpressionValidator id="RegularExpressionValidator4" runat="server" ErrorMessage="*" ControlToValidate="TxtEmpCode"
										ValidationExpression="^[a-zA-Z0-9]+$"></asp:RegularExpressionValidator></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td>
						<table style="WIDTH: 784px; HEIGHT: 24px">
							<tr>
								<td style="WIDTH: 88px" align="left">E-Mail Id :-
								</td>
								<td style="WIDTH: 205px"><asp:textbox id="TxtMail" runat="server" MaxLength="30" Width="171px"></asp:textbox>
									<asp:RegularExpressionValidator id="RegularExpressionValidator2" runat="server" ErrorMessage="*" ControlToValidate="TxtMail"
										ValidationExpression='^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*\.(\w{2}|(com|net|org|edu|int|mil|gov|arpa|biz|aero|name|coop|info|pro|museum))$'></asp:RegularExpressionValidator></td>
								<td style="WIDTH: 90px">User Type :-
								</td>
								<td style="WIDTH: 142px"><asp:dropdownlist id="DDUsrTyp" runat="server" Width="118px" BackColor="#EBEDF3"></asp:dropdownlist></td>
								<td></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td align="center">
						<table style="WIDTH: 784px; HEIGHT: 48px">
							<tr>
								<td style="WIDTH: 235px" align="center">Date Of Birth
								</td>
								<td style="WIDTH: 129px" align="center">
									Phone No&nbsp;
								</td>
								<td style="WIDTH: 209px">Mob No
								</td>
							</tr>
							<tr>
								<td style="WIDTH: 235px" vAlign="middle" align="center">
									<asp:textbox id="TxtDob" runat="server" Width="98px" CssClass="stextbox" ReadOnly="True"></asp:textbox>
									<A onmouseover="window.status ='Date Picker';return true;" onmouseout="window.status='';return true;"
										href="javascript:show_calendar('Form1.TxtDob');">
										<asp:image id="imgdatfrmall" runat="server" ImageUrl="../images/cal.gif"></asp:image>
									</A>
									<asp:RegularExpressionValidator id="RegularExpressionValidator7" runat="server" ControlToValidate="TxtDob" ErrorMessage="*"
										ValidationExpression="^((0?[13578]|10|12)(-|\/)(([0-9])|(0[0-9])|([12])([0-9]?)|(3[01]?))(-|\/)((\d{4})|(\d{2}))|(0?[2469]|11)(-|\/)(([0-9])|(0[0-9])|([12])([0-9]?)|(3[0]?))(-|\/)((\d{4}|\d{2})))$"></asp:RegularExpressionValidator>
								</td>
								<td style="WIDTH: 129px" align="center"><asp:textbox id="TxtPhNo" runat="server" MaxLength="15" Width="108px"></asp:textbox>
									<asp:regularexpressionvalidator id="Regularexpressionvalidator5" runat="server" ValidationExpression="^[0-9]+$"
										ControlToValidate="TxtPhNo" ErrorMessage="*"></asp:regularexpressionvalidator></td>
								<td style="WIDTH: 209px"><asp:textbox id="TxtMobNo" runat="server" MaxLength="11" Width="125px"></asp:textbox>
									<asp:regularexpressionvalidator id="Regularexpressionvalidator6" runat="server" ValidationExpression="^[0-9]+$"
										ControlToValidate="TxtMobNo" ErrorMessage="*"></asp:regularexpressionvalidator></td>
							</tr>
						</table>
						<HR width="100%" SIZE="1">
						<asp:button id="BtnRegUser" runat="server" Width="105px" BackColor="#EBEDF3" Text="Register User" onclick="BtnRegUser_Click"></asp:button><asp:button id="BtnUpdt" runat="server" Width="105px" BackColor="#EBEDF3" Text="Update" Enabled="False" onclick="BtnUpdt_Click"></asp:button></td>
				</tr>
				<tr>
					<td align="center"><asp:datagrid id="DGUsr" runat="server" Width="789px" BackColor="White" PageSize="5" AllowPaging="True"
							BorderStyle="Solid" BorderWidth="1px" CellPadding="3" GridLines="Vertical" ForeColor="Black" DataKeyField="USER_ID"
							AutoGenerateColumns="False" BorderColor="#999999" OnPageIndexChanged="ChangeGridPage" onselectedindexchanged="DGUsr_SelectedIndexChanged">
							<FooterStyle BackColor="#CCCCCC"></FooterStyle>
							<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#000099"></SelectedItemStyle>
							<AlternatingItemStyle BackColor="#CCCCCC"></AlternatingItemStyle>
							<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
							<Columns>
								<asp:BoundColumn DataField="USER_ID" HeaderText="USER ID"></asp:BoundColumn>
								<asp:ButtonColumn Text="Button" DataTextField="USER_NAME" HeaderText="USER NAME" CommandName="USER NAME"></asp:ButtonColumn>
								<asp:BoundColumn DataField="USER_MAIL_ID" HeaderText="USER MAIL ID"></asp:BoundColumn>
								<asp:BoundColumn DataField="USER_TYPE" HeaderText="TYPE"></asp:BoundColumn>
								<asp:BoundColumn DataField="USER_CONTACT_NO" HeaderText="CONTACT NO"></asp:BoundColumn>
								<asp:BoundColumn DataField="USER_MOB_NO" HeaderText="MOB  NO"></asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
						</asp:datagrid><asp:button id="BtnEdit" runat="server" Width="95px" BackColor="#EBEDF3" Text="Edit" Enabled="False" onclick="BtnEdit_Click"></asp:button><asp:button id="Btndel" runat="server" Width="103px" BackColor="#EBEDF3" Text="Delete" Enabled="False" onclick="Btndel_Click"></asp:button></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
