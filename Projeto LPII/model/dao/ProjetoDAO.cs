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
            bool state = false; 

            MySqlConnection connection = Database.GetInstance().GetConnection();

            string query ="INSERT INTO Projeto (cliente, nome, dataInicio, previsaoTermino, situacao) " +
                           "VALUES (@Cliente, @Nome, @DataInicio, @PrevisaoTermino, @Situacao);";

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@Cliente", p.Cliente);
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

                if (dataReader.Read())
                {
                    projeto = new Projeto();
                    projeto.Codigo = dataReader.GetInt32(0);
                    projeto.Cliente = dataReader.GetInt32(1);
                    projeto.Nome = dataReader.GetString(2);
                    projeto.DataInicio = dataReader.GetDateTime(3);
                    projeto.PrevisaoTermino = dataReader.GetDateTime(4);

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

                if (dataReader.Read())
                {
                    projeto = new Projeto();
                    projeto.Codigo = dataReader.GetInt32(0);
                    projeto.Cliente = dataReader.GetInt32(1);
                    projeto.Nome = dataReader.GetString(2);
                    projeto.DataInicio = dataReader.GetDateTime(3);
                    projeto.PrevisaoTermino = dataReader.GetDateTime(4);

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
            return projeto;
        }

        public List<Projeto> ListAll()
        {
            MySqlConnection connection = Database.GetInstance().GetConnection();

            List<Projeto> lista = new List<Projeto>();

            Projeto projeto;

            string query = "SELECT * FROM Projeto";

            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    projeto = new Projeto();
                    projeto.Codigo = dataReader.GetInt32(0);
                    projeto.Cliente = dataReader.GetInt32(1);
                    projeto.Nome = dataReader.GetString(2);
                    projeto.DataInicio = dataReader.GetDateTime(3);
                    projeto.PrevisaoTermino = dataReader.GetDateTime(4);
                    projeto.Situacao = dataReader.GetString(5);

                    lista.Add(projeto); 
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
