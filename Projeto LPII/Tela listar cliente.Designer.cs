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
            this.checkBoxListarClientesInativos = new System.Windows.Forms.CheckBox();
            this.checkBoxListarClientesAtivos = new System.Windows.Forms.CheckBox();
            this.groupBoxSelecionarClientes = new System.Windows.Forms.GroupBox();
            this.buttonVoltarListarCliente = new System.Windows.Forms.Button();
            this.buttonConfirmarListagemdeClientes = new System.Windows.Forms.Button();
            this.groupBoxSelecionarClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(12, 9);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(81, 21);
            this.labelCliente.TabIndex = 0;
            this.labelCliente.Text = "CLIENTES ";
            this.labelCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBoxListarClientesInativos
            // 
            this.checkBoxListarClientesInativos.AutoSize = true;
            this.checkBoxListarClientesInativos.Location = new System.Drawing.Point(73, 96);
            this.checkBoxListarClientesInativos.Name = "checkBoxListarClientesInativos";
            this.checkBoxListarClientesInativos.Size = new System.Drawing.Size(83, 24);
            this.checkBoxListarClientesInativos.TabIndex = 2;
            this.checkBoxListarClientesInativos.Text = "Inativos ";
            this.checkBoxListarClientesInativos.UseVisualStyleBackColor = true;
            // 
            // checkBoxListarClientesAtivos
            // 
            this.checkBoxListarClientesAtivos.AutoSize = true;
            this.checkBoxListarClientesAtivos.Location = new System.Drawing.Point(73, 57);
            this.checkBoxListarClientesAtivos.Name = "checkBoxListarClientesAtivos";
            this.checkBoxListarClientesAtivos.Size = new System.Drawing.Size(73, 24);
            this.checkBoxListarClientesAtivos.TabIndex = 3;
            this.checkBoxListarClientesAtivos.Text = "Ativos ";
            this.checkBoxListarClientesAtivos.UseVisualStyleBackColor = true;
            this.checkBoxListarClientesAtivos.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBoxSelecionarClientes
            // 
            this.groupBoxSelecionarClientes.Controls.Add(this.checkBoxListarClientesInativos);
            this.groupBoxSelecionarClientes.Controls.Add(this.checkBoxListarClientesAtivos);
            this.groupBoxSelecionarClientes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSelecionarClientes.Location = new System.Drawing.Point(52, 63);
            this.groupBoxSelecionarClientes.Name = "groupBoxSelecionarClientes";
            this.groupBoxSelecionarClientes.Size = new System.Drawing.Size(311, 151);
            this.groupBoxSelecionarClientes.TabIndex = 4;
            this.groupBoxSelecionarClientes.TabStop = false;
            this.groupBoxSelecionarClientes.Text = "Selecionar clientes ";
            this.groupBoxSelecionarClientes.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonVoltarListarCliente
            // 
            this.buttonVoltarListarCliente.BackColor = System.Drawing.Color.Crimson;
            this.buttonVoltarListarCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltarListarCliente.Location = new System.Drawing.Point(179, 233);
            this.buttonVoltarListarCliente.Name = "buttonVoltarListarCliente";
            this.buttonVoltarListarCliente.Size = new System.Drawing.Size(84, 34);
            this.buttonVoltarListarCliente.TabIndex = 28;
            this.buttonVoltarListarCliente.Text = "Voltar  ";
            this.buttonVoltarListarCliente.UseVisualStyleBackColor = false;
            this.buttonVoltarListarCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonConfirmarListagemdeClientes
            // 
            this.buttonConfirmarListagemdeClientes.BackColor = System.Drawing.Color.Orange;
            this.buttonConfirmarListagemdeClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmarListagemdeClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonConfirmarListagemdeClientes.Location = new System.Drawing.Point(275, 234);
            this.buttonConfirmarListagemdeClientes.Name = "buttonConfirmarListagemdeClientes";
            this.buttonConfirmarListagemdeClientes.Size = new System.Drawing.Size(88, 33);
            this.buttonConfirmarListagemdeClientes.TabIndex = 27;
            this.buttonConfirmarListagemdeClientes.Text = "OK";
            this.buttonConfirmarListagemdeClientes.UseVisualStyleBackColor = false;
            this.buttonConfirmarListagemdeClientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tela_listar_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 308);
            this.ControlBox = false;
            this.Controls.Add(this.buttonVoltarListarCliente);
            this.Controls.Add(this.buttonConfirmarListagemdeClientes);
            this.Controls.Add(this.groupBoxSelecionarClientes);
            this.Controls.Add(this.labelCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tela_listar_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_listar_cliente";
            this.Load += new System.EventHandler(this.Tela_listar_cliente_Load);
            this.groupBoxSelecionarClientes.ResumeLayout(false);
            this.groupBoxSelecionarClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.CheckBox checkBoxListarClientesInativos;
        private System.Windows.Forms.CheckBox checkBoxListarClientesAtivos;
        private System.Windows.Forms.GroupBox groupBoxSelecionarClientes;
        private System.Windows.Forms.Button buttonVoltarListarCliente;
        private System.Windows.Forms.Button buttonConfirmarListagemdeClientes;
    }
}