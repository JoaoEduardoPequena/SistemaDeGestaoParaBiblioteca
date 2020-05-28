namespace GUI
{
    partial class FrmEnviarSMS
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
            this.txtNumeroTelefone = new System.Windows.Forms.TextBox();
            this.txtTextoMensagem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btEnviarMensagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número do Telefone";
            // 
            // txtNumeroTelefone
            // 
            this.txtNumeroTelefone.Location = new System.Drawing.Point(36, 31);
            this.txtNumeroTelefone.Name = "txtNumeroTelefone";
            this.txtNumeroTelefone.Size = new System.Drawing.Size(374, 20);
            this.txtNumeroTelefone.TabIndex = 1;
            // 
            // txtTextoMensagem
            // 
            this.txtTextoMensagem.Location = new System.Drawing.Point(36, 77);
            this.txtTextoMensagem.Multiline = true;
            this.txtTextoMensagem.Name = "txtTextoMensagem";
            this.txtTextoMensagem.Size = new System.Drawing.Size(374, 115);
            this.txtTextoMensagem.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Texto da Mensagem";
            // 
            // btEnviarMensagem
            // 
            this.btEnviarMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnviarMensagem.Location = new System.Drawing.Point(36, 198);
            this.btEnviarMensagem.Name = "btEnviarMensagem";
            this.btEnviarMensagem.Size = new System.Drawing.Size(130, 38);
            this.btEnviarMensagem.TabIndex = 4;
            this.btEnviarMensagem.Text = "Enviar Mensagem";
            this.btEnviarMensagem.UseVisualStyleBackColor = true;
            this.btEnviarMensagem.Click += new System.EventHandler(this.btEnviarMensagem_Click);
            // 
            // FrmEnviarSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 243);
            this.Controls.Add(this.btEnviarMensagem);
            this.Controls.Add(this.txtTextoMensagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroTelefone);
            this.Controls.Add(this.label1);
            this.Name = "FrmEnviarSMS";
            this.Text = "FrmEnviarSMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNumeroTelefone;
        public System.Windows.Forms.TextBox txtTextoMensagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btEnviarMensagem;
    }
}