using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MODELO;
using BLL;

namespace GUI
{
    public partial class FrmCadastroEditora : Form
    {
        ModeloEditora modeloEditora = new ModeloEditora();
        BLLEditora bllEditora = new BLLEditora();

        public FrmCadastroEditora()
        {
            InitializeComponent();
        }

        private void LimpaTela()
        {
            txtCodEditora.Clear();
            txtNomeEditora.Clear();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                modeloEditora.Nome_Ed = txtNomeEditora.Text;
                if (txtCodEditora.Text.Length <= 0)
                {
                    // Inserir
                    bllEditora.InserirEditora(modeloEditora);
                    txtCodEditora.Text = Convert.ToString(modeloEditora.Cod_Ed);
                    LimpaTela();
                    MessageBox.Show("Registro Inserido Com Sucesso");
                    txtNomeEditora.Focus();
                }
                else
                {
                    // Alterar
                    modeloEditora.Cod_Ed = int.Parse(txtCodEditora.Text);
                    bllEditora.AlterarEditora(modeloEditora);
                    LimpaTela();
                    MessageBox.Show("Registro Actualizado Com Sucesso", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeEditora.Focus();
                }
            }

            catch (Exception erro)
            {
              throw new Exception(erro.Message.ToString());
              txtNomeEditora.Focus();
            }
            
           
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            FrmConsultaEditoras f = new FrmConsultaEditoras();
            f.ShowDialog();
            if (f.codigo!=0)
            {
                modeloEditora = bllEditora.CarregaModeloEditoraPorCodigo(f.codigo);
                txtCodEditora.Text = modeloEditora.Cod_Ed.ToString();
                txtNomeEditora.Text = modeloEditora.Nome_Ed.ToString();
            }
        }

        private void btExcluir_Click_1(object sender, EventArgs e)
        {
            if (txtCodEditora.Text.Length == 0)
            {
                MessageBox.Show("Código da Editora deve ser informado antes da Exclusão");
                txtNomeEditora.Focus();
                return;
            }

            if (txtCodEditora.Text.Length > 0)
            {
                DialogResult resposta = MessageBox.Show("Tens Certeza que pretendes Eliminar este Registro?","PERGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == resposta)
                {
                    int codigoEditora = int.Parse(txtCodEditora.Text);
                    bllEditora.ExcluirEditora(codigoEditora);
                    LimpaTela();
                    MessageBox.Show("Registro Eliminado Com Sucesso");
                    txtNomeEditora.Focus();
                }

                else
                {
                    MessageBox.Show("Operação Cancelada pelo Utilizador","INFORMAÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LimpaTela();
                    txtNomeEditora.Focus();
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            txtNomeEditora.Focus();
        }
    }
}
