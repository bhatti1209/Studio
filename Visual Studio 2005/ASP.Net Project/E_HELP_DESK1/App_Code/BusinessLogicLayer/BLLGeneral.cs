using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OracleClient;
using E_HELP_DESK1.DataAccessLayer;
using System.Web.SessionState;
using System.Text.RegularExpressions;
using System.Web.UI.HtmlControls;
using System.Configuration;

namespace E_HELP_DESK1.BusinessLogicLayer
{
	/// <summary>
	/// Summary description for BLLGeneral.
	/// </summary>
	public class BLLGeneral
	{
		private static Regex _isNumber = new Regex(@"^\d+$");
//	
//		
		public BLLGeneral()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		#region Properties
		 private string _pipecode  = string.Empty;
		private string _phtable  = string.Empty;
		private string _phcode  = string.Empty;
		private string _phase  = string.Empty;
		private string _maxxtmlno =string.Empty;
		private string _packageCoordinator = string.Empty;
			
		
		public string pipecode
		{
			get{ return _pipecode; }
			set{ _pipecode = value; }
		}


		public string phase
		{
			get{ return _phase; }
			set{ _phase = value; }
		}
		public string phtable
		{
			get{ return _phtable; }
			set{ _phtable = value; }
		}
		public string phcode
		{
			get{ return _phcode; }
			set{ _phcode = value; }
		}
		public string packageCoordinator
		{
			get{ return _packageCoordinator; }
			set{ _packageCoordinator = value; }
		}

		public string MaxXtmlno
		{
			get{ return _maxxtmlno; }
			set{ _maxxtmlno = value; }
		}
				
		#endregion

		#region FUNCTION TO FILL DROPDOWN LIST
		public  static void FillDropDownBox(DropDownList oDropDownList,DataTable oDataTable,string TextFeild,string ValueFeild,bool AddSelect)
		{
			oDropDownList.DataSource=oDataTable;
			oDropDownList.DataTextField=TextFeild;
			oDropDownList.DataValueField=ValueFeild;
			oDropDownList.DataBind();

			//Add a default SELECT option to the dropdown
			if(AddSelect==true)
			{
				ListItem oListItem=new ListItem("Please Select","Please Select");
				oDropDownList.Items.Insert(0,oListItem);
			}
		
		}
		#endregion
		#region FUNCTION TO GetFormattedDate
		public static string GetFormattedDate(string strDate) 
		{ 
			string[] arInfo = new string[2];
    
			char[] splitter  = {'/'};
            
			arInfo = strDate.Split(splitter);
						
			return arInfo[1].ToString() + "/" + arInfo[0].ToString() + "/" + arInfo[2].ToString();
			
		} 
		#endregion
		#region FUNCTION TO FILL LIST BOX
		public static void FillListBox(ListBox oListBox,DataTable oDataTable,string TextFeild,string ValueFeild,bool AddSelect)
		{
			oListBox.DataSource=oDataTable;
			oListBox.DataTextField=TextFeild;
			oListBox.DataValueField=ValueFeild;
			oListBox.DataBind();		
		}
		public static void FillListBox(ListBox oListBox,DataTable oDataTable,string TextFeild,string ValueFeild)
		{
			oListBox.DataSource=oDataTable;
			oListBox.DataTextField=TextFeild;
			oListBox.DataValueField=ValueFeild;
			oListBox.DataBind();		
		}
		#endregion
		#region FUNCTION TO ClearControls
		public static void ClearControls(HtmlForm _form)
		{
			foreach(Control c in _form.Controls)
			{
				if(c is TextBox)
				{
					((TextBox)c).Text = "";
				}

				if(c is DropDownList)
				{
					((DropDownList)c).SelectedIndex = -1;
				}

				if(c is Label)
				{
					if(IsInteger(((Label)c).Text))
					{
						((Label)c).Text = "0";
					}
					else
					{ 
						((Label)c).Text = "";
					}
				}
			}
		}
		#endregion
		#region FUNCTION TO CheckInteger
		public static bool IsInteger(string theValue)
		{
			Match m = _isNumber.Match(theValue);
			return m.Success;
		} //IsInteger

		
		#endregion
		#region FUNCTION TO CheckNumber
		public static bool IsNumeric(string strNumber) 
		{ 
			Regex objNotPositivePattern=new Regex("[^0-9.]");
			Regex objPositivePattern=new Regex("^[.][0-9]+$|[0-9]*[.]*[0-9]+$");
			Regex objTwoDotPattern=new Regex("[0-9]*[.][0-9]*[.][0-9]*");
			return !objNotPositivePattern.IsMatch(strNumber) &&	objPositivePattern.IsMatch(strNumber) && !objTwoDotPattern.IsMatch(strNumber);

		} 
		#endregion
		#region FUNCTION TO GetDetails
		public static string [] GetCampaignDetails(string Campaign) 
		{ 
			string[] arInfo = new string[2];
    
			char[] splitter  = {'/'};
            
			return Campaign.Split(splitter);
									
		} 
		#endregion
		
		#region GetPackageCoordinatorData
		
		public static DataTable GetPackageCoordinatorData( string phTable, string pipeCode)
		{
			
			DataTable oDataTable = DALCommon.ExecuteDataTable("select distinct PackageCoOrdinator from " + phTable + "_RGS where DOCNUM like '" + pipeCode + "%' ORDER BY PackageCoOrdinator");
			return oDataTable;
		}

	
		#endregion
		#region GenerateNewTransmittalNo
		
