using System;
using System.Data;
using System.Xml;
using System.Data.OracleClient;
using System.Collections;
using System.Configuration;

namespace E_HELP_DESK1.ApplicationFramework
{
	/// <summary>
	/// Summary description for OracleHelper.
	/// </summary>
	public class OracleHelper
	{
		#region constructors
		public OracleHelper()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		#endregion
		#region private utility methods
		/// <summary>
		/// This method is used to attach array of OracleParameters to a OracleCommand.
		/// 
		/// This method will assign a value of DbNull to any parameter with a direction of
		/// InputOutput and a value of null.  
		/// 
		/// This behavior will prevent default values from being used, but
		/// this will be the less common case than an intended pure output parameter (derived as InputOutput)
		/// where the user provided no input value.
		/// </summary>
		/// <param name="command">The command to which the parameters will be added</param>
		/// <param name="commandParameters">an array of OracleParameters tho be added to command</param>
		private static void AttachParameters(OracleCommand command,OracleParameter[] commandParameters)
		{
			foreach (OracleParameter p in commandParameters)
			{
				//check for derived output value with no value assigned
				if ((p.Direction == ParameterDirection.InputOutput) && (p.Value == null))
				{
					p.Value = DBNull.Value;
				}
				
				command.Parameters.Add(p);
			}
		}

		/// <summary>
		/// This method opens (if necessary) and assigns a connection, transaction, command type and parameters 
		/// to the provided command.
		/// </summary>
		/// <param name="command">the OracleCommand to be prepared</param>
		/// <param name="connection">a valid OracleConnection, on which to execute this command</param>
		/// <param name="transaction">a valid OracleTransaction, or 'null'</param>
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">the stored procedure name or T-Oracle command</param>
		/// <param name="commandParameters">an array of OracleParameters to be associated with the command or 'null' if no parameters are required</param>
		private static void PrepareCommand(OracleCommand command, OracleConnection connection, OracleTransaction transaction, CommandType commandType, string commandText, OracleParameter[] commandParameters)
		{
			//if the provided connection is not open, we will open it
			if (connection.State != ConnectionState.Open)
			{
				connection.Open();
			}

			//associate the connection with the command
			command.Connection = connection;

			//set the command text (stored procedure name or Oracle statement)
			command.CommandText = commandText;

			//if we were provided a transaction, assign it.
			if (transaction != null)
			{
				command.Transaction = transaction;
			}

			//set the command type
			command.CommandType = commandType;

//			if(ConfigurationSettings.AppSettings["CommandTimeout"]!= null)
//			{
//				int iInt;
//				iInt = int.Parse(ConfigurationSettings.AppSettings["CommandTimeout"].ToString());
//				command.CommandTimeout= iInt;
//			}
//			else
//			{
//				command.CommandTimeout=300;
//			}
			//
			//attach the command parameters if they are provided
			if (commandParameters != null)
			{
				AttachParameters(command, commandParameters);
			}
			
			return;
		}
		#endregion private utility methods
		#region ExecuteNonQuery

		/// <summary>
		/// Create, prepare and execute a OracleCommand (that returns no resultset) 
		/// against the database specified in  the connection string. 
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <param name="connection">a valid OracleConnection, on which to execute this command</param>
		/// <param name="transaction">a valid OracleTransaction, or 'null'</param>
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">the stored procedure name or T-Oracle command</param>
		/// <param name="commandParameters">an array of OracleParameters to be associated with the command or 'null' if no parameters are required</param>
		/// <returns>an int representing the number of rows affected by the command</returns>
		public static int ExecuteNonQuery(OracleConnection connection, OracleTransaction transaction, CommandType commandType, string commandText, OracleParameter[] commandParameters)
		{	
			//create a command and prepare it for execution
			OracleCommand cmd = new OracleCommand();
			PrepareCommand(cmd, connection, transaction, commandType, commandText, commandParameters);			
			//finally, execute the command.
			int retval = cmd.ExecuteNonQuery();
			
			// detach the OracleParameters from the command object, so they can be used again.
			cmd.Parameters.Clear();
			return retval;			
		}

		/// <summary>
		/// Execute a OracleCommand (that returns no resultset and takes no parameters) against the database specified in 
		/// the connection string. 
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  int result = ExecuteNonQuery(connString, CommandType.StoredProcedure, "csp_ORD_PublishOrders");
		/// </remarks>
		/// <param name="connectionString">a valid connection string for a OracleConnection</param>
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">the stored procedure name or T-Oracle command</param>
		/// <returns>an int representing the number of rows affected by the command</returns>
		public static int ExecuteNonQuery(string connectionString, CommandType commandType, string commandText)
		{
			int retval;
			//create & open a OracleConnection, and dispose of it after we are done.
			using (OracleConnection cn = new OracleConnection(connectionString))
			{
				cn.Open();
				retval =ExecuteNonQuery(cn, (OracleTransaction)null, commandType, commandText, (OracleParameter[])null);
				//call the private overload using null for OracleTransaction and the set of OracleParameters
			}
			return retval;
		}

