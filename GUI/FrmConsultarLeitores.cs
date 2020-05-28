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
    public partial class FrmConsultarLeitores : Form
    {
        BLL_Leitor bll_leitor = new BLL_Leitor();

        public int codigoLeitor=0;
        
        public FrmConsultarLeitores()
        {
            InitializeComponent();
        }

        private void ActualizarGrid()
        {
            dgvDadosLeitores.DataSource = bll_leitor.ListarTodosLeitores();
        }

        private void dgvDadosLeitores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                this.codigoLeitor = Convert.ToInt32(dgvDadosLeitores.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void FrmConsultarLeitores_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if ( !string.IsNullOrEmpty(txtPesquisar.Text) )
            {
                dgvDadosLeitores.DataSource = bll_leitor.ListarLeitorPeloNome(txtPesquisar.Text);
            }

            else
            {
                ActualizarGrid();
            }

        }

    }
}
