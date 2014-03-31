using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Collections.Specialized;

namespace E_HELP_DESK1.DataAccessLayer
{
	/// <summary>
	/// Summary description for DAL_Login.
	/// </summary>
	public class DataAccessLogin
	{

#region constant
		private const string SP_LOGIN = "Edmsproc_Login";
#endregion

		#region constructor
		public DataAccessLogin()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		#endregion
		#region AUTHENTICATE USER
		public static bool AuthenticateUser(ICollection objForm)
		{
			OracleParameter[] oOracleParemeter = new OracleParameter[4];
			NameValueCollection objRequest = (NameValueCollection)objForm;

			oOracleParemeter[0]=new OracleParameter("@username",OracleType.VarChar);
			oOracleParemeter[0].Value=objRequest["username"];
			oOracleParemeter[0].Direction=ParameterDirection.Input;
			

			oOracleParemeter[1]=new OracleParameter("@password",OracleType.VarChar);
			oOracleParemeter[1].Value=objRequest["pwd"];
			oOracleParemeter[1].Direction=ParameterDirection.Input;	
			

			oOracleParemeter[2]=new OracleParameter("@return",OracleType.Int32);
			oOracleParemeter[2].Direction=ParameterDirection.Output;

//			OracleDataReader sdrInfo = DALCommon.ExecuteReader(oOracleParemeter,SP_LOGIN);

		
			
			OracleDataReader sdrInfo = DALCommon.ExecuteReader("SELECT Login_Name,PASSWORD,USer_Name,user_Desc  from TBLUSER_INFO where Login_Name = '" + objRequest["username"] + "' and PASSWORD = '" + objRequest["pwd"] + "'");
			if(sdrInfo != null && sdrInfo.HasRows == true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		#endregion
		#region GET LOGIN INFO
		public static OracleDataReader GetUserLoginInfo(ICollection objForm)
		{

			NameValueCollection objRequest = (NameValueCollection)objForm;
//			OracleDataReader sdrInfo = DALCommon.ExecuteReader(objRequest,SP_LOGIN);
			
//			OracleDataReader sdrInfo = DALCommon.ExecuteReader("select A.USERNAME, A.PASSWORD,A.ROLE,B.LOC_CODE,A.USER_ID from PD_USER A left join PD_ASSIGNMFTOUSER B on A.USER_ID = B.USER_ID where A.USER_ID = '" + objRequest["username"] + "' and A.PASSWORD = '" + objRequest["pwd"] + "'");
			OracleDataReader sdrInfo = DALCommon.ExecuteReader("SELECT Login_Name,PASSWORD,USer_Name,user_Desc  from TBLUSER_INFO where Login_Name = '" + objRequest["username"] + "' and PASSWORD = '" + objRequest["pwd"] + "'");
			
			if(sdrInfo != null && sdrInfo.HasRows == true)	
			{
				return sdrInfo;
			}
			else
			{
				return null;
			}
						
		}
		#endregion
	}
}
