using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using MODELO;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace DAL
{
    public class DALLivro
    {
        public void Inserir(ModeloLivro modeloLivro)
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "INSERT INTO tbLivro(id_autor,id_editora,titulo,edicao,foto,estante,exemplar) VALUES(@id_autor,@id_editora,@titulo,@edicao,@foto,@estante,@exemplar); SELECT @@IDENTITY ;";

                sqlCommand.Parameters.AddWithValue("@id_autor",modeloLivro.Id_Autor);
                sqlCommand.Parameters.AddWithValue("@id_editora",modeloLivro.Id_Editora);
                sqlCommand.Parameters.AddWithValue("@titulo",modeloLivro.Titulo);
                sqlCommand.Parameters.AddWithValue("@edicao",modeloLivro.Edicao);
                sqlCommand.Parameters.AddWithValue("@estante",modeloLivro.Estante_Numero);
                sqlCommand.Parameters.AddWithValue("@exemplar",modeloLivro.numExemplaresLivro);
                sqlCommand.Parameters.Add("@foto",System.Data.SqlDbType.Image);

                if (modeloLivro.Foto == null)
                {
                    sqlCommand.Parameters["@foto"].Value = DBNull.Value;
                }

                else
                {
                    sqlCommand.Parameters["@foto"].Value = modeloLivro.Foto;
                }

                sqlConnection.Open();
                modeloLivro.Id_Livro = Convert.ToInt32(sqlCommand.ExecuteScalar());
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

        public void Alterar(ModeloLivro modeloLivros)
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "UPDATE tbLivro SET id_autor=@id_autor,id_editora=@id_editora,titulo=@titulo,edicao=@edicao,estante=@estante,exemplar=@exemplar,foto=@foto WHERE id_livro = @id_livro";

                sqlCommand.Parameters.AddWithValue("@id_livro",modeloLivros.Id_Livro);
                sqlCommand.Parameters.AddWithValue("@id_autor",modeloLivros.Id_Autor);
                sqlCommand.Parameters.AddWithValue("@id_editora",modeloLivros.Id_Editora);
                sqlCommand.Parameters.AddWithValue("@titulo",modeloLivros.Titulo);
                sqlCommand.Parameters.AddWithValue("@edicao",modeloLivros.Edicao);
                sqlCommand.Parameters.AddWithValue("@estante",modeloLivros.Estante_Numero);
                sqlCommand.Parameters.AddWithValue("@exemplar",modeloLivros.numExemplaresLivro);
                sqlCommand.Parameters.Add("@foto",System.Data.SqlDbType.Image);

                if (modeloLivros.Foto == null)
                {
                    sqlCommand.Parameters["@foto"].Value = DBNull.Value;
                }

                else
                {
                    sqlCommand.Parameters["@foto"].Value = modeloLivros.Foto;
                }

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

        public ModeloLivro CarregaModeloLivroPorCodigo(int codigo)
        {
            ModeloLivro modeloLivro = new ModeloLivro();

            SqlDataReader sqlDataReader = null;

            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_LISTAR_LIVRO_PELO_CODIGO";
                //sqlCommand.CommandText = "SELECT tbLivro.id_livro,tbLivro.titulo,tbAutor.id_autor,tbEditora.id_editora,tbLivro.edicao,tbLivro.estante,tbLivro.exemplar,tbLivro.foto FROM tbLivro INNER JOIN tbAutor ON tbLivro.id_autor = tbAutor.id_autor JOIN tbEditora ON tbLivro.id_editora=tbEditora.id_editora WHERE tbLivro.id_livro=@id_livro";
                sqlCommand.Parameters.AddWithValue("@CodigoLivro",codigo);

                sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    modeloLivro.Id_Livro = Convert.ToInt32(sqlDataReader["id_livro"]);
                    modeloLivro.Id_Autor = Convert.ToInt32(sqlDataReader["id_autor"]);
                    modeloLivro.Id_Editora = Convert.ToInt32(sqlDataReader["id_editora"]);
                    modeloLivro.Titulo = Convert.ToString(sqlDataReader["titulo"]);
                    modeloLivro.Edicao = Convert.ToString(sqlDataReader["edicao"]);
                    modeloLivro.Estante_Numero = Convert.ToInt32(sqlDataReader["estante"]);
                    modeloLivro.numExemplaresLivro = Convert.ToInt32(sqlDataReader["exemplar"]);

                    try
                    {
                        modeloLivro.Foto = (byte[])sqlDataReader["foto"];
                    }
                    catch { }

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

            return modeloLivro;
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
                //sqlCommand.CommandText = "SP_LISTAR_TODOS_LIVROS";// Nome Do Procedimento Armazenado
                sqlCommand.CommandText = "SELECT tbLivro.id_livro,tbLivro.titulo,tbAutor.nome,tbEditora.editora,tbLivro.edicao,tbLivro.estante,tbLivro.exemplar,tbLivro.foto FROM tbLivro INNER JOIN tbAutor ON tbLivro.id_autor = tbAutor.id_autor JOIN tbEditora ON tbLivro.id_editora=tbEditora.id_editora";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Consultar dados de Livros.Datalhes: " + ex.Message.ToString(),"AVISO");
            }

            finally
            {
               sqlConnection.Close();
            }

            return dataTable;
        }

        public DataTable LocalizarLivroPeloTitulo(string titulo)
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
                //sqlCommand.CommandText = "SELECT tbLivro.id_livro,tbLivro.titulo,tbAutor.id_autor,tbEditora.id_editora,tbLivro.edicao,tbLivro.estante,tbLivro.exemplar,tbLivro.foto FROM tbLivro INNER JOIN tbAutor ON tbLivro.id_autor = tbAutor.id_autor JOIN tbEditora ON tbLivro.id_editora=tbEditora.id_editora WHERE tbLivro.titulo LIKE '%'+@titulo+'%' "; 
                sqlCommand.CommandText = "SELECT tbLivro.id_livro,tbLivro.titulo,tbAutor.nome,tbEditora.editora,tbLivro.edicao,tbLivro.estante,tbLivro.exemplar,tbLivro.foto FROM tbLivro INNER JOIN tbAutor ON tbLivro.id_autor = tbAutor.id_autor JOIN tbEditora ON tbLivro.id_editora=tbEditora.id_editora WHERE tbLivro.titulo LIKE '%'+@titulo+'%' ";
                sqlCommand.Parameters.AddWithValue("@titulo",titulo);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Consultar livro pelo Titulo.Datalhes:" +ex.Message.ToString(),"AVISO");
            }

            finally
            {
                sqlConnection.Close();
            }

            return dataTable;
        }

        public DataTable LocalizarLivroPeloCodigo(int codigoLivro)
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
                sqlCommand.CommandText = "SELECT * FROM tbLivro WHERE id_livro LIKE '%'+@id_livro+'%' ";
                sqlCommand.Parameters.AddWithValue("@id_livro",codigoLivro);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Consultar livro pelo Código do Livro.Datalhes:" + ex.Message.ToString(), "AVISO");
            }

            finally
            {
                sqlConnection.Close();
            }

            return dataTable;
        }

        public void Excluir(int codgio)
        {
            SqlConnection sqlConection = new SqlConnection();
            try
            {
                sqlConection.ConnectionString = DadosDaConexao.StringDeConexao;

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConection;
                sqlCommand.CommandText = "DELETE FROM tbLivro WHERE id_livro = @id_livro";
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@id_livro",codgio);

                sqlConection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
              MessageBox.Show("Erro ao Tentar Consultar dados de Livro pelo Titulo do Livro.Datalhes:"  +ex.Message.ToString(),"AVISO");
            }

            finally
            {
               sqlConection.Close();
            } 
        }


    }
}
