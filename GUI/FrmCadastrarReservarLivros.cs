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
    public partial class FrmCadastrarReservarLivros : Form
    {
        ModeloLeitores modeloLeitor = new ModeloLeitores();
        BLL_Leitor bll_Leitor = new BLL_Leitor();

        ModeloReservaLivro modeloReservaLivros = new ModeloReservaLivro();
        BLLReservarLivro bllReservarLivros = new BLLReservarLivro();

        public FrmCadastrarReservarLivros()
        {
            InitializeComponent();
        }

        private void btAdicionarLivroParaReservar_Click(object sender, EventArgs e)
        {
            if (txtCodigoLeitor.Text != "" && txtCodigoLivro.Text != "")
            {
              dgvListaLivrosReservados.Rows.Add(txtCodigoLeitor.Text,txtCodigoLivro.Text,lblTituloLivro.Text,dtDataLimiteReserva.Text);

              txtCodigoLivro.Clear();
              lblTituloLivro.Text = "Digita o Código do Livro ou clica no botão Localizar";  
            }
        }

        private void dgvListaLivrosReservados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Remove o index da linha actual do dagridview - dgvListaLivrosReservados
            dgvListaLivrosReservados.Rows.RemoveAt(e.RowIndex); 
        }

        private void txtCodigoLeitor_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCodigoLeitor.Text))
                {
                    modeloLeitor = bll_Leitor.CarregaModeloLeitorPorCodigo(int.Parse(txtCodigoLeitor.Text));
                    lblNomeLeitor.Text = Convert.ToString(modeloLeitor.Nome);
                    //if (lblNomeLeitor.Text !="" || lblNomeLeitor.Text != null)
                    //{
                    //    String nomeLeitor = lblNomeLeitor.Text;
                    //}
                    //else
                    //{
                    //    MessageBox.Show("O código do Leitor informado não existe", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    this.lblNomeLeitor.Text = "Digita o Código do Leitor ou clica no botão Localizar";
                    //}
                    
                }

                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btEfectuarReserva_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvListaLivrosReservados.RowCount; i++)
            {
                modeloReservaLivros.Cod_Leitor = Convert.ToInt32(dgvListaLivrosReservados.Rows[i].Cells[0].Value);
                modeloReservaLivros.Id_Livro = Convert.ToInt32(dgvListaLivrosReservados.Rows[i].Cells[1].Value);
                //modeloReservaLivros.Data_Reserva = Convert.ToDateTime(dgvListaLivrosReservados.Rows[i].Cells[2].Value);
                modeloReservaLivros.Data_Limite = Convert.ToDateTime(dgvListaLivrosReservados.Rows[i].Cells[3].Value);
                modeloReservaLivros.Estado_Reserva = "Livro Reservado";

                bllReservarLivros.InserirReservaDeLivros(modeloReservaLivros);
                MessageBox.Show("Reservas de Livros Efectuada Com Sucesso");
            }

        }

        private void btLocalizarReserva_Click(object sender, EventArgs e)
        {
            FrmConsultarLivrosReservados frmConsultarLivrosReservado = new FrmConsultarLivrosReservados();
            frmConsultarLivrosReservado.ShowDialog();
        }

        private void btLocalizarLeitores_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConsultarLeitores f = new FrmConsultarLeitores();
                f.ShowDialog();

                if (f.codigoLeitor !=0)
                {
                    txtCodigoLeitor.Text = f.codigoLeitor.ToString();
                    modeloLeitor = bll_Leitor.CarregaModeloLeitorPorCodigo(f.codigoLeitor);
                    lblNomeLeitor.Text = Convert.ToString(modeloLeitor.Nome);
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            

        }

        private void txtCodigoLeitor_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoLeitor.Text == "" && modeloLeitor==null)
            {
                this.lblNomeLeitor.Text = "Digita o Código do Leitor ou clica no botão Localizar";
            }
            
        }

        private void btLocalizarLivro_Click(object sender, EventArgs e)
        {
            BLLLivro bllLivro = new BLLLivro();
            ModeloLivro modeloLivro = new ModeloLivro();

            FrmConsultarLivros f = new FrmConsultarLivros();

            f.ShowDialog();
            if (f.codigoLivro != 0)
            {
                //Modelo Livro
                modeloLivro = bllLivro.CarregaModeloLivrosPorCodigo(f.codigoLivro);
                lblTituloLivro.Text = Convert.ToString(modeloLivro.Titulo);
                txtCodigoLivro.Text = Convert.ToString(modeloLivro.Id_Livro);
            }
        }

    }
}
