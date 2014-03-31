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


using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace E_HELP_DESK1.UI
{
	public partial class Report : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DropDownList DrpItsptname;
		protected System.Web.UI.WebControls.DropDownList drpRpttypitspt;
		protected System.Web.UI.WebControls.CheckBox chkclosercallitspt;
		protected System.Web.UI.WebControls.CheckBox chkopencallitspt;
		protected System.Web.UI.WebControls.DropDownList Drpsitename;
		protected System.Web.UI.WebControls.DropDownList drpRpttypsite;
		protected System.Web.UI.WebControls.CheckBox chkclosercallsite;
		protected System.Web.UI.WebControls.CheckBox chkopencallsite;
		protected System.Web.UI.WebControls.RadioButton optbtnall;
		protected System.Web.UI.WebControls.DropDownList drpRpttypall;
		protected System.Web.UI.WebControls.TextBox txtdatfrmall;
		protected System.Web.UI.WebControls.Image imgdatfrmall;
		protected System.Web.UI.WebControls.TextBox txtdattoall;
		protected System.Web.UI.WebControls.Image imgdattoall;
		protected System.Web.UI.WebControls.Button btnrptall;

		
		protected appsesson.appsesson v_loginsesson;

		protected CrystalDecisions.Web.CrystalReportViewer CrystalReportViewer1 = new CrystalDecisions.Web.CrystalReportViewer();

	
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

		

		protected void btnrptsite_Click(object sender, System.EventArgs e)
		{
			if((txtdatfrmsite.Text=="")||(txtdattosite.Text==""))
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\"Please Enter the proper date. \");</script>");
				imgdatfrmsite.Visible=true;
				imgdattosite.Visible=true;
			}
			else
			{
				BLLReport o_BLLReport = new BLLReport();
				o_BLLReport.setdatefield(txtdatfrmsite.Text.Trim(),txtdattosite.Text.Trim());
				Session["o_BLLReport"]=o_BLLReport;
				Response.Redirect("Report1.aspx");
			}   

		}

		protected void optbtnitspt_CheckedChanged(object sender, System.EventArgs e)
		{
			txtdatfrmitspt.Enabled =true;
			txtdattoitspt.Enabled = true;
			btnrptitspt.Enabled = true;

			imgdatfrmitspt.Visible = true;
			imgdattoitspt.Visible = true;
			
		}
		private void refreshcontrol()
		{
			txtdatfrmitspt.Enabled =false;
			txtdattoitspt.Enabled = false;

			txtdatfrmitspt.Text="";
			txtdattoitspt.Text = "";

			btnrptitspt.Enabled = false;

			imgdatfrmitspt.Visible = false;
			imgdattoitspt.Visible= false;


			txtdatfrmsite.Enabled=true;
			txtdattosite.Enabled=true;
			btnrptsite.Enabled=true;

			txtdatfrmsite.Text="";
			txtdattosite.Text="";

			imgdatfrmsite.Visible=true;
			imgdattosite.Visible=true;
		}

		protected void optbtnsite_CheckedChanged(object sender, System.EventArgs e)
		{
			txtdatfrmsite.Enabled=true;
			txtdattosite.Enabled=true;
			btnrptsite.Enabled=true;

			imgdatfrmsite.Visible=true;
			imgdattosite.Visible=true;
		}

		protected void btnrptitspt_Click(object sender, System.EventArgs e)
		{
			BLLReport o_BLLReport = new BLLReport();
			o_BLLReport.setdatefield(txtdatfrmitspt.Text.Trim(),txtdattoitspt.Text.Trim());

			Session["o_BLLReport"]=o_BLLReport;
			Response.Redirect("individualcomplain.aspx");
		}
	}
}