		/// <summary>
		/// Execute a OracleCommand (that returns no resultset) against the database specified in the connection string 
		/// using the provided parameters.
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  int result = ExecuteNonQuery(connString, "csp_ORD_PublishOrders", new OracleParameter("@i_iProdid", 24));
		/// </remarks>
		/// <param name="connectionString">a valid connection string for a OracleConnection</param>
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">the stored procedure name or T-Oracle command</param>
		/// <param name="commandParameters">an array of OracleParamters used to execute the command</param>
		/// <returns>an int representing the number of rows affected by the command</returns>
		public static int ExecuteNonQuery(string connectionString, string spName, params OracleParameter[] commandParameters)
		{
			int retval;
			//create & open a OracleConnection, and dispose of it after we are done.
			using (OracleConnection cn = new OracleConnection(connectionString))
			{
				cn.Open();
				retval =ExecuteNonQuery(cn,(OracleTransaction)null, CommandType.StoredProcedure, spName, commandParameters);

				//call the private overload using null for OracleTransaction
			}
			return retval;
		}


		/// <summary>
		/// Execute a OracleCommand (that returns no resultset and takes no parameters) against the provided OracleTransaction. 
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  int result = ExecuteNonQuery(trans, CommandType.StoredProcedure, "csp_ORD_PublishOrders");
		/// </remarks>
		/// <param name="transaction">a valid OracleTransaction</param>
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">the stored procedure name or T-Oracle command</param>
		/// <returns>an int representing the number of rows affected by the command</returns>
		public static int ExecuteNonQuery(OracleTransaction transaction, CommandType commandType, string commandText)
		{
			//call the private overload using transaction.Connection for OracleConnection and null for the set of OracleParameters
			return ExecuteNonQuery(transaction.Connection, transaction, commandType, commandText,(OracleParameter[])null);
		}

		/// <summary>
		/// Execute a OracleCommand (that returns no resultset) against the specified OracleTransaction
		/// using the provided parameters.
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  int result = ExecuteNonQuery(trans, "csp_ORD_GetOrders", new OracleParameter("@i_iProdid", 24));
		/// </remarks>
		/// <param name="transaction">a valid OracleTransaction</param>
		/// <param name="spName">the stored procedure name or T-Oracle command</param>
		/// <param name="commandParameters">an array of OracleParamters used to execute the command</param>
		/// <returns>an int representing the number of rows affected by the command</returns>
		public static int ExecuteNonQuery(OracleTransaction transaction, string spName, params OracleParameter[] commandParameters)
		{
			//call the private overload using transaction.Connection for OracleConnection 
			return ExecuteNonQuery(transaction.Connection, transaction, CommandType.StoredProcedure, spName, commandParameters);
		}


		#endregion ExecuteNonQuery
		#region ExecuteDataSet

		/// <summary>
		/// Create, prepare and execute a OracleCommand (that returns a resultset) 
		/// against the database specified in  the connection string. 
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <param name="connection">a valid OracleConnection, on which to execute this command</param>
		/// <param name="transaction">a valid OracleTransaction, or 'null'</param>
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">the stored procedure name or T-Oracle command</param>
		/// <param name="commandParameters">an array of OracleParameters to be associated with the command or 'null' if no parameters are required</param>
		/// <returns>a dataset containing the resultset generated by the command</returns>
		private static DataSet ExecuteDataset(OracleConnection connection, OracleTransaction transaction, CommandType commandType, string commandText, OracleParameter[] commandParameters)
		{	
			//create a command and prepare it for execution
			OracleCommand cmd = new OracleCommand();
			PrepareCommand(cmd, connection, transaction, commandType, commandText, commandParameters);			
			
			//create the DataAdapter & DataSet
			OracleDataAdapter da = new OracleDataAdapter(cmd);
			DataSet ds = new DataSet();

			//fill the DataSet using default values for DataTable names, etc.
			da.Fill(ds);
						
			//detach the OracleParameters from the command object, so they can be used again.			
			cmd.Parameters.Clear();
			
			//return the dataset
			return ds;		
		}

