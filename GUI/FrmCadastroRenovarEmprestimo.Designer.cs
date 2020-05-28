namespace GUI
{
    partial class FrmCadastroRenovarEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroRenovarEmprestimo));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nome_leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_devolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btCancelarEmprestimo = new System.Windows.Forms.Button();
            this.btRealizarEmprestimo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.titulo_obra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_devolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Livro";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "LOCALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome_leitor,
            this.titulo_livro,
            this.data_devolucao,
            this.estado_livro});
            this.dataGridView1.Location = new System.Drawing.Point(27, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(598, 123);
            this.dataGridView1.TabIndex = 3;
            // 
            // nome_leitor
            // 
            this.nome_leitor.HeaderText = "Nome do Leitor";
            this.nome_leitor.Name = "nome_leitor";
            this.nome_leitor.Width = 150;
            // 
            // titulo_livro
            // 
            this.titulo_livro.HeaderText = "Titulo do Livro";
            this.titulo_livro.Name = "titulo_livro";
            // 
            // data_devolucao
            // 
            this.data_devolucao.HeaderText = "Data da Devolução";
            this.data_devolucao.Name = "data_devolucao";
            this.data_devolucao.Width = 150;
            // 
            // estado_livro
            // 
            this.estado_livro.HeaderText = "Estado do Livro";
            this.estado_livro.Name = "estado_livro";
            this.estado_livro.Width = 150;
            // 
            // btCancelarEmprestimo
            // 
            this.btCancelarEmprestimo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCancelarEmprestimo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCancelarEmprestimo.Image = ((System.Drawing.Image)(resources.GetObject("btCancelarEmprestimo.Image")));
            this.btCancelarEmprestimo.Location = new System.Drawing.Point(316, 340);
            this.btCancelarEmprestimo.Name = "btCancelarEmprestimo";
            this.btCancelarEmprestimo.Size = new System.Drawing.Size(149, 42);
            this.btCancelarEmprestimo.TabIndex = 65;
            this.btCancelarEmprestimo.Text = "Cancelar Renovação";
            this.btCancelarEmprestimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancelarEmprestimo.UseVisualStyleBackColor = true;
            // 
            // btRealizarEmprestimo
            // 
            this.btRealizarEmprestimo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btRealizarEmprestimo.Image = ((System.Drawing.Image)(resources.GetObject("btRealizarEmprestimo.Image")));
            this.btRealizarEmprestimo.Location = new System.Drawing.Point(389, 11);
            this.btRealizarEmprestimo.Name = "btRealizarEmprestimo";
            this.btRealizarEmprestimo.Size = new System.Drawing.Size(150, 35);
            this.btRealizarEmprestimo.TabIndex = 64;
            this.btRealizarEmprestimo.Text = "Renovar  Emprestimo";
            this.btRealizarEmprestimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRealizarEmprestimo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(27, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 143);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens de Livros Renovados";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titulo_obra,
            this.dt_devolucao});
            this.dataGridView2.Location = new System.Drawing.Point(106, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(361, 114);
            this.dataGridView2.TabIndex = 0;
            // 
            // titulo_obra
            // 
            this.titulo_obra.HeaderText = "Titulo do Livro";
            this.titulo_obra.Name = "titulo_obra";
            this.titulo_obra.Width = 150;
            // 
            // dt_devolucao
            // 
            this.dt_devolucao.HeaderText = "Data da Devolução";
            this.dt_devolucao.Name = "dt_devolucao";
            this.dt_devolucao.Width = 150;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(133, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 42);
            this.button2.TabIndex = 67;
            this.button2.Text = "Confirmar Renovação";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroRenovarEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCancelarEmprestimo);
            this.Controls.Add(this.btRealizarEmprestimo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmCadastroRenovarEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renovar Emprestimos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_leitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_devolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_livro;
        private System.Windows.Forms.Button btCancelarEmprestimo;
        private System.Windows.Forms.Button btRealizarEmprestimo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo_obra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_devolucao;
        private System.Windows.Forms.Button button2;
    }
}