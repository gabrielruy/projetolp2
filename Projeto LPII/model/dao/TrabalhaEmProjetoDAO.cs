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
        public bool Create(TrabalhaEmProjeto trabalha)
        {
            bool state = false;

            MySqlConnection connection = Database.GetInstance().GetConnection();

            string query ="INSERT INTO TrabalhaEmProjeto (codigo_colaborador, codigo_projeto) " +
                          "VALUES (@Colaborador, @Projeto);";

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@Colaborador", trabalha.Colaborador.Codigo);
            command.Parameters.AddWithValue("@Projeto", trabalha.Projeto.Codigo);

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                command.ExecuteNonQuery();

                state = true;
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString(), "Erro.", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return state;
        }

        public bool Delete(TrabalhaEmProjeto t)
        {
            bool state = false; 

            MySqlConnection connection = Database.GetInstance().GetConnection();

            string query = string.Format("DELETE FROM Cliente WHERE codigo = {0};", t.Codigo);

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


        public List<TrabalhaEmProjeto> ListAll(int codProj)
        {
            MySqlConnection connection = Database.GetInstance().GetConnection();

            List<TrabalhaEmProjeto> lista = new List<TrabalhaEmProjeto>();

            TrabalhaEmProjeto trabalhador;

            string query =
            string.Format("SELECT tp.*, c.*, p.* FROM Projeto p " +
                          "JOIN TrabalhaEmProjeto tp ON p.codigo = tp.codigo_projeto " +
                          "JOIN Colaborador c ON tp.codigo_colaborador = c.codigo " +
                          "WHERE tp.codigo_projeto = " + codProj);


            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlDataReader dataReader = command.ExecuteReader();

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
                    trabalhador.Colaborador.Cargo = dataReader.GetString(5);
                    trabalhador.Colaborador.NroRh = dataReader.GetInt32(6);
                    trabalhador.Colaborador.Login = dataReader.GetString(7);
                    trabalhador.Colaborador.Senha = dataReader.GetString(8);
                    trabalhador.Projeto.Codigo = dataReader.GetInt32(9);
                    trabalhador.Projeto.Nome = dataReader.GetString(10);
                    trabalhador.Projeto.Cliente = dataReader.GetInt32(11);
                    trabalhador.Projeto.DataInicio = dataReader.GetDateTime(12);
                    trabalhador.Projeto.PrevisaoTermino = dataReader.GetDateTime(13);
                    trabalhador.Projeto.Situacao = dataReader.GetString(14);

                    lista.Add(trabalhador); 
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
