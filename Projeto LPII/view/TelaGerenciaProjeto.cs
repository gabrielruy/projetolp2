using Projeto_LPII.model.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_LPII.view
{
    public partial class TelaGerenciaProjeto : Form
    {
        private ProjetoDAO daoProj = new ProjetoDAO();
        private TrabalhaEmProjetoDAO daoTrab = new TrabalhaEmProjetoDAO();

        public TelaGerenciaProjeto()
        {
            InitializeComponent();
            AtualizaDGV();
        }

        private void AtualizaDGV()
        {
            List<Projeto> lista = daoProj.ListAll();

            dataGridView1.Rows.Clear();

            foreach (Projeto p in lista)
                dataGridView1.Rows.Add(p.Codigo.ToString(), p.Nome);

            dataGridView1.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e) //Buscar
        {
            dataGridView1.DataSource = null;
            List<Projeto> projeto = new List<Projeto>();

            if (textBox2.Text.Equals("")) //Se for vazio lista todos
                AtualizaDGV();
            else //Se tiver alguma entrada...
            {
                projeto = daoProj.ListByName(textBox2.Text); //Lê do banco
                dataGridView1.Rows.Clear(); //Limpa o Data Grid View
                //Adiciona somente o procurado
                foreach(Projeto proj in projeto)
                {
                    dataGridView1.Rows.Add(proj.Codigo.ToString(), proj.Nome);
                }

                /* Limpa a seleção de linhas no Data Grid View */
                dataGridView1.ClearSelection();
            }

            dataGridView1.ClearSelection();
        }

        private void buttonVoltarListarCliente_Click(object sender, EventArgs e) //Atualizar
        {
            Projeto projeto;

            projeto = GetDTO();

            if (daoProj.Update(projeto))
            {
                MessageBox.Show("O Projeto foi atualizado.", "Projeto atualizado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizaDGV();
            }    
            else
                MessageBox.Show("Erro ao atualizar.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e) //Excluir
        {
            var result = MessageBox.Show(this, "Você tem certeza que deseja excluir este fornecedor?",
                "Deseja excluir fornecedor?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Projeto p = GetDTO();

                if (daoProj.Delete(p))
                {
                    MessageBox.Show("Fornecedor foi excluído.", "Fornecedor Excluído",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                AtualizaDGV(); 

                LimparTextBox(); 
            }
        }

        private void buttonConfirmarListagemdeClientes_Click(object sender, EventArgs e) //Cancelar
        {
            LimparTextBox();
        }

        private void button2_Click(object sender, EventArgs e) //Voltar
        {
            this.Close();
        }

        private void LimparTextBox()
        {
            textBox1.Text = "";
            txtCodigo.Text = "";
            txtSituacao.Text = null;
            dateTimeProjeto.Text = "";
            dateTimePicker1.Text = "";
            comboBox2.Text = "";
            txtNroCliente.Text = "";
            dataGridView2.Rows.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibeProjeto();
        }

        private void ExibeProjeto()
        {
            int codigo = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            Projeto p = daoProj.Read(codigo);
            SetDTO_Projeto(p);
            AtualizaDGV_Colaborador(p.Codigo);
        }

        private void SetDTO_Projeto(Projeto p)
        {
            txtCodigo.Text = p.Codigo.ToString(); //Codigo
            txtNroCliente.Text = p.Cliente.Codigo.ToString(); //Codigo do cliente
            comboBox2.Text = p.Cliente.Nome.ToString(); //Cliente
            textBox1.Text = p.Nome; //Nome
            dateTimeProjeto.Text = p.DataInicio.ToLongDateString(); //Data inicio
            dateTimePicker1.Text = p.PrevisaoTermino.ToLongDateString(); //Previsao Termino
            txtSituacao.Text = p.Situacao; //Situacao
        }

        private Projeto GetDTO()
        {
            Projeto projeto = new Projeto();
            projeto.Cliente = new Cliente();

            projeto.Codigo = int.Parse(txtCodigo.Text);
            projeto.Nome = textBox1.Text;
            projeto.Cliente.Codigo = int.Parse(txtNroCliente.Text);
            projeto.DataInicio = dateTimeProjeto.Value;
            projeto.PrevisaoTermino = dateTimePicker1.Value;
            projeto.Situacao = txtSituacao.Text;
            return projeto;
        }

        private void AtualizaDGV_Colaborador(int codigo)
        {
            List<TrabalhaEmProjeto> lista = daoTrab.ListAll(codigo);

            dataGridView2.Rows.Clear();

            foreach (TrabalhaEmProjeto t in lista)
                dataGridView2.Rows.Add(t.Colaborador.Nome);

            dataGridView2.ClearSelection();
        }
    }
}
