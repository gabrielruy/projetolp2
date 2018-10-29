﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPII
{
    class Projeto
    { 
        /*Atribusto da classe*/
        private int codigo;
        private String nome;
        private Cliente cliente;
        private DateTime dataInicio;
        private DateTime previsaoTermino;
        private String situacao;

        /*Get e set dos atributos */
        public int Codigo { get { return codigo; } set { codigo = value; } }
        public String Nome { get { return nome; } set { nome = value; } }
        public String Situacao { get { return situacao; } set { situacao = value; } }
        public Cliente Cliente { get { return cliente; } set { cliente = value; } }
        public DateTime DataInicio { get { return dataInicio; } set { dataInicio = value; } }
        public DateTime PrevisaoTermino { get { return previsaoTermino; } set { previsaoTermino = value; } }
    }
}
