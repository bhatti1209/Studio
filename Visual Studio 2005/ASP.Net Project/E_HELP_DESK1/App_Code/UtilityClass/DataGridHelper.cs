using System;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace ecryptex.UtilityClasses
{
	/// <summary>
	/// Summary description for DataGridHelper.
	/// </summary>
	public class DataGridHelper:System.Web.UI.Page
	{
		#region Constructor
		public DataGridHelper()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		#endregion

		#region Protected Page-Level Properties

		protected string SortExpression
		{
			get
			{
				object o = ViewState["SortExpression"];
				if (o == null)
					return string.Empty;
				else
					return o.ToString();
			}
			set
			{
				ViewState["SortExpression"] = value;
			}
		}

		protected bool SortAscending
		{
			get
			{
				object o = ViewState["SortAscending"];
				if (o == null)
					return true;
				else
					return Convert.ToBoolean(o);
			}
			set
			{
				ViewState["SortAscending"] = value;
			}
		}

		#endregion

		#region Data Grid Formating

		protected void  DataGridFormat(DataGrid dg)
		{
			dg.CellPadding = -1;
			dg.CellSpacing = 0;
			dg.CssClass = "datagrid";
			dg.GridLines = GridLines.Both;			
		}

		#endregion

		#region DataGrid Binding

		protected void BindData(DataGrid dg, object dataSource)
		{
			// Update the columns in the DataGrid
			foreach(DataGridColumn c in dg.Columns)
			{
				// Clear any &lt;img&gt; tags that might be present
				c.HeaderText = Regex.Replace(c.HeaderText, 
					"&nbsp;<.*>", String.Empty);

				if (SortExpression != string.Empty && 
					c.SortExpression == SortExpression)
				{
					if (SortAscending)
						c.HeaderText += string.Concat("&nbsp;<img src=\"", 
							dg.ResolveUrl("~/images/up.gif"), 
							"\" border=\"0\" width=\"11\" height=\"7\" />");
					else
						c.HeaderText += string.Concat("&nbsp;<img src=\"", 
							dg.ResolveUrl("~/images/down.gif"), 
							"\" border=\"0\" width=\"11\" height=\"7\" />");
				}
			}

			dg.DataSource = dataSource;
			dg.DataBind();
		}

		#endregion

		#region DataGrid Sorting

		protected void HandleSorting(DataGrid dg, string sortExpr)
		{
			// reset the DataGrid back to the first page
			dg.CurrentPageIndex = 0;			

			// if clicking on same, sorted column then toggle sort direction
			if (SortExpression == sortExpr)	
				SortAscending = !SortAscending;		
			else
				// reset ascending to true when sorting by a new column
				SortAscending = true;				

			SortExpression = sortExpr;
			
		}

		#endregion

		# region Pager Control
		
		protected void enabledisable(DataGrid dg,ImageButton imgFirst,ImageButton imgLast,ImageButton imgNext,ImageButton imgPrev)
		{
			string strIcons="../images/pager/lightblue";

			imgFirst.ImageUrl = strIcons + "/first-icon-off.gif";
			imgLast.ImageUrl = strIcons + "/last-icon-off.gif";
			imgPrev.ImageUrl = strIcons + "/previous-icon-off.gif";
			imgNext.ImageUrl = strIcons + "/next-icon-off.gif";

			if (dg.PageCount == 1)
			{
				imgFirst.Enabled = false;
				imgLast.Enabled = false;
				imgPrev.Enabled = false;
				imgNext.Enabled = false;
				
				imgFirst.Style.Add("cursor","Default");
				imgLast.Style.Add("cursor","Default");
				imgPrev.Style.Add("cursor","Default");
				imgNext.Style.Add("cursor","Default");
			}

			else if (dg.CurrentPageIndex == 0 )
			{
				imgFirst.Enabled = false;
				imgPrev.Enabled = false;
				imgNext.Enabled = true;
				imgLast.Enabled = true;

				imgFirst.Style.Add("cursor","Default");
				imgPrev.Style.Add("cursor","Default");
				imgLast.Style.Add("cursor","Hand");
				imgNext.Style.Add("cursor","Hand");

				imgLast.ImageUrl = strIcons + "/last-icon-on.gif";
				imgNext.ImageUrl = strIcons + "/next-icon-on.gif";
			}
			else if(dg.CurrentPageIndex == dg.PageCount - 1 )
			{
				imgNext.Enabled = false;
				imgLast.Enabled = false;
				imgFirst.Enabled = true;
				imgPrev.Enabled = true;

				imgNext.Style.Add("cursor","Default");
				imgLast.Style.Add("cursor","Default");
				imgFirst.Style.Add("cursor","Hand");
				imgPrev.Style.Add("cursor","Hand");

				imgFirst.ImageUrl = strIcons + "/first-icon-on.gif";
				imgPrev.ImageUrl = strIcons + "/previous-icon-on.gif";
			}
			else
			{
				imgFirst.Enabled = true;
				imgLast.Enabled = true;
				imgPrev.Enabled = true;
				imgNext.Enabled = true;

				imgFirst.Style.Add("cursor","Hand");
				imgLast.Style.Add("cursor","Hand");
				imgPrev.Style.Add("cursor","Hand");
				imgNext.Style.Add("cursor","Hand");

				imgLast.ImageUrl = strIcons + "/last-icon-on.gif";
				imgNext.ImageUrl = strIcons + "/next-icon-on.gif";
				imgFirst.ImageUrl = strIcons + "/first-icon-on.gif";
				imgPrev.ImageUrl = strIcons + "/previous-icon-on.gif";
			}

		}

		protected void PagerButtonClick(Object sender  , ImageClickEventArgs e ,DataGrid dg)
		{
			ImageButton oImageButton=(ImageButton)sender;

			switch (oImageButton.CommandName.ToString().ToLower())
			{
				case "first":
					dg.CurrentPageIndex = 0;
					break;

				case "prev":
					dg.CurrentPageIndex = Math.Max(dg.CurrentPageIndex - 1, 0);
					
					break;
				
				case "next":
					dg.CurrentPageIndex = Math.Min(dg.CurrentPageIndex + 1, dg.PageCount - 1);
					
					
					break;	
				
				case "last":
					dg.CurrentPageIndex = dg.PageCount - 1;
					
					break;
			
				default:
					break;
			}			

		}

		#endregion
	}
}
