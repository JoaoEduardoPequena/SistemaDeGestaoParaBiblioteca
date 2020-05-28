namespace GUI
{
    partial class FrmConsultarLivrosReservados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvConsultaLivroReservados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaLivroReservados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaLivroReservados
            // 
            this.dgvConsultaLivroReservados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaLivroReservados.Location = new System.Drawing.Point(12, 123);
            this.dgvConsultaLivroReservados.Name = "dgvConsultaLivroReservados";
            this.dgvConsultaLivroReservados.Size = new System.Drawing.Size(787, 318);
            this.dgvConsultaLivroReservados.TabIndex = 0;
            // 
            // FrmConsultarLivrosReservados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 453);
            this.Controls.Add(this.dgvConsultaLivroReservados);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmConsultarLivrosReservados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Livros Reservados";
            this.Load += new System.EventHandler(this.FrmConsultarLivrosReservados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaLivroReservados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaLivroReservados;
    }
}