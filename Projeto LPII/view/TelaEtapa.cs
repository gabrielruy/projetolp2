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
        public TelaEtapa()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bntProximo_Click(object sender, EventArgs e)
        {
            //No fim chama a tela de trabalho em projeto 

            TelaTrabalhoEmProjeto trabalhoEmProjeto = new TelaTrabalhoEmProjeto();
            trabalhoEmProjeto.Show();
        }
    }
}
