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
	/// Summary description for BLLComplain.
	/// </summary>
	public class BLLComplain
	{
		public BLLComplain()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public   DataTable GetSiteName()
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("select SITE_NAME,SITE_ID from TBL_SITE_REGISTRATION Order by SITE_ID");	
			if(oDataTable.Rows.Count > 0)
			{	
			}
			return oDataTable;
		}
		//FUNCTION USED FOR INSERT THE COMPLAIN 
		public  string Insercomplain(string v_COMP_TYPE,string v_COMPLAINER_NAME,string v_COMP_SITE_ID,string v_COMP_PHNO, string v_COMPLANER_PHNO, string v_TxtCpmSub, string v_TxtCmpDtl, string v_loginid)
		{
			bool result;
			result=DALCommon.ExecuteScalar("Insert into TBL_COMPLAIN(COMP_NO,COMP_TYPE,COMPLAINER_NAME,COMP_SITE_ID,COMP_REG_BY,COMP_REG_DATE_TIME,COMP_STATUS,COMP_PHNO,COMPLANER_PHNO,CMPSUB,CMPDTL)  values (SEQ_TBL_COMPLAIN.nextval,'"+v_COMP_TYPE+"','"+v_COMPLAINER_NAME+"','"+v_COMP_SITE_ID+"','"+v_loginid+"',sysdate,'Pending','"+v_COMP_PHNO+"','"+v_COMPLANER_PHNO+"','"+v_TxtCpmSub+"','"+v_TxtCmpDtl+"')");
				DataTable oDataTable =DALCommon.ExecuteDataTable("select max(COMP_NO) from TBL_COMPLAIN where COMP_REG_BY = '"+v_loginid+"' ");	
				if(oDataTable.Rows.Count > 0)
				{	
				}
				return oDataTable.Rows[0][0].ToString();
		}
		public   DataTable GetSitedata(string v_tmpsiteid)
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("select SITE_CONT_NO,SITE_LOTUS_NOTE_EMAIL from TBL_SITE_REGISTRATION where SITE_ID='"+v_tmpsiteid+"' ");	
			if(oDataTable.Rows.Count > 0)
			{	
			}
			return oDataTable;
		}
	}
}
