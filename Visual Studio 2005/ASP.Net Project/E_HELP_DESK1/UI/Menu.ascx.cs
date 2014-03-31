namespace E_HELP_DESK1.UI
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using System.Web.SessionState; 
	using System.IO;

	using E_HELP_DESK1.appsesson;

	/// <summary>
	///		Summary description for Menu.
	/// </summary>
	public partial class Menu : System.Web.UI.UserControl
	{

		
		protected appsesson v_loginsesson;

		public static HtmlGenericControl frame;

		protected void Page_Load(object sender, System.EventArgs e)
		{

			v_loginsesson = (appsesson)Session["p_loginsesson"];
//			if(!IsPostBack)
//			{
//				if(v_loginsesson == null)
//				{
//					//Response.Redirect("MainLogin.aspx");
//					Response.End();
//				}
//			}
			if(v_loginsesson == null)
			{
				Response.Redirect("MainLogin.aspx");
//				Response.End();
			}
			  
			
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		///		Required method for Designer support - do not modify
		///		the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{

		}
		#endregion

		protected void A1_ServerClick(object sender, System.EventArgs e)
		{
		
				frame.Attributes["src"]="HomeFrame.aspx";

		}

//		private void A2_ServerClick(object sender, System.EventArgs e)
//		{
//			frame.Attributes["src"] = "user_Registration.aspx";
//		}

		protected void A3_ServerClick(object sender, System.EventArgs e)
		{
			
				if(v_loginsesson.getlogintype()== "1")
				{
					frame.Attributes["src"] = "Site_registration.aspx";
				}
				else
				{
					Page.RegisterStartupScript("k1","<script language=javascript> alert(\" This Section Requires Admin Access. \");</script>");
				}
		}

		protected void A4_ServerClick(object sender, System.EventArgs e)
		{
			frame.Attributes["src"] = "ChangePassword.aspx";
		}

		protected void A5_ServerClick(object sender, System.EventArgs e)
		{
			if(v_loginsesson.getlogintype()== "1")
			{
				frame.Attributes["src"] = "user_Registration.aspx";
			}
			else
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\" This Section Requires Admin Access. \");</script>");
			}
		}

		protected void A6_ServerClick(object sender, System.EventArgs e)
		{
			frame.Attributes["src"] = "Complain.aspx";
		}

		protected void A7_ServerClick(object sender, System.EventArgs e)
		{
			frame.Attributes["src"]="complainstatus.aspx";
		}

		protected void A8_ServerClick(object sender, System.EventArgs e)
		{
//			frame.Attributes["src"]="visit.aspx";
			frame.Attributes["src"]="MyComplain.aspx";
		}
		public static void setcontrol(HtmlGenericControl homeframe)
		{
			frame = homeframe;
		}
		protected void A9_ServerClick(object sender, System.EventArgs e)
		{
			
			Session.RemoveAll();
			Response.Redirect("MainLogin.aspx");
		}
		private void A11_ServerClick(object sender, System.EventArgs e)
		{
		
		}

		protected void A12_ServerClick(object sender, System.EventArgs e)
		{
			if(v_loginsesson.getlogintype()== "1")
			{
				frame.Attributes["Src"]=	"Vender_Registration.aspx";
			}
			else
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\" This Section Requires Admin Access.\");</script>");
			}
		}

		protected void A13_ServerClick(object sender, System.EventArgs e)
		{
			if(v_loginsesson.getlogintype()== "1")
			{
				frame.Attributes["Src"]=	"Report.aspx";
			}
			else
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\"This Section Requires Admin Access.\");</script>");
			}
		}

		protected void A17_ServerClick(object sender, System.EventArgs e)
		{
						string 	baseLocation =HttpRuntime.AppDomainAppPath.ToString();
						string vfpath="";
						string vfanme="";

			if(v_loginsesson.getlogintype() =="1")
			{
							vfpath=baseLocation+"ZZP000-A03-J00-520.pdf";
							vfanme="ZZP000-A03-J00-520.pdf";
			}
			else if(v_loginsesson.getlogintype() =="2")
			{

							vfpath=baseLocation+"ZZP000-A03-J00-519.pdf";
							vfanme="ZZP000-A03-J00-519.pdf";
			}
			
			
						//Response.Write(baseLocation);
						//Response.End();
			
						FileStream MyFileStream = new FileStream(vfpath.ToString(),FileMode.Open);
						long FileSize;
						 
						FileSize = MyFileStream.Length;
						byte[] Buffer = new byte[(int)FileSize];
						MyFileStream.Read(Buffer, 0, (int)MyFileStream.Length);
						MyFileStream.Close();
						
						Response.ClearHeaders();
						Response.ClearContent();
			
						Response.ContentType="application";
						
						Response.AddHeader("content-disposition","attachment;filename="+vfanme+"");
						Response.BinaryWrite(Buffer);
						Response.End();
		}
	}
}
