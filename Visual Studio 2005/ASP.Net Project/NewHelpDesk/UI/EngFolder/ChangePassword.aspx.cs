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
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;

            if (usernamebox.Text == "")
            {
                counter1 = 0;
                Label7.Visible = true;
            }
            else
            {
                counter1 = 1;
                Label7.Visible = false;
            }

            if (oldpassbox1.Text == "")
            {
                counter2 = 0;
                Label8.Visible = true;
            }
            else
            {
                counter2 = 1;
                Label8.Visible = false;
            }

            if (newpassbox1.Text == "")
            {
                counter3 = 0;
                Label9.Visible = true;
            }
            else
            {
                counter3 = 1;
                Label9.Visible = false;
            }

            if (newpassbox2.Text == "")
            {
                counter4 = 0;
                Label10.Visible = true;
            }
            else
            {
                counter4 = 1;
                Label10.Visible = false;
            }

            if (newpassbox1.Text != newpassbox2.Text) 
            {
                Label5.Visible = true;
                counter = 0;
            }
            else
            {
                Label5.Visible = false;
                counter = 1;
                LoginTableAdapters.NHD_LOGINTableAdapter b = new LoginTableAdapters.NHD_LOGINTableAdapter();
                int temp = Convert.ToInt32(b.ConfirmLogin(usernamebox.Text, oldpassbox1.Text));

                if (temp > 0)
                {
                    counter = 1;
                    Label6.Visible = false;
                }
                else
                {
                    counter = 0;
                    Label6.Visible = true;
                }
            }

            if ((counter == 1)&&(counter1 == 1)&&(counter2 == 1)&&(counter3 == 1)&&(counter4 == 1))
            {
                LoginTableAdapters.NHD_LOGINTableAdapter a = new LoginTableAdapters.NHD_LOGINTableAdapter();
                a.ChangePassword(newpassbox1.Text, usernamebox.Text);
                Page.RegisterStartupScript("k1", "<script language=javascript> alert(\" Password Changed!! \");</script>");
            }
        }
    }
}