		/// <summary>
		/// Execute a OracleCommand (that returns a resultset and takes no parameters) against the database specified in 
		/// the connection string. 
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  DataSet ds = ExecuteDataset(connString, CommandType.StoredProcedure, "csp_ORD_GetOrders");
		/// </remarks>
		/// <param name="connectionString">a valid connection string for a OracleConnection</param>
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">the stored procedure name or T-Oracle command</param>
		/// <returns>a dataset containing the resultset generated by the command</returns>
		public static DataSet ExecuteDataset(string connectionString, CommandType commandType, string commandText)
		{
			DataSet objDataset;
			//create & open a OracleConnection, and dispose of it after we are done.
			using (OracleConnection cn = new OracleConnection(connectionString))
			{
				cn.Open();

				//call the private overload using null for OracleTransaction and the set of OracleParameters.
				objDataset=ExecuteDataset(cn, (OracleTransaction)null, commandType, commandText, (OracleParameter[])null);
				cn.Close();
			}
			return objDataset;
		}

		/// <summary>
		/// Execute a OracleCommand (that returns a resultset) against the database specified in the connection string 
		/// using the provided parameters.
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  DataSet ds = ExecuteDataset(connString, "csp_ORD_GetOrders", new OracleParameter("@i_iProdid", 24));
		/// </remarks>
		/// <param name="connectionString">a valid connection string for a OracleConnection</param>
		/// <param name="spName">the stored procedure name</param>
		/// <param name="commandParameters">an array of OracleParamters used to execute the command</param>
		/// <returns>a dataset containing the resultset generated by the command</returns>
		public static DataSet ExecuteDataset(string connectionString, string spName, params OracleParameter[] commandParameters)
		{
			DataSet objDataset;
			//create & open a OracleConnection, and dispose of it after we are done.
			using (OracleConnection cn = new OracleConnection(connectionString))
			{
				cn.Open();

				//call the private overload using null for OracleTransaction.
				objDataset=ExecuteDataset(cn, (OracleTransaction)null, CommandType.StoredProcedure, spName, commandParameters);
				cn.Close();
			}
			return objDataset;
		}


		/// <summary>
		/// Execute a OracleCommand (that returns a resultset and takes no parameters) against the provided OracleTransaction. 
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  DataSet ds = ExecuteDataset(trans, CommandType.StoredProcedure, "csp_ORD_GetOrders");
		/// </remarks>
		/// <param name="transaction">a valid OracleTransaction</param>
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">the stored procedure name or T-Oracle command</param>
		/// <returns>a dataset containing the resultset generated by the command</returns>
		public static DataSet ExecuteDataset(OracleTransaction transaction, CommandType commandType, string commandText)
		{
			//call the private overload using transaction.Connection for OracleTransaction and null for the set of OracleParameters.
			return ExecuteDataset(transaction.Connection, transaction, commandType, commandText, (OracleParameter[])null);
		}
		
		/// <summary>
		/// Execute a OracleCommand (that returns a resultset) against the specified OracleTransaction
		/// using the provided parameters.
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  DataSet ds = ExecuteDataset(trans, "csp_ORD_GetOrders", new OracleParameter("@i_iProdid", 24));
		/// </remarks>
		/// <param name="transaction">a valid OracleTransaction</param>
		/// <param name="spName">the stored procedure name</param>
		/// <param name="commandParameters">an array of OracleParamters used to execute the command</param>
		/// <returns>a dataset containing the resultset generated by the command</returns>
		public static DataSet ExecuteDataset(OracleTransaction transaction, string spName, params OracleParameter[] commandParameters)
		{
			//call the private overload using transaction.Connection for OracleTransaction.
			return ExecuteDataset(transaction.Connection, transaction, CommandType.StoredProcedure, spName, commandParameters);
		}
		
				
		#endregion ExecuteDataSet
		#region ExecuteDataTable

		/// <summary>
		/// Create, prepare and execute a OracleCommand (that returns a resultset) 
		/// against the database specified in  the connection string. 
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <param name="connection">a valid OracleConnection, on which to execute this command</param>
		/// <param name="transaction">a valid OracleTransaction, or 'null'</param>
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">the stored procedure name or T-Oracle command</param>
		/// <param name="commandParameters">an array of OracleParameters to be associated with the command or 'null' if no parameters are required</param>
		/// <returns>a datatable containing the resultset generated by the command</returns>
		private static DataTable ExecuteDataTable(OracleConnection connection, OracleTransaction transaction, CommandType commandType, string commandText, OracleParameter[] commandParameters)
		{	

			//create a command and prepare it for execution
			OracleCommand cmd = new OracleCommand();
			PrepareCommand(cmd, connection, transaction, commandType, commandText, commandParameters);			
			
			//create the DataAdapter & DataSet
			OracleDataAdapter da = new OracleDataAdapter(cmd);
			DataTable dt = new DataTable();

			//fill the DataSet using default values for DataTable names, etc.
			da.Fill(dt);
			
			// detach the OracleParameters from the command object, so they can be used again.			
			cmd.Parameters.Clear();
			
			//return the dataset
			return dt;	
			
		}

