using System;
using System.Windows.Forms;

namespace Win02 {
    public partial class TelaPrincipal : Form {
        public TelaPrincipal() {
            InitializeComponent();
            AtualizarTabela();
        }

        public void AtualizarTabela() {
            dgvTabelaFuncionario.DataSource = Banco.FuncionarioDataAccess.pegarFuncionario();
        }

        private void button2_Click(object sender, EventArgs e) {

        }

        private void NovoAction(object sender, EventArgs e) {
            new CadastroFuncionario(this).Show();
        }

        private void EditarAction(object sender, EventArgs e) {
            int id = (int) dgvTabelaFuncionario.SelectedRows[0].Cells[0].Value;
            new CadastroFuncionario(this, id).Show();
        }
    }
}
