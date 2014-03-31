using System;
using System.Data;
using System.Data.OracleClient;
using System.Configuration;

namespace E_HELP_DESK1.ApplicationFramework
{
	/// <summary>
	/// Summary description for DataBaseGeneral.
	/// </summary>
	public class DataBaseGeneral
	{
		public DataBaseGeneral()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		private static int NewRowID=-1;

		#region GET CONNECTION
		
		public static OracleConnection getConnection()
		{
			OracleConnection oConnection=new OracleConnection();
			oConnection.ConnectionString=ConfigurationSettings.AppSettings["ConnectionString"];
			oConnection.Open();
			return oConnection;
		}


		#endregion


		#region GET RECORDS USING SELECT QUERY

		public static string GetScalarValue(string strOracle)
		{
			OracleConnection oConnection=getConnection();
			OracleCommand oCommand = new OracleCommand(strOracle,oConnection);
			object obj = oCommand.ExecuteScalar();
			oConnection.Close();
			if(obj==null)
			{
				return "";
			}
			else
			{
				return obj.ToString();
			}
		}

		public static DataTable GetDataTable(string strOracle)
		{
			OracleConnection oConnection=getConnection();
			OracleCommand oCommand = new OracleCommand(strOracle,oConnection);
			DataSet oDataSet = new DataSet();
			OracleDataAdapter oAdapter = new OracleDataAdapter(oCommand);
			oAdapter.Fill(oDataSet);
			return oDataSet.Tables[0];
		}

		public static OracleDataReader GetDataReader(string strOracle)
		{
			OracleConnection oConnection=getConnection();
			OracleCommand oCommand = new OracleCommand(strOracle,oConnection);			
			return oCommand.ExecuteReader(CommandBehavior.CloseConnection);
		}

		#endregion

		#region InsertRecordsusingDataTable

		public static bool InsertRecordsusingDataTable(DataTable oDataTable, string strTableName, bool IsUpdate)
		{
			OracleConnection oConnection=getConnection();

			string strQuery="select * from " + strTableName + " where 1=2";

			OracleDataAdapter oDataAdapter=new OracleDataAdapter(strQuery,oConnection);
			oDataAdapter.Fill(oDataTable);

			OracleCommandBuilder oCommandBuilder=new OracleCommandBuilder(oDataAdapter);
			oDataAdapter.InsertCommand=oCommandBuilder.GetInsertCommand();

			if(IsUpdate)
			{
				oDataAdapter.UpdateCommand=oCommandBuilder.GetUpdateCommand();
			}
			oDataAdapter.Update(oDataTable);
			return true;
		}

		#endregion

		#region GetTableSchema

		public static DataTable GetTableSchema(string strTableName)
		{
			string strOracle = "SELECT * FROM " + strTableName + " WHERE 1=2";
			return GetDataTable(strOracle);
		}

		#endregion

		#region InsertRecordsusingDataSet

		public static bool InsertRecordsusingDataSet(DataSet oDataSet,string strParentTableName,string ForeignKeyField, bool IsUpdate)
		{
			OracleConnection oConnection=getConnection();
			//OracleTransaction oOracleTransaction = oConnection.BeginTransaction();
			
			try
			{
				foreach(DataTable oDataTable in oDataSet.Tables)
				{
					string strQuery="select * from " + oDataTable.TableName;
				
					OracleDataAdapter oDataAdapter=new OracleDataAdapter(strQuery,oConnection);
					//oDataAdapter.SelectCommand.Transaction = oOracleTransaction;
				
					oDataAdapter.Fill(oDataTable);
										
					if(oDataTable.TableName == strParentTableName)
					{
						oDataAdapter.RowUpdated += new OracleRowUpdatedEventHandler(oDataAdapter_OnRowUpdate);
					}
					else
					{
						foreach(DataRow oDataRow in oDataTable.Rows)
						{
							if(oDataRow[ForeignKeyField] == System.DBNull.Value)
								oDataRow[ForeignKeyField] = NewRowID;
						}
					}

					OracleCommandBuilder oCommandBuilder=new OracleCommandBuilder(oDataAdapter);
					oDataAdapter.InsertCommand=oCommandBuilder.GetInsertCommand();
					//oDataAdapter.InsertCommand.Transaction = oOracleTransaction;
					oDataAdapter.UpdateCommand=oCommandBuilder.GetUpdateCommand();
					//oDataAdapter.UpdateCommand.Transaction = oOracleTransaction;


					oDataAdapter.Update(oDataTable);
													
				}
			
				//oOracleTransaction.Commit();
				return true;
			}
			catch (Exception _exc)
			{
				string str = _exc.Message;
				//oOracleTransaction.Rollback();
				return false;
			}
			finally
			{
				oConnection.Close();
				oConnection.Dispose();
				//oOracleTransaction.Dispose();
			}
		}

		private static void oDataAdapter_OnRowUpdate(object sender,
			OracleRowUpdatedEventArgs  e)
		{
			OracleCommand oOracleCommand = new OracleCommand("SELECT @@IDENTITY",
				e.Command.Connection);

			//e.Row["OrderId"] = oOracleCommand.ExecuteScalar();
			NewRowID = int.Parse(oOracleCommand.ExecuteScalar().ToString());
			e.Row.AcceptChanges();
		}

		#endregion

		#region  IsNameExists
		public static bool IsNameExists(string TableName, string FieldName, string FieldValue)
		{
			string strOracle="SELECT " + FieldName + " FROM " + TableName + " WHERE " + FieldName + " ='" + FieldValue + "'";
			if(GetScalarValue(strOracle)=="")
				return false;
			else
				return true;
		}

		public static bool IsNameExists(string strTableName, string strFieldName, string strFieldValue, string strPKFieldName, int intPKFieldValue)
		{
			string strOracle="SELECT " + strFieldName + " FROM " + strTableName + " WHERE " + strFieldName + " ='" + strFieldValue + "' AND " + strPKFieldName + "<> " + intPKFieldValue;
			if(GetScalarValue(strOracle)=="")
				return false;
			else
				return true;
		}

		public static bool IsNameExists(string TableName, string FieldName, string FieldValue, string FieldName2, int FieldValue2, int Val)
		{
			string strOracle="SELECT " + FieldName + " FROM " + TableName + " WHERE " + FieldName + " ='" + FieldValue + "' and " + FieldName2 + "="+ FieldValue2;
			if(GetScalarValue(strOracle)=="")
				return false;
			else
				return true;
		}
		
		public static bool IsNameExists(string strTableName, string strFieldName, string strFieldValue, string FieldName2, int FieldValue2, string strPKFieldName, int intPKFieldValue)
		{
			string strOracle="SELECT " + strFieldName + " FROM " + strTableName + " WHERE " + strFieldName + " ='" + strFieldValue + "' AND " + FieldName2 + "<>" + FieldValue2 + " and " + strPKFieldName + "=" + intPKFieldValue;
			if(GetScalarValue(strOracle)=="")
				return false;
			else
				return true;
		}

		#endregion

	}
}
