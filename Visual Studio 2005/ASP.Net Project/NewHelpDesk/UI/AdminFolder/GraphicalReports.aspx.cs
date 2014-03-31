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

    }

    protected void resetbutton_Click(object sender, EventArgs e)
    {
        Calendar1.Visible = false;
        Calendar2.Visible = false;
        fromdatebox.Text = "";
        todatebox.Text = "";

        Label17.Visible = false;
        Label18.Visible = false;
        Label3.Visible = false;
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Calendar1.Visible = true;
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Calendar2.Visible = true;
    }

    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        todatebox.Text = Calendar2.SelectedDate.ToShortDateString();
        Calendar2.Visible = false;
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        fromdatebox.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = false;
    }
    protected void submitbutton_Click(object sender, EventArgs e)
    {
        int counter1 = 0;
        int counter2 = 0;
        int counter3 = 0;

        if (fromdatebox.Text == "")
        {
            counter1 = 0;
            Label17.Visible = true;
        }
        else
        {
            counter1 = 1;
            Label17.Visible = false;
        }
        if (todatebox.Text == "")
        {
            counter2 = 0;
            Label18.Visible = true;
        }
        else
        {
            counter2 = 1;
            Label18.Visible = false;
        }
        if (engnamebox.Text == "")
        {
            counter3 = 0;
            Label3.Visible = true;
        }
        else
        {
            counter3 = 1;
            Label3.Visible = false;
        }

        if ((counter1 == 1) && (counter2 == 1) && (counter3 == 1))
        {
        }
    }
}
