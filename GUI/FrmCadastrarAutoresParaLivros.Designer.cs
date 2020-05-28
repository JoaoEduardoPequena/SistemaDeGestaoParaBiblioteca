namespace GUI
{
    partial class FrmCadastrarAutoresParaLivros
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cod_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_autor_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cód. Livro";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "LOCALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_livro,
            this.cod_autor,
            this.titulo_Livro,
            this.id_autor_livro});
            this.dataGridView1.Location = new System.Drawing.Point(29, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Informe o código do Livro ou Clica no botão Localizar";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Adicionar Autores";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cód. Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Informe o código do Livro ou Clica no botão Localizar";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(107, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "LOCALIZAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cod_livro
            // 
            this.cod_livro.HeaderText = "Cod. Livro";
            this.cod_livro.Name = "cod_livro";
            // 
            // cod_autor
            // 
            this.cod_autor.HeaderText = "Cód.Autor";
            this.cod_autor.Name = "cod_autor";
            // 
            // titulo_Livro
            // 
            this.titulo_Livro.HeaderText = "Titulo do Livro";
            this.titulo_Livro.Name = "titulo_Livro";
            // 
            // id_autor_livro
            // 
            this.id_autor_livro.HeaderText = "Nome do Autor";
            this.id_autor_livro.Name = "id_autor_livro";
            this.id_autor_livro.Width = 150;
            // 
            // FrmCadastrarAutoresParaLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 348);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastrarAutoresParaLivros";
            this.Text = "Cadastrar Autores Para o Livro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_autor_livro;
    }
}