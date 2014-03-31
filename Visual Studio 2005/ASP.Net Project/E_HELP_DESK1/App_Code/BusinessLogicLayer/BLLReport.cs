using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OracleClient;
using System.Web.SessionState;
using System.Text.RegularExpressions;
using System.Web.UI.HtmlControls;
using System.Configuration;

using E_HELP_DESK1.DataAccessLayer;
using E_HELP_DESK1.UI;

namespace E_HELP_DESK1.BusinessLogicLayer
{
	/// <summary>
	/// Summary description for BLLReport.
	/// </summary>	
	public class BLLReport
	{
		public  string pdfrom, pdto;
		public BLLReport()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public void setdatefield(string p_from , string p_to)
		{
			pdfrom = p_from;
			pdto = p_to;
		}


	}
}
