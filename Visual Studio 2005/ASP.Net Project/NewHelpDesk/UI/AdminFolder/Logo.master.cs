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

public partial class UI_Logo : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Appsession logon = (Appsession)Session["p_loginsession"];
        Namelabel.Visible = true;
        Namelabel.Text = logon.getusername();
    }
}
