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

using System.Web.Mail;

using E_HELP_DESK1.BusinessLogicLayer;

namespace E_HELP_DESK1.UI
{
	/// <summary>
	/// Summary description for MyComplain.
	/// </summary>
	public partial class MyComplain : System.Web.UI.Page
	{
		
		protected appsesson.appsesson v_loginsesson;
		protected BLLMyComplain oBLLMyComplain;
		
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			v_loginsesson = (appsesson.appsesson)Session["p_loginsesson"];
			if(!IsPostBack)
			{
				
				DGMyCmp.CurrentPageIndex=0;
				if(v_loginsesson == null)
				{
//					Response.Redirect("MainLogin.aspx");
					Response.End();
				}
				fillpagectrl();
				binddatagrid();
			}


		}

		
		public void ChangeGridPage(Object objSender,DataGridPageChangedEventArgs objArgs )
		{
			// runs when one of the pager controls is clicked

			// update the current page number from the parameter values
			DGMyCmp.CurrentPageIndex = objArgs.NewPageIndex;

			// recreate the data set and bind it to the DataGrid control
			Refreshcontrol();
			binddatagrid();
		}

		public void DGMyCmp_ItemCommand(object source,System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{		
			if (e.CommandName=="CMPSUB1")	
			{
				oBLLMyComplain = new BLLMyComplain();

				string sno=DGMyCmp.DataKeys[e.Item.ItemIndex].ToString();
				oBLLMyComplain.setcomplainnumber(sno);

				Session["oBLLMyComplain"]=oBLLMyComplain;


				switch(BLLComplainstatus.GetComplainStatus(sno))
				{
					case "Running":
//						btnclosed.Enabled=true;
						btndone.Enabled=true;
						btnforward.Enabled=true;
						btnsendback.Enabled=true;

						BtnChkcmp.Enabled=false;

						DDvndrname.SelectedIndex=-1;
						DDvndrname.Enabled=false;
						btnsend.Enabled=false;
						TxtRemark.Enabled=true;
					break;

					case "Closed":
//						btnclosed.Enabled=false;
						btndone.Enabled=false;
						btnforward.Enabled=false;
						btnsendback.Enabled=false;

						BtnChkcmp.Enabled=false;

						DDvndrname.SelectedIndex=-1;
						DDvndrname.Enabled=false;
						btnsend.Enabled=false;
						TxtRemark.Enabled=false;
					break;

					case"Resolved":
//						btnclosed.Enabled=false;
						btndone.Enabled=false;
						btnforward.Enabled=false;
						btnsendback.Enabled=false;
						DDvndrname.SelectedIndex=-1;
						DDvndrname.Enabled=false;
						btnsend.Enabled=false;
						BtnChkcmp.Enabled=false;
						TxtRemark.Enabled=false;
					break;

					case"Forward":

						BtnChkcmp.Enabled=true;
						
//						btnclosed.Enabled=false;
						btndone.Enabled=false;
						btnforward.Enabled=false;
						btnsendback.Enabled=false;
						TxtRemark.Enabled=false;
						DDvndrname.SelectedIndex=-1;
						DDvndrname.Enabled=false;
						btnsend.Enabled=false;
					break;

					default:
						break;
				}
				
				DataTable oDataTable = new DataTable();
				oDataTable = oBLLMyComplain.GetMyComplainData();

				txtcmpdtl.Text=oDataTable.Rows[0][4].ToString();

				TxtCmpdtl2.Text = "Complainer Name :-  " + oDataTable.Rows[0][0].ToString(); 
				TxtCmpdtl2.Text = TxtCmpdtl2.Text + "\n";
				TxtCmpdtl2.Text=TxtCmpdtl2.Text +"Complainer PH No :-"+oDataTable.Rows[0][2];
				TxtCmpdtl2.Text = TxtCmpdtl2.Text + "\n";
				TxtCmpdtl2.Text=TxtCmpdtl2.Text +"Complainer Mob No:-"+oDataTable.Rows[0][3];
				TxtCmpdtl2.Text = TxtCmpdtl2.Text + "\n";
				TxtCmpdtl2.Text = TxtCmpdtl2.Text + "Complain date & time:- " + oDataTable.Rows[0][1].ToString();
				TxtCmpdtl2.Text = TxtCmpdtl2.Text + "\n";
			
			}
		}
		private void fillpagectrl()
		{
			BLLcommon oBLLcommon = new BLLcommon();
			DataTable ovenderDataTable = new DataTable();
			BLLMyComplain venderdata = new  BLLMyComplain();
			ovenderDataTable = venderdata.Getvendor();
			BLLcommon.FillDropDownBox(DDvndrname,ovenderDataTable,"VENDOR_NAME","VENDOR_ID",true);

			Lblusrname.Text=v_loginsesson.getloginid();

		}
		private void binddatagrid()
		{
			BLLMyComplain oBLLMyComplain = new  BLLMyComplain();
			DataTable oDataTable = new DataTable();
			oDataTable =oBLLMyComplain.GetMyComplain(v_loginsesson.getloginid());

			if(oDataTable.Rows.Count>0)

			{
				DGMyCmp.DataSource=oDataTable;
				DGMyCmp.DataBind();	
			}
			else
			{
				DGMyCmp.Visible=false;
				Refreshcontrol();
			}
		}

		private void Refreshcontrol()
		{
//			btnclosed.Enabled=false;
			btndone.Enabled=false;
			btnforward.Enabled=false;
			btnsendback.Enabled=false;
			BtnChkcmp.Enabled=false;

			txtcmpdtl.Text="";
			TxtCmpdtl2.Text="";
			TxtRemark.Text="";

			DDvndrname.Enabled=false;
			btnsend.Enabled=false;
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

		protected void btnforward_Click(object sender, System.EventArgs e)
		{
//			btnclosed.Enabled=false;
			btndone.Enabled=false;
			btnsendback.Enabled=false;
			btnsend.Enabled=false;
			DDvndrname.Enabled=true;
			DDvndrname.SelectedIndex=-1;
		}

		protected void DDvndrname_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(DDvndrname.SelectedIndex!= -1)
			{
				btnsend.Enabled=true;
			}
		}
		protected void btnsend_Click(object sender, System.EventArgs e)
		{
			 if(TxtRemark.Text.Trim() != "")
			{
				 oBLLMyComplain = (BLLMyComplain)Session["oBLLMyComplain"];
				 oBLLMyComplain.Forwardcomplain(DDvndrname.SelectedValue.ToString(),TxtRemark.Text);
				 Mail.SendMail(DDvndrname.SelectedValue.ToString(),oBLLMyComplain.getcomplainno());

				binddatagrid();
				Refreshcontrol();
			}
			else
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Fill Remark!! \");</script>");
			}
		}

		protected void btnsendback_Click(object sender, System.EventArgs e)
		{
			if(TxtRemark.Text.Trim() != "")
			{
				oBLLMyComplain = (BLLMyComplain)Session["oBLLMyComplain"];
				oBLLMyComplain.sendbackcomplain(TxtRemark.Text.Trim(),v_loginsesson.getloginid());
				DGMyCmp.CurrentPageIndex=0;
				binddatagrid();
				Refreshcontrol();
			}
			else
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Fill Remark!! \");</script>");
			}
		}

//		private void btnclosed_Click(object sender, System.EventArgs e)
//		{
//			if(TxtRemark.Text.Trim() != "")
//			{
//				oBLLMyComplain = (BLLMyComplain)Session["oBLLMyComplain"];
//				oBLLMyComplain.closecomplain(TxtRemark.Text.Trim(),v_loginsesson.getloginid());
//				binddatagrid();
//				Refreshcontrol();
//			}
//			else
//			{
//				Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Fill Remark!! \");</script>");
//			}
//		}

		protected void btndone_Click(object sender, System.EventArgs e)
		{
			if(TxtRemark.Text.Trim() != "")
			{
				oBLLMyComplain = (BLLMyComplain)Session["oBLLMyComplain"];
				oBLLMyComplain.resolvedcomplain(TxtRemark.Text.Trim(),v_loginsesson.getloginid());
				binddatagrid();
				Refreshcontrol();
			}
			else
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Fill Remark!! \");</script>");
			}
		}
		protected void DGMyCmp_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}
	
		protected void BtnChkcmp_Click(object sender, System.EventArgs e)
		{
			
			Response.Redirect("visit.aspx");
		}
	}
}
