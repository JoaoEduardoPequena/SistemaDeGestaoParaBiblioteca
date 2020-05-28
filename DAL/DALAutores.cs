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
    public class DALAutores
    {
        public void Inserir(ModeloAutor modeloAutores)
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
            sqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            //sqlCommand.CommandText = "SP_INSERIR_EDITORAS";
            sqlCommand.CommandText = "INSERT INTO tbAutor(nome) VALUES(@nome)";
            sqlCommand.Parameters.AddWithValue("@nome",modeloAutores.Nome_Autor);
            sqlConnection.Open();
            modeloAutores.Id_Autor = Convert.ToInt32(sqlCommand.ExecuteScalar());
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

        public ModeloAutor CarregaModeloAutores(int codigo)
        {
            ModeloAutor modeloAutor = new ModeloAutor();

            SqlDataReader sqlDataReader = null;

            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_LISTAR_AUTOR_POR_CODIGO";
                //sqlCommand.CommandText = "select * from tbAutor where id_autor=@id_autor";
                sqlCommand.Parameters.AddWithValue("@id_autor",codigo);

                sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    modeloAutor.Id_Autor = Convert.ToInt32(sqlDataReader["id_autor"]);
                    modeloAutor.Nome_Autor = Convert.ToString(sqlDataReader["nome"]);
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

            return modeloAutor;
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
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_LISTAR_TODOS_AUTORES";// Nome Do Procedimento Armazenado
                //sqlCommand.CommandText = "select * from tbAutor";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Consultar dados de Autores.Datalhes:" + ex.Message.ToString(),"AVISO");
            }

            finally
            {
                sqlConnection.Close();
            }

            return dataTable;
        }

        public DataTable LocalizarAutoresPorNome(string nomeAutor)
        {
            SqlConnection sqlConnection = new SqlConnection();
            DataTable dataTable = new DataTable();

            try
            {
                sqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_CONSULTAR_AUTORES_POR_NOME";
                //sqlCommand.CommandText = "SELECT * FROM tbAutor WHERE nome LIKE '%'+@nome+'%' "; 
                sqlCommand.Parameters.AddWithValue("@nome",nomeAutor);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Consultar dados de Autores por Nome.Datalhes:" + ex.Message.ToString(),"AVISO");
            }

            finally
            {
                sqlConnection.Close();
            }

            return dataTable;
        }

        public void Alterar(ModeloAutor modeloAutor)
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "UPDATE tbAutor SET nome = @nome WHERE id_autor=@id_autor";

                sqlCommand.Parameters.AddWithValue("@id_autor",modeloAutor.Id_Autor);
                sqlCommand.Parameters.AddWithValue("@nome",modeloAutor.Nome_Autor);

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
                sqlCommand.CommandText = "DELETE FROM tbAutor WHERE id_autor=@id_autor";
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@id_autor",codgio);

                sqlConection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar Excluir Registro do Autor. Detalhe:" + ex.Message, "AVISO");
            }

            finally
            {
                sqlConection.Close();
            }  
        }


    }
}
