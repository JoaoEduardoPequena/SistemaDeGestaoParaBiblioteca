namespace GUI
{
    partial class FrmCadastroLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroLivros));
            this.label2 = new System.Windows.Forms.Label();
            this.txtTituloLivro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodLivro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoEditora = new System.Windows.Forms.TextBox();
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.btBuscarEditora = new System.Windows.Forms.Button();
            this.pictureBox_CapaLivro = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btBuscarAutores = new System.Windows.Forms.Button();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoAutor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumeroEdicao = new System.Windows.Forms.TextBox();
            this.btAdicionarImagem = new System.Windows.Forms.Button();
            this.btRemoverImagem = new System.Windows.Forms.Button();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btExibirRelatorio = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumerosExemplar = new System.Windows.Forms.TextBox();
            this.txtNumeroEstante = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CapaLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Titulo do Livro";
            // 
            // txtTituloLivro
            // 
            this.txtTituloLivro.Location = new System.Drawing.Point(103, 49);
            this.txtTituloLivro.Name = "txtTituloLivro";
            this.txtTituloLivro.Size = new System.Drawing.Size(513, 20);
            this.txtTituloLivro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Código";
            // 
            // txtCodLivro
            // 
            this.txtCodLivro.Location = new System.Drawing.Point(100, 15);
            this.txtCodLivro.Multiline = true;
            this.txtCodLivro.Name = "txtCodLivro";
            this.txtCodLivro.ReadOnly = true;
            this.txtCodLivro.Size = new System.Drawing.Size(67, 20);
            this.txtCodLivro.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Código Editora";
            // 
            // txtCodigoEditora
            // 
            this.txtCodigoEditora.Location = new System.Drawing.Point(103, 122);
            this.txtCodigoEditora.Name = "txtCodigoEditora";
            this.txtCodigoEditora.Size = new System.Drawing.Size(67, 20);
            this.txtCodigoEditora.TabIndex = 17;
            this.txtCodigoEditora.Leave += new System.EventHandler(this.txtCodigoEditora_Leave);
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.Location = new System.Drawing.Point(180, 122);
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.ReadOnly = true;
            this.txtNomeEditora.Size = new System.Drawing.Size(296, 20);
            this.txtNomeEditora.TabIndex = 19;
            // 
            // btBuscarEditora
            // 
            this.btBuscarEditora.BackColor = System.Drawing.Color.White;
            this.btBuscarEditora.ForeColor = System.Drawing.Color.DarkRed;
            this.btBuscarEditora.Image = ((System.Drawing.Image)(resources.GetObject("btBuscarEditora.Image")));
            this.btBuscarEditora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscarEditora.Location = new System.Drawing.Point(491, 116);
            this.btBuscarEditora.Name = "btBuscarEditora";
            this.btBuscarEditora.Size = new System.Drawing.Size(122, 30);
            this.btBuscarEditora.TabIndex = 2;
            this.btBuscarEditora.Text = "Buscar";
            this.btBuscarEditora.UseVisualStyleBackColor = false;
            this.btBuscarEditora.Click += new System.EventHandler(this.btBuscarEditora_Click);
            // 
            // pictureBox_CapaLivro
            // 
            this.pictureBox_CapaLivro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_CapaLivro.Location = new System.Drawing.Point(632, 19);
            this.pictureBox_CapaLivro.Name = "pictureBox_CapaLivro";
            this.pictureBox_CapaLivro.Size = new System.Drawing.Size(243, 132);
            this.pictureBox_CapaLivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_CapaLivro.TabIndex = 22;
            this.pictureBox_CapaLivro.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Imagem da Capa do Livro";
            // 
            // btBuscarAutores
            // 
            this.btBuscarAutores.BackColor = System.Drawing.Color.White;
            this.btBuscarAutores.ForeColor = System.Drawing.Color.DarkRed;
            this.btBuscarAutores.Image = ((System.Drawing.Image)(resources.GetObject("btBuscarAutores.Image")));
            this.btBuscarAutores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscarAutores.Location = new System.Drawing.Point(491, 76);
            this.btBuscarAutores.Name = "btBuscarAutores";
            this.btBuscarAutores.Size = new System.Drawing.Size(122, 30);
            this.btBuscarAutores.TabIndex = 1;
            this.btBuscarAutores.Text = "Buscar";
            this.btBuscarAutores.UseVisualStyleBackColor = false;
            this.btBuscarAutores.Click += new System.EventHandler(this.btBuscarAutores_Click);
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(180, 82);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.ReadOnly = true;
            this.txtNomeAutor.Size = new System.Drawing.Size(296, 20);
            this.txtNomeAutor.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Código Autor";
            // 
            // txtCodigoAutor
            // 
            this.txtCodigoAutor.Location = new System.Drawing.Point(103, 82);
            this.txtCodigoAutor.Name = "txtCodigoAutor";
            this.txtCodigoAutor.Size = new System.Drawing.Size(67, 20);
            this.txtCodigoAutor.TabIndex = 28;
            this.txtCodigoAutor.Leave += new System.EventHandler(this.txtCodigoAutor_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Edição";
            // 
            // txtNumeroEdicao
            // 
            this.txtNumeroEdicao.Location = new System.Drawing.Point(103, 159);
            this.txtNumeroEdicao.Name = "txtNumeroEdicao";
            this.txtNumeroEdicao.Size = new System.Drawing.Size(513, 20);
            this.txtNumeroEdicao.TabIndex = 3;
            // 
            // btAdicionarImagem
            // 
            this.btAdicionarImagem.BackColor = System.Drawing.Color.White;
            this.btAdicionarImagem.ForeColor = System.Drawing.Color.DarkRed;
            this.btAdicionarImagem.Image = ((System.Drawing.Image)(resources.GetObject("btAdicionarImagem.Image")));
            this.btAdicionarImagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdicionarImagem.Location = new System.Drawing.Point(632, 155);
            this.btAdicionarImagem.Name = "btAdicionarImagem";
            this.btAdicionarImagem.Size = new System.Drawing.Size(117, 30);
            this.btAdicionarImagem.TabIndex = 34;
            this.btAdicionarImagem.Text = "Adicionar";
            this.btAdicionarImagem.UseVisualStyleBackColor = false;
            this.btAdicionarImagem.Click += new System.EventHandler(this.btAdicionarImagem_Click);
            // 
            // btRemoverImagem
            // 
            this.btRemoverImagem.BackColor = System.Drawing.Color.White;
            this.btRemoverImagem.ForeColor = System.Drawing.Color.DarkRed;
            this.btRemoverImagem.Image = ((System.Drawing.Image)(resources.GetObject("btRemoverImagem.Image")));
            this.btRemoverImagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRemoverImagem.Location = new System.Drawing.Point(758, 154);
            this.btRemoverImagem.Name = "btRemoverImagem";
            this.btRemoverImagem.Size = new System.Drawing.Size(117, 30);
            this.btRemoverImagem.TabIndex = 35;
            this.btRemoverImagem.Text = "Remover";
            this.btRemoverImagem.UseVisualStyleBackColor = false;
            this.btRemoverImagem.Click += new System.EventHandler(this.btRemoverImagem_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btLocalizar.Image")));
            this.btLocalizar.Location = new System.Drawing.Point(313, 224);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(85, 87);
            this.btLocalizar.TabIndex = 39;
            this.btLocalizar.Text = "Localizar";
            this.btLocalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btLocalizar.UseVisualStyleBackColor = true;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.Location = new System.Drawing.Point(633, 224);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(83, 87);
            this.btCancelar.TabIndex = 38;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.Location = new System.Drawing.Point(529, 224);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(83, 87);
            this.btExcluir.TabIndex = 37;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.Location = new System.Drawing.Point(421, 224);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(83, 87);
            this.btSalvar.TabIndex = 36;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "ISBN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Categória";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Ano da Publicação";
            // 
            // btExibirRelatorio
            // 
            this.btExibirRelatorio.Location = new System.Drawing.Point(737, 224);
            this.btExibirRelatorio.Name = "btExibirRelatorio";
            this.btExibirRelatorio.Size = new System.Drawing.Size(95, 87);
            this.btExibirRelatorio.TabIndex = 43;
            this.btExibirRelatorio.Text = "Exibir Relatório";
            this.btExibirRelatorio.UseVisualStyleBackColor = true;
            this.btExibirRelatorio.Click += new System.EventHandler(this.btExibirRelatorio_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Nº de Exemplares";
            // 
            // txtNumerosExemplar
            // 
            this.txtNumerosExemplar.Location = new System.Drawing.Point(148, 273);
            this.txtNumerosExemplar.Name = "txtNumerosExemplar";
            this.txtNumerosExemplar.Size = new System.Drawing.Size(62, 20);
            this.txtNumerosExemplar.TabIndex = 47;
            // 
            // txtNumeroEstante
            // 
            this.txtNumeroEstante.Location = new System.Drawing.Point(148, 297);
            this.txtNumeroEstante.Name = "txtNumeroEstante";
            this.txtNumeroEstante.Size = new System.Drawing.Size(62, 20);
            this.txtNumeroEstante.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Localizado na Estante Nº";
            // 
            // FrmCadastroLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 337);
            this.Controls.Add(this.txtNumeroEstante);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNumerosExemplar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btExibirRelatorio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btLocalizar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btRemoverImagem);
            this.Controls.Add(this.btAdicionarImagem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumeroEdicao);
            this.Controls.Add(this.btBuscarAutores);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigoAutor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox_CapaLivro);
            this.Controls.Add(this.btBuscarEditora);
            this.Controls.Add(this.txtNomeEditora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigoEditora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTituloLivro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodLivro);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmCadastroLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Livros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadastroLivros_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadastroLivros_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroLivros_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CapaLivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTituloLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodLivro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoEditora;
        private System.Windows.Forms.TextBox txtNomeEditora;
        private System.Windows.Forms.Button btBuscarEditora;
        private System.Windows.Forms.PictureBox pictureBox_CapaLivro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btBuscarAutores;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoAutor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumeroEdicao;
        private System.Windows.Forms.Button btAdicionarImagem;
        private System.Windows.Forms.Button btRemoverImagem;
        private System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNumerosExemplar;
        private System.Windows.Forms.TextBox txtNumeroEstante;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button btExibirRelatorio;
    }
}