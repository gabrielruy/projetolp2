namespace Projeto_LPII.view
{
    partial class TelaGerenciaColaboradores
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonVoltarListarCliente = new System.Windows.Forms.Button();
            this.buttonConfirmarListagemdeClientes = new System.Windows.Forms.Button();
            this.txtRegistroRh = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxLoginSenhaColaborador = new System.Windows.Forms.GroupBox();
            this.labelLoginColaborador = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.labelSenhaColaborador = new System.Windows.Forms.Label();
            this.labelNroRegistroColaborador = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTelefoneColaborador = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelEmailColaborador = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelNomeColaborador = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFuncao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxLoginSenhaColaborador.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(419, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 33);
            this.button3.TabIndex = 57;
            this.button3.Text = "BUSCAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(431, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 34);
            this.button2.TabIndex = 67;
            this.button2.Text = "VOLTAR ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(169, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 34);
            this.button1.TabIndex = 65;
            this.button1.Text = "EXCLUIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(327, 20);
            this.textBox2.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 69;
            this.label2.Text = " Nome:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nome});
            this.dataGridView1.Location = new System.Drawing.Point(20, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 276);
            this.dataGridView1.TabIndex = 68;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.Width = 130;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 300;
            // 
            // buttonVoltarListarCliente
            // 
            this.buttonVoltarListarCliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonVoltarListarCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltarListarCliente.Location = new System.Drawing.Point(20, 347);
            this.buttonVoltarListarCliente.Name = "buttonVoltarListarCliente";
            this.buttonVoltarListarCliente.Size = new System.Drawing.Size(96, 34);
            this.buttonVoltarListarCliente.TabIndex = 64;
            this.buttonVoltarListarCliente.Text = "ATUALIZAR ";
            this.buttonVoltarListarCliente.UseVisualStyleBackColor = false;
            this.buttonVoltarListarCliente.Click += new System.EventHandler(this.buttonVoltarListarCliente_Click);
            // 
            // buttonConfirmarListagemdeClientes
            // 
            this.buttonConfirmarListagemdeClientes.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonConfirmarListagemdeClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmarListagemdeClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonConfirmarListagemdeClientes.Location = new System.Drawing.Point(301, 348);
            this.buttonConfirmarListagemdeClientes.Name = "buttonConfirmarListagemdeClientes";
            this.buttonConfirmarListagemdeClientes.Size = new System.Drawing.Size(88, 33);
            this.buttonConfirmarListagemdeClientes.TabIndex = 66;
            this.buttonConfirmarListagemdeClientes.Text = "CANCELAR";
            this.buttonConfirmarListagemdeClientes.UseVisualStyleBackColor = false;
            this.buttonConfirmarListagemdeClientes.Click += new System.EventHandler(this.buttonConfirmarListagemdeClientes_Click);
            // 
            // txtRegistroRh
            // 
            this.txtRegistroRh.Location = new System.Drawing.Point(655, 176);
            this.txtRegistroRh.Mask = "00000";
            this.txtRegistroRh.Name = "txtRegistroRh";
            this.txtRegistroRh.Size = new System.Drawing.Size(269, 20);
            this.txtRegistroRh.TabIndex = 83;
            this.txtRegistroRh.ValidatingType = typeof(int);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(655, 124);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(269, 20);
            this.txtTelefone.TabIndex = 82;
            // 
            // groupBoxLoginSenhaColaborador
            // 
            this.groupBoxLoginSenhaColaborador.Controls.Add(this.labelLoginColaborador);
            this.groupBoxLoginSenhaColaborador.Controls.Add(this.txtLogin);
            this.groupBoxLoginSenhaColaborador.Controls.Add(this.txtSenha);
            this.groupBoxLoginSenhaColaborador.Controls.Add(this.labelSenhaColaborador);
            this.groupBoxLoginSenhaColaborador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLoginSenhaColaborador.Location = new System.Drawing.Point(552, 212);
            this.groupBoxLoginSenhaColaborador.Name = "groupBoxLoginSenhaColaborador";
            this.groupBoxLoginSenhaColaborador.Size = new System.Drawing.Size(383, 75);
            this.groupBoxLoginSenhaColaborador.TabIndex = 81;
            this.groupBoxLoginSenhaColaborador.TabStop = false;
            this.groupBoxLoginSenhaColaborador.Text = "Defina seu login e senha";
            // 
            // labelLoginColaborador
            // 
            this.labelLoginColaborador.AutoSize = true;
            this.labelLoginColaborador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginColaborador.Location = new System.Drawing.Point(19, 32);
            this.labelLoginColaborador.Name = "labelLoginColaborador";
            this.labelLoginColaborador.Size = new System.Drawing.Size(49, 20);
            this.labelLoginColaborador.TabIndex = 20;
            this.labelLoginColaborador.Text = "Login:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(103, 25);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(99, 27);
            this.txtLogin.TabIndex = 13;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(277, 25);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(95, 27);
            this.txtSenha.TabIndex = 14;
            // 
            // labelSenhaColaborador
            // 
            this.labelSenhaColaborador.AutoSize = true;
            this.labelSenhaColaborador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenhaColaborador.Location = new System.Drawing.Point(219, 32);
            this.labelSenhaColaborador.Name = "labelSenhaColaborador";
            this.labelSenhaColaborador.Size = new System.Drawing.Size(52, 20);
            this.labelSenhaColaborador.TabIndex = 12;
            this.labelSenhaColaborador.Text = "Senha:";
            // 
            // labelNroRegistroColaborador
            // 
            this.labelNroRegistroColaborador.AutoSize = true;
            this.labelNroRegistroColaborador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroRegistroColaborador.Location = new System.Drawing.Point(551, 174);
            this.labelNroRegistroColaborador.Name = "labelNroRegistroColaborador";
            this.labelNroRegistroColaborador.Size = new System.Drawing.Size(98, 20);
            this.labelNroRegistroColaborador.TabIndex = 80;
            this.labelNroRegistroColaborador.Text = "Nr. Reg. (RH):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(553, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "Função:";
            // 
            // labelTelefoneColaborador
            // 
            this.labelTelefoneColaborador.AutoSize = true;
            this.labelTelefoneColaborador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefoneColaborador.Location = new System.Drawing.Point(551, 122);
            this.labelTelefoneColaborador.Name = "labelTelefoneColaborador";
            this.labelTelefoneColaborador.Size = new System.Drawing.Size(69, 20);
            this.labelTelefoneColaborador.TabIndex = 78;
            this.labelTelefoneColaborador.Text = "Telefone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(655, 98);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(269, 20);
            this.txtEmail.TabIndex = 77;
            // 
            // labelEmailColaborador
            // 
            this.labelEmailColaborador.AutoSize = true;
            this.labelEmailColaborador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailColaborador.Location = new System.Drawing.Point(551, 96);
            this.labelEmailColaborador.Name = "labelEmailColaborador";
            this.labelEmailColaborador.Size = new System.Drawing.Size(55, 20);
            this.labelEmailColaborador.TabIndex = 76;
            this.labelEmailColaborador.Text = "E-mail:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(655, 72);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(269, 20);
            this.txtNome.TabIndex = 75;
            // 
            // labelNomeColaborador
            // 
            this.labelNomeColaborador.AutoSize = true;
            this.labelNomeColaborador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeColaborador.Location = new System.Drawing.Point(551, 70);
            this.labelNomeColaborador.Name = "labelNomeColaborador";
            this.labelNomeColaborador.Size = new System.Drawing.Size(53, 20);
            this.labelNomeColaborador.TabIndex = 74;
            this.labelNomeColaborador.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(655, 46);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(269, 20);
            this.txtCodigo.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(551, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "Código:";
            // 
            // txtFuncao
            // 
            this.txtFuncao.Location = new System.Drawing.Point(655, 150);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(269, 20);
            this.txtFuncao.TabIndex = 87;
            // 
            // TelaGerenciaColaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 419);
            this.Controls.Add(this.txtFuncao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegistroRh);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.groupBoxLoginSenhaColaborador);
            this.Controls.Add(this.labelNroRegistroColaborador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTelefoneColaborador);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelEmailColaborador);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelNomeColaborador);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonVoltarListarCliente);
            this.Controls.Add(this.buttonConfirmarListagemdeClientes);
            this.Name = "TelaGerenciaColaboradores";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA GERENCIADOR DE PROJETOS - Gerenciamento de Colaboradores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxLoginSenhaColaborador.ResumeLayout(false);
            this.groupBoxLoginSenhaColaborador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonVoltarListarCliente;
        private System.Windows.Forms.Button buttonConfirmarListagemdeClientes;
        private System.Windows.Forms.MaskedTextBox txtRegistroRh;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.GroupBox groupBoxLoginSenhaColaborador;
        private System.Windows.Forms.Label labelLoginColaborador;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label labelSenhaColaborador;
        private System.Windows.Forms.Label labelNroRegistroColaborador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTelefoneColaborador;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelEmailColaborador;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelNomeColaborador;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFuncao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}