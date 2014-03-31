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
using System.Threading;

using E_HELP_DESK1.BusinessLogicLayer;

namespace E_HELP_DESK1.UI
{
	/// <summary>
	/// Summary description for user_Registration.
	/// </summary>
	public partial class user_Registration : System.Web.UI.Page
	{

		protected appsesson.appsesson v_loginsesson;
		

		protected void Page_Load(object sender, System.EventArgs e)                   
		{
			v_loginsesson = (appsesson.appsesson)Session["p_loginsesson"];
			//fill data grid
			if(! IsPostBack)
			{
				if(v_loginsesson == null)
				{
//					Response.Redirect("MainLogin.aspx");
					Response.End();
				}

				fillpagectrl();//call function for fill the drop down
				binddatagrid();// call function for fill the user vdatagrid
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
			this.DGUsr.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DGUsr_ItemCommand);

		}
		#endregion

		protected void BtnRegUser_Click(object sender, System.EventArgs e)
		{
			if(checkdata())
			{
				/////////////////////NEW USER REGISTRATION//////////////////////////////
				DataTable oDataTable = new DataTable();
				BLLuser_Registration userdata = new BLLuser_Registration();
				//check login id is already exsist or not.
				oDataTable=userdata.checkLoginId(TxtLgnName.Text.Trim().ToUpper());
				if (oDataTable.Rows.Count>0)
				{
					Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Login Id Already Exist \");</script>");
				}
				else
				{
					bool result;
					result= userdata.RegisterSupportUser(
						TxtUsrName.Text.Trim(),
						TxtLgnName.Text.Trim().ToUpper(),
						TxtEmpCode.Text.Trim(),
						TxtMail.Text.Trim(),
						DDUsrTyp.SelectedValue.Trim(),
						TxtDob.Text.Trim(),
						TxtPhNo.Text.Trim(),
						TxtMobNo.Text.Trim()	
						);
					if(result)
					{
						Page.RegisterStartupScript("k1","<script language=javascript> alert(\" User Registered successfully \");</script>");
					}
					else
					{
						Page.RegisterStartupScript("k1","<script language=javascript> alert(\" User Registration failed \");</script>");
					}
					binddatagrid();
					Refreshcontrol();
				}
			}

		}

		// function are used to Fill data grid
		private void binddatagrid()
		{
						BLLuser_Registration oBLLuser_Registration = new BLLuser_Registration();
						DataTable oDGDataTable = new DataTable();
						oDGDataTable =oBLLuser_Registration.GetAllUser();
						DGUsr.DataSource=oDGDataTable;
						DGUsr.DataBind();
		}
		// function used for fill page drop down
		private void fillpagectrl()
		{
				BLLcommon oBLLcommon = new BLLcommon();
				DataTable oDataTable = new DataTable();			
				BLLuser_Registration usertype = new BLLuser_Registration();
				oDataTable = usertype.GetUserType();
				BLLcommon.FillDropDownBox(DDUsrTyp,oDataTable,"LOGIN","LOGIN_ID",true);
		}
		


		private void DGUsr_ItemCommand(object source,System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{		
			if (e.CommandName=="USER NAME")	
			{
				string  usrid = DGUsr.DataKeys[e.Item.ItemIndex].ToString();
				BLLuser_Registration.setusrid(usrid);
				BtnRegUser.Enabled=false;
				Btndel.Enabled=true;
				BtnEdit.Enabled=true;
				BtnUpdt.Enabled=false;
			}
			
		}
		public void ChangeGridPage(Object objSender, DataGridPageChangedEventArgs objArgs )
		{
			// runs when one of the pager controls is clicked

			// update the current page number from the parameter values
			DGUsr.CurrentPageIndex = objArgs.NewPageIndex;

			// recreate the data set and bind it to the DataGrid control
			Refreshcontrol();
			binddatagrid();
		}

		protected void DGUsr_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		protected void BtnEdit_Click(object sender, System.EventArgs e)
		{
			BtnRegUser.Enabled=false;
			TxtLgnName.Enabled=false;
			BtnUpdt.Enabled=true;
			Btndel.Enabled=false;
			BtnEdit.Enabled=false;

			BLLuser_Registration oBLLuser_Registration = new BLLuser_Registration();
			DataTable oDGDataTable = new DataTable();
			oDGDataTable =oBLLuser_Registration.GetUserdata();

				TxtUsrName.Text=oDGDataTable.Rows[0][1].ToString();
				TxtLgnName.Text=oDGDataTable.Rows[0][2].ToString();
				TxtEmpCode.Text=oDGDataTable.Rows[0][3].ToString();
				TxtMail.Text=oDGDataTable.Rows[0][4].ToString();
				DDUsrTyp.SelectedValue=oDGDataTable.Rows[0][5].ToString();
				TxtDob.Text=oDGDataTable.Rows[0][6].ToString();
				TxtPhNo.Text=oDGDataTable.Rows[0][7].ToString();
				TxtMobNo.Text=oDGDataTable.Rows[0][8].ToString();


		}

		protected void BtnUpdt_Click(object sender, System.EventArgs e)
		{
			if(checkdata())
			{
				BLLuser_Registration oBLLuser_Registration = new BLLuser_Registration();
				oBLLuser_Registration.updateUser(
					TxtUsrName.Text.Trim(),
					TxtEmpCode.Text.Trim(),
					TxtMail.Text.Trim(),
					DDUsrTyp.SelectedValue.Trim(),
					TxtDob.Text.Trim(),
					TxtPhNo.Text.Trim(),
					TxtMobNo.Text.Trim()
					);


				binddatagrid();//fill data grid
				Refreshcontrol();//refresh control
			}
	}

		protected void Btndel_Click(object sender, System.EventArgs e)
		{
			BLLuser_Registration oBLLuser_Registration = new BLLuser_Registration();
			oBLLuser_Registration.DeleteUser();
			binddatagrid();
			Refreshcontrol();
		}

		private void Refreshcontrol()
		{
			TxtDob.Text="";
			DDUsrTyp.SelectedIndex=-1;
			TxtEmpCode.Text="";
			TxtLgnName.Text="";
			TxtMail.Text="";
			TxtMobNo.Text="";
			TxtPhNo.Text="";
			TxtUsrName.Text="";
			Btndel.Enabled=false;
			BtnEdit.Enabled=false;
			BtnUpdt.Enabled=false;
			BtnRegUser.Enabled=true;
			TxtLgnName.Enabled=true;
		}
		private bool checkdata()
		{
			
			if(DDUsrTyp.SelectedIndex==0)
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\"Select User Type. !! \");</script>");
				return false;
			}
			else if(TxtUsrName.Text.Trim()=="" )
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\"Enter User Name. !! \");</script>");
				return false;
			}
			else if(TxtLgnName.Text.Trim()=="" )
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\"Enter Login Name. !! \");</script>");
				return false;
			}
			else if(TxtMail.Text.Trim()=="")
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\"Enter Email Id. !! \");</script>");
				return false;
			}
			else if((TxtPhNo.Text.Trim()=="")&&(TxtMobNo.Text.Trim()==""))
			{
				Page.RegisterStartupScript("k1","<script language=javascript> alert(\" Please Enter atleast one Contact number !! \");</script>");
				return false;
			}
				return true;
		}
		}
	}

