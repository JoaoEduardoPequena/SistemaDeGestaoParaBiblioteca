using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MODELO;
using DAL;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BLL
{
    public class BLL_Leitor
    {
        DALLeitor dalLeitor = new DALLeitor();
       
        public void InserirLeitor(ModeloLeitores modeloLeitor)
        {
            if (modeloLeitor.Nome.Length == 0)
            {
                throw new Exception("O Preenchimento do campo Nome do Leitor é Obrigatório");
            }

            if (modeloLeitor.Telefone<=0)
            {
                throw new Exception("O Preenchimento do campo telefone é Obrigatório");
            }

            /* VALIDAR CAMPO DE E_MAIL DO LEITOR */
            string stringRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
                + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
                + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(stringRegex);
            if (!re.IsMatch(modeloLeitor.Email))
            {
                throw new Exception("Digite um email válido.");
            }

            modeloLeitor.Email.ToLower();

            dalLeitor.Inserir(modeloLeitor);
        }

        public DataTable ListarTodosLeitores()
        {
            return dalLeitor.Localizar();
        }

        public DataTable ListarLeitorPeloNome(string nomeLeitor)
        {
            return dalLeitor.LocalizarLeitorPeloNome(nomeLeitor);
        }

        public DataTable ListarLeitorPeloCodigo(int codigoLeitor)
        {
            return dalLeitor.LocalizarLeitorPeloCodigo(codigoLeitor);
        }

        public ModeloLeitores CarregaModeloLeitorPorCodigo(int codigo)
        {
            if (codigo<=0)
            {
                throw new Exception("O código do Leitor informado não pode ser negativo ou igual a Zero");
            }

            return dalLeitor.CarregaModeloLeitorPorCodigo(codigo);
        }

        public void ExcluirLeitor(int codigoLeitor)
        {
            dalLeitor.Excluir(codigoLeitor);
        }

        public void AlterarLeitor(ModeloLeitores modeloLeitor)
        {
            if (modeloLeitor.Nome.Length == 0)
            {
                throw new Exception("O Preenchimento do campo Nome do Leitor é Obrigatório");
            }

            if (modeloLeitor.Telefone <= 0)
            {
                throw new Exception("O Preenchimento do campo Telefone é Obrigatório");
            }

            dalLeitor.Alterar(modeloLeitor);
        }

    }
}
