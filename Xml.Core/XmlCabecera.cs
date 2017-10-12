using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xml.Core
{
    public class XmlCabecera
    {
        public int folio { get; set; }
        public int idtrabajador { get; set; }
        public int idempresa { get; set; }
        public DateTime periodoinicio { get; set; }
        public DateTime periodofin { get; set; }
        public string emitido { get; set; }
        public string nocertificado { get; set; }
        public string metododepago { get; set; }
        public string versiontimbrefiscal { get; set; }
        public string uuid { get; set; }
        public string fechatimbrado { get; set; }
        public string sellocfd { get; set; }
        public string nocertificadosat { get; set; }
        public string sellosat { get; set; }
        public string xml { get; set; }
        public byte[] codeqr { get; set; }
        public string error { get; set; }
        public int tiponomina { get; set; }
    }

    public class CodigoBidimensional
    {
        public int folio { get; set; }
        public int idtrabajador { get; set; }
        public string re { get; set; }
        public string rr { get; set; }
        public decimal tt { get; set; }
        public string uuid { get; set; }
    }
}
