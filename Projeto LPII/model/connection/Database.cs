using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_LPII
{
    class Database
    {
        /* Atributos */
        private static MySqlConnection connection; /* Conexão com o Banco de Dados */
        private static Database instance; /* Instância do objeto Database */
        private string connectionString = /* String de configuração da Conexão */
            "Server=localhost; database=projeto; Uid=Gabriel; Pwd=";

        /* Construtor privado */
        private Database()
        {
            try
            {
                connection = new MySqlConnection(connectionString); /* Configura a conexão */
                connection.Open(); /* Abre a conexão para teste */
            }
            catch (Exception exception)
            {
                if (exception.Message.ToString().Contains("Unknown database 'projeto'"))
                {
                    CreateDB(); /* Chama o método para criar o Bando de Dados */
                }
                else
                {
                    /* Se ocorrer algum erro mostra uma caixa de texto com o erro */
                    MessageBox.Show(exception.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                connection.Close(); /* Fecha a conexão */
            }
        }

        /* Retorna a Instância */
        public static Database GetInstance()
        {
            /* Se não possui instância, chama o construtor. Por fim, retorna a instância */
            if (instance == null)
                instance = new Database();
            return instance;
        }

        /* Retorna a conexão com o Banco de Dados */
        public MySqlConnection GetConnection()
        {
            return connection;
        }

        /* Executa um comando SQL que não retorna dados, e indica se foi possível executar */
        public bool ExecuteSQL(MySqlCommand command)
        {
            bool state = false;
            try
            {
                /* Abre a conexão */
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                /* Informa a conexão para o comando */
                command.Connection = connection;
                command.ExecuteNonQuery();

                /* Indica que executou */
                state = true;
            }
            catch (Exception exception)
            {
                /* Se ocorrer algum erro mostra uma caixa de texto com o erro */
                MessageBox.Show(exception.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                /* Fecha a conexão */
                connection.Close();
            }
            return state;
        }

        /* Cria o Banco de Dados */
        private void CreateDB()
        {
            try
            {
                /* Troca a string de conexão */
                connection.ConnectionString = "Server=localhost; Uid=root; Pwd=";

                /* Abre a conexão */
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                /* Responsável pelos comandos MySql */
                MySqlCommand command;

                /* String que contém o comando SQL que será executado */
                string query;

                /* SQL para criar o Banco de Dados mercado */
                query = "CREATE DATABASE IF NOT EXISTS projeto";

                /* Executa o comando MySql */
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                /* Muda o banco de dados em uso */
                connection.ChangeDatabase("projeto");

                /* SQL para criar a tabela Colaborador */
                query = "CREATE TABLE IF NOT EXISTS Colaborador (" +
                    "codigo INTEGER AUTO_INCREMENT," +
                    "nome VARCHAR(64) NOT NULL," +
                    "login VARCHAR(64) NOT NULL," +
                    "senha VARCHAR(64) NOT NULL," +
                    "telefone VARCHAR(64) NOT NULL," +
                    "cargo VARCHAR(64) NOT NULL," +
                    "nroRh INTEGER NOT NULL," +
                    "email VARCHAR(64) NOT NULL," +
                    "CONSTRAINT pk_colaborador PRIMARY KEY(codigo)," +
                    "CONSTRAINT un_colaborador_nome UNIQUE(nome)," +
                    "CONSTRAINT un_colaborador_nroRh UNIQUE(nroRh)," +
                    "CONSTRAINT un_colaborador_login UNIQUE(login));";

                /* Executa o comando MySql */
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                /* SQL para criar a tabela Cliente */
                query = "CREATE TABLE IF NOT EXISTS Cliente (" +
                    "codigo INTEGER AUTO_INCREMENT," +
                    "nome VARCHAR(64) NOT NULL," +
                    "cnpj VARCHAR(64) NOT NULL," +
                    "telefone VARCHAR(64) NOT NULL," +
                    "email VARCHAR(64) NOT NULL," +
                    "responsavel VARCHAR(64) NOT NULL," +
                    "rua VARCHAR(64) NOT NULL," +
                    "numero INTEGER NOT NULL," +
                    "cep VARCHAR(64) NOT NULL," +
                    "cidade VARCHAR(64) NOT NULL," +
                    "estado VARCHAR(64) NOT NULL," +
                    "CONSTRAINT pk_cliente PRIMARY KEY(codigo), " +
                    "CONSTRAINT un_cliente_cnpj UNIQUE(cnpj));";

                /* Executa o comando MySql */
                command = new MySqlCommand(query, connection);  
                command.ExecuteNonQuery();

                /* SQL para criar a tabela Projeto */
                query = "CREATE TABLE IF NOT EXISTS Projeto (" +
                    "codigo INTEGER AUTO_INCREMENT," +
                    "cliente INTEGER NOT NULL," +
                    "nome VARCHAR(64) NOT NULL," +
                    "dataInicio DATETIME NOT NULL, " +
                    "previsaoTermino DATETIME NOT NULL, " +
                    "situacao VARCHAR(64) NOT NULL," +
                    "CONSTRAINT pk_projeto PRIMARY KEY(codigo)" +
                    "CONSTRAINT fk_projeto_cliente FOREIGN KEY(cliente) " +
                    "REFERENCES Cliente(codigo));";

                /* Executa o comando MySql */
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                /* SQL para criar a tabela Etapa */
                query = "CREATE TABLE IF NOT EXISTS Etapa (" +
                    "codigo INTEGER AUTO_INCREMENT," +
                    "nome VARCHAR(64) NOT NULL," +
                    "duracao INTEGER, " +
                    "projeto INTEGER NOT NULL," +
                    "numero INTEGER AUTO_INCREMENT," +
                    "CONSTRAINT pk_etapa PRIMARY KEY(codigo)" +
                    "CONSTRAINT fk_etapa_projeto FOREIGN KEY(projeto) " +
                    "REFERENCES Projeto(codigo));";

                /* Executa o comando MySql */
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                /* SQL para criar a tabela de relação entre colaborador e projeto */
                query = "CREATE TABLE IF NOT EXISTS TrabalhaEmProjeto (" +
                    "codigo INTEGER AUTO_INCREMENT," +
                    "codigo_colaborador INTEGER," +
                    "codigo_projeto INTEGER," +
                    "CONSTRAINT pk_trabalha_em_projeto PRIMARY KEY(codigo)" +
                    "CONSTRAINT fk_trabalha_colaborador FOREIGN KEY(codigo_colaborador) " +
                    "REFERENCES Colaborador(codigo)" +
                    "CONSTRAINT fk_trabalha_projeto FOREIGN KEY(codigo_projeto) " +
                    "REFERENCES Projeto(codigo));";

                /* Executa o comando MySql */
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                /* Se ocorrer alguma exceção mostra uma caixa de texto com o erro */
                MessageBox.Show(exception.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                /* Fecha a conexão */
                connection.Close();
            }
        }
    }
}
