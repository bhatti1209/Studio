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
	/// Summary description for BLLVender_Registration.
	/// </summary>
	public class BLLVender_Registration
	{
		static string v_VENDOR_ID;

		public BLLVender_Registration()
		{

		}
		//register new vender
		public  bool RegisterVender(string v_VENDOR_NAME, string v_VENDOR_MAIL_ID, string v_VENDOR_CONT_NO1, string v_VENDOR_CONT_NO2, string v_VENDOR_LOCATION)
		{
			bool result;
			result=DALCommon.ExecuteScalar("Insert into TBL_VENDOR values(SEQ_TBL_VENDOR.nextval,'"+v_VENDOR_NAME+"','"+v_VENDOR_MAIL_ID+"','"+v_VENDOR_CONT_NO1+"','"+v_VENDOR_CONT_NO2+"','"+v_VENDOR_LOCATION+"')");
			return result;
		}

		//get all vender for data grid
		public   DataTable GetAllVender()
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("Select VENDOR_ID,VENDOR_NAME,VENDOR_MAIL_ID,VENDOR_CONT_NO1,VENDOR_CONT_NO2 from TBL_VENDOR order by VENDOR_ID desc");
			
			if(oDataTable.Rows.Count > 0)
			{
			}
			return oDataTable;
		}

		//for set the current vender selected
		public static void setvendorid( string VENDOR_ID )
		{
			v_VENDOR_ID=VENDOR_ID;
		}

		//retrive particular vendor data
		public   DataTable getvenderdata()
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("Select *from TBL_VENDOR where VENDOR_ID='"+v_VENDOR_ID+"'");	
			if(oDataTable.Rows.Count > 0)
			{
			}
			return oDataTable;
		}

		//update vender data
		public  bool UpdateVender(string v_VENDOR_MAIL_ID, string v_VENDOR_CONT_NO1, string v_VENDOR_CONT_NO2, string v_VENDOR_LOCATION)
		{
			bool result;
			result=DALCommon.ExecuteScalar("Update TBL_VENDOR set VENDOR_MAIL_ID='"+v_VENDOR_MAIL_ID+"',VENDOR_CONT_NO1='"+v_VENDOR_CONT_NO1+"',VENDOR_CONT_NO2='"+v_VENDOR_CONT_NO2+"',VENDOR_LOCATION='"+v_VENDOR_LOCATION+"' where VENDOR_ID='"+v_VENDOR_ID+"'");
			return result;
		}
		//delete vender
		public  bool deleteVender()
		{
			bool result;
			result=DALCommon.ExecuteScalar("delete TBL_VENDOR where VENDOR_ID='"+v_VENDOR_ID+"'");
			return result;
		}

		public   DataTable CheckVenderName(string p_VENDOR_NAME)
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("Select VENDOR_NAME from TBL_VENDOR where VENDOR_NAME='"+p_VENDOR_NAME+"'");	
			if(oDataTable.Rows.Count > 0)
			{
			}
			return oDataTable;
		}


	}
}
