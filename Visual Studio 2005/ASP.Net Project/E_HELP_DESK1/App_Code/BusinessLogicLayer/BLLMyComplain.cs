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
	/// Summary description for BLLMyComplain.
	/// </summary>
	public class BLLMyComplain
	{

		public  string cmpno;
		public BLLMyComplain()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public   DataTable GetMyComplain(string v_loginid)
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("Select   COMP_NO,COMP_TYPE,TBL_SITE_REGISTRATION.SITE_NAME,CMPSUB,COMP_STATUS from  TBL_COMPLAIN,TBL_SITE_REGISTRATION where ( TBL_SITE_REGISTRATION.SITE_ID = TBL_COMPLAIN.COMP_SITE_ID ) and  (COMP_HANDLE_BY ='"+v_loginid+"') and (COMP_STATUS='Running' or COMP_STATUS='Forward' or (COMP_STATUS='Resolved' and to_char(CMPRESOLVEDDATE_TIME,'mm/dd/yyyy')=to_char(sysdate,'mm/dd/yyyy') ))  order by COMP_NO desc");
			
			if(oDataTable.Rows.Count > 0)
			{
			}
			return oDataTable;
		}
		public   DataTable GetMyComplainData()
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("Select COMPLAINER_NAME,COMP_REG_DATE_TIME,COMP_PHNO,COMPLANER_PHNO,CMPDTL from  TBL_COMPLAIN where COMP_NO ='"+cmpno+"' ");

			if(oDataTable.Rows.Count > 0)
			{
			}
			return oDataTable;
		}

		public void setcomplainnumber(string v_tempcmpno)
		{
			cmpno=v_tempcmpno;
		}

		public   DataTable Getvendor()
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("select VENDOR_ID,VENDOR_NAME from TBL_VENDOR Order by VENDOR_ID");
			
			if(oDataTable.Rows.Count > 0)
			{		
			}
			return oDataTable;
		}

		public bool sendbackcomplain(string p_remark, string p_Login_id)
		{
			bool result;
			result=DALCommon.ExecuteScalar("insert into TBL_COMPLAIN_ACTION values(SEQ_TBL_COMPLAIN_ACTION.nextval,'"+cmpno+"','"+p_Login_id+"','SendBack',sysdate,'"+p_remark+"')");
			if(result)
			{
				result=DALCommon.ExecuteScalar("Update TBL_COMPLAIN set COMP_HANDLE_BY ='',COMP_HANDLE_DATE_TIME ='' ,COMP_STATUS = 'Pending' where COMP_NO ='"+cmpno+"' ");
				return result;
			}
			return result;
		}
//		public bool closecomplain(string p_remark, string p_Login_id)
//		{
//			bool result;
//			result=DALCommon.ExecuteScalar("insert into TBL_COMPLAIN_ACTION values(SEQ_TBL_COMPLAIN_ACTION.nextval,'"+cmpno+"','"+p_Login_id+"','Closed',sysdate,'"+p_remark+"')");
//			result=DALCommon.ExecuteScalar("Update TBL_COMPLAIN set COMP_STATUS = 'Closed' where COMP_NO ='"+cmpno+"' ");
//		
//			return result;
//		}
		public bool resolvedcomplain(string p_remark, string p_Login_id)
		{
			bool result;
			result=DALCommon.ExecuteScalar("insert into TBL_COMPLAIN_ACTION values(SEQ_TBL_COMPLAIN_ACTION.nextval,'"+cmpno+"','"+p_Login_id+"','Resolved',sysdate,'"+p_remark+"')");
			if(result)
			{
				result=DALCommon.ExecuteScalar("Update TBL_COMPLAIN set COMP_STATUS = 'Resolved',CMPRESOLVEDDATE_TIME = sysdate where COMP_NO ='"+cmpno+"' ");
				return result;
			}
			return result;
		}

		public   DataTable getcmpstatusdetail()
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("select COMP_STATUS from TBL_COMPLAIN where COMP_NO ='"+cmpno+"' ");
			
			if(oDataTable.Rows.Count > 0)
			{		
			}
			return oDataTable;
		}
		public bool Forwardcomplain(string v_venderid, string Remark )
		{
			//	send mail to vender
				bool result;

				result=DALCommon.ExecuteScalar("Update TBL_COMPLAIN set COMP_STATUS = 'Forward' where COMP_NO ='"+cmpno+"' ");
			if(result)
			{
				result=DALCommon.ExecuteScalar("Insert into TBL_COMP_FORWARD(FRWD_ID,FRWD_COMP_NO,COMP_FRWD_TO,COMP_FRWD_DATE_TIME,FRWD_REMARK,CMPSTATUS)values (SEQ_TBL_COMP_FORWARD.nextval,'"+cmpno+"','"+v_venderid+"',sysdate,'"+Remark+"','Running')");
				return result;
			}
			return result;
		}
		public DataTable GetVenderEmail(string v_venderid)
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("select VENDOR_MAIL_ID , VENDOR_NAME form TBL_VENDOR where VENDOR_ID='"+v_venderid+"'");

				if(oDataTable.Rows.Count > 0)
				{
				}
				return oDataTable;
			
		}
		public DataTable GetSiteEmail()
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("select SITE_LOTUS_NOTE_EMAIL , SITE_NAME form TBL_SITE_REGISTRATION where SITE_ID='"+cmpno+"'");
			if(oDataTable.Rows.Count > 0)
			{
			}
			return oDataTable;
		}
		public string getcomplainno()
		{
				return cmpno;
		}
	}
}
