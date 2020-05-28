namespace GUI
{
    partial class FrmCadastroEditora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroEditora));
            this.txtCodEditora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCodEditora
            // 
            this.txtCodEditora.Location = new System.Drawing.Point(116, 29);
            this.txtCodEditora.Name = "txtCodEditora";
            this.txtCodEditora.ReadOnly = true;
            this.txtCodEditora.Size = new System.Drawing.Size(100, 20);
            this.txtCodEditora.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código Editora";
            // 
            // btSalvar
            // 
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.Location = new System.Drawing.Point(144, 122);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(83, 87);
            this.btSalvar.TabIndex = 2;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome da Editora";
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.Location = new System.Drawing.Point(116, 71);
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.Size = new System.Drawing.Size(339, 20);
            this.txtNomeEditora.TabIndex = 0;
            // 
            // btExcluir
            // 
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.Location = new System.Drawing.Point(255, 122);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(83, 87);
            this.btExcluir.TabIndex = 5;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click_1);
            // 
            // btCancelar
            // 
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.Location = new System.Drawing.Point(372, 122);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(83, 87);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btLocalizar.Image")));
            this.btLocalizar.Location = new System.Drawing.Point(28, 122);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(85, 87);
            this.btLocalizar.TabIndex = 7;
            this.btLocalizar.Text = "Localizar";
            this.btLocalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btLocalizar.UseVisualStyleBackColor = true;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // FrmCadastroEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(474, 235);
            this.Controls.Add(this.btLocalizar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeEditora);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodEditora);
            this.MaximizeBox = false;
            this.Name = "FrmCadastroEditora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Editoras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodEditora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeEditora;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btLocalizar;
    }
}