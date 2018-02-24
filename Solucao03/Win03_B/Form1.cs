using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win03_B {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            foreach (RadioButton radio in gbContrato.Controls) {
                radio.CheckedChanged += delegate (object sender, EventArgs args) {
                    lblTipoContrato.Text = ((RadioButton)sender).Text;
                };
            }
            //gbLinguagem.Controls
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) {

        }
    }
}
