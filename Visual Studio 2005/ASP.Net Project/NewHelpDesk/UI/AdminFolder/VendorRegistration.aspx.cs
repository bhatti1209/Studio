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
    protected void registerbutton_Click(object sender, EventArgs e)
    {
        int counter = 0;
        if (vennamebox.Text == "")
        {
            Label17.Visible = true;
            counter = 0;
        }
        else
        {
            Label17.Visible = false;
            counter = 1;
        }
        if (counter == 1)
        {
            LoginTableAdapters.NHD_VENDORDBTableAdapter a = new LoginTableAdapters.NHD_VENDORDBTableAdapter();
            decimal cn1 = Convert.ToDecimal(contact1box.Text);
            decimal cn2 = Convert.ToDecimal(contact2box.Text);
            string name = vennamebox.Text;
            string email = vendoremailbox.Text;
            string address1 = vendorlocationbox.Text;

            a.InsertVendor(name, email, cn1, cn2, address1);
            Page.RegisterStartupScript("k1", "<script language=javascript> alert(\" Vendor Has Been Registered !! \");</script>");
            vennamebox.Text = "";
            vendoremailbox.Text = "";
            vendorlocationbox.Text = "";
            contact1box.Text = "";
            contact2box.Text = "";
        }
    }
}
