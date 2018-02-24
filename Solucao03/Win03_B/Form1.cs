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

            foreach (CheckBox check in gbLinguagem.Controls) {
                check.CheckedChanged += delegate (object sender, EventArgs args) {
                    Verificar();
                };
            }
        }

        private void Verificar() {
            StringBuilder sb = new StringBuilder();

            foreach(CheckBox check in gbLinguagem.Controls) {
                if (check.Checked == true) {
                    sb.Append(check.Text + " - ");
                }
            }
            lblLinguagens.Text = sb.ToString();
        }
    }
}
