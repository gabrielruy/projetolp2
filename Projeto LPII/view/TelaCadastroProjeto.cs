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
    public partial class Tela_cadastro_projeto : Form
    {

        private ProjetoDAO daoProj = new ProjetoDAO();
        private TrabalhaEmProjetoDAO daoTrab = new TrabalhaEmProjetoDAO();
        private ColaboradorDAO daoColab = new ColaboradorDAO();
        private ClienteDAO daoCliente = new ClienteDAO();

        public Tela_cadastro_projeto()
        {
            InitializeComponent();
            AtualizaDGV();
        }

        private void AtualizaDGV()
        {
            List<Colaborador> lista = daoColab.ListAll();

            dataGridView1.Rows.Clear();

            foreach (Colaborador c in lista)
                dataGridView1.Rows.Add(c.Codigo, c.Nome);

            dataGridView1.ClearSelection();
        }

        private bool estaPreenchido()
        {
            if(txtCliente.Text != "" && txtNome.Text != "")
            {
                return true;
            }
            return false;
        }

        private Projeto GetDTO()
        {
            Projeto projeto = new Projeto();

            projeto.Cliente = int.Parse(txtCliente.Text);
            projeto.Nome = txtNome.Text;
            projeto.DataInicio = dateTimeProjeto.Value;
            projeto.PrevisaoTermino = dateTimePicker1.Value;
            projeto.Situacao = "Pendente";
            return projeto;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private bool vinculouTrabalhadores()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (bool.Parse(dataGridView1.Rows[i].Cells[2].FormattedValue.ToString()) == true)
                {
                    return true;
                }
            }
            return false;
        }

        private bool informouClienteValido()
        {
            List<Cliente> lista = daoCliente.ListAll();

            foreach (Cliente c in lista)
            {
                if(c.Codigo == int.Parse(txtCliente.Text))
                {
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e) //Salvar
        {
            bool isFilled = new bool();
            bool trabalhadorVinculado = new bool();
            bool clienteValido = new bool();
            isFilled = estaPreenchido();
            trabalhadorVinculado = vinculouTrabalhadores();
            
            if (isFilled)
            {
                if (trabalhadorVinculado)
                {
                    clienteValido = informouClienteValido();
                    if (clienteValido)
                    {
                        Projeto projeto;
                        Projeto proj;

                        projeto = GetDTO();

                        if (daoProj.Create(projeto))
                        {
                            proj = daoProj.Read(projeto.Nome);
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                if (bool.Parse(dataGridView1.Rows[i].Cells[2].FormattedValue.ToString()) == true)
                                {
                                    TrabalhaEmProjeto trabalhador = new TrabalhaEmProjeto();
                                    trabalhador.Projeto = proj;
                                    trabalhador.Colaborador = daoColab.Read(int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()));
                                    daoTrab.Create(trabalhador);
                                }
                            }
                            MessageBox.Show("Projeto criado com sucesso.", "Projeto criado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Erro ao cadastrar.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Informe um número de cliente válido.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                    
                }
                else
                {
                    MessageBox.Show("É necessário vincular ao menos um trabalhador.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e) //Cancelar
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
