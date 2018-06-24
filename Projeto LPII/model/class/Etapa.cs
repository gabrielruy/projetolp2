using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPII
{
    class Etapa
    {
        private int codigo;
        private String nome;
        private int duracao; //Em dias
        private int projeto;
        private int numero;

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public String Nome { get { return nome; } set { nome = value; } }
        public int Duracao { get { return duracao; } set { duracao = value; } }
        public int Projeto { get { return projeto; } set { projeto = value; } }
        public int Numero { get { return numero; } set { numero = value; } }
    }
}
