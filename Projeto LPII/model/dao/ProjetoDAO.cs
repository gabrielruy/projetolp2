using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_LPII.model.dao
{
    class ProjetoDAO
    {
        public bool Create(Projeto p)
        {
            bool state = false; /* Indica se o comando foi executado com sucesso */

            /* Recebe a conexão utilizada para acessar o Banco de Dados */
            MySqlConnection connection = Database.GetInstance().GetConnection();

            /* String que contém o SQL que será executado */
            string query =
            string.Format("INSERT INTO Projeto (cliente, nome, dataInicio, previsaoTermino) " +
                           "VALUES ('{0}','{1}','{2}','{3}');",
                           p.Cliente, p.Nome, p.DataInicio, p.PrevisaoTermino);

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
                /* Exceção por violar algum UNIQUE */
                if (exception.Number == (int)MySqlErrorCode.DuplicateKeyEntry)
                {
                    // Se o cliente nao existir
                    if (exception.Message.ToString().Contains("fk_projeto_cliente"))
                        MessageBox.Show("O Cliente não existe.", "Cliente inexistente.",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            finally
            {
                /* Fecha a conexão */
                connection.Close();
            }
            return state;
        }

        public bool Update(Projeto p)
        {
            bool state = false; /* Indica se o comando foi executado com sucesso */

            /* Recebe a conexão utilizada para acessar o Banco de Dados */
            MySqlConnection connection = Database.GetInstance().GetConnection();

            /* String que contém o SQL que será executado */
            string query =
            string.Format("UPDATE Projeto SET cliente='{0}', nome='{1}', dataInicio='{2}," +
            "previsaoTermino='{3}'" +
            "WHERE codigo={7};", p.Cliente, p.Nome, p.DataInicio, p.PrevisaoTermino);

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
                /* Exceção por violar algum UNIQUE */
                if (exception.Number == (int)MySqlErrorCode.DuplicateKeyEntry)
                {
                    /* UNIQUE(nome) */
                    if (exception.Message.ToString().Contains("fk_projeto_cliente"))
                        MessageBox.Show("Este cliente é invalido.", "Cliente inválido",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            finally
            {
                /* Fecha a conexão */
                connection.Close();
            }
            return state;
        }

        public bool Delete(Projeto p)
        {
            bool state = false; /* Indica se o comando foi executado com sucesso */

            /* Recebe a conexão utilizada para acessar o Banco de Dados */
            MySqlConnection connection = Database.GetInstance().GetConnection();

            /* String que contém o SQL que será executado */
            string query = string.Format("DELETE FROM Projeto WHERE codigo = {0};", p.Codigo);

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

        public Projeto Read(String nome)
        {
            /* Recebe a conexão utilizada para acessar o Banco de Dados */
            MySqlConnection connection = Database.GetInstance().GetConnection();

            /* Objeto de Categoria para receber as informações do Banco de Dados */
            Projeto projeto = null;

            /* String que contém o SQL que será executado */
            string query = string.Format("SELECT * FROM Projeto WHERE nome LIKE '%{0}%'", nome);

            /* Responsável pelo comando SQL */
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                /* Abre a conexão */
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                /* Responsável pela leitura do Banco de Dados */
                MySqlDataReader dataReader = command.ExecuteReader();

                /* Verifica se troxe informações do banco e coloca no objeto categoria */
                if (dataReader.Read())
                {
                    projeto = new Projeto();
                    projeto.Codigo = dataReader.GetInt32(0);
                    projeto.Cliente = dataReader.GetInt32(1);
                    projeto.Nome = dataReader.GetString(2);
                    projeto.DataInicio = dataReader.GetDateTime(3);
                    projeto.PrevisaoTermino = dataReader.GetDateTime(4);

                }
                /* Fecha o dataReader */
                dataReader.Close();
            }
            catch (Exception exception)
            {
                /* Se ocorrer alguma exceção mostra uma caixa de texto com o erro */
                MessageBox.Show(exception.ToString(), "Erro.", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                /* Fecha a conexão */
                connection.Close();
            }
            return projeto;
        }

        public Projeto Read(int codigo)
        {
            /* Recebe a conexão utilizada para acessar o Banco de Dados */
            MySqlConnection connection = Database.GetInstance().GetConnection();

            /* Objeto de Categoria para receber as informações do Banco de Dados */
            Projeto projeto = null;

            /* String que contém o SQL que será executado */
            string query = "SELECT * FROM Projeto WHERE codigo = " + codigo;

            /* Responsável pelo comando SQL */
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                /* Abre a conexão */
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                /* Responsável pela leitura do Banco de Dados */
                MySqlDataReader dataReader = command.ExecuteReader();

                /* Verifica se troxe informações do banco e coloca no objeto categoria */
                if (dataReader.Read())
                {
                    projeto = new Projeto();
                    projeto.Codigo = dataReader.GetInt32(0);
                    projeto.Cliente = dataReader.GetInt32(1);
                    projeto.Nome = dataReader.GetString(2);
                    projeto.DataInicio = dataReader.GetDateTime(3);
                    projeto.PrevisaoTermino = dataReader.GetDateTime(4);

                }
                /* Fecha o dataReader */
                dataReader.Close();
            }
            catch (Exception exception)
            {
                /* Se ocorrer alguma exceção mostra uma caixa de texto com o erro */
                MessageBox.Show(exception.ToString(), "Erro.", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                /* Fecha a conexão */
                connection.Close();
            }
            return projeto;
        }

        public List<Projeto> ListAll()
        {
            /* Recebe a conexão utilizada para acessar o Banco de Dados */
            MySqlConnection connection = Database.GetInstance().GetConnection();

            List<Projeto> lista = new List<Projeto>();

            /* Preenchido com as informações do Banco de Dados */
            Projeto projeto;

            /* String que contém o SQL que será executado */
            string query = "SELECT * FROM Projeto";

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
                    projeto = new Projeto();
                    projeto.Codigo = dataReader.GetInt32(0);
                    projeto.Cliente = dataReader.GetInt32(1);
                    projeto.Nome = dataReader.GetString(2);
                    projeto.DataInicio = dataReader.GetDateTime(3);
                    projeto.PrevisaoTermino = dataReader.GetDateTime(4);

                    lista.Add(projeto); /* Adiciona na lista */
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
            /* Retorna a lista */
            return lista;
        }
    }
}
