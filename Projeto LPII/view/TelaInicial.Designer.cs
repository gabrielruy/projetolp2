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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFechaSistem = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLEINTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOLABORADORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROJETOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROJETOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMANDAMENTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMSTOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rELATÓRIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gERENCIARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOLABORADORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROJETOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(12, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "SGP - SISTEMA GERENCIADOR DE PROJETOS ";
            // 
            // buttonFechaSistem
            // 
            this.buttonFechaSistem.BackColor = System.Drawing.Color.Crimson;
            this.buttonFechaSistem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechaSistem.Location = new System.Drawing.Point(566, 329);
            this.buttonFechaSistem.Name = "buttonFechaSistem";
            this.buttonFechaSistem.Size = new System.Drawing.Size(77, 36);
            this.buttonFechaSistem.TabIndex = 2;
            this.buttonFechaSistem.Text = "Sair";
            this.buttonFechaSistem.UseVisualStyleBackColor = false;
            this.buttonFechaSistem.Click += new System.EventHandler(this.buttonFechaSistem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROToolStripMenuItem,
            this.pROJETOSToolStripMenuItem,
            this.rELATÓRIOSToolStripMenuItem,
            this.gERENCIARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cADASTROToolStripMenuItem
            // 
            this.cADASTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLEINTESToolStripMenuItem,
            this.cOLABORADORESToolStripMenuItem,
            this.pROJETOToolStripMenuItem});
            this.cADASTROToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            this.cADASTROToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.cADASTROToolStripMenuItem.Text = "CADASTRAR ";
            // 
            // cLEINTESToolStripMenuItem
            // 
            this.cLEINTESToolStripMenuItem.Name = "cLEINTESToolStripMenuItem";
            this.cLEINTESToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.cLEINTESToolStripMenuItem.Text = "NOVO CLIENTE";
            this.cLEINTESToolStripMenuItem.Click += new System.EventHandler(this.cLEINTESToolStripMenuItem_Click);
            // 
            // cOLABORADORESToolStripMenuItem
            // 
            this.cOLABORADORESToolStripMenuItem.Name = "cOLABORADORESToolStripMenuItem";
            this.cOLABORADORESToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.cOLABORADORESToolStripMenuItem.Text = "NOVO COLABORADOR";
            // 
            // pROJETOToolStripMenuItem
            // 
            this.pROJETOToolStripMenuItem.Name = "pROJETOToolStripMenuItem";
            this.pROJETOToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.pROJETOToolStripMenuItem.Text = "NOVO PROJETO";
            // 
            // pROJETOSToolStripMenuItem
            // 
            this.pROJETOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eMANDAMENTOToolStripMenuItem,
            this.eMSTOPToolStripMenuItem});
            this.pROJETOSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pROJETOSToolStripMenuItem.Name = "pROJETOSToolStripMenuItem";
            this.pROJETOSToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.pROJETOSToolStripMenuItem.Text = "PROJETOS ";
            // 
            // eMANDAMENTOToolStripMenuItem
            // 
            this.eMANDAMENTOToolStripMenuItem.Name = "eMANDAMENTOToolStripMenuItem";
            this.eMANDAMENTOToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.eMANDAMENTOToolStripMenuItem.Text = "EM ANDAMENTO ";
            // 
            // eMSTOPToolStripMenuItem
            // 
            this.eMSTOPToolStripMenuItem.Name = "eMSTOPToolStripMenuItem";
            this.eMSTOPToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.eMSTOPToolStripMenuItem.Text = "EM STOP";
            // 
            // rELATÓRIOSToolStripMenuItem
            // 
            this.rELATÓRIOSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rELATÓRIOSToolStripMenuItem.Name = "rELATÓRIOSToolStripMenuItem";
            this.rELATÓRIOSToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.rELATÓRIOSToolStripMenuItem.Text = "RELATÓRIOS ";
            this.rELATÓRIOSToolStripMenuItem.Click += new System.EventHandler(this.rELATÓRIOSToolStripMenuItem_Click);
            // 
            // gERENCIARToolStripMenuItem
            // 
            this.gERENCIARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTEToolStripMenuItem,
            this.cOLABORADORToolStripMenuItem,
            this.pROJETOToolStripMenuItem1});
            this.gERENCIARToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gERENCIARToolStripMenuItem.Name = "gERENCIARToolStripMenuItem";
            this.gERENCIARToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.gERENCIARToolStripMenuItem.Text = "GERENCIAR ";
            // 
            // cLIENTEToolStripMenuItem
            // 
            this.cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
            this.cLIENTEToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.cLIENTEToolStripMenuItem.Text = "CLIENTE ";
            this.cLIENTEToolStripMenuItem.Click += new System.EventHandler(this.cLIENTEToolStripMenuItem_Click_1);
            // 
            // cOLABORADORToolStripMenuItem
            // 
            this.cOLABORADORToolStripMenuItem.Name = "cOLABORADORToolStripMenuItem";
            this.cOLABORADORToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.cOLABORADORToolStripMenuItem.Text = "COLABORADOR ";
            this.cOLABORADORToolStripMenuItem.Click += new System.EventHandler(this.cOLABORADORToolStripMenuItem_Click_1);
            // 
            // pROJETOToolStripMenuItem1
            // 
            this.pROJETOToolStripMenuItem1.Name = "pROJETOToolStripMenuItem1";
            this.pROJETOToolStripMenuItem1.Size = new System.Drawing.Size(189, 24);
            this.pROJETOToolStripMenuItem1.Text = "PROJETO";
            this.pROJETOToolStripMenuItem1.Click += new System.EventHandler(this.pROJETOToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(654, 374);
            this.Controls.Add(this.buttonFechaSistem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFechaSistem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cADASTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLEINTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOLABORADORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROJETOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rELATÓRIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROJETOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMANDAMENTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMSTOPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gERENCIARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOLABORADORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROJETOToolStripMenuItem1;
    }
}

