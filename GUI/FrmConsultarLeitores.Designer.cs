namespace GUI
{
    partial class FrmConsultarLeitores
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dgvDadosLeitores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosLeitores)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Informe o nome do Leitor para Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(249, 60);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(461, 20);
            this.txtPesquisar.TabIndex = 34;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // dgvDadosLeitores
            // 
            this.dgvDadosLeitores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosLeitores.Location = new System.Drawing.Point(14, 100);
            this.dgvDadosLeitores.MultiSelect = false;
            this.dgvDadosLeitores.Name = "dgvDadosLeitores";
            this.dgvDadosLeitores.ReadOnly = true;
            this.dgvDadosLeitores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosLeitores.Size = new System.Drawing.Size(709, 271);
            this.dgvDadosLeitores.TabIndex = 36;
            this.dgvDadosLeitores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDadosLeitores_CellDoubleClick);
            // 
            // FrmConsultarLeitores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 383);
            this.Controls.Add(this.dgvDadosLeitores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesquisar);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmConsultarLeitores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Leitores";
            this.Load += new System.EventHandler(this.FrmConsultarLeitores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosLeitores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dgvDadosLeitores;
    }
}