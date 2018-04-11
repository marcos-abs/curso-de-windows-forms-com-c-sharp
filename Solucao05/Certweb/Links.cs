using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Certweb.Armazenamento.Arquivo;
using Certweb.Armazenamento.Modelo;

namespace Certweb {
    public partial class Links : UserControl {
        public Links() {
            InitializeComponent();
            CarregarLinks();
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            Link link = new Link() { Descricao = txtDescricao.Text, Endereco = txtLink.Text };
            GerenciadorLinks.AdicionarLinks(link);
            txtDescricao.Text = "";
            txtLink.Text = "";
            CarregarLinks();
        }

        private void CarregarLinks() {
            pnFlowLinks.Controls.Clear();
            List<Link> lista = GerenciadorLinks.LerLinks();

            foreach (var link in lista) {
                var pn = new FlowLayoutPanel();
                pn.FlowDirection = FlowDirection.LeftToRight;
                pn.Size = new Size(680, 400);
                pn.AutoSize = true;

                var descricao = new Label() { Text = link.Descricao, Font = new Font("Century Gothic", 8), ForeColor = Color.FromArgb(68, 68, 68) };
                //
                var endereco = new Label() { Text = link.Endereco, Font = new Font("Century Gothic", 8), ForeColor = Color.FromArgb(134, 134, 134) };
                //
                var btnEditar = new LinkLabel() { Text = "Editar", Font = new Font("Century Gothic", 8) };
                //
                var btnExcluir = new LinkLabel() { Text = "Excluir", Font = new Font("Century Gothic", 8) };
                // 

                pn.Controls.Add(descricao);
                pn.Controls.Add(endereco);
                pn.Controls.Add(btnEditar);
                pn.Controls.Add(btnExcluir);

                pnFlowLinks.Controls.Add(pn);

                btnEditar.Click += delegate {
                    EditarAction(link);
                };

                btnExcluir.Click += delegate {
                    ExcluirAction(link);
                };
            }
        }

        private void EditarAction(Link link) {

        }

        private void ExcluirAction(Link link) {
            GerenciadorLinks.RemoverLinks(link);
            CarregarLinks();
        }


        private void txtDescricao_Enter(object sender, EventArgs e) {
            var campo = (TextBox)sender;
            if(campo.Text == "Descrição") {
                campo.Text = "";
                campo.ForeColor = Color.Black;
            }
        }

        private void txtDescricao_Leave(object sender, EventArgs e) {
            var campo = (TextBox)sender;
            if (campo.Text == "") {
                campo.Text = "Descrição";
                campo.ForeColor = Color.FromArgb(68, 68, 68);
            }
        }

        private void txtLink_Enter(object sender, EventArgs e) {
            var campo = (TextBox)sender;
            if (campo.Text == "URL do site") {
                campo.Text = "";
                campo.ForeColor = Color.Black;
            }
        }

        private void txtLink_Leave(object sender, EventArgs e) {
            var campo = (TextBox)sender;
            if (campo.Text == "") {
                campo.Text = "URL do site";
                campo.ForeColor = Color.FromArgb(68, 68, 68);
            }
        }
    }
}
