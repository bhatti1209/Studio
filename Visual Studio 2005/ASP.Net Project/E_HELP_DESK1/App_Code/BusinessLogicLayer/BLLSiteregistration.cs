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
	/// Summary description for Site_registration.
	/// </summary>
	public class BLLSiteregistration
	{
		public static string v_siteid;

		public BLLSiteregistration()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		//FUNCTION ARE USED GETTING FOR TYPE OF OFFICES
		public   DataTable Gettypeofoffice()
		{

			DataTable oDataTable =DALCommon.ExecuteDataTable("select OFFICE_TYPE,OFFICE_ID from TBL_OFFICE_TYPE Order by OFFICE_ID");
			
			if(oDataTable.Rows.Count > 0)
			{
				
			}
			return oDataTable;
		}
		//////////////////////////
		
		public  bool Registeroffice(string v_SITE_NAME, string v_SITE_LOCATION_CODE, string v_SITE_LOCATION, string v_SITE_OFFICE_TYPE, string v_SITE_LOC_ADD,string v_SITE_CONT_PERSON_NAME, string v_SITE_CONT_PERSON_PHNO,string v_SITE_CONT_NO,string v_SITE_LOTUS_NOTE_EMAIL,string v_SITE_TEMP_NW_IP,string v_SITE_TEMP_GATEWAY_IP,string v_SITE_TEMP_SUBNETMASK )
		{
			bool result;
			result=DALCommon.ExecuteScalar("Insert into TBL_SITE_REGISTRATION values(SEQ_TBL_SITE_REGISTRATION.nextval ,'"+v_SITE_NAME+"','"+v_SITE_LOCATION_CODE+"','"+v_SITE_LOCATION+"','"+v_SITE_OFFICE_TYPE+"','"+v_SITE_LOC_ADD+"','"+v_SITE_CONT_PERSON_NAME+"','"+v_SITE_CONT_PERSON_PHNO+"','"+v_SITE_CONT_NO+"','"+v_SITE_LOTUS_NOTE_EMAIL+"','"+v_SITE_TEMP_NW_IP+"','"+v_SITE_TEMP_GATEWAY_IP+"','"+v_SITE_TEMP_SUBNETMASK+"')");
			if(result)
			{
				result=BllMainLogin.SetLogin(v_SITE_NAME);
				return result;
			}
			return result;
		}



		public   DataTable GetAllSite()
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("Select SITE_ID,SITE_NAME,SITE_OFFICE_TYPE,SITE_CONT_PERSON_NAME,SITE_CONT_PERSON_PHNO,SITE_CONT_NO,SITE_LOTUS_NOTE_EMAIL from  TBL_SITE_REGISTRATION");
			
			if(oDataTable.Rows.Count > 0)
			{
			}
			return oDataTable;
		}

		public static void setsiteid(string v_tempsiteid)
		{
			v_siteid=v_tempsiteid;
		}

		public   DataTable GetSitedata()
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("Select * from  TBL_SITE_REGISTRATION where SITE_ID ='"+v_siteid+"'");
			
			if(oDataTable.Rows.Count > 0)
			{
			}
			return oDataTable;
		}

		public  bool updateofficedata(string v_SITE_LOCATION_CODE, string v_SITE_LOCATION, string v_SITE_OFFICE_TYPE, string v_SITE_LOC_ADD,string v_SITE_CONT_PERSON_NAME, string v_SITE_CONT_PERSON_PHNO,string v_SITE_CONT_NO,string v_SITE_LOTUS_NOTE_EMAIL,string v_SITE_TEMP_NW_IP,string v_SITE_TEMP_GATEWAY_IP,string v_SITE_TEMP_SUBNETMASK )
		{
			bool result;
			result=DALCommon.ExecuteScalar("Update TBL_SITE_REGISTRATION set SITE_LOCATION_CODE = '"+v_SITE_LOCATION_CODE+"', SITE_LOCATION='"+v_SITE_LOCATION+"',SITE_OFFICE_TYPE='"+v_SITE_OFFICE_TYPE+"',SITE_LOC_ADD='"+v_SITE_LOC_ADD+"',SITE_CONT_PERSON_NAME='"+v_SITE_CONT_PERSON_NAME+"',SITE_CONT_PERSON_PHNO='"+v_SITE_CONT_PERSON_PHNO+"',SITE_CONT_NO='"+v_SITE_CONT_NO+"',SITE_LOTUS_NOTE_EMAIL='"+v_SITE_LOTUS_NOTE_EMAIL+"',SITE_TEMP_NW_IP='"+v_SITE_TEMP_NW_IP+"',SITE_TEMP_GATEWAY_IP='"+v_SITE_TEMP_GATEWAY_IP+"',SITE_TEMP_SUBNETMASK='"+v_SITE_TEMP_SUBNETMASK+"'where SITE_ID='"+v_siteid+"'");
			return result;
		}
		
		public  bool deleteoffice()
		{
			bool result;
			result=DALCommon.ExecuteScalar("Delete from TBL_LOGIN where LOGIN_NAME IN (select SITE_NAME from TBL_SITE_REGISTRATION where SITE_ID ='"+v_siteid+"')");
			result=DALCommon.ExecuteScalar("Delete from TBL_SITE_REGISTRATION where SITE_ID ='"+v_siteid+"'");
			return result;
		}
		public   DataTable checksitename(string p_sitename)
		{

			DataTable oDataTable =DALCommon.ExecuteDataTable("select SITE_NAME from TBL_SITE_REGISTRATION where SITE_NAME ='"+p_sitename+"'");
			
			if(oDataTable.Rows.Count > 0)
			{
				
			}
			return oDataTable;
		}
		
       
	}
}
