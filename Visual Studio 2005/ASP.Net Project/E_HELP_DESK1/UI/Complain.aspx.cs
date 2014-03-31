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

namespace E_HELP_DESK1.UI
{
	/// <summary>
	/// Summary description for Complain.
	/// </summary>
	public partial class Complain : System.Web.UI.Page
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
				fillpagectrl();
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

		protected void ddsitename_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			DataTable oDataTable = new DataTable();
			BLLComplain sitedata = new BLLComplain();
			oDataTable =sitedata.GetSitedata(DDSiteName.SelectedValue);
			TxtSitePhNo.Text=oDataTable.Rows[0][0].ToString();
			TxtSiteEMail.Text=oDataTable.Rows[0][1].ToString();
		}

		protected void BtnRegCmp_Click(object sender, System.EventArgs e)
		{
			string complaintno;
			if(checkdata())
			{
				BLLComplain oBLLComplain = new BLLComplain();
				complaintno=oBLLComplain.Insercomplain(
					DDTypeCmpln.SelectedValue.Trim(),
					TxtUsrName.Text.Trim(),
					DDSiteName.SelectedValue.Trim(),
					TxtCmplnerPhNo.Text,
					TxtCmplnerCellNo.Text,
					TxtCpmSub.Text.Trim(),
					TxtCmpDtl.Text.Trim(),
					v_loginsesson.getloginid()
					);
				
				Mail.SendMailcnfm(DDSiteName.SelectedValue.Trim().ToString(),complaintno);
				refreshcontrol();
				string msg;
				msg = "Complain Registred Successfully your Complain no =" + complaintno;
				Page.RegisterStartupScript("k1","<script language=javascript> alert(' " + msg + " ');</script>");
			}
		}
		public void fillpagectrl()
		{
			DataTable oDataTable = new DataTable();
			BLLComplain sitedata = new BLLComplain();
			oDataTable =sitedata.GetSiteName();
			BLLcommon.FillDropDownBox (DDSiteName,oDataTable,"SITE_NAME","SITE_ID",true);
			//BLLGeneral.FillDropDownBox (DDSiteName,oDataTable,"SITE_NAME","SITE_ID",true);
		}

		public void refreshcontrol()
		{
			
			TxtCmpDtl.Text="";
			TxtCpmSub.Text="";
			TxtCmplnerPhNo.Text="";
			TxtCmplnerCellNo.Text="";
			TxtSiteEMail.Text="";
			TxtSitePhNo.Text="";
			TxtUsrName.Text="";
			
			DDTypeCmpln.SelectedIndex=-1;
			DDSiteName.SelectedIndex=-1;
		}
		
		private bool checkdata()
		{
			if(DDTypeCmpln.SelectedIndex==0)
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Please select the type of problem !! \");</script>");
				return false;
			}
			else if(DDSiteName.SelectedIndex==0)
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Please select The site !! \");</script>");
				return false;
			}
			else if(TxtUsrName.Text.Trim()=="")
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Please Enter User name  \");</script>");
				return false;
			}

			else if((TxtCmplnerPhNo.Text.Trim()=="")&&(TxtCmplnerCellNo.Text.Trim()==""))
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Please Enter atleast one Contact number !! \");</script>");
				return false;
			}
			else if((TxtCpmSub.Text.Trim()=="")||(TxtCmpDtl.Text.Trim() ==""))
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Please Enter Subject and detail properly. \");</script>");
				return false;
			}
			else if((TxtCmpDtl.Text.ToString().Trim().Length>500))
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Complain detail Should be less then 500 character. \");</script>");
				return false;
			}
				return true;
		}

		protected void TxtCmpDtl_TextChanged(object sender, System.EventArgs e)
		{
		
		}


	}
}
