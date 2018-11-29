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
    public partial class TelaRelatorios : Form
    {
        private Relatorios gerar = new Relatorios();
        private ClienteDAO daoCliente = new ClienteDAO();
        private ColaboradorDAO daoColab = new ColaboradorDAO();
        private ProjetoDAO daoProj = new ProjetoDAO();

        public TelaRelatorios()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e) // Buscar
        {
            if (radioCliente.Checked)
            {
                if (isFilled())
                {
                    int codigo = int.Parse(txtBusca.Text);
                    Cliente c = daoCliente.Read(codigo);

                    if (c != null)
                    {
                        if (gerar.Cliente(c))
                        {
                            MessageBox.Show("Relatório de cliente gerado com sucesso.", "Relatório gerado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }                           
                    else
                        MessageBox.Show("O código de cliente informado não é válido.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Informe o código do cliente.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else if (radioColaborador.Checked)
            {
                if (isFilled())
                {
                    int codigo = int.Parse(txtBusca.Text);
                    Colaborador c = daoColab.Read(codigo);

                    if (c != null)
                    {
                        if (gerar.Colaborador(c))
                        {
                            MessageBox.Show("Relatório de colaborador gerado com sucesso.", "Relatório gerado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }                       
                    else
                        MessageBox.Show("O código de colaborador informado não é válido.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Informe o código do colaborador.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else if (radioProjeto.Checked)
            {
                if (isFilled())
                {
                    int codigo = int.Parse(txtBusca.Text);
                    Projeto p = daoProj.Read(codigo);

                    if (p.Cliente != null)
                    {
                        if (gerar.Projeto(p))
                        {
                            MessageBox.Show("Relatório de projeto gerado com sucesso.", "Relatório gerado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }                     
                    else
                        MessageBox.Show("O código de projeto informado não é válido.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Informe o código do projeto.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else
            {
                MessageBox.Show("Selecione um relatório para gerar.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool isFilled()
        {
            if (txtBusca.Text == "")
                return false;
            return true;
        }

        private void btnVoltar_Click(object sender, EventArgs e) // Voltar
        {
            this.Close(); 
        }
    }
}
