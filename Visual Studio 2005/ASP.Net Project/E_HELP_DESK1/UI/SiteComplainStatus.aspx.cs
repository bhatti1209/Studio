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
using System.IO;

using E_HELP_DESK1.BusinessLogicLayer;

namespace E_HELP_DESK1.UI
{
	/// <summary>
	/// Summary description for SiteComplainStatus.
	/// </summary>
	public partial class SiteComplainStatus : System.Web.UI.Page
	{
		
			protected appsesson.appsesson v_loginsesson ;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			v_loginsesson = (appsesson.appsesson)Session["p_loginsesson"];
			if(! IsPostBack)
			{
				if(v_loginsesson == null)
				{
					//					Response.Redirect("MainLogin.aspx");
					Response.End();
				}
				binddatagrid();// call function for fill the user vdatagrid
			}// Put user code to initialize the page here
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

		public void ChangeGridPage(Object objSender,DataGridPageChangedEventArgs objArgs )
		{
			// runs when one of the pager controls is clicked

			// update the current page number from the parameter values
			dghome.CurrentPageIndex = objArgs.NewPageIndex;

			// recreate the data set and bind it to the DataGrid control

			binddatagrid();
		}

		private void binddatagrid()
		{
		
			DataTable oDataTable = new DataTable();
			oDataTable = BLLHomeFrame.GetAllComplaint();

			if(oDataTable.Rows.Count>0)

			{
				dghome.DataSource=oDataTable;
				dghome.DataBind();	
			}
			else
			{
				dghome.Visible=false;
			}
		}

		private void imgbtnlogout_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Session.RemoveAll();
			Response.Redirect("MainLogin.aspx");
		}

		protected void dghome_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}



		protected void LinkButton1_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("Site_Complaint.aspx");
		}

		protected void Linkhelp_Click(object sender, System.EventArgs e)
		{
			string 	baseLocation =HttpRuntime.AppDomainAppPath.ToString();

		

			string vfpath=baseLocation+"ZZP000-A03-J00-514.pdf";
			string vfanme="ZZP000-A03-J00-514.pdf";


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

		protected void Linklogout_Click(object sender, System.EventArgs e)
		{
			Session.RemoveAll();

			Response.Redirect("MainLogin.aspx");
		}



	}
}
