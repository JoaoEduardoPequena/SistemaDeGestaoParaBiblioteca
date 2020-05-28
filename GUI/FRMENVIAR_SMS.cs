using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FRMENVIAR_SMS : Form
    {
        public FRMENVIAR_SMS()
        {
            InitializeComponent();
        }

        private void btEnviarSMS_Click(object sender, EventArgs e)
        {
            using (var port = new System.IO.Ports.SerialPort())
            {
                port.PortName = "COM4";
                port.Open();
                port.DtrEnable = true;
                port.RtsEnable = true;
                port.Write("AT\r"); // iniciando a comunicação
                port.Write("AT+CMGF=1\r"); // setando a comunicação para o modo texto
                port.Write(string.Format("AT+CMGS=\"{0}\"\r",txtTelefone.Text)); // setando o número do destinatário
                port.Write(txtTextoMensagem.Text + char.ConvertFromUtf32(26)); // enviando a mensagem
            }

        }
    }
}
