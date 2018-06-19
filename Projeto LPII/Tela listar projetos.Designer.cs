namespace Projeto_LPII
{
    partial class Tela_listar_projetos
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
            this.labelProjetos = new System.Windows.Forms.Label();
            this.groupBoxSelecioanarProjetos = new System.Windows.Forms.GroupBox();
            this.checkBoxListarProjetosStop = new System.Windows.Forms.CheckBox();
            this.checkBoxListarProjetosEncerrados = new System.Windows.Forms.CheckBox();
            this.checkBoxListarProjetoAndamento = new System.Windows.Forms.CheckBox();
            this.buttonVoltarListaProjetos = new System.Windows.Forms.Button();
            this.buttonConfirmaListaProjetos = new System.Windows.Forms.Button();
            this.groupBoxSelecioanarProjetos.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProjetos
            // 
            this.labelProjetos.AutoSize = true;
            this.labelProjetos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProjetos.Location = new System.Drawing.Point(12, 9);
            this.labelProjetos.Name = "labelProjetos";
            this.labelProjetos.Size = new System.Drawing.Size(84, 21);
            this.labelProjetos.TabIndex = 1;
            this.labelProjetos.Text = "PROJETOS";
            // 
            // groupBoxSelecioanarProjetos
            // 
            this.groupBoxSelecioanarProjetos.Controls.Add(this.checkBoxListarProjetosStop);
            this.groupBoxSelecioanarProjetos.Controls.Add(this.checkBoxListarProjetosEncerrados);
            this.groupBoxSelecioanarProjetos.Controls.Add(this.checkBoxListarProjetoAndamento);
            this.groupBoxSelecioanarProjetos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSelecioanarProjetos.Location = new System.Drawing.Point(31, 69);
            this.groupBoxSelecioanarProjetos.Name = "groupBoxSelecioanarProjetos";
            this.groupBoxSelecioanarProjetos.Size = new System.Drawing.Size(307, 180);
            this.groupBoxSelecioanarProjetos.TabIndex = 5;
            this.groupBoxSelecioanarProjetos.TabStop = false;
            this.groupBoxSelecioanarProjetos.Text = "Selecionar Projetos";
            // 
            // checkBoxListarProjetosStop
            // 
            this.checkBoxListarProjetosStop.AutoSize = true;
            this.checkBoxListarProjetosStop.Location = new System.Drawing.Point(73, 138);
            this.checkBoxListarProjetosStop.Name = "checkBoxListarProjetosStop";
            this.checkBoxListarProjetosStop.Size = new System.Drawing.Size(86, 24);
            this.checkBoxListarProjetosStop.TabIndex = 4;
            this.checkBoxListarProjetosStop.Text = "Em stop ";
            this.checkBoxListarProjetosStop.UseVisualStyleBackColor = true;
            this.checkBoxListarProjetosStop.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBoxListarProjetosEncerrados
            // 
            this.checkBoxListarProjetosEncerrados.AutoSize = true;
            this.checkBoxListarProjetosEncerrados.Location = new System.Drawing.Point(73, 96);
            this.checkBoxListarProjetosEncerrados.Name = "checkBoxListarProjetosEncerrados";
            this.checkBoxListarProjetosEncerrados.Size = new System.Drawing.Size(105, 24);
            this.checkBoxListarProjetosEncerrados.TabIndex = 2;
            this.checkBoxListarProjetosEncerrados.Text = "Encerrados ";
            this.checkBoxListarProjetosEncerrados.UseVisualStyleBackColor = true;
            // 
            // checkBoxListarProjetoAndamento
            // 
            this.checkBoxListarProjetoAndamento.AutoSize = true;
            this.checkBoxListarProjetoAndamento.Location = new System.Drawing.Point(73, 57);
            this.checkBoxListarProjetoAndamento.Name = "checkBoxListarProjetoAndamento";
            this.checkBoxListarProjetoAndamento.Size = new System.Drawing.Size(129, 24);
            this.checkBoxListarProjetoAndamento.TabIndex = 3;
            this.checkBoxListarProjetoAndamento.Text = "Em andamento";
            this.checkBoxListarProjetoAndamento.UseVisualStyleBackColor = true;
            // 
            // buttonVoltarListaProjetos
            // 
            this.buttonVoltarListaProjetos.BackColor = System.Drawing.Color.Crimson;
            this.buttonVoltarListaProjetos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltarListaProjetos.Location = new System.Drawing.Point(154, 271);
            this.buttonVoltarListaProjetos.Name = "buttonVoltarListaProjetos";
            this.buttonVoltarListaProjetos.Size = new System.Drawing.Size(84, 34);
            this.buttonVoltarListaProjetos.TabIndex = 30;
            this.buttonVoltarListaProjetos.Text = "Voltar  ";
            this.buttonVoltarListaProjetos.UseVisualStyleBackColor = false;
            this.buttonVoltarListaProjetos.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonConfirmaListaProjetos
            // 
            this.buttonConfirmaListaProjetos.BackColor = System.Drawing.Color.Orange;
            this.buttonConfirmaListaProjetos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmaListaProjetos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonConfirmaListaProjetos.Location = new System.Drawing.Point(250, 272);
            this.buttonConfirmaListaProjetos.Name = "buttonConfirmaListaProjetos";
            this.buttonConfirmaListaProjetos.Size = new System.Drawing.Size(88, 33);
            this.buttonConfirmaListaProjetos.TabIndex = 29;
            this.buttonConfirmaListaProjetos.Text = "OK";
            this.buttonConfirmaListaProjetos.UseVisualStyleBackColor = false;
            // 
            // Tela_listar_projetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 347);
            this.ControlBox = false;
            this.Controls.Add(this.buttonVoltarListaProjetos);
            this.Controls.Add(this.groupBoxSelecioanarProjetos);
            this.Controls.Add(this.buttonConfirmaListaProjetos);
            this.Controls.Add(this.labelProjetos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tela_listar_projetos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_listar_projetos";
            this.Load += new System.EventHandler(this.Tela_listar_projetos_Load);
            this.groupBoxSelecioanarProjetos.ResumeLayout(false);
            this.groupBoxSelecioanarProjetos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProjetos;
        private System.Windows.Forms.GroupBox groupBoxSelecioanarProjetos;
        private System.Windows.Forms.CheckBox checkBoxListarProjetosEncerrados;
        private System.Windows.Forms.CheckBox checkBoxListarProjetoAndamento;
        private System.Windows.Forms.CheckBox checkBoxListarProjetosStop;
        private System.Windows.Forms.Button buttonVoltarListaProjetos;
        private System.Windows.Forms.Button buttonConfirmaListaProjetos;
    }
}