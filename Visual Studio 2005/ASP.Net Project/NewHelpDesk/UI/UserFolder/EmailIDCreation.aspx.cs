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
        Datetextbox.Text = DateTime.Today.ToShortDateString();

        if (!IsPostBack)
        {
            DropDownList1.DataBind();
            DropDownList4.Items.Add(" ");

            for (int q = 0; q < DropDownList1.Items.Count; q++)
            {
                DropDownList4.Items.Add(DropDownList1.Items[q].ToString());
            }
        }


        if (IsPostBack)
        {
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;

            if (DropDownList4.Text == "")
            {
                counter1 = 0;
                Label10.Visible = true;
            }
            else
            {
                counter1 = 1;
                Label10.Visible = false;
            }

            if (suggestednamebox.Text == "")
            {
                counter2 = 0;
                Label12.Visible = true;
            }
            else
            {
                counter2 = 1;
                Label12.Visible = false;
            }

            if (DropDownList3.Text == "")
            {
                counter3 = 0;
                Label13.Visible = true;
            }
            else
            {
                counter3 = 1;
                Label13.Visible = false;
            }

            if (forwardbox.Text == "")
            {
                counter4 = 0;
                Label14.Visible = true;
            }
            else
            {
                counter4 = 1;
                Label14.Visible = false;
            }

            if ((counter1 == 1) && (counter2 == 1) && (counter3 == 1) && (counter4 == 1))
            {
            }
        }
    }
    protected void resetbutton_Click(object sender, EventArgs e)
    {
        suggestednamebox.Text = "";
        forwardbox.Text = "";
        DropDownList2.SelectedIndex = 0;
        DropDownList3.SelectedIndex = 0;
        DropDownList4.SelectedIndex = 0;
        Label10.Visible = false;
        Label12.Visible = false;
        Label13.Visible = false;
        Label14.Visible = false;
    }
}
