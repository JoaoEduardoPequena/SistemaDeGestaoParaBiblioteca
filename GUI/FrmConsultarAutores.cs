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

namespace GUI
{
    public partial class FrmConsultarAutores : Form
    {
        BLLAutor bllAutor = new BLLAutor();

        public int codigo;

        public FrmConsultarAutores()
        {
            InitializeComponent();
        }

        private void ActualizarGrid()
        {
            dgvDadosAutores.DataSource = bllAutor.ListarTodosAutores();
        }

        private void FrmConsultarAutores_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void dgvDadosAutores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0) //Se o index da linha actual e maior ou igual a zero (0)
            {
                codigo = Convert.ToInt32(dgvDadosAutores.CurrentRow.Cells[0].Value.ToString());
                this.Close();
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text!="")
            {
                dgvDadosAutores.DataSource = bllAutor.ListarAutoresPorNome(txtPesquisa.Text);
            }

            else
            {
                ActualizarGrid();
            }

        }
    }
}
