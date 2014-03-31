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
	/// Summary description for BLLComplainstatus.
	/// </summary>
	public class BLLComplainstatus
	{
		public BLLComplainstatus()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public   DataTable GetComplain()
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("Select COMP_NO,COMP_TYPE,TBL_SITE_REGISTRATION.SITE_NAME,CMPSUB,COMP_STATUS from  TBL_COMPLAIN,TBL_SITE_REGISTRATION where ( TBL_SITE_REGISTRATION.SITE_ID = TBL_COMPLAIN.COMP_SITE_ID ) and COMP_STATUS='Pending' order by COMP_NO desc");
			if(oDataTable.Rows.Count > 0)
			{
			}
			return oDataTable;
		}
		public   DataTable GetComplainData(string v_compno)
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("Select COMPLAINER_NAME,COMP_REG_DATE_TIME,COMP_PHNO,COMPLANER_PHNO,CMPDTL from  TBL_COMPLAIN where COMP_NO='"+v_compno+"'");

			if(oDataTable.Rows.Count > 0)
			{
			}
			return oDataTable;
		}
		public static string GetComplainStatus(string v_compno)
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("Select COMP_STATUS from  TBL_COMPLAIN where COMP_NO='"+v_compno+"'");

			if(oDataTable.Rows.Count > 0)
			{
			}
			return oDataTable.Rows[0][0].ToString();
		}
		public static  bool cmpundertaken(string v_compno ,string v_loginid )
		{
			bool result;
				result=DALCommon.ExecuteScalar("Update TBL_COMPLAIN set COMP_HANDLE_BY = '"+v_loginid+"',COMP_HANDLE_DATE_TIME =sysdate,COMP_STATUS = 'Running' where COMP_NO ='"+v_compno+"' ");
			return result;
		}
	}
}
