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

public partial class UI_AdminFolder_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            LoginTableAdapters.NHD_SITEDBTableAdapter a = new LoginTableAdapters.NHD_SITEDBTableAdapter();
            a.InsertSite(locationcodebox.Text, sitenamebox.Text, locationbox.Text, DropDownList1.Text, locationaddbox.Text, personnamebox.Text, Convert.ToDecimal(personphonebox.Text), emailbox.Text, networkipbox.Text, gatewayipbox.Text, submaskbox.Text);
        }
    }
}
