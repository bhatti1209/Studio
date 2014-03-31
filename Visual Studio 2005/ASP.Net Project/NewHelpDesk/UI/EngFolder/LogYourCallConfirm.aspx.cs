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
        Appsession temp = (Appsession)Session["p_loginsession"];
        ticketidlabel.Text = temp.gettckid();
        Label12.Text = Convert.ToString(DateTime.Now.Date.ToShortDateString());

        if (IsPostBack)
        {
            if (CheckBox1.Checked == true)
                assignbox.Enabled = true;
            else
                assignbox.Enabled = false;
        }
    }
    protected void Assignbutton_Click(object sender, EventArgs e)
    {
        string temp;
        int counter = 0;

        LoginTableAdapters.NHD_CMPTBLTableAdapter a = new LoginTableAdapters.NHD_CMPTBLTableAdapter();

        if (CheckBox1.Checked == true)
        {
            temp = assignbox.Text;
            counter = 1;
        }
        else
        {
            temp = "";
            counter = 0;
        }

        a.UpdateAssign(temp, ticketidlabel.Text);

        if (counter == 1)
            a.UpdateStatus("Assigned", ticketidlabel.Text);

        Page.RegisterStartupScript("k1", "<script language=javascript> alert(\" Your Call Has Been Logged, Thank You !! \");</script>");

        Assignbutton.Enabled = false;
    }
}
