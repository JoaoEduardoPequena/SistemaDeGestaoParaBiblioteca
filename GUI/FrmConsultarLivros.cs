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
    public partial class FrmConsultarLivros : Form
    {
        BLLLivro bll_Livro = new BLLLivro();
        
        public int codigoLivro;

        public FrmConsultarLivros()
        {
            InitializeComponent();
        }

        private void ActualizarGrid()
        {
            dgvDadosLivros.DataSource = bll_Livro.ListarTodosLivros();
        }

        private void FrmConsultarLivros_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void dgvDadosLivros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                codigoLivro = Convert.ToInt32(dgvDadosLivros.CurrentRow.Cells[0].Value);
                this.Close();
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text!="")
            {
               dgvDadosLivros.DataSource = bll_Livro.ListarLivroPeloTitulo(txtPesquisar.Text);
            }

            else
            {
               ActualizarGrid();
            }
        }


    }
}
