using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using MODELO;
using BLL;

namespace GUI
{
    public partial class FrmCadastroAutores : Form
    {
        ModeloAutor modeloAutor = new ModeloAutor();
        BLLAutor bllAutores = new BLLAutor();

        public FrmCadastroAutores()
        {
            InitializeComponent();
        }

        private void LimpaTela()
        {
          txtCodAutor.Clear();
          txtNomeAutores.Clear();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            FrmConsultarAutores f = new FrmConsultarAutores();
            f.ShowDialog();
            if (f.codigo!=0)
            {
                modeloAutor = bllAutores.CarregaModeloAutoresPorCodigo(f.codigo);
                txtCodAutor.Text  = Convert.ToString(modeloAutor.Id_Autor);
                txtNomeAutores.Text = modeloAutor.Nome_Autor.ToString();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                modeloAutor.Nome_Autor = txtNomeAutores.Text;
                if (txtCodAutor.Text.Length <= 0)
                {
                    // Inserir
                    bllAutores.InserirAutores(modeloAutor);
                    txtCodAutor.Text = modeloAutor.Id_Autor.ToString();
                    LimpaTela();
                    MessageBox.Show("Registro Inseridos Com Sucesso");
                    txtNomeAutores.Focus();
                }

                else
                {
                    // Alterar
                    modeloAutor.Id_Autor = int.Parse(txtCodAutor.Text);
                    bllAutores.AlterarAutor(modeloAutor);
                    LimpaTela();
                    MessageBox.Show("Registro Actualizado Com Sucesso","INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeAutores.Focus();
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString() );
                txtNomeAutores.Focus();
            }
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            txtNomeAutores.Focus();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodAutor.Text.Length == 0)
            {
               MessageBox.Show("Código do Autor deve ser informado antes da exclusão");
               txtNomeAutores.Focus();
            }

            if (txtCodAutor.Text.Length > 0)
            {
                DialogResult resposta = MessageBox.Show("Tens Certeza que pretendes Eliminar este Registro?", "PERGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == resposta)
                {
                    int codigoAutor = int.Parse(txtCodAutor.Text);
                    bllAutores.ExcluirAutor(codigoAutor);
                    LimpaTela();
                    MessageBox.Show("Registro Eliminado Com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeAutores.Focus();
                }

                else
                {
                    MessageBox.Show("Operação Cancelada pelo Utilizador");
                    LimpaTela();
                    txtNomeAutores.Focus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
