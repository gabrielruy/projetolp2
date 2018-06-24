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
    public partial class Tela_cadastro_de_cliente : Form
    {

        /* Atributo responsável pelo CRUD Cliente */
        private ClienteDAO dao = new ClienteDAO();

        public Tela_cadastro_de_cliente()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Cadastrar
        {
            Cliente cliente;

            /* Chama o método para retornar um objeto Cliente com as informações da tela */
            cliente = GetDTO();

            if (dao.Create(cliente))
                MessageBox.Show("O Cliente foi cadastrado.", "Cliente Cadastrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Erro ao cadastrar.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e) // Cancelar
        {
            nomeCliente.Text = ""; //Nome
            textBox1.Text = ""; //Codigo
            maskedTextBox1.Text = ""; //CNPJ
            emailCliente.Text = ""; //Email
            txtCep.Text = ""; //CEP
            ruaCliente.Text = ""; //Rua
            maskedTextBox3.Text = ""; //Numero
            cidadeCliente.Text = ""; //Cidade
            comboBox1.Text = ""; //UF - Estado
            nomeContatoCliente.Text = ""; //Responsavel
            // Ta faltando telefone

            this.Close(); 
        }

        /* Retorna um objeto categoria com as informações recolhidas da tela */
        private Cliente GetDTO()
        {
            Cliente cliente = new Cliente();

            /* Quando um Cliente é adicionado, não é inserido o código */
            if (!textBox1.Text.Equals(""))
                cliente.Codigo = int.Parse(textBox1.Text);
            cliente.Nome = nomeCliente.Text;
            cliente.Cnpj = maskedTextBox1.Text;
            //cliente.Telefone = ;
            cliente.Email = emailCliente.Text;
            cliente.Responsavel = nomeContatoCliente.Text;
            cliente.Rua = ruaCliente.Text;
            cliente.Numero = int.Parse(maskedTextBox3.Text);
            cliente.Cep = txtCep.Text;
            cliente.Cidade = cidadeCliente.Text;
            cliente.Estado = comboBox1.Text;
            return cliente;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
