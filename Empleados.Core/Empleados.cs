﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados.Core
{
    public class Empleados
    {
        public int idtrabajador { get; set; }
        public string noempleado { get; set; }
        public string nombres { get; set; }
        public string paterno { get; set; }
        public string materno { get; set; }
        public string nombrecompleto { get; set; }
        public int idempresa { get; set; }
        public int idperiodo { get; set; }
        public int idsalario { get; set; }
        public int iddepartamento { get; set; }
        public int idpuesto { get; set; }
        public DateTime fechaingreso { get; set; }
        public int antiguedad { get; set; }
        public DateTime fechaantiguedad { get; set; }
        public int antiguedadmod { get; set; }
        public DateTime fechanacimiento { get; set; }
        public int edad { get; set; }
        public string rfc { get; set; }
        public string curp { get; set; }
        public string nss { get; set; }
        public int digitoverificador { get; set; }
        public int tiposalario { get; set; }
        public decimal sdi { get; set; }
        public decimal sd { get; set; }
        public decimal sueldo { get; set; }
        public int estatus { get; set; }
        public int idusuario { get; set; }
        public string cuenta { get; set; }
        public string clabe { get; set; }
        public string idbancario { get; set; }
        public string metodopago { get; set; }
        public int tiporegimen { get; set; }
        public bool obracivil { get; set; }
    }

    public class IncrementoSalarial
    {
        public int chk { get; set; }
        public int idtrabajador { get; set; }
        public int noempleado { get; set; }
        public string nombre { get; set; }
        public decimal sdivigente { get; set; }
        public decimal sdinuevo { get; set; }
        public int antiguedad { get; set; }
        public int antiguedadmod { get; set; }
        public DateTime fechaimss { get; set; }
    }

    public class EmpleadosEstatus
    {
        public int id { get; set; }
        public int idtrabajador { get; set; }
        public int idempresa { get; set; }
        public int estatus { get; set; }
    }

    public class CatalogoEmpleado
    {
        public int rownumber { get; set; }
        public int idtrabajador { get; set; }
        public string noempleado { get; set; }
        public string paterno { get; set; }
        public string materno { get; set; }
        public string nombres { get; set; }
        public string nombrecompleto { get; set; }
        public string curp { get; set; }
        public DateTime fechaingreso { get; set; }
        public int antiguedad { get; set; }
        public decimal sdi { get; set; }
        public decimal sd { get; set; }
        public decimal sueldo { get; set; }
        public string cuenta { get; set; }
        public string estatus { get; set; }
        public string departamento { get; set; }
        public string puesto { get; set; }
        public string fechabaja { get; set; }
    }
}
