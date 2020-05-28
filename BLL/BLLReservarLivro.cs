using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using MODELO;
using System.Windows.Forms;
using System.Data;

namespace BLL
{
    public class BLLReservarLivro
    {
        DALReservarLivros dalReservarLivros = new DALReservarLivros();
        ModeloReservaLivro modeloReservaLivro = new ModeloReservaLivro();

        public void InserirReservaDeLivros(ModeloReservaLivro modeloReservaLivros)
        {
            if (modeloReservaLivros.Id_Livro<= 0)
            {
                MessageBox.Show("O campo Código do Livro Não pode ser Negativo");
            }

            /*if (modeloReservaLivro.Cod_Leitor<=0)
            {
                MessageBox.Show("O campo Código do Leitor Não pode ser Negativo");
            }*/

            dalReservarLivros.Inserir(modeloReservaLivros);
        }

        public DataTable ListarTodosLivrosReservados()
        {
            return dalReservarLivros.Localizar();
        }
    }
}
