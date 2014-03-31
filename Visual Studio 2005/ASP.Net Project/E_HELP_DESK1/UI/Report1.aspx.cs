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

	public partial class Report1 : System.Web.UI.Page
	{

		Complaint crpt;
		private CrystalDecisions.Shared.TableLogOnInfo mylogin = new TableLogOnInfo();

		protected void Page_Load(object sender, System.EventArgs e)
		{
			
			crpt = new Complaint();

			foreach(CrystalDecisions.CrystalReports.Engine.Table mytable in crpt.Database.Tables)
			{
				mylogin = mytable.LogOnInfo;
				mylogin.ConnectionInfo.Password="EHELPDEK";
				mylogin.ConnectionInfo.UserID="EHELPDEK";
				mytable.ApplyLogOnInfo(mylogin);
			}
			string reportpath = Server.MapPath("Complaint.rpt");
		
			ParameterDiscreteValue crtParamDiscreteValue;
			ParameterField crtParamField;
			ParameterFields crtParamFields;

			 ParameterValues values = new ParameterValues();
			crtParamDiscreteValue = new ParameterDiscreteValue();
			crtParamField = new ParameterField();
			crtParamFields = new ParameterFields();

			BLLReport o_BLLReport = (BLLReport)Session["o_BLLReport"];
			crtParamDiscreteValue.Value =o_BLLReport.pdfrom;


			string from = o_BLLReport.pdfrom;
			string to =o_BLLReport.pdto;
 
			crtParamField.ParameterFieldName = "@fromdate";
			crtParamField.CurrentValues.Add(crtParamDiscreteValue);

			crtParamFields.Add(crtParamField);
			values.Add(crtParamDiscreteValue);
			crpt.DataDefinition.ParameterFields[0].ApplyCurrentValues(values);
			
			crtParamDiscreteValue.Value=o_BLLReport.pdto;
			crtParamField.ParameterFieldName="@todate";
			crtParamField.CurrentValues.Add(crtParamDiscreteValue);
			crtParamFields.Add(crtParamField);
			values.Add(crtParamDiscreteValue);

			crpt.DataDefinition.ParameterFields[1].ApplyCurrentValues(values);
			
//			crpt.RecordSelectionFormula="{TBL_COMPLAIN.COMP_REG_DATE_TIME} >= Date(" + from.ToString() + ") AND {TBL_COMPLAIN.COMP_REG_DATE_TIME} <= Date(" + to.ToString() + ") ";


//          crpt.RecordSelectionFormula= "DateValue({TBL_COMPLAIN.COMP_REG_DATE_TIME}) >= Date(03/,Mar/2007) AND DateVAlue({TBL_COMPLAIN.COMP_REG_DATE_TIME}) <= Date(03/Mar/2007)";

			//////////////////////////////////////////////////////
//			if {usp_RPT_RW_CONDS_TIME;1.TIRE_CHAIN_RSTRCT_DESC} like "Condition A*" then
//  
//    NumberVar DaysDiff := DateDiff("d",{usp_RPT_RW_CONDS_TIME;1.ENTRY_DTTM},{usp_RPT_RW_CONDS_TIME;1.EXP_DTTM});
//    NumberVar HourStart := Hour({usp_RPT_RW_CONDS_TIME;1.ENTRY_DTTM});
//    NumberVar MinStart := Minute({usp_RPT_RW_CONDS_TIME;1.ENTRY_DTTM});
//    NumberVar HourEnd := Hour({usp_RPT_RW_CONDS_TIME;1.EXP_DTTM});
//    NumberVar MinEnd := Minute({usp_RPT_RW_CONDS_TIME;1.EXP_DTTM});
//
//    NumberVar HourDiff:= 0;
//    NumberVar MinDiff := 0;
// 
//    // get days and hours
//    If DaysDiff >= 1 then
//        (
//        If HourStart > HourEnd Then   
//            (
//             HourDiff := (HourEnd - HourStart) + 24;//adjust number of hours
//             DaysDiff := DaysDiff - 1;//adjust the number of days
//            )
//        else
//            HourDiff := HourEnd - HourStart;
//        )
//    else
//       HourDiff := HourEnd-HourStart;
//
//    //get minutes
//    If HourDiff >= 1 then
//        (
//        If MinStart > MinEnd Then   
//            (
//            MinDiff := 60 + (MinEnd - MinStart);//adjust minute
//            (HourDiff := HourDiff - 1)//adjust hour
//            )
//        else
//            MinDiff := MinEnd - MinStart
//         )
//    else
//         MinDiff := MinEnd - MinStart;
//
//    // output
//    Totext(DaysDiff,"00") + " Days," + Totext(HourDiff,"00") + " Hours," + 
//    ToText(MinDiff,"00") + " Minutes";
			/////////////////////////////////////////////////////

			CrystalReportViewer1.ReportSource=crpt;
		
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
