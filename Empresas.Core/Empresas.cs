using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresas.Core
{
    public class Empresas
    {
        public int idempresa { get; set; }
        public string nombre { get; set; }
        public string rfc { get; set; }
        public string registro { get; set; }
        public int digitoverificador { get; set; }
        public string representante { get; set; }
        public int estatus { get; set; }
        public string certificado { get; set; }
        public string nocertificado { get; set; }
        public string observacion { get; set; }
        public bool obracivil { get; set; }
        public int idregimenfiscal { get; set; }
        public string codigopostal { get; set; }
        public string archivokey { get; set; }
        public string archivocer { get; set; }
        public string passwordkey { get; set; }
        public string usuariopac { get; set; }
        public string passwordpac { get; set; }
    }


}
