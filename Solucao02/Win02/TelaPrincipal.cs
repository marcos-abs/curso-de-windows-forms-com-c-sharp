using System;
using System.Windows.Forms;

namespace Win02 {
    public partial class TelaPrincipal : Form {
        public TelaPrincipal() {
            InitializeComponent();
            dgvTabelaFuncionario.DataSource = Banco.FuncionarioDataAccess.pegarFuncionario();
        }

        private void button2_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }
    }
}
