///-------------------------------------------------------------------------------------------------------
///<class name="DALCommon">
///		<summary>
///		 This class contains Commom Add/Delete/Modify/Executereader methods.
///		</summary>
/// </class>
///-------------------------------------------------------------------------------------------------------

using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using E_HELP_DESK1.ApplicationFramework;

namespace E_HELP_DESK1.DataAccessLayer
{
	/// <summary>
	/// Summary description for DALCommon.
	/// </summary>
	public class DALCommon
	{
		public DALCommon()
		{
			
		}
		
		#region EXECUTENONQUERY
		public static DBResult ExecuteNonQuery(OracleParameter[] oOracleParameter,string SPName)
		{
			DBHelper oDBHelper = new DBHelper();
			oDBHelper.ConnectionString=OracleConnectionMgmt.GetConnectionString();
			oDBHelper.SPName=SPName;
			DBResult oDBResult = oDBHelper.ExecuteSPOutputValues(oOracleParameter);
			return oDBResult;
		}
		#endregion

		#region EXECUTENONQUERY
		public static bool ExecuteNonQuery(string strsql)
		{
			bool result;
			//string res;
			int res;
			try
			{
				using (OracleConnection conn = new OracleConnection(OracleConnectionMgmt.GetConnectionString()))
				{
					conn.Open();
					OracleCommand  cmd = new OracleCommand(strsql,conn);				
					res=cmd.ExecuteNonQuery(); 
				 
					if(res>=1)
					{
						result=true;
					}
					else
					{
						result =false;
					}
					conn.Close();
				}
			}
			
			catch (Exception ex)
			{
				string m;
				m=ex.Message.ToString();

				result=false;
			}
			
			
			return result;
		}
		#endregion

		

		#region EXECUTEREADER
		public static OracleDataReader ExecuteReader(OracleParameter[] oOracleParemeter, string SPName)
		{
			OracleDataReader oOracleDataReader;
			try
			{
				oOracleDataReader = OracleHelper.ExecuteReader(OracleConnectionMgmt.GetConnectionString(),CommandType.StoredProcedure,SPName,oOracleParemeter);

			}
			catch
			{
				oOracleDataReader = null;
			}
			
			
			return oOracleDataReader;
		}
		public static OracleDataReader ExecuteReader(string strsql)
		{
			OracleDataReader oOracleDataReader;
			try
			{
				oOracleDataReader = OracleHelper.ExecuteReader(OracleConnectionMgmt.GetConnectionString(),CommandType.Text,strsql);

			}
			catch
			{
				oOracleDataReader = null;
			}
			
			
			
			 return oOracleDataReader;
		 }
		#endregion
		#region EXECUTESCALAR
		public static bool ExecuteScalar(string strsql)
		{
		 bool result;
			//string res;
			object res;
			try
			{
				using (OracleConnection conn = new OracleConnection(OracleConnectionMgmt.GetConnectionString()))
				{
					conn.Open();
					OracleCommand  cmd = new OracleCommand(strsql,conn);				
					//res = cmd.ExecuteScalar().ToString();
					res=cmd.ExecuteScalar();

					 
					if(res==null)
					{
					result=true;
					}
					else
					{
					result = false;
					}
					conn.Close();
				}
			}
			
			catch (Exception ex)
			{
				string m;
				m=ex.Message.ToString();

                			result=false;
			}
			
			
			return result;
		}
//		public static string ExecuteScalar(string strsql)
//		{
//			string res;
//			try
//			{
//				using (OracleConnection conn = new OracleConnection(OracleConnectionMgmt.GetConnectionString()))
//				{
//					conn.Open();
//					OracleCommand  cmd = new OracleCommand(strsql,conn);				
//					res = cmd.ExecuteScalar().ToString();
//					conn.Close();
//				}
//			}
//			catch
//			{
//			
//			}
//			
//			
//		}
		public static int ExecuteScalar(string strsql,ref int status)
		{
			int res = 0;
			try
			{
				using (OracleConnection conn = new OracleConnection(OracleConnectionMgmt.GetConnectionString()))
				{
					conn.Open();
					OracleCommand  cmd = new OracleCommand(strsql,conn);				
					res = Convert.ToInt32(cmd.ExecuteScalar());
					conn.Close();
				}
			}
			catch
			{
				res = 0;
			}
			
			status = res + 1;
			return res;
		}
		#endregion
		#region EXECUTEDATASET

		public static DataSet ExecuteDataSet(OracleParameter[] oOracleParemeter, string SPName)
		{
			DataSet oDataSet = new DataSet();

			try
			{
				oDataSet = OracleHelper.ExecuteDataset(OracleConnectionMgmt.GetConnectionString(), SPName, oOracleParemeter);
			}
			catch
			{
				oDataSet = null;
			}
			
			
			return oDataSet;
			
		}
		public static DataTable ExecuteDataTable(string strsql)
		{
			DataSet oDataSet = new DataSet();
			
			try
			{
				oDataSet = OracleHelper.ExecuteDataset(OracleConnectionMgmt.GetConnectionString(),CommandType.Text,strsql);
			}
			catch
			{
				oDataSet = null;
			}
			
			
			return oDataSet.Tables[0];
			
		}
		#endregion

	}
}
