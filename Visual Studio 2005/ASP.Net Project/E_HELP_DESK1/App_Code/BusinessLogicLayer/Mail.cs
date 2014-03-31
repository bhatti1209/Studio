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
using System.Web.Mail;
using System.IO;
using System.Text;

using E_HELP_DESK1.DataAccessLayer;

namespace E_HELP_DESK1.BusinessLogicLayer
{
	/// <summary>
	/// Summary description for Mail.
	/// </summary>
	public class Mail
	{
		public Mail()
		{
			//
			// TODO: Add constructor logic her
			//
		}
		public static bool SendMail(string p_VENDOR_ID, string p_COMP_NO)
		{
			MailMessage oEmail  =new MailMessage();

			oEmail.To = getvendermailid(p_VENDOR_ID);
			oEmail.From= "pankaj.uniyal@ril.com";
			oEmail.Bcc="pooja.n.singh@ril.com";
			oEmail.Subject = "E-Help Desk";

			StringBuilder strMessage = createMail( p_COMP_NO,p_VENDOR_ID );

			oEmail.Body = strMessage.ToString();
			oEmail.Priority = MailPriority.High;
			oEmail.BodyFormat =	MailFormat.Html;
			SmtpMail.SmtpServer.Insert(0,"10.22.19.06");
		
			try
			{
				SmtpMail.Send(oEmail);
			}
			catch(Exception)
			{
				return false;
			}
			return true;
		}
		
		public static bool SendMailcnfm(string p_SITE_ID, string p_cmpno)
		{
			MailMessage oEmail  =new MailMessage();
			oEmail.To = getsitemailid(p_SITE_ID);
			oEmail.From= "pankaj.uniyal@ril.com";
			oEmail.Bcc="pankaj.uniyal@ril.com";
			oEmail.Subject = "Complaint Registered Confirmation";
			StringBuilder  strMessage = new StringBuilder ();

			////////////////////////////////////////////////////////
			DataTable oDataTable = Mail.getRegcmpdetail(p_cmpno);
			////////////////////////////////////////////////////////
			strMessage.Append ("<body bottomMargin=0 leftMargin=0 topMargin=0 rightMargin=0 MS_POSITIONING=GridLayout>");
			strMessage.Append("<table width=100% border=0 cellpadding=0 cellspacing=0  bordercolor=black align=left >");
				strMessage.Append("<tr>");
					strMessage.Append("<td>");
						strMessage.Append("<table width=100% border=0 cellpadding=0 cellspacing=0  bordercolor=black align=left >");
							strMessage.Append("<tr>");
								strMessage.Append("<td align=center ><font size=5>E Help Desk");
								strMessage.Append("</td>");
							strMessage.Append("</tr>");
						strMessage.Append("</table>");
					strMessage.Append("</td>");
				strMessage.Append("</tr>");
				strMessage.Append("<tr>");
					strMessage.Append("<td>");
						strMessage.Append("<table width=100% border=0 cellpadding=0 cellspacing=0  bordercolor=black align=left >");
							strMessage.Append("<tr>");
								strMessage.Append("<td align=center ><font size=4>complaint Registered Confirmation ");
								strMessage.Append("</td>");
							strMessage.Append("</tr>");
						strMessage.Append("</table>");
					strMessage.Append("</td>");
				strMessage.Append("</tr>");
				strMessage.Append("<tr>");
					strMessage.Append("<td>");
						strMessage.Append("<table width=100% border=0 cellpadding=0 cellspacing=0  bordercolor=black align=left >");
							strMessage.Append("<tr>");
								strMessage.Append("<td align=left><font size=3>complaint Number :-" + p_cmpno);	
								strMessage.Append("</td>");
								strMessage.Append("<td align=left><font size=3>Complaint Register time :-" +oDataTable.Rows[0][4] );
								strMessage.Append("</td>");
								strMessage.Append("<td td align=left ><font size=3>Compalint Type :-" +oDataTable.Rows[0][1]);
								strMessage.Append("</td>");
							strMessage.Append("</tr>");
						strMessage.Append("</table>");
					strMessage.Append("</td>");
				strMessage.Append("</tr>");
				
				strMessage.Append("<tr>");
					strMessage.Append("<td>");
						strMessage.Append("<table width=100% border=0 cellpadding=0 cellspacing=0  bordercolor=black align=left >");
							strMessage.Append("<tr>");
								strMessage.Append("<td align=left><font size=3>Complainer Name :-");
								strMessage.Append("</td>");
								strMessage.Append("<td><font size=3>"+ oDataTable.Rows[0][2]);
								strMessage.Append("</td>");
								strMessage.Append("<td><font size=3> Complainer Ph No:-" + oDataTable.Rows[0][5] );
								strMessage.Append("</td>");
								strMessage.Append("<td><font size=3> Complainer Mob No :-"+ oDataTable.Rows[0][6]);
								strMessage.Append("</td>");
								strMessage.Append("<td><font size=3>Complaint Side :-" + oDataTable.Rows[0][9]);
								strMessage.Append("</td>");
							strMessage.Append("</tr>");
						strMessage.Append("</table>");
					strMessage.Append("</td>");
				strMessage.Append("</tr>");
				strMessage.Append("<tr>");
					strMessage.Append("<td>");
						strMessage.Append("<table width=100% border=0 cellpadding=0 cellspacing=0  bordercolor=black align=left >");
							strMessage.Append("<tr>");
								strMessage.Append("<td><font size=3> Complaint Subject :- " + oDataTable.Rows[0][7]);
								strMessage.Append("</td>");
							strMessage.Append("</tr>");
						strMessage.Append("</table>");
					strMessage.Append("</td>");
				strMessage.Append("</tr>");
				strMessage.Append("<tr>");
					strMessage.Append("<td>");
						strMessage.Append("<table width=100% border=0 cellpadding=0 cellspacing=0  bordercolor=black align=left >");
							strMessage.Append("<tr>");
								strMessage.Append("<td align=center><font size=3> Complaint Detail :- ");
								strMessage.Append("</td>");
							strMessage.Append("</tr>");
						strMessage.Append("</table>");
					strMessage.Append("</td>");
				strMessage.Append("</tr>");
				strMessage.Append("<tr>");
					strMessage.Append("<td>");
						strMessage.Append("<table width=100% border=0 cellpadding=0 cellspacing=0  bordercolor=black align=left >");
							strMessage.Append("<tr>");
								strMessage.Append("<td><font size=3>"+ oDataTable.Rows[0][8]);
								strMessage.Append("</td>");
							strMessage.Append("</tr>");
						strMessage.Append("</table>");
					strMessage.Append("</td>");
				strMessage.Append("</tr>");
			strMessage.Append("</table>");
			strMessage.Append("</body>");

			/////////////////////////////////////////////////////////
//			string strMessage ="your complaint Registered successfully"; 

			oEmail.Body = strMessage.ToString ();
			oEmail.Priority = MailPriority.High;
			oEmail.BodyFormat =	MailFormat.Html;
			SmtpMail.SmtpServer.Insert(0,"10.22.19.06");
		
			try
			{
				SmtpMail.Send(oEmail);
			}
			catch(Exception)
			{
				return false;
			}
			return true;
		}

