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
        Datetextbox.Text = Convert.ToString(DateTime.Today.ToShortDateString());

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
            if (CheckBox1.Checked == true)
                usernamebox.Enabled = true;
            else
                usernamebox.Enabled = false;

            if (DropDownList1.Text == "IT")
            {
                DropDownList2.DataTextField = "column1";
                DropDownList2.DataValueField = "column1";
                DropDownList3.DataSourceID = "AccessDataSourceSC1";
                DropDownList3.DataTextField = "Blank_Field";
                DropDownList3.DataValueField = "Blank_Field";
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
            else if (DropDownList1.Text == "")
            {
                DropDownList2.SelectedIndex = 0;
                DropDownList3.SelectedIndex = 0;
                DropDownList2.DataTextField = "Blank_Field";
                DropDownList2.DataValueField = "Blank_Field";
                DropDownList3.DataTextField = "Blank_Field";
                DropDownList3.DataValueField = "Blank_Field";
            }

            if (DropDownList2.Text == "IT-Enterprise Server")
            {
                DropDownList3.DataSourceID = "AccessDataSourceSC1";
                DropDownList3.DataTextField = "column1";
                DropDownList3.DataValueField = "column1";
                DropDownList2.Text = "IT-Enterprise Server";
            }
            else if (DropDownList2.Text == "IT-Intel Server")
            {
                DropDownList3.DataSourceID = "AccessDataSourceSC3";
                DropDownList3.DataTextField = "column1";
                DropDownList3.DataValueField = "column1";
                DropDownList2.Text = "IT-Intel Server";
            }
            else if (DropDownList2.Text == "IT-Hardware")
            {
                DropDownList3.DataSourceID = "AccessDataSourceSC2";
                DropDownList3.DataTextField = "column1";
                DropDownList3.DataValueField = "column1";
                DropDownList2.Text = "IT-Hardware";
            }
            else if (DropDownList2.Text == "IT-Networking")
            {
                DropDownList3.DataSourceID = "AccessDataSourceSC4";
                DropDownList3.DataTextField = "column1";
                DropDownList3.DataValueField = "column1";
                DropDownList2.Text = "IT-Networking";
            }
            else if (DropDownList2.Text == "IT-Telecom")
            {
                DropDownList3.DataSourceID = "AccessDataSourceSC5";
                DropDownList3.DataTextField = "column1";
                DropDownList3.DataValueField = "column1";
                DropDownList2.Text = "IT-Telecom";
            }
            else if (DropDownList2.Text == "IT-Software")
            {
                DropDownList3.DataSourceID = "AccessDataSourceSC6";
                DropDownList3.DataTextField = "column1";
                DropDownList3.DataValueField = "column1";
                DropDownList2.Text = "IT-Software";
            }
        }
    }

    protected void ResetButton_Click(object sender, EventArgs e)
    {
        DropDownList2.DataBind();
        DropDownList2.DataTextField = "blank_field";
        DropDownList1.SelectedIndex = 0;

        DropDownList3.DataSourceID = "AccessDataSourceSC1";
        DropDownList3.SelectedIndex = 0;
        DropDownList3.DataTextField = "Blank_Field";
        DropDownList3.DataValueField = "Blank_Field";

        DropDownList6.SelectedIndex = 0;

        SubjectBox.Text = "";
        problembox.Text = "";
        Label8.Visible = false;
        Label9.Visible = false;
        Label16.Visible = false;
        Label14.Visible = false;
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        int counter1 = 0;
        int counter2 = 0;
        int counter3 = 0;
        int counter4 = 0;

        if (DropDownList2.Text == "")
        {
            Label9.Visible = true;
            counter1 = 0;
        }
        else
        {
            Label9.Visible = false;
            counter1 = 1;
        }

        if (DropDownList3.Text == "")
        {
            counter2 = 0;
            Label14.Visible = true;
        }
        else
        {
            Label14.Visible = false;
            counter2 = 1;
        }

        if (problembox.Text == "")
        {
            Label8.Visible = true;
            counter3 = 0;
        }
        else
        {
            Label8.Visible = false;
            counter3 = 1;
        }
        if (SubjectBox.Text == "")
        {
            counter4 = 0;
            Label9.Visible = true;
        }
        else
        {
            counter4 = 1;
            Label9.Visible = false;
        }


        if ((counter1 == 1) && (counter2 == 1) && (counter3 == 1)&&(counter4==1))       //write code for submit button
        {
            string ticket = generate_ticket();
            Appsession temp = (Appsession)Session["p_loginsession"];
            string username = Convert.ToString(temp.getusername());
            string a = DateTime.Now.Date.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
            DateTime currentdate = Convert.ToDateTime(a);
            string siteid = DropDownList6.Text;
            string comp_user;

            if (CheckBox1.Checked == true)
                comp_user = usernamebox.Text;
            else
            {
                comp_user = username;
            }

            LoginTableAdapters.NHD_CMPTBLTableAdapter c = new LoginTableAdapters.NHD_CMPTBLTableAdapter();

            if (FileUpload1.FileName == "")
                c.InsertComplain(ticket, DropDownList2.Text, DropDownList3.Text, username, siteid, comp_user, SubjectBox.Text, DropDownList1.Text, DropDownList5.Text, currentdate, problembox.Text, "Open");
            else
                c.InsertComplainWithData(ticket, DropDownList2.Text, DropDownList3.Text, username, siteid, comp_user, SubjectBox.Text, DropDownList1.Text, DropDownList5.Text, currentdate, problembox.Text, "Open", FileUpload1.FileBytes);

            temp.settckid(ticket);
            
            Response.Redirect("http://localhost:1658/NewHelpDesk/UI/AdminFolder/LogYourCallConfirm.aspx");
        }
    }

    private int checkchange(string temp1)
    {
        string temp2 = "";
        int counter = 0;

        for (int w = (temp1.Length - 1); w >= 0; w--)
        {
            if (temp1[w] == '-')
                counter++;
            if (counter == 1 && temp1[w] != '-')
                temp2 += temp1[w];
        }
        string temp3 = "";
        int len = (temp2.Length - 1);
        for (int a1 = 0; a1 <= len; a1++)
            temp3 += temp2[len - a1];
        int dbdate = Convert.ToInt32(temp3);

        string tyear = Convert.ToString(DateTime.Today.Year);
        string t2 = DateTime.Today.Month.ToString();
        if (t2.Length == 1)
            t2 = "0" + t2;
        string t3 = DateTime.Today.Date.ToShortDateString();
        string t4 = "";
        int count = 0;
        for (int q = 0; q < t3.Length; q++)
        {
            if (t3[q] == '/')
                count++;
            if (count == 1 && t3[q] != '/')
                t4 += t3[q];
        }
        if (t4.Length == 1)
            t4 = "0" + t4;

        string ans = tyear + t2 + t4;
        int currdate = Convert.ToInt32(ans);

        if (currdate == dbdate)
            return 0;
        else
            return 1;
    }

    private string generate_ticket()
    {
        LoginTableAdapters.NHD_CMPTBLTableAdapter z = new LoginTableAdapters.NHD_CMPTBLTableAdapter();
        string temp11 = z.GetRefIDDesc();

        int res = checkchange(temp11);
        if (res == 0)
        {
            LoginTableAdapters.NHD_CMPTBLTableAdapter n = new LoginTableAdapters.NHD_CMPTBLTableAdapter();
            string temp1 = n.GetRefIDDesc();
            string temp2 = "";
            int counter = 0;

            for (int w = (temp1.Length - 1); w >= 0; w--)
            {
                if (temp1[w] == '-')
                    counter++;
                if (counter == 0 && temp1[w] != '-')
                    temp2 += temp1[w];
            }
            string temp3 = "";
            int len = (temp2.Length - 1);
            for (int a1 = 0; a1 <= len; a1++)
                temp3 += temp2[len - a1];

            int curr = Convert.ToInt32(temp3);

            string temp;
            temp = "RGTIL-" + DateTime.Today.Year;
            string t2 = DateTime.Today.Month.ToString();
            if (t2.Length == 1)
                t2 = "0" + t2;
            string t3 = DateTime.Today.Date.ToShortDateString();
            string t4 = "";
            int count = 0;
            for (int q = 0; q < t3.Length; q++)
            {
                if (t3[q] == '/')
                    count++;
                if (count == 1 && t3[q] != '/')
                    t4 += t3[q];
            }
            if (t4.Length == 1)
                t4 = "0" + t4;
            string t5;
            curr++;
            t5 = Convert.ToString(curr);
            if (t5.Length == 1)
                t5 = "0" + t5;

            string ans = temp + t2 + t4 + "-" + t5;
            return ans;
        }
        else
        {
            string temp;
            temp = "RGTIL-" + DateTime.Today.Year;
            string t2 = DateTime.Today.Month.ToString();
            if (t2.Length == 1)
                t2 = "0" + t2;
            string t3 = DateTime.Today.Date.ToShortDateString();
            string t4 = "";
            int count = 0;
            for (int q = 0; q < t3.Length; q++)
            {
                if (t3[q] == '/')
                    count++;
                if (count == 1 && t3[q] != '/')
                    t4 += t3[q];
            }
            if (t4.Length == 1)
                t4 = "0" + t4;

            string ans = temp + t2 + t4 + "-01";
            return ans;
        }
    }
}
