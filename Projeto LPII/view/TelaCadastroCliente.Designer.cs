namespace Projeto_LPII
{
    partial class Tela_cadastro_de_cliente
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
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.nomeCliente = new System.Windows.Forms.TextBox();
            this.ruaCliente = new System.Windows.Forms.TextBox();
            this.labelRua = new System.Windows.Forms.Label();
            this.labelCep = new System.Windows.Forms.Label();
            this.labelNro = new System.Windows.Forms.Label();
            this.labelCidade = new System.Windows.Forms.Label();
            this.cidadeCliente = new System.Windows.Forms.TextBox();
            this.groupBoxLogradouro = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelCnpj = new System.Windows.Forms.Label();
            this.groupBoxContato = new System.Windows.Forms.GroupBox();
            this.nomeContatoCliente = new System.Windows.Forms.TextBox();
            this.labelNomeContato = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.emailCliente = new System.Windows.Forms.TextBox();
            this.buttonCancelarCadastroCliente = new System.Windows.Forms.Button();
            this.buttonconfirmarCadastroCliente = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.maskedTextBoxTelefoneCliente = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxLogradouro.SuspendLayout();
            this.groupBoxContato.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpresa.Location = new System.Drawing.Point(12, 23);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(69, 20);
            this.labelEmpresa.TabIndex = 1;
            this.labelEmpresa.Text = "Empresa:";
            // 
            // nomeCliente
            // 
            this.nomeCliente.Location = new System.Drawing.Point(106, 25);
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.Size = new System.Drawing.Size(545, 20);
            this.nomeCliente.TabIndex = 0;
            // 
            // ruaCliente
            // 
            this.ruaCliente.Location = new System.Drawing.Point(90, 26);
            this.ruaCliente.Name = "ruaCliente";
            this.ruaCliente.Size = new System.Drawing.Size(323, 27);
            this.ruaCliente.TabIndex = 1;
            // 
            // labelRua
            // 
            this.labelRua.AutoSize = true;
            this.labelRua.Location = new System.Drawing.Point(22, 29);
            this.labelRua.Name = "labelRua";
            this.labelRua.Size = new System.Drawing.Size(37, 20);
            this.labelRua.TabIndex = 6;
            this.labelRua.Text = "Rua:";
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Location = new System.Drawing.Point(22, 95);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(37, 20);
            this.labelCep.TabIndex = 7;
            this.labelCep.Text = "CEP:";
            // 
            // labelNro
            // 
            this.labelNro.AutoSize = true;
            this.labelNro.Location = new System.Drawing.Point(442, 29);
            this.labelNro.Name = "labelNro";
            this.labelNro.Size = new System.Drawing.Size(66, 20);
            this.labelNro.TabIndex = 9;
            this.labelNro.Text = "Número:";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(22, 62);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(59, 20);
            this.labelCidade.TabIndex = 13;
            this.labelCidade.Text = "Cidade:";
            // 
            // cidadeCliente
            // 
            this.cidadeCliente.Location = new System.Drawing.Point(90, 59);
            this.cidadeCliente.Name = "cidadeCliente";
            this.cidadeCliente.Size = new System.Drawing.Size(323, 27);
            this.cidadeCliente.TabIndex = 3;
            // 
            // groupBoxLogradouro
            // 
            this.groupBoxLogradouro.Controls.Add(this.comboBox1);
            this.groupBoxLogradouro.Controls.Add(this.maskedTextBox3);
            this.groupBoxLogradouro.Controls.Add(this.txtCep);
            this.groupBoxLogradouro.Controls.Add(this.labelEstado);
            this.groupBoxLogradouro.Controls.Add(this.cidadeCliente);
            this.groupBoxLogradouro.Controls.Add(this.labelCep);
            this.groupBoxLogradouro.Controls.Add(this.labelCidade);
            this.groupBoxLogradouro.Controls.Add(this.ruaCliente);
            this.groupBoxLogradouro.Controls.Add(this.labelRua);
            this.groupBoxLogradouro.Controls.Add(this.labelNro);
            this.groupBoxLogradouro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLogradouro.Location = new System.Drawing.Point(16, 129);
            this.groupBoxLogradouro.Name = "groupBoxLogradouro";
            this.groupBoxLogradouro.Size = new System.Drawing.Size(666, 163);
            this.groupBoxLogradouro.TabIndex = 4;
            this.groupBoxLogradouro.TabStop = false;
            this.groupBoxLogradouro.Text = "Logradouro ";
            this.groupBoxLogradouro.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AC ",
            "AL",
            "AP",
            "AM",
            "BA ",
            "CE",
            "DF ",
            "ES",
            "GO",
            "MA",
            "MT ",
            "MS ",
            "MG ",
            "PA",
            "PB",
            "PR ",
            "PE",
            "PI",
            "RJ",
            "RN ",
            "RS ",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE ",
            "TO "});
            this.comboBox1.Location = new System.Drawing.Point(514, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(514, 26);
            this.maskedTextBox3.Mask = "00000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(121, 27);
            this.maskedTextBox3.TabIndex = 2;
            this.maskedTextBox3.ValidatingType = typeof(int);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(90, 92);
            this.txtCep.Mask = "00000-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(323, 27);
            this.txtCep.TabIndex = 0;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(442, 66);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(29, 20);
            this.labelEstado.TabIndex = 15;
            this.labelEstado.Text = "UF:";
            // 
            // labelCnpj
            // 
            this.labelCnpj.AutoSize = true;
            this.labelCnpj.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCnpj.Location = new System.Drawing.Point(12, 51);
            this.labelCnpj.Name = "labelCnpj";
            this.labelCnpj.Size = new System.Drawing.Size(44, 20);
            this.labelCnpj.TabIndex = 16;
            this.labelCnpj.Text = "CNPJ:";
            // 
            // groupBoxContato
            // 
            this.groupBoxContato.Controls.Add(this.nomeContatoCliente);
            this.groupBoxContato.Controls.Add(this.labelNomeContato);
            this.groupBoxContato.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxContato.Location = new System.Drawing.Point(16, 298);
            this.groupBoxContato.Name = "groupBoxContato";
            this.groupBoxContato.Size = new System.Drawing.Size(666, 76);
            this.groupBoxContato.TabIndex = 5;
            this.groupBoxContato.TabStop = false;
            this.groupBoxContato.Text = "Contato";
            // 
            // nomeContatoCliente
            // 
            this.nomeContatoCliente.Location = new System.Drawing.Point(90, 26);
            this.nomeContatoCliente.Name = "nomeContatoCliente";
            this.nomeContatoCliente.Size = new System.Drawing.Size(545, 27);
            this.nomeContatoCliente.TabIndex = 0;
            // 
            // labelNomeContato
            // 
            this.labelNomeContato.AutoSize = true;
            this.labelNomeContato.Location = new System.Drawing.Point(22, 26);
            this.labelNomeContato.Name = "labelNomeContato";
            this.labelNomeContato.Size = new System.Drawing.Size(53, 20);
            this.labelNomeContato.TabIndex = 19;
            this.labelNomeContato.Text = "Nome:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(12, 77);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(55, 20);
            this.labelEmail.TabIndex = 19;
            this.labelEmail.Text = "E-mail:";
            this.labelEmail.Click += new System.EventHandler(this.label12_Click);
            // 
            // emailCliente
            // 
            this.emailCliente.Location = new System.Drawing.Point(106, 79);
            this.emailCliente.Name = "emailCliente";
            this.emailCliente.Size = new System.Drawing.Size(545, 20);
            this.emailCliente.TabIndex = 2;
            // 
            // buttonCancelarCadastroCliente
            // 
            this.buttonCancelarCadastroCliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCancelarCadastroCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadastroCliente.Location = new System.Drawing.Point(469, 392);
            this.buttonCancelarCadastroCliente.Name = "buttonCancelarCadastroCliente";
            this.buttonCancelarCadastroCliente.Size = new System.Drawing.Size(84, 34);
            this.buttonCancelarCadastroCliente.TabIndex = 7;
            this.buttonCancelarCadastroCliente.Text = "CANCELAR";
            this.buttonCancelarCadastroCliente.UseVisualStyleBackColor = false;
            this.buttonCancelarCadastroCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonconfirmarCadastroCliente
            // 
            this.buttonconfirmarCadastroCliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonconfirmarCadastroCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonconfirmarCadastroCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonconfirmarCadastroCliente.Location = new System.Drawing.Point(563, 392);
            this.buttonconfirmarCadastroCliente.Name = "buttonconfirmarCadastroCliente";
            this.buttonconfirmarCadastroCliente.Size = new System.Drawing.Size(88, 33);
            this.buttonconfirmarCadastroCliente.TabIndex = 6;
            this.buttonconfirmarCadastroCliente.Text = "CADASTRAR";
            this.buttonconfirmarCadastroCliente.UseVisualStyleBackColor = false;
            this.buttonconfirmarCadastroCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(106, 51);
            this.maskedTextBox1.Mask = "99.000.000/0000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(545, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefone.Location = new System.Drawing.Point(12, 103);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(69, 20);
            this.labelTelefone.TabIndex = 30;
            this.labelTelefone.Text = "Telefone:";
            // 
            // maskedTextBoxTelefoneCliente
            // 
            this.maskedTextBoxTelefoneCliente.Location = new System.Drawing.Point(105, 103);
            this.maskedTextBoxTelefoneCliente.Mask = "(99) 00000-0000";
            this.maskedTextBoxTelefoneCliente.Name = "maskedTextBoxTelefoneCliente";
            this.maskedTextBoxTelefoneCliente.Size = new System.Drawing.Size(546, 20);
            this.maskedTextBoxTelefoneCliente.TabIndex = 3;
            // 
            // Tela_cadastro_de_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 449);
            this.Controls.Add(this.maskedTextBoxTelefoneCliente);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.buttonCancelarCadastroCliente);
            this.Controls.Add(this.buttonconfirmarCadastroCliente);
            this.Controls.Add(this.emailCliente);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.groupBoxContato);
            this.Controls.Add(this.labelCnpj);
            this.Controls.Add(this.groupBoxLogradouro);
            this.Controls.Add(this.nomeCliente);
            this.Controls.Add(this.labelEmpresa);
            this.Name = "Tela_cadastro_de_cliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA GERENCIADOR DE PROJETOS -  Cadastro de Cliente";
            this.groupBoxLogradouro.ResumeLayout(false);
            this.groupBoxLogradouro.PerformLayout();
            this.groupBoxContato.ResumeLayout(false);
            this.groupBoxContato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.TextBox nomeCliente;
        private System.Windows.Forms.TextBox ruaCliente;
        private System.Windows.Forms.Label labelRua;
        private System.Windows.Forms.Label labelCep;
        private System.Windows.Forms.Label labelNro;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.TextBox cidadeCliente;
        private System.Windows.Forms.GroupBox groupBoxLogradouro;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelCnpj;
        private System.Windows.Forms.GroupBox groupBoxContato;
        private System.Windows.Forms.TextBox nomeContatoCliente;
        private System.Windows.Forms.Label labelNomeContato;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox emailCliente;
        private System.Windows.Forms.Button buttonCancelarCadastroCliente;
        private System.Windows.Forms.Button buttonconfirmarCadastroCliente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefoneCliente;
    }
}