using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MODELO;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLLivro
    {
        DALLivro dalLivros = new DALLivro();
       
        public void InserirLivros(ModeloLivro modeloLivro)
        {
            if (modeloLivro.Titulo.Trim().Length==0)
            {
                throw new Exception("O campo Titulo do Livro é Obrigatório");
                //System.Windows.Forms.MessageBox.Show("O campo Titulo do Livro é Obrigatório");
            }

            if (modeloLivro.Id_Autor<=0)
            {
                throw new Exception("O campo Código do Autor do Livro é Obrigatório");
            }

            if (modeloLivro.Id_Editora <= 0)
            {
                throw new Exception("O campo Código da Editora do Livro é Obrigatório");
            }

            if (modeloLivro.Edicao.Trim().Length==0)
            {
                throw new Exception("O campo Edição do Livro é Obrigatório");
            }
                
            dalLivros.Inserir(modeloLivro);
        }

        public DataTable ListarTodosLivros()
        {
           return dalLivros.Localizar();
        }

        public DataTable ListarLivroPeloTitulo(string tituloLivro)
        {
          return dalLivros.LocalizarLivroPeloTitulo(tituloLivro);
        }

        public DataTable ListarLivroPeloCodigo(int codigoLivro)
        {
            return dalLivros.LocalizarLivroPeloCodigo(codigoLivro);
        }

        public ModeloLivro CarregaModeloLivrosPorCodigo(int codigo)
        {
           return dalLivros.CarregaModeloLivroPorCodigo(codigo);
        }

        public void ExcluirLivro(int codigoLivro)
        {
           dalLivros.Excluir(codigoLivro);
        }

        public void AlterarLivro( ModeloLivro modeloLivro)
        {
          dalLivros.Alterar(modeloLivro);
        }


    }
}
