using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

namespace DraftWebPage.UI.IncidentReport
{
    public partial class PRM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TreeView MenuBrowser = (TreeView)Page.Master.FindControl("MenuBrowser");

                MenuBrowser.Nodes[0].Expanded = true;
                MenuBrowser.Nodes[0].ChildNodes[0].Select();
            }
        }

        protected void PreviousButton_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ARM.aspx");
        }

        protected void NextButton_Click(object sender, ImageClickEventArgs e)
        {
            ClientScript.RegisterClientScriptBlock(this.GetType(), "newWindow", "<script>alert(\"Your Complain Has Been Logged !!\");</script>");
            //Response.Redirect("HomePage.aspx");
        }

        protected void CancelButton_Click(object sender, ImageClickEventArgs e)
        {
            ClientScript.RegisterClientScriptBlock(this.GetType(), "newWindow", "<script>alert(\"Close ??\");</script>");
        }
    }
}
