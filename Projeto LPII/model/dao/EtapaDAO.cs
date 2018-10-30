﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_LPII.model.dao
{
    class EtapaDAO
    {

        private ProjetoDAO daoProj = new ProjetoDAO();

        public bool Create(Etapa e)
        {
            bool state = false; 

            MySqlConnection connection = Database.GetInstance().GetConnection();

            string query =
            string.Format("INSERT INTO Etapa (nome, projeto, descricao) " +
                           "VALUES ('{0}','{1}', ' ');",
                           e.Nome, e.Projeto.Codigo);

            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                command.ExecuteNonQuery();

                state = true; 
            }
            catch (MySqlException exception)
            {
                if (exception.Number == (int)MySqlErrorCode.DuplicateKeyEntry)
                {
                    MessageBox.Show("Erro ao cadastrar etapa.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            finally
            {
                connection.Close();
            }
            return state;
        }

        public bool Update(Etapa e)
        {
            bool state = false; 

            MySqlConnection connection = Database.GetInstance().GetConnection();

            string query =
            string.Format("UPDATE Etapa SET descricao='{0}'" +
            "WHERE codigo={1};", e.Descricao, e.Codigo);

            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                command.ExecuteNonQuery();

                state = true; 
            }
            catch (MySqlException exception)
            {
                if (exception.Number == (int)MySqlErrorCode.DuplicateKeyEntry)
                {
                    MessageBox.Show("Erro ao atualizar.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            finally
            {
                connection.Close();
            }
            return state;
        }

        public bool Delete(Etapa e)
        {
            bool state = false; 

            MySqlConnection connection = Database.GetInstance().GetConnection();

            string query = string.Format("DELETE FROM Etapa WHERE codigo = {0};", e.Codigo);

            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                command.ExecuteNonQuery();

                state = true; 
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.Message, "Erro ao excluir",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                connection.Close();
            }
            return state;
        }

        public Etapa Read(int codigo)
        {
            MySqlConnection connection = Database.GetInstance().GetConnection();

            Etapa etapa = null;

            string query = "SELECT * FROM Etapa WHERE codigo = " + codigo;

            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    etapa = new Etapa();
                    etapa.Codigo = dataReader.GetInt32(0);
                    etapa.Nome = dataReader.GetString(1);
                    if(dataReader.GetString(3) != null)
                        etapa.Descricao = dataReader.GetString(3);

                }
                dataReader.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Erro.", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return etapa;
        }

        public List<Etapa> ListByName(String nome)
        {
            MySqlConnection connection = Database.GetInstance().GetConnection();

            List<Etapa> lista = new List<Etapa>();

            Etapa etapa = null;

            string query = "SELECT * FROM Etapa WHERE nome LIKE @Nome;";

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@Nome", nome + "%");

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    etapa = new Etapa();
                    etapa.Codigo = dataReader.GetInt32(0);
                    etapa.Nome = dataReader.GetString(1);
                    etapa.Descricao = dataReader.GetString(3);

                    lista.Add(etapa);
                }
                dataReader.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Erro.", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return lista;
        }

        public List<Etapa> ListInProject(int codProj)
        {
            /* Recebe a conexão utilizada para acessar o Banco de Dados */
            MySqlConnection connection = Database.GetInstance().GetConnection();

            List<Etapa> listaEtapa = new List<Etapa>();
            List<Etapa> lista = new List<Etapa>();

            /* Preenchido com as informações do Banco de Dados */
            Etapa etapa;

            /* String que contém o SQL que será executado */
            string query = "SELECT * FROM Etapa WHERE projeto = " + codProj;

            /* Responsável pelo comando SQL */
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                /* Abre a conexão */
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                /* Responsável pela leitura do Banco de Dados */
                MySqlDataReader dataReader = command.ExecuteReader();

                /* Lê todos os dados na tabela do Banco de Dados */
                while (dataReader.Read())
                {
                    etapa = new Etapa();
                    etapa.Codigo = dataReader.GetInt32(0);
                    etapa.Nome = dataReader.GetString(1);
                    etapa.Projeto = new Projeto();
                    etapa.Projeto.Codigo = dataReader.GetInt32(2);

                    listaEtapa.Add(etapa); /* Adiciona na lista */
                }
                dataReader.Close();

                foreach(Etapa e in listaEtapa)
                {
                    Projeto projeto = daoProj.Read(e.Projeto.Codigo);
                    e.Projeto.Nome = projeto.Nome;
                    e.Projeto.DataInicio = projeto.DataInicio;
                    e.Projeto.PrevisaoTermino = projeto.PrevisaoTermino;
                    e.Projeto.Situacao = projeto.Situacao;

                    e.Projeto.Cliente = projeto.Cliente;

                    lista.Add(e);
                }
            }
            catch (Exception exception)
            {
                /* Se ocorrer alguma exceção mostra uma caixa de texto com o erro */
                MessageBox.Show(exception.ToString(), "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                /* Fecha a conexão */
                connection.Close();
            }
            /* Retorna a lista */
            return lista;
        }
    }
}
