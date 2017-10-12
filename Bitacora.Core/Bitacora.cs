using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitacora.Core
{
    public class Bitacora
    {
        public int rownuber { get; set; }
        public int id { get; set; }
        public int idusuario { get; set; }
        public string usuario { get; set; }
        public int idtrabajador { get; set; }
        public int idempresa { get; set; }
        public string noempleado { get; set; }
        public string nombre { get; set; }
        public DateTime fecha { get; set; }
        public string tabla { get; set; }
        public string accion { get; set; }
        public string informacion { get; set; }
    }
}
