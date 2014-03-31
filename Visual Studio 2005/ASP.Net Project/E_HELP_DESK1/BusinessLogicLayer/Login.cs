using System;
using System.Collections.Specialized;
using System.Web;
using System.Web.SessionState;
using System.Data;
using System.Data.OracleClient;
using E_HELP_DESK1.DataAccessLayer;

namespace E_HELP_DESK1.BusinessLogicLayer
{
	/// <summary>
	/// Summary description for Bll_Login.
	/// </summary>
	public class Login
	{
		#region constructor
		public Login()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		#endregion
		#region PROPERTY
		#region PROPERTY DECLARATION
		private bool _isValidUser=false;
		private string _username="";
		private string _password="";
		private string _userid="";
		#endregion

		#region PROPERTY DEFINITION

		public bool IsValidUser
		{
			get
			{
				return _isValidUser;
			}

			set
			{
				_isValidUser=value;
			}
		}
		public string Username
		{
			get
			{
				return _username;
			}

			set
			{
				_username=value;
			}
		}
		public string Password
		{
			get
			{
				return _password;
			}

			set
			{
				_password=value;
			}
		}
		public string UserId
		{
			get
			{
				return _userid;
			}

			set
			{
				_userid=value;
			}
		}
		
		#endregion
		#endregion
		#region AUTHENTICATE USER
		
		public int AuthenticateUser()
		{
			string Pwd = "";
			int Status = 0;
			//-------------------------------------------------------//
			NameValueCollection InputParams = new NameValueCollection();
			
			InputParams.Add("username",_username);
			InputParams.Add("pwd",_password);
			bool Chk = DataAccessLogin.AuthenticateUser(InputParams);


			
			OracleDataReader sdrMemberInfo = DataAccessLogin.GetUserLoginInfo(InputParams);
			//------------------------------------------------------//
			E_HELP_DESK1.DATAOBJECTS.MemberData oMemberData = new E_HELP_DESK1.DATAOBJECTS.MemberData();

			if(sdrMemberInfo != null && sdrMemberInfo.HasRows == true)
			{
				Status = 1;
				sdrMemberInfo.Read();
								
				oMemberData.Username = sdrMemberInfo["USERNAME"].ToString();
				oMemberData.RoleID = sdrMemberInfo["ROLEID"].ToString();
				oMemberData.RoleName  = sdrMemberInfo["RoleName"].ToString();
				oMemberData.UserId = sdrMemberInfo["USERID"].ToString();
				Pwd = sdrMemberInfo["USERPASSWORD"].ToString();
                oMemberData.DisplayName  = sdrMemberInfo["DisplayName"].ToString();
			
			}
			
			//-----------------------------------------------------//
			int Result=0;
			switch(Status)
			{
				case 1:					
					
					if(Pwd == _password )
					{
						if (oMemberData.RoleID == "1") {Result =1;}
						if (oMemberData.RoleID == "2") {Result =2;}
						if (oMemberData.RoleID == "3") {Result =3;}
						if (oMemberData.RoleID == "4") {Result =4;}
						HttpContext.Current.Session["MemberData"] = oMemberData;
						SessionInfo.Role =oMemberData.RoleID ;
						SessionInfo.DisplayName =oMemberData.DisplayName ;
					}
					else
						Result = 0;
					break;
				
				case 0:
					Result = 0;
					break;
			}
			return Result; 
			//----------------------------------------------------//
			
		}
		#endregion
	}
}
