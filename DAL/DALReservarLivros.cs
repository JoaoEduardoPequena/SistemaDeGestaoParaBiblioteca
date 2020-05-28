using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MODELO;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace DAL
{
    public class DALReservarLivros
    {
        public void Inserir(ModeloReservaLivro modeloReservar)
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "INSERT INTO tbReservaLivro(id_livro,id_leitor,data_reserva,data_limite,estado_reserva) VALUES(@id_livro,@id_leitor,@data_reserva,@data_limite,@estado_reserva); SELECT @@IDENTITY; ";
                sqlCommand.Parameters.AddWithValue("@id_livro",modeloReservar.Id_Livro);
                sqlCommand.Parameters.AddWithValue("@id_leitor",modeloReservar.Cod_Leitor);

                sqlCommand.Parameters.Add("@data_reserva",SqlDbType.Date);
                sqlCommand.Parameters["@data_reserva"].Value = modeloReservar.Data_Reserva;

                sqlCommand.Parameters.Add("@data_limite",SqlDbType.Date);
                sqlCommand.Parameters["@data_limite"].Value = modeloReservar.Data_Limite;

                sqlCommand.Parameters.AddWithValue("@estado_reserva",modeloReservar.Estado_Reserva);

                sqlConnection.Open();
                modeloReservar.Id_Reserva = Convert.ToInt32(sqlCommand.ExecuteScalar());
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

        public ModeloReservaLivro CarregaModeloReservaLivros( int codigo )
        {
            ModeloReservaLivro modeloReservaLivro = new ModeloReservaLivro();
            SqlDataReader sqlDataReader = null;
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "";
                sqlCommand.Parameters.AddWithValue("@id_reserva",codigo);

                sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    modeloReservaLivro.Id_Reserva = Convert.ToInt32(sqlDataReader["id_reserva"]);
                    modeloReservaLivro.Id_Livro = Convert.ToInt32(sqlDataReader["id_livro"]);
                    modeloReservaLivro.Cod_Leitor = Convert.ToInt32(sqlDataReader["id_leitor"]);
                    modeloReservaLivro.Data_Reserva = Convert.ToDateTime(sqlDataReader["data_reserva"]);
                    modeloReservaLivro.Data_Limite = Convert.ToDateTime(sqlDataReader["data_limite"]);
                    modeloReservaLivro.Estado_Reserva = Convert.ToString(sqlDataReader["estado_reserva"]);

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

            return modeloReservaLivro;
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
                sqlCommand.CommandText = "SELECT tbReservaLivro.id_reserva,tbLeitor.nome, tbLivro.titulo,tbReservaLivro.data_reserva, tbReservaLivro.data_limite,tbReservaLivro.estado_reserva FROM tbReservaLivro INNER JOIN tbLeitor ON tbReservaLivro.id_leitor = tbLeitor.id_leitor INNER JOIN tbLivro ON tbReservaLivro.id_livro = tbLivro.id_livro";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Consultar Todos Livros Reservados.Datalhes: " + ex.Message.ToString(), "AVISO");
            }

            finally
            {
                sqlConnection.Close();
            }

            return dataTable;
        }
    }
}