		public static StringBuilder createMail(string p_COMP_NO,string p_VENDOR_ID)
		{

			DataTable  oDataTable = new DataTable();
			oDataTable=getcomplaintdetail(p_COMP_NO);
			StringBuilder  mail = new StringBuilder ();

			mail.Append ("<body bottomMargin=0 leftMargin=0 topMargin=0 rightMargin=0 MS_POSITIONING=GridLayout>");
				mail.Append("<table width=100% border=0 cellpadding=1 cellspacing=1  bordercolor=black align=left >");
					mail.Append("<tr>");
						mail.Append("<td>");
							mail.Append("<table width=100% border=0 cellpadding=0 cellspacing=0  bordercolor=black align=left >");
								mail.Append("<tr>");
									mail.Append("<td align=center ><font size=5>E Help Desk");
									mail.Append("</td>");
								mail.Append("</tr>");
							mail.Append("</table>");
						mail.Append("</td>");
					mail.Append("</tr>");
					mail.Append("<tr>");
						mail.Append("<td>");
							mail.Append("<table width=100% border=0 cellpadding=1 cellspacing=1  bordercolor=black align=left >");
								mail.Append("<tr>");
									mail.Append("<td><font size=2>To : -" + getvenderName(p_VENDOR_ID) );
									mail.Append("</td>");
								mail.Append("</tr>");
							mail.Append("</table>");
						mail.Append("</td>");
					mail.Append("</tr>");
					mail.Append("<tr>");
						mail.Append("<td>");
							mail.Append("<table width=100% border=0 cellpadding=1 cellspacing=1  bordercolor=black align=left >");
								mail.Append("<tr>");
									mail.Append("<td><font size=2>Complaint No : -" + oDataTable.Rows[0][0]);
									mail.Append("</td>");
									mail.Append("<td><font size=2>Complaint Type : -" + oDataTable.Rows[0][1]);
									mail.Append("</td>");
									mail.Append("<td><font size=2>Complaint Site: -" + oDataTable.Rows[0][8]);
									mail.Append("</td>");
								mail.Append("</tr>");
							mail.Append("</table>");
						mail.Append("</td>");
					mail.Append("</tr>");
					mail.Append("<tr>");
						mail.Append("<td>");
							mail.Append("<table width=100% border=0 cellpadding=1 cellspacing=1  bordercolor=black align=left >");
								mail.Append("<tr>");
									mail.Append("<td><font size=2>Complaint Register time : -" + oDataTable.Rows[0][3]);
									mail.Append("</td>");
									mail.Append("<td><font size=2>Complainer Name : -" + oDataTable.Rows[0][2]);
									mail.Append("</td>");
									mail.Append("<td><font size=2>Complainer Ph No: -" + oDataTable.Rows[0][6]);
									mail.Append("</td>");
									mail.Append("<td><font size=2>Complainer Mob No: -" + oDataTable.Rows[0][7]);
									mail.Append("</td>");
								mail.Append("</tr>");
							mail.Append("</table>");
						mail.Append("</td>");
					mail.Append("</tr>");
					mail.Append("<tr>");
						mail.Append("<td>");
							mail.Append("<table width=100% border=0 cellpadding=1 cellspacing=1  bordercolor=black align=left >");
								mail.Append("<tr>");
									mail.Append("<td><font size=2>Complaint Subject: -" + oDataTable.Rows[0][8]);
									mail.Append("</td>");
								mail.Append("</tr>");
							mail.Append("</table>");
						mail.Append("</td>");
					mail.Append("</tr>");
					mail.Append("<tr>");
						mail.Append("<td>");
							mail.Append("<table width=100% border=0 cellpadding=1 cellspacing=1  bordercolor=black align=left >");
								mail.Append("<tr>");
									mail.Append("<td><font size=2 align=center >Complaint Detail: -");
									mail.Append("</td>");
								mail.Append("</tr>");
							mail.Append("</table>");
						mail.Append("</td>");
					mail.Append("</tr>");
					mail.Append("<tr>");
						mail.Append("<td>");
							mail.Append("<table width=100% border=0 cellpadding=1 cellspacing=1  bordercolor=black align=left >");
								mail.Append("<tr>");
									mail.Append("<td><font size=2>"+ oDataTable.Rows[0][9]);
									mail.Append("</td>");
								mail.Append("</tr>");
							mail.Append("</table>");
						mail.Append("</td>");
					mail.Append("</tr>");
					mail.Append("<tr>");
						mail.Append("<td>");
							mail.Append("<table width=100% border=0 cellpadding=1 cellspacing=1  bordercolor=black align=left >");
								mail.Append("<tr>");
									mail.Append("<td><font size=2>Site Address: -");
									mail.Append("</td>");
								mail.Append("</tr>");
							mail.Append("</table>");
						mail.Append("</td>");
					mail.Append("</tr>");
					mail.Append("<tr>");
						mail.Append("<td>");
							mail.Append("<table width=100% border=0 cellpadding=1 cellspacing=1  bordercolor=black align=left >");
								mail.Append("<tr>");
									mail.Append("<td><font size=2>" + oDataTable.Rows[0][14]);
									mail.Append("</td>");
								mail.Append("</tr>");
							mail.Append("</table>");
						mail.Append("</td>");
					mail.Append("</tr>");
					mail.Append("<tr>");
						mail.Append("<td>");
							mail.Append("<table width=100% border=0 cellpadding=1 cellspacing=1  bordercolor=black align=left >");
								mail.Append("<tr>");
									mail.Append("<td><font size=2>From : - E Help Desk");
									mail.Append("</td>");
								mail.Append("</tr>");
							mail.Append("</table>");
						mail.Append("</td>");
					mail.Append("</tr>");
					mail.Append("<tr>");
						mail.Append("<td>");
							mail.Append("<table width=100% border=0 cellpadding=1 cellspacing=1  bordercolor=black align=left >");
								mail.Append("<tr>");
									mail.Append("<td><font size=2>Name " + oDataTable.Rows[0][21]);
									mail.Append("</td>");
								mail.Append("</tr>");
							mail.Append("</table>");
						mail.Append("</td>");
					mail.Append("</tr>");
					mail.Append("<tr>");
						mail.Append("<td>");
							mail.Append("<table width=100% border=0 cellpadding=1 cellspacing=1  bordercolor=black align=left >");
								mail.Append("<tr>");
									mail.Append("<td><font size=2>Ph No:-" + oDataTable.Rows[0][22]);
									mail.Append("</td>");
									mail.Append("<td><font size=2>Mob No:-" + oDataTable.Rows[0][23]);
									mail.Append("</td>");
								mail.Append("</tr>");
							mail.Append("</table>");
						mail.Append("</td>");
					mail.Append("</tr>");
					mail.Append("<tr>");
						mail.Append("<td>");
							mail.Append("<table width=100% border=0 cellpadding=1 cellspacing=1  bordercolor=black align=left >");
								mail.Append("<tr>");
									mail.Append("<td><font size=2> Note :- Please Mark a Copy To RGTIL IT E-HELPDESK For all Further correspondence");
									mail.Append("</td>");
								mail.Append("</tr>");
							mail.Append("</table>");
						mail.Append("</td>");
					mail.Append("</tr>");
				mail.Append("</table>");
			mail.Append("</body>");
//			mail= "Complaint No :-" + oDataTable.Rows[0][0].ToString()+ "\r\n";
//			
//			mail = mail + " Complaint Type :-" + oDataTable.Rows[0][1].ToString()+ "\r\n";
//
//			mail = mail + "Complain Registered Date Time :-" + oDataTable.Rows[0][3].ToString()+ "\r\n";
// 
//			mail = mail + "Complainer Name :-" + oDataTable.Rows[0][2].ToString()+ "\r\n";
// 
//			mail = mail + "Complainer PH NO :-" + oDataTable.Rows[0][6].ToString()+ "," + oDataTable.Rows[0][7].ToString()+"\r\n";
//
//			mail = mail + "Complaint Handled By :-" + oDataTable.Rows[0][21]+"\r\n";
//
//			mail = mail + "PH NO :-" + oDataTable.Rows[0][22].ToString()+ "'" + oDataTable.Rows[0][23].ToString()+"\r\n";
//
//			mail = mail + "Site NAME :-"+ oDataTable.Rows[0][10].ToString();
//
//			mail = mail + "COMPLAINT SUBJECT :-" + oDataTable.Rows[0][8].ToString()+"\r\n";
//
//			mail = mail + " COMPLAIN DETAIL :- " + oDataTable.Rows[0][9].ToString()+"\r\n";

			return mail;

		}

