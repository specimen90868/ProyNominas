using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nominas
{
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/nomina12", IsNullable = false)]
    public class Nomina
    {
        #region REQUERIDOS
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoNomina { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public DateTime FechaPago { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public DateTime FechaInicialPago { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public DateTime FechaFinalPago { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal NumDiasPagados { get; set; }

        public NominaEmisor Emisor { get; set; }

        public NominaReceptor Receptor { get; set; }

        public Percepciones Percepciones { get; set; }

        public Deducciones Deducciones { get; set; }

        #endregion

        public Nomina()
        {
            this.Version = "1.2";
        }

        #region OPCIONALES

        private decimal TotalPercepcionesField;

        private bool TotalPercepcionesFieldSpecified;
        
        private decimal TotalDeduccionesField;

        private bool TotalDeduccionesFieldSpecified;

        private decimal TotalOtrosPagosField;

        private bool TotalOtrosPagosFieldSpecified;

        private OtrosPagos OtrosPagosField;

        private bool OtrosPagosFieldSpecified;

        private Incapacidad[] IncapacidadesField;

        private bool IncapacidadesFieldSpecified;


        public Incapacidad[] Incapacidades
        {
            get { return IncapacidadesField; }
            set { IncapacidadesField = value; }
        }

        [System.Xml.Serialization.XmlIgnore()]
        public bool IncapacidadesSpecified
        {
            get { return IncapacidadesFieldSpecified; }
            set { IncapacidadesFieldSpecified = value; }
        }


        public OtrosPagos OtrosPagos
        {
            get { return OtrosPagosField; }
            set { OtrosPagosField = value; }
        }

        [System.Xml.Serialization.XmlIgnore()]
        public bool OtrosPagosSpecified
        {
            get { return OtrosPagosFieldSpecified; }
            set { OtrosPagosFieldSpecified = value; }
        }



        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalPercepciones
        {
            get {
                return this.TotalPercepcionesField;
            }
            set {
                this.TotalPercepcionesField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalPercepcionesSpecified
        {
            get
            {
                return this.TotalPercepcionesFieldSpecified;
            }
            set
            {
                this.TotalPercepcionesFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalDeducciones
        {
            get
            {
                return this.TotalDeduccionesField;
            }
            set
            {
                this.TotalDeduccionesField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalDeduccionesSpecified
        {
            get
            {
                return this.TotalDeduccionesFieldSpecified;
            }
            set
            {
                this.TotalDeduccionesFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalOtrosPagos
        {
            get
            {
                return this.TotalOtrosPagosField;
            }
            set
            {
                this.TotalOtrosPagosField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalOtrosPagosSpecified
        {
            get
            {
                return this.TotalOtrosPagosFieldSpecified;
            }
            set
            {
                this.TotalOtrosPagosFieldSpecified = value;
            }
        }

        #endregion

    }

    
    public class NominaEmisor
    {
        private string RegistroPatronalField;

        private bool RegistroPatronalFieldSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RegistroPatronal
        {
            get
            {
                return this.RegistroPatronalField;
            }
            set
            {
                this.RegistroPatronalField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RegistroPatronalSpecified
        {
            get
            {
                return this.RegistroPatronalFieldSpecified;
            }
            set
            {
                this.RegistroPatronalFieldSpecified = value;
            }
        }
    }
    
    public class NominaReceptor
    {
        #region REQUERIDOS
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Curp { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoContrato { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoRegimen { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumEmpleado { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PeriodicidadPago { get; set; }
       
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaveEntFed { get; set; }
        #endregion

        #region OPCIONALES
        private string NumSeguridadSocialField; //Opcional

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumSeguridadSocial
        {
            get { return NumSeguridadSocialField; }
            set { NumSeguridadSocialField = value; }
        }

        private bool NumSeguridadSocialFieldSpecified;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumSeguridadSocialSpecified
        {
            get { return NumSeguridadSocialFieldSpecified; }
            set { NumSeguridadSocialFieldSpecified = value; }
        }

        private DateTime FechaInicioRelLaboralField; //Opcional

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public DateTime FechaInicioRelLaboral
        {
            get { return FechaInicioRelLaboralField; }
            set { FechaInicioRelLaboralField = value; }
        }

        private bool FechaInicioRelLaboralFieldSpecified;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FechaInicioRelLaboralSpecified
        {
            get { return FechaInicioRelLaboralFieldSpecified; }
            set { FechaInicioRelLaboralFieldSpecified = value; }
        }

        private string AntiguedadField; //Opcional

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="Antigüedad")]
        public string Antiguedad
        {
            get { return AntiguedadField; }
            set { AntiguedadField = value; }
        }

        private bool AntiguedadFieldSpecified;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AntiguedadSpecified
        {
            get { return AntiguedadFieldSpecified; }
            set { AntiguedadFieldSpecified = value; }
        }

        private string DepartamentoField; //Opcional

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Departamento
        {
            get { return DepartamentoField; }
            set { DepartamentoField = value; }
        }

        private bool DepartamentoFieldSpecified;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DepartamentoSpecified
        {
            get { return DepartamentoFieldSpecified; }
            set { DepartamentoFieldSpecified = value; }
        }

        private string PuestoField; //Opcional

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Puesto
        {
            get { return PuestoField; }
            set { PuestoField = value; }
        }

        private bool PuestoFieldSpecified;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PuestoSpecified
        {
            get { return PuestoFieldSpecified; }
            set { PuestoFieldSpecified = value; }
        }

        private int RiesgoPuestoField; //Opcional

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int RiesgoPuesto
        {
            get { return RiesgoPuestoField; }
            set { RiesgoPuestoField = value; }
        }

        private bool RiesgoPuestoFieldSpecified;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RiesgoPuestoSpecified
        {
            get { return RiesgoPuestoFieldSpecified; }
            set { RiesgoPuestoFieldSpecified = value; }
        }

        private decimal SalarioDiarioIntegradoField;  //Opcional

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SalarioDiarioIntegrado
        {
            get { return SalarioDiarioIntegradoField; }
            set { SalarioDiarioIntegradoField = value; }
        }

        private bool SalarioDiarioIntegradoFieldSpecified;
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SalarioDiarioIntegradoSpecified
        {
            get { return SalarioDiarioIntegradoFieldSpecified; }
            set { SalarioDiarioIntegradoFieldSpecified = value; }
        }

        #endregion
    }

    
    public class Percepciones
    {
        #region REQUERIDOS
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalGravado { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalExento { get; set; }

        [System.Xml.Serialization.XmlElementAttribute()]
        public Percepcion[] Percepcion { get; set; }
        #endregion

        #region OPCIONALES

        private decimal TotalSueldosField;
 
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalSueldos
        {
            get { return TotalSueldosField; }
            set { TotalSueldosField = value; }
        }

        private bool TotalSueldosFieldSpecified;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalSueldosSpecified
        {
            get { return TotalSueldosFieldSpecified; }
            set { TotalSueldosFieldSpecified = value; }
        }

        private decimal TotalSeparacionIndemnizacionField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalSeparacionIndemnizacion
        {
            get { return TotalSeparacionIndemnizacionField;  }
            set { TotalSeparacionIndemnizacionField = value; }
        }

        private bool TotalSeparacionIndemnizacionFieldSpecified;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalSeparacionIndemnizacionSpecified
        {
            get { return TotalSeparacionIndemnizacionFieldSpecified; }
            set { TotalSeparacionIndemnizacionFieldSpecified = value; }
        }

        private SeparacionIndemnizacion SeparacionIndemnizacionField;

        [System.Xml.Serialization.XmlElementAttribute()]
        public SeparacionIndemnizacion SeparacionIndemnizacion
        {
            get { return SeparacionIndemnizacionField; }
            set { SeparacionIndemnizacionField = value; }
        }

        private bool SeparacionIndemnizacionFieldSpecified;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SeparacionIndemnizacionSpecified
        {
            get { return SeparacionIndemnizacionFieldSpecified; }
            set { SeparacionIndemnizacionFieldSpecified = value; }
        }

        #endregion
    }

    
    public class Percepcion
    {

        #region REQUERIDOS
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoPercepcion { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Clave { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Concepto { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ImporteGravado { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ImporteExento { get; set; }
        #endregion
  
        #region OPCIONALES

        private NominaHorasExtra HorasExtraField;
        private bool HorasExtraFieldSpecified;

        [System.Xml.Serialization.XmlElementAttribute()]
        public NominaHorasExtra HorasExtra
        {
          get { return HorasExtraField; }
          set { HorasExtraField = value; }
        }

        [System.Xml.Serialization.XmlIgnore()]
        public bool HorasExtraSpecified
        {
          get { return HorasExtraFieldSpecified; }
          set { HorasExtraFieldSpecified = value; }
        }

        #endregion

    }

    public class NominaHorasExtra
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Dias { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoHoras { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int HorasExtra { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ImportePagado { get; set; }
    }


    public class Deducciones
    {

        #region REQUERIDOS

        [System.Xml.Serialization.XmlElementAttribute()]
        public Deduccion[] Deduccion { get; set; }

        #endregion

        #region OPCIONALES

        private decimal TotalOtrasDeduccionesField;

        private bool TotalOtrasDeduccionesFieldSpecified;

        private decimal TotalImpuestosRetenidosField;

        private bool TotalImpuestosRetenidosFieldSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalOtrasDeducciones
        {
            get { return TotalOtrasDeduccionesField; }
            set { TotalOtrasDeduccionesField = value; }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalOtrasDeduccionesSpecified
        {
            get { return TotalOtrasDeduccionesFieldSpecified; }
            set { TotalOtrasDeduccionesFieldSpecified = value; }
        }

        

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalImpuestosRetenidos
        {
            get { return TotalImpuestosRetenidosField; }
            set { TotalImpuestosRetenidosField = value; }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalImpuestosRetenidosSpecified
        {
            get { return TotalImpuestosRetenidosFieldSpecified; }
            set { TotalImpuestosRetenidosFieldSpecified = value; }
        }
        #endregion

    }

    
    public class Deduccion
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoDeduccion { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Clave { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Concepto { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Importe { get; set; }
    }


    public class OtrosPagos
    {
        public OtroPago OtroPago { get; set; }
    }
    

    public class OtroPago
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoOtroPago { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Clave { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Concepto { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Importe { get; set; }

        private SubsidioAlEmpleo SubsidioAlEmpleoField;
        private bool SubsidioAlEmpleoFieldSpecified;

        [System.Xml.Serialization.XmlElementAttribute()]
        public SubsidioAlEmpleo SubsidioAlEmpleo
        {
            get { return SubsidioAlEmpleoField; }
            set { SubsidioAlEmpleoField = value; }
        }

        [System.Xml.Serialization.XmlIgnore()]
        public bool SubsidioAlEmpleoSpecified
        {
            get { return SubsidioAlEmpleoFieldSpecified; }
            set { SubsidioAlEmpleoFieldSpecified = value; }
        }
    }

       
    public class Incapacidad
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int DiasIncapacidad { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoIncapacidad { get; set; }
    }


    public class SubsidioAlEmpleo
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SubsidioCausado { get; set; }
    }

    public class SeparacionIndemnizacion
    {
        #region REQUERIDOS

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalPagado { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int NumAñosServicio { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal UltimoSueldoMensOrd { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal IngresoAcumulable { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal IngresoNoAcumulable { get; set; }

        #endregion
    }


}
