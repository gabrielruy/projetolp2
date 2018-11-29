namespace Projeto_LPII.view
{
    partial class TelaRelatorios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.radioColaborador = new System.Windows.Forms.RadioButton();
            this.radioCliente = new System.Windows.Forms.RadioButton();
            this.radioProjeto = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBusca = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(473, 160);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(88, 34);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(473, 96);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 33);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "GERAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // radioColaborador
            // 
            this.radioColaborador.AutoSize = true;
            this.radioColaborador.Location = new System.Drawing.Point(201, 30);
            this.radioColaborador.Name = "radioColaborador";
            this.radioColaborador.Size = new System.Drawing.Size(134, 24);
            this.radioColaborador.TabIndex = 1;
            this.radioColaborador.TabStop = true;
            this.radioColaborador.Text = "COLABORADOR";
            this.radioColaborador.UseVisualStyleBackColor = true;
            // 
            // radioCliente
            // 
            this.radioCliente.AutoSize = true;
            this.radioCliente.Location = new System.Drawing.Point(28, 30);
            this.radioCliente.Name = "radioCliente";
            this.radioCliente.Size = new System.Drawing.Size(82, 24);
            this.radioCliente.TabIndex = 3;
            this.radioCliente.TabStop = true;
            this.radioCliente.Text = "CLIENTE";
            this.radioCliente.UseVisualStyleBackColor = true;
            // 
            // radioProjeto
            // 
            this.radioProjeto.AutoSize = true;
            this.radioProjeto.Location = new System.Drawing.Point(409, 30);
            this.radioProjeto.Name = "radioProjeto";
            this.radioProjeto.Size = new System.Drawing.Size(86, 24);
            this.radioProjeto.TabIndex = 2;
            this.radioProjeto.TabStop = true;
            this.radioProjeto.Text = "PROJETO";
            this.radioProjeto.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioColaborador);
            this.groupBox1.Controls.Add(this.radioCliente);
            this.groupBox1.Controls.Add(this.radioProjeto);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RELATÓRIOS (POR CÓDIGO)";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(12, 104);
            this.txtBusca.Mask = "00000";
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(455, 20);
            this.txtBusca.TabIndex = 5;
            this.txtBusca.ValidatingType = typeof(int);
            // 
            // TelaRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 246);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVoltar);
            this.Name = "TelaRelatorios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA GERENCIADOR DE PROJETOS - Relatórios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton radioColaborador;
        private System.Windows.Forms.RadioButton radioCliente;
        private System.Windows.Forms.RadioButton radioProjeto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtBusca;
    }
}