using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPII
{
    class TrabalhaEmProjeto
    {
        private int codigo;
        private Colaborador colaborador;
        private Projeto projeto;
      
        public int Codigo { get { return codigo; } set { codigo = value; } }
        public Colaborador Colaborador { get { return colaborador; } set { colaborador = value; } }
        public Projeto Projeto { get { return projeto; } set { projeto = value; } }
    }
}
