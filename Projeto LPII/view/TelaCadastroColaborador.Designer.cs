namespace Projeto_LPII
{
    partial class Tela_cadastro_de_colaborador
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
            this.labelColaborador = new System.Windows.Forms.Label();
            this.labelNomeColaborador = new System.Windows.Forms.Label();
            this.nomeColaborador = new System.Windows.Forms.TextBox();
            this.labelEmailColaborador = new System.Windows.Forms.Label();
            this.emailColaborador = new System.Windows.Forms.TextBox();
            this.labelTelefoneColaborador = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNroRegistroColaborador = new System.Windows.Forms.Label();
            this.labelSenhaColaborador = new System.Windows.Forms.Label();
            this.cadastroLoginColaborador = new System.Windows.Forms.TextBox();
            this.cadastroSenhaColaborador = new System.Windows.Forms.TextBox();
            this.buttonconfirmarCadastroColaborador = new System.Windows.Forms.Button();
            this.buttoncancelarCadastroColaborador = new System.Windows.Forms.Button();
            this.groupBoxLoginSenhaColaborador = new System.Windows.Forms.GroupBox();
            this.labelLoginColaborador = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBoxLoginSenhaColaborador.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelColaborador
            // 
            this.labelColaborador.AutoSize = true;
            this.labelColaborador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColaborador.Location = new System.Drawing.Point(12, 9);
            this.labelColaborador.Name = "labelColaborador";
            this.labelColaborador.Size = new System.Drawing.Size(231, 21);
            this.labelColaborador.TabIndex = 0;
            this.labelColaborador.Text = "CADASTRO DE COLABORADOR";
            this.labelColaborador.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNomeColaborador
            // 
            this.labelNomeColaborador.AutoSize = true;
            this.labelNomeColaborador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeColaborador.Location = new System.Drawing.Point(40, 103);
            this.labelNomeColaborador.Name = "labelNomeColaborador";
            this.labelNomeColaborador.Size = new System.Drawing.Size(118, 20);
            this.labelNomeColaborador.TabIndex = 1;
            this.labelNomeColaborador.Text = "Nome completo";
            // 
            // nomeColaborador
            // 
            this.nomeColaborador.Location = new System.Drawing.Point(164, 103);
            this.nomeColaborador.Name = "nomeColaborador";
            this.nomeColaborador.Size = new System.Drawing.Size(240, 20);
            this.nomeColaborador.TabIndex = 2;
            // 
            // labelEmailColaborador
            // 
            this.labelEmailColaborador.AutoSize = true;
            this.labelEmailColaborador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailColaborador.Location = new System.Drawing.Point(102, 139);
            this.labelEmailColaborador.Name = "labelEmailColaborador";
            this.labelEmailColaborador.Size = new System.Drawing.Size(52, 20);
            this.labelEmailColaborador.TabIndex = 3;
            this.labelEmailColaborador.Text = "e-mail";
            this.labelEmailColaborador.Click += new System.EventHandler(this.label3_Click);
            // 
            // emailColaborador
            // 
            this.emailColaborador.Location = new System.Drawing.Point(164, 141);
            this.emailColaborador.Name = "emailColaborador";
            this.emailColaborador.Size = new System.Drawing.Size(240, 20);
            this.emailColaborador.TabIndex = 4;
            // 
            // labelTelefoneColaborador
            // 
            this.labelTelefoneColaborador.AutoSize = true;
            this.labelTelefoneColaborador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefoneColaborador.Location = new System.Drawing.Point(87, 180);
            this.labelTelefoneColaborador.Name = "labelTelefoneColaborador";
            this.labelTelefoneColaborador.Size = new System.Drawing.Size(66, 20);
            this.labelTelefoneColaborador.TabIndex = 5;
            this.labelTelefoneColaborador.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Função ";
            // 
            // labelNroRegistroColaborador
            // 
            this.labelNroRegistroColaborador.AutoSize = true;
            this.labelNroRegistroColaborador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroRegistroColaborador.Location = new System.Drawing.Point(13, 257);
            this.labelNroRegistroColaborador.Name = "labelNroRegistroColaborador";
            this.labelNroRegistroColaborador.Size = new System.Drawing.Size(145, 20);
            this.labelNroRegistroColaborador.TabIndex = 9;
            this.labelNroRegistroColaborador.Text = "Nrº de Registro (RH)";
            this.labelNroRegistroColaborador.Click += new System.EventHandler(this.label6_Click);
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
            // cadastroLoginColaborador
            // 
            this.cadastroLoginColaborador.Location = new System.Drawing.Point(102, 34);
            this.cadastroLoginColaborador.Name = "cadastroLoginColaborador";
            this.cadastroLoginColaborador.Size = new System.Drawing.Size(99, 27);
            this.cadastroLoginColaborador.TabIndex = 13;
            // 
            // cadastroSenhaColaborador
            // 
            this.cadastroSenhaColaborador.Location = new System.Drawing.Point(281, 32);
            this.cadastroSenhaColaborador.Name = "cadastroSenhaColaborador";
            this.cadastroSenhaColaborador.Size = new System.Drawing.Size(85, 27);
            this.cadastroSenhaColaborador.TabIndex = 14;
            // 
            // buttonconfirmarCadastroColaborador
            // 
            this.buttonconfirmarCadastroColaborador.BackColor = System.Drawing.Color.Orange;
            this.buttonconfirmarCadastroColaborador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonconfirmarCadastroColaborador.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonconfirmarCadastroColaborador.Location = new System.Drawing.Point(334, 392);
            this.buttonconfirmarCadastroColaborador.Name = "buttonconfirmarCadastroColaborador";
            this.buttonconfirmarCadastroColaborador.Size = new System.Drawing.Size(88, 33);
            this.buttonconfirmarCadastroColaborador.TabIndex = 15;
            this.buttonconfirmarCadastroColaborador.Text = "Cadastrar";
            this.buttonconfirmarCadastroColaborador.UseVisualStyleBackColor = false;
            this.buttonconfirmarCadastroColaborador.Click += new System.EventHandler(this.buttonconfirmarCadastroColaborador_Click);
            // 
            // buttoncancelarCadastroColaborador
            // 
            this.buttoncancelarCadastroColaborador.BackColor = System.Drawing.Color.Crimson;
            this.buttoncancelarCadastroColaborador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncancelarCadastroColaborador.Location = new System.Drawing.Point(229, 392);
            this.buttoncancelarCadastroColaborador.Name = "buttoncancelarCadastroColaborador";
            this.buttoncancelarCadastroColaborador.Size = new System.Drawing.Size(84, 34);
            this.buttoncancelarCadastroColaborador.TabIndex = 16;
            this.buttoncancelarCadastroColaborador.Text = "Cancelar ";
            this.buttoncancelarCadastroColaborador.UseVisualStyleBackColor = false;
            this.buttoncancelarCadastroColaborador.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxLoginSenhaColaborador
            // 
            this.groupBoxLoginSenhaColaborador.Controls.Add(this.labelLoginColaborador);
            this.groupBoxLoginSenhaColaborador.Controls.Add(this.cadastroLoginColaborador);
            this.groupBoxLoginSenhaColaborador.Controls.Add(this.cadastroSenhaColaborador);
            this.groupBoxLoginSenhaColaborador.Controls.Add(this.labelSenhaColaborador);
            this.groupBoxLoginSenhaColaborador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLoginSenhaColaborador.Location = new System.Drawing.Point(44, 302);
            this.groupBoxLoginSenhaColaborador.Name = "groupBoxLoginSenhaColaborador";
            this.groupBoxLoginSenhaColaborador.Size = new System.Drawing.Size(378, 75);
            this.groupBoxLoginSenhaColaborador.TabIndex = 19;
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
            this.labelLoginColaborador.Click += new System.EventHandler(this.label9_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(164, 179);
            this.maskedTextBox1.Mask = "(99) 00000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(129, 20);
            this.maskedTextBox1.TabIndex = 20;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(164, 257);
            this.maskedTextBox2.Mask = "00000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(240, 20);
            this.maskedTextBox2.TabIndex = 21;
            this.maskedTextBox2.ValidatingType = typeof(int);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 221);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // Tela_cadastro_de_colaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 544);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.groupBoxLoginSenhaColaborador);
            this.Controls.Add(this.buttoncancelarCadastroColaborador);
            this.Controls.Add(this.buttonconfirmarCadastroColaborador);
            this.Controls.Add(this.labelNroRegistroColaborador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTelefoneColaborador);
            this.Controls.Add(this.emailColaborador);
            this.Controls.Add(this.labelEmailColaborador);
            this.Controls.Add(this.nomeColaborador);
            this.Controls.Add(this.labelNomeColaborador);
            this.Controls.Add(this.labelColaborador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tela_cadastro_de_colaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_cadastro_de_colaborador";
            this.Load += new System.EventHandler(this.Tela_cadastro_de_colaborador_Load);
            this.groupBoxLoginSenhaColaborador.ResumeLayout(false);
            this.groupBoxLoginSenhaColaborador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelColaborador;
        private System.Windows.Forms.Label labelNomeColaborador;
        private System.Windows.Forms.TextBox nomeColaborador;
        private System.Windows.Forms.Label labelEmailColaborador;
        private System.Windows.Forms.TextBox emailColaborador;
        private System.Windows.Forms.Label labelTelefoneColaborador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelNroRegistroColaborador;
        private System.Windows.Forms.Label labelSenhaColaborador;
        private System.Windows.Forms.TextBox cadastroLoginColaborador;
        private System.Windows.Forms.TextBox cadastroSenhaColaborador;
        private System.Windows.Forms.Button buttonconfirmarCadastroColaborador;
        private System.Windows.Forms.Button buttoncancelarCadastroColaborador;
        private System.Windows.Forms.GroupBox groupBoxLoginSenhaColaborador;
        private System.Windows.Forms.Label labelLoginColaborador;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}