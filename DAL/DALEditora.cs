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
    public class DALEditora
    {
        public void Inserir(ModeloEditora modeloEditora)
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_INSERIR_EDITORAS";
                //sqlCommand.CommandText = "INSERT INTO tbEditora(editora) VALUES (@editora)";
                sqlCommand.Parameters.AddWithValue("@Nome", modeloEditora.Nome_Ed);
                /*sqlCommand.Parameters.Add("@editora",SqlDbType.VarChar,100);
                sqlCommand.Parameters["@editora"].Value = modeloEditora.Nome_Ed;*/
                //sqlCommand.Parameters.Add( new SqlParameter("@nomeEditora",modeloEditora.Nome_Ed) );
                sqlConnection.Open();
                modeloEditora.Cod_Ed = Convert.ToInt32(sqlCommand.ExecuteScalar());
                //sqlCommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
              throw new Exception(ex.Message.ToString() );
            }

            finally
            {
                sqlConnection.Close();
            }
        }

        public ModeloEditora CarregaModeloEditora(int codigo)
        {
            ModeloEditora modeloEditora = new ModeloEditora();

            SqlDataReader sqlDataReader = null;

            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SP_LISTAR_EDITORA_POR_CODIGO";
                //sqlCommand.CommandText = "select * from tbEditora where id_editora=@id_editora";
                sqlCommand.Parameters.AddWithValue("@id_editora",codigo);

                sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    modeloEditora.Cod_Ed = Convert.ToInt32(sqlDataReader["id_editora"]);
                    modeloEditora.Nome_Ed = Convert.ToString(sqlDataReader["editora"]);
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

            return modeloEditora;
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
                sqlCommand.CommandText = "SP_LISTAR_TODAS_EDITORAS";// Nome Do Procedimento Armazenado
                //sqlCommand.CommandText = "select * from tbEditora";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Consultar dados de Editoras.Datalhes: " +ex.Message.ToString(),"AVISO");
            }

            finally
            {
                sqlConnection.Close();
            }

            return dataTable;
        }

        public DataTable LocalizarEditorasPorNome(string nomeEditora)
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
                //sqlCommand.CommandText = "SP_CONSULTAR_EDITORAS_POR_NOME";// Nome Do Procedimento Armazenado
                sqlCommand.CommandText = "SELECT * FROM tbEditora WHERE editora LIKE '%'+@editora+'%' ";
                sqlCommand.Parameters.AddWithValue("@editora",nomeEditora);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Consultar Registro de Editoras.Datalhes: " + ex.Message.ToString(),"AVISO");
            }

            finally
            {
                sqlConnection.Close();
            }

            return dataTable;
        }

        public void Alterar(ModeloEditora modeloEditora)
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                //sqlCommand.CommandText = "SP_ACTUALIZAR_EDITORA";
                sqlCommand.CommandText = "UPDATE tbEditora SET editora=@editora WHERE id_editora=@id_editora";
                sqlCommand.Parameters.AddWithValue("@id_editora",modeloEditora.Cod_Ed);
                sqlCommand.Parameters.AddWithValue("@editora",modeloEditora.Nome_Ed);
                
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
                sqlCommand.CommandText = "SP_EXCLUIR_EDITORA";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id_editora",codgio);

                sqlConection.Open();
                sqlCommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
               MessageBox.Show("Erro ao tentar Excluir Registro da Editora. Detalhe:"+ ex.Message,"AVISO");
            }

            finally
            {
              sqlConection.Close();
            }
            
        }
    }
}
