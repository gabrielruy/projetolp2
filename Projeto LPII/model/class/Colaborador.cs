using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPII
{
    class Colaborador
    {
        /*Atributos da Classe*/
        private int codigo;
        private String nome;
        private String email;
        private String telefone;
        private String cargo;
        private int nroRh;
        private String login;
        private String senha;

        /*Get e set dos atributos da classe */
        public int Codigo { get { return codigo; } set { codigo = value; } }
        public String Nome { get { return nome; } set { nome = value; } }
        public String Email { get { return email; } set { email = value; } }
        public String Telefone { get { return telefone; } set { telefone = value; } }
        public String Cargo { get { return cargo; } set { cargo = value; } }
        public int NroRh { get { return nroRh; } set { nroRh = value; } }
        public String Login { get { return login; } set { login = value; } }
        public String Senha { get { return senha; } set { senha = value; } }
    }
}
