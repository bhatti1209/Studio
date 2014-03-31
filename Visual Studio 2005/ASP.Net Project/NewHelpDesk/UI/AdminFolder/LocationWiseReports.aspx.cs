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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

public partial class UI_AdminFolder_Default : System.Web.UI.Page
{
    ReportDocument rpt;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList4.DataBind();
            DropDownList6.Items.Add("All");

            for (int q = 0; q < DropDownList4.Items.Count; q++)
            {
                DropDownList6.Items.Add(DropDownList4.Items[q].ToString());
            }
        }

        if (DropDownList1.Text == "All")
        {
            DropDownList2.SelectedIndex = 0;
            DropDownList3.SelectedIndex = 0;
            DropDownList2.DataSourceID = "";
            DropDownList2.DataTextField = "";
            DropDownList2.DataValueField = "";
            int count = DropDownList2.Items.Count;
            for (int q = 0; q < count; q++)
                DropDownList2.Items.RemoveAt(0);
            DropDownList2.Items.Add("All");

            int count3 = DropDownList7.Items.Count;
            for (int q3 = 0; q3 < count3; q3++)
                DropDownList7.Items.RemoveAt(0);
            DropDownList7.Items.Add("All");

            DropDownList3.DataSourceID = "";
            DropDownList3.DataTextField = "";
            DropDownList3.DataValueField = "";
            DropDownList2.Text = "All";
            int count1 = DropDownList3.Items.Count;
            for (int q = 0; q < count1; q++)
                DropDownList3.Items.RemoveAt(0);
            DropDownList3.Items.Add("All");

            int count2 = DropDownList8.Items.Count;
            for (int q2 = 0; q2 < count2; q2++)
                DropDownList8.Items.RemoveAt(0);
            DropDownList8.Items.Add("All");
        }

        if (IsPostBack)
        {
            int counter = 1;

            if (DropDownList1.Text == "IT")
            {
                DropDownList2.DataSourceID = "AccessDataSource1";
                DropDownList2.DataTextField = "column1";
                DropDownList2.DataValueField = "column1";
                DropDownList3.DataSourceID = "AccessDataSourceSC1";
                DropDownList3.DataTextField = "Blank_Field";
                DropDownList3.DataValueField = "Blank_Field";
                counter = 0;
            }
            else if (DropDownList1.Text == "GIS")
            {
                DropDownList2.SelectedIndex = 0;
                DropDownList3.SelectedIndex = 0;
                DropDownList2.DataTextField = "Blank_Field";
                DropDownList2.DataValueField = "Blank_Field";
                DropDownList3.DataTextField = "Blank_Field";
                DropDownList3.DataValueField = "Blank_Field";
            }
            else if (DropDownList1.Text == "Application")
            {
                DropDownList2.SelectedIndex = 0;
                DropDownList3.SelectedIndex = 0;
                DropDownList2.DataTextField = "Blank_Field";
                DropDownList2.DataValueField = "Blank_Field";
                DropDownList3.DataTextField = "Blank_Field";
                DropDownList3.DataValueField = "Blank_Field";
            }
            else if (DropDownList1.Text == "All")
            {
                DropDownList2.SelectedIndex = 0;
                DropDownList3.SelectedIndex = 0;
                DropDownList2.DataSourceID = "";
                DropDownList2.DataTextField = "";
                DropDownList2.DataValueField = "";
                int count = DropDownList2.Items.Count;
                for (int q = 0; q < count; q++)
                    DropDownList2.Items.RemoveAt(0);
                DropDownList2.Items.Add("All");
                DropDownList3.DataSourceID = "";
                DropDownList3.DataTextField = "";
                DropDownList3.DataValueField = "";
                DropDownList2.Text = "All";
                int count1 = DropDownList3.Items.Count;
                for (int q = 0; q < count1; q++)
                    DropDownList3.Items.RemoveAt(0);
                DropDownList3.Items.Add("All");
                int count21 = DropDownList8.Items.Count;
                for (int q2 = 0; q2 < count21; q2++)
                    DropDownList8.Items.RemoveAt(0);
                DropDownList8.Items.Add("All");
                int count3 = DropDownList7.Items.Count;
                for (int q3 = 0; q3 < count3; q3++)
                    DropDownList7.Items.RemoveAt(0);
                DropDownList7.Items.Add("All");
            }

            if (DropDownList7.Text == "IT-Enterprise Server")
            {
                DropDownList3.DataSourceID = "AccessDataSourceSC1";
                DropDownList3.DataTextField = "column1";
                DropDownList3.DataValueField = "column1";
                DropDownList7.Text = "IT-Enterprise Server";
                counter = 1;
            }
            else if (DropDownList7.Text == "IT-Intel Server")
            {
                DropDownList3.DataSourceID = "AccessDataSourceSC3";
                DropDownList3.DataTextField = "column1";
                DropDownList3.DataValueField = "column1";
                DropDownList7.Text = "IT-Intel Server";
                counter = 1;
            }
            else if (DropDownList7.Text == "IT-Hardware")
            {
                DropDownList3.DataSourceID = "AccessDataSourceSC2";
                DropDownList3.DataTextField = "column1";
                DropDownList3.DataValueField = "column1";
                DropDownList7.Text = "IT-Hardware";
                counter = 1;
            }
            else if (DropDownList7.Text == "IT-Networking")
            {
                DropDownList3.DataSourceID = "AccessDataSourceSC4";
                DropDownList3.DataTextField = "column1";
                DropDownList3.DataValueField = "column1";
                DropDownList7.Text = "IT-Networking";
                counter = 1;
            }
            else if (DropDownList7.Text == "IT-Telecom")
            {
                DropDownList3.DataSourceID = "AccessDataSourceSC5";
                DropDownList3.DataTextField = "column1";
                DropDownList3.DataValueField = "column1";
                DropDownList7.Text = "IT-Telecom";
                counter = 1;
            }
            else if (DropDownList7.Text == "IT-Software")
            {
                DropDownList3.DataSourceID = "AccessDataSourceSC6";
                DropDownList3.DataTextField = "column1";
                DropDownList3.DataValueField = "column1";
                DropDownList7.Text = "IT-Software";
                counter = 1;
            }

            if (counter == 0)
            {
                int count4 = DropDownList7.Items.Count;
                for (int q4 = 0; q4 < count4; q4++)
                    DropDownList7.Items.RemoveAt(0);

                DropDownList2.DataBind();
                DropDownList7.Items.Add("All");

                for (int q4 = 1; q4 < DropDownList2.Items.Count; q4++)
                {
                    if (DropDownList2.Items[q4].ToString() != "All")
                        DropDownList7.Items.Add(DropDownList2.Items[q4].ToString());
                }
            }

            if (DropDownList7.Text != "All"&&DropDownList8.Text =="All")
            {
                int count2 = DropDownList8.Items.Count;
                for (int q2 = 0; q2 < count2; q2++)
                    DropDownList8.Items.RemoveAt(0);

                DropDownList3.DataBind();
                DropDownList8.Items.Add("All");

                for (int q = 1; q < DropDownList3.Items.Count; q++)
                {
                    if (DropDownList3.Items[q].ToString() != "All")
                        DropDownList8.Items.Add(DropDownList3.Items[q].ToString());
                }
            }
        }
    }
    protected void resetbutton_Click(object sender, EventArgs e)
    {
        DropDownList2.SelectedIndex = 0;
        DropDownList3.SelectedIndex = 0;
        DropDownList2.DataSourceID = "";
        DropDownList2.DataTextField = "";
        DropDownList2.DataValueField = "";
        int count = DropDownList2.Items.Count;
        for (int q = 0; q < count; q++)
            DropDownList2.Items.RemoveAt(0);
        DropDownList2.Items.Add("All");
        DropDownList3.DataSourceID = "";
        DropDownList3.DataTextField = "";
        DropDownList3.DataValueField = "";
        DropDownList2.Text = "All";
        int count1 = DropDownList3.Items.Count;
        for (int q = 0; q < count1; q++)
            DropDownList3.Items.RemoveAt(0);
        DropDownList3.Items.Add("All");

        int count21 = DropDownList8.Items.Count;
        for (int q2 = 0; q2 < count21; q2++)
            DropDownList8.Items.RemoveAt(0);
        DropDownList8.Items.Add("All");
        int count3 = DropDownList7.Items.Count;
        for (int q3 = 0; q3 < count3; q3++)
            DropDownList7.Items.RemoveAt(0);
        DropDownList7.Items.Add("All");

        DropDownList1.SelectedIndex = 0;

        DropDownList7.SelectedIndex = 0;
        DropDownList8.SelectedIndex = 0;

        Calendar1.Visible = false;
        Calendar2.Visible = false;
        fromdatebox.Text = "";
        todatebox.Text = "";

        Label17.Visible = false;
        Label18.Visible = false;
        Label9.Visible = false;
        Label7.Visible = false;
        Label6.Visible = false;
        Label14.Visible = false;

        CrystalReportViewer1.Visible = false;
    }
    protected void submitbutton_Click(object sender, EventArgs e)
    {
        DropDownList8.Text = DropDownList8.Text;

        int counter1 = 0;
        int counter2 = 0;
        int counter3 = 0;
        int counter4 = 0;
        int counter5 = 0;
        int counter6 = 0;

        if (DropDownList7.Text == "")
        {
            Label9.Visible = true;
            counter1 = 0;
        }
        else
        {
            Label9.Visible = false;
            counter1 = 1;
        }
        if (DropDownList8.Text == "")
        {
            Label14.Visible = true;
            counter2 = 0;
        }
        else
        {
            Label14.Visible = false;
            counter2 = 1;
        }
        if (DropDownList6.Text == "")
        {
            Label6.Visible = true;
            counter3 = 0;
        }
        else
        {
            Label6.Visible = false;
            counter3 = 1;
        }
        if (DropDownList5.Text == "")
        {
            Label7.Visible = true;
            counter4 = 0;
        }
        else
        {
            Label7.Visible = false;
            counter4 = 1;
        }
        if (fromdatebox.Text == "")
        {
            Label17.Visible = true;
            counter5 = 0;
        }
        else
        {
            Label17.Visible = false;
            counter5 = 1;
        }
        if (todatebox.Text == "")
        {
            Label18.Visible = true;
            counter6 = 0;
        }
        else
        {
            Label18.Visible = false;
            counter6 = 1;
        }
        if ((counter1 == 1) && (counter2 == 1) && (counter3 == 1) && (counter4 == 1) && (counter5 == 1) && (counter6 == 1))
        {
            CrystalReportViewer1.Visible = true;

            string temp1 = Calendar1.SelectedDate.ToShortDateString();
            string temp2 = Calendar2.SelectedDate.ToShortDateString();
            string t1 = "";
            string t2 = "";
            string year1 = Calendar1.SelectedDate.Year.ToString();
            string month1 = Calendar1.SelectedDate.Month.ToString();
            string year2 = Calendar2.SelectedDate.Year.ToString();
            string month2 = Calendar2.SelectedDate.Month.ToString();

            int counter = 0;
            for (int q = 0; q < temp1.Length; q++)
            {
                if (temp1[q] == '/')
                    counter++;

                if (counter == 1 && temp1[q] != '/')
                    t1 += temp1[q];
            }

            int count = 0;
            for (int q = 0; q < temp2.Length; q++)
            {
                if (temp2[q] == '/')
                    count++;

                if (count == 1 && temp2[q] != '/')
                    t2 += temp2[q];
            }

            string dateselect = "{NHD_CMPTBL.LOG_DATE} in DateTime (" + year1 + "," + month1 + "," + t1 + ", 00, 00, 00) to DateTime (" + year2 + "," + month2 + "," + t2 + ", 23,59,59)";

            if (DropDownList1.Text != "All")
            {
                string helpdesk = DropDownList1.Text;

                dateselect += "and {NHD_CMPTBL.HLPDEK} = \"" + helpdesk + "\"";
            }

            if (DropDownList7.Text != "All")
            {
                string cat = DropDownList7.Text;

                dateselect += "and {NHD_CMPTBL.CAT} = \"" + cat + "\"";
            }

            if (DropDownList8.Text != "All")
            {
                string subcat = DropDownList8.Text;
                dateselect += "and {NHD_CMPTBL.SUBCAT} = \"" + subcat + "\"";
            }

            if (DropDownList5.Text != "All")
            {
                string priority = DropDownList5.Text;
                dateselect += "and {NHD_CMPTBL.PRIORITY} = \"" + priority + "\"";
            }

            if (DropDownList6.Text != "All")
            {
                string siteid = DropDownList6.Text;
                dateselect += "and {NHD_CMPTBL.SITE_ID} = \"" + siteid + "\"";
            }

            CrystalReportViewer1.SelectionFormula = dateselect;
        }
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

    private void Page_Init(object sender, EventArgs e)
    {
        ConfigureCrystalReports();
    }

    private void ConfigureCrystalReports()
    {
        rpt = new ReportDocument();
        ConnectionInfo connectionInfo = new ConnectionInfo();
        string path = Server.MapPath("Reports\\LocationWiseReport.rpt");
        rpt.Load(path);

        SetDBLogonForReport(connectionInfo, rpt);
        CrystalReportViewer1.ReportSource = rpt;
        CrystalReportViewer1.Visible = false;
    }

    private void SetDBLogonForReport(ConnectionInfo connectionInfo, ReportDocument reportDocument)
    {
        Tables tables = reportDocument.Database.Tables;

        foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
        {
            TableLogOnInfo tableLogonInfo = table.LogOnInfo;
            tableLogonInfo.ConnectionInfo.ServerName = "RGTIL";
            tableLogonInfo.ConnectionInfo.Password = "EHELPDEK";
            tableLogonInfo.ConnectionInfo.UserID = "EHELPDEK";
            table.ApplyLogOnInfo(tableLogonInfo);
        }
    }
}
