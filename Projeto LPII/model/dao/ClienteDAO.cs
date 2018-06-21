using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_LPII.model.dao
{
    class ClienteDAO
    {
        public bool Create(Cliente c)
        {
            bool state = false; /* Indica se o comando foi executado com sucesso */

            /* Recebe a conexão utilizada para acessar o Banco de Dados */
            MySqlConnection connection = Database.GetInstance().GetConnection();

            /* String que contém o SQL que será executado */
            string query =
            string.Format("INSERT INTO Cliente (nome, cnpj, telefone, email, responsavel, rua, numero, cep, cidade, estado) " +
                           "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}');",
                           c.Nome, c.Cnpj, c.Telefone, c.Email, c.Responsavel, c.Rua, c.Numero, c.Cep, c.Cidade, c.Estado);

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
                    /* UNIQUE(cnpj) */
                    if (exception.Message.ToString().Contains("un_cliente_cnpj"))
                        MessageBox.Show("Este CNPJ já está cadastrado.", "CNPJ já Cadastrado",
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

        public bool Update(Cliente c)
        {
            bool state = false; /* Indica se o comando foi executado com sucesso */

            /* Recebe a conexão utilizada para acessar o Banco de Dados */
            MySqlConnection connection = Database.GetInstance().GetConnection();

            /* String que contém o SQL que será executado */
            string query =
            string.Format("UPDATE Cliente SET nome='{0}', cnpj='{1}', telefone='{2}," +
            "email='{3}', responsavel='{4}', rua='{5}', numero='{6}', cep='{7}'," +
            "cidade='{8}', estado'{9}'" +
            "WHERE codigo={10};", c.Nome, c.Cnpj, c.Telefone, c.Email, c.Responsavel,
            c.Rua, c.Numero, c.Cep, c.Cidade, c.Estado, c.Codigo);

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
                    /* UNIQUE(cnpj) */
                    if (exception.Message.ToString().Contains("un_cliente_cnpj"))
                        MessageBox.Show("Este CNPJ já está cadastrado.", "CNPJ já Cadastrado",
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

        public bool Delete(Cliente c)
        {
            bool state = false; /* Indica se o comando foi executado com sucesso */

            /* Recebe a conexão utilizada para acessar o Banco de Dados */
            MySqlConnection connection = Database.GetInstance().GetConnection();

            /* String que contém o SQL que será executado */
            string query = string.Format("DELETE FROM Cliente WHERE codigo = {0};", c.Codigo);

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

        public Cliente Read(int codigo)
        {
            /* Recebe a conexão utilizada para acessar o Banco de Dados */
            MySqlConnection connection = Database.GetInstance().GetConnection();

            /* Objeto de Categoria para receber as informações do Banco de Dados */
            Cliente cliente = null;

            /* String que contém o SQL que será executado */
            string query = "SELECT * FROM Cliente WHERE codigo = " + codigo;

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
                    cliente= new Cliente();
                    cliente.Codigo = dataReader.GetInt32(0);
                    cliente.Nome = dataReader.GetString(1);
                    cliente.Cnpj = dataReader.GetString(2);
                    cliente.Telefone = dataReader.GetString(3);
                    cliente.Email = dataReader.GetString(4);
                    cliente.Responsavel = dataReader.GetString(5);
                    cliente.Rua = dataReader.GetString(6);
                    cliente.Numero = dataReader.GetInt32(7);
                    cliente.Cep = dataReader.GetString(8);
                    cliente.Cidade = dataReader.GetString(9);
                    cliente.Estado = dataReader.GetString(10);
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
            return cliente;
        }

        public Cliente Read(String nome)
        {
            /* Recebe a conexão utilizada para acessar o Banco de Dados */
            MySqlConnection connection = Database.GetInstance().GetConnection();

            /* Objeto de Categoria para receber as informações do Banco de Dados */
            Cliente cliente = null;

            /* String que contém o SQL que será executado */
            string query = string.Format("SELECT * FROM Cliente WHERE nome LIKE '%{0}%'", nome);

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
                    cliente = new Cliente();
                    cliente.Codigo = dataReader.GetInt32(0);
                    cliente.Nome = dataReader.GetString(1);
                    cliente.Cnpj = dataReader.GetString(2);
                    cliente.Telefone = dataReader.GetString(3);
                    cliente.Email = dataReader.GetString(4);
                    cliente.Responsavel = dataReader.GetString(5);
                    cliente.Rua = dataReader.GetString(6);
                    cliente.Numero = dataReader.GetInt32(7);
                    cliente.Cep = dataReader.GetString(8);
                    cliente.Cidade = dataReader.GetString(9);
                    cliente.Estado = dataReader.GetString(10);
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
            return cliente;
        }

        public List<Cliente> ListAll()
        {
            /* Recebe a conexão utilizada para acessar o Banco de Dados */
            MySqlConnection connection = Database.GetInstance().GetConnection();

            List<Cliente> lista = new List<Cliente>();

            /* Preenchido com as informações do Banco de Dados */
            Cliente cliente;

            /* String que contém o SQL que será executado */
            string query = "SELECT * FROM Cliente";

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
                    cliente = new Cliente();
                    cliente.Codigo = dataReader.GetInt32(0);
                    cliente.Nome = dataReader.GetString(1);
                    cliente.Cnpj = dataReader.GetString(2);
                    cliente.Telefone = dataReader.GetString(3);
                    cliente.Email = dataReader.GetString(4);
                    cliente.Responsavel = dataReader.GetString(5);
                    cliente.Rua = dataReader.GetString(6);
                    cliente.Numero = dataReader.GetInt32(7);
                    cliente.Cep = dataReader.GetString(8);
                    cliente.Cidade = dataReader.GetString(9);
                    cliente.Estado = dataReader.GetString(10);

                    lista.Add(cliente); /* Adiciona na lista */
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
