using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPII
{
    class Etapa
    {
        /*atributos da classe */
        private int codigo;
        private String nome;
        private Projeto projeto;

        /*Get e set dos atributos da classe */
        public int Codigo { get { return codigo; } set { codigo = value; } }
        public String Nome { get { return nome; } set { nome = value; } }
        public Projeto Projeto { get { return projeto; } set { projeto = value; } }
    }
}
