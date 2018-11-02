namespace Projeto_LPII.view
{
    partial class TelaGerenciaProjeto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInicioProjeto = new System.Windows.Forms.Label();
            this.dateTimeProjeto = new System.Windows.Forms.DateTimePicker();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelNomeProjeto = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonVoltarListarCliente = new System.Windows.Forms.Button();
            this.buttonConfirmarListagemdeClientes = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.TextBox();
            this.txtNroCliente = new System.Windows.Forms.TextBox();
            this.txtSituacao = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "Situação:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(419, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 34);
            this.button2.TabIndex = 79;
            this.button2.Text = "VOLTAR ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(548, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 179);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colaboradores ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Nome,
            this.chkColumn});
            this.dataGridView2.Location = new System.Drawing.Point(45, 37);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(406, 119);
            this.dataGridView2.TabIndex = 0;
            // 
            // codigo
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codigo.DefaultCellStyle = dataGridViewCellStyle1;
            this.codigo.HeaderText = "Cód.";
            this.codigo.Name = "codigo";
            this.codigo.Width = 45;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 245;
            // 
            // chkColumn
            // 
            this.chkColumn.HeaderText = "Selec.";
            this.chkColumn.Name = "chkColumn";
            this.chkColumn.Width = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelInicioProjeto);
            this.groupBox1.Controls.Add(this.dateTimeProjeto);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(548, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 131);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datas";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(291, 27);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Previsão de término: ";
            // 
            // labelInicioProjeto
            // 
            this.labelInicioProjeto.AutoSize = true;
            this.labelInicioProjeto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInicioProjeto.Location = new System.Drawing.Point(8, 33);
            this.labelInicioProjeto.Name = "labelInicioProjeto";
            this.labelInicioProjeto.Size = new System.Drawing.Size(122, 20);
            this.labelInicioProjeto.TabIndex = 9;
            this.labelInicioProjeto.Text = "Inicio do Projeto:";
            // 
            // dateTimeProjeto
            // 
            this.dateTimeProjeto.Location = new System.Drawing.Point(160, 28);
            this.dateTimeProjeto.Name = "dateTimeProjeto";
            this.dateTimeProjeto.Size = new System.Drawing.Size(291, 27);
            this.dateTimeProjeto.TabIndex = 0;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(544, 127);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(58, 20);
            this.labelCliente.TabIndex = 83;
            this.labelCliente.Text = "Cliente:";
            // 
            // labelNomeProjeto
            // 
            this.labelNomeProjeto.AutoSize = true;
            this.labelNomeProjeto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeProjeto.Location = new System.Drawing.Point(544, 100);
            this.labelNomeProjeto.Name = "labelNomeProjeto";
            this.labelNomeProjeto.Size = new System.Drawing.Size(57, 20);
            this.labelNomeProjeto.TabIndex = 82;
            this.labelNomeProjeto.Text = "Nome: ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(419, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 33);
            this.button3.TabIndex = 73;
            this.button3.Text = "BUSCAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(161, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 34);
            this.button1.TabIndex = 77;
            this.button1.Text = "EXCLUIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(325, 20);
            this.textBox2.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 81;
            this.label2.Text = "Nome  ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Name});
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 276);
            this.dataGridView1.TabIndex = 80;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.Width = 150;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.Width = 300;
            // 
            // buttonVoltarListarCliente
            // 
            this.buttonVoltarListarCliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonVoltarListarCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltarListarCliente.Location = new System.Drawing.Point(12, 346);
            this.buttonVoltarListarCliente.Name = "buttonVoltarListarCliente";
            this.buttonVoltarListarCliente.Size = new System.Drawing.Size(96, 34);
            this.buttonVoltarListarCliente.TabIndex = 76;
            this.buttonVoltarListarCliente.Text = "ATUALIZAR ";
            this.buttonVoltarListarCliente.UseVisualStyleBackColor = false;
            this.buttonVoltarListarCliente.Click += new System.EventHandler(this.buttonVoltarListarCliente_Click);
            // 
            // buttonConfirmarListagemdeClientes
            // 
            this.buttonConfirmarListagemdeClientes.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonConfirmarListagemdeClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmarListagemdeClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonConfirmarListagemdeClientes.Location = new System.Drawing.Point(286, 349);
            this.buttonConfirmarListagemdeClientes.Name = "buttonConfirmarListagemdeClientes";
            this.buttonConfirmarListagemdeClientes.Size = new System.Drawing.Size(88, 33);
            this.buttonConfirmarListagemdeClientes.TabIndex = 78;
            this.buttonConfirmarListagemdeClientes.Text = "CANCELAR";
            this.buttonConfirmarListagemdeClientes.UseVisualStyleBackColor = false;
            this.buttonConfirmarListagemdeClientes.Click += new System.EventHandler(this.buttonConfirmarListagemdeClientes_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(642, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(357, 20);
            this.textBox1.TabIndex = 86;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(642, 48);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(357, 20);
            this.txtCodigo.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(544, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 89;
            this.label5.Text = "Código:";
            // 
            // comboBox2
            // 
            this.comboBox2.Location = new System.Drawing.Point(716, 129);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.ReadOnly = true;
            this.comboBox2.Size = new System.Drawing.Size(283, 20);
            this.comboBox2.TabIndex = 92;
            // 
            // txtNroCliente
            // 
            this.txtNroCliente.Location = new System.Drawing.Point(642, 129);
            this.txtNroCliente.Name = "txtNroCliente";
            this.txtNroCliente.Size = new System.Drawing.Size(68, 20);
            this.txtNroCliente.TabIndex = 93;
            // 
            // txtSituacao
            // 
            this.txtSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSituacao.FormattingEnabled = true;
            this.txtSituacao.Items.AddRange(new object[] {
            "Pendente",
            "Em Andamento",
            "Pausado"});
            this.txtSituacao.Location = new System.Drawing.Point(642, 73);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(357, 21);
            this.txtSituacao.TabIndex = 94;
            // 
            // TelaGerenciaProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 496);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.txtNroCliente);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.labelNomeProjeto);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonVoltarListarCliente);
            this.Controls.Add(this.buttonConfirmarListagemdeClientes);
            //this.Name = "TelaGerenciaProjeto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA GERENCIADOR DE PROJETOS - Gerenciamento de Projetos";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInicioProjeto;
        private System.Windows.Forms.DateTimePicker dateTimeProjeto;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelNomeProjeto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonVoltarListarCliente;
        private System.Windows.Forms.Button buttonConfirmarListagemdeClientes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox comboBox2;
        private System.Windows.Forms.TextBox txtNroCliente;
        private System.Windows.Forms.ComboBox txtSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkColumn;
    }
}