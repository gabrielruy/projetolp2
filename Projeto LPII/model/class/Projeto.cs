using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPII
{
    class Projeto
    {
        private int codigo;
        private String nome;
        private int cliente;
        private DateTime dataInicio;
        private DateTime previsaoTermino;
        private String situacao;

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public String Nome { get { return nome; } set { nome = value; } }
        public String Situacao { get { return situacao; } set { situacao = value; } }
        public int Cliente { get { return cliente; } set { cliente = value; } }
        public DateTime DataInicio { get { return dataInicio; } set { dataInicio = value; } }
        public DateTime PrevisaoTermino { get { return previsaoTermino; } set { previsaoTermino = value; } }
    }
}
