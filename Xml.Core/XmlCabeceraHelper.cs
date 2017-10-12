using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Xml.Core
{
    public class XmlCabeceraHelper : Data.Obj.DataObj
    {

        public List<XmlCabecera> obtenerXmlPeriodo(int idempresa, DateTime inicio, DateTime fin, int emitido)
        {
            string consulta = "select idtrabajador, emitido, periodoinicio, periodofin, isnull(uuid, ' - ') as uuid, isnull(convert(varchar(10), FechaTimbrado,121), ' - ') as fechatimbrado, folio," +
                              "isnull(error, ' - ') as error from xmlcabecera where idempresa = @idempresa and periodoinicio = @periodoinicio and periodofin = @periodofin and emitido ";
            if (emitido == 0)
                consulta = consulta + "= 'S'";
            if (emitido == 1)
                consulta = consulta + "in ('N','T')";
            if (emitido == 2)
                consulta = consulta + "in ('S','N','T')";
            if (emitido == 3)
                consulta = consulta + "= 'NA'";

            List<XmlCabecera> lst = new List<XmlCabecera>();
            DataTable dt = new DataTable();
            Command.CommandText = consulta;
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", idempresa);
            Command.Parameters.AddWithValue("periodoinicio", inicio);
            Command.Parameters.AddWithValue("periodofin", fin);
            dt = SelectData(Command);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                XmlCabecera xml = new XmlCabecera();
                xml.idtrabajador = int.Parse(dt.Rows[i]["idtrabajador"].ToString());
                xml.emitido = dt.Rows[i]["emitido"].ToString();
                xml.periodoinicio = DateTime.Parse(dt.Rows[i]["periodoinicio"].ToString());
                xml.periodofin = DateTime.Parse(dt.Rows[i]["periodofin"].ToString());
                xml.uuid = dt.Rows[i]["uuid"].ToString();
                xml.fechatimbrado = dt.Rows[i]["fechatimbrado"].ToString();
                xml.folio = int.Parse(dt.Rows[i]["folio"].ToString());
                xml.error = dt.Rows[i]["error"].ToString();
                lst.Add(xml);
            }

            return lst;
        }

        public DataTable obtenerComplementoNomina(int idempresa, int idtrabajador, DateTime inicio, DateTime fin, int periodo)
        {
            Command.CommandText = "exec stp_ReciboXml @idempresa, @idtrabajador, @inicio, @fin, @periodo";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", idempresa);
            Command.Parameters.AddWithValue("idtrabajador", idtrabajador);
            Command.Parameters.AddWithValue("inicio", inicio);
            Command.Parameters.AddWithValue("fin", fin);
            Command.Parameters.AddWithValue("periodo", periodo);
            DataTable dt = new DataTable();
            dt = SelectData(Command);
            return dt;
        }

        public DataTable obtenerCatalogoNomina(int idtrabajador)
        {
            Command.CommandText = "exec stp_ReciboXmlCatalogos @idtrabajador";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idtrabajador", idtrabajador);
            DataTable dt = new DataTable();
            dt = SelectData(Command);
            return dt;
        }

        public List<XmlCabecera> obtenerPeriodosSinTimbrar(int idempresa, int tiponomina, int periodo)
        {
            Command.CommandText = @"select distinct cast(periodoinicio as varchar(10)) + '/' + cast(periodofin as varchar(10)) as xml 
                                    from xmlCabecera where idempresa = @idempresa and tiponomina = @tiponomina and emitido in ('T','N') and periodo = @periodo";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", idempresa);
            Command.Parameters.AddWithValue("tiponomina", tiponomina);
            Command.Parameters.AddWithValue("periodo", periodo);
            DataTable dt = new DataTable();
            List<XmlCabecera> lstXml = new List<XmlCabecera>();
            dt = SelectData(Command);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                XmlCabecera x = new XmlCabecera();
                x.xml = dt.Rows[i]["xml"].ToString();
                lstXml.Add(x);
            }
            return lstXml;
        }

        public List<XmlCabecera> obtenerPeriodosTimbrados(int idempresa, int tiponomina, int periodo)
        {
            Command.CommandText = @"select distinct cast(periodoinicio as varchar(10)) + '/' + cast(periodofin as varchar(10)) as xml 
                                    from xmlCabecera where idempresa = @idempresa and tiponomina = @tiponomina and emitido = 'S' and periodo = @periodo";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", idempresa);
            Command.Parameters.AddWithValue("tiponomina", tiponomina);
            Command.Parameters.AddWithValue("periodo", periodo);
            DataTable dt = new DataTable();
            List<XmlCabecera> lstXml = new List<XmlCabecera>();
            dt = SelectData(Command);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                XmlCabecera x = new XmlCabecera();
                x.xml = dt.Rows[i]["xml"].ToString();
                lstXml.Add(x);
            }
            return lstXml;
        }

        public List<CodigoBidimensional> obtenerDatosCodigoQr(int idempresa, int tiponomina, DateTime inicio, DateTime fin)
        {
            Command.CommandText = "exec stp_GenerarCodigoQr @idempresa, @tiponomina, @inicio, @fin";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", idempresa);
            Command.Parameters.AddWithValue("tiponomina", tiponomina);
            Command.Parameters.AddWithValue("inicio", inicio);
            Command.Parameters.AddWithValue("fin", fin);
            List<CodigoBidimensional> lstQR = new List<CodigoBidimensional>();
            DataTable dt = new DataTable();
            dt = SelectData(Command);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CodigoBidimensional qr = new CodigoBidimensional();
                qr.folio = int.Parse(dt.Rows[i]["folio"].ToString());
                qr.idtrabajador = int.Parse(dt.Rows[i]["idtrabajador"].ToString());
                qr.re = dt.Rows[i]["re"].ToString();
                qr.rr = dt.Rows[i]["rr"].ToString();
                qr.tt = decimal.Parse(dt.Rows[i]["tt"].ToString());
                qr.uuid = dt.Rows[i]["uuid"].ToString();
                lstQR.Add(qr);
            }
            return lstQR;
        }

        public List<XmlCancelados> obtenerCancelados(int idempresa, DateTime inicio, DateTime fin)
        {
            Command.CommandText = "select uuid, fecha, respuesta, acuse, folio from xmlcancelados where idempresa = @idempresa and fecha >= @inicio and fecha <= @fin";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", idempresa);
            Command.Parameters.AddWithValue("inicio", inicio);
            Command.Parameters.AddWithValue("fin", fin);

            List<XmlCancelados> lstCancelados = new List<XmlCancelados>();
            DataTable dt = new DataTable();
            dt = SelectData(Command);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                XmlCancelados c = new XmlCancelados();
                c.uuid = dt.Rows[i]["uuid"].ToString();
                c.fecha = DateTime.Parse(dt.Rows[i]["fecha"].ToString());
                c.respuesta = dt.Rows[i]["respuesta"].ToString();
                c.acuse = dt.Rows[i]["acuse"].ToString();
                c.folio = int.Parse(dt.Rows[i]["folio"].ToString());
                lstCancelados.Add(c);
            }
            return lstCancelados;
        }

        public List<XmlCancelados> obtenerCancelados(string folioFiscal)
        {
            Command.CommandText = "select uuid, fecha, respuesta, acuse, folio from xmlcancelados where uuid = @uuid";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("uuid", folioFiscal);

            List<XmlCancelados> lstCancelados = new List<XmlCancelados>();
            DataTable dt = new DataTable();
            dt = SelectData(Command);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                XmlCancelados c = new XmlCancelados();
                c.uuid = dt.Rows[i]["uuid"].ToString();
                c.fecha = DateTime.Parse(dt.Rows[i]["fecha"].ToString());
                c.respuesta = dt.Rows[i]["respuesta"].ToString();
                c.acuse = dt.Rows[i]["acuse"].ToString();
                c.folio = int.Parse(dt.Rows[i]["folio"].ToString());
                lstCancelados.Add(c);
            }
            return lstCancelados;
        }

        public string obtenerXml(int folio)
        {
            Command.CommandText = "select xml from xmlcabecera where folio = @folio";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("folio", folio);
            string dato = Select(Command).ToString();
            return dato;
        }

        public string obtenerAcuse(string uuid)
        {
            Command.CommandText = "select acuse from xmlcancelados where uuid = @uuid";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("uuid", uuid);
            string dato = Select(Command).ToString();
            return dato;
        }

        public int actualizaXmlCabecera(XmlCabecera xc)
        {
            Command.CommandText = @"update xmlcabecera set emitido = @emitido, nocertificado = @nocertificado, versiontimbrefiscal = @versiontimbrefiscal, uuid = @uuid,
                                    fechatimbrado = @fechatimbrado, sellocfd = @sellocfd, nocertificadosat = @nocertificadosat, sellosat = @sellosat, xml = @xml, codeqr = @qr, error = @error
                                    where folio = @folio";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("emitido", xc.emitido);
            Command.Parameters.AddWithValue("nocertificado", xc.nocertificado);
            Command.Parameters.AddWithValue("versiontimbrefiscal", xc.versiontimbrefiscal);
            Command.Parameters.AddWithValue("uuid", xc.uuid);
            Command.Parameters.AddWithValue("fechatimbrado", xc.fechatimbrado);
            Command.Parameters.AddWithValue("sellocfd", xc.sellocfd);
            Command.Parameters.AddWithValue("nocertificadosat", xc.nocertificadosat);
            Command.Parameters.AddWithValue("sellosat", xc.sellosat);
            Command.Parameters.AddWithValue("xml", xc.xml);
            Command.Parameters.AddWithValue("folio", xc.folio);
            Command.Parameters.AddWithValue("qr", xc.codeqr);
            Command.Parameters.AddWithValue("error", xc.error);

            return Command.ExecuteNonQuery();
        }

        public int actualizaXmlCabeceraError(XmlCabecera xc)
        {
            Command.CommandText = @"update xmlcabecera set error = @error where folio = @folio";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("error", xc.error);
            Command.Parameters.AddWithValue("folio", xc.folio);

            return Command.ExecuteNonQuery();
        }

        public int actualizaXmlCabeceraCancelado(int folio)
        {
            Command.CommandText = @"update xmlcabecera set emitido = 'N', uuid = null, fechatimbrado = null, sellocfd = null, nocertificadosat = null, sellosat = null, xml = null, codeqr = null where folio = @folio";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("folio", folio);

            return Command.ExecuteNonQuery();
        }

        public int actualizaXmlCodeQr(XmlCabecera xc)
        {
            Command.CommandText = @"update xmlcabecera set codeqr = @qr where folio = @folio";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("qr", xc.codeqr);
            Command.Parameters.AddWithValue("folio", xc.folio);

            return Command.ExecuteNonQuery();
        }

        public int insertaCfdiMaster(int idempresa, int idtrabajador, DateTime inicio, DateTime fin)
        {
            Command.CommandText = @"exec stp_CfdiMaster @idempresa, @idtrabajador, @inicio, @fin";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", idempresa);
            Command.Parameters.AddWithValue("idtrabajador", idtrabajador);
            Command.Parameters.AddWithValue("inicio", inicio);
            Command.Parameters.AddWithValue("fin", fin);
            return Command.ExecuteNonQuery();
        }

        public int insertaCfdiMaster(int idempresa, DateTime inicio, DateTime fin, int periodo, int tiponomina)
        {
            Command.CommandText = @"exec stp_GenerarRecibosCabecera @idempresa, @inicio, @fin, @periodo, @tiponomina";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", idempresa);
            Command.Parameters.AddWithValue("inicio", inicio);
            Command.Parameters.AddWithValue("fin", fin);
            Command.Parameters.AddWithValue("periodo", periodo);
            Command.Parameters.AddWithValue("tiponomina", tiponomina);
            return Command.ExecuteNonQuery();
        }

        public int insertaCfdiDetalle(int idempresa, int idtrabajador, DateTime inicio, DateTime fin)
        {
            Command.CommandText = @"exec stp_CfdiDetalle @idempresa, @idtrabajador, @inicio, @fin";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", idempresa);
            Command.Parameters.AddWithValue("idtrabajador", idtrabajador);
            Command.Parameters.AddWithValue("inicio", inicio);
            Command.Parameters.AddWithValue("fin", fin);
            return Command.ExecuteNonQuery();
        }

        public int insertaCfdiDetalle(int idempresa, DateTime inicio, DateTime fin, int periodo, int tiponomina)
        {
            Command.CommandText = @"exec stp_GenerarRecibosDetalle @idempresa, @inicio, @fin, @periodo, @tiponomina";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", idempresa);
            Command.Parameters.AddWithValue("inicio", inicio);
            Command.Parameters.AddWithValue("fin", fin);
            Command.Parameters.AddWithValue("periodo", periodo);
            Command.Parameters.AddWithValue("tiponomina", tiponomina);
            return Command.ExecuteNonQuery();
        }

        public int insertaCancelado(XmlCancelados xc)
        {
            Command.CommandText = @"insert into xmlcancelados (folio, idempresa, uuid, fecha, respuesta, acuse, xml) values (@folio, @idempresa, @uuid, @fecha, @respuesta, @acuse, @xml)";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("folio", xc.folio);
            Command.Parameters.AddWithValue("idempresa", xc.idempresa);
            Command.Parameters.AddWithValue("uuid", xc.uuid);
            Command.Parameters.AddWithValue("fecha", xc.fecha);
            Command.Parameters.AddWithValue("respuesta", xc.respuesta);
            Command.Parameters.AddWithValue("acuse", xc.acuse);
            Command.Parameters.AddWithValue("xml", xc.xml);
            return Command.ExecuteNonQuery();
        }

        public int eliminaCfdiMaster(int idtrabajador, DateTime inicio, DateTime fin, int tiponomina)
        {
            Command.CommandText = @"delete from CfdiMaster where idtrabajador = @idtrabajador and periodoinicio = @inicio and periodofin = @fin and tiponomina = @tiponomina";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idtrabajador", idtrabajador);
            Command.Parameters.AddWithValue("inicio", inicio);
            Command.Parameters.AddWithValue("fin", fin);
            Command.Parameters.AddWithValue("tiponomina", tiponomina);
            return Command.ExecuteNonQuery();
        }

        public int eliminaCfdiMaster(int idempresa, DateTime inicio, DateTime fin, int tiponomina, int periodo)
        {
            Command.CommandText = @"delete from cfdiMaster where idempresa = @idempresa and periodoinicio = @periodoinicio and periodofin = @periodofin
                                    and tiponomina = @tiponomina and periodo = @periodo";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("periodoinicio", inicio);
            Command.Parameters.AddWithValue("periodofin", fin);
            Command.Parameters.AddWithValue("idempresa", idempresa);
            Command.Parameters.AddWithValue("tiponomina", tiponomina);
            Command.Parameters.AddWithValue("periodo", periodo);
            return Command.ExecuteNonQuery();
        }


        /// <summary>
        /// METODO TEMPORAL
        /// </summary>
        /// <param name="idempresa"></param>
        /// <param name="inicio"></param>
        /// <param name="fin"></param>
        /// <returns></returns>
        public List<XmlCabecera> obtenerXml(int idempresa, DateTime inicio, DateTime fin)
        {
            string consulta = "select idtrabajador, xml from xmlcabecera where idempresa = @idempresa and periodoinicio >= @inicio and periodoinicio < @fin and emitido = 'S'";
            List<XmlCabecera> lst = new List<XmlCabecera>();
            DataTable dt = new DataTable();
            Command.CommandText = consulta;
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("idempresa", idempresa);
            Command.Parameters.AddWithValue("inicio", inicio);
            Command.Parameters.AddWithValue("fin", fin);
            dt = SelectData(Command);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                XmlCabecera xml = new XmlCabecera();
                xml.idtrabajador = int.Parse(dt.Rows[i]["idtrabajador"].ToString());
                xml.xml = dt.Rows[i]["xml"].ToString();
                lst.Add(xml);
            }

            return lst;
        }

    }
}
