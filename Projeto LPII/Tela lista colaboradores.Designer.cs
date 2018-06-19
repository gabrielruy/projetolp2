namespace Projeto_LPII
{
    partial class Tela_lista_colaboradores
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
            this.labelcolaboradores = new System.Windows.Forms.Label();
            this.labelpesquisar = new System.Windows.Forms.Label();
            this.listarColaboradores = new System.Windows.Forms.TextBox();
            this.buttonConfirmarListarColaboradores = new System.Windows.Forms.Button();
            this.buttonVoltaListaColaboradores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelcolaboradores
            // 
            this.labelcolaboradores.AutoSize = true;
            this.labelcolaboradores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcolaboradores.Location = new System.Drawing.Point(12, 9);
            this.labelcolaboradores.Name = "labelcolaboradores";
            this.labelcolaboradores.Size = new System.Drawing.Size(149, 21);
            this.labelcolaboradores.TabIndex = 1;
            this.labelcolaboradores.Text = "COLABORADORES  ";
            // 
            // labelpesquisar
            // 
            this.labelpesquisar.AutoSize = true;
            this.labelpesquisar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpesquisar.Location = new System.Drawing.Point(60, 72);
            this.labelpesquisar.Name = "labelpesquisar";
            this.labelpesquisar.Size = new System.Drawing.Size(71, 20);
            this.labelpesquisar.TabIndex = 2;
            this.labelpesquisar.Text = "Pesquisar";
            // 
            // listarColaboradores
            // 
            this.listarColaboradores.Location = new System.Drawing.Point(137, 67);
            this.listarColaboradores.Multiline = true;
            this.listarColaboradores.Name = "listarColaboradores";
            this.listarColaboradores.Size = new System.Drawing.Size(180, 30);
            this.listarColaboradores.TabIndex = 3;
            // 
            // buttonConfirmarListarColaboradores
            // 
            this.buttonConfirmarListarColaboradores.BackColor = System.Drawing.Color.Orange;
            this.buttonConfirmarListarColaboradores.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmarListarColaboradores.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmarListarColaboradores.Location = new System.Drawing.Point(323, 67);
            this.buttonConfirmarListarColaboradores.Name = "buttonConfirmarListarColaboradores";
            this.buttonConfirmarListarColaboradores.Size = new System.Drawing.Size(82, 30);
            this.buttonConfirmarListarColaboradores.TabIndex = 4;
            this.buttonConfirmarListarColaboradores.Text = "OK";
            this.buttonConfirmarListarColaboradores.UseVisualStyleBackColor = false;
            // 
            // buttonVoltaListaColaboradores
            // 
            this.buttonVoltaListaColaboradores.BackColor = System.Drawing.Color.Crimson;
            this.buttonVoltaListaColaboradores.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltaListaColaboradores.ForeColor = System.Drawing.Color.White;
            this.buttonVoltaListaColaboradores.Location = new System.Drawing.Point(323, 103);
            this.buttonVoltaListaColaboradores.Name = "buttonVoltaListaColaboradores";
            this.buttonVoltaListaColaboradores.Size = new System.Drawing.Size(82, 30);
            this.buttonVoltaListaColaboradores.TabIndex = 5;
            this.buttonVoltaListaColaboradores.Text = "Voltar";
            this.buttonVoltaListaColaboradores.UseVisualStyleBackColor = false;
            this.buttonVoltaListaColaboradores.Click += new System.EventHandler(this.buttonVoltaListaColaboradores_Click);
            // 
            // Tela_lista_colaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 178);
            this.ControlBox = false;
            this.Controls.Add(this.buttonVoltaListaColaboradores);
            this.Controls.Add(this.buttonConfirmarListarColaboradores);
            this.Controls.Add(this.listarColaboradores);
            this.Controls.Add(this.labelpesquisar);
            this.Controls.Add(this.labelcolaboradores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tela_lista_colaboradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_lista_colaboradores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelcolaboradores;
        private System.Windows.Forms.Label labelpesquisar;
        private System.Windows.Forms.TextBox listarColaboradores;
        private System.Windows.Forms.Button buttonConfirmarListarColaboradores;
        private System.Windows.Forms.Button buttonVoltaListaColaboradores;
    }
}