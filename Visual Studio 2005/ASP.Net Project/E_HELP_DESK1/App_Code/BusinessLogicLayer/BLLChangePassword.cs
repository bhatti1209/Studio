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
using E_HELP_DESK1.appsesson;

namespace E_HELP_DESK1.BusinessLogicLayer
{
	/// <summary>
	/// Summary description for BLLChangePassword.
	/// </summary>
	public class BLLChangePassword
	{
		public BLLChangePassword()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public static bool changepassword(string v_tempnewpass, string v_oldpass,string v_loginid)
		{
			bool result;
			result=DALCommon.ExecuteNonQuery("Update TBL_LOGIN set LOGIN_PWD='"+v_tempnewpass+"' where LOGIN_NAME='"+v_loginid+"' and LOGIN_PWD='"+v_oldpass+"'");
			return result;
		}
	}
}
