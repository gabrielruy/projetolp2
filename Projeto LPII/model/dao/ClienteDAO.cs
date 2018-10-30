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
            bool state = false;

            MySqlConnection connection = Database.GetInstance().GetConnection();

            string query = "INSERT INTO Cliente (nome, cnpj, telefone, email, responsavel, rua, numero, cep, cidade, estado)" +
                           "VALUES (@Nome, @Cnpj, @Telefone, @Email, @Responsavel, @Rua, @Numero, @Cep, @Cidade, @Estado);";

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@Nome", c.Nome);
            command.Parameters.AddWithValue("@Cnpj", c.Cnpj);
            command.Parameters.AddWithValue("@Telefone", c.Telefone);
            command.Parameters.AddWithValue("@Email", c.Email);
            command.Parameters.AddWithValue("@Responsavel", c.Responsavel);
            command.Parameters.AddWithValue("@Rua", c.Rua);
            command.Parameters.AddWithValue("@Numero", c.Numero);
            command.Parameters.AddWithValue("@Cep", c.Cep);
            command.Parameters.AddWithValue("@Cidade", c.Cidade);
            command.Parameters.AddWithValue("@Estado", c.Estado);

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
                    if (exception.Message.ToString().Contains("un_cliente_cnpj"))
                        MessageBox.Show("Este CNPJ já está cadastrado.", "CNPJ já Cadastrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            finally
            {
                connection.Close();
            }
            return state;
        }

        public bool Update(Cliente c)
        {
            bool state = false; 

            MySqlConnection connection = Database.GetInstance().GetConnection();

            string query = "UPDATE Cliente SET nome=@Nome, cnpj=@Cnpj, telefone=@Telefone, email=@Email, responsavel=@Responsavel, rua=@Rua, numero=@Numero, cep=@Cep, cidade=@Cidade, estado=@Estado WHERE codigo=@Codigo";

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@Codigo", c.Codigo);
            command.Parameters.AddWithValue("@Nome", c.Nome);
            command.Parameters.AddWithValue("@Cnpj", c.Cnpj);
            command.Parameters.AddWithValue("@Telefone", c.Telefone);
            command.Parameters.AddWithValue("@Email", c.Email);
            command.Parameters.AddWithValue("@Responsavel", c.Responsavel);
            command.Parameters.AddWithValue("@Rua", c.Rua);
            command.Parameters.AddWithValue("@Numero", c.Numero);
            command.Parameters.AddWithValue("@Cep", c.Cep);
            command.Parameters.AddWithValue("@Cidade", c.Cidade);
            command.Parameters.AddWithValue("@Estado", c.Estado);

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
                    if (exception.Message.ToString().Contains("un_cliente_cnpj"))
                        MessageBox.Show("Este CNPJ já está cadastrado.", "CNPJ já Cadastrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            finally
            {
                connection.Close();
            }
            return state;
        }

        public bool Delete(Cliente c)
        {
            bool state = false; 

            MySqlConnection connection = Database.GetInstance().GetConnection();

            string query = "DELETE FROM Cliente WHERE codigo = @Codigo;";

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@Codigo", c.Codigo);

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                command.ExecuteNonQuery();

                state = true; 
            }
            catch (MySqlException exception)
            {
                MessageBox.Show("O cliente tem projetos vinculados.", "Cliente não pode ser excluído",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connection.Close();
            }
            return state;
        }

        public Cliente Read(int codigo)
        {
            MySqlConnection connection = Database.GetInstance().GetConnection();

            Cliente cliente = null;

            string query = "SELECT * FROM Cliente WHERE codigo = @Codigo;";

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@Codigo", codigo);

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlDataReader dataReader = command.ExecuteReader();

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
            return cliente;
        }

        public List<Cliente> ListByName(String nome)
        {
            MySqlConnection connection = Database.GetInstance().GetConnection();

            Cliente cliente = null;
            List<Cliente> lista = new List<Cliente>();

            string query = string.Format("SELECT * FROM Cliente WHERE nome LIKE '%{0}%'", nome);

            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlDataReader dataReader = command.ExecuteReader();

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

                    lista.Add(cliente);
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

        public List<Cliente> ListAll()
        {
            MySqlConnection connection = Database.GetInstance().GetConnection();

            List<Cliente> lista = new List<Cliente>();

            Cliente cliente;

            string query = "SELECT * FROM Cliente";

            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlDataReader dataReader = command.ExecuteReader();

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

                    lista.Add(cliente);
                }
                dataReader.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return lista;
        }
    }   
}