		/// <summary>
		/// Execute a OracleCommand (that returns a resultset and takes no parameters) against the database specified in 
		/// the connection string. 
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  DataTable dt = ExecuteDataTable(connString, CommandType.StoredProcedure, "csp_ORD_GetOrders");
		/// </remarks>
		/// <param name="connectionString">a valid connection string for a OracleConnection</param>
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">the stored procedure name or T-Oracle command</param>
		/// <returns>a datatable containing the resultset generated by the command</returns>
		public static DataTable ExecuteDataTable(string connectionString, CommandType commandType, string commandText)
		{
			DataTable objDataTable;
			//create & open a OracleConnection, and dispose of it after we are done.
			using (OracleConnection cn = new OracleConnection(connectionString))
			{
				cn.Open();
				//call the private overload using null for OracleTransaction and the set of OracleParameters.
				objDataTable=ExecuteDataTable(cn, (OracleTransaction)null, commandType, commandText, (OracleParameter[])null);
				cn.Close();
			}
			return objDataTable;
		}

		/// <summary>
		/// Execute a OracleCommand (that returns a resultset) against the database specified in the connection string 
		/// using the provided parameters.
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  DataTable dt = ExecuteDataTable(connString, "csp_ORD_GetOrders", new OracleParameter("@i_iProdid", 24));
		/// </remarks>
		/// <param name="connectionString">a valid connection string for a OracleConnection</param>
		/// <param name="spName">the stored procedure name</param>
		/// <param name="commandParameters">an array of OracleParamters used to execute the command</param>
		/// <returns>a datatable containing the resultset generated by the command</returns>
		public static DataTable ExecuteDataTable(string connectionString, string spName, params OracleParameter[] commandParameters)
		{
			DataTable objDataTable;
			//create & open a OracleConnection, and dispose of it after we are done.
			using (OracleConnection cn = new OracleConnection(connectionString))
			{
				cn.Open();
				//call the private overload using null for OracleTransaction.
				objDataTable=ExecuteDataTable(cn, (OracleTransaction)null, CommandType.StoredProcedure, spName, commandParameters);
				cn.Close();
			}
			return objDataTable;
		}


		/// <summary>
		/// Execute a OracleCommand (that returns a resultset and takes no parameters) against the provided OracleTransaction. 
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  DataSet ds = ExecuteDataset(trans, CommandType.StoredProcedure, "csp_ORD_GetOrders");
		/// </remarks>
		/// <param name="transaction">a valid OracleTransaction</param>
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">the stored procedure name or T-Oracle command</param>
		/// <returns>a datatable containing the resultset generated by the command</returns>
		public static DataTable ExecuteDataTable(OracleTransaction transaction, CommandType commandType, string commandText)
		{
			//call the private overload using transaction.Connection for OracleTransaction and null for the set of OracleParameters.
			return ExecuteDataTable(transaction.Connection, transaction, commandType, commandText, (OracleParameter[])null);

		}
		
		/// <summary>
		/// Execute a OracleCommand (that returns a resultset) against the specified OracleTransaction
		/// using the provided parameters.
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  DataTable dt = ExecuteDataTable(trans, "csp_ORD_GetOrders", new OracleParameter("@i_iProdid", 24));
		/// </remarks>
		/// <param name="transaction">a valid OracleTransaction</param>
		/// <param name="spName">the stored procedure name</param>
		/// <param name="commandParameters">an array of OracleParamters used to execute the command</param>
		/// <returns>a datatable containing the resultset generated by the command</returns>
		public static DataTable ExecuteDataTable(OracleTransaction transaction, string spName, params OracleParameter[] commandParameters)
		{
			//call the private overload using transaction.Connection for OracleTransaction.
			return ExecuteDataTable(transaction.Connection, transaction, CommandType.StoredProcedure, spName, commandParameters);
		}
		
				
		#endregion ExecuteDataTable
		#region ExecuteReader

		/// <summary>
		/// this enum is used to indicate whether the connection was provided by the caller, or created by OracleHelper, so that
		/// we can set the appropriate CommandBehavior when calling ExecuteReader()
		/// </summary>
		private enum OracleConnectionOwnership	
		{
			/// <summary>Connection is owned and managed by OracleHelper</summary>
			Internal, 
			/// <summary>Connection is owned and managed by the caller</summary>
			External
		}

