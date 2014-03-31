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
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;

            if (usernamebox.Text == "")
            {
                Label10.Visible = true;
                counter1 = 0;
            }
            else
            {
                Label10.Visible = false;
                counter1 = 1;
            }

            if (userloginidbox.Text == "")
            {
                Label11.Visible = true;
                counter2=0;
            }
            else
            {
                Label11.Visible=false;
                counter2=1;
            }
            if (DropDownList1.Text == "")
            {
                counter3 = 0;
                Label15.Visible = true;
            }
            else
            {
                counter3 = 1;
                Label15.Visible = false;
            }

            if(counter1==1&&counter2==1&&counter3==1)
            {
                string dob = dob1.Text + "/" + dob2.Text + "/" + dob3.Text;
                string pass = "password";

                string logintype="";

                if (DropDownList1.Text == "Administrator")
                    logintype = "Admin";
                else if (DropDownList1.Text == "IT-Engineer")
                    logintype = "ITEng";
                else if (DropDownList1.Text == "User")
                    logintype = "User";

                LoginTableAdapters.NHD_USERDATATableAdapter a = new LoginTableAdapters.NHD_USERDATATableAdapter();
                a.InsertUser(usernamebox.Text, userloginidbox.Text, usermailidbox.Text, usercontactnobox.Text, userdepartmentbox.Text, usersiteidbox.Text, logintype,dob);

                LoginTableAdapters.NHD_LOGINTableAdapter b = new LoginTableAdapters.NHD_LOGINTableAdapter();
                b.InsertUser(userloginidbox.Text, pass);

                Page.RegisterStartupScript("k1", "<script language=javascript> alert(\" User Created !! \");</script>");

                usernamebox.Text = "";
                usermailidbox.Text = "";
                userloginidbox.Text = "";
                userdepartmentbox.Text = "";
                usercontactnobox.Text = "";
                usersiteidbox.Text = "";
                dob1.Text = "";
                dob2.Text = "";
                dob3.Text = "";
                DropDownList1.SelectedIndex = 0;
            }
        }
    }
}
