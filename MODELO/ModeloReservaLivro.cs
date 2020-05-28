using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloReservaLivro
    {
        public int Id_Reserva { get; set; }
        public int Id_Livro { get; set; }
        public int Cod_Leitor { get; set; }
        public DateTime Data_Reserva { get; set; }
        public DateTime Data_Limite { get; set; }
        public string Estado_Reserva { get; set; }
    }
}
