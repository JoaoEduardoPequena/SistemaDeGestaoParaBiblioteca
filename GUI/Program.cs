using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var cultura = new CultureInfo("pt-PT");
            Thread.CurrentThread.CurrentCulture = cultura;
            Thread.CurrentThread.CurrentUICulture = cultura;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmCadastrarReservarLivros());
            //Application.Run(new FrmCadastroAutores());
            Application.Run(new FrmLoginUsuarios());
            //Application.Run(new Form1() );
            //Application.Run(new FrmRelatorioPersoalizado());
            //Application.Run(new FrmEnviarSMS());
            //Application.Run(new FRMENVIAR_SMS());
            //Application.Run(new FrmCadastroBibliotecarios());
            //Application.Run(new FrmCadastroRenovarEmprestimo());
        }
    }
}
