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
    public partial class TelaLogin : Form
    {

        ColaboradorDAO daoColab = new ColaboradorDAO();
    
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //Cancelar
        {
            Application.Exit();
        }

        private void bnEntrar_Click(object sender, EventArgs e)
        {
            List<Colaborador> lista = daoColab.ListAll();
            bool state = false;

            if (txtUsuario.Text.ToString() == "admin" && txtSenha.Text.ToString() == "1234")
            {
                IniciaSistema();
                state = true;
            }
            else
            {
                foreach (Colaborador c in lista)
                {
                    if (txtUsuario.Text.ToString() == c.Login && txtSenha.Text.ToString() == c.Senha)
                    {
                        IniciaSistema();
                        state = true;
                    }
                    else
                    {
                        state = false;
                    }
                }
            }

            if(!state)
            {
                MessageBox.Show("Usuário ou/e senha inválidos.", "Erro ao logar",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void IniciaSistema()
        {
            Form1 telaInicial = new Form1();
            this.Hide();
            telaInicial.ShowDialog();          
        }
    }
}
