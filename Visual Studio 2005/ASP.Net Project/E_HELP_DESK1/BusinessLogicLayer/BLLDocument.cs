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
using E_HELP_DESK1.BusinessLogicLayer;
namespace E_HELP_DESK1.BusinessLogicLayer
{
	/// <summary>
	/// Summary description for BLLDocument.
	/// </summary>
	public class BLLDocument
	{
		public BLLDocument()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		#region GetDocTitle
	

		public   DataSet GetDocFileinfo()
		{
			OracleParameter oOracleParemeter;
			
			//DataSet  oDataSet = DALCommon.ExecuteDataSet("SELECT tbl_fileinfo.sno, tbl_user.username, tbl.rolename, tbl_state.sname,tbl_dist.dname, tbl_taluk.talukname, tbl_village.vname,tbl_fileinfo.uploadedby, tbl_fileinfo.downloadedby,tbl_fileinfo.uploadfname, tbl_fileinfo.downloadfname,tbl_fileinfo.status, tbl_fileinfo.remarks  FROM tbl_fileinfo,tbl_state,tbl_dist,tbl_taluk,tbl_village, tbl_user tbl_user,tbl_userrole tbl  WHERE   (tbl_user.userid=1) and (    (tbl_fileinfo.SID = tbl_state.SID) AND (tbl_fileinfo.did = tbl_dist.did) AND (tbl_fileinfo.tid = tbl_taluk.tid)AND (tbl_fileinfo.vid = tbl_village.vid) AND (tbl_fileinfo.userid = tbl_user.userid) AND (tbl_fileinfo.roleid = tbl.roleid))");
			//DataSet  oDataSet =DALCommon.ExecuteDataSet("SELECT tbl_fileinfo.sno, tbl_user.username, tbl.rolename, tbl_state.sname,tbl_dist.dname, tbl_taluk.talukname, tbl_village.vname,tbl_fileinfo.uploadedby, tbl_fileinfo.downloadedby,tbl_fileinfo.uploadfname, tbl_fileinfo.downloadfname,tbl_fileinfo.status, tbl_fileinfo.remarks  FROM tbl_fileinfo,tbl_state,tbl_dist,tbl_taluk,tbl_village, tbl_user tbl_user,tbl_userrole tbl  WHERE   (tbl_user.userid=1) and (    (tbl_fileinfo.SID = '" + std + "') AND (tbl_fileinfo.did = '" + dtc + "') AND (tbl_fileinfo.tid = '" + thc + "')AND (tbl_fileinfo.vid = '" + vlc + "'");
			OracleCommand cmd=new OracleCommand();
			OracleDataAdapter ad=new OracleDataAdapter();
			
			DataSet oDataSet=new DataSet();
			//cmd.CommandText="SELECT tbl_fileinfo.sno, tbl_user.username, tbl.rolename, tbl_state.sname,tbl_dist.dname, tbl_taluk.talukname, tbl_village.vname,tbl_fileinfo.uploadedby, tbl_fileinfo.downloadedby,tbl_fileinfo.uploadfname, tbl_fileinfo.downloadfname,tbl_fileinfo.status, tbl_fileinfo.remarks  FROM tbl_fileinfo,tbl_state,tbl_dist,tbl_taluk,tbl_village, tbl_user tbl_user,tbl_userrole tbl  WHERE   (tbl_user.userid=1) and (    (tbl_fileinfo.SID = '" + std + "') AND (tbl_fileinfo.did = '" + dtc + "') AND (tbl_fileinfo.tid = '" + thc + "')AND (tbl_fileinfo.vid = '" + vlc + "'";
			cmd.CommandText="SELECT TBL_USER.USERNAME, TBL_FILEINFO.FNAME, TBL_FILEINFO.UDATE, TBL_FILEINFO.STATUS, TBL_FILEINFO.REMARKS, TBL_FILEINFO.FPATH,TBL_FILEINFO.SID, TBL_FILEINFO.DID, TBL_FILEINFO.TID, TBL_FILEINFO.VID FROM TBL_FILEINFO INNER JOIN TBL_USER ON TBL_FILEINFO.USERID = TBL_USER.USERID INNER JOIN TBL_USERROLE ON TBL_USER.ROLEID = TBL_USERROLE.ROLEID WHERE     (TBL_FILEINFO.SID = 1) AND (TBL_FILEINFO.DID = 1) AND (TBL_FILEINFO.TID = 1) AND (TBL_FILEINFO.VID = 1)";
			ad.SelectCommand=cmd;
			ad.Fill(oDataSet);
			return  oDataSet;
		}
		
