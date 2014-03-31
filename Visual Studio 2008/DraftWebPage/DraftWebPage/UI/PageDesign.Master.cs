using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DraftWebPage
{
    public partial class PageDesign : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MenuBrowser_SelectedNodeChanged(object sender, EventArgs e)
        {/*
            //if the selected node has parent
            if (MenuBrowser.SelectedNode.Parent != null)
            {
                //make sure the selected node is at level 1(next to root) of the tree
                //if not then let the tree view be open i.e. dont collapse
                if (MenuBrowser.SelectedNode.Parent.Parent == null)
                {
                    Image1.AlternateText += MenuBrowser.SelectedNode.Text;
                    MenuBrowser.CollapseAll();
                    MenuBrowser.SelectedNode.Parent.Expanded = true;
                    MenuBrowser.SelectedNode.Expanded = true;
                }
            }
            else
            {
                //if the selected node is at the root level
                MenuBrowser.CollapseAll();
                MenuBrowser.SelectedNode.Expanded = true;
            }*/
        }

        protected void MenuBrowser_TreeNodeExpanded(object sender, TreeNodeEventArgs e)
        {
            int count = 0;

            //count the number of expanded nodes in the treeview
            foreach (TreeNode tn in MenuBrowser.Nodes)
            {
                if (tn.Expanded == true)
                    count++;
            }

            if (count > 1)
            {
                //if more than one expanded menu are there...close all first
                foreach (TreeNode tn in MenuBrowser.Nodes)
                {
                    tn.Collapse();
                    tn.Selected = false;
                }

                //now expand only the one which is being called. and select it
                foreach (TreeNode tn2 in MenuBrowser.Nodes)
                {
                    if (tn2.Text == e.Node.Text)
                    {
                        //for collapsing all the child nodes inside the main node.
                        //so tht on opening no expanded node(s) are there.
                        foreach (TreeNode cn in tn2.ChildNodes)
                        {
                            cn.Collapse();
                        }
                        tn2.Expand();
                    }
                }
            }
        }
    }
}
