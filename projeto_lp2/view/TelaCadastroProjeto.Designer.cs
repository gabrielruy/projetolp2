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
            this.listBoxClienteProjeto = new System.Windows.Forms.ListBox();
            this.labelNroEtapas = new System.Windows.Forms.Label();
            this.nroEtapasProjeto = new System.Windows.Forms.TextBox();
            this.dateTimeProjeto = new System.Windows.Forms.DateTimePicker();
            this.labelInicioProjeto = new System.Windows.Forms.Label();
            this.buttonCancelarNovoProjeto = new System.Windows.Forms.Button();
            this.buttonCadastrarNovoProjeto = new System.Windows.Forms.Button();
            this.labelMembrosProjeto = new System.Windows.Forms.Label();
            this.textBoxMembrosProjeto = new System.Windows.Forms.TextBox();
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
            this.labelNomeProjeto.Location = new System.Drawing.Point(46, 115);
            this.labelNomeProjeto.Name = "labelNomeProjeto";
            this.labelNomeProjeto.Size = new System.Drawing.Size(128, 20);
            this.labelNomeProjeto.TabIndex = 1;
            this.labelNomeProjeto.Text = "Nome do Projeto ";
            // 
            // nomeProjeto
            // 
            this.nomeProjeto.Location = new System.Drawing.Point(180, 115);
            this.nomeProjeto.Name = "nomeProjeto";
            this.nomeProjeto.Size = new System.Drawing.Size(240, 20);
            this.nomeProjeto.TabIndex = 3;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(96, 159);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(55, 20);
            this.labelCliente.TabIndex = 4;
            this.labelCliente.Text = "Cliente";
            // 
            // listBoxClienteProjeto
            // 
            this.listBoxClienteProjeto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxClienteProjeto.FormattingEnabled = true;
            this.listBoxClienteProjeto.ItemHeight = 17;
            this.listBoxClienteProjeto.Items.AddRange(new object[] {
            " Eletrolux",
            " Volkswagem",
            " Ambev",
            " Yamaha",
            " Nike ",
            " Adidas",
            " Puma",
            " Revista Kappa",
            " Universidade federal de São Carlos ",
            " Universidade de São Paulo ",
            " Boni centro automotivo ",
            " SF Automativa ",
            " Instituto Federal de São Paulo campus São Carlos ",
            " Serasa "});
            this.listBoxClienteProjeto.Location = new System.Drawing.Point(180, 159);
            this.listBoxClienteProjeto.Name = "listBoxClienteProjeto";
            this.listBoxClienteProjeto.Size = new System.Drawing.Size(240, 21);
            this.listBoxClienteProjeto.TabIndex = 5;
            // 
            // labelNroEtapas
            // 
            this.labelNroEtapas.AutoSize = true;
            this.labelNroEtapas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroEtapas.Location = new System.Drawing.Point(60, 209);
            this.labelNroEtapas.Name = "labelNroEtapas";
            this.labelNroEtapas.Size = new System.Drawing.Size(104, 20);
            this.labelNroEtapas.TabIndex = 6;
            this.labelNroEtapas.Text = "Nrº de etapas ";
            // 
            // nroEtapasProjeto
            // 
            this.nroEtapasProjeto.Location = new System.Drawing.Point(180, 209);
            this.nroEtapasProjeto.Name = "nroEtapasProjeto";
            this.nroEtapasProjeto.Size = new System.Drawing.Size(240, 20);
            this.nroEtapasProjeto.TabIndex = 7;
            // 
            // dateTimeProjeto
            // 
            this.dateTimeProjeto.Location = new System.Drawing.Point(180, 293);
            this.dateTimeProjeto.Name = "dateTimeProjeto";
            this.dateTimeProjeto.Size = new System.Drawing.Size(240, 20);
            this.dateTimeProjeto.TabIndex = 8;
            this.dateTimeProjeto.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelInicioProjeto
            // 
            this.labelInicioProjeto.AutoSize = true;
            this.labelInicioProjeto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInicioProjeto.Location = new System.Drawing.Point(55, 294);
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
            this.buttonCancelarNovoProjeto.Location = new System.Drawing.Point(237, 383);
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
            this.buttonCadastrarNovoProjeto.Location = new System.Drawing.Point(332, 384);
            this.buttonCadastrarNovoProjeto.Name = "buttonCadastrarNovoProjeto";
            this.buttonCadastrarNovoProjeto.Size = new System.Drawing.Size(88, 33);
            this.buttonCadastrarNovoProjeto.TabIndex = 17;
            this.buttonCadastrarNovoProjeto.Text = "Iniciar";
            this.buttonCadastrarNovoProjeto.UseVisualStyleBackColor = false;
            this.buttonCadastrarNovoProjeto.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelMembrosProjeto
            // 
            this.labelMembrosProjeto.AutoSize = true;
            this.labelMembrosProjeto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMembrosProjeto.Location = new System.Drawing.Point(17, 250);
            this.labelMembrosProjeto.Name = "labelMembrosProjeto";
            this.labelMembrosProjeto.Size = new System.Drawing.Size(147, 20);
            this.labelMembrosProjeto.TabIndex = 19;
            this.labelMembrosProjeto.Text = "Membros do projeto";
            // 
            // textBoxMembrosProjeto
            // 
            this.textBoxMembrosProjeto.Location = new System.Drawing.Point(180, 250);
            this.textBoxMembrosProjeto.Name = "textBoxMembrosProjeto";
            this.textBoxMembrosProjeto.Size = new System.Drawing.Size(240, 20);
            this.textBoxMembrosProjeto.TabIndex = 20;
            // 
            // Tela_cadastro_projeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 524);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxMembrosProjeto);
            this.Controls.Add(this.labelMembrosProjeto);
            this.Controls.Add(this.buttonCancelarNovoProjeto);
            this.Controls.Add(this.buttonCadastrarNovoProjeto);
            this.Controls.Add(this.labelInicioProjeto);
            this.Controls.Add(this.dateTimeProjeto);
            this.Controls.Add(this.nroEtapasProjeto);
            this.Controls.Add(this.labelNroEtapas);
            this.Controls.Add(this.listBoxClienteProjeto);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.nomeProjeto);
            this.Controls.Add(this.labelNomeProjeto);
            this.Controls.Add(this.labelNovoProjeto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tela_cadastro_projeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_cadastro_projeto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNovoProjeto;
        private System.Windows.Forms.Label labelNomeProjeto;
        private System.Windows.Forms.TextBox nomeProjeto;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.ListBox listBoxClienteProjeto;
        private System.Windows.Forms.Label labelNroEtapas;
        private System.Windows.Forms.TextBox nroEtapasProjeto;
        private System.Windows.Forms.DateTimePicker dateTimeProjeto;
        private System.Windows.Forms.Label labelInicioProjeto;
        private System.Windows.Forms.Button buttonCancelarNovoProjeto;
        private System.Windows.Forms.Button buttonCadastrarNovoProjeto;
        private System.Windows.Forms.Label labelMembrosProjeto;
        private System.Windows.Forms.TextBox textBoxMembrosProjeto;
    }
}