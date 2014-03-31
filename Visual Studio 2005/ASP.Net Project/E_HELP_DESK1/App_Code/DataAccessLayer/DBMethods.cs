using System;
using System.Data;
using System.Data.OracleClient;

namespace E_HELP_DESK1.DataAccessLayer
{
	/// <summary>
	/// Summary description for Dal_DBMethods.
	/// </summary>
	public class DBMethods
	{
		public DBMethods()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public int UpdateData(string strSql)
		{
			int Result = 0;
			string strconn = ApplicationFramework.OracleConnectionMgmt.GetConnectionString();
			OracleConnection  conn = new OracleConnection(strconn);
			OracleCommand  cmd = new OracleCommand(strSql,conn);
			conn.Open();
			Result = cmd.ExecuteNonQuery();	
			conn.Close();
			return Result;
		}
		public OracleDataReader CheckDuplicate(string strSql)
		{
			string strconn = ApplicationFramework.OracleConnectionMgmt.GetConnectionString();
			OracleConnection  conn = new OracleConnection(strconn);
			OracleCommand  cmd = new OracleCommand(strSql,conn);
			conn.Open();
			return cmd.ExecuteReader();
			//
				
			conn.Close();
			//return Result;
		}
	}
}
