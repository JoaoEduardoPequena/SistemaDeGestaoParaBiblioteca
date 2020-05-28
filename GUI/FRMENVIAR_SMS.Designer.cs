namespace GUI
{
    partial class FRMENVIAR_SMS
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
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtTextoMensagem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btEnviarSMS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(99, 25);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(230, 20);
            this.txtTelefone.TabIndex = 0;
            // 
            // txtTextoMensagem
            // 
            this.txtTextoMensagem.Location = new System.Drawing.Point(28, 91);
            this.txtTextoMensagem.Multiline = true;
            this.txtTextoMensagem.Name = "txtTextoMensagem";
            this.txtTextoMensagem.Size = new System.Drawing.Size(310, 54);
            this.txtTextoMensagem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto da Mensagem";
            // 
            // btEnviarSMS
            // 
            this.btEnviarSMS.Location = new System.Drawing.Point(28, 151);
            this.btEnviarSMS.Name = "btEnviarSMS";
            this.btEnviarSMS.Size = new System.Drawing.Size(75, 29);
            this.btEnviarSMS.TabIndex = 4;
            this.btEnviarSMS.Text = "Enviar";
            this.btEnviarSMS.UseVisualStyleBackColor = true;
            this.btEnviarSMS.Click += new System.EventHandler(this.btEnviarSMS_Click);
            // 
            // FRMENVIAR_SMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 186);
            this.Controls.Add(this.btEnviarSMS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTextoMensagem);
            this.Controls.Add(this.txtTelefone);
            this.Name = "FRMENVIAR_SMS";
            this.Text = "FRMENVIAR_SMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtTextoMensagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btEnviarSMS;
    }
}