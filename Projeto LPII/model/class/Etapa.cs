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
        private string descricao;
        private DateTime dataInicio;
        private DateTime previsaoTermino;
        private String situacao;

        /*Get e set dos atributos da classe */
        public int Codigo { get { return codigo; } set { codigo = value; } }
        public String Nome { get { return nome; } set { nome = value; } }
        public Projeto Projeto { get { return projeto; } set { projeto = value; } }
        public string Descricao { get { return descricao; } set { descricao = value; } }
        public DateTime DataInicio { get { return dataInicio; } set { dataInicio = value; } }
        public DateTime PrevisaoTermino { get { return previsaoTermino; } set { previsaoTermino = value; } }
        public String Situacao { get { return situacao; } set { situacao = value; } }
    }
}
