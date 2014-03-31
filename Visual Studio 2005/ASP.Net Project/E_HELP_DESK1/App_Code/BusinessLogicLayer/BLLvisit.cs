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
	/// Summary description for BLLvisit.
	/// </summary>
	
	public class BLLvisit
	{
		public static string fwdcmpid;
		public BLLvisit()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public   DataTable forwardcmpdata(string COMP_NO)
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("SELECT tbl_vendor.vendor_name,tbl_comp_forward.frwd_id,tbl_comp_forward.frwd_comp_no,tbl_comp_forward.comp_frwd_date_time,tbl_comp_forward.cmpstatus	FROM tbl_vendor,tbl_comp_forward WHERE((tbl_vendor.vendor_id = tbl_comp_forward.comp_frwd_to) AND (tbl_comp_forward.frwd_comp_no ='"+COMP_NO+"')) order by FRWD_ID desc ");
		
			if(oDataTable.Rows.Count > 0)
			{
			}
			return oDataTable;
		}

		public static void setfwdcmpno(string p_fwdcmpid)
		{
			fwdcmpid = p_fwdcmpid;
		}
		public   DataTable getfwdcmpstatus()
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("select CMPSTATUS from TBL_COMP_FORWARD where FRWD_ID ='"+fwdcmpid+"' ");
			
			if(oDataTable.Rows.Count > 0)
			{		
			}
			return oDataTable;
		}
		public  bool cmplainclosed()
		{
			bool result;
			result=DALCommon.ExecuteScalar("Update TBL_COMP_FORWARD set CMPSTATUS = 'Closed'where FRWD_ID ='"+fwdcmpid+"' ");
		
			result=DALCommon.ExecuteScalar("Update TBL_COMPLAIN set COMP_STATUS = 'Running' where COMP_NO =(select FRWD_COMP_NO from TBL_COMP_FORWARD where FRWD_ID='"+fwdcmpid+"')");
			return result;
		}

		public  bool Addvisit()
		{
			bool result;
			result=DALCommon.ExecuteScalar("Update TBL_COMP_FORWARD set CMPSTATUS = 'Closed'where FRWD_ID ='"+fwdcmpid+"' ");
		
			result=DALCommon.ExecuteScalar("Update TBL_COMPLAIN set COMP_STATUS = 'Running' where COMP_NO =(select FRWD_COMP_NO from TBL_COMP_FORWARD where FRWD_ID='"+fwdcmpid+"')");
			return result;
		}

		public  bool Resolvedcomplain()
		{
			bool result;
			result=DALCommon.ExecuteScalar("Update TBL_COMP_FORWARD set CMPSTATUS = 'Resolved'where FRWD_ID ='"+fwdcmpid+"' ");
			result=DALCommon.ExecuteScalar("Update TBL_COMPLAIN set COMP_STATUS = 'Resolved',CMPRESOLVEDDATE_TIME=sysdate where COMP_NO =(select FRWD_COMP_NO from TBL_COMP_FORWARD where FRWD_ID='"+fwdcmpid+"')");
			return result;
		}

		public  bool addvisit(string p_visitdate, string p_visit_Rmark)
		{
			bool result;
			result=DALCommon.ExecuteScalar("Insert into TBL_VISIT values( SEQ_tbl_VISIT.nextval,(select FRWD_COMP_NO from TBL_COMP_FORWARD where FRWD_ID='"+fwdcmpid+"'),(select COMP_FRWD_TO from TBL_COMP_FORWARD where FRWD_ID='"+fwdcmpid+"'),'"+p_visitdate+"','"+p_visit_Rmark+"')");
			return result;
		}

		public   DataTable getvisitdetail()
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("SELECT distinct tbl_visit.VISIT_ID,tbl_visit.visit_date_time,tbl_visit.VISIT_REMARK, tbl_vendor.vendor_name FROM tbl_vendor, tbl_visit,TBL_COMP_FORWARD WHERE ((tbl_vendor.vendor_id = tbl_visit.visit_by) AND (tbl_visit.COMP_NO =(select FRWD_COMP_NO from TBL_COMP_FORWARD where FRWD_ID='"+fwdcmpid+"') AND tbl_visit.VISIT_BY= (select COMP_FRWD_TO from TBL_COMP_FORWARD where FRWD_ID='"+fwdcmpid+"')))order by VISIT_ID desc");
			
			if(oDataTable.Rows.Count > 0)
			{		
			}
			return oDataTable;
		}


	}
}
