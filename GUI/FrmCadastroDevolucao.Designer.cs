namespace GUI
{
    partial class FrmCadastroDevolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroDevolucao));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoLivro = new System.Windows.Forms.TextBox();
            this.dgvDevolucaoLivros = new System.Windows.Forms.DataGridView();
            this.cod_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_emprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_devolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBuscarEmprestimo = new System.Windows.Forms.Button();
            this.btCancelarDevolucao = new System.Windows.Forms.Button();
            this.btComfirmarDevolucao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btBuscarLivros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucaoLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Livro";
            // 
            // txtCodigoLivro
            // 
            this.txtCodigoLivro.Location = new System.Drawing.Point(112, 39);
            this.txtCodigoLivro.Name = "txtCodigoLivro";
            this.txtCodigoLivro.Size = new System.Drawing.Size(109, 20);
            this.txtCodigoLivro.TabIndex = 1;
            // 
            // dgvDevolucaoLivros
            // 
            this.dgvDevolucaoLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucaoLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_livro,
            this.nome_leitor,
            this.dt_emprestimo,
            this.dt_devolucao});
            this.dgvDevolucaoLivros.Location = new System.Drawing.Point(22, 81);
            this.dgvDevolucaoLivros.MultiSelect = false;
            this.dgvDevolucaoLivros.Name = "dgvDevolucaoLivros";
            this.dgvDevolucaoLivros.ReadOnly = true;
            this.dgvDevolucaoLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevolucaoLivros.Size = new System.Drawing.Size(676, 212);
            this.dgvDevolucaoLivros.TabIndex = 2;
            // 
            // cod_livro
            // 
            this.cod_livro.HeaderText = "Cód.Livro";
            this.cod_livro.Name = "cod_livro";
            this.cod_livro.ReadOnly = true;
            // 
            // nome_leitor
            // 
            this.nome_leitor.HeaderText = "Nome do Leitor";
            this.nome_leitor.Name = "nome_leitor";
            this.nome_leitor.ReadOnly = true;
            this.nome_leitor.Width = 200;
            // 
            // dt_emprestimo
            // 
            this.dt_emprestimo.HeaderText = "Data de Emprestimo";
            this.dt_emprestimo.Name = "dt_emprestimo";
            this.dt_emprestimo.ReadOnly = true;
            this.dt_emprestimo.Width = 150;
            // 
            // dt_devolucao
            // 
            this.dt_devolucao.HeaderText = "Data de Devolução";
            this.dt_devolucao.Name = "dt_devolucao";
            this.dt_devolucao.ReadOnly = true;
            this.dt_devolucao.Width = 150;
            // 
            // btBuscarEmprestimo
            // 
            this.btBuscarEmprestimo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btBuscarEmprestimo.Image = ((System.Drawing.Image)(resources.GetObject("btBuscarEmprestimo.Image")));
            this.btBuscarEmprestimo.Location = new System.Drawing.Point(86, 300);
            this.btBuscarEmprestimo.Name = "btBuscarEmprestimo";
            this.btBuscarEmprestimo.Size = new System.Drawing.Size(176, 46);
            this.btBuscarEmprestimo.TabIndex = 62;
            this.btBuscarEmprestimo.Text = "Buscar Livros Devolvidos";
            this.btBuscarEmprestimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBuscarEmprestimo.UseVisualStyleBackColor = true;
            // 
            // btCancelarDevolucao
            // 
            this.btCancelarDevolucao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCancelarDevolucao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCancelarDevolucao.Image = ((System.Drawing.Image)(resources.GetObject("btCancelarDevolucao.Image")));
            this.btCancelarDevolucao.Location = new System.Drawing.Point(451, 299);
            this.btCancelarDevolucao.Name = "btCancelarDevolucao";
            this.btCancelarDevolucao.Size = new System.Drawing.Size(176, 46);
            this.btCancelarDevolucao.TabIndex = 65;
            this.btCancelarDevolucao.Text = "Cancelar Devolução";
            this.btCancelarDevolucao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancelarDevolucao.UseVisualStyleBackColor = true;
            // 
            // btComfirmarDevolucao
            // 
            this.btComfirmarDevolucao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btComfirmarDevolucao.Image = ((System.Drawing.Image)(resources.GetObject("btComfirmarDevolucao.Image")));
            this.btComfirmarDevolucao.Location = new System.Drawing.Point(268, 300);
            this.btComfirmarDevolucao.Name = "btComfirmarDevolucao";
            this.btComfirmarDevolucao.Size = new System.Drawing.Size(176, 46);
            this.btComfirmarDevolucao.TabIndex = 64;
            this.btComfirmarDevolucao.Text = "Confirmar Devolução";
            this.btComfirmarDevolucao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btComfirmarDevolucao.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Informa o Código do Livro que pretendes Devolver e clica no botão Buscar";
            // 
            // btBuscarLivros
            // 
            this.btBuscarLivros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btBuscarLivros.Image = ((System.Drawing.Image)(resources.GetObject("btBuscarLivros.Image")));
            this.btBuscarLivros.Location = new System.Drawing.Point(602, 23);
            this.btBuscarLivros.Name = "btBuscarLivros";
            this.btBuscarLivros.Size = new System.Drawing.Size(96, 48);
            this.btBuscarLivros.TabIndex = 67;
            this.btBuscarLivros.Text = "Buscar ";
            this.btBuscarLivros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBuscarLivros.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(716, 364);
            this.Controls.Add(this.btBuscarLivros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCancelarDevolucao);
            this.Controls.Add(this.btComfirmarDevolucao);
            this.Controls.Add(this.btBuscarEmprestimo);
            this.Controls.Add(this.dgvDevolucaoLivros);
            this.Controls.Add(this.txtCodigoLivro);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmCadastroDevolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Devolução de Livros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucaoLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoLivro;
        private System.Windows.Forms.DataGridView dgvDevolucaoLivros;
        private System.Windows.Forms.Button btBuscarEmprestimo;
        private System.Windows.Forms.Button btCancelarDevolucao;
        private System.Windows.Forms.Button btComfirmarDevolucao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBuscarLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_leitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_emprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_devolucao;
    }
}