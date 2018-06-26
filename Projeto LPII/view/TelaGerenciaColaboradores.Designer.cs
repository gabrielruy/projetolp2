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
            this.labelcolaboradores = new System.Windows.Forms.Label();
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
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(427, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 33);
            this.button3.TabIndex = 57;
            this.button3.Text = "BUSCAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(431, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 34);
            this.button2.TabIndex = 67;
            this.button2.Text = "VOLTAR ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(169, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 34);
            this.button1.TabIndex = 65;
            this.button1.Text = "EXCLUIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(327, 20);
            this.textBox2.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 69;
            this.label2.Text = " Nome";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nome});
            this.dataGridView1.Location = new System.Drawing.Point(20, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 276);
            this.dataGridView1.TabIndex = 68;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.Width = 150;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 300;
            // 
            // buttonVoltarListarCliente
            // 
            this.buttonVoltarListarCliente.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonVoltarListarCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltarListarCliente.Location = new System.Drawing.Point(20, 419);
            this.buttonVoltarListarCliente.Name = "buttonVoltarListarCliente";
            this.buttonVoltarListarCliente.Size = new System.Drawing.Size(96, 34);
            this.buttonVoltarListarCliente.TabIndex = 64;
            this.buttonVoltarListarCliente.Text = "ATUALIZAR ";
            this.buttonVoltarListarCliente.UseVisualStyleBackColor = false;
            this.buttonVoltarListarCliente.Click += new System.EventHandler(this.buttonVoltarListarCliente_Click);
            // 
            // buttonConfirmarListagemdeClientes
            // 
            this.buttonConfirmarListagemdeClientes.BackColor = System.Drawing.Color.Crimson;
            this.buttonConfirmarListagemdeClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmarListagemdeClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonConfirmarListagemdeClientes.Location = new System.Drawing.Point(301, 420);
            this.buttonConfirmarListagemdeClientes.Name = "buttonConfirmarListagemdeClientes";
            this.buttonConfirmarListagemdeClientes.Size = new System.Drawing.Size(88, 33);
            this.buttonConfirmarListagemdeClientes.TabIndex = 66;
            this.buttonConfirmarListagemdeClientes.Text = "CANCELAR";
            this.buttonConfirmarListagemdeClientes.UseVisualStyleBackColor = false;
            this.buttonConfirmarListagemdeClientes.Click += new System.EventHandler(this.buttonConfirmarListagemdeClientes_Click);
            // 
            // labelcolaboradores
            // 
            this.labelcolaboradores.AutoSize = true;
            this.labelcolaboradores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcolaboradores.Location = new System.Drawing.Point(12, 9);
            this.labelcolaboradores.Name = "labelcolaboradores";
            this.labelcolaboradores.Size = new System.Drawing.Size(223, 21);
            this.labelcolaboradores.TabIndex = 73;
            this.labelcolaboradores.Text = "GERENCIAR COLABORADOR   ";
            // 
            // txtRegistroRh
            // 
            this.txtRegistroRh.Location = new System.Drawing.Point(702, 230);
            this.txtRegistroRh.Mask = "00000";
            this.txtRegistroRh.Name = "txtRegistroRh";
            this.txtRegistroRh.Size = new System.Drawing.Size(240, 20);
            this.txtRegistroRh.TabIndex = 83;
            this.txtRegistroRh.ValidatingType = typeof(int);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(702, 152);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(129, 20);
            this.txtTelefone.TabIndex = 82;
            // 
            // groupBoxLoginSenhaColaborador
            // 
            this.groupBoxLoginSenhaColaborador.Controls.Add(this.labelLoginColaborador);
            this.groupBoxLoginSenhaColaborador.Controls.Add(this.txtLogin);
            this.groupBoxLoginSenhaColaborador.Controls.Add(this.txtSenha);
            this.groupBoxLoginSenhaColaborador.Controls.Add(this.labelSenhaColaborador);
            this.groupBoxLoginSenhaColaborador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLoginSenhaColaborador.Location = new System.Drawing.Point(582, 275);
            this.groupBoxLoginSenhaColaborador.Name = "groupBoxLoginSenhaColaborador";
            this.groupBoxLoginSenhaColaborador.Size = new System.Drawing.Size(378, 75);
            this.groupBoxLoginSenhaColaborador.TabIndex = 81;
            this.groupBoxLoginSenhaColaborador.TabStop = false;
            this.groupBoxLoginSenhaColaborador.Text = "Defina seu login e senha";
            // 
            // labelLoginColaborador
            // 
            this.labelLoginColaborador.AutoSize = true;
            this.labelLoginColaborador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginColaborador.Location = new System.Drawing.Point(40, 34);
            this.labelLoginColaborador.Name = "labelLoginColaborador";
            this.labelLoginColaborador.Size = new System.Drawing.Size(46, 20);
            this.labelLoginColaborador.TabIndex = 20;
            this.labelLoginColaborador.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(102, 34);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(99, 27);
            this.txtLogin.TabIndex = 13;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(281, 32);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(85, 27);
            this.txtSenha.TabIndex = 14;
            // 
            // labelSenhaColaborador
            // 
            this.labelSenhaColaborador.AutoSize = true;
            this.labelSenhaColaborador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenhaColaborador.Location = new System.Drawing.Point(220, 32);
            this.labelSenhaColaborador.Name = "labelSenhaColaborador";
            this.labelSenhaColaborador.Size = new System.Drawing.Size(49, 20);
            this.labelSenhaColaborador.TabIndex = 12;
            this.labelSenhaColaborador.Text = "Senha";
            // 
            // labelNroRegistroColaborador
            // 
            this.labelNroRegistroColaborador.AutoSize = true;
            this.labelNroRegistroColaborador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroRegistroColaborador.Location = new System.Drawing.Point(551, 230);
            this.labelNroRegistroColaborador.Name = "labelNroRegistroColaborador";
            this.labelNroRegistroColaborador.Size = new System.Drawing.Size(145, 20);
            this.labelNroRegistroColaborador.TabIndex = 80;
            this.labelNroRegistroColaborador.Text = "Nrº de Registro (RH)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(632, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "Função ";
            // 
            // labelTelefoneColaborador
            // 
            this.labelTelefoneColaborador.AutoSize = true;
            this.labelTelefoneColaborador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefoneColaborador.Location = new System.Drawing.Point(625, 153);
            this.labelTelefoneColaborador.Name = "labelTelefoneColaborador";
            this.labelTelefoneColaborador.Size = new System.Drawing.Size(66, 20);
            this.labelTelefoneColaborador.TabIndex = 78;
            this.labelTelefoneColaborador.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(702, 114);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 20);
            this.txtEmail.TabIndex = 77;
            // 
            // labelEmailColaborador
            // 
            this.labelEmailColaborador.AutoSize = true;
            this.labelEmailColaborador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailColaborador.Location = new System.Drawing.Point(640, 112);
            this.labelEmailColaborador.Name = "labelEmailColaborador";
            this.labelEmailColaborador.Size = new System.Drawing.Size(52, 20);
            this.labelEmailColaborador.TabIndex = 76;
            this.labelEmailColaborador.Text = "e-mail";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(702, 76);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(240, 20);
            this.txtNome.TabIndex = 75;
            // 
            // labelNomeColaborador
            // 
            this.labelNomeColaborador.AutoSize = true;
            this.labelNomeColaborador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeColaborador.Location = new System.Drawing.Point(578, 76);
            this.labelNomeColaborador.Name = "labelNomeColaborador";
            this.labelNomeColaborador.Size = new System.Drawing.Size(118, 20);
            this.labelNomeColaborador.TabIndex = 74;
            this.labelNomeColaborador.Text = "Nome completo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(702, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(240, 20);
            this.txtCodigo.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(578, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "Codigo";
            // 
            // txtFuncao
            // 
            this.txtFuncao.Location = new System.Drawing.Point(702, 194);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(240, 20);
            this.txtFuncao.TabIndex = 87;
            // 
            // TelaGerenciaColaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 537);
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
            this.Controls.Add(this.labelcolaboradores);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonVoltarListarCliente);
            this.Controls.Add(this.buttonConfirmarListagemdeClientes);
            this.Name = "TelaGerenciaColaboradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GERENCIAMENTO DE COLABORADORES";
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
        private System.Windows.Forms.Label labelcolaboradores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
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
    }
}