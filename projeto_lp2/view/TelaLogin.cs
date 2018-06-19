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
    public partial class Tela_de_login : Form
    {
        public Tela_de_login()
        {
            InitializeComponent();
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelarNovoProjeto_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCadastroNovoColaborador_Click(object sender, EventArgs e)
        {
            Tela_cadastro_de_colaborador cadastro_De_Colaborador = new Tela_cadastro_de_colaborador();
            cadastro_De_Colaborador.Show();
          
        }

        private void buttonConfirmarLogin_Click(object sender, EventArgs e)
        {
            //Tratamentos try-catch 
            try
            {
                
            
            }
            catch(Exception ex)
            {
                MessageBox.Show("Senha ou usuário incorretos!!",  ex.Message);
            }
        }

        private void SenhaColaboradorInicio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
