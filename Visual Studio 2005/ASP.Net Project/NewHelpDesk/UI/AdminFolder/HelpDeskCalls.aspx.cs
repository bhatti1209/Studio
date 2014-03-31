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
using System.IO;

public partial class UI_AdminFolder_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList4.DataBind();
            DropDownList6.Items.Add("");

            for (int q = 0; q < DropDownList4.Items.Count; q++)
            {
                DropDownList6.Items.Add(DropDownList4.Items[q].ToString());
            }
        }

        if (IsPostBack)
        {
            if (DropDownList1.Text == "IT-Enterprise Server")
            {
                DropDownList2.DataSourceID = "AccessDataSourceSC1";
                DropDownList2.DataTextField = "column1";
                DropDownList2.DataValueField = "column1";
                DropDownList1.Text = "IT-Enterprise Server";
            }
            else if (DropDownList1.Text == "IT-Intel Server")
            {
                DropDownList2.DataSourceID = "AccessDataSourceSC3";
                DropDownList2.DataTextField = "column1";
                DropDownList2.DataValueField = "column1";
                DropDownList1.Text = "IT-Intel Server";
            }
            else if (DropDownList1.Text == "IT-Hardware")
            {
                DropDownList2.DataSourceID = "AccessDataSourceSC2";
                DropDownList2.DataTextField = "column1";
                DropDownList2.DataValueField = "column1";
                DropDownList1.Text = "IT-Hardware";
            }
            else if (DropDownList1.Text == "IT-Networking")
            {
                DropDownList2.DataSourceID = "AccessDataSourceSC4";
                DropDownList2.DataTextField = "column1";
                DropDownList2.DataValueField = "column1";
                DropDownList1.Text = "IT-Networking";
            }
            else if (DropDownList1.Text == "IT-Telecom")
            {
                DropDownList2.DataSourceID = "AccessDataSourceSC5";
                DropDownList2.DataTextField = "column1";
                DropDownList2.DataValueField = "column1";
                DropDownList1.Text = "IT-Telecom";
            }
            else if (DropDownList1.Text == "IT-Software")
            {
                DropDownList2.DataSourceID = "AccessDataSourceSC6";
                DropDownList2.DataTextField = "column1";
                DropDownList2.DataValueField = "column1";
                DropDownList1.Text = "IT-Software";
            }
            else if (DropDownList1.Text == "All")
            {
                DropDownList2.SelectedIndex = 0;
                DropDownList2.DataSourceID = "";
                DropDownList2.DataTextField = "";
                DropDownList2.DataValueField = "";
                int count1 = DropDownList2.Items.Count;
                for (int q = 0; q < count1; q++)
                    DropDownList2.Items.RemoveAt(0);
                DropDownList2.Items.Add("All");
                DropDownList1.Text = "All";
            }
        }
    }
    protected void resetbutton_Click(object sender, EventArgs e)
    {
        DropDownList1.SelectedIndex = 0;
        DropDownList2.SelectedIndex = 0;
        DropDownList3.SelectedIndex = 0;
        DropDownList6.SelectedIndex = 0;
        GridView1.DataSourceID = "";
        GridView1.Visible = false;
        assignbutton.Visible = false;
        probdescbox.Visible = false;

        downloadbutton.Visible = false;
        downloadbutton.Enabled = false;
        Label5.Visible = false;
        Label6.Visible = false;
        Label7.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int counter1 = 0;
        int counter2 = 0;
        int counter3 = 0;

        if (DropDownList1.Text == "")
        {
            Label5.Visible = true;
            counter1 = 0;
        }
        else
        {
            Label5.Visible = false;
            counter1 = 1;
        }

        if (DropDownList2.Text == "")
        {
            Label6.Visible = true;
            counter2 = 0;
        }
        else
        {
            Label6.Visible = false;
            counter2 = 1;
        }

        if (DropDownList3.Text == "")
        {
            Label7.Visible = true;
            counter3 = 0;
        }
        else
        {
            Label7.Visible = false;
            counter3 = 1;
        }

        if ((counter1 == 1)&&(counter2==1)&&(counter3==1))
        {
            GridView1.Visible = true;

            if (DropDownList6.Text == "")
            {
                if (DropDownList1.Text == "All" && DropDownList3.Text == "All")
                    GridView1.DataSourceID = "noneselected1";
                if (DropDownList1.Text == "All" && DropDownList3.Text != "All")
                    GridView1.DataSourceID = "statusselected1";
                if (DropDownList1.Text != "All" && DropDownList3.Text == "All")
                    GridView1.DataSourceID = "categoryselected1";
                if (DropDownList1.Text != "All" && DropDownList3.Text != "All")
                    GridView1.DataSourceID = "bothselected1";
            }
            else
            {
                if (DropDownList1.Text == "All" && DropDownList3.Text == "All")
                    GridView1.DataSourceID = "noneselected2";
                if (DropDownList1.Text == "All" && DropDownList3.Text != "All")
                    GridView1.DataSourceID = "statusselected2";
                if (DropDownList1.Text != "All" && DropDownList3.Text == "All")
                    GridView1.DataSourceID = "categoryselected2";
                if (DropDownList1.Text != "All" && DropDownList3.Text != "All")
                    GridView1.DataSourceID = "bothselected2";
            }

            assignbutton.Visible = true;
            GridView1.DataBind();

            for (int q = 0; q < GridView1.Rows.Count; q++)
            {
                CheckBox temp = (CheckBox)GridView1.Rows[q].Cells[0].FindControl("CheckBox1");

                if (GridView1.Rows[q].Cells[5].Text == "Open")
                    temp.Enabled = true;
                else
                {
                    temp.Enabled = false;
                    DropDownList t1 = (DropDownList)GridView1.Rows[q].Cells[4].FindControl("DropDownList5");
                    t1.Enabled = false;
                }
            }
        }
    }

    protected void assignbutton_Click(object sender, EventArgs e)
    {
        int counter = 0;

        for (int q = 0; q < GridView1.Rows.Count; q++)
        {
            CheckBox temp = (CheckBox)GridView1.Rows[q].Cells[0].FindControl("CheckBox1");

            if (temp.Checked == true)
            {
                DropDownList t1 = (DropDownList)GridView1.Rows[q].Cells[1].FindControl("DropDownList5");
                string ticket = GridView1.Rows[q].Cells[1].Text;

                LoginTableAdapters.NHD_CMPTBLTableAdapter a = new LoginTableAdapters.NHD_CMPTBLTableAdapter();
                a.UpdateAssign(t1.Text, ticket);
                a.UpdateStatus("Assigned", ticket);
                counter = 1;
            }
        }

        if (counter == 1)
        {
            Page.RegisterStartupScript("k1", "<script language=javascript> alert(\"  Job(s) Assigned  !! \");</script>");
            GridView1.DataBind();
            for (int q = 0; q < GridView1.Rows.Count; q++)
            {
                CheckBox temp = (CheckBox)GridView1.Rows[q].Cells[0].FindControl("CheckBox1");

                if (GridView1.Rows[q].Cells[5].Text == "Open")
                    temp.Enabled = true;
                else
                {
                    temp.Enabled = false;
                    DropDownList t1 = (DropDownList)GridView1.Rows[q].Cells[4].FindControl("DropDownList5");
                    t1.Enabled = false;
                }
            }
        }
    }
    
    protected void  LinkButton1_Click(object sender, EventArgs e)
    {
        probdescbox.Visible = true;
        downloadbutton.Visible = true;
        int ind = GridView1.SelectedIndex;

        GridViewRowCollection a = GridView1.Rows;
        string refid = a[ind].Cells[1].Text;

        LoginTableAdapters.NHD_CMPTBLTableAdapter c = new LoginTableAdapters.NHD_CMPTBLTableAdapter();
        probdescbox.Text = c.GetProbDesc(refid);

        byte[] data = c.GetFileData(refid);

        if (data != null)
            downloadbutton.Enabled = true;
    }
    protected void downloadbutton_Click(object sender, EventArgs e)
    {
        int ind = GridView1.SelectedIndex;

        GridViewRowCollection a1 = GridView1.Rows;
        string refid = a1[ind].Cells[1].Text;

        LoginTableAdapters.NHD_CMPTBLTableAdapter a = new LoginTableAdapters.NHD_CMPTBLTableAdapter();
        byte[] data = a.GetFileData(refid);

        string path = "C:\\Helpdek.jpeg";
        FileStream newfile = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
        newfile.Write(data, 0, data.Length);
        newfile.Close();
    }
}