		/// <summary>
		/// Create and prepare a OracleCommand, and call ExecuteReader with the appropriate CommandBehavior.
		/// </summary>
		/// <remarks>
		/// If we created and opened the connection, we want the connection to be closed when the DataReader is closed.
		/// 
		/// If the caller provided the connection, we want to leave it to them to manage.
		/// </remarks>
		/// <param name="connection">a valid OracleConnection, on which to execute this command</param>
		/// <param name="transaction">a valid OracleTransaction, or 'null'</param>
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">the stored procedure name or T-Oracle command</param>
		/// <param name="commandParameters">an array of OracleParameters to be associated with the command or 'null' if no parameters are required</param>
		/// <param name="connectionOwnership">indicates whether the connection parameter was provided by the caller, or created by OracleHelper</param>
		/// <returns>OracleDataReader containing the results of the command</returns>
		private static OracleDataReader ExecuteReader(OracleConnection connection, OracleTransaction transaction, CommandType commandType, string commandText, OracleParameter[] commandParameters, OracleConnectionOwnership connectionOwnership)
		{	
			//create a command and prepare it for execution
			OracleCommand cmd = new OracleCommand();

			PrepareCommand(cmd, connection, transaction, commandType, commandText, commandParameters);

			//create a reader
			OracleDataReader dr;

			// call ExecuteReader with the appropriate CommandBehavior
			if (connectionOwnership == OracleConnectionOwnership.External)
			{
				dr = cmd.ExecuteReader();
			}
			else
			{
				dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
			}
			
			// detach the OracleParameters from the command object, so they can be used again.
			cmd.Parameters.Clear();
			
			return dr;
		}


		/// <summary>
		/// Execute a OracleCommand (that returns a resultset and takes no parameters) against the database specified in 
		/// the connection string. 
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  OracleDataReader dr = ExecuteReader(connString, CommandType.StoredProcedure, "csp_ORD_GetOrders");
		/// </remarks>
		/// <param name="connectionString">a valid connection string for a OracleConnection</param>
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">the stored procedure name or T-Oracle command</param>
		/// <returns>a OracleDataReader containing the resultset generated by the command</returns>
		public static OracleDataReader ExecuteReader(string connectionString, CommandType commandType, string commandText)
		{
			//create & open a OracleConnection
			OracleConnection cn = new OracleConnection(connectionString);
			cn.Open();

			try
			{
				//call the private overload that takes an internally owned connection in place of the connection string
				return ExecuteReader(cn, null, commandType, commandText, (OracleParameter[])null, OracleConnectionOwnership.Internal);
			}
			catch
			{
				//if we fail to return the OracleDatReader, we need to close the connection ourselves
				cn.Close();
				throw;
			}
		}

		/// <summary>
		/// Execute a OracleCommand (that returns a resultset) against the database specified in the connection string 
		/// using the provided parameters.
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  OracleDataReader dr = ExecuteReader(connString, CommandType.StoredProcedure, "GetOrders", new OracleParameter("@prodid", 24));
		/// </remarks>
		/// <param name="connectionString">a valid connection string for a OracleConnection</param>
		/// <param name="spName">the stored procedure name</param>
		/// <param name="commandParameters">an array of OracleParamters used to execute the command</param>
		/// <returns>a OracleDataReader containing the resultset generated by the command</returns>
		public static OracleDataReader ExecuteReader(string connectionString, string spName, params OracleParameter[] commandParameters)
		{
			//create & open a OracleConnection
			OracleConnection cn = new OracleConnection(connectionString);
			cn.Open();

			try
			{
				//call the private overload that takes an internally owned connection in place of the connection string
				return ExecuteReader(cn, null, CommandType.StoredProcedure, spName, commandParameters, OracleConnectionOwnership.Internal);
			}
			catch
			{
				//if we fail to return the OracleDatReader, we need to close the connection ourselves
				cn.Close();
				throw;
			}
		}


		/// <summary>
		/// Execute a OracleCommand (that returns a resultset and takes no parameters) against the provided OracleTransaction. 
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  OracleDataReader dr = ExecuteReader(trans, CommandType.StoredProcedure, "csp_ORD_GetOrders");
		/// </remarks>
		/// <param name="transaction">a valid OracleTransaction</param>
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">the stored procedure name or T-Oracle command</param>
		/// <returns>a OracleDataReader containing the resultset generated by the command</returns>
		public static OracleDataReader ExecuteReader(OracleTransaction transaction, CommandType commandType, string commandText)
		{
			//pass through to private overload, indicating that the connection is owned by the caller
			return ExecuteReader(transaction.Connection, transaction, commandType, commandText, (OracleParameter[])null, OracleConnectionOwnership.External);
		}

