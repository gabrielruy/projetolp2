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
    public partial class Tela_lista_colaboradores : Form
    {
        public Tela_lista_colaboradores()
        {
            InitializeComponent();
        }

        private void buttonVoltaListaColaboradores_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
