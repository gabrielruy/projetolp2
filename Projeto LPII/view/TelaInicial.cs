using Projeto_LPII.view;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void incluirNovoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chama tela de cliente 
            Tela_cadastro_de_cliente cadastro_De_Cliente = new Tela_cadastro_de_cliente();
            cadastro_De_Cliente.ShowDialog();

        }
        /*
        private void listarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chama a tela listar cliente
            Tela_listar_cliente listar_Cliente = new Tela_listar_cliente();
            listar_Cliente.ShowDialog();
        }*/

        private void cadastrarNoColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chama a tela de cadastro de colaborador 
            Tela_cadastro_de_colaborador cadastro_De_Colaborador = new Tela_cadastro_de_colaborador();
            cadastro_De_Colaborador.ShowDialog();
        }

        private void cadastrarNovoProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_cadastro_projeto cadastro_Projeto = new Tela_cadastro_projeto();
            cadastro_Projeto.ShowDialog();

        }
        /*
        private void listarProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_listar_projetos listar_Projetos = new Tela_listar_projetos();
            listar_Projetos.ShowDialog();
        }

        private void listarColaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_lista_colaboradores lista_Colaboradores = new  Tela_lista_colaboradores();
            lista_Colaboradores.ShowDialog();

        }*/

        private void buttonFechaSistem_Click(object sender, EventArgs e)
        {
            //Derruba o sistema para tela de  login novamente
            Application.Exit();

        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_cadastro_de_cliente cadastro_De_Cliente = new Tela_cadastro_de_cliente();
            cadastro_De_Cliente.ShowDialog();
        }

        private void cOLABORADORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_cadastro_de_colaborador cadastro_De_Colaborador = new Tela_cadastro_de_colaborador();
            cadastro_De_Colaborador.ShowDialog();
        }

        private void pROJETOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_cadastro_projeto cadastro_Projeto = new Tela_cadastro_projeto();
            cadastro_Projeto.ShowDialog();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void cLEINTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_cadastro_de_cliente cadastro_De_Cliente = new Tela_cadastro_de_cliente();
            cadastro_De_Cliente.ShowDialog();
        }

        private void rELATÓRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaRelatorios relatorios = new TelaRelatorios();
            relatorios.ShowDialog();


        }

        private void cLIENTEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TelaGerenciaCliente gerenciaCliente = new TelaGerenciaCliente();
            gerenciaCliente.ShowDialog();
        }

        private void cOLABORADORToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TelaGerenciaColaboradores gerenciaColaboradores = new TelaGerenciaColaboradores();
            gerenciaColaboradores.ShowDialog();
        }

        private void pROJETOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaGerenciaProjeto gerenciaProjeto = new TelaGerenciaProjeto();
            gerenciaProjeto.ShowDialog();
        }

        private void eMANDAMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaTrabalhoEmProjeto trabalhoEmProjeto = new TelaTrabalhoEmProjeto();
            trabalhoEmProjeto.Show();
        }

        private void cOLABORADORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_cadastro_de_colaborador cadastro_De_Colaborador = new Tela_cadastro_de_colaborador();
            cadastro_De_Colaborador.ShowDialog();
        }

        private void pROJETOToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Tela_cadastro_projeto cadastro_Projeto = new Tela_cadastro_projeto();
            cadastro_Projeto.ShowDialog();
        }
    }



    namespace Projeto_LPII.view
    {
        //Verificar o aconteceu aqui, criou  a classe sozinho para chamar a tela 
        class TelaGerenciarColaboradores
        {
            internal void Show()
            {
                throw new NotImplementedException();
            }
        }
    }
}