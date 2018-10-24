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
    public partial class Tela_cadastro_de_colaborador : Form
    {
        /* Atributo responsável pelo CRUD Cliente */
        private ColaboradorDAO dao = new ColaboradorDAO();

        public Tela_cadastro_de_colaborador()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Tela_cadastro_de_colaborador_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //Cancelar
        {
            //Colocar aqui se precisar limpar a tela
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonconfirmarCadastroColaborador_Click(object sender, EventArgs e) //Cadastrar
        {
            bool isFilled = new bool();
            isFilled = estaPreenchido();

            if (isFilled)
            {
                Colaborador c;

                /* Chama o método para retornar um objeto colaborador com as informações da tela */
                c = GetDTO();

                if (dao.Create(c))
                {
                    MessageBox.Show("O colaborador foi cadastrado.", "Colaborador Cadastrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }                 
                else
                    MessageBox.Show("Erro ao cadastrar.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
        }

        private bool estaPreenchido()
        {
            if(nomeColaborador.Text != "" &&
                cadastroLoginColaborador.Text != "" &&
                cadastroSenhaColaborador.Text != "" &&
                maskedTextBox1.Text != "" &&
                comboBox1.Text != "" &&
                maskedTextBox2.Text != "" &&
                emailColaborador.Text != ""
                )
            {
                return true;
            }
            return false;
        }

        /* Retorna um objeto categoria com as informações recolhidas da tela */
        private Colaborador GetDTO()
        {
            Colaborador c = new Colaborador();

            c.Nome = nomeColaborador.Text;
            c.Login = cadastroLoginColaborador.Text;
            c.Senha = cadastroSenhaColaborador.Text;
            c.Telefone = maskedTextBox1.Text;
            c.Cargo = comboBox1.Text;
            c.NroRh = int.Parse(maskedTextBox2.Text);
            c.Email = emailColaborador.Text;
            return c;
        }
    }
}
