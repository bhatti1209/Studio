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

public partial class UI_AdminFolder_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Appsession temp = (Appsession)Session["p_loginsession"];
        Hidden1.Value = temp.getusername();
        probdescbox.Visible = false;

        if (IsPostBack)
        {
            int counter1 = 0;
            int counter2 = 0;

            if (DropDownList1.Text == "")
            {
                Label4.Visible = true;
                counter1 = 0;
            }
            else
            {
                Label4.Visible = false;
                counter1 = 1;
            }

            if (DropDownList2.Text == "")
            {
                Label5.Visible = true;
                counter2 = 0;
            }
            else
            {
                Label5.Visible = false;
                counter2 = 1;
            }

            if ((counter1 == 1) && (counter2 == 1))  
            {
                GridView1.Visible = true;

                if (DropDownList1.Text != "All" && DropDownList2.Text == "All")
                    GridView1.DataSourceID = "helpdeskselected";
                if (DropDownList1.Text == "All" && DropDownList2.Text != "All")
                    GridView1.DataSourceID = "callstatusselected";
                if (DropDownList1.Text != "All" && DropDownList2.Text != "All")
                    GridView1.DataSourceID = "bothselected";
                if (DropDownList1.Text == "All" && DropDownList2.Text == "All")
                    GridView1.DataSourceID = "noneselected";
            }
        }
    }
    protected void ResetButton_Click(object sender, EventArgs e)
    {
        DropDownList1.SelectedIndex = 0;
        DropDownList2.SelectedIndex = 0;
        Label4.Visible = false;
        Label5.Visible = false;

        GridView1.Visible = false;
        probdescbox.Visible = false;
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        probdescbox.Visible = true;
        int ind = GridView1.SelectedIndex;

        GridViewRowCollection a = GridView1.Rows;
        string refid = a[ind].Cells[0].Text;
        
        LoginTableAdapters.NHD_CMPTBLTableAdapter c = new LoginTableAdapters.NHD_CMPTBLTableAdapter();
        probdescbox.Text = c.GetProbDesc(refid);
    }
}
