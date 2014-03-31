using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class UI_Login_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            LoginTableAdapters.NHD_LOGINTableAdapter a = new LoginTableAdapters.NHD_LOGINTableAdapter();
            int t = Convert.ToInt32(a.ConfirmLogin(TextBox1.Text, TextBox2.Text));

            if (t > 0)
            {
                LoginTableAdapters.LoginTableAdapter b = new LoginTableAdapters.LoginTableAdapter();
                string type = b.GetLoginType(TextBox1.Text);
                string username = b.GetUsername(TextBox1.Text);

                Appsession logon = new Appsession();
                logon.setloginid(TextBox1.Text, type);
                logon.setusername(username);
                Session["p_loginsession"] = logon;

                if (type == "Admin")
                    Response.Redirect("http://localhost:1658/NewHelpDesk/UI/AdminFolder/WelcomePage.aspx");

                if (type == "User")
                    Response.Redirect("http://localhost:1658/NewHelpDesk/UI/UserFolder/WelcomePage.aspx");

                if (type == "ITEng")
                    Response.Redirect("http://localhost:1658/NewHelpDesk/UI/EngFolder/WelcomePage.aspx");
            }
            else
            {
                Page.RegisterStartupScript("k1", "<script language=javascript> alert(\" Username/Password Incorrect !! \");</script>"); 
            }
        }
    }
}
