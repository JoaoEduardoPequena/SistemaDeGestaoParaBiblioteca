using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MODELO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class DALBibliotecarios
    {
        public void Inserir(ModeloBibliotecarios modeloBibliotecario)
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.CommandText = "INSERT INTO tbBibliotecarios(nome,usuario,senha,email,telefone,funcao) VALUES (@nome,@usuario,@senha,@email,@telefone,@funcao)";
                sqlCommand.Parameters.AddWithValue("@nome",modeloBibliotecario.Nome);
                sqlCommand.Parameters.AddWithValue("@usuario",modeloBibliotecario.Usuario);
                sqlCommand.Parameters.AddWithValue("@senha",modeloBibliotecario.Senha);
                sqlCommand.Parameters.AddWithValue("@email",modeloBibliotecario.Email);
                sqlCommand.Parameters.AddWithValue("@telefone",modeloBibliotecario.Telefone);
                sqlCommand.Parameters.AddWithValue("@funcao",modeloBibliotecario.Funcao);

                sqlConnection.Open();
                modeloBibliotecario.Id_Bibliotecario = Convert.ToInt32(sqlCommand.ExecuteScalar());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            finally
            {
                sqlConnection.Close();
            }
        }

        public ModeloBibliotecarios CarregaModeloBibliotecariosPorCodigo(int codigoBibliotecario)
        {
            ModeloBibliotecarios modeloBibliotecario = new  ModeloBibliotecarios();

            SqlDataReader sqlDataReader = null;

            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT * FROM tbBibliotecarios WHERE id_bibliotecario = @id_bibliotecario ";
                sqlCommand.Parameters.AddWithValue("@id_bibliotecario",codigoBibliotecario);

                sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    modeloBibliotecario.Id_Bibliotecario= Convert.ToInt32(sqlDataReader["id_bibliotecario"]);
                    modeloBibliotecario.Nome = Convert.ToString(sqlDataReader["nome"]);
                    modeloBibliotecario.Usuario = Convert.ToString(sqlDataReader["usuario"]);
                    modeloBibliotecario.Senha = Convert.ToString(sqlDataReader["senha"]);
                    modeloBibliotecario.Email = Convert.ToString(sqlDataReader["email"]);
                    modeloBibliotecario.Telefone = Convert.ToInt32(sqlDataReader["telefone"]);
                    modeloBibliotecario.Funcao = Convert.ToString(sqlDataReader["funcao"]);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlConnection.Close();
                sqlDataReader.Close();
            }

            return modeloBibliotecario;
        }

        public ModeloBibliotecarios LoginBibliotecario(string usuario, string senha)
        {
            ModeloBibliotecarios modeloBibliotecario = new ModeloBibliotecarios();

            SqlDataReader sqlDataReader = null;

            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT * FROM tbBibliotecarios WHERE (usuario = @usuario AND senha = @senha)";
                sqlCommand.Parameters.AddWithValue("@usuario",usuario);
                sqlCommand.Parameters.AddWithValue("@senha",senha);

                sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    modeloBibliotecario.Id_Bibliotecario = Convert.ToInt32(sqlDataReader["id_bibliotecario"]);
                    modeloBibliotecario.Nome = Convert.ToString(sqlDataReader["nome"]);
                    modeloBibliotecario.Usuario = Convert.ToString(sqlDataReader["usuario"]);
                    modeloBibliotecario.Senha = Convert.ToString(sqlDataReader["senha"]);
                    modeloBibliotecario.Email = Convert.ToString(sqlDataReader["email"]);
                    modeloBibliotecario.Telefone = Convert.ToInt32(sqlDataReader["telefone"]);
                    modeloBibliotecario.Funcao = Convert.ToString(sqlDataReader["funcao"]);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlConnection.Close();
                sqlDataReader.Close();
            }

            return modeloBibliotecario;
        }

        public DataTable Localizar()
        {
            SqlConnection sqlConnection = new SqlConnection();
            DataTable dataTable = new DataTable();

            try
            {
                sqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT * FROM tbBibliotecarios";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Consultar dados de Funcionários.Datalhes: " + ex.Message.ToString(),"AVISO");
            }

            finally
            {
                sqlConnection.Close();
            }

            return dataTable;
        }

        public DataTable LocalizarBibliotecarioPeloNome(string nome)
        {
            SqlConnection sqlConnection = new SqlConnection();
            DataTable dataTable = new DataTable();

            try
            {
                sqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT * FROM tbBibliotecarios WHERE nome LIKE '%'+@nome+'%' ";
                sqlCommand.Parameters.AddWithValue("@nome",nome);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Consultar Bibliotecário pelo Nome.Datalhes:" + ex.Message.ToString(), "AVISO");
            }

            finally
            {
                sqlConnection.Close();
            }

            return dataTable;
        }

        public DataTable LocalizarBibliotecariosPeloCodigo(int codigoBibliotecario)
        {
            SqlConnection sqlConnection = new SqlConnection();
            DataTable dataTable = new DataTable();

            try
            {
                sqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT * FROM tbLivro WHERE id_bibliotecario LIKE '%'+@id_bibliotecario+'%' ";
                sqlCommand.Parameters.AddWithValue("@id_bibliotecario",codigoBibliotecario);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Consultar Funcionário pelo Código.Datalhes:" + ex.Message.ToString(),"AVISO");
            }

            finally
            {
                sqlConnection.Close();
            }

            return dataTable;
        }

        public void Alterar(ModeloBibliotecarios modeloBibliotecario)
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "UPDATE tbBibliotecarios SET nome=@nome,usuario=@usuario,senha=@senha,email=@email,telefone=@telefone,funcao=@funcao WHERE id_bibliotecario = @id_bibliotecario";

                sqlCommand.Parameters.AddWithValue("@id_bibliotecario",modeloBibliotecario.Id_Bibliotecario);
                sqlCommand.Parameters.AddWithValue("@nome",modeloBibliotecario.Nome);
                sqlCommand.Parameters.AddWithValue("@usuario",modeloBibliotecario.Usuario);
                sqlCommand.Parameters.AddWithValue("@senha", modeloBibliotecario.Senha);
                sqlCommand.Parameters.AddWithValue("@email", modeloBibliotecario.Email);
                sqlCommand.Parameters.AddWithValue("@telefone",modeloBibliotecario.Telefone);
                sqlCommand.Parameters.AddWithValue("@funcao",modeloBibliotecario.Funcao);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            finally
            {
                sqlConnection.Close();
            }
        }

        public void Excluir(int codgio)
        {
            SqlConnection sqlConection = new SqlConnection();
            try
            {
                sqlConection.ConnectionString = DadosDaConexao.StringDeConexao;

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConection;
                sqlCommand.CommandText = "DELETE FROM tbBibliotecarios WHERE id_bibliotecario = @id_bibliotecario";
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@id_bibliotecario",codgio);

                sqlConection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Excluir Bibliotecário.Datalhes:" + ex.Message.ToString(),"AVISO");
            }

            finally
            {
                sqlConection.Close();
            }
        }

    }
}
