﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win02.Modelo;
using System.ComponentModel.DataAnnotations;

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
            List<ValidationResult> listErros = new List<ValidationResult>();
            ValidationContext contexto = new ValidationContext(funcionario);
            bool validado = Validator.TryValidateObject(funcionario, contexto, listErros, true);
            if (validado) {
                // validacao ok.

                // salvar os dados

                // fechar e atualizar a TelaPrincipal

            } else {
                //validacao erro.
                StringBuilder sb = new StringBuilder();
                foreach (ValidationResult erro in listErros) {
                    sb.Append(erro.ErrorMessage + "\n");
                }
                lblErros.Text = sb.ToString();
            }
        }
    }
}
