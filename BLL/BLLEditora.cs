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
    public class BLLEditora
    {
        DALEditora dalEditora = new DALEditora();

        public void InserirEditora(ModeloEditora modeloEditoras)
        {
            if (modeloEditoras.Nome_Ed.Trim().Length==0)
            {
                throw new Exception("O campo Nome da Editora é obrigatório");
            }

            dalEditora.Inserir(modeloEditoras);
        }

        public DataTable ListarTodasEditoras()
        {
            return dalEditora.Localizar();
        }

        public DataTable ListarEditoraPorNome(string nomeEditora)
        {
          return dalEditora.LocalizarEditorasPorNome(nomeEditora);
        }

        public ModeloEditora CarregaModeloEditoraPorCodigo(int codigo)
        {
            return dalEditora.CarregaModeloEditora(codigo);
        }

        public void AlterarEditora(ModeloEditora modeloEditoras)
        {
            dalEditora.Alterar(modeloEditoras);
        }

        public void ExcluirEditora(int codigo)
        {
            dalEditora.Excluir(codigo);
        }
    }
}
