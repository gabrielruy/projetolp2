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
    public partial class Tela_listar_cliente : Form
    {
        /* Atributo responsável pelo CRUD Fornecedor */
        private ClienteDAO dao = new ClienteDAO();

        public Tela_listar_cliente()
        {
            InitializeComponent();
        }

        private void Tela_listar_cliente_Load(object sender, EventArgs e)
        {
            AtualizaDGV(); /* Atualiza o Data Grid View */
        }

        /* Atualiza as informações do dataGridView */
        private void AtualizaDGV()
        {
            /* Recebe todos os fornecedores do Bando de Dados */
            List<Cliente> lista = dao.ListAll();

            /* Limpa o Data Grid View */
            dataGridView1.Rows.Clear();

            /* Percorre a lista adicionando os fornecedores no Data Grid View */
            foreach (Cliente cliente in lista)
                dataGridView1.Rows.Add(cliente.Codigo.ToString(), cliente.Nome);

            /* Limpa a seleção de linhas no Data Grid View */
            dataGridView1.ClearSelection();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Cancelar
        {
            LimparTextBox();
        }

        /* Limpa as caixas de texto */
        private void LimparTextBox()
        {
            textBox1.Text = "";
            nomeCliente.Text = "";
            maskedTextBox1.Text = "";
            emailCliente.Text = "";
            maskedTextBox2.Text = "";
            ruaCliente.Text = "";
            maskedTextBox3.Text = "";
            cidadeCliente.Text = "";
            comboBox1.Text = "";
            nomeContatoCliente.Text = "";
        }

        private void button2_Click(object sender, EventArgs e) //Atualizar
        {
            Cliente cliente;

            /* Chama o método para retornar um objeto Cliente com as informações da tela */
            cliente = GetDTO();

            if (dao.Update(cliente))
                MessageBox.Show("O Cliente foi atualizado.", "Cliente atualizado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Erro ao atualizar.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /* Retorna um objeto categoria com as informações recolhidas da tela */
        private Cliente GetDTO()
        {
            Cliente cliente = new Cliente();

            cliente.Codigo = int.Parse(textBox1.Text);
            cliente.Nome = nomeCliente.Text;
            cliente.Cnpj = maskedTextBox1.Text;
            //cliente.Telefone = ;
            cliente.Email = emailCliente.Text;
            cliente.Responsavel = nomeContatoCliente.Text;
            cliente.Rua = ruaCliente.Text;
            cliente.Numero = int.Parse(maskedTextBox3.Text);
            cliente.Cep = maskedTextBox2.Text;
            cliente.Cidade = cidadeCliente.Text;
            cliente.Estado = comboBox1.Text;
            return cliente;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibeCliente();
        }

        /*private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibeCliente();
        }*/

        /* Verifica qual cliente foi selecionado e o exibe */
        private void ExibeCliente()
        {
            /* Pega o código do fornecedor selecionado */
            int codigo = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            /* Busca no Banco de Dados e preenche a tela */
            Cliente c = dao.Read(codigo);
            SetDTO(c);
        }

        /* Preenche a tela com as informações passadas com a categoria */
        private void SetDTO(Cliente c)
        {
            textBox1.Text = c.Codigo.ToString(); //Codigo
            nomeCliente.Text = c.Nome; //Nome
            maskedTextBox1.Text = c.Cnpj; //CNPJ
            emailCliente.Text = c.Email; //Email
            ///////////// Telefone
            maskedTextBox2.Text = c.Cep; //CEP
            ruaCliente.Text = c.Rua; //Rua
            maskedTextBox3.Text = c.Numero.ToString(); //Numero
            cidadeCliente.Text = c.Cidade; //Cidade
            comboBox1.Text = c.Estado; //Estado
        }

        private void button3_Click(object sender, EventArgs e) //Buscar
        {
            dataGridView1.DataSource = null;
            Cliente cliente = new Cliente();

            if (textBox2.Text.Equals("")) //Se for vazio lista todos
                AtualizaDGV();
            else //Se tiver alguma entrada...
            {
                cliente = dao.Read(textBox2.Text); //Lê do banco
                dataGridView1.Rows.Clear(); //Limpa o Data Grid View
                //Adiciona somente o procurado
                dataGridView1.Rows.Add(cliente.Codigo.ToString(), cliente.Nome);
                /* Limpa a seleção de linhas no Data Grid View */
                dataGridView1.ClearSelection();
            }

            textBox2.Text = "";  // esvazia o campo, para proximo uso

            /* Limpa a seleção de linhas no Data Grid View */
            dataGridView1.ClearSelection();
        }

        private void button1_Click_1(object sender, EventArgs e) //Excluir
        {
            /* Verifica se o usúario tem certeza que deseja excluir o fornecedor */
            var result = MessageBox.Show(this, "Você tem certeza que deseja excluir este fornecedor?",
                "Deseja excluir fornecedor?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                /* Busca no Banco de Dados e exclui */
                Cliente c = GetDTO();

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

        private void button2_Click_1(object sender, EventArgs e) //Voltar
        {
            this.Close();
        }
    }
}
