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
    public partial class Injury : System.Web.UI.Page
    {
        int personcount;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TreeView MenuBrowser = (TreeView)Page.Master.FindControl("MenuBrowser");

                MenuBrowser.Nodes[0].Expanded = true;
                MenuBrowser.Nodes[0].ChildNodes[0].Select();

                personcount = Convert.ToInt32(Session["pc"]);
                PersonCountLabel.Text = personcount.ToString();
            }
            else
            {
                personcount = Convert.ToInt32(Session["pc"]);
            }
        }
        
        protected void CalButton_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Calendar1.Visible = false;
            DOB.Text = Calendar1.SelectedDate.Date.Day.ToString() + "/" + Calendar1.SelectedDate.Month.ToString() + "/" + Calendar1.SelectedDate.Year.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }
        
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton1.ImageUrl = "~/Images/SelectedTab2.jpg";
            LinkButton2.Font.Bold = true;

            LinkButton3.Font.Bold = false;
            ImageButton2.ImageUrl = "~/Images/UnSelectedTab2.jpg";

            MultiView1.ActiveViewIndex = 0;
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            ImageButton1.ImageUrl = "~/Images/SelectedTab2.jpg";
            LinkButton2.Font.Bold = true;

            LinkButton3.Font.Bold = false;
            ImageButton2.ImageUrl = "~/Images/UnSelectedTab2.jpg";

             MultiView1.ActiveViewIndex = 0;
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            ImageButton1.ImageUrl = "~/Images/UnSelectedTab2.jpg";
            LinkButton2.Font.Bold = false;

            LinkButton3.Font.Bold = true;
            ImageButton2.ImageUrl = "~/Images/SelectedTab2.jpg";
            MultiView1.ActiveViewIndex = 1;
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton1.ImageUrl = "~/Images/UnSelectedTab2.jpg";
            LinkButton2.Font.Bold = false;

            LinkButton3.Font.Bold = true;
            ImageButton2.ImageUrl = "~/Images/SelectedTab2.jpg";
            MultiView1.ActiveViewIndex = 1;
        }

        protected void PreviousButton_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("CreateIR.aspx");
        }

        protected void NextButton_Click(object sender, ImageClickEventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void PreviousButton2_Click(object sender, ImageClickEventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void NextButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ARM.aspx");
        }

        protected void CancelButton_Click(object sender, ImageClickEventArgs e)
        {
            ClientScript.RegisterClientScriptBlock(this.GetType(), "newWindow", "<script>alert(\"Close ??\");</script>");
        }
    }
}
