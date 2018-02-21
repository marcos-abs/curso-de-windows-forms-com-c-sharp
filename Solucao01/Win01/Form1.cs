using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void ClickAction(object sender, EventArgs e) {
            string frase = string.Format("Olá {0}!", txtNome.Text);
            MessageBox.Show(frase, "Bem vindo!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
