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
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Button a = (Button)GridView1.Rows[GridView1.SelectedIndex].Cells[5].FindControl("Button2");
        a.Visible = true;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        LoginTableAdapters.NHD_VENDORDBTableAdapter a = new LoginTableAdapters.NHD_VENDORDBTableAdapter();

        TextBox t1 = (TextBox)GridView1.Rows[GridView1.SelectedIndex].Cells[1].FindControl("TextBox1");
        TextBox t2 = (TextBox)GridView1.Rows[GridView1.SelectedIndex].Cells[2].FindControl("TextBox2");
        TextBox t3 = (TextBox)GridView1.Rows[GridView1.SelectedIndex].Cells[3].FindControl("TextBox3");
        TextBox t4 = (TextBox)GridView1.Rows[GridView1.SelectedIndex].Cells[4].FindControl("TextBox4");
        LinkButton t5 = (LinkButton)GridView1.Rows[GridView1.SelectedIndex].Cells[0].FindControl("LinkButton1");

        string name = t5.Text;
        string email = t1.Text;
        decimal cn1 = Convert.ToDecimal(t2.Text);
        decimal cn2 = Convert.ToDecimal(t3.Text);
        string address1 = t4.Text;

        a.UpdateTBL(address1, email, cn1, cn2, name);
        GridView1.DataBind();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        LinkButton t5 = (LinkButton)GridView1.Rows[GridView1.SelectedIndex].Cells[0].FindControl("LinkButton1");
        string name = t5.Text;

        LoginTableAdapters.NHD_VENDORDBTableAdapter a = new LoginTableAdapters.NHD_VENDORDBTableAdapter();
        a.DeleteVendor(name);

        GridView1.DataBind();
    }
}