		/// <summary>
		/// Execute a OracleCommand (that returns a resultset) against the specified OracleTransaction
		/// using the provided parameters.
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///   OracleDataReader dr = ExecuteReader(trans, "csp_ORD_GetOrders", new OracleParameter("@i_iProdid", 24));
		/// </remarks>
		/// <param name="transaction">a valid OracleTransaction</param>
		/// <param name="spName">the stored procedure name</param>
		/// <param name="commandParameters">an array of OracleParamters used to execute the command</param>
		/// <returns>a OracleDataReader containing the resultset generated by the command</returns>
		public static OracleDataReader ExecuteReader(OracleTransaction transaction, string spName, params OracleParameter[] commandParameters)
		{
			//pass through to private overload, indicating that the connection is owned by the caller
			return ExecuteReader(transaction.Connection, transaction, CommandType.StoredProcedure, spName, commandParameters, OracleConnectionOwnership.External);
		}

		
		#endregion ExecuteReader
		#region ExecuteScalar

		/// <summary>
		/// Create, prepare and execute a OracleCommand (that returns a 1x1 resultset) 
		/// against the database specified in  the connection string. 
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <param name="connection">a valid OracleConnection, on which to execute this command</param>
		/// <param name="transaction">a valid OracleTransaction, or 'null'</param>
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">the stored procedure name or T-Oracle command</param>
		/// <param name="commandParameters">an array of OracleParameters to be associated with the command or 'null' if no parameters are required</param>
		/// <returns>an object containing the value in the 1x1 resultset generated by the command</returns>
		private static object ExecuteScalar(OracleConnection connection, OracleTransaction transaction, CommandType commandType, string commandText, OracleParameter[] commandParameters)
		{	
			//create a command and prepare it for execution
			OracleCommand cmd = new OracleCommand();
			PrepareCommand(cmd, connection, transaction, commandType, commandText, commandParameters);			
			
			//execute the command & return the results
		
			object retval = cmd.ExecuteScalar();
			
			// detach the OracleParameters from the command object, so they can be used again.
			cmd.Parameters.Clear();
			return retval;
		}

		/// <summary>
		/// Execute a OracleCommand (that returns a 1x1 resultset and takes no parameters) against the database specified in 
		/// the connection string. 
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  int orderCount = (int)ExecuteScalar(connString, CommandType.StoredProcedure, "csp_ORD_GetOrderCount");
		/// </remarks>
		/// <param name="connectionString">a valid connection string for a OracleConnection</param>
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">the stored procedure name or T-Oracle command</param>
		/// <returns>an object containing the value in the 1x1 resultset generated by the command</returns>
		public static object ExecuteScalar(string connectionString, CommandType commandType, string commandText)
		{
			object objReturn;
			//create & open a OracleConnection, and dispose of it after we are done.
			using (OracleConnection cn = new OracleConnection(connectionString))
			{
				cn.Open();

				//call the private overload using null for OracleTransaction and the set of OracleParameters.
				objReturn=ExecuteScalar(cn, (OracleTransaction)null, commandType, commandText, (OracleParameter[])null);
				cn.Close();
			}
			return objReturn;
		}

		/// <summary>
		/// Execute a OracleCommand (that returns a 1x1 resultset) against the database specified in the connection string 
		/// using the provided parameters.
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  int orderCount = (int)ExecuteScalar(connString, "csp_ORD_GetOrderCount", new OracleParameter("@prodid", 24));
		/// </remarks>
		/// <param name="connectionString">a valid connection string for a OracleConnection</param>
		/// <param name="spName">the stored procedure name</param>
		/// <param name="commandParameters">an array of OracleParamters used to execute the command</param>
		/// <returns>an object containing the value in the 1x1 resultset generated by the command</returns>
		public static object ExecuteScalar(string connectionString, string spName, params OracleParameter[] commandParameters)
		{
			object objReturn;
			//create & open a OracleConnection, and dispose of it after we are done.
			using (OracleConnection cn = new OracleConnection(connectionString))
			{
				cn.Open();

				//call the private overload using null for OracleTransaction.
				objReturn=ExecuteScalar(cn, (OracleTransaction)null, CommandType.StoredProcedure, spName, commandParameters);
				cn.Close();
			}
			return objReturn;

		}

		/// <summary>
		/// Execute a OracleCommand (that returns a 1x1 resultset and takes no parameters) against the provided OracleTransaction. 
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  int orderCount = (int)ExecuteScalar(trans, CommandType.StoredProcedure, "csp_ORD_GetOrderCount");
		/// </remarks>
		/// <param name="transaction">a valid OracleTransaction</param>
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">the stored procedure name or T-Oracle command</param>
		/// <returns>an object containing the value in the 1x1 resultset generated by the command</returns>
		public static object ExecuteScalar(OracleTransaction transaction, CommandType commandType, string commandText)
		{
			//call the private overload using transaction.Connection for OracleTransaction and null for the set of OracleParameters.
			return ExecuteScalar(transaction.Connection, transaction, commandType, commandText, (OracleParameter[])null);
		}

