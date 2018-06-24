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
    public partial class Tela_lista_colaboradores : Form
    {
        /* Atributo responsável pelo CRUD Fornecedor */
        private ColaboradorDAO dao = new ColaboradorDAO();

        public Tela_lista_colaboradores()
        {
            InitializeComponent();
        }

        private void Tela_lista_colaboradores_load(object sender, EventArgs e)
        {
            AtualizaDGV(); /* Atualiza o Data Grid View */
        }

        /* Atualiza as informações do dataGridView */
        private void AtualizaDGV()
        {
            /* Recebe todos os fornecedores do Bando de Dados */
            List<Colaborador> lista = dao.ListAll();

            /* Limpa o Data Grid View */
            dataGridView1.Rows.Clear();

            /* Percorre a lista adicionando os fornecedores no Data Grid View */
            foreach (Colaborador c in lista)
                dataGridView1.Rows.Add(c.Codigo.ToString(), c.Nome);

            /* Limpa a seleção de linhas no Data Grid View */
            dataGridView1.ClearSelection();
        }

        /* Preenche a tela com as informações passadas com a categoria */
        private void SetDTO(Colaborador c)
        {
            ////////// .Text = c.Codigo.ToString(); //Codigo
            nomeColaborador.Text = c.Nome; //Nome
            cadastroLoginColaborador.Text = c.Login; //Login
            cadastroSenhaColaborador.Text = c.Senha; //Senha
            maskedTextBox1.Text = c.Senha; // Telefone
            comboBox1.Text = c.Cargo; //Cargo
            maskedTextBox2.Text = c.NroRh.ToString(); //NroRh
            emailColaborador.Text = c.Email; //Email

        }

        /* Retorna um objeto categoria com as informações recolhidas da tela */
        private Colaborador GetDTO()
        {
            Colaborador c = new Colaborador();

            //c.Codigo = int.Parse(textBox1.Text);
            c.Nome = nomeColaborador.Text;
            c.Login = cadastroLoginColaborador.Text;
            c.Senha = cadastroSenhaColaborador.Text;
            c.Telefone = maskedTextBox1.Text;
            c.Cargo = comboBox1.Text;
            c.NroRh = int.Parse(maskedTextBox2.Text);
            c.Email = emailColaborador.Text;
            return c;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibeColaborador();
        }

        /*private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibeColaborador();
        }*/

        /* Verifica qual cliente foi selecionado e o exibe */
        private void ExibeColaborador()
        {
            /* Pega o código do fornecedor selecionado */
            int codigo = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            /* Busca no Banco de Dados e preenche a tela */
            Colaborador c = dao.Read(codigo);
            SetDTO(c);
        }

        private void buttonVoltaListaColaboradores_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) //Buscar
        {
            dataGridView1.DataSource = null;
            Colaborador c = new Colaborador();

            if (textBox2.Text.Equals("")) //Se for vazio lista todos
                AtualizaDGV();
            else //Se tiver alguma entrada...
            {
                c = dao.Read(textBox2.Text); //Lê do banco
                dataGridView1.Rows.Clear(); //Limpa o Data Grid View
                //Adiciona somente o procurado
                dataGridView1.Rows.Add(c.Codigo.ToString(), c.Nome);
                /* Limpa a seleção de linhas no Data Grid View */
                dataGridView1.ClearSelection();
            }

            textBox2.Text = "";  // esvazia o campo, para proximo uso

            /* Limpa a seleção de linhas no Data Grid View */
            dataGridView1.ClearSelection();
        }

        private void buttonVoltarListarCliente_Click(object sender, EventArgs e) //Atualizar
        {
            Colaborador c;

            /* Chama o método para retornar um objeto Colaborador com as informações da tela */
            c = GetDTO();

            if (dao.Update(c))
                MessageBox.Show("O colaborador foi atualizado.", "Colaborador atualizado",
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
                Colaborador c = GetDTO();

                /* Chama o método para excluir o fornecedor do bd */
                if (dao.Delete(c))
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
            nomeColaborador.Text = "";
            emailColaborador.Text = "";
            maskedTextBox1.Text = "";
            comboBox1.Text = "";
            maskedTextBox2.Text = "";
            cadastroLoginColaborador.Text = "";
            cadastroSenhaColaborador.Text = "";
        }

        private void buttonConfirmarListagemdeClientes_Click(object sender, EventArgs e) //Cancelar
        {
            LimparTextBox();
        }

        private void button2_Click(object sender, EventArgs e) //Voltar
        {
            this.Close();
        }
    }
}
