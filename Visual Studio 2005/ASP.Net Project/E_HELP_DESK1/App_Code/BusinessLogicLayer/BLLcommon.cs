using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OracleClient;
using System.Web.SessionState;
using System.Text.RegularExpressions;
using System.Web.UI.HtmlControls;
using System.Configuration;

using E_HELP_DESK1.DataAccessLayer;

namespace E_HELP_DESK1.BusinessLogicLayer
{
	/// <summary>
	/// Summary description for BLLcommon.
	/// </summary>
	public class BLLcommon
	{
		public BLLcommon()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		#region FUNCTION TO FILL DROPDOWN LIST
		public  static void FillDropDownBox(DropDownList oDropDownList,DataTable oDataTable,string TextFeild,string ValueFeild,bool AddSelect)
		{
			oDropDownList.DataSource=oDataTable;
			oDropDownList.DataTextField=TextFeild;
			oDropDownList.DataValueField=ValueFeild;
			oDropDownList.DataBind();

			//Add a default SELECT option to the dropdown
			if(AddSelect==true)
			{
				ListItem oListItem=new ListItem("Please Select","Please Select");
				oDropDownList.Items.Insert(0,oListItem);
			}
		}
		#endregion
	}
}