		public  DataTable GenerateNewTransmittalNo( string plType, string phCode)
		{
			
			DataTable oDataTable = DALCommon.ExecuteDataTable("SELECT MAX(XtmlNo)AS xtmlmax FROM EDMSTRANSMITTAL WHERE XtmlNo LIKE '" + plType + "-" +phCode + "-IN-" + "%'" );		

			return oDataTable;
		}
		#endregion
		#region GetDocumentRegister
		
		public static DataTable GetDocumentRegister( string phTable, string pipeCode,string packagecoordinator)
		{
			
			DataTable oDataTable = DALCommon.ExecuteDataTable("select distinct DOCNUM from " + phTable + "_Rgs where docnum like '" + pipeCode + "%' and PackageCoordinator='" + packagecoordinator + "' ORDER BY DOCNUM " );
			return oDataTable;
		}
		#endregion
		#region GetPipelinesData
		public static DataTable GetPipelinesData()
		{
			
			DataTable oDataTable = DALCommon.ExecuteDataTable("select distinct Pipelinecode,Pipelinetype from EDMSpipelines ");
			return oDataTable;
		}

		public static DataTable GetPipelinesData(string plType)
		{
			
			DataTable oDataTable = DALCommon.ExecuteDataTable("select distinct Pipelinecode,Pipelinetype from EDMSpipelines where Pipelinecode = '"+ plType +"'");
			return oDataTable;
		}
		#endregion
		#region GetRecipientData
		public static DataTable GetRecipientData()
		{
			
			DataTable oDataTable = DALCommon.ExecuteDataTable("select UserID,DisplayName from EdmsUser ORDER BY DisplayName");
			return oDataTable;
		}
		#endregion
		#region GetPhaseData
		public   DataTable GetStateData()
		{
			
			DataTable oDataTable = DALCommon.ExecuteDataTable("select Sid,Sname from TBL_State Order by SName");
			
			if(oDataTable.Rows.Count > 0)
			{
				
			}
			return oDataTable;
		}

		

		public   DataTable GetDistData(string Sid)
		{
			
			DataTable oDataTable = DALCommon.ExecuteDataTable("select TBL_Dist.Did,TBL_Dist.Dname from TBL_Dist,Tbl_state Where Tbl_State.SID=TBL_Dist.SID and TBL_Dist.Sid= '" + Sid + "' Order by Dname");
			
			if(oDataTable.Rows.Count > 0)
			{
				
			}
			return oDataTable;
		}

		public   DataTable GetThData(string Did)
		{
			
			DataTable oDataTable = DALCommon.ExecuteDataTable("select TBL_Taluk.Tid,TBL_Taluk.TALUKNAME from TBL_Taluk,TBL_Dist,Tbl_State Where TBL_Taluk.DID=TBL_Dist.DID AND TBL_Dist.SID=Tbl_State.SID and  TBL_Taluk.Did= '" + Did + "' Order by TALUKNAME");
			
			if(oDataTable.Rows.Count > 0)
			{
				
			}
			return oDataTable;
		}

		public   DataTable GetVilgData(string Tid)
		{
			
			DataTable oDataTable = DALCommon.ExecuteDataTable("select TBL_Village.Vid,TBL_Village.Vname from TBL_Village,TBL_Taluk,TBL_Dist,Tbl_State Where TBL_Village.TID=TBL_Taluk.TID and TBL_Dist.DID=TBL_Taluk.DID and TBL_Dist.SID=Tbl_State.SID and  TBL_Village.Tid= '" + Tid + "' Order by Vname");
			
			if(oDataTable.Rows.Count > 0)
			{
				
			}
			return oDataTable;
		}

		
		public  DataTable GetPhaseData(string phaseValue)
		{
			
			DataTable oDataTable = DALCommon.ExecuteDataTable("select PhaseID,Phasedesc,phaseTable,phasecode from EDMSPHASE where PhaseID = '" + phaseValue + "'  Order by PhaseDesc");
			if(oDataTable.Rows.Count > 0)
			{
				phase = Convert.ToString(oDataTable.Rows[0][1]);
				phtable = Convert.ToString(oDataTable.Rows[0][2]);
				phcode = Convert.ToString(oDataTable.Rows[0][3]);
			}
			return oDataTable;
		}
		#endregion
		#region GetRFIData
		public static DataTable GetRFIData(string phase)
		{
			
			DataTable oDataTable = DALCommon.ExecuteDataTable("select * from EDMSReasonforIssue where PhaseCODE = '" + phase + "' ORDER BY RFICode");
			return oDataTable;
		}
		
		#endregion
		#region UNIQUE ID

		public static string uniqueid() 
		{
			double diff=0;
			try 
			{
				System.DateTime startDate = new System.DateTime();
				startDate= DateTime.Now;  
				System.DateTime endDate = new System.DateTime(2006,3,1);
			
				System.TimeSpan TS = new System.TimeSpan(startDate.Ticks-endDate.Ticks);
				diff=TS.TotalSeconds; 
			}
			catch
			{
				diff = -1;
			}

			string unique = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + "_" + Math.Round(diff) + "_";
			return unique ;
		}
		

		#endregion
		#region GetFileServer
		// Default (App database) connection string.
		// Need to Enhance the by implementing local caching and 
		// also making it thread safe
		public static string GetFileServer()
		{
			return ConfigurationSettings.AppSettings["FileServerLocation"];
		}
		#endregion GetFileServer
		

	}

	}
