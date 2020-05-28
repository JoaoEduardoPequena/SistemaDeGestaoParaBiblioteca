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
    public partial class FrmLoginUsuarios : Form
    {
        public int codigoBibliotecario;
        public string Usuario, Senha, funcaoBibliotecario;

        BLLBibliotecario bllBibliotecario = new BLLBibliotecario();
        ModeloBibliotecarios modeloBibliotecarios = new ModeloBibliotecarios();

        public FrmLoginUsuarios()
        {
            InitializeComponent();
        }

        private void LimpaTela()
        {
          txtUsuario.Clear();
          txtSenha.Clear();
        }

        private void LoginBibliotecarios()
        {

            if (txtUsuario.Text == "")
            {
                MessageBox.Show("O campo Usuário está vázio");
                LimpaTela();
                txtUsuario.Focus();
                txtUsuario.BackColor = Color.Red;
                return;
            }

            if (txtSenha.Text == "")
            {
                MessageBox.Show("O campo senha está vázio");
                LimpaTela();
                txtSenha.Focus();
                txtSenha.BackColor = Color.Red;
                return;
            }

              modeloBibliotecarios = bllBibliotecario.VerificarLoginBibliotecario(txtUsuario.Text,txtSenha.Text);
              codigoBibliotecario = Convert.ToInt32(modeloBibliotecarios.Id_Bibliotecario);
              Usuario = Convert.ToString(modeloBibliotecarios.Usuario);
              Senha = Convert.ToString(modeloBibliotecarios.Senha);
              funcaoBibliotecario = Convert.ToString(modeloBibliotecarios.Funcao);
              

            if (txtUsuario.Text == Usuario && txtSenha.Text == Senha)
            {
                FrmMenuAcessoPrincipal frmMenuPrincipal = new FrmMenuAcessoPrincipal(Usuario,funcaoBibliotecario,codigoBibliotecario);
                this.Visible = false;
                frmMenuPrincipal.Show();
            }

            else
            {
                MessageBox.Show("Nome do Usuário  ou a Senha está errada.Por favor Insira os dados correctamente","AVISO");
                LimpaTela();
                txtUsuario.Focus();
            }

        }

        private void btOK_Click(object sender, EventArgs e)
        {
          LoginBibliotecarios();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(" Tens Certeza Que Pretendes Sair da Aplicação?", "PERGUNTA", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }

            else
            {
                MessageBox.Show("Operação Cancelada Pelo Utilizador", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
