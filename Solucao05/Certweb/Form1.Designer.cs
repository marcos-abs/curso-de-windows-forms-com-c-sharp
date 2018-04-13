namespace Certweb {
    partial class TelaInicial {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.pnDragDrop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnLinks = new System.Windows.Forms.Button();
            this.btnTarefas = new System.Windows.Forms.Button();
            this.btnPainel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnIndicador = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.CertwebSystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuSystemTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.executarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnTarefas = new Certweb.Tarefas();
            this.pnSobre = new Certweb.Sobre();
            this.pnPainel = new Certweb.Painel();
            this.pnLinks = new Certweb.Links();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuSystemTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDragDrop
            // 
            this.pnDragDrop.BackColor = System.Drawing.Color.Purple;
            resources.ApplyResources(this.pnDragDrop, "pnDragDrop");
            this.pnDragDrop.Name = "pnDragDrop";
            this.pnDragDrop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnDragDrop_MouseDown);
            this.pnDragDrop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnDragDrop_MouseMove);
            this.pnDragDrop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnDragDrop_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.btnSobre);
            this.panel2.Controls.Add(this.btnLinks);
            this.panel2.Controls.Add(this.btnTarefas);
            this.panel2.Controls.Add(this.btnPainel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pnIndicador);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnSobre.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSobre, "btnSobre");
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.UseVisualStyleBackColor = false;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnLinks
            // 
            this.btnLinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnLinks.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnLinks, "btnLinks");
            this.btnLinks.ForeColor = System.Drawing.Color.White;
            this.btnLinks.Name = "btnLinks";
            this.btnLinks.UseVisualStyleBackColor = false;
            this.btnLinks.Click += new System.EventHandler(this.btnLinks_Click);
            // 
            // btnTarefas
            // 
            this.btnTarefas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnTarefas.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnTarefas, "btnTarefas");
            this.btnTarefas.ForeColor = System.Drawing.Color.White;
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.UseVisualStyleBackColor = false;
            this.btnTarefas.Click += new System.EventHandler(this.btnTarefas_Click);
            // 
            // btnPainel
            // 
            this.btnPainel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnPainel.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnPainel, "btnPainel");
            this.btnPainel.ForeColor = System.Drawing.Color.White;
            this.btnPainel.Name = "btnPainel";
            this.btnPainel.UseVisualStyleBackColor = false;
            this.btnPainel.Click += new System.EventHandler(this.btnPainel_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pnIndicador
            // 
            this.pnIndicador.BackColor = System.Drawing.Color.Purple;
            resources.ApplyResources(this.pnIndicador, "pnIndicador");
            this.pnIndicador.Name = "pnIndicador";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnFechar, "btnFechar");
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // CertwebSystemTray
            // 
            this.CertwebSystemTray.ContextMenuStrip = this.MenuSystemTray;
            resources.ApplyResources(this.CertwebSystemTray, "CertwebSystemTray");
            // 
            // MenuSystemTray
            // 
            this.MenuSystemTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executarToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.MenuSystemTray.Name = "contextMenuStrip1";
            resources.ApplyResources(this.MenuSystemTray, "MenuSystemTray");
            // 
            // executarToolStripMenuItem
            // 
            this.executarToolStripMenuItem.Name = "executarToolStripMenuItem";
            resources.ApplyResources(this.executarToolStripMenuItem, "executarToolStripMenuItem");
            this.executarToolStripMenuItem.Click += new System.EventHandler(this.ExecutarTarefas);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            resources.ApplyResources(this.fecharToolStripMenuItem, "fecharToolStripMenuItem");
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pnTarefas
            // 
            resources.ApplyResources(this.pnTarefas, "pnTarefas");
            this.pnTarefas.Name = "pnTarefas";
            // 
            // pnSobre
            // 
            this.pnSobre.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pnSobre, "pnSobre");
            this.pnSobre.Name = "pnSobre";
            // 
            // pnPainel
            // 
            resources.ApplyResources(this.pnPainel, "pnPainel");
            this.pnPainel.Name = "pnPainel";
            // 
            // pnLinks
            // 
            resources.ApplyResources(this.pnLinks, "pnLinks");
            this.pnLinks.Name = "pnLinks";
            // 
            // TelaInicial
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnTarefas);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnDragDrop);
            this.Controls.Add(this.pnSobre);
            this.Controls.Add(this.pnPainel);
            this.Controls.Add(this.pnLinks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaInicial";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuSystemTray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnDragDrop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPainel;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnLinks;
        private System.Windows.Forms.Button btnTarefas;
        private System.Windows.Forms.Button btnFechar;
        private Links pnLinks;
        private Painel pnPainel;
        private Sobre pnSobre;
        private Tarefas pnTarefas;
        private System.Windows.Forms.Panel pnIndicador;
        private System.Windows.Forms.ContextMenuStrip MenuSystemTray;
        private System.Windows.Forms.ToolStripMenuItem executarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        public System.Windows.Forms.NotifyIcon CertwebSystemTray;
    }
}

