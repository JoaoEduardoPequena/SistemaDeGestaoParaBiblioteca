using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using MODELO;

namespace GUI
{
    public partial class FrmCadastroLeitores : Form
    {
        BLL_Leitor bll_Leitor = new BLL_Leitor();
        ModeloLeitores modeloLeitor = new ModeloLeitores();

        public FrmCadastroLeitores()
        {
            InitializeComponent();
        }

        private void LimpaTela()
        {
           txtCodigoLeitor.Clear();
           txtNomeLeitor.Clear();
           txtEmail_Leitor.Clear();
           mskTelefoneLeitor.Clear();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                modeloLeitor.Nome = txtNomeLeitor.Text;
                modeloLeitor.Email = txtEmail_Leitor.Text;

                mskTelefoneLeitor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                modeloLeitor.Telefone = int.Parse(mskTelefoneLeitor.Text);

                if (txtCodigoLeitor.Text.Length <= 0)
                {
                    // Inserir
                    bll_Leitor.InserirLeitor(modeloLeitor);

                    txtCodigoLeitor.Text = modeloLeitor.Id_Leitor.ToString();
                    LimpaTela();
                    MessageBox.Show("Registro Inseridos Com Sucesso");
                    txtNomeLeitor.Focus();
                }

                else
                {
                    // Alterar
                    modeloLeitor.Id_Leitor = int.Parse(txtCodigoLeitor.Text);
                    bll_Leitor.AlterarLeitor(modeloLeitor);
                    LimpaTela();
                    MessageBox.Show("Registro Actualizado Com Sucesso", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeLeitor.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                txtNomeLeitor.Focus();
            }
             
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            FrmConsultarLeitores f = new FrmConsultarLeitores();
            f.ShowDialog();
            if (f.codigoLeitor!=0)
            {
                modeloLeitor = bll_Leitor.CarregaModeloLeitorPorCodigo(f.codigoLeitor);
                txtCodigoLeitor.Text = modeloLeitor.Id_Leitor.ToString();
                txtNomeLeitor.Text = modeloLeitor.Nome.ToString();
                txtEmail_Leitor.Text = modeloLeitor.Email.ToString();
                mskTelefoneLeitor.Text = modeloLeitor.Telefone.ToString();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            txtNomeLeitor.Focus();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigoLeitor.Text.Length == 0)
            {
                MessageBox.Show("Código do Leitor deve ser informado antes da Exclusão");
                txtNomeLeitor.Focus();
                return;
            }

            if (txtCodigoLeitor.Text.Length > 0)
            {
                DialogResult resposta = MessageBox.Show("Tens Certeza que pretendes Eliminar este Registro?", "PERGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == resposta)
                {
                    int codigoLeitor = int.Parse(txtCodigoLeitor.Text);
                    bll_Leitor.ExcluirLeitor(codigoLeitor);
                    LimpaTela();
                    MessageBox.Show("Registro Eliminado Com Sucesso");
                    txtNomeLeitor.Focus();
                }

                else
                {
                    MessageBox.Show("Operação Cancelada pelo Utilizador", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaTela();
                    txtNomeLeitor.Focus();
                }
            }
        }

        private void FrmCadastroLeitores_Load(object sender, EventArgs e)
        {

        }

        private void FrmCadastroLeitores_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair", this.Text,
             MessageBoxButtons.YesNo, MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void FrmCadastroLeitores_KeyDown(object sender, KeyEventArgs e)
        {
            /* Para substituir a tecla TAB pelo ENTER
             Primeiro modifique a propriedade KeyPreview para True.
             No evento KeyDown*/
            if (e.KeyCode == Keys.Return)
            {
                SelectNextControl(this.ActiveControl, true, false, false, true);
            }
        }

    }
}
