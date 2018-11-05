﻿using System;
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
        private static MySqlConnection connection; 
        private static Database instance; 
        private string connectionString = 
            "Server=localhost; database=projeto; Uid=root; Pwd=mysql";

        private Database()
        {
            try
            {
                connection = new MySqlConnection(connectionString); 
                connection.Open(); 
            }
            catch (Exception exception)
            {
                if (exception.Message.ToString().Contains("Unknown database 'projeto'"))
                {
                    CreateDB(); 
                }
                else
                {
                    MessageBox.Show(exception.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                connection.Close();
            }
        }

        public static Database GetInstance()
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public bool ExecuteSQL(MySqlCommand command)
        {
            bool state = false;
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                command.Connection = connection;
                command.ExecuteNonQuery();

                state = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return state;
        }

        private void CreateDB()
        {
            try
            {
                connection.ConnectionString = "Server=localhost; Uid=root; Pwd=mysql";

                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlCommand command;

                string query;

                query = "CREATE DATABASE IF NOT EXISTS projeto";

                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                connection.ChangeDatabase("projeto");

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

                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

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

                command = new MySqlCommand(query, connection);  
                command.ExecuteNonQuery();

                query = "CREATE TABLE IF NOT EXISTS Projeto (" +
                    "codigo INTEGER AUTO_INCREMENT," +
                    "cliente INTEGER NOT NULL," +
                    "nome VARCHAR(64) NOT NULL," +
                    "dataInicio DATETIME NOT NULL, " +
                    "previsaoTermino DATETIME NOT NULL, " +
                    "situacao VARCHAR(64)," +
                    "CONSTRAINT pk_projeto PRIMARY KEY(codigo)," +
                    "CONSTRAINT fk_projeto_cliente FOREIGN KEY(cliente) " +
                    "REFERENCES Cliente(codigo));";

                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                query = "CREATE TABLE IF NOT EXISTS Etapa (" +
                    "codigo INTEGER AUTO_INCREMENT," +
                    "nome VARCHAR(64) NOT NULL," +
                    "projeto INTEGER NOT NULL," +
                    "descricao VARCHAR(1024)," +
                    "CONSTRAINT pk_etapa PRIMARY KEY(codigo)," +
                    "CONSTRAINT fk_etapa_projeto FOREIGN KEY(projeto) " +
                    "REFERENCES Projeto(codigo));";

                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                query = "CREATE TABLE IF NOT EXISTS TrabalhaEmProjeto (" +
                    "codigo INTEGER AUTO_INCREMENT," +
                    "codigo_colaborador INTEGER," +
                    "codigo_projeto INTEGER," +
                    "CONSTRAINT pk_trabalha_em_projeto PRIMARY KEY(codigo)," +
                    "CONSTRAINT fk_trabalha_colaborador FOREIGN KEY(codigo_colaborador) " +
                    "REFERENCES Colaborador(codigo)," +
                    "CONSTRAINT fk_trabalha_projeto FOREIGN KEY(codigo_projeto) " +
                    "REFERENCES Projeto(codigo));";

                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
