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
    public partial class Painel : UserControl {
        public Painel() {
            InitializeComponent();
        }

        public void QuantidadeLinks() {
            List<Link> lista = GerenciadorLinks.LerLinks();
            lblQuantidade.Text = lista.Count.ToString();
        }
    }
}
