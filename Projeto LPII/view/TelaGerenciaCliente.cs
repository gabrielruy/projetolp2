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
    public partial class TelaGerenciaCliente : Form
    {
        private ClienteDAO dao = new ClienteDAO();

        public TelaGerenciaCliente()
        {
            InitializeComponent();
            AtualizaDGV();
        }

        private void TelaGerenciaCliente_Load(object sender, EventArgs e)
        {
            AtualizaDGV();
        }

        private void AtualizaDGV()
        {
            List<Cliente> lista = dao.ListAll();

            dataGrid.Rows.Clear();

            foreach (Cliente cliente in lista)
                dataGrid.Rows.Add(cliente.Codigo.ToString(), cliente.Nome);

            dataGrid.ClearSelection();
        }

        private void buttonConfirmarListagemdeClientes_Click(object sender, EventArgs e) //Cancelar
        {
            LimparTextBox();
            AtualizaDGV();
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e) //Buscar
        {
            dataGrid.DataSource = null;
            List<Cliente> clientes = new List<Cliente>();

            if (textBox2.Text.Equals("")) //Se for vazio lista todos
                AtualizaDGV();
            else //Se tiver alguma entrada...
            {
                clientes = dao.ListByName(textBox2.Text); //Lê do banco
                dataGrid.Rows.Clear(); //Limpa o Data Grid View
                //Adiciona somente o procurado
                foreach(Cliente cliente in clientes)
                {
                    dataGrid.Rows.Add(cliente.Codigo.ToString(), cliente.Nome);
                    dataGrid.ClearSelection();
                }
            }

            dataGrid.ClearSelection();
        }

        private void buttonVoltarListarCliente_Click(object sender, EventArgs e) //Atualizar
        {
            Cliente cliente;

            cliente = GetDTO();

            if (dao.Update(cliente))
            {
                MessageBox.Show("O Cliente foi atualizado.", "Cliente atualizado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizaDGV();
            }               
            else
                MessageBox.Show("Erro ao atualizar.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e) //Excluir
        {
            var result = MessageBox.Show(this, "Você tem certeza que deseja excluir este cliente?",
                "Deseja excluir cliente?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Cliente c = GetDTO();

                if (dao.Delete(c))
                {
                    MessageBox.Show("Cliente foi excluído.", "Cliente Excluído",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                AtualizaDGV(); 

                LimparTextBox(); 
            }
        }

        private void button2_Click(object sender, EventArgs e) //Voltar
        {
            this.Close();
        }

        private void SetDTO(Cliente c)
        {
            txtCodigo.Text = c.Codigo.ToString(); //Codigo
            nomeCliente.Text = c.Nome; //Nome
            maskedTextBox1.Text = c.Cnpj; //CNPJ
            emailCliente.Text = c.Email; //Email
            maskedTextBoxTelefoneCliente.Text = c.Telefone; //Telefone
            txtCep.Text = c.Cep; //CEP
            ruaCliente.Text = c.Rua; //Rua
            maskedTextBox3.Text = c.Numero.ToString(); //Numero
            cidadeCliente.Text = c.Cidade; //Cidade
            comboBox1.Text = c.Estado; //Estado
            nomeContatoCliente.Text = c.Responsavel; //Responsavel
        }

        private void LimparTextBox()
        {
            txtCodigo.Text = "";
            nomeCliente.Text = "";
            maskedTextBox1.Text = "";
            emailCliente.Text = "";
            maskedTextBoxTelefoneCliente.Text = "";
            txtCep.Text = "";
            ruaCliente.Text = "";
            maskedTextBox3.Text = "";
            cidadeCliente.Text = "";
            comboBox1.Text = null;
            nomeContatoCliente.Text = "";
        }

        private Cliente GetDTO()
        {
            Cliente cliente = new Cliente();

            if(txtCodigo.Text != null)
            {
                cliente.Codigo = int.Parse(txtCodigo.Text);
                cliente.Nome = nomeCliente.Text;
                cliente.Cnpj = maskedTextBox1.Text;
                cliente.Telefone = maskedTextBoxTelefoneCliente.Text;
                cliente.Email = emailCliente.Text;
                cliente.Responsavel = nomeContatoCliente.Text;
                cliente.Rua = ruaCliente.Text;
                cliente.Numero = int.Parse(maskedTextBox3.Text);
                cliente.Cep = txtCep.Text;
                cliente.Cidade = cidadeCliente.Text;
                cliente.Estado = comboBox1.Text;
                return cliente;
            }
            return null;
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibeCliente();
        }

        private void ExibeCliente()
        {
            int codigo = int.Parse(dataGrid.CurrentRow.Cells[0].Value.ToString());

            Cliente c = dao.Read(codigo);
            SetDTO(c);
        }
    }
}
