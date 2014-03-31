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

using E_HELP_DESK1.BusinessLogicLayer ;

namespace E_HELP_DESK1.UI
{
	/// <summary>
	/// Summary description for Site_registration.
	/// </summary>
	public partial class Site_registration : System.Web.UI.Page
	{

		string error;
		bool flag = true;


		protected appsesson.appsesson v_loginsesson;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			v_loginsesson = (appsesson.appsesson)Session["p_loginsesson"];
			binddatagrid();
			if(! IsPostBack)
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
			this.DGsite.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DGsite_ItemCommand);

		}
		#endregion

		protected void BtnRgstrSite_Click(object sender, System.EventArgs e)
		{
			if(checkdata())
			{
				DataTable oDataTable = new DataTable();
				BLLSiteregistration SiteData = new BLLSiteregistration();
				oDataTable = SiteData.checksitename(TxtSiteName.Text.Trim().ToUpper());
				if (oDataTable.Rows.Count>0)
				{
					Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Site Name Already Exist \");</script>");
				}
				else
				{
					bool result;
						result = SiteData.Registeroffice(
						TxtSiteName.Text.Trim().ToUpper(),
						TxtCode.Text.Trim(),
						txtLoc.Text.Trim(),
						DDOfficeType.SelectedValue.Trim(),
						TxtAdd.Text.Trim().ToUpper(),
						TxtContPName.Text.Trim(),
						TxtContPhNo.Text.Trim(),
						TxtSitePhNo.Text.Trim(),
						TxtEmail.Text.Trim(),
						TxtTmpNWIP.Text.Trim(),
						TxtGIP.Text.Trim(),
						TxtSubIP.Text.Trim()
						);
			
					if(result)
					{
						Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Site Registered successfully.\");</script>");
					}
					else
					{
						Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Site Registration failed .\");</script>");
					}
					binddatagrid();
					refreshcontrol();
				}
			}

		}
		private void binddatagrid()
		{
			BLLSiteregistration oBLLSiteregistration = new BLLSiteregistration();
			DataTable oDGDataTable = new DataTable();
			oDGDataTable =oBLLSiteregistration.GetAllSite();
			DGsite.DataSource=oDGDataTable;
			DGsite.DataBind();
		}

		private void fillpagectrl()
		{
			BLLcommon oBLLcommon = new BLLcommon();
			DataTable oDataTable = new DataTable();
			BLLSiteregistration sitedata = new BLLSiteregistration();
			oDataTable = sitedata.Gettypeofoffice();
			BLLcommon.FillDropDownBox(DDOfficeType,oDataTable,"OFFICE_TYPE","OFFICE_ID",true);
		}
		protected void DGsite_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
		}
		private void DGsite_ItemCommand(object source,System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			if (e.CommandName=="NAME")	
			{
				string  siteid = DGsite.DataKeys[e.Item.ItemIndex].ToString();
				BLLSiteregistration.setsiteid(siteid);
				BtnRgstrSite.Enabled=false;
				btndelete.Enabled=true;
				btnedit.Enabled=true;
				btnupdate.Enabled=false;
			}
		}
		public void ChangeGridPage(Object objSender, DataGridPageChangedEventArgs objArgs )
		{
			// runs when one of the pager controls is clicked

			// update the current page number from the parameter values
			DGsite.CurrentPageIndex = objArgs.NewPageIndex;

			// recreate the data set and bind it to the DataGrid control
			refreshcontrol();
			binddatagrid();
		}
		private void refreshcontrol()
		{
			txtLoc.Text="";
			TxtSiteName.Text="";
			TxtSitePhNo.Text="";
			TxtSubIP.Text="";
			TxtTmpNWIP.Text="";
			TxtAdd.Text="";
			TxtGIP.Text="";
			TxtEmail.Text="";
			TxtContPName.Text="";
			TxtContPhNo.Text="";
			TxtCode.Text="";
			DDOfficeType.SelectedIndex=-1;
			btndelete.Enabled=false;
			btnedit.Enabled=false;
			btnupdate.Enabled=false;
			BtnRgstrSite.Enabled=true;
			TxtSiteName.Enabled=true;
		}
		protected void btnedit_Click(object sender, System.EventArgs e)
		{
			BtnRgstrSite.Enabled=false;
			btnupdate.Enabled=true;
			btndelete.Enabled=false;
			btnedit.Enabled=false;
			TxtSiteName.Enabled=false;

			BLLSiteregistration oBLLSiteregistration = new BLLSiteregistration();
			DataTable oDGDataTable = new DataTable();
			oDGDataTable =oBLLSiteregistration.GetSitedata();

			TxtSiteName.Text=oDGDataTable.Rows[0][1].ToString();
			TxtCode.Text=oDGDataTable.Rows[0][2].ToString();
			txtLoc.Text=oDGDataTable.Rows[0][3].ToString();
			DDOfficeType.SelectedValue=oDGDataTable.Rows[0][4].ToString();
			TxtAdd.Text=oDGDataTable.Rows[0][5].ToString();
			TxtContPName.Text=oDGDataTable.Rows[0][6].ToString();					
			TxtContPhNo.Text=oDGDataTable.Rows[0][7].ToString();
			TxtSitePhNo.Text=oDGDataTable.Rows[0][8].ToString();
			TxtEmail.Text=oDGDataTable.Rows[0][9].ToString();
			TxtTmpNWIP.Text=oDGDataTable.Rows[0][10].ToString();
			TxtGIP.Text=oDGDataTable.Rows[0][11].ToString();
			TxtSubIP.Text=oDGDataTable.Rows[0][12].ToString();
		}

		protected void btnupdate_Click(object sender, System.EventArgs e)
		{
			if(checkdata())
			{
				BLLSiteregistration SiteData = new BLLSiteregistration();
				SiteData.updateofficedata(
					TxtCode.Text.Trim(),
					txtLoc.Text.Trim(),
					DDOfficeType.SelectedValue.Trim(),
					TxtAdd.Text.Trim(),
					TxtContPName.Text.Trim(),
					TxtContPhNo.Text.Trim(),
					TxtSitePhNo.Text.Trim(),
					TxtEmail.Text.Trim(),
					TxtTmpNWIP.Text.Trim(),
					TxtGIP.Text.Trim(),
					TxtSubIP.Text.Trim()
					);

				binddatagrid();
				refreshcontrol();
			}
		}

		protected void btndelete_Click(object sender, System.EventArgs e)
		{
			BLLSiteregistration SiteData = new BLLSiteregistration();
			SiteData.deleteoffice();
			binddatagrid();
			refreshcontrol();
		}
		private bool checkdata()
		{

			flag = false;

			if(DDOfficeType.SelectedIndex==0)
			{
//				
				error = "Select Office Type,";
				flag= true;

			}
			if(TxtSiteName.Text.Trim()=="")
			{
				error = error+"Enter Site Name,";
				flag= true;
			}
			if((TxtContPhNo.Text.Trim()=="")||(TxtContPName.Text.Trim()=="")||(TxtSitePhNo.Text.Trim()=="")||(TxtEmail.Text.Trim()==""))
			{
				error = error+"Enter Contact Detail.";
				flag= true;
			}
			else if((TxtAdd.Text.ToString().Trim().Length>200))
			{
				error = error+"Address Should be less then 200 character.";
				flag= true;
			}
			
			if(flag)
			{
//					Page.RegisterStartupScript("k1","<script language=javascript> alert(\"Select Office Type. !! \");</script>");
				Page.RegisterStartupScript("k1","<script language=javascript> alert(' " + error + " ');</script>");
				return false;
			}
				return true;
		}

		protected void TxtEmail_TextChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
