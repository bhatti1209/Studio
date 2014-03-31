using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for Appsession
/// </summary>
public class Appsession
{
     string loginid;
     string usertype;
     string username;
     string ticketid;

	public Appsession()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void setloginid(string f_loginid, string f_usertype)
    {
        loginid = f_loginid;
        usertype = f_usertype;
    }

    public void setusername(string f_username)
    {
        username = f_username;
    }

    public string  getloginid()
    {
        return loginid;
    }

    public string getusername()
    {
        return username;
    }

    public string gettckid()
    {
        return ticketid;
    }

    public void settckid(string tck)
    {
        ticketid = tck;
    }
}
