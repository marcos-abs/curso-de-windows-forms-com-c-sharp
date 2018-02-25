using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win03_D {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void lblAzul_Click(object sender, EventArgs e) {
            splitContainer1.Panel2.BackColor = Color.Blue;
        }

        private void lblBranco_Click(object sender, EventArgs e) {
            splitContainer1.Panel2.BackColor = Color.White;
        }
    }
}
