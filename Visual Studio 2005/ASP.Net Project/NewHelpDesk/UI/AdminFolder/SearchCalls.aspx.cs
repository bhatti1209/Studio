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
            int counter = 0;

            if (refidbox.Text == "")
            {
                Label2.Visible = true;
                counter = 0;
            }
            else
            {
                Label2.Visible = false;
                counter = 1;
            }

            if (counter == 1)
            {
                GridView1.Visible = true;
                probdescbox.Visible = false;
            }
        }
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
