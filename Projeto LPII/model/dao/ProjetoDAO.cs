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

        private ClienteDAO daoCliente = new ClienteDAO();

        public bool Create(Projeto p)
        {
            bool state = false; 

            MySqlConnection connection = Database.GetInstance().GetConnection();

            string query ="INSERT INTO Projeto (cliente, nome, dataInicio, previsaoTermino, situacao) " +
                           "VALUES (@Cliente, @Nome, @DataInicio, @PrevisaoTermino, @Situacao);";

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@Cliente", p.Cliente.Codigo);
            command.Parameters.AddWithValue("@Nome", p.Nome);
            command.Parameters.AddWithValue("@DataInicio", p.DataInicio);
            command.Parameters.AddWithValue("@PrevisaoTermino", p.PrevisaoTermino);
            command.Parameters.AddWithValue("@Situacao", p.Situacao);

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
                    if (exception.Message.ToString().Contains("fk_projeto_cliente"))
                        MessageBox.Show("O Cliente não existe.", "Cliente inexistente.",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            finally
            {
                connection.Close();
            }
            return state;
        }

        public bool Update(Projeto p)
        {
            bool state = false; 

            MySqlConnection connection = Database.GetInstance().GetConnection();

            string query = "UPDATE Projeto SET cliente=@Cliente, nome=@Nome, dataInicio=@DataInicio, previsaoTermino=@PrevisaoTermino WHERE codigo = @Codigo;";

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@Nome", p.Nome);
            command.Parameters.AddWithValue("@Cliente", p.Cliente);
            command.Parameters.AddWithValue("@Datainicio", p.DataInicio);
            command.Parameters.AddWithValue("@Codigo", p.Codigo);
            command.Parameters.AddWithValue("@PrevisaoTermino", p.PrevisaoTermino);

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
                    if (exception.Message.ToString().Contains("fk_projeto_cliente"))
                        MessageBox.Show("Este cliente é invalido.", "Cliente inválido",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            finally
            {
                connection.Close();
            }
            return state;
        }

        public bool Delete(Projeto p)
        {
            bool state = false;

            MySqlConnection connection = Database.GetInstance().GetConnection();

            string query = string.Format("DELETE FROM Projeto WHERE codigo = {0};", p.Codigo);

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

        public Projeto Read(String nome)
        {
            MySqlConnection connection = Database.GetInstance().GetConnection();

            Projeto projeto = null;

            string query = string.Format("SELECT * FROM Projeto WHERE nome LIKE '%{0}%'", nome);

            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlDataReader dataReader = command.ExecuteReader();

                projeto = new Projeto();

                if (dataReader.Read())
                {
                    projeto.Codigo = dataReader.GetInt32(0);
                    projeto.Cliente = new Cliente();
                    projeto.Cliente.Codigo = dataReader.GetInt32(1);
                    projeto.Nome = dataReader.GetString(2);
                    projeto.DataInicio = dataReader.GetDateTime(3);
                    projeto.PrevisaoTermino = dataReader.GetDateTime(4);
                    projeto.Situacao = dataReader.GetString(5);
                }
                dataReader.Close();

                Cliente cliente = daoCliente.Read(projeto.Cliente.Codigo);
                projeto.Cliente.Nome = cliente.Nome;
                projeto.Cliente.Cnpj = cliente.Cnpj;
                projeto.Cliente.Telefone = cliente.Telefone;
                projeto.Cliente.Email = cliente.Email;
                projeto.Cliente.Responsavel = cliente.Responsavel;
                projeto.Cliente.Rua = cliente.Rua;
                projeto.Cliente.Numero = cliente.Numero;
                projeto.Cliente.Cep = cliente.Cep;
                projeto.Cliente.Cidade = cliente.Cidade;
                projeto.Cliente.Estado = cliente.Estado;
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
            return projeto;
        }

        public Projeto Read(int codigo)
        {
            MySqlConnection connection = Database.GetInstance().GetConnection();

            Projeto projeto = null;

            string query = "SELECT * FROM Projeto WHERE codigo = " + codigo;

            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlDataReader dataReader = command.ExecuteReader();

                projeto = new Projeto();

                if (dataReader.Read())
                {
                    projeto.Codigo = dataReader.GetInt32(0);
                    projeto.Cliente = new Cliente();
                    projeto.Cliente.Codigo = dataReader.GetInt32(1);
                    projeto.Nome = dataReader.GetString(2);
                    projeto.DataInicio = dataReader.GetDateTime(3);
                    projeto.PrevisaoTermino = dataReader.GetDateTime(4);
                    projeto.Situacao = dataReader.GetString(5);
                }
                dataReader.Close();

                Cliente cliente = daoCliente.Read(projeto.Cliente.Codigo);
                projeto.Cliente.Nome = cliente.Nome;
                projeto.Cliente.Cnpj = cliente.Cnpj;
                projeto.Cliente.Telefone = cliente.Telefone;
                projeto.Cliente.Email = cliente.Email;
                projeto.Cliente.Responsavel = cliente.Responsavel;
                projeto.Cliente.Rua = cliente.Rua;
                projeto.Cliente.Numero = cliente.Numero;
                projeto.Cliente.Cep = cliente.Cep;
                projeto.Cliente.Cidade = cliente.Cidade;
                projeto.Cliente.Estado = cliente.Estado;
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
            return projeto;
        }

        public List<Projeto> ListAll()
        {
            MySqlConnection connection = Database.GetInstance().GetConnection();

            List<Projeto> listaAuxiliar = new List<Projeto>();
            List<Projeto> lista = new List<Projeto>();

            string query = "SELECT * FROM Projeto";

            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Projeto projeto = new Projeto();
                    projeto.Codigo = dataReader.GetInt32(0);
                    projeto.Cliente = new Cliente();
                    projeto.Cliente.Codigo = dataReader.GetInt32(1);
                    projeto.Nome = dataReader.GetString(2);
                    projeto.DataInicio = dataReader.GetDateTime(3);
                    projeto.PrevisaoTermino = dataReader.GetDateTime(4);
                    projeto.Situacao = dataReader.GetString(5);

                    listaAuxiliar.Add(projeto);
                }
                dataReader.Close();

                foreach(Projeto proj in listaAuxiliar)
                {
                    Cliente cliente = daoCliente.Read(proj.Cliente.Codigo);
                    proj.Cliente.Nome = cliente.Nome;
                    proj.Cliente.Cnpj = cliente.Cnpj;
                    proj.Cliente.Telefone = cliente.Telefone;
                    proj.Cliente.Email = cliente.Email;
                    proj.Cliente.Responsavel = cliente.Responsavel;
                    proj.Cliente.Rua = cliente.Rua;
                    proj.Cliente.Numero = cliente.Numero;
                    proj.Cliente.Cep = cliente.Cep;
                    proj.Cliente.Cidade = cliente.Cidade;
                    proj.Cliente.Estado = cliente.Estado;
                    lista.Add(proj);
                }
                             
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

        public List<Projeto> ListBySituation(String situacao)
        {
            MySqlConnection connection = Database.GetInstance().GetConnection();

            List<Projeto> listaAuxiliar = new List<Projeto>();
            List<Projeto> lista = new List<Projeto>();

            string query = "SELECT * FROM Projeto where situacao = " + situacao;

            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Projeto projeto = new Projeto();
                    projeto.Codigo = dataReader.GetInt32(0);
                    projeto.Cliente = new Cliente();
                    projeto.Cliente.Codigo = dataReader.GetInt32(1);
                    projeto.Nome = dataReader.GetString(2);
                    projeto.DataInicio = dataReader.GetDateTime(3);
                    projeto.PrevisaoTermino = dataReader.GetDateTime(4);
                    projeto.Situacao = dataReader.GetString(5);

                    listaAuxiliar.Add(projeto);
                }
                dataReader.Close();

                foreach (Projeto proj in listaAuxiliar)
                {
                    Cliente cliente = daoCliente.Read(proj.Cliente.Codigo);
                    proj.Cliente.Nome = cliente.Nome;
                    proj.Cliente.Cnpj = cliente.Cnpj;
                    proj.Cliente.Telefone = cliente.Telefone;
                    proj.Cliente.Email = cliente.Email;
                    proj.Cliente.Responsavel = cliente.Responsavel;
                    proj.Cliente.Rua = cliente.Rua;
                    proj.Cliente.Numero = cliente.Numero;
                    proj.Cliente.Cep = cliente.Cep;
                    proj.Cliente.Cidade = cliente.Cidade;
                    proj.Cliente.Estado = cliente.Estado;
                    lista.Add(proj);
                }
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
