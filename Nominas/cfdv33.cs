using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nominas
{
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/cfd/3", IsNullable = false)]
    public class Comprobante
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Fecha { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Sello { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FormaPago { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NoCertificado { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Certificado { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SubTotal { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Descuento { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Moneda { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Total { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoDeComprobante { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MetodoPago { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LugarExpedicion { get; set; }

        
        public Emisor Emisor { get; set; }

        public Receptor Receptor { get; set; }

        public ComplementoConceptos Conceptos { get; set; }


        [System.Xml.Serialization.XmlElementAttribute("Complemento")]
        public Complemento Complemento { get; set; }

        public Comprobante() {
            this.Version = "3.3";
            this.MetodoPago = "PUE";
            this.TipoDeComprobante = "N";
            this.FormaPago = "99";
            this.Moneda = "MXN";
        }
    }

    public class Emisor {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Rfc { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Nombre { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RegimenFiscal { get; set; }

    }

    public class Receptor {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Rfc { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Nombre { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UsoCFDI { get; set; }
    }

    public class ComplementoConcepto {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Cantidad { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaveUnidad { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaveProdServ { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Descripcion { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ValorUnitario { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Importe { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Descuento { get; set; }

        public ComplementoConcepto() {
            this.Cantidad = 1;
            this.ClaveUnidad = "ACT";
            this.Descripcion = "Pago de nómina";
            this.ClaveProdServ = "84111505";
        }
    }

    public class ComplementoConceptos
    {
        public ComplementoConcepto Concepto { get; set; }
    }

    public class Complemento
    {
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any { get; set; }
    }
}
