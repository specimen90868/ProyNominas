using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace Empresas.Core
{
    public class EmpresasHelper : Data.Obj.DataObj
    {
        public List<Empresas> obtenerEmpresas()
        {
            DataTable dtEmpresas = new DataTable();
            Command.CommandText = "select idempresa, nombre, rfc, registro, digitoverificador, representante from empresas where estatus = 1";
            Command.Parameters.Clear();
            dtEmpresas = SelectData(Command);
            List<Empresas> lstEmpresa = new List<Empresas>();
            for (int i = 0; i < dtEmpresas.Rows.Count; i++)
            {
                Empresas e = new Empresas();
                e.idempresa = int.Parse(dtEmpresas.Rows[i]["idempresa"].ToString());
                e.nombre = dtEmpresas.Rows[i]["nombre"].ToString();
                e.rfc = dtEmpresas.Rows[i]["rfc"].ToString();
                e.registro = dtEmpresas.Rows[i]["registro"].ToString();
                e.digitoverificador = int.Parse(dtEmpresas.Rows[i]["digitoverificador"].ToString());
                e.representante = dtEmpresas.Rows[i]["representante"].ToString();
                lstEmpresa.Add(e);
            }
            return lstEmpresa;
        }

        public List<Empresas> obtenerEmpresa(int idempresa)
        {
            DataTable dtEmpresas = new DataTable();
            Command.CommandText = @"select idempresa, nombre, rfc, registro, digitoverificador, representante, observacion, obracivil, 
                                    idregimenfiscal, codigopostal, archivokey, archivocer, passwordkey, usuariopac, passwordpac, nocertificado from empresas where idempresa = @idempresa";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", idempresa);
            dtEmpresas = SelectData(Command);
            List<Empresas> lstEmpresa = new List<Empresas>();
            for (int i = 0; i < dtEmpresas.Rows.Count; i++)
            {
                Empresas e = new Empresas();
                e.idempresa = int.Parse(dtEmpresas.Rows[i]["idempresa"].ToString());
                e.nombre = dtEmpresas.Rows[i]["nombre"].ToString();
                e.rfc = dtEmpresas.Rows[i]["rfc"].ToString();
                e.registro = dtEmpresas.Rows[i]["registro"].ToString();
                e.digitoverificador = int.Parse(dtEmpresas.Rows[i]["digitoverificador"].ToString());
                e.representante = dtEmpresas.Rows[i]["representante"].ToString();
                e.observacion = dtEmpresas.Rows[i]["observacion"].ToString();
                e.obracivil = bool.Parse(dtEmpresas.Rows[i]["obracivil"].ToString());
                e.idregimenfiscal = int.Parse(dtEmpresas.Rows[i]["idregimenfiscal"].ToString());
                e.codigopostal = dtEmpresas.Rows[i]["codigopostal"].ToString();
                e.archivokey = dtEmpresas.Rows[i]["archivokey"].ToString();
                e.archivocer = dtEmpresas.Rows[i]["archivocer"].ToString();
                e.passwordkey = dtEmpresas.Rows[i]["passwordkey"].ToString();
                e.usuariopac = dtEmpresas.Rows[i]["usuariopac"].ToString();
                e.passwordpac = dtEmpresas.Rows[i]["passwordpac"].ToString();
                e.nocertificado = dtEmpresas.Rows[i]["nocertificado"].ToString();
                lstEmpresa.Add(e);
            }
            return lstEmpresa;
        }
        
        public List<Empresas> InicioEmpresa()
        {
            List<Empresas> lstEmpresa = new List<Empresas>();
            Command.CommandText = "select idempresa, nombre, registro, digitoverificador, observacion from empresas where estatus = 1";
            Command.Parameters.Clear();
            DataTable dtEmpresa = new DataTable();
            dtEmpresa = SelectData(Command);
            for(int i = 0; i < dtEmpresa.Rows.Count; i++)
            {
                Empresas e = new Empresas();
                e.idempresa = int.Parse(dtEmpresa.Rows[i]["idempresa"].ToString());
                e.nombre = dtEmpresa.Rows[i]["nombre"].ToString();
                e.registro = dtEmpresa.Rows[i]["registro"].ToString();
                e.digitoverificador = int.Parse(dtEmpresa.Rows[i]["digitoverificador"].ToString());
                e.observacion = dtEmpresa.Rows[i]["observacion"].ToString();
                lstEmpresa.Add(e);
            }
            return lstEmpresa;
        }

        public object obtenerIdEmpresa(Empresas e)
        {
            Command.CommandText = "select idempresa from empresas where rfc = @rfc and registro = @registro";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("rfc", e.rfc);
            Command.Parameters.AddWithValue("registro", e.registro);
            object id = Select(Command);
            return id;
        }

        public int obtenerIdEmpresa(string nombre)
        {
            Command.CommandText = "select idempresa from empresas where nombre = @nombre";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("nombre", nombre);          
            object id = Select(Command);
            return (int)id;
        }

        public object obtenerRegistroPatronal(Empresas e)
        {
            Command.CommandText = "select registro + convert(char(1),digitoverificador) as registropatronal from dbo.Empresas where idempresa = @idempresa";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", e.idempresa);
            object id = Select(Command);
            return id;
        }

        public bool obtenerObraCivilEmpresa(Empresas e)
        {
            Command.CommandText = "select obracivil from dbo.Empresas where idempresa = @idempresa";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", e.idempresa);
            object dato = Select(Command);
            return (bool)dato;
        }

        public List<Empresas> obtenerDatosCertPac(int idempresa)
        {
            List<Empresas> lst = new List<Empresas>();
            Command.CommandText = "select rfc, archivocer, archivokey, passwordkey, usuariopac, passwordpac from Empresas where idempresa = @idempresa";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", idempresa);
            DataTable dt = new DataTable();
            dt = SelectData(Command);
            Empresas empresa = new Empresas();
            empresa.rfc = dt.Rows[0]["rfc"].ToString();
            empresa.archivocer = dt.Rows[0]["archivocer"].ToString();
            empresa.archivokey = dt.Rows[0]["archivokey"].ToString();
            empresa.passwordkey = dt.Rows[0]["passwordkey"].ToString();
            empresa.usuariopac = dt.Rows[0]["usuariopac"].ToString();
            empresa.passwordpac = dt.Rows[0]["passwordpac"].ToString();
            lst.Add(empresa);
            return lst;
        }

        public int insertaEmpresa(Empresas e)
        {
            Command.CommandText = "insert into empresas (nombre, rfc, registro, digitoverificador, representante, estatus, certificado, nocertificado, observacion, obracivil, idregimenfiscal, codigopostal, archivokey, archivocer, passwordkey, usuariopac, passwordpac) " +
                "values (@nombre, @rfc, @registro, @digitoverificador, @representante, @estatus, @certificado, @nocertificado, @observacion, @obracivil, @idregimenfiscal, @codigopostal, @archivokey, @archivocer, @passwordkey, @usuariopac, @passwordpac)";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("nombre",e.nombre);
            Command.Parameters.AddWithValue("rfc", e.rfc);
            Command.Parameters.AddWithValue("registro", e.registro);
            Command.Parameters.AddWithValue("digitoverificador", e.digitoverificador);
            Command.Parameters.AddWithValue("representante", e.representante);
            Command.Parameters.AddWithValue("estatus", e.estatus);
            Command.Parameters.AddWithValue("certificado", e.certificado);
            Command.Parameters.AddWithValue("nocertificado", e.nocertificado);
            Command.Parameters.AddWithValue("observacion", e.observacion);
            Command.Parameters.AddWithValue("obracivil", e.obracivil);
            Command.Parameters.AddWithValue("idregimenfiscal", e.idregimenfiscal);
            Command.Parameters.AddWithValue("codigopostal", e.codigopostal);
            Command.Parameters.AddWithValue("archivokey", e.archivokey);
            Command.Parameters.AddWithValue("archivocer", e.archivocer);
            Command.Parameters.AddWithValue("passwordkey", e.passwordkey);
            Command.Parameters.AddWithValue("usuariopac", e.usuariopac);
            Command.Parameters.AddWithValue("passwordpac", e.passwordpac);
            return Command.ExecuteNonQuery();
        }

        public int actualizaEmpresa(Empresas e)
        {
            Command.CommandText = @"update empresas set nombre = @nombre, rfc = @rfc, registro = @registro, digitoverificador = @digitoverificador, representante = @representante, 
                estatus = @estatus, certificado = @certificado, nocertificado = @nocertificado, observacion = @observacion, 
                obracivil = @obracivil, idregimenfiscal = @idregimenfiscal, codigopostal = @codigopostal, archivokey = @archivokey, archivocer = @archivocer, passwordkey = @passwordkey,
                usuariopac = @usuariopac, passwordpac = @passwordpac where idempresa = @idempresa";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", e.idempresa);
            Command.Parameters.AddWithValue("nombre", e.nombre);
            Command.Parameters.AddWithValue("rfc", e.rfc);
            Command.Parameters.AddWithValue("registro", e.registro);
            Command.Parameters.AddWithValue("digitoverificador", e.digitoverificador);
            Command.Parameters.AddWithValue("representante", e.representante);
            Command.Parameters.AddWithValue("estatus", e.estatus);
            Command.Parameters.AddWithValue("certificado", e.certificado);
            Command.Parameters.AddWithValue("nocertificado", e.nocertificado);
            Command.Parameters.AddWithValue("observacion", e.observacion);
            Command.Parameters.AddWithValue("obracivil", e.obracivil);
            Command.Parameters.AddWithValue("idregimenfiscal", e.idregimenfiscal);
            Command.Parameters.AddWithValue("codigopostal", e.codigopostal);
            Command.Parameters.AddWithValue("archivokey", e.archivokey);
            Command.Parameters.AddWithValue("archivocer", e.archivocer);
            Command.Parameters.AddWithValue("passwordkey", e.passwordkey);
            Command.Parameters.AddWithValue("usuariopac", e.usuariopac);
            Command.Parameters.AddWithValue("passwordpac", e.passwordpac);
            return Command.ExecuteNonQuery();
        }

        public int bajaEmpresa(Empresas e)
        {
            Command.CommandText = "update empresas set estatus = 0 where idempresa = @idempresa";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", e.idempresa);
            return Command.ExecuteNonQuery();
        }

        public int actualizaCertificado(int idEmpresa, string certificado)
        {
            Command.CommandText = @"update empresas set certificado = @certificado where idempresa = @idempresa";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", idEmpresa);
            Command.Parameters.AddWithValue("certificado", certificado);
            return Command.ExecuteNonQuery();
        }
    }
}

