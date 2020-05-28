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
    public class DALLeitor
    {
        public void Inserir(ModeloLeitores modeloLeitor)
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_INSERIR_LEITORES";
                //sqlCommand.CommandText = "INSERT INTO tbLeitor(nome,email,telefone) VALUES(@nome,@email,@telefone); SELECT @@IDENTITY;";
                sqlCommand.Parameters.AddWithValue("@nome",modeloLeitor.Nome);
                sqlCommand.Parameters.AddWithValue("@email",modeloLeitor.Email);
                sqlCommand.Parameters.AddWithValue("@telefone",modeloLeitor.Telefone);

                sqlConnection.Open();
                modeloLeitor.Id_Leitor = Convert.ToInt32(sqlCommand.ExecuteScalar());
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

        public ModeloLeitores CarregaModeloLeitorPorCodigo(int codigo)
        {
            ModeloLeitores modeloLeitor = new ModeloLeitores();

            SqlDataReader sqlDataReader = null;

            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT * FROM tbLeitor WHERE id_leitor=@id_leitor";
                sqlCommand.Parameters.AddWithValue("@id_leitor",codigo);

                sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                 sqlDataReader.Read();
                 modeloLeitor.Id_Leitor = Convert.ToInt32(sqlDataReader["id_leitor"]);
                 modeloLeitor.Nome = Convert.ToString(sqlDataReader["nome"]);
                 modeloLeitor.Email = Convert.ToString(sqlDataReader["email"]);
                 modeloLeitor.Telefone = Convert.ToInt32(sqlDataReader["telefone"]);
                }

                //else
                //{
                //    MessageBox.Show("O código do Leitor informado não existe","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //}

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

            return modeloLeitor;
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
                sqlCommand.CommandText = " SELECT * FROM tbLeitor";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Consultar dados de Leitor.Datalhes:" + ex.Message.ToString(),"AVISO");
            }

            finally
            {
                sqlConnection.Close();
            }

            return dataTable;
        }

        public DataTable LocalizarLeitorPeloNome(string nomeLeitor)
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
                sqlCommand.CommandText = "SELECT * FROM tbLeitor WHERE nome LIKE '%'+@nome+'%' ";
                sqlCommand.Parameters.AddWithValue("@nome",nomeLeitor);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Consultar livro pelo Nome.Datalhes:" + ex.Message.ToString(),"AVISO");
            }

            finally
            {
                sqlConnection.Close();
            }

            return dataTable;
        }

        public DataTable LocalizarLeitorPeloCodigo(int codigoLeitor)
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
                sqlCommand.CommandText = "SELECT * FROM tbLeitor WHERE id_leitor LIKE '%'+@id_leitor+'%' ";
                sqlCommand.Parameters.AddWithValue("@id_leitor",codigoLeitor);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Consultar Leitor Pelo Código.Datalhes:" + ex.Message.ToString(),"AVISO");
            }

            finally
            {
                sqlConnection.Close();
            }

            return dataTable;
        }

        public void Alterar(ModeloLeitores modeloLeitor)
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "UPDATE tbLeitor SET nome=@nome,email=@email,telefone=@telefone WHERE id_leitor = @id_leitor";

                sqlCommand.Parameters.AddWithValue("@id_leitor",modeloLeitor.Id_Leitor);
                sqlCommand.Parameters.AddWithValue("@nome",modeloLeitor.Nome);
                sqlCommand.Parameters.AddWithValue("@email",modeloLeitor.Email);
                sqlCommand.Parameters.AddWithValue("@telefone",modeloLeitor.Telefone);
               
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
                sqlCommand.CommandText = "DELETE FROM tbLeitor WHERE id_leitor = @id_leitor";
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@id_leitor",codgio);

                sqlConection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar Excluir Registro do Leitor. Detalhe:" + ex.Message,"AVISO");
            }

            finally
            {
                sqlConection.Close();
            }
        }


    }
}
