using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win13 {
    public partial class Form1 : Form {
        List<TreeNode> listaNodes = new List<TreeNode>();

        public Form1() {
            InitializeComponent();
        }

        private void Backup_Click(object sender, EventArgs e) {
            StringBuilder sb = new StringBuilder();
            foreach (var node in listaNodes) {
                sb.Append(node.Text + "\n");
            }
            label1.Text = sb.ToString();
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e) {
            if (e.Node.Checked) {
                listaNodes.Add(e.Node);
            } else {
                listaNodes.Remove(e.Node);
            }
        }
    }
}
