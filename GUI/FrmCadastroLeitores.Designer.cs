namespace GUI
{
    partial class FrmCadastroLeitores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroLeitores));
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail_Leitor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeLeitor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoLeitor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTelefoneLeitor = new System.Windows.Forms.MaskedTextBox();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "E-Mail";
            // 
            // txtEmail_Leitor
            // 
            this.txtEmail_Leitor.Location = new System.Drawing.Point(81, 88);
            this.txtEmail_Leitor.Name = "txtEmail_Leitor";
            this.txtEmail_Leitor.Size = new System.Drawing.Size(360, 20);
            this.txtEmail_Leitor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nome ";
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.Location = new System.Drawing.Point(81, 51);
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.Size = new System.Drawing.Size(416, 20);
            this.txtNomeLeitor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Código";
            // 
            // txtCodigoLeitor
            // 
            this.txtCodigoLeitor.Location = new System.Drawing.Point(81, 17);
            this.txtCodigoLeitor.Name = "txtCodigoLeitor";
            this.txtCodigoLeitor.ReadOnly = true;
            this.txtCodigoLeitor.Size = new System.Drawing.Size(94, 20);
            this.txtCodigoLeitor.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Telefone";
            // 
            // mskTelefoneLeitor
            // 
            this.mskTelefoneLeitor.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefoneLeitor.Location = new System.Drawing.Point(81, 118);
            this.mskTelefoneLeitor.Mask = "(+244) 000-000-000";
            this.mskTelefoneLeitor.Name = "mskTelefoneLeitor";
            this.mskTelefoneLeitor.Size = new System.Drawing.Size(149, 21);
            this.mskTelefoneLeitor.TabIndex = 2;
            // 
            // btLocalizar
            // 
            this.btLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btLocalizar.Image")));
            this.btLocalizar.Location = new System.Drawing.Point(49, 165);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(85, 87);
            this.btLocalizar.TabIndex = 43;
            this.btLocalizar.Text = "Localizar";
            this.btLocalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btLocalizar.UseVisualStyleBackColor = true;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.Location = new System.Drawing.Point(414, 165);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(83, 87);
            this.btCancelar.TabIndex = 42;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.Location = new System.Drawing.Point(290, 165);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(83, 87);
            this.btExcluir.TabIndex = 41;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.Location = new System.Drawing.Point(164, 165);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(83, 87);
            this.btSalvar.TabIndex = 40;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // FrmCadastroLeitores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(519, 270);
            this.Controls.Add(this.btLocalizar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.mskTelefoneLeitor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail_Leitor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeLeitor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoLeitor);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmCadastroLeitores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Leitores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadastroLeitores_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadastroLeitores_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroLeitores_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail_Leitor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeLeitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoLeitor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTelefoneLeitor;
        private System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSalvar;
    }
}