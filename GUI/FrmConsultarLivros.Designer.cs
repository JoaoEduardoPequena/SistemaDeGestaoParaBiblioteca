namespace GUI
{
    partial class FrmConsultarLivros
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
            this.dgvDadosLivros = new System.Windows.Forms.DataGridView();
            this.codLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroEdicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto_livro = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDadosLivros
            // 
            this.dgvDadosLivros.AllowUserToAddRows = false;
            this.dgvDadosLivros.AllowUserToDeleteRows = false;
            this.dgvDadosLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codLivro,
            this.titulo_livro,
            this.codAutor,
            this.cod_editora,
            this.numeroEdicao,
            this.estante,
            this.exemplar,
            this.foto_livro});
            this.dgvDadosLivros.Location = new System.Drawing.Point(6, 104);
            this.dgvDadosLivros.MultiSelect = false;
            this.dgvDadosLivros.Name = "dgvDadosLivros";
            this.dgvDadosLivros.ReadOnly = true;
            this.dgvDadosLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosLivros.Size = new System.Drawing.Size(878, 289);
            this.dgvDadosLivros.TabIndex = 0;
            this.dgvDadosLivros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDadosLivros_CellDoubleClick);
            // 
            // codLivro
            // 
            this.codLivro.DataPropertyName = "id_livro";
            this.codLivro.HeaderText = "Código";
            this.codLivro.Name = "codLivro";
            this.codLivro.ReadOnly = true;
            // 
            // titulo_livro
            // 
            this.titulo_livro.DataPropertyName = "titulo";
            this.titulo_livro.HeaderText = "Titulo";
            this.titulo_livro.Name = "titulo_livro";
            this.titulo_livro.ReadOnly = true;
            // 
            // codAutor
            // 
            this.codAutor.DataPropertyName = "nome";
            this.codAutor.HeaderText = "Autores";
            this.codAutor.Name = "codAutor";
            this.codAutor.ReadOnly = true;
            // 
            // cod_editora
            // 
            this.cod_editora.DataPropertyName = "editora";
            this.cod_editora.HeaderText = "Editora";
            this.cod_editora.Name = "cod_editora";
            this.cod_editora.ReadOnly = true;
            // 
            // numeroEdicao
            // 
            this.numeroEdicao.DataPropertyName = "edicao";
            this.numeroEdicao.HeaderText = "Edição";
            this.numeroEdicao.Name = "numeroEdicao";
            this.numeroEdicao.ReadOnly = true;
            // 
            // estante
            // 
            this.estante.DataPropertyName = "estante";
            this.estante.HeaderText = "Nº Estante";
            this.estante.Name = "estante";
            this.estante.ReadOnly = true;
            // 
            // exemplar
            // 
            this.exemplar.DataPropertyName = "exemplar";
            this.exemplar.HeaderText = "Total Exemplar";
            this.exemplar.Name = "exemplar";
            this.exemplar.ReadOnly = true;
            // 
            // foto_livro
            // 
            this.foto_livro.DataPropertyName = "foto";
            this.foto_livro.HeaderText = "Imagem da Capa do Livro";
            this.foto_livro.Name = "foto_livro";
            this.foto_livro.ReadOnly = true;
            this.foto_livro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.foto_livro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.foto_livro.Width = 159;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informe o Titulo do Livro para Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(235, 56);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(374, 20);
            this.txtPesquisar.TabIndex = 2;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // FrmConsultarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 401);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDadosLivros);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmConsultarLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas de Livros";
            this.Load += new System.EventHandler(this.FrmConsultarLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDadosLivros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroEdicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn estante;
        private System.Windows.Forms.DataGridViewTextBoxColumn exemplar;
        private System.Windows.Forms.DataGridViewImageColumn foto_livro;
    }
}