using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using BLL;
using MODELO;

namespace GUI
{
    public partial class FrmCadastroLivros : Form
    {
        public int CodigoLivro;
        BLLLivro bllLivro = new BLLLivro();
        ModeloLivro modeloLivro = new ModeloLivro();

        BLLAutor bllAutor = new BLLAutor();
        ModeloAutor modeloAutor = new ModeloAutor();

        BLLEditora bllEditora = new BLLEditora();
        ModeloEditora modeloEditora = new ModeloEditora();

        public string foto = "";

        public FrmCadastroLivros()
        {
            InitializeComponent();
        }

        private void LimpaTela()
        {
            txtCodLivro.Clear();
            txtTituloLivro.Clear();

            txtCodigoAutor.Clear();
            txtNomeAutor.Clear();

            txtCodigoEditora.Clear();
            txtNomeEditora.Clear();
            txtNumeroEdicao.Clear();
            txtNumerosExemplar.Clear();
            txtNumeroEstante.Clear();

            this.foto = "";
            pictureBox_CapaLivro.Image = null;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                modeloLivro.Id_Autor = int.Parse(txtCodigoAutor.Text);
                modeloLivro.Id_Editora = int.Parse(txtCodigoEditora.Text);
                modeloLivro.Titulo = txtTituloLivro.Text;
                modeloLivro.Edicao = txtNumeroEdicao.Text;
                modeloLivro.Estante_Numero = int.Parse(txtNumeroEstante.Text);
                modeloLivro.numExemplaresLivro = int.Parse(txtNumerosExemplar.Text);

                if (txtCodLivro.Text.Length <= 0)
                {
                    // Inserir
                    modeloLivro.CarregaImagem(this.foto);
                    bllLivro.InserirLivros(modeloLivro);
                    LimpaTela();
                    MessageBox.Show("Registro Inserido Com Sucesso");
                    txtTituloLivro.Focus();
                }

                else
                {
                    // Alterar
                    modeloLivro.Id_Livro = int.Parse(txtCodLivro.Text);
                    if (this.foto == "Foto na Memoria do PC")
                    {
                        modeloLivro = bllLivro.CarregaModeloLivrosPorCodigo(modeloLivro.Id_Livro);
                        modeloLivro.Foto = modeloLivro.Foto;
                    }
                    else
                    {
                        modeloLivro.CarregaImagem(this.foto);
                    }
                  
                    bllLivro.AlterarLivro(modeloLivro);
                    LimpaTela();
                    MessageBox.Show("Registro Actualizado Com Sucesso");
                    txtTituloLivro.Focus();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void txtCodigoAutor_Leave(object sender, EventArgs e)
        {
            try
            {
                int codigoAutor = int.Parse(txtCodigoAutor.Text);
                if (codigoAutor != 0)
                {
                    modeloAutor = bllAutor.CarregaModeloAutoresPorCodigo(codigoAutor);
                    txtCodigoAutor.Text = modeloAutor.Id_Autor.ToString();
                    txtNomeAutor.Text = modeloAutor.Nome_Autor.ToString();
                }
                else if (codigoAutor == 0 && txtCodigoAutor.Text == "")
                {
                    txtNomeAutor.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btBuscarAutores_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConsultarAutores f = new FrmConsultarAutores();
                f.ShowDialog();
                if (f.codigo!= 0)
                {
                    txtCodigoAutor.Text = f.codigo.ToString();
                    txtCodigoAutor_Leave(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btBuscarEditora_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConsultaEditoras f = new FrmConsultaEditoras();
                f.ShowDialog();
                if (f.codigo != 0)
                {
                    txtCodigoEditora.Text = f.codigo.ToString();
                    txtCodigoEditora_Leave(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
            
        }

        private void txtCodigoEditora_Leave(object sender, EventArgs e)
        {
            try
            {
                int codigoEditora = Convert.ToInt32(txtCodigoEditora.Text);
                if (codigoEditora != 0)
                {
                    modeloEditora = bllEditora.CarregaModeloEditoraPorCodigo(codigoEditora);
                    txtCodigoEditora.Text = modeloEditora.Cod_Ed.ToString();
                    txtNomeEditora.Text = modeloEditora.Nome_Ed.ToString();
                }

                else if (txtCodigoAutor.Text == "")
                {
                    txtNomeEditora.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ConsultarCodigoDeAutor_E_Editora()
        {
            try
            {
                FrmConsultarLivros f = new FrmConsultarLivros();
                if (f.codigoLivro != 0)
                {
                    modeloAutor = bllAutor.CarregaModeloAutoresPorCodigo(f.codigoLivro);
                    txtNomeAutor.Text = modeloAutor.Nome_Autor.ToString();

                    modeloEditora = bllEditora.CarregaModeloEditoraPorCodigo(f.codigoLivro);
                    txtNomeEditora.Text = modeloEditora.Nome_Ed.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            FrmConsultarLivros f = new FrmConsultarLivros();
            f.ShowDialog();
            if (f.codigoLivro!=0)
            {
                //Modelo Livro
                modeloLivro = bllLivro.CarregaModeloLivrosPorCodigo(f.codigoLivro);
                txtCodigoAutor.Text = Convert.ToString(modeloLivro.Id_Autor);
                txtCodigoEditora.Text = Convert.ToString(modeloLivro.Id_Editora);
                txtCodLivro.Text = Convert.ToString(modeloLivro.Id_Livro);
                txtTituloLivro.Text = Convert.ToString(modeloLivro.Titulo);
                txtNumeroEdicao.Text = Convert.ToString(modeloLivro.Edicao);
                txtNumeroEstante.Text = Convert.ToString(modeloLivro.Estante_Numero);
                txtNumerosExemplar.Text = Convert.ToString(modeloLivro.numExemplaresLivro);

             //________________________________________________________________________________________________________________

                // Modelo Autor - Pega o codigo do Autor que está sendo passado no momento, e coloca o seu dado no  txtNomeAutor
                modeloAutor = bllAutor.CarregaModeloAutoresPorCodigo(modeloLivro.Id_Autor);
                txtNomeAutor.Text = modeloAutor.Nome_Autor.ToString();

                //Modelo Editora - Pega o codigo da editora que está sendo passado no momento, e coloca o seu dado no  txtNomeEditora
                modeloEditora = bllEditora.CarregaModeloEditoraPorCodigo(modeloLivro.Id_Editora);
                txtNomeEditora.Text = modeloEditora.Nome_Ed.ToString();

                try
                {
                    // Carrega a imagem que está na Memoria do computador
                    MemoryStream ms = new MemoryStream(modeloLivro.Foto);
                    pictureBox_CapaLivro.Image = Image.FromStream(ms);
                    this.foto = "Foto na Memoria do PC";
                }
                catch { } 
                       
            }
        }

        private void btAdicionarImagem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            // Se a negação do openFileDialog1.FileName for verdade, ou seja se o openFileDialog1.FileName for nulo ou vázio
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                this.foto = openFileDialog1.FileName;
                pictureBox_CapaLivro.Load(this.foto);
            }
        }

        private void btRemoverImagem_Click(object sender, EventArgs e)
        {
            this.foto = "";
            pictureBox_CapaLivro.Image = null;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            txtTituloLivro.Focus();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodLivro.Text.Length == 0)
                {
                    MessageBox.Show(" O Código do Livro deve ser informado antes da exclusão");
                    txtTituloLivro.Focus();
                    return;
                }

                if (txtCodLivro.Text.Length > 0)
                {
                    DialogResult resposta = MessageBox.Show("Tens Certeza que pretendes Eliminar este Registro?", "PERGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == resposta)
                    {
                        int codigoLivro = int.Parse(txtCodLivro.Text);
                        bllLivro.ExcluirLivro(codigoLivro);
                        LimpaTela();
                        MessageBox.Show("Registro Eliminado Com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTituloLivro.Focus();
                    }

                    else
                    {
                        MessageBox.Show("Operação Cancelada pelo Utilizador");
                        LimpaTela();
                        txtTituloLivro.Focus();
                    }
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void btExibirRelatorio_Click(object sender, EventArgs e)
        {
            if (txtCodLivro.Text.Length!=0)
            {
                CodigoLivro = int.Parse(txtCodLivro.Text);
                //FrmRelatorioPeloCodigoLivro f = new FrmRelatorioPeloCodigoLivro(CodigoLivro);
                //f.ShowDialog();
            }
            else
            {
              MessageBox.Show("Para Exibir o relatório é necessário clicar no botão localizar","Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
              return;
            }

        }

        private void FrmCadastroLivros_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmCadastroLivros_KeyDown(object sender, KeyEventArgs e)
        {
            /* Para substituir a tecla TAB pelo ENTER
             Primeiro modifique a propriedade KeyPreview para True.
             No evento KeyDown*/ 
            if (e.KeyCode == Keys.Return)
            {
                SelectNextControl(this.ActiveControl, true, false, false, true);
            }
        }

        private void FrmCadastroLivros_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair", this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            { 
                e.Cancel = true;
            }
        }

    }
}
