using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using E_HELP_DESK1.BusinessLogicLayer;

namespace E_HELP_DESK1.UI
{
	/// <summary>
	/// Summary description for complaintitspt1.
	/// </summary>
	public partial class complaintitspt1 : System.Web.UI.Page
	{
//		complaintitspt crpt;
		private CrystalDecisions.Shared.TableLogOnInfo mylogin = new TableLogOnInfo();
	
		protected void Page_Load(object sender, System.EventArgs e)
		{

//			crpt = new complaintitspt();
//
//			foreach(CrystalDecisions.CrystalReports.Engine.Table mytable in crpt.Database.Tables)
//			{
//				mylogin = mytable.LogOnInfo;
//				mylogin.ConnectionInfo.Password="EHELPDEK";
//				mylogin.ConnectionInfo.UserID="EHELPDEK";
//				mytable.ApplyLogOnInfo(mylogin);
//			}
//			string reportpath = Server.MapPath("complaintitspt.rpt");
//		
//			ParameterDiscreteValue crtParamDiscreteValue;
//			ParameterField crtParamField;
//			ParameterFields crtParamFields;
//
//			ParameterValues values = new ParameterValues();
//			crtParamDiscreteValue = new ParameterDiscreteValue();
//			crtParamField = new ParameterField();
//			crtParamFields = new ParameterFields();
//			crtParamDiscreteValue.Value =BLLReport.pdfrom;
//
//
//			string from = BLLReport.pdfrom;
//			string to =BLLReport.pdto;
// 
//			crtParamField.ParameterFieldName = "@fromdate";
//			crtParamField.CurrentValues.Add(crtParamDiscreteValue);
//
//			crtParamFields.Add(crtParamField);
//			values.Add(crtParamDiscreteValue);
//			crpt.DataDefinition.ParameterFields[0].ApplyCurrentValues(values);
//			
//			crtParamDiscreteValue.Value=BLLReport.pdto;;
//			crtParamField.ParameterFieldName="@todate";
//			crtParamField.CurrentValues.Add(crtParamDiscreteValue);
//			crtParamFields.Add(crtParamField);
//			values.Add(crtParamDiscreteValue);
//
//			crpt.DataDefinition.ParameterFields[1].ApplyCurrentValues(values);
//			
////			crpt.RecordSelectionFormula="{TBL_COMPLAIN.COMP_REG_DATE_TIME} >= Date(" + from.ToString() + ") AND {TBL_COMPLAIN.COMP_REG_DATE_TIME} <= Date(" + to.ToString() + ") ";
//
//			CrystalReportViewer1.ReportSource=crpt;
//			// Put user code to initialize the page here
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    

		}
		#endregion
	}
}
