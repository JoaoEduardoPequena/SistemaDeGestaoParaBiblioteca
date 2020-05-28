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
    public partial class FrmConsultarLivrosReservados : Form
    {
        BLLReservarLivro bllReservarLivro = new BLLReservarLivro();

        public FrmConsultarLivrosReservados()
        {
            InitializeComponent();
        }

        private void ActualizarGrid()
        {
          dgvConsultaLivroReservados.DataSource = bllReservarLivro.ListarTodosLivrosReservados(); 
        }

        private void FrmConsultarLivrosReservados_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
    }
}
