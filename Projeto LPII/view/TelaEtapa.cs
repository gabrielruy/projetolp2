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
            AtualizaDGV(int.Parse(txtCodigo.Text));
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


        private void btnBuscar_Click(object sender, EventArgs e) //Buscar
        {
            dataGridViewEtapas.DataSource = null;
            List<Etapa> etapas = new List<Etapa>();

            if (txtBuscaEtapa.Text.Equals("")) //Se for vazio lista todos
                AtualizaDGV(int.Parse(txtCodigo.Text));
            else //Se tiver alguma entrada...
            {
                etapas = daoEtapa.ListByName(txtBuscaEtapa.Text); //Lê do banco
                dataGridViewEtapas.Rows.Clear(); //Limpa o Data Grid View
                foreach (Etapa etapa in etapas)
                {
                    //Adiciona somente o procurado
                    dataGridViewEtapas.Rows.Add(etapa.Codigo.ToString(), etapa.Nome);
                    dataGridViewEtapas.ClearSelection();
                }
                
            }

            LimpaTxtEtapa();
            LimpaTxtDescricao();

            dataGridViewEtapas.ClearSelection();
        }

        private void btnSalvar_Click(object sender, EventArgs e) //Salvar
        {
            if (MessageBox.Show("Tem certeza que deseja salvar as alterações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(descricaoEtapa.Text.Length < 1020)
                {
                    Etapa etapa;

                    etapa = GetDTO_Etapa();

                    if(etapa != null)
                    {
                        if (daoEtapa.Update(etapa))
                        {
                            MessageBox.Show("A etapa foi atualizada.", "Etapa atualizado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ExibeDescricao();
                        }
                        else
                            MessageBox.Show("Erro ao atualizar.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Escolha uma etapa para atualizar.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Limite máximo de caracteres excedido. As alterações não foram salvas.", "Alterações descartadas",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("As alterações não foram salvas.", "Alterações descartadas",
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

            if(dataGridViewEtapas.CurrentRow != null)
            {
                etapa.Codigo = int.Parse(dataGridViewEtapas.CurrentRow.Cells[0].Value.ToString());
                etapa.Nome = txtAddEtapa.Text;
                etapa.Projeto.Codigo = int.Parse(txtCodigo.Text);
                etapa.Descricao = descricaoEtapa.Text;

                return etapa;
            }

            return null;
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
