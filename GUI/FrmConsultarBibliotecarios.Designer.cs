namespace GUI
{
    partial class FrmConsultarBibliotecarios
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
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dgvDadosBibliotecarios = new System.Windows.Forms.DataGridView();
            this.id_bibliotecario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosBibliotecarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informe o Nome do Bibliotecário (a) Para Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(274, 42);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(372, 20);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // dgvDadosBibliotecarios
            // 
            this.dgvDadosBibliotecarios.AllowUserToAddRows = false;
            this.dgvDadosBibliotecarios.AllowUserToDeleteRows = false;
            this.dgvDadosBibliotecarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDadosBibliotecarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosBibliotecarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_bibliotecario,
            this.nome,
            this.senha,
            this.usuario,
            this.email,
            this.telefone,
            this.funcao});
            this.dgvDadosBibliotecarios.Location = new System.Drawing.Point(12, 79);
            this.dgvDadosBibliotecarios.MultiSelect = false;
            this.dgvDadosBibliotecarios.Name = "dgvDadosBibliotecarios";
            this.dgvDadosBibliotecarios.ReadOnly = true;
            this.dgvDadosBibliotecarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosBibliotecarios.Size = new System.Drawing.Size(745, 294);
            this.dgvDadosBibliotecarios.TabIndex = 5;
            this.dgvDadosBibliotecarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDadosBibliotecarios_CellDoubleClick);
            // 
            // id_bibliotecario
            // 
            this.id_bibliotecario.DataPropertyName = "id_bibliotecario";
            this.id_bibliotecario.FillWeight = 59F;
            this.id_bibliotecario.HeaderText = "Código";
            this.id_bibliotecario.Name = "id_bibliotecario";
            this.id_bibliotecario.ReadOnly = true;
            this.id_bibliotecario.Width = 50;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome ";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 150;
            // 
            // senha
            // 
            this.senha.DataPropertyName = "senha";
            this.senha.HeaderText = "Senha";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "Login";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.ToolTipText = "Nome de Login do Usuário";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "E-Mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            // 
            // funcao
            // 
            this.funcao.DataPropertyName = "funcao";
            this.funcao.HeaderText = "Perfil";
            this.funcao.Name = "funcao";
            this.funcao.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 17);
            this.panel1.TabIndex = 65;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.MediumBlue;
            this.panel2.Location = new System.Drawing.Point(-2, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 20);
            this.panel2.TabIndex = 66;
            // 
            // FrmConsultarBibliotecarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(769, 409);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDadosBibliotecarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisar);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmConsultarBibliotecarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Usuários - Bibliotecários";
            this.Load += new System.EventHandler(this.FrmConsultarBibliotecarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosBibliotecarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dgvDadosBibliotecarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_bibliotecario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcao;
    }
}