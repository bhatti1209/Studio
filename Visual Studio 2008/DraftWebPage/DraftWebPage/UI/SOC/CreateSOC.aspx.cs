using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DraftWebPage.UI.SOC
{
    public partial class CreateSOC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TreeView MenuBrowser = (TreeView)Page.Master.FindControl("MenuBrowser");

                MenuBrowser.CollapseAll();
                MenuBrowser.Nodes[1].Expanded = true;
                MenuBrowser.Nodes[1].ChildNodes[0].Select();
            }
        }
    }
}
