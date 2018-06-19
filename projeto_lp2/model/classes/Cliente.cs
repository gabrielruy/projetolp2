using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPII
{
    class Cliente
    {
        private int codigo;
        private String nome;
        private String cnpj;
        private String telefone;
        private String email;
        private String responsavel;
        private String rua;
        private int numero;
        private String cep;
        private String cidade;
        private String estado;

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public String Nome { get { return nome; } set { nome = value; } }
        public String Cnpj { get { return cnpj; } set { cnpj = value; } }
        public String Telefone { get { return telefone; } set { telefone = value; } }
        public String Email { get { return email; } set { email = value; } }
        public String Responsavel { get { return responsavel; } set { responsavel = value; } }
        public String Rua { get { return rua; } set { rua = value; } }
        public int Numero { get { return numero; } set { numero = value; } }
        public String Cep { get { return cep; } set { cep = value; } }
        public String Cidade { get { return cidade; } set { cidade = value; } }
        public String Estado { get { return estado; } set { estado = value; } }
    }
}
