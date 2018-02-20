using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosNominales.Core
{
    public class PeriodosNominales
    {
        public int id { get; set; }
        public int idempresa { get; set; }
        public int anio { get; set; }
        public int noperiodo { get; set; }
        public DateTime fechainicio { get; set; }
        public DateTime fechafin { get; set; }
        public int periodo { get; set; }
        public int tiponomina { get; set; }
    }
}