		public static string getvendermailid(string p_VENDOR_ID)
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("select VENDOR_MAIL_ID from TBL_VENDOR where VENDOR_ID = '"+p_VENDOR_ID+"'");	
			if(oDataTable.Rows.Count > 0)
			{	
			}
			return oDataTable.Rows[0][0].ToString();
		}
		public static string getvenderName(string p_VENDOR_ID)
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("select VENDOR_NAME from TBL_VENDOR where VENDOR_ID = '"+p_VENDOR_ID+"'");	
			if(oDataTable.Rows.Count > 0)
			{	
			}
			return oDataTable.Rows[0][0].ToString();
		}
		public static string getsitemailid(string p_SITE_ID)
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("select SITE_LOTUS_NOTE_EMAIL from TBL_SITE_REGISTRATION where SITE_ID ='"+p_SITE_ID+"'");	
			if(oDataTable.Rows.Count > 0)
			{	
			}
			return oDataTable.Rows[0][0].ToString();
		}
		public static  DataTable getcomplaintdetail(string p_COMP_NO)
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("SELECT tbl_complain.comp_no, tbl_complain.comp_type, tbl_complain.complainer_name, tbl_complain.comp_reg_date_time, tbl_complain.comp_handle_by, tbl_complain.comp_status, tbl_complain.comp_phno, tbl_complain.complaner_phno, tbl_complain.cmpsub, tbl_complain.cmpdtl, tbl_site_registration.site_name,  tbl_site_registration.site_location_code, tbl_site_registration.site_location, tbl_site_registration.site_office_type, tbl_site_registration.site_loc_add, tbl_site_registration.site_cont_person_name, tbl_site_registration.site_cont_person_phno, tbl_site_registration.site_cont_no, tbl_site_registration.site_temp_nw_ip, tbl_site_registration.site_temp_gateway_ip, tbl_site_registration.site_temp_subnetmask, tbl_supt_user.user_name, tbl_supt_user.user_contact_no, tbl_supt_user.user_mob_no  FROM tbl_complain, tbl_site_registration, tbl_supt_user WHERE (((tbl_complain.comp_handle_by = tbl_supt_user.user_login_name) AND (tbl_complain.comp_site_id = tbl_site_registration.site_id)) AND (tbl_complain.comp_no = '"+p_COMP_NO+"'))");	
			if(oDataTable.Rows.Count > 0)
			{	
			}
			return oDataTable;
		}
		public static  DataTable getRegcmpdetail(string p_COMP_NO)
		{
			DataTable oDataTable =DALCommon.ExecuteDataTable("SELECT tbl_complain.comp_no, tbl_complain.comp_type, tbl_complain.complainer_name, tbl_complain.comp_reg_by, tbl_complain.comp_reg_date_time, tbl_complain.comp_phno, tbl_complain.complaner_phno, tbl_complain.cmpsub, tbl_complain.cmpdtl, tbl.site_name FROM tbl_complain, tbl_site_registration tbl WHERE ((tbl_complain.comp_site_id = tbl.site_id)AND (tbl_complain.comp_no = '"+p_COMP_NO+"'))");	
			if(oDataTable.Rows.Count > 0)
			{	
			}
			return oDataTable;
		}
	}
}
