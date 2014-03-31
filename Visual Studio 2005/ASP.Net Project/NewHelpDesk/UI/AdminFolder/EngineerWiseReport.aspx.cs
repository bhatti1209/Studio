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

    }
   
    protected void resetbutton_Click(object sender, EventArgs e)
    {
        Calendar1.Visible = false;
        Calendar2.Visible = false;
        fromdatebox.Text = "";
        todatebox.Text = "";
        CrystalReportViewer1.Visible = false;

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

            dateselect += " and {NHD_CMPTBL.ASSGN_TO} = \"" + engnamebox.Text + "\"";

            if (DropDownList6.Text != "All")
            {
                string callstatus = DropDownList6.Text;

                dateselect += " and {NHD_CMPTBL.STATUS} = \"" + callstatus + "\"";
            }

            CrystalReportViewer1.SelectionFormula = dateselect;
        }
    }

    private void Page_Init(object sender, EventArgs e)
    {
        ConfigureCrystalReports();
    }

    private void ConfigureCrystalReports()
    {
        rpt = new ReportDocument();
        ConnectionInfo connectionInfo = new ConnectionInfo();
        string path = Server.MapPath("Reports\\EngineerWiseReport.rpt");
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
