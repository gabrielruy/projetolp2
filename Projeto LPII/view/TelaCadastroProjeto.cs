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

        /* Atributos responsáveis pelo CRUD */
        private ProjetoDAO daoProj = new ProjetoDAO();
        private TrabalhaEmProjetoDAO daoTrab = new TrabalhaEmProjetoDAO();
        private ColaboradorDAO daoColab = new ColaboradorDAO();

        public Tela_cadastro_projeto()
        {
            InitializeComponent();
        }

        private void Tela_cadastro_projeto_Load(object sender, EventArgs e)
        {
            AtualizaDGV(); /* Atualiza o Data Grid View */
        }

        /* Atualiza as informações do dataGridView */
        private void AtualizaDGV()
        {
            /* Recebe todos os colaboradores do Bando de Dados */
            List<Colaborador> lista = daoColab.ListAll();

            /* Limpa o Data Grid View */
            dataGridView1.Rows.Clear();

            /* Percorre a lista adicionando os fornecedores no Data Grid View */
            foreach (Colaborador c in lista)
                dataGridView1.Rows.Add(c.Nome);

            /* Limpa a seleção de linhas no Data Grid View */
            dataGridView1.ClearSelection();
        }

        /* Retorna um objeto categoria com as informações recolhidas da tela */
        private Projeto GetDTO()
        {
            Projeto projeto = new Projeto();

            projeto.Cliente = int.Parse(textBox1.Text);
            projeto.Nome = nomeProjeto.Text;
            projeto.DataInicio = DateTime.Parse(dateTimeProjeto.Text);
            projeto.PrevisaoTermino = DateTime.Parse(dateTimePicker1.Text);
            projeto.Situacao = "Pendente";
            return projeto;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Salvar
        {
            Projeto projeto;

            /* Chama o método para retornar um objeto Projeto com as informações da tela */
            projeto = GetDTO();

            daoProj.Create(projeto);

            //Percorre  todos os colaboradores que estão no DGV
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells[1];
                if (chk.Selected == true)
                {
                    TrabalhaEmProjeto trabalhador = new TrabalhaEmProjeto();
                    trabalhador.Projeto = projeto;
                    trabalhador.Colaborador = daoColab.Read(int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()));
                    daoTrab.Create(trabalhador);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //Cancelar
        {
            this.Close();
        }
    }
}
