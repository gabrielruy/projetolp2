namespace Projeto_LPII.view
{
    partial class TelaTrabalhoEmProjeto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.radioEmAndamento = new System.Windows.Forms.RadioButton();
            this.radioPausado = new System.Windows.Forms.RadioButton();
            this.radioTodos = new System.Windows.Forms.RadioButton();
            this.radioPendente = new System.Windows.Forms.RadioButton();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Previsao_Termino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Cliente,
            this.Nome,
            this.Data_Inicio,
            this.Previsao_Termino,
            this.Situação});
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(937, 311);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(835, 368);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(114, 33);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // radioEmAndamento
            // 
            this.radioEmAndamento.AutoSize = true;
            this.radioEmAndamento.Location = new System.Drawing.Point(133, 12);
            this.radioEmAndamento.Name = "radioEmAndamento";
            this.radioEmAndamento.Size = new System.Drawing.Size(97, 17);
            this.radioEmAndamento.TabIndex = 3;
            this.radioEmAndamento.TabStop = true;
            this.radioEmAndamento.Text = "Em Andamento";
            this.radioEmAndamento.UseVisualStyleBackColor = true;
            this.radioEmAndamento.CheckedChanged += new System.EventHandler(this.radioEmAndamento_CheckedChanged);
            // 
            // radioPausado
            // 
            this.radioPausado.AutoSize = true;
            this.radioPausado.Location = new System.Drawing.Point(282, 12);
            this.radioPausado.Name = "radioPausado";
            this.radioPausado.Size = new System.Drawing.Size(67, 17);
            this.radioPausado.TabIndex = 4;
            this.radioPausado.TabStop = true;
            this.radioPausado.Text = "Pausado";
            this.radioPausado.UseVisualStyleBackColor = true;
            this.radioPausado.CheckedChanged += new System.EventHandler(this.radioPausado_CheckedChanged);
            // 
            // radioTodos
            // 
            this.radioTodos.AutoSize = true;
            this.radioTodos.Location = new System.Drawing.Point(398, 12);
            this.radioTodos.Name = "radioTodos";
            this.radioTodos.Size = new System.Drawing.Size(55, 17);
            this.radioTodos.TabIndex = 5;
            this.radioTodos.TabStop = true;
            this.radioTodos.Text = "Todos";
            this.radioTodos.UseVisualStyleBackColor = true;
            this.radioTodos.CheckedChanged += new System.EventHandler(this.radioTodos_CheckedChanged);
            // 
            // radioPendente
            // 
            this.radioPendente.AutoSize = true;
            this.radioPendente.Location = new System.Drawing.Point(12, 12);
            this.radioPendente.Name = "radioPendente";
            this.radioPendente.Size = new System.Drawing.Size(71, 17);
            this.radioPendente.TabIndex = 6;
            this.radioPendente.TabStop = true;
            this.radioPendente.Text = "Pendente";
            this.radioPendente.UseVisualStyleBackColor = true;
            this.radioPendente.CheckedChanged += new System.EventHandler(this.radioPendente_CheckedChanged);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.Width = 70;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 130;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 250;
            // 
            // Data_Inicio
            // 
            this.Data_Inicio.HeaderText = "Data de Início";
            this.Data_Inicio.Name = "Data_Inicio";
            this.Data_Inicio.Width = 160;
            // 
            // Previsao_Termino
            // 
            this.Previsao_Termino.HeaderText = "Previsao Término";
            this.Previsao_Termino.Name = "Previsao_Termino";
            this.Previsao_Termino.Width = 160;
            // 
            // Situação
            // 
            this.Situação.HeaderText = "Situação";
            this.Situação.Name = "Situação";
            // 
            // TelaTrabalhoEmProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 417);
            this.Controls.Add(this.radioPendente);
            this.Controls.Add(this.radioTodos);
            this.Controls.Add(this.radioPausado);
            this.Controls.Add(this.radioEmAndamento);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TelaTrabalhoEmProjeto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA GERENCIADOR DE PROJETOS - Projetos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.RadioButton radioEmAndamento;
        private System.Windows.Forms.RadioButton radioPausado;
        private System.Windows.Forms.RadioButton radioTodos;
        private System.Windows.Forms.RadioButton radioPendente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Previsao_Termino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situação;
    }
}