<%@ Control Language="c#" Inherits="E_HELP_DESK1.UI.Menu" CodeFile="Menu.ascx.cs" %>
<LINK href="csshorizontalmenu.css" type="text/css" rel="stylesheet">
<script src="csshorizontalmenu.js" type="text/javascript">


		/***********************************************

		* CSS Horizontal List Menu- by JavaScript Kit (www.javascriptkit.com)
		* Menu interface credits: http://www.dynamicdrive.com/style/csslibrary/item/glossy-vertical-menu/ 
		* This notice must stay intact for usage
		* Visit JavaScript Kit at http://www.javascriptkit.com/ for this script and 100s more

		***********************************************/

</script>
<div class="horizontalcssmenu">
	<ul id="cssmenu1">
		<li style="BORDER-LEFT: #202020 1px solid">
			<A id="A1" href="#" runat="server" onserverclick="A1_ServerClick">Home</A>
		</li>
		<li>
			<A href="#">SETTINGS</A>
			<ul>
				<li>
					<A id="A4" href="#" runat="server" onserverclick="A4_ServerClick">Change Password</A>
				</li>
			</ul>
		</li>
		<li>
			<A href="#">IT Administrator</A>
			<ul>
				<li>
					<A id="A5" href="#" runat="server" onserverclick="A5_ServerClick">User Registration</A>
				</li>
				<li>
					<A id="A3" href="#" runat="server" onserverclick="A3_ServerClick">Pipeline Site Registration</A>
				</li>
				<li>
					<A id="A12" href="#" runat="server" onserverclick="A12_ServerClick">Vendor Registration </A>
				</li>
				<li>
					<A id="A13" href="#" runat="server" onserverclick="A13_ServerClick">Create Report</A>
				</li>
			</ul>
		</li>
		<li>
			<A href="#">IT Support</A>
			<ul>
				<li>
					<A id="A6" href="#" runat="server" onserverclick="A6_ServerClick">Register Complaint</A>
				</li>
				<li>
					<A id="A8" href="#" runat="server" onserverclick="A8_ServerClick">Undertaken Complaint</A>
				</li>
				<li>
					<A id="A7" href="#" runat="server" onserverclick="A7_ServerClick">Complaint Box</A>
				</li>
			</ul>
		</li>
		<li>
			<A href="#">Miscellaneous </A>
			<ul>
				<li>
					<A id="A17" href="#" runat="server" onserverclick="A17_ServerClick">Help</A>
				</li>
			</ul>
		</li>
		<li>
			<A id="A9" href="#" runat="server" onserverclick="A9_ServerClick">LOGOUT</A>
		</li>
	</ul>
	<br style="CLEAR: left">
</div>
