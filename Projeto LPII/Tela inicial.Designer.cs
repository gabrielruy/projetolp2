namespace Projeto_LPII
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirNovoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNoColaboradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarColaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoProjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProjetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFechaSistem = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(467, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.colaboradorToolStripMenuItem,
            this.projetoToolStripMenuItem});
            this.toolStripSplitButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(16, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirNovoClienteToolStripMenuItem,
            this.listarClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // incluirNovoClienteToolStripMenuItem
            // 
            this.incluirNovoClienteToolStripMenuItem.Name = "incluirNovoClienteToolStripMenuItem";
            this.incluirNovoClienteToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.incluirNovoClienteToolStripMenuItem.Text = "Cadastrar novo cliente";
            this.incluirNovoClienteToolStripMenuItem.Click += new System.EventHandler(this.incluirNovoClienteToolStripMenuItem_Click);
            // 
            // listarClienteToolStripMenuItem
            // 
            this.listarClienteToolStripMenuItem.Name = "listarClienteToolStripMenuItem";
            this.listarClienteToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.listarClienteToolStripMenuItem.Text = "Listar cliente";
            this.listarClienteToolStripMenuItem.Click += new System.EventHandler(this.listarClienteToolStripMenuItem_Click);
            // 
            // colaboradorToolStripMenuItem
            // 
            this.colaboradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNoColaboradorToolStripMenuItem,
            this.listarColaboradoresToolStripMenuItem});
            this.colaboradorToolStripMenuItem.Name = "colaboradorToolStripMenuItem";
            this.colaboradorToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.colaboradorToolStripMenuItem.Text = "Colaborador ";
            // 
            // cadastrarNoColaboradorToolStripMenuItem
            // 
            this.cadastrarNoColaboradorToolStripMenuItem.Name = "cadastrarNoColaboradorToolStripMenuItem";
            this.cadastrarNoColaboradorToolStripMenuItem.Size = new System.Drawing.Size(248, 24);
            this.cadastrarNoColaboradorToolStripMenuItem.Text = "Cadastrar no colaborador";
            this.cadastrarNoColaboradorToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNoColaboradorToolStripMenuItem_Click);
            // 
            // listarColaboradoresToolStripMenuItem
            // 
            this.listarColaboradoresToolStripMenuItem.Name = "listarColaboradoresToolStripMenuItem";
            this.listarColaboradoresToolStripMenuItem.Size = new System.Drawing.Size(248, 24);
            this.listarColaboradoresToolStripMenuItem.Text = "Listar colaboradores ";
            this.listarColaboradoresToolStripMenuItem.Click += new System.EventHandler(this.listarColaboradoresToolStripMenuItem_Click);
            // 
            // projetoToolStripMenuItem
            // 
            this.projetoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoProjetoToolStripMenuItem,
            this.listarProjetosToolStripMenuItem});
            this.projetoToolStripMenuItem.Name = "projetoToolStripMenuItem";
            this.projetoToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.projetoToolStripMenuItem.Text = "Projeto ";
            // 
            // cadastrarNovoProjetoToolStripMenuItem
            // 
            this.cadastrarNovoProjetoToolStripMenuItem.Name = "cadastrarNovoProjetoToolStripMenuItem";
            this.cadastrarNovoProjetoToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.cadastrarNovoProjetoToolStripMenuItem.Text = "Cadastrar novo projeto ";
            this.cadastrarNovoProjetoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoProjetoToolStripMenuItem_Click);
            // 
            // listarProjetosToolStripMenuItem
            // 
            this.listarProjetosToolStripMenuItem.Name = "listarProjetosToolStripMenuItem";
            this.listarProjetosToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.listarProjetosToolStripMenuItem.Text = "Listar projetos ";
            this.listarProjetosToolStripMenuItem.Click += new System.EventHandler(this.listarProjetosToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "SGP - SISTEMA GERENCIADOR DE PROJETOS ";
            // 
            // buttonFechaSistem
            // 
            this.buttonFechaSistem.BackColor = System.Drawing.Color.Crimson;
            this.buttonFechaSistem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechaSistem.Location = new System.Drawing.Point(378, 326);
            this.buttonFechaSistem.Name = "buttonFechaSistem";
            this.buttonFechaSistem.Size = new System.Drawing.Size(77, 36);
            this.buttonFechaSistem.TabIndex = 2;
            this.buttonFechaSistem.Text = "Sair";
            this.buttonFechaSistem.UseVisualStyleBackColor = false;
            this.buttonFechaSistem.Click += new System.EventHandler(this.buttonFechaSistem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 374);
            this.Controls.Add(this.buttonFechaSistem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incluirNovoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaboradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNoColaboradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarColaboradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoProjetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProjetosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFechaSistem;
    }
}