		/// <summary>
		/// Execute a OracleCommand (that returns a 1x1 resultset) against the specified OracleTransaction
		/// using the provided parameters.
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  int orderCount = (int)ExecuteScalar(trans, "csp_ORD_GetOrderCount", new OracleParameter("@i_iProdid", 24));
		/// </remarks>
		/// <param name="transaction">a valid OracleTransaction</param>
		/// <param name="spName">the stored procedure name</param>
		/// <param name="commandParameters">an array of OracleParamters used to execute the command</param>
		/// <returns>an object containing the value in the 1x1 resultset generated by the command</returns>
		public static object ExecuteScalar(OracleTransaction transaction, string spName, params OracleParameter[] commandParameters)
		{
			//call the private overload using transaction.Connection for OracleTransaction.
			return ExecuteScalar(transaction.Connection, transaction, CommandType.StoredProcedure, spName, commandParameters);
		}


		#endregion ExecuteScalar
		#region ExecuteXmlReader

		/// <summary>
		/// Create, prepare and execute a OracleCommand (that returns a resultset) 
		/// against the database specified in  the connection string. 
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <param name="connection">a valid OracleConnection, on which to execute this command</param>
		/// <param name="transaction">a valid OracleTransaction, or 'null'</param>
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">the stored procedure name or T-Oracle command</param>
		/// <param name="commandParameters">an array of OracleParameters to be associated with the command or 'null' if no parameters are required</param>
		/// <returns>an XmlReader containing the resultset generated by the command</returns>
//		private static XmlReader ExecuteXmlReader(OracleConnection connection, OracleTransaction transaction, CommandType commandType, string commandText, OracleParameter[] commandParameters)
//		{	
//			//create a command and prepare it for execution
//			OracleCommand cmd = new OracleCommand();
//			PrepareCommand(cmd, connection, transaction, commandType, commandText, commandParameters);			
//			XmlReader retval = cmd.ExecuteReader();
//			//create the DataAdapter & DataSet
//			//XmlReader retval = cmd.ExecuteXmlReader();
//			
//			// detach the OracleParameters from the command object, so they can be used again.
//			cmd.Parameters.Clear();
//			return retval;
//		}

		/// <summary>
		/// Execute a OracleCommand (that returns a resultset and takes no parameters) against the provided OracleConnection. 
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  XmlReader r = ExecuteXmlReader(conn, CommandType.StoredProcedure, "csp_ORD_GetOrders");
		/// </remarks>
		/// <param name="connection">a valid OracleConnection</param>
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">the stored procedure name or T-Oracle command using "FOR XML AUTO"</param>
		/// <returns>an XmlReader containing the resultset generated by the command</returns>
//		public static XmlReader ExecuteXmlReader(OracleConnection connection, CommandType commandType, string commandText)
//		{
//			//call the private overload using null for OracleTransaction and the set of OracleParameters.
//			return ExecuteXmlReader(connection, (OracleTransaction)null, commandType, commandText, (OracleParameter[])null);
//		}

		/// <summary>
		/// Execute a OracleCommand (that returns a resultset) against the specified OracleConnection 
		/// using the provided parameters.
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  XmlReader r = ExecuteXmlReader(conn, "csp_ORD_GetOrders", new OracleParameter("@i_iProdid", 24));
		/// </remarks>
		/// <param name="connection">a valid OracleConnection</param>
		/// <param name="spName">the stored procedure name using "FOR XML AUTO"</param>
		/// <param name="commandParameters">an array of OracleParamters used to execute the command</param>
		/// <returns>an XmlReader containing the resultset generated by the command</returns>
//		public static XmlReader ExecuteXmlReader(OracleConnection connection, string spName, params OracleParameter[] commandParameters)
//		{
//			//call the private overload using null for OracleTransaction.
//			return ExecuteXmlReader(connection, (OracleTransaction)null, CommandType.StoredProcedure, spName, commandParameters);
//		}

		/// <summary>
		/// Execute a OracleCommand (that returns a resultset and takes no parameters) against the provided OracleTransaction. 
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  XmlReader r = ExecuteXmlReader(trans, CommandType.StoredProcedure, "csp_ORD_GetOrders");
		/// </remarks>
		/// <param name="transaction">a valid OracleTransaction</param>
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">the stored procedure name or T-Oracle command using "FOR XML AUTO"</param>
		/// <returns>an XmlReader containing the resultset generated by the command</returns>
//		public static XmlReader ExecuteXmlReader(OracleTransaction transaction, CommandType commandType, string commandText)
//		{
//			//call the private overload using transaction.Connection for OracleTransaction and null for the set of OracleParameters.
//			return ExecuteXmlReader(transaction.Connection, transaction, commandType, commandText, (OracleParameter[])null);
//		}

