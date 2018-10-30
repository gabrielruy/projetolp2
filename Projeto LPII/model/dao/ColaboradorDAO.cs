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
            bool state = false; 

            MySqlConnection connection = Database.GetInstance().GetConnection();

            string query =
            string.Format("INSERT INTO Colaborador (nome, login, senha, telefone, cargo, nroRh, email) " +
                           "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');",
                           c.Nome, c.Login, c.Senha, c.Telefone, c.Cargo, c.NroRh, c.Email);

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
                    if (exception.Message.ToString().Contains("un_colaborador_nome"))
                        MessageBox.Show("Este nome já está cadastrado.", "Nome já cadastrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    if (exception.Message.ToString().Contains("un_colaborador_nroRh"))
                        MessageBox.Show("Este número de RH já está cadastrado.", "Número de RH já cadastrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    if (exception.Message.ToString().Contains("un_colaborador_login"))
                        MessageBox.Show("Este login já está cadastrado.", "Login já Cadastrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            finally
            {
                connection.Close();
            }
            return state;
        }

        public bool Update(Colaborador c)
        {
            bool state = false; 

            MySqlConnection connection = Database.GetInstance().GetConnection();

            string query =
            string.Format("UPDATE Colaborador SET nome='{0}', login='{1}', senha='{2}'," +
            "telefone='{3}', cargo='{4}', nroRh='{5}', email='{6}'" +
            "WHERE codigo={7};", c.Nome, c.Login, c.Senha, c.Telefone, c.Cargo,
            c.NroRh, c.Email, c.Codigo);

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
                    if (exception.Message.ToString().Contains("un_colaborador_nome"))
                        MessageBox.Show("Este nome já está cadastrado.", "Nome já cadastrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    if (exception.Message.ToString().Contains("un_colaborador_nroRh"))
                        MessageBox.Show("Este número de RH já está cadastrado.", "Número de RH já cadastrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    if (exception.Message.ToString().Contains("un_colaborador_login"))
                        MessageBox.Show("Este login já está cadastrado.", "Login já Cadastrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            finally
            {
                connection.Close();
            }
            return state;
        }

        public bool Delete(Colaborador c)
        {
            bool state = false; 

            MySqlConnection connection = Database.GetInstance().GetConnection();

            string query = string.Format("DELETE FROM Colaborador WHERE codigo = {0};", c.Codigo);

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

        public Colaborador Read(int codigo)
        {
            MySqlConnection connection = Database.GetInstance().GetConnection();

            Colaborador colaborador = null;

            string query = "SELECT * FROM Colaborador WHERE codigo = " + codigo;

            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlDataReader dataReader = command.ExecuteReader();

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
            return colaborador;
        }

        public List<Colaborador> ListByName(String nome)
        {
            MySqlConnection connection = Database.GetInstance().GetConnection();

            List<Colaborador> lista = new List<Colaborador>();

            Colaborador colaborador = null;

            string query = "SELECT * FROM Colaborador WHERE nome LIKE @Nome;";

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@Nome", nome + "%");

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlDataReader dataReader = command.ExecuteReader();

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

                    lista.Add(colaborador);
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

        public List<Colaborador> ListAll()
        {
            MySqlConnection connection = Database.GetInstance().GetConnection();

            List<Colaborador> lista = new List<Colaborador>();

            Colaborador colaborador;

            string query = "SELECT * FROM Colaborador";

            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlDataReader dataReader = command.ExecuteReader();

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

                    lista.Add(colaborador); 
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

