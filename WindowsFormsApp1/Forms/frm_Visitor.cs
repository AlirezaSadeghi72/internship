using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataLayer;

namespace WindowsFormsApp1.Forms
{
    public partial class frm_Visitor : Form
    {
        #region متغییر ها

        private Color[] colorlevel = { Color.Red, Color.Green, Color.Blue, Color.BlueViolet,Color.Aqua, Color.Black, Color.Coral, Color.Yellow };
        private List<visitors> visitor = new List<visitors>();
        #endregion

        public frm_Visitor()
        {
            InitializeComponent();
            visitor = conection.get<visitors>();
            setTreeView();
        }


        #region متدها

        private void setTreeView()
        {

            List<visitors> treeSup_vis = visitor.Where(v => v.supervisor_rdf == 0).ToList();
            if (treeSup_vis != null)
            {
                
                foreach (var SupVi in treeSup_vis)
                {
                    if (visitor.Where(v => v.supervisor_rdf == SupVi.vis_rdf).ToList().Count > 0)
                    {
                        TreeNode node = treeView1.Nodes.Add(SupVi.vis_name);
                        addNode(node, SupVi.vis_rdf, 1);
                        node.ForeColor = colorlevel[0];
                    }
                }
            }

        }

        private void addNode(TreeNode node, int visId, int levelNode)
        {
            List<visitors> childeVis = visitor.Where(v => v.supervisor_rdf == visId).ToList();
            
            foreach (visitors chVis in childeVis)
            {
                TreeNode node1 = node.Nodes.Add(chVis.vis_name);
                addNode(node1, chVis.vis_rdf, ++levelNode);
                node1.ForeColor = colorlevel[levelNode];
            }
        }

        private void CheckChildren(TreeNode rootNode, bool isChecked)
        {
            foreach (TreeNode node in rootNode.Nodes)
            {
                CheckChildren(node, isChecked);
                node.Checked = isChecked;
            }
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked)
            {
                CheckChildren(e.Node, true);

            }
            else
            {
                CheckChildren(e.Node, false);
            }
        }
        #endregion

        //if (e.Node.Checked)
        //{
        //    e.Node.Checked = false;
        //    foreach (TreeNode node in e.Node.Nodes)
        //    {
        //        node.Checked = true;
        //    }
        //}
        //else
        //{
        //    e.Node.Checked = true;
        //    foreach (TreeNode node in e.Node.Nodes)
        //    {
        //        node.Checked = false;
        //    }
        //}
    }
}
