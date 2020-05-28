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
    public partial class FrmConsultarBibliotecarios : Form
    {
        BLLBibliotecario bllBibliotecario = new BLLBibliotecario();
        public int codigoBibliotecario;

        string FuncaoBibliotecario;
      
        public FrmConsultarBibliotecarios( string funcaoBibliotecario)
        {
            InitializeComponent();

            this.FuncaoBibliotecario = funcaoBibliotecario;
        }

        private void DesabilitarCamposDataGrid_Bibliotecarios()
        {
            try
            {
                if (FuncaoBibliotecario == "USUARIO" || FuncaoBibliotecario == "Atendente")
                {
                    dgvDadosBibliotecarios.Columns[2].Visible = false; // Torna invisel o campo senha
                    dgvDadosBibliotecarios.Columns[3].Visible = false; // Torna invisel o campo login
                    dgvDadosBibliotecarios.Columns[6].Visible = false; // Torna invisel o campo perfil

                    dgvDadosBibliotecarios.DataSource = bllBibliotecario.ListarTodosBibliotecarios();
                }

                else if (FuncaoBibliotecario == "ADMINISTRADOR")
                {
                  dgvDadosBibliotecarios.DataSource = bllBibliotecario.ListarTodosBibliotecarios();
                }
            }

            catch (Exception ex)
            {
              MessageBox.Show("Mensgem  de Erro", ex.Message);
            }
            
        }

        private void ActualizarGrid()
        {
            DesabilitarCamposDataGrid_Bibliotecarios();
        }

        private void FrmConsultarBibliotecarios_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPesquisar.Text))
            {
                dgvDadosBibliotecarios.DataSource = bllBibliotecario.ListarBibliotecariosPeloNome(txtPesquisar.Text);
            }

            else
            {
                ActualizarGrid();
            }
        }

        private void dgvDadosBibliotecarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >=0)
                {
                    codigoBibliotecario = Convert.ToInt32(dgvDadosBibliotecarios.Rows[e.RowIndex].Cells[0].Value);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() );
            }
            
        }
    }
}
