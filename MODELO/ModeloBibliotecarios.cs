using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloBibliotecarios
    {
        public int Id_Bibliotecario { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Numero_BI { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public string Funcao { get; set; }
        public byte[] Foto { get; set; }

        public void CarregaImagem(string caminhoImagem)
        {
            try
            {
                if (caminhoImagem != "")
                {
                    FileInfo fileIfon = new FileInfo(caminhoImagem);
                    FileStream fileStream = new FileStream(caminhoImagem, FileMode.Open, FileAccess.Read, FileShare.Read);
                    this.Foto = new byte[Convert.ToInt32(fileIfon.Length)];
                    int iByteReader = fileStream.Read(this.Foto, 0, Convert.ToInt32(fileIfon.Length));
                    fileStream.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


    }
}
