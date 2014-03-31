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
using E_HELP_DESK1.appsesson;  
using E_HELP_DESK1.BusinessLogicLayer;
using System.IO;

namespace E_HELP_DESK1.UI
{
	/// <summary>
	/// Summary description for Site_Complaint.
	/// </summary>
	public partial class Site_Complaint : System.Web.UI.Page
	{
	
		
		protected appsesson.appsesson v_loginsesson ;

		//public appsesson.appsesson vlogininfo;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
				v_loginsesson = (appsesson.appsesson)Session["p_loginsesson"];
//			if(!IsPostBack)
//			{
				if(v_loginsesson == null)
				{
					Response.Redirect("MainLogin.aspx");
//					Response.End();
				}
//			}
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

		protected void Button2_Click(object sender, System.EventArgs e)
		{
			if(checkdata())
			{
					BLLComplain oBLLComplain = new BLLComplain();
			string complaintno=oBLLComplain.Insercomplain(
						DDTypeCmpln.SelectedValue.Trim(),
						TxtUsrName.Text.Trim(),
						v_loginsesson.GetSiteid(),
						TxtCmplnerPhNo.Text,
						TxtCmplnerCellNo.Text,
						TxtCpmSub.Text.Trim(),
						TxtCmpDtl.Text.Trim(),
						v_loginsesson.getloginid()
						);

				Mail.SendMailcnfm(v_loginsesson.GetSiteid(),complaintno);
				Refreshcontrol();
				string msg = "Complain Registred Successfully your Complain no =" + complaintno;
				Page.RegisterStartupScript("k1","<script language=javascript> alert(' " + msg + " ');</script>");
			}
		}

		public void Refreshcontrol()
		{
			TxtCmpDtl.Text="";
			TxtCpmSub.Text="";
			TxtCmplnerPhNo.Text="";
			TxtCmplnerCellNo.Text="";
			TxtUsrName.Text="";
			DDTypeCmpln.SelectedIndex=-1;
		}
		private bool checkdata()
		{
			if(DDTypeCmpln.SelectedIndex==0)
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Please select the type of problem !! \");</script>");
				return false;
			}
			else if(TxtUsrName.Text.Trim() == "")
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
			else if(TxtCmpDtl.Text.Trim()=="")
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Enter Complaint Detail.!! \");</script>");
			}
			
			return true;
		}

		private void TxtCmpDtl_TextChanged(object sender, System.EventArgs e)
		{
		
		}



		private void DDTypeCmpln_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		protected void Lnklogout_Click(object sender, System.EventArgs e)
		{
			Session.RemoveAll();

			Response.Redirect("MainLogin.aspx");
		}

		protected void lnkview_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("SiteComplainStatus.aspx");
		}

		protected void lnkhlp_Click(object sender, System.EventArgs e)
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
	
	}
}
