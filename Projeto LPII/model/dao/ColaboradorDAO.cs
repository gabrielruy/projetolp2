using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_LPII.model.dao
{
    class ColaboradorDAO
    {
        public bool Create(Colaborador c)
        {
            bool state = false; /* Indica se o comando foi executado com sucesso */

            /* Recebe a conexão utilizada para acessar o Banco de Dados */
            MySqlConnection connection = Database.GetInstance().GetConnection();

            /* String que contém o SQL que será executado */
            string query =
            string.Format("INSERT INTO Colaborador (nome, login, senha, telefone, cargo, nroRh, email) " +
                           "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');",
                           c.Nome, c.Login, c.Senha, c.Telefone, c.Cargo, c.NroRh, c.Email);

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
                    if (exception.Message.ToString().Contains("un_colaborador_nome"))
                        MessageBox.Show("Este nome já está cadastrado.", "Nome já cadastrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    /* UNIQUE(nroRh) */
                    if (exception.Message.ToString().Contains("un_colaborador_nroRh"))
                        MessageBox.Show("Este número de RH já está cadastrado.", "Número de RH já cadastrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    /* UNIQUE(login) */
                    if (exception.Message.ToString().Contains("un_colaborador_login"))
                        MessageBox.Show("Este login já está cadastrado.", "Login já Cadastrado",
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

        public bool Update(Colaborador c)
        {
            bool state = false; /* Indica se o comando foi executado com sucesso */

            /* Recebe a conexão utilizada para acessar o Banco de Dados */
            MySqlConnection connection = Database.GetInstance().GetConnection();

            /* String que contém o SQL que será executado */
            string query =
            string.Format("UPDATE Colaborador SET nome='{0}', login='{1}', senha='{2}," +
            "telefone='{3}', cargo='{4}', nroRh='{5}', email='{6}'" +
            "WHERE codigo={7};", c.Nome, c.Login, c.Senha, c.Telefone, c.Cargo,
            c.NroRh, c.Email, c.Codigo);

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
                    if (exception.Message.ToString().Contains("un_colaborador_nome"))
                        MessageBox.Show("Este nome já está cadastrado.", "Nome já cadastrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    /* UNIQUE(nroRh) */
                    if (exception.Message.ToString().Contains("un_colaborador_nroRh"))
                        MessageBox.Show("Este número de RH já está cadastrado.", "Número de RH já cadastrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    /* UNIQUE(login) */
                    if (exception.Message.ToString().Contains("un_colaborador_login"))
                        MessageBox.Show("Este login já está cadastrado.", "Login já Cadastrado",
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

        public bool Delete(Colaborador c)
        {
            bool state = false; /* Indica se o comando foi executado com sucesso */

            /* Recebe a conexão utilizada para acessar o Banco de Dados */
            MySqlConnection connection = Database.GetInstance().GetConnection();

            /* String que contém o SQL que será executado */
            string query = string.Format("DELETE FROM Colaborador WHERE codigo = {0};", c.Codigo);

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

        public Colaborador Read(int codigo)
        {
            /* Recebe a conexão utilizada para acessar o Banco de Dados */
            MySqlConnection connection = Database.GetInstance().GetConnection();

            /* Objeto de Categoria para receber as informações do Banco de Dados */
            Colaborador colaborador = null;

            /* String que contém o SQL que será executado */
            string query = "SELECT * FROM Colaborador WHERE codigo = " + codigo;

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
                    colaborador = new Colaborador();
                    colaborador.Codigo = dataReader.GetInt32(0);
                    colaborador.Nome = dataReader.GetString(1);
                    colaborador.Login = dataReader.GetString(2);
                    colaborador.Senha = dataReader.GetString(3);
                    colaborador.Telefone = dataReader.GetString(4);
                    colaborador.Cargo = dataReader.GetString(5);
                    colaborador.NroRh = dataReader.GetInt32(6);
                    colaborador.Email = dataReader.GetString(7);
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
            return colaborador;
        }

        public Colaborador Read(String nome)
        {
            /* Recebe a conexão utilizada para acessar o Banco de Dados */
            MySqlConnection connection = Database.GetInstance().GetConnection();

            /* Objeto de Categoria para receber as informações do Banco de Dados */
            Colaborador colaborador = null;

            /* String que contém o SQL que será executado */
            string query = string.Format("SELECT * FROM Colaborador WHERE nome LIKE '%{0}%'", nome);

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
                    colaborador = new Colaborador();
                    colaborador.Codigo = dataReader.GetInt32(0);
                    colaborador.Nome = dataReader.GetString(1);
                    colaborador.Login = dataReader.GetString(2);
                    colaborador.Senha = dataReader.GetString(3);
                    colaborador.Telefone = dataReader.GetString(4);
                    colaborador.Cargo = dataReader.GetString(5);
                    colaborador.NroRh = dataReader.GetInt32(6);
                    colaborador.Email = dataReader.GetString(7);
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
            return colaborador;
        }

        public List<Colaborador> ListAll()
        {
            /* Recebe a conexão utilizada para acessar o Banco de Dados */
            MySqlConnection connection = Database.GetInstance().GetConnection();

            List<Colaborador> lista = new List<Colaborador>();

            /* Preenchido com as informações do Banco de Dados */
            Colaborador colaborador;

            /* String que contém o SQL que será executado */
            string query = "SELECT * FROM Colaborador";

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
                    colaborador = new Colaborador();
                    colaborador.Codigo = dataReader.GetInt32(0);
                    colaborador.Nome = dataReader.GetString(1);
                    colaborador.Login = dataReader.GetString(2);
                    colaborador.Senha = dataReader.GetString(3);
                    colaborador.Telefone = dataReader.GetString(4);
                    colaborador.Cargo = dataReader.GetString(5);
                    colaborador.NroRh = dataReader.GetInt32(6);
                    colaborador.Email = dataReader.GetString(7);

                    lista.Add(colaborador); /* Adiciona na lista */
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

