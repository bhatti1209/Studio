using System;
using System.Configuration;

namespace E_HELP_DESK1.ApplicationFramework
{
	/// <summary>
	/// Summary description for OracleConnectionMgmt.
	/// </summary>
	public sealed class OracleConnectionMgmt
	{
		public OracleConnectionMgmt()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		#region GetConnectionString
		// Default (App database) connection string.
		// Need to Enhance the by implementing local caching and 
		// also making it thread safe
		public static string GetConnectionString()
		{
			return ConfigurationSettings.AppSettings["ConnectionString"];
		}
		#endregion GetConnectionString
	}
}
