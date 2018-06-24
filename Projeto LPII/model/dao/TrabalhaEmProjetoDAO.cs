using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_LPII.model.dao
{
    class TrabalhaEmProjetoDAO
    {
        /* Salva um Trabalhador no Banco de Dados */
        public void Create(TrabalhaEmProjeto trabalha)
        {
            /* Recebe a conexão utilizada para acessar o Banco de Dados */
            MySqlConnection connection = Database.GetInstance().GetConnection();

            /* String que contém o SQL que será executado */
            string query =
            string.Format("INSERT INTO TrabalhaEmProjeto (codigo_colaborador, codigo_projeto) " +
                          "VALUES ('{0}','{1}');",
                           trabalha.Colaborador, trabalha.Projeto);

            /* Responsável pelo comando SQL */
            MySqlCommand command = new MySqlCommand(query, connection);

            /* Executa o comando SQL */
            command.ExecuteNonQuery();
        }

        // Deleta um trabalhador do banco de dados
        public bool Delete(TrabalhaEmProjeto t)
        {
            bool state = false; /* Indica se o comando foi executado com sucesso */

            /* Recebe a conexão utilizada para acessar o Banco de Dados */
            MySqlConnection connection = Database.GetInstance().GetConnection();

            /* String que contém o SQL que será executado */
            string query = string.Format("DELETE FROM Cliente WHERE codigo = {0};", t.Codigo);

            /* Responsável pelo comando SQL */
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                /* Abre a conexão */
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                /* Executa o comando SQL */
                command.ExecuteNonQuery();

                state = true; /* Comando foi executado */
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


        /* Recupera uma lista contendo todos os trabalhadores em um projeto no Banco de Dados */
        public List<TrabalhaEmProjeto> ListAll(int codProj)
        {
            /* Recebe a conexão utilizada para acessar o Banco de Dados */
            MySqlConnection connection = Database.GetInstance().GetConnection();

            /* Lista de itens */
            List<TrabalhaEmProjeto> lista = new List<TrabalhaEmProjeto>();

            /* Preenchido com as informações do Banco de Dados */
            TrabalhaEmProjeto trabalhador;

            /* String que contém o SQL que será executado */
            string query =
            string.Format("SELECT tp.*, c.*, p.* FROM Projeto p " +
                          "JOIN TrabalhaEmProjeto tp ON p.codigo = tp.codigo_projeto " +
                          "JOIN Colaborador c ON tp.codigo_colaborador = c.codigo " +
                          "WHERE tp.codigo_projeto = " + codProj);


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
                    trabalhador = new TrabalhaEmProjeto();
                    trabalhador.Colaborador = new Colaborador();
                    trabalhador.Projeto = new Projeto();
                    trabalhador.Codigo = dataReader.GetInt32(0);
                    trabalhador.Colaborador.Codigo = dataReader.GetInt32(1);
                    trabalhador.Colaborador.Nome = dataReader.GetString(2);
                    trabalhador.Colaborador.Email = dataReader.GetString(3);
                    trabalhador.Colaborador.Telefone = dataReader.GetString(4);
                    trabalhador.Colaborador.Cargo = dataReader.GetString(6);
                    trabalhador.Colaborador.NroRh = dataReader.GetInt32(7);
                    trabalhador.Colaborador.Login = dataReader.GetString(9);
                    trabalhador.Colaborador.Senha = dataReader.GetString(10);
                    trabalhador.Projeto.Codigo = dataReader.GetInt32(11);
                    trabalhador.Projeto.Nome = dataReader.GetString(12);
                    trabalhador.Projeto.Cliente = dataReader.GetInt32(13);
                    trabalhador.Projeto.DataInicio = dataReader.GetDateTime(14);
                    trabalhador.Projeto.PrevisaoTermino = dataReader.GetDateTime(15);
                    trabalhador.Projeto.Situacao = dataReader.GetString(16);

                    lista.Add(trabalhador); /* Adiciona na lista */
                }
                dataReader.Close();
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
            return lista; /* Retorna a lista */
        }
    }
}
