using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloEmprestimo
    {
        public int Id_Emprestimo { get; set; }
        public int Id_Reserva { get; set; }
        public int Cod_Leitor { get; set; } 
        public int Id_Livro { get; set; }
        public int Id_Bibliotecario { get; set; }
        public DateTime Data_Emprestimo { get; set; }
        public DateTime Data_Devolucao { get; set; }
        public DateTime Data_Renovacao { get; set; }
        public string Estado_Emprestimo { get; set; }
    }
}
