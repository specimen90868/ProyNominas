using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xml.Core
{
    public class XmlCancelados
    {
        public int id { get; set; }
        public int folio { get; set; }
        public int idempresa { get; set; }
        public string uuid { get; set; }
        public DateTime fecha { get; set; }
        public string respuesta { get; set; }
        public string acuse { get; set; }
        public string xml { get; set; }
    }
}
