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
    public partial class FrmCadastroBibliotecarios : Form
    {
        ModeloBibliotecarios modeloBibliotecario = new ModeloBibliotecarios();
        BLLBibliotecario bllBibliotecario = new BLLBibliotecario();

        public string FuncionarioLogado;

        public FrmCadastroBibliotecarios(string funcaoBibliotecario)
        {
            InitializeComponent();

            this.FuncionarioLogado = funcaoBibliotecario;
        }

        private void LimpaTela()
        {
          txtCodBibliotecario.Clear();
          txtNomeBibliotecario.Clear();
          txtUsuarioBibliotecario.Clear();
          txtSenhaBibliotecario.Clear();
          
          txtEmail_Bibliotecario.Clear();
          mskTelefoneBibliotecario.Clear();
          cboFuncaoBibliotecario.Text = "";
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                modeloBibliotecario.Nome = txtNomeBibliotecario.Text;
                modeloBibliotecario.Usuario = txtUsuarioBibliotecario.Text;
                modeloBibliotecario.Senha = txtSenhaBibliotecario.Text;
                modeloBibliotecario.Email = txtEmail_Bibliotecario.Text.ToLower();

                mskTelefoneBibliotecario.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                modeloBibliotecario.Telefone = Convert.ToInt32(mskTelefoneBibliotecario.Text);

                modeloBibliotecario.Funcao = cboFuncaoBibliotecario.Text.ToUpper();

                if (txtCodBibliotecario.Text.Length <= 0)
                {
                    //Inserir
                    bllBibliotecario.InserirBibliotecario(modeloBibliotecario);

                    txtCodBibliotecario.Text = Convert.ToString(modeloBibliotecario.Id_Bibliotecario);
                    LimpaTela();
                    MessageBox.Show("Registro Inseridos Com Sucesso","Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeBibliotecario.Focus();
                }

                else
                {    // Alterar
                    bllBibliotecario.AlterarBibliotecario(modeloBibliotecario);
                    LimpaTela();
                    MessageBox.Show("Registro Actualizado Com Sucesso", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeBibliotecario.Focus();
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                txtNomeBibliotecario.Focus();
            }

        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConsultarBibliotecarios f = new FrmConsultarBibliotecarios(FuncionarioLogado);
                f.ShowDialog();
                if (f.codigoBibliotecario != 0)
                {
                    modeloBibliotecario = bllBibliotecario.CarregaModeloBibliotecariosPeloCodigo(f.codigoBibliotecario);
                    txtCodBibliotecario.Text = modeloBibliotecario.Id_Bibliotecario.ToString();
                    txtNomeBibliotecario.Text = modeloBibliotecario.Nome.ToString();
                    txtUsuarioBibliotecario.Text = modeloBibliotecario.Usuario.ToString();
                    txtSenhaBibliotecario.Text = modeloBibliotecario.Senha.ToString();

                    txtEmail_Bibliotecario.Text = modeloBibliotecario.Email.ToString();
                    mskTelefoneBibliotecario.Text = modeloBibliotecario.Telefone.ToString();
                    cboFuncaoBibliotecario.Text = modeloBibliotecario.Funcao.ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            txtNomeBibliotecario.Focus();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodBibliotecario.Text.Length <=0)
            {
                MessageBox.Show("O código do Bibliotecário(a) deve ser informado antes da exclusão");
                txtNomeBibliotecario.Focus();
            }

            if (txtCodBibliotecario.Text.Length > 0)
            {
                DialogResult resposta = MessageBox.Show("Tens Certeza que pretendes Eliminar este Registro?","PERGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == resposta)
                {
                    int CodBibliotecario = int.Parse(txtCodBibliotecario.Text);
                    bllBibliotecario.ExcluirBibliotecario(CodBibliotecario);
                    LimpaTela();
                    MessageBox.Show("Registro Eliminado Com Sucesso","Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeBibliotecario.Focus();
                }

                else
                {
                    MessageBox.Show("Operação Cancelada pelo Utilizador");
                    LimpaTela();
                    txtNomeBibliotecario.Focus();
                }
            }
        }

        private void FrmCadastroBibliotecarios_Load(object sender, EventArgs e)
        {

        }

    }
}