		/// <summary>
		/// Execute a OracleCommand (that returns a resultset) against the specified OracleTransaction
		/// using the provided parameters.
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  XmlReader r = ExecuteXmlReader(trans, "csp_ORD_GetOrders", new OracleParameter("@i_iProdid", 24));
		/// </remarks>
		/// <param name="transaction">a valid OracleTransaction</param>
		/// <param name="spName">the stored procedure name using "FOR XML AUTO"</param>
		/// <param name="commandParameters">an array of OracleParamters used to execute the command</param>
		/// <returns>an XmlReader containing the resultset generated by the command</returns>
//		public static XmlReader ExecuteXmlReader(OracleTransaction transaction, string spName, params OracleParameter[] commandParameters)
//		{
//			//call the private overload using transaction.Connection for OracleTransaction.
//			return ExecuteXmlReader(transaction.Connection, transaction, CommandType.StoredProcedure, spName, commandParameters);
//		}

		
		#endregion ExecuteXmlReader
		#region Methods add by Offshore team

		/// <summary>
		/// Execute a OracleCommand (that returns a resultset) against the database specified in the connection string 
		/// using the provided parameters.
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  OracleDataReader dr = ExecuteReader(connString, CommandType.StoredProcedure, "GetOrders", new OracleParameter("@prodid", 24));
		/// </remarks>
		/// <param name="connectionString">A valid connection string for a OracleConnection</param>
		/// <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">The stored procedure name or T-Oracle command</param>
		/// <param name="commandParameters">An array of OracleParamters used to execute the command</param>
		/// <returns>A OracleDataReader containing the resultset generated by the command</returns>
		public static OracleDataReader ExecuteReader(string connectionString, CommandType commandType, string commandText, params OracleParameter[] commandParameters)
		{
			if( (connectionString == null) || (connectionString.Length == 0) ) 
			{
				throw new ArgumentNullException( "connectionString" );
			}
			OracleConnection connection = null;
			try
			{
				connection = new OracleConnection(connectionString);
				connection.Open();

				// Call the private overload that takes an internally owned connection in place of the connection string
				return ExecuteReader(connection, null, commandType, commandText, commandParameters,OracleConnectionOwnership.Internal);
			}
			catch
			{
				// If we fail to return the OracleDatReader, we need to close the connection ourselves
				if( connection != null ) 
				{ 		
					connection.Dispose();
				}
				throw;
			} 
		}


		/// <summary>
		/// Execute a OracleCommand (that returns a 1x1 resultset) against the database specified in the connection string 
		/// using the provided parameters.
		/// </summary>
		/// <remarks>
		/// e.g.:  
		///  int orderCount = (int)ExecuteScalar(connString, CommandType.StoredProcedure, "GetOrderCount", new OracleParameter("@prodid", 24));
		/// </remarks>
		/// <param name="connectionString">A valid connection string for a OracleConnection</param>
		/// <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">The stored procedure name or T-Oracle command</param>
		/// <param name="commandParameters">An array of OracleParamters used to execute the command</param>
		/// <returns>An object containing the value in the 1x1 resultset generated by the command</returns>
		public static object ExecuteScalar(string connectionString, CommandType commandType, string commandText, params OracleParameter[] commandParameters)
		{
			object objReturn;
			if( connectionString == null || connectionString.Length == 0 ) throw new ArgumentNullException( "connectionString" );
			// Create & open a OracleConnection, and dispose of it after we are done
			using (OracleConnection connection = new OracleConnection(connectionString))
			{
				connection.Open();

				// Call the overload that takes a connection in place of the connection string
				objReturn=ExecuteScalar(connection, null, commandType, commandText, commandParameters);
				connection.Close();
			}
			return objReturn;
		}

		
		/// <summary>
		/// Create, prepare and execute a OracleCommand (that returns no resultset) 
		/// against the database specified in  the connection string. 
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <param name="connection">a valid OracleConnection, on which to execute this command</param>
		/// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
		/// <param name="commandText">the stored procedure name or T-Oracle command</param>
		/// <param name="commandParameters">an array of OracleParameters to be associated with the command or 'null' if no parameters are required</param>
		/// <returns>an int representing the number of rows affected by the command</returns>
		public static int ExecuteNonQuery(OracleConnection connection, CommandType commandType, string commandText, OracleParameter[] commandParameters)
		{	
			//create a command and prepare it for execution
			OracleCommand cmd = new OracleCommand();
			PrepareCommand(cmd, connection, null, commandType, commandText, commandParameters);	
			
			//finally, execute the command.
			int retval = cmd.ExecuteNonQuery();
			
			// detach the OracleParameters from the command object, so they can be used again.
			cmd.Parameters.Clear();
			return retval;			
		}

		#endregion
	}
}
