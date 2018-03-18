using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certweb {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            pnPainel.Visible = true;
            pnLinks.Visible = false;
            pnSobre.Visible = false;
            pnTarefas.Visible = false;
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnTarefas_Click(object sender, EventArgs e) {
            MoverIndicador((Button)sender);
            pnPainel.Visible = false;
            pnLinks.Visible = false;
            pnSobre.Visible = false;
            pnTarefas.Visible = true;
        }

        private void btnLinks_Click(object sender, EventArgs e) {
            MoverIndicador((Button)sender);
            pnPainel.Visible = false;
            pnLinks.Visible = true;
            pnSobre.Visible = false;
            pnTarefas.Visible = false;
        }

        private void btnSobre_Click(object sender, EventArgs e) {
            MoverIndicador((Button)sender);
            pnPainel.Visible = false;
            pnLinks.Visible = false;
            pnSobre.Visible = true;
            pnTarefas.Visible = false;
        }

        private void btnPainel_Click(object sender, EventArgs e) {
            MoverIndicador((Button)sender);
            pnPainel.Visible = true;
            pnLinks.Visible = false;
            pnSobre.Visible = false;
            pnTarefas.Visible = false;
        }

        private void MoverIndicador(Button btnMenu) {
            pnIndicador.Location = new Point(pnIndicador.Location.X, btnMenu.Location.Y);
        }
    }
}
