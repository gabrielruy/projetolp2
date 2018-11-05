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
    public partial class TelaGerenciaProjeto : Form
    {
        private ProjetoDAO daoProj = new ProjetoDAO();
        private TrabalhaEmProjetoDAO daoTrab = new TrabalhaEmProjetoDAO();
        private ColaboradorDAO daoColab = new ColaboradorDAO();
        private ClienteDAO daoCliente = new ClienteDAO();
        private EtapaDAO daoEtapa = new EtapaDAO();

        private List<int> codTrabalhadoresProjeto;

        public TelaGerenciaProjeto()
        {
            InitializeComponent();
            AtualizaDGV();
        }

        private void AtualizaDGV()
        {
            List<Projeto> lista = daoProj.ListAll();

            dataGridView1.Rows.Clear();

            foreach (Projeto p in lista)
                dataGridView1.Rows.Add(p.Codigo.ToString(), p.Nome);

            dataGridView1.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e) //Buscar
        {
            dataGridView1.DataSource = null;
            List<Projeto> projeto = new List<Projeto>();

            if (textBox2.Text.Equals("")) //Se for vazio lista todos
                AtualizaDGV();
            else //Se tiver alguma entrada...
            {
                projeto = daoProj.ListByName(textBox2.Text); //Lê do banco
                dataGridView1.Rows.Clear(); //Limpa o Data Grid View
                //Adiciona somente o procurado
                foreach(Projeto proj in projeto)
                {
                    dataGridView1.Rows.Add(proj.Codigo.ToString(), proj.Nome);
                }

                /* Limpa a seleção de linhas no Data Grid View */
                dataGridView1.ClearSelection();
            }

            dataGridView1.ClearSelection();
        }

        private void buttonVoltarListarCliente_Click(object sender, EventArgs e) //Atualizar
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione um projeto para atualizar.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Projeto projeto;

                bool clienteValido = informouClienteValido();

                if (clienteValido)
                {
                    projeto = GetDTO();

                    AtualizaTrabalhadores();

                    if (daoProj.Update(projeto))
                    {
                        MessageBox.Show("O Projeto foi atualizado.", "Projeto atualizado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizaDGV();
                        AtualizaDGV_Colaborador(int.Parse(txtCodigo.Text));
                        ExibeProjeto(int.Parse(txtCodigo.Text));
                    }
                    else
                        MessageBox.Show("Erro ao atualizar.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Informe um número de cliente válido.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }                      
        }

        private void button1_Click(object sender, EventArgs e) //Excluir
        {
            if(txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione um projeto para excluir.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var result = MessageBox.Show(this, "Você tem certeza que deseja excluir este projeto?",
                "Deseja excluir projeto?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    Projeto p = GetDTO();

                    if (ExcluiTrabalhadores() && ExcluiEtapas())
                    {
                        if (daoProj.Delete(p))
                        {
                            MessageBox.Show("Projeto foi excluído.", "Projeto Excluído",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    AtualizaDGV();

                    LimparTextBox();
                }
            }           
        }

        private void buttonConfirmarListagemdeClientes_Click(object sender, EventArgs e) //Cancelar
        {
            LimparTextBox();
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e) //Voltar
        {
            this.Close();
        }

        private void LimparTextBox()
        {
            textBox1.Text = "";
            txtCodigo.Text = "";
            txtSituacao.Text = null;
            dateTimeProjeto.Text = "";
            dateTimePicker1.Text = "";
            comboBox2.Text = "";
            txtNroCliente.Text = "";
            dataGridView2.Rows.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibeProjeto(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
        }

        private bool ExcluiTrabalhadores()
        {
            if (daoTrab.DeleteInProject(int.Parse(txtNroCliente.Text)))
                return true;

            return false;
        }
        
        private bool ExcluiEtapas()
        {
            if (daoEtapa.DeleteInProject(int.Parse(txtNroCliente.Text)))
                return true;

            return false;
        }

        private void AtualizaTrabalhadores()
        {
            List<TrabalhaEmProjeto> listaTrabalhador = daoTrab.ListInProject(int.Parse(txtCodigo.Text));
            List<int> listaCodigo = daoTrab.ListCodeInProject(int.Parse(txtCodigo.Text));

            Projeto proj = daoProj.Read(int.Parse(txtCodigo.Text));
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (bool.Parse(dataGridView2.Rows[i].Cells[2].FormattedValue.ToString()) == true)
                {               
                    TrabalhaEmProjeto trabalhador = new TrabalhaEmProjeto();
                    trabalhador.Projeto = proj;
                    trabalhador.Colaborador = daoColab.Read(dataGridView2.Rows[i].Cells[1].Value.ToString());
                    if(listaTrabalhador.Contains(trabalhador))
                    {
                        continue;
                    }
                    else
                    {
                        daoTrab.Create(trabalhador);
                    }                   
                }
                else
                {
                    if(dataGridView2.Rows[i].Cells[0].Value != null && 
                        listaCodigo.Contains(int.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString())))
                    {
                        bool state  = daoTrab.Delete(int.Parse(txtCodigo.Text.ToString()),
                            int.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString()));
                    }
                }
            }
        }

        private bool informouClienteValido()
        {
            List<Cliente> lista = daoCliente.ListAll();

            foreach (Cliente c in lista)
            {
                if (c.Codigo == int.Parse(txtNroCliente.Text))
                {
                    return true;
                }
            }
            return false;
        }

        private void ExibeProjeto(int codigo)
        {
            Projeto p = daoProj.Read(codigo);
            SetDTO_Projeto(p);
            AtualizaDGV_Colaborador(p.Codigo);
        }

        private void SetDTO_Projeto(Projeto p)
        {
            txtCodigo.Text = p.Codigo.ToString(); //Codigo
            txtNroCliente.Text = p.Cliente.Codigo.ToString(); //Codigo do cliente
            comboBox2.Text = p.Cliente.Nome.ToString(); //Cliente
            textBox1.Text = p.Nome; //Nome
            dateTimeProjeto.Text = p.DataInicio.ToLongDateString(); //Data inicio
            dateTimePicker1.Text = p.PrevisaoTermino.ToLongDateString(); //Previsao Termino
            txtSituacao.Text = p.Situacao; //Situacao
        }

        private Projeto GetDTO()
        {
            Projeto projeto = new Projeto();
            projeto.Cliente = new Cliente();

            projeto.Codigo = int.Parse(txtCodigo.Text);
            projeto.Nome = textBox1.Text;
            projeto.Cliente.Codigo = int.Parse(txtNroCliente.Text);
            projeto.DataInicio = dateTimeProjeto.Value;
            projeto.PrevisaoTermino = dateTimePicker1.Value;
            projeto.Situacao = txtSituacao.Text;
            return projeto;
        }

        private void AtualizaDGV_Colaborador(int codigo)
        {
            List<Colaborador> listaColab = daoColab.ListAll();
            List<int> listaTrabalhador = daoTrab.ListCodeInProject(codigo);
            codTrabalhadoresProjeto = new List<int>();

            if(codTrabalhadoresProjeto != null && codTrabalhadoresProjeto.Count > 0)
                codTrabalhadoresProjeto.Clear();

            dataGridView2.Rows.Clear();

            foreach (Colaborador c in listaColab)
            {
                if(listaTrabalhador.Contains(c.Codigo))
                {
                    dataGridView2.Rows.Add(c.Codigo, c.Nome, true);
                    codTrabalhadoresProjeto.Add(c.Codigo);
                }        
                else
                    dataGridView2.Rows.Add(c.Codigo, c.Nome);
            }
            dataGridView2.ClearSelection();
        }
    }
}
