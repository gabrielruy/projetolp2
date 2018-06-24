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
            this.labelNovoProjeto = new System.Windows.Forms.Label();
            this.labelNomeProjeto = new System.Windows.Forms.Label();
            this.nomeProjeto = new System.Windows.Forms.TextBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.dateTimeProjeto = new System.Windows.Forms.DateTimePicker();
            this.labelInicioProjeto = new System.Windows.Forms.Label();
            this.buttonCancelarNovoProjeto = new System.Windows.Forms.Button();
            this.buttonCadastrarNovoProjeto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkColuna = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNovoProjeto
            // 
            this.labelNovoProjeto.AutoSize = true;
            this.labelNovoProjeto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNovoProjeto.Location = new System.Drawing.Point(12, 9);
            this.labelNovoProjeto.Name = "labelNovoProjeto";
            this.labelNovoProjeto.Size = new System.Drawing.Size(124, 21);
            this.labelNovoProjeto.TabIndex = 0;
            this.labelNovoProjeto.Text = "NOVO PROJETO";
            // 
            // labelNomeProjeto
            // 
            this.labelNomeProjeto.AutoSize = true;
            this.labelNomeProjeto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeProjeto.Location = new System.Drawing.Point(46, 65);
            this.labelNomeProjeto.Name = "labelNomeProjeto";
            this.labelNomeProjeto.Size = new System.Drawing.Size(128, 20);
            this.labelNomeProjeto.TabIndex = 1;
            this.labelNomeProjeto.Text = "Nome do Projeto ";
            // 
            // nomeProjeto
            // 
            this.nomeProjeto.Location = new System.Drawing.Point(180, 65);
            this.nomeProjeto.Name = "nomeProjeto";
            this.nomeProjeto.Size = new System.Drawing.Size(240, 20);
            this.nomeProjeto.TabIndex = 3;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(96, 109);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(55, 20);
            this.labelCliente.TabIndex = 4;
            this.labelCliente.Text = "Cliente";
            // 
            // dateTimeProjeto
            // 
            this.dateTimeProjeto.Location = new System.Drawing.Point(159, 42);
            this.dateTimeProjeto.Name = "dateTimeProjeto";
            this.dateTimeProjeto.Size = new System.Drawing.Size(240, 27);
            this.dateTimeProjeto.TabIndex = 8;
            this.dateTimeProjeto.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelInicioProjeto
            // 
            this.labelInicioProjeto.AutoSize = true;
            this.labelInicioProjeto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInicioProjeto.Location = new System.Drawing.Point(34, 46);
            this.labelInicioProjeto.Name = "labelInicioProjeto";
            this.labelInicioProjeto.Size = new System.Drawing.Size(119, 20);
            this.labelInicioProjeto.TabIndex = 9;
            this.labelInicioProjeto.Text = "Inicio do Projeto";
            this.labelInicioProjeto.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonCancelarNovoProjeto
            // 
            this.buttonCancelarNovoProjeto.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancelarNovoProjeto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarNovoProjeto.Location = new System.Drawing.Point(507, 622);
            this.buttonCancelarNovoProjeto.Name = "buttonCancelarNovoProjeto";
            this.buttonCancelarNovoProjeto.Size = new System.Drawing.Size(84, 34);
            this.buttonCancelarNovoProjeto.TabIndex = 18;
            this.buttonCancelarNovoProjeto.Text = "Cancelar ";
            this.buttonCancelarNovoProjeto.UseVisualStyleBackColor = false;
            this.buttonCancelarNovoProjeto.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCadastrarNovoProjeto
            // 
            this.buttonCadastrarNovoProjeto.BackColor = System.Drawing.Color.Orange;
            this.buttonCadastrarNovoProjeto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrarNovoProjeto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCadastrarNovoProjeto.Location = new System.Drawing.Point(622, 622);
            this.buttonCadastrarNovoProjeto.Name = "buttonCadastrarNovoProjeto";
            this.buttonCadastrarNovoProjeto.Size = new System.Drawing.Size(88, 33);
            this.buttonCadastrarNovoProjeto.TabIndex = 17;
            this.buttonCadastrarNovoProjeto.Text = "Salvar";
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
            this.groupBox1.Location = new System.Drawing.Point(21, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 136);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etapas";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 27);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Previsão de término ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(689, 276);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colaboradores ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Colaboradores";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.chkColuna});
            this.dataGridView1.Location = new System.Drawing.Point(159, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 187);
            this.dataGridView1.TabIndex = 11;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 200;
            // 
            // chkColuna
            // 
            this.chkColuna.HeaderText = "Selecionar";
            this.chkColuna.Name = "chkColuna";
            this.chkColuna.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkColuna.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 25;
            // 
            // Tela_cadastro_projeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 697);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancelarNovoProjeto);
            this.Controls.Add(this.buttonCadastrarNovoProjeto);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.nomeProjeto);
            this.Controls.Add(this.labelNomeProjeto);
            this.Controls.Add(this.labelNovoProjeto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tela_cadastro_projeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_cadastro_projeto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNovoProjeto;
        private System.Windows.Forms.Label labelNomeProjeto;
        private System.Windows.Forms.TextBox nomeProjeto;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.DateTimePicker dateTimeProjeto;
        private System.Windows.Forms.Label labelInicioProjeto;
        private System.Windows.Forms.Button buttonCancelarNovoProjeto;
        private System.Windows.Forms.Button buttonCadastrarNovoProjeto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkColuna;
        private System.Windows.Forms.TextBox textBox1;
    }
}