namespace Certweb {
    partial class Form1 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.pnDragDrop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDragDrop.Location = new System.Drawing.Point(0, 0);
            this.pnDragDrop.Name = "pnDragDrop";
            this.pnDragDrop.Size = new System.Drawing.Size(1036, 15);
            this.pnDragDrop.TabIndex = 0;
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 605);
            this.panel2.TabIndex = 1;
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.Image = ((System.Drawing.Image)(resources.GetObject("btnSobre.Image")));
            this.btnSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobre.Location = new System.Drawing.Point(46, 499);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(183, 70);
            this.btnSobre.TabIndex = 4;
            this.btnSobre.Text = "      Sobre";
            this.btnSobre.UseVisualStyleBackColor = false;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnLinks
            // 
            this.btnLinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnLinks.FlatAppearance.BorderSize = 0;
            this.btnLinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinks.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinks.ForeColor = System.Drawing.Color.White;
            this.btnLinks.Image = ((System.Drawing.Image)(resources.GetObject("btnLinks.Image")));
            this.btnLinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLinks.Location = new System.Drawing.Point(46, 415);
            this.btnLinks.Name = "btnLinks";
            this.btnLinks.Size = new System.Drawing.Size(183, 70);
            this.btnLinks.TabIndex = 3;
            this.btnLinks.Text = "     Links";
            this.btnLinks.UseVisualStyleBackColor = false;
            this.btnLinks.Click += new System.EventHandler(this.btnLinks_Click);
            // 
            // btnTarefas
            // 
            this.btnTarefas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnTarefas.FlatAppearance.BorderSize = 0;
            this.btnTarefas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarefas.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarefas.ForeColor = System.Drawing.Color.White;
            this.btnTarefas.Image = ((System.Drawing.Image)(resources.GetObject("btnTarefas.Image")));
            this.btnTarefas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTarefas.Location = new System.Drawing.Point(46, 331);
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.Size = new System.Drawing.Size(183, 70);
            this.btnTarefas.TabIndex = 2;
            this.btnTarefas.Text = "        Tarefas";
            this.btnTarefas.UseVisualStyleBackColor = false;
            this.btnTarefas.Click += new System.EventHandler(this.btnTarefas_Click);
            // 
            // btnPainel
            // 
            this.btnPainel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnPainel.FlatAppearance.BorderSize = 0;
            this.btnPainel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPainel.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPainel.ForeColor = System.Drawing.Color.White;
            this.btnPainel.Image = ((System.Drawing.Image)(resources.GetObject("btnPainel.Image")));
            this.btnPainel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPainel.Location = new System.Drawing.Point(46, 247);
            this.btnPainel.Name = "btnPainel";
            this.btnPainel.Size = new System.Drawing.Size(183, 70);
            this.btnPainel.TabIndex = 1;
            this.btnPainel.Text = "      Painel";
            this.btnPainel.UseVisualStyleBackColor = false;
            this.btnPainel.Click += new System.EventHandler(this.btnPainel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnIndicador
            // 
            this.pnIndicador.BackColor = System.Drawing.Color.Purple;
            this.pnIndicador.Location = new System.Drawing.Point(18, 247);
            this.pnIndicador.Name = "pnIndicador";
            this.pnIndicador.Size = new System.Drawing.Size(10, 70);
            this.pnIndicador.TabIndex = 7;
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(1005, 15);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(31, 38);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // CertwebSystemTray
            // 
            this.CertwebSystemTray.ContextMenuStrip = this.MenuSystemTray;
            this.CertwebSystemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("CertwebSystemTray.Icon")));
            this.CertwebSystemTray.Text = "Certweb Programa";
            this.CertwebSystemTray.Visible = true;
            // 
            // MenuSystemTray
            // 
            this.MenuSystemTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executarToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.MenuSystemTray.Name = "contextMenuStrip1";
            this.MenuSystemTray.Size = new System.Drawing.Size(119, 48);
            // 
            // executarToolStripMenuItem
            // 
            this.executarToolStripMenuItem.Name = "executarToolStripMenuItem";
            this.executarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.executarToolStripMenuItem.Text = "Executar";
            this.executarToolStripMenuItem.Click += new System.EventHandler(this.ExecutarTarefas);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pnTarefas
            // 
            this.pnTarefas.Location = new System.Drawing.Point(269, 15);
            this.pnTarefas.Name = "pnTarefas";
            this.pnTarefas.Size = new System.Drawing.Size(734, 602);
            this.pnTarefas.TabIndex = 6;
            // 
            // pnSobre
            // 
            this.pnSobre.BackColor = System.Drawing.Color.White;
            this.pnSobre.Location = new System.Drawing.Point(269, 15);
            this.pnSobre.Name = "pnSobre";
            this.pnSobre.Size = new System.Drawing.Size(767, 605);
            this.pnSobre.TabIndex = 5;
            // 
            // pnPainel
            // 
            this.pnPainel.Location = new System.Drawing.Point(269, 15);
            this.pnPainel.Name = "pnPainel";
            this.pnPainel.Size = new System.Drawing.Size(946, 605);
            this.pnPainel.TabIndex = 4;
            // 
            // pnLinks
            // 
            this.pnLinks.Location = new System.Drawing.Point(269, 15);
            this.pnLinks.Name = "pnLinks";
            this.pnLinks.Size = new System.Drawing.Size(734, 602);
            this.pnLinks.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 620);
            this.Controls.Add(this.pnTarefas);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnDragDrop);
            this.Controls.Add(this.pnSobre);
            this.Controls.Add(this.pnPainel);
            this.Controls.Add(this.pnLinks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
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

