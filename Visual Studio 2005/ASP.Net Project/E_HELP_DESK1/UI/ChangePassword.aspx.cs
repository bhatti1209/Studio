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

using E_HELP_DESK1.BusinessLogicLayer;
using E_HELP_DESK1.DataAccessLayer; 
using System.Configuration; 
using System.Data.OracleClient;
namespace E_HELP_DESK1.UI
{
	/// <summary>
	/// Summary description for WebForm1.
	/// </summary>
	public partial class WebForm1 : System.Web.UI.Page
	{
		

		protected appsesson.appsesson v_loginsesson;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			v_loginsesson = (appsesson.appsesson)Session["p_loginsesson"];

			if(!IsPostBack)
			{
				if(v_loginsesson == null)
				{
//					Response.Redirect("MainLogin.aspx");
					Response.End();
				}
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    

		}
		#endregion

		protected void txtoldpass_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		protected void txtnewpass_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		protected void txtcnfpass_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		protected void btnchange_Click(object sender, System.EventArgs e)
		{
			if(txtnewpass.Text.Trim() == txtcnfpass.Text.Trim() )
			{
				bool result;

				result = BLLChangePassword.changepassword(txtnewpass.Text.Trim().ToUpper(),txtoldpass.Text.Trim().ToUpper(),v_loginsesson.getloginid());
				if(result)
				{
					Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Password Changed!! \");</script>");
				}
				else
				{
					Page.RegisterStartupScript("k1","<script language=javascript> alert(\" please enter correct password.!! \");</script>");
				}
			}
			else
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\"Please confirm the new password \");</script>");
			}
		}


	}
}
