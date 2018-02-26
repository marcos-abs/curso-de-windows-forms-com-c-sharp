namespace Win13 {
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Arquivos de Programas");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Arquivos de Programas (x86)");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Usuários");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Windows");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("C:\\", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("D:\\");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Backup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            treeNode7.Name = "ArquivosDeProgramas";
            treeNode7.Text = "Arquivos de Programas";
            treeNode8.Name = "ArquivosDeProgramasX86";
            treeNode8.Text = "Arquivos de Programas (x86)";
            treeNode9.Name = "Usuarios";
            treeNode9.Text = "Usuários";
            treeNode10.Name = "Windows";
            treeNode10.Text = "Windows";
            treeNode11.Name = "Unidade_C";
            treeNode11.Text = "C:\\";
            treeNode12.Name = "Unidade_D";
            treeNode12.Text = "D:\\";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(229, 121);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            // 
            // Backup
            // 
            this.Backup.Location = new System.Drawing.Point(303, 103);
            this.Backup.Name = "Backup";
            this.Backup.Size = new System.Drawing.Size(75, 23);
            this.Backup.TabIndex = 1;
            this.Backup.Text = "Backup";
            this.Backup.UseVisualStyleBackColor = true;
            this.Backup.Click += new System.EventHandler(this.Backup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Backup);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button Backup;
        private System.Windows.Forms.Label label1;
    }
}

