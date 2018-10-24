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
    public partial class TelaTrabalhoEmProjeto : Form
    {

        private ProjetoDAO dao = new ProjetoDAO();

        public TelaTrabalhoEmProjeto()
        {
            InitializeComponent();
            radioTodos.Checked = true;
            AtualizaDGV();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtualizaDGV()
        {
            List<Projeto> lista = dao.ListAll();

            dataGridView1.Rows.Clear();

            foreach (Projeto projeto in lista)
                dataGridView1.Rows.Add(projeto.Codigo.ToString(), projeto.Cliente.ToString(), projeto.Nome, projeto.DataInicio.ToString(), projeto.PrevisaoTermino.ToString(), projeto.Situacao);

            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Tela_cadastro_de_cliente cadastro_De_Cliente = new Tela_cadastro_de_cliente();
            cadastro_De_Cliente.ShowDialog();
        }

        private void radioPausado_CheckedChanged(object sender, EventArgs e)
        {
            filtraDGV();
        }

        private void radioEmAndamento_CheckedChanged(object sender, EventArgs e)
        {
            filtraDGV();
        }

        private void radioPendente_CheckedChanged(object sender, EventArgs e)
        {
            filtraDGV();
        }

        private void radioTodos_CheckedChanged(object sender, EventArgs e)
        {
            filtraDGV();
        }

        private void filtraDGV()
        {
            if (radioTodos.Checked)
            {
                AtualizaDGV();
            }
            else
            {
                string situacao;
                if(radioPendente.Checked)
                {
                    situacao = "'Pendente'";
                }
                else if (radioPausado.Checked)
                {
                    situacao = "'Pausado'";
                }
                else
                {
                    situacao = "'Em Andamento'";
                }
                List<Projeto> lista = dao.ListBySituation(situacao);

                dataGridView1.Rows.Clear();

                foreach (Projeto projeto in lista)
                    dataGridView1.Rows.Add(projeto.Codigo.ToString(), projeto.Cliente.ToString(), projeto.Nome, projeto.DataInicio.ToString(), projeto.PrevisaoTermino.ToString(), projeto.Situacao);

                dataGridView1.ClearSelection();
            }          
        }
    }
}
