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
	/// Summary description for BLLHomeFrame.
	/// </summary>
	public class BLLHomeFrame
	{
		public BLLHomeFrame()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public static  DataTable GetAllComplaint()
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("Select COMP_NO,COMP_TYPE,TBL_SITE_REGISTRATION.SITE_NAME,COMP_STATUS,COMP_REG_DATE_TIME,COMP_HANDLE_BY,COMP_HANDLE_DATE_TIME from  TBL_COMPLAIN,TBL_SITE_REGISTRATION where ( TBL_SITE_REGISTRATION.SITE_ID = TBL_COMPLAIN.COMP_SITE_ID ) and (COMP_STATUS='Running' or COMP_STATUS='Forward'or COMP_STATUS='Pending' or (COMP_STATUS='Resolved' and to_char(CMPRESOLVEDDATE_TIME,'mm/dd/yyyy')=to_char(sysdate,'mm/dd/yyyy') ))  order by COMP_NO desc");
			
			if(oDataTable.Rows.Count > 0)
			{
			}
			return oDataTable;
		} 
	}
}
