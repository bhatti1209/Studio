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
	/// Summary description for complainstatus.
	/// </summary>
	public partial class complainstatus : System.Web.UI.Page
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
				DataGrid1.CurrentPageIndex=0;
			}
			binddatagrid();
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
			this.DataGrid1.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_ItemCommand);

		}
		#endregion

		private void DataGrid1_ItemCommand(object source,System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{		
			if (e.CommandName=="CMPSUB1")	
			{
				BLLComplainstatus oCmpBLLComplainstatus = new BLLComplainstatus();
				DataTable oDataTable = new DataTable();
				string  sno=DataGrid1.DataKeys[e.Item.ItemIndex].ToString();
				v_loginsesson.setcmpno(sno);
				oDataTable = oCmpBLLComplainstatus.GetComplainData(v_loginsesson.getcmpno());
				
				Txtdtl.Text=oDataTable.Rows[0][4].ToString();

				txtdtl2.Text="Complainer Name :-  " + oDataTable.Rows[0][0].ToString(); 
				txtdtl2.Text = txtdtl2.Text+"\n";
				txtdtl2.Text=txtdtl2.Text +"Complainer Ph No :-  " + oDataTable.Rows[0][2].ToString();
				txtdtl2.Text = txtdtl2.Text+"\n";
				txtdtl2.Text=txtdtl2.Text +"Complainer Mob No :-  " + oDataTable.Rows[0][3].ToString();
				txtdtl2.Text = txtdtl2.Text+"\n";
				txtdtl2.Text = txtdtl2.Text+ "Complain date & time  :- " + oDataTable.Rows[0][1].ToString();
				txtdtl2.Text = txtdtl2.Text+"\n";

				if(BLLComplainstatus.GetComplainStatus(v_loginsesson.getcmpno())=="Pending")
				{
					Btnundertaken.Enabled=true;
				}
			}
		}
		public void ChangeGridPage(Object objSender, DataGridPageChangedEventArgs objArgs )
		{
			// runs when one of the pager controls is clicked
			// update the current page number from the parameter values
			DataGrid1.CurrentPageIndex = objArgs.NewPageIndex;
			// recreate the data set and bind it to the DataGrid control
			Btnundertaken.Enabled=false;
			refreshcontrol();
			binddatagrid();
		}
		private void binddatagrid()
			{
			BLLComplainstatus oBLLComplainstatus = new BLLComplainstatus();
			DataTable oDataTable = new DataTable();
			oDataTable =oBLLComplainstatus.GetComplain();
			if(oDataTable.Rows.Count>0)

			{
				DataGrid1.DataSource=oDataTable;
				DataGrid1.DataBind();
			}
			else
			{
				DataGrid1.Visible=false;
				Btnundertaken.Enabled=false;
			}
		}
		private void refreshcontrol()
		{
			Txtdtl.Text="";
			txtdtl2.Text="";
			Btnundertaken.Enabled=false;
		}

		protected void Btnundertaken_Click(object sender, System.EventArgs e)
		{
			if(BLLComplainstatus.GetComplainStatus( v_loginsesson.getcmpno())== "Pending" ) 
			{
				BLLComplainstatus.cmpundertaken(v_loginsesson.getcmpno(),v_loginsesson.getloginid());
				DataGrid1.CurrentPageIndex=0;	
			}
			else
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Complain Not Exsist. !! \");</script>");
			}
			binddatagrid();
			refreshcontrol();
		}

		protected void DataGrid1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

	}
}
