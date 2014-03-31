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

namespace E_HELP_DESK1.appsesson
{
	/// <summary>
	/// Summary description for appsesson.
	/// </summary>
	public class appsesson
	{
		public appsesson()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		string usertype;
		string login_id;
		string  ucmpno;

		public bool  setlogininfo(string p_Loginusrtyp , string p_loginid)
		{
			usertype = p_Loginusrtyp;
			login_id = p_loginid;
			return true;
		}
		public string GetSiteid()
		{
			string loginid = getloginid();
			DataTable oDataTable =DALCommon.ExecuteDataTable("select SITE_ID from TBL_SITE_REGISTRATION where SITE_NAME='"+loginid+"'");	
			if(oDataTable.Rows.Count > 0)
			{	
			}
			return oDataTable.Rows[0][0].ToString();
		}
		public string getlogintype()
		{
			return usertype;
		}
		public string getloginid()
		{
			return login_id;
		}
		public void setcmpno(string v_cmpno)
		{
			ucmpno = v_cmpno;
		}
		public string getcmpno()
		{
			return ucmpno;
		}
	}
}
