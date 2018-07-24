using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace Empleados.Core
{
    public class EmpleadosHelper : Data.Obj.DataObj
    {
        public List<Empleados> obtenerEmpleados(Empleados e)
        {
            DataTable dtEmpleados = new DataTable();
            List<Empleados> lstEmpleados = new List<Empleados>();
            Command.CommandText = "select idtrabajador, noempleado, paterno, materno, nombres, nombrecompleto, curp, fechaingreso, antiguedad, sdi, sd, sueldo, cuenta, clabe, idbancario from trabajadores where idempresa = @idempresa and estatus = @estatus";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", e.idempresa);
            Command.Parameters.AddWithValue("estatus", e.estatus);
            dtEmpleados = SelectData(Command);

            for (int i = 0; i < dtEmpleados.Rows.Count; i++)
            {
                Empleados empleado = new Empleados();
                empleado.idtrabajador = int.Parse(dtEmpleados.Rows[i]["idtrabajador"].ToString());
                empleado.noempleado = dtEmpleados.Rows[i]["noempleado"].ToString();
                empleado.paterno = dtEmpleados.Rows[i]["paterno"].ToString();
                empleado.materno = dtEmpleados.Rows[i]["materno"].ToString();
                empleado.nombres = dtEmpleados.Rows[i]["nombres"].ToString();
                empleado.nombrecompleto = dtEmpleados.Rows[i]["nombrecompleto"].ToString();
                empleado.curp = dtEmpleados.Rows[i]["curp"].ToString();
                empleado.fechaingreso = DateTime.Parse(dtEmpleados.Rows[i]["fechaingreso"].ToString());
                empleado.antiguedad = int.Parse(dtEmpleados.Rows[i]["antiguedad"].ToString());
                empleado.sdi = decimal.Parse(dtEmpleados.Rows[i]["sdi"].ToString());
                empleado.sd = decimal.Parse(dtEmpleados.Rows[i]["sd"].ToString());
                empleado.sueldo = decimal.Parse(dtEmpleados.Rows[i]["sueldo"].ToString());
                empleado.cuenta = dtEmpleados.Rows[i]["cuenta"].ToString();
                empleado.clabe = dtEmpleados.Rows[i]["clabe"].ToString();
                empleado.idbancario = dtEmpleados.Rows[i]["idbancario"].ToString();
                lstEmpleados.Add(empleado);
            }

            return lstEmpleados;
        }

        public List<Empleados> obtenerEmpleados(Empleados e, int periodo)
        {
            DataTable dtEmpleados = new DataTable();
            List<Empleados> lstEmpleados = new List<Empleados>();
            Command.CommandText =  @"select idtrabajador, noempleado, nombrecompleto from trabajadores where idempresa = @idempresa and estatus = @estatus and
                                    idperiodo in (select idperiodo from periodos where idempresa = @idempresa and dias = @dias)";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", e.idempresa);
            Command.Parameters.AddWithValue("estatus", e.estatus);
            Command.Parameters.AddWithValue("dias", periodo);
            dtEmpleados = SelectData(Command);

            for (int i = 0; i < dtEmpleados.Rows.Count; i++)
            {
                Empleados empleado = new Empleados();
                empleado.idtrabajador = int.Parse(dtEmpleados.Rows[i]["idtrabajador"].ToString());
                empleado.noempleado = dtEmpleados.Rows[i]["noempleado"].ToString();
                empleado.nombrecompleto = dtEmpleados.Rows[i]["nombrecompleto"].ToString();
                lstEmpleados.Add(empleado);
            }

            return lstEmpleados;
        }

        public List<Empleados> buscarEmpleado(Empleados e, bool esNoEmpleado, int periodo = 0)
        {
            DataTable dtEmpleados = new DataTable();
            List<Empleados> lstEmpleados = new List<Empleados>();
            if (periodo.Equals(0))
                if(esNoEmpleado){
                    Command.CommandText = @"select idtrabajador, noempleado, nombrecompleto from trabajadores where idempresa = @idempresa and noempleado like '%' + @noempleado + '%'";
                    Command.Parameters.Clear();
                    Command.Parameters.AddWithValue("noempleado", e.noempleado);
                }
                else{
                    Command.CommandText = @"select idtrabajador, noempleado, nombrecompleto from trabajadores where idempresa = @idempresa and nombrecompleto like '%' + @nombre + '%'";
                    Command.Parameters.Clear();
                    Command.Parameters.AddWithValue("nombre", e.nombrecompleto);
                }
            else
            {
                if (esNoEmpleado)
                {
                    Command.CommandText = @"select idtrabajador, noempleado, nombrecompleto from trabajadores where idempresa = @idempresa and noempleado like '%' + @noempleado + '%' and estatus = @estatus and
                                        idperiodo in (select idperiodo from periodos where idempresa = @idempresa and dias = @dias)";
                    Command.Parameters.Clear();
                    Command.Parameters.AddWithValue("noempleado", e.noempleado);
                }
                else {
                    Command.CommandText = @"select idtrabajador, noempleado, nombrecompleto from trabajadores where idempresa = @idempresa and nombrecompleto like '%' + @nombre + '%' and estatus = @estatus and
                                        idperiodo in (select idperiodo from periodos where idempresa = @idempresa and dias = @dias)";
                    Command.Parameters.Clear();
                    Command.Parameters.AddWithValue("nombre", e.nombrecompleto);
                }
                Command.Parameters.AddWithValue("dias", periodo);
                Command.Parameters.AddWithValue("estatus", e.estatus);
            }   
            Command.Parameters.AddWithValue("idempresa", e.idempresa);
           
            dtEmpleados = SelectData(Command);

            for (int i = 0; i < dtEmpleados.Rows.Count; i++)
            {
                Empleados empleado = new Empleados();
                empleado.idtrabajador = int.Parse(dtEmpleados.Rows[i]["idtrabajador"].ToString());
                empleado.noempleado = dtEmpleados.Rows[i]["noempleado"].ToString();
                empleado.nombrecompleto = dtEmpleados.Rows[i]["nombrecompleto"].ToString();
                lstEmpleados.Add(empleado);
            }

            return lstEmpleados;
        }

        public List<Empleados> obtenerEmpleadosBaja(Empleados e)
        {
            DataTable dtEmpleados = new DataTable();
            List<Empleados> lstEmpleados = new List<Empleados>();
            Command.CommandText = @"select idtrabajador, noempleado, paterno, materno, nombres, nombrecompleto, curp, fechaingreso, antiguedad, sdi, sd, sueldo, cuenta, clabe, idbancario from trabajadores where idempresa = @idempresa";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", e.idempresa);
            dtEmpleados = SelectData(Command);

            for (int i = 0; i < dtEmpleados.Rows.Count; i++)
            {
                Empleados empleado = new Empleados();
                empleado.idtrabajador = int.Parse(dtEmpleados.Rows[i]["idtrabajador"].ToString());
                empleado.noempleado = dtEmpleados.Rows[i]["noempleado"].ToString();
                empleado.paterno = dtEmpleados.Rows[i]["paterno"].ToString();
                empleado.materno = dtEmpleados.Rows[i]["materno"].ToString();
                empleado.nombres = dtEmpleados.Rows[i]["nombres"].ToString();
                empleado.nombrecompleto = dtEmpleados.Rows[i]["nombrecompleto"].ToString();
                empleado.curp = dtEmpleados.Rows[i]["curp"].ToString();
                empleado.fechaingreso = DateTime.Parse(dtEmpleados.Rows[i]["fechaingreso"].ToString());
                empleado.antiguedad = int.Parse(dtEmpleados.Rows[i]["antiguedad"].ToString());
                empleado.sdi = decimal.Parse(dtEmpleados.Rows[i]["sdi"].ToString());
                empleado.sd = decimal.Parse(dtEmpleados.Rows[i]["sd"].ToString());
                empleado.sueldo = decimal.Parse(dtEmpleados.Rows[i]["sueldo"].ToString());
                empleado.cuenta = dtEmpleados.Rows[i]["cuenta"].ToString();
                empleado.clabe = dtEmpleados.Rows[i]["clabe"].ToString();
                empleado.idbancario = dtEmpleados.Rows[i]["idbancario"].ToString();
                lstEmpleados.Add(empleado);
            }

            return lstEmpleados;
        }

        public List<Empleados> obtenerEmpleadosBaja(Empleados e, int periodo)
        {
            DataTable dtEmpleados = new DataTable();
            List<Empleados> lstEmpleados = new List<Empleados>();
            Command.CommandText = @"select idtrabajador, noempleado from trabajadores where idempresa = @idempresa
                                    and idperiodo in (select idperiodo from periodos where idempresa = @idempresa and dias = @dias)
                                    order by idtrabajador asc";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", e.idempresa);
            Command.Parameters.AddWithValue("dias", periodo);
            dtEmpleados = SelectData(Command);

            for (int i = 0; i < dtEmpleados.Rows.Count; i++)
            {
                Empleados empleado = new Empleados();
                empleado.idtrabajador = int.Parse(dtEmpleados.Rows[i]["idtrabajador"].ToString());
                empleado.noempleado = dtEmpleados.Rows[i]["noempleado"].ToString();
                lstEmpleados.Add(empleado);
            }

            return lstEmpleados;
        }

        public List<Empleados> obtenerEmpleadosAusentismo(Empleados e)
        {
            DataTable dtEmpleados = new DataTable();
            List<Empleados> lstEmpleados = new List<Empleados>();
            Command.CommandText = @"select idtrabajador, noempleado, nombrecompleto, nss, digitoverificador, sdi 
                from trabajadores where idempresa = @idempresa";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", e.idempresa);
            dtEmpleados = SelectData(Command);

            for (int i = 0; i < dtEmpleados.Rows.Count; i++)
            {
                Empleados empleado = new Empleados();
                empleado.idtrabajador = int.Parse(dtEmpleados.Rows[i]["idtrabajador"].ToString());
                empleado.noempleado = dtEmpleados.Rows[i]["noempleado"].ToString();
                empleado.nombrecompleto = dtEmpleados.Rows[i]["nombrecompleto"].ToString();
                empleado.nss = dtEmpleados.Rows[i]["nss"].ToString();
                empleado.digitoverificador = int.Parse(dtEmpleados.Rows[i]["digitoverificador"].ToString());
                empleado.sdi = decimal.Parse(dtEmpleados.Rows[i]["sdi"].ToString());
                lstEmpleados.Add(empleado);
            }

            return lstEmpleados;
        }

        public List<CatalogoEmpleado> obtenerEmpleados(int idEmpresa, string criterio, int startIndex)
        {
            DataTable dtEmpleados = new DataTable();
            List<CatalogoEmpleado> lstEmpleados = new List<CatalogoEmpleado>();
            Command.CommandText = @"exec stp_Empleados_GetPaged @startindex, @criterio, @idempresa";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("startindex", startIndex);
            Command.Parameters.AddWithValue("criterio", criterio);
            Command.Parameters.AddWithValue("idempresa", idEmpresa);
            dtEmpleados = SelectData(Command);

            for (int i = 0; i < dtEmpleados.Rows.Count; i++)
            {
                CatalogoEmpleado empleado = new CatalogoEmpleado();
                empleado.rownumber = int.Parse(dtEmpleados.Rows[i]["EmpleadosRowNumber"].ToString());
                empleado.idtrabajador = int.Parse(dtEmpleados.Rows[i]["idtrabajador"].ToString());
                empleado.noempleado = dtEmpleados.Rows[i]["noempleado"].ToString();
                empleado.paterno = dtEmpleados.Rows[i]["paterno"].ToString();
                empleado.materno = dtEmpleados.Rows[i]["materno"].ToString();
                empleado.nombres = dtEmpleados.Rows[i]["nombres"].ToString();
                empleado.nombrecompleto = dtEmpleados.Rows[i]["nombrecompleto"].ToString();
                empleado.curp = dtEmpleados.Rows[i]["curp"].ToString();
                empleado.fechaingreso = DateTime.Parse(dtEmpleados.Rows[i]["fechaingreso"].ToString());
                empleado.antiguedad = int.Parse(dtEmpleados.Rows[i]["antiguedad"].ToString());
                empleado.sdi = decimal.Parse(dtEmpleados.Rows[i]["sdi"].ToString());
                empleado.sd = decimal.Parse(dtEmpleados.Rows[i]["sd"].ToString());
                empleado.sueldo = decimal.Parse(dtEmpleados.Rows[i]["sueldo"].ToString());
                empleado.cuenta = dtEmpleados.Rows[i]["cuenta"].ToString();
                empleado.estatus = dtEmpleados.Rows[i]["estatus"].ToString();
                empleado.departamento = dtEmpleados.Rows[i]["departamento"].ToString();
                empleado.puesto = dtEmpleados.Rows[i]["puesto"].ToString();
                empleado.fechabaja = dtEmpleados.Rows[i]["fechabaja"].ToString();
                lstEmpleados.Add(empleado);
            }

            return lstEmpleados;
        }

        public List<CatalogoEmpleado> obtenerEmpleados(int idEmpresa, string nombre, string paterno, string materno)
        {
            DataTable dtEmpleados = new DataTable();
            List<CatalogoEmpleado> lstEmpleados = new List<CatalogoEmpleado>();
            Command.CommandText = @"exec stp_Empleados @idempresa, @nombre, @paterno, @materno";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("nombre", nombre);
            Command.Parameters.AddWithValue("paterno", paterno);
            Command.Parameters.AddWithValue("materno", materno);
            Command.Parameters.AddWithValue("idempresa", idEmpresa);
            dtEmpleados = SelectData(Command);

            for (int i = 0; i < dtEmpleados.Rows.Count; i++)
            {
                CatalogoEmpleado empleado = new CatalogoEmpleado();
                empleado.rownumber = int.Parse(dtEmpleados.Rows[i]["EmpleadosRowNumber"].ToString());
                empleado.idtrabajador = int.Parse(dtEmpleados.Rows[i]["idtrabajador"].ToString());
                empleado.noempleado = dtEmpleados.Rows[i]["noempleado"].ToString();
                empleado.paterno = dtEmpleados.Rows[i]["paterno"].ToString();
                empleado.materno = dtEmpleados.Rows[i]["materno"].ToString();
                empleado.nombres = dtEmpleados.Rows[i]["nombres"].ToString();
                empleado.nombrecompleto = dtEmpleados.Rows[i]["nombrecompleto"].ToString();
                empleado.curp = dtEmpleados.Rows[i]["curp"].ToString();
                empleado.fechaingreso = DateTime.Parse(dtEmpleados.Rows[i]["fechaingreso"].ToString());
                empleado.antiguedad = int.Parse(dtEmpleados.Rows[i]["antiguedad"].ToString());
                empleado.sdi = decimal.Parse(dtEmpleados.Rows[i]["sdi"].ToString());
                empleado.sd = decimal.Parse(dtEmpleados.Rows[i]["sd"].ToString());
                empleado.sueldo = decimal.Parse(dtEmpleados.Rows[i]["sueldo"].ToString());
                empleado.cuenta = dtEmpleados.Rows[i]["cuenta"].ToString();
                empleado.estatus = dtEmpleados.Rows[i]["estatus"].ToString();
                empleado.departamento = dtEmpleados.Rows[i]["departamento"].ToString();
                empleado.puesto = dtEmpleados.Rows[i]["puesto"].ToString();
                empleado.fechabaja = dtEmpleados.Rows[i]["fechabaja"].ToString();
                lstEmpleados.Add(empleado);
            }

            return lstEmpleados;
        }

        public List<EmpleadosEstatus> obtenerEmpleadosEstatus(int idEmpresa)
        {
            DataTable dtEmpleados = new DataTable();
            List<EmpleadosEstatus> lstEmpleados = new List<EmpleadosEstatus>();
            Command.CommandText = @"select idtrabajador, estatus from trabajadoresestatus 
                    where idempresa = @idempresa";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", idEmpresa);
            dtEmpleados = SelectData(Command);

            for (int i = 0; i < dtEmpleados.Rows.Count; i++)
            {
                EmpleadosEstatus empleado = new EmpleadosEstatus();
                empleado.idtrabajador = int.Parse(dtEmpleados.Rows[i]["idtrabajador"].ToString());
                empleado.estatus = int.Parse(dtEmpleados.Rows[i]["estatus"].ToString());
                lstEmpleados.Add(empleado);
            }

            return lstEmpleados;
        }

        public List<Empleados> obtenerEmpleado(Empleados e)
        {
            DataTable dtEmpleados = new DataTable();
            List<Empleados> lstEmpleados = new List<Empleados>();
            
            Command.CommandText = "select * from trabajadores where idtrabajador = @idtrabajador";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idtrabajador", e.idtrabajador);
            
            dtEmpleados = SelectData(Command);

            for (int i = 0; i < dtEmpleados.Rows.Count; i++)
            {
                Empleados empleado = new Empleados();
                empleado.idtrabajador = int.Parse(dtEmpleados.Rows[i]["idtrabajador"].ToString());
                empleado.noempleado = dtEmpleados.Rows[i]["noempleado"].ToString();
                empleado.nombres = dtEmpleados.Rows[i]["nombres"].ToString();
                empleado.paterno = dtEmpleados.Rows[i]["paterno"].ToString();
                empleado.materno = dtEmpleados.Rows[i]["materno"].ToString();
                empleado.nombrecompleto = dtEmpleados.Rows[i]["nombrecompleto"].ToString();
                empleado.idempresa = int.Parse(dtEmpleados.Rows[i]["idempresa"].ToString());
                empleado.idperiodo = int.Parse(dtEmpleados.Rows[i]["idperiodo"].ToString());
                empleado.idsalario = int.Parse(dtEmpleados.Rows[i]["idsalario"].ToString());
                empleado.iddepartamento = int.Parse(dtEmpleados.Rows[i]["iddepartamento"].ToString());
                empleado.idpuesto = int.Parse(dtEmpleados.Rows[i]["idpuesto"].ToString());
                empleado.fechaingreso = DateTime.Parse(dtEmpleados.Rows[i]["fechaingreso"].ToString());
                empleado.antiguedad = int.Parse(dtEmpleados.Rows[i]["antiguedad"].ToString());
                empleado.fechaantiguedad = DateTime.Parse(dtEmpleados.Rows[i]["fechaantiguedad"].ToString());
                empleado.antiguedadmod = int.Parse(dtEmpleados.Rows[i]["antiguedadmod"].ToString());
                empleado.fechanacimiento = DateTime.Parse(dtEmpleados.Rows[i]["fechanacimiento"].ToString());
                empleado.edad = int.Parse(dtEmpleados.Rows[i]["edad"].ToString());
                empleado.rfc = dtEmpleados.Rows[i]["rfc"].ToString();
                empleado.curp = dtEmpleados.Rows[i]["curp"].ToString();
                empleado.nss = dtEmpleados.Rows[i]["nss"].ToString();
                empleado.digitoverificador = int.Parse(dtEmpleados.Rows[i]["digitoverificador"].ToString());
                empleado.tiposalario = int.Parse(dtEmpleados.Rows[i]["tiposalario"].ToString());
                empleado.sdi = decimal.Parse(dtEmpleados.Rows[i]["sdi"].ToString());
                empleado.sd = decimal.Parse(dtEmpleados.Rows[i]["sd"].ToString());
                empleado.sueldo = decimal.Parse(dtEmpleados.Rows[i]["sueldo"].ToString());
                empleado.cuenta = dtEmpleados.Rows[i]["cuenta"].ToString();
                empleado.clabe = dtEmpleados.Rows[i]["clabe"].ToString();
                empleado.idbancario = dtEmpleados.Rows[i]["idbancario"].ToString();
                empleado.metodopago = dtEmpleados.Rows[i]["metodopago"].ToString();
                empleado.tiporegimen = int.Parse(dtEmpleados.Rows[i]["tiporegimen"].ToString());
                empleado.obracivil = bool.Parse(dtEmpleados.Rows[i]["obracivil"].ToString());
                
                lstEmpleados.Add(empleado);
            }

            return lstEmpleados;
        }

        public List<IncrementoSalarial> obtenerIncremento(Empleados e)
        {
            DataTable dtIncremento = new DataTable();
            List<IncrementoSalarial> lstEmpleadosIncremento = new List<IncrementoSalarial>();

            Command.CommandText = "exec stp_IncrementoSalarioAnual @idempresa, @estatus";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", e.idempresa);
            Command.Parameters.AddWithValue("estatus", e.estatus);

            dtIncremento = SelectData(Command);

            for (int i = 0; i < dtIncremento.Rows.Count; i++)
            {
                IncrementoSalarial incremento = new IncrementoSalarial();
                incremento.chk = int.Parse(dtIncremento.Rows[i]["chk"].ToString());
                incremento.idtrabajador = int.Parse(dtIncremento.Rows[i]["idtrabajador"].ToString());
                incremento.noempleado = int.Parse(dtIncremento.Rows[i]["noempleado"].ToString());
                incremento.nombre = dtIncremento.Rows[i]["nombre"].ToString();
                incremento.sdivigente = decimal.Parse(dtIncremento.Rows[i]["sdivigente"].ToString());
                incremento.sdinuevo = decimal.Parse(dtIncremento.Rows[i]["sdinuevo"].ToString());
                incremento.antiguedad = int.Parse(dtIncremento.Rows[i]["antiguedad"].ToString());
                incremento.antiguedadmod = int.Parse(dtIncremento.Rows[i]["antiguedadmod"].ToString());
                incremento.fechaimss = DateTime.Parse(dtIncremento.Rows[i]["fechaimss"].ToString());
                lstEmpleadosIncremento.Add(incremento);
            }

            return lstEmpleadosIncremento;
        }

        public List<Empleados> obtenerAntiguedades(string noempleados)
        {
            string[] noEmp = noempleados.Split(',');
            string commandText = "select idtrabajador, idsalario, idperiodo, antiguedadmod, sdi, sd, fechaantiguedad, sueldo from trabajadores " +
                    "where noempleado in ({0})";
            string[] paramNombre = noEmp.Select((s, i) => "@noempleado" + i.ToString()).ToArray();
            string inClausula = string.Join(",", paramNombre);

            DataTable dtEmpleados = new DataTable();
            List<Empleados> lstEmpleados = new List<Empleados>();
            Command.CommandText = string.Format(commandText, inClausula);
            Command.Parameters.Clear();
            
            for (int i = 0; i < paramNombre.Length; i++)
            {
                Command.Parameters.AddWithValue(paramNombre[i], noEmp[i]);
            }

            dtEmpleados = SelectData(Command);

            for (int i = 0; i < dtEmpleados.Rows.Count; i++)
            {
                Empleados empleado = new Empleados();
                empleado.idtrabajador = int.Parse(dtEmpleados.Rows[i]["idtrabajador"].ToString());
                empleado.idsalario = int.Parse(dtEmpleados.Rows[i]["idsalario"].ToString());
                empleado.idperiodo = int.Parse(dtEmpleados.Rows[i]["idperiodo"].ToString());
                empleado.antiguedadmod = int.Parse(dtEmpleados.Rows[i]["antiguedadmod"].ToString());
                empleado.sdi = decimal.Parse(dtEmpleados.Rows[i]["sdi"].ToString());
                empleado.sd = decimal.Parse(dtEmpleados.Rows[i]["sd"].ToString());
                empleado.sueldo = decimal.Parse(dtEmpleados.Rows[i]["sueldo"].ToString());
                empleado.fechaantiguedad = DateTime.Parse(dtEmpleados.Rows[i]["fechaantiguedad"].ToString());
                lstEmpleados.Add(empleado);
            }

            return lstEmpleados;
        }

        public List<Empleados> obtenerSalarioDiario(string noempleados)
        {
            string[] noEmp = noempleados.Split(',');
            string commandText = "select idtrabajador, sd from trabajadores where noempleado in ({0})";
            string[] paramNombre = noEmp.Select((s, i) => "@noempleado" + i.ToString()).ToArray();
            string inClausula = string.Join(",", paramNombre);

            DataTable dtEmpleados = new DataTable();
            List<Empleados> lstEmpleados = new List<Empleados>();
            Command.CommandText = string.Format(commandText, inClausula);
            Command.Parameters.Clear();

            for (int i = 0; i < paramNombre.Length; i++)
            {
                Command.Parameters.AddWithValue(paramNombre[i], noEmp[i]);
            }

            dtEmpleados = SelectData(Command);

            for (int i = 0; i < dtEmpleados.Rows.Count; i++)
            {
                Empleados empleado = new Empleados();
                empleado.idtrabajador = int.Parse(dtEmpleados.Rows[i]["idtrabajador"].ToString());
                empleado.sd = decimal.Parse(dtEmpleados.Rows[i]["sd"].ToString());
                lstEmpleados.Add(empleado);
            }

            return lstEmpleados;
        }

        public object obtenerFechaIngreso(int idtrabajador)
        {
            Command.CommandText = "select fechaingreso from trabajadores where idtrabajador = @idtrabajador";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idtrabajador", idtrabajador);
            object dato = Select(Command);
            return dato;
        }

        public object obtenerSalarioDiario(Empleados e)
        {
            Command.CommandText = "select sd from trabajadores where idtrabajador = @idtrabajador";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idtrabajador", e.idtrabajador);
            object dato = Select(Command);
            return dato;
        }

        public object obtenerSalarioDiarioIntegrado(Empleados e)
        {
            Command.CommandText = "select sdi from trabajadores where idtrabajador = @idtrabajador";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idtrabajador", e.idtrabajador);
            object dato = Select(Command);
            return dato;
        }

        public object obtenerEstatus(Empleados e)
        {
            Command.CommandText = "select estatus from trabajadoresestatus where idtrabajador = @idtrabajador";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idtrabajador",e.idtrabajador);
            object estatus = Select(Command);
            return estatus;
        }

        public object obtenerEstatus(int idtrabajador)
        {
            Command.CommandText = "select estatus from trabajadores where idtrabajador = @idtrabajador";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idtrabajador", idtrabajador);
            object estatus = Select(Command);
            return estatus;
        }

        public object obtenerIdTrabajador(Empleados e)
        {
            Command.CommandText = "select idtrabajador from trabajadores where rfc = @rfc";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("rfc", e.rfc);
            object dato = Select(Command);
            return dato;
        }

        public object obtenerIdSalarioMinimo(int idTrabajador)
        {
            Command.CommandText = "select idsalario from trabajadores where idtrabajador = @idtrabajador";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idtrabajador", idTrabajador);
            object dato = Select(Command);
            return dato;
        }
        
        public object obtenerIdTrabajador(string noempleado, int idEmpresa)
        {
            Command.CommandText = "select idtrabajador from trabajadores where noempleado = @noempleado and idempresa = @idempresa";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("noempleado", noempleado);
            Command.Parameters.AddWithValue("idempresa", idEmpresa);
            object dato = Select(Command);
            return dato;
        }
        
        public object obtenerIdPeriodo(string noempleado)
        {
            Command.CommandText = "select idperiodo from trabajadores where noempleado = @noempleado";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("noempleado", noempleado);
            object dato = Select(Command);
            return dato;
        }

        public object obtenerIdPeriodo(int idTrabajador)
        {
            Command.CommandText = "select idperiodo from trabajadores where idtrabajador = @idtrabajador";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idtrabajador", idTrabajador);
            object dato = Select(Command);
            return dato;
        }

        public object obtenerDiasPeriodo(int idtrabajador)
        {
            Command.CommandText = "select dias from dbo.Periodos where idperiodo = (select idperiodo from Trabajadores where idtrabajador = @idtrabajador)";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idtrabajador", idtrabajador);
            object dato = Select(Command);
            return dato;
        }

        public object obtenerNss(Empleados e)
        {
            Command.CommandText = "select nss + convert(char(1),digitoverificador) as nss from trabajadores where idtrabajador = @idtrabajador";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idtrabajador", e.idtrabajador);
            object dato = Select(Command);
            return dato;
        }

        public object obtenerIdEmpresa(Empleados e)
        {
            Command.CommandText = "select idempresa from trabajadores where idtrabajador = @idtrabajador";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idtrabajador", e.idtrabajador);
            object dato = Select(Command);
            return dato;
        }

        public int insertaEmpleado(Empleados e)
        {
            Command.CommandText = "insert into trabajadores (noempleado,nombres,paterno,materno,nombrecompleto,idempresa,idperiodo,idsalario,iddepartamento,idpuesto,fechaingreso,antiguedad," + 
                "fechaantiguedad,antiguedadmod,fechanacimiento,edad,rfc,curp,nss,digitoverificador,tiposalario,sdi,sd,sueldo,estatus,idusuario,cuenta,clabe,idbancario,metodopago, tiporegimen, obracivil) " +
                "values (@noempleado,@nombres,@paterno,@materno,@nombrecompleto,@idempresa,@idperiodo,@idsalario,@iddepartamento,@idpuesto,@fechaingreso,@antiguedad,@fechaantiguedad,@antiguedadmod," +
                "@fechanacimiento,@edad,@rfc,@curp,@nss,@digitoverificador,@tiposalario,@sdi,@sd,@sueldo,@estatus,@idusuario,@cuenta,@clabe,@idbancario, @metodopago, @tiporegimen, @obracivil)";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("noempleado", e.noempleado);
            Command.Parameters.AddWithValue("nombres",e.nombres);
            Command.Parameters.AddWithValue("paterno", e.paterno);
            Command.Parameters.AddWithValue("materno", e.materno);
            Command.Parameters.AddWithValue("nombrecompleto", e.nombrecompleto);
            Command.Parameters.AddWithValue("idempresa", e.idempresa);
            Command.Parameters.AddWithValue("idperiodo", e.idperiodo);
            Command.Parameters.AddWithValue("idsalario", e.idsalario);
            Command.Parameters.AddWithValue("iddepartamento", e.iddepartamento);
            Command.Parameters.AddWithValue("idpuesto", e.idpuesto);
            Command.Parameters.AddWithValue("fechaingreso", e.fechaingreso);
            Command.Parameters.AddWithValue("antiguedad", e.antiguedad);
            Command.Parameters.AddWithValue("fechaantiguedad", e.fechaantiguedad);
            Command.Parameters.AddWithValue("antiguedadmod", e.antiguedadmod);
            Command.Parameters.AddWithValue("fechanacimiento", e.fechanacimiento);
            Command.Parameters.AddWithValue("edad", e.edad);
            Command.Parameters.AddWithValue("rfc", e.rfc);
            Command.Parameters.AddWithValue("curp", e.curp);
            Command.Parameters.AddWithValue("nss", e.nss);
            Command.Parameters.AddWithValue("digitoverificador", e.digitoverificador);
            Command.Parameters.AddWithValue("tiposalario", e.tiposalario);
            Command.Parameters.AddWithValue("sdi", e.sdi);
            Command.Parameters.AddWithValue("sd", e.sd);
            Command.Parameters.AddWithValue("sueldo", e.sueldo);
            Command.Parameters.AddWithValue("estatus", e.estatus);
            Command.Parameters.AddWithValue("idusuario", e.idusuario);
            Command.Parameters.AddWithValue("cuenta", e.cuenta);
            Command.Parameters.AddWithValue("clabe", e.clabe);
            Command.Parameters.AddWithValue("idbancario", e.idbancario);
            Command.Parameters.AddWithValue("metodopago", e.metodopago);
            Command.Parameters.AddWithValue("tiporegimen", e.tiporegimen);
            Command.Parameters.AddWithValue("obracivil", e.obracivil);
            return Command.ExecuteNonQuery();
        }

        public int insertaEmpleadoEstatus(EmpleadosEstatus ee)
        {
            Command.CommandText = "insert into trabajadoresestatus (idtrabajador, idempresa, estatus) values (@idtrabajador, @idempresa, @estatus)";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idtrabajador", ee.idtrabajador);
            Command.Parameters.AddWithValue("idempresa", ee.idempresa);
            Command.Parameters.AddWithValue("estatus", ee.estatus);
            return Command.ExecuteNonQuery();
        }

        public int actualizaEmpleado(Empleados e)
        {
            Command.CommandText = "update trabajadores set noempleado = @noempleado, nombres = @nombres, paterno = @paterno, materno = @materno, nombrecompleto = @nombrecompleto," +
                "idperiodo = @idperiodo, idsalario = @idsalario, iddepartamento = @iddepartamento, idpuesto = @idpuesto, fechaingreso = @fechaingreso, antiguedad = @antiguedad, fechaantiguedad = @fechaantiguedad," + 
                "antiguedadmod = @antiguedadmod, fechanacimiento = @fechanacimiento, edad= @edad, rfc = @rfc, curp = @curp, nss = @nss, digitoverificador = @digitoverificador, " + 
                "tiposalario = @tiposalario, sdi = @sdi, sd = @sd, sueldo = @sueldo, cuenta = @cuenta, clabe = @clabe, idbancario = @idbancario, metodopago = @metodopago, tiporegimen = @tiporegimen, obracivil = @obracivil where idtrabajador = @idtrabajador";
                
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idtrabajador", e.idtrabajador);
            Command.Parameters.AddWithValue("noempleado", e.noempleado);
            Command.Parameters.AddWithValue("nombres", e.nombres);
            Command.Parameters.AddWithValue("paterno", e.paterno);
            Command.Parameters.AddWithValue("materno", e.materno);
            Command.Parameters.AddWithValue("nombrecompleto", e.nombrecompleto);
            Command.Parameters.AddWithValue("idperiodo", e.idperiodo);
            Command.Parameters.AddWithValue("idsalario", e.idsalario);
            Command.Parameters.AddWithValue("iddepartamento", e.iddepartamento);
            Command.Parameters.AddWithValue("idpuesto", e.idpuesto);
            Command.Parameters.AddWithValue("fechaingreso", e.fechaingreso);
            Command.Parameters.AddWithValue("antiguedad", e.antiguedad);
            Command.Parameters.AddWithValue("fechaantiguedad", e.fechaantiguedad);
            Command.Parameters.AddWithValue("antiguedadmod", e.antiguedadmod);
            Command.Parameters.AddWithValue("fechanacimiento", e.fechanacimiento);
            Command.Parameters.AddWithValue("edad", e.edad);
            Command.Parameters.AddWithValue("rfc", e.rfc);
            Command.Parameters.AddWithValue("curp", e.curp);
            Command.Parameters.AddWithValue("nss", e.nss);
            Command.Parameters.AddWithValue("digitoverificador", e.digitoverificador);
            Command.Parameters.AddWithValue("tiposalario", e.tiposalario);
            Command.Parameters.AddWithValue("sdi", e.sdi);
            Command.Parameters.AddWithValue("sd", e.sd);
            Command.Parameters.AddWithValue("sueldo", e.sueldo);
            Command.Parameters.AddWithValue("cuenta", e.cuenta);
            Command.Parameters.AddWithValue("clabe", e.clabe);
            Command.Parameters.AddWithValue("idbancario", e.idbancario);
            Command.Parameters.AddWithValue("metodopago", e.metodopago);
            Command.Parameters.AddWithValue("tiporegimen", e.tiporegimen);
            Command.Parameters.AddWithValue("obracivil", e.obracivil);
            return Command.ExecuteNonQuery();
        }

        public int eliminarEmpleado(Empleados e)
        {
            Command.CommandText = "delete from trabajadores where idtrabajador = @idtrabajador";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idtrabajador",e.idtrabajador);
            return Command.ExecuteNonQuery();
        }

        public int eliminaEmpleadoEstatus(int idtrabajador)
        {
            Command.CommandText = "delete from trabajadoresestatus where idtrabajador = @idtrabajador";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idtrabajador", idtrabajador);
            return Command.ExecuteNonQuery();
        }

        public int bajaEmpleado(EmpleadosEstatus ee)
        {
            Command.CommandText = "update trabajadoresestatus set estatus = @estatus where idtrabajador = @idtrabajador and idempresa = @idempresa";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("estatus",ee.estatus);
            Command.Parameters.AddWithValue("idtrabajador", ee.idtrabajador);
            Command.Parameters.AddWithValue("idempresa", ee.idempresa);
            return Command.ExecuteNonQuery();
        }

        public int reingreso(Empleados e)
        {
            Command.CommandText = @"update trabajadores set idempresa = @idempresa, fechaingreso = @fechaingreso, fechaantiguedad = @fechaantiguedad, antiguedad = @antiguedad, antiguedadmod = @antiguedadmod,
                iddepartamento = @iddepartamento, idpuesto = @idpuesto, idperiodo = @idperiodo, sueldo = @sueldo, sd = @sd, sdi = @sdi, estatus = @estatus, idusuario = @idusuario, cuenta = @cuenta, clabe = @clabe, 
                idbancario = @idbancario, metodopago = @metodopago, obracivil = @obracivil where idtrabajador = @idtrabajador";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", e.idempresa);
            Command.Parameters.AddWithValue("fechaingreso", e.fechaingreso);
            Command.Parameters.AddWithValue("fechaantiguedad", e.fechaantiguedad);
            Command.Parameters.AddWithValue("antiguedad", e.antiguedad);
            Command.Parameters.AddWithValue("antiguedadmod", e.antiguedadmod);
            Command.Parameters.AddWithValue("iddepartamento", e.iddepartamento);
            Command.Parameters.AddWithValue("idpuesto", e.idpuesto);
            Command.Parameters.AddWithValue("idperiodo", e.idperiodo);
            Command.Parameters.AddWithValue("sueldo", e.sueldo);
            Command.Parameters.AddWithValue("sd", e.sd);
            Command.Parameters.AddWithValue("sdi", e.sdi);
            Command.Parameters.AddWithValue("estatus", e.estatus);
            Command.Parameters.AddWithValue("idusuario", e.idusuario);
            Command.Parameters.AddWithValue("idtrabajador", e.idtrabajador);
            Command.Parameters.AddWithValue("cuenta", e.cuenta);
            Command.Parameters.AddWithValue("clabe", e.clabe);
            Command.Parameters.AddWithValue("idbancario", e.idbancario);
            Command.Parameters.AddWithValue("metodopago", e.idbancario);
            Command.Parameters.AddWithValue("obracivil", e.obracivil);
            return Command.ExecuteNonQuery();
        }

        public int actualizaSueldo(Empleados e)
        {
            Command.CommandText = "update trabajadores set sueldo = @sueldo, sd = @sd, sdi = @sdi where idtrabajador = @idtrabajador";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("sueldo", e.sueldo);
            Command.Parameters.AddWithValue("sd", e.sd);
            Command.Parameters.AddWithValue("sdi", e.sdi);
            Command.Parameters.AddWithValue("idtrabajador", e.idtrabajador);
            return Command.ExecuteNonQuery();
        }

        public int actualizaDeptoPuesto(Empleados e)
        {
            Command.CommandText = "update trabajadores set iddepartamento = @iddepartamento, idpuesto = @idpuesto where idtrabajador = @idtrabajador";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("iddepartamento", e.iddepartamento);
            Command.Parameters.AddWithValue("idpuesto", e.idpuesto);
            Command.Parameters.AddWithValue("idtrabajador", e.idtrabajador);
            return Command.ExecuteNonQuery();
        }

        public int actualizaDeptoPuesto(int iddeptopuesto, int idtrabajador, string tipo)
        {
            if (tipo == "D")
            {
                Command.CommandText = "update trabajadores set iddepartamento = @iddepartamento where idtrabajador = @idtrabajador";
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("iddepartamento", iddeptopuesto);
                Command.Parameters.AddWithValue("idtrabajador", idtrabajador);
            }

            if (tipo == "P")
            {
                Command.CommandText = "update trabajadores set idpuesto = @idpuesto where idtrabajador = @idtrabajador";
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("idpuesto", iddeptopuesto);
                Command.Parameters.AddWithValue("idtrabajador", idtrabajador);
            }
            
            return Command.ExecuteNonQuery();
        }

        public int actualizaAntiguedad(int idEmpresa)
        {
            Command.CommandText = "exec stp_ActualizaAntiguedad @idempresa";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", idEmpresa);
            return Command.ExecuteNonQuery();
        }

        public int actualizaEstatus(int idtrabajador)
        {
            Command.CommandText = "update trabajadores set estatus = 1 where idtrabajador = @idtrabajador";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idtrabajador", idtrabajador);
            return Command.ExecuteNonQuery();
        }

        public object existeEmpleado(Empleados e)
        {
            Command.CommandText = "select count(idtrabajador) from trabajadores where nss = @nss and digitoverificador = @digito and idempresa = @idempresa";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("nss", e.nss);
            Command.Parameters.AddWithValue("digito", e.digitoverificador);
            Command.Parameters.AddWithValue("idempresa", e.idempresa);
            object dato = Select(Command);
            return dato;
        }

        public object existeEmpleado(int idempresa, string noempleado)
        {
            Command.CommandText = "select count(idtrabajador) from trabajadores where idempresa = @idempresa and noempleado = @noempleado";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", idempresa);
            Command.Parameters.AddWithValue("noempleado", noempleado);
            object dato = Select(Command);
            return dato;
        }

        public List<Empleados> obtenerEmpleadoPorDepto(int idEmpresa, string idDepartamentos, DateTime fecha, int tiponomina, bool timbrado, int periodo)
        {
            DataTable dtEmpleados = new DataTable();
            List<Empleados> lstEmpleados = new List<Empleados>();
            if (timbrado)
                Command.CommandText = @"select cm.idtrabajador, cm.noempleado, cm.nombre as nombrecompleto from cfdimaster cm 
                                    where cm.iddepartamento in (select * from fnListaCadenaATabla(@deptos)) and cm.periodoinicio = @fecha and
                                    cm.idempresa = @idempresa and cm.tiponomina = @tiponomina and cm.periodo = @periodo
                                    group by cm.idtrabajador, cm.noempleado, cm.nombre";
            else
                Command.CommandText = @"select pn.idtrabajador, t.noempleado, t.nombrecompleto from pagonomina pn inner join trabajadores t on pn.idtrabajador = t.idtrabajador
                                    where pn.iddepartamento in (select * from fnListaCadenaATabla(@deptos)) and pn.fechainicio = @fecha and
                                    pn.idempresa = @idempresa and pn.tiponomina = @tiponomina and pn.periodo = @periodo
                                    group by pn.idtrabajador, t.noempleado, t.nombrecompleto";
            
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", idEmpresa);
            Command.Parameters.AddWithValue("deptos", idDepartamentos);
            Command.Parameters.AddWithValue("fecha", fecha);
            Command.Parameters.AddWithValue("tiponomina", tiponomina);
            Command.Parameters.AddWithValue("periodo", periodo);
            dtEmpleados = SelectData(Command);
            for (int i = 0; i < dtEmpleados.Rows.Count; i++)
            {
                Empleados emp = new Empleados();
                emp.idtrabajador = int.Parse(dtEmpleados.Rows[i]["idtrabajador"].ToString());
                emp.noempleado = dtEmpleados.Rows[i]["noempleado"].ToString();
                emp.nombrecompleto = dtEmpleados.Rows[i]["nombrecompleto"].ToString();
                lstEmpleados.Add(emp);
            }
            return lstEmpleados;
        }

        public object esObraCivil(int idempresa, int idtrabajador)
        {
            Command.CommandText = @"select obracivil from trabajadores where idempresa = @idempresa and idtrabajador = @idtrabajador";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", idempresa);
            Command.Parameters.AddWithValue("idtrabajador", idtrabajador);
            object dato = Select(Command);
            return dato;
        }

        public int insertaBitacora(int idusuario, int idtrabajador, int idempresa, string tabla, string accion, string informacion)
        {
            Command.CommandText = @"exec stp_Bitacora @idusuario, @idtrabajador, @idempresa, @tabla, @accion, @informacion";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idusuario", idusuario);
            Command.Parameters.AddWithValue("idtrabajador", idtrabajador);
            Command.Parameters.AddWithValue("idempresa", idempresa);
            Command.Parameters.AddWithValue("tabla", tabla);
            Command.Parameters.AddWithValue("accion", accion);
            Command.Parameters.AddWithValue("informacion", informacion);
            return Command.ExecuteNonQuery();
        }

    }
}
