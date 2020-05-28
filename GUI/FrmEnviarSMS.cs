using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace GUI
{
    public partial class FrmEnviarSMS : Form
    {
        private AutoResetEvent receiveNow;
        public FrmEnviarSMS()
        {
            InitializeComponent();
        }

        private void btEnviarMensagem_Click(object sender, EventArgs e)
        {
            EnviaSms(txtNumeroTelefone.Text, txtTextoMensagem.Text);
        }

 private bool EnviaSms(string numero, string mensagem)
  {
	using (SerialPort serialPort = new SerialPort())
	{
        numero = txtNumeroTelefone.Text;
        mensagem = txtTextoMensagem.Text;

		bool mensagemEnviada = false;

		try
		{
			receiveNow = new AutoResetEvent(false);
			serialPort.PortName = "COM4";
			serialPort.Handshake = Handshake.RequestToSend;
			serialPort.DtrEnable = true;
			serialPort.RtsEnable = true;
			serialPort.NewLine = Environment.NewLine;
			serialPort.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            serialPort.Open();
			string recievedData = ExecCommand(serialPort, "AT", 300, "Telefonenãoconectado");
			recievedData = ExecCommand(serialPort, "AT+CMGF=1", 300, "Falha no formato da mensagem");
			String command = "AT+CMGS=\"" + numero + "\"";
			recievedData = ExecCommand(serialPort, command, 300, "Falha no número");
			command = mensagem + char.ConvertFromUtf32(26) + "\r";
			recievedData = ExecCommand(serialPort, command, 3000, "Falhaaoenviarmensagem");
			serialPort.Close();
			if (recievedData.EndsWith("\r\nOK\r\n"))
			{
				mensagemEnviada = true;
			}
			else if (recievedData.Contains("ERROR"))
			{
				mensagemEnviada = false;
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("Erro ao enviar SMS: " + ex.Message);
		}
		return mensagemEnviada;
	}
}

private string ExecCommand(SerialPort port, string command, int responseTimeout, string errorMessage)
{
	try
	{
		port.DiscardOutBuffer();
		port.DiscardInBuffer();
		receiveNow.Reset();
		port.Write(command + "\r");

		string input = ReadResponse(port, responseTimeout);
		if ((input.Length == 0) || ((!input.EndsWith("\r\n> ")) && (!input.EndsWith("\r\nOK\r\n"))))
			throw new ApplicationException("No success message was received.");
		return input;
	}
	catch (Exception ex)
	{
		throw ex;
	}
}


public string ReadResponse(SerialPort port, int timeout)
{
	string buffer = string.Empty;
	try
	{
		do
		{
			if (receiveNow.WaitOne(timeout, false))
			{
				string t = port.ReadExisting();
				buffer += t;
			}
			else
			{
				if (buffer.Length> 0)
					throw new ApplicationException("Response received is incomplete.");
				else
					throw new ApplicationException("No data received from phone.");
			}
		}
		while (!buffer.EndsWith("\r\nOK\r\n") && !buffer.EndsWith("\r\n> ") && !buffer.EndsWith("\r\nERROR\r\n"));
	}
	catch (Exception ex)
	{
		throw ex;
	}
	return buffer;
   }


public void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
{
    try
    {
        if (e.EventType == SerialData.Chars)
        {
            receiveNow.Set();
        }
    }
    catch (Exception ex)
    {
        throw ex;
    }
}

 }

 }


