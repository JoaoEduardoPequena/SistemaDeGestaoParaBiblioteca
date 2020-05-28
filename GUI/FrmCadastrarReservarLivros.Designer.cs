namespace GUI
{
    partial class FrmCadastrarReservarLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarReservarLivros));
            this.groupBox_Leitores = new System.Windows.Forms.GroupBox();
            this.btLocalizarLeitores = new System.Windows.Forms.Button();
            this.lblNomeLeitor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoLeitor = new System.Windows.Forms.TextBox();
            this.groupBox_Livros = new System.Windows.Forms.GroupBox();
            this.groupBox_SituacaoLivro = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal_ExemplarDisponiveis = new System.Windows.Forms.TextBox();
            this.radioButtonLivroEmprestado = new System.Windows.Forms.RadioButton();
            this.radioButtonDisponivel = new System.Windows.Forms.RadioButton();
            this.radioButtonLivroReservado = new System.Windows.Forms.RadioButton();
            this.btEfectuarReserva = new System.Windows.Forms.Button();
            this.btLocalizarReserva = new System.Windows.Forms.Button();
            this.btCancelarReserva = new System.Windows.Forms.Button();
            this.btAdicionarLivroParaReservar = new System.Windows.Forms.Button();
            this.groupBox_LivrosReservados = new System.Windows.Forms.GroupBox();
            this.dgvListaLivrosReservados = new System.Windows.Forms.DataGridView();
            this.cod_Leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_LimteBusaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.dtDataLimiteReserva = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDataReserva = new System.Windows.Forms.DateTimePicker();
            this.lblTituloLivro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoLivro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btLocalizarLivro = new System.Windows.Forms.Button();
            this.groupBox_Leitores.SuspendLayout();
            this.groupBox_Livros.SuspendLayout();
            this.groupBox_SituacaoLivro.SuspendLayout();
            this.groupBox_LivrosReservados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLivrosReservados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Leitores
            // 
            this.groupBox_Leitores.Controls.Add(this.btLocalizarLeitores);
            this.groupBox_Leitores.Controls.Add(this.lblNomeLeitor);
            this.groupBox_Leitores.Controls.Add(this.label2);
            this.groupBox_Leitores.Controls.Add(this.txtCodigoLeitor);
            this.groupBox_Leitores.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox_Leitores.Location = new System.Drawing.Point(12, 28);
            this.groupBox_Leitores.Name = "groupBox_Leitores";
            this.groupBox_Leitores.Size = new System.Drawing.Size(882, 60);
            this.groupBox_Leitores.TabIndex = 0;
            this.groupBox_Leitores.TabStop = false;
            this.groupBox_Leitores.Text = "Leitores";
            // 
            // btLocalizarLeitores
            // 
            this.btLocalizarLeitores.BackColor = System.Drawing.Color.White;
            this.btLocalizarLeitores.ForeColor = System.Drawing.Color.DarkRed;
            this.btLocalizarLeitores.Image = ((System.Drawing.Image)(resources.GetObject("btLocalizarLeitores.Image")));
            this.btLocalizarLeitores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLocalizarLeitores.Location = new System.Drawing.Point(594, 17);
            this.btLocalizarLeitores.Name = "btLocalizarLeitores";
            this.btLocalizarLeitores.Size = new System.Drawing.Size(137, 30);
            this.btLocalizarLeitores.TabIndex = 46;
            this.btLocalizarLeitores.Text = "LOCALIZAR";
            this.btLocalizarLeitores.UseVisualStyleBackColor = false;
            this.btLocalizarLeitores.Click += new System.EventHandler(this.btLocalizarLeitores_Click);
            // 
            // lblNomeLeitor
            // 
            this.lblNomeLeitor.AutoSize = true;
            this.lblNomeLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeLeitor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNomeLeitor.Location = new System.Drawing.Point(219, 24);
            this.lblNomeLeitor.Name = "lblNomeLeitor";
            this.lblNomeLeitor.Size = new System.Drawing.Size(344, 15);
            this.lblNomeLeitor.TabIndex = 45;
            this.lblNomeLeitor.Text = "Digita o Código do Leitor ou clica no botão Localizar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Código do Leitor";
            // 
            // txtCodigoLeitor
            // 
            this.txtCodigoLeitor.Location = new System.Drawing.Point(105, 23);
            this.txtCodigoLeitor.Name = "txtCodigoLeitor";
            this.txtCodigoLeitor.Size = new System.Drawing.Size(99, 20);
            this.txtCodigoLeitor.TabIndex = 0;
            this.txtCodigoLeitor.TextChanged += new System.EventHandler(this.txtCodigoLeitor_TextChanged);
            this.txtCodigoLeitor.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigoLeitor_Validating);
            // 
            // groupBox_Livros
            // 
            this.groupBox_Livros.Controls.Add(this.btLocalizarLivro);
            this.groupBox_Livros.Controls.Add(this.groupBox_SituacaoLivro);
            this.groupBox_Livros.Controls.Add(this.btEfectuarReserva);
            this.groupBox_Livros.Controls.Add(this.btLocalizarReserva);
            this.groupBox_Livros.Controls.Add(this.btCancelarReserva);
            this.groupBox_Livros.Controls.Add(this.btAdicionarLivroParaReservar);
            this.groupBox_Livros.Controls.Add(this.groupBox_LivrosReservados);
            this.groupBox_Livros.Controls.Add(this.label5);
            this.groupBox_Livros.Controls.Add(this.dtDataLimiteReserva);
            this.groupBox_Livros.Controls.Add(this.label4);
            this.groupBox_Livros.Controls.Add(this.dtDataReserva);
            this.groupBox_Livros.Controls.Add(this.lblTituloLivro);
            this.groupBox_Livros.Controls.Add(this.label3);
            this.groupBox_Livros.Controls.Add(this.txtCodigoLivro);
            this.groupBox_Livros.ForeColor = System.Drawing.Color.Blue;
            this.groupBox_Livros.Location = new System.Drawing.Point(12, 95);
            this.groupBox_Livros.Name = "groupBox_Livros";
            this.groupBox_Livros.Size = new System.Drawing.Size(882, 369);
            this.groupBox_Livros.TabIndex = 1;
            this.groupBox_Livros.TabStop = false;
            this.groupBox_Livros.Text = "Livros";
            // 
            // groupBox_SituacaoLivro
            // 
            this.groupBox_SituacaoLivro.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_SituacaoLivro.Controls.Add(this.label1);
            this.groupBox_SituacaoLivro.Controls.Add(this.txtTotal_ExemplarDisponiveis);
            this.groupBox_SituacaoLivro.Controls.Add(this.radioButtonLivroEmprestado);
            this.groupBox_SituacaoLivro.Controls.Add(this.radioButtonDisponivel);
            this.groupBox_SituacaoLivro.Controls.Add(this.radioButtonLivroReservado);
            this.groupBox_SituacaoLivro.ForeColor = System.Drawing.Color.Blue;
            this.groupBox_SituacaoLivro.Location = new System.Drawing.Point(6, 91);
            this.groupBox_SituacaoLivro.Name = "groupBox_SituacaoLivro";
            this.groupBox_SituacaoLivro.Size = new System.Drawing.Size(210, 212);
            this.groupBox_SituacaoLivro.TabIndex = 62;
            this.groupBox_SituacaoLivro.TabStop = false;
            this.groupBox_SituacaoLivro.Text = "Situação do Livro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(2, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Total de Exemplares de Livros Disponiveis";
            // 
            // txtTotal_ExemplarDisponiveis
            // 
            this.txtTotal_ExemplarDisponiveis.Location = new System.Drawing.Point(28, 161);
            this.txtTotal_ExemplarDisponiveis.Name = "txtTotal_ExemplarDisponiveis";
            this.txtTotal_ExemplarDisponiveis.ReadOnly = true;
            this.txtTotal_ExemplarDisponiveis.Size = new System.Drawing.Size(151, 20);
            this.txtTotal_ExemplarDisponiveis.TabIndex = 45;
            // 
            // radioButtonLivroEmprestado
            // 
            this.radioButtonLivroEmprestado.AutoCheck = false;
            this.radioButtonLivroEmprestado.Enabled = false;
            this.radioButtonLivroEmprestado.ForeColor = System.Drawing.Color.Black;
            this.radioButtonLivroEmprestado.Location = new System.Drawing.Point(16, 74);
            this.radioButtonLivroEmprestado.Name = "radioButtonLivroEmprestado";
            this.radioButtonLivroEmprestado.Size = new System.Drawing.Size(114, 28);
            this.radioButtonLivroEmprestado.TabIndex = 2;
            this.radioButtonLivroEmprestado.TabStop = true;
            this.radioButtonLivroEmprestado.Text = "Livro Emprestado";
            this.radioButtonLivroEmprestado.UseVisualStyleBackColor = true;
            // 
            // radioButtonDisponivel
            // 
            this.radioButtonDisponivel.AutoCheck = false;
            this.radioButtonDisponivel.Enabled = false;
            this.radioButtonDisponivel.ForeColor = System.Drawing.Color.Black;
            this.radioButtonDisponivel.Location = new System.Drawing.Point(16, 108);
            this.radioButtonDisponivel.Name = "radioButtonDisponivel";
            this.radioButtonDisponivel.Size = new System.Drawing.Size(114, 28);
            this.radioButtonDisponivel.TabIndex = 1;
            this.radioButtonDisponivel.TabStop = true;
            this.radioButtonDisponivel.Text = "Livro Disponível";
            this.radioButtonDisponivel.UseVisualStyleBackColor = true;
            // 
            // radioButtonLivroReservado
            // 
            this.radioButtonLivroReservado.AutoCheck = false;
            this.radioButtonLivroReservado.Enabled = false;
            this.radioButtonLivroReservado.ForeColor = System.Drawing.Color.Black;
            this.radioButtonLivroReservado.Location = new System.Drawing.Point(16, 37);
            this.radioButtonLivroReservado.Name = "radioButtonLivroReservado";
            this.radioButtonLivroReservado.Size = new System.Drawing.Size(114, 31);
            this.radioButtonLivroReservado.TabIndex = 0;
            this.radioButtonLivroReservado.TabStop = true;
            this.radioButtonLivroReservado.Text = "Livro Reservado";
            this.radioButtonLivroReservado.UseVisualStyleBackColor = true;
            // 
            // btEfectuarReserva
            // 
            this.btEfectuarReserva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btEfectuarReserva.Image = ((System.Drawing.Image)(resources.GetObject("btEfectuarReserva.Image")));
            this.btEfectuarReserva.Location = new System.Drawing.Point(391, 314);
            this.btEfectuarReserva.Name = "btEfectuarReserva";
            this.btEfectuarReserva.Size = new System.Drawing.Size(144, 46);
            this.btEfectuarReserva.TabIndex = 61;
            this.btEfectuarReserva.Text = "Efectuar Reserva";
            this.btEfectuarReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEfectuarReserva.UseVisualStyleBackColor = true;
            this.btEfectuarReserva.Click += new System.EventHandler(this.btEfectuarReserva_Click);
            // 
            // btLocalizarReserva
            // 
            this.btLocalizarReserva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLocalizarReserva.Image = ((System.Drawing.Image)(resources.GetObject("btLocalizarReserva.Image")));
            this.btLocalizarReserva.Location = new System.Drawing.Point(211, 314);
            this.btLocalizarReserva.Name = "btLocalizarReserva";
            this.btLocalizarReserva.Size = new System.Drawing.Size(174, 46);
            this.btLocalizarReserva.TabIndex = 60;
            this.btLocalizarReserva.Text = "Buscar Livros Reservados";
            this.btLocalizarReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLocalizarReserva.UseVisualStyleBackColor = true;
            this.btLocalizarReserva.Click += new System.EventHandler(this.btLocalizarReserva_Click);
            // 
            // btCancelarReserva
            // 
            this.btCancelarReserva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCancelarReserva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCancelarReserva.Image = ((System.Drawing.Image)(resources.GetObject("btCancelarReserva.Image")));
            this.btCancelarReserva.Location = new System.Drawing.Point(541, 314);
            this.btCancelarReserva.Name = "btCancelarReserva";
            this.btCancelarReserva.Size = new System.Drawing.Size(144, 46);
            this.btCancelarReserva.TabIndex = 59;
            this.btCancelarReserva.Text = "Cancelar Reservar";
            this.btCancelarReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // btAdicionarLivroParaReservar
            // 
            this.btAdicionarLivroParaReservar.BackColor = System.Drawing.Color.White;
            this.btAdicionarLivroParaReservar.ForeColor = System.Drawing.Color.DarkRed;
            this.btAdicionarLivroParaReservar.Image = ((System.Drawing.Image)(resources.GetObject("btAdicionarLivroParaReservar.Image")));
            this.btAdicionarLivroParaReservar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdicionarLivroParaReservar.Location = new System.Drawing.Point(742, 17);
            this.btAdicionarLivroParaReservar.Name = "btAdicionarLivroParaReservar";
            this.btAdicionarLivroParaReservar.Size = new System.Drawing.Size(137, 30);
            this.btAdicionarLivroParaReservar.TabIndex = 53;
            this.btAdicionarLivroParaReservar.Text = "Adicionar Livro";
            this.btAdicionarLivroParaReservar.UseVisualStyleBackColor = false;
            this.btAdicionarLivroParaReservar.Click += new System.EventHandler(this.btAdicionarLivroParaReservar_Click);
            // 
            // groupBox_LivrosReservados
            // 
            this.groupBox_LivrosReservados.Controls.Add(this.dgvListaLivrosReservados);
            this.groupBox_LivrosReservados.ForeColor = System.Drawing.Color.Blue;
            this.groupBox_LivrosReservados.Location = new System.Drawing.Point(222, 91);
            this.groupBox_LivrosReservados.Name = "groupBox_LivrosReservados";
            this.groupBox_LivrosReservados.Size = new System.Drawing.Size(652, 212);
            this.groupBox_LivrosReservados.TabIndex = 52;
            this.groupBox_LivrosReservados.TabStop = false;
            this.groupBox_LivrosReservados.Text = "Livros Reservados";
            // 
            // dgvListaLivrosReservados
            // 
            this.dgvListaLivrosReservados.AllowUserToAddRows = false;
            this.dgvListaLivrosReservados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaLivrosReservados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_Leitor,
            this.codLivro,
            this.tituloLivro,
            this.dt_LimteBusaca});
            this.dgvListaLivrosReservados.Location = new System.Drawing.Point(6, 21);
            this.dgvListaLivrosReservados.MultiSelect = false;
            this.dgvListaLivrosReservados.Name = "dgvListaLivrosReservados";
            this.dgvListaLivrosReservados.ReadOnly = true;
            this.dgvListaLivrosReservados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaLivrosReservados.Size = new System.Drawing.Size(640, 178);
            this.dgvListaLivrosReservados.TabIndex = 51;
            this.dgvListaLivrosReservados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaLivrosReservados_CellDoubleClick);
            // 
            // cod_Leitor
            // 
            this.cod_Leitor.HeaderText = "Cód. Leitor";
            this.cod_Leitor.Name = "cod_Leitor";
            this.cod_Leitor.ReadOnly = true;
            this.cod_Leitor.Width = 82;
            // 
            // codLivro
            // 
            this.codLivro.HeaderText = "Cód. Livro";
            this.codLivro.Name = "codLivro";
            this.codLivro.ReadOnly = true;
            this.codLivro.Width = 82;
            // 
            // tituloLivro
            // 
            this.tituloLivro.HeaderText = "Titulo do Livro";
            this.tituloLivro.Name = "tituloLivro";
            this.tituloLivro.ReadOnly = true;
            this.tituloLivro.Width = 200;
            // 
            // dt_LimteBusaca
            // 
            this.dt_LimteBusaca.HeaderText = "Buscar até";
            this.dt_LimteBusaca.Name = "dt_LimteBusaca";
            this.dt_LimteBusaca.ReadOnly = true;
            this.dt_LimteBusaca.Width = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(218, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Data Limite da Busca do Livro";
            // 
            // dtDataLimiteReserva
            // 
            this.dtDataLimiteReserva.Checked = false;
            this.dtDataLimiteReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataLimiteReserva.Location = new System.Drawing.Point(372, 56);
            this.dtDataLimiteReserva.Name = "dtDataLimiteReserva";
            this.dtDataLimiteReserva.Size = new System.Drawing.Size(99, 20);
            this.dtDataLimiteReserva.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(11, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Data da Reserva";
            // 
            // dtDataReserva
            // 
            this.dtDataReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataReserva.Location = new System.Drawing.Point(106, 56);
            this.dtDataReserva.Name = "dtDataReserva";
            this.dtDataReserva.Size = new System.Drawing.Size(99, 20);
            this.dtDataReserva.TabIndex = 47;
            // 
            // lblTituloLivro
            // 
            this.lblTituloLivro.AutoSize = true;
            this.lblTituloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLivro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTituloLivro.Location = new System.Drawing.Point(218, 21);
            this.lblTituloLivro.Name = "lblTituloLivro";
            this.lblTituloLivro.Size = new System.Drawing.Size(338, 15);
            this.lblTituloLivro.TabIndex = 45;
            this.lblTituloLivro.Text = "Digita o Código do Livro ou clica no botão Localizar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(10, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Código do Livro";
            // 
            // txtCodigoLivro
            // 
            this.txtCodigoLivro.Location = new System.Drawing.Point(105, 21);
            this.txtCodigoLivro.Name = "txtCodigoLivro";
            this.txtCodigoLivro.Size = new System.Drawing.Size(99, 20);
            this.txtCodigoLivro.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(550, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Código da Reserva";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(659, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(99, 20);
            this.textBox2.TabIndex = 45;
            // 
            // btLocalizarLivro
            // 
            this.btLocalizarLivro.BackColor = System.Drawing.Color.White;
            this.btLocalizarLivro.ForeColor = System.Drawing.Color.DarkRed;
            this.btLocalizarLivro.Image = ((System.Drawing.Image)(resources.GetObject("btLocalizarLivro.Image")));
            this.btLocalizarLivro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLocalizarLivro.Location = new System.Drawing.Point(594, 17);
            this.btLocalizarLivro.Name = "btLocalizarLivro";
            this.btLocalizarLivro.Size = new System.Drawing.Size(137, 30);
            this.btLocalizarLivro.TabIndex = 63;
            this.btLocalizarLivro.Text = "LOCALIZAR";
            this.btLocalizarLivro.UseVisualStyleBackColor = false;
            this.btLocalizarLivro.Click += new System.EventHandler(this.btLocalizarLivro_Click);
            // 
            // FrmCadastrarReservarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(898, 474);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox_Livros);
            this.Controls.Add(this.groupBox_Leitores);
            this.MaximizeBox = false;
            this.Name = "FrmCadastrarReservarLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RESERVA DE LIVROS - OBRAS";
            this.groupBox_Leitores.ResumeLayout(false);
            this.groupBox_Leitores.PerformLayout();
            this.groupBox_Livros.ResumeLayout(false);
            this.groupBox_Livros.PerformLayout();
            this.groupBox_SituacaoLivro.ResumeLayout(false);
            this.groupBox_SituacaoLivro.PerformLayout();
            this.groupBox_LivrosReservados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLivrosReservados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Leitores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoLeitor;
        private System.Windows.Forms.Button btLocalizarLeitores;
        private System.Windows.Forms.GroupBox groupBox_Livros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoLivro;
        private System.Windows.Forms.GroupBox groupBox_LivrosReservados;
        private System.Windows.Forms.DataGridView dgvListaLivrosReservados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtDataLimiteReserva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDataReserva;
        private System.Windows.Forms.Button btAdicionarLivroParaReservar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btLocalizarReserva;
        private System.Windows.Forms.Button btCancelarReserva;
        private System.Windows.Forms.Button btEfectuarReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Leitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_LimteBusaca;
        private System.Windows.Forms.GroupBox groupBox_SituacaoLivro;
        private System.Windows.Forms.RadioButton radioButtonDisponivel;
        private System.Windows.Forms.RadioButton radioButtonLivroReservado;
        private System.Windows.Forms.RadioButton radioButtonLivroEmprestado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal_ExemplarDisponiveis;
        private System.Windows.Forms.Button btLocalizarLivro;
        public System.Windows.Forms.Label lblNomeLeitor;
        public System.Windows.Forms.Label lblTituloLivro;
    }
}