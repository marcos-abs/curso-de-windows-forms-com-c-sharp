using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win02.Modelo;

namespace Win02 {
    public partial class CadastroFuncionario : Form {
        public CadastroFuncionario() {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {

        }

        private void SalvarAction(object sender, EventArgs e) {
            // Mover os dados da classe funcionario
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = txtNome.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Salario = decimal.Parse(txtSalario.Text);
            funcionario.Sexo = (rbMasculino.Checked) ? "M" : "F";
            funcionario.TipoContrato = (rbCLT.Checked) ? "CLT" : (rbPJ.Checked) ? "PJ":"AUT";
            funcionario.DataCadastro = DateTime.Now;

            // validar os dados
            // salvar os dados
            // fechar e atualizar a TelaPrincipal
        }
    }
}
