///<class name="DBHelper">
///   <summary>
///       This Class contains the methods for Insert / Update / Delete
///    </summary>
///</class>
///
///-------------------------------------------------------------------------------------------------------

using System;
using System.Data;
using System.Data.OracleClient;  
using System.Collections;
using E_HELP_DESK1.ApplicationFramework;

namespace E_HELP_DESK1.DataAccessLayer
{
	/// <summary>
	/// Summary description for DBHelper.
	/// </summary>
	public sealed class DBHelper
	{
		string strConnection;
		string strStoredProcName;
		public DBHelper()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public string ConnectionString
		{
			get
			{
				return strConnection;
			}
			set
			{
				strConnection = value;
			}
		}

		//<property name="SPName"
		//          class="DBHelper" public="1">
		//   <summary>
		//     Public Property Get - Set, To assign and Return Stored Procedure Name
		//   </summary>
		//   <param name="" type="">
		//   </param>
		//   <histories>
		//   </histories>
		//   <remarks>
		//	    <para>
		//	    </para>	
		//   </remarks>
		//</property>

		public string SPName
		{
			get
			{
				return strStoredProcName;
			}
			set
			{
				strStoredProcName = value;
			}
		}
		
		//<function name="ExecuteSP"
		//          class="DBHelper" public="1">
		//   <summary>
		//		Following function will Execute SP, and Returns DBReult
		//   </summary>
		//   <param name="" type="">
		//   </param>
		//   <histories>
		//   </histories>
		//   <remarks>
		//	    <para>
		//	    </para>	
		//   </remarks>
		//</function>

		public DBResult ExecuteSP()
		{
			DBResult oDBResult = new DBResult();
			
			try
			{
				oDBResult.ReturnCode = OracleHelper.ExecuteNonQuery(strConnection ,strStoredProcName);
			}
			catch(OracleException ex)
			{
				oDBResult.ErrorList.Add("errormessage",ex.Message);
			}
			catch(Exception ex)
			{
				oDBResult.ErrorList.Add("errormessage",ex.Message);
			}
			
			return oDBResult;
		}
		
		//<function name="ExecuteSPOutputValues"
		//          class="DBHelper" public="1">
		//   <summary>
		//		Following function will Execute SP Output Values and return Value provided by SP
		//		value may be int, string or UniqueIdintifier
		//   </summary>
		//   <param name="oOracleParameter" type="OracleParameter[]">
		//   </param>
		//   <histories>
		//   </histories>
		//   <remarks>
		//	    <para>
		//	    </para>	
		//   </remarks>
		//</function>

		public DBResult ExecuteSPOutputValues(OracleParameter[] oOracleParameter)
		{
			
			DBResult oDBResult = new DBResult();
			int icount = oOracleParameter.Length; 
			try
			{
				oDBResult.ReturnCode = OracleHelper.ExecuteNonQuery(strConnection ,strStoredProcName,oOracleParameter);
				for(int j=0; j < icount ;j++)
				{
					if(oOracleParameter[j].Direction== ParameterDirection.Output ||    oOracleParameter[j].Direction== ParameterDirection.InputOutput)
						oDBResult.OutParameters.Add(oOracleParameter[j].Value);  
				}
				
			}
			catch(OracleException ex)
			{
				oDBResult.ErrorList.Add("errormessage",ex.Message);
			}
			catch(Exception ex)
			{
				oDBResult.ErrorList.Add("errormessage",ex.Message);
			}
		 
			return oDBResult;
			
		
		}
	}
}
