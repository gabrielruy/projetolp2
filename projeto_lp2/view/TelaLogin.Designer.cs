namespace Projeto_LPII
{
    partial class Tela_de_login
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
            this.efetueSeuLogin = new System.Windows.Forms.Label();
            this.groupBoxLoginInicio = new System.Windows.Forms.GroupBox();
            this.loginInicio = new System.Windows.Forms.Label();
            this.LoginColaboradorInicio = new System.Windows.Forms.TextBox();
            this.senhaColaboradorInicio = new System.Windows.Forms.TextBox();
            this.SenhaInicio = new System.Windows.Forms.Label();
            this.buttonFecharLogin = new System.Windows.Forms.Button();
            this.buttonConfirmarLogin = new System.Windows.Forms.Button();
            this.buttonCadastroNovoColaborador = new System.Windows.Forms.Button();
            this.buttonRecuperaçãoSenha = new System.Windows.Forms.Button();
            this.groupBoxLoginInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // efetueSeuLogin
            // 
            this.efetueSeuLogin.AutoSize = true;
            this.efetueSeuLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efetueSeuLogin.Location = new System.Drawing.Point(12, 9);
            this.efetueSeuLogin.Name = "efetueSeuLogin";
            this.efetueSeuLogin.Size = new System.Drawing.Size(144, 21);
            this.efetueSeuLogin.TabIndex = 1;
            this.efetueSeuLogin.Text = "EFETUE SEU LOGIN";
            this.efetueSeuLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxLoginInicio
            // 
            this.groupBoxLoginInicio.Controls.Add(this.loginInicio);
            this.groupBoxLoginInicio.Controls.Add(this.LoginColaboradorInicio);
            this.groupBoxLoginInicio.Controls.Add(this.senhaColaboradorInicio);
            this.groupBoxLoginInicio.Controls.Add(this.SenhaInicio);
            this.groupBoxLoginInicio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLoginInicio.Location = new System.Drawing.Point(51, 60);
            this.groupBoxLoginInicio.Name = "groupBoxLoginInicio";
            this.groupBoxLoginInicio.Size = new System.Drawing.Size(378, 89);
            this.groupBoxLoginInicio.TabIndex = 20;
            this.groupBoxLoginInicio.TabStop = false;
            this.groupBoxLoginInicio.Text = "Digite seu dados";
            // 
            // loginInicio
            // 
            this.loginInicio.AutoSize = true;
            this.loginInicio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginInicio.Location = new System.Drawing.Point(40, 34);
            this.loginInicio.Name = "loginInicio";
            this.loginInicio.Size = new System.Drawing.Size(46, 20);
            this.loginInicio.TabIndex = 20;
            this.loginInicio.Text = "Login";
            // 
            // LoginColaboradorInicio
            // 
            this.LoginColaboradorInicio.Location = new System.Drawing.Point(102, 34);
            this.LoginColaboradorInicio.Name = "LoginColaboradorInicio";
            this.LoginColaboradorInicio.Size = new System.Drawing.Size(99, 27);
            this.LoginColaboradorInicio.TabIndex = 13;
            // 
            // senhaColaboradorInicio
            // 
            this.senhaColaboradorInicio.Location = new System.Drawing.Point(275, 32);
            this.senhaColaboradorInicio.Name = "senhaColaboradorInicio";
            this.senhaColaboradorInicio.PasswordChar = '*';
            this.senhaColaboradorInicio.Size = new System.Drawing.Size(91, 27);
            this.senhaColaboradorInicio.TabIndex = 14;
            this.senhaColaboradorInicio.TextChanged += new System.EventHandler(this.SenhaColaboradorInicio_TextChanged);
            // 
            // SenhaInicio
            // 
            this.SenhaInicio.AutoSize = true;
            this.SenhaInicio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenhaInicio.Location = new System.Drawing.Point(220, 32);
            this.SenhaInicio.Name = "SenhaInicio";
            this.SenhaInicio.Size = new System.Drawing.Size(49, 20);
            this.SenhaInicio.TabIndex = 12;
            this.SenhaInicio.Text = "Senha";
            // 
            // buttonFecharLogin
            // 
            this.buttonFecharLogin.BackColor = System.Drawing.Color.Crimson;
            this.buttonFecharLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFecharLogin.Location = new System.Drawing.Point(236, 155);
            this.buttonFecharLogin.Name = "buttonFecharLogin";
            this.buttonFecharLogin.Size = new System.Drawing.Size(84, 34);
            this.buttonFecharLogin.TabIndex = 22;
            this.buttonFecharLogin.Text = "Fechar";
            this.buttonFecharLogin.UseVisualStyleBackColor = false;
            this.buttonFecharLogin.Click += new System.EventHandler(this.buttonCancelarNovoProjeto_Click);
            // 
            // buttonConfirmarLogin
            // 
            this.buttonConfirmarLogin.BackColor = System.Drawing.Color.Orange;
            this.buttonConfirmarLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmarLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonConfirmarLogin.Location = new System.Drawing.Point(341, 155);
            this.buttonConfirmarLogin.Name = "buttonConfirmarLogin";
            this.buttonConfirmarLogin.Size = new System.Drawing.Size(88, 33);
            this.buttonConfirmarLogin.TabIndex = 21;
            this.buttonConfirmarLogin.Text = "Entrar";
            this.buttonConfirmarLogin.UseVisualStyleBackColor = false;
            this.buttonConfirmarLogin.Click += new System.EventHandler(this.buttonConfirmarLogin_Click);
            // 
            // buttonCadastroNovoColaborador
            // 
            this.buttonCadastroNovoColaborador.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonCadastroNovoColaborador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastroNovoColaborador.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCadastroNovoColaborador.Location = new System.Drawing.Point(236, 205);
            this.buttonCadastroNovoColaborador.Name = "buttonCadastroNovoColaborador";
            this.buttonCadastroNovoColaborador.Size = new System.Drawing.Size(194, 33);
            this.buttonCadastroNovoColaborador.TabIndex = 23;
            this.buttonCadastroNovoColaborador.Text = "Fazer um novo cadastro";
            this.buttonCadastroNovoColaborador.UseVisualStyleBackColor = false;
            this.buttonCadastroNovoColaborador.Click += new System.EventHandler(this.buttonCadastroNovoColaborador_Click);
            // 
            // buttonRecuperaçãoSenha
            // 
            this.buttonRecuperaçãoSenha.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonRecuperaçãoSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecuperaçãoSenha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRecuperaçãoSenha.Location = new System.Drawing.Point(236, 257);
            this.buttonRecuperaçãoSenha.Name = "buttonRecuperaçãoSenha";
            this.buttonRecuperaçãoSenha.Size = new System.Drawing.Size(193, 51);
            this.buttonRecuperaçãoSenha.TabIndex = 24;
            this.buttonRecuperaçãoSenha.Text = "Esqueceu sua senha ou login? Click aqui!";
            this.buttonRecuperaçãoSenha.UseVisualStyleBackColor = false;
            // 
            // Tela_de_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 369);
            this.Controls.Add(this.buttonRecuperaçãoSenha);
            this.Controls.Add(this.buttonCadastroNovoColaborador);
            this.Controls.Add(this.buttonFecharLogin);
            this.Controls.Add(this.buttonConfirmarLogin);
            this.Controls.Add(this.groupBoxLoginInicio);
            this.Controls.Add(this.efetueSeuLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tela_de_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_de_login";
            this.groupBoxLoginInicio.ResumeLayout(false);
            this.groupBoxLoginInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label efetueSeuLogin;
        private System.Windows.Forms.GroupBox groupBoxLoginInicio;
        private System.Windows.Forms.Label loginInicio;
        private System.Windows.Forms.TextBox LoginColaboradorInicio;
        private System.Windows.Forms.TextBox senhaColaboradorInicio;
        private System.Windows.Forms.Label SenhaInicio;
        private System.Windows.Forms.Button buttonFecharLogin;
        private System.Windows.Forms.Button buttonConfirmarLogin;
        private System.Windows.Forms.Button buttonCadastroNovoColaborador;
        private System.Windows.Forms.Button buttonRecuperaçãoSenha;
    }
}