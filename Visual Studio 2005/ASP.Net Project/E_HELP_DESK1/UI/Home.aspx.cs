using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace E_HELP_DESK1.UI
{
	/// <summary>
	/// Summary description for Home.
	/// </summary>
	public partial class Home : System.Web.UI.Page
	{

		protected appsesson.appsesson v_loginsesson;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			
			v_loginsesson = (appsesson.appsesson)Session["p_loginsesson"];

			if(!IsPostBack)
			{
				if(v_loginsesson == null)
				{
//					Response.Redirect("MainLogin.aspx");
					HtmlGenericControl menu1; 
					menu1 =(HtmlGenericControl)this.FindControl("Menu1"); 
					menu1.Visible=false;
					Response.End();
				}
			}
			HtmlGenericControl myIFrame; 
			myIFrame =(HtmlGenericControl)this.FindControl("MyHelpDeskFrame"); 
			Menu.setcontrol(myIFrame);
			myIFrame.Attributes["src"] ="HomeFrame.aspx";
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    

		}
		#endregion
	}
}
