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
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            Link link = new Link() { Descricao = txtDescricao.Text, Endereco = txtLink.Text };
            GerenciadorLinks.AdicionarLinks(link);
            txtDescricao.Text = "";
            txtLink.Text = "";
        }
    }
}
