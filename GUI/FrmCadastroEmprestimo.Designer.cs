namespace GUI
{
    partial class FrmCadastroEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroEmprestimo));
            this.groupBoxLEITORES = new System.Windows.Forms.GroupBox();
            this.lblNomeDoLeitor = new System.Windows.Forms.Label();
            this.btLocalizarLeitores = new System.Windows.Forms.Button();
            this.txtCodLeitor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.groupBoxLIVROS = new System.Windows.Forms.GroupBox();
            this.btCancelarEmprestimo = new System.Windows.Forms.Button();
            this.btRealizarEmprestimo = new System.Windows.Forms.Button();
            this.btLocalizarEmprestimo = new System.Windows.Forms.Button();
            this.groupBox_SituacaoLivro = new System.Windows.Forms.GroupBox();
            this.radioButtonLivroDisponivel = new System.Windows.Forms.RadioButton();
            this.radioButtonLivroReservado = new System.Windows.Forms.RadioButton();
            this.radioButtonLivroEmprestado = new System.Windows.Forms.RadioButton();
            this.groupBox_ItensLivrosEmprestados = new System.Windows.Forms.GroupBox();
            this.dgvListaIntesEmprestimo = new System.Windows.Forms.DataGridView();
            this.cod_leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_devolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.dtDataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dt_DataEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTituloDoLivro = new System.Windows.Forms.Label();
            this.btAdicionarLivrosEmprestimo = new System.Windows.Forms.Button();
            this.txtCodLivro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodEmprestimo = new System.Windows.Forms.TextBox();
            this.groupBoxLEITORES.SuspendLayout();
            this.groupBoxLIVROS.SuspendLayout();
            this.groupBox_SituacaoLivro.SuspendLayout();
            this.groupBox_ItensLivrosEmprestados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaIntesEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLEITORES
            // 
            this.groupBoxLEITORES.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxLEITORES.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxLEITORES.Controls.Add(this.lblNomeDoLeitor);
            this.groupBoxLEITORES.Controls.Add(this.btLocalizarLeitores);
            this.groupBoxLEITORES.Controls.Add(this.txtCodLeitor);
            this.groupBoxLEITORES.Controls.Add(this.label1);
            this.groupBoxLEITORES.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxLEITORES.Location = new System.Drawing.Point(12, 38);
            this.groupBoxLEITORES.Name = "groupBoxLEITORES";
            this.groupBoxLEITORES.Size = new System.Drawing.Size(809, 54);
            this.groupBoxLEITORES.TabIndex = 49;
            this.groupBoxLEITORES.TabStop = false;
            this.groupBoxLEITORES.Text = "Leitor";
            // 
            // lblNomeDoLeitor
            // 
            this.lblNomeDoLeitor.AutoSize = true;
            this.lblNomeDoLeitor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNomeDoLeitor.Location = new System.Drawing.Point(240, 23);
            this.lblNomeDoLeitor.Name = "lblNomeDoLeitor";
            this.lblNomeDoLeitor.Size = new System.Drawing.Size(253, 13);
            this.lblNomeDoLeitor.TabIndex = 48;
            this.lblNomeDoLeitor.Text = "Digita o Código do Leitor ou clica no botão Localizar";
            // 
            // btLocalizarLeitores
            // 
            this.btLocalizarLeitores.BackColor = System.Drawing.Color.White;
            this.btLocalizarLeitores.ForeColor = System.Drawing.Color.DarkRed;
            this.btLocalizarLeitores.Image = ((System.Drawing.Image)(resources.GetObject("btLocalizarLeitores.Image")));
            this.btLocalizarLeitores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLocalizarLeitores.Location = new System.Drawing.Point(519, 13);
            this.btLocalizarLeitores.Name = "btLocalizarLeitores";
            this.btLocalizarLeitores.Size = new System.Drawing.Size(150, 33);
            this.btLocalizarLeitores.TabIndex = 47;
            this.btLocalizarLeitores.Text = "LOCALIZAR";
            this.btLocalizarLeitores.UseVisualStyleBackColor = false;
            // 
            // txtCodLeitor
            // 
            this.txtCodLeitor.Location = new System.Drawing.Point(105, 19);
            this.txtCodLeitor.Name = "txtCodLeitor";
            this.txtCodLeitor.Size = new System.Drawing.Size(117, 20);
            this.txtCodLeitor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Leitor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(11, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nome do Funcionário:";
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.BackColor = System.Drawing.Color.Blue;
            this.lblNomeFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(132, 13);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(108, 13);
            this.lblNomeFuncionario.TabIndex = 51;
            this.lblNomeFuncionario.Text = "Nome do Funcionário";
            // 
            // groupBoxLIVROS
            // 
            this.groupBoxLIVROS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxLIVROS.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxLIVROS.Controls.Add(this.btCancelarEmprestimo);
            this.groupBoxLIVROS.Controls.Add(this.btRealizarEmprestimo);
            this.groupBoxLIVROS.Controls.Add(this.btLocalizarEmprestimo);
            this.groupBoxLIVROS.Controls.Add(this.groupBox_SituacaoLivro);
            this.groupBoxLIVROS.Controls.Add(this.groupBox_ItensLivrosEmprestados);
            this.groupBoxLIVROS.Controls.Add(this.label9);
            this.groupBoxLIVROS.Controls.Add(this.dtDataDevolucao);
            this.groupBoxLIVROS.Controls.Add(this.label8);
            this.groupBoxLIVROS.Controls.Add(this.dt_DataEmprestimo);
            this.groupBoxLIVROS.Controls.Add(this.label7);
            this.groupBoxLIVROS.Controls.Add(this.lblTituloDoLivro);
            this.groupBoxLIVROS.Controls.Add(this.btAdicionarLivrosEmprestimo);
            this.groupBoxLIVROS.Controls.Add(this.txtCodLivro);
            this.groupBoxLIVROS.Controls.Add(this.label5);
            this.groupBoxLIVROS.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxLIVROS.Location = new System.Drawing.Point(14, 93);
            this.groupBoxLIVROS.Name = "groupBoxLIVROS";
            this.groupBoxLIVROS.Size = new System.Drawing.Size(809, 397);
            this.groupBoxLIVROS.TabIndex = 52;
            this.groupBoxLIVROS.TabStop = false;
            this.groupBoxLIVROS.Text = "Livro";
            // 
            // btCancelarEmprestimo
            // 
            this.btCancelarEmprestimo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCancelarEmprestimo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCancelarEmprestimo.Image = ((System.Drawing.Image)(resources.GetObject("btCancelarEmprestimo.Image")));
            this.btCancelarEmprestimo.Location = new System.Drawing.Point(410, 340);
            this.btCancelarEmprestimo.Name = "btCancelarEmprestimo";
            this.btCancelarEmprestimo.Size = new System.Drawing.Size(149, 46);
            this.btCancelarEmprestimo.TabIndex = 63;
            this.btCancelarEmprestimo.Text = "Cancelar Emprestimo";
            this.btCancelarEmprestimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancelarEmprestimo.UseVisualStyleBackColor = true;
            // 
            // btRealizarEmprestimo
            // 
            this.btRealizarEmprestimo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btRealizarEmprestimo.Image = ((System.Drawing.Image)(resources.GetObject("btRealizarEmprestimo.Image")));
            this.btRealizarEmprestimo.Location = new System.Drawing.Point(243, 341);
            this.btRealizarEmprestimo.Name = "btRealizarEmprestimo";
            this.btRealizarEmprestimo.Size = new System.Drawing.Size(150, 46);
            this.btRealizarEmprestimo.TabIndex = 62;
            this.btRealizarEmprestimo.Text = "Realizar Emprestimo";
            this.btRealizarEmprestimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRealizarEmprestimo.UseVisualStyleBackColor = true;
            this.btRealizarEmprestimo.Click += new System.EventHandler(this.btRealizarEmprestimo_Click);
            // 
            // btLocalizarEmprestimo
            // 
            this.btLocalizarEmprestimo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLocalizarEmprestimo.Image = ((System.Drawing.Image)(resources.GetObject("btLocalizarEmprestimo.Image")));
            this.btLocalizarEmprestimo.Location = new System.Drawing.Point(76, 341);
            this.btLocalizarEmprestimo.Name = "btLocalizarEmprestimo";
            this.btLocalizarEmprestimo.Size = new System.Drawing.Size(150, 46);
            this.btLocalizarEmprestimo.TabIndex = 61;
            this.btLocalizarEmprestimo.Text = "Localizar Emprestimo";
            this.btLocalizarEmprestimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLocalizarEmprestimo.UseVisualStyleBackColor = true;
            // 
            // groupBox_SituacaoLivro
            // 
            this.groupBox_SituacaoLivro.Controls.Add(this.radioButtonLivroDisponivel);
            this.groupBox_SituacaoLivro.Controls.Add(this.radioButtonLivroReservado);
            this.groupBox_SituacaoLivro.Controls.Add(this.radioButtonLivroEmprestado);
            this.groupBox_SituacaoLivro.ForeColor = System.Drawing.Color.Blue;
            this.groupBox_SituacaoLivro.Location = new System.Drawing.Point(13, 104);
            this.groupBox_SituacaoLivro.Name = "groupBox_SituacaoLivro";
            this.groupBox_SituacaoLivro.Size = new System.Drawing.Size(152, 229);
            this.groupBox_SituacaoLivro.TabIndex = 55;
            this.groupBox_SituacaoLivro.TabStop = false;
            this.groupBox_SituacaoLivro.Text = "Situação do Livro";
            // 
            // radioButtonLivroDisponivel
            // 
            this.radioButtonLivroDisponivel.AutoCheck = false;
            this.radioButtonLivroDisponivel.AutoSize = true;
            this.radioButtonLivroDisponivel.Enabled = false;
            this.radioButtonLivroDisponivel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonLivroDisponivel.Location = new System.Drawing.Point(27, 164);
            this.radioButtonLivroDisponivel.Name = "radioButtonLivroDisponivel";
            this.radioButtonLivroDisponivel.Size = new System.Drawing.Size(102, 17);
            this.radioButtonLivroDisponivel.TabIndex = 2;
            this.radioButtonLivroDisponivel.Text = "Livro Disponível";
            this.radioButtonLivroDisponivel.UseVisualStyleBackColor = true;
            // 
            // radioButtonLivroReservado
            // 
            this.radioButtonLivroReservado.AutoCheck = false;
            this.radioButtonLivroReservado.AutoSize = true;
            this.radioButtonLivroReservado.Enabled = false;
            this.radioButtonLivroReservado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonLivroReservado.Location = new System.Drawing.Point(27, 100);
            this.radioButtonLivroReservado.Name = "radioButtonLivroReservado";
            this.radioButtonLivroReservado.Size = new System.Drawing.Size(103, 17);
            this.radioButtonLivroReservado.TabIndex = 1;
            this.radioButtonLivroReservado.TabStop = true;
            this.radioButtonLivroReservado.Text = "Livro Reservado";
            this.radioButtonLivroReservado.UseVisualStyleBackColor = true;
            // 
            // radioButtonLivroEmprestado
            // 
            this.radioButtonLivroEmprestado.AutoCheck = false;
            this.radioButtonLivroEmprestado.AutoSize = true;
            this.radioButtonLivroEmprestado.Enabled = false;
            this.radioButtonLivroEmprestado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonLivroEmprestado.Location = new System.Drawing.Point(27, 44);
            this.radioButtonLivroEmprestado.Name = "radioButtonLivroEmprestado";
            this.radioButtonLivroEmprestado.Size = new System.Drawing.Size(107, 17);
            this.radioButtonLivroEmprestado.TabIndex = 0;
            this.radioButtonLivroEmprestado.TabStop = true;
            this.radioButtonLivroEmprestado.Text = "Livro Emprestado";
            this.radioButtonLivroEmprestado.UseVisualStyleBackColor = true;
            // 
            // groupBox_ItensLivrosEmprestados
            // 
            this.groupBox_ItensLivrosEmprestados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_ItensLivrosEmprestados.Controls.Add(this.dgvListaIntesEmprestimo);
            this.groupBox_ItensLivrosEmprestados.ForeColor = System.Drawing.Color.Blue;
            this.groupBox_ItensLivrosEmprestados.Location = new System.Drawing.Point(188, 104);
            this.groupBox_ItensLivrosEmprestados.Name = "groupBox_ItensLivrosEmprestados";
            this.groupBox_ItensLivrosEmprestados.Size = new System.Drawing.Size(594, 229);
            this.groupBox_ItensLivrosEmprestados.TabIndex = 54;
            this.groupBox_ItensLivrosEmprestados.TabStop = false;
            this.groupBox_ItensLivrosEmprestados.Text = "Itens Emprestados";
            // 
            // dgvListaIntesEmprestimo
            // 
            this.dgvListaIntesEmprestimo.AllowUserToAddRows = false;
            this.dgvListaIntesEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaIntesEmprestimo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_leitor,
            this.cod_livro,
            this.titulo_livro,
            this.dt_devolucao});
            this.dgvListaIntesEmprestimo.Location = new System.Drawing.Point(31, 32);
            this.dgvListaIntesEmprestimo.MultiSelect = false;
            this.dgvListaIntesEmprestimo.Name = "dgvListaIntesEmprestimo";
            this.dgvListaIntesEmprestimo.ReadOnly = true;
            this.dgvListaIntesEmprestimo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaIntesEmprestimo.Size = new System.Drawing.Size(525, 180);
            this.dgvListaIntesEmprestimo.TabIndex = 0;
            // 
            // cod_leitor
            // 
            this.cod_leitor.HeaderText = "Cód.Leitor";
            this.cod_leitor.Name = "cod_leitor";
            this.cod_leitor.ReadOnly = true;
            // 
            // cod_livro
            // 
            this.cod_livro.HeaderText = "Cód.Livro";
            this.cod_livro.Name = "cod_livro";
            this.cod_livro.ReadOnly = true;
            // 
            // titulo_livro
            // 
            this.titulo_livro.HeaderText = "Título do Livro";
            this.titulo_livro.Name = "titulo_livro";
            this.titulo_livro.ReadOnly = true;
            this.titulo_livro.Width = 150;
            // 
            // dt_devolucao
            // 
            this.dt_devolucao.HeaderText = "Data Devolução";
            this.dt_devolucao.Name = "dt_devolucao";
            this.dt_devolucao.ReadOnly = true;
            this.dt_devolucao.Width = 120;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(226, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Data Devolução";
            // 
            // dtDataDevolucao
            // 
            this.dtDataDevolucao.Checked = false;
            this.dtDataDevolucao.Enabled = false;
            this.dtDataDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataDevolucao.Location = new System.Drawing.Point(317, 66);
            this.dtDataDevolucao.Name = "dtDataDevolucao";
            this.dtDataDevolucao.Size = new System.Drawing.Size(95, 20);
            this.dtDataDevolucao.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(11, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Data Emprestimo";
            // 
            // dt_DataEmprestimo
            // 
            this.dt_DataEmprestimo.Checked = false;
            this.dt_DataEmprestimo.Enabled = false;
            this.dt_DataEmprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_DataEmprestimo.Location = new System.Drawing.Point(105, 63);
            this.dt_DataEmprestimo.Name = "dt_DataEmprestimo";
            this.dt_DataEmprestimo.Size = new System.Drawing.Size(95, 20);
            this.dt_DataEmprestimo.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(10, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(657, 22);
            this.label7.TabIndex = 49;
            this.label7.Text = "_________________________________________________________________________________" +
    "___________________________________________";
            // 
            // lblTituloDoLivro
            // 
            this.lblTituloDoLivro.AutoSize = true;
            this.lblTituloDoLivro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTituloDoLivro.Location = new System.Drawing.Point(240, 22);
            this.lblTituloDoLivro.Name = "lblTituloDoLivro";
            this.lblTituloDoLivro.Size = new System.Drawing.Size(189, 13);
            this.lblTituloDoLivro.TabIndex = 48;
            this.lblTituloDoLivro.Text = "Digita o Código do Livro para Localizar";
            // 
            // btAdicionarLivrosEmprestimo
            // 
            this.btAdicionarLivrosEmprestimo.BackColor = System.Drawing.Color.White;
            this.btAdicionarLivrosEmprestimo.ForeColor = System.Drawing.Color.DarkRed;
            this.btAdicionarLivrosEmprestimo.Image = ((System.Drawing.Image)(resources.GetObject("btAdicionarLivrosEmprestimo.Image")));
            this.btAdicionarLivrosEmprestimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdicionarLivrosEmprestimo.Location = new System.Drawing.Point(517, 13);
            this.btAdicionarLivrosEmprestimo.Name = "btAdicionarLivrosEmprestimo";
            this.btAdicionarLivrosEmprestimo.Size = new System.Drawing.Size(150, 33);
            this.btAdicionarLivrosEmprestimo.TabIndex = 47;
            this.btAdicionarLivrosEmprestimo.Text = "Adicionar Livro";
            this.btAdicionarLivrosEmprestimo.UseVisualStyleBackColor = false;
            this.btAdicionarLivrosEmprestimo.Click += new System.EventHandler(this.btAdicionarLivrosEmprestimo_Click);
            // 
            // txtCodLivro
            // 
            this.txtCodLivro.Location = new System.Drawing.Point(105, 19);
            this.txtCodLivro.Name = "txtCodLivro";
            this.txtCodLivro.Size = new System.Drawing.Size(117, 20);
            this.txtCodLivro.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(10, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Código do Livro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(599, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Código Emprestimo";
            // 
            // txtCodEmprestimo
            // 
            this.txtCodEmprestimo.Location = new System.Drawing.Point(705, 16);
            this.txtCodEmprestimo.Name = "txtCodEmprestimo";
            this.txtCodEmprestimo.ReadOnly = true;
            this.txtCodEmprestimo.Size = new System.Drawing.Size(111, 20);
            this.txtCodEmprestimo.TabIndex = 54;
            // 
            // FrmCadastroEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(833, 503);
            this.Controls.Add(this.txtCodEmprestimo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxLIVROS);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxLEITORES);
            this.MaximizeBox = false;
            this.Name = "FrmCadastroEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Emprestimo de Livros";
            this.Load += new System.EventHandler(this.FrmCadastroEmprestimo_Load);
            this.groupBoxLEITORES.ResumeLayout(false);
            this.groupBoxLEITORES.PerformLayout();
            this.groupBoxLIVROS.ResumeLayout(false);
            this.groupBoxLIVROS.PerformLayout();
            this.groupBox_SituacaoLivro.ResumeLayout(false);
            this.groupBox_SituacaoLivro.PerformLayout();
            this.groupBox_ItensLivrosEmprestados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaIntesEmprestimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLEITORES;
        private System.Windows.Forms.TextBox txtCodLeitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblNomeDoLeitor;
        private System.Windows.Forms.Button btLocalizarLeitores;
        private System.Windows.Forms.GroupBox groupBoxLIVROS;
        private System.Windows.Forms.Label lblTituloDoLivro;
        private System.Windows.Forms.Button btAdicionarLivrosEmprestimo;
        private System.Windows.Forms.TextBox txtCodLivro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtDataDevolucao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dt_DataEmprestimo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodEmprestimo;
        private System.Windows.Forms.GroupBox groupBox_SituacaoLivro;
        private System.Windows.Forms.RadioButton radioButtonLivroDisponivel;
        private System.Windows.Forms.RadioButton radioButtonLivroReservado;
        private System.Windows.Forms.RadioButton radioButtonLivroEmprestado;
        private System.Windows.Forms.GroupBox groupBox_ItensLivrosEmprestados;
        private System.Windows.Forms.DataGridView dgvListaIntesEmprestimo;
        private System.Windows.Forms.Button btRealizarEmprestimo;
        private System.Windows.Forms.Button btLocalizarEmprestimo;
        private System.Windows.Forms.Button btCancelarEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_leitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_devolucao;
    }
}