namespace GUI
{
    partial class FrmConsultaEditoras
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
            this.dgvDadosEditoras = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosEditoras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDadosEditoras
            // 
            this.dgvDadosEditoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosEditoras.Location = new System.Drawing.Point(20, 63);
            this.dgvDadosEditoras.MultiSelect = false;
            this.dgvDadosEditoras.Name = "dgvDadosEditoras";
            this.dgvDadosEditoras.ReadOnly = true;
            this.dgvDadosEditoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosEditoras.Size = new System.Drawing.Size(457, 225);
            this.dgvDadosEditoras.TabIndex = 0;
            this.dgvDadosEditoras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDadosEditoras_CellDoubleClick);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(241, 26);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(236, 20);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informe o Nome da Editora Para Pesquisar";
            // 
            // FrmConsultaEditoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(496, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dgvDadosEditoras);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaEditoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Editoras";
            this.Load += new System.EventHandler(this.FrmConsultaEditoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosEditoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvDadosEditoras;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;

    }
}