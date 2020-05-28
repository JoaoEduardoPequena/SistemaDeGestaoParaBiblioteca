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
    public class BLLBibliotecario
    {
        DALBibliotecarios dalBibliotecario = new DALBibliotecarios();

        public void InserirBibliotecario(ModeloBibliotecarios modeloBibliotecario)
        {
            if (modeloBibliotecario.Nome.Trim().Length == 0)
            {
                throw new Exception("O Preenchimento do campo Nome é Obrigatório");
            }

            if (modeloBibliotecario.Usuario.Trim().Length == 0)
            {
                throw new Exception("O Preenchimento do campo Usuário é Obrigatório");
            }

            if (modeloBibliotecario.Senha.Trim().Length == 0)
            {
                throw new Exception("O Preenchimento do campo Senha é Obrigatório");
            }
            
            /* VALIDAR CAMPO E_MAIL*/
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
                + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
                + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modeloBibliotecario.Email.ToLower() ))
            {
                throw new Exception("Digite um email válido.");
            }

            if (modeloBibliotecario.Telefone<=0)
            {
                throw new Exception("O Preenchimento do campo Telefone é Obrigatório");
            }

            if (modeloBibliotecario.Funcao.ToUpper().Length==0)
            {
                throw new Exception("O Preenchimento do campo Perfil é Obrigatório");
            }

            dalBibliotecario.Inserir(modeloBibliotecario);
        }

        public ModeloBibliotecarios CarregaModeloBibliotecariosPeloCodigo(int codigo)
        {
            return dalBibliotecario.CarregaModeloBibliotecariosPorCodigo(codigo);
        }

        public ModeloBibliotecarios VerificarLoginBibliotecario(string usuario, string senha)
        {
          return dalBibliotecario.LoginBibliotecario(usuario,senha);
        }

        public DataTable ListarTodosBibliotecarios()
        {
            return dalBibliotecario.Localizar();
        }

        public DataTable ListarBibliotecariosPeloNome(string nome)
        {
          return dalBibliotecario.LocalizarBibliotecarioPeloNome(nome);
        }

        public void ExcluirBibliotecario(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("Selecione o Código do Usuário antes de excluí-lo.");
            }
            dalBibliotecario.Excluir(codigo);
        }

        public void AlterarBibliotecario(ModeloBibliotecarios modeloBibliotecarios)
        {
            if (modeloBibliotecarios.Id_Bibliotecario <=0)
            {
                throw new Exception("Selecciona o código do funcionario para alteração");
            }

            if (modeloBibliotecarios.Nome.Trim().Length == 0)
            {
                throw new Exception("O Preenchimento do campo Nome é Obrigatório");
            }

            if (modeloBibliotecarios.Usuario.Trim().Length == 0)
            {
                throw new Exception("O Preenchimento do campo Usuário é Obrigatório");
            }

            if (modeloBibliotecarios.Senha.Trim().Length == 0)
            {
                throw new Exception("O Preenchimento do campo Senha é Obrigatório");
            }


            if (modeloBibliotecarios.Telefone <= 0)
            {
                throw new Exception("O Preenchimento do campo Telefone é Obrigatório");
            }

            if (modeloBibliotecarios.Funcao.ToUpper().Length == 0)
            {
                throw new Exception("O Preenchimento do campo Função é Obrigatório");
            }

            /* VALIDAR CAMPO E_MAIL DO FUNCIONÁRIO */
            string stringRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
                + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
                + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(stringRegex);
            if (!re.IsMatch(modeloBibliotecarios.Email.ToLower()) )
            {
                throw new Exception("Digite um email válido.");
            }

            dalBibliotecario.Alterar(modeloBibliotecarios);
        }

    }
}
