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
using E_HELP_DESK1.appsesson;

namespace E_HELP_DESK1.UI
{
	/// <summary>
	/// Summary description for MainLogin.
	/// </summary>
	public partial class MainLogin : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
	
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

		protected void Button1_Click(object sender, System.EventArgs e)
		{
			BllMainLogin login = new BllMainLogin();
			DataTable oDGDataTable = new DataTable();
			oDGDataTable = login.chkusr(txtloginname.Text.Trim().ToUpper(),txtpass.Text.Trim().ToUpper());

			if (oDGDataTable.Rows.Count>0)
			{

				string flag =oDGDataTable.Rows[0][1].ToString();

				appsesson.appsesson loginsesson = new E_HELP_DESK1.appsesson.appsesson();

				if((flag=="1") ||(flag=="2"))
				{
					if(loginsesson.setlogininfo(flag,txtloginname.Text.Trim().ToUpper()))
					{
						Session["p_loginsesson"]=loginsesson;
						Response.Redirect("Home.aspx");
					}
				}
				else if(flag=="3")
				{
					if(loginsesson.setlogininfo(flag,txtloginname.Text.Trim().ToUpper()))
					{	
//						if(appsesson.appsesson.setlogininfo(flag,txtloginname.Text.Trim()))
//						{
						Session["p_loginsesson"]=loginsesson;
						Response.Redirect("Site_Complaint.aspx?logininfo=");
//						}
					}
				}
			}
			else
			{
			Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Not a valid user !! \");</script>");
			return;
			}
		}

		protected void LinkButton1_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("http://plm.ril.com/Home.asp");
		}


	}
}
