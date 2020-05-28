using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using System.IO.Ports;
//using System.IO;
//using System.IO.Ports.SerialPort;

using BLL;
using MODELO;


namespace GUI
{
    
    public partial class FrmMenuAcessoPrincipal : Form
    {
        public int CodigoBibliotecario;
        public string LogadoBibliotecario,FuncaoBibliotecario;
        //SerialPort porta = new SerialPort();

        public FrmMenuAcessoPrincipal(string usuario, string funcaoBibliotecario, int codBibliotecario)
        {
            InitializeComponent();

            if (usuario!="" && funcaoBibliotecario!= "")
            {
                this.LogadoBibliotecario = usuario;
                this.FuncaoBibliotecario = funcaoBibliotecario;
                this.CodigoBibliotecario = codBibliotecario;
                toolStripStatusLabel_NomeUsuarioLogad.Text = this.LogadoBibliotecario.ToUpper();
            }

        }

        private void FrmMenuAcessoPrincipal_Load(object sender, EventArgs e)
        {
            // Evento Timer para controlar a data e a hora
            timer1_Tick(sender, e); 
        }

        private void editoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FuncaoBibliotecario == "ADMINISTRADOR")
            {
                FrmCadastroEditora frmCadastroEditora = new FrmCadastroEditora();
                //frmCadastroEditora.MdiParent = this;
                frmCadastroEditora.ShowDialog();
            }

            else
            {
                MessageBox.Show("Utilizador: " + LogadoBibliotecario.ToUpper() + "\n"+" Você Não tens Acesso a esta Area. Esta Area é restrito somentea para o ADMINISTRADOR do Sistema", "AVISO");
            }

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;
            DateTime hora = DateTime.Now;

            lblData.Text = data.ToShortDateString();
            lblHora.Text = hora.ToLongTimeString();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FuncaoBibliotecario == "ADMINISTRADOR")
            {
                FrmCadastroBibliotecarios frmCadastroBibliotecarios = new FrmCadastroBibliotecarios(FuncaoBibliotecario);
                frmCadastroBibliotecarios.ShowDialog();
            }

            else
            {
                MessageBox.Show("Utilizador: " + LogadoBibliotecario.ToUpper() + "\n"+" Você Não tens Acesso a esta Area.Esta area é restrito somente para os Administradores do sistema", "AVISO");
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        { // Cadastro de funcionarios 
            funcionariosToolStripMenuItem_Click(sender, e);
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FuncaoBibliotecario == "ADMINISTRADOR")
            {
                FrmCadastroAutores frmCadastroAutor = new FrmCadastroAutores();
                frmCadastroAutor.ShowDialog();
            }

            else
            {
                MessageBox.Show("Utilizador: " + LogadoBibliotecario.ToUpper() + "\n" + " Você Não tens Acesso a esta Area. Esta Area é restrito somentea para o ADMINISTRADOR do Sistema", "AVISO");
            }
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FuncaoBibliotecario == "ADMINISTRADOR")
            {
                FrmCadastroLivros frmCadastroLivro = new FrmCadastroLivros();
                frmCadastroLivro.ShowDialog();
            }

            else
            {
                MessageBox.Show("Utilizador: " + LogadoBibliotecario.ToUpper() + "\n" + " Você Não tens Acesso a esta Area. Esta Area é restrito somentea para o ADMINISTRADOR do Sistema", "AVISO");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {   //Cadastro de Livros 
            livroToolStripMenuItem_Click(sender, e);
        }

        private void leitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroLeitores frmCadastroLeitor = new FrmCadastroLeitores();
            frmCadastroLeitor.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {    //Cadastro de Leitores
            leitoresToolStripMenuItem_Click(sender, e);
        }

        private void editoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaEditoras frmConsultaEditoras = new FrmConsultaEditoras();
            frmConsultaEditoras.ShowDialog();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarAutores frmConsultarAutores = new FrmConsultarAutores();
            frmConsultarAutores.ShowDialog();
        }

        private void livroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultarLivros frmConsultarLivros = new FrmConsultarLivros();
            frmConsultarLivros.ShowDialog();
        }

        private void leitoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultarLeitores frmConsultarLeitores = new FrmConsultarLeitores();
            frmConsultarLeitores.ShowDialog();
        }

        private void funcionariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          FrmConsultarBibliotecarios frmConsultarBibliotecarios = new FrmConsultarBibliotecarios(FuncaoBibliotecario);
          frmConsultarBibliotecarios.ShowDialog();
        }

        private void efectuarReservaDeLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          FrmCadastrarReservarLivros frmCadastrarReservarLivros = new FrmCadastrarReservarLivros();
          frmCadastrarReservarLivros.ShowDialog();
        }

        private void efectuarEmprestimoDeLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroEmprestimo frmCadastroEmprestimo = new FrmCadastroEmprestimo(this.LogadoBibliotecario,this.CodigoBibliotecario);
            frmCadastroEmprestimo.ShowDialog();
        }

        private void efectuarDevoluçãoDeLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroDevolucao frmCadastroDevolucao = new FrmCadastroDevolucao();
            frmCadastroDevolucao.ShowDialog();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            // Efectuar Reservas de Livros
            efectuarReservaDeLivrosToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            // Efectuar Emprestimo de Livros
            efectuarEmprestimoDeLivrosToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            // Efectuar Devolução de Livros
            efectuarDevoluçãoDeLivrosToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tens Certeza Que Pretendes Sair da Aplicação?", "PERGUNTA ?", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }

            else
            {
                MessageBox.Show("Operação Cancelada Pelo Utilizador", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmRelatorioDeLivrosCadastrados f = new FrmRelatorioDeLivrosCadastrados();
            //f.ShowDialog();
        }

        private void eNVIARSMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEnviarSMS frmEnviarSMS = new FrmEnviarSMS();
            frmEnviarSMS.ShowDialog();
        }

        private void relatórioSimplesDeLivroCadastradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmRelatorioPeloCodigoLivro f = new FrmRelatorioPeloCodigoLivro();
            //f.ShowDialog();
        }

        private void FrmMenuAcessoPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desejas Realmente Sair da Aplicação?", "Mensagem de Confirmação",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        
    }
}
