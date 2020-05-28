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
    public partial class FrmConsultaEditoras : Form
    {
        BLLEditora bllEditora = new BLLEditora();

        public int codigo;

        public FrmConsultaEditoras()
        {
            InitializeComponent();
        }

        private void ActualizarGrid()
        {
            dgvDadosEditoras.DataSource = bllEditora.ListarTodasEditoras();
        }

        private void dgvDadosEditoras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                codigo = Convert.ToInt32(dgvDadosEditoras.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void FrmConsultaEditoras_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text!="")
            {
                dgvDadosEditoras.DataSource=bllEditora.ListarEditoraPorNome(txtPesquisar.Text);
            }

            else
            {
                ActualizarGrid();
            }
        }
    }
}
