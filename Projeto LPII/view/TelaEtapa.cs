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
    public partial class TelaEtapa : Form
    {
        private EtapaDAO daoEtapa = new EtapaDAO();
        private ProjetoDAO daoProj = new ProjetoDAO();

        public TelaEtapa(int codigoProjeto)
        {
            InitializeComponent();
            ExibeProjeto(codigoProjeto);
            AtualizaDGV(codigoProjeto);
        }

        private void button4_Click(object sender, EventArgs e) //Voltar
        {
            this.Close();
        }


        private void button3_Click(object sender, EventArgs e) //Cancelar
        {
            LimpaTxtEtapa();
            LimpaTxtDescricao();
            LimpaBusca();
        }

        private void bntAddEtapa_Click(object sender, EventArgs e) //Adicionar Etapa
        {
            if(txtAddEtapa.Text != "")
            {
                Etapa etapa;

                etapa = GetDTO_Etapa();

                if (daoEtapa.Create(etapa))
                {
                    MessageBox.Show("Etapa cadastrada com sucesso.", "Etapa cadastrada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpaTxtEtapa();
                    LimpaTxtDescricao();
                    AtualizaDGV(int.Parse(txtCodigo.Text));
                }
                else
                    MessageBox.Show("Erro ao cadastrar.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Informe o nome da etapa.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewEtapas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibeDescricao();
        }


        private void ExibeProjeto(int codProj)
        {
            Projeto p = daoProj.Read(codProj);
            SetDTO_Projeto(p);
        }

        private void SetDTO_Projeto(Projeto p)
        {
            txtCodigo.Text = p.Codigo.ToString();
            txtNome.Text = p.Nome;
            txtCliente.Text = p.Cliente.Nome.ToString();
            txtSituacao.Text = p.Situacao;
        }

        private Etapa GetDTO_Etapa()
        {
            Etapa etapa = new Etapa();
            etapa.Projeto = new Projeto();

            etapa.Nome = txtAddEtapa.Text;
            etapa.Projeto.Codigo = int.Parse(txtCodigo.Text);

            return etapa;
        }

        private void LimpaTxtEtapa()
        {
            txtAddEtapa.Text = "";
        }

        private void LimpaTxtDescricao()
        {
            descricaoEtapa.Text = "";
        }

        private void LimpaBusca()
        {
            txtBuscaEtapa.Text = "";
        }

        private void AtualizaDGV(int codProj)
        {
            List<Etapa> lista = daoEtapa.ListInProject(codProj);

            dataGridViewEtapas.Rows.Clear();

            foreach (Etapa etapa in lista)
                dataGridViewEtapas.Rows.Add(etapa.Codigo.ToString(), etapa.Nome);

            dataGridViewEtapas.ClearSelection();
        }

        private void ExibeDescricao()
        {
            int codEtapa = int.Parse(dataGridViewEtapas.CurrentRow.Cells[0].Value.ToString());

            Etapa e = daoEtapa.Read(codEtapa);
            if (e.Descricao != null)
                descricaoEtapa.Text = e.Descricao.ToString();
            else
                descricaoEtapa.Text = "";
        }
    }
}
