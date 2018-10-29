namespace Projeto_LPII
{
    partial class Tela_cadastro_projeto
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
            this.labelNomeProjeto = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.dateTimeProjeto = new System.Windows.Forms.DateTimePicker();
            this.labelInicioProjeto = new System.Windows.Forms.Label();
            this.buttonCancelarNovoProjeto = new System.Windows.Forms.Button();
            this.buttonCadastrarNovoProjeto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkColuna = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtCliente = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomeProjeto
            // 
            this.labelNomeProjeto.AutoSize = true;
            this.labelNomeProjeto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeProjeto.Location = new System.Drawing.Point(12, 9);
            this.labelNomeProjeto.Name = "labelNomeProjeto";
            this.labelNomeProjeto.Size = new System.Drawing.Size(57, 20);
            this.labelNomeProjeto.TabIndex = 1;
            this.labelNomeProjeto.Text = "Nome: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(167, 11);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(506, 20);
            this.txtNome.TabIndex = 2;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(12, 35);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(136, 20);
            this.labelCliente.TabIndex = 4;
            this.labelCliente.Text = "Número do cliente:";
            // 
            // dateTimeProjeto
            // 
            this.dateTimeProjeto.Location = new System.Drawing.Point(155, 29);
            this.dateTimeProjeto.Name = "dateTimeProjeto";
            this.dateTimeProjeto.Size = new System.Drawing.Size(506, 27);
            this.dateTimeProjeto.TabIndex = 8;
            // 
            // labelInicioProjeto
            // 
            this.labelInicioProjeto.AutoSize = true;
            this.labelInicioProjeto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInicioProjeto.Location = new System.Drawing.Point(5, 31);
            this.labelInicioProjeto.Name = "labelInicioProjeto";
            this.labelInicioProjeto.Size = new System.Drawing.Size(128, 20);
            this.labelInicioProjeto.TabIndex = 9;
            this.labelInicioProjeto.Text = "Previsão de início:";
            // 
            // buttonCancelarNovoProjeto
            // 
            this.buttonCancelarNovoProjeto.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCancelarNovoProjeto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarNovoProjeto.Location = new System.Drawing.Point(491, 439);
            this.buttonCancelarNovoProjeto.Name = "buttonCancelarNovoProjeto";
            this.buttonCancelarNovoProjeto.Size = new System.Drawing.Size(84, 34);
            this.buttonCancelarNovoProjeto.TabIndex = 7;
            this.buttonCancelarNovoProjeto.Text = "CANCELAR";
            this.buttonCancelarNovoProjeto.UseVisualStyleBackColor = false;
            this.buttonCancelarNovoProjeto.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCadastrarNovoProjeto
            // 
            this.buttonCadastrarNovoProjeto.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCadastrarNovoProjeto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrarNovoProjeto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCadastrarNovoProjeto.Location = new System.Drawing.Point(585, 440);
            this.buttonCadastrarNovoProjeto.Name = "buttonCadastrarNovoProjeto";
            this.buttonCadastrarNovoProjeto.Size = new System.Drawing.Size(88, 33);
            this.buttonCadastrarNovoProjeto.TabIndex = 6;
            this.buttonCadastrarNovoProjeto.Text = "CADASTRAR";
            this.buttonCadastrarNovoProjeto.UseVisualStyleBackColor = false;
            this.buttonCadastrarNovoProjeto.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelInicioProjeto);
            this.groupBox1.Controls.Add(this.dateTimeProjeto);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 108);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(506, 27);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Previsão de término:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(689, 236);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colaboradores ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nome,
            this.chkColuna});
            this.dataGridView1.Location = new System.Drawing.Point(19, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 187);
            this.dataGridView1.TabIndex = 1;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 380;
            // 
            // chkColuna
            // 
            this.chkColuna.HeaderText = "Selecionar";
            this.chkColuna.Name = "chkColuna";
            this.chkColuna.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkColuna.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(167, 37);
            this.txtCliente.Mask = "00000";
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(506, 20);
            this.txtCliente.TabIndex = 9;
            this.txtCliente.ValidatingType = typeof(int);
            // 
            // Tela_cadastro_projeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 488);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancelarNovoProjeto);
            this.Controls.Add(this.buttonCadastrarNovoProjeto);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelNomeProjeto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tela_cadastro_projeto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA GERENCIADOR DE PROJETOS - Cadastro de Projeto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNomeProjeto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.DateTimePicker dateTimeProjeto;
        private System.Windows.Forms.Label labelInicioProjeto;
        private System.Windows.Forms.Button buttonCancelarNovoProjeto;
        private System.Windows.Forms.Button buttonCadastrarNovoProjeto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkColuna;
        private System.Windows.Forms.MaskedTextBox txtCliente;
    }
}