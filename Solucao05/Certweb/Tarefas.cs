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
using Certweb.Internet;
using System.Diagnostics;
using System.Threading;

namespace Certweb {
    public partial class Tarefas : UserControl {

        private Painel _painel;

        public Tarefas() {
            InitializeComponent();
        }

        public void SetPanels(Painel painel) {
            _painel = painel;
            CarregarLinks();
        }

        public void CarregarLinks() {
            pnFlowLinks.Controls.Clear();
            List<Link> lista = GerenciadorLinks.LerLinks();

            if (lista != null) {
                foreach (var link in lista) {
                    var pn = new FlowLayoutPanel();
                    pn.FlowDirection = FlowDirection.LeftToRight;
                    pn.Size = new Size(680, 400);
                    pn.AutoSize = true;

                    var descricao = new Label() { Text = link.Descricao, Font = new Font(Texto.FONT, 8), ForeColor = Color.FromArgb(68, 68, 68) };
                    var endereco = new Label() { Text = link.Endereco, Font = new Font(Texto.FONT, 8), ForeColor = Color.FromArgb(134, 134, 134) };

                    pn.Controls.Add(descricao);
                    pn.Controls.Add(endereco);

                    pnFlowLinks.Controls.Add(pn);
                }
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e) {
            Thread th = new Thread(Executar);
            th.IsBackground = true;
            th.Start();
        }

        private void Executar() {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            List<Link> lista = GerenciadorLinks.LerLinks();

            double TotalLinks = lista.Count;
            double LinkProcessamentoAtual = 0;
            Painel.Modelo.QuantidadeErros = 0;

            foreach (var link in lista) {
                GerenciadorDeAcesso.AcessarLink(link.Endereco);
                LinkProcessamentoAtual++;
                double Porcentagem = LinkProcessamentoAtual / TotalLinks * 100;
                if (this.InvokeRequired) {
                    Invoke(new Action(() => {
                        pnProgressBar.Value = Convert.ToInt32(Porcentagem);
                    }));
                }
            }
            sw.Stop();

            //sw.Elapsed.ToString("mm");

            Painel.Modelo.TempoDecorrido = sw.Elapsed;
            Painel.Modelo.UltimaExecucao = DateTime.Now;
            if(_painel.InvokeRequired) {
                Invoke(new Action(() => {
                    _painel.AtualizarTextoTela();
                }));
            }
            MessageBox.Show("Sucesso!");
        }
    }
}
