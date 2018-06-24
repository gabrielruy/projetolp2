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

namespace Projeto_LPII
{
    public partial class Tela_listar_projetos : Form
    {

        /* Atributos responsáveis pelo CRUD */
        private ProjetoDAO daoProj = new ProjetoDAO();
        private TrabalhaEmProjetoDAO daoTrab = new TrabalhaEmProjetoDAO();
        private ColaboradorDAO daoColab = new ColaboradorDAO();

        public Tela_listar_projetos()
        {
            InitializeComponent();
        }

        private void Tela_listar_projetos_Load(object sender, EventArgs e)
        {
            AtualizaDGV(); /* Atualiza o Data Grid View */
        }

        /* Atualiza as informações do dataGridView */
        private void AtualizaDGV()
        {
            /* Recebe todos os colaboradores do Bando de Dados */
            List<Projeto> lista = daoProj.ListAll();

            /* Limpa o Data Grid View */
            dataGridView1.Rows.Clear();

            /* Percorre a lista adicionando os fornecedores no Data Grid View */
            foreach (Projeto p in lista)
                dataGridView1.Rows.Add(p.Cliente, p.Nome);

            /* Limpa a seleção de linhas no Data Grid View */
            dataGridView1.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e) //Voltar
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibeProjeto();
        }

        /*private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibeProjeto();
        }*/

        /* Verifica qual cliente foi selecionado e o exibe */
        private void ExibeProjeto()
        {
            /* Pega o código do fornecedor selecionado */
            int codigo = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            /* Busca no Banco de Dados e preenche a tela */
            Projeto p = daoProj.Read(codigo);
            SetDTO_Projeto(p);
            AtualizaDGV_Colaborador(p.Codigo);
        }

        /* Preenche a tela com as informações passadas com a categoria */
        private void SetDTO_Projeto(Projeto p)
        {
            textBox3.Text = p.Codigo.ToString();
            textBox1.Text = p.Cliente.ToString(); //Cliente
            nomeProjeto.Text = p.Nome; //Nome
            dateTimeProjeto.Text = p.DataInicio.ToLongDateString(); //Data inicio
            dateTimePicker1.Text = p.PrevisaoTermino.ToLongDateString(); //Previsao Termino
            txtSituacao.Text = p.Situacao; //Situacao
        }

        /* Retorna um objeto categoria com as informações recolhidas da tela */
        private Projeto GetDTO()
        {
            Projeto projeto = new Projeto();

            projeto.Codigo = int.Parse(textBox3.Text);
            projeto.Nome = nomeProjeto.Text;
            projeto.Cliente = int.Parse(textBox1.Text);
            projeto.DataInicio = DateTime.Parse(dateTimeProjeto.Text);
            projeto.PrevisaoTermino = DateTime.Parse(dateTimePicker1.Text);
            projeto.Situacao = txtSituacao.Text;
            return projeto;
        }

        /* Atualiza as informações do dataGridView */
        private void AtualizaDGV_Colaborador(int codigo)
        {
            /* Recebe todos os colaboradores do Bando de Dados */
            List<TrabalhaEmProjeto> lista = daoTrab.ListAll(codigo);

            /* Limpa o Data Grid View */
            dataGridView2.Rows.Clear();

            /* Percorre a lista adicionando os fornecedores no Data Grid View */
            foreach (TrabalhaEmProjeto t in lista)
                dataGridView2.Rows.Add(t.Colaborador.Nome);

            /* Limpa a seleção de linhas no Data Grid View */
            dataGridView2.ClearSelection();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonConfirmaListaProjetos_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonVoltarListarCliente_Click(object sender, EventArgs e) //Atualizar
        {
            Projeto projeto;

            /* Chama o método para retornar um objeto Cliente com as informações da tela */
            projeto = GetDTO();

            if (daoProj.Update(projeto))
                MessageBox.Show("O Projeto foi atualizado.", "Projeto atualizado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Erro ao atualizar.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e) //Excluir
        {
            /* Verifica se o usúario tem certeza que deseja excluir o fornecedor */
            var result = MessageBox.Show(this, "Você tem certeza que deseja excluir este fornecedor?",
                "Deseja excluir fornecedor?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                /* Busca no Banco de Dados e exclui */
                Projeto p = GetDTO();

                /* Chama o método para excluir o fornecedor do bd */
                if (daoProj.Delete(p))
                {
                    /* Mensagem indicando que o fornecedor foi excluído */
                    MessageBox.Show("Fornecedor foi excluído.", "Fornecedor Excluído",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                AtualizaDGV(); /* Atualiza o Data Grid View */

                LimparTextBox(); /* Limpa as caixas de texto */
            }
        }

        /* Limpa as caixas de texto */
        private void LimparTextBox()
        {
            textBox1.Text = "";
            textBox3.Text = "";
            nomeProjeto.Text = "";
            dateTimeProjeto.Text = "";
            dateTimePicker1.Text = "";
            txtSituacao.Text = "";
        }

        private void buttonConfirmarListagemdeClientes_Click(object sender, EventArgs e) //Cancelar
        {
            LimparTextBox();
        }

        private void button3_Click(object sender, EventArgs e) //Buscar
        {
            dataGridView1.DataSource = null;
            Projeto projeto = new Projeto();

            if (textBox2.Text.Equals("")) //Se for vazio lista todos
                AtualizaDGV();
            else //Se tiver alguma entrada...
            {
                projeto = daoProj.Read(textBox2.Text); //Lê do banco
                dataGridView1.Rows.Clear(); //Limpa o Data Grid View
                //Adiciona somente o procurado
                dataGridView1.Rows.Add(projeto.Codigo.ToString(), projeto.Nome);
                /* Limpa a seleção de linhas no Data Grid View */
                dataGridView1.ClearSelection();
            }

            textBox2.Text = "";  // esvazia o campo, para proximo uso

            /* Limpa a seleção de linhas no Data Grid View */
            dataGridView1.ClearSelection();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
