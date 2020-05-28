using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MODELO
{
    public class ModeloLivro
    {
        public int Id_Livro { get; set; }
        public int Id_Editora { get; set; }
        public int Id_Autor { get; set; }
        public string Titulo { get; set; }
        public string Edicao { get; set; }
        public byte[] Foto { get; set; }
        public int numExemplaresLivro{ get; set; }
        public int Estante_Numero{ get; set; }
        public int totaDisponivelExemplar{ get; set; }

       /* public ModeloLivro( )
        {
            this.Id_Livro = 0;
            this.Id_Editora =0;
            this.Id_Autor=0;
            this.Titulo = "";
            this.Edicao = "";
            // foto nula vector na existe
        }*/

        /*public ModeloLivro(int id_livro, int id_editora,int id_autor, string titulo_livro, string numero_edicao,string foto)
        {
            this.Id_Livro = id_livro;
            this.Id_Editora = id_editora;
            this.Id_Autor= id_autor;
            this.Titulo = titulo_livro;
            this.Edicao = numero_edicao;
            // Carrega Imagem e passar o caminho da imagem dentro da construtora do metodo CarregaImagem
            this.CarregaImagem(foto);
        }*/


       /* public ModeloLivro(int id_livro, int id_editora, int id_autor, string titulo_livro, string numero_edicao, byte[] foto)
        {
            this.Id_Livro = id_livro;
            this.Id_Editora = id_editora;
            this.Id_Autor = id_autor;
            this.Titulo = titulo_livro;
            this.Edicao = numero_edicao;
            this.Foto = foto;
        }*/

        // Metodo Para Carregar Imagem
        public void CarregaImagem(string caminhoImagem)
        {
            try
            {
                if (caminhoImagem!="")
                {
                    FileInfo fileIfon = new FileInfo(caminhoImagem);
                    FileStream fileStream = new FileStream(caminhoImagem, FileMode.Open, FileAccess.Read, FileShare.Read);
                    this.Foto = new byte [Convert.ToInt32(fileIfon.Length)];// Converter o tamanho do arquivo neste caso a imagem em byte
                    int iByteReader = fileStream.Read(this.Foto, 0, Convert.ToInt32(fileIfon.Length));
                    fileStream.Close();
                }
            }
            catch (Exception ex)
            {
              throw new Exception (ex.Message.ToString());
            }
        }
    }
}
