﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win03_A {
    public partial class Flow : Form {
        public Flow() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            flowLayoutPanel1.Controls.Add(new CheckBox() { Text = textBox1.Text });
        }
    }
}
