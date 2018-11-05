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
    public partial class TelaGerenciaColaboradores : Form
    {
        private ColaboradorDAO dao = new ColaboradorDAO();

        public TelaGerenciaColaboradores()
        {
            InitializeComponent();
            AtualizaDGV();
        }

        private void AtualizaDGV()
        {
            List<Colaborador> lista = dao.ListAll();

            dataGridView1.Rows.Clear();

            foreach (Colaborador c in lista)
                dataGridView1.Rows.Add(c.Codigo.ToString(), c.Nome);

            dataGridView1.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e) //Buscar
        {
            dataGridView1.DataSource = null;
            List<Colaborador> c = new List<Colaborador>();

            if (textBox2.Text.Equals("")) //Se for vazio lista todos
                AtualizaDGV();
            else //Se tiver alguma entrada...
            {
                c = dao.ListByName(textBox2.Text); //Lê do banco
                dataGridView1.Rows.Clear(); //Limpa o Data Grid View
                //Adiciona somente o procurado
                foreach(Colaborador colab in c)
                {
                    dataGridView1.Rows.Add(colab.Codigo.ToString(), colab.Nome);
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
                MessageBox.Show("Selecione um colaborador para atualizar.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Colaborador c;

                c = GetDTO();

                if (dao.Update(c))
                {
                    MessageBox.Show("O colaborador foi atualizado.", "Colaborador atualizado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizaDGV();
                }

                else
                    MessageBox.Show("Erro ao atualizar.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }               
        }

        private void button1_Click(object sender, EventArgs e) //Excluir
        {
            if(txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione um colaborador para excluir.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var result = MessageBox.Show(this, "Você tem certeza que deseja excluir este colaborador?",
                "Deseja excluir o colaborador?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    Colaborador c = GetDTO();

                    if (dao.Delete(c))
                    {
                        MessageBox.Show("Colaborador foi excluído.", "Colaborador Excluído",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    AtualizaDGV();

                    LimparTextBox();
                }
            }            
        }

        private void buttonConfirmarListagemdeClientes_Click(object sender, EventArgs e) //Cancelar
        {
            LimparTextBox();
            AtualizaDGV();
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e) //Voltar
        {
            this.Close();
        }

        private void LimparTextBox()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtFuncao.Text = "";
            txtRegistroRh.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibeColaborador();
        }

        private void ExibeColaborador()
        {
            int codigo = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            Colaborador c = dao.Read(codigo);
            SetDTO(c);
        }

        private void SetDTO(Colaborador c)
        {
            txtCodigo.Text = c.Codigo.ToString(); //Codigo
            txtNome.Text = c.Nome; //Nome
            txtTelefone.Text = c.Telefone; // Telefone
            txtFuncao.Text = c.Cargo; //Cargo
            txtRegistroRh.Text = c.NroRh.ToString(); //NroRh
            txtEmail.Text = c.Email; //Email           
        }

        private Colaborador GetDTO()
        {
            Colaborador c = new Colaborador();

            c.Codigo = int.Parse(txtCodigo.Text);
            c.Nome = txtNome.Text;
            c.Telefone = txtTelefone.Text;
            c.Cargo = txtFuncao.Text;
            c.NroRh = int.Parse(txtRegistroRh.Text);
            c.Email = txtEmail.Text;
            return c;
        }
    }
}
