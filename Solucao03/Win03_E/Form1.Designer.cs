namespace Win03_E {
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
            this.tabCadastro = new System.Windows.Forms.TabControl();
            this.tabDadosPessoais = new System.Windows.Forms.TabPage();
            this.tabCarteiraDeTrabalho = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabCNH = new System.Windows.Forms.TabPage();
            this.tabCadastro.SuspendLayout();
            this.tabDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.tabDadosPessoais);
            this.tabCadastro.Controls.Add(this.tabCarteiraDeTrabalho);
            this.tabCadastro.Controls.Add(this.tabCNH);
            this.tabCadastro.Location = new System.Drawing.Point(12, 12);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.SelectedIndex = 0;
            this.tabCadastro.Size = new System.Drawing.Size(769, 279);
            this.tabCadastro.TabIndex = 0;
            // 
            // tabDadosPessoais
            // 
            this.tabDadosPessoais.Controls.Add(this.textBox2);
            this.tabDadosPessoais.Controls.Add(this.linkLabel1);
            this.tabDadosPessoais.Controls.Add(this.textBox1);
            this.tabDadosPessoais.Controls.Add(this.label1);
            this.tabDadosPessoais.Location = new System.Drawing.Point(4, 22);
            this.tabDadosPessoais.Name = "tabDadosPessoais";
            this.tabDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tabDadosPessoais.Size = new System.Drawing.Size(761, 253);
            this.tabDadosPessoais.TabIndex = 0;
            this.tabDadosPessoais.Text = "Dados Pessoais";
            this.tabDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // tabCarteiraDeTrabalho
            // 
            this.tabCarteiraDeTrabalho.Location = new System.Drawing.Point(4, 22);
            this.tabCarteiraDeTrabalho.Name = "tabCarteiraDeTrabalho";
            this.tabCarteiraDeTrabalho.Padding = new System.Windows.Forms.Padding(3);
            this.tabCarteiraDeTrabalho.Size = new System.Drawing.Size(761, 253);
            this.tabCarteiraDeTrabalho.TabIndex = 1;
            this.tabCarteiraDeTrabalho.Text = "Carteira de Trabalho";
            this.tabCarteiraDeTrabalho.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(10, 72);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // tabCNH
            // 
            this.tabCNH.Location = new System.Drawing.Point(4, 22);
            this.tabCNH.Name = "tabCNH";
            this.tabCNH.Padding = new System.Windows.Forms.Padding(3);
            this.tabCNH.Size = new System.Drawing.Size(761, 253);
            this.tabCNH.TabIndex = 2;
            this.tabCNH.Text = "CNH";
            this.tabCNH.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 440);
            this.Controls.Add(this.tabCadastro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabCadastro.ResumeLayout(false);
            this.tabDadosPessoais.ResumeLayout(false);
            this.tabDadosPessoais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCadastro;
        private System.Windows.Forms.TabPage tabDadosPessoais;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabCarteiraDeTrabalho;
        private System.Windows.Forms.TabPage tabCNH;
    }
}

