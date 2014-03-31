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
	/// Summary description for BLLuser_Registration.
	/// </summary>
	public class BLLuser_Registration
	{
		public static string v_userid;

		public BLLuser_Registration()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public  bool RegisterSupportUser(string v_USER_NAME,string v_USER_LOGIN_NAME,string v_USER_EMP_CODE,string v_USER_MAIL_ID,string v_USER_TYPE,string v_USER_DOB,string v_USER_CONTACT_NO,string v_USER_MOB_NO)
		{
			bool result;
			result=DALCommon.ExecuteScalar("Insert into TBL_SUPT_USER values(SEQ_TBL_SUPT_USER.nextval,'"+v_USER_NAME+"','"+v_USER_LOGIN_NAME+"','"+v_USER_EMP_CODE+"','"+v_USER_MAIL_ID+"','"+v_USER_TYPE+"','"+v_USER_DOB+"','"+v_USER_CONTACT_NO+"','"+v_USER_MOB_NO+"')");
			if(result)
			{
				BllMainLogin logindata = new BllMainLogin();
				result=BllMainLogin.SetLogin(v_USER_LOGIN_NAME,v_USER_TYPE);
				return result;
			}
			return result;
		}

		public   DataTable GetUserType()
		{

			DataTable oDataTable =DALCommon.ExecuteDataTable("select LOGIN,LOGIN_ID from TBL_LOGIN_TYPE Order by LOGIN_ID");
			
			if(oDataTable.Rows.Count > 0)
			{
				
			}
			return oDataTable;
		}

		public   DataTable GetAllUser()
		{

			DataTable oDataTable =DALCommon.ExecuteDataTable("Select USER_ID,USER_NAME,USER_MAIL_ID,USER_TYPE,USER_CONTACT_NO,USER_MOB_NO from  TBL_SUPT_USER order by USER_ID desc");
			
			if(oDataTable.Rows.Count > 0)
			{
			}
			return oDataTable;
		}
		
		public static void setusrid(string v_tmpusrid)
		{
			v_userid=v_tmpusrid;
		}
		
		public   DataTable GetUserdata()
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("Select * from  TBL_SUPT_USER where USER_ID='"+v_userid+"'");
			
			if(oDataTable.Rows.Count > 0)
			{
			}
			return oDataTable;
		}
		public  bool DeleteUser()
		{
			bool result;
			//delete from login table
			result=DALCommon.ExecuteScalar("Delete from TBL_LOGIN where LOGIN_NAME IN (select USER_LOGIN_NAME from TBL_SUPT_USER where USER_ID ='"+v_userid+"')");
			result=DALCommon.ExecuteScalar("Delete from TBL_SUPT_USER where USER_ID ='"+v_userid+"' ");
			return result;
		}

		public  bool updateUser(string v_USER_NAME,string v_USER_EMP_CODE,string v_USER_MAIL_ID,string v_USER_TYPE,string v_USER_DOB,string v_USER_CONTACT_NO,string v_USER_MOB_NO)
		{
			bool result;
			result=DALCommon.ExecuteScalar("Update TBL_SUPT_USER set USER_NAME= '"+v_USER_NAME+"',USER_EMP_CODE='"+v_USER_EMP_CODE+"',USER_MAIL_ID='"+v_USER_MAIL_ID+"',USER_TYPE='"+v_USER_TYPE+"',USER_DOB='"+v_USER_DOB+"',USER_CONTACT_NO='"+v_USER_CONTACT_NO+"',USER_MOB_NO='"+v_USER_MOB_NO+"' where USER_ID='"+v_userid+"'");
			return result;
		}

		public   DataTable checkLoginId(string p_LoginId)
		{

			DataTable oDataTable =DALCommon.ExecuteDataTable("select USER_LOGIN_NAME from TBL_SUPT_USER where USER_LOGIN_NAME ='"+p_LoginId+"'");
			
			if(oDataTable.Rows.Count > 0)
			{
				
			}
			return oDataTable;
		}

	
	}
}
