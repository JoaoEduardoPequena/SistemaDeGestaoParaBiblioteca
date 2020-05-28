namespace GUI
{
    partial class FrmCadastroBibliotecarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroBibliotecarios));
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuarioBibliotecario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaBibliotecario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeBibliotecario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodBibliotecario = new System.Windows.Forms.TextBox();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail_Bibliotecario = new System.Windows.Forms.TextBox();
            this.mskTelefoneBibliotecario = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cboFuncaoBibliotecario = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Login";
            // 
            // txtUsuarioBibliotecario
            // 
            this.txtUsuarioBibliotecario.Location = new System.Drawing.Point(136, 107);
            this.txtUsuarioBibliotecario.Name = "txtUsuarioBibliotecario";
            this.txtUsuarioBibliotecario.Size = new System.Drawing.Size(403, 20);
            this.txtUsuarioBibliotecario.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Senha";
            // 
            // txtSenhaBibliotecario
            // 
            this.txtSenhaBibliotecario.Location = new System.Drawing.Point(136, 136);
            this.txtSenhaBibliotecario.Name = "txtSenhaBibliotecario";
            this.txtSenhaBibliotecario.Size = new System.Drawing.Size(403, 20);
            this.txtSenhaBibliotecario.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nome";
            // 
            // txtNomeBibliotecario
            // 
            this.txtNomeBibliotecario.Location = new System.Drawing.Point(136, 76);
            this.txtNomeBibliotecario.Name = "txtNomeBibliotecario";
            this.txtNomeBibliotecario.Size = new System.Drawing.Size(403, 20);
            this.txtNomeBibliotecario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Código";
            // 
            // txtCodBibliotecario
            // 
            this.txtCodBibliotecario.Location = new System.Drawing.Point(136, 45);
            this.txtCodBibliotecario.Name = "txtCodBibliotecario";
            this.txtCodBibliotecario.ReadOnly = true;
            this.txtCodBibliotecario.Size = new System.Drawing.Size(82, 20);
            this.txtCodBibliotecario.TabIndex = 40;
            // 
            // btLocalizar
            // 
            this.btLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btLocalizar.Image")));
            this.btLocalizar.Location = new System.Drawing.Point(136, 238);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(85, 87);
            this.btLocalizar.TabIndex = 56;
            this.btLocalizar.Text = "Localizar";
            this.btLocalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btLocalizar.UseVisualStyleBackColor = true;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.Location = new System.Drawing.Point(455, 238);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(83, 87);
            this.btCancelar.TabIndex = 55;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.Location = new System.Drawing.Point(350, 238);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(83, 87);
            this.btExcluir.TabIndex = 54;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.Location = new System.Drawing.Point(240, 238);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(83, 87);
            this.btSalvar.TabIndex = 53;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "E-Mail";
            // 
            // txtEmail_Bibliotecario
            // 
            this.txtEmail_Bibliotecario.Location = new System.Drawing.Point(136, 196);
            this.txtEmail_Bibliotecario.Name = "txtEmail_Bibliotecario";
            this.txtEmail_Bibliotecario.Size = new System.Drawing.Size(403, 20);
            this.txtEmail_Bibliotecario.TabIndex = 57;
            // 
            // mskTelefoneBibliotecario
            // 
            this.mskTelefoneBibliotecario.Location = new System.Drawing.Point(138, 165);
            this.mskTelefoneBibliotecario.Mask = "(+244) 000-000-000";
            this.mskTelefoneBibliotecario.Name = "mskTelefoneBibliotecario";
            this.mskTelefoneBibliotecario.Size = new System.Drawing.Size(119, 20);
            this.mskTelefoneBibliotecario.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Telefone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Selecciona o Perfil ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cboFuncaoBibliotecario
            // 
            this.cboFuncaoBibliotecario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboFuncaoBibliotecario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFuncaoBibliotecario.FormattingEnabled = true;
            this.cboFuncaoBibliotecario.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "USUARIO"});
            this.cboFuncaoBibliotecario.Location = new System.Drawing.Point(419, 165);
            this.cboFuncaoBibliotecario.Name = "cboFuncaoBibliotecario";
            this.cboFuncaoBibliotecario.Size = new System.Drawing.Size(120, 21);
            this.cboFuncaoBibliotecario.TabIndex = 63;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 29);
            this.panel1.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.MediumBlue;
            this.panel2.Location = new System.Drawing.Point(-9, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 20);
            this.panel2.TabIndex = 65;
            // 
            // FrmCadastroBibliotecarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 360);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboFuncaoBibliotecario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mskTelefoneBibliotecario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail_Bibliotecario);
            this.Controls.Add(this.btLocalizar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsuarioBibliotecario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenhaBibliotecario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeBibliotecario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodBibliotecario);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmCadastroBibliotecarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários - Bibliotecários";
            this.Load += new System.EventHandler(this.FrmCadastroBibliotecarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsuarioBibliotecario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenhaBibliotecario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeBibliotecario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodBibliotecario;
        private System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail_Bibliotecario;
        private System.Windows.Forms.MaskedTextBox mskTelefoneBibliotecario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cboFuncaoBibliotecario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}