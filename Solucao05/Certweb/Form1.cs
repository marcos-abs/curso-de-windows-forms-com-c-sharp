using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Certweb.Armazenamento.Arquivo;

namespace Certweb {
    public partial class Form1 : Form {
        public Form1() {
            GerenciadorLinks.LerLinks();
            InitializeComponent();
            PainelVisivel(pnPainel);
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            GerenciadorLinks.SalvarLinks();
            GerenciadorTelaPainel.SalvarDados(Painel.Modelo);
            Application.Exit();
        }

        private void btnTarefas_Click(object sender, EventArgs e) {
            MoverIndicador((Button)sender);
            PainelVisivel(pnTarefas);
        }

        private void btnLinks_Click(object sender, EventArgs e) {
            MoverIndicador((Button)sender);
            PainelVisivel(pnLinks);
        }

        private void btnSobre_Click(object sender, EventArgs e) {
            MoverIndicador((Button)sender);
            PainelVisivel(pnSobre);
        }

        private void btnPainel_Click(object sender, EventArgs e) {
            MoverIndicador((Button)sender);
            PainelVisivel(pnPainel);
        }

        private void MoverIndicador(Button btnMenu) {
            pnIndicador.Location = new Point(pnIndicador.Location.X, btnMenu.Location.Y);
        }

        // Refatorado
        private void PainelVisivel(UserControl pn) {

            pnPainel.Visible = false;
            pnLinks.Visible = false;
            pnSobre.Visible = false;
            pnTarefas.Visible = false;

            pn.Visible = true;
        }

        private bool BotaoMousePressionado = false;
        private Point PontoInicialFormulario;
        private Point PontoInicialCursor;

        private void pnDragDrop_MouseDown(object sender, MouseEventArgs e) {
            BotaoMousePressionado = true;
            PontoInicialFormulario = this.Location;
            PontoInicialCursor = Cursor.Position;
        }

        private void pnDragDrop_MouseUp(object sender, MouseEventArgs e) {
            BotaoMousePressionado = false;
        }

        private void pnDragDrop_MouseMove(object sender, MouseEventArgs e) {
            if(BotaoMousePressionado == true) {
                Point dif = Point.Subtract(Cursor.Position, new Size(PontoInicialCursor));
                this.Location = Point.Add(PontoInicialFormulario, new Size(dif));
            }
        }
    }
}
