using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPII
{
    class Login
    {
        /*atributos da classe */
        private int codigo;
        private string usuario;
        private string senha;

        /*Get e set dos atributos da classe */
        public int Codigo { get { return codigo; } set { codigo = value; } }
        public String Usuario { get { return usuario; } set { usuario = value; } }
        public String Senha{ get { return senha; } set { senha = value; } }
    }
}
