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
	/// Summary description for Vender_Registration.
	/// </summary>
	public partial class Vender_Registration : System.Web.UI.Page
	{

		string error;
		bool flag = true;

		protected appsesson.appsesson v_loginsesson;
	
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
				binddatagrid();
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
			this.DGVender.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DGVender_ItemCommand);

		}
		#endregion

		protected void BtnvndrReg_Click(object sender, System.EventArgs e)
		{
			if(checkdata())
			{
				DataTable oDataTable = new DataTable();
				BLLVender_Registration venderdata = new BLLVender_Registration();

				oDataTable=venderdata.CheckVenderName(TxtVndrName.Text.Trim().ToUpper());
				if (oDataTable.Rows.Count>0)
				{
					Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Vender Name Already Exist \");</script>");
				}
				else
				{
					bool result;
					result= venderdata.RegisterVender(
						TxtVndrName.Text.Trim().ToUpper(),
						TxtVndrMail.Text.Trim(),
						TxtPhno1.Text.Trim(),
						TxtPhno2.Text.Trim(),
						TxtVndrLoc.Text.Trim()
						);
					if(result)
					{
						Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Vender Registered successfully.  \");</script>");
					}
					else
					{
						Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Vender Registration failed. \");</script>");
					}

					binddatagrid();
					Refreshcontrol();
				}
			}
		}
		public  bool checkdata()
		{
			flag = false;

			if(TxtVndrName.Text.Trim()=="")
			{
				//				Page.RegisterStartupScript("k1","<script language=javascript> alert(\"Select Office Type. !! \");</script>");
				error = "Enter User Name,";
				flag= true;
				//return false;
			}
			if((TxtPhno1.Text.Trim()=="")&&(TxtPhno2.Text.Trim()==""))
			{
				error = error + "Enter Contact Detail,";
				flag = true;
			}
			if(TxtVndrMail.Text.Trim()=="")
			{
				error = error + "Enter E-Mail Id.,";
				flag = true;
			}
			else if((TxtVndrLoc.Text.ToString().Trim().Length>200))
			{
				error = error+"Address Should be less then 200 character.";
				flag= true;
			}
			if(flag)
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(' " + error + " ');</script>");
				return false;
			}
			
			return true;
		}

		protected void DGVender_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void DGVender_ItemCommand(object source,System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{		
			if (e.CommandName=="NAME")	
			{
				string  sno=DGVender.DataKeys[e.Item.ItemIndex].ToString();
				BLLVender_Registration.setvendorid(sno);

				BtnvndrReg.Enabled=false;
				btnedit.Enabled=true;
				btndel.Enabled=true;
			}
		}
		public void ChangeGridPage(Object objSender, DataGridPageChangedEventArgs objArgs )
		{
			
				// runs when one of the pager controls is clicked
				// update the current page number from the parameter values
				DGVender.CurrentPageIndex = objArgs.NewPageIndex;
				// recreate the data set and bind it to the DataGrid control
				Refreshcontrol();
				binddatagrid();
			
		}

		protected void btnedit_Click(object sender, System.EventArgs e)
		{
			//disable all controls
			btndel.Enabled=false;
			BtnvndrReg.Enabled=false;
			TxtVndrName.Enabled=false;
			//enable update button
			btnupdate.Enabled=true;

			//retrive all data and send into the text boxes
			BLLVender_Registration oBLLVender_Registration = new BLLVender_Registration();
			DataTable oDGDataTable = new DataTable();
			oDGDataTable =oBLLVender_Registration.getvenderdata();
			TxtVndrName.Text=oDGDataTable.Rows[0][1].ToString();
			TxtVndrMail.Text=oDGDataTable.Rows[0][2].ToString();
			TxtPhno1.Text=oDGDataTable.Rows[0][3].ToString();
			TxtPhno2.Text=oDGDataTable.Rows[0][4].ToString();
			TxtVndrLoc.Text=oDGDataTable.Rows[0][5].ToString();
		}

			//send updated vendor data 
		protected void btnupdate_Click(object sender, System.EventArgs e)
		{
			
			BLLVender_Registration venderdata = new BLLVender_Registration();
   
			 venderdata.UpdateVender(
									TxtVndrMail.Text.Trim(),
									TxtPhno1.Text.Trim(),
									TxtPhno2.Text.Trim(),
									TxtVndrLoc.Text.Trim()	
									);

			binddatagrid();
			Page.RegisterStartupScript("k1","<script language=javascript> alert(\" updated successfully. \");</script>");
			Refreshcontrol();
			
		}

		protected void btndel_Click(object sender, System.EventArgs e)
		{
			BLLVender_Registration venderdata = new BLLVender_Registration();
			venderdata.deleteVender();
			binddatagrid();
			Refreshcontrol();
  
		}

		private void binddatagrid()
		{
				BLLVender_Registration oBLLVender_Registration = new BLLVender_Registration();
				DataTable oDGDataTable = new DataTable();
				oDGDataTable =oBLLVender_Registration.GetAllVender();
				DGVender.DataSource=oDGDataTable;
				DGVender.DataBind();
		}
		private void Refreshcontrol()
		{
			TxtPhno1.Text="";
			TxtPhno2.Text="";
			TxtVndrLoc.Text="";
			TxtVndrMail.Text="";
			TxtVndrName.Text="";
			btndel.Enabled=false;
			btnedit.Enabled=false;
 			btnupdate.Enabled=false;
			BtnvndrReg.Enabled=true;
			TxtVndrName.Enabled=true;
 			
		}

		protected void TxtVndrLoc_TextChanged(object sender, System.EventArgs e)
		{
		
		}

	}
}
