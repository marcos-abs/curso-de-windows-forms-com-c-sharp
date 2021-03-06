﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win14 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e) {
            webBrowser.Url = new Uri(txtURL.Text);
        }

        private void webBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e) {
            //progressBar.Value = (int)e.CurrentProgress; // Erro valor superior 100 (150)
            if (e.CurrentProgress <= 0 || e.MaximumProgress <= 0) {
                progressBar.Value = 0;
            } else {
                progressBar.Value = (Convert.ToInt32(e.CurrentProgress) / Convert.ToInt32(e.MaximumProgress)) * 100;
            }
        }
    }
}
