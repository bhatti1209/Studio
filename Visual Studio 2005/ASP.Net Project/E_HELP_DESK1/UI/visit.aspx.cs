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
	/// Summary description for visit.
	/// </summary>
	public partial class visit : System.Web.UI.Page
	{

		protected appsesson.appsesson v_loginsesson;
		protected BLLMyComplain oBLLMyComplain;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			if(! IsPostBack)
			{
				v_loginsesson = (appsesson.appsesson)Session["p_loginsesson"];
				if(! IsPostBack)
				{
					if(v_loginsesson == null)
					{
//						Response.Redirect("MainLogin.aspx");
						Response.End();
					}

				}
				oBLLMyComplain = (BLLMyComplain)Session["oBLLMyComplain"];
				lblcmpno.Text=lblcmpno.Text + oBLLMyComplain.getcomplainno().ToString();
				binddatagrid();
			}
			// Put user code to initialize the page here
		}

		private void binddatagrid()
		{
//			BLLMyComplain oBLLMyComplain = new  BLLMyComplain();
			DataTable oDataTable = new DataTable();
			BLLvisit oBLLvisit= new BLLvisit();
			BLLMyComplain oBLLMyComplain =(BLLMyComplain)Session["oBLLMyComplain"];
			oDataTable=oBLLvisit.forwardcmpdata(oBLLMyComplain.getcomplainno().ToString());

			if(oDataTable.Rows.Count>0)
			{
				DGfwdcmp.DataSource=oDataTable;
				DGfwdcmp.DataBind();	
			}
			else
			{
				DGfwdcmp.Visible=false;
			}
		}
		private void bindvisitdatagrid()
		{
//			BLLMyComplain oBLLMyComplain = new  BLLMyComplain();
			DataTable oDataTable = new DataTable();
			BLLvisit oBLLvisit= new BLLvisit();
			oDataTable=oBLLvisit.getvisitdetail();

			if(oDataTable.Rows.Count>0)
			{
				DGvisit.Visible=true;
				DGvisit.DataSource=oDataTable;
				DGvisit.DataBind();
				Lblvisit.Text="Total Visit :-" + oDataTable.Rows.Count ;
			}
			else
			{
				Lblvisit.Text="Total Visit :-" + oDataTable.Rows.Count ;
				DGvisit.Visible=false;
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

		protected void DGfwdcmp_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}
		public void DGfwdcmp_ItemCommand(object source,System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			if (e.CommandName=="Forward")
			{
				BLLvisit  oBLLvisit = new BLLvisit();
			
				string  sno=DGfwdcmp.DataKeys[e.Item.ItemIndex].ToString();
				BLLvisit.setfwdcmpno(sno);
				Refreshcontrol();
				DGvisit.CurrentPageIndex=0;
				bindvisitdatagrid();
			
				DataTable cmpstatus = new DataTable();
				cmpstatus=oBLLvisit.getfwdcmpstatus();
				switch(cmpstatus.Rows[0][0].ToString())
				{
					case "Running":
						btnaddvisit.Enabled=true;
						btnclosecmp.Enabled=true;
						btndone.Enabled=true;
						break;

					case "Closed":
						Refreshcontrol();
						break;

					case"Resolved":
						Refreshcontrol();
						break;

					default:
						break;
				}
			}

		}
		public void Refreshcontrol()
		{
			btnaddvisit.Enabled=false;
			btnclosecmp.Enabled=false;
			btndone.Enabled=false;
			txtvisitdate.Enabled=false;
			txtvisitdtl.Enabled=false;
			btnsavevisit.Enabled=false;

			txtvisitdtl.Text="";
			txtvisitdate.Text="";
			imgdatfrmall.Visible=false;
			
		}

		protected void btnclosecmp_Click(object sender, System.EventArgs e)
		{
			BLLvisit oBLLvisit= new BLLvisit();
			oBLLvisit.cmplainclosed();
			Response.Redirect("MyComplain.aspx");
//			binddatagrid();
//			Refreshcontrol();
		}

		protected void btndone_Click(object sender, System.EventArgs e)
		{
			BLLvisit oBLLvisit= new BLLvisit();
			oBLLvisit.Resolvedcomplain();
			Refreshcontrol();
			binddatagrid();
			Response.Redirect("MyComplain.aspx");
		}

		protected void btnaddvisit_Click(object sender, System.EventArgs e)
		{
			Refreshcontrol();
			btnsavevisit.Enabled=true;
			txtvisitdate.Enabled=true;
			txtvisitdtl.Enabled=true;

			imgdatfrmall.Visible=true;
			txtvisitdtl.Enabled=true;
		}

		private void txtvisitdtl_TextChanged(object sender, System.EventArgs e)
		{
		}
		protected void btnsavevisit_Click(object sender, System.EventArgs e)
		{
			if(checkaddvisitdata())
			{
				BLLvisit oBLLvisit= new BLLvisit();
				oBLLvisit.addvisit(txtvisitdate.Text.Trim(),txtvisitdtl.Text.Trim()); 
				Refreshcontrol();
				bindvisitdatagrid();
			}
		}
		protected void DGvisit_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		}
		public void ChangeGridPage(Object objSender, DataGridPageChangedEventArgs objArgs )
		{
			// runs when one of the pager controls is clicked
			// update the current page number from the parameter values
			DGfwdcmp.CurrentPageIndex = objArgs.NewPageIndex;
			// recreate the data set and bind it to the DataGrid control
			Refreshcontrol();
			binddatagrid();
		}

		public void ChangevisitGridPage(Object objSender, DataGridPageChangedEventArgs objArgs )
		{
			// runs when one of the pager controls is clicked
			// update the current page number from the parameter values
			DGvisit.CurrentPageIndex = objArgs.NewPageIndex;
			// recreate the data set and bind it to the DataGrid control
			Refreshcontrol();
			bindvisitdatagrid();
			
		}

		private void imscal_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
		
		}

		private bool checkaddvisitdata()
		{
			if((txtvisitdate.Text.Trim()=="")||(txtvisitdtl.Text.Trim()==""))
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\"Please Fill Visit Date and Detail ..!! \");</script>");
				return false;
			}
			return true;
		}
	}
}
