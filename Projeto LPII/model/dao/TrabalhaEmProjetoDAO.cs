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

        private ColaboradorDAO daoColab = new ColaboradorDAO();
        private ProjetoDAO daoProj = new ProjetoDAO();

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

        public bool DeleteInProject(int codProj)
        {
            bool state = false; 

            MySqlConnection connection = Database.GetInstance().GetConnection();

            string query = string.Format("DELETE FROM TrabalhaEmProjeto WHERE codigo_projeto = {0};", codProj);

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
                MessageBox.Show("Erro ao excluir trabalhadores vinculados ao projeto.", "Erro ao excluir.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return state;
        }

        public bool Delete(int codProj, int codColab)
        {
            bool state = false;

            MySqlConnection connection = Database.GetInstance().GetConnection();

            string query = string.Format("DELETE FROM TrabalhaEmProjeto WHERE codigo_projeto = {0} and codigo_colaborador = {1};", codProj, codColab);

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
                MessageBox.Show("Erro ao excluir trabalhador vinculado ao projeto.", "Erro ao excluir.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return state;
        }

        public List<TrabalhaEmProjeto> ListInProject(int codProj)
        {
            MySqlConnection connection = Database.GetInstance().GetConnection();

            List<TrabalhaEmProjeto> lista = new List<TrabalhaEmProjeto>();
            List<TrabalhaEmProjeto> listaAuxiliar = new List<TrabalhaEmProjeto>();

            TrabalhaEmProjeto trabalhador;

            string query =
            string.Format("SELECT * FROM TrabalhaEmProjeto WHERE codigo_projeto = " + codProj);


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
                    trabalhador.Projeto.Codigo = dataReader.GetInt32(2);

                    listaAuxiliar.Add(trabalhador); 
                }
                dataReader.Close();

                foreach(TrabalhaEmProjeto t in listaAuxiliar)
                {
                    Colaborador colaborador = daoColab.Read(t.Colaborador.Codigo);

                    t.Colaborador.Nome = colaborador.Nome;
                    t.Colaborador.Email = colaborador.Email;
                    t.Colaborador.Telefone = colaborador.Telefone;
                    t.Colaborador.Cargo = colaborador.Cargo;
                    t.Colaborador.NroRh = colaborador.NroRh;
                    t.Colaborador.Login = colaborador.Login;
                    t.Colaborador.Senha = colaborador.Senha;

                    lista.Add(t);                        
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

        public List<int> ListCodeInProject(int codProj)
        {
            MySqlConnection connection = Database.GetInstance().GetConnection();

            List<int> lista = new List<int>();

            int codTrabalhador;

            string query =
            string.Format("SELECT * FROM TrabalhaEmProjeto WHERE codigo_projeto = " + codProj);


            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    codTrabalhador = dataReader.GetInt32(1);

                    lista.Add(codTrabalhador);
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
