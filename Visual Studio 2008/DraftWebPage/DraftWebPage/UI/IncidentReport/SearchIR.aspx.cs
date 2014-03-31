using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DraftWebPage.UI.IncidentReport
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TreeView MenuBrowser = (TreeView)Page.Master.FindControl("MenuBrowser");

                MenuBrowser.Nodes[0].Expanded = true;
                MenuBrowser.Nodes[0].ChildNodes[1].Select();
            }
        }
    }
}
