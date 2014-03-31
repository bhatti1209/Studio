<%@ Page language="c#" Inherits="E_HELP_DESK1.UI.visit" CodeFile="visit.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>visit</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script language="JavaScript" src="date-picker.js"></script>
	</HEAD>
	<body bgColor="#ebedf3">
		<form id="Form1" style="Z-INDEX: 101; LEFT: -8px; WIDTH: 800px; POSITION: absolute; TOP: 0px; HEIGHT: 520px"
			method="post" runat="server">
			<asp:label id="lblcmpno" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 0px" runat="server"
				Height="8px" Width="192px" Font-Bold="True">Complain No :-</asp:label><asp:datagrid id="DGfwdcmp" style="Z-INDEX: 102; LEFT: 16px; POSITION: absolute; TOP: 24px" runat="server"
				Height="128px" Width="776px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Vertical" ForeColor="Black" AutoGenerateColumns="False"
				AllowPaging="True" PageSize="5" OnItemCommand="DGfwdcmp_ItemCommand" DataKeyField="FRWD_ID" OnPageIndexChanged="ChangeGridPage" onselectedindexchanged="DGfwdcmp_SelectedIndexChanged">
				<FooterStyle BackColor="#CCCCCC"></FooterStyle>
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#000099"></SelectedItemStyle>
				<AlternatingItemStyle BackColor="#CCCCCC"></AlternatingItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
				<Columns>
					<asp:BoundColumn DataField="FRWD_ID" HeaderText="ID">
						<HeaderStyle Font-Size="Smaller" Width="40px"></HeaderStyle>
					</asp:BoundColumn>
					<asp:ButtonColumn DataTextField="vendor_name" HeaderText="Forward To" CommandName="Forward">
						<HeaderStyle Font-Size="Smaller" Width="100px"></HeaderStyle>
					</asp:ButtonColumn>
					<asp:BoundColumn DataField="COMP_FRWD_DATE_TIME" HeaderText="Date Time">
						<HeaderStyle Font-Size="Smaller" Width="150px"></HeaderStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="CMPSTATUS" HeaderText="Status">
						<HeaderStyle Font-Size="Smaller" Width="50px"></HeaderStyle>
					</asp:BoundColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
			</asp:datagrid><asp:button id="btnclosecmp" style="Z-INDEX: 103; LEFT: 64px; POSITION: absolute; TOP: 208px"
				runat="server" Height="24px" Width="120px" BackColor="#EBEDF3" Text="Send Back" Enabled="False" onclick="btnclosecmp_Click"></asp:button><asp:button id="btnaddvisit" style="Z-INDEX: 104; LEFT: 208px; POSITION: absolute; TOP: 208px"
				runat="server" Height="24px" Width="120px" BackColor="#EBEDF3" Text="Add Visit" Enabled="False" onclick="btnaddvisit_Click"></asp:button><asp:button id="btndone" style="Z-INDEX: 105; LEFT: 344px; POSITION: absolute; TOP: 208px" runat="server"
				Height="24px" Width="120px" BackColor="#EBEDF3" Text="Resolved" Enabled="False" onclick="btndone_Click"></asp:button><asp:datagrid id="DGvisit" style="Z-INDEX: 106; LEFT: 16px; POSITION: absolute; TOP: 312px" runat="server"
				Height="176px" Width="776px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Vertical" ForeColor="Black" AutoGenerateColumns="False"
				AllowPaging="True" PageSize="5" OnPageIndexChanged="ChangevisitGridPage" onselectedindexchanged="DGvisit_SelectedIndexChanged">
				<FooterStyle BackColor="#CCCCCC"></FooterStyle>
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#000099"></SelectedItemStyle>
				<AlternatingItemStyle BackColor="#CCCCCC"></AlternatingItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
				<Columns>
					<asp:BoundColumn DataField="vendor_name" HeaderText="VISITED BY">
						<HeaderStyle Font-Size="Smaller" Width="100px"></HeaderStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="visit_date_time" HeaderText="VISIT DATE TIME">
						<HeaderStyle Font-Size="Smaller" Width="150px"></HeaderStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="VISIT_REMARK" HeaderText="VISIT DETAIL">
						<HeaderStyle Font-Size="Smaller"></HeaderStyle>
					</asp:BoundColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
			</asp:datagrid><asp:button id="btnsavevisit" style="Z-INDEX: 107; LEFT: 328px; POSITION: absolute; TOP: 280px"
				runat="server" Width="72px" BackColor="#EBEDF3" Text="Save Visit" Enabled="False" onclick="btnsavevisit_Click"></asp:button><asp:label id="Lblvisit" style="Z-INDEX: 108; LEFT: 24px; POSITION: absolute; TOP: 280px" runat="server"
				Height="15px" Width="200px" Font-Bold="True">Total Visit :-  </asp:label><asp:textbox id="txtvisitdate" style="Z-INDEX: 109; LEFT: 576px; POSITION: absolute; TOP: 208px"
				runat="server" Width="98px" Enabled="False" CssClass="stextbox" ReadOnly="True"></asp:textbox><asp:label id="Label1" style="Z-INDEX: 110; LEFT: 480px; POSITION: absolute; TOP: 208px" runat="server"
				Width="88px" Font-Bold="True">Visit Date :-</asp:label><A onmouseover="window.status ='Date Picker';return true;" onmouseout="window.status='';return true;"
				href="javascript:show_calendar('Form1.txtvisitdate');"><asp:image id="imgdatfrmall" style="Z-INDEX: 111; LEFT: 680px; POSITION: absolute; TOP: 208px"
					runat="server" ImageUrl="../images/cal.gif" Visible="False"></asp:image></A><asp:textbox id="txtvisitdtl" style="Z-INDEX: 112; LEFT: 112px; POSITION: absolute; TOP: 240px"
				runat="server" Height="24px" Width="675px" Enabled="False" MaxLength="100"></asp:textbox><asp:label id="Label2" style="Z-INDEX: 113; LEFT: 24px; POSITION: absolute; TOP: 240px" runat="server">Visit Detail : -</asp:label></form>
	</body>
</HTML>
