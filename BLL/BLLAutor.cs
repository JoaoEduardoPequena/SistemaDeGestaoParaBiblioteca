using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MODELO;
using DAL;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public class BLLAutor
    {
        DALAutores dalAutores = new DALAutores();

        public void InserirAutores(ModeloAutor modeloAutores)
        {
            if (modeloAutores.Nome_Autor.Trim().Length == 0)
            {
                throw new Exception("O campo Nome do Autor é Obrigatório");
            }

            dalAutores.Inserir(modeloAutores);
        }

        public DataTable ListarTodosAutores()
        {
            return dalAutores.Localizar();
        }

        public ModeloAutor CarregaModeloAutoresPorCodigo(int codigo)
        {
            return dalAutores.CarregaModeloAutores(codigo);
        }

        public DataTable ListarAutoresPorNome(string nomeAutor)
        {
          return dalAutores.LocalizarAutoresPorNome(nomeAutor);
        }

        public void ExcluirAutor(int codigo)
        {
            if (codigo<=0)
            {
              throw new Exception("Selecione um Autor antes de excluí-lo.");
            }

           dalAutores.Excluir(codigo);
        }

        public void AlterarAutor(ModeloAutor modeloAutor)
        {
            dalAutores.Alterar(modeloAutor);
        }

    }
}
