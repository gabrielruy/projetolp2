﻿using System;
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

        private void listarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chama a tela listar cliente
            Tela_listar_cliente listar_Cliente = new Tela_listar_cliente();
            listar_Cliente.ShowDialog();
        }

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

        private void listarProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_listar_projetos listar_Projetos = new Tela_listar_projetos();
            listar_Projetos.ShowDialog();
        }

        private void listarColaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_lista_colaboradores lista_Colaboradores = new  Tela_lista_colaboradores();
            lista_Colaboradores.ShowDialog();

        }

        private void buttonFechaSistem_Click(object sender, EventArgs e)
        {
            //Derruba o sistema para tela de  login novamente
            Tela_de_login login = new Tela_de_login();
            login.ShowDialog();
                
          }
    }
}
