namespace Projeto_LPII
{
    partial class Tela_listar_cliente
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
            this.labelCliente = new System.Windows.Forms.Label();
            this.buttonVoltarListarCliente = new System.Windows.Forms.Button();
            this.buttonConfirmarListagemdeClientes = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.emailCliente = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.groupBoxContato = new System.Windows.Forms.GroupBox();
            this.nomeContatoCliente = new System.Windows.Forms.TextBox();
            this.labelNomeContato = new System.Windows.Forms.Label();
            this.labelCnpj = new System.Windows.Forms.Label();
            this.groupBoxLogradouro = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.cidadeCliente = new System.Windows.Forms.TextBox();
            this.labelCep = new System.Windows.Forms.Label();
            this.labelCidade = new System.Windows.Forms.Label();
            this.ruaCliente = new System.Windows.Forms.TextBox();
            this.labelBairro = new System.Windows.Forms.Label();
            this.labelRua = new System.Windows.Forms.Label();
            this.bairroCleinte = new System.Windows.Forms.TextBox();
            this.labelNro = new System.Windows.Forms.Label();
            this.nomeCliente = new System.Windows.Forms.TextBox();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxContato.SuspendLayout();
            this.groupBoxLogradouro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(12, 9);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(159, 21);
            this.labelCliente.TabIndex = 0;
            this.labelCliente.Text = "GERENCIAR CLIENTE ";
            this.labelCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonVoltarListarCliente
            // 
            this.buttonVoltarListarCliente.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonVoltarListarCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltarListarCliente.Location = new System.Drawing.Point(12, 392);
            this.buttonVoltarListarCliente.Name = "buttonVoltarListarCliente";
            this.buttonVoltarListarCliente.Size = new System.Drawing.Size(96, 34);
            this.buttonVoltarListarCliente.TabIndex = 28;
            this.buttonVoltarListarCliente.Text = "ATUALIZAR ";
            this.buttonVoltarListarCliente.UseVisualStyleBackColor = false;
            this.buttonVoltarListarCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonConfirmarListagemdeClientes
            // 
            this.buttonConfirmarListagemdeClientes.BackColor = System.Drawing.Color.Orange;
            this.buttonConfirmarListagemdeClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmarListagemdeClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonConfirmarListagemdeClientes.Location = new System.Drawing.Point(419, 392);
            this.buttonConfirmarListagemdeClientes.Name = "buttonConfirmarListagemdeClientes";
            this.buttonConfirmarListagemdeClientes.Size = new System.Drawing.Size(88, 33);
            this.buttonConfirmarListagemdeClientes.TabIndex = 27;
            this.buttonConfirmarListagemdeClientes.Text = "SALVAR";
            this.buttonConfirmarListagemdeClientes.UseVisualStyleBackColor = false;
            this.buttonConfirmarListagemdeClientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Location = new System.Drawing.Point(628, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 20);
            this.textBox1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Código";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(628, 113);
            this.maskedTextBox1.Mask = "99.000.000/0000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(113, 20);
            this.maskedTextBox1.TabIndex = 37;
            // 
            // emailCliente
            // 
            this.emailCliente.Location = new System.Drawing.Point(803, 114);
            this.emailCliente.Name = "emailCliente";
            this.emailCliente.Size = new System.Drawing.Size(138, 20);
            this.emailCliente.TabIndex = 36;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(747, 114);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(56, 20);
            this.labelEmail.TabIndex = 35;
            this.labelEmail.Text = "e-mail ";
            // 
            // groupBoxContato
            // 
            this.groupBoxContato.Controls.Add(this.nomeContatoCliente);
            this.groupBoxContato.Controls.Add(this.labelNomeContato);
            this.groupBoxContato.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxContato.Location = new System.Drawing.Point(538, 380);
            this.groupBoxContato.Name = "groupBoxContato";
            this.groupBoxContato.Size = new System.Drawing.Size(408, 76);
            this.groupBoxContato.TabIndex = 34;
            this.groupBoxContato.TabStop = false;
            this.groupBoxContato.Text = "Contato";
            // 
            // nomeContatoCliente
            // 
            this.nomeContatoCliente.Location = new System.Drawing.Point(89, 23);
            this.nomeContatoCliente.Name = "nomeContatoCliente";
            this.nomeContatoCliente.Size = new System.Drawing.Size(304, 27);
            this.nomeContatoCliente.TabIndex = 19;
            // 
            // labelNomeContato
            // 
            this.labelNomeContato.AutoSize = true;
            this.labelNomeContato.Location = new System.Drawing.Point(22, 26);
            this.labelNomeContato.Name = "labelNomeContato";
            this.labelNomeContato.Size = new System.Drawing.Size(54, 20);
            this.labelNomeContato.TabIndex = 19;
            this.labelNomeContato.Text = "Nome ";
            // 
            // labelCnpj
            // 
            this.labelCnpj.AutoSize = true;
            this.labelCnpj.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCnpj.Location = new System.Drawing.Point(577, 114);
            this.labelCnpj.Name = "labelCnpj";
            this.labelCnpj.Size = new System.Drawing.Size(37, 20);
            this.labelCnpj.TabIndex = 33;
            this.labelCnpj.Text = "cnpj";
            // 
            // groupBoxLogradouro
            // 
            this.groupBoxLogradouro.Controls.Add(this.comboBox1);
            this.groupBoxLogradouro.Controls.Add(this.maskedTextBox3);
            this.groupBoxLogradouro.Controls.Add(this.maskedTextBox2);
            this.groupBoxLogradouro.Controls.Add(this.labelEstado);
            this.groupBoxLogradouro.Controls.Add(this.cidadeCliente);
            this.groupBoxLogradouro.Controls.Add(this.labelCep);
            this.groupBoxLogradouro.Controls.Add(this.labelCidade);
            this.groupBoxLogradouro.Controls.Add(this.ruaCliente);
            this.groupBoxLogradouro.Controls.Add(this.labelBairro);
            this.groupBoxLogradouro.Controls.Add(this.labelRua);
            this.groupBoxLogradouro.Controls.Add(this.bairroCleinte);
            this.groupBoxLogradouro.Controls.Add(this.labelNro);
            this.groupBoxLogradouro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLogradouro.Location = new System.Drawing.Point(538, 152);
            this.groupBoxLogradouro.Name = "groupBoxLogradouro";
            this.groupBoxLogradouro.Size = new System.Drawing.Size(408, 204);
            this.groupBoxLogradouro.TabIndex = 32;
            this.groupBoxLogradouro.TabStop = false;
            this.groupBoxLogradouro.Text = "Logradouro ";
            // 
            // comboBox1
            // 
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
            this.comboBox1.Location = new System.Drawing.Point(90, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(54, 28);
            this.comboBox1.TabIndex = 19;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(282, 73);
            this.maskedTextBox3.Mask = "00000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(79, 27);
            this.maskedTextBox3.TabIndex = 18;
            this.maskedTextBox3.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(89, 26);
            this.maskedTextBox2.Mask = "00000-999";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(272, 27);
            this.maskedTextBox2.TabIndex = 17;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(50, 142);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(26, 20);
            this.labelEstado.TabIndex = 15;
            this.labelEstado.Text = "UF";
            // 
            // cidadeCliente
            // 
            this.cidadeCliente.Location = new System.Drawing.Point(258, 107);
            this.cidadeCliente.Name = "cidadeCliente";
            this.cidadeCliente.Size = new System.Drawing.Size(103, 27);
            this.cidadeCliente.TabIndex = 14;
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Location = new System.Drawing.Point(31, 28);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(35, 20);
            this.labelCep.TabIndex = 7;
            this.labelCep.Text = "Cep";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(200, 110);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(60, 20);
            this.labelCidade.TabIndex = 13;
            this.labelCidade.Text = "Cidade ";
            // 
            // ruaCliente
            // 
            this.ruaCliente.Location = new System.Drawing.Point(89, 73);
            this.ruaCliente.Name = "ruaCliente";
            this.ruaCliente.Size = new System.Drawing.Size(147, 27);
            this.ruaCliente.TabIndex = 5;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(31, 107);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(53, 20);
            this.labelBairro.TabIndex = 12;
            this.labelBairro.Text = "Bairro ";
            // 
            // labelRua
            // 
            this.labelRua.AutoSize = true;
            this.labelRua.Location = new System.Drawing.Point(31, 73);
            this.labelRua.Name = "labelRua";
            this.labelRua.Size = new System.Drawing.Size(38, 20);
            this.labelRua.TabIndex = 6;
            this.labelRua.Text = "Rua ";
            // 
            // bairroCleinte
            // 
            this.bairroCleinte.Location = new System.Drawing.Point(89, 107);
            this.bairroCleinte.Name = "bairroCleinte";
            this.bairroCleinte.Size = new System.Drawing.Size(105, 27);
            this.bairroCleinte.TabIndex = 11;
            // 
            // labelNro
            // 
            this.labelNro.AutoSize = true;
            this.labelNro.Location = new System.Drawing.Point(242, 76);
            this.labelNro.Name = "labelNro";
            this.labelNro.Size = new System.Drawing.Size(34, 20);
            this.labelNro.TabIndex = 9;
            this.labelNro.Text = "Nro";
            // 
            // nomeCliente
            // 
            this.nomeCliente.Location = new System.Drawing.Point(628, 75);
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.Size = new System.Drawing.Size(313, 20);
            this.nomeCliente.TabIndex = 31;
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpresa.Location = new System.Drawing.Point(553, 75);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(70, 20);
            this.labelEmpresa.TabIndex = 30;
            this.labelEmpresa.Text = "Empresa ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 276);
            this.dataGridView1.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Código ou Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 20);
            this.textBox2.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(114, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 34);
            this.button1.TabIndex = 43;
            this.button1.Text = "EXCLUIR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(419, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 33);
            this.button3.TabIndex = 45;
            this.button3.Text = "BUSCAR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(423, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 34);
            this.button2.TabIndex = 44;
            this.button2.Text = "Voltar  ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Tela_listar_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 512);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.emailCliente);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.groupBoxContato);
            this.Controls.Add(this.labelCnpj);
            this.Controls.Add(this.groupBoxLogradouro);
            this.Controls.Add(this.nomeCliente);
            this.Controls.Add(this.labelEmpresa);
            this.Controls.Add(this.buttonVoltarListarCliente);
            this.Controls.Add(this.buttonConfirmarListagemdeClientes);
            this.Controls.Add(this.labelCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tela_listar_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gerenciar_Cliente";
            this.Load += new System.EventHandler(this.Tela_listar_cliente_Load);
            this.groupBoxContato.ResumeLayout(false);
            this.groupBoxContato.PerformLayout();
            this.groupBoxLogradouro.ResumeLayout(false);
            this.groupBoxLogradouro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Button buttonVoltarListarCliente;
        private System.Windows.Forms.Button buttonConfirmarListagemdeClientes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox emailCliente;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.GroupBox groupBoxContato;
        private System.Windows.Forms.TextBox nomeContatoCliente;
        private System.Windows.Forms.Label labelNomeContato;
        private System.Windows.Forms.Label labelCnpj;
        private System.Windows.Forms.GroupBox groupBoxLogradouro;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TextBox cidadeCliente;
        private System.Windows.Forms.Label labelCep;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.TextBox ruaCliente;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.Label labelRua;
        private System.Windows.Forms.TextBox bairroCleinte;
        private System.Windows.Forms.Label labelNro;
        private System.Windows.Forms.TextBox nomeCliente;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}