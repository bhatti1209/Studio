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
	/// Summary description for BllMainLogin.
	/// </summary>
	public class BllMainLogin
	{
		public BllMainLogin()
		{
			//
			// TODO: Add constructor logic here
			//
		}
			//set the login user
		public static  bool SetLogin( string v_LOGIN_NAME, string v_LOGIN_ID)
		{
			bool result;
			result=DALCommon.ExecuteScalar("Insert into TBL_LOGIN values('"+v_LOGIN_NAME+"','"+v_LOGIN_NAME+"','"+v_LOGIN_ID+"')");
			return result;
		}
		public static bool SetLogin( string v_LOGIN_NAME)
		{
			bool result;
			result=DALCommon.ExecuteScalar("Insert into TBL_LOGIN values('"+v_LOGIN_NAME+"','"+v_LOGIN_NAME+"',3)");
			return result;
		}
		public   DataTable chkusr(string v_LOGIN_NAME ,string v_LOGIN_PWD)
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("Select LOGIN_NAME,LOGIN_TYPE from TBL_LOGIN where LOGIN_NAME ='"+v_LOGIN_NAME+"'  and LOGIN_PWD='"+v_LOGIN_PWD+"'");	
			if(oDataTable.Rows.Count > 0)
			{
			}
			return oDataTable;		
		}

	}
}
