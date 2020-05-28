using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmCadastroEmprestimo : Form
    {
        public int CodigoFuncionario;
        public  string NomeUsuarioLogado;

        public FrmCadastroEmprestimo( string usuario, int codigoFuncionario)
        {
            InitializeComponent();

            this.NomeUsuarioLogado = usuario;
            this.CodigoFuncionario = codigoFuncionario;
            this.lblNomeFuncionario.Text = this.NomeUsuarioLogado.ToUpper();
        }

        private void FrmCadastroEmprestimo_Load(object sender, EventArgs e)
        {
            
        }

        private void btAdicionarLivrosEmprestimo_Click(object sender, EventArgs e)
        {
            if (txtCodLeitor.Text!="" && txtCodLivro.Text!="" && dt_DataEmprestimo.Text!="" && dtDataDevolucao.Text!="")
            {
              dgvListaIntesEmprestimo.Rows.Add(txtCodLeitor.Text, txtCodLivro.Text,lblTituloDoLivro.Text,dtDataDevolucao.Text);
            }
        }

        private void btRealizarEmprestimo_Click(object sender, EventArgs e)
        {

        }

    }
}
