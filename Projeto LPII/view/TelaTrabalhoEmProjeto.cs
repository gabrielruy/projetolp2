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
    }
}
