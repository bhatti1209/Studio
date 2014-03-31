using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace TestWebApp
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Label1.Text += "Postback";
            }
            else
            {
                Label1.Text += "NoPostback";
            }
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            TableRow tr = new TableRow();
            TableCell tc = new TableCell();
            TextBox t = new TextBox();
            tc.Controls.Add(t);
            tr.Cells.Add(tc);
            tr.Cells.Add(tc);
            tr.Cells.Add(tc);
            int r = Table1.Rows.Count;
            Table1.Rows.AddAt(r - 1, tr);

            ViewState["rc"] = Table1.Rows.Count;
            ViewState["rowadded"] = true;
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            if ((bool)ViewState["rowadded"])
            {
                int rowstoadd = (int)ViewState["rc"] - 3;

                for (int q = 0; q < rowstoadd; q++)
                {
                    TableRow tr = new TableRow();
                    TableCell tc = new TableCell();
                    TextBox t = new TextBox();
                    tc.Controls.Add(t);
                    tr.Cells.Add(tc);
                    tr.Cells.Add(tc);
                    tr.Cells.Add(tc);
                    int r = Table1.Rows.Count;
                    Table1.Rows.AddAt(r - 1, tr);
                }
            }
        }
    }
}