		public   DataSet GetDocFileinfo(string std,string dtc,string thc,string vlc)
		{
			//OracleParameter oOracleParemeter;
			
			//DataSet  oDataSet = DALCommon.ExecuteDataSet("SELECT tbl_fileinfo.sno, tbl_user.username, tbl.rolename, tbl_state.sname,tbl_dist.dname, tbl_taluk.talukname, tbl_village.vname,tbl_fileinfo.uploadedby, tbl_fileinfo.downloadedby,tbl_fileinfo.uploadfname, tbl_fileinfo.downloadfname,tbl_fileinfo.status, tbl_fileinfo.remarks  FROM tbl_fileinfo,tbl_state,tbl_dist,tbl_taluk,tbl_village, tbl_user tbl_user,tbl_userrole tbl  WHERE   (tbl_user.userid=1) and (    (tbl_fileinfo.SID = tbl_state.SID) AND (tbl_fileinfo.did = tbl_dist.did) AND (tbl_fileinfo.tid = tbl_taluk.tid)AND (tbl_fileinfo.vid = tbl_village.vid) AND (tbl_fileinfo.userid = tbl_user.userid) AND (tbl_fileinfo.roleid = tbl.roleid))");
			//DataSet  oDataSet =DALCommon.ExecuteDataSet("SELECT tbl_fileinfo.sno, tbl_user.username, tbl.rolename, tbl_state.sname,tbl_dist.dname, tbl_taluk.talukname, tbl_village.vname,tbl_fileinfo.uploadedby, tbl_fileinfo.downloadedby,tbl_fileinfo.uploadfname, tbl_fileinfo.downloadfname,tbl_fileinfo.status, tbl_fileinfo.remarks  FROM tbl_fileinfo,tbl_state,tbl_dist,tbl_taluk,tbl_village, tbl_user tbl_user,tbl_userrole tbl  WHERE   (tbl_user.userid=1) and (    (tbl_fileinfo.SID = '" + std + "') AND (tbl_fileinfo.did = '" + dtc + "') AND (tbl_fileinfo.tid = '" + thc + "')AND (tbl_fileinfo.vid = '" + vlc + "'");
			OracleCommand cmd=new OracleCommand();
			OracleDataAdapter ad=new OracleDataAdapter();
			
			DataSet oDataSet=new DataSet();
			cmd.CommandText="SELECT tbl_fileinfo.sno, tbl_user.username, tbl.rolename, tbl_state.sname,tbl_dist.dname, tbl_taluk.talukname, tbl_village.vname,tbl_fileinfo.uploadedby, tbl_fileinfo.downloadedby,tbl_fileinfo.uploadfname, tbl_fileinfo.downloadfname,tbl_fileinfo.status, tbl_fileinfo.remarks  FROM tbl_fileinfo,tbl_state,tbl_dist,tbl_taluk,tbl_village, tbl_user tbl_user,tbl_userrole tbl  WHERE   (tbl_user.userid=1) and (    (tbl_fileinfo.SID = '" + std + "') AND (tbl_fileinfo.did = '" + dtc + "') AND (tbl_fileinfo.tid = '" + thc + "')AND (tbl_fileinfo.vid = '" + vlc + "'";
			ad.SelectCommand=cmd;
			//ad.Fill(oDataSet,"SELECT tbl_fileinfo.sno, tbl_user.username, tbl.rolename, tbl_state.sname,tbl_dist.dname, tbl_taluk.talukname, tbl_village.vname,tbl_fileinfo.uploadedby, tbl_fileinfo.downloadedby,tbl_fileinfo.uploadfname, tbl_fileinfo.downloadfname,tbl_fileinfo.status, tbl_fileinfo.remarks  FROM tbl_fileinfo,tbl_state,tbl_dist,tbl_taluk,tbl_village, tbl_user tbl_user,tbl_userrole tbl  WHERE   (tbl_user.userid=1) and (    (tbl_fileinfo.SID = '" + std + "') AND (tbl_fileinfo.did = '" + dtc + "') AND (tbl_fileinfo.tid = '" + thc + "')AND (tbl_fileinfo.vid = '" + vlc + "'");
			ad.Fill(oDataSet);
			//DataSet  oDataSet =DALCommon.ExecuteDataSet(oOracleParemeter,"SELECT tbl_fileinfo.sno, tbl_user.username, tbl.rolename, tbl_state.sname,tbl_dist.dname, tbl_taluk.talukname, tbl_village.vname,tbl_fileinfo.uploadedby, tbl_fileinfo.downloadedby,tbl_fileinfo.uploadfname, tbl_fileinfo.downloadfname,tbl_fileinfo.status, tbl_fileinfo.remarks  FROM tbl_fileinfo,tbl_state,tbl_dist,tbl_taluk,tbl_village, tbl_user tbl_user,tbl_userrole tbl  WHERE   (tbl_user.userid=1) and (    (tbl_fileinfo.SID = '" + std + "') AND (tbl_fileinfo.did = '" + dtc + "') AND (tbl_fileinfo.tid = '" + thc + "')AND (tbl_fileinfo.vid = '" + vlc + "'");
			return  oDataSet;
		}

		#endregion
		#region GetDocRev
		public   DataTable GetDocRev(string phtable,string docnum)
		{
			
			DataTable oDataTable = DALCommon.ExecuteDataTable("SELECT DocRev FROM " + phtable + " WHERE docNum='" + docnum + "'");
			return oDataTable;
		}
		#endregion

	
	}
}
