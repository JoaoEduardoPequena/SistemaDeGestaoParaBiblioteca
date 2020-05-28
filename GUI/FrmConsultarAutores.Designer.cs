namespace GUI
{
    partial class FrmConsultarAutores
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
            this.dgvDadosAutores = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDadosAutores
            // 
            this.dgvDadosAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosAutores.Location = new System.Drawing.Point(18, 55);
            this.dgvDadosAutores.MultiSelect = false;
            this.dgvDadosAutores.Name = "dgvDadosAutores";
            this.dgvDadosAutores.ReadOnly = true;
            this.dgvDadosAutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosAutores.Size = new System.Drawing.Size(407, 206);
            this.dgvDadosAutores.TabIndex = 0;
            this.dgvDadosAutores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDadosAutores_CellDoubleClick);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(110, 22);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(315, 20);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Autor";
            // 
            // FrmConsultarAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(443, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dgvDadosAutores);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmConsultarAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas de Autores";
            this.Load += new System.EventHandler(this.FrmConsultarAutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvDadosAutores;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;

    }
}